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

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// An access budget that defines consumption limits for a specific resource within defined
    /// time periods.
    /// </summary>
    public partial class AccessBudget
    {
        /// <summary>
        /// Gets and sets the property AggregateRemainingBudget. 
        /// <para>
        /// The total remaining budget across all active budget periods for this resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? AggregateRemainingBudget { get; set; }

        /// <summary>
        /// Checks to see if the AggregateRemainingBudget property is set.
        /// </summary>
        internal bool IsSetAggregateRemainingBudget() => this.AggregateRemainingBudget.HasValue;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// A list of budget details for this resource. Contains active budget periods that apply
        /// to the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2)]
        public List<AccessBudgetDetails> Details { get; set; } = AWSConfigs.InitializeCollections ? new List<AccessBudgetDetails>() : null;

        /// <summary>
        /// Checks to see if the Details property is set.
        /// </summary>
        internal bool IsSetDetails() => this.Details != null && (this.Details.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource that this access budget applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 200)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;
    }
}
