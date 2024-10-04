namespace HDD_Interface_ThamSo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            MyClass myClass = new MyClass();
            MessageBox.Show(myClass.PrintOut("Object"));
            IIfc1 ifc1 = (IIfc1)myClass;
            MessageBox.Show(ifc1.PrintOut("Salala"));
        }
    }
}
