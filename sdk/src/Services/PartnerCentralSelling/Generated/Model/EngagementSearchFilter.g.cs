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
    /// A recursive filter node. Exactly one member must be set. The boolean combinators nest
    /// sub-filters: <c>AndAllFilters</c> joins its children with AND, <c>OrAllFilters</c>
    /// matches when at least one child matches, and <c>NotFilter</c> negates its single child.
    /// The remaining members are leaf conditions over a single field. Nesting is limited
    /// to a depth of 3, and each combinator list can contain up to 10 entries.
    /// </summary>
    public partial class EngagementSearchFilter
    {
        /// <summary>
        /// Gets and sets the property AndAllFilters. 
        /// <para>
        /// A list of sub-filters that are joined with a logical AND. The node matches only when
        /// every sub-filter matches.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<EngagementSearchFilter> AndAllFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<EngagementSearchFilter>() : null;

        /// <summary>
        /// Checks to see if the AndAllFilters property is set.
        /// </summary>
        internal bool IsSetAndAllFilters() => this.AndAllFilters != null && (this.AndAllFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ContainsAll. 
        /// <para>
        /// A leaf condition that matches when the field holds every supplied value exactly. Specify
        /// a single <c>StringValue</c> or a <c>StringListValue</c>. For a field that holds one
        /// value for each lead interaction, each supplied value must be present on at least one
        /// interaction. For a single-valued field, a list of more than one value returns no results.
        /// Supported on string fields only.
        /// </para>
        /// </summary>
        public EngagementSearchPredicate ContainsAll { get; set; }

        /// <summary>
        /// Checks to see if the ContainsAll property is set.
        /// </summary>
        internal bool IsSetContainsAll() => this.ContainsAll != null;

        /// <summary>
        /// Gets and sets the property ContainsAny. 
        /// <para>
        /// A leaf condition that matches when the field contains any of the supplied values as
        /// a case-insensitive substring. Specify a single <c>StringValue</c> or a <c>StringListValue</c>.
        /// For a field that holds one value for each lead interaction, the condition matches
        /// when any of those values contains a supplied value. Supported on string fields only.
        /// </para>
        /// </summary>
        public EngagementSearchPredicate ContainsAny { get; set; }

        /// <summary>
        /// Checks to see if the ContainsAny property is set.
        /// </summary>
        internal bool IsSetContainsAny() => this.ContainsAny != null;

        /// <summary>
        /// Gets and sets the property EqualsTo. 
        /// <para>
        /// A leaf condition that matches when the field equals the supplied <c>StringValue</c>.
        /// </para>
        /// </summary>
        public EngagementSearchPredicate EqualsTo { get; set; }

        /// <summary>
        /// Checks to see if the EqualsTo property is set.
        /// </summary>
        internal bool IsSetEqualsTo() => this.EqualsTo != null;

        /// <summary>
        /// Gets and sets the property GreaterThan. 
        /// <para>
        /// A leaf condition that matches when the field is greater than the supplied value. This
        /// condition is supported only on ordered fields, such as date and numeric fields.
        /// </para>
        /// </summary>
        public EngagementSearchPredicate GreaterThan { get; set; }

        /// <summary>
        /// Checks to see if the GreaterThan property is set.
        /// </summary>
        internal bool IsSetGreaterThan() => this.GreaterThan != null;

        /// <summary>
        /// Gets and sets the property GreaterThanOrEquals. 
        /// <para>
        /// A leaf condition that matches when the field is greater than or equal to the supplied
        /// value. This condition is supported only on ordered fields, such as date and numeric
        /// fields.
        /// </para>
        /// </summary>
        public EngagementSearchPredicate GreaterThanOrEquals { get; set; }

        /// <summary>
        /// Checks to see if the GreaterThanOrEquals property is set.
        /// </summary>
        internal bool IsSetGreaterThanOrEquals() => this.GreaterThanOrEquals != null;

        /// <summary>
        /// Gets and sets the property LessThan. 
        /// <para>
        /// A leaf condition that matches when the field is less than the supplied value. This
        /// condition is supported only on ordered fields, such as date and numeric fields.
        /// </para>
        /// </summary>
        public EngagementSearchPredicate LessThan { get; set; }

        /// <summary>
        /// Checks to see if the LessThan property is set.
        /// </summary>
        internal bool IsSetLessThan() => this.LessThan != null;

        /// <summary>
        /// Gets and sets the property LessThanOrEquals. 
        /// <para>
        /// A leaf condition that matches when the field is less than or equal to the supplied
        /// value. This condition is supported only on ordered fields, such as date and numeric
        /// fields.
        /// </para>
        /// </summary>
        public EngagementSearchPredicate LessThanOrEquals { get; set; }

        /// <summary>
        /// Checks to see if the LessThanOrEquals property is set.
        /// </summary>
        internal bool IsSetLessThanOrEquals() => this.LessThanOrEquals != null;

        /// <summary>
        /// Gets and sets the property NotFilter. 
        /// <para>
        /// A single sub-filter that is negated. The node matches when the sub-filter does not
        /// match.
        /// </para>
        /// </summary>
        public EngagementSearchFilter NotFilter { get; set; }

        /// <summary>
        /// Checks to see if the NotFilter property is set.
        /// </summary>
        internal bool IsSetNotFilter() => this.NotFilter != null;

        /// <summary>
        /// Gets and sets the property OrAllFilters. 
        /// <para>
        /// A list of sub-filters that are joined with a logical OR. The node matches when at
        /// least one sub-filter matches.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<EngagementSearchFilter> OrAllFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<EngagementSearchFilter>() : null;

        /// <summary>
        /// Checks to see if the OrAllFilters property is set.
        /// </summary>
        internal bool IsSetOrAllFilters() => this.OrAllFilters != null && (this.OrAllFilters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
