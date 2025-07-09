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
    /// The configuration of the origin endpoint.
    /// </summary>
    public partial class OriginEndpointListConfiguration
    {
        private string _arn;
        private string _channelGroupName;
        private string _channelName;
        private ContainerType _containerType;
        private DateTime? _createdAt;
        private List<ListDashManifestConfiguration> _dashManifests = AWSConfigs.InitializeCollections ? new List<ListDashManifestConfiguration>() : null;
        private string _description;
        private ForceEndpointErrorConfiguration _forceEndpointErrorConfiguration;
        private List<ListHlsManifestConfiguration> _hlsManifests = AWSConfigs.InitializeCollections ? new List<ListHlsManifestConfiguration>() : null;
        private List<ListLowLatencyHlsManifestConfiguration> _lowLatencyHlsManifests = AWSConfigs.InitializeCollections ? new List<ListLowLatencyHlsManifestConfiguration>() : null;
        private DateTime? _modifiedAt;
        private List<ListMssManifestConfiguration> _mssManifests = AWSConfigs.InitializeCollections ? new List<ListMssManifestConfiguration>() : null;
        private string _originEndpointName;

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
        /// and must be unique for your account in the AWS Region and channel group. 
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
        /// Gets and sets the property ContainerType. 
        /// <para>
        /// The type of container attached to this origin endpoint. A container type is a file
        /// format that encapsulates one or more media streams, such as audio and video, into
        /// a single file. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContainerType ContainerType
        {
            get { return this._containerType; }
            set { this._containerType = value; }
        }

        // Check to see if ContainerType property is set
        internal bool IsSetContainerType()
        {
            return this._containerType != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the origin endpoint was created.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DashManifests. 
        /// <para>
        /// A DASH manifest configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ListDashManifestConfiguration> DashManifests
        {
            get { return this._dashManifests; }
            set { this._dashManifests = value; }
        }

        // Check to see if DashManifests property is set
        internal bool IsSetDashManifests()
        {
            return this._dashManifests != null && (this._dashManifests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Any descriptive information that you want to add to the origin endpoint for future
        /// identification purposes.
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
        /// Gets and sets the property ForceEndpointErrorConfiguration. 
        /// <para>
        /// The failover settings for the endpoint.
        /// </para>
        /// </summary>
        public ForceEndpointErrorConfiguration ForceEndpointErrorConfiguration
        {
            get { return this._forceEndpointErrorConfiguration; }
            set { this._forceEndpointErrorConfiguration = value; }
        }

        // Check to see if ForceEndpointErrorConfiguration property is set
        internal bool IsSetForceEndpointErrorConfiguration()
        {
            return this._forceEndpointErrorConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property HlsManifests. 
        /// <para>
        /// An HTTP live streaming (HLS) manifest configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ListHlsManifestConfiguration> HlsManifests
        {
            get { return this._hlsManifests; }
            set { this._hlsManifests = value; }
        }

        // Check to see if HlsManifests property is set
        internal bool IsSetHlsManifests()
        {
            return this._hlsManifests != null && (this._hlsManifests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LowLatencyHlsManifests. 
        /// <para>
        /// A low-latency HLS manifest configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ListLowLatencyHlsManifestConfiguration> LowLatencyHlsManifests
        {
            get { return this._lowLatencyHlsManifests; }
            set { this._lowLatencyHlsManifests = value; }
        }

        // Check to see if LowLatencyHlsManifests property is set
        internal bool IsSetLowLatencyHlsManifests()
        {
            return this._lowLatencyHlsManifests != null && (this._lowLatencyHlsManifests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The date and time the origin endpoint was modified.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property MssManifests. 
        /// <para>
        /// A list of Microsoft Smooth Streaming (MSS) manifest configurations associated with
        /// the origin endpoint. Each configuration represents a different MSS streaming option
        /// available from this endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ListMssManifestConfiguration> MssManifests
        {
            get { return this._mssManifests; }
            set { this._mssManifests = value; }
        }

        // Check to see if MssManifests property is set
        internal bool IsSetMssManifests()
        {
            return this._mssManifests != null && (this._mssManifests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OriginEndpointName. 
        /// <para>
        /// The name that describes the origin endpoint. The name is the primary identifier for
        /// the origin endpoint, and and must be unique for your account in the AWS Region and
        /// channel. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string OriginEndpointName
        {
            get { return this._originEndpointName; }
            set { this._originEndpointName = value; }
        }

        // Check to see if OriginEndpointName property is set
        internal bool IsSetOriginEndpointName()
        {
            return this._originEndpointName != null;
        }

    }
}