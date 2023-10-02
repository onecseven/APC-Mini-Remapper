using WindowsInput;
using VKC = WindowsInput.Native.VirtualKeyCode;
using APCmini;

namespace APC_Mini_Remapper
{
    public partial class AssignHotkey : Form
    {

        // ON INDEX SELECTED CHANGE, DO 'CONFIGURE BUTTON' WITH THE CURRENT CONFIGURATION

        private APCInputDevice conf;
        public AssignHotkey(string name)
        {
            InitializeComponent();
            this.Text = name;
            this.conf = APCListener.GetOrCreateConf(name);
            //populate defaults
            if (((APCButton)conf).Transitions.ContainsKey(lookup.evnt(conf.type, "OFF")))
            {
                var pressTransition = ((APCButton)conf).Transitions[lookup.evnt(conf.type, "OFF")];
                if (pressTransition.Hotkey.HasValue)
                {
                    charKey.SelectedText = pressTransition.Hotkey.Value.mod1.Value.label;
                    if (pressTransition.Hotkey.Value.mod1.HasValue) mod1.SelectedText = pressTransition.Hotkey.Value.mod1.Value.label;
                    if (pressTransition.Hotkey.Value.mod2.HasValue) mod2.SelectedText = pressTransition.Hotkey.Value.mod2.Value.label;
                }
            }
            //add options
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
