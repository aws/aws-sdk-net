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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the ListMonitoringSchedules operation.
    /// </summary>
    public partial class ListMonitoringSchedulesResponse : AmazonWebServiceResponse
    {
        private List<MonitoringScheduleSummary> _monitoringScheduleSummaries = AWSConfigs.InitializeCollections ? new List<MonitoringScheduleSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MonitoringScheduleSummaries. 
        /// <para>
        /// A JSON array in which each element is a summary for a monitoring schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<MonitoringScheduleSummary> MonitoringScheduleSummaries
        {
            get { return this._monitoringScheduleSummaries; }
            set { this._monitoringScheduleSummaries = value; }
        }

        // Check to see if MonitoringScheduleSummaries property is set
        internal bool IsSetMonitoringScheduleSummaries()
        {
            return this._monitoringScheduleSummaries != null && (this._monitoringScheduleSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned if the response is truncated. To retrieve the next set of job executions,
        /// use it in the next request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
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