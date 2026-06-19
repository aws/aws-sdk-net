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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
        private List<SearchFilterClause> _andAllFilters = AWSConfigs.InitializeCollections ? new List<SearchFilterClause>() : null;
        private SearchAttributeFilter _attributeFilter;
        private SearchMapFilter _mapFilter;
        private List<SearchFilterClause> _orAnyFilters = AWSConfigs.InitializeCollections ? new List<SearchFilterClause>() : null;

        /// <summary>
        /// Gets and sets the property AndAllFilters. 
        /// <para>
        /// A list of filter clauses that must all match (logical AND).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<SearchFilterClause> AndAllFilters
        {
            get { return this._andAllFilters; }
            set { this._andAllFilters = value; }
        }

        // Check to see if AndAllFilters property is set
        internal bool IsSetAndAllFilters()
        {
            return this._andAllFilters != null && (this._andAllFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AttributeFilter. 
        /// <para>
        /// A filter on a single attribute value.
        /// </para>
        /// </summary>
        public SearchAttributeFilter AttributeFilter
        {
            get { return this._attributeFilter; }
            set { this._attributeFilter = value; }
        }

        // Check to see if AttributeFilter property is set
        internal bool IsSetAttributeFilter()
        {
            return this._attributeFilter != null;
        }

        /// <summary>
        /// Gets and sets the property MapFilter. 
        /// <para>
        /// A filter on a map attribute's key-value pair.
        /// </para>
        /// </summary>
        public SearchMapFilter MapFilter
        {
            get { return this._mapFilter; }
            set { this._mapFilter = value; }
        }

        // Check to see if MapFilter property is set
        internal bool IsSetMapFilter()
        {
            return this._mapFilter != null;
        }

        /// <summary>
        /// Gets and sets the property OrAnyFilters. 
        /// <para>
        /// A list of filter clauses where at least one must match (logical OR).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<SearchFilterClause> OrAnyFilters
        {
            get { return this._orAnyFilters; }
            set { this._orAnyFilters = value; }
        }

        // Check to see if OrAnyFilters property is set
        internal bool IsSetOrAnyFilters()
        {
            return this._orAnyFilters != null && (this._orAnyFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}