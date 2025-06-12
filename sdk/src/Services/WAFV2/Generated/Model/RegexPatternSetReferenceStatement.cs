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
    /// A rule statement used to search web request components for matches with regular expressions.
    /// To use this, create a <a>RegexPatternSet</a> that specifies the expressions that you
    /// want to detect, then use the ARN of that set in this statement. A web request matches
    /// the pattern set rule statement if the request component matches any of the patterns
    /// in the set. To create a regex pattern set, see <a>CreateRegexPatternSet</a>.
    /// 
    ///  
    /// <para>
    /// Each regex pattern set rule statement references a regex pattern set. You create and
    /// maintain the set independent of your rules. This allows you to use the single set
    /// in multiple rules. When you update the referenced set, WAF automatically updates all
    /// rules that reference it.
    /// </para>
    /// </summary>
    public partial class RegexPatternSetReferenceStatement
    {
        private string _arn;
        private FieldToMatch _fieldToMatch;
        private List<TextTransformation> _textTransformations = AWSConfigs.InitializeCollections ? new List<TextTransformation>() : null;

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