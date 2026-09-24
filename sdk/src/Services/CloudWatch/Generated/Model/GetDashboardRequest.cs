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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the GetDashboard operation.
    /// Displays the details of the dashboard that you specify.
    /// 
    ///  
    /// <para>
    /// To copy an existing dashboard, use <c>GetDashboard</c>, and then use the data returned
    /// within <c>DashboardBody</c> as the template for the new dashboard when you call <c>PutDashboard</c>
    /// to create the copy.
    /// </para>
    ///  
    /// <para>
    /// You might have recently enabled an <a href="https://docs.aws.amazon.com/glossary/latest/reference/glos-chap.html#optinregion">opt-in
    /// Region (Region that is disabled by default)</a> for your account. In that Region,
    /// <c>GetDashboard</c> can return an access denied error for up to 24 hours after you
    /// enable the Region. This delay occurs while dashboard data propagates. The error does
    /// not indicate a problem with your permissions. Because dashboards are global, you can
    /// call <c>GetDashboard</c> in any other enabled Region, or retry after propagation completes.
    /// </para>
    /// </summary>
    public partial class GetDashboardRequest : AmazonCloudWatchRequest
    {
        private string _dashboardName;

        /// <summary>
        /// Gets and sets the property DashboardName. 
        /// <para>
        /// The name of the dashboard to be described.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DashboardName
        {
            get { return this._dashboardName; }
            set { this._dashboardName = value; }
        }

        // Check to see if DashboardName property is set
        internal bool IsSetDashboardName()
        {
            return this._dashboardName != null;
        }

    }
}