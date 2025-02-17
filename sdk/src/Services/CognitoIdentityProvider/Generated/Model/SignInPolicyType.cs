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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The policy for allowed types of authentication in a user pool.
    /// 
    ///  
    /// <para>
    /// This data type is a request and response parameter of <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateUserPool.html">CreateUserPool</a>
    /// and <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateUserPool.html">UpdateUserPool</a>,
    /// and a response parameter of <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html">DescribeUserPool</a>.
    /// </para>
    /// </summary>
    public partial class SignInPolicyType
    {
        private List<string> _allowedFirstAuthFactors = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllowedFirstAuthFactors. 
        /// <para>
        /// The sign-in methods that a user pool supports as the first factor. You can permit
        /// users to start authentication with a standard username and password, or with other
        /// one-time password and hardware factors.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<string> AllowedFirstAuthFactors
        {
            get { return this._allowedFirstAuthFactors; }
            set { this._allowedFirstAuthFactors = value; }
        }

        // Check to see if AllowedFirstAuthFactors property is set
        internal bool IsSetAllowedFirstAuthFactors()
        {
            return this._allowedFirstAuthFactors != null && (this._allowedFirstAuthFactors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}