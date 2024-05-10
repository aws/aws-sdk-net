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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Details for a reserved-node exchange. Examples include the node type for a reserved
    /// node, the price for a node, the node's state, and other details.
    /// </summary>
    public partial class ReservedNodeConfigurationOption
    {
        private ReservedNode _sourceReservedNode;
        private int? _targetReservedNodeCount;
        private ReservedNodeOffering _targetReservedNodeOffering;

        /// <summary>
        /// Gets and sets the property SourceReservedNode.
        /// </summary>
        public ReservedNode SourceReservedNode
        {
            get { return this._sourceReservedNode; }
            set { this._sourceReservedNode = value; }
        }

        // Check to see if SourceReservedNode property is set
        internal bool IsSetSourceReservedNode()
        {
            return this._sourceReservedNode != null;
        }

        /// <summary>
        /// Gets and sets the property TargetReservedNodeCount. 
        /// <para>
        /// The target reserved-node count.
        /// </para>
        /// </summary>
        public int? TargetReservedNodeCount
        {
            get { return this._targetReservedNodeCount; }
            set { this._targetReservedNodeCount = value; }
        }

        // Check to see if TargetReservedNodeCount property is set
        internal bool IsSetTargetReservedNodeCount()
        {
            return this._targetReservedNodeCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetReservedNodeOffering.
        /// </summary>
        public ReservedNodeOffering TargetReservedNodeOffering
        {
            get { return this._targetReservedNodeOffering; }
            set { this._targetReservedNodeOffering = value; }
        }

        // Check to see if TargetReservedNodeOffering property is set
        internal bool IsSetTargetReservedNodeOffering()
        {
            return this._targetReservedNodeOffering != null;
        }

    }
}