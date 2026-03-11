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
    /// The bytes (typically a string that corresponds with ASCII characters) that you want
    /// AWS WAF to search for in web requests, the location in requests that you want AWS
    /// WAF to search, and other settings.
    /// </para>
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
        /// Gets and sets the property PositionalConstraint. 
        /// <para>
        /// Within the portion of a web request that you want to search (for example, in the query
        /// string, if any), specify where you want AWS WAF to search. Valid values include the
        /// following:
        /// </para>
        ///  
        /// <para>
        ///  <b>CONTAINS</b> 
        /// </para>
        ///  
        /// <para>
        /// The specified part of the web request must include the value of <c>TargetString</c>,
        /// but the location doesn't matter.
        /// </para>
        ///  
        /// <para>
        ///  <b>CONTAINS_WORD</b> 
        /// </para>
        ///  
        /// <para>
        /// The specified part of the web request must include the value of <c>TargetString</c>,
        /// and <c>TargetString</c> must contain only alphanumeric characters or underscore (A-Z,
        /// a-z, 0-9, or _). In addition, <c>TargetString</c> must be a word, which means one
        /// of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TargetString</c> exactly matches the value of the specified part of the web request,
        /// such as the value of a header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TargetString</c> is at the beginning of the specified part of the web request
        /// and is followed by a character other than an alphanumeric character or underscore
        /// (_), for example, <c>BadBot;</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TargetString</c> is at the end of the specified part of the web request and is
        /// preceded by a character other than an alphanumeric character or underscore (_), for
        /// example, <c>;BadBot</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TargetString</c> is in the middle of the specified part of the web request and
        /// is preceded and followed by characters other than alphanumeric characters or underscore
        /// (_), for example, <c>-BadBot;</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>EXACTLY</b> 
        /// </para>
        ///  
        /// <para>
        /// The value of the specified part of the web request must exactly match the value of
        /// <c>TargetString</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>STARTS_WITH</b> 
        /// </para>
        ///  
        /// <para>
        /// The value of <c>TargetString</c> must appear at the beginning of the specified part
        /// of the web request.
        /// </para>
        ///  
        /// <para>
        ///  <b>ENDS_WITH</b> 
        /// </para>
        ///  
        /// <para>
        /// The value of <c>TargetString</c> must appear at the end of the specified part of the
        /// web request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// string in the part of web requests that you specified in <c>FieldToMatch</c>. The
        /// maximum length of the value is 50 bytes.
        /// </para>
        ///  
        /// <para>
        /// Valid values depend on the values that you specified for <c>FieldToMatch</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HEADER</c>: The value that you want AWS WAF to search for in the request header
        /// that you specified in <a>FieldToMatch</a>, for example, the value of the <c>User-Agent</c>
        /// or <c>Referer</c> header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>METHOD</c>: The HTTP method, which indicates the type of operation specified in
        /// the request. CloudFront supports the following methods: <c>DELETE</c>, <c>GET</c>,
        /// <c>HEAD</c>, <c>OPTIONS</c>, <c>PATCH</c>, <c>POST</c>, and <c>PUT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>QUERY_STRING</c>: The value that you want AWS WAF to search for in the query string,
        /// which is the part of a URL that appears after a <c>?</c> character.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>URI</c>: The value that you want AWS WAF to search for in the part of a URL that
        /// identifies a resource, for example, <c>/images/daily-ad.jpg</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BODY</c>: The part of a request that contains any additional data that you want
        /// to send to your web server as the HTTP request body, such as data from a form. The
        /// request body immediately follows the request headers. Note that only the first <c>8192</c>
        /// bytes of the request body are forwarded to AWS WAF for inspection. To allow or block
        /// requests based on the length of the body, you can create a size constraint set. For
        /// more information, see <a>CreateSizeConstraintSet</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SINGLE_QUERY_ARG</c>: The parameter in the query string that you will inspect,
        /// such as <i>UserName</i> or <i>SalesRegion</i>. The maximum length for <c>SINGLE_QUERY_ARG</c>
        /// is 30 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALL_QUERY_ARGS</c>: Similar to <c>SINGLE_QUERY_ARG</c>, but instead of inspecting
        /// a single parameter, AWS WAF inspects all parameters within the query string for the
        /// value or regex pattern that you specify in <c>TargetString</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If <c>TargetString</c> includes alphabetic characters A-Z and a-z, note that the value
        /// is case sensitive.
        /// </para>
        ///  
        /// <para>
        ///  <b>If you're using the AWS WAF API</b> 
        /// </para>
        ///  
        /// <para>
        /// Specify a base64-encoded version of the value. The maximum length of the value before
        /// you base64-encode it is 50 bytes.
        /// </para>
        ///  
        /// <para>
        /// For example, suppose the value of <c>Type</c> is <c>HEADER</c> and the value of <c>Data</c>
        /// is <c>User-Agent</c>. If you want to search the <c>User-Agent</c> header for the value
        /// <c>BadBot</c>, you base64-encode <c>BadBot</c> using MIME base64-encoding and include
        /// the resulting value, <c>QmFkQm90</c>, in the value of <c>TargetString</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>If you're using the AWS CLI or one of the AWS SDKs</b> 
        /// </para>
        ///  
        /// <para>
        /// The value that you want AWS WAF to search for. The SDK automatically base64 encodes
        /// the value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// WAF performs the transformation on <c>FieldToMatch</c> before inspecting it for a
        /// match.
        /// </para>
        ///  
        /// <para>
        /// You can only specify a single type of TextTransformation.
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
        ///  
        /// <para>
        ///  <b>NONE</b> 
        /// </para>
        ///  
        /// <para>
        /// Specify <c>NONE</c> if you don't want to perform any text transformations.
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