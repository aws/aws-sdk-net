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
    /// Information about a hardware system model (shape) that's available for an Exadata
    /// infrastructure. The shape determines resources, such as CPU cores, memory, and storage,
    /// to allocate to the Exadata infrastructure.
    /// </summary>
    public partial class DbSystemShapeSummary
    {
        /// <summary>
        /// Gets and sets the property AreServerTypesSupported. 
        /// <para>
        /// Indicates whether the hardware system model supports configurable database and server
        /// storage types.
        /// </para>
        /// </summary>
        public bool? AreServerTypesSupported { get; set; }

        /// <summary>
        /// Checks to see if the AreServerTypesSupported property is set.
        /// </summary>
        internal bool IsSetAreServerTypesSupported() => this.AreServerTypesSupported.HasValue;

        /// <summary>
        /// Gets and sets the property AvailableCoreCount. 
        /// <para>
        /// The maximum number of CPU cores that can be enabled for the shape.
        /// </para>
        /// </summary>
        public int? AvailableCoreCount { get; set; }

        /// <summary>
        /// Checks to see if the AvailableCoreCount property is set.
        /// </summary>
        internal bool IsSetAvailableCoreCount() => this.AvailableCoreCount.HasValue;

        /// <summary>
        /// Gets and sets the property AvailableCoreCountPerNode. 
        /// <para>
        /// The maximum number of CPU cores per DB node that can be enabled for the shape.
        /// </para>
        /// </summary>
        public int? AvailableCoreCountPerNode { get; set; }

        /// <summary>
        /// Checks to see if the AvailableCoreCountPerNode property is set.
        /// </summary>
        internal bool IsSetAvailableCoreCountPerNode() => this.AvailableCoreCountPerNode.HasValue;

        /// <summary>
        /// Gets and sets the property AvailableDataStorageInTBs. 
        /// <para>
        /// The maximum amount of data storage, in terabytes (TB), that can be enabled for the
        /// shape.
        /// </para>
        /// </summary>
        public int? AvailableDataStorageInTBs { get; set; }

        /// <summary>
        /// Checks to see if the AvailableDataStorageInTBs property is set.
        /// </summary>
        internal bool IsSetAvailableDataStorageInTBs() => this.AvailableDataStorageInTBs.HasValue;

        /// <summary>
        /// Gets and sets the property AvailableDataStoragePerServerInTBs. 
        /// <para>
        /// The maximum amount of data storage, in terabytes (TB), that's available per storage
        /// server for the shape.
        /// </para>
        /// </summary>
        public int? AvailableDataStoragePerServerInTBs { get; set; }

        /// <summary>
        /// Checks to see if the AvailableDataStoragePerServerInTBs property is set.
        /// </summary>
        internal bool IsSetAvailableDataStoragePerServerInTBs() => this.AvailableDataStoragePerServerInTBs.HasValue;

        /// <summary>
        /// Gets and sets the property AvailableDbNodePerNodeInGBs. 
        /// <para>
        /// The maximum amount of DB node storage, in gigabytes (GB), that's available per DB
        /// node for the shape.
        /// </para>
        /// </summary>
        public int? AvailableDbNodePerNodeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the AvailableDbNodePerNodeInGBs property is set.
        /// </summary>
        internal bool IsSetAvailableDbNodePerNodeInGBs() => this.AvailableDbNodePerNodeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property AvailableDbNodeStorageInGBs. 
        /// <para>
        /// The maximum amount of DB node storage, in gigabytes (GB), that can be enabled for
        /// the shape.
        /// </para>
        /// </summary>
        public int? AvailableDbNodeStorageInGBs { get; set; }

        /// <summary>
        /// Checks to see if the AvailableDbNodeStorageInGBs property is set.
        /// </summary>
        internal bool IsSetAvailableDbNodeStorageInGBs() => this.AvailableDbNodeStorageInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property AvailableMemoryInGBs. 
        /// <para>
        /// The maximum amount of memory, in gigabytes (GB), that can be enabled for the shape.
        /// </para>
        /// </summary>
        public int? AvailableMemoryInGBs { get; set; }

        /// <summary>
        /// Checks to see if the AvailableMemoryInGBs property is set.
        /// </summary>
        internal bool IsSetAvailableMemoryInGBs() => this.AvailableMemoryInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property AvailableMemoryPerNodeInGBs. 
        /// <para>
        /// The maximum amount of memory, in gigabytes (GB), that's available per DB node for
        /// the shape.
        /// </para>
        /// </summary>
        public int? AvailableMemoryPerNodeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the AvailableMemoryPerNodeInGBs property is set.
        /// </summary>
        internal bool IsSetAvailableMemoryPerNodeInGBs() => this.AvailableMemoryPerNodeInGBs.HasValue;

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
        /// Gets and sets the property CoreCountIncrement. 
        /// <para>
        /// The discrete number by which the CPU core count for the shape can be increased or
        /// decreased.
        /// </para>
        /// </summary>
        public int? CoreCountIncrement { get; set; }

        /// <summary>
        /// Checks to see if the CoreCountIncrement property is set.
        /// </summary>
        internal bool IsSetCoreCountIncrement() => this.CoreCountIncrement.HasValue;

        /// <summary>
        /// Gets and sets the property MaxStorageCount. 
        /// <para>
        /// The maximum number of Exadata storage servers that's available for the shape.
        /// </para>
        /// </summary>
        public int? MaxStorageCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxStorageCount property is set.
        /// </summary>
        internal bool IsSetMaxStorageCount() => this.MaxStorageCount.HasValue;

        /// <summary>
        /// Gets and sets the property MaximumNodeCount. 
        /// <para>
        /// The maximum number of compute servers that is available for the shape.
        /// </para>
        /// </summary>
        public int? MaximumNodeCount { get; set; }

        /// <summary>
        /// Checks to see if the MaximumNodeCount property is set.
        /// </summary>
        internal bool IsSetMaximumNodeCount() => this.MaximumNodeCount.HasValue;

        /// <summary>
        /// Gets and sets the property MinCoreCountPerNode. 
        /// <para>
        /// The minimum number of CPU cores that can be enabled per node for the shape.
        /// </para>
        /// </summary>
        public int? MinCoreCountPerNode { get; set; }

        /// <summary>
        /// Checks to see if the MinCoreCountPerNode property is set.
        /// </summary>
        internal bool IsSetMinCoreCountPerNode() => this.MinCoreCountPerNode.HasValue;

        /// <summary>
        /// Gets and sets the property MinDataStorageInTBs. 
        /// <para>
        /// The minimum amount of data storage, in terabytes (TB), that must be allocated for
        /// the shape.
        /// </para>
        /// </summary>
        public int? MinDataStorageInTBs { get; set; }

        /// <summary>
        /// Checks to see if the MinDataStorageInTBs property is set.
        /// </summary>
        internal bool IsSetMinDataStorageInTBs() => this.MinDataStorageInTBs.HasValue;

        /// <summary>
        /// Gets and sets the property MinDbNodeStoragePerNodeInGBs. 
        /// <para>
        /// The minimum amount of DB node storage, in gigabytes (GB), that must be allocated per
        /// DB node for the shape.
        /// </para>
        /// </summary>
        public int? MinDbNodeStoragePerNodeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the MinDbNodeStoragePerNodeInGBs property is set.
        /// </summary>
        internal bool IsSetMinDbNodeStoragePerNodeInGBs() => this.MinDbNodeStoragePerNodeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property MinMemoryPerNodeInGBs. 
        /// <para>
        /// The minimum amount of memory, in gigabytes (GB), that must be allocated per DB node
        /// for the shape.
        /// </para>
        /// </summary>
        public int? MinMemoryPerNodeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the MinMemoryPerNodeInGBs property is set.
        /// </summary>
        internal bool IsSetMinMemoryPerNodeInGBs() => this.MinMemoryPerNodeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property MinStorageCount. 
        /// <para>
        /// The minimum number of Exadata storage servers that are available for the shape.
        /// </para>
        /// </summary>
        public int? MinStorageCount { get; set; }

        /// <summary>
        /// Checks to see if the MinStorageCount property is set.
        /// </summary>
        internal bool IsSetMinStorageCount() => this.MinStorageCount.HasValue;

        /// <summary>
        /// Gets and sets the property MinimumCoreCount. 
        /// <para>
        /// The minimum number of CPU cores that can be enabled for the shape.
        /// </para>
        /// </summary>
        public int? MinimumCoreCount { get; set; }

        /// <summary>
        /// Checks to see if the MinimumCoreCount property is set.
        /// </summary>
        internal bool IsSetMinimumCoreCount() => this.MinimumCoreCount.HasValue;

        /// <summary>
        /// Gets and sets the property MinimumNodeCount. 
        /// <para>
        /// The minimum number of compute servers that are available for the shape.
        /// </para>
        /// </summary>
        public int? MinimumNodeCount { get; set; }

        /// <summary>
        /// Checks to see if the MinimumNodeCount property is set.
        /// </summary>
        internal bool IsSetMinimumNodeCount() => this.MinimumNodeCount.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the shape.
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
        /// The runtime minimum number of CPU cores that can be enabled for the shape.
        /// </para>
        /// </summary>
        public int? RuntimeMinimumCoreCount { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeMinimumCoreCount property is set.
        /// </summary>
        internal bool IsSetRuntimeMinimumCoreCount() => this.RuntimeMinimumCoreCount.HasValue;

        /// <summary>
        /// Gets and sets the property ShapeAttributes. 
        /// <para>
        /// If provided and applicable, return DB System shape parameters based on the shape attribute
        /// provided.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ShapeAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ShapeAttributes property is set.
        /// </summary>
        internal bool IsSetShapeAttributes() => this.ShapeAttributes != null && (this.ShapeAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ShapeFamily. 
        /// <para>
        /// The family of the shape.
        /// </para>
        /// </summary>
        public string ShapeFamily { get; set; }

        /// <summary>
        /// Checks to see if the ShapeFamily property is set.
        /// </summary>
        internal bool IsSetShapeFamily() => this.ShapeFamily != null;

        /// <summary>
        /// Gets and sets the property ShapeType. 
        /// <para>
        /// The shape type. This property is determined by the CPU hardware.
        /// </para>
        /// </summary>
        public ShapeType ShapeType { get; set; }

        /// <summary>
        /// Checks to see if the ShapeType property is set.
        /// </summary>
        internal bool IsSetShapeType() => this.ShapeType != null;
    }
}
