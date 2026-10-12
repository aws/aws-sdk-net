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

namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// The Amazon RDS DB instance storage configuration used for recommendations.
    /// </summary>
    public partial class RdsDbInstanceStorageConfiguration
    {
        /// <summary>
        /// Gets and sets the property AllocatedStorageInGb. 
        /// <para>
        /// The new amount of storage in GB to allocate for the DB instance.
        /// </para>
        /// </summary>
        public double? AllocatedStorageInGb { get; set; }

        /// <summary>
        /// Checks to see if the AllocatedStorageInGb property is set.
        /// </summary>
        internal bool IsSetAllocatedStorageInGb() => this.AllocatedStorageInGb.HasValue;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The amount of Provisioned IOPS (input/output operations per second) to be initially
        /// allocated for the DB instance.
        /// </para>
        /// </summary>
        public double? Iops { get; set; }

        /// <summary>
        /// Checks to see if the Iops property is set.
        /// </summary>
        internal bool IsSetIops() => this.Iops.HasValue;

        /// <summary>
        /// Gets and sets the property StorageThroughput. 
        /// <para>
        /// The storage throughput for the DB instance.
        /// </para>
        /// </summary>
        public double? StorageThroughput { get; set; }

        /// <summary>
        /// Checks to see if the StorageThroughput property is set.
        /// </summary>
        internal bool IsSetStorageThroughput() => this.StorageThroughput.HasValue;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The storage type to associate with the DB instance.
        /// </para>
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;
    }
}
