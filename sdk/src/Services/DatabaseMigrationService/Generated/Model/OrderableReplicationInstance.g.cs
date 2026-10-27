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
    /// In response to the <c>DescribeOrderableReplicationInstances</c> operation, this object
    /// describes an available replication instance. This description includes the replication
    /// instance's type, engine version, and allocated storage.
    /// </summary>
    public partial class OrderableReplicationInstance
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// List of Availability Zones for this replication instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailabilityZones { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AvailabilityZones property is set.
        /// </summary>
        internal bool IsSetAvailabilityZones() => this.AvailabilityZones != null && (this.AvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DefaultAllocatedStorage. 
        /// <para>
        /// The default amount of storage (in gigabytes) that is allocated for the replication
        /// instance.
        /// </para>
        /// </summary>
        public int? DefaultAllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the DefaultAllocatedStorage property is set.
        /// </summary>
        internal bool IsSetDefaultAllocatedStorage() => this.DefaultAllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version of the replication engine.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property IncludedAllocatedStorage. 
        /// <para>
        /// The amount of storage (in gigabytes) that is allocated for the replication instance.
        /// </para>
        /// </summary>
        public int? IncludedAllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the IncludedAllocatedStorage property is set.
        /// </summary>
        internal bool IsSetIncludedAllocatedStorage() => this.IncludedAllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property MaxAllocatedStorage. 
        /// <para>
        /// The minimum amount of storage (in gigabytes) that can be allocated for the replication
        /// instance.
        /// </para>
        /// </summary>
        public int? MaxAllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the MaxAllocatedStorage property is set.
        /// </summary>
        internal bool IsSetMaxAllocatedStorage() => this.MaxAllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property MinAllocatedStorage. 
        /// <para>
        /// The minimum amount of storage (in gigabytes) that can be allocated for the replication
        /// instance.
        /// </para>
        /// </summary>
        public int? MinAllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the MinAllocatedStorage property is set.
        /// </summary>
        internal bool IsSetMinAllocatedStorage() => this.MinAllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property ReleaseStatus. 
        /// <para>
        /// The value returned when the specified <c>EngineVersion</c> of the replication instance
        /// is in Beta or test mode. This indicates some features might not work as expected.
        /// </para>
        ///  <note> 
        /// <para>
        /// DMS supports the <c>ReleaseStatus</c> parameter in versions 3.1.4 and later.
        /// </para>
        ///  </note>
        /// </summary>
        public ReleaseStatusValues ReleaseStatus { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseStatus property is set.
        /// </summary>
        internal bool IsSetReleaseStatus() => this.ReleaseStatus != null;

        /// <summary>
        /// Gets and sets the property ReplicationInstanceClass. 
        /// <para>
        /// The compute and memory capacity of the replication instance as defined for the specified
        /// replication instance class. For example to specify the instance class dms.c4.large,
        /// set this parameter to <c>"dms.c4.large"</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information on the settings and capacities for the available replication
        /// instance classes, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_ReplicationInstance.html#CHAP_ReplicationInstance.InDepth">
        /// Selecting the right DMS replication instance for your migration</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 30)]
        public string ReplicationInstanceClass { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationInstanceClass property is set.
        /// </summary>
        internal bool IsSetReplicationInstanceClass() => this.ReplicationInstanceClass != null;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The type of storage used by the replication instance.
        /// </para>
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;
    }
}
