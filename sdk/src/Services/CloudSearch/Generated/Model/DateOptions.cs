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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// Options for a date field. Dates and times are specified in UTC (Coordinated Universal
    /// Time) according to IETF RFC3339: yyyy-mm-ddT00:00:00Z. Present if <code>IndexFieldType</code>
    /// specifies the field is of type <code>date</code>. All options are enabled by default.
    /// </summary>
    public partial class DateOptions
    {
        private string _defaultValue;
        private bool? _facetEnabled;
        private bool? _returnEnabled;
        private bool? _searchEnabled;
        private bool? _sortEnabled;
        private string _sourceField;

        /// <summary>
        /// Gets and sets the property DefaultValue. A value to use for the field if the field
        /// isn't specified for a document.
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string DefaultValue
        {
            get { return this._defaultValue; }
            set { this._defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this._defaultValue != null;
        }

        /// <summary>
        /// Gets and sets the property FacetEnabled. 
        /// <para>
        /// Whether facet information can be returned for the field.
        /// </para>
        /// </summary>
        public bool FacetEnabled
        {
            get { return this._facetEnabled.GetValueOrDefault(); }
            set { this._facetEnabled = value; }
        }

        // Check to see if FacetEnabled property is set
        internal bool IsSetFacetEnabled()
        {
            return this._facetEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReturnEnabled. 
        /// <para>
        /// Whether the contents of the field can be returned in the search results.
        /// </para>
        /// </summary>
        public bool ReturnEnabled
        {
            get { return this._returnEnabled.GetValueOrDefault(); }
            set { this._returnEnabled = value; }
        }

        // Check to see if ReturnEnabled property is set
        internal bool IsSetReturnEnabled()
        {
            return this._returnEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SearchEnabled. 
        /// <para>
        /// Whether the contents of the field are searchable.
        /// </para>
        /// </summary>
        public bool SearchEnabled
        {
            get { return this._searchEnabled.GetValueOrDefault(); }
            set { this._searchEnabled = value; }
        }

        // Check to see if SearchEnabled property is set
        internal bool IsSetSearchEnabled()
        {
            return this._searchEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SortEnabled. 
        /// <para>
        /// Whether the field can be used to sort the search results.
        /// </para>
        /// </summary>
        public bool SortEnabled
        {
            get { return this._sortEnabled.GetValueOrDefault(); }
            set { this._sortEnabled = value; }
        }

        // Check to see if SortEnabled property is set
        internal bool IsSetSortEnabled()
        {
            return this._sortEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceField.
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string SourceField
        {
            get { return this._sourceField; }
            set { this._sourceField = value; }
        }

        // Check to see if SourceField property is set
        internal bool IsSetSourceField()
        {
            return this._sourceField != null;
        }

    }
}