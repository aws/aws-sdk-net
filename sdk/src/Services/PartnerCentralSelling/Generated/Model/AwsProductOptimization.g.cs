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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Specific optimization strategies partners can implement to reduce costs.
    /// </summary>
    public partial class AwsProductOptimization
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Human-readable explanation of the optimization strategy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property SavingsAmount. 
        /// <para>
        /// Quantified cost savings achievable by implementing this optimization.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string SavingsAmount { get; set; }

        /// <summary>
        /// Checks to see if the SavingsAmount property is set.
        /// </summary>
        internal bool IsSetSavingsAmount() => this.SavingsAmount != null;
    }
}
