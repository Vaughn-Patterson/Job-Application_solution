﻿using System;
using System.Windows.Forms;

namespace JobApp
{

    public partial class Jobseeker_submit_resume : Form
    {
         
        private readonly Jobapp_dbEntities _db;
        public Jobseeker_submit_resume()
        {
            InitializeComponent();
            _db = new Jobapp_dbEntities();

        }

        private void Cancel_bt_Click(object sender, EventArgs e)
        {
            var Job_Seeker_Accountview = new Job_Seeker_Accountview();
            Job_Seeker_Accountview.Close();
        }

        private void Submit_bt_Click(object sender, EventArgs e)
        {


            try
            {
                var Education_level = edu_tb.Text;
                var Contact_number = cont_tb.Text;
                var Hobbies = hobby_tb.Text;
                var Email = email_tb.Text;
                var PriorWork_Experiences = exper_tb.Text;
                var Qualifications = qualifica_tb.Text;

                // var vacancy_id = v
                var Resume_details = new Resume_details
                {
                    Education_level = Education_level,
                    Contact_number = Contact_number,
                    Hobbies = Hobbies,
                    Email = Email,
                    PriorWork_Experiences = PriorWork_Experiences,
                    Qualifications = Qualifications


                };

                _db.Resume_details.Add(Resume_details);
                _db.SaveChanges();

                var resume_id = Resume_details.id;


                var Job_Applications_details = new Job_Applications_details
                {


                    resume_id = resume_id,

                  

                };

                _db.Job_Applications_details.Add(Job_Applications_details);
                _db.SaveChanges();

            }
            catch (Exception)
            {

                // throw;
            }



        }
    }
}
