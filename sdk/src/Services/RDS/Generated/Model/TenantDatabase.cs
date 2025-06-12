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
    /// A tenant database in the DB instance. This data type is an element in the response
    /// to the <c>DescribeTenantDatabases</c> action.
    /// </summary>
    public partial class TenantDatabase
    {
        private string _characterSetName;
        private string _dbInstanceIdentifier;
        private string _dbiResourceId;
        private bool? _deletionProtection;
        private string _masterUsername;
        private MasterUserSecret _masterUserSecret;
        private string _ncharCharacterSetName;
        private TenantDatabasePendingModifiedValues _pendingModifiedValues;
        private string _status;
        private List<Tag> _tagList = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _tenantDatabaseARN;
        private DateTime? _tenantDatabaseCreateTime;
        private string _tenantDatabaseResourceId;
        private string _tenantDBName;

        /// <summary>
        /// Gets and sets the property CharacterSetName. 
        /// <para>
        /// The character set of the tenant database.
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
        /// The ID of the DB instance that contains the tenant database.
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
        /// The Amazon Web Services Region-unique, immutable identifier for the DB instance.
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
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Specifies whether deletion protection is enabled for the DB instance.
        /// </para>
        /// </summary>
        public bool? DeletionProtection
        {
            get { return this._deletionProtection; }
            set { this._deletionProtection = value; }
        }

        // Check to see if DeletionProtection property is set
        internal bool IsSetDeletionProtection()
        {
            return this._deletionProtection.HasValue; 
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
        /// Gets and sets the property MasterUserSecret.
        /// </summary>
        public MasterUserSecret MasterUserSecret
        {
            get { return this._masterUserSecret; }
            set { this._masterUserSecret = value; }
        }

        // Check to see if MasterUserSecret property is set
        internal bool IsSetMasterUserSecret()
        {
            return this._masterUserSecret != null;
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
        /// Gets and sets the property PendingModifiedValues. 
        /// <para>
        /// Information about pending changes for a tenant database.
        /// </para>
        /// </summary>
        public TenantDatabasePendingModifiedValues PendingModifiedValues
        {
            get { return this._pendingModifiedValues; }
            set { this._pendingModifiedValues = value; }
        }

        // Check to see if PendingModifiedValues property is set
        internal bool IsSetPendingModifiedValues()
        {
            return this._pendingModifiedValues != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the tenant database.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
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
        /// Gets and sets the property TenantDatabaseARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the tenant database.
        /// </para>
        /// </summary>
        public string TenantDatabaseARN
        {
            get { return this._tenantDatabaseARN; }
            set { this._tenantDatabaseARN = value; }
        }

        // Check to see if TenantDatabaseARN property is set
        internal bool IsSetTenantDatabaseARN()
        {
            return this._tenantDatabaseARN != null;
        }

        /// <summary>
        /// Gets and sets the property TenantDatabaseCreateTime. 
        /// <para>
        /// The creation time of the tenant database.
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
        /// The Amazon Web Services Region-unique, immutable identifier for the tenant database.
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
        /// The database name of the tenant database.
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