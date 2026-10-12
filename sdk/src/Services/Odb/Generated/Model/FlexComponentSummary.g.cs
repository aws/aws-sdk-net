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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// Information about a flex component that's available for an Exadata infrastructure.
    /// A flex component defines the hardware resources, such as CPU cores, memory, and storage,
    /// that can be allocated to a shape.
    /// </summary>
    public partial class FlexComponentSummary
    {
        /// <summary>
        /// Gets and sets the property AvailableCoreCount. 
        /// <para>
        /// The maximum number of CPU cores that can be enabled for the flex component.
        /// </para>
        /// </summary>
        public int? AvailableCoreCount { get; set; }

        /// <summary>
        /// Checks to see if the AvailableCoreCount property is set.
        /// </summary>
        internal bool IsSetAvailableCoreCount() => this.AvailableCoreCount.HasValue;

        /// <summary>
        /// Gets and sets the property AvailableDbStorageInGBs. 
        /// <para>
        /// The maximum amount of database storage, in gigabytes (GB), that can be enabled for
        /// the flex component.
        /// </para>
        /// </summary>
        public int? AvailableDbStorageInGBs { get; set; }

        /// <summary>
        /// Checks to see if the AvailableDbStorageInGBs property is set.
        /// </summary>
        internal bool IsSetAvailableDbStorageInGBs() => this.AvailableDbStorageInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property AvailableLocalStorageInGBs. 
        /// <para>
        /// The maximum amount of local storage, in gigabytes (GB), that can be enabled for the
        /// flex component.
        /// </para>
        /// </summary>
        public int? AvailableLocalStorageInGBs { get; set; }

        /// <summary>
        /// Checks to see if the AvailableLocalStorageInGBs property is set.
        /// </summary>
        internal bool IsSetAvailableLocalStorageInGBs() => this.AvailableLocalStorageInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property AvailableMemoryInGBs. 
        /// <para>
        /// The maximum amount of memory, in gigabytes (GB), that can be enabled for the flex
        /// component.
        /// </para>
        /// </summary>
        public int? AvailableMemoryInGBs { get; set; }

        /// <summary>
        /// Checks to see if the AvailableMemoryInGBs property is set.
        /// </summary>
        internal bool IsSetAvailableMemoryInGBs() => this.AvailableMemoryInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property ComputeModel. 
        /// <para>
        /// The OCI model compute model used when you create or clone an instance: ECPU or OCPU.
        /// An ECPU is an abstracted measure of compute resources. ECPUs are based on the number
        /// of cores elastically allocated from a pool of compute and storage servers. An OCPU
        /// is a legacy physical measure of compute resources. OCPUs are based on the physical
        /// core of a processor with hyper-threading enabled. 
        /// </para>
        /// </summary>
        public ComputeModel ComputeModel { get; set; }

        /// <summary>
        /// Checks to see if the ComputeModel property is set.
        /// </summary>
        internal bool IsSetComputeModel() => this.ComputeModel != null;

        /// <summary>
        /// Gets and sets the property DescriptionSummary. 
        /// <para>
        /// A summary description of the flex component.
        /// </para>
        /// </summary>
        public string DescriptionSummary { get; set; }

        /// <summary>
        /// Checks to see if the DescriptionSummary property is set.
        /// </summary>
        internal bool IsSetDescriptionSummary() => this.DescriptionSummary != null;

        /// <summary>
        /// Gets and sets the property HardwareType. 
        /// <para>
        /// The type of hardware for the flex component. Valid values are <c>COMPUTE</c> for compute
        /// servers and <c>CELL</c> for storage servers.
        /// </para>
        /// </summary>
        public HardwareType HardwareType { get; set; }

        /// <summary>
        /// Checks to see if the HardwareType property is set.
        /// </summary>
        internal bool IsSetHardwareType() => this.HardwareType != null;

        /// <summary>
        /// Gets and sets the property MinimumCoreCount. 
        /// <para>
        /// The minimum number of CPU cores that can be enabled for the flex component.
        /// </para>
        /// </summary>
        public int? MinimumCoreCount { get; set; }

        /// <summary>
        /// Checks to see if the MinimumCoreCount property is set.
        /// </summary>
        internal bool IsSetMinimumCoreCount() => this.MinimumCoreCount.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the flex component.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RuntimeMinimumCoreCount. 
        /// <para>
        /// The runtime minimum number of CPU cores that can be enabled for the flex component.
        /// </para>
        /// </summary>
        public int? RuntimeMinimumCoreCount { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeMinimumCoreCount property is set.
        /// </summary>
        internal bool IsSetRuntimeMinimumCoreCount() => this.RuntimeMinimumCoreCount.HasValue;

        /// <summary>
        /// Gets and sets the property Shape. 
        /// <para>
        /// The shape that uses the flex component.
        /// </para>
        /// </summary>
        public string Shape { get; set; }

        /// <summary>
        /// Checks to see if the Shape property is set.
        /// </summary>
        internal bool IsSetShape() => this.Shape != null;
    }
}
