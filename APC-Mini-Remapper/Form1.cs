using APCmini;
namespace APC_Mini_Remapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button_Click;
            button2.Click += Button_Click;
            button3.Click += Button_Click;
            button4.Click += Button_Click;
            button5.Click += Button_Click;
            button6.Click += Button_Click;
            button7.Click += Button_Click;
            button8.Click += Button_Click;
            button9.Click += Button_Click;
            button10.Click += Button_Click;
            button11.Click += Button_Click;
            button12.Click += Button_Click;
            button13.Click += Button_Click;
            button14.Click += Button_Click;
            button15.Click += Button_Click;
            button16.Click += Button_Click;
            button17.Click += Button_Click;
            button18.Click += Button_Click;
            button19.Click += Button_Click;
            button20.Click += Button_Click;
            button21.Click += Button_Click;
            button22.Click += Button_Click;
            button23.Click += Button_Click;
            button24.Click += Button_Click;
            button25.Click += Button_Click;
            button26.Click += Button_Click;
            button27.Click += Button_Click;
            button28.Click += Button_Click;
            button29.Click += Button_Click;
            button30.Click += Button_Click;
            button31.Click += Button_Click;
            button32.Click += Button_Click;
            button33.Click += Button_Click;
            button34.Click += Button_Click;
            button35.Click += Button_Click;
            button36.Click += Button_Click;
            button37.Click += Button_Click;
            button38.Click += Button_Click;
            button39.Click += Button_Click;
            button40.Click += Button_Click;
            button41.Click += Button_Click;
            button42.Click += Button_Click;
            button43.Click += Button_Click;
            button44.Click += Button_Click;
            button45.Click += Button_Click;
            button46.Click += Button_Click;
            button47.Click += Button_Click;
            button48.Click += Button_Click;
            button49.Click += Button_Click;
            button50.Click += Button_Click;
            button51.Click += Button_Click;
            button52.Click += Button_Click;
            button53.Click += Button_Click;
            button54.Click += Button_Click;
            button55.Click += Button_Click;
            button56.Click += Button_Click;
            button57.Click += Button_Click;
            button58.Click += Button_Click;
            button59.Click += Button_Click;
            button60.Click += Button_Click;
            button61.Click += Button_Click;
            button62.Click += Button_Click;
            button63.Click += Button_Click;
            button64.Click += Button_Click;
            SHIFT.Click += Button_Click;
            STOP_ALL.Click += Button_Click;
            UNLABELLED_BOTTOM.Click += Button_Click;
            UNLABELLED_TOP.Click += Button_Click;
            SELECT.Click += Button_Click;
            MUTE.Click += Button_Click;
            REC_ARM.Click += Button_Click;
            SOLO.Click += Button_Click;
            CLIP_STOP.Click += Button_Click;
            SEND.Click += Button_Click;
            DEVICE.Click += Button_Click;
            RIGHT.Click += Button_Click;
            PAN.Click += Button_Click;
            LEFT.Click += Button_Click;
            VOLUME.Click += Button_Click;
            DOWN.Click += Button_Click;
            UP.Click += Button_Click;
        }

    private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button65_Click(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (sender is Button && ((Button)sender).Name.StartsWith("button"))
            {
                GridButtonClicked(sender, e);
            } else
            {
                OuterButtonClicked(sender, e);
            }
        }

        private void GridButtonClicked(object sender, EventArgs e)
        {
            int num = ((Button)sender).TabIndex;
            MessageBox.Show(((Button)sender).Name, num.ToString());
        }
        private void OuterButtonClicked(object sender, EventArgs e)
        {
            string lab = ((Button)sender).Name;
            MessageBox.Show(APCmini.BTNS.lookup.BtnTable.Single(kvp => kvp.Value == lab).Value);
        }
    } 
}
