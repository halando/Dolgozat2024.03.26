using System.Windows.Forms;

namespace Kolcsonzesek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeButtons();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox1 = new ListBox();
            listBox1.Items.AddRange(new object[] { });
            listBox1.SelectedIndexChanged += ListBox_SelectedIndexChanged;
            listBox1.Dock = DockStyle.Left;
            listBox1.Width = 150;

            ListBox listBoxBooks = new ListBox();
            listBoxBooks.Dock = DockStyle.Fill;

            Controls.Add(listBox1);
            Controls.Add(listBoxBooks);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox1 = (ListBox)sender;
            ListBox listBoxBooks = Controls[1] as ListBox;
            listBoxBooks.Items.Clear();

            
            if (listBox1.SelectedIndex != -1)
            {
                listBoxBooks.Items.Add("Book 1");
                listBoxBooks.Items.Add("Book 2");
                listBoxBooks.Items.Add("Book 3");
            }

            Button buttonReturn = Controls[3] as Button;
            buttonReturn.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListBox listBoxBooks = Controls[1] as ListBox;
            if (listBoxBooks.SelectedIndex != -1)
            {
                listBoxBooks.Items.RemoveAt(listBoxBooks.SelectedIndex);
        
            }

            Button buttonReturn = (Button)sender;
            buttonReturn.Enabled = false;
        }
    }

    private void InitializeButtons()
    {
        // Gombok inicializálása
        Button buttonReturn = new Button();
        buttonReturn.Text = "Visszahozva";
        buttonReturn.Dock = DockStyle.Bottom;
        buttonReturn.Enabled = false;
        buttonReturn.Click += ButtonReturn_Click;

        Button buttonClose = new Button();
        buttonClose.Text = "Bezar";
        buttonClose.Dock = DockStyle.Bottom;
        buttonClose.Click += ButtonClose_Click;

        Controls.Add(buttonReturn);
        Controls.Add(buttonClose);
    }




}