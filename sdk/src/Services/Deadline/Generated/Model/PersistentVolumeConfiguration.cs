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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
        private int? _iops;
        private int? _lastUsedTtlHours;
        private string _mountPath;
        private int? _sizeGiB;
        private int? _throughputMiB;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The IOPS per persistent volume. The default is 3000.
        /// </para>
        /// </summary>
        [AWSProperty(Min=100, Max=80000)]
        public int? Iops
        {
            get { return this._iops; }
            set { this._iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this._iops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUsedTtlHours. 
        /// <para>
        /// The number of hours a persistent volume can remain unused before it is deleted. The
        /// default is 168 (7 days).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8760)]
        public int? LastUsedTtlHours
        {
            get { return this._lastUsedTtlHours; }
            set { this._lastUsedTtlHours = value; }
        }

        // Check to see if LastUsedTtlHours property is set
        internal bool IsSetLastUsedTtlHours()
        {
            return this._lastUsedTtlHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MountPath. 
        /// <para>
        /// The file system path where the persistent volume is mounted on the worker instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string MountPath
        {
            get { return this._mountPath; }
            set { this._mountPath = value; }
        }

        // Check to see if MountPath property is set
        internal bool IsSetMountPath()
        {
            return this._mountPath != null;
        }

        /// <summary>
        /// Gets and sets the property SizeGiB. 
        /// <para>
        /// The persistent volume size in GiB. The default is 250.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65536)]
        public int? SizeGiB
        {
            get { return this._sizeGiB; }
            set { this._sizeGiB = value; }
        }

        // Check to see if SizeGiB property is set
        internal bool IsSetSizeGiB()
        {
            return this._sizeGiB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThroughputMiB. 
        /// <para>
        /// The throughput per persistent volume in MiB. The default is 125.
        /// </para>
        /// </summary>
        [AWSProperty(Min=125, Max=2000)]
        public int? ThroughputMiB
        {
            get { return this._throughputMiB; }
            set { this._throughputMiB = value; }
        }

        // Check to see if ThroughputMiB property is set
        internal bool IsSetThroughputMiB()
        {
            return this._throughputMiB.HasValue; 
        }

    }
}