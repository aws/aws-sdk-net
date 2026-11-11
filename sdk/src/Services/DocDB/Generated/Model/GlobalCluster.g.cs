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

namespace Amazon.DocDB.Model
{
    /// <summary>
    /// A data type representing an Amazon DocumentDB global cluster.
    /// </summary>
    public partial class GlobalCluster
    {
        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The default database name within the new global cluster.
        /// </para>
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// The deletion protection setting for the new global cluster.
        /// </para>
        /// </summary>
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtection property is set.
        /// </summary>
        internal bool IsSetDeletionProtection() => this.DeletionProtection.HasValue;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The Amazon DocumentDB database engine used by the global cluster. 
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// Indicates the database engine version.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property FailoverState. 
        /// <para>
        /// A data object containing all properties for the current state of an in-process or
        /// pending switchover or failover process for this global cluster. This object is empty
        /// unless the <c>SwitchoverGlobalCluster</c> or <c>FailoverGlobalCluster</c> operation
        /// was called on this global cluster.
        /// </para>
        /// </summary>
        public FailoverState FailoverState { get; set; }

        /// <summary>
        /// Checks to see if the FailoverState property is set.
        /// </summary>
        internal bool IsSetFailoverState() => this.FailoverState != null;

        /// <summary>
        /// Gets and sets the property GlobalClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the global cluster.
        /// </para>
        /// </summary>
        public string GlobalClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the GlobalClusterArn property is set.
        /// </summary>
        internal bool IsSetGlobalClusterArn() => this.GlobalClusterArn != null;

        /// <summary>
        /// Gets and sets the property GlobalClusterIdentifier. 
        /// <para>
        /// Contains a user-supplied global cluster identifier. This identifier is the unique
        /// key that identifies a global cluster. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string GlobalClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the GlobalClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetGlobalClusterIdentifier() => this.GlobalClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property GlobalClusterMembers. 
        /// <para>
        /// The list of cluster IDs for secondary clusters within the global cluster. Currently
        /// limited to one item. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GlobalClusterMember> GlobalClusterMembers { get; set; } = AWSConfigs.InitializeCollections ? new List<GlobalClusterMember>() : null;

        /// <summary>
        /// Checks to see if the GlobalClusterMembers property is set.
        /// </summary>
        internal bool IsSetGlobalClusterMembers() => this.GlobalClusterMembers != null && (this.GlobalClusterMembers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GlobalClusterResourceId. 
        /// <para>
        /// The Amazon Web Services RegionRegion-unique, immutable identifier for the global database
        /// cluster. This identifier is found in CloudTrail log entries whenever the KMS customer
        /// master key (CMK) for the cluster is accessed. 
        /// </para>
        /// </summary>
        public string GlobalClusterResourceId { get; set; }

        /// <summary>
        /// Checks to see if the GlobalClusterResourceId property is set.
        /// </summary>
        internal bool IsSetGlobalClusterResourceId() => this.GlobalClusterResourceId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies the current state of this global cluster.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StorageEncrypted. 
        /// <para>
        /// The storage encryption setting for the global cluster.
        /// </para>
        /// </summary>
        public bool? StorageEncrypted { get; set; }

        /// <summary>
        /// Checks to see if the StorageEncrypted property is set.
        /// </summary>
        internal bool IsSetStorageEncrypted() => this.StorageEncrypted.HasValue;

        /// <summary>
        /// Gets and sets the property TagList. 
        /// <para>
        /// A list of global cluster tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> TagList { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the TagList property is set.
        /// </summary>
        internal bool IsSetTagList() => this.TagList != null && (this.TagList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
