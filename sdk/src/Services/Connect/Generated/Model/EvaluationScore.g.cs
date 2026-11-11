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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about scores of a contact evaluation item (section or question).
    /// </summary>
    public partial class EvaluationScore
    {
        /// <summary>
        /// Gets and sets the property AppliedWeight. 
        /// <para>
        /// Weight applied to this evaluation score.
        /// </para>
        /// </summary>
        public double? AppliedWeight { get; set; }

        /// <summary>
        /// Checks to see if the AppliedWeight property is set.
        /// </summary>
        internal bool IsSetAppliedWeight() => this.AppliedWeight.HasValue;

        /// <summary>
        /// Gets and sets the property AutomaticFail. 
        /// <para>
        /// The flag that marks the item as automatic fail. If the item or a child item gets an
        /// automatic fail answer, this flag will be true.
        /// </para>
        /// </summary>
        public bool? AutomaticFail { get; set; }

        /// <summary>
        /// Checks to see if the AutomaticFail property is set.
        /// </summary>
        internal bool IsSetAutomaticFail() => this.AutomaticFail.HasValue;

        /// <summary>
        /// Gets and sets the property EarnedPoints. 
        /// <para>
        /// The points earned for the item.
        /// </para>
        /// </summary>
        public int? EarnedPoints { get; set; }

        /// <summary>
        /// Checks to see if the EarnedPoints property is set.
        /// </summary>
        internal bool IsSetEarnedPoints() => this.EarnedPoints.HasValue;

        /// <summary>
        /// Gets and sets the property MaxBasePoint. 
        /// <para>
        /// The maximum base points possible for the item.
        /// </para>
        /// </summary>
        public int? MaxBasePoint { get; set; }

        /// <summary>
        /// Checks to see if the MaxBasePoint property is set.
        /// </summary>
        internal bool IsSetMaxBasePoint() => this.MaxBasePoint.HasValue;

        /// <summary>
        /// Gets and sets the property NotApplicable. 
        /// <para>
        /// The flag to mark the item as not applicable for scoring.
        /// </para>
        /// </summary>
        public bool? NotApplicable { get; set; }

        /// <summary>
        /// Checks to see if the NotApplicable property is set.
        /// </summary>
        internal bool IsSetNotApplicable() => this.NotApplicable.HasValue;

        /// <summary>
        /// Gets and sets the property Percentage. 
        /// <para>
        /// The score percentage for an item in a contact evaluation.
        /// </para>
        /// </summary>
        public double? Percentage { get; set; }

        /// <summary>
        /// Checks to see if the Percentage property is set.
        /// </summary>
        internal bool IsSetPercentage() => this.Percentage.HasValue;

        /// <summary>
        /// Gets and sets the property PerformanceCategory. 
        /// <para>
        /// The performance category for the score.
        /// </para>
        /// </summary>
        public PerformanceCategoryName PerformanceCategory { get; set; }

        /// <summary>
        /// Checks to see if the PerformanceCategory property is set.
        /// </summary>
        internal bool IsSetPerformanceCategory() => this.PerformanceCategory != null;
    }
}
