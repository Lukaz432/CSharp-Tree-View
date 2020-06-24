using System;
using System.Windows.Forms;

namespace TreeViewProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddNode()
        {
            TreeNode newNode = new TreeNode("[New Node]");
            TreeNode selNode = tv.SelectedNode;
            if (selNode != null)
            {
                selNode.Nodes.Add(newNode);
                tv.SelectedNode.Expand();
            } else
            {
                tv.Nodes.Add(newNode);
                tv.SelectedNode = newNode;
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddNode();
        }
        private void DelBtn_Click(object sender, EventArgs e)
        {
            TreeNode selNode = tv.SelectedNode;
            DialogResult result;
            if (selNode.Nodes.Count > 0)
            {
                DialogResult = MessageBox.Show(
                    "This node is NOT empty. Deleting it will cause everything inside it disappear. Continue?",
                    "Warning!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.Yes)
                {
                    tv.SelectedNode.Remove();
                }
            } else
            {
                tv.SelectedNode.Remove();
            }
        }

    }
}
