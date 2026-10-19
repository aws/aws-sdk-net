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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// A rule statement that compares a number of bytes against the size of a request component,
    /// using a comparison operator, such as greater than (>) or less than (&lt;). For example,
    /// you can use a size constraint statement to look for query strings that are longer
    /// than 100 bytes. 
    /// 
    ///  
    /// <para>
    /// If you configure WAF to inspect the request body, WAF inspects only the number of
    /// bytes in the body up to the limit for the web ACL and protected resource type. If
    /// you know that the request body for your web requests should never exceed the inspection
    /// limit, you can use a size constraint statement to block requests that have a larger
    /// request body size. For more information about the inspection limits, see <c>Body</c>
    /// and <c>JsonBody</c> settings for the <c>FieldToMatch</c> data type. 
    /// </para>
    ///  
    /// <para>
    /// If you choose URI for the value of Part of the request to filter on, the slash (/)
    /// in the URI counts as one character. For example, the URI <c>/logo.jpg</c> is nine
    /// characters long.
    /// </para>
    /// </summary>
    public partial class SizeConstraintStatement
    {
        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// The operator to use to compare the request part to the size setting. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ComparisonOperator ComparisonOperator { get; set; }

        /// <summary>
        /// Checks to see if the ComparisonOperator property is set.
        /// </summary>
        internal bool IsSetComparisonOperator() => this.ComparisonOperator != null;

        /// <summary>
        /// Gets and sets the property FieldToMatch. 
        /// <para>
        /// The part of the web request that you want WAF to inspect. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FieldToMatch FieldToMatch { get; set; }

        /// <summary>
        /// Checks to see if the FieldToMatch property is set.
        /// </summary>
        internal bool IsSetFieldToMatch() => this.FieldToMatch != null;

        /// <summary>
        /// Gets and sets the property PreParseTextTransformations. 
        /// <para>
        /// Pre-parse text transformations normalize the raw query string before WAF parses it
        /// into individual query arguments. They are applied before the standard text transformations.
        /// Pre-parse text transformations are only supported when <c>FieldToMatch</c> is <c>SingleQueryArgument</c>
        /// or <c>AllQueryArguments</c>. You can specify up to 10 pre-parse text transformations
        /// per rule statement.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PreParseTextTransformation> PreParseTextTransformations { get; set; } = AWSConfigs.InitializeCollections ? new List<PreParseTextTransformation>() : null;

        /// <summary>
        /// Checks to see if the PreParseTextTransformations property is set.
        /// </summary>
        internal bool IsSetPreParseTextTransformations() => this.PreParseTextTransformations != null && (this.PreParseTextTransformations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size, in byte, to compare to the request part, after any transformations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 21474836480)]
        public long? Size { get; set; }

        /// <summary>
        /// Checks to see if the Size property is set.
        /// </summary>
        internal bool IsSetSize() => this.Size.HasValue;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<TextTransformation> TextTransformations { get; set; } = AWSConfigs.InitializeCollections ? new List<TextTransformation>() : null;

        /// <summary>
        /// Checks to see if the TextTransformations property is set.
        /// </summary>
        internal bool IsSetTextTransformations() => this.TextTransformations != null && (this.TextTransformations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
