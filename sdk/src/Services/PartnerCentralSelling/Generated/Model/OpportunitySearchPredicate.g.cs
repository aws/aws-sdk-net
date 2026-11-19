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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// A leaf filter condition. It carries the field (<c>Key</c>) and the typed value (<c>Value</c>)
    /// to compare against. The enclosing <c>OpportunitySearchFilter</c> member determines
    /// the comparison operator.
    /// </summary>
    public partial class OpportunitySearchPredicate
    {
        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The opportunity field that the condition applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OpportunitySearchFilterName Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The typed value the condition compares against. Specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A single string value – used by <c>EqualsTo</c>, and by <c>ContainsAny</c> or <c>ContainsAll</c>
        /// for a single-value match.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A list of string values – used by <c>ContainsAny</c> or <c>ContainsAll</c> to match
        /// against multiple values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An integral numeric value – used by the range comparisons on integral numeric fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A fractional numeric value – used by the range comparisons on numeric amount fields
        /// such as <c>EstimatedMrr</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A date-time value in RFC 3339 format – used by the range comparisons on date fields.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public OpportunitySearchFilterValue Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
