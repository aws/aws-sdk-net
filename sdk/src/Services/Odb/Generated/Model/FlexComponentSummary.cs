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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
        private int? _availableCoreCount;
        private int? _availableDbStorageInGBs;
        private int? _availableLocalStorageInGBs;
        private int? _availableMemoryInGBs;
        private ComputeModel _computeModel;
        private string _descriptionSummary;
        private HardwareType _hardwareType;
        private int? _minimumCoreCount;
        private string _name;
        private int? _runtimeMinimumCoreCount;
        private string _shape;

        /// <summary>
        /// Gets and sets the property AvailableCoreCount. 
        /// <para>
        /// The maximum number of CPU cores that can be enabled for the flex component.
        /// </para>
        /// </summary>
        public int? AvailableCoreCount
        {
            get { return this._availableCoreCount; }
            set { this._availableCoreCount = value; }
        }

        // Check to see if AvailableCoreCount property is set
        internal bool IsSetAvailableCoreCount()
        {
            return this._availableCoreCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailableDbStorageInGBs. 
        /// <para>
        /// The maximum amount of database storage, in gigabytes (GB), that can be enabled for
        /// the flex component.
        /// </para>
        /// </summary>
        public int? AvailableDbStorageInGBs
        {
            get { return this._availableDbStorageInGBs; }
            set { this._availableDbStorageInGBs = value; }
        }

        // Check to see if AvailableDbStorageInGBs property is set
        internal bool IsSetAvailableDbStorageInGBs()
        {
            return this._availableDbStorageInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailableLocalStorageInGBs. 
        /// <para>
        /// The maximum amount of local storage, in gigabytes (GB), that can be enabled for the
        /// flex component.
        /// </para>
        /// </summary>
        public int? AvailableLocalStorageInGBs
        {
            get { return this._availableLocalStorageInGBs; }
            set { this._availableLocalStorageInGBs = value; }
        }

        // Check to see if AvailableLocalStorageInGBs property is set
        internal bool IsSetAvailableLocalStorageInGBs()
        {
            return this._availableLocalStorageInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailableMemoryInGBs. 
        /// <para>
        /// The maximum amount of memory, in gigabytes (GB), that can be enabled for the flex
        /// component.
        /// </para>
        /// </summary>
        public int? AvailableMemoryInGBs
        {
            get { return this._availableMemoryInGBs; }
            set { this._availableMemoryInGBs = value; }
        }

        // Check to see if AvailableMemoryInGBs property is set
        internal bool IsSetAvailableMemoryInGBs()
        {
            return this._availableMemoryInGBs.HasValue; 
        }

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
        public ComputeModel ComputeModel
        {
            get { return this._computeModel; }
            set { this._computeModel = value; }
        }

        // Check to see if ComputeModel property is set
        internal bool IsSetComputeModel()
        {
            return this._computeModel != null;
        }

        /// <summary>
        /// Gets and sets the property DescriptionSummary. 
        /// <para>
        /// A summary description of the flex component.
        /// </para>
        /// </summary>
        public string DescriptionSummary
        {
            get { return this._descriptionSummary; }
            set { this._descriptionSummary = value; }
        }

        // Check to see if DescriptionSummary property is set
        internal bool IsSetDescriptionSummary()
        {
            return this._descriptionSummary != null;
        }

        /// <summary>
        /// Gets and sets the property HardwareType. 
        /// <para>
        /// The type of hardware for the flex component. Valid values are <c>COMPUTE</c> for compute
        /// servers and <c>CELL</c> for storage servers.
        /// </para>
        /// </summary>
        public HardwareType HardwareType
        {
            get { return this._hardwareType; }
            set { this._hardwareType = value; }
        }

        // Check to see if HardwareType property is set
        internal bool IsSetHardwareType()
        {
            return this._hardwareType != null;
        }

        /// <summary>
        /// Gets and sets the property MinimumCoreCount. 
        /// <para>
        /// The minimum number of CPU cores that can be enabled for the flex component.
        /// </para>
        /// </summary>
        public int? MinimumCoreCount
        {
            get { return this._minimumCoreCount; }
            set { this._minimumCoreCount = value; }
        }

        // Check to see if MinimumCoreCount property is set
        internal bool IsSetMinimumCoreCount()
        {
            return this._minimumCoreCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the flex component.
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
        /// Gets and sets the property RuntimeMinimumCoreCount. 
        /// <para>
        /// The runtime minimum number of CPU cores that can be enabled for the flex component.
        /// </para>
        /// </summary>
        public int? RuntimeMinimumCoreCount
        {
            get { return this._runtimeMinimumCoreCount; }
            set { this._runtimeMinimumCoreCount = value; }
        }

        // Check to see if RuntimeMinimumCoreCount property is set
        internal bool IsSetRuntimeMinimumCoreCount()
        {
            return this._runtimeMinimumCoreCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Shape. 
        /// <para>
        /// The shape that uses the flex component.
        /// </para>
        /// </summary>
        public string Shape
        {
            get { return this._shape; }
            set { this._shape = value; }
        }

        // Check to see if Shape property is set
        internal bool IsSetShape()
        {
            return this._shape != null;
        }

    }
}