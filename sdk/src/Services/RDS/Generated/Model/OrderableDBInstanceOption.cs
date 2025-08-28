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
    /// Contains a list of available options for a DB instance.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <c>DescribeOrderableDBInstanceOptions</c>
    /// action.
    /// </para>
    /// </summary>
    public partial class OrderableDBInstanceOption
    {
        private string _availabilityZoneGroup;
        private List<AvailabilityZone> _availabilityZones = AWSConfigs.InitializeCollections ? new List<AvailabilityZone>() : null;
        private List<AvailableProcessorFeature> _availableProcessorFeatures = AWSConfigs.InitializeCollections ? new List<AvailableProcessorFeature>() : null;
        private string _dbInstanceClass;
        private string _engine;
        private string _engineVersion;
        private string _licenseModel;
        private int? _maxIopsPerDbInstance;
        private double? _maxIopsPerGib;
        private int? _maxStorageSize;
        private int? _maxStorageThroughputPerDbInstance;
        private double? _maxStorageThroughputPerIops;
        private int? _minIopsPerDbInstance;
        private double? _minIopsPerGib;
        private int? _minStorageSize;
        private int? _minStorageThroughputPerDbInstance;
        private double? _minStorageThroughputPerIops;
        private bool? _multiAZCapable;
        private bool? _outpostCapable;
        private bool? _readReplicaCapable;
        private string _storageType;
        private List<string> _supportedActivityStreamModes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supportedEngineModes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supportedNetworkTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _supportsClusters;
        private bool? _supportsDedicatedLogVolume;
        private bool? _supportsEnhancedMonitoring;
        private bool? _supportsGlobalDatabases;
        private bool? _supportsHttpEndpoint;
        private bool? _supportsIAMDatabaseAuthentication;
        private bool? _supportsIops;
        private bool? _supportsKerberosAuthentication;
        private bool? _supportsPerformanceInsights;
        private bool? _supportsStorageAutoscaling;
        private bool? _supportsStorageEncryption;
        private bool? _supportsStorageThroughput;
        private bool? _vpc;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneGroup. 
        /// <para>
        /// The Availability Zone group for a DB instance.
        /// </para>
        /// </summary>
        public string AvailabilityZoneGroup
        {
            get { return this._availabilityZoneGroup; }
            set { this._availabilityZoneGroup = value; }
        }

        // Check to see if AvailabilityZoneGroup property is set
        internal bool IsSetAvailabilityZoneGroup()
        {
            return this._availabilityZoneGroup != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// A list of Availability Zones for a DB instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AvailabilityZone> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && (this._availabilityZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AvailableProcessorFeatures. 
        /// <para>
        /// A list of the available processor features for the DB instance class of a DB instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AvailableProcessorFeature> AvailableProcessorFeatures
        {
            get { return this._availableProcessorFeatures; }
            set { this._availableProcessorFeatures = value; }
        }

        // Check to see if AvailableProcessorFeatures property is set
        internal bool IsSetAvailableProcessorFeatures()
        {
            return this._availableProcessorFeatures != null && (this._availableProcessorFeatures.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        public int? MaxIopsPerDbInstance
        {
            get { return this._maxIopsPerDbInstance; }
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
        public double? MaxIopsPerGib
        {
            get { return this._maxIopsPerGib; }
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
        public int? MaxStorageSize
        {
            get { return this._maxStorageSize; }
            set { this._maxStorageSize = value; }
        }

        // Check to see if MaxStorageSize property is set
        internal bool IsSetMaxStorageSize()
        {
            return this._maxStorageSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxStorageThroughputPerDbInstance. 
        /// <para>
        /// Maximum storage throughput for a DB instance.
        /// </para>
        /// </summary>
        public int? MaxStorageThroughputPerDbInstance
        {
            get { return this._maxStorageThroughputPerDbInstance; }
            set { this._maxStorageThroughputPerDbInstance = value; }
        }

        // Check to see if MaxStorageThroughputPerDbInstance property is set
        internal bool IsSetMaxStorageThroughputPerDbInstance()
        {
            return this._maxStorageThroughputPerDbInstance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxStorageThroughputPerIops. 
        /// <para>
        /// Maximum storage throughput to provisioned IOPS ratio for a DB instance.
        /// </para>
        /// </summary>
        public double? MaxStorageThroughputPerIops
        {
            get { return this._maxStorageThroughputPerIops; }
            set { this._maxStorageThroughputPerIops = value; }
        }

        // Check to see if MaxStorageThroughputPerIops property is set
        internal bool IsSetMaxStorageThroughputPerIops()
        {
            return this._maxStorageThroughputPerIops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinIopsPerDbInstance. 
        /// <para>
        /// Minimum total provisioned IOPS for a DB instance.
        /// </para>
        /// </summary>
        public int? MinIopsPerDbInstance
        {
            get { return this._minIopsPerDbInstance; }
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
        public double? MinIopsPerGib
        {
            get { return this._minIopsPerGib; }
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
        public int? MinStorageSize
        {
            get { return this._minStorageSize; }
            set { this._minStorageSize = value; }
        }

        // Check to see if MinStorageSize property is set
        internal bool IsSetMinStorageSize()
        {
            return this._minStorageSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinStorageThroughputPerDbInstance. 
        /// <para>
        /// Minimum storage throughput for a DB instance.
        /// </para>
        /// </summary>
        public int? MinStorageThroughputPerDbInstance
        {
            get { return this._minStorageThroughputPerDbInstance; }
            set { this._minStorageThroughputPerDbInstance = value; }
        }

        // Check to see if MinStorageThroughputPerDbInstance property is set
        internal bool IsSetMinStorageThroughputPerDbInstance()
        {
            return this._minStorageThroughputPerDbInstance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinStorageThroughputPerIops. 
        /// <para>
        /// Minimum storage throughput to provisioned IOPS ratio for a DB instance.
        /// </para>
        /// </summary>
        public double? MinStorageThroughputPerIops
        {
            get { return this._minStorageThroughputPerIops; }
            set { this._minStorageThroughputPerIops = value; }
        }

        // Check to see if MinStorageThroughputPerIops property is set
        internal bool IsSetMinStorageThroughputPerIops()
        {
            return this._minStorageThroughputPerIops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MultiAZCapable. 
        /// <para>
        /// Indicates whether a DB instance is Multi-AZ capable.
        /// </para>
        /// </summary>
        public bool? MultiAZCapable
        {
            get { return this._multiAZCapable; }
            set { this._multiAZCapable = value; }
        }

        // Check to see if MultiAZCapable property is set
        internal bool IsSetMultiAZCapable()
        {
            return this._multiAZCapable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutpostCapable. 
        /// <para>
        /// Indicates whether a DB instance supports RDS on Outposts.
        /// </para>
        ///  
        /// <para>
        /// For more information about RDS on Outposts, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/rds-on-outposts.html">Amazon
        /// RDS on Amazon Web Services Outposts</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        public bool? OutpostCapable
        {
            get { return this._outpostCapable; }
            set { this._outpostCapable = value; }
        }

        // Check to see if OutpostCapable property is set
        internal bool IsSetOutpostCapable()
        {
            return this._outpostCapable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReadReplicaCapable. 
        /// <para>
        /// Indicates whether a DB instance can have a read replica.
        /// </para>
        /// </summary>
        public bool? ReadReplicaCapable
        {
            get { return this._readReplicaCapable; }
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
        /// The storage type for a DB instance.
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
        /// Gets and sets the property SupportedActivityStreamModes. 
        /// <para>
        /// The list of supported modes for Database Activity Streams. Aurora PostgreSQL returns
        /// the value <c>[sync, async]</c>. Aurora MySQL and RDS for Oracle return <c>[async]</c>
        /// only. If Database Activity Streams isn't supported, the return value is an empty list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedActivityStreamModes
        {
            get { return this._supportedActivityStreamModes; }
            set { this._supportedActivityStreamModes = value; }
        }

        // Check to see if SupportedActivityStreamModes property is set
        internal bool IsSetSupportedActivityStreamModes()
        {
            return this._supportedActivityStreamModes != null && (this._supportedActivityStreamModes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedEngineModes. 
        /// <para>
        /// A list of the supported DB engine modes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedEngineModes
        {
            get { return this._supportedEngineModes; }
            set { this._supportedEngineModes = value; }
        }

        // Check to see if SupportedEngineModes property is set
        internal bool IsSetSupportedEngineModes()
        {
            return this._supportedEngineModes != null && (this._supportedEngineModes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedNetworkTypes. 
        /// <para>
        /// The network types supported by the DB instance (<c>IPV4</c> or <c>DUAL</c>).
        /// </para>
        ///  
        /// <para>
        /// A DB instance can support only the IPv4 protocol or the IPv4 and the IPv6 protocols
        /// (<c>DUAL</c>).
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html">
        /// Working with a DB instance in a VPC</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedNetworkTypes
        {
            get { return this._supportedNetworkTypes; }
            set { this._supportedNetworkTypes = value; }
        }

        // Check to see if SupportedNetworkTypes property is set
        internal bool IsSetSupportedNetworkTypes()
        {
            return this._supportedNetworkTypes != null && (this._supportedNetworkTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportsClusters. 
        /// <para>
        /// Indicates whether DB instances can be configured as a Multi-AZ DB cluster.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ deployments with two readable standby DB instances</a> in the <i>Amazon RDS
        /// User Guide.</i> 
        /// </para>
        /// </summary>
        public bool? SupportsClusters
        {
            get { return this._supportsClusters; }
            set { this._supportsClusters = value; }
        }

        // Check to see if SupportsClusters property is set
        internal bool IsSetSupportsClusters()
        {
            return this._supportsClusters.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsDedicatedLogVolume. 
        /// <para>
        /// Indicates whether a DB instance supports using a dedicated log volume (DLV).
        /// </para>
        /// </summary>
        public bool? SupportsDedicatedLogVolume
        {
            get { return this._supportsDedicatedLogVolume; }
            set { this._supportsDedicatedLogVolume = value; }
        }

        // Check to see if SupportsDedicatedLogVolume property is set
        internal bool IsSetSupportsDedicatedLogVolume()
        {
            return this._supportsDedicatedLogVolume.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsEnhancedMonitoring. 
        /// <para>
        /// Indicates whether a DB instance supports Enhanced Monitoring at intervals from 1 to
        /// 60 seconds.
        /// </para>
        /// </summary>
        public bool? SupportsEnhancedMonitoring
        {
            get { return this._supportsEnhancedMonitoring; }
            set { this._supportsEnhancedMonitoring = value; }
        }

        // Check to see if SupportsEnhancedMonitoring property is set
        internal bool IsSetSupportsEnhancedMonitoring()
        {
            return this._supportsEnhancedMonitoring.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsGlobalDatabases. 
        /// <para>
        /// Indicates whether you can use Aurora global databases with a specific combination
        /// of other DB engine attributes.
        /// </para>
        /// </summary>
        public bool? SupportsGlobalDatabases
        {
            get { return this._supportsGlobalDatabases; }
            set { this._supportsGlobalDatabases = value; }
        }

        // Check to see if SupportsGlobalDatabases property is set
        internal bool IsSetSupportsGlobalDatabases()
        {
            return this._supportsGlobalDatabases.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsHttpEndpoint. 
        /// <para>
        /// Indicates whether a DB instance supports HTTP endpoints.
        /// </para>
        /// </summary>
        public bool? SupportsHttpEndpoint
        {
            get { return this._supportsHttpEndpoint; }
            set { this._supportsHttpEndpoint = value; }
        }

        // Check to see if SupportsHttpEndpoint property is set
        internal bool IsSetSupportsHttpEndpoint()
        {
            return this._supportsHttpEndpoint.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsIAMDatabaseAuthentication. 
        /// <para>
        /// Indicates whether a DB instance supports IAM database authentication.
        /// </para>
        /// </summary>
        public bool? SupportsIAMDatabaseAuthentication
        {
            get { return this._supportsIAMDatabaseAuthentication; }
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
        public bool? SupportsIops
        {
            get { return this._supportsIops; }
            set { this._supportsIops = value; }
        }

        // Check to see if SupportsIops property is set
        internal bool IsSetSupportsIops()
        {
            return this._supportsIops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsKerberosAuthentication. 
        /// <para>
        /// Indicates whether a DB instance supports Kerberos Authentication.
        /// </para>
        /// </summary>
        public bool? SupportsKerberosAuthentication
        {
            get { return this._supportsKerberosAuthentication; }
            set { this._supportsKerberosAuthentication = value; }
        }

        // Check to see if SupportsKerberosAuthentication property is set
        internal bool IsSetSupportsKerberosAuthentication()
        {
            return this._supportsKerberosAuthentication.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsPerformanceInsights. 
        /// <para>
        /// Indicates whether a DB instance supports Performance Insights.
        /// </para>
        /// </summary>
        public bool? SupportsPerformanceInsights
        {
            get { return this._supportsPerformanceInsights; }
            set { this._supportsPerformanceInsights = value; }
        }

        // Check to see if SupportsPerformanceInsights property is set
        internal bool IsSetSupportsPerformanceInsights()
        {
            return this._supportsPerformanceInsights.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsStorageAutoscaling. 
        /// <para>
        /// Indicates whether Amazon RDS can automatically scale storage for DB instances that
        /// use the specified DB instance class.
        /// </para>
        /// </summary>
        public bool? SupportsStorageAutoscaling
        {
            get { return this._supportsStorageAutoscaling; }
            set { this._supportsStorageAutoscaling = value; }
        }

        // Check to see if SupportsStorageAutoscaling property is set
        internal bool IsSetSupportsStorageAutoscaling()
        {
            return this._supportsStorageAutoscaling.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsStorageEncryption. 
        /// <para>
        /// Indicates whether a DB instance supports encrypted storage.
        /// </para>
        /// </summary>
        public bool? SupportsStorageEncryption
        {
            get { return this._supportsStorageEncryption; }
            set { this._supportsStorageEncryption = value; }
        }

        // Check to see if SupportsStorageEncryption property is set
        internal bool IsSetSupportsStorageEncryption()
        {
            return this._supportsStorageEncryption.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsStorageThroughput. 
        /// <para>
        /// Indicates whether a DB instance supports storage throughput.
        /// </para>
        /// </summary>
        public bool? SupportsStorageThroughput
        {
            get { return this._supportsStorageThroughput; }
            set { this._supportsStorageThroughput = value; }
        }

        // Check to see if SupportsStorageThroughput property is set
        internal bool IsSetSupportsStorageThroughput()
        {
            return this._supportsStorageThroughput.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Vpc. 
        /// <para>
        /// Indicates whether a DB instance is in a VPC.
        /// </para>
        /// </summary>
        public bool? Vpc
        {
            get { return this._vpc; }
            set { this._vpc = value; }
        }

        // Check to see if Vpc property is set
        internal bool IsSetVpc()
        {
            return this._vpc.HasValue; 
        }

    }
}