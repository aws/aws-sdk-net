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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the hardware for the instance.
    /// </summary>
    public partial class InstanceHardware
    {
        private int? _cpuCount;
        private List<Disk> _disks = new List<Disk>();
        private float? _ramSizeInGb;

        /// <summary>
        /// Gets and sets the property CpuCount. 
        /// <para>
        /// The number of vCPUs the instance has.
        /// </para>
        /// </summary>
        public int CpuCount
        {
            get { return this._cpuCount.GetValueOrDefault(); }
            set { this._cpuCount = value; }
        }

        // Check to see if CpuCount property is set
        internal bool IsSetCpuCount()
        {
            return this._cpuCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Disks. 
        /// <para>
        /// The disks attached to the instance.
        /// </para>
        /// </summary>
        public List<Disk> Disks
        {
            get { return this._disks; }
            set { this._disks = value; }
        }

        // Check to see if Disks property is set
        internal bool IsSetDisks()
        {
            return this._disks != null && this._disks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RamSizeInGb. 
        /// <para>
        /// The amount of RAM in GB on the instance (e.g., <code>1.0</code>).
        /// </para>
        /// </summary>
        public float RamSizeInGb
        {
            get { return this._ramSizeInGb.GetValueOrDefault(); }
            set { this._ramSizeInGb = value; }
        }

        // Check to see if RamSizeInGb property is set
        internal bool IsSetRamSizeInGb()
        {
            return this._ramSizeInGb.HasValue; 
        }

    }
}