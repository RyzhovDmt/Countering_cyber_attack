using System;
using System.Collections.Generic;
using System.Linq;
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
using OxyPlot;

namespace Countering_cyber_attack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel vm = new MainViewModel();
        private MainViewModel viewModel;
        public double s1 = 0;
        public bool ex1 = true, lang_ru = true;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new MainViewModel();

            DataContext = viewModel;
        }
        public void GetVal()
        {

        }
        private void slValue1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((Slider)sender).SelectionEnd = e.NewValue;
            viewModel.refresh_params(1, e.NewValue);
            viewModel.rebuild_graph(lang_ru);
            viewModel.MyModel.InvalidatePlot(true);
            textblock1.Text = viewModel.make_comment(2, e.NewValue, lang_ru);
            textblock1.Foreground = viewModel.calc_color(2, e.NewValue);
            //oxPlot.InvalidatePlot(true);
            //this.PlotView.InvalidatePlot(true);
            //if (e.NewValue>5)

        }

        private void slValue2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((Slider)sender).SelectionEnd = e.NewValue;
            viewModel.refresh_params(2, e.NewValue);
            viewModel.rebuild_graph(lang_ru);
            viewModel.MyModel.InvalidatePlot(true);
            textblock1.Text = viewModel.make_comment(1, e.NewValue, lang_ru);
            textblock1.Foreground = viewModel.calc_color(1, e.NewValue);
        }

        private void slValue3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((Slider)sender).SelectionEnd = e.NewValue;
            viewModel.refresh_params(3, e.NewValue);
            viewModel.rebuild_graph(lang_ru);
            viewModel.MyModel.InvalidatePlot(true);
            textblock1.Text = viewModel.make_comment(3, e.NewValue, lang_ru);
            textblock1.Foreground = viewModel.calc_color(3, e.NewValue);
        }

        private void slValue4_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((Slider)sender).SelectionEnd = e.NewValue;
            viewModel.refresh_params(4, e.NewValue);
            viewModel.rebuild_graph(lang_ru);
            viewModel.MyModel.InvalidatePlot(true);
            textblock1.Text = viewModel.make_comment(4, e.NewValue, lang_ru);
            textblock1.Foreground = viewModel.calc_color(4, e.NewValue);
        }

        private void slValue5_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((Slider)sender).SelectionEnd = e.NewValue;
            viewModel.refresh_params(5, e.NewValue);
            viewModel.rebuild_graph(lang_ru);
            viewModel.MyModel.InvalidatePlot(true);
            textblock1.Text = viewModel.make_comment(5, e.NewValue, lang_ru);
            textblock1.Foreground = viewModel.calc_color(5, e.NewValue);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            slValue1.Value = 0.1;
            slValue2.Value = 0.24;
            slValue3.Value = 0.1;
            slValue4.Value = 3.4;
            slValue5.Value = 3.4;
            if (lang_ru)
            
                textblock1.Text = "Пример: Уровень технологий равный, противодействие атаке почти не оказывается. Как следствие, количество атак идет на спад лишь спустя некоторое время. Атака считается успешно реализованной.";
            else
                textblock1.Text = "Example: The level of technology is equal, there is almost no resistance to the attack. As a result, the number of attacks decreases only after some time.";
            textblock1.Foreground = Brushes.MediumBlue;
        }
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            slValue1.Value = 1;
            slValue2.Value = 0.22;
            slValue3.Value = 1;
            slValue4.Value = 4.6;
            slValue5.Value = 2.2;
            if (lang_ru)

                textblock1.Text = "Пример: Коэффициенты эффективности и интенсивности подавления вторжения максимальны. Количество атак в еденицу времени быстро идет на спад и вскоре опускается ниже критической отметки. В результате така успешно подавлена";
            else
                textblock1.Text = "Example: The intrusion suppression efficiency and voltages are at their maximum. The number of attacks per unit of time is rapidly declining";
            textblock1.Foreground = Brushes.MediumBlue;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            if (lang_ru)
            {
                lang_ru = false;
                menu_1.Header = "Examples";
                menu_item_1.Header = "Example 1";
                menu_item_2.Header = "Example 2";
                menu_item_3.Header = "Exercise 1";
                menu_item_4.Header = "Exercise 2";
                menu_3.Header = "Exercises";
                Check.Content = "Check";
                menu_2.Header = "Change language";
                tb_1.Text = "Attack intensity factor";
                tb_2.Text = "Attacker's IT development level";
                tb_3.Text = "Reaction intensity factor";
                tb_4.Text = "Cyber ​​Intrusion Suppression Effectiveness";
                tb_5.Text = "Technological level of the protecting side";
                title.Title = "Countering computer attacks";
                textblock1.Text = "This mathematical model makes it possible to assess the dynamics of the process of suppressing the destructive effects of cyberattacks on an information resource";
                tab_item1.Header = "Model";
                tab_item2.Header = "Description of the mathematical model";
                tab_item3.Header = "Description of the computer model";
                Uri uri = new Uri("/myPhoto_en.JPG", UriKind.Relative);
                ImageSource imgSource = new BitmapImage(uri);
                img.Source = imgSource;
                uri = new Uri("/myPhoto2_en.JPG", UriKind.Relative);
                imgSource = new BitmapImage(uri);
                img1.Source = imgSource;
                uri = new Uri("/myPhoto3_en.JPG", UriKind.Relative);
                imgSource = new BitmapImage(uri);
                img2.Source = imgSource;
                uri = new Uri("/myPhoto4_en.JPG", UriKind.Relative);
                imgSource = new BitmapImage(uri);
                //img3.Source = imgSource;
                

            }
            else
            {
                lang_ru = true;
                menu_1.Header = "Примеры";
                menu_item_1.Header = "Пример 1";
                menu_item_2.Header = "Пример 2";
                menu_item_3.Header = "Упражнение 1";
                menu_item_4.Header = "Упражнение 2";
                menu_3.Header = "Упражнения";
                menu_2.Header = "Сменить язык";
                tb_1.Text = "Коэффициент интенсивности атаки";
                tb_2.Text = "Уровень развития ИТ злоумышленника";
                tb_3.Text = "Коэффициент интенсивности противодействия";
                tb_4.Text = "Эффективность подавления кибервторжений";
                tb_5.Text = "Технологический уровень защищающей стороны";
                title.Title = "Противодействие компьютерным атакам";
                textblock1.Text = "Данная математическая модель позволяет оценить динамику процесса подавления деструктивных воздействий кибератак на информационный ресурс";
                tab_item1.Header = "Модель";
                tab_item2.Header = "Описание матмодели";
                tab_item3.Header = "Описание компьютерной модели";

                Uri uri = new Uri("/myPhoto.JPG", UriKind.Relative);
                ImageSource imgSource = new BitmapImage(uri);
                img.Source = imgSource;
                uri = new Uri("/myPhoto2.JPG", UriKind.Relative);
                imgSource = new BitmapImage(uri);
                img1.Source = imgSource;
                uri = new Uri("/myPhoto3.JPG", UriKind.Relative);
                imgSource = new BitmapImage(uri);
                img2.Source = imgSource;
                uri = new Uri("/myPhoto4.JPG", UriKind.Relative);
                imgSource = new BitmapImage(uri);
                //img3.Source = imgSource;
                Check.Content = "Проверить";
            }
            viewModel.rebuild_graph(lang_ru);
            viewModel.MyModel.InvalidatePlot(true);
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            if (ex1)
            {
                if (slValue1.Value >= 0.4 && slValue1.Value < 0.5)
                {
                    Check.Visibility = System.Windows.Visibility.Hidden;
                    if (lang_ru)

                        textblock1.Text = "Верно";
                    else
                        textblock1.Text = "Right";
                    textblock1.Foreground = Brushes.Green;
                }
                else
                {
                    if (lang_ru)

                        if (slValue1.Value >= 0.5)
                            textblock1.Text = "Не верно. Для подавления атаки достаточно и меньшего значения";
                        else textblock1.Text = "Не верно. Для подавления атаки данного значения не достаточно";
                    else
                        if (slValue1.Value >= 0.5)
                            textblock1.Text = "Wrong.To suppress an attack, a smaller value is sufficient.";
                        else textblock1.Text = "Wrong. This value is not enough to suppress an attack.";
                    textblock1.Foreground = Brushes.Red;
                }
            }

            else
            {
                if (slValue3.Value >= 0.2 && slValue3.Value <= 0.24)
                {
                    Check.Visibility = System.Windows.Visibility.Hidden;
                    if (lang_ru)

                        textblock1.Text = "Верно";
                    else
                        textblock1.Text = "Right";
                    textblock1.Foreground = Brushes.Green;
                }
                else
                {
                    if (lang_ru)
                        if (slValue3.Value >= 0.24)
                            textblock1.Text = "Не верно. Для подавления атаки достаточно и меньшего значения";
                        else textblock1.Text = "Не верно. Для подавления атаки данного значения не достаточно";


                    else
                        if (slValue3.Value >= 0.24)
                            textblock1.Text = "Wrong.To suppress an attack, a smaller value is sufficient.";
                        else textblock1.Text = "Wrong. This value is not enough to suppress an attack.";
                    textblock1.Foreground = Brushes.Red;
                }
                
            }

        }
        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            ex1 = true;
            Check.Visibility = System.Windows.Visibility.Visible;
            slValue1.Value = 0.02;
            //slValue1.IsEnabled =
            slValue2.Value = 0.24;
            slValue3.Value = 0.1;
            slValue4.Value = 3.4;
            slValue5.Value = 3.4;
            if (lang_ru)

                textblock1.Text = "Для данных параметров выберете минимально возможное значение коэффициента интесивности подавления, чтобы остановить атаку (атака считается остановленой если число атак на ресурс в единицу времени не привышает критической отметки)";
            else
                textblock1.Text = "For these parameters, select the minimum possible value of the suppression intensity coefficient to stop the attack (the attack is considered stopped if the number of attacks on the resource per unit of time does not exceed the critical level)";
            textblock1.Foreground = Brushes.MediumBlue;
        }
        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            ex1 = false;
            Check.Visibility = System.Windows.Visibility.Visible;
            slValue1.Value = 0.2;
            slValue2.Value = 0.42;
            slValue3.Value = 0;
            slValue4.Value = 1.8;
            slValue5.Value = 2.8;
            if (lang_ru)

                textblock1.Text = "Выберете минимально возможное значение эффективности подавления кибервторжений необходимое для остановки данной атаки  (атака считается остановленой если число атак на ресурс в единицу времени не привышает критической отметки)";
            else
                textblock1.Text = "Select the lowest possible value of the cyber intrusion suppression efficiency required to stop the attack (the attack is considered stopped if the number of attacks on the resource per unit of time does not exceed the critical level)";
            textblock1.Foreground = Brushes.MediumBlue;
        }
    }
}
