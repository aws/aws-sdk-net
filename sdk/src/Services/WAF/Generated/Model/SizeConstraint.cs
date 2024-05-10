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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
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
namespace Amazon.WAF.Model
{
    /// <summary>
    /// <note> 
    /// <para>
    /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
    /// WAF Classic</a> in the developer guide.
    /// </para>
    ///  
    /// <para>
    ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
    /// for regional and global use. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Specifies a constraint on the size of a part of the web request. AWS WAF uses the
    /// <c>Size</c>, <c>ComparisonOperator</c>, and <c>FieldToMatch</c> to build an expression
    /// in the form of "<c>Size</c> <c>ComparisonOperator</c> size in bytes of <c>FieldToMatch</c>".
    /// If that expression is true, the <c>SizeConstraint</c> is considered to match.
    /// </para>
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
        /// with the provided <c>Size</c> and <c>FieldToMatch</c> to build an expression in the
        /// form of "<c>Size</c> <c>ComparisonOperator</c> size in bytes of <c>FieldToMatch</c>".
        /// If that expression is true, the <c>SizeConstraint</c> is considered to match.
        /// </para>
        ///  
        /// <para>
        ///  <b>EQ</b>: Used to test if the <c>Size</c> is equal to the size of the <c>FieldToMatch</c>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>NE</b>: Used to test if the <c>Size</c> is not equal to the size of the <c>FieldToMatch</c>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>LE</b>: Used to test if the <c>Size</c> is less than or equal to the size of the
        /// <c>FieldToMatch</c> 
        /// </para>
        ///  
        /// <para>
        ///  <b>LT</b>: Used to test if the <c>Size</c> is strictly less than the size of the
        /// <c>FieldToMatch</c> 
        /// </para>
        ///  
        /// <para>
        ///  <b>GE</b>: Used to test if the <c>Size</c> is greater than or equal to the size of
        /// the <c>FieldToMatch</c> 
        /// </para>
        ///  
        /// <para>
        ///  <b>GT</b>: Used to test if the <c>Size</c> is strictly greater than the size of the
        /// <c>FieldToMatch</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// <para>
        /// Specifies where in a web request to look for the size constraint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// <c>FieldToMatch</c>. AWS WAF uses this in combination with <c>ComparisonOperator</c>
        /// and <c>FieldToMatch</c> to build an expression in the form of "<c>Size</c> <c>ComparisonOperator</c>
        /// size in bytes of <c>FieldToMatch</c>". If that expression is true, the <c>SizeConstraint</c>
        /// is considered to match.
        /// </para>
        ///  
        /// <para>
        /// Valid values for size are 0 - 21474836480 bytes (0 - 20 GB).
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>URI</c> for the value of <c>Type</c>, the / in the URI counts as
        /// one character. For example, the URI <c>/logo.jpg</c> is nine characters long.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=21474836480)]
        public long? Size
        {
            get { return this._size; }
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
        /// WAF performs the transformation on <c>FieldToMatch</c> before inspecting it for a
        /// match.
        /// </para>
        ///  
        /// <para>
        /// You can only specify a single type of TextTransformation.
        /// </para>
        ///  
        /// <para>
        /// Note that if you choose <c>BODY</c> for the value of <c>Type</c>, you must choose
        /// <c>NONE</c> for <c>TextTransformation</c> because CloudFront forwards only the first
        /// 8192 bytes for inspection. 
        /// </para>
        ///  
        /// <para>
        ///  <b>NONE</b> 
        /// </para>
        ///  
        /// <para>
        /// Specify <c>NONE</c> if you don't want to perform any text transformations.
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
        ///  <c>COMPRESS_WHITE_SPACE</c> also replaces multiple spaces with one space.
        /// </para>
        ///  
        /// <para>
        ///  <b>HTML_ENTITY_DECODE</b> 
        /// </para>
        ///  
        /// <para>
        /// Use this option to replace HTML-encoded characters with unencoded characters. <c>HTML_ENTITY_DECODE</c>
        /// performs the following operations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Replaces <c>(ampersand)quot;</c> with <c>"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Replaces <c>(ampersand)nbsp;</c> with a non-breaking space, decimal 160
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Replaces <c>(ampersand)lt;</c> with a "less than" symbol
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Replaces <c>(ampersand)gt;</c> with <c>&gt;</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Replaces characters that are represented in hexadecimal format, <c>(ampersand)#xhhhh;</c>,
        /// with the corresponding characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Replaces characters that are represented in decimal format, <c>(ampersand)#nnnn;</c>,
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
        [AWSProperty(Required=true)]
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