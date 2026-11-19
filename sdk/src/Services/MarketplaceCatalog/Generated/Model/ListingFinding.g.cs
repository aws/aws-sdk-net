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

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// One row of the checklist of criteria for a listing field. A row is either a criterion
    /// that the field already meets or advice for a criterion that it doesn't.
    /// </summary>
    public partial class ListingFinding
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// What you should do to meet the criterion.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// What the criterion asks for. The text is the same for every listing. The reasoning
        /// for a specific listing is in the rationale of the alternatives.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// How much the criterion blocks the listing. It is set on every row. For a row with
        /// a status of <c>PASS</c>, it is the weight of a criterion that is already met. Valid
        /// values are <c>BLOCKING</c> and <c>ADVISORY</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommendationSeverity Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The result for the criterion. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PASS</c> - The criterion is met and no action is needed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAIL</c> - The criterion isn't met or wasn't scored.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This value is different from the status of the content recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ListingFindingStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
