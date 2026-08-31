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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// A router input in AWS Elemental MediaConnect. A router input is a source of media
    /// content that can be routed to one or more router outputs.
    /// </summary>
    public partial class RouterInput
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property Configuration.
        /// </summary>
        [AWSProperty(Required = true)]
        public RouterInputConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property ContentQualityAnalysisConfiguration. 
        /// <para>
        /// The content quality analysis configuration for the router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouterContentQualityAnalysisConfiguration ContentQualityAnalysisConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ContentQualityAnalysisConfiguration property is set.
        /// </summary>
        internal bool IsSetContentQualityAnalysisConfiguration() => this.ContentQualityAnalysisConfiguration != null;

        /// <summary>
        /// Gets and sets the property ContentQualityAnalysisType. 
        /// <para>
        /// The type of content quality analysis applied to the router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouterContentQualityAnalysisType ContentQualityAnalysisType { get; set; }

        /// <summary>
        /// Checks to see if the ContentQualityAnalysisType property is set.
        /// </summary>
        internal bool IsSetContentQualityAnalysisType() => this.ContentQualityAnalysisType != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the router input was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InputType. 
        /// <para>
        /// The type of the router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouterInputType InputType { get; set; }

        /// <summary>
        /// Checks to see if the InputType property is set.
        /// </summary>
        internal bool IsSetInputType() => this.InputType != null;

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address of the router input.
        /// </para>
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// Checks to see if the IpAddress property is set.
        /// </summary>
        internal bool IsSetIpAddress() => this.IpAddress != null;

        /// <summary>
        /// Gets and sets the property MaintenanceConfiguration. 
        /// <para>
        /// The maintenance configuration settings applied to this router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MaintenanceConfiguration MaintenanceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceConfiguration property is set.
        /// </summary>
        internal bool IsSetMaintenanceConfiguration() => this.MaintenanceConfiguration != null;

        /// <summary>
        /// Gets and sets the property MaintenanceSchedule. 
        /// <para>
        /// The current maintenance schedule details for this router input.
        /// </para>
        /// </summary>
        public MaintenanceSchedule MaintenanceSchedule { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceSchedule property is set.
        /// </summary>
        internal bool IsSetMaintenanceSchedule() => this.MaintenanceSchedule != null;

        /// <summary>
        /// Gets and sets the property MaintenanceScheduleType. 
        /// <para>
        /// The type of maintenance schedule currently in effect for this router input.
        /// </para>
        /// </summary>
        public MaintenanceScheduleType MaintenanceScheduleType { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceScheduleType property is set.
        /// </summary>
        internal bool IsSetMaintenanceScheduleType() => this.MaintenanceScheduleType != null;

        /// <summary>
        /// Gets and sets the property MaintenanceType. 
        /// <para>
        /// The type of maintenance configuration applied to this router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MaintenanceType MaintenanceType { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceType property is set.
        /// </summary>
        internal bool IsSetMaintenanceType() => this.MaintenanceType != null;

        /// <summary>
        /// Gets and sets the property MaximumBitrate. 
        /// <para>
        /// The maximum bitrate for the router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? MaximumBitrate { get; set; }

        /// <summary>
        /// Checks to see if the MaximumBitrate property is set.
        /// </summary>
        internal bool IsSetMaximumBitrate() => this.MaximumBitrate.HasValue;

        /// <summary>
        /// Gets and sets the property MaximumRoutedOutputs. 
        /// <para>
        /// The maximum number of outputs that can be simultaneously routed to this input.
        /// </para>
        /// </summary>
        public int? MaximumRoutedOutputs { get; set; }

        /// <summary>
        /// Checks to see if the MaximumRoutedOutputs property is set.
        /// </summary>
        internal bool IsSetMaximumRoutedOutputs() => this.MaximumRoutedOutputs.HasValue;

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// The messages associated with the router input.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouterInputMessage> Messages { get; set; } = AWSConfigs.InitializeCollections ? new List<RouterInputMessage>() : null;

        /// <summary>
        /// Checks to see if the Messages property is set.
        /// </summary>
        internal bool IsSetMessages() => this.Messages != null && (this.Messages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The Amazon Web Services Region where the router input is located.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RegionName { get; set; }

        /// <summary>
        /// Checks to see if the RegionName property is set.
        /// </summary>
        internal bool IsSetRegionName() => this.RegionName != null;

        /// <summary>
        /// Gets and sets the property RoutedOutputs. 
        /// <para>
        /// The number of router outputs associated with the router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? RoutedOutputs { get; set; }

        /// <summary>
        /// Checks to see if the RoutedOutputs property is set.
        /// </summary>
        internal bool IsSetRoutedOutputs() => this.RoutedOutputs.HasValue;

        /// <summary>
        /// Gets and sets the property RoutingScope. 
        /// <para>
        /// Indicates whether the router input is configured for Regional or global routing.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RoutingScope RoutingScope { get; set; }

        /// <summary>
        /// Checks to see if the RoutingScope property is set.
        /// </summary>
        internal bool IsSetRoutingScope() => this.RoutingScope != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouterInputState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StreamDetails.
        /// </summary>
        [AWSProperty(Required = true)]
        public RouterInputStreamDetails StreamDetails { get; set; }

        /// <summary>
        /// Checks to see if the StreamDetails property is set.
        /// </summary>
        internal bool IsSetStreamDetails() => this.StreamDetails != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs that can be used to tag and organize this router input.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The tier level of the router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouterInputTier Tier { get; set; }

        /// <summary>
        /// Checks to see if the Tier property is set.
        /// </summary>
        internal bool IsSetTier() => this.Tier != null;

        /// <summary>
        /// Gets and sets the property TransitEncryption.
        /// </summary>
        [AWSProperty(Required = true)]
        public RouterInputTransitEncryption TransitEncryption { get; set; }

        /// <summary>
        /// Checks to see if the TransitEncryption property is set.
        /// </summary>
        internal bool IsSetTransitEncryption() => this.TransitEncryption != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the router input was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
