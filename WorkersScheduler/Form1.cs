using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace WorkersScheduler
{
    public partial class f_main_form : Form
    {
        const int days_number = 14;
        const int workers_number = 5;
        const int workers_per_day = 3;
        const int max_working_days = 9;
        const int population_size = 100;
        const int generations_number = 100;
        const int overwork_penalty = 50;
        const int mutation_probability = 10;
        Dictionary<int, Color> color_by_penalty = new Dictionary<int, Color> { { 0, Color.White }, { 5, Color.Silver }, { 10, Color.Gray } };
        Dictionary<Color, int> penalty_by_color = new Dictionary<Color, int> { { Color.White, 0 }, { Color.Silver, 5 }, { Color.Gray, 10 } };
        Dictionary<int, Color> color_by_schedule_flag = new Dictionary<int, Color> { { 0, Color.White }, { 1, Color.LightGreen } };
        Dictionary<Color, int> schedule_flag_by_color = new Dictionary<Color, int> { { Color.White, 0 }, { Color.LightGreen, 1 } };

        GeneticAlgorithm scheduler;

        public f_main_form()
        {
            InitializeComponent();
            scheduler = new GeneticAlgorithm(population_size, generations_number, overwork_penalty, mutation_probability);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Color GetNextRestrictionColor(Color _color)
        {
            for (int i = 0; i < penalty_by_color.Count - 1; i++)
            {
                if (penalty_by_color.Keys.ElementAt(i) == _color)
                {
                    return penalty_by_color.Keys.ElementAt(++i);
                }
            }
            return penalty_by_color.Keys.ElementAt(0);
        }

        private Color GetNextScheduleColor(Color _color)
        {
            for (int i = 0; i < schedule_flag_by_color.Count - 1; i++)
            {
                if (schedule_flag_by_color.Keys.ElementAt(i) == _color)
                {
                    return schedule_flag_by_color.Keys.ElementAt(++i);
                }
            }
            return schedule_flag_by_color.Keys.ElementAt(0);
        }

        private void pb_restrictions_1_1_Click(object sender, EventArgs e)
        {
            pb_restrictions_1_1.BackColor = GetNextRestrictionColor(pb_restrictions_1_1.BackColor);
        }

        private void pb_restrictions_1_2_Click(object sender, EventArgs e)
        {
            pb_restrictions_1_2.BackColor = GetNextRestrictionColor(pb_restrictions_1_2.BackColor);
        }

        private void pb_restrictions_1_3_Click(object sender, EventArgs e)
        {
            pb_restrictions_1_3.BackColor = GetNextRestrictionColor(pb_restrictions_1_3.BackColor);
        }

        private void pb_restrictions_1_4_Click(object sender, EventArgs e)
        {
            pb_restrictions_1_4.BackColor = GetNextRestrictionColor(pb_restrictions_1_4.BackColor);
        }

        private void pb_restrictions_1_5_Click(object sender, EventArgs e)
        {
            pb_restrictions_1_5.BackColor = GetNextRestrictionColor(pb_restrictions_1_5.BackColor);
        }

        private void pb_restrictions_1_6_Click(object sender, EventArgs e)
        {
            pb_restrictions_1_6.BackColor = GetNextRestrictionColor(pb_restrictions_1_6.BackColor);
        }

        private void pb_restrictions_1_7_Click(object sender, EventArgs e)
        {
            pb_restrictions_1_7.BackColor = GetNextRestrictionColor(pb_restrictions_1_7.BackColor);
        }

        private void pb_restrictions_1_8_Click(object sender, EventArgs e)
        {
            pb_restrictions_1_8.BackColor = GetNextRestrictionColor(pb_restrictions_1_8.BackColor);
        }

        private void pb_restrictions_1_9_Click(object sender, EventArgs e)
        {
            pb_restrictions_1_9.BackColor = GetNextRestrictionColor(pb_restrictions_1_9.BackColor);
        }

        private void pb_restrictions_1_10_Click(object sender, EventArgs e)
        {
            pb_restrictions_1_10.BackColor = GetNextRestrictionColor(pb_restrictions_1_10.BackColor);
        }

        private void pb_restrictions_1_11_Click(object sender, EventArgs e)
        {
            pb_restrictions_1_11.BackColor = GetNextRestrictionColor(pb_restrictions_1_11.BackColor);
        }

        private void pb_restrictions_1_12_Click(object sender, EventArgs e)
        {
            pb_restrictions_1_12.BackColor = GetNextRestrictionColor(pb_restrictions_1_12.BackColor);
        }

        private void pb_restrictions_1_13_Click(object sender, EventArgs e)
        {
            pb_restrictions_1_13.BackColor = GetNextRestrictionColor(pb_restrictions_1_13.BackColor);
        }

        private void pb_restrictions_1_14_Click(object sender, EventArgs e)
        {
            pb_restrictions_1_14.BackColor = GetNextRestrictionColor(pb_restrictions_1_14.BackColor);
        }

        private void pb_restrictions_2_1_Click(object sender, EventArgs e)
        {
            pb_restrictions_2_1.BackColor = GetNextRestrictionColor(pb_restrictions_2_1.BackColor);
        }

        private void pb_restrictions_2_2_Click(object sender, EventArgs e)
        {
            pb_restrictions_2_2.BackColor = GetNextRestrictionColor(pb_restrictions_2_2.BackColor);
        }

        private void pb_restrictions_2_3_Click(object sender, EventArgs e)
        {
            pb_restrictions_2_3.BackColor = GetNextRestrictionColor(pb_restrictions_2_3.BackColor);
        }

        private void pb_restrictions_2_4_Click(object sender, EventArgs e)
        {
            pb_restrictions_2_4.BackColor = GetNextRestrictionColor(pb_restrictions_2_4.BackColor);
        }

        private void pb_restrictions_2_5_Click(object sender, EventArgs e)
        {
            pb_restrictions_2_5.BackColor = GetNextRestrictionColor(pb_restrictions_2_5.BackColor);
        }

        private void pb_restrictions_2_6_Click(object sender, EventArgs e)
        {
            pb_restrictions_2_6.BackColor = GetNextRestrictionColor(pb_restrictions_2_6.BackColor);
        }

        private void pb_restrictions_2_7_Click(object sender, EventArgs e)
        {
            pb_restrictions_2_7.BackColor = GetNextRestrictionColor(pb_restrictions_2_7.BackColor);
        }

        private void pb_restrictions_2_8_Click(object sender, EventArgs e)
        {
            pb_restrictions_2_8.BackColor = GetNextRestrictionColor(pb_restrictions_2_8.BackColor);
        }

        private void pb_restrictions_2_9_Click(object sender, EventArgs e)
        {
            pb_restrictions_2_9.BackColor = GetNextRestrictionColor(pb_restrictions_2_9.BackColor);
        }

        private void pb_restrictions_2_10_Click(object sender, EventArgs e)
        {
            pb_restrictions_2_10.BackColor = GetNextRestrictionColor(pb_restrictions_2_10.BackColor);
        }

        private void pb_restrictions_2_11_Click(object sender, EventArgs e)
        {
            pb_restrictions_2_11.BackColor = GetNextRestrictionColor(pb_restrictions_2_11.BackColor);
        }

        private void pb_restrictions_2_12_Click(object sender, EventArgs e)
        {
            pb_restrictions_2_12.BackColor = GetNextRestrictionColor(pb_restrictions_2_12.BackColor);
        }

        private void pb_restrictions_2_13_Click(object sender, EventArgs e)
        {
            pb_restrictions_2_13.BackColor = GetNextRestrictionColor(pb_restrictions_2_13.BackColor);
        }

        private void pb_restrictions_2_14_Click(object sender, EventArgs e)
        {
            pb_restrictions_2_14.BackColor = GetNextRestrictionColor(pb_restrictions_2_14.BackColor);
        }

        private void pb_restrictions_3_1_Click(object sender, EventArgs e)
        {
            pb_restrictions_3_1.BackColor = GetNextRestrictionColor(pb_restrictions_3_1.BackColor);
        }

        private void pb_restrictions_3_2_Click(object sender, EventArgs e)
        {
            pb_restrictions_3_2.BackColor = GetNextRestrictionColor(pb_restrictions_3_2.BackColor);
        }

        private void pb_restrictions_3_3_Click(object sender, EventArgs e)
        {
            pb_restrictions_3_3.BackColor = GetNextRestrictionColor(pb_restrictions_3_3.BackColor);
        }

        private void pb_restrictions_3_4_Click(object sender, EventArgs e)
        {
            pb_restrictions_3_4.BackColor = GetNextRestrictionColor(pb_restrictions_3_4.BackColor);
        }

        private void pb_restrictions_3_5_Click(object sender, EventArgs e)
        {
            pb_restrictions_3_5.BackColor = GetNextRestrictionColor(pb_restrictions_3_5.BackColor);
        }

        private void pb_restrictions_3_6_Click(object sender, EventArgs e)
        {
            pb_restrictions_3_6.BackColor = GetNextRestrictionColor(pb_restrictions_3_6.BackColor);
        }

        private void pb_restrictions_3_7_Click(object sender, EventArgs e)
        {
            pb_restrictions_3_7.BackColor = GetNextRestrictionColor(pb_restrictions_3_7.BackColor);
        }

        private void pb_restrictions_3_8_Click(object sender, EventArgs e)
        {
            pb_restrictions_3_8.BackColor = GetNextRestrictionColor(pb_restrictions_3_8.BackColor);
        }

        private void pb_restrictions_3_9_Click(object sender, EventArgs e)
        {
            pb_restrictions_3_9.BackColor = GetNextRestrictionColor(pb_restrictions_3_9.BackColor);
        }

        private void pb_restrictions_3_10_Click(object sender, EventArgs e)
        {
            pb_restrictions_3_10.BackColor = GetNextRestrictionColor(pb_restrictions_3_10.BackColor);
        }

        private void pb_restrictions_3_11_Click(object sender, EventArgs e)
        {
            pb_restrictions_3_11.BackColor = GetNextRestrictionColor(pb_restrictions_3_11.BackColor);
        }

        private void pb_restrictions_3_12_Click(object sender, EventArgs e)
        {
            pb_restrictions_3_12.BackColor = GetNextRestrictionColor(pb_restrictions_3_12.BackColor);
        }

        private void pb_restrictions_3_13_Click(object sender, EventArgs e)
        {
            pb_restrictions_3_13.BackColor = GetNextRestrictionColor(pb_restrictions_3_13.BackColor);
        }

        private void pb_restrictions_3_14_Click(object sender, EventArgs e)
        {
            pb_restrictions_3_14.BackColor = GetNextRestrictionColor(pb_restrictions_3_14.BackColor);
        }

        private void pb_restrictions_4_1_Click(object sender, EventArgs e)
        {
            pb_restrictions_4_1.BackColor = GetNextRestrictionColor(pb_restrictions_4_1.BackColor);
        }

        private void pb_restrictions_4_2_Click(object sender, EventArgs e)
        {
            pb_restrictions_4_2.BackColor = GetNextRestrictionColor(pb_restrictions_4_2.BackColor);
        }

        private void pb_restrictions_4_3_Click(object sender, EventArgs e)
        {
            pb_restrictions_4_3.BackColor = GetNextRestrictionColor(pb_restrictions_4_3.BackColor);
        }

        private void pb_restrictions_4_4_Click(object sender, EventArgs e)
        {
            pb_restrictions_4_4.BackColor = GetNextRestrictionColor(pb_restrictions_4_4.BackColor);
        }

        private void pb_restrictions_4_5_Click(object sender, EventArgs e)
        {
            pb_restrictions_4_5.BackColor = GetNextRestrictionColor(pb_restrictions_4_5.BackColor);
        }

        private void pb_restrictions_4_6_Click(object sender, EventArgs e)
        {
            pb_restrictions_4_6.BackColor = GetNextRestrictionColor(pb_restrictions_4_6.BackColor);
        }

        private void pb_restrictions_4_7_Click(object sender, EventArgs e)
        {
            pb_restrictions_4_7.BackColor = GetNextRestrictionColor(pb_restrictions_4_7.BackColor);
        }

        private void pb_restrictions_4_8_Click(object sender, EventArgs e)
        {
            pb_restrictions_4_8.BackColor = GetNextRestrictionColor(pb_restrictions_4_8.BackColor);
        }

        private void pb_restrictions_4_9_Click(object sender, EventArgs e)
        {
            pb_restrictions_4_9.BackColor = GetNextRestrictionColor(pb_restrictions_4_9.BackColor);
        }

        private void pb_restrictions_4_10_Click(object sender, EventArgs e)
        {
            pb_restrictions_4_10.BackColor = GetNextRestrictionColor(pb_restrictions_4_10.BackColor);
        }

        private void pb_restrictions_4_11_Click(object sender, EventArgs e)
        {
            pb_restrictions_4_11.BackColor = GetNextRestrictionColor(pb_restrictions_4_11.BackColor);
        }

        private void pb_restrictions_4_12_Click(object sender, EventArgs e)
        {
            pb_restrictions_4_12.BackColor = GetNextRestrictionColor(pb_restrictions_4_12.BackColor);
        }

        private void pb_restrictions_4_13_Click(object sender, EventArgs e)
        {
            pb_restrictions_4_13.BackColor = GetNextRestrictionColor(pb_restrictions_4_13.BackColor);
        }

        private void pb_restrictions_4_14_Click(object sender, EventArgs e)
        {
            pb_restrictions_4_14.BackColor = GetNextRestrictionColor(pb_restrictions_4_14.BackColor);
        }

        private void pb_restrictions_5_1_Click(object sender, EventArgs e)
        {
            pb_restrictions_5_1.BackColor = GetNextRestrictionColor(pb_restrictions_5_1.BackColor);
        }

        private void pb_restrictions_5_2_Click(object sender, EventArgs e)
        {
            pb_restrictions_5_2.BackColor = GetNextRestrictionColor(pb_restrictions_5_2.BackColor);
        }

        private void pb_restrictions_5_3_Click(object sender, EventArgs e)
        {
            pb_restrictions_5_3.BackColor = GetNextRestrictionColor(pb_restrictions_5_3.BackColor);
        }

        private void pb_restrictions_5_4_Click(object sender, EventArgs e)
        {
            pb_restrictions_5_4.BackColor = GetNextRestrictionColor(pb_restrictions_5_4.BackColor);
        }

        private void pb_restrictions_5_5_Click(object sender, EventArgs e)
        {
            pb_restrictions_5_5.BackColor = GetNextRestrictionColor(pb_restrictions_5_5.BackColor);
        }

        private void pb_restrictions_5_6_Click(object sender, EventArgs e)
        {
            pb_restrictions_5_6.BackColor = GetNextRestrictionColor(pb_restrictions_5_6.BackColor);
        }

        private void pb_restrictions_5_7_Click(object sender, EventArgs e)
        {
            pb_restrictions_5_7.BackColor = GetNextRestrictionColor(pb_restrictions_5_7.BackColor);
        }

        private void pb_restrictions_5_8_Click(object sender, EventArgs e)
        {
            pb_restrictions_5_8.BackColor = GetNextRestrictionColor(pb_restrictions_5_8.BackColor);
        }

        private void pb_restrictions_5_9_Click(object sender, EventArgs e)
        {
            pb_restrictions_5_9.BackColor = GetNextRestrictionColor(pb_restrictions_5_9.BackColor);
        }

        private void pb_restrictions_5_10_Click(object sender, EventArgs e)
        {
            pb_restrictions_5_10.BackColor = GetNextRestrictionColor(pb_restrictions_5_10.BackColor);
        }

        private void pb_restrictions_5_11_Click(object sender, EventArgs e)
        {
            pb_restrictions_5_11.BackColor = GetNextRestrictionColor(pb_restrictions_5_11.BackColor);
        }

        private void pb_restrictions_5_12_Click(object sender, EventArgs e)
        {
            pb_restrictions_5_12.BackColor = GetNextRestrictionColor(pb_restrictions_5_12.BackColor);
        }

        private void pb_restrictions_5_13_Click(object sender, EventArgs e)
        {
            pb_restrictions_5_13.BackColor = GetNextRestrictionColor(pb_restrictions_5_13.BackColor);
        }

        private void pb_restrictions_5_14_Click(object sender, EventArgs e)
        {
            pb_restrictions_5_14.BackColor = GetNextRestrictionColor(pb_restrictions_5_14.BackColor);
        }

        private void b_calculate_Click(object sender, EventArgs e)
        {
            int[,] restriction_matrix = CreateRestrictionMatrix();
            int[,] schedule_matrix = CreateScheduleMatrix();
            scheduler.SetScheduleSettings(workers_number, days_number, workers_per_day, max_working_days ,restriction_matrix);

            int[,] optimal_schedule = scheduler.BuildSchedule();
            ShowSchedule(optimal_schedule);
        }

        private int[,] CreateRestrictionMatrix()
        {
            int[,] restriction_matrix = new int[workers_number, days_number];
            restriction_matrix[0, 0] = penalty_by_color[pb_restrictions_1_1.BackColor];
            restriction_matrix[0, 1] = penalty_by_color[pb_restrictions_1_2.BackColor];
            restriction_matrix[0, 2] = penalty_by_color[pb_restrictions_1_3.BackColor];
            restriction_matrix[0, 3] = penalty_by_color[pb_restrictions_1_4.BackColor];
            restriction_matrix[0, 4] = penalty_by_color[pb_restrictions_1_5.BackColor];
            restriction_matrix[0, 5] = penalty_by_color[pb_restrictions_1_6.BackColor];
            restriction_matrix[0, 6] = penalty_by_color[pb_restrictions_1_7.BackColor];
            restriction_matrix[0, 7] = penalty_by_color[pb_restrictions_1_8.BackColor];
            restriction_matrix[0, 8] = penalty_by_color[pb_restrictions_1_9.BackColor];
            restriction_matrix[0, 9] = penalty_by_color[pb_restrictions_1_10.BackColor];
            restriction_matrix[0, 10] = penalty_by_color[pb_restrictions_1_11.BackColor];
            restriction_matrix[0, 11] = penalty_by_color[pb_restrictions_1_12.BackColor];
            restriction_matrix[0, 12] = penalty_by_color[pb_restrictions_1_13.BackColor];
            restriction_matrix[0, 13] = penalty_by_color[pb_restrictions_1_14.BackColor];
            restriction_matrix[1, 0] = penalty_by_color[pb_restrictions_2_1.BackColor];
            restriction_matrix[1, 1] = penalty_by_color[pb_restrictions_2_2.BackColor];
            restriction_matrix[1, 2] = penalty_by_color[pb_restrictions_2_3.BackColor];
            restriction_matrix[1, 3] = penalty_by_color[pb_restrictions_2_4.BackColor];
            restriction_matrix[1, 4] = penalty_by_color[pb_restrictions_2_5.BackColor];
            restriction_matrix[1, 5] = penalty_by_color[pb_restrictions_2_6.BackColor];
            restriction_matrix[1, 6] = penalty_by_color[pb_restrictions_2_7.BackColor];
            restriction_matrix[1, 7] = penalty_by_color[pb_restrictions_2_8.BackColor];
            restriction_matrix[1, 8] = penalty_by_color[pb_restrictions_2_9.BackColor];
            restriction_matrix[1, 9] = penalty_by_color[pb_restrictions_2_10.BackColor];
            restriction_matrix[1, 10] = penalty_by_color[pb_restrictions_2_11.BackColor];
            restriction_matrix[1, 11] = penalty_by_color[pb_restrictions_2_12.BackColor];
            restriction_matrix[1, 12] = penalty_by_color[pb_restrictions_2_13.BackColor];
            restriction_matrix[1, 13] = penalty_by_color[pb_restrictions_2_14.BackColor];
            restriction_matrix[2, 0] = penalty_by_color[pb_restrictions_3_1.BackColor];
            restriction_matrix[2, 1] = penalty_by_color[pb_restrictions_3_2.BackColor];
            restriction_matrix[2, 2] = penalty_by_color[pb_restrictions_3_3.BackColor];
            restriction_matrix[2, 3] = penalty_by_color[pb_restrictions_3_4.BackColor];
            restriction_matrix[2, 4] = penalty_by_color[pb_restrictions_3_5.BackColor];
            restriction_matrix[2, 5] = penalty_by_color[pb_restrictions_3_6.BackColor];
            restriction_matrix[2, 6] = penalty_by_color[pb_restrictions_3_7.BackColor];
            restriction_matrix[2, 7] = penalty_by_color[pb_restrictions_3_8.BackColor];
            restriction_matrix[2, 8] = penalty_by_color[pb_restrictions_3_9.BackColor];
            restriction_matrix[2, 9] = penalty_by_color[pb_restrictions_3_10.BackColor];
            restriction_matrix[2, 10] = penalty_by_color[pb_restrictions_3_11.BackColor];
            restriction_matrix[2, 11] = penalty_by_color[pb_restrictions_3_12.BackColor];
            restriction_matrix[2, 12] = penalty_by_color[pb_restrictions_3_13.BackColor];
            restriction_matrix[2, 13] = penalty_by_color[pb_restrictions_3_14.BackColor];
            restriction_matrix[3, 0] = penalty_by_color[pb_restrictions_4_1.BackColor];
            restriction_matrix[3, 1] = penalty_by_color[pb_restrictions_4_2.BackColor];
            restriction_matrix[3, 2] = penalty_by_color[pb_restrictions_4_3.BackColor];
            restriction_matrix[3, 3] = penalty_by_color[pb_restrictions_4_4.BackColor];
            restriction_matrix[3, 4] = penalty_by_color[pb_restrictions_4_5.BackColor];
            restriction_matrix[3, 5] = penalty_by_color[pb_restrictions_4_6.BackColor];
            restriction_matrix[3, 6] = penalty_by_color[pb_restrictions_4_7.BackColor];
            restriction_matrix[3, 7] = penalty_by_color[pb_restrictions_4_8.BackColor];
            restriction_matrix[3, 8] = penalty_by_color[pb_restrictions_4_9.BackColor];
            restriction_matrix[3, 9] = penalty_by_color[pb_restrictions_4_10.BackColor];
            restriction_matrix[3, 10] = penalty_by_color[pb_restrictions_4_11.BackColor];
            restriction_matrix[3, 11] = penalty_by_color[pb_restrictions_4_12.BackColor];
            restriction_matrix[3, 12] = penalty_by_color[pb_restrictions_4_13.BackColor];
            restriction_matrix[3, 13] = penalty_by_color[pb_restrictions_4_14.BackColor];
            restriction_matrix[4, 0] = penalty_by_color[pb_restrictions_5_1.BackColor];
            restriction_matrix[4, 1] = penalty_by_color[pb_restrictions_5_2.BackColor];
            restriction_matrix[4, 2] = penalty_by_color[pb_restrictions_5_3.BackColor];
            restriction_matrix[4, 3] = penalty_by_color[pb_restrictions_5_4.BackColor];
            restriction_matrix[4, 4] = penalty_by_color[pb_restrictions_5_5.BackColor];
            restriction_matrix[4, 5] = penalty_by_color[pb_restrictions_5_6.BackColor];
            restriction_matrix[4, 6] = penalty_by_color[pb_restrictions_5_7.BackColor];
            restriction_matrix[4, 7] = penalty_by_color[pb_restrictions_5_8.BackColor];
            restriction_matrix[4, 8] = penalty_by_color[pb_restrictions_5_9.BackColor];
            restriction_matrix[4, 9] = penalty_by_color[pb_restrictions_5_10.BackColor];
            restriction_matrix[4, 10] = penalty_by_color[pb_restrictions_5_11.BackColor];
            restriction_matrix[4, 11] = penalty_by_color[pb_restrictions_5_12.BackColor];
            restriction_matrix[4, 12] = penalty_by_color[pb_restrictions_5_13.BackColor];
            restriction_matrix[4, 13] = penalty_by_color[pb_restrictions_5_14.BackColor];
            return restriction_matrix;
        }

        private int[,] CreateScheduleMatrix()
        {
            int[,] schedule_matrix = new int[workers_number, days_number];
            schedule_matrix[0, 0] = schedule_flag_by_color[pb_schedule_1_1.BackColor];
            schedule_matrix[0, 1] = schedule_flag_by_color[pb_schedule_1_2.BackColor];
            schedule_matrix[0, 2] = schedule_flag_by_color[pb_schedule_1_3.BackColor];
            schedule_matrix[0, 3] = schedule_flag_by_color[pb_schedule_1_4.BackColor];
            schedule_matrix[0, 4] = schedule_flag_by_color[pb_schedule_1_5.BackColor];
            schedule_matrix[0, 5] = schedule_flag_by_color[pb_schedule_1_6.BackColor];
            schedule_matrix[0, 6] = schedule_flag_by_color[pb_schedule_1_7.BackColor];
            schedule_matrix[0, 7] = schedule_flag_by_color[pb_schedule_1_8.BackColor];
            schedule_matrix[0, 8] = schedule_flag_by_color[pb_schedule_1_9.BackColor];
            schedule_matrix[0, 9] = schedule_flag_by_color[pb_schedule_1_10.BackColor];
            schedule_matrix[0, 10] = schedule_flag_by_color[pb_schedule_1_11.BackColor];
            schedule_matrix[0, 11] = schedule_flag_by_color[pb_schedule_1_12.BackColor];
            schedule_matrix[0, 12] = schedule_flag_by_color[pb_schedule_1_13.BackColor];
            schedule_matrix[0, 13] = schedule_flag_by_color[pb_schedule_1_14.BackColor];
            schedule_matrix[1, 0] = schedule_flag_by_color[pb_schedule_2_1.BackColor];
            schedule_matrix[1, 1] = schedule_flag_by_color[pb_schedule_2_2.BackColor];
            schedule_matrix[1, 2] = schedule_flag_by_color[pb_schedule_2_3.BackColor];
            schedule_matrix[1, 3] = schedule_flag_by_color[pb_schedule_2_4.BackColor];
            schedule_matrix[1, 4] = schedule_flag_by_color[pb_schedule_2_5.BackColor];
            schedule_matrix[1, 5] = schedule_flag_by_color[pb_schedule_2_6.BackColor];
            schedule_matrix[1, 6] = schedule_flag_by_color[pb_schedule_2_7.BackColor];
            schedule_matrix[1, 7] = schedule_flag_by_color[pb_schedule_2_8.BackColor];
            schedule_matrix[1, 8] = schedule_flag_by_color[pb_schedule_2_9.BackColor];
            schedule_matrix[1, 9] = schedule_flag_by_color[pb_schedule_2_10.BackColor];
            schedule_matrix[1, 10] = schedule_flag_by_color[pb_schedule_2_11.BackColor];
            schedule_matrix[1, 11] = schedule_flag_by_color[pb_schedule_2_12.BackColor];
            schedule_matrix[1, 12] = schedule_flag_by_color[pb_schedule_2_13.BackColor];
            schedule_matrix[1, 13] = schedule_flag_by_color[pb_schedule_2_14.BackColor];
            schedule_matrix[2, 0] = schedule_flag_by_color[pb_schedule_3_1.BackColor];
            schedule_matrix[2, 1] = schedule_flag_by_color[pb_schedule_3_2.BackColor];
            schedule_matrix[2, 2] = schedule_flag_by_color[pb_schedule_3_3.BackColor];
            schedule_matrix[2, 3] = schedule_flag_by_color[pb_schedule_3_4.BackColor];
            schedule_matrix[2, 4] = schedule_flag_by_color[pb_schedule_3_5.BackColor];
            schedule_matrix[2, 5] = schedule_flag_by_color[pb_schedule_3_6.BackColor];
            schedule_matrix[2, 6] = schedule_flag_by_color[pb_schedule_3_7.BackColor];
            schedule_matrix[2, 7] = schedule_flag_by_color[pb_schedule_3_8.BackColor];
            schedule_matrix[2, 8] = schedule_flag_by_color[pb_schedule_3_9.BackColor];
            schedule_matrix[2, 9] = schedule_flag_by_color[pb_schedule_3_10.BackColor];
            schedule_matrix[2, 10] = schedule_flag_by_color[pb_schedule_3_11.BackColor];
            schedule_matrix[2, 11] = schedule_flag_by_color[pb_schedule_3_12.BackColor];
            schedule_matrix[2, 12] = schedule_flag_by_color[pb_schedule_3_13.BackColor];
            schedule_matrix[2, 13] = schedule_flag_by_color[pb_schedule_3_14.BackColor];
            schedule_matrix[3, 0] = schedule_flag_by_color[pb_schedule_4_1.BackColor];
            schedule_matrix[3, 1] = schedule_flag_by_color[pb_schedule_4_2.BackColor];
            schedule_matrix[3, 2] = schedule_flag_by_color[pb_schedule_4_3.BackColor];
            schedule_matrix[3, 3] = schedule_flag_by_color[pb_schedule_4_4.BackColor];
            schedule_matrix[3, 4] = schedule_flag_by_color[pb_schedule_4_5.BackColor];
            schedule_matrix[3, 5] = schedule_flag_by_color[pb_schedule_4_6.BackColor];
            schedule_matrix[3, 6] = schedule_flag_by_color[pb_schedule_4_7.BackColor];
            schedule_matrix[3, 7] = schedule_flag_by_color[pb_schedule_4_8.BackColor];
            schedule_matrix[3, 8] = schedule_flag_by_color[pb_schedule_4_9.BackColor];
            schedule_matrix[3, 9] = schedule_flag_by_color[pb_schedule_4_10.BackColor];
            schedule_matrix[3, 10] = schedule_flag_by_color[pb_schedule_4_11.BackColor];
            schedule_matrix[3, 11] = schedule_flag_by_color[pb_schedule_4_12.BackColor];
            schedule_matrix[3, 12] = schedule_flag_by_color[pb_schedule_4_13.BackColor];
            schedule_matrix[3, 13] = schedule_flag_by_color[pb_schedule_4_14.BackColor];
            schedule_matrix[4, 0] = schedule_flag_by_color[pb_schedule_5_1.BackColor];
            schedule_matrix[4, 1] = schedule_flag_by_color[pb_schedule_5_2.BackColor];
            schedule_matrix[4, 2] = schedule_flag_by_color[pb_schedule_5_3.BackColor];
            schedule_matrix[4, 3] = schedule_flag_by_color[pb_schedule_5_4.BackColor];
            schedule_matrix[4, 4] = schedule_flag_by_color[pb_schedule_5_5.BackColor];
            schedule_matrix[4, 5] = schedule_flag_by_color[pb_schedule_5_6.BackColor];
            schedule_matrix[4, 6] = schedule_flag_by_color[pb_schedule_5_7.BackColor];
            schedule_matrix[4, 7] = schedule_flag_by_color[pb_schedule_5_8.BackColor];
            schedule_matrix[4, 8] = schedule_flag_by_color[pb_schedule_5_9.BackColor];
            schedule_matrix[4, 9] = schedule_flag_by_color[pb_schedule_5_10.BackColor];
            schedule_matrix[4, 10] = schedule_flag_by_color[pb_schedule_5_11.BackColor];
            schedule_matrix[4, 11] = schedule_flag_by_color[pb_schedule_5_12.BackColor];
            schedule_matrix[4, 12] = schedule_flag_by_color[pb_schedule_5_13.BackColor];
            schedule_matrix[4, 13] = schedule_flag_by_color[pb_schedule_5_14.BackColor];
            return schedule_matrix;
        }

        private void pb_schedule_1_1_Click(object sender, EventArgs e)
        {
            pb_schedule_1_1.BackColor = GetNextScheduleColor(pb_schedule_1_1.BackColor);
        }

        private void pb_schedule_1_2_Click(object sender, EventArgs e)
        {
            pb_schedule_1_2.BackColor = GetNextScheduleColor(pb_schedule_1_2.BackColor);
        }

        private void pb_schedule_1_3_Click(object sender, EventArgs e)
        {
            pb_schedule_1_3.BackColor = GetNextScheduleColor(pb_schedule_1_3.BackColor);
        }

        private void pb_schedule_1_4_Click(object sender, EventArgs e)
        {
            pb_schedule_1_4.BackColor = GetNextScheduleColor(pb_schedule_1_4.BackColor);
        }

        private void pb_schedule_1_5_Click(object sender, EventArgs e)
        {
            pb_schedule_1_5.BackColor = GetNextScheduleColor(pb_schedule_1_5.BackColor);
        }

        private void pb_schedule_1_6_Click(object sender, EventArgs e)
        {
            pb_schedule_1_6.BackColor = GetNextScheduleColor(pb_schedule_1_6.BackColor);
        }

        private void pb_schedule_1_7_Click(object sender, EventArgs e)
        {
            pb_schedule_1_7.BackColor = GetNextScheduleColor(pb_schedule_1_7.BackColor);
        }

        private void pb_schedule_1_8_Click(object sender, EventArgs e)
        {
            pb_schedule_1_8.BackColor = GetNextScheduleColor(pb_schedule_1_8.BackColor);
        }

        private void pb_schedule_1_9_Click(object sender, EventArgs e)
        {
            pb_schedule_1_9.BackColor = GetNextScheduleColor(pb_schedule_1_9.BackColor);
        }

        private void pb_schedule_1_10_Click(object sender, EventArgs e)
        {
            pb_schedule_1_10.BackColor = GetNextScheduleColor(pb_schedule_1_10.BackColor);
        }

        private void pb_schedule_1_11_Click(object sender, EventArgs e)
        {
            pb_schedule_1_11.BackColor = GetNextScheduleColor(pb_schedule_1_11.BackColor);
        }

        private void pb_schedule_1_12_Click(object sender, EventArgs e)
        {
            pb_schedule_1_12.BackColor = GetNextScheduleColor(pb_schedule_1_12.BackColor);
        }

        private void pb_schedule_1_13_Click(object sender, EventArgs e)
        {
            pb_schedule_1_13.BackColor = GetNextScheduleColor(pb_schedule_1_13.BackColor);
        }

        private void pb_schedule_1_14_Click(object sender, EventArgs e)
        {
            pb_schedule_1_14.BackColor = GetNextScheduleColor(pb_schedule_1_14.BackColor);
        }

        private void pb_schedule_2_1_Click(object sender, EventArgs e)
        {
            pb_schedule_2_1.BackColor = GetNextScheduleColor(pb_schedule_2_1.BackColor);
        }

        private void pb_schedule_2_2_Click(object sender, EventArgs e)
        {
            pb_schedule_2_2.BackColor = GetNextScheduleColor(pb_schedule_2_2.BackColor);
        }

        private void pb_schedule_2_3_Click(object sender, EventArgs e)
        {
            pb_schedule_2_3.BackColor = GetNextScheduleColor(pb_schedule_2_3.BackColor);
        }

        private void pb_schedule_2_4_Click(object sender, EventArgs e)
        {
            pb_schedule_2_4.BackColor = GetNextScheduleColor(pb_schedule_2_4.BackColor);
        }

        private void pb_schedule_2_5_Click(object sender, EventArgs e)
        {
            pb_schedule_2_5.BackColor = GetNextScheduleColor(pb_schedule_2_5.BackColor);
        }

        private void pb_schedule_2_6_Click(object sender, EventArgs e)
        {
            pb_schedule_2_6.BackColor = GetNextScheduleColor(pb_schedule_2_6.BackColor);
        }

        private void pb_schedule_2_7_Click(object sender, EventArgs e)
        {
            pb_schedule_2_7.BackColor = GetNextScheduleColor(pb_schedule_2_7.BackColor);
        }

        private void pb_schedule_2_8_Click(object sender, EventArgs e)
        {
            pb_schedule_2_8.BackColor = GetNextScheduleColor(pb_schedule_2_8.BackColor);
        }

        private void pb_schedule_2_9_Click(object sender, EventArgs e)
        {
            pb_schedule_2_9.BackColor = GetNextScheduleColor(pb_schedule_2_9.BackColor);
        }

        private void pb_schedule_2_10_Click(object sender, EventArgs e)
        {
            pb_schedule_2_10.BackColor = GetNextScheduleColor(pb_schedule_2_10.BackColor);
        }

        private void pb_schedule_2_11_Click(object sender, EventArgs e)
        {
            pb_schedule_2_11.BackColor = GetNextScheduleColor(pb_schedule_2_11.BackColor);
        }

        private void pb_schedule_2_12_Click(object sender, EventArgs e)
        {
            pb_schedule_2_12.BackColor = GetNextScheduleColor(pb_schedule_2_12.BackColor);
        }

        private void pb_schedule_2_13_Click(object sender, EventArgs e)
        {
            pb_schedule_2_13.BackColor = GetNextScheduleColor(pb_schedule_2_13.BackColor);
        }

        private void pb_schedule_2_14_Click(object sender, EventArgs e)
        {
            pb_schedule_2_14.BackColor = GetNextScheduleColor(pb_schedule_2_14.BackColor);
        }

        private void pb_schedule_3_1_Click(object sender, EventArgs e)
        {
            pb_schedule_3_1.BackColor = GetNextScheduleColor(pb_schedule_3_1.BackColor);
        }

        private void pb_schedule_3_2_Click(object sender, EventArgs e)
        {
            pb_schedule_3_2.BackColor = GetNextScheduleColor(pb_schedule_3_2.BackColor);
        }

        private void pb_schedule_3_3_Click(object sender, EventArgs e)
        {
            pb_schedule_3_3.BackColor = GetNextScheduleColor(pb_schedule_3_3.BackColor);
        }

        private void pb_schedule_3_4_Click(object sender, EventArgs e)
        {
            pb_schedule_3_4.BackColor = GetNextScheduleColor(pb_schedule_3_4.BackColor);
        }

        private void pb_schedule_3_5_Click(object sender, EventArgs e)
        {
            pb_schedule_3_5.BackColor = GetNextScheduleColor(pb_schedule_3_5.BackColor);
        }

        private void pb_schedule_3_6_Click(object sender, EventArgs e)
        {
            pb_schedule_3_6.BackColor = GetNextScheduleColor(pb_schedule_3_6.BackColor);
        }

        private void pb_schedule_3_7_Click(object sender, EventArgs e)
        {
            pb_schedule_3_7.BackColor = GetNextScheduleColor(pb_schedule_3_7.BackColor);
        }

        private void pb_schedule_3_8_Click(object sender, EventArgs e)
        {
            pb_schedule_3_8.BackColor = GetNextScheduleColor(pb_schedule_3_8.BackColor);
        }

        private void pb_schedule_3_9_Click(object sender, EventArgs e)
        {
            pb_schedule_3_9.BackColor = GetNextScheduleColor(pb_schedule_3_9.BackColor);
        }

        private void pb_schedule_3_10_Click(object sender, EventArgs e)
        {
            pb_schedule_3_10.BackColor = GetNextScheduleColor(pb_schedule_3_10.BackColor);
        }

        private void pb_schedule_3_11_Click(object sender, EventArgs e)
        {
            pb_schedule_3_11.BackColor = GetNextScheduleColor(pb_schedule_3_11.BackColor);
        }

        private void pb_schedule_3_12_Click(object sender, EventArgs e)
        {
            pb_schedule_3_12.BackColor = GetNextScheduleColor(pb_schedule_3_12.BackColor);
        }

        private void pb_schedule_3_13_Click(object sender, EventArgs e)
        {
            pb_schedule_3_13.BackColor = GetNextScheduleColor(pb_schedule_3_13.BackColor);
        }

        private void pb_schedule_3_14_Click(object sender, EventArgs e)
        {
            pb_schedule_3_14.BackColor = GetNextScheduleColor(pb_schedule_3_14.BackColor);
        }

        private void pb_schedule_4_1_Click(object sender, EventArgs e)
        {
            pb_schedule_4_1.BackColor = GetNextScheduleColor(pb_schedule_4_1.BackColor);
        }

        private void pb_schedule_4_2_Click(object sender, EventArgs e)
        {
            pb_schedule_4_2.BackColor = GetNextScheduleColor(pb_schedule_4_2.BackColor);
        }

        private void pb_schedule_4_3_Click(object sender, EventArgs e)
        {
            pb_schedule_4_3.BackColor = GetNextScheduleColor(pb_schedule_4_3.BackColor);
        }

        private void pb_schedule_4_4_Click(object sender, EventArgs e)
        {
            pb_schedule_4_4.BackColor = GetNextScheduleColor(pb_schedule_4_4.BackColor);
        }

        private void pb_schedule_4_5_Click(object sender, EventArgs e)
        {
            pb_schedule_4_5.BackColor = GetNextScheduleColor(pb_schedule_4_5.BackColor);
        }

        private void pb_schedule_4_6_Click(object sender, EventArgs e)
        {
            pb_schedule_4_6.BackColor = GetNextScheduleColor(pb_schedule_4_6.BackColor);
        }

        private void pb_schedule_4_7_Click(object sender, EventArgs e)
        {
            pb_schedule_4_7.BackColor = GetNextScheduleColor(pb_schedule_4_7.BackColor);
        }

        private void pb_schedule_4_8_Click(object sender, EventArgs e)
        {
            pb_schedule_4_8.BackColor = GetNextScheduleColor(pb_schedule_4_8.BackColor);
        }

        private void pb_schedule_4_9_Click(object sender, EventArgs e)
        {
            pb_schedule_4_9.BackColor = GetNextScheduleColor(pb_schedule_4_9.BackColor);
        }

        private void pb_schedule_4_10_Click(object sender, EventArgs e)
        {
            pb_schedule_4_10.BackColor = GetNextScheduleColor(pb_schedule_4_10.BackColor);
        }

        private void pb_schedule_4_11_Click(object sender, EventArgs e)
        {
            pb_schedule_4_11.BackColor = GetNextScheduleColor(pb_schedule_4_11.BackColor);
        }

        private void pb_schedule_4_12_Click(object sender, EventArgs e)
        {
            pb_schedule_4_12.BackColor = GetNextScheduleColor(pb_schedule_4_12.BackColor);
        }

        private void pb_schedule_4_13_Click(object sender, EventArgs e)
        {
            pb_schedule_4_13.BackColor = GetNextScheduleColor(pb_schedule_4_13.BackColor);
        }

        private void pb_schedule_4_14_Click(object sender, EventArgs e)
        {
            pb_schedule_4_14.BackColor = GetNextScheduleColor(pb_schedule_4_14.BackColor);
        }

        private void pb_schedule_5_1_Click(object sender, EventArgs e)
        {
            pb_schedule_5_1.BackColor = GetNextScheduleColor(pb_schedule_5_1.BackColor);
        }

        private void pb_schedule_5_2_Click(object sender, EventArgs e)
        {
            pb_schedule_5_2.BackColor = GetNextScheduleColor(pb_schedule_5_2.BackColor);
        }

        private void pb_schedule_5_3_Click(object sender, EventArgs e)
        {
            pb_schedule_5_3.BackColor = GetNextScheduleColor(pb_schedule_5_3.BackColor);
        }

        private void pb_schedule_5_4_Click(object sender, EventArgs e)
        {
            pb_schedule_5_4.BackColor = GetNextScheduleColor(pb_schedule_5_4.BackColor);
        }

        private void pb_schedule_5_5_Click(object sender, EventArgs e)
        {
            pb_schedule_5_5.BackColor = GetNextScheduleColor(pb_schedule_5_5.BackColor);
        }

        private void pb_schedule_5_6_Click(object sender, EventArgs e)
        {
            pb_schedule_5_6.BackColor = GetNextScheduleColor(pb_schedule_5_6.BackColor);
        }

        private void pb_schedule_5_7_Click(object sender, EventArgs e)
        {
            pb_schedule_5_7.BackColor = GetNextScheduleColor(pb_schedule_5_7.BackColor);
        }

        private void pb_schedule_5_8_Click(object sender, EventArgs e)
        {
            pb_schedule_5_8.BackColor = GetNextScheduleColor(pb_schedule_5_8.BackColor);
        }

        private void pb_schedule_5_9_Click(object sender, EventArgs e)
        {
            pb_schedule_5_9.BackColor = GetNextScheduleColor(pb_schedule_5_9.BackColor);
        }

        private void pb_schedule_5_10_Click(object sender, EventArgs e)
        {
            pb_schedule_5_10.BackColor = GetNextScheduleColor(pb_schedule_5_10.BackColor);
        }

        private void pb_schedule_5_11_Click(object sender, EventArgs e)
        {
            pb_schedule_5_11.BackColor = GetNextScheduleColor(pb_schedule_5_11.BackColor);
        }

        private void pb_schedule_5_12_Click(object sender, EventArgs e)
        {
            pb_schedule_5_12.BackColor = GetNextScheduleColor(pb_schedule_5_12.BackColor);
        }

        private void pb_schedule_5_13_Click(object sender, EventArgs e)
        {
            pb_schedule_5_13.BackColor = GetNextScheduleColor(pb_schedule_5_13.BackColor);
        }

        private void pb_schedule_5_14_Click(object sender, EventArgs e)
        {
            pb_schedule_5_14.BackColor = GetNextScheduleColor(pb_schedule_5_14.BackColor);
        }

        private void b_clear_Click(object sender, EventArgs e)
        {
            pb_schedule_1_1.BackColor = color_by_schedule_flag[0];
            pb_schedule_1_2.BackColor = color_by_schedule_flag[0];
            pb_schedule_1_3.BackColor = color_by_schedule_flag[0];
            pb_schedule_1_4.BackColor = color_by_schedule_flag[0];
            pb_schedule_1_5.BackColor = color_by_schedule_flag[0];
            pb_schedule_1_6.BackColor = color_by_schedule_flag[0];
            pb_schedule_1_7.BackColor = color_by_schedule_flag[0];
            pb_schedule_1_8.BackColor = color_by_schedule_flag[0];
            pb_schedule_1_9.BackColor = color_by_schedule_flag[0];
            pb_schedule_1_10.BackColor = color_by_schedule_flag[0];
            pb_schedule_1_11.BackColor = color_by_schedule_flag[0];
            pb_schedule_1_12.BackColor = color_by_schedule_flag[0];
            pb_schedule_1_13.BackColor = color_by_schedule_flag[0];
            pb_schedule_1_14.BackColor = color_by_schedule_flag[0];
            pb_schedule_2_1.BackColor = color_by_schedule_flag[0];
            pb_schedule_2_2.BackColor = color_by_schedule_flag[0];
            pb_schedule_2_3.BackColor = color_by_schedule_flag[0];
            pb_schedule_2_4.BackColor = color_by_schedule_flag[0];
            pb_schedule_2_5.BackColor = color_by_schedule_flag[0];
            pb_schedule_2_6.BackColor = color_by_schedule_flag[0];
            pb_schedule_2_7.BackColor = color_by_schedule_flag[0];
            pb_schedule_2_8.BackColor = color_by_schedule_flag[0];
            pb_schedule_2_9.BackColor = color_by_schedule_flag[0];
            pb_schedule_2_10.BackColor = color_by_schedule_flag[0];
            pb_schedule_2_11.BackColor = color_by_schedule_flag[0];
            pb_schedule_2_12.BackColor = color_by_schedule_flag[0];
            pb_schedule_2_13.BackColor = color_by_schedule_flag[0];
            pb_schedule_2_14.BackColor = color_by_schedule_flag[0];
            pb_schedule_3_1.BackColor = color_by_schedule_flag[0];
            pb_schedule_3_2.BackColor = color_by_schedule_flag[0];
            pb_schedule_3_3.BackColor = color_by_schedule_flag[0];
            pb_schedule_3_4.BackColor = color_by_schedule_flag[0];
            pb_schedule_3_5.BackColor = color_by_schedule_flag[0];
            pb_schedule_3_6.BackColor = color_by_schedule_flag[0];
            pb_schedule_3_7.BackColor = color_by_schedule_flag[0];
            pb_schedule_3_8.BackColor = color_by_schedule_flag[0];
            pb_schedule_3_9.BackColor = color_by_schedule_flag[0];
            pb_schedule_3_10.BackColor = color_by_schedule_flag[0];
            pb_schedule_3_11.BackColor = color_by_schedule_flag[0];
            pb_schedule_3_12.BackColor = color_by_schedule_flag[0];
            pb_schedule_3_13.BackColor = color_by_schedule_flag[0];
            pb_schedule_3_14.BackColor = color_by_schedule_flag[0];
            pb_schedule_4_1.BackColor = color_by_schedule_flag[0];
            pb_schedule_4_2.BackColor = color_by_schedule_flag[0];
            pb_schedule_4_3.BackColor = color_by_schedule_flag[0];
            pb_schedule_4_4.BackColor = color_by_schedule_flag[0];
            pb_schedule_4_5.BackColor = color_by_schedule_flag[0];
            pb_schedule_4_6.BackColor = color_by_schedule_flag[0];
            pb_schedule_4_7.BackColor = color_by_schedule_flag[0];
            pb_schedule_4_8.BackColor = color_by_schedule_flag[0];
            pb_schedule_4_9.BackColor = color_by_schedule_flag[0];
            pb_schedule_4_10.BackColor = color_by_schedule_flag[0];
            pb_schedule_4_11.BackColor = color_by_schedule_flag[0];
            pb_schedule_4_12.BackColor = color_by_schedule_flag[0];
            pb_schedule_4_13.BackColor = color_by_schedule_flag[0];
            pb_schedule_4_14.BackColor = color_by_schedule_flag[0];
            pb_schedule_5_1.BackColor = color_by_schedule_flag[0];
            pb_schedule_5_2.BackColor = color_by_schedule_flag[0];
            pb_schedule_5_3.BackColor = color_by_schedule_flag[0];
            pb_schedule_5_4.BackColor = color_by_schedule_flag[0];
            pb_schedule_5_5.BackColor = color_by_schedule_flag[0];
            pb_schedule_5_6.BackColor = color_by_schedule_flag[0];
            pb_schedule_5_7.BackColor = color_by_schedule_flag[0];
            pb_schedule_5_8.BackColor = color_by_schedule_flag[0];
            pb_schedule_5_9.BackColor = color_by_schedule_flag[0];
            pb_schedule_5_10.BackColor = color_by_schedule_flag[0];
            pb_schedule_5_11.BackColor = color_by_schedule_flag[0];
            pb_schedule_5_12.BackColor = color_by_schedule_flag[0];
            pb_schedule_5_13.BackColor = color_by_schedule_flag[0];
            pb_schedule_5_14.BackColor = color_by_schedule_flag[0];
        }

        private void ShowSchedule(int[,] _schedule)
        {
            pb_schedule_1_1.BackColor = color_by_schedule_flag[_schedule[0, 0]];
            pb_schedule_1_2.BackColor = color_by_schedule_flag[_schedule[0, 1]];
            pb_schedule_1_3.BackColor = color_by_schedule_flag[_schedule[0, 2]];
            pb_schedule_1_4.BackColor = color_by_schedule_flag[_schedule[0, 3]];
            pb_schedule_1_5.BackColor = color_by_schedule_flag[_schedule[0, 4]];
            pb_schedule_1_6.BackColor = color_by_schedule_flag[_schedule[0, 5]];
            pb_schedule_1_7.BackColor = color_by_schedule_flag[_schedule[0, 6]];
            pb_schedule_1_8.BackColor = color_by_schedule_flag[_schedule[0, 7]];
            pb_schedule_1_9.BackColor = color_by_schedule_flag[_schedule[0, 8]];
            pb_schedule_1_10.BackColor = color_by_schedule_flag[_schedule[0, 9]];
            pb_schedule_1_11.BackColor = color_by_schedule_flag[_schedule[0, 10]];
            pb_schedule_1_12.BackColor = color_by_schedule_flag[_schedule[0, 11]];
            pb_schedule_1_13.BackColor = color_by_schedule_flag[_schedule[0, 12]];
            pb_schedule_1_14.BackColor = color_by_schedule_flag[_schedule[0, 13]];
            pb_schedule_2_1.BackColor = color_by_schedule_flag[_schedule[1, 0]];
            pb_schedule_2_2.BackColor = color_by_schedule_flag[_schedule[1, 1]];
            pb_schedule_2_3.BackColor = color_by_schedule_flag[_schedule[1, 2]];
            pb_schedule_2_4.BackColor = color_by_schedule_flag[_schedule[1, 3]];
            pb_schedule_2_5.BackColor = color_by_schedule_flag[_schedule[1, 4]];
            pb_schedule_2_6.BackColor = color_by_schedule_flag[_schedule[1, 5]];
            pb_schedule_2_7.BackColor = color_by_schedule_flag[_schedule[1, 6]];
            pb_schedule_2_8.BackColor = color_by_schedule_flag[_schedule[1, 7]];
            pb_schedule_2_9.BackColor = color_by_schedule_flag[_schedule[1, 8]];
            pb_schedule_2_10.BackColor = color_by_schedule_flag[_schedule[1, 9]];
            pb_schedule_2_11.BackColor = color_by_schedule_flag[_schedule[1, 10]];
            pb_schedule_2_12.BackColor = color_by_schedule_flag[_schedule[1, 11]];
            pb_schedule_2_13.BackColor = color_by_schedule_flag[_schedule[1, 12]];
            pb_schedule_2_14.BackColor = color_by_schedule_flag[_schedule[1, 13]];
            pb_schedule_3_1.BackColor = color_by_schedule_flag[_schedule[2, 0]];
            pb_schedule_3_2.BackColor = color_by_schedule_flag[_schedule[2, 1]];
            pb_schedule_3_3.BackColor = color_by_schedule_flag[_schedule[2, 2]];
            pb_schedule_3_4.BackColor = color_by_schedule_flag[_schedule[2, 3]];
            pb_schedule_3_5.BackColor = color_by_schedule_flag[_schedule[2, 4]];
            pb_schedule_3_6.BackColor = color_by_schedule_flag[_schedule[2, 5]];
            pb_schedule_3_7.BackColor = color_by_schedule_flag[_schedule[2, 6]];
            pb_schedule_3_8.BackColor = color_by_schedule_flag[_schedule[2, 7]];
            pb_schedule_3_9.BackColor = color_by_schedule_flag[_schedule[2, 8]];
            pb_schedule_3_10.BackColor = color_by_schedule_flag[_schedule[2, 9]];
            pb_schedule_3_11.BackColor = color_by_schedule_flag[_schedule[2, 10]];
            pb_schedule_3_12.BackColor = color_by_schedule_flag[_schedule[2, 11]];
            pb_schedule_3_13.BackColor = color_by_schedule_flag[_schedule[2, 12]];
            pb_schedule_3_14.BackColor = color_by_schedule_flag[_schedule[2, 13]];
            pb_schedule_4_1.BackColor = color_by_schedule_flag[_schedule[3, 0]];
            pb_schedule_4_2.BackColor = color_by_schedule_flag[_schedule[3, 1]];
            pb_schedule_4_3.BackColor = color_by_schedule_flag[_schedule[3, 2]];
            pb_schedule_4_4.BackColor = color_by_schedule_flag[_schedule[3, 3]];
            pb_schedule_4_5.BackColor = color_by_schedule_flag[_schedule[3, 4]];
            pb_schedule_4_6.BackColor = color_by_schedule_flag[_schedule[3, 5]];
            pb_schedule_4_7.BackColor = color_by_schedule_flag[_schedule[3, 6]];
            pb_schedule_4_8.BackColor = color_by_schedule_flag[_schedule[3, 7]];
            pb_schedule_4_9.BackColor = color_by_schedule_flag[_schedule[3, 8]];
            pb_schedule_4_10.BackColor = color_by_schedule_flag[_schedule[3, 9]];
            pb_schedule_4_11.BackColor = color_by_schedule_flag[_schedule[3, 10]];
            pb_schedule_4_12.BackColor = color_by_schedule_flag[_schedule[3, 11]];
            pb_schedule_4_13.BackColor = color_by_schedule_flag[_schedule[3, 12]];
            pb_schedule_4_14.BackColor = color_by_schedule_flag[_schedule[3, 13]];
            pb_schedule_5_1.BackColor = color_by_schedule_flag[_schedule[4, 0]];
            pb_schedule_5_2.BackColor = color_by_schedule_flag[_schedule[4, 1]];
            pb_schedule_5_3.BackColor = color_by_schedule_flag[_schedule[4, 2]];
            pb_schedule_5_4.BackColor = color_by_schedule_flag[_schedule[4, 3]];
            pb_schedule_5_5.BackColor = color_by_schedule_flag[_schedule[4, 4]];
            pb_schedule_5_6.BackColor = color_by_schedule_flag[_schedule[4, 5]];
            pb_schedule_5_7.BackColor = color_by_schedule_flag[_schedule[4, 6]];
            pb_schedule_5_8.BackColor = color_by_schedule_flag[_schedule[4, 7]];
            pb_schedule_5_9.BackColor = color_by_schedule_flag[_schedule[4, 8]];
            pb_schedule_5_10.BackColor = color_by_schedule_flag[_schedule[4, 9]];
            pb_schedule_5_11.BackColor = color_by_schedule_flag[_schedule[4, 10]];
            pb_schedule_5_12.BackColor = color_by_schedule_flag[_schedule[4, 11]];
            pb_schedule_5_13.BackColor = color_by_schedule_flag[_schedule[4, 12]];
            pb_schedule_5_14.BackColor = color_by_schedule_flag[_schedule[4, 13]];
        }
    }
}
