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

namespace Amazon.Neptune.Model
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
        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// A list of Availability Zones for a DB instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AvailabilityZone> AvailabilityZones { get; set; } = AWSConfigs.InitializeCollections ? new List<AvailabilityZone>() : null;

        /// <summary>
        /// Checks to see if the AvailabilityZones property is set.
        /// </summary>
        internal bool IsSetAvailabilityZones() => this.AvailabilityZones != null && (this.AvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        /// The DB instance class for a DB instance.
        /// </para>
        /// </summary>
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceClass property is set.
        /// </summary>
        internal bool IsSetDBInstanceClass() => this.DBInstanceClass != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The engine type of a DB instance.
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
        /// The engine version of a DB instance.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The license model for a DB instance.
        /// </para>
        /// </summary>
        public string LicenseModel { get; set; }

        /// <summary>
        /// Checks to see if the LicenseModel property is set.
        /// </summary>
        internal bool IsSetLicenseModel() => this.LicenseModel != null;

        /// <summary>
        /// Gets and sets the property MaxIopsPerDbInstance. 
        /// <para>
        /// Maximum total provisioned IOPS for a DB instance.
        /// </para>
        /// </summary>
        public int? MaxIopsPerDbInstance { get; set; }

        /// <summary>
        /// Checks to see if the MaxIopsPerDbInstance property is set.
        /// </summary>
        internal bool IsSetMaxIopsPerDbInstance() => this.MaxIopsPerDbInstance.HasValue;

        /// <summary>
        /// Gets and sets the property MaxIopsPerGib. 
        /// <para>
        /// Maximum provisioned IOPS per GiB for a DB instance.
        /// </para>
        /// </summary>
        public double? MaxIopsPerGib { get; set; }

        /// <summary>
        /// Checks to see if the MaxIopsPerGib property is set.
        /// </summary>
        internal bool IsSetMaxIopsPerGib() => this.MaxIopsPerGib.HasValue;

        /// <summary>
        /// Gets and sets the property MaxStorageSize. 
        /// <para>
        /// Maximum storage size for a DB instance.
        /// </para>
        /// </summary>
        public int? MaxStorageSize { get; set; }

        /// <summary>
        /// Checks to see if the MaxStorageSize property is set.
        /// </summary>
        internal bool IsSetMaxStorageSize() => this.MaxStorageSize.HasValue;

        /// <summary>
        /// Gets and sets the property MinIopsPerDbInstance. 
        /// <para>
        /// Minimum total provisioned IOPS for a DB instance.
        /// </para>
        /// </summary>
        public int? MinIopsPerDbInstance { get; set; }

        /// <summary>
        /// Checks to see if the MinIopsPerDbInstance property is set.
        /// </summary>
        internal bool IsSetMinIopsPerDbInstance() => this.MinIopsPerDbInstance.HasValue;

        /// <summary>
        /// Gets and sets the property MinIopsPerGib. 
        /// <para>
        /// Minimum provisioned IOPS per GiB for a DB instance.
        /// </para>
        /// </summary>
        public double? MinIopsPerGib { get; set; }

        /// <summary>
        /// Checks to see if the MinIopsPerGib property is set.
        /// </summary>
        internal bool IsSetMinIopsPerGib() => this.MinIopsPerGib.HasValue;

        /// <summary>
        /// Gets and sets the property MinStorageSize. 
        /// <para>
        /// Minimum storage size for a DB instance.
        /// </para>
        /// </summary>
        public int? MinStorageSize { get; set; }

        /// <summary>
        /// Checks to see if the MinStorageSize property is set.
        /// </summary>
        internal bool IsSetMinStorageSize() => this.MinStorageSize.HasValue;

        /// <summary>
        /// Gets and sets the property MultiAZCapable. 
        /// <para>
        /// Indicates whether a DB instance is Multi-AZ capable.
        /// </para>
        /// </summary>
        public bool? MultiAZCapable { get; set; }

        /// <summary>
        /// Checks to see if the MultiAZCapable property is set.
        /// </summary>
        internal bool IsSetMultiAZCapable() => this.MultiAZCapable.HasValue;

        /// <summary>
        /// Gets and sets the property ReadReplicaCapable. 
        /// <para>
        /// Indicates whether a DB instance can have a Read Replica.
        /// </para>
        /// </summary>
        public bool? ReadReplicaCapable { get; set; }

        /// <summary>
        /// Checks to see if the ReadReplicaCapable property is set.
        /// </summary>
        internal bool IsSetReadReplicaCapable() => this.ReadReplicaCapable.HasValue;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// Not applicable. In Neptune the storage type is managed at the DB Cluster level.
        /// </para>
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property SupportedNetworkTypes. 
        /// <para>
        /// The network types supported by the orderable DB instance option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedNetworkTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedNetworkTypes property is set.
        /// </summary>
        internal bool IsSetSupportedNetworkTypes() => this.SupportedNetworkTypes != null && (this.SupportedNetworkTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportsEnhancedMonitoring. 
        /// <para>
        /// Indicates whether a DB instance supports Enhanced Monitoring at intervals from 1 to
        /// 60 seconds.
        /// </para>
        /// </summary>
        public bool? SupportsEnhancedMonitoring { get; set; }

        /// <summary>
        /// Checks to see if the SupportsEnhancedMonitoring property is set.
        /// </summary>
        internal bool IsSetSupportsEnhancedMonitoring() => this.SupportsEnhancedMonitoring.HasValue;

        /// <summary>
        /// Gets and sets the property SupportsGlobalDatabases. 
        /// <para>
        /// A value that indicates whether you can use Neptune global databases with a specific
        /// combination of other DB engine attributes.
        /// </para>
        /// </summary>
        public bool? SupportsGlobalDatabases { get; set; }

        /// <summary>
        /// Checks to see if the SupportsGlobalDatabases property is set.
        /// </summary>
        internal bool IsSetSupportsGlobalDatabases() => this.SupportsGlobalDatabases.HasValue;

        /// <summary>
        /// Gets and sets the property SupportsIAMDatabaseAuthentication. 
        /// <para>
        /// Indicates whether a DB instance supports IAM database authentication.
        /// </para>
        /// </summary>
        public bool? SupportsIAMDatabaseAuthentication { get; set; }

        /// <summary>
        /// Checks to see if the SupportsIAMDatabaseAuthentication property is set.
        /// </summary>
        internal bool IsSetSupportsIAMDatabaseAuthentication() => this.SupportsIAMDatabaseAuthentication.HasValue;

        /// <summary>
        /// Gets and sets the property SupportsIops. 
        /// <para>
        /// Indicates whether a DB instance supports provisioned IOPS.
        /// </para>
        /// </summary>
        public bool? SupportsIops { get; set; }

        /// <summary>
        /// Checks to see if the SupportsIops property is set.
        /// </summary>
        internal bool IsSetSupportsIops() => this.SupportsIops.HasValue;

        /// <summary>
        /// Gets and sets the property SupportsPerformanceInsights. 
        /// <para>
        ///  <i>(Not supported by Neptune)</i> 
        /// </para>
        /// </summary>
        public bool? SupportsPerformanceInsights { get; set; }

        /// <summary>
        /// Checks to see if the SupportsPerformanceInsights property is set.
        /// </summary>
        internal bool IsSetSupportsPerformanceInsights() => this.SupportsPerformanceInsights.HasValue;

        /// <summary>
        /// Gets and sets the property SupportsStorageEncryption. 
        /// <para>
        /// Indicates whether a DB instance supports encrypted storage.
        /// </para>
        /// </summary>
        public bool? SupportsStorageEncryption { get; set; }

        /// <summary>
        /// Checks to see if the SupportsStorageEncryption property is set.
        /// </summary>
        internal bool IsSetSupportsStorageEncryption() => this.SupportsStorageEncryption.HasValue;

        /// <summary>
        /// Gets and sets the property Vpc. 
        /// <para>
        /// Indicates whether a DB instance is in a VPC.
        /// </para>
        /// </summary>
        public bool? Vpc { get; set; }

        /// <summary>
        /// Checks to see if the Vpc property is set.
        /// </summary>
        internal bool IsSetVpc() => this.Vpc.HasValue;
    }
}
