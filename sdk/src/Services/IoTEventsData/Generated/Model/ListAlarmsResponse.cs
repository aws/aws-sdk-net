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
 * Do not modify this file. This file is generated from the iotevents-data-2018-10-23.normal.json service model.
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
namespace Amazon.IoTEventsData.Model
{
    /// <summary>
    /// This is the response object from the ListAlarms operation.
    /// </summary>
    public partial class ListAlarmsResponse : AmazonWebServiceResponse
    {
        private List<AlarmSummary> _alarmSummaries = AWSConfigs.InitializeCollections ? new List<AlarmSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AlarmSummaries. 
        /// <para>
        /// A list that summarizes each alarm.
        /// </para>
        /// </summary>
        public List<AlarmSummary> AlarmSummaries
        {
            get { return this._alarmSummaries; }
            set { this._alarmSummaries = value; }
        }

        // Check to see if AlarmSummaries property is set
        internal bool IsSetAlarmSummaries()
        {
            return this._alarmSummaries != null && (this._alarmSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that you can use to return the next set of results, or <c>null</c> if there
        /// are no more results.
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