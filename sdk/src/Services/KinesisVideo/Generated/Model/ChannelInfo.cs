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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
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
namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// A structure that encapsulates a signaling channel's metadata and properties.
    /// </summary>
    public partial class ChannelInfo
    {
        private string _channelARN;
        private string _channelName;
        private Status _channelStatus;
        private ChannelType _channelType;
        private DateTime? _creationTime;
        private SingleMasterConfiguration _singleMasterConfiguration;
        private string _version;

        /// <summary>
        /// Gets and sets the property ChannelARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the signaling channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ChannelARN
        {
            get { return this._channelARN; }
            set { this._channelARN = value; }
        }

        // Check to see if ChannelARN property is set
        internal bool IsSetChannelARN()
        {
            return this._channelARN != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the signaling channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property ChannelStatus. 
        /// <para>
        /// Current status of the signaling channel.
        /// </para>
        /// </summary>
        public Status ChannelStatus
        {
            get { return this._channelStatus; }
            set { this._channelStatus = value; }
        }

        // Check to see if ChannelStatus property is set
        internal bool IsSetChannelStatus()
        {
            return this._channelStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelType. 
        /// <para>
        /// The type of the signaling channel.
        /// </para>
        /// </summary>
        public ChannelType ChannelType
        {
            get { return this._channelType; }
            set { this._channelType = value; }
        }

        // Check to see if ChannelType property is set
        internal bool IsSetChannelType()
        {
            return this._channelType != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the signaling channel was created.
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
        /// Gets and sets the property SingleMasterConfiguration. 
        /// <para>
        /// A structure that contains the configuration for the <c>SINGLE_MASTER</c> channel type.
        /// </para>
        /// </summary>
        public SingleMasterConfiguration SingleMasterConfiguration
        {
            get { return this._singleMasterConfiguration; }
            set { this._singleMasterConfiguration = value; }
        }

        // Check to see if SingleMasterConfiguration property is set
        internal bool IsSetSingleMasterConfiguration()
        {
            return this._singleMasterConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The current version of the signaling channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}