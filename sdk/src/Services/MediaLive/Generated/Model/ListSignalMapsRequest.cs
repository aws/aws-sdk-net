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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the ListSignalMaps operation.
    /// Lists signal maps.
    /// </summary>
    public partial class ListSignalMapsRequest : AmazonMediaLiveRequest
    {
        private string _cloudWatchAlarmTemplateGroupIdentifier;
        private string _eventBridgeRuleTemplateGroupIdentifier;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CloudWatchAlarmTemplateGroupIdentifier. A cloudwatch alarm
        /// template group's identifier. Can be either be its id or current name.
        /// </summary>
        public string CloudWatchAlarmTemplateGroupIdentifier
        {
            get { return this._cloudWatchAlarmTemplateGroupIdentifier; }
            set { this._cloudWatchAlarmTemplateGroupIdentifier = value; }
        }

        // Check to see if CloudWatchAlarmTemplateGroupIdentifier property is set
        internal bool IsSetCloudWatchAlarmTemplateGroupIdentifier()
        {
            return this._cloudWatchAlarmTemplateGroupIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EventBridgeRuleTemplateGroupIdentifier. An eventbridge
        /// rule template group's identifier. Can be either be its id or current name.
        /// </summary>
        public string EventBridgeRuleTemplateGroupIdentifier
        {
            get { return this._eventBridgeRuleTemplateGroupIdentifier; }
            set { this._eventBridgeRuleTemplateGroupIdentifier = value; }
        }

        // Check to see if EventBridgeRuleTemplateGroupIdentifier property is set
        internal bool IsSetEventBridgeRuleTemplateGroupIdentifier()
        {
            return this._eventBridgeRuleTemplateGroupIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. A token used to retrieve the next set of results
        /// in paginated list responses.
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