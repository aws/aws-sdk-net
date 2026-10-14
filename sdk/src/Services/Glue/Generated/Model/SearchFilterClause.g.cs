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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// A filter clause that supports nested boolean logic. Exactly one of <c>andAllFilters</c>,
    /// <c>orAnyFilters</c>, <c>attributeFilter</c>, or <c>mapFilter</c> must be specified.
    /// </summary>
    public partial class SearchFilterClause
    {
        /// <summary>
        /// Gets and sets the property AndAllFilters. 
        /// <para>
        /// A list of filter clauses that must all match (logical AND).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<SearchFilterClause> AndAllFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<SearchFilterClause>() : null;

        /// <summary>
        /// Checks to see if the AndAllFilters property is set.
        /// </summary>
        internal bool IsSetAndAllFilters() => this.AndAllFilters != null && (this.AndAllFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AttributeFilter. 
        /// <para>
        /// A filter on a single attribute value.
        /// </para>
        /// </summary>
        public SearchAttributeFilter AttributeFilter { get; set; }

        /// <summary>
        /// Checks to see if the AttributeFilter property is set.
        /// </summary>
        internal bool IsSetAttributeFilter() => this.AttributeFilter != null;

        /// <summary>
        /// Gets and sets the property MapFilter. 
        /// <para>
        /// A filter on a map attribute's key-value pair.
        /// </para>
        /// </summary>
        public SearchMapFilter MapFilter { get; set; }

        /// <summary>
        /// Checks to see if the MapFilter property is set.
        /// </summary>
        internal bool IsSetMapFilter() => this.MapFilter != null;

        /// <summary>
        /// Gets and sets the property OrAnyFilters. 
        /// <para>
        /// A list of filter clauses where at least one must match (logical OR).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<SearchFilterClause> OrAnyFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<SearchFilterClause>() : null;

        /// <summary>
        /// Checks to see if the OrAnyFilters property is set.
        /// </summary>
        internal bool IsSetOrAnyFilters() => this.OrAnyFilters != null && (this.OrAnyFilters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
