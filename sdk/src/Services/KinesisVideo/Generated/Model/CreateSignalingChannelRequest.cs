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
    /// Container for the parameters to the CreateSignalingChannel operation.
    /// Creates a signaling channel. 
    /// 
    ///  
    /// <para>
    ///  <c>CreateSignalingChannel</c> is an asynchronous operation.
    /// </para>
    /// </summary>
    public partial class CreateSignalingChannelRequest : AmazonKinesisVideoRequest
    {
        private string _channelName;
        private ChannelType _channelType;
        private SingleMasterConfiguration _singleMasterConfiguration;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// A name for the signaling channel that you are creating. It must be unique for each
        /// Amazon Web Services account and Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property ChannelType. 
        /// <para>
        /// A type of the signaling channel that you are creating. Currently, <c>SINGLE_MASTER</c>
        /// is the only supported channel type. 
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
        /// Gets and sets the property SingleMasterConfiguration. 
        /// <para>
        /// A structure containing the configuration for the <c>SINGLE_MASTER</c> channel type.
        /// 
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of tags (key-value pairs) that you want to associate with this channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}