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
    /// Container for the parameters to the ModifyReplicationConfig operation. Modifies an
    /// existing DMS Serverless replication configuration that you can use to start a replication.
    /// This command includes input validation and logic to check the state of any replication
    /// that uses this configuration. You can only modify a replication configuration before
    /// any replication that uses it has started. As soon as you have initially started a
    /// replication with a given configuiration, you can't modify that configuration, even
    /// if you stop it. <para> Other run statuses that allow you to run this command include
    /// FAILED and CREATED. A provisioning state that allows you to run this command is FAILED_PROVISION.
    /// </para>
    /// </summary>
    public partial class ModifyReplicationConfigRequest : AmazonDatabaseMigrationServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ComputeConfig. 
        /// <para>
        /// Configuration parameters for provisioning an DMS Serverless replication.
        /// </para>
        /// </summary>
        public ComputeConfig ComputeConfig { get; set; }

        /// <summary>
        /// Checks to see if the ComputeConfig property is set.
        /// </summary>
        internal bool IsSetComputeConfig() => this.ComputeConfig != null;

        /// <summary>
        /// Gets and sets the property ReplicationConfigArn. 
        /// <para>
        /// The Amazon Resource Name of the replication to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReplicationConfigArn { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationConfigArn property is set.
        /// </summary>
        internal bool IsSetReplicationConfigArn() => this.ReplicationConfigArn != null;

        /// <summary>
        /// Gets and sets the property ReplicationConfigIdentifier. 
        /// <para>
        /// The new replication config to apply to the replication.
        /// </para>
        /// </summary>
        public string ReplicationConfigIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationConfigIdentifier property is set.
        /// </summary>
        internal bool IsSetReplicationConfigIdentifier() => this.ReplicationConfigIdentifier != null;

        /// <summary>
        /// Gets and sets the property ReplicationSettings. 
        /// <para>
        /// The settings for the replication.
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
        /// The type of replication.
        /// </para>
        /// </summary>
        public MigrationTypeValue ReplicationType { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationType property is set.
        /// </summary>
        internal bool IsSetReplicationType() => this.ReplicationType != null;

        /// <summary>
        /// Gets and sets the property SourceEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source endpoint for this DMS serverless replication
        /// configuration.
        /// </para>
        /// </summary>
        public string SourceEndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceEndpointArn property is set.
        /// </summary>
        internal bool IsSetSourceEndpointArn() => this.SourceEndpointArn != null;

        /// <summary>
        /// Gets and sets the property SupplementalSettings. 
        /// <para>
        /// Additional settings for the replication.
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
        /// Table mappings specified in the replication.
        /// </para>
        /// </summary>
        public string TableMappings { get; set; }

        /// <summary>
        /// Checks to see if the TableMappings property is set.
        /// </summary>
        internal bool IsSetTableMappings() => this.TableMappings != null;

        /// <summary>
        /// Gets and sets the property TargetEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the target endpoint for this DMS serverless replication
        /// configuration.
        /// </para>
        /// </summary>
        public string TargetEndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetEndpointArn property is set.
        /// </summary>
        internal bool IsSetTargetEndpointArn() => this.TargetEndpointArn != null;
    }
}
