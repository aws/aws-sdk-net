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
        /// <summary>
        /// Gets and sets the property CpuCount. 
        /// <para>
        /// The number of vCPUs included in the power.
        /// </para>
        /// </summary>
        public float? CpuCount { get; set; }

        /// <summary>
        /// Checks to see if the CpuCount property is set.
        /// </summary>
        internal bool IsSetCpuCount() => this.CpuCount.HasValue;

        /// <summary>
        /// Gets and sets the property IsActive. 
        /// <para>
        /// A Boolean value indicating whether the power is active and can be specified for container
        /// services.
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
        /// The friendly name of the power (<c>nano</c>).
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PowerId. 
        /// <para>
        /// The ID of the power (<c>nano-1</c>).
        /// </para>
        /// </summary>
        public string PowerId { get; set; }

        /// <summary>
        /// Checks to see if the PowerId property is set.
        /// </summary>
        internal bool IsSetPowerId() => this.PowerId != null;

        /// <summary>
        /// Gets and sets the property Price. 
        /// <para>
        /// The monthly price of the power in USD.
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
        /// The amount of RAM (in GB) of the power.
        /// </para>
        /// </summary>
        public float? RamSizeInGb { get; set; }

        /// <summary>
        /// Checks to see if the RamSizeInGb property is set.
        /// </summary>
        internal bool IsSetRamSizeInGb() => this.RamSizeInGb.HasValue;
    }
}
