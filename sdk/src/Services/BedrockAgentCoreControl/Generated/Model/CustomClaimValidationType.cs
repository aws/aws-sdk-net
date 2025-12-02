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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
        private AuthorizingClaimMatchValueType _authorizingClaimMatchValue;
        private string _inboundTokenClaimName;
        private InboundTokenClaimValueType _inboundTokenClaimValueType;

        /// <summary>
        /// Gets and sets the property AuthorizingClaimMatchValue. 
        /// <para>
        /// Defines the value or values to match for and the relationship of the match.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuthorizingClaimMatchValueType AuthorizingClaimMatchValue
        {
            get { return this._authorizingClaimMatchValue; }
            set { this._authorizingClaimMatchValue = value; }
        }

        // Check to see if AuthorizingClaimMatchValue property is set
        internal bool IsSetAuthorizingClaimMatchValue()
        {
            return this._authorizingClaimMatchValue != null;
        }

        /// <summary>
        /// Gets and sets the property InboundTokenClaimName. 
        /// <para>
        /// The name of the custom claim field to check.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string InboundTokenClaimName
        {
            get { return this._inboundTokenClaimName; }
            set { this._inboundTokenClaimName = value; }
        }

        // Check to see if InboundTokenClaimName property is set
        internal bool IsSetInboundTokenClaimName()
        {
            return this._inboundTokenClaimName != null;
        }

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
        [AWSProperty(Required=true)]
        public InboundTokenClaimValueType InboundTokenClaimValueType
        {
            get { return this._inboundTokenClaimValueType; }
            set { this._inboundTokenClaimValueType = value; }
        }

        // Check to see if InboundTokenClaimValueType property is set
        internal bool IsSetInboundTokenClaimValueType()
        {
            return this._inboundTokenClaimValueType != null;
        }

    }
}