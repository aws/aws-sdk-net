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

namespace Amazon.NetworkFlowMonitor.Model
{
    /// <summary>
    /// Container for the parameters to the ListPerformanceMonitors operation. Returns a list
    /// of the performance monitors in an account. You can optionally return only the monitors
    /// that have a specific status or type. <para> Results are paginated. Use the <c>nextToken</c>
    /// parameter to return additional results. </para>
    /// </summary>
    public partial class ListPerformanceMonitorsRequest : AmazonNetworkFlowMonitorRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of performance monitors that you want to return with this call. If you
        /// don't specify a value, the default is 25.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MonitorStatus. 
        /// <para>
        /// The status of the performance monitors that you want to return. If you don't specify
        /// a status, Network Flow Monitor returns performance monitors with any status.
        /// </para>
        /// </summary>
        public MonitorStatus MonitorStatus { get; set; }

        /// <summary>
        /// Checks to see if the MonitorStatus property is set.
        /// </summary>
        internal bool IsSetMonitorStatus() => this.MonitorStatus != null;

        /// <summary>
        /// Gets and sets the property MonitorType. 
        /// <para>
        /// The type of the performance monitors that you want to return. If you don't specify
        /// a type, Network Flow Monitor returns performance monitors of any type.
        /// </para>
        /// </summary>
        public PerformanceMonitorType MonitorType { get; set; }

        /// <summary>
        /// Checks to see if the MonitorType property is set.
        /// </summary>
        internal bool IsSetMonitorType() => this.MonitorType != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. You receive this token from a previous call.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
