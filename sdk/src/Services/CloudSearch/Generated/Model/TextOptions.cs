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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// Options for text field. Present if <c>IndexFieldType</c> specifies the field is of
    /// type <c>text</c>. A <c>text</c> field is always searchable. All options are enabled
    /// by default.
    /// </summary>
    public partial class TextOptions
    {
        private string _analysisScheme;
        private string _defaultValue;
        private bool? _highlightEnabled;
        private bool? _returnEnabled;
        private bool? _sortEnabled;
        private string _sourceField;

        /// <summary>
        /// Gets and sets the property AnalysisScheme. 
        /// <para>
        /// The name of an analysis scheme for a <c>text</c> field.
        /// </para>
        /// </summary>
        public string AnalysisScheme
        {
            get { return this._analysisScheme; }
            set { this._analysisScheme = value; }
        }

        // Check to see if AnalysisScheme property is set
        internal bool IsSetAnalysisScheme()
        {
            return this._analysisScheme != null;
        }

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
        /// Gets and sets the property HighlightEnabled. 
        /// <para>
        /// Whether highlights can be returned for the field.
        /// </para>
        /// </summary>
        public bool? HighlightEnabled
        {
            get { return this._highlightEnabled; }
            set { this._highlightEnabled = value; }
        }

        // Check to see if HighlightEnabled property is set
        internal bool IsSetHighlightEnabled()
        {
            return this._highlightEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReturnEnabled. 
        /// <para>
        /// Whether the contents of the field can be returned in the search results.
        /// </para>
        /// </summary>
        public bool? ReturnEnabled
        {
            get { return this._returnEnabled; }
            set { this._returnEnabled = value; }
        }

        // Check to see if ReturnEnabled property is set
        internal bool IsSetReturnEnabled()
        {
            return this._returnEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SortEnabled. 
        /// <para>
        /// Whether the field can be used to sort the search results.
        /// </para>
        /// </summary>
        public bool? SortEnabled
        {
            get { return this._sortEnabled; }
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