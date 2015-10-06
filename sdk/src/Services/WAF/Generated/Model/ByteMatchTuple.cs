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
    /// The bytes (typically a string that corresponds with ASCII characters) that you want
    /// AWS WAF to search for in web requests, the location in requests that you want AWS
    /// WAF to search, and other settings.
    /// </summary>
    public partial class ByteMatchTuple
    {
        private FieldToMatch _fieldToMatch;
        private PositionalConstraint _positionalConstraint;
        private MemoryStream _targetStream;
        private TextTransformation _textTransformation;

        /// <summary>
        /// Gets and sets the property FieldToMatch. 
        /// <para>
        /// The part of a web request that you want AWS WAF to search, such as a specified header
        /// or a query string. For more information, see <a>FieldToMatch</a>.
        /// </para>
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
        /// Gets and sets the property PositionalConstraint. 
        /// <para>
        /// Within the portion of a web request that you want to search (for example, in the query
        /// string, if any), specify where you want AWS WAF to search. Valid values include the
        /// following:
        /// </para>
        ///  
        /// <para>
        /// <b>CONTAINS</b>
        /// </para>
        ///  
        /// <para>
        /// The specified part of the web request must include the value of <code>TargetString</code>,
        /// but the location doesn't matter.
        /// </para>
        ///  
        /// <para>
        /// <b>CONTAINS_WORD</b>
        /// </para>
        ///  
        /// <para>
        /// The specified part of the web request must include the value of <code>TargetString</code>,
        /// and <code>TargetString</code> must contain only alphanumeric characters or underscore
        /// (A-Z, a-z, 0-9, or _). In addition, <code>TargetString</code> must be a word, which
        /// means one of the following:
        /// </para>
        ///  <ul> <li> <code>TargetString</code> exactly matches the value of the specified part
        /// of the web request, such as the value of a header.</li> <li> <code>TargetString</code>
        /// is at the beginning of the specified part of the web request and is followed by a
        /// character other than an alphanumeric character or underscore (_), for example, <code>BadBot;</code>.</li>
        /// <li> <code>TargetString</code> is at the end of the specified part of the web request
        /// and is preceded by a character other than an alphanumeric character or underscore
        /// (_), for example, <code>;BadBot</code>.</li> <li> <code>TargetString</code> is in
        /// the middle of the specified part of the web request and is preceded and followed by
        /// characters other than alphanumeric characters or underscore (_), for example, <code>-BadBot;</code>.</li>
        /// </ul> 
        /// <para>
        /// <b>EXACTLY</b>
        /// </para>
        ///  
        /// <para>
        /// The value of the specified part of the web request must exactly match the value of
        /// <code>TargetString</code>.
        /// </para>
        ///  
        /// <para>
        /// <b>STARTS_WITH</b>
        /// </para>
        ///  
        /// <para>
        /// The value of <code>TargetString</code> must appear at the beginning of the specified
        /// part of the web request.
        /// </para>
        ///  
        /// <para>
        /// <b>ENDS_WITH</b>
        /// </para>
        ///  
        /// <para>
        /// The value of <code>TargetString</code> must appear at the end of the specified part
        /// of the web request.
        /// </para>
        /// </summary>
        public PositionalConstraint PositionalConstraint
        {
            get { return this._positionalConstraint; }
            set { this._positionalConstraint = value; }
        }

        // Check to see if PositionalConstraint property is set
        internal bool IsSetPositionalConstraint()
        {
            return this._positionalConstraint != null;
        }

        /// <summary>
        /// Gets and sets the property TargetStream. 
        /// <para>
        /// The value that you want AWS WAF to search for. AWS WAF searches for the specified
        /// string in the part of web requests that you specified in <code>FieldToMatch</code>.
        /// The maximum length of the value is 50 bytes.
        /// </para>
        ///  
        /// <para>
        /// Valid values depend on the values that you specified for <code>FieldToMatch</code>:
        /// </para>
        ///  <ul> <li> <code>HEADER</code>: The value that you want AWS WAF to search for in the
        /// request header that you specified in <a>FieldToMatch</a>, for example, the value of
        /// the <code>User-Agent</code> or <code>Referer</code> header.</li> <li> <code>METHOD</code>:
        /// The HTTP method, which indicates the type of operation specified in the request. CloudFront
        /// supports the following methods: <code>DELETE</code>, <code>GET</code>, <code>HEAD</code>,
        /// <code>OPTIONS</code>, <code>PATCH</code>, <code>POST</code>, and <code>PUT</code>.</li>
        /// <li> <code>QUERY_STRING</code>: The value that you want AWS WAF to search for in the
        /// query string, which is the part of a URL that appears after a <code>?</code> character.</li>
        /// <li> <code>URI</code>: The value that you want AWS WAF to search for in the part of
        /// a URL that identifies a resource, for example, <code>/images/daily-ad.jpg</code>.</li>
        /// </ul> 
        /// <para>
        /// If <code>TargetString</code> includes alphabetic characters A-Z and a-z, note that
        /// the value is case sensitive.
        /// </para>
        ///  
        /// <para>
        /// <b>If you're using the AWS WAF API</b>
        /// </para>
        ///  
        /// <para>
        /// Specify a base64-encoded version of the value. The maximum length of the value before
        /// you base64-encode it is 50 bytes. 
        /// </para>
        ///  
        /// <para>
        /// For example, suppose the value of <code>Type</code> is <code>HEADER</code> and the
        /// value of <code>Data</code> is <code>User-Agent</code>. If you want to search the <code>User-Agent</code>
        /// header for the value <code>BadBot</code>, you base64-encode <code>BadBot</code> using
        /// MIME base64 encoding and include the resulting value, <code>QmFkQm90</code>, in the
        /// value of <code>TargetString</code>.
        /// </para>
        ///  
        /// <para>
        /// <b>If you're using the AWS CLI or one of the AWS SDKs</b>
        /// </para>
        ///  
        /// <para>
        /// The value that you want AWS WAF to search for. The SDK automatically base64 encodes
        /// the value.
        /// </para>
        /// </summary>
        public MemoryStream TargetStream
        {
            get { return this._targetStream; }
            set { this._targetStream = value; }
        }

        // Check to see if TargetStream property is set
        internal bool IsSetTargetStream()
        {
            return this._targetStream != null;
        }

        /// <summary>
        /// Gets and sets the property TextTransformation. 
        /// <para>
        /// Text transformations eliminate some of the unusual formatting that attackers use in
        /// web requests in an effort to bypass AWS WAF. If you specify a transformation, AWS
        /// WAF performs the transformation on <code>TargetString</code> before inspecting a request
        /// for a match.
        /// </para>
        ///  
        /// <para>
        /// <b>CMD_LINE</b>
        /// </para>
        ///  
        /// <para>
        /// When you're concerned that attackers are injecting an operating system commandline
        /// command and using unusual formatting to disguise some or all of the command, use this
        /// option to perform the following transformations:
        /// </para>
        ///  <ul> <li>Delete the following characters: \ " ' ^</li> <li>Delete spaces before the
        /// following characters: / (</li> <li>Replace the following characters with a space:
        /// , ;</li> <li>Replace multiple spaces with one space</li> <li>Convert uppercase letters
        /// (A-Z) to lowercase (a-z)</li> </ul> 
        /// <para>
        /// <b>COMPRESS_WHITE_SPACE</b>
        /// </para>
        ///  
        /// <para>
        /// Use this option to replace the following characters with a space character (decimal
        /// 32):
        /// </para>
        ///  <ul> <li>\f, formfeed, decimal 12</li> <li>\t, tab, decimal 9</li> <li>\n, newline,
        /// decimal 10</li> <li>\r, carriage return, decimal 13</li> <li>\v, vertical tab, decimal
        /// 11</li> <li>non-breaking space, decimal 160</li> </ul> 
        /// <para>
        /// <code>COMPRESS_WHITE_SPACE</code> also replaces multiple spaces with one space.
        /// </para>
        ///  
        /// <para>
        /// <b>HTML_ENTITY_DECODE</b>
        /// </para>
        ///  
        /// <para>
        /// Use this option to replace HTML-encoded characters with unencoded characters. <code>HTML_ENTITY_DECODE</code>
        /// performs the following operations:
        /// </para>
        ///  <ul> <li>Replaces <code>(ampersand)quot;</code> with <code>"</code> </li> <li>Replaces
        /// <code>(ampersand)nbsp;</code> with a non-breaking space, decimal 160</li> <li>Replaces
        /// <code>(ampersand)lt;</code> with a "less than" symbol</li> <li>Replaces <code>(ampersand)gt;</code>
        /// with <code>&gt;</code> </li> <li>Replaces characters that are represented in hexadecimal
        /// format, <code>(ampersand)#xhhhh;</code>, with the corresponding characters</li> <li>Replaces
        /// characters that are represented in decimal format, <code>(ampersand)#nnnn;</code>,
        /// with the corresponding characters</li> </ul> 
        /// <para>
        /// <b>LOWERCASE</b>
        /// </para>
        ///  
        /// <para>
        /// Use this option to convert uppercase letters (A-Z) to lowercase (a-z).
        /// </para>
        ///  
        /// <para>
        /// <b>URL_DECODE</b>
        /// </para>
        ///  
        /// <para>
        /// Use this option to decode a URL-encoded value.
        /// </para>
        ///  
        /// <para>
        /// <b>NONE</b>
        /// </para>
        ///  
        /// <para>
        /// Specify <code>NONE</code> if you don't want to perform any text transformations.
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