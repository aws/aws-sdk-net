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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateReplicationConfig operation. Creates a configuration
    /// that you can later provide to configure and start an DMS Serverless replication. You
    /// can also provide options to validate the configuration inputs before you start the
    /// replication.
    /// </summary>
    public partial class CreateReplicationConfigRequest : AmazonDatabaseMigrationServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ComputeConfig. 
        /// <para>
        /// Configuration parameters for provisioning an DMS Serverless replication.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ComputeConfig ComputeConfig { get; set; }

        /// <summary>
        /// Checks to see if the ComputeConfig property is set.
        /// </summary>
        internal bool IsSetComputeConfig() => this.ComputeConfig != null;

        /// <summary>
        /// Gets and sets the property ReplicationConfigIdentifier. 
        /// <para>
        /// A unique identifier that you want to use to create a <c>ReplicationConfigArn</c> that
        /// is returned as part of the output from this action. You can then pass this output
        /// <c>ReplicationConfigArn</c> as the value of the <c>ReplicationConfigArn</c> option
        /// for other actions to identify both DMS Serverless replications and replication configurations
        /// that you want those actions to operate on. For some actions, you can also use either
        /// this unique identifier or a corresponding ARN in action filters to identify the specific
        /// replication and replication configuration to operate on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReplicationConfigIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationConfigIdentifier property is set.
        /// </summary>
        internal bool IsSetReplicationConfigIdentifier() => this.ReplicationConfigIdentifier != null;

        /// <summary>
        /// Gets and sets the property ReplicationSettings. 
        /// <para>
        /// Optional JSON settings for DMS Serverless replications that are provisioned using
        /// this replication configuration. For example, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tasks.CustomizingTasks.TaskSettings.ChangeProcessingTuning.html">
        /// Change processing tuning settings</a>.
        /// </para>
        /// </summary>
        public string ReplicationSettings { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationSettings property is set.
        /// </summary>
        internal bool IsSetReplicationSettings() => this.ReplicationSettings != null;

        /// <summary>
        /// Gets and sets the property ReplicationType. 
        /// <para>
        /// The type of DMS Serverless replication to provision using this replication configuration.
        /// </para>
        ///  
        /// <para>
        /// Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"full-load"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"cdc"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"full-load-and-cdc"</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public MigrationTypeValue ReplicationType { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationType property is set.
        /// </summary>
        internal bool IsSetReplicationType() => this.ReplicationType != null;

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// Optional unique value or name that you set for a given resource that can be used to
        /// construct an Amazon Resource Name (ARN) for that resource. For more information, see
        /// <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Security.html#CHAP_Security.FineGrainedAccess">
        /// Fine-grained access control using resource names and tags</a>.
        /// </para>
        /// </summary>
        public string ResourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceIdentifier() => this.ResourceIdentifier != null;

        /// <summary>
        /// Gets and sets the property SourceEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source endpoint for this DMS Serverless replication
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceEndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceEndpointArn property is set.
        /// </summary>
        internal bool IsSetSourceEndpointArn() => this.SourceEndpointArn != null;

        /// <summary>
        /// Gets and sets the property SupplementalSettings. 
        /// <para>
        /// Optional JSON settings for specifying supplemental data. For more information, see
        /// <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tasks.TaskData.html">
        /// Specifying supplemental data for task settings</a>.
        /// </para>
        /// </summary>
        public string SupplementalSettings { get; set; }

        /// <summary>
        /// Checks to see if the SupplementalSettings property is set.
        /// </summary>
        internal bool IsSetSupplementalSettings() => this.SupplementalSettings != null;

        /// <summary>
        /// Gets and sets the property TableMappings. 
        /// <para>
        /// JSON table mappings for DMS Serverless replications that are provisioned using this
        /// replication configuration. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tasks.CustomizingTasks.TableMapping.SelectionTransformation.html">
        /// Specifying table selection and transformations rules using JSON</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TableMappings { get; set; }

        /// <summary>
        /// Checks to see if the TableMappings property is set.
        /// </summary>
        internal bool IsSetTableMappings() => this.TableMappings != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more optional tags associated with resources used by the DMS Serverless replication.
        /// For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tagging.html">
        /// Tagging resources in Database Migration Service</a>.
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
        /// Gets and sets the property TargetEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the target endpoint for this DMS serverless replication
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetEndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetEndpointArn property is set.
        /// </summary>
        internal bool IsSetTargetEndpointArn() => this.TargetEndpointArn != null;
    }
}
