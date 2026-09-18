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
    /// Details for a match predicate. A predicate might look for characteristics such as
    /// specific IP addresses, geographic locations, or sizes.
    /// </summary>
    public partial class AwsWafRegionalRateBasedRuleMatchPredicate
    {
        /// <summary>
        /// Gets and sets the property DataId. 
        /// <para>
        /// The unique identifier for the predicate.
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
        /// If set to <c>true</c>, then the rule actions are performed on requests that match
        /// the predicate settings.
        /// </para>
        ///  
        /// <para>
        /// If set to <c>false</c>, then the rule actions are performed on all requests except
        /// those that match the predicate settings.
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
        /// The type of predicate. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ByteMatch</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GeoMatch</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IPMatch</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RegexMatch</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SizeConstraint</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SqlInjectionMatch</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>XssMatch</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
