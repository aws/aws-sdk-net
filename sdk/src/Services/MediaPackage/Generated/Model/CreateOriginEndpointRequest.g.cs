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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.MediaPackage.Model
{
    /// <summary>
    /// Container for the parameters to the CreateOriginEndpoint operation. Creates a new
    /// OriginEndpoint record.
    /// </summary>
    public partial class CreateOriginEndpointRequest : AmazonMediaPackageRequest
    {
        /// <summary>
        /// Gets and sets the property Authorization.
        /// </summary>
        public Authorization Authorization { get; set; }

        /// <summary>
        /// Checks to see if the Authorization property is set.
        /// </summary>
        internal bool IsSetAuthorization() => this.Authorization != null;

        /// <summary>
        /// Gets and sets the property ChannelId. The ID of the Channel that the OriginEndpoint
        /// will be associated with. This cannot be changed after the OriginEndpoint is created.
        /// </summary>
        [AWSProperty(Required = true)]
        public string ChannelId { get; set; }

        /// <summary>
        /// Checks to see if the ChannelId property is set.
        /// </summary>
        internal bool IsSetChannelId() => this.ChannelId != null;

        /// <summary>
        /// Gets and sets the property CmafPackage.
        /// </summary>
        public CmafPackageCreateOrUpdateParameters CmafPackage { get; set; }

        /// <summary>
        /// Checks to see if the CmafPackage property is set.
        /// </summary>
        internal bool IsSetCmafPackage() => this.CmafPackage != null;

        /// <summary>
        /// Gets and sets the property DashPackage.
        /// </summary>
        public DashPackage DashPackage { get; set; }

        /// <summary>
        /// Checks to see if the DashPackage property is set.
        /// </summary>
        internal bool IsSetDashPackage() => this.DashPackage != null;

        /// <summary>
        /// Gets and sets the property Description. A short text description of the OriginEndpoint.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property HlsPackage.
        /// </summary>
        public HlsPackage HlsPackage { get; set; }

        /// <summary>
        /// Checks to see if the HlsPackage property is set.
        /// </summary>
        internal bool IsSetHlsPackage() => this.HlsPackage != null;

        /// <summary>
        /// Gets and sets the property Id. The ID of the OriginEndpoint. The ID must be unique
        /// within the region and it cannot be changed after the OriginEndpoint is created.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ManifestName. A short string that will be used as the filename
        /// of the OriginEndpoint URL (defaults to "index").
        /// </summary>
        public string ManifestName { get; set; }

        /// <summary>
        /// Checks to see if the ManifestName property is set.
        /// </summary>
        internal bool IsSetManifestName() => this.ManifestName != null;

        /// <summary>
        /// Gets and sets the property MssPackage.
        /// </summary>
        public MssPackage MssPackage { get; set; }

        /// <summary>
        /// Checks to see if the MssPackage property is set.
        /// </summary>
        internal bool IsSetMssPackage() => this.MssPackage != null;

        /// <summary>
        /// Gets and sets the property Origination. Control whether origination of video is allowed
        /// for this OriginEndpoint. If set to ALLOW, the OriginEndpoint may by requested, pursuant
        /// to any other form of access control. If set to DENY, the OriginEndpoint may not be
        /// requested. This can be helpful for Live to VOD harvesting, or for temporarily disabling
        /// origination
        /// </summary>
        public Origination Origination { get; set; }

        /// <summary>
        /// Checks to see if the Origination property is set.
        /// </summary>
        internal bool IsSetOrigination() => this.Origination != null;

        /// <summary>
        /// Gets and sets the property StartoverWindowSeconds. Maximum duration (seconds) of content
        /// to retain for startover playback. If not specified, startover playback will be disabled
        /// for the OriginEndpoint.
        /// </summary>
        public int? StartoverWindowSeconds { get; set; }

        /// <summary>
        /// Checks to see if the StartoverWindowSeconds property is set.
        /// </summary>
        internal bool IsSetStartoverWindowSeconds() => this.StartoverWindowSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeDelaySeconds. Amount of delay (seconds) to enforce
        /// on the playback of live content. If not specified, there will be no time delay in
        /// effect for the OriginEndpoint.
        /// </summary>
        public int? TimeDelaySeconds { get; set; }

        /// <summary>
        /// Checks to see if the TimeDelaySeconds property is set.
        /// </summary>
        internal bool IsSetTimeDelaySeconds() => this.TimeDelaySeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Whitelist. A list of source IP CIDR blocks that will be
        /// allowed to access the OriginEndpoint.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Whitelist { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Whitelist property is set.
        /// </summary>
        internal bool IsSetWhitelist() => this.Whitelist != null && (this.Whitelist.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
