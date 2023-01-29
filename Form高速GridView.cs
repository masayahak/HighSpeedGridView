using GridPager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModel;

namespace 高速GridView
{
    public partial class Form高速GridView : Form
    {
        private VM売上 vm売上;

        public Form高速GridView()
        {
            InitializeComponent();

            dtp開始.Value = new DateTime(2022, 1, 1, 0, 0, 0, DateTimeKind.Local);
            dtp終了.Value = new DateTime(2022, 12, 31, 0, 0, 0, DateTimeKind.Local);
        }

        private void Form高速GridView_Load(object sender, EventArgs e)
        {
            // DataGirdViewのパフォーマンス・チューニング
            InitDataGridView();

            panelロード中.Visible = false;
            panel進捗.Visible = false;
        }

        // ----------------------------------------------------------------
        // GridView 高速化用の設定
        // ----------------------------------------------------------------
        private void InitDataGridView()
        {
            Type dgvtype = typeof(DataGridView);

            // プロパティ設定の取得
            System.Reflection.PropertyInfo dgvPropertyInfo =
                dgvtype.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance
                | System.Reflection.BindingFlags.NonPublic);
            dgvPropertyInfo.SetValue(dataGridView, true, null);

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView.RowHeadersVisible = false;
        }


        private void btn検索_Click(object sender, EventArgs e)
        {

            // 計測対象の処理
            DataLoad();

        }

        // ----------------------------------------------------------------
        // データ読み込み
        // ----------------------------------------------------------------

        private async void DataLoad()
        {

            // ----------------------------
            // 実行経過パネルを表示する。            
            // ----------------------------
            Show進捗();
            textBox進捗.Text = "";

            this.lbl件数.Text = string.Format("検索中");

            panelロード中.Visible = true;

            // ----------------------------
            // 処理開始メッセージ
            // ----------------------------
            textBox進捗.AppendText("■■■ 処理を開始 ■■■");
            textBox進捗.AppendText(Environment.NewLine);

            vm売上 = new VM売上();

            DateTime 期間開始 = this.dtp開始.Value.Date;
            DateTime 期間終了 = this.dtp終了.Value.Date;

            // =======================================================
            // 非同期でデータ取得
            // =======================================================
            var 売上s = new List<T売上>();

            // Stopwatchクラス生成
            var sw = new System.Diagnostics.Stopwatch();
            // 計測開始
            sw.Start();

            // ------------ 計測処理 ---------------
            await Task.Run(() =>
            {
                vm売上.LoadT売上(期間開始, 期間終了);
                売上s = vm売上.Get売上s();
            });

            // 計測停止
            sw.Stop();


            // 件数の表示
            var 件数表示 = 売上s.Count().ToString("#,##0 件");
            this.lbl件数.Text = 件数表示;
            textBox進捗.AppendText("DBからの取得件数: " + 件数表示);
            textBox進捗.AppendText(Environment.NewLine);

            var DBの時間 = Math.Round(sw.Elapsed.TotalMilliseconds / 1000, 3);
            textBox進捗.AppendText($"●DBから取得するための時間");
            textBox進捗.AppendText(Environment.NewLine);

            textBox進捗.AppendText($" ＝ {DBの時間}秒");
            textBox進捗.AppendText(Environment.NewLine);

            // 計測開始
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            // ------------ 計測処理 ---------------
            // 取得したデータをGridへ表示
            BindingSource bs = new BindingSource();
            bs.DataSource = 売上s;
            dataGridView.DataSource = bs;

            // 計測停止
            sw.Stop();

            var Grid表示の時間 = Math.Round(sw.Elapsed.TotalMilliseconds / 1000, 3);
            textBox進捗.AppendText($"●Gridへ表示するための時間");
            textBox進捗.AppendText(Environment.NewLine);
            textBox進捗.AppendText($" ＝ {Grid表示の時間}秒");
            textBox進捗.AppendText(Environment.NewLine);


            // 見栄えの調整
            Grid列幅調整();

            panelロード中.Visible = false;

            textBox進捗.AppendText("─── 処理を終了 ───");
            textBox進捗.AppendText(Environment.NewLine);
        }

        private void Grid列幅調整()
        {
            // 列幅の設定:
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                if (column.ValueType == typeof(int))
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (column.ValueType == typeof(DateTime))
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }

        private void button閉じる_Click(object sender, EventArgs e)
        {
            panel進捗.Visible = false;
        }

        private void button進捗_Click(object sender, EventArgs e)
        {
            Show進捗();
        }

        private void Show進捗()
        {
            panel進捗.Visible = true;
            panel進捗.BringToFront();
        }

    }
}
