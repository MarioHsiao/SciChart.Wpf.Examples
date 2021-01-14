﻿// *************************************************************************************
// SCICHART® Copyright SciChart Ltd. 2011-2021. All rights reserved.
//  
// Web: http://www.scichart.com
//   Support: support@scichart.com
//   Sales:   sales@scichart.com
// 
// TimeFrame.cs is part of SCICHART®, High Performance Scientific Charts
// For full terms and conditions of the license, see http://www.scichart.com/scichart-eula/
// 
// This source code is protected by international copyright law. Unauthorized
// reproduction, reverse-engineering, or distribution of all or any portion of
// this source code is strictly prohibited.
// 
// This source code contains confidential and proprietary trade secrets of
// SciChart Ltd., and should at no time be copied, transferred, sold,
// distributed or made available without express written permission.
// *************************************************************************************
using System.Globalization;
using System.Linq;

namespace SciChart.Examples.ExternalDependencies.Common
{
    public class TimeFrame : StrongTyped<string>
    {        
        public TimeFrame(string value, string displayname) : base(value)
        {
            Displayname = displayname;
        }

        public static readonly TimeFrame Daily = new TimeFrame("Daily", "Daily");
        public static readonly TimeFrame Hourly = new TimeFrame("Hourly", "1 Hour");
        public static readonly TimeFrame Minute15 = new TimeFrame("Minute15", "15 Minutes");
        public static readonly TimeFrame Minute5 = new TimeFrame("Minute5", "5 Minutes");

        public string Displayname { get; private set; }

        public static TimeFrame Parse(string input)
        {
            return new[] {Minute5, Minute15, Hourly, Daily}.Single(x => x.Value.ToUpper(CultureInfo.InvariantCulture) == input.ToUpper(CultureInfo.InvariantCulture));
        }
    }
}