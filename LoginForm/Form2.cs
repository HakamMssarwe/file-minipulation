using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form2 : Form
    {
        static private List<string> tasks = new List<string>();
        private string path = @"../../projects.txt";
        private string tempFilePath = @"../../tempFile.txt";

        LoginForm loginForm;
        public Form2(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            loginForm = new LoginForm();
            loginForm.Show();
        }

        private void addTaskBtn_Click(object sender, EventArgs e)
        {
           
            //basically if the project exists and not new
            if (newTaskInput.Text != "" && File.ReadAllText(path).IndexOf(projectNameInput.Text) != -1)
            {
                string line;
                using (StreamReader file = new StreamReader(path))
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        if (line.IndexOf($"{"{" + projectNameInput.Text},") != -1)

                            line = line.Insert(line.Length - 1, (line[line.Length - 2] != ':'? ", " : "") + newTaskInput.Text);

                        
                            File.AppendAllText(tempFilePath, line + "\n");

                    }

                }

                MessageBox.Show("The task was assigned to it!");
                File.WriteAllText(path, File.ReadAllText(tempFilePath));
                File.WriteAllText(tempFilePath, "");


            }


           else if (newTaskInput.Text != "")
            {
                tasks.Add(newTaskInput.Text);
                newTaskLabel.Text = $"New Task ({tasks.Count})";
            }

            newTaskInput.Text = "";
        }



        private void assignProjectBtn_Click(object sender, EventArgs e)
        {
            if (File.ReadAllText(path).IndexOf($"{{{projectNameInput.Text}, tasks:") != -1)
                MessageBox.Show("Project already exists!");

            

            else if (tasks.Count != 0 && projectNameInput.Text != "")
            {
                File.AppendAllText(path, $"{{{projectNameInput.Text}, tasks:");
                for (int i = 0; i < tasks.Count; i++)
                {
                    File.AppendAllText(path, tasks[i]);
                    File.AppendAllText(path, i != tasks.Count-1 ? ", " : "}\n");
                }

                projectNameInput.Text = "";
                newTaskInput.Text = "";
                tasks.Clear();
                newTaskLabel.Text = $"New Task ({tasks.Count})";
                MessageBox.Show("Project created successfully!");
            }
            else
                MessageBox.Show("Cannot leave empty fields and cannot initiate a project without at least one task");
            

        }

        private void viewProjectBtn_Click(object sender, EventArgs e)
        {
            ViewProjects viewProjectsForm = new ViewProjects(path);
            viewProjectsForm.Show();
        }

        private void deleteProjectBtn_Click(object sender, EventArgs e)
        {
            if (projectNameInput.Text == "")
                MessageBox.Show("Enter the name of the project you would like to delete!");


            string line;

            using (StreamReader file = new StreamReader(path))
            {
                while ((line = file.ReadLine()) != null)
                {
                    if (line.IndexOf($"{"{"+projectNameInput.Text},") == -1)
                        File.AppendAllText(tempFilePath, line + "\n");
                    
                }

            }


            File.WriteAllText(path, File.ReadAllText(tempFilePath));
            File.WriteAllText(tempFilePath, "");
            MessageBox.Show("if a project with that name existed, it was removed.");
            projectNameInput.Text = "";


                

            
        }

        private void updateProjectBtn_Click(object sender, EventArgs e)
        {

        }

        private void removeTaskBtn_Click(object sender, EventArgs e)
        {
            //basically if the project exists and not new
            if (newTaskInput.Text != "" && File.ReadAllText(path).IndexOf($"{{{projectNameInput.Text}, tasks:") != -1)
            {
                string line;
                using (StreamReader file = new StreamReader(path))
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        if (line.IndexOf($"{"{" + projectNameInput.Text},") != -1)
                        {
                            int tempLineLength = line.Length;

                            line = line.Replace($", {newTaskInput.Text}", ""); 

                            if (tempLineLength == line.Length) //if no replace happened that means the task was the first
                                line = line.Replace($"{newTaskInput.Text}", "").Replace(":, ","");
                            
                        }


                        File.AppendAllText(tempFilePath, line + "\n");

                    }

                }

                MessageBox.Show("The task was removed!");
                File.WriteAllText(path, File.ReadAllText(tempFilePath));
                File.WriteAllText(tempFilePath, "");


            }

            else if (newTaskInput.Text != "")
            {
                tasks.Remove(newTaskInput.Text);
                newTaskLabel.Text = $"Tasks({tasks.Count.ToString()})";
            }


            newTaskInput.Text = "";

        }
    }
}
