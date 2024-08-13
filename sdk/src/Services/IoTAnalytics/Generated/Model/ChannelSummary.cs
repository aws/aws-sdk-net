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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
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
namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// A summary of information about a channel.
    /// </summary>
    public partial class ChannelSummary
    {
        private string _channelName;
        private ChannelStorageSummary _channelStorage;
        private DateTime? _creationTime;
        private DateTime? _lastMessageArrivalTime;
        private DateTime? _lastUpdateTime;
        private ChannelStatus _status;

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ChannelName
        {
            get { return this._channelName; }
            set { this._channelName = value; }
        }

        // Check to see if ChannelName property is set
        internal bool IsSetChannelName()
        {
            return this._channelName != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelStorage. 
        /// <para>
        /// Where channel data is stored.
        /// </para>
        /// </summary>
        public ChannelStorageSummary ChannelStorage
        {
            get { return this._channelStorage; }
            set { this._channelStorage = value; }
        }

        // Check to see if ChannelStorage property is set
        internal bool IsSetChannelStorage()
        {
            return this._channelStorage != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the channel was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastMessageArrivalTime. 
        /// <para>
        /// The last time when a new message arrived in the channel.
        /// </para>
        ///  
        /// <para>
        /// IoT Analytics updates this value at most once per minute for one channel. Hence, the
        /// <c>lastMessageArrivalTime</c> value is an approximation.
        /// </para>
        ///  
        /// <para>
        /// This feature only applies to messages that arrived in the data store after October
        /// 23, 2020. 
        /// </para>
        /// </summary>
        public DateTime? LastMessageArrivalTime
        {
            get { return this._lastMessageArrivalTime; }
            set { this._lastMessageArrivalTime = value; }
        }

        // Check to see if LastMessageArrivalTime property is set
        internal bool IsSetLastMessageArrivalTime()
        {
            return this._lastMessageArrivalTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The last time the channel was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime
        {
            get { return this._lastUpdateTime; }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the channel.
        /// </para>
        /// </summary>
        public ChannelStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}