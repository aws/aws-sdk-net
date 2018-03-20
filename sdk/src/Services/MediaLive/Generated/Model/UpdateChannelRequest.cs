/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateChannel operation.
    /// Updates a channel.
    /// </summary>
    public partial class UpdateChannelRequest : AmazonMediaLiveRequest
    {
        private string _channelId;
        private List<OutputDestination> _destinations = new List<OutputDestination>();
        private EncoderSettings _encoderSettings;
        private List<InputAttachment> _inputAttachments = new List<InputAttachment>();
        private InputSpecification _inputSpecification;
        private string _name;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property ChannelId. channel ID
        /// </summary>
        public string ChannelId
        {
            get { return this._channelId; }
            set { this._channelId = value; }
        }

        // Check to see if ChannelId property is set
        internal bool IsSetChannelId()
        {
            return this._channelId != null;
        }

        /// <summary>
        /// Gets and sets the property Destinations. A list of output destinations for this channel.
        /// </summary>
        public List<OutputDestination> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && this._destinations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EncoderSettings. The encoder settings for this channel.
        /// </summary>
        public EncoderSettings EncoderSettings
        {
            get { return this._encoderSettings; }
            set { this._encoderSettings = value; }
        }

        // Check to see if EncoderSettings property is set
        internal bool IsSetEncoderSettings()
        {
            return this._encoderSettings != null;
        }

        /// <summary>
        /// Gets and sets the property InputAttachments.
        /// </summary>
        public List<InputAttachment> InputAttachments
        {
            get { return this._inputAttachments; }
            set { this._inputAttachments = value; }
        }

        // Check to see if InputAttachments property is set
        internal bool IsSetInputAttachments()
        {
            return this._inputAttachments != null && this._inputAttachments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InputSpecification. Specification of input for this channel
        /// (max. bitrate, resolution, codec, etc.)
        /// </summary>
        public InputSpecification InputSpecification
        {
            get { return this._inputSpecification; }
            set { this._inputSpecification = value; }
        }

        // Check to see if InputSpecification property is set
        internal bool IsSetInputSpecification()
        {
            return this._inputSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property Name. The name of the channel.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. An optional Amazon Resource Name (ARN) of the
        /// role to assume when running the Channel. If you do not specify this on an update call
        /// but the role was previously set that role will be removed.
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}