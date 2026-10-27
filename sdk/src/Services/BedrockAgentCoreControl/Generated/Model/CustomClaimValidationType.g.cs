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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Defines the name of a custom claim field and rules for finding matches to authenticate
    /// its value.
    /// </summary>
    public partial class CustomClaimValidationType
    {
        /// <summary>
        /// Gets and sets the property AuthorizingClaimMatchValue. 
        /// <para>
        /// Defines the value or values to match for and the relationship of the match.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuthorizingClaimMatchValueType AuthorizingClaimMatchValue { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizingClaimMatchValue property is set.
        /// </summary>
        internal bool IsSetAuthorizingClaimMatchValue() => this.AuthorizingClaimMatchValue != null;

        /// <summary>
        /// Gets and sets the property InboundTokenClaimName. 
        /// <para>
        /// The name of the custom claim field to check.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string InboundTokenClaimName { get; set; }

        /// <summary>
        /// Checks to see if the InboundTokenClaimName property is set.
        /// </summary>
        internal bool IsSetInboundTokenClaimName() => this.InboundTokenClaimName != null;

        /// <summary>
        /// Gets and sets the property InboundTokenClaimValueType. 
        /// <para>
        /// The data type of the claim value to check for.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use <c>STRING</c> if you want to find an exact match to a string you define.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>STRING_ARRAY</c> if you want to fnd a match to at least one value in an array
        /// you define.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public InboundTokenClaimValueType InboundTokenClaimValueType { get; set; }

        /// <summary>
        /// Checks to see if the InboundTokenClaimValueType property is set.
        /// </summary>
        internal bool IsSetInboundTokenClaimValueType() => this.InboundTokenClaimValueType != null;
    }
}
