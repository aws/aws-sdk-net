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
    /// A rule statement that compares a number of bytes against the size of a request component,
    /// using a comparison operator, such as greater than (&gt;) or less than (&lt;). For
    /// example, you can use a size constraint statement to look for query strings that are
    /// longer than 100 bytes. 
    /// 
    ///  
    /// <para>
    /// If you configure WAF to inspect the request body, WAF inspects only the number of
    /// bytes of the body up to the limit for the web ACL. By default, for regional web ACLs,
    /// this limit is 8 KB (8,192 kilobytes) and for CloudFront web ACLs, this limit is 16
    /// KB (16,384 kilobytes). For CloudFront web ACLs, you can increase the limit in the
    /// web ACL <code>AssociationConfig</code>, for additional fees. If you know that the
    /// request body for your web requests should never exceed the inspection limit, you could
    /// use a size constraint statement to block requests that have a larger request body
    /// size.
    /// </para>
    ///  
    /// <para>
    /// If you choose URI for the value of Part of the request to filter on, the slash (/)
    /// in the URI counts as one character. For example, the URI <code>/logo.jpg</code> is
    /// nine characters long.
    /// </para>
    /// </summary>
    public partial class SizeConstraintStatement
    {
        private ComparisonOperator _comparisonOperator;
        private FieldToMatch _fieldToMatch;
        private long? _size;
        private List<TextTransformation> _textTransformations = new List<TextTransformation>();

        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// The operator to use to compare the request part to the size setting. 
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
        /// Gets and sets the property Size. 
        /// <para>
        /// The size, in byte, to compare to the request part, after any transformations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=21474836480)]
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