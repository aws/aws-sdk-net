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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the BatchDelete operation.
    /// Starts delete of resources.
    /// </summary>
    public partial class BatchDeleteRequest : AmazonMediaLiveRequest
    {
        private List<string> _channelIds = new List<string>();
        private List<string> _inputIds = new List<string>();
        private List<string> _inputSecurityGroupIds = new List<string>();
        private List<string> _multiplexIds = new List<string>();

        /// <summary>
        /// Gets and sets the property ChannelIds. List of channel IDs
        /// </summary>
        public List<string> ChannelIds
        {
            get { return this._channelIds; }
            set { this._channelIds = value; }
        }

        // Check to see if ChannelIds property is set
        internal bool IsSetChannelIds()
        {
            return this._channelIds != null && this._channelIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InputIds. List of input IDs
        /// </summary>
        public List<string> InputIds
        {
            get { return this._inputIds; }
            set { this._inputIds = value; }
        }

        // Check to see if InputIds property is set
        internal bool IsSetInputIds()
        {
            return this._inputIds != null && this._inputIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InputSecurityGroupIds. List of input security group IDs
        /// </summary>
        public List<string> InputSecurityGroupIds
        {
            get { return this._inputSecurityGroupIds; }
            set { this._inputSecurityGroupIds = value; }
        }

        // Check to see if InputSecurityGroupIds property is set
        internal bool IsSetInputSecurityGroupIds()
        {
            return this._inputSecurityGroupIds != null && this._inputSecurityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MultiplexIds. List of multiplex IDs
        /// </summary>
        public List<string> MultiplexIds
        {
            get { return this._multiplexIds; }
            set { this._multiplexIds = value; }
        }

        // Check to see if MultiplexIds property is set
        internal bool IsSetMultiplexIds()
        {
            return this._multiplexIds != null && this._multiplexIds.Count > 0; 
        }

    }
}