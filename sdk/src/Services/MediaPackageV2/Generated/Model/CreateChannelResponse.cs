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
    /// This is the response object from the CreateChannel operation.
    /// </summary>
    public partial class CreateChannelResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _channelGroupName;
        private string _channelName;
        private DateTime? _createdAt;
        private string _description;
        private string _eTag;
        private List<IngestEndpoint> _ingestEndpoints = AWSConfigs.InitializeCollections ? new List<IngestEndpoint>() : null;
        private InputSwitchConfiguration _inputSwitchConfiguration;
        private InputType _inputType;
        private DateTime? _modifiedAt;
        private OutputHeaderConfiguration _outputHeaderConfiguration;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) associated with the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelGroupName. 
        /// <para>
        /// The name that describes the channel group. The name is the primary identifier for
        /// the channel group, and must be unique for your account in the AWS Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// and must be unique for your account in the AWS Region and channel group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the channel was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for your channel.
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
        /// Gets and sets the property ETag. 
        /// <para>
        /// The current Entity Tag (ETag) associated with this resource. The entity tag can be
        /// used to safely make concurrent updates to the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }

        /// <summary>
        /// Gets and sets the property IngestEndpoints.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IngestEndpoint> IngestEndpoints
        {
            get { return this._ingestEndpoints; }
            set { this._ingestEndpoints = value; }
        }

        // Check to see if IngestEndpoints property is set
        internal bool IsSetIngestEndpoints()
        {
            return this._ingestEndpoints != null && (this._ingestEndpoints.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The date and time the channel was modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ModifiedAt
        {
            get { return this._modifiedAt; }
            set { this._modifiedAt = value; }
        }

        // Check to see if ModifiedAt property is set
        internal bool IsSetModifiedAt()
        {
            return this._modifiedAt.HasValue; 
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
        /// The comma-separated list of tag key:value pairs assigned to the channel.
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