using WindowsInput;
using VKC = WindowsInput.Native.VirtualKeyCode;

namespace APC_Mini_Remapper
{
    public partial class AssignHotkey : Form
    {
        List<KeyId> charKeys = new List<KeyId>() {
            new KeyId("NONE", VKC.SPACE),
            new KeyId("SPACE", VKC.SPACE),
            new KeyId("A", VKC.VK_A),
            new KeyId("B", VKC.VK_B),
            new KeyId("C", VKC.VK_C),
            new KeyId("D", VKC.VK_D),
            new KeyId("E", VKC.VK_E),
            new KeyId("F", VKC.VK_F),
            new KeyId("G", VKC.VK_G),
            new KeyId("H", VKC.VK_H),
            new KeyId("I", VKC.VK_I),
            new KeyId("J", VKC.VK_J),
            new KeyId("K", VKC.VK_K),
            new KeyId("L", VKC.VK_L),
            new KeyId("M", VKC.VK_M),
            new KeyId("N", VKC.VK_N),
            new KeyId("O", VKC.VK_O),
            new KeyId("P", VKC.VK_P),
            new KeyId("Q", VKC.VK_Q),
            new KeyId("R", VKC.VK_R),
            new KeyId("S", VKC.VK_S),
            new KeyId("T", VKC.VK_T),
            new KeyId("U", VKC.VK_U),
            new KeyId("V", VKC.VK_V),
            new KeyId("W", VKC.VK_W),
            new KeyId("X", VKC.VK_X),
            new KeyId("Y", VKC.VK_Y),
            new KeyId("Z", VKC.VK_Z),
            new KeyId("0", VKC.VK_0),
            new KeyId("1", VKC.VK_1),
            new KeyId("2", VKC.VK_2),
            new KeyId("3", VKC.VK_3),
            new KeyId("4", VKC.VK_4),
            new KeyId("5", VKC.VK_5),
            new KeyId("6", VKC.VK_6),
            new KeyId("7", VKC.VK_7),
            new KeyId("8", VKC.VK_8),
            new KeyId("9", VKC.VK_9),
            new KeyId("UP", VKC.UP),
            new KeyId("DOWN", VKC.DOWN),
            new KeyId("RIGHT", VKC.RIGHT),
            new KeyId("LEFT", VKC.LEFT),
            new KeyId("MUTE", VKC.VOLUME_MUTE),
            new KeyId("VOLUME DOWN", VKC.VOLUME_DOWN),
            new KeyId("VOLUME UP", VKC.VOLUME_UP),
            new KeyId("PLAY/PAUSE", VKC.MEDIA_PLAY_PAUSE),
            new KeyId("STOP", VKC.MEDIA_STOP),
            new KeyId("NEXT", VKC.MEDIA_NEXT_TRACK),
            new KeyId("PREV", VKC.MEDIA_PREV_TRACK),
            new KeyId("TAB", VKC.TAB)
        };

        List<KeyId> modKeys = new List<KeyId>(){
            new KeyId("NONE", VKC.SPACE),
            new KeyId("CTRL", VKC.CONTROL),
            //new KeyId("LCTRL", VKC.LCONTROL),
            //new KeyId("RCTRL", VKC.RCONTROL),
            //new KeyId("LWIN", VKC.LWIN),
            new KeyId("WIN", VKC.RWIN),
            new KeyId("ALT", VKC.MENU),
            new KeyId("SHIFT", VKC.SHIFT),
        };
        public AssignHotkey(string name)
        {
            InitializeComponent();
            this.Text = name;
            foreach (var key in modKeys)
            {
                mod1.Items.Add(key.label);
                mod2.Items.Add(key.label);
            }

            foreach (var key in charKeys)
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
    }
}
