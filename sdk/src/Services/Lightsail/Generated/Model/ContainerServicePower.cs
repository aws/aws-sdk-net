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
    /// Describes the powers that can be specified for an Amazon Lightsail container service.
    /// 
    ///  
    /// <para>
    /// The power specifies the amount of RAM, the number of vCPUs, and the base price of
    /// the container service.
    /// </para>
    /// </summary>
    public partial class ContainerServicePower
    {
        private float? _cpuCount;
        private bool? _isActive;
        private string _name;
        private string _powerId;
        private float? _price;
        private float? _ramSizeInGb;

        /// <summary>
        /// Gets and sets the property CpuCount. 
        /// <para>
        /// The number of vCPUs included in the power.
        /// </para>
        /// </summary>
        public float? CpuCount
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
        /// Gets and sets the property IsActive. 
        /// <para>
        /// A Boolean value indicating whether the power is active and can be specified for container
        /// services.
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
        /// The friendly name of the power (<c>nano</c>).
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
        /// Gets and sets the property PowerId. 
        /// <para>
        /// The ID of the power (<c>nano-1</c>).
        /// </para>
        /// </summary>
        public string PowerId
        {
            get { return this._powerId; }
            set { this._powerId = value; }
        }

        // Check to see if PowerId property is set
        internal bool IsSetPowerId()
        {
            return this._powerId != null;
        }

        /// <summary>
        /// Gets and sets the property Price. 
        /// <para>
        /// The monthly price of the power in USD.
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
        /// The amount of RAM (in GB) of the power.
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

    }
}