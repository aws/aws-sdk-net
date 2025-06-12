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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
    /// Container for the parameters to the CreateReplicationConfig operation.
    /// Creates a configuration that you can later provide to configure and start an DMS Serverless
    /// replication. You can also provide options to validate the configuration inputs before
    /// you start the replication.
    /// </summary>
    public partial class CreateReplicationConfigRequest : AmazonDatabaseMigrationServiceRequest
    {
        private ComputeConfig _computeConfig;
        private string _replicationConfigIdentifier;
        private string _replicationSettings;
        private MigrationTypeValue _replicationType;
        private string _resourceIdentifier;
        private string _sourceEndpointArn;
        private string _supplementalSettings;
        private string _tableMappings;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _targetEndpointArn;

        /// <summary>
        /// Gets and sets the property ComputeConfig. 
        /// <para>
        /// Configuration parameters for provisioning an DMS Serverless replication.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ComputeConfig ComputeConfig
        {
            get { return this._computeConfig; }
            set { this._computeConfig = value; }
        }

        // Check to see if ComputeConfig property is set
        internal bool IsSetComputeConfig()
        {
            return this._computeConfig != null;
        }

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
        [AWSProperty(Required=true)]
        public string ReplicationConfigIdentifier
        {
            get { return this._replicationConfigIdentifier; }
            set { this._replicationConfigIdentifier = value; }
        }

        // Check to see if ReplicationConfigIdentifier property is set
        internal bool IsSetReplicationConfigIdentifier()
        {
            return this._replicationConfigIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationSettings. 
        /// <para>
        /// Optional JSON settings for DMS Serverless replications that are provisioned using
        /// this replication configuration. For example, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tasks.CustomizingTasks.TaskSettings.ChangeProcessingTuning.html">
        /// Change processing tuning settings</a>.
        /// </para>
        /// </summary>
        public string ReplicationSettings
        {
            get { return this._replicationSettings; }
            set { this._replicationSettings = value; }
        }

        // Check to see if ReplicationSettings property is set
        internal bool IsSetReplicationSettings()
        {
            return this._replicationSettings != null;
        }

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
        [AWSProperty(Required=true)]
        public MigrationTypeValue ReplicationType
        {
            get { return this._replicationType; }
            set { this._replicationType = value; }
        }

        // Check to see if ReplicationType property is set
        internal bool IsSetReplicationType()
        {
            return this._replicationType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// Optional unique value or name that you set for a given resource that can be used to
        /// construct an Amazon Resource Name (ARN) for that resource. For more information, see
        /// <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Security.html#CHAP_Security.FineGrainedAccess">
        /// Fine-grained access control using resource names and tags</a>.
        /// </para>
        /// </summary>
        public string ResourceIdentifier
        {
            get { return this._resourceIdentifier; }
            set { this._resourceIdentifier = value; }
        }

        // Check to see if ResourceIdentifier property is set
        internal bool IsSetResourceIdentifier()
        {
            return this._resourceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SourceEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source endpoint for this DMS Serverless replication
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceEndpointArn
        {
            get { return this._sourceEndpointArn; }
            set { this._sourceEndpointArn = value; }
        }

        // Check to see if SourceEndpointArn property is set
        internal bool IsSetSourceEndpointArn()
        {
            return this._sourceEndpointArn != null;
        }

        /// <summary>
        /// Gets and sets the property SupplementalSettings. 
        /// <para>
        /// Optional JSON settings for specifying supplemental data. For more information, see
        /// <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tasks.TaskData.html">
        /// Specifying supplemental data for task settings</a>.
        /// </para>
        /// </summary>
        public string SupplementalSettings
        {
            get { return this._supplementalSettings; }
            set { this._supplementalSettings = value; }
        }

        // Check to see if SupplementalSettings property is set
        internal bool IsSetSupplementalSettings()
        {
            return this._supplementalSettings != null;
        }

        /// <summary>
        /// Gets and sets the property TableMappings. 
        /// <para>
        /// JSON table mappings for DMS Serverless replications that are provisioned using this
        /// replication configuration. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tasks.CustomizingTasks.TableMapping.SelectionTransformation.html">
        /// Specifying table selection and transformations rules using JSON</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TableMappings
        {
            get { return this._tableMappings; }
            set { this._tableMappings = value; }
        }

        // Check to see if TableMappings property is set
        internal bool IsSetTableMappings()
        {
            return this._tableMappings != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more optional tags associated with resources used by the DMS Serverless replication.
        /// For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tagging.html">
        /// Tagging resources in Database Migration Service</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the target endpoint for this DMS serverless replication
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetEndpointArn
        {
            get { return this._targetEndpointArn; }
            set { this._targetEndpointArn = value; }
        }

        // Check to see if TargetEndpointArn property is set
        internal bool IsSetTargetEndpointArn()
        {
            return this._targetEndpointArn != null;
        }

    }
}