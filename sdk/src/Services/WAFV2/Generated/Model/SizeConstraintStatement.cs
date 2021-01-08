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
    /// <note> 
    /// <para>
    /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
    /// 2019. For information, including how to migrate your AWS WAF resources from the prior
    /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// A rule statement that compares a number of bytes against the size of a request component,
    /// using a comparison operator, such as greater than (&gt;) or less than (&lt;). For
    /// example, you can use a size constraint statement to look for query strings that are
    /// longer than 100 bytes. 
    /// </para>
    ///  
    /// <para>
    /// If you configure AWS WAF to inspect the request body, AWS WAF inspects only the first
    /// 8192 bytes (8 KB). If the request body for your web requests never exceeds 8192 bytes,
    /// you can create a size constraint condition and block requests that have a request
    /// body greater than 8192 bytes.
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
        /// The part of a web request that you want AWS WAF to inspect. For more information,
        /// see <a>FieldToMatch</a>. 
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
        /// in a rule statement, AWS WAF performs all transformations on the content of the request
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