using System;
using System.Collections.Generic;

namespace WorkersScheduler
{
    class Chromosome
    {
        private int _rows, _cols;
        private int[,] _genes;

        public Chromosome(int rows, int cols)
        {
            _rows = rows;
            _cols = cols;
            _genes = new int[_rows, _cols];
        }

        public int[,] GetGenesMatrix()
        {
            return _genes;
        }

        public void SetGensColumn(int j, int[] column)
        {
            if (j <= _cols && column.GetLength(0) == _rows)
            {
                for (int i = 0; i < _rows; i++)
                {
                    _genes[i, j] = column[i];
                }
            } else
            {
                // TODO
            }
        }

        public void SetGensMatrix(int[,] matrix)
        {
            if (matrix.GetLength(0) == _rows && matrix.GetLength(1) == _cols)
            {
                for (int i = 0; i < _rows; i++)
                {
                    for (int j = 0; j < _cols; j++)
                    {
                        _genes[i, j] = matrix[i, j];
                    }
                }
            } else
            {
                // TODO
            }
        }

        public int this[int i, int j]
        {
            get
            {
                return _genes[i, j];
            }

            set
            {
                _genes[i, j] = value;
            }
        }
    }

    class ScheduleChromosome : Chromosome
    {
        private int _workers_num, _days_num, _workers_per_day;
        private int _schedule_penalty;

        public ScheduleChromosome(int workers_num, int days_num, int workers_per_day) : base(workers_num, days_num)
        {
            _workers_num = workers_num;
            _days_num = days_num;
            _workers_per_day = workers_per_day;
        }

        public void BuildRandomSchedule(Random random_seed)
        {
            SetGensMatrix(GenRandomSchedule(random_seed));
        }

        public int[,] GenRandomSchedule(Random random_seed)
        {
            int[,] random_schedule_matrix = new int[_workers_num, _days_num];
            for (int j = 0; j < _days_num; j++)
            {
                int[] column = GenRandomScheduleColumn(random_seed);
                for (int i = 0; i < _workers_num; i++)
                {
                    random_schedule_matrix[i, j] = column[i];
                }
            }
            return random_schedule_matrix;
        }

        public int[] GenRandomScheduleColumn(Random random_seed)
        {
            List<int> random_workers_combination = new List<int>();
            int new_random_worker_number = random_seed.Next(Convert.ToInt32(_workers_num));
            random_workers_combination.Add(new_random_worker_number);
            while (random_workers_combination.Count < _workers_per_day)
            {
                bool new_worker_found = false;
                while (!new_worker_found)
                {
                    new_random_worker_number = random_seed.Next(Convert.ToInt32(_workers_num));
                    bool worker_already_in_combination = false;
                    random_workers_combination.ForEach(delegate (int worker_number)
                    {
                        if (worker_number == new_random_worker_number)
                        {
                            worker_already_in_combination = true;
                        }
                    });
                    if (!worker_already_in_combination)
                    {
                        random_workers_combination.Add(new_random_worker_number);
                        new_worker_found = true;
                    }
                }
            }

            int[] random_schedule_column = new int[_workers_num];
            random_workers_combination.ForEach(delegate (int worker_number)
            {
                random_schedule_column[worker_number] = 1;
            });
            return random_schedule_column;
        }

        public int CalculateWorkersPenalty(int[,] penalty_matrix)
        {
            int curr_penalty = 0;
            for (int i = 0; i < _workers_num; i++)
            {
                for (int j = 0; j < _days_num; j++)
                {
                    curr_penalty += this[i, j] * penalty_matrix[i, j];
                }
            }
            return curr_penalty;
        }

        public int CountWorkerOverworkDays(int worker_number, int max_working_days)
        {
            int working_days = 0, overwork_days = 0;
            for (int j = 0; j < _days_num; j++)
            {
                working_days += this[worker_number, j] * 1;
                if (working_days >= max_working_days)
                {
                    overwork_days += this[worker_number, j] * 1;
                }
            }
            return overwork_days;
        }

        public int CalculateDutchLawPenalty(int max_working_days, int overwork_penalty)
        {
            int total_penalty = 0;
            for (int i = 0; i < _workers_num; i++)
            {
                int overwork_days = CountWorkerOverworkDays(i, max_working_days);
                total_penalty += overwork_days * overwork_penalty;
            }
            return total_penalty;
        }

        public int GetPenalty()
        {
            return _schedule_penalty;
        }

        public void SetPenalty(int penalty)
        {
            _schedule_penalty = penalty;
        }
    }

    class GeneticAlgorithm
    {
        private int _population_size, _generations_number, _overwork_penalty, _mutation_probability;
        private int _workers_num, _days_num, _workers_per_day, _max_working_days;
        private int[,] _penalty_matrix;
        private static Random random_seed = new Random();

        public GeneticAlgorithm(int population_size, int generations_number, int overwork_penalty, int mutation_probability)
        {
            _population_size = population_size;
            _generations_number = generations_number;
            _overwork_penalty = overwork_penalty;
            _mutation_probability = mutation_probability;
        }

        public void SetScheduleSettings(int workers_num, int days_num, int workers_per_day, int max_working_days, int[,] penalty_matrix)
        {
            _workers_num = workers_num;
            _days_num = days_num;
            _workers_per_day = workers_per_day;
            _max_working_days = max_working_days;
            _penalty_matrix = penalty_matrix;
        }

