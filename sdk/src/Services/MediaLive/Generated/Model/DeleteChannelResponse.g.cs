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
    /// This is the response object from the DeleteChannel operation.
    /// </summary>
    public partial class DeleteChannelResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AnywhereSettings. Anywhere settings for this channel.
        /// </summary>
        public DescribeAnywhereSettings AnywhereSettings { get; set; }

        /// <summary>
        /// Checks to see if the AnywhereSettings property is set.
        /// </summary>
        internal bool IsSetAnywhereSettings() => this.AnywhereSettings != null;

        /// <summary>
        /// Gets and sets the property Arn. The unique arn of the channel.
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

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
        /// Gets and sets the property ChannelClass. The class for this channel. STANDARD for
        /// a channel with two pipelines or SINGLE_PIPELINE for a channel with one pipeline.
        /// </summary>
        public ChannelClass ChannelClass { get; set; }

        /// <summary>
        /// Checks to see if the ChannelClass property is set.
        /// </summary>
        internal bool IsSetChannelClass() => this.ChannelClass != null;

        /// <summary>
        /// Gets and sets the property ChannelEngineVersion. Requested engine version for this
        /// channel.
        /// </summary>
        public ChannelEngineVersionResponse ChannelEngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the ChannelEngineVersion property is set.
        /// </summary>
        internal bool IsSetChannelEngineVersion() => this.ChannelEngineVersion != null;

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
        /// Gets and sets the property Destinations. A list of destinations of the channel. For
        /// UDP outputs, there is one destination per output. For other types (HLS, for example),
        /// there is one destination per packager.
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
        /// Gets and sets the property EgressEndpoints. The endpoints where outgoing connections
        /// initiate from
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ChannelEgressEndpoint> EgressEndpoints { get; set; } = AWSConfigs.InitializeCollections ? new List<ChannelEgressEndpoint>() : null;

        /// <summary>
        /// Checks to see if the EgressEndpoints property is set.
        /// </summary>
        internal bool IsSetEgressEndpoints() => this.EgressEndpoints != null && (this.EgressEndpoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EncoderSettings.
        /// </summary>
        public EncoderSettings EncoderSettings { get; set; }

        /// <summary>
        /// Checks to see if the EncoderSettings property is set.
        /// </summary>
        internal bool IsSetEncoderSettings() => this.EncoderSettings != null;

        /// <summary>
        /// Gets and sets the property Id. The unique id of the channel.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InferenceSettings. Include this setting to include Elemental
        /// Inference features in this channel.
        /// </summary>
        public DescribeInferenceSettings InferenceSettings { get; set; }

        /// <summary>
        /// Checks to see if the InferenceSettings property is set.
        /// </summary>
        internal bool IsSetInferenceSettings() => this.InferenceSettings != null;

        /// <summary>
        /// Gets and sets the property InputAttachments. List of input attachments for channel.
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
        /// Gets and sets the property LinkedChannelSettings. Linked Channel Settings for this
        /// channel.
        /// </summary>
        public DescribeLinkedChannelSettings LinkedChannelSettings { get; set; }

        /// <summary>
        /// Checks to see if the LinkedChannelSettings property is set.
        /// </summary>
        internal bool IsSetLinkedChannelSettings() => this.LinkedChannelSettings != null;

        /// <summary>
        /// Gets and sets the property LogLevel. The log level being written to CloudWatch Logs.
        /// </summary>
        public LogLevel LogLevel { get; set; }

        /// <summary>
        /// Checks to see if the LogLevel property is set.
        /// </summary>
        internal bool IsSetLogLevel() => this.LogLevel != null;

        /// <summary>
        /// Gets and sets the property Maintenance. Maintenance settings for this channel.
        /// </summary>
        public MaintenanceStatus Maintenance { get; set; }

        /// <summary>
        /// Checks to see if the Maintenance property is set.
        /// </summary>
        internal bool IsSetMaintenance() => this.Maintenance != null;

        /// <summary>
        /// Gets and sets the property Name. The name of the channel. (user-mutable)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PipelineDetails. Runtime details for the pipelines of a
        /// running channel.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PipelineDetail> PipelineDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<PipelineDetail>() : null;

        /// <summary>
        /// Checks to see if the PipelineDetails property is set.
        /// </summary>
        internal bool IsSetPipelineDetails() => this.PipelineDetails != null && (this.PipelineDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PipelinesRunningCount. The number of currently healthy
        /// pipelines.
        /// </summary>
        public int? PipelinesRunningCount { get; set; }

        /// <summary>
        /// Checks to see if the PipelinesRunningCount property is set.
        /// </summary>
        internal bool IsSetPipelinesRunningCount() => this.PipelinesRunningCount.HasValue;

        /// <summary>
        /// Gets and sets the property RoleArn. The Amazon Resource Name (ARN) of the role assumed
        /// when running the Channel.
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property State.
        /// </summary>
        public ChannelState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. A collection of key-value pairs.
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
        /// Gets and sets the property Vpc. Settings for VPC output
        /// </summary>
        public VpcOutputSettingsDescription Vpc { get; set; }

        /// <summary>
        /// Checks to see if the Vpc property is set.
        /// </summary>
        internal bool IsSetVpc() => this.Vpc != null;
    }
}
