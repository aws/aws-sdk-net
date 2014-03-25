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
        private string indexFieldType;
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

        /// <summary>
        /// Sets the IndexFieldName property
        /// </summary>
        /// <param name="indexFieldName">The value to set for the IndexFieldName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public IndexField WithIndexFieldName(string indexFieldName)
        {
            this.indexFieldName = indexFieldName;
            return this;
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
        public string IndexFieldType
        {
            get { return this.indexFieldType; }
            set { this.indexFieldType = value; }
        }

        /// <summary>
        /// Sets the IndexFieldType property
        /// </summary>
        /// <param name="indexFieldType">The value to set for the IndexFieldType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public IndexField WithIndexFieldType(string indexFieldType)
        {
            this.indexFieldType = indexFieldType;
            return this;
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

        /// <summary>
        /// Sets the IntOptions property
        /// </summary>
        /// <param name="intOptions">The value to set for the IntOptions property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public IndexField WithIntOptions(IntOptions intOptions)
        {
            this.intOptions = intOptions;
            return this;
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

        /// <summary>
        /// Sets the DoubleOptions property
        /// </summary>
        /// <param name="doubleOptions">The value to set for the DoubleOptions property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public IndexField WithDoubleOptions(DoubleOptions doubleOptions)
        {
            this.doubleOptions = doubleOptions;
            return this;
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

        /// <summary>
        /// Sets the LiteralOptions property
        /// </summary>
        /// <param name="literalOptions">The value to set for the LiteralOptions property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public IndexField WithLiteralOptions(LiteralOptions literalOptions)
        {
            this.literalOptions = literalOptions;
            return this;
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

        /// <summary>
        /// Sets the TextOptions property
        /// </summary>
        /// <param name="textOptions">The value to set for the TextOptions property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public IndexField WithTextOptions(TextOptions textOptions)
        {
            this.textOptions = textOptions;
            return this;
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

        /// <summary>
        /// Sets the DateOptions property
        /// </summary>
        /// <param name="dateOptions">The value to set for the DateOptions property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public IndexField WithDateOptions(DateOptions dateOptions)
        {
            this.dateOptions = dateOptions;
            return this;
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

        /// <summary>
        /// Sets the LatLonOptions property
        /// </summary>
        /// <param name="latLonOptions">The value to set for the LatLonOptions property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public IndexField WithLatLonOptions(LatLonOptions latLonOptions)
        {
            this.latLonOptions = latLonOptions;
            return this;
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

        /// <summary>
        /// Sets the IntArrayOptions property
        /// </summary>
        /// <param name="intArrayOptions">The value to set for the IntArrayOptions property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public IndexField WithIntArrayOptions(IntArrayOptions intArrayOptions)
        {
            this.intArrayOptions = intArrayOptions;
            return this;
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

        /// <summary>
        /// Sets the DoubleArrayOptions property
        /// </summary>
        /// <param name="doubleArrayOptions">The value to set for the DoubleArrayOptions property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public IndexField WithDoubleArrayOptions(DoubleArrayOptions doubleArrayOptions)
        {
            this.doubleArrayOptions = doubleArrayOptions;
            return this;
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

        /// <summary>
        /// Sets the LiteralArrayOptions property
        /// </summary>
        /// <param name="literalArrayOptions">The value to set for the LiteralArrayOptions property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public IndexField WithLiteralArrayOptions(LiteralArrayOptions literalArrayOptions)
        {
            this.literalArrayOptions = literalArrayOptions;
            return this;
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

        /// <summary>
        /// Sets the TextArrayOptions property
        /// </summary>
        /// <param name="textArrayOptions">The value to set for the TextArrayOptions property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public IndexField WithTextArrayOptions(TextArrayOptions textArrayOptions)
        {
            this.textArrayOptions = textArrayOptions;
            return this;
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

        /// <summary>
        /// Sets the DateArrayOptions property
        /// </summary>
        /// <param name="dateArrayOptions">The value to set for the DateArrayOptions property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public IndexField WithDateArrayOptions(DateArrayOptions dateArrayOptions)
        {
            this.dateArrayOptions = dateArrayOptions;
            return this;
        }
            

        // Check to see if DateArrayOptions property is set
        internal bool IsSetDateArrayOptions()
        {
            return this.dateArrayOptions != null;
        }
    }
}
