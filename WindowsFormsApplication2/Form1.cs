using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        //入力する配列定義
        string[,] File1cont = new string[300, 10000];
        string[,] File2cont = new string[300, 10000];
        string[,] File3cont = new string[300, 10000];
        string[,] File4cont = new string[300, 10000];
        string[,] File5cont = new string[300, 10000];

        string plot_stock_num_string;
        int plot_stock_num_int;

        //出力する配列定義
        string[,,] recomend_stock = new string[365, 10000, 6];
        
        public Form1()
        {
            InitializeComponent();
        }

        //
        //ファイルを選択する
        //
        string Open_file()
        {
            //フォルダ選択ダイアログの初期値指定
            //string file_sel.SelectedPath = @"C:\Data\OneDrive\stock";

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();

            string folder_name = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);

            //dnameにテキストボックスのフォルダ名を入れる
            string dname = openFileDialog1.FileName;

            if (System.IO.File.Exists(dname) == false)
            {
                MessageBox.Show(dname + "が見つかりません。", "通知");
                return dname;
            }

            return dname;

        }


        //
        //ファイルを読み込む
        //
        public string[,] read_file(string dname)
        {
            int days = 1;
            int days2 = 0;
            int days3 = 1;
            int stock_num = 1;
            string[,] in_data_file_temp = new string[370, 10000];
            string[,] in_data_file = new string[370, 10000];

            System.IO.StreamReader sr = new System.IO.StreamReader(dname, Encoding.GetEncoding("Shift_JIS"));

            for (days = 1; days <= 369; days++)
            {
                if (sr.EndOfStream == false)
                {
                    //ファイル一行読み込み、カンマ区切り毎にfield[]に格納
                    string file_contents_2 = sr.ReadLine();

                    string[] fields = file_contents_2.Split(',');

                    //
                    //列方向に文字があるだけ読んで配列に格納。要素数はfileds.Length
                    //
                    for (stock_num = 0; stock_num < fields.Length; stock_num++)
                    {
                        in_data_file_temp[days, stock_num] = fields[stock_num];
                    }
                }
                else
                {
                    //最後の行まで読み終わった場合の終了処置
                    //file_contents_Box.Items.Add(days + ", " + stock_num + ", " + "EndOfStream");
                    days2 = days;
                    days = 369;
                }
            }

            //
            //列番号を銘柄番号に並び替え
            //
            for (int stock_num2 = 0; stock_num2 < 10000; stock_num2++)
            {
                for (stock_num = 0; stock_num < 10000; stock_num++)
                {
                    string stock_num_string;
                    stock_num_string = stock_num.ToString();
                    if (in_data_file_temp[1, stock_num2] == stock_num_string)
                    {
                        //stock_numと１行目が一致すれば格納
                        days3 = 1;
                        for (days = 1; days < 369; days++)
                        {
                            in_data_file[days3, stock_num] = in_data_file_temp[days, stock_num2];
                            days3 = days3 + 1;
                        }
                    }
                    else
                    {
                        //stock_numと１行目が一致しなければ空欄
                    }
                }
            }

            listBox1.Items.Add("178行目 dname = " + dname + ", days3 = " + days3 + ", days2 = " + days2 + ", ");


            //days2は年初から年末までの営業日数
            for (double n2 = 0; n2 <= 369; n2++)
            {
                if (n2 > days2 - 2)
                {
                    in_data_file[(int)n2, 0] = "end";
                    //
                    //データの最終行識別のため（2018/1/21）
                    //
                    n2 = 370;
                }
                else
                {
                    //一列目は日付ではなく、年初から年末までの営業日数正規化
                    if (n2 <= 7)
                    {
                        //
                        //銘柄番号、銘柄名の行は無視
                        //
                    }
                    else
                    {
                        double nom_day;
                        nom_day = (n2 - 8) / (double)(days2 - 10);
                        in_data_file[(int)n2, 0] = nom_day.ToString("G4");
                    }
                }
            }

            //
            //デバッグ用ファイル書き出し(in_data_file)
            //
            //
            //新たなファイルを用意する前に既存ファイル削除
            //
            System.IO.File.Delete(@dname + "_" + "_indatafile_18.csv");

            Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
            //sjisEnc = Encoding.GetEncoding("Shift_JIS");
            System.IO.StreamWriter writer = new System.IO.StreamWriter(@dname + "_" + "_indatafile_18.csv", true, sjisEnc);
            //writer = new System.IO.StreamWriter(@dname + "_" + "_indatafile.csv", true, sjisEnc);

            //
            //計算結果の書き出し
            //
            for (int n3 = 1; n3 <= days2 + 1; n3++)
            {
                for (stock_num = 0; stock_num < 10000; stock_num++)
                {
                    writer.Write(in_data_file[n3, stock_num] + ",");
                }
                writer.Write("\r\n");

            }

            writer.Close();

            //
            //ここまでファイル書き出し
            //

            return in_data_file;
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            //
            //テキストボックス内の番号読み取る。
            //
            plot_stock_num_string = textBox10.Text;
            plot_stock_num_int = Convert.ToInt16(plot_stock_num_string);
        }

        private void Compute_button_Click(object sender, EventArgs e)
        {
            double[] fileOKNG = new double[6];
            string[,,] Plot_file_cont = new string[6, 370, 10001];
            double[] days_count = new double[6];

            //
            //File1cont～File5contを見て、ファイルが有るか判断
            //ファイルが有れば、Double配列に変換
            //
            if( File1cont[1,1001] == "1001" )
            {
                fileOKNG[1] = 1;
                for( int days = 0; days < 369; days++ )
                {
                    if ( days > 7 && String.IsNullOrEmpty(File1cont[days, 0]))
                    {
                        days_count[1] = days;
                        days = 369;
                    }
                    else
                    {
                        for (int stock_num = 0; stock_num < 10000; stock_num++)
                        {
                            Plot_file_cont[1, days, stock_num] = File1cont[days, stock_num];
                        }
                    }
                }
            }
            else
            {
                fileOKNG[1] = 0;
            }

            if (File2cont[1, 1001] == "1001")
            {
                fileOKNG[2] = 1;
                for (int days = 0; days < 369; days++)
                {
                    if ( days > 7 && String.IsNullOrEmpty(File2cont[days, 0]))
                    {
                        days_count[2] = days;
                        days = 369;
                    }
                    else
                    {
                        for (int stock_num = 0; stock_num < 10000; stock_num++)
                        {
                            Plot_file_cont[2, days, stock_num] = File2cont[days, stock_num];
                        }
                    }
                }
            }
            else
            {
                fileOKNG[2] = 0;
            }

            if (File3cont[1, 1001] == "1001")
            {
                fileOKNG[3] = 1;
                for (int days = 0; days < 369; days++)
                {
                    if ( days > 7 && String.IsNullOrEmpty(File3cont[days, 0]))
                    {
                        days_count[3] = days;
                        days = 369;
                    }
                    else
                    {
                        for (int stock_num = 0; stock_num < 10000; stock_num++)
                        {
                            Plot_file_cont[3, days, stock_num] = File3cont[days, stock_num];
                        }
                    }
                }
            }
            else
            {
                fileOKNG[3] = 0;
            }

            if (File4cont[1, 1001] == "1001")
            {
                fileOKNG[4] = 1;
                for (int days = 0; days < 369; days++)
                {
                    if ( days > 7 && String.IsNullOrEmpty(File4cont[days, 0]))
                    {
                        days_count[4] = days;
                        days = 369;
                    }
                    else
                    {
                        for (int stock_num = 0; stock_num < 10000; stock_num++)
                        {
                            Plot_file_cont[4, days, stock_num] = File4cont[days, stock_num];
                        }
                    }
                }
            }
            else
            {
                fileOKNG[4] = 0;
            }

            if (File5cont[1, 1001] == "1001")
            {
                fileOKNG[5] = 1;
                for (int days = 0; days < 369; days++)
                {
                    if ( days > 7 && String.IsNullOrEmpty(File5cont[days, 0]) )
                    {
                        days_count[5] = days;
                        days = 369;
                    }
                    else
                    {
                        for (int stock_num = 0; stock_num < 10000; stock_num++)
                        {
                            Plot_file_cont[5, days, stock_num] = File5cont[days, stock_num];
                        }
                    }
                }
            }
            else
            {
                fileOKNG[5] = 0;
            }

            double[,,] plot = new double[7, 3, 370];

            double max_days_count_file = 0;
            double min_days_count_file = 370;
            double ave_days_count_file = 0;

            //
            //max_days_count_fileの探索
            //
            for(int i = 1; i < 6; i++)
            {
                if( max_days_count_file < days_count[i] )
                {
                    max_days_count_file = days_count[i];
                }
                else
                {

                }
            }

            //
            //min_days_count_fileの探索
            //
            for (int i = 1; i < 6; i++)
            {
                if(fileOKNG[i] == 1)
                {
                    if (min_days_count_file > days_count[i])
                    {
                        min_days_count_file = days_count[i];
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }

            //
            //ave_days_count_fileの探索
            //
            double file_OKNG = 0;

            for (int i = 1; i < 6; i++)
            {
                ave_days_count_file = ave_days_count_file + days_count[i];
                file_OKNG = file_OKNG + fileOKNG[i];
            }
            ave_days_count_file = ave_days_count_file / file_OKNG;

            //
            //データプロット
            //
            Form2 form2 = new Form2();
            form2.Show();

            for (int i = 1; i < 6; i++)
            {
                if (fileOKNG[i] == 1)
                {
                    if( days_count[i] < 240 )
                    {
                        days_count[i] = max_days_count_file;
                    }
                    else
                    {

                    }

                    for (int j = 8; j <= days_count[i]; j++)
                    {
                        plot[i, 1, j] = (j - 8) / (days_count[i] - 10);
                        if (String.IsNullOrEmpty(Plot_file_cont[i, j, plot_stock_num_int]))
                        {
                            plot[i, 2, j] = plot[i, 2, (j - 1)];
                            //plot[i, 2, j] = Convert.ToDouble(Plot_file_cont[i, (j - 1), plot_stock_num_int]);

                            //listBox1.Items.Add("431行目 plot[i, 1, j] = " + plot[i, 1, j] + ", plot[i, 2, j] = " + plot[i, 2, j] + ", ");
                        }
                        else
                        {
                            plot[i, 2, j] = Convert.ToDouble(Plot_file_cont[i, j, plot_stock_num_int]);

                            //listBox1.Items.Add("437行目 plot[i, 1, j] = " + plot[i, 1, j] + ", plot[i, 2, j] = " + plot[i, 2, j] + ", ");
                        }

                        //listBox1.Items.Add("407行目 days_count[i] = " + days_count[i] + ", i =" + i + ", j = " + j + ", ");
                        //listBox1.Items.Add("408行目 plot[i, 1, j] = " + plot[i, 1, j] + " , plot[i, 2, j] = " + plot[i, 2, j] + ", ");

                        //listBox1.Items.Add("443行目 max_days_count_file = " + max_days_count_file + ", ");
                        //listBox1.Items.Add("444行目 days_count[i] = " + days_count[i] + ", ");
                    }
                    form2.Form2_plot(plot, (days_count[i] - 8), Plot_file_cont[1, 1, plot_stock_num_int], Plot_file_cont[1, 2, plot_stock_num_int], fileOKNG);
                }
                else
                {

                }
            }
        }

        private void File1_sel_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void File2_sel_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void File3_sel_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void File4_sel_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void File5_sel_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void File1_sel_button_Click(object sender, EventArgs e)
        {
            string File1;
            File1 = Open_file();

            //テキストボックスに選択したファイル名を表示する
            File1_sel_Box.Text = File1;

            //ファイルを読み込む
            //string[,] File1cont = new string[300, 5000];
            File1cont = read_file(File1);
        }

        private void File2_sel_button_Click(object sender, EventArgs e)
        {
            string File2;
            File2 = Open_file();

            //テキストボックスに選択したファイル名を表示する
            File2_sel_Box.Text = File2;

            //ファイルを読み込む
            //string[,] File2cont = new string[300, 5000];
            File2cont = read_file(File2);
        }

        private void File3_sel_button_Click(object sender, EventArgs e)
        {
            string File3;
            File3 = Open_file();

            //テキストボックスに選択したファイル名を表示する
            File3_sel_Box.Text = File3;

            //ファイルを読み込む
            //string[,] File3cont = new string[300, 5000];
            File3cont = read_file(File3);
        }

        private void File4_sel_button_Click(object sender, EventArgs e)
        {
            string File4;
            File4 = Open_file();

            //テキストボックスに選択したファイル名を表示する
            File4_sel_Box.Text = File4;

            //ファイルを読み込む
            //string[,] File4cont = new string[300, 5000];
            File4cont = read_file(File4);
        }

        private void File5_sel_button_Click(object sender, EventArgs e)
        {
            string File5;
            File5 = Open_file();

            //テキストボックスに選択したファイル名を表示する
            File5_sel_Box.Text = File5;

            //ファイルを読み込む
            //string[,] File5cont = new string[300, 5000];
            File5cont = read_file(File5);
        }

        private void Quit_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("終了します。", "通知");
            //アプリケーションを終了する。
            Application.Exit();
        }
    }
}
