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
    /// Container for the parameters to the ListDashboards operation.
    /// Returns a list of the dashboards for your account. If you include <c>DashboardNamePrefix</c>,
    /// only those dashboards with names starting with the prefix are listed. Otherwise, all
    /// dashboards in your account are listed. 
    /// 
    ///  
    /// <para>
    ///  <c>ListDashboards</c> returns up to 1000 results on one page. If there are more than
    /// 1000 dashboards, you can call <c>ListDashboards</c> again and include the value you
    /// received for <c>NextToken</c> in the first call, to receive the next 1000 results.
    /// </para>
    /// </summary>
    public partial class ListDashboardsRequest : AmazonCloudWatchRequest
    {
        private string _dashboardNamePrefix;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DashboardNamePrefix. 
        /// <para>
        /// If you specify this parameter, only the dashboards with names starting with the specified
        /// string are listed. The maximum length is 255, and valid characters are A-Z, a-z, 0-9,
        /// ".", "-", and "_". 
        /// </para>
        /// </summary>
        public string DashboardNamePrefix
        {
            get { return this._dashboardNamePrefix; }
            set { this._dashboardNamePrefix = value; }
        }

        // Check to see if DashboardNamePrefix property is set
        internal bool IsSetDashboardNamePrefix()
        {
            return this._dashboardNamePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned by a previous call to indicate that there is more data available.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}