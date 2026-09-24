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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// This is the response object from the DescribeFlow operation.
    /// </summary>
    public partial class DescribeFlowResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  Specifies when the flow was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        ///  The ARN of the user who created the flow. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the flow. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DestinationFlowConfigList. 
        /// <para>
        ///  The configuration that controls how Amazon AppFlow transfers data to the destination
        /// connector. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DestinationFlowConfig> DestinationFlowConfigList { get; set; } = AWSConfigs.InitializeCollections ? new List<DestinationFlowConfig>() : null;

        /// <summary>
        /// Checks to see if the DestinationFlowConfigList property is set.
        /// </summary>
        internal bool IsSetDestinationFlowConfigList() => this.DestinationFlowConfigList != null && (this.DestinationFlowConfigList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FlowArn. 
        /// <para>
        ///  The flow's Amazon Resource Name (ARN). 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string FlowArn { get; set; }

        /// <summary>
        /// Checks to see if the FlowArn property is set.
        /// </summary>
        internal bool IsSetFlowArn() => this.FlowArn != null;

        /// <summary>
        /// Gets and sets the property FlowName. 
        /// <para>
        ///  The specified name of the flow. Spaces are not allowed. Use underscores (_) or hyphens
        /// (-) only. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string FlowName { get; set; }

        /// <summary>
        /// Checks to see if the FlowName property is set.
        /// </summary>
        internal bool IsSetFlowName() => this.FlowName != null;

        /// <summary>
        /// Gets and sets the property FlowStatus. 
        /// <para>
        ///  Indicates the current status of the flow. 
        /// </para>
        /// </summary>
        public FlowStatus FlowStatus { get; set; }

        /// <summary>
        /// Checks to see if the FlowStatus property is set.
        /// </summary>
        internal bool IsSetFlowStatus() => this.FlowStatus != null;

        /// <summary>
        /// Gets and sets the property FlowStatusMessage. 
        /// <para>
        ///  Contains an error message if the flow status is in a suspended or error state. This
        /// applies only to scheduled or event-triggered flows. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string FlowStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the FlowStatusMessage property is set.
        /// </summary>
        internal bool IsSetFlowStatusMessage() => this.FlowStatusMessage != null;

        /// <summary>
        /// Gets and sets the property KmsArn. 
        /// <para>
        ///  The ARN (Amazon Resource Name) of the Key Management Service (KMS) key you provide
        /// for encryption. This is required if you do not want to use the Amazon AppFlow-managed
        /// KMS key. If you don't provide anything here, Amazon AppFlow uses the Amazon AppFlow-managed
        /// KMS key. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string KmsArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsArn property is set.
        /// </summary>
        internal bool IsSetKmsArn() => this.KmsArn != null;

        /// <summary>
        /// Gets and sets the property LastRunExecutionDetails. 
        /// <para>
        ///  Describes the details of the most recent flow run. 
        /// </para>
        /// </summary>
        public ExecutionDetails LastRunExecutionDetails { get; set; }

        /// <summary>
        /// Checks to see if the LastRunExecutionDetails property is set.
        /// </summary>
        internal bool IsSetLastRunExecutionDetails() => this.LastRunExecutionDetails != null;

        /// <summary>
        /// Gets and sets the property LastRunMetadataCatalogDetails. 
        /// <para>
        /// Describes the metadata catalog, metadata table, and data partitions that Amazon AppFlow
        /// used for the associated flow run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetadataCatalogDetail> LastRunMetadataCatalogDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<MetadataCatalogDetail>() : null;

        /// <summary>
        /// Checks to see if the LastRunMetadataCatalogDetails property is set.
        /// </summary>
        internal bool IsSetLastRunMetadataCatalogDetails() => this.LastRunMetadataCatalogDetails != null && (this.LastRunMetadataCatalogDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        ///  Specifies when the flow was last updated. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedBy. 
        /// <para>
        ///  Specifies the user name of the account that performed the most recent update. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string LastUpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedBy property is set.
        /// </summary>
        internal bool IsSetLastUpdatedBy() => this.LastUpdatedBy != null;

        /// <summary>
        /// Gets and sets the property MetadataCatalogConfig. 
        /// <para>
        /// Specifies the configuration that Amazon AppFlow uses when it catalogs the data that's
        /// transferred by the associated flow. When Amazon AppFlow catalogs the data from a flow,
        /// it stores metadata in a data catalog.
        /// </para>
        /// </summary>
        public MetadataCatalogConfig MetadataCatalogConfig { get; set; }

        /// <summary>
        /// Checks to see if the MetadataCatalogConfig property is set.
        /// </summary>
        internal bool IsSetMetadataCatalogConfig() => this.MetadataCatalogConfig != null;

        /// <summary>
        /// Gets and sets the property SchemaVersion. 
        /// <para>
        /// The version number of your data schema. Amazon AppFlow assigns this version number.
        /// The version number increases by one when you change any of the following settings
        /// in your flow configuration:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Source-to-destination field mappings
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Field data types
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Partition keys
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public long? SchemaVersion { get; set; }

        /// <summary>
        /// Checks to see if the SchemaVersion property is set.
        /// </summary>
        internal bool IsSetSchemaVersion() => this.SchemaVersion.HasValue;

        /// <summary>
        /// Gets and sets the property SourceFlowConfig. 
        /// <para>
        ///  The configuration that controls how Amazon AppFlow retrieves data from the source
        /// connector. 
        /// </para>
        /// </summary>
        public SourceFlowConfig SourceFlowConfig { get; set; }

        /// <summary>
        /// Checks to see if the SourceFlowConfig property is set.
        /// </summary>
        internal bool IsSetSourceFlowConfig() => this.SourceFlowConfig != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The tags used to organize, track, or control access for your flow. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tasks. 
        /// <para>
        ///  A list of tasks that Amazon AppFlow performs while transferring the data in the flow
        /// run. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Task> Tasks { get; set; } = AWSConfigs.InitializeCollections ? new List<Task>() : null;

        /// <summary>
        /// Checks to see if the Tasks property is set.
        /// </summary>
        internal bool IsSetTasks() => this.Tasks != null && (this.Tasks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TriggerConfig. 
        /// <para>
        ///  The trigger settings that determine how and when the flow runs. 
        /// </para>
        /// </summary>
        public TriggerConfig TriggerConfig { get; set; }

        /// <summary>
        /// Checks to see if the TriggerConfig property is set.
        /// </summary>
        internal bool IsSetTriggerConfig() => this.TriggerConfig != null;
    }
}
