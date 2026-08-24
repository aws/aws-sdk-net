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
    /// The value and match operator used to authorize a claim during JWT validation.
    /// </summary>
    public partial class AuthorizingClaimMatchValueType
    {
        private ClaimMatchOperatorType _claimMatchOperator;
        private ClaimMatchValueType _claimMatchValue;

        /// <summary>
        /// Gets and sets the property ClaimMatchOperator. 
        /// <para>
        /// The operator used to compare the claim value against the expected value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClaimMatchOperatorType ClaimMatchOperator
        {
            get { return this._claimMatchOperator; }
            set { this._claimMatchOperator = value; }
        }

        // Check to see if ClaimMatchOperator property is set
        internal bool IsSetClaimMatchOperator()
        {
            return this._claimMatchOperator != null;
        }

        /// <summary>
        /// Gets and sets the property ClaimMatchValue. 
        /// <para>
        /// The expected value or values that the claim is compared against.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClaimMatchValueType ClaimMatchValue
        {
            get { return this._claimMatchValue; }
            set { this._claimMatchValue = value; }
        }

        // Check to see if ClaimMatchValue property is set
        internal bool IsSetClaimMatchValue()
        {
            return this._claimMatchValue != null;
        }

    }
}