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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Provides a list of conditional branches. Branches are evaluated in the order that
    /// they are entered in the list. The first branch with a condition that evaluates to
    /// true is executed. The last branch in the list is the default branch. The default branch
    /// should not have any condition expression. The default branch is executed if no other
    /// branch has a matching condition.
    /// </summary>
    public partial class ConditionalSpecification
    {
        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// Determines whether a conditional branch is active. When <c>active</c> is false, the
        /// conditions are not evaluated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Active { get; set; }

        /// <summary>
        /// Checks to see if the Active property is set.
        /// </summary>
        internal bool IsSetActive() => this.Active.HasValue;

        /// <summary>
        /// Gets and sets the property ConditionalBranches. 
        /// <para>
        /// A list of conditional branches. A conditional branch is made up of a condition, a
        /// response and a next step. The response and next step are executed when the condition
        /// is true.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4)]
        public List<ConditionalBranch> ConditionalBranches { get; set; } = AWSConfigs.InitializeCollections ? new List<ConditionalBranch>() : null;

        /// <summary>
        /// Checks to see if the ConditionalBranches property is set.
        /// </summary>
        internal bool IsSetConditionalBranches() => this.ConditionalBranches != null && (this.ConditionalBranches.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DefaultBranch. 
        /// <para>
        /// The conditional branch that should be followed when the conditions for other branches
        /// are not satisfied. A conditional branch is made up of a condition, a response and
        /// a next step.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DefaultConditionalBranch DefaultBranch { get; set; }

        /// <summary>
        /// Checks to see if the DefaultBranch property is set.
        /// </summary>
        internal bool IsSetDefaultBranch() => this.DefaultBranch != null;
    }
}
