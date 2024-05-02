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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides information about how a custom index field is used during a search.
    /// </summary>
    public partial class Search
    {
        private bool? _displayable;
        private bool? _facetable;
        private bool? _searchable;
        private bool? _sortable;

        /// <summary>
        /// Gets and sets the property Displayable. 
        /// <para>
        /// Determines whether the field is returned in the query response. The default is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? Displayable
        {
            get { return this._displayable; }
            set { this._displayable = value; }
        }

        // Check to see if Displayable property is set
        internal bool IsSetDisplayable()
        {
            return this._displayable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Facetable. 
        /// <para>
        /// Indicates that the field can be used to create search facets, a count of results for
        /// each value in the field. The default is <c>false</c> .
        /// </para>
        /// </summary>
        public bool? Facetable
        {
            get { return this._facetable; }
            set { this._facetable = value; }
        }

        // Check to see if Facetable property is set
        internal bool IsSetFacetable()
        {
            return this._facetable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Searchable. 
        /// <para>
        /// Determines whether the field is used in the search. If the <c>Searchable</c> field
        /// is <c>true</c>, you can use relevance tuning to manually tune how Amazon Kendra weights
        /// the field in the search. The default is <c>true</c> for string fields and <c>false</c>
        /// for number and date fields.
        /// </para>
        /// </summary>
        public bool? Searchable
        {
            get { return this._searchable; }
            set { this._searchable = value; }
        }

        // Check to see if Searchable property is set
        internal bool IsSetSearchable()
        {
            return this._searchable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Sortable. 
        /// <para>
        /// Determines whether the field can be used to sort the results of a query. If you specify
        /// sorting on a field that does not have <c>Sortable</c> set to <c>true</c>, Amazon Kendra
        /// returns an exception. The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? Sortable
        {
            get { return this._sortable; }
            set { this._sortable = value; }
        }

        // Check to see if Sortable property is set
        internal bool IsSetSortable()
        {
            return this._sortable.HasValue; 
        }

    }
}