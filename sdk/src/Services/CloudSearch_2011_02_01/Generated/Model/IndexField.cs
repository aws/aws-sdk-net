/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudsearch-2011-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudSearch_2011_02_01.Model
{
    /// <summary>
    /// Defines a field in the index, including its name, type, and the source of its data.
    /// The <code>IndexFieldType</code> indicates which of the options will be present. It
    /// is invalid to specify options for a type other than the <code>IndexFieldType</code>.
    /// </summary>
    public partial class IndexField
    {
        private string _indexFieldName;
        private IndexFieldType _indexFieldType;
        private LiteralOptions _literalOptions;
        private List<SourceAttribute> _sourceAttributes = new List<SourceAttribute>();
        private TextOptions _textOptions;
        private UIntOptions _uIntOptions;

        /// <summary>
        /// Gets and sets the property IndexFieldName. 
        /// <para>
        /// The name of a field in the search index. Field names must begin with a letter and
        /// can contain the following characters: a-z (lowercase), 0-9, and _ (underscore). Uppercase
        /// letters and hyphens are not allowed. The names "body", "docid", and "text_relevance"
        /// are reserved and cannot be specified as field or rank expression names.
        /// </para>
        /// </summary>
        public string IndexFieldName
        {
            get { return this._indexFieldName; }
            set { this._indexFieldName = value; }
        }

        // Check to see if IndexFieldName property is set
        internal bool IsSetIndexFieldName()
        {
            return this._indexFieldName != null;
        }

        /// <summary>
        /// Gets and sets the property IndexFieldType. 
        /// <para>
        /// The type of field. Based on this type, exactly one of the <a>UIntOptions</a>, <a>LiteralOptions</a>
        /// or <a>TextOptions</a> must be present.
        /// </para>
        /// </summary>
        public IndexFieldType IndexFieldType
        {
            get { return this._indexFieldType; }
            set { this._indexFieldType = value; }
        }

        // Check to see if IndexFieldType property is set
        internal bool IsSetIndexFieldType()
        {
            return this._indexFieldType != null;
        }

        /// <summary>
        /// Gets and sets the property LiteralOptions. 
        /// <para>
        /// Options for literal field. Present if <code>IndexFieldType</code> specifies the field
        /// is of type literal.
        /// </para>
        /// </summary>
        public LiteralOptions LiteralOptions
        {
            get { return this._literalOptions; }
            set { this._literalOptions = value; }
        }

        // Check to see if LiteralOptions property is set
        internal bool IsSetLiteralOptions()
        {
            return this._literalOptions != null;
        }

        /// <summary>
        /// Gets and sets the property SourceAttributes. 
        /// <para>
        /// An optional list of source attributes that provide data for this index field. If not
        /// specified, the data is pulled from a source attribute with the same name as this <code>IndexField</code>.
        /// When one or more source attributes are specified, an optional data transformation
        /// can be applied to the source data when populating the index field. You can configure
        /// a maximum of 20 sources for an <code>IndexField</code>.
        /// </para>
        /// </summary>
        public List<SourceAttribute> SourceAttributes
        {
            get { return this._sourceAttributes; }
            set { this._sourceAttributes = value; }
        }

        // Check to see if SourceAttributes property is set
        internal bool IsSetSourceAttributes()
        {
            return this._sourceAttributes != null && this._sourceAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TextOptions. 
        /// <para>
        /// Options for text field. Present if <code>IndexFieldType</code> specifies the field
        /// is of type text.
        /// </para>
        /// </summary>
        public TextOptions TextOptions
        {
            get { return this._textOptions; }
            set { this._textOptions = value; }
        }

        // Check to see if TextOptions property is set
        internal bool IsSetTextOptions()
        {
            return this._textOptions != null;
        }

        /// <summary>
        /// Gets and sets the property UIntOptions. 
        /// <para>
        /// Options for an unsigned integer field. Present if <code>IndexFieldType</code> specifies
        /// the field is of type unsigned integer.
        /// </para>
        /// </summary>
        public UIntOptions UIntOptions
        {
            get { return this._uIntOptions; }
            set { this._uIntOptions = value; }
        }

        // Check to see if UIntOptions property is set
        internal bool IsSetUIntOptions()
        {
            return this._uIntOptions != null;
        }

    }
}