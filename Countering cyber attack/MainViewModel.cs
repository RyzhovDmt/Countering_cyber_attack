using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace Countering_cyber_attack
{
    using System;

    using OxyPlot;
    using OxyPlot.Series;
    class MainViewModel
    {
        
        double a = 0, b = 0, g = 0, i_def = 0, i_att = 0, n = -1;
        public string make_comment(int num, double param, bool lang)
        {
            string text = "";
;
            if (lang)
            {
                if (calc_value(4) < 5.1 && calc_value(4) > 4.9)
                { return "Количество атак в единицу времени близко к критической отметке. Вторжение удалось остановить, но угроза возобновления атак сохраняется"; }
                if (calc_value(4) < 5)
                { return "Количество атак в единицу времени не привышает критической отметки. Атака на инфраструктуру успешно подавлена"; }
                if (calc_value(4) > 5)
                { return "Количество атак в единицу времени выше критической отметки. Атака успешно реализована"; }
                /*
                switch (num)
                {
                    case 1:
                        if (param > 0.33 && param < 0.66) return "Среднее число атак на инфраструктуру ресурса в единицу времени";
                        if (param > 0.66) return "Увеличение количества атак на инфраструктуру ресурса в единицу времени";
                        else return "Уменьшение количества атак на инфраструктуру ресурса в единицу времени";
                    //break;
                    case 2:
                        if (param > 0.33 && param < 0.66) return "Среднее число атак на инфраструктуру ресурса в единицу времени";
                        if (param > 0.66) return "Уменьшение количества атак на инфраструктуру ресурса в единицу времени";
                        else return "Увеличение количества атак на инфраструктуру ресурса в единицу времени";
                    case 3:
                        if (param > 0.33 && param < 0.66) return "Среднее уровень подавления атаки";
                        if (param > 0.66) return "Увеличение уровня подавления атаки";
                        else return "Уменьшение уровня подавления атаки";
                    case 4:
                        if (param > 3.3 && param < 6.6) return "Среднее число атак на инфраструктуру ресурса в единицу времени";
                        if (param > 6.6) return "Увеличение количества атак на инфраструктуру ресурса в единицу времени";
                        else return "Уменьшение количества атак на инфраструктуру ресурса в единицу времени";
                    case 5:
                        if (param > 3.3 && param < 6.6) return "Среднее уровень подавления атаки";
                        if (param > 6.6) return "Увеличение уровня подавления атаки";
                        else return "Уменьшение уровня подавления атаки";
                    default: throw new ArgumentException("Недопустимый номер параметра");
                }
                */
            }
            else
            {
                if (calc_value(4) < 5.1 && calc_value(4) > 4.9)
                { return "The number of attacks per unit of time is close to the critical point. The invasion was stopped, but the threat of renewed attacks remains"; }
                if (calc_value(4) < 5)
                { return "The number of attacks per unit of time does not exceed the critical level. Infrastructure Attack Successfully Suppressed"; }
                if (calc_value(4) > 5)
                { return "The number of attacks per unit of time is above the critical level. Attack successfully completed"; }
                /*
                switch (num)
                {
                    case 1:
                        if (param > 0.33 && param < 0.66) return "Average number of attacks on resource infrastructure per unit of time";
                        if (param > 0.66) return "Increase in the number of attacks on resource infrastructure per unit of time";
                        else return "Reducing the number of attacks on the resource infrastructure per unit of time";
                    //break;
                    case 2:
                        if (param > 0.33 && param < 0.66) return "Average number of attacks on resource infrastructure per unit of time";
                        if (param > 0.66) return "Reducing the number of attacks on the resource infrastructure per unit of time";
                        else return "Increase in the number of attacks on resource infrastructure per unit of time";
                    case 3:
                        if (param > 0.33 && param < 0.66) return "Medium attack suppression";
                        if (param > 0.66) return "Increase the level of attack suppression";
                        else return "Decrease the level of attack suppression";
                    case 4:
                        if (param > 3.3 && param < 6.6) return "Average number of attacks on resource infrastructure per unit of time";
                        if (param > 6.6) return "Increase in the number of attacks on resource infrastructure per unit of time";
                        else return "Reducing the number of attacks on the resource infrastructure per unit of time";
                    case 5:
                        if (param > 3.3 && param < 6.6) return "Medium attack suppression";
                        if (param > 6.6) return "Increase the level of attack suppression";
                        else return "Decrease the level of attack suppression";
                    default: throw new ArgumentException("Недопустимый номер параметра");
                }
                */
            }
            return text;

        }
        public SolidColorBrush calc_color(int num, double param)
        {
            string text = "";
            if (calc_value(4) < 5.1 && calc_value(4) > 4.9)
                return Brushes.Orange;
            if (calc_value(4) < 5)
                return Brushes.Green;
            if (calc_value(4) > 5)
                return Brushes.Red;
            /*
            switch (num)
            {
                case 1:
                    if (param > 0.33 && param < 0.66) return Brushes.Orange;
                    if (param > 0.66) return Brushes.Red;
                    else return Brushes.Green;
                    //break;
                case 2:
                    if (param > 0.33 && param < 0.66) return Brushes.Orange;
                    if (param > 0.66) return Brushes.Green;
                    else return Brushes.Red;
                //break;
                case 3:
                    if (param > 0.33 && param < 0.66) return Brushes.Orange;
                    if (param > 0.66) return Brushes.Green;
                    else return Brushes.Red;
                case 4:
                    if (param > 3.3 && param < 6.6) return Brushes.Orange;
                    if (param > 6.6) return Brushes.Red;
                    else return Brushes.Green;
                case 5:
                    if (param > 3.3 && param < 6.6) return Brushes.Orange;
                    if (param > 6.6) return Brushes.Green;
                    else return Brushes.Red;
                default: throw new ArgumentException("Недопустимый номер параметра");
            }
            */
            return Brushes.Black;

        }
        public void refresh_params(int num, double param)
        {
            switch (num)
            {
                case 1: a = param; break;
                case 2: b = param; break;
                case 3: g = param; break;
                case 4: i_att = param; break;
                case 5: i_def = param; break;
                default: throw new ArgumentException("Недопустимый номер параметра");
            }
            
        }
        public double calc_expr()
        {
            double l = 0;
            l = (b*b-2*g*b+a*a)*i_att*i_att-4*a*b*n* i_att;
            //if (l < 0) return -l;
            return l;
        }

        public double calc_value(double x)
        {
            double y = 0, y_p = 0;
            //y = ((calc_expr())) / (a * Math.Exp((calc_expr()) * x) + (calc_expr()));
            //y += ((calc_expr()) + (a + b) * i_att) / (2 * a);
            y = (Math.Sqrt(calc_expr())) / (a * Math.Exp(Math.Sqrt(calc_expr()) * x) + Math.Sqrt(calc_expr()));
            y += (Math.Sqrt(calc_expr()) + (a + b) * i_att) / (2 * a);
            if (y != y) return y_p;
            y_p = y;
            return y;
        }
        public double calc_z_value(double x)
        {
            double y = 0, y_p = 0;
            int[] s = new int[5] { -1, -1, -1, -1, -1 };
            //y = ((calc_expr())) / (a * Math.Exp((calc_expr()) * x) + (calc_expr()));
            //y += ((calc_expr()) + (a + b) * i_att) / (2 * a);
            y = (g*i_def-s[0]*n*Math.Exp((i_def-(s[1] * n /g))*x+(i_def*g- s[2] * n))) / (1- Math.Exp((i_def - (s[3] * n / g)) * x + (i_def * g - s[4] * n)));
            y += 5;
            if (y != y) return y_p;
            y_p = y;
            return y;
        }
        public double calc_const(double x)
        {
            

            return 5;
        }
        public void rebuild_graph(bool ru)
        {
            //List<LineSeries> listPointAray = new List<LineSeries>();
            if (ru)
                MyModel.Title = "Модель противодействия компьютерным атакам";
            else
                MyModel.Title = "Computer Attack Counteraction Model";
            MyModel.Series.Clear();
            var series = new FunctionSeries(calc_value, 0, 10, 0.1, "Cyber attack")
            {
                Color = OxyColors.OrangeRed
            };
            this.MyModel.Series.Add(series);
            //listPointAray.Add(series);
            var series_ = new FunctionSeries(calc_z_value, 0, 10, 0.1, "Cyber attack")
            {
                Color = OxyColors.Green
            };
            this.MyModel.Series.Add(series_);
            var series_2 = new FunctionSeries(calc_const, 0, 10, 0.1, "Cyber attack")
            {
                Color = OxyColors.Orange,
                LineStyle = LineStyle.Dash
            };
            this.MyModel.Series.Add(series_2);

        }
        public MainViewModel()
        {

                this.MyModel = new PlotModel { Title = "Модель противодействия компьютерным атакам", IsLegendVisible = true };

                //this.MyModel.Series.Add(new FunctionSeries(f, 0, 10, 0.1, "cos(x)"));
                rebuild_graph(true);
                MyModel.InvalidatePlot(true); //refresh
            

        }

        public PlotModel MyModel
        {
            get; private set;
        }
    }
}
