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
    /// A filter node. Specify exactly one member. <c>AndAllFilters</c>, <c>OrAllFilters</c>,
    /// and <c>NotFilter</c> combine child filters. The other members compare a single field
    /// to a value. Each combinator list can contain up to 10 filters.
    /// </summary>
    public partial class Filter
    {
        /// <summary>
        /// Gets and sets the property AndAllFilters. 
        /// <para>
        /// A list of child filters joined with a logical AND. The node matches only when every
        /// child filter matches.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<Filter> AndAllFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the AndAllFilters property is set.
        /// </summary>
        internal bool IsSetAndAllFilters() => this.AndAllFilters != null && (this.AndAllFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ContainsAll. 
        /// <para>
        /// A condition that matches when the field contains every value in the supplied <c>StringListValue</c>.
        /// Supported on fields that hold more than one value.
        /// </para>
        /// </summary>
        public FilterCondition ContainsAll { get; set; }

        /// <summary>
        /// Checks to see if the ContainsAll property is set.
        /// </summary>
        internal bool IsSetContainsAll() => this.ContainsAll != null;

        /// <summary>
        /// Gets and sets the property ContainsAny. 
        /// <para>
        /// A condition that matches when the field matches any of the values in the supplied
        /// <c>StringListValue</c>.
        /// </para>
        /// </summary>
        public FilterCondition ContainsAny { get; set; }

        /// <summary>
        /// Checks to see if the ContainsAny property is set.
        /// </summary>
        internal bool IsSetContainsAny() => this.ContainsAny != null;

        /// <summary>
        /// Gets and sets the property EqualsTo. 
        /// <para>
        /// A condition that matches when the field equals the supplied <c>StringValue</c>.
        /// </para>
        /// </summary>
        public FilterCondition EqualsTo { get; set; }

        /// <summary>
        /// Checks to see if the EqualsTo property is set.
        /// </summary>
        internal bool IsSetEqualsTo() => this.EqualsTo != null;

        /// <summary>
        /// Gets and sets the property GreaterThan. 
        /// <para>
        /// A condition that matches when the date field is later than the supplied <c>DateValue</c>.
        /// </para>
        /// </summary>
        public FilterCondition GreaterThan { get; set; }

        /// <summary>
        /// Checks to see if the GreaterThan property is set.
        /// </summary>
        internal bool IsSetGreaterThan() => this.GreaterThan != null;

        /// <summary>
        /// Gets and sets the property GreaterThanOrEquals. 
        /// <para>
        /// A condition that matches when the date field is the same as or later than the supplied
        /// <c>DateValue</c>.
        /// </para>
        /// </summary>
        public FilterCondition GreaterThanOrEquals { get; set; }

        /// <summary>
        /// Checks to see if the GreaterThanOrEquals property is set.
        /// </summary>
        internal bool IsSetGreaterThanOrEquals() => this.GreaterThanOrEquals != null;

        /// <summary>
        /// Gets and sets the property LessThan. 
        /// <para>
        /// A condition that matches when the date field is earlier than the supplied <c>DateValue</c>.
        /// </para>
        /// </summary>
        public FilterCondition LessThan { get; set; }

        /// <summary>
        /// Checks to see if the LessThan property is set.
        /// </summary>
        internal bool IsSetLessThan() => this.LessThan != null;

        /// <summary>
        /// Gets and sets the property LessThanOrEquals. 
        /// <para>
        /// A condition that matches when the date field is the same as or earlier than the supplied
        /// <c>DateValue</c>.
        /// </para>
        /// </summary>
        public FilterCondition LessThanOrEquals { get; set; }

        /// <summary>
        /// Checks to see if the LessThanOrEquals property is set.
        /// </summary>
        internal bool IsSetLessThanOrEquals() => this.LessThanOrEquals != null;

        /// <summary>
        /// Gets and sets the property NotFilter. 
        /// <para>
        /// A single child filter that is negated. The node matches when the child filter doesn't
        /// match.
        /// </para>
        /// </summary>
        public Filter NotFilter { get; set; }

        /// <summary>
        /// Checks to see if the NotFilter property is set.
        /// </summary>
        internal bool IsSetNotFilter() => this.NotFilter != null;

        /// <summary>
        /// Gets and sets the property OrAllFilters. 
        /// <para>
        /// A list of child filters joined with a logical OR. The node matches when at least one
        /// child filter matches.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<Filter> OrAllFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the OrAllFilters property is set.
        /// </summary>
        internal bool IsSetOrAllFilters() => this.OrAllFilters != null && (this.OrAllFilters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
