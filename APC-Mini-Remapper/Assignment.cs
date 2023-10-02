using WindowsInput;
using VKC = WindowsInput.Native.VirtualKeyCode;
using APCmini;

namespace APC_Mini_Remapper
{
    public partial class AssignHotkey : Form
    {

        public AssignHotkey(string name)
        {
            InitializeComponent();
            this.Text = name;
            foreach (var key in APCmini.Keys.modKeys)
            {
                mod1.Items.Add(key.label);
                mod2.Items.Add(key.label);
            }
            foreach (var key in APCmini.Keys.charKeys)
            {
                charKey.Items.Add(key.label);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void keySelectionGroup_Enter(object sender, EventArgs e)
        {

        }

        private void mod1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
