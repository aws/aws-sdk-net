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
    /// Information about a hardware system model (shape) that's available for an Exadata
    /// infrastructure. The shape determines resources, such as CPU cores, memory, and storage,
    /// to allocate to the Exadata infrastructure.
    /// </summary>
    public partial class DbSystemShapeSummary
    {
        private bool? _areServerTypesSupported;
        private int? _availableCoreCount;
        private int? _availableCoreCountPerNode;
        private int? _availableDataStorageInTBs;
        private int? _availableDataStoragePerServerInTBs;
        private int? _availableDbNodePerNodeInGBs;
        private int? _availableDbNodeStorageInGBs;
        private int? _availableMemoryInGBs;
        private int? _availableMemoryPerNodeInGBs;
        private ComputeModel _computeModel;
        private int? _coreCountIncrement;
        private int? _maximumNodeCount;
        private int? _maxStorageCount;
        private int? _minCoreCountPerNode;
        private int? _minDataStorageInTBs;
        private int? _minDbNodeStoragePerNodeInGBs;
        private int? _minimumCoreCount;
        private int? _minimumNodeCount;
        private int? _minMemoryPerNodeInGBs;
        private int? _minStorageCount;
        private string _name;
        private int? _runtimeMinimumCoreCount;
        private string _shapeFamily;
        private ShapeType _shapeType;

        /// <summary>
        /// Gets and sets the property AreServerTypesSupported. 
        /// <para>
        /// Indicates whether the hardware system model supports configurable database and server
        /// storage types.
        /// </para>
        /// </summary>
        public bool? AreServerTypesSupported
        {
            get { return this._areServerTypesSupported; }
            set { this._areServerTypesSupported = value; }
        }

        // Check to see if AreServerTypesSupported property is set
        internal bool IsSetAreServerTypesSupported()
        {
            return this._areServerTypesSupported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailableCoreCount. 
        /// <para>
        /// The maximum number of CPU cores that can be enabled for the shape.
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
        /// Gets and sets the property AvailableCoreCountPerNode. 
        /// <para>
        /// The maximum number of CPU cores per DB node that can be enabled for the shape.
        /// </para>
        /// </summary>
        public int? AvailableCoreCountPerNode
        {
            get { return this._availableCoreCountPerNode; }
            set { this._availableCoreCountPerNode = value; }
        }

        // Check to see if AvailableCoreCountPerNode property is set
        internal bool IsSetAvailableCoreCountPerNode()
        {
            return this._availableCoreCountPerNode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailableDataStorageInTBs. 
        /// <para>
        /// The maximum amount of data storage, in terabytes (TB), that can be enabled for the
        /// shape.
        /// </para>
        /// </summary>
        public int? AvailableDataStorageInTBs
        {
            get { return this._availableDataStorageInTBs; }
            set { this._availableDataStorageInTBs = value; }
        }

        // Check to see if AvailableDataStorageInTBs property is set
        internal bool IsSetAvailableDataStorageInTBs()
        {
            return this._availableDataStorageInTBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailableDataStoragePerServerInTBs. 
        /// <para>
        /// The maximum amount of data storage, in terabytes (TB), that's available per storage
        /// server for the shape.
        /// </para>
        /// </summary>
        public int? AvailableDataStoragePerServerInTBs
        {
            get { return this._availableDataStoragePerServerInTBs; }
            set { this._availableDataStoragePerServerInTBs = value; }
        }

        // Check to see if AvailableDataStoragePerServerInTBs property is set
        internal bool IsSetAvailableDataStoragePerServerInTBs()
        {
            return this._availableDataStoragePerServerInTBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailableDbNodePerNodeInGBs. 
        /// <para>
        /// The maximum amount of DB node storage, in gigabytes (GB), that's available per DB
        /// node for the shape.
        /// </para>
        /// </summary>
        public int? AvailableDbNodePerNodeInGBs
        {
            get { return this._availableDbNodePerNodeInGBs; }
            set { this._availableDbNodePerNodeInGBs = value; }
        }

        // Check to see if AvailableDbNodePerNodeInGBs property is set
        internal bool IsSetAvailableDbNodePerNodeInGBs()
        {
            return this._availableDbNodePerNodeInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailableDbNodeStorageInGBs. 
        /// <para>
        /// The maximum amount of DB node storage, in gigabytes (GB), that can be enabled for
        /// the shape.
        /// </para>
        /// </summary>
        public int? AvailableDbNodeStorageInGBs
        {
            get { return this._availableDbNodeStorageInGBs; }
            set { this._availableDbNodeStorageInGBs = value; }
        }

        // Check to see if AvailableDbNodeStorageInGBs property is set
        internal bool IsSetAvailableDbNodeStorageInGBs()
        {
            return this._availableDbNodeStorageInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailableMemoryInGBs. 
        /// <para>
        /// The maximum amount of memory, in gigabytes (GB), that can be enabled for the shape.
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
        /// Gets and sets the property AvailableMemoryPerNodeInGBs. 
        /// <para>
        /// The maximum amount of memory, in gigabytes (GB), that's available per DB node for
        /// the shape.
        /// </para>
        /// </summary>
        public int? AvailableMemoryPerNodeInGBs
        {
            get { return this._availableMemoryPerNodeInGBs; }
            set { this._availableMemoryPerNodeInGBs = value; }
        }

        // Check to see if AvailableMemoryPerNodeInGBs property is set
        internal bool IsSetAvailableMemoryPerNodeInGBs()
        {
            return this._availableMemoryPerNodeInGBs.HasValue; 
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
        /// Gets and sets the property CoreCountIncrement. 
        /// <para>
        /// The discrete number by which the CPU core count for the shape can be increased or
        /// decreased.
        /// </para>
        /// </summary>
        public int? CoreCountIncrement
        {
            get { return this._coreCountIncrement; }
            set { this._coreCountIncrement = value; }
        }

        // Check to see if CoreCountIncrement property is set
        internal bool IsSetCoreCountIncrement()
        {
            return this._coreCountIncrement.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumNodeCount. 
        /// <para>
        /// The maximum number of compute servers that is available for the shape.
        /// </para>
        /// </summary>
        public int? MaximumNodeCount
        {
            get { return this._maximumNodeCount; }
            set { this._maximumNodeCount = value; }
        }

        // Check to see if MaximumNodeCount property is set
        internal bool IsSetMaximumNodeCount()
        {
            return this._maximumNodeCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxStorageCount. 
        /// <para>
        /// The maximum number of Exadata storage servers that's available for the shape.
        /// </para>
        /// </summary>
        public int? MaxStorageCount
        {
            get { return this._maxStorageCount; }
            set { this._maxStorageCount = value; }
        }

        // Check to see if MaxStorageCount property is set
        internal bool IsSetMaxStorageCount()
        {
            return this._maxStorageCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinCoreCountPerNode. 
        /// <para>
        /// The minimum number of CPU cores that can be enabled per node for the shape.
        /// </para>
        /// </summary>
        public int? MinCoreCountPerNode
        {
            get { return this._minCoreCountPerNode; }
            set { this._minCoreCountPerNode = value; }
        }

        // Check to see if MinCoreCountPerNode property is set
        internal bool IsSetMinCoreCountPerNode()
        {
            return this._minCoreCountPerNode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinDataStorageInTBs. 
        /// <para>
        /// The minimum amount of data storage, in terabytes (TB), that must be allocated for
        /// the shape.
        /// </para>
        /// </summary>
        public int? MinDataStorageInTBs
        {
            get { return this._minDataStorageInTBs; }
            set { this._minDataStorageInTBs = value; }
        }

        // Check to see if MinDataStorageInTBs property is set
        internal bool IsSetMinDataStorageInTBs()
        {
            return this._minDataStorageInTBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinDbNodeStoragePerNodeInGBs. 
        /// <para>
        /// The minimum amount of DB node storage, in gigabytes (GB), that must be allocated per
        /// DB node for the shape.
        /// </para>
        /// </summary>
        public int? MinDbNodeStoragePerNodeInGBs
        {
            get { return this._minDbNodeStoragePerNodeInGBs; }
            set { this._minDbNodeStoragePerNodeInGBs = value; }
        }

        // Check to see if MinDbNodeStoragePerNodeInGBs property is set
        internal bool IsSetMinDbNodeStoragePerNodeInGBs()
        {
            return this._minDbNodeStoragePerNodeInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinimumCoreCount. 
        /// <para>
        /// The minimum number of CPU cores that can be enabled for the shape.
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
        /// Gets and sets the property MinimumNodeCount. 
        /// <para>
        /// The minimum number of compute servers that are available for the shape.
        /// </para>
        /// </summary>
        public int? MinimumNodeCount
        {
            get { return this._minimumNodeCount; }
            set { this._minimumNodeCount = value; }
        }

        // Check to see if MinimumNodeCount property is set
        internal bool IsSetMinimumNodeCount()
        {
            return this._minimumNodeCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinMemoryPerNodeInGBs. 
        /// <para>
        /// The minimum amount of memory, in gigabytes (GB), that must be allocated per DB node
        /// for the shape.
        /// </para>
        /// </summary>
        public int? MinMemoryPerNodeInGBs
        {
            get { return this._minMemoryPerNodeInGBs; }
            set { this._minMemoryPerNodeInGBs = value; }
        }

        // Check to see if MinMemoryPerNodeInGBs property is set
        internal bool IsSetMinMemoryPerNodeInGBs()
        {
            return this._minMemoryPerNodeInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinStorageCount. 
        /// <para>
        /// The minimum number of Exadata storage servers that are available for the shape.
        /// </para>
        /// </summary>
        public int? MinStorageCount
        {
            get { return this._minStorageCount; }
            set { this._minStorageCount = value; }
        }

        // Check to see if MinStorageCount property is set
        internal bool IsSetMinStorageCount()
        {
            return this._minStorageCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the shape.
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
        /// The runtime minimum number of CPU cores that can be enabled for the shape.
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
        /// Gets and sets the property ShapeFamily. 
        /// <para>
        /// The family of the shape.
        /// </para>
        /// </summary>
        public string ShapeFamily
        {
            get { return this._shapeFamily; }
            set { this._shapeFamily = value; }
        }

        // Check to see if ShapeFamily property is set
        internal bool IsSetShapeFamily()
        {
            return this._shapeFamily != null;
        }

        /// <summary>
        /// Gets and sets the property ShapeType. 
        /// <para>
        /// The shape type. This property is determined by the CPU hardware.
        /// </para>
        /// </summary>
        public ShapeType ShapeType
        {
            get { return this._shapeType; }
            set { this._shapeType = value; }
        }

        // Check to see if ShapeType property is set
        internal bool IsSetShapeType()
        {
            return this._shapeType != null;
        }

    }
}