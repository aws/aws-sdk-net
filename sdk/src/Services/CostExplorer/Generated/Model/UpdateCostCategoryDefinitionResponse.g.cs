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
    /// This is the response object from the UpdateCostCategoryDefinition operation.
    /// </summary>
    public partial class UpdateCostCategoryDefinitionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CostCategoryArn. 
        /// <para>
        /// The unique identifier for your cost category. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string CostCategoryArn { get; set; }

        /// <summary>
        /// Checks to see if the CostCategoryArn property is set.
        /// </summary>
        internal bool IsSetCostCategoryArn() => this.CostCategoryArn != null;

        /// <summary>
        /// Gets and sets the property EffectiveStart. 
        /// <para>
        /// The cost category's effective start date. It can only be a billing start date (first
        /// day of the month).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 25)]
        public string EffectiveStart { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveStart property is set.
        /// </summary>
        internal bool IsSetEffectiveStart() => this.EffectiveStart != null;
    }
}
