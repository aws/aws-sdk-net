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
    /// Container for the parameters to the UpdateChannelClass operation.
    /// Changes the class of the channel.
    /// </summary>
    public partial class UpdateChannelClassRequest : AmazonMediaLiveRequest
    {
        private ChannelClass _channelClass;
        private string _channelId;
        private List<OutputDestination> _destinations = new List<OutputDestination>();

        /// <summary>
        /// Gets and sets the property ChannelClass. The channel class that you wish to update
        /// this channel to use.
        /// </summary>
        [AWSProperty(Required=true)]
        public ChannelClass ChannelClass
        {
            get { return this._channelClass; }
            set { this._channelClass = value; }
        }

        // Check to see if ChannelClass property is set
        internal bool IsSetChannelClass()
        {
            return this._channelClass != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelId. Channel Id of the channel whose class should
        /// be updated.
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}