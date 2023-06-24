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
    /// This is the response object from the ListSubChannels operation.
    /// </summary>
    public partial class ListSubChannelsResponse : AmazonWebServiceResponse
    {
        private string _channelArn;
        private string _nextToken;
        private List<SubChannelSummary> _subChannels = new List<SubChannelSummary>();

        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The ARN of elastic channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1600)]
        public string ChannelArn
        {
            get { return this._channelArn; }
            set { this._channelArn = value; }
        }

        // Check to see if ChannelArn property is set
        internal bool IsSetChannelArn()
        {
            return this._channelArn != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token passed by previous API calls until all requested sub-channels are returned.
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

        /// <summary>
        /// Gets and sets the property SubChannels. 
        /// <para>
        /// The information about each sub-channel.
        /// </para>
        /// </summary>
        public List<SubChannelSummary> SubChannels
        {
            get { return this._subChannels; }
            set { this._subChannels = value; }
        }

        // Check to see if SubChannels property is set
        internal bool IsSetSubChannels()
        {
            return this._subChannels != null && this._subChannels.Count > 0; 
        }

    }
}