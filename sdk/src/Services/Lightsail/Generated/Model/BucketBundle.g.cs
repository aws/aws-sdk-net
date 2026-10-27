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
    /// Describes the specifications of a bundle that can be applied to an Amazon Lightsail
    /// bucket.
    /// 
    ///  
    /// <para>
    /// A bucket bundle specifies the monthly cost, storage space, and data transfer quota
    /// for a bucket.
    /// </para>
    /// </summary>
    public partial class BucketBundle
    {
        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The ID of the bundle.
        /// </para>
        /// </summary>
        public string BundleId { get; set; }

        /// <summary>
        /// Checks to see if the BundleId property is set.
        /// </summary>
        internal bool IsSetBundleId() => this.BundleId != null;

        /// <summary>
        /// Gets and sets the property IsActive. 
        /// <para>
        /// Indicates whether the bundle is active. Use for a new or existing bucket.
        /// </para>
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// Checks to see if the IsActive property is set.
        /// </summary>
        internal bool IsSetIsActive() => this.IsActive.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the bundle.
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
        /// The monthly price of the bundle, in US dollars.
        /// </para>
        /// </summary>
        public float? Price { get; set; }

        /// <summary>
        /// Checks to see if the Price property is set.
        /// </summary>
        internal bool IsSetPrice() => this.Price.HasValue;

        /// <summary>
        /// Gets and sets the property StoragePerMonthInGb. 
        /// <para>
        /// The storage size of the bundle, in GB.
        /// </para>
        /// </summary>
        public int? StoragePerMonthInGb { get; set; }

        /// <summary>
        /// Checks to see if the StoragePerMonthInGb property is set.
        /// </summary>
        internal bool IsSetStoragePerMonthInGb() => this.StoragePerMonthInGb.HasValue;

        /// <summary>
        /// Gets and sets the property TransferPerMonthInGb. 
        /// <para>
        /// The monthly network transfer quota of the bundle.
        /// </para>
        /// </summary>
        public int? TransferPerMonthInGb { get; set; }

        /// <summary>
        /// Checks to see if the TransferPerMonthInGb property is set.
        /// </summary>
        internal bool IsSetTransferPerMonthInGb() => this.TransferPerMonthInGb.HasValue;
    }
}
