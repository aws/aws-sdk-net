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
    /// Configuration information for a field in the index, including its name, type, and
    /// options. The supported options depend on the <c><a>IndexFieldType</a></c>.
    /// </summary>
    public partial class IndexField
    {
        private DateArrayOptions _dateArrayOptions;
        private DateOptions _dateOptions;
        private DoubleArrayOptions _doubleArrayOptions;
        private DoubleOptions _doubleOptions;
        private string _indexFieldName;
        private IndexFieldType _indexFieldType;
        private IntArrayOptions _intArrayOptions;
        private IntOptions _intOptions;
        private LatLonOptions _latLonOptions;
        private LiteralArrayOptions _literalArrayOptions;
        private LiteralOptions _literalOptions;
        private TextArrayOptions _textArrayOptions;
        private TextOptions _textOptions;

        /// <summary>
        /// Gets and sets the property DateArrayOptions.
        /// </summary>
        public DateArrayOptions DateArrayOptions
        {
            get { return this._dateArrayOptions; }
            set { this._dateArrayOptions = value; }
        }

        // Check to see if DateArrayOptions property is set
        internal bool IsSetDateArrayOptions()
        {
            return this._dateArrayOptions != null;
        }

        /// <summary>
        /// Gets and sets the property DateOptions.
        /// </summary>
        public DateOptions DateOptions
        {
            get { return this._dateOptions; }
            set { this._dateOptions = value; }
        }

        // Check to see if DateOptions property is set
        internal bool IsSetDateOptions()
        {
            return this._dateOptions != null;
        }

        /// <summary>
        /// Gets and sets the property DoubleArrayOptions.
        /// </summary>
        public DoubleArrayOptions DoubleArrayOptions
        {
            get { return this._doubleArrayOptions; }
            set { this._doubleArrayOptions = value; }
        }

        // Check to see if DoubleArrayOptions property is set
        internal bool IsSetDoubleArrayOptions()
        {
            return this._doubleArrayOptions != null;
        }

        /// <summary>
        /// Gets and sets the property DoubleOptions.
        /// </summary>
        public DoubleOptions DoubleOptions
        {
            get { return this._doubleOptions; }
            set { this._doubleOptions = value; }
        }

        // Check to see if DoubleOptions property is set
        internal bool IsSetDoubleOptions()
        {
            return this._doubleOptions != null;
        }

        /// <summary>
        /// Gets and sets the property IndexFieldName. 
        /// <para>
        /// A string that represents the name of an index field. CloudSearch supports regular
        /// index fields as well as dynamic fields. A dynamic field's name defines a pattern that
        /// begins or ends with a wildcard. Any document fields that don't map to a regular index
        /// field but do match a dynamic field's pattern are configured with the dynamic field's
        /// indexing options. 
        /// </para>
        ///  
        /// <para>
        /// Regular field names begin with a letter and can contain the following characters:
        /// a-z (lowercase), 0-9, and _ (underscore). Dynamic field names must begin or end with
        /// a wildcard (*). The wildcard can also be the only character in a dynamic field name.
        /// Multiple wildcards, and wildcards embedded within a string are not supported. 
        /// </para>
        ///  
        /// <para>
        /// The name <c>score</c> is reserved and cannot be used as a field name. To reference
        /// a document's ID, you can use the name <c>_id</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property IntArrayOptions.
        /// </summary>
        public IntArrayOptions IntArrayOptions
        {
            get { return this._intArrayOptions; }
            set { this._intArrayOptions = value; }
        }

        // Check to see if IntArrayOptions property is set
        internal bool IsSetIntArrayOptions()
        {
            return this._intArrayOptions != null;
        }

        /// <summary>
        /// Gets and sets the property IntOptions.
        /// </summary>
        public IntOptions IntOptions
        {
            get { return this._intOptions; }
            set { this._intOptions = value; }
        }

        // Check to see if IntOptions property is set
        internal bool IsSetIntOptions()
        {
            return this._intOptions != null;
        }

        /// <summary>
        /// Gets and sets the property LatLonOptions.
        /// </summary>
        public LatLonOptions LatLonOptions
        {
            get { return this._latLonOptions; }
            set { this._latLonOptions = value; }
        }

        // Check to see if LatLonOptions property is set
        internal bool IsSetLatLonOptions()
        {
            return this._latLonOptions != null;
        }

        /// <summary>
        /// Gets and sets the property LiteralArrayOptions.
        /// </summary>
        public LiteralArrayOptions LiteralArrayOptions
        {
            get { return this._literalArrayOptions; }
            set { this._literalArrayOptions = value; }
        }

        // Check to see if LiteralArrayOptions property is set
        internal bool IsSetLiteralArrayOptions()
        {
            return this._literalArrayOptions != null;
        }

        /// <summary>
        /// Gets and sets the property LiteralOptions.
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
        /// Gets and sets the property TextArrayOptions.
        /// </summary>
        public TextArrayOptions TextArrayOptions
        {
            get { return this._textArrayOptions; }
            set { this._textArrayOptions = value; }
        }

        // Check to see if TextArrayOptions property is set
        internal bool IsSetTextArrayOptions()
        {
            return this._textArrayOptions != null;
        }

        /// <summary>
        /// Gets and sets the property TextOptions.
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

    }
}