/*
 * Copyright 2012-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;


using Amazon.Util;
using Amazon.Util.Internal;

namespace Amazon.MobileAnalytics.MobileAnalyticsManager
{
    /// <summary>
    /// Represents configuration for Mobile Analytics.
    /// </summary>
    public partial class MobileAnalyticsManagerConfig
    {
        private const string mobileAnalyticsKey = "mobileAnalytics";
        
        internal void Configure(MobileAnalyticsManagerConfigSection section)
        {
            SessionTimeout = section.SessionTimeout.GetValueOrDefault(defaultSessionTimeout);
            MaxDBSize = section.MaxDBSize.GetValueOrDefault(defaultMaxDBSize);
            DBWarningThreshold = section.DBWarningThreashold.GetValueOrDefault(defaultDBWarningThreshold);
            MaxRequestSize = section.MaxRequestSize.GetValueOrDefault(defaultMaxRequestSize);
            AllowUseDataNetwork = section.AllowUseDataNetwork.GetValueOrDefault(defaultAllowUseDataNetwork);
        }

    }

    internal class MobileAnalyticsManagerConfigSectionRoot
    {
        private const string mobileAnalyticsKey = "mobileAnalytics";

        public MobileAnalyticsManagerConfigSectionRoot(XElement section)
        {
            if (section == null)
                return;

            this.SectionConfig = AWSConfigs.GetObject<MobileAnalyticsManagerConfigSection>(section, mobileAnalyticsKey);
        }

        public MobileAnalyticsManagerConfigSection SectionConfig { get; set; }
    }

    internal class MobileAnalyticsManagerConfigSection
    {
        public int? SessionTimeout { get; set; }
        public int? MaxDBSize { get; set; }
        public double? DBWarningThreashold { get; set; }
        public int? MaxRequestSize { get; set; }
        public bool? AllowUseDataNetwork { get; set; }
    }
}