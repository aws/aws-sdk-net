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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>Configuration information for a field in the index, including its name, type, and options. The supported options depend on the <c>
    /// IndexFieldType </c> .</para>
    /// </summary>
    public partial class IndexField
    {
        
        private string indexFieldName;
        private IndexFieldType indexFieldType;
        private IntOptions intOptions;
        private DoubleOptions doubleOptions;
        private LiteralOptions literalOptions;
        private TextOptions textOptions;
        private DateOptions dateOptions;
        private LatLonOptions latLonOptions;
        private IntArrayOptions intArrayOptions;
        private DoubleArrayOptions doubleArrayOptions;
        private LiteralArrayOptions literalArrayOptions;
        private TextArrayOptions textArrayOptions;
        private DateArrayOptions dateArrayOptions;


        /// <summary>
        /// The name of a field in the search index. Field names must begin with a letter and can contain the following characters: a-z (lowercase),
        /// 0-9, and _ (underscore). Uppercase letters and hyphens are not allowed. The name "score" is reserved and cannot be specified as field or
        /// expression name.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 64</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-z][a-z0-9_]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string IndexFieldName
        {
            get { return this.indexFieldName; }
            set { this.indexFieldName = value; }
        }

        // Check to see if IndexFieldName property is set
        internal bool IsSetIndexFieldName()
        {
            return this.indexFieldName != null;
        }

        /// <summary>
        /// The type of field. The valid options for a field depend on the field type. For more information about the supported field types, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-index-fields.html" target="_blank">Configuring Index
        /// Fields</a> in the <i>Amazon CloudSearch Developer Guide</i>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>int, double, literal, text, date, latlon, int-array, double-array, literal-array, text-array, date-array</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public IndexFieldType IndexFieldType
        {
            get { return this.indexFieldType; }
            set { this.indexFieldType = value; }
        }

        // Check to see if IndexFieldType property is set
        internal bool IsSetIndexFieldType()
        {
            return this.indexFieldType != null;
        }

        /// <summary>
        /// Options for a 64-bit signed integer field. Present if <c>IndexFieldType</c> specifies the field is of type <c>int</c>. All options are
        /// enabled by default.
        ///  
        /// </summary>
        public IntOptions IntOptions
        {
            get { return this.intOptions; }
            set { this.intOptions = value; }
        }

        // Check to see if IntOptions property is set
        internal bool IsSetIntOptions()
        {
            return this.intOptions != null;
        }

        /// <summary>
        /// Options for a double-precision 64-bit floating point field. Present if <c>IndexFieldType</c> specifies the field is of type <c>double</c>.
        /// All options are enabled by default.
        ///  
        /// </summary>
        public DoubleOptions DoubleOptions
        {
            get { return this.doubleOptions; }
            set { this.doubleOptions = value; }
        }

        // Check to see if DoubleOptions property is set
        internal bool IsSetDoubleOptions()
        {
            return this.doubleOptions != null;
        }

        /// <summary>
        /// Options for literal field. Present if <c>IndexFieldType</c> specifies the field is of type <c>literal</c>. All options are enabled by
        /// default.
        ///  
        /// </summary>
        public LiteralOptions LiteralOptions
        {
            get { return this.literalOptions; }
            set { this.literalOptions = value; }
        }

        // Check to see if LiteralOptions property is set
        internal bool IsSetLiteralOptions()
        {
            return this.literalOptions != null;
        }

        /// <summary>
        /// Options for text field. Present if <c>IndexFieldType</c> specifies the field is of type <c>text</c>. A <c>text</c> field is always
        /// searchable. All options are enabled by default.
        ///  
        /// </summary>
        public TextOptions TextOptions
        {
            get { return this.textOptions; }
            set { this.textOptions = value; }
        }

        // Check to see if TextOptions property is set
        internal bool IsSetTextOptions()
        {
            return this.textOptions != null;
        }

        /// <summary>
        /// Options for a date field. Dates and times are specified in UTC (Coordinated Universal Time) according to IETF RFC3339: yyyy-mm-ddT00:00:00Z.
        /// Present if <c>IndexFieldType</c> specifies the field is of type <c>date</c>. All options are enabled by default.
        ///  
        /// </summary>
        public DateOptions DateOptions
        {
            get { return this.dateOptions; }
            set { this.dateOptions = value; }
        }

        // Check to see if DateOptions property is set
        internal bool IsSetDateOptions()
        {
            return this.dateOptions != null;
        }

        /// <summary>
        /// Options for a latlon field. A latlon field contains a location stored as a latitude and longitude value pair. Present if
        /// <c>IndexFieldType</c> specifies the field is of type <c>latlon</c>. All options are enabled by default.
        ///  
        /// </summary>
        public LatLonOptions LatLonOptions
        {
            get { return this.latLonOptions; }
            set { this.latLonOptions = value; }
        }

        // Check to see if LatLonOptions property is set
        internal bool IsSetLatLonOptions()
        {
            return this.latLonOptions != null;
        }

        /// <summary>
        /// Options for a field that contains an array of 64-bit signed integers. Present if <c>IndexFieldType</c> specifies the field is of type
        /// <c>int-array</c>. All options are enabled by default.
        ///  
        /// </summary>
        public IntArrayOptions IntArrayOptions
        {
            get { return this.intArrayOptions; }
            set { this.intArrayOptions = value; }
        }

        // Check to see if IntArrayOptions property is set
        internal bool IsSetIntArrayOptions()
        {
            return this.intArrayOptions != null;
        }

        /// <summary>
        /// Options for a field that contains an array of double-precision 64-bit floating point values. Present if <c>IndexFieldType</c> specifies the
        /// field is of type <c>double-array</c>. All options are enabled by default.
        ///  
        /// </summary>
        public DoubleArrayOptions DoubleArrayOptions
        {
            get { return this.doubleArrayOptions; }
            set { this.doubleArrayOptions = value; }
        }

        // Check to see if DoubleArrayOptions property is set
        internal bool IsSetDoubleArrayOptions()
        {
            return this.doubleArrayOptions != null;
        }

        /// <summary>
        /// Options for a field that contains an array of literal strings. Present if <c>IndexFieldType</c> specifies the field is of type
        /// <c>literal-array</c>. All options are enabled by default.
        ///  
        /// </summary>
        public LiteralArrayOptions LiteralArrayOptions
        {
            get { return this.literalArrayOptions; }
            set { this.literalArrayOptions = value; }
        }

        // Check to see if LiteralArrayOptions property is set
        internal bool IsSetLiteralArrayOptions()
        {
            return this.literalArrayOptions != null;
        }

        /// <summary>
        /// Options for a field that contains an array of text strings. Present if <c>IndexFieldType</c> specifies the field is of type
        /// <c>text-array</c>. A <c>text-array</c> field is always searchable. All options are enabled by default.
        ///  
        /// </summary>
        public TextArrayOptions TextArrayOptions
        {
            get { return this.textArrayOptions; }
            set { this.textArrayOptions = value; }
        }

        // Check to see if TextArrayOptions property is set
        internal bool IsSetTextArrayOptions()
        {
            return this.textArrayOptions != null;
        }

        /// <summary>
        /// Options for a field that contains an array of dates. Present if <c>IndexFieldType</c> specifies the field is of type <c>date-array</c>. All
        /// options are enabled by default.
        ///  
        /// </summary>
        public DateArrayOptions DateArrayOptions
        {
            get { return this.dateArrayOptions; }
            set { this.dateArrayOptions = value; }
        }

        // Check to see if DateArrayOptions property is set
        internal bool IsSetDateArrayOptions()
        {
            return this.dateArrayOptions != null;
        }
    }
}
