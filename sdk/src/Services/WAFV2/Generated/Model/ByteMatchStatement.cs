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

#pragma warning disable CS0612,CS0618,CS1570
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
        private List<TextTransformation> _textTransformations = AWSConfigs.InitializeCollections ? new List<TextTransformation>() : null;

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
        /// The area within the portion of the web request that you want WAF to search for <c>SearchString</c>.
        /// Valid values include the following:
        /// </para>
        ///  
        /// <para>
        ///  <b>CONTAINS</b> 
        /// </para>
        ///  
        /// <para>
        /// The specified part of the web request must include the value of <c>SearchString</c>,
        /// but the location doesn't matter.
        /// </para>
        ///  
        /// <para>
        ///  <b>CONTAINS_WORD</b> 
        /// </para>
        ///  
        /// <para>
        /// The specified part of the web request must include the value of <c>SearchString</c>,
        /// and <c>SearchString</c> must contain only alphanumeric characters or underscore (A-Z,
        /// a-z, 0-9, or _). In addition, <c>SearchString</c> must be a word, which means that
        /// both of the following are true:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SearchString</c> is at the beginning of the specified part of the web request
        /// or is preceded by a character other than an alphanumeric character or underscore (_).
        /// Examples include the value of a header and <c>;BadBot</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SearchString</c> is at the end of the specified part of the web request or is
        /// followed by a character other than an alphanumeric character or underscore (_), for
        /// example, <c>BadBot;</c> and <c>-BadBot;</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>EXACTLY</b> 
        /// </para>
        ///  
        /// <para>
        /// The value of the specified part of the web request must exactly match the value of
        /// <c>SearchString</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>STARTS_WITH</b> 
        /// </para>
        ///  
        /// <para>
        /// The value of <c>SearchString</c> must appear at the beginning of the specified part
        /// of the web request.
        /// </para>
        ///  
        /// <para>
        ///  <b>ENDS_WITH</b> 
        /// </para>
        ///  
        /// <para>
        /// The value of <c>SearchString</c> must appear at the end of the specified part of the
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
        /// Gets and sets the property SearchString. 
        /// <para>
        /// A string value that you want WAF to search for. WAF searches only in the part of web
        /// requests that you designate for inspection in <a>FieldToMatch</a>. The maximum length
        /// of the value is 200 bytes.
        /// </para>
        ///  
        /// <para>
        /// Valid values depend on the component that you specify for inspection in <c>FieldToMatch</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Method</c>: The HTTP method that you want WAF to search for. This indicates the
        /// type of operation specified in the request. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UriPath</c>: The value that you want WAF to search for in the URI path, for example,
        /// <c>/images/daily-ad.jpg</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>JA3Fingerprint</c>: Available for use with Amazon CloudFront distributions and
        /// Application Load Balancers. Match against the request's JA3 fingerprint. The JA3 fingerprint
        /// is a 32-character hash derived from the TLS Client Hello of an incoming request. This
        /// fingerprint serves as a unique identifier for the client's TLS configuration. You
        /// can use this choice only with a string match <c>ByteMatchStatement</c> with the <c>PositionalConstraint</c>
        /// set to <c>EXACTLY</c>. 
        /// </para>
        ///  
        /// <para>
        /// You can obtain the JA3 fingerprint for client requests from the web ACL logs. If WAF
        /// is able to calculate the fingerprint, it includes it in the logs. For information
        /// about the logging fields, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging-fields.html">Log
        /// fields</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HeaderOrder</c>: The list of header names to match for. WAF creates a string that
        /// contains the ordered list of header names, from the headers in the web request, and
        /// then matches against that string. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If <c>SearchString</c> includes alphabetic characters A-Z and a-z, note that the value
        /// is case sensitive.
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
        /// For example, suppose the value of <c>Type</c> is <c>HEADER</c> and the value of <c>Data</c>
        /// is <c>User-Agent</c>. If you want to search the <c>User-Agent</c> header for the value
        /// <c>BadBot</c>, you base64-encode <c>BadBot</c> using MIME base64-encoding and include
        /// the resulting value, <c>QmFkQm90</c>, in the value of <c>SearchString</c>.
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
        /// web requests in an effort to bypass detection. Text transformations are used in rule
        /// match statements, to transform the <c>FieldToMatch</c> request component before inspecting
        /// it, and they're used in rate-based rule statements, to transform request components
        /// before using them as custom aggregation keys. If you specify one or more transformations
        /// to apply, WAF performs all transformations on the specified content, starting from
        /// the lowest priority setting, and then uses the transformed component contents. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._textTransformations != null && (this._textTransformations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}