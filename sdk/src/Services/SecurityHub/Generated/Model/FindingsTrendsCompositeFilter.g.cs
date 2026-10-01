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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A filter structure that contains a logical combination of string filters and nested
    /// composite filters for findings trend data.
    /// </summary>
    public partial class FindingsTrendsCompositeFilter
    {
        /// <summary>
        /// Gets and sets the property NestedCompositeFilters. 
        /// <para>
        /// A list of nested composite filters that you can use to create complex filter conditions
        /// for findings trend data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FindingsTrendsCompositeFilter> NestedCompositeFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<FindingsTrendsCompositeFilter>() : null;

        /// <summary>
        /// Checks to see if the NestedCompositeFilters property is set.
        /// </summary>
        internal bool IsSetNestedCompositeFilters() => this.NestedCompositeFilters != null && (this.NestedCompositeFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The logical operator (AND, OR) to apply between the string filters and nested composite
        /// filters.
        /// </para>
        /// </summary>
        public AllowedOperators Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property StringFilters. 
        /// <para>
        /// A list of string filters that apply to findings trend data fields.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FindingsTrendsStringFilter> StringFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<FindingsTrendsStringFilter>() : null;

        /// <summary>
        /// Checks to see if the StringFilters property is set.
        /// </summary>
        internal bool IsSetStringFilters() => this.StringFilters != null && (this.StringFilters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
