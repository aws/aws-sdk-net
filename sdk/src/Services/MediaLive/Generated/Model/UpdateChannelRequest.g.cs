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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateChannel operation. Updates a channel.
    /// </summary>
    public partial class UpdateChannelRequest : AmazonMediaLiveRequest
    {
        /// <summary>
        /// Gets and sets the property AnywhereSettings. The Elemental Anywhere settings for this
        /// channel.
        /// </summary>
        public AnywhereSettings AnywhereSettings { get; set; }

        /// <summary>
        /// Checks to see if the AnywhereSettings property is set.
        /// </summary>
        internal bool IsSetAnywhereSettings() => this.AnywhereSettings != null;

        /// <summary>
        /// Gets and sets the property CdiInputSpecification. Specification of CDI inputs for
        /// this channel
        /// </summary>
        public CdiInputSpecification CdiInputSpecification { get; set; }

        /// <summary>
        /// Checks to see if the CdiInputSpecification property is set.
        /// </summary>
        internal bool IsSetCdiInputSpecification() => this.CdiInputSpecification != null;

        /// <summary>
        /// Gets and sets the property ChannelEngineVersion. Channel engine version for this channel
        /// </summary>
        public ChannelEngineVersionRequest ChannelEngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the ChannelEngineVersion property is set.
        /// </summary>
        internal bool IsSetChannelEngineVersion() => this.ChannelEngineVersion != null;

        /// <summary>
        /// Gets and sets the property ChannelId. channel ID
        /// </summary>
        [AWSProperty(Required = true)]
        public string ChannelId { get; set; }

        /// <summary>
        /// Checks to see if the ChannelId property is set.
        /// </summary>
        internal bool IsSetChannelId() => this.ChannelId != null;

        /// <summary>
        /// Gets and sets the property ChannelSecurityGroups. A list of IDs for all the Input
        /// Security Groups attached to the channel.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ChannelSecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ChannelSecurityGroups property is set.
        /// </summary>
        internal bool IsSetChannelSecurityGroups() => this.ChannelSecurityGroups != null && (this.ChannelSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Destinations. A list of output destinations for this channel.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OutputDestination> Destinations { get; set; } = AWSConfigs.InitializeCollections ? new List<OutputDestination>() : null;

        /// <summary>
        /// Checks to see if the Destinations property is set.
        /// </summary>
        internal bool IsSetDestinations() => this.Destinations != null && (this.Destinations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DryRun.
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property EncoderSettings. The encoder settings for this channel.
        /// </summary>
        public EncoderSettings EncoderSettings { get; set; }

        /// <summary>
        /// Checks to see if the EncoderSettings property is set.
        /// </summary>
        internal bool IsSetEncoderSettings() => this.EncoderSettings != null;

        /// <summary>
        /// Gets and sets the property InferenceSettings. Include this setting to include Elemental
        /// Inference features in this channel.
        /// </summary>
        public InferenceSettings InferenceSettings { get; set; }

        /// <summary>
        /// Checks to see if the InferenceSettings property is set.
        /// </summary>
        internal bool IsSetInferenceSettings() => this.InferenceSettings != null;

        /// <summary>
        /// Gets and sets the property InputAttachments.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputAttachment> InputAttachments { get; set; } = AWSConfigs.InitializeCollections ? new List<InputAttachment>() : null;

        /// <summary>
        /// Checks to see if the InputAttachments property is set.
        /// </summary>
        internal bool IsSetInputAttachments() => this.InputAttachments != null && (this.InputAttachments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InputSpecification. Specification of network and file inputs
        /// for this channel
        /// </summary>
        public InputSpecification InputSpecification { get; set; }

        /// <summary>
        /// Checks to see if the InputSpecification property is set.
        /// </summary>
        internal bool IsSetInputSpecification() => this.InputSpecification != null;

        /// <summary>
        /// Gets and sets the property LinkedChannelSettings. The linked channel settings for
        /// the channel.
        /// </summary>
        public LinkedChannelSettings LinkedChannelSettings { get; set; }

        /// <summary>
        /// Checks to see if the LinkedChannelSettings property is set.
        /// </summary>
        internal bool IsSetLinkedChannelSettings() => this.LinkedChannelSettings != null;

        /// <summary>
        /// Gets and sets the property LogLevel. The log level to write to CloudWatch Logs.
        /// </summary>
        public LogLevel LogLevel { get; set; }

        /// <summary>
        /// Checks to see if the LogLevel property is set.
        /// </summary>
        internal bool IsSetLogLevel() => this.LogLevel != null;

        /// <summary>
        /// Gets and sets the property Maintenance. Maintenance settings for this channel.
        /// </summary>
        public MaintenanceUpdateSettings Maintenance { get; set; }

        /// <summary>
        /// Checks to see if the Maintenance property is set.
        /// </summary>
        internal bool IsSetMaintenance() => this.Maintenance != null;

        /// <summary>
        /// Gets and sets the property Name. The name of the channel.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RoleArn. An optional Amazon Resource Name (ARN) of the
        /// role to assume when running the Channel. If you do not specify this on an update call
        /// but the role was previously set that role will be removed.
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SpecialRouterSettings. When using MediaConnect Router as
        /// the source of a MediaLive input there's a special handoff that occurs when a router
        /// output is created. This group of settings is set on your behalf by the MediaConnect
        /// Router service using this set of settings. This setting object can only by used by
        /// that service.
        /// </summary>
        public SpecialRouterSettings SpecialRouterSettings { get; set; }

        /// <summary>
        /// Checks to see if the SpecialRouterSettings property is set.
        /// </summary>
        internal bool IsSetSpecialRouterSettings() => this.SpecialRouterSettings != null;
    }
}
