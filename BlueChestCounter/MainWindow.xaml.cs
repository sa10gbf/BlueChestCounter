using BlueChestCounter.Properties;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static BlueChestCounter.MainWindow;

namespace BlueChestCounter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        float blueChestCount;
        float blueChestPercentage;
        float noBlueChestCount;
        float coronationRingCount;
        float coronationRingPercentage;
        float lineageRingCount;
        float lineageRingPercentage;
        float intricacyRingCount;
        float intricacyRingPercentage;
        float hihiCount;
        float hihiPercentage;
        float totalFight;
        float todaytotalfight;
        List<String> goldBarRecords = new List<string>();
        float totalCoronationRingCount;
        float totalLineageRingCount;
        float totalIntricacyRingCount;
        float totalGoldBarCount;
        float totalBlueChestCount;
        float totalCoronationRingPercentage;
        float totalLineageRingPercentage;
        float totalIntricacyRingPercentage;
        float totalGoldBarPercentage;
        float totalBlueChestPercentage;
        float overallFight;
        String lastGoldBarDate;

        public MainWindow()
        {
            InitializeComponent();
        }


        public void GetListSetting()
        {

            if (Properties.Settings.Default.GoldBarRecords != null)
            {
                StringCollection goldBarRecordsCollection = new StringCollection();
                goldBarRecordsCollection = Properties.Settings.Default.GoldBarRecords;
                goldBarRecords = goldBarRecordsCollection.Cast<string>().ToList();
                foreach (var item in goldBarRecords)
                {
                    GoldBarRecord.Items.Add(item);
                }

            }
        }

        public void GetSetting()
        {
            hihiCount = Properties.Settings.Default.GoldBar;
            hihiPercentage = Properties.Settings.Default.GoldBarPercentage;
            coronationRingCount = Properties.Settings.Default.CoronationRing;
            coronationRingPercentage = Properties.Settings.Default.CoronationRingPercentage;
            lineageRingCount = Properties.Settings.Default.LineageRing;
            lineageRingPercentage = Properties.Settings.Default.LineageRingPercentage;
            intricacyRingCount = Properties.Settings.Default.IntricacyRing;
            intricacyRingPercentage = Properties.Settings.Default.IntricacyRingPercentage;
            blueChestCount = Properties.Settings.Default.BlueChest;
            blueChestPercentage = Properties.Settings.Default.BlueChestPercentage;
            noBlueChestCount = Properties.Settings.Default.NoBlueChestCount;
            totalFight = Properties.Settings.Default.TotalFight;
            todaytotalfight = Properties.Settings.Default.TodayTotalFight;
            totalCoronationRingCount = Properties.Settings.Default.TotalCoronationRing;
            totalLineageRingCount = Properties.Settings.Default.TotalLineageRing;
            totalIntricacyRingCount = Properties.Settings.Default.TotalIntricacyRing;
            totalGoldBarCount = Properties.Settings.Default.TotalGoldBar;
            totalBlueChestCount = Properties.Settings.Default.TotalBlueChest;
            lastGoldBarDate = Properties.Settings.Default.LastGoldBarDate;
            totalCoronationRingPercentage = Properties.Settings.Default.TotalCoronationRingP;
            totalLineageRingPercentage = Properties.Settings.Default.TotalLineageRingP;
            totalIntricacyRingPercentage = Properties.Settings.Default.TotalIntricacyRingP;
            totalGoldBarPercentage = Properties.Settings.Default.TotalGoldBarP;
            totalBlueChestPercentage = Properties.Settings.Default.TotalBlueChestP;
            overallFight = Properties.Settings.Default.OverallFight;

            Total.Content = totalFight;
            TodayFightCount.Content = todaytotalfight;
            LastGoldBarDate.Content = lastGoldBarDate;
            TotalCoronationRingCount.Content = totalCoronationRingCount;
            TotalLineageRingCount.Content = totalLineageRingCount;
            TotalIntricacyRingCount.Content = totalIntricacyRingCount;
            TotalGoldBarCount.Content = totalGoldBarCount;
            TotalBlueChestCount.Content = totalBlueChestCount;

            TotalCoronationRingPercentage.Content = (totalCoronationRingPercentage * 100).ToString("0.00") + "%";
            TotalLineageRingPercentage.Content = (totalLineageRingPercentage * 100).ToString("0.00") + "%";
            TotalIntricacyRingPercentage.Content = (totalIntricacyRingPercentage * 100).ToString("0.00") + "%";
            TotalGoldBarPercentage.Content = (totalGoldBarPercentage * 100).ToString("0.00") + "%";
            TotalBlueChestPercentage.Content = (totalBlueChestPercentage * 100).ToString("0.00") + "%";

            ///////////////CoronationRing
            CoronationRingCount.Content = coronationRingCount;
            if(coronationRingCount == 0 || blueChestCount == 0)
            {
                CoronationRingCounttPercentage.Content = "0.00%";
            }
            else
            {
                CoronationRingCounttPercentage.Content = (coronationRingPercentage * 100).ToString("0.00") + "%";
            }
            ////////////LineageRing
            LineageRingCount.Content = lineageRingCount;
            if(lineageRingCount == 0 || blueChestCount == 0)
            {
                LineageRingCountPercentage.Content = "0.00%";
            }
            else
            {
                LineageRingCountPercentage.Content = (lineageRingPercentage * 100).ToString("0.00") + "%";
            }
            ////////////IntricacyRing
            IntricacyRingCount.Content = intricacyRingCount;
            if(intricacyRingCount == 0 || blueChestCount == 0)
            {
                IntricacyRingCountPercentage.Content = "0.00%";
            }
            else
            {
                IntricacyRingCountPercentage.Content = (intricacyRingPercentage * 100).ToString("0.00") + "%";
            }
            //////////GoldBar
            GoldBarCount.Content = hihiCount;
            if (hihiCount == 0 || blueChestCount == 0)
            {
                GoldBarCountPercentage.Content = "0.00%";
            }
            else
            {
                GoldBarCountPercentage.Content = (hihiPercentage * 100).ToString("0.00") + "%";
            }
            //////////BlueChest
            BlueChestCount.Content = blueChestCount;
            NoBlueChestCount.Content = noBlueChestCount;
            if (noBlueChestCount != 0)
            {

                BlueChestCountPercentage.Content = (blueChestPercentage * 100).ToString("0.00") + "%";
            }
            else if ((hihiCount > 0 || coronationRingCount > 0 || lineageRingCount > 0 || intricacyRingCount > 0) && noBlueChestCount == 0)
            {
                BlueChestCountPercentage.Content = "100%";
            }
            else
            {
                BlueChestCountPercentage.Content = "0%";
            }

        }

        public void SaveSetting()
        {
            Properties.Settings.Default.GoldBar = hihiCount;
            Properties.Settings.Default.GoldBarPercentage = hihiPercentage;
            Properties.Settings.Default.CoronationRing = coronationRingCount;
            Properties.Settings.Default.CoronationRingPercentage = coronationRingPercentage;
            Properties.Settings.Default.LineageRing = lineageRingCount;
            Properties.Settings.Default.LineageRingPercentage = lineageRingPercentage;
            Properties.Settings.Default.IntricacyRing = intricacyRingCount;
            Properties.Settings.Default.IntricacyRingPercentage = intricacyRingPercentage;
            Properties.Settings.Default.BlueChest = blueChestCount;
            Properties.Settings.Default.BlueChestPercentage = blueChestPercentage;
            Properties.Settings.Default.NoBlueChestCount = noBlueChestCount;
            Properties.Settings.Default.TotalFight = totalFight;
            Properties.Settings.Default.TodayTotalFight = todaytotalfight;
            Properties.Settings.Default.TotalCoronationRing = totalCoronationRingCount;
            Properties.Settings.Default.TotalLineageRing = totalLineageRingCount;
            Properties.Settings.Default.TotalIntricacyRing = totalIntricacyRingCount;
            Properties.Settings.Default.TotalGoldBar = totalGoldBarCount;
            Properties.Settings.Default.TotalBlueChest = totalBlueChestCount;
            Properties.Settings.Default.LastGoldBarDate = lastGoldBarDate;
            Properties.Settings.Default.TotalCoronationRingP = totalCoronationRingPercentage;
            Properties.Settings.Default.TotalLineageRingP = totalLineageRingPercentage;
            Properties.Settings.Default.TotalIntricacyRingP = totalIntricacyRingPercentage;
            Properties.Settings.Default.TotalGoldBarP = totalGoldBarPercentage;
            Properties.Settings.Default.TotalBlueChestP = totalBlueChestPercentage;
            Properties.Settings.Default.OverallFight = overallFight;


            StringCollection goldBarRecordsCollection = new StringCollection();
            goldBarRecordsCollection.AddRange(goldBarRecords.ToArray());
            Properties.Settings.Default.GoldBarRecords = goldBarRecordsCollection;

            Properties.Settings.Default.Save();
        }

        private void noBlueChest_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            noBlueChestCount++;
            totalFight++;
            todaytotalfight++;
            NoBlueChestCount.Content = noBlueChestCount.ToString();
            blueChestPercentage = (blueChestCount / totalFight);
            Total.Content = totalFight;

            SaveSetting();
            GetSetting();
        }

        private void coronationRing_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            coronationRingCount++;
            totalFight++;
            CoronationRingCount.Content = coronationRingCount.ToString();
            todaytotalfight++;
            blueChestCount++;
            BlueChestCount.Content = blueChestCount.ToString();
            Total.Content = totalFight;
            coronationRingPercentage = (coronationRingCount / blueChestCount);
            lineageRingPercentage = (lineageRingCount / blueChestCount);
            intricacyRingPercentage = (intricacyRingCount / blueChestCount);
            hihiPercentage = (hihiCount / blueChestCount);

            blueChestPercentage = (blueChestCount / totalFight);

            SaveSetting();
            GetSetting();
        }

        private void lineageRing_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lineageRingCount++;
            totalFight++;
            LineageRingCount.Content = lineageRingCount.ToString();
            todaytotalfight++;
            blueChestCount++;
            BlueChestCount.Content = blueChestCount.ToString();
            Total.Content = totalFight;
            coronationRingPercentage = (coronationRingCount / blueChestCount);
            lineageRingPercentage = (lineageRingCount / blueChestCount);
            intricacyRingPercentage = (intricacyRingCount / blueChestCount);
            hihiPercentage = (hihiCount / blueChestCount);

            blueChestPercentage = (blueChestCount / totalFight);

            SaveSetting();
            GetSetting();
        }

        private void intricacyRing_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            intricacyRingCount++;
            totalFight++;
            IntricacyRingCount.Content = intricacyRingCount.ToString();
            todaytotalfight++;
            blueChestCount++;
            BlueChestCount.Content = blueChestCount.ToString();
            Total.Content = totalFight;
            coronationRingPercentage = (coronationRingCount / blueChestCount);
            lineageRingPercentage = (lineageRingCount / blueChestCount);
            intricacyRingPercentage = (intricacyRingCount / blueChestCount);
            hihiPercentage = (hihiCount / blueChestCount);

            blueChestPercentage = (blueChestCount / totalFight);

            SaveSetting();
            GetSetting();
        }

        private void goldBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            hihiCount++;
            totalFight++;
            GoldBarCount.Content = hihiCount.ToString();
            todaytotalfight++;
            blueChestCount++;
            BlueChestCount.Content = blueChestCount.ToString();
            Total.Content = totalFight;
            coronationRingPercentage = (coronationRingCount / blueChestCount);
            lineageRingPercentage = (lineageRingCount / blueChestCount);
            intricacyRingPercentage = (intricacyRingCount / blueChestCount);
            hihiPercentage = (hihiCount / blueChestCount);

            blueChestPercentage = (blueChestCount / totalFight);

            SaveSetting();
            GetSetting();
        }

        private void coronationRing_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(coronationRingCount > 0)
            {
                coronationRingCount--;
                totalFight--;
                blueChestCount--;
            }
            if (todaytotalfight > 0){
                todaytotalfight--;
            }

            CoronationRingCount.Content = coronationRingCount.ToString();
            Total.Content = totalFight;
            BlueChestCount.Content = blueChestCount.ToString();

            coronationRingPercentage = (coronationRingCount / blueChestCount);
            lineageRingPercentage = (lineageRingCount / blueChestCount);
            intricacyRingPercentage = (intricacyRingCount / blueChestCount);
            hihiPercentage = (hihiCount / blueChestCount);

            blueChestPercentage = (blueChestCount / totalFight);

            SaveSetting();
            GetSetting();
        }

        private void lineageRing_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(lineageRingCount > 0)
            {
                lineageRingCount--;
                totalFight--;
                blueChestCount--;
            }
            if (todaytotalfight > 0)
            {
                todaytotalfight--;
            }

            LineageRingCount.Content = lineageRingCount.ToString();
            Total.Content = totalFight;
            BlueChestCount.Content = blueChestCount.ToString();

            coronationRingPercentage = (coronationRingCount / blueChestCount);
            lineageRingPercentage = (lineageRingCount / blueChestCount);
            intricacyRingPercentage = (intricacyRingCount / blueChestCount);
            hihiPercentage = (hihiCount / blueChestCount);

            blueChestPercentage = (blueChestCount / totalFight);

            SaveSetting();
            GetSetting();
        }

        private void intricacyRing_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

            if(intricacyRingCount > 0)
            {
                intricacyRingCount--;
                totalFight--;
                blueChestCount--;
            }
            if (todaytotalfight > 0)
            {
                todaytotalfight--;
            }

            IntricacyRingCount.Content = intricacyRingCount.ToString();
            Total.Content = totalFight;
            BlueChestCount.Content = blueChestCount.ToString();

            coronationRingPercentage = (coronationRingCount / blueChestCount);
            lineageRingPercentage = (lineageRingCount / blueChestCount);
            intricacyRingPercentage = (intricacyRingCount / blueChestCount);
            hihiPercentage = (hihiCount / blueChestCount);

            blueChestPercentage = (blueChestCount / totalFight);

            SaveSetting();
            GetSetting();
        
        }

        private void goldBar_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(hihiCount > 0)
            {
                hihiCount--;
                totalFight--;
                blueChestCount--;
            }
            if (todaytotalfight > 0)
            {
                todaytotalfight--;
            }
            GoldBarCount.Content = hihiCount.ToString();
            Total.Content = totalFight;
            BlueChestCount.Content = blueChestCount.ToString();

            coronationRingPercentage = (coronationRingCount / blueChestCount);
            lineageRingPercentage = (lineageRingCount / blueChestCount);
            intricacyRingPercentage = (intricacyRingCount / blueChestCount);
            hihiPercentage = (hihiCount / blueChestCount);

            blueChestPercentage = (blueChestCount / totalFight);

            SaveSetting();
            GetSetting();
        }

        private void PushGoldBar_Click(object sender, RoutedEventArgs e)
        {
            if (hihiCount == 1)
            {
                lastGoldBarDate = DateTime.Now.ToString("d");
                var blueChestNumber = blueChestCount.ToString();
                LastGoldBarDate.Content = lastGoldBarDate;
                String record = lastGoldBarDate + "          " + blueChestNumber + " blue chest " + "          " + totalFight.ToString() + " battles";
                goldBarRecords.Add(record);
                GoldBarRecord.Items.Clear();

                totalCoronationRingCount = totalCoronationRingCount + coronationRingCount;
                totalLineageRingCount = totalLineageRingCount + lineageRingCount;
                totalIntricacyRingCount = totalIntricacyRingCount + intricacyRingCount;
                totalGoldBarCount = totalGoldBarCount + hihiCount;
                totalBlueChestCount = totalBlueChestCount + blueChestCount;
                overallFight = overallFight + totalFight;

                totalCoronationRingPercentage = totalCoronationRingCount / totalBlueChestCount;
                totalLineageRingPercentage = totalLineageRingCount / totalBlueChestCount;
                totalIntricacyRingPercentage = totalIntricacyRingCount / totalBlueChestCount;
                totalGoldBarPercentage = totalGoldBarCount / totalBlueChestCount;
                totalBlueChestPercentage = totalBlueChestCount / overallFight;

                TotalCoronationRingCount.Content = totalCoronationRingCount.ToString();
                TotalLineageRingCount.Content = totalLineageRingCount.ToString();
                TotalIntricacyRingCount.Content = totalIntricacyRingCount.ToString();
                TotalGoldBarCount.Content = totalGoldBarCount.ToString();
                TotalBlueChestCount.Content = totalBlueChestCount.ToString();

                TotalCoronationRingPercentage.Content = (totalCoronationRingPercentage * 100).ToString("0.00") + "%";
                TotalLineageRingPercentage.Content = (totalLineageRingPercentage * 100).ToString("0.00") + "%";
                TotalIntricacyRingPercentage.Content = (totalIntricacyRingPercentage * 100).ToString("0.00") + "%";
                TotalGoldBarPercentage.Content = (totalGoldBarPercentage * 100).ToString("0.00") + "%";
                TotalBlueChestPercentage.Content = (totalBlueChestPercentage * 100).ToString("0.00") + "%";

                blueChestCount = 0;
                noBlueChestCount = 0;
                coronationRingCount = 0;
                lineageRingCount = 0;
                intricacyRingCount = 0;
                hihiCount = 0;
                totalFight = 0;
                BlueChestCount.Content = blueChestCount.ToString();
                NoBlueChestCount.Content = noBlueChestCount.ToString();
                CoronationRingCount.Content = coronationRingCount.ToString();
                LineageRingCount.Content = lineageRingCount.ToString();
                IntricacyRingCount.Content = intricacyRingCount.ToString();
                GoldBarCount.Content = hihiCount.ToString();
                LineageRingCountPercentage.Content = "0%";
                CoronationRingCounttPercentage.Content = "0%";
                IntricacyRingCountPercentage.Content = "0%";
                GoldBarCountPercentage.Content = "0%";
                BlueChestCountPercentage.Content = "0%";
                Total.Content = totalFight;

                SaveSetting();
                GetListSetting();
            }
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            GetSetting();
            
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            todaytotalfight = 0;
            SaveSetting();
            GetSetting();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            //GoldBarRecord.DataSource = null;
            GoldBarRecord.Items.Clear();
            goldBarRecords = new List<String>();
            blueChestCount = 0;
            blueChestPercentage = 0;
            noBlueChestCount = 0;
            coronationRingCount = 0;
            coronationRingPercentage = 0;
            lineageRingCount = 0;
            lineageRingPercentage = 0;
            intricacyRingCount = 0;
            intricacyRingPercentage = 0;
            hihiCount = 0;
            hihiPercentage = 0;
            totalFight = 0;
            todaytotalfight = 0;
            totalCoronationRingCount = 0;
            totalLineageRingCount = 0;
            totalIntricacyRingCount = 0;
            totalGoldBarCount = 0;
            totalBlueChestCount = 0;
            totalCoronationRingPercentage = 0;
            totalLineageRingPercentage = 0;
            totalIntricacyRingPercentage = 0;
            totalGoldBarPercentage = 0;
            totalBlueChestPercentage = 0;
            overallFight = 0;
            lastGoldBarDate = null;
            SaveSetting();
            GetSetting();
        }

        private void noBlueChest_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (noBlueChestCount > 0)
            {
                noBlueChestCount--;
                totalFight--;
            }
            if (todaytotalfight > 0)
            {
                todaytotalfight--;
            }

            NoBlueChestCount.Content = noBlueChestCount.ToString();
            blueChestPercentage = (blueChestCount / totalFight);
            Total.Content = totalFight;
            SaveSetting();
            GetSetting();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GetListSetting();
        }
    }
}
