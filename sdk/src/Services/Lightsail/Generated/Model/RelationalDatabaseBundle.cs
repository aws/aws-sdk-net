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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes a database bundle. A bundle describes the performance specifications of
    /// the database.
    /// </summary>
    public partial class RelationalDatabaseBundle
    {
        private string _bundleId;
        private int? _cpuCount;
        private int? _diskSizeInGb;
        private bool? _isActive;
        private bool? _isEncrypted;
        private string _name;
        private float? _price;
        private float? _ramSizeInGb;
        private int? _transferPerMonthInGb;

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The ID for the database bundle.
        /// </para>
        /// </summary>
        public string BundleId
        {
            get { return this._bundleId; }
            set { this._bundleId = value; }
        }

        // Check to see if BundleId property is set
        internal bool IsSetBundleId()
        {
            return this._bundleId != null;
        }

        /// <summary>
        /// Gets and sets the property CpuCount. 
        /// <para>
        /// The number of virtual CPUs (vCPUs) for the database bundle.
        /// </para>
        /// </summary>
        public int? CpuCount
        {
            get { return this._cpuCount; }
            set { this._cpuCount = value; }
        }

        // Check to see if CpuCount property is set
        internal bool IsSetCpuCount()
        {
            return this._cpuCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DiskSizeInGb. 
        /// <para>
        /// The size of the disk for the database bundle.
        /// </para>
        /// </summary>
        public int? DiskSizeInGb
        {
            get { return this._diskSizeInGb; }
            set { this._diskSizeInGb = value; }
        }

        // Check to see if DiskSizeInGb property is set
        internal bool IsSetDiskSizeInGb()
        {
            return this._diskSizeInGb.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsActive. 
        /// <para>
        /// A Boolean value indicating whether the database bundle is active.
        /// </para>
        /// </summary>
        public bool? IsActive
        {
            get { return this._isActive; }
            set { this._isActive = value; }
        }

        // Check to see if IsActive property is set
        internal bool IsSetIsActive()
        {
            return this._isActive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsEncrypted. 
        /// <para>
        /// A Boolean value indicating whether the database bundle is encrypted.
        /// </para>
        /// </summary>
        public bool? IsEncrypted
        {
            get { return this._isEncrypted; }
            set { this._isEncrypted = value; }
        }

        // Check to see if IsEncrypted property is set
        internal bool IsSetIsEncrypted()
        {
            return this._isEncrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the database bundle.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Price. 
        /// <para>
        /// The cost of the database bundle in US currency.
        /// </para>
        /// </summary>
        public float? Price
        {
            get { return this._price; }
            set { this._price = value; }
        }

        // Check to see if Price property is set
        internal bool IsSetPrice()
        {
            return this._price.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RamSizeInGb. 
        /// <para>
        /// The amount of RAM in GB (for example, <c>2.0</c>) for the database bundle.
        /// </para>
        /// </summary>
        public float? RamSizeInGb
        {
            get { return this._ramSizeInGb; }
            set { this._ramSizeInGb = value; }
        }

        // Check to see if RamSizeInGb property is set
        internal bool IsSetRamSizeInGb()
        {
            return this._ramSizeInGb.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransferPerMonthInGb. 
        /// <para>
        /// The data transfer rate per month in GB for the database bundle.
        /// </para>
        /// </summary>
        public int? TransferPerMonthInGb
        {
            get { return this._transferPerMonthInGb; }
            set { this._transferPerMonthInGb = value; }
        }

        // Check to see if TransferPerMonthInGb property is set
        internal bool IsSetTransferPerMonthInGb()
        {
            return this._transferPerMonthInGb.HasValue; 
        }

    }
}