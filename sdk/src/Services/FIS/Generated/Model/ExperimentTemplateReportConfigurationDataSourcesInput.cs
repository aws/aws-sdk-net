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
    /// Specifies the data sources for the experiment report.
    /// </summary>
    public partial class ExperimentTemplateReportConfigurationDataSourcesInput
    {
        private List<ReportConfigurationCloudWatchDashboardInput> _cloudWatchDashboards = AWSConfigs.InitializeCollections ? new List<ReportConfigurationCloudWatchDashboardInput>() : null;

        /// <summary>
        /// Gets and sets the property CloudWatchDashboards. 
        /// <para>
        /// The CloudWatch dashboards to include as data sources in the experiment report.
        /// </para>
        /// </summary>
        public List<ReportConfigurationCloudWatchDashboardInput> CloudWatchDashboards
        {
            get { return this._cloudWatchDashboards; }
            set { this._cloudWatchDashboards = value; }
        }

        // Check to see if CloudWatchDashboards property is set
        internal bool IsSetCloudWatchDashboards()
        {
            return this._cloudWatchDashboards != null && (this._cloudWatchDashboards.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}