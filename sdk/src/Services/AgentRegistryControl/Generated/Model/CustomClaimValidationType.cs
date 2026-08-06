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
 * Do not modify this file. This file is generated from the agent-registry-control-2025-12-01.normal.json service model.
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
namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// A validation rule applied to a single claim of an inbound JWT.
    /// </summary>
    public partial class CustomClaimValidationType
    {
        private AuthorizingClaimMatchValueType _authorizingClaimMatchValue;
        private string _inboundTokenClaimName;
        private InboundTokenClaimValueType _inboundTokenClaimValueType;

        /// <summary>
        /// Gets and sets the property AuthorizingClaimMatchValue. 
        /// <para>
        /// The value and match operator used to authorize the claim.
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
        /// The name of the claim in the inbound token to validate.
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
        /// The value type of the claim in the inbound token, either a string or an array of strings.
        /// </para>
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