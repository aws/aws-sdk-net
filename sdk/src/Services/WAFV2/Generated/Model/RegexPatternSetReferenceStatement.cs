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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

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
    /// A rule statement used to search web request components for matches with regular expressions.
    /// To use this, create a <a>RegexPatternSet</a> that specifies the expressions that you
    /// want to detect, then use the ARN of that set in this statement. A web request matches
    /// the pattern set rule statement if the request component matches any of the patterns
    /// in the set. To create a regex pattern set, see <a>CreateRegexPatternSet</a>.
    /// </para>
    ///  
    /// <para>
    /// Each regex pattern set rule statement references a regex pattern set. You create and
    /// maintain the set independent of your rules. This allows you to use the single set
    /// in multiple rules. When you update the referenced set, AWS WAF automatically updates
    /// all rules that reference it.
    /// </para>
    /// </summary>
    public partial class RegexPatternSetReferenceStatement
    {
        private string _arn;
        private FieldToMatch _fieldToMatch;
        private List<TextTransformation> _textTransformations = new List<TextTransformation>();

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <a>RegexPatternSet</a> that this statement references.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
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