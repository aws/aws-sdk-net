/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the rds-2014-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// This data type is used as a response element in the <a>ModifyDBInstance</a> action.
    /// </summary>
    public partial class PendingModifiedValues
    {
        private int? _allocatedStorage;
        private int? _backupRetentionPeriod;
        private string _dBInstanceClass;
        private string _dBInstanceIdentifier;
        private string _engineVersion;
        private int? _iops;
        private string _masterUserPassword;
        private bool? _multiAZ;
        private int? _port;
        private string _storageType;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public PendingModifiedValues() { }

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        ///  Contains the new <code>AllocatedStorage</code> size for the DB instance that will
        /// be applied or is in progress. 
        /// </para>
        /// </summary>
        public int AllocatedStorage
        {
            get { return this._allocatedStorage.GetValueOrDefault(); }
            set { this._allocatedStorage = value; }
        }

        // Check to see if AllocatedStorage property is set
        internal bool IsSetAllocatedStorage()
        {
            return this._allocatedStorage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        ///  Specifies the pending number of days for which automated backups are retained. 
        /// </para>
        /// </summary>
        public int BackupRetentionPeriod
        {
            get { return this._backupRetentionPeriod.GetValueOrDefault(); }
            set { this._backupRetentionPeriod = value; }
        }

        // Check to see if BackupRetentionPeriod property is set
        internal bool IsSetBackupRetentionPeriod()
        {
            return this._backupRetentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        ///  Contains the new <code>DBInstanceClass</code> for the DB instance that will be applied
        /// or is in progress. 
        /// </para>
        /// </summary>
        public string DBInstanceClass
        {
            get { return this._dBInstanceClass; }
            set { this._dBInstanceClass = value; }
        }

        // Check to see if DBInstanceClass property is set
        internal bool IsSetDBInstanceClass()
        {
            return this._dBInstanceClass != null;
        }

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        ///  Contains the new <code>DBInstanceIdentifier</code> for the DB instance that will
        /// be applied or is in progress. 
        /// </para>
        /// </summary>
        public string DBInstanceIdentifier
        {
            get { return this._dBInstanceIdentifier; }
            set { this._dBInstanceIdentifier = value; }
        }

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this._dBInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        ///  Indicates the database engine version. 
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        ///  Specifies the new Provisioned IOPS value for the DB instance that will be applied
        /// or is being applied. 
        /// </para>
        /// </summary>
        public int Iops
        {
            get { return this._iops.GetValueOrDefault(); }
            set { this._iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this._iops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MasterUserPassword. 
        /// <para>
        ///  Contains the pending or in-progress change of the master credentials for the DB instance.
        /// 
        /// </para>
        /// </summary>
        public string MasterUserPassword
        {
            get { return this._masterUserPassword; }
            set { this._masterUserPassword = value; }
        }

        // Check to see if MasterUserPassword property is set
        internal bool IsSetMasterUserPassword()
        {
            return this._masterUserPassword != null;
        }

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        ///  Indicates that the Single-AZ DB instance is to change to a Multi-AZ deployment. 
        /// </para>
        /// </summary>
        public bool MultiAZ
        {
            get { return this._multiAZ.GetValueOrDefault(); }
            set { this._multiAZ = value; }
        }

        // Check to see if MultiAZ property is set
        internal bool IsSetMultiAZ()
        {
            return this._multiAZ.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        ///  Specifies the pending port for the DB instance. 
        /// </para>
        /// </summary>
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        ///  Specifies storage type to be associated with the DB instance. 
        /// </para>
        /// </summary>
        public string StorageType
        {
            get { return this._storageType; }
            set { this._storageType = value; }
        }

        // Check to see if StorageType property is set
        internal bool IsSetStorageType()
        {
            return this._storageType != null;
        }

    }
}