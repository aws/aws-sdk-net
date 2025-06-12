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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
        private string _characterSetName;
        private string _dbInstanceIdentifier;
        private string _dbiResourceId;
        private string _dbSnapshotIdentifier;
        private string _dbSnapshotTenantDatabaseARN;
        private string _engineName;
        private string _masterUsername;
        private string _ncharCharacterSetName;
        private string _snapshotType;
        private List<Tag> _tagList = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private DateTime? _tenantDatabaseCreateTime;
        private string _tenantDatabaseResourceId;
        private string _tenantDBName;

        /// <summary>
        /// Gets and sets the property CharacterSetName. 
        /// <para>
        /// The name of the character set of a tenant database.
        /// </para>
        /// </summary>
        public string CharacterSetName
        {
            get { return this._characterSetName; }
            set { this._characterSetName = value; }
        }

        // Check to see if CharacterSetName property is set
        internal bool IsSetCharacterSetName()
        {
            return this._characterSetName != null;
        }

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// The ID for the DB instance that contains the tenant databases.
        /// </para>
        /// </summary>
        public string DBInstanceIdentifier
        {
            get { return this._dbInstanceIdentifier; }
            set { this._dbInstanceIdentifier = value; }
        }

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this._dbInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DbiResourceId. 
        /// <para>
        /// The resource identifier of the source CDB instance. This identifier can't be changed
        /// and is unique to an Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string DbiResourceId
        {
            get { return this._dbiResourceId; }
            set { this._dbiResourceId = value; }
        }

        // Check to see if DbiResourceId property is set
        internal bool IsSetDbiResourceId()
        {
            return this._dbiResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property DBSnapshotIdentifier. 
        /// <para>
        /// The identifier for the snapshot of the DB instance.
        /// </para>
        /// </summary>
        public string DBSnapshotIdentifier
        {
            get { return this._dbSnapshotIdentifier; }
            set { this._dbSnapshotIdentifier = value; }
        }

        // Check to see if DBSnapshotIdentifier property is set
        internal bool IsSetDBSnapshotIdentifier()
        {
            return this._dbSnapshotIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DBSnapshotTenantDatabaseARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the snapshot tenant database.
        /// </para>
        /// </summary>
        public string DBSnapshotTenantDatabaseARN
        {
            get { return this._dbSnapshotTenantDatabaseARN; }
            set { this._dbSnapshotTenantDatabaseARN = value; }
        }

        // Check to see if DBSnapshotTenantDatabaseARN property is set
        internal bool IsSetDBSnapshotTenantDatabaseARN()
        {
            return this._dbSnapshotTenantDatabaseARN != null;
        }

        /// <summary>
        /// Gets and sets the property EngineName. 
        /// <para>
        /// The name of the database engine.
        /// </para>
        /// </summary>
        public string EngineName
        {
            get { return this._engineName; }
            set { this._engineName = value; }
        }

        // Check to see if EngineName property is set
        internal bool IsSetEngineName()
        {
            return this._engineName != null;
        }

        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// The master username of the tenant database.
        /// </para>
        /// </summary>
        public string MasterUsername
        {
            get { return this._masterUsername; }
            set { this._masterUsername = value; }
        }

        // Check to see if MasterUsername property is set
        internal bool IsSetMasterUsername()
        {
            return this._masterUsername != null;
        }

        /// <summary>
        /// Gets and sets the property NcharCharacterSetName. 
        /// <para>
        /// The <c>NCHAR</c> character set name of the tenant database.
        /// </para>
        /// </summary>
        public string NcharCharacterSetName
        {
            get { return this._ncharCharacterSetName; }
            set { this._ncharCharacterSetName = value; }
        }

        // Check to see if NcharCharacterSetName property is set
        internal bool IsSetNcharCharacterSetName()
        {
            return this._ncharCharacterSetName != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotType. 
        /// <para>
        /// The type of DB snapshot.
        /// </para>
        /// </summary>
        public string SnapshotType
        {
            get { return this._snapshotType; }
            set { this._snapshotType = value; }
        }

        // Check to see if SnapshotType property is set
        internal bool IsSetSnapshotType()
        {
            return this._snapshotType != null;
        }

        /// <summary>
        /// Gets and sets the property TagList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> TagList
        {
            get { return this._tagList; }
            set { this._tagList = value; }
        }

        // Check to see if TagList property is set
        internal bool IsSetTagList()
        {
            return this._tagList != null && (this._tagList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TenantDatabaseCreateTime. 
        /// <para>
        /// The time the DB snapshot was taken, specified in Coordinated Universal Time (UTC).
        /// If you copy the snapshot, the creation time changes.
        /// </para>
        /// </summary>
        public DateTime? TenantDatabaseCreateTime
        {
            get { return this._tenantDatabaseCreateTime; }
            set { this._tenantDatabaseCreateTime = value; }
        }

        // Check to see if TenantDatabaseCreateTime property is set
        internal bool IsSetTenantDatabaseCreateTime()
        {
            return this._tenantDatabaseCreateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TenantDatabaseResourceId. 
        /// <para>
        /// The resource ID of the tenant database.
        /// </para>
        /// </summary>
        public string TenantDatabaseResourceId
        {
            get { return this._tenantDatabaseResourceId; }
            set { this._tenantDatabaseResourceId = value; }
        }

        // Check to see if TenantDatabaseResourceId property is set
        internal bool IsSetTenantDatabaseResourceId()
        {
            return this._tenantDatabaseResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property TenantDBName. 
        /// <para>
        /// The name of the tenant database.
        /// </para>
        /// </summary>
        public string TenantDBName
        {
            get { return this._tenantDBName; }
            set { this._tenantDBName = value; }
        }

        // Check to see if TenantDBName property is set
        internal bool IsSetTenantDBName()
        {
            return this._tenantDBName != null;
        }

    }
}