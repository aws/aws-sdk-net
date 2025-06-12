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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
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
namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateChannel operation.
    /// Create a channel to start receiving content streams. The channel represents the input
    /// to MediaPackage for incoming live content from an encoder such as AWS Elemental MediaLive.
    /// The channel receives content, and after packaging it, outputs it through an origin
    /// endpoint to downstream devices (such as video players or CDNs) that request the content.
    /// You can create only one channel with each request. We recommend that you spread out
    /// channels between channel groups, such as putting redundant channels in the same AWS
    /// Region in different channel groups.
    /// </summary>
    public partial class CreateChannelRequest : AmazonMediaPackageV2Request
    {
        private string _channelGroupName;
        private string _channelName;
        private string _clientToken;
        private string _description;
        private InputSwitchConfiguration _inputSwitchConfiguration;
        private InputType _inputType;
        private OutputHeaderConfiguration _outputHeaderConfiguration;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ChannelGroupName. 
        /// <para>
        /// The name that describes the channel group. The name is the primary identifier for
        /// the channel group, and must be unique for your account in the AWS Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ChannelGroupName
        {
            get { return this._channelGroupName; }
            set { this._channelGroupName = value; }
        }

        // Check to see if ChannelGroupName property is set
        internal bool IsSetChannelGroupName()
        {
            return this._channelGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name that describes the channel. The name is the primary identifier for the channel,
        /// and must be unique for your account in the AWS Region and channel group. You can't
        /// change the name after you create the channel.
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure the idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// Enter any descriptive text that helps you to identify the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property InputSwitchConfiguration. 
        /// <para>
        /// The configuration for input switching based on the media quality confidence score
        /// (MQCS) as provided from AWS Elemental MediaLive. This setting is valid only when <c>InputType</c>
        /// is <c>CMAF</c>.
        /// </para>
        /// </summary>
        public InputSwitchConfiguration InputSwitchConfiguration
        {
            get { return this._inputSwitchConfiguration; }
            set { this._inputSwitchConfiguration = value; }
        }

        // Check to see if InputSwitchConfiguration property is set
        internal bool IsSetInputSwitchConfiguration()
        {
            return this._inputSwitchConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property InputType. 
        /// <para>
        /// The input type will be an immutable field which will be used to define whether the
        /// channel will allow CMAF ingest or HLS ingest. If unprovided, it will default to HLS
        /// to preserve current behavior.
        /// </para>
        ///  
        /// <para>
        /// The allowed values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HLS</c> - The HLS streaming specification (which defines M3U8 manifests and TS
        /// segments).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CMAF</c> - The DASH-IF CMAF Ingest specification (which defines CMAF segments
        /// with optional DASH manifests).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InputType InputType
        {
            get { return this._inputType; }
            set { this._inputType = value; }
        }

        // Check to see if InputType property is set
        internal bool IsSetInputType()
        {
            return this._inputType != null;
        }

        /// <summary>
        /// Gets and sets the property OutputHeaderConfiguration. 
        /// <para>
        /// The settings for what common media server data (CMSD) headers AWS Elemental MediaPackage
        /// includes in responses to the CDN. This setting is valid only when <c>InputType</c>
        /// is <c>CMAF</c>.
        /// </para>
        /// </summary>
        public OutputHeaderConfiguration OutputHeaderConfiguration
        {
            get { return this._outputHeaderConfiguration; }
            set { this._outputHeaderConfiguration = value; }
        }

        // Check to see if OutputHeaderConfiguration property is set
        internal bool IsSetOutputHeaderConfiguration()
        {
            return this._outputHeaderConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A comma-separated list of tag key:value pairs that you define. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>"Key1": "Value1",</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"Key2": "Value2"</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
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