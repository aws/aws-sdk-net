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
    /// Specifies a query argument in the request as an aggregate key for a rate-based rule.
    /// Each distinct value for the named query argument contributes to the aggregation instance.
    /// If you use a single query argument as your custom key, then each value fully defines
    /// an aggregation instance.
    /// </summary>
    public partial class RateLimitQueryArgument
    {
        private string _name;
        private List<TextTransformation> _textTransformations = AWSConfigs.InitializeCollections ? new List<TextTransformation>() : null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the query argument to use. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
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