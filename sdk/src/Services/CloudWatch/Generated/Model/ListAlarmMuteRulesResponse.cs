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
    /// This is the response object from the ListAlarmMuteRules operation.
    /// </summary>
    public partial class ListAlarmMuteRulesResponse : AmazonWebServiceResponse
    {
        private List<AlarmMuteRuleSummary> _alarmMuteRuleSummaries = AWSConfigs.InitializeCollections ? new List<AlarmMuteRuleSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AlarmMuteRuleSummaries. 
        /// <para>
        /// A list of alarm mute rule summaries.
        /// </para>
        /// </summary>
        public List<AlarmMuteRuleSummary> AlarmMuteRuleSummaries
        {
            get { return this._alarmMuteRuleSummaries; }
            set { this._alarmMuteRuleSummaries = value; }
        }

        // Check to see if AlarmMuteRuleSummaries property is set
        internal bool IsSetAlarmMuteRuleSummaries()
        {
            return this._alarmMuteRuleSummaries != null && (this._alarmMuteRuleSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use when requesting the next set of results. If this field is absent,
        /// there are no more results to retrieve.
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