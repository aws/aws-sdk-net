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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Contains the details of a tenant database in a snapshot of a DB instance.
    /// </summary>
    public partial class DBSnapshotTenantDatabase
    {
        /// <summary>
        /// Gets and sets the property CharacterSetName. 
        /// <para>
        /// The name of the character set of a tenant database.
        /// </para>
        /// </summary>
        public string CharacterSetName { get; set; }

        /// <summary>
        /// Checks to see if the CharacterSetName property is set.
        /// </summary>
        internal bool IsSetCharacterSetName() => this.CharacterSetName != null;

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// The ID for the DB instance that contains the tenant databases.
        /// </para>
        /// </summary>
        public string DBInstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetDBInstanceIdentifier() => this.DBInstanceIdentifier != null;

        /// <summary>
        /// Gets and sets the property DBSnapshotIdentifier. 
        /// <para>
        /// The identifier for the snapshot of the DB instance.
        /// </para>
        /// </summary>
        public string DBSnapshotIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBSnapshotIdentifier property is set.
        /// </summary>
        internal bool IsSetDBSnapshotIdentifier() => this.DBSnapshotIdentifier != null;

        /// <summary>
        /// Gets and sets the property DBSnapshotTenantDatabaseARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the snapshot tenant database.
        /// </para>
        /// </summary>
        public string DBSnapshotTenantDatabaseARN { get; set; }

        /// <summary>
        /// Checks to see if the DBSnapshotTenantDatabaseARN property is set.
        /// </summary>
        internal bool IsSetDBSnapshotTenantDatabaseARN() => this.DBSnapshotTenantDatabaseARN != null;

        /// <summary>
        /// Gets and sets the property DbiResourceId. 
        /// <para>
        /// The resource identifier of the source CDB instance. This identifier can't be changed
        /// and is unique to an Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string DbiResourceId { get; set; }

        /// <summary>
        /// Checks to see if the DbiResourceId property is set.
        /// </summary>
        internal bool IsSetDbiResourceId() => this.DbiResourceId != null;

        /// <summary>
        /// Gets and sets the property EngineName. 
        /// <para>
        /// The name of the database engine.
        /// </para>
        /// </summary>
        public string EngineName { get; set; }

        /// <summary>
        /// Checks to see if the EngineName property is set.
        /// </summary>
        internal bool IsSetEngineName() => this.EngineName != null;

        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// The master username of the tenant database.
        /// </para>
        /// </summary>
        public string MasterUsername { get; set; }

        /// <summary>
        /// Checks to see if the MasterUsername property is set.
        /// </summary>
        internal bool IsSetMasterUsername() => this.MasterUsername != null;

        /// <summary>
        /// Gets and sets the property NcharCharacterSetName. 
        /// <para>
        /// The <c>NCHAR</c> character set name of the tenant database.
        /// </para>
        /// </summary>
        public string NcharCharacterSetName { get; set; }

        /// <summary>
        /// Checks to see if the NcharCharacterSetName property is set.
        /// </summary>
        internal bool IsSetNcharCharacterSetName() => this.NcharCharacterSetName != null;

        /// <summary>
        /// Gets and sets the property SnapshotType. 
        /// <para>
        /// The type of DB snapshot.
        /// </para>
        /// </summary>
        public string SnapshotType { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotType property is set.
        /// </summary>
        internal bool IsSetSnapshotType() => this.SnapshotType != null;

        /// <summary>
        /// Gets and sets the property TagList.
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

        /// <summary>
        /// Gets and sets the property TenantDBName. 
        /// <para>
        /// The name of the tenant database.
        /// </para>
        /// </summary>
        public string TenantDBName { get; set; }

        /// <summary>
        /// Checks to see if the TenantDBName property is set.
        /// </summary>
        internal bool IsSetTenantDBName() => this.TenantDBName != null;

        /// <summary>
        /// Gets and sets the property TenantDatabaseCreateTime. 
        /// <para>
        /// The time the DB snapshot was taken, specified in Coordinated Universal Time (UTC).
        /// If you copy the snapshot, the creation time changes.
        /// </para>
        /// </summary>
        public DateTime? TenantDatabaseCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the TenantDatabaseCreateTime property is set.
        /// </summary>
        internal bool IsSetTenantDatabaseCreateTime() => this.TenantDatabaseCreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property TenantDatabaseResourceId. 
        /// <para>
        /// The resource ID of the tenant database.
        /// </para>
        /// </summary>
        public string TenantDatabaseResourceId { get; set; }

        /// <summary>
        /// Checks to see if the TenantDatabaseResourceId property is set.
        /// </summary>
        internal bool IsSetTenantDatabaseResourceId() => this.TenantDatabaseResourceId != null;
    }
}