        public int[,] BuildSchedule()
        {
            // Generate initial population
            ScheduleChromosome[] parent_population = new ScheduleChromosome[_population_size];
            for (int i = 0; i < _population_size; i++)
            {
                parent_population[i] = new ScheduleChromosome(_workers_num, _days_num, _workers_per_day);
                parent_population[i].BuildRandomSchedule(random_seed);
                int workers_penalty = parent_population[i].CalculateWorkersPenalty(_penalty_matrix);
                int dutch_law_penalty = parent_population[i].CalculateDutchLawPenalty(_max_working_days, _overwork_penalty);
                parent_population[i].SetPenalty(workers_penalty + dutch_law_penalty);
            }

            // Init childrens population
            ScheduleChromosome[] children_population = new ScheduleChromosome[_population_size];
            for (int i = 0; i < _population_size; i++)
            {
                children_population[i] = new ScheduleChromosome(_workers_num, _days_num, _workers_per_day);
            }

            // Start genetic algorithm cycle
            for (int i = 0; i < _generations_number; i++)
            {
                // Create children population
                for (int j = 0; j < _population_size; j++)
                {
                    ScheduleChromosome first_parent = SelectParent(parent_population);
                    ScheduleChromosome second_parent = SelectParent(parent_population);
                    children_population[j] = CrossParents(first_parent, second_parent);
                    MutateChromosome(children_population[j], _mutation_probability);

                    int workers_penalty = children_population[j].CalculateWorkersPenalty(_penalty_matrix);
                    int dutch_law_penalty = children_population[j].CalculateDutchLawPenalty(_max_working_days, _overwork_penalty);
                    children_population[j].SetPenalty(workers_penalty + dutch_law_penalty);
                }

                // Saving children population
                for (int j = 0; j < _population_size; j++)
                {
                    parent_population[j] = children_population[j];
                }
            }

            int lowest_penalty = 1090347500;
            ScheduleChromosome best = new ScheduleChromosome(_workers_num, _days_num, _workers_per_day);
            for (int i = 0; i < _population_size; i++)
            {
                if (parent_population[i].GetPenalty() < lowest_penalty)
                {
                    best = parent_population[i];
                }
            }

            return best.GetGenesMatrix();
        }

        public ScheduleChromosome SelectParent(ScheduleChromosome[] parent_population)
        {
            int biggest_penalty = 0;
            for (int i = 0; i < parent_population.Length; i++)
            {
                if (parent_population[i].GetPenalty() > biggest_penalty)
                {
                    biggest_penalty = parent_population[i].GetPenalty();
                }
            }

            int[] fitness = new int[parent_population.Length];
            double fitness_sum = 0;
            for (int i = 0; i < parent_population.Length; i++)
            {
                fitness[i] = biggest_penalty - parent_population[i].GetPenalty();
                fitness_sum += fitness[i];
            }

            double[] probability = new double[parent_population.Length];
            for (int i = 0; i < parent_population.Length; i++)
            {
                probability[i] = fitness[i] / fitness_sum;
            }

            double[] cumulative_probability = new double[parent_population.Length];
            cumulative_probability[0] = probability[0];
            for (int i = 1; i < parent_population.Length; i++)
            {
                cumulative_probability[i] = cumulative_probability[i - 1] + probability[i];
            }

            double rand_num = (double)(random_seed.Next(1, 101)) / (double)100;

            int result_index = 0;
            for (int i = 0; i < parent_population.Length; i++)
            {
                if (rand_num <= cumulative_probability[i])
                {
                    result_index = i;
                    break;
                }
            }

            return parent_population[result_index];
        }

        ScheduleChromosome CrossParents(ScheduleChromosome first_parent_chromosome, ScheduleChromosome second_parent_chromosome)
        {
            int[,] result_matrix = new int[_workers_num, _days_num];
            for (int i = 0; i < _days_num; i++)
            {
                double max_column_penalty = 0;
                int first_parent_column_penalty = 0;
                int second_parent_column_penalty = 0;
                for (int j = 0; j < _workers_num; j++)
                {
                    first_parent_column_penalty += first_parent_chromosome[j, i] * _penalty_matrix[j, i];
                    second_parent_column_penalty += second_parent_chromosome[j, i] * _penalty_matrix[j, i];
                    max_column_penalty += _penalty_matrix[j, i];
                }
                max_column_penalty += max_column_penalty / 20;
                double first_parent_probability = (max_column_penalty - first_parent_column_penalty) / max_column_penalty;
                double rand_num = (double)(random_seed.Next(1, 101)) / (double)100;

                if (rand_num <= first_parent_probability)
                {
                    for (int j = 0; j < _workers_num; j++)
                    {
                        result_matrix[j, i] = first_parent_chromosome[j, i];
                    }
                }
                else
                {
                    for (int j = 0; j < _workers_num; j++)
                    {
                        result_matrix[j, i] = second_parent_chromosome[j, i];
                    }
                }
            }

            ScheduleChromosome result = new ScheduleChromosome(_workers_num, _days_num, _workers_per_day);
            result.SetGensMatrix(result_matrix);
            return result;
        }

        void MutateChromosome(ScheduleChromosome chromosome, int mutation_probability)
        {
            for (int i = 0; i < _days_num; i++)
            {
                int mutation_starter = random_seed.Next(1, 101);
                if (mutation_starter < mutation_probability)
                {
                    chromosome.SetGensColumn(i, chromosome.GenRandomScheduleColumn(random_seed));
                }
            }
        }
    }
}
