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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about the <c>ByteMatchSet</c>, <c>IPSet</c>, <c>SqlInjectionMatchSet</c>,
    /// <c>XssMatchSet</c>, <c>RegexMatchSet</c>, <c>GeoMatchSet</c>, and <c>SizeConstraintSet</c>
    /// objects that you want to add to a rule and, for each object, indicates whether you
    /// want to negate the settings.
    /// </summary>
    public partial class AwsWafRulePredicateListDetails
    {
        /// <summary>
        /// Gets and sets the property DataId. 
        /// <para>
        /// A unique identifier for a predicate in a rule, such as <c>ByteMatchSetId</c> or <c>IPSetId</c>.
        /// 
        /// </para>
        /// </summary>
        public string DataId { get; set; }

        /// <summary>
        /// Checks to see if the DataId property is set.
        /// </summary>
        internal bool IsSetDataId() => this.DataId != null;

        /// <summary>
        /// Gets and sets the property Negated. 
        /// <para>
        /// Specifies if you want WAF to allow, block, or count requests based on the settings
        /// in the <c>ByteMatchSet</c>, <c>IPSet</c>, <c>SqlInjectionMatchSet</c>, <c>XssMatchSet</c>,
        /// <c>RegexMatchSet</c>, <c>GeoMatchSet</c>, or <c>SizeConstraintSet</c>. 
        /// </para>
        /// </summary>
        public bool? Negated { get; set; }

        /// <summary>
        /// Checks to see if the Negated property is set.
        /// </summary>
        internal bool IsSetNegated() => this.Negated.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of predicate in a rule, such as <c>ByteMatch</c> or <c>IPSet</c>. 
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
