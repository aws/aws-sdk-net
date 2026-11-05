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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Details for a reserved-node exchange. Examples include the node type for a reserved
    /// node, the price for a node, the node's state, and other details.
    /// </summary>
    public partial class ReservedNodeConfigurationOption
    {
        /// <summary>
        /// Gets and sets the property SourceReservedNode.
        /// </summary>
        public ReservedNode SourceReservedNode { get; set; }

        /// <summary>
        /// Checks to see if the SourceReservedNode property is set.
        /// </summary>
        internal bool IsSetSourceReservedNode() => this.SourceReservedNode != null;

        /// <summary>
        /// Gets and sets the property TargetReservedNodeCount. 
        /// <para>
        /// The target reserved-node count.
        /// </para>
        /// </summary>
        public int? TargetReservedNodeCount { get; set; }

        /// <summary>
        /// Checks to see if the TargetReservedNodeCount property is set.
        /// </summary>
        internal bool IsSetTargetReservedNodeCount() => this.TargetReservedNodeCount.HasValue;

        /// <summary>
        /// Gets and sets the property TargetReservedNodeOffering.
        /// </summary>
        public ReservedNodeOffering TargetReservedNodeOffering { get; set; }

        /// <summary>
        /// Checks to see if the TargetReservedNodeOffering property is set.
        /// </summary>
        internal bool IsSetTargetReservedNodeOffering() => this.TargetReservedNodeOffering != null;
    }
}
