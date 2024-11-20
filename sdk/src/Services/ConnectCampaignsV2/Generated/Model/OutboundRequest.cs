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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
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
namespace Amazon.ConnectCampaignsV2.Model
{
    /// <summary>
    /// An outbound request for a campaign.
    /// </summary>
    public partial class OutboundRequest
    {
        private ChannelSubtypeParameters _channelSubtypeParameters;
        private string _clientToken;
        private DateTime? _expirationTime;

        /// <summary>
        /// Gets and sets the property ChannelSubtypeParameters.
        /// </summary>
        [AWSProperty(Required=true)]
        public ChannelSubtypeParameters ChannelSubtypeParameters
        {
            get { return this._channelSubtypeParameters; }
            set { this._channelSubtypeParameters = value; }
        }

        // Check to see if ChannelSubtypeParameters property is set
        internal bool IsSetChannelSubtypeParameters()
        {
            return this._channelSubtypeParameters != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=200)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationTime.
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ExpirationTime
        {
            get { return this._expirationTime; }
            set { this._expirationTime = value; }
        }

        // Check to see if ExpirationTime property is set
        internal bool IsSetExpirationTime()
        {
            return this._expirationTime.HasValue; 
        }

    }
}