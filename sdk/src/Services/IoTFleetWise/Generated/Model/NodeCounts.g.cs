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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Information about the number of nodes and node types in a vehicle network.
    /// </summary>
    public partial class NodeCounts
    {
        /// <summary>
        /// Gets and sets the property TotalActuators. 
        /// <para>
        /// The total number of nodes in a vehicle network that represent actuators.
        /// </para>
        /// </summary>
        public int? TotalActuators { get; set; }

        /// <summary>
        /// Checks to see if the TotalActuators property is set.
        /// </summary>
        internal bool IsSetTotalActuators() => this.TotalActuators.HasValue;

        /// <summary>
        /// Gets and sets the property TotalAttributes. 
        /// <para>
        /// The total number of nodes in a vehicle network that represent attributes.
        /// </para>
        /// </summary>
        public int? TotalAttributes { get; set; }

        /// <summary>
        /// Checks to see if the TotalAttributes property is set.
        /// </summary>
        internal bool IsSetTotalAttributes() => this.TotalAttributes.HasValue;

        /// <summary>
        /// Gets and sets the property TotalBranches. 
        /// <para>
        /// The total number of nodes in a vehicle network that represent branches.
        /// </para>
        /// </summary>
        public int? TotalBranches { get; set; }

        /// <summary>
        /// Checks to see if the TotalBranches property is set.
        /// </summary>
        internal bool IsSetTotalBranches() => this.TotalBranches.HasValue;

        /// <summary>
        /// Gets and sets the property TotalNodes. 
        /// <para>
        /// The total number of nodes in a vehicle network.
        /// </para>
        /// </summary>
        public int? TotalNodes { get; set; }

        /// <summary>
        /// Checks to see if the TotalNodes property is set.
        /// </summary>
        internal bool IsSetTotalNodes() => this.TotalNodes.HasValue;

        /// <summary>
        /// Gets and sets the property TotalProperties. 
        /// <para>
        /// The total properties for the node.
        /// </para>
        /// </summary>
        public int? TotalProperties { get; set; }

        /// <summary>
        /// Checks to see if the TotalProperties property is set.
        /// </summary>
        internal bool IsSetTotalProperties() => this.TotalProperties.HasValue;

        /// <summary>
        /// Gets and sets the property TotalSensors. 
        /// <para>
        /// The total number of nodes in a vehicle network that represent sensors.
        /// </para>
        /// </summary>
        public int? TotalSensors { get; set; }

        /// <summary>
        /// Checks to see if the TotalSensors property is set.
        /// </summary>
        internal bool IsSetTotalSensors() => this.TotalSensors.HasValue;

        /// <summary>
        /// Gets and sets the property TotalStructs. 
        /// <para>
        /// The total structure for the node.
        /// </para>
        /// </summary>
        public int? TotalStructs { get; set; }

        /// <summary>
        /// Checks to see if the TotalStructs property is set.
        /// </summary>
        internal bool IsSetTotalStructs() => this.TotalStructs.HasValue;
    }
}
