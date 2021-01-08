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

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// This is the response object from the DescribeAlarmHistory operation.
    /// </summary>
    public partial class DescribeAlarmHistoryResponse : AmazonWebServiceResponse
    {
        private List<AlarmHistoryItem> _alarmHistoryItems = new List<AlarmHistoryItem>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AlarmHistoryItems. 
        /// <para>
        /// The alarm histories, in JSON format.
        /// </para>
        /// </summary>
        public List<AlarmHistoryItem> AlarmHistoryItems
        {
            get { return this._alarmHistoryItems; }
            set { this._alarmHistoryItems = value; }
        }

        // Check to see if AlarmHistoryItems property is set
        internal bool IsSetAlarmHistoryItems()
        {
            return this._alarmHistoryItems != null && this._alarmHistoryItems.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that marks the start of the next batch of returned results.
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