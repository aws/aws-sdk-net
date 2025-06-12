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
    /// Describes a bundle, which is a set of specs describing your virtual private server
    /// (or <i>instance</i>).
    /// </summary>
    public partial class Bundle
    {
        private string _bundleId;
        private int? _cpuCount;
        private int? _diskSizeInGb;
        private string _instanceType;
        private bool? _isActive;
        private string _name;
        private int? _power;
        private float? _price;
        private int? _publicIpv4AddressCount;
        private float? _ramSizeInGb;
        private List<string> _supportedAppCategories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supportedPlatforms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _transferPerMonthInGb;

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The bundle ID (<c>micro_x_x</c>).
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
        /// The number of vCPUs included in the bundle (<c>2</c>).
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
        /// The size of the SSD (<c>30</c>).
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
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type (<c>micro</c>).
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property IsActive. 
        /// <para>
        /// A Boolean value indicating whether the bundle is active.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name for the bundle (<c>Micro</c>).
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
        /// Gets and sets the property Power. 
        /// <para>
        /// A numeric value that represents the power of the bundle (<c>500</c>). You can use
        /// the bundle's power value in conjunction with a blueprint's minimum power value to
        /// determine whether the blueprint will run on the bundle. For example, you need a bundle
        /// with a power value of 500 or more to create an instance that uses a blueprint with
        /// a minimum power value of 500.
        /// </para>
        /// </summary>
        public int? Power
        {
            get { return this._power; }
            set { this._power = value; }
        }

        // Check to see if Power property is set
        internal bool IsSetPower()
        {
            return this._power.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Price. 
        /// <para>
        /// The price in US dollars (<c>5.0</c>) of the bundle.
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
        /// Gets and sets the property PublicIpv4AddressCount. 
        /// <para>
        /// An integer that indicates the public ipv4 address count included in the bundle, the
        /// value is either 0 or 1.
        /// </para>
        /// </summary>
        public int? PublicIpv4AddressCount
        {
            get { return this._publicIpv4AddressCount; }
            set { this._publicIpv4AddressCount = value; }
        }

        // Check to see if PublicIpv4AddressCount property is set
        internal bool IsSetPublicIpv4AddressCount()
        {
            return this._publicIpv4AddressCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RamSizeInGb. 
        /// <para>
        /// The amount of RAM in GB (<c>2.0</c>).
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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedAppCategories
        {
            get { return this._supportedAppCategories; }
            set { this._supportedAppCategories = value; }
        }

        // Check to see if SupportedAppCategories property is set
        internal bool IsSetSupportedAppCategories()
        {
            return this._supportedAppCategories != null && (this._supportedAppCategories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedPlatforms. 
        /// <para>
        /// The operating system platform (Linux/Unix-based or Windows Server-based) that the
        /// bundle supports. You can only launch a <c>WINDOWS</c> bundle on a blueprint that supports
        /// the <c>WINDOWS</c> platform. <c>LINUX_UNIX</c> blueprints require a <c>LINUX_UNIX</c>
        /// bundle.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedPlatforms
        {
            get { return this._supportedPlatforms; }
            set { this._supportedPlatforms = value; }
        }

        // Check to see if SupportedPlatforms property is set
        internal bool IsSetSupportedPlatforms()
        {
            return this._supportedPlatforms != null && (this._supportedPlatforms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TransferPerMonthInGb. 
        /// <para>
        /// The data transfer rate per month in GB (<c>2000</c>).
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