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
    /// Event trigger context data
    /// </summary>
    public partial class EventTriggerContext
    {
        private ChannelContext _channelContext;
        private string _sourceEvent;

        /// <summary>
        /// Gets and sets the property ChannelContext.
        /// </summary>
        public ChannelContext ChannelContext
        {
            get { return this._channelContext; }
            set { this._channelContext = value; }
        }

        // Check to see if ChannelContext property is set
        internal bool IsSetChannelContext()
        {
            return this._channelContext != null;
        }

        /// <summary>
        /// Gets and sets the property SourceEvent.
        /// </summary>
        [AWSProperty(Min=1)]
        public string SourceEvent
        {
            get { return this._sourceEvent; }
            set { this._sourceEvent = value; }
        }

        // Check to see if SourceEvent property is set
        internal bool IsSetSourceEvent()
        {
            return this._sourceEvent != null;
        }

    }
}