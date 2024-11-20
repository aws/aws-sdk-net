/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the fis-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.FIS.Model
{
    /// <summary>
    /// The CloudWatch dashboards to include as data sources in the experiment report.
    /// </summary>
    public partial class ExperimentTemplateReportConfigurationCloudWatchDashboard
    {
        private string _dashboardIdentifier;

        /// <summary>
        /// Gets and sets the property DashboardIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the CloudWatch dashboard to include in the experiment
        /// report.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string DashboardIdentifier
        {
            get { return this._dashboardIdentifier; }
            set { this._dashboardIdentifier = value; }
        }

        // Check to see if DashboardIdentifier property is set
        internal bool IsSetDashboardIdentifier()
        {
            return this._dashboardIdentifier != null;
        }

    }
}