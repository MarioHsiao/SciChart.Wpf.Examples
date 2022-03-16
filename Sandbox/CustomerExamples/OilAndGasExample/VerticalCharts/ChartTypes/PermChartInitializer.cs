﻿using System.Collections.Generic;
using System.Linq;
using System.Windows;
using SciChart.Charting.Model.ChartSeries;

namespace OilAndGasExample.VerticalCharts.ChartTypes
{
    public class PermChartInitializer : IChartInitializer
    {
        public string ChartTitle => "PERM";

        public IAxisViewModel GetXAxis()
        {
            return new NumericAxisViewModel
            {
                Visibility = Visibility.Collapsed
            };
        }

        public IAxisViewModel GetYAxis()
        {
            return new NumericAxisViewModel
            {
                Visibility = Visibility.Collapsed
            };
        }

        public IEnumerable<IRenderableSeriesViewModel> GetSeries()
        {
            return Enumerable.Empty<IRenderableSeriesViewModel>();
        }
    }
}
