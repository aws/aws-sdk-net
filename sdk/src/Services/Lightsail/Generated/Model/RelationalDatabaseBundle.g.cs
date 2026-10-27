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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes a database bundle. A bundle describes the performance specifications of
    /// the database.
    /// </summary>
    public partial class RelationalDatabaseBundle
    {
        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The ID for the database bundle.
        /// </para>
        /// </summary>
        public string BundleId { get; set; }

        /// <summary>
        /// Checks to see if the BundleId property is set.
        /// </summary>
        internal bool IsSetBundleId() => this.BundleId != null;

        /// <summary>
        /// Gets and sets the property CpuCount. 
        /// <para>
        /// The number of virtual CPUs (vCPUs) for the database bundle.
        /// </para>
        /// </summary>
        public int? CpuCount { get; set; }

        /// <summary>
        /// Checks to see if the CpuCount property is set.
        /// </summary>
        internal bool IsSetCpuCount() => this.CpuCount.HasValue;

        /// <summary>
        /// Gets and sets the property DiskSizeInGb. 
        /// <para>
        /// The size of the disk for the database bundle.
        /// </para>
        /// </summary>
        public int? DiskSizeInGb { get; set; }

        /// <summary>
        /// Checks to see if the DiskSizeInGb property is set.
        /// </summary>
        internal bool IsSetDiskSizeInGb() => this.DiskSizeInGb.HasValue;

        /// <summary>
        /// Gets and sets the property IsActive. 
        /// <para>
        /// A Boolean value indicating whether the database bundle is active.
        /// </para>
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// Checks to see if the IsActive property is set.
        /// </summary>
        internal bool IsSetIsActive() => this.IsActive.HasValue;

        /// <summary>
        /// Gets and sets the property IsEncrypted. 
        /// <para>
        /// A Boolean value indicating whether the database bundle is encrypted.
        /// </para>
        /// </summary>
        public bool? IsEncrypted { get; set; }

        /// <summary>
        /// Checks to see if the IsEncrypted property is set.
        /// </summary>
        internal bool IsSetIsEncrypted() => this.IsEncrypted.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the database bundle.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Price. 
        /// <para>
        /// The cost of the database bundle in US currency.
        /// </para>
        /// </summary>
        public float? Price { get; set; }

        /// <summary>
        /// Checks to see if the Price property is set.
        /// </summary>
        internal bool IsSetPrice() => this.Price.HasValue;

        /// <summary>
        /// Gets and sets the property RamSizeInGb. 
        /// <para>
        /// The amount of RAM in GB (for example, <c>2.0</c>) for the database bundle.
        /// </para>
        /// </summary>
        public float? RamSizeInGb { get; set; }

        /// <summary>
        /// Checks to see if the RamSizeInGb property is set.
        /// </summary>
        internal bool IsSetRamSizeInGb() => this.RamSizeInGb.HasValue;

        /// <summary>
        /// Gets and sets the property TransferPerMonthInGb. 
        /// <para>
        /// The data transfer rate per month in GB for the database bundle.
        /// </para>
        /// </summary>
        public int? TransferPerMonthInGb { get; set; }

        /// <summary>
        /// Checks to see if the TransferPerMonthInGb property is set.
        /// </summary>
        internal bool IsSetTransferPerMonthInGb() => this.TransferPerMonthInGb.HasValue;
    }
}
