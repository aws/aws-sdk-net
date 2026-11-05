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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Specifies the persistent EBS volume configuration for workers in a service managed
    /// fleet.
    /// </summary>
    public partial class PersistentVolumeConfiguration
    {
        /// <summary>
        /// Gets and sets the property Iops. The IOPS per persistent volume. The default is 3000.
        /// </summary>
        [AWSProperty(Min = 100, Max = 80000)]
        public int? Iops { get; set; }

        /// <summary>
        /// Checks to see if the Iops property is set.
        /// </summary>
        internal bool IsSetIops() => this.Iops.HasValue;

        /// <summary>
        /// Gets and sets the property LastUsedTtlHours. The number of hours a persistent volume
        /// can remain unused before it is deleted. The default is 12.
        /// </summary>
        [AWSProperty(Min = 1, Max = 8760)]
        public int? LastUsedTtlHours { get; set; }

        /// <summary>
        /// Checks to see if the LastUsedTtlHours property is set.
        /// </summary>
        internal bool IsSetLastUsedTtlHours() => this.LastUsedTtlHours.HasValue;

        /// <summary>
        /// Gets and sets the property MountPath. The file system path where the persistent volume
        /// is mounted on the worker instance.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string MountPath { get; set; }

        /// <summary>
        /// Checks to see if the MountPath property is set.
        /// </summary>
        internal bool IsSetMountPath() => this.MountPath != null;

        /// <summary>
        /// Gets and sets the property SizeGiB. The persistent volume size in GiB. The default
        /// is 250.
        /// </summary>
        [AWSProperty(Min = 1, Max = 65536)]
        public int? SizeGiB { get; set; }

        /// <summary>
        /// Checks to see if the SizeGiB property is set.
        /// </summary>
        internal bool IsSetSizeGiB() => this.SizeGiB.HasValue;

        /// <summary>
        /// Gets and sets the property ThroughputMiB. The throughput per persistent volume in
        /// MiB. The default is 125.
        /// </summary>
        [AWSProperty(Min = 125, Max = 2000)]
        public int? ThroughputMiB { get; set; }

        /// <summary>
        /// Checks to see if the ThroughputMiB property is set.
        /// </summary>
        internal bool IsSetThroughputMiB() => this.ThroughputMiB.HasValue;
    }
}
