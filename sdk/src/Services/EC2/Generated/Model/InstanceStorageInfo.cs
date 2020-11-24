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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the disks that are available for the instance type.
    /// </summary>
    public partial class InstanceStorageInfo
    {
        private List<DiskInfo> _disks = new List<DiskInfo>();
        private EphemeralNvmeSupport _nvmeSupport;
        private long? _totalSizeInGB;

        /// <summary>
        /// Gets and sets the property Disks. 
        /// <para>
        /// Describes the disks that are available for the instance type.
        /// </para>
        /// </summary>
        public List<DiskInfo> Disks
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
        /// Gets and sets the property NvmeSupport. 
        /// <para>
        /// Indicates whether non-volatile memory express (NVMe) is supported for instance store.
        /// </para>
        /// </summary>
        public EphemeralNvmeSupport NvmeSupport
        {
            get { return this._nvmeSupport; }
            set { this._nvmeSupport = value; }
        }

        // Check to see if NvmeSupport property is set
        internal bool IsSetNvmeSupport()
        {
            return this._nvmeSupport != null;
        }

        /// <summary>
        /// Gets and sets the property TotalSizeInGB. 
        /// <para>
        /// The total size of the disks, in GB.
        /// </para>
        /// </summary>
        public long TotalSizeInGB
        {
            get { return this._totalSizeInGB.GetValueOrDefault(); }
            set { this._totalSizeInGB = value; }
        }

        // Check to see if TotalSizeInGB property is set
        internal bool IsSetTotalSizeInGB()
        {
            return this._totalSizeInGB.HasValue; 
        }

    }
}