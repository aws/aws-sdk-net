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
    /// Contains a list of available options for a DB instance.
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
        private List<AvailableProcessorFeature> _availableProcessorFeatures = new List<AvailableProcessorFeature>();
        private string _dbInstanceClass;
        private string _engine;
        private string _engineVersion;
        private string _licenseModel;
        private int? _maxIopsPerDbInstance;
        private double? _maxIopsPerGib;
        private int? _maxStorageSize;
        private int? _minIopsPerDbInstance;
        private double? _minIopsPerGib;
        private int? _minStorageSize;
        private bool? _multiAZCapable;
        private bool? _readReplicaCapable;
        private string _storageType;
        private bool? _supportsEnhancedMonitoring;
        private bool? _supportsIAMDatabaseAuthentication;
        private bool? _supportsIops;
        private bool? _supportsPerformanceInsights;
        private bool? _supportsStorageEncryption;
        private bool? _vpc;

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// A list of Availability Zones for a DB instance.
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
        /// Gets and sets the property AvailableProcessorFeatures. 
        /// <para>
        /// A list of the available processor features for the DB instance class of a DB instance.
        /// </para>
        /// </summary>
        public List<AvailableProcessorFeature> AvailableProcessorFeatures
        {
            get { return this._availableProcessorFeatures; }
            set { this._availableProcessorFeatures = value; }
        }

        // Check to see if AvailableProcessorFeatures property is set
        internal bool IsSetAvailableProcessorFeatures()
        {
            return this._availableProcessorFeatures != null && this._availableProcessorFeatures.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        /// The DB instance class for a DB instance.
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
        /// The engine type of a DB instance.
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
        /// The engine version of a DB instance.
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
        /// The license model for a DB instance.
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
        /// Gets and sets the property MaxIopsPerDbInstance. 
        /// <para>
        /// Maximum total provisioned IOPS for a DB instance.
        /// </para>
        /// </summary>
        public int MaxIopsPerDbInstance
        {
            get { return this._maxIopsPerDbInstance.GetValueOrDefault(); }
            set { this._maxIopsPerDbInstance = value; }
        }

        // Check to see if MaxIopsPerDbInstance property is set
        internal bool IsSetMaxIopsPerDbInstance()
        {
            return this._maxIopsPerDbInstance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxIopsPerGib. 
        /// <para>
        /// Maximum provisioned IOPS per GiB for a DB instance.
        /// </para>
        /// </summary>
        public double MaxIopsPerGib
        {
            get { return this._maxIopsPerGib.GetValueOrDefault(); }
            set { this._maxIopsPerGib = value; }
        }

        // Check to see if MaxIopsPerGib property is set
        internal bool IsSetMaxIopsPerGib()
        {
            return this._maxIopsPerGib.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxStorageSize. 
        /// <para>
        /// Maximum storage size for a DB instance.
        /// </para>
        /// </summary>
        public int MaxStorageSize
        {
            get { return this._maxStorageSize.GetValueOrDefault(); }
            set { this._maxStorageSize = value; }
        }

        // Check to see if MaxStorageSize property is set
        internal bool IsSetMaxStorageSize()
        {
            return this._maxStorageSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinIopsPerDbInstance. 
        /// <para>
        /// Minimum total provisioned IOPS for a DB instance.
        /// </para>
        /// </summary>
        public int MinIopsPerDbInstance
        {
            get { return this._minIopsPerDbInstance.GetValueOrDefault(); }
            set { this._minIopsPerDbInstance = value; }
        }

        // Check to see if MinIopsPerDbInstance property is set
        internal bool IsSetMinIopsPerDbInstance()
        {
            return this._minIopsPerDbInstance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinIopsPerGib. 
        /// <para>
        /// Minimum provisioned IOPS per GiB for a DB instance.
        /// </para>
        /// </summary>
        public double MinIopsPerGib
        {
            get { return this._minIopsPerGib.GetValueOrDefault(); }
            set { this._minIopsPerGib = value; }
        }

        // Check to see if MinIopsPerGib property is set
        internal bool IsSetMinIopsPerGib()
        {
            return this._minIopsPerGib.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinStorageSize. 
        /// <para>
        /// Minimum storage size for a DB instance.
        /// </para>
        /// </summary>
        public int MinStorageSize
        {
            get { return this._minStorageSize.GetValueOrDefault(); }
            set { this._minStorageSize = value; }
        }

        // Check to see if MinStorageSize property is set
        internal bool IsSetMinStorageSize()
        {
            return this._minStorageSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MultiAZCapable. 
        /// <para>
        /// Indicates whether a DB instance is Multi-AZ capable.
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
        /// Indicates whether a DB instance can have a Read Replica.
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
        /// Indicates the storage type for a DB instance.
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
        /// Gets and sets the property SupportsEnhancedMonitoring. 
        /// <para>
        /// Indicates whether a DB instance supports Enhanced Monitoring at intervals from 1 to
        /// 60 seconds.
        /// </para>
        /// </summary>
        public bool SupportsEnhancedMonitoring
        {
            get { return this._supportsEnhancedMonitoring.GetValueOrDefault(); }
            set { this._supportsEnhancedMonitoring = value; }
        }

        // Check to see if SupportsEnhancedMonitoring property is set
        internal bool IsSetSupportsEnhancedMonitoring()
        {
            return this._supportsEnhancedMonitoring.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsIAMDatabaseAuthentication. 
        /// <para>
        /// Indicates whether a DB instance supports IAM database authentication.
        /// </para>
        /// </summary>
        public bool SupportsIAMDatabaseAuthentication
        {
            get { return this._supportsIAMDatabaseAuthentication.GetValueOrDefault(); }
            set { this._supportsIAMDatabaseAuthentication = value; }
        }

        // Check to see if SupportsIAMDatabaseAuthentication property is set
        internal bool IsSetSupportsIAMDatabaseAuthentication()
        {
            return this._supportsIAMDatabaseAuthentication.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsIops. 
        /// <para>
        /// Indicates whether a DB instance supports provisioned IOPS.
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
        /// Gets and sets the property SupportsPerformanceInsights. 
        /// <para>
        /// True if a DB instance supports Performance Insights, otherwise false.
        /// </para>
        /// </summary>
        public bool SupportsPerformanceInsights
        {
            get { return this._supportsPerformanceInsights.GetValueOrDefault(); }
            set { this._supportsPerformanceInsights = value; }
        }

        // Check to see if SupportsPerformanceInsights property is set
        internal bool IsSetSupportsPerformanceInsights()
        {
            return this._supportsPerformanceInsights.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsStorageEncryption. 
        /// <para>
        /// Indicates whether a DB instance supports encrypted storage.
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
        /// Indicates whether a DB instance is in a VPC.
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