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
    /// A filter that matches category segments based on the tags assigned to the rules that
    /// create the categories. Provide exactly one of <c>OrConditions</c>, <c>AndCondition</c>,
    /// or <c>TagCondition</c>.
    /// </summary>
    public partial class CategoriesAttributeFilter
    {
        /// <summary>
        /// Gets and sets the property AndCondition. 
        /// <para>
        /// A condition that the filter evaluates using AND logic. A category segment matches
        /// only when all of the tag conditions in the condition are met.
        /// </para>
        /// </summary>
        public CategoriesAttributeAndCondition AndCondition { get; set; }

        /// <summary>
        /// Checks to see if the AndCondition property is set.
        /// </summary>
        internal bool IsSetAndCondition() => this.AndCondition != null;

        /// <summary>
        /// Gets and sets the property OrConditions. 
        /// <para>
        /// A list of conditions that the filter evaluates using OR logic. A category segment
        /// matches when at least one of the conditions in the list is met.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CategoriesAttributeAndCondition> OrConditions { get; set; } = AWSConfigs.InitializeCollections ? new List<CategoriesAttributeAndCondition>() : null;

        /// <summary>
        /// Checks to see if the OrConditions property is set.
        /// </summary>
        internal bool IsSetOrConditions() => this.OrConditions != null && (this.OrConditions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TagCondition. 
        /// <para>
        /// A single tag condition that a category segment must match. The category's rule must
        /// have the specified tag key and value.
        /// </para>
        /// </summary>
        public TagCondition TagCondition { get; set; }

        /// <summary>
        /// Checks to see if the TagCondition property is set.
        /// </summary>
        internal bool IsSetTagCondition() => this.TagCondition != null;
    }
}
