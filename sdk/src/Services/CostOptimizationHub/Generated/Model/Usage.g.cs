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
    /// Details about the usage.
    /// </summary>
    public partial class Usage
    {
        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The operation value.
        /// </para>
        /// </summary>
        public string Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;

        /// <summary>
        /// Gets and sets the property ProductCode. 
        /// <para>
        /// The product code.
        /// </para>
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// Checks to see if the ProductCode property is set.
        /// </summary>
        internal bool IsSetProductCode() => this.ProductCode != null;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The usage unit.
        /// </para>
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;

        /// <summary>
        /// Gets and sets the property UsageAmount. 
        /// <para>
        /// The usage amount.
        /// </para>
        /// </summary>
        public double? UsageAmount { get; set; }

        /// <summary>
        /// Checks to see if the UsageAmount property is set.
        /// </summary>
        internal bool IsSetUsageAmount() => this.UsageAmount.HasValue;

        /// <summary>
        /// Gets and sets the property UsageType. 
        /// <para>
        /// The usage type.
        /// </para>
        /// </summary>
        public string UsageType { get; set; }

        /// <summary>
        /// Checks to see if the UsageType property is set.
        /// </summary>
        internal bool IsSetUsageType() => this.UsageType != null;
    }
}
