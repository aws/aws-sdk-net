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
    /// Container for the parameters to the PutDashboard operation.
    /// Creates a dashboard if it does not already exist, or updates an existing dashboard.
    /// If you update a dashboard, the entire contents are replaced with what you specify
    /// here.
    /// 
    ///  
    /// <para>
    /// All dashboards in your account are global, not region-specific.
    /// </para>
    ///  
    /// <para>
    /// A simple way to create a dashboard using <c>PutDashboard</c> is to copy an existing
    /// dashboard. To copy an existing dashboard using the console, you can load the dashboard
    /// and then use the View/edit source command in the Actions menu to display the JSON
    /// block for that dashboard. Another way to copy a dashboard is to use <c>GetDashboard</c>,
    /// and then use the data returned within <c>DashboardBody</c> as the template for the
    /// new dashboard when you call <c>PutDashboard</c>.
    /// </para>
    ///  
    /// <para>
    /// When you create a dashboard with <c>PutDashboard</c>, a good practice is to add a
    /// text widget at the top of the dashboard with a message that the dashboard was created
    /// by script and should not be changed in the console. This message could also point
    /// console users to the location of the <c>DashboardBody</c> script or the CloudFormation
    /// template used to create the dashboard.
    /// </para>
    /// </summary>
    public partial class PutDashboardRequest : AmazonCloudWatchRequest
    {
        private string _dashboardBody;
        private string _dashboardName;

        /// <summary>
        /// Gets and sets the property DashboardBody. 
        /// <para>
        /// The detailed information about the dashboard in JSON format, including the widgets
        /// to include and their location on the dashboard. This parameter is required.
        /// </para>
        ///  
        /// <para>
        /// For more information about the syntax, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/CloudWatch-Dashboard-Body-Structure.html">Dashboard
        /// Body Structure and Syntax</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DashboardBody
        {
            get { return this._dashboardBody; }
            set { this._dashboardBody = value; }
        }

        // Check to see if DashboardBody property is set
        internal bool IsSetDashboardBody()
        {
            return this._dashboardBody != null;
        }

        /// <summary>
        /// Gets and sets the property DashboardName. 
        /// <para>
        /// The name of the dashboard. If a dashboard with this name already exists, this call
        /// modifies that dashboard, replacing its current contents. Otherwise, a new dashboard
        /// is created. The maximum length is 255, and valid characters are A-Z, a-z, 0-9, "-",
        /// and "_". This parameter is required.
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