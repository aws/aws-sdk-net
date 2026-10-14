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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeCostCategoryDefinition operation. Returns
    /// the name, Amazon Resource Name (ARN), rules, definition, and effective dates of a
    /// cost category that's defined in the account. <para> You have the option to use <c>EffectiveOn</c>
    /// to return a cost category that's active on a specific date. If there's no <c>EffectiveOn</c>
    /// specified, you see a Cost Category that's effective on the current date. If cost category
    /// is still effective, <c>EffectiveEnd</c> is omitted in the response. </para>
    /// </summary>
    public partial class DescribeCostCategoryDefinitionRequest : AmazonCostExplorerRequest
    {
        /// <summary>
        /// Gets and sets the property CostCategoryArn. 
        /// <para>
        /// The unique identifier for your cost category. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string CostCategoryArn { get; set; }

        /// <summary>
        /// Checks to see if the CostCategoryArn property is set.
        /// </summary>
        internal bool IsSetCostCategoryArn() => this.CostCategoryArn != null;

        /// <summary>
        /// Gets and sets the property EffectiveOn. 
        /// <para>
        /// The date when the cost category was effective. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 25)]
        public string EffectiveOn { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveOn property is set.
        /// </summary>
        internal bool IsSetEffectiveOn() => this.EffectiveOn != null;
    }
}
