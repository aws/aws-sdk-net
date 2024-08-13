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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
        private int? _totalActuators;
        private int? _totalAttributes;
        private int? _totalBranches;
        private int? _totalNodes;
        private int? _totalProperties;
        private int? _totalSensors;
        private int? _totalStructs;

        /// <summary>
        /// Gets and sets the property TotalActuators. 
        /// <para>
        /// The total number of nodes in a vehicle network that represent actuators.
        /// </para>
        /// </summary>
        public int? TotalActuators
        {
            get { return this._totalActuators; }
            set { this._totalActuators = value; }
        }

        // Check to see if TotalActuators property is set
        internal bool IsSetTotalActuators()
        {
            return this._totalActuators.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalAttributes. 
        /// <para>
        /// The total number of nodes in a vehicle network that represent attributes.
        /// </para>
        /// </summary>
        public int? TotalAttributes
        {
            get { return this._totalAttributes; }
            set { this._totalAttributes = value; }
        }

        // Check to see if TotalAttributes property is set
        internal bool IsSetTotalAttributes()
        {
            return this._totalAttributes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalBranches. 
        /// <para>
        /// The total number of nodes in a vehicle network that represent branches.
        /// </para>
        /// </summary>
        public int? TotalBranches
        {
            get { return this._totalBranches; }
            set { this._totalBranches = value; }
        }

        // Check to see if TotalBranches property is set
        internal bool IsSetTotalBranches()
        {
            return this._totalBranches.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalNodes. 
        /// <para>
        /// The total number of nodes in a vehicle network.
        /// </para>
        /// </summary>
        public int? TotalNodes
        {
            get { return this._totalNodes; }
            set { this._totalNodes = value; }
        }

        // Check to see if TotalNodes property is set
        internal bool IsSetTotalNodes()
        {
            return this._totalNodes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalProperties. 
        /// <para>
        /// The total properties for the node.
        /// </para>
        /// </summary>
        public int? TotalProperties
        {
            get { return this._totalProperties; }
            set { this._totalProperties = value; }
        }

        // Check to see if TotalProperties property is set
        internal bool IsSetTotalProperties()
        {
            return this._totalProperties.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalSensors. 
        /// <para>
        /// The total number of nodes in a vehicle network that represent sensors.
        /// </para>
        /// </summary>
        public int? TotalSensors
        {
            get { return this._totalSensors; }
            set { this._totalSensors = value; }
        }

        // Check to see if TotalSensors property is set
        internal bool IsSetTotalSensors()
        {
            return this._totalSensors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalStructs. 
        /// <para>
        /// The total structure for the node.
        /// </para>
        /// </summary>
        public int? TotalStructs
        {
            get { return this._totalStructs; }
            set { this._totalStructs = value; }
        }

        // Check to see if TotalStructs property is set
        internal bool IsSetTotalStructs()
        {
            return this._totalStructs.HasValue; 
        }

    }
}