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

namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// The MemoryDB reserved instances recommendation details.
    /// 
    ///  <note> 
    /// <para>
    /// While the API reference uses "MemoryDB reserved instances", the user guide and other
    /// documentation refer to them as "MemoryDB reserved nodes", as the terms are used interchangeably.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class MemoryDbReservedInstances
    {
        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The MemoryDB reserved instances configuration used for recommendations.
        /// </para>
        /// </summary>
        public MemoryDbReservedInstancesConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property CostCalculation.
        /// </summary>
        public ReservedInstancesCostCalculation CostCalculation { get; set; }

        /// <summary>
        /// Checks to see if the CostCalculation property is set.
        /// </summary>
        internal bool IsSetCostCalculation() => this.CostCalculation != null;
    }
}
