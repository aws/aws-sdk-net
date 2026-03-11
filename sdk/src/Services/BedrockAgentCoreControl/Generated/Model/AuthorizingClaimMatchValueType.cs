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
    /// Defines the value or values to match for and the relationship of the match.
    /// </summary>
    public partial class AuthorizingClaimMatchValueType
    {
        private ClaimMatchOperatorType _claimMatchOperator;
        private ClaimMatchValueType _claimMatchValue;

        /// <summary>
        /// Gets and sets the property ClaimMatchOperator. 
        /// <para>
        /// Defines the relationship between the claim field value and the value or values you're
        /// matching for.
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
        /// The value or values to match for.
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