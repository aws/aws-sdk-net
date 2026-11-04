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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the GetDashboard operation.
    /// </summary>
    public partial class GetDashboardResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DashboardArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dashboard.
        /// </para>
        /// </summary>
        public string DashboardArn { get; set; }

        /// <summary>
        /// Checks to see if the DashboardArn property is set.
        /// </summary>
        internal bool IsSetDashboardArn() => this.DashboardArn != null;

        /// <summary>
        /// Gets and sets the property DashboardBody. 
        /// <para>
        /// The detailed information about the dashboard, including what widgets are included
        /// and their location on the dashboard. For more information about the <c>DashboardBody</c>
        /// syntax, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Dashboard-Body-Structure.html">Dashboard
        /// Body Structure and Syntax</a>. 
        /// </para>
        /// </summary>
        public string DashboardBody { get; set; }

        /// <summary>
        /// Checks to see if the DashboardBody property is set.
        /// </summary>
        internal bool IsSetDashboardBody() => this.DashboardBody != null;

        /// <summary>
        /// Gets and sets the property DashboardName. 
        /// <para>
        /// The name of the dashboard.
        /// </para>
        /// </summary>
        public string DashboardName { get; set; }

        /// <summary>
        /// Checks to see if the DashboardName property is set.
        /// </summary>
        internal bool IsSetDashboardName() => this.DashboardName != null;
    }
}
