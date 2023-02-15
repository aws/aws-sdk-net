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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// A rule statement that defines a string match search for WAF to apply to web requests.
    /// The byte match statement provides the bytes to search for, the location in requests
    /// that you want WAF to search, and other settings. The bytes to search for are typically
    /// a string that corresponds with ASCII characters. In the WAF console and the developer
    /// guide, this is called a string match statement.
    /// </summary>
    public partial class ByteMatchStatement
    {
        private FieldToMatch _fieldToMatch;
        private PositionalConstraint _positionalConstraint;
        private MemoryStream _searchString;
        private List<TextTransformation> _textTransformations = new List<TextTransformation>();

        /// <summary>
        /// Gets and sets the property FieldToMatch. 
        /// <para>
        /// The part of the web request that you want WAF to inspect. 
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
        /// The area within the portion of the web request that you want WAF to search for <code>SearchString</code>.
        /// Valid values include the following:
        /// </para>
        ///  
        /// <para>
        ///  <b>CONTAINS</b> 
        /// </para>
        ///  
        /// <para>
        /// The specified part of the web request must include the value of <code>SearchString</code>,
        /// but the location doesn't matter.
        /// </para>
        ///  
        /// <para>
        ///  <b>CONTAINS_WORD</b> 
        /// </para>
        ///  
        /// <para>
        /// The specified part of the web request must include the value of <code>SearchString</code>,
        /// and <code>SearchString</code> must contain only alphanumeric characters or underscore
        /// (A-Z, a-z, 0-9, or _). In addition, <code>SearchString</code> must be a word, which
        /// means that both of the following are true:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SearchString</code> is at the beginning of the specified part of the web request
        /// or is preceded by a character other than an alphanumeric character or underscore (_).
        /// Examples include the value of a header and <code>;BadBot</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SearchString</code> is at the end of the specified part of the web request
        /// or is followed by a character other than an alphanumeric character or underscore (_),
        /// for example, <code>BadBot;</code> and <code>-BadBot;</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>EXACTLY</b> 
        /// </para>
        ///  
        /// <para>
        /// The value of the specified part of the web request must exactly match the value of
        /// <code>SearchString</code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>STARTS_WITH</b> 
        /// </para>
        ///  
        /// <para>
        /// The value of <code>SearchString</code> must appear at the beginning of the specified
        /// part of the web request.
        /// </para>
        ///  
        /// <para>
        ///  <b>ENDS_WITH</b> 
        /// </para>
        ///  
        /// <para>
        /// The value of <code>SearchString</code> must appear at the end of the specified part
        /// of the web request.
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
        /// Gets and sets the property SearchString. 
        /// <para>
        /// A string value that you want WAF to search for. WAF searches only in the part of web
        /// requests that you designate for inspection in <a>FieldToMatch</a>. The maximum length
        /// of the value is 200 bytes.
        /// </para>
        ///  
        /// <para>
        /// Valid values depend on the component that you specify for inspection in <code>FieldToMatch</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Method</code>: The HTTP method that you want WAF to search for. This indicates
        /// the type of operation specified in the request. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UriPath</code>: The value that you want WAF to search for in the URI path,
        /// for example, <code>/images/daily-ad.jpg</code>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If <code>SearchString</code> includes alphabetic characters A-Z and a-z, note that
        /// the value is case sensitive.
        /// </para>
        ///  
        /// <para>
        ///  <b>If you're using the WAF API</b> 
        /// </para>
        ///  
        /// <para>
        /// Specify a base64-encoded version of the value. The maximum length of the value before
        /// you base64-encode it is 200 bytes.
        /// </para>
        ///  
        /// <para>
        /// For example, suppose the value of <code>Type</code> is <code>HEADER</code> and the
        /// value of <code>Data</code> is <code>User-Agent</code>. If you want to search the <code>User-Agent</code>
        /// header for the value <code>BadBot</code>, you base64-encode <code>BadBot</code> using
        /// MIME base64-encoding and include the resulting value, <code>QmFkQm90</code>, in the
        /// value of <code>SearchString</code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>If you're using the CLI or one of the Amazon Web Services SDKs</b> 
        /// </para>
        ///  
        /// <para>
        /// The value that you want WAF to search for. The SDK automatically base64 encodes the
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MemoryStream SearchString
        {
            get { return this._searchString; }
            set { this._searchString = value; }
        }

        // Check to see if SearchString property is set
        internal bool IsSetSearchString()
        {
            return this._searchString != null;
        }

        /// <summary>
        /// Gets and sets the property TextTransformations. 
        /// <para>
        /// Text transformations eliminate some of the unusual formatting that attackers use in
        /// web requests in an effort to bypass detection. If you specify one or more transformations
        /// in a rule statement, WAF performs all transformations on the content of the request
        /// component identified by <code>FieldToMatch</code>, starting from the lowest priority
        /// setting, before inspecting the content for a match.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<TextTransformation> TextTransformations
        {
            get { return this._textTransformations; }
            set { this._textTransformations = value; }
        }

        // Check to see if TextTransformations property is set
        internal bool IsSetTextTransformations()
        {
            return this._textTransformations != null && this._textTransformations.Count > 0; 
        }

    }
}