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
    /// Describes a bundle, which is a set of specs describing your virtual private server
    /// (or <i>instance</i>).
    /// </summary>
    public partial class Bundle
    {
        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The bundle ID (<c>micro_x_x</c>).
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
        /// The number of vCPUs included in the bundle (<c>2</c>).
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
        /// The size of the SSD (<c>30</c>).
        /// </para>
        /// </summary>
        public int? DiskSizeInGb { get; set; }

        /// <summary>
        /// Checks to see if the DiskSizeInGb property is set.
        /// </summary>
        internal bool IsSetDiskSizeInGb() => this.DiskSizeInGb.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type (<c>micro</c>).
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property IsActive. 
        /// <para>
        /// A Boolean value indicating whether the bundle is active.
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
        /// A friendly name for the bundle (<c>Micro</c>).
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Power. 
        /// <para>
        /// A numeric value that represents the power of the bundle (<c>500</c>). You can use
        /// the bundle's power value in conjunction with a blueprint's minimum power value to
        /// determine whether the blueprint will run on the bundle. For example, you need a bundle
        /// with a power value of 500 or more to create an instance that uses a blueprint with
        /// a minimum power value of 500.
        /// </para>
        /// </summary>
        public int? Power { get; set; }

        /// <summary>
        /// Checks to see if the Power property is set.
        /// </summary>
        internal bool IsSetPower() => this.Power.HasValue;

        /// <summary>
        /// Gets and sets the property Price. 
        /// <para>
        /// The price in US dollars (<c>5.0</c>) of the bundle.
        /// </para>
        /// </summary>
        public float? Price { get; set; }

        /// <summary>
        /// Checks to see if the Price property is set.
        /// </summary>
        internal bool IsSetPrice() => this.Price.HasValue;

        /// <summary>
        /// Gets and sets the property PublicIpv4AddressCount. 
        /// <para>
        /// An integer that indicates the public ipv4 address count included in the bundle, the
        /// value is either 0 or 1.
        /// </para>
        /// </summary>
        public int? PublicIpv4AddressCount { get; set; }

        /// <summary>
        /// Checks to see if the PublicIpv4AddressCount property is set.
        /// </summary>
        internal bool IsSetPublicIpv4AddressCount() => this.PublicIpv4AddressCount.HasValue;

        /// <summary>
        /// Gets and sets the property RamSizeInGb. 
        /// <para>
        /// The amount of RAM in GB (<c>2.0</c>).
        /// </para>
        /// </summary>
        public float? RamSizeInGb { get; set; }

        /// <summary>
        /// Checks to see if the RamSizeInGb property is set.
        /// </summary>
        internal bool IsSetRamSizeInGb() => this.RamSizeInGb.HasValue;

        /// <summary>
        /// Gets and sets the property SupportedAppCategories. 
        /// <para>
        /// Virtual computer blueprints that are supported by a Lightsail for Research bundle.
        /// </para>
        ///  <important> 
        /// <para>
        /// This parameter only applies to Lightsail for Research resources.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedAppCategories { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedAppCategories property is set.
        /// </summary>
        internal bool IsSetSupportedAppCategories() => this.SupportedAppCategories != null && (this.SupportedAppCategories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedPlatforms. 
        /// <para>
        /// The operating system platform (Linux/Unix-based or Windows Server-based) that the
        /// bundle supports. You can only launch a <c>WINDOWS</c> bundle on a blueprint that supports
        /// the <c>WINDOWS</c> platform. <c>LINUX_UNIX</c> blueprints require a <c>LINUX_UNIX</c>
        /// bundle.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedPlatforms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedPlatforms property is set.
        /// </summary>
        internal bool IsSetSupportedPlatforms() => this.SupportedPlatforms != null && (this.SupportedPlatforms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TransferPerMonthInGb. 
        /// <para>
        /// The data transfer rate per month in GB (<c>2000</c>).
        /// </para>
        /// </summary>
        public int? TransferPerMonthInGb { get; set; }

        /// <summary>
        /// Checks to see if the TransferPerMonthInGb property is set.
        /// </summary>
        internal bool IsSetTransferPerMonthInGb() => this.TransferPerMonthInGb.HasValue;
    }
}
