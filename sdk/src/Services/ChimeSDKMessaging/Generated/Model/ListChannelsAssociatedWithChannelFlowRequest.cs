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
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// Container for the parameters to the ListChannelsAssociatedWithChannelFlow operation.
    /// Lists all channels associated with a specified channel flow. You can associate a channel
    /// flow with multiple channels, but you can only associate a channel with one channel
    /// flow. This is a developer API.
    /// </summary>
    public partial class ListChannelsAssociatedWithChannelFlowRequest : AmazonChimeSDKMessagingRequest
    {
        private string _channelFlowArn;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ChannelFlowArn. 
        /// <para>
        /// The ARN of the channel flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=1600)]
        public string ChannelFlowArn
        {
            get { return this._channelFlowArn; }
            set { this._channelFlowArn = value; }
        }

        // Check to see if ChannelFlowArn property is set
        internal bool IsSetChannelFlowArn()
        {
            return this._channelFlowArn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of channels that you want to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token passed by previous API calls until all requested channels are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
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