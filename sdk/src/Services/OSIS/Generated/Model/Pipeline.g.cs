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

namespace Amazon.OSIS.Model
{
    /// <summary>
    /// Information about an existing OpenSearch Ingestion pipeline.
    /// </summary>
    public partial class Pipeline
    {
        /// <summary>
        /// Gets and sets the property BufferOptions.
        /// </summary>
        public BufferOptions BufferOptions { get; set; }

        /// <summary>
        /// Checks to see if the BufferOptions property is set.
        /// </summary>
        internal bool IsSetBufferOptions() => this.BufferOptions != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the pipeline was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// Destinations to which the pipeline writes data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PipelineDestination> Destinations { get; set; } = AWSConfigs.InitializeCollections ? new List<PipelineDestination>() : null;

        /// <summary>
        /// Checks to see if the Destinations property is set.
        /// </summary>
        internal bool IsSetDestinations() => this.Destinations != null && (this.Destinations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EncryptionAtRestOptions.
        /// </summary>
        public EncryptionAtRestOptions EncryptionAtRestOptions { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionAtRestOptions property is set.
        /// </summary>
        internal bool IsSetEncryptionAtRestOptions() => this.EncryptionAtRestOptions != null;

        /// <summary>
        /// Gets and sets the property IngestEndpointUrls. 
        /// <para>
        /// The ingestion endpoints for the pipeline, which you can send data to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IngestEndpointUrls { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IngestEndpointUrls property is set.
        /// </summary>
        internal bool IsSetIngestEndpointUrls() => this.IngestEndpointUrls != null && (this.IngestEndpointUrls.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The date and time when the pipeline was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LogPublishingOptions. 
        /// <para>
        /// Key-value pairs that represent log publishing settings.
        /// </para>
        /// </summary>
        public LogPublishingOptions LogPublishingOptions { get; set; }

        /// <summary>
        /// Checks to see if the LogPublishingOptions property is set.
        /// </summary>
        internal bool IsSetLogPublishingOptions() => this.LogPublishingOptions != null;

        /// <summary>
        /// Gets and sets the property MaxUnits. 
        /// <para>
        /// The maximum pipeline capacity, in Ingestion Compute Units (ICUs).
        /// </para>
        /// </summary>
        public int? MaxUnits { get; set; }

        /// <summary>
        /// Checks to see if the MaxUnits property is set.
        /// </summary>
        internal bool IsSetMaxUnits() => this.MaxUnits.HasValue;

        /// <summary>
        /// Gets and sets the property MinUnits. 
        /// <para>
        /// The minimum pipeline capacity, in Ingestion Compute Units (ICUs).
        /// </para>
        /// </summary>
        public int? MinUnits { get; set; }

        /// <summary>
        /// Checks to see if the MinUnits property is set.
        /// </summary>
        internal bool IsSetMinUnits() => this.MinUnits.HasValue;

        /// <summary>
        /// Gets and sets the property PipelineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the pipeline.
        /// </para>
        /// </summary>
        public string PipelineArn { get; set; }

        /// <summary>
        /// Checks to see if the PipelineArn property is set.
        /// </summary>
        internal bool IsSetPipelineArn() => this.PipelineArn != null;

        /// <summary>
        /// Gets and sets the property PipelineConfigurationBody. 
        /// <para>
        /// The Data Prepper pipeline configuration in YAML format.
        /// </para>
        /// </summary>
        public string PipelineConfigurationBody { get; set; }

        /// <summary>
        /// Checks to see if the PipelineConfigurationBody property is set.
        /// </summary>
        internal bool IsSetPipelineConfigurationBody() => this.PipelineConfigurationBody != null;

        /// <summary>
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline.
        /// </para>
        /// </summary>
        public string PipelineName { get; set; }

        /// <summary>
        /// Checks to see if the PipelineName property is set.
        /// </summary>
        internal bool IsSetPipelineName() => this.PipelineName != null;

        /// <summary>
        /// Gets and sets the property PipelineRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that the pipeline uses to access AWS
        /// resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string PipelineRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the PipelineRoleArn property is set.
        /// </summary>
        internal bool IsSetPipelineRoleArn() => this.PipelineRoleArn != null;

        /// <summary>
        /// Gets and sets the property ServiceVpcEndpoints. 
        /// <para>
        /// A list of VPC endpoints that OpenSearch Ingestion has created to other Amazon Web
        /// Services services.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceVpcEndpoint> ServiceVpcEndpoints { get; set; } = AWSConfigs.InitializeCollections ? new List<ServiceVpcEndpoint>() : null;

        /// <summary>
        /// Checks to see if the ServiceVpcEndpoints property is set.
        /// </summary>
        internal bool IsSetServiceVpcEndpoints() => this.ServiceVpcEndpoints != null && (this.ServiceVpcEndpoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the pipeline.
        /// </para>
        /// </summary>
        public PipelineStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the current status of the pipeline.
        /// </para>
        /// </summary>
        public PipelineStatusReason StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags associated with the given pipeline.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcEndpointService. 
        /// <para>
        /// The VPC endpoint service name for the pipeline.
        /// </para>
        /// </summary>
        public string VpcEndpointService { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointService property is set.
        /// </summary>
        internal bool IsSetVpcEndpointService() => this.VpcEndpointService != null;

        /// <summary>
        /// Gets and sets the property VpcEndpoints. 
        /// <para>
        /// The VPC interface endpoints that have access to the pipeline.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcEndpoint> VpcEndpoints { get; set; } = AWSConfigs.InitializeCollections ? new List<VpcEndpoint>() : null;

        /// <summary>
        /// Checks to see if the VpcEndpoints property is set.
        /// </summary>
        internal bool IsSetVpcEndpoints() => this.VpcEndpoints != null && (this.VpcEndpoints.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
