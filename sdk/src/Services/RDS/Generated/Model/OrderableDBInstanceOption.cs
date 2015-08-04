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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
    /// Contains a list of available options for a DB instance 
    /// 
    ///  
    /// <para>
    ///  This data type is used as a response element in the <a>DescribeOrderableDBInstanceOptions</a>
    /// action. 
    /// </para>
    /// </summary>
    public partial class OrderableDBInstanceOption
    {
        private List<AvailabilityZone> _availabilityZones = new List<AvailabilityZone>();
        private string _dbInstanceClass;
        private string _engine;
        private string _engineVersion;
        private string _licenseModel;
        private bool? _multiAZCapable;
        private bool? _readReplicaCapable;
        private string _storageType;
        private bool? _supportsIops;
        private bool? _supportsStorageEncryption;
        private bool? _vpc;

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        ///  A list of Availability Zones for the orderable DB instance. 
        /// </para>
        /// </summary>
        public List<AvailabilityZone> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && this._availabilityZones.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        ///  The DB instance class for the orderable DB instance. 
        /// </para>
        /// </summary>
        public string DBInstanceClass
        {
            get { return this._dbInstanceClass; }
            set { this._dbInstanceClass = value; }
        }

        // Check to see if DBInstanceClass property is set
        internal bool IsSetDBInstanceClass()
        {
            return this._dbInstanceClass != null;
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        ///  The engine type of the orderable DB instance. 
        /// </para>
        /// </summary>
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        ///  The engine version of the orderable DB instance. 
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
        /// Gets and sets the property LicenseModel. 
        /// <para>
        ///  The license model for the orderable DB instance. 
        /// </para>
        /// </summary>
        public string LicenseModel
        {
            get { return this._licenseModel; }
            set { this._licenseModel = value; }
        }

        // Check to see if LicenseModel property is set
        internal bool IsSetLicenseModel()
        {
            return this._licenseModel != null;
        }

        /// <summary>
        /// Gets and sets the property MultiAZCapable. 
        /// <para>
        ///  Indicates whether this orderable DB instance is multi-AZ capable. 
        /// </para>
        /// </summary>
        public bool MultiAZCapable
        {
            get { return this._multiAZCapable.GetValueOrDefault(); }
            set { this._multiAZCapable = value; }
        }

        // Check to see if MultiAZCapable property is set
        internal bool IsSetMultiAZCapable()
        {
            return this._multiAZCapable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReadReplicaCapable. 
        /// <para>
        ///  Indicates whether this orderable DB instance can have a Read Replica. 
        /// </para>
        /// </summary>
        public bool ReadReplicaCapable
        {
            get { return this._readReplicaCapable.GetValueOrDefault(); }
            set { this._readReplicaCapable = value; }
        }

        // Check to see if ReadReplicaCapable property is set
        internal bool IsSetReadReplicaCapable()
        {
            return this._readReplicaCapable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        ///  Indicates the storage type for this orderable DB instance. 
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

        /// <summary>
        /// Gets and sets the property SupportsIops. 
        /// <para>
        ///  Indicates whether this orderable DB instance supports provisioned IOPS. 
        /// </para>
        /// </summary>
        public bool SupportsIops
        {
            get { return this._supportsIops.GetValueOrDefault(); }
            set { this._supportsIops = value; }
        }

        // Check to see if SupportsIops property is set
        internal bool IsSetSupportsIops()
        {
            return this._supportsIops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsStorageEncryption. 
        /// <para>
        ///  Indicates whether this orderable DB instance supports encrypted storage. 
        /// </para>
        /// </summary>
        public bool SupportsStorageEncryption
        {
            get { return this._supportsStorageEncryption.GetValueOrDefault(); }
            set { this._supportsStorageEncryption = value; }
        }

        // Check to see if SupportsStorageEncryption property is set
        internal bool IsSetSupportsStorageEncryption()
        {
            return this._supportsStorageEncryption.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Vpc. 
        /// <para>
        ///  Indicates whether this is a VPC orderable DB instance. 
        /// </para>
        /// </summary>
        public bool Vpc
        {
            get { return this._vpc.GetValueOrDefault(); }
            set { this._vpc = value; }
        }

        // Check to see if Vpc property is set
        internal bool IsSetVpc()
        {
            return this._vpc.HasValue; 
        }

    }
}