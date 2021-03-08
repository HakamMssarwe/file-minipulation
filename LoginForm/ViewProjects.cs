using System;
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
    public partial class ViewProjects : Form
    {
        private string path;
        public ViewProjects(string path)
        {
            InitializeComponent();
            this.path = path;
            projectsOutput.Text = File.ReadAllText(path);

        }

    }
}
