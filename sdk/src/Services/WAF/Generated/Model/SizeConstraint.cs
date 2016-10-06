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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAF.Model
{
    /// <summary>
    /// Specifies a constraint on the size of a part of the web request. AWS WAF uses the
    /// <code>Size</code>, <code>ComparisonOperator</code>, and <code>FieldToMatch</code>
    /// to build an expression in the form of "<code>Size</code> <code>ComparisonOperator</code>
    /// size in bytes of <code>FieldToMatch</code>". If that expression is true, the <code>SizeConstraint</code>
    /// is considered to match.
    /// </summary>
    public partial class SizeConstraint
    {
        private ComparisonOperator _comparisonOperator;
        private FieldToMatch _fieldToMatch;
        private long? _size;
        private TextTransformation _textTransformation;

        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// The type of comparison you want AWS WAF to perform. AWS WAF uses this in combination
        /// with the provided <code>Size</code> and <code>FieldToMatch</code> to build an expression
        /// in the form of "<code>Size</code> <code>ComparisonOperator</code> size in bytes of
        /// <code>FieldToMatch</code>". If that expression is true, the <code>SizeConstraint</code>
        /// is considered to match.
        /// </para>
        ///  
        /// <para>
        ///  <b>EQ</b>: Used to test if the <code>Size</code> is equal to the size of the <code>FieldToMatch</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>NE</b>: Used to test if the <code>Size</code> is not equal to the size of the
        /// <code>FieldToMatch</code> 
        /// </para>
        ///  
        /// <para>
        ///  <b>LE</b>: Used to test if the <code>Size</code> is less than or equal to the size
        /// of the <code>FieldToMatch</code> 
        /// </para>
        ///  
        /// <para>
        ///  <b>LT</b>: Used to test if the <code>Size</code> is strictly less than the size of
        /// the <code>FieldToMatch</code> 
        /// </para>
        ///  
        /// <para>
        ///  <b>GE</b>: Used to test if the <code>Size</code> is greater than or equal to the
        /// size of the <code>FieldToMatch</code> 
        /// </para>
        ///  
        /// <para>
        ///  <b>GT</b>: Used to test if the <code>Size</code> is strictly greater than the size
        /// of the <code>FieldToMatch</code> 
        /// </para>
        /// </summary>
        public ComparisonOperator ComparisonOperator
        {
            get { return this._comparisonOperator; }
            set { this._comparisonOperator = value; }
        }

        // Check to see if ComparisonOperator property is set
        internal bool IsSetComparisonOperator()
        {
            return this._comparisonOperator != null;
        }

        /// <summary>
        /// Gets and sets the property FieldToMatch.
        /// </summary>
        public FieldToMatch FieldToMatch
        {
            get { return this._fieldToMatch; }
            set { this._fieldToMatch = value; }
        }

        // Check to see if FieldToMatch property is set
        internal bool IsSetFieldToMatch()
        {
            return this._fieldToMatch != null;
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size in bytes that you want AWS WAF to compare against the size of the specified
        /// <code>FieldToMatch</code>. AWS WAF uses this in combination with <code>ComparisonOperator</code>
        /// and <code>FieldToMatch</code> to build an expression in the form of "<code>Size</code>
        /// <code>ComparisonOperator</code> size in bytes of <code>FieldToMatch</code>". If that
        /// expression is true, the <code>SizeConstraint</code> is considered to match.
        /// </para>
        ///  
        /// <para>
        /// Valid values for size are 0 - 21474836480 bytes (0 - 20 GB).
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>URI</code> for the value of <code>Type</code>, the / in the URI
        /// counts as one character. For example, the URI <code>/logo.jpg</code> is nine characters
        /// long.
        /// </para>
        /// </summary>
        public long Size
        {
            get { return this._size.GetValueOrDefault(); }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TextTransformation. 
        /// <para>
        /// Text transformations eliminate some of the unusual formatting that attackers use in
        /// web requests in an effort to bypass AWS WAF. If you specify a transformation, AWS
        /// WAF performs the transformation on <code>FieldToMatch</code> before inspecting a request
        /// for a match.
        /// </para>
        ///  
        /// <para>
        /// Note that if you choose <code>BODY</code> for the value of <code>Type</code>, you
        /// must choose <code>NONE</code> for <code>TextTransformation</code> because CloudFront
        /// forwards only the first 8192 bytes for inspection. 
        /// </para>
        ///  
        /// <para>
        ///  <b>NONE</b> 
        /// </para>
        ///  
        /// <para>
        /// Specify <code>NONE</code> if you don't want to perform any text transformations.
        /// </para>
        ///  
        /// <para>
        ///  <b>CMD_LINE</b> 
        /// </para>
        ///  
        /// <para>
        /// When you're concerned that attackers are injecting an operating system command line
        /// command and using unusual formatting to disguise some or all of the command, use this
        /// option to perform the following transformations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Delete the following characters: \ " ' ^
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete spaces before the following characters: / (
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Replace the following characters with a space: , ;
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Replace multiple spaces with one space
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Convert uppercase letters (A-Z) to lowercase (a-z)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>COMPRESS_WHITE_SPACE</b> 
        /// </para>
        ///  
        /// <para>
        /// Use this option to replace the following characters with a space character (decimal
        /// 32):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// \f, formfeed, decimal 12
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// \t, tab, decimal 9
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// \n, newline, decimal 10
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// \r, carriage return, decimal 13
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// \v, vertical tab, decimal 11
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// non-breaking space, decimal 160
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <code>COMPRESS_WHITE_SPACE</code> also replaces multiple spaces with one space.
        /// </para>
        ///  
        /// <para>
        ///  <b>HTML_ENTITY_DECODE</b> 
        /// </para>
        ///  
        /// <para>
        /// Use this option to replace HTML-encoded characters with unencoded characters. <code>HTML_ENTITY_DECODE</code>
        /// performs the following operations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Replaces <code>(ampersand)quot;</code> with <code>"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Replaces <code>(ampersand)nbsp;</code> with a non-breaking space, decimal 160
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Replaces <code>(ampersand)lt;</code> with a "less than" symbol
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Replaces <code>(ampersand)gt;</code> with <code>&gt;</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Replaces characters that are represented in hexadecimal format, <code>(ampersand)#xhhhh;</code>,
        /// with the corresponding characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Replaces characters that are represented in decimal format, <code>(ampersand)#nnnn;</code>,
        /// with the corresponding characters
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>LOWERCASE</b> 
        /// </para>
        ///  
        /// <para>
        /// Use this option to convert uppercase letters (A-Z) to lowercase (a-z).
        /// </para>
        ///  
        /// <para>
        ///  <b>URL_DECODE</b> 
        /// </para>
        ///  
        /// <para>
        /// Use this option to decode a URL-encoded value.
        /// </para>
        /// </summary>
        public TextTransformation TextTransformation
        {
            get { return this._textTransformation; }
            set { this._textTransformation = value; }
        }

        // Check to see if TextTransformation property is set
        internal bool IsSetTextTransformation()
        {
            return this._textTransformation != null;
        }

    }
}