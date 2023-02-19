using System.Drawing.Text;
using static System.Net.Mime.MediaTypeNames;

namespace WordPad_Killer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        List<int> font_size = new() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };

    private void Form1_Load(object sender, EventArgs e)
        {
            //WebClient wc = new WebClient();
            //var bytes = wc.DownloadData("https://en.wikipedia.org/wiki/Main_Page");
            //var str = Encoding.Default.GetString(bytes);
            //File.WriteAllText("site.txt",str);
            //cmB_font.Items.AddRange(Font.ToString().ToArray>());

            foreach (var item in FontFamily.Families)
            {
                cmB_font.Items.Add(item.Name);
            }

            foreach (var item in font_size)
            {
                cmB_fontSize.Items.Add(item);
            }


            cmB_color.DataSource = typeof(Color).GetProperties().Where(x => x.PropertyType == typeof(Color)).Select(x => x.GetValue(null)).ToList();//internetden goturmuwem,ozum texmini bawa duwdum amma tam tuta bilmedim ,sorry :( ;
            richTextBox1.ForeColor = Color.Black;
        }

        private void cmB_font_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(cmB_font.SelectedItem.ToString()??richTextBox1.Font.Name ,richTextBox1.Font.Size);
          
        }

        private void cmB_fontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            float size = Convert.ToSingle(((ComboBox)sender).Text);

            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, size);
           
        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily,richTextBox1.Font.Size,FontStyle.Bold);
        }

        private void cmB_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmB_color.SelectedIndex >= 0)
                richTextBox1.ForeColor = (Color)cmB_color.SelectedValue;
        }

        private void btn_U_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Underline);
        }

        private void bnt_3_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Italic);
        }

        private void btn_L_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btn_R_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void tb_Load_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void tb_save_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            if (tb_Load.TextLength > 0)
            {openFileDialog1.FileName = tb_Load.Text;
                try
                {
                    richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                   
                }
                catch (Exception)
                {

                    MessageBox.Show("File Tapilmadi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                openFileDialog1.Filter = "All Files |*.*|Text Files | *.txt";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                    tb_Load.Text = openFileDialog1.FileName;
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = tb_save.Text;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                MessageBox.Show("File Save olundu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_save.Text = null;
                tb_Load.Text = null;
                richTextBox1.Text = null;
            }
        }
    }
}