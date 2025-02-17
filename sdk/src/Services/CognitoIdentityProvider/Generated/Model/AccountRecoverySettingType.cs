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
    /// The settings for user message delivery in forgot-password operations. Contains preference
    /// for email or SMS message delivery of password reset codes, or for admin-only password
    /// reset.
    /// 
    ///  
    /// <para>
    /// This data type is a request and response parameter of <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateUserPool.html">CreateUserPool</a>
    /// and <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateUserPool.html">UpdateUserPool</a>,
    /// and a response parameter of <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html">DescribeUserPool</a>.
    /// </para>
    /// </summary>
    public partial class AccountRecoverySettingType
    {
        private List<RecoveryOptionType> _recoveryMechanisms = AWSConfigs.InitializeCollections ? new List<RecoveryOptionType>() : null;

        /// <summary>
        /// Gets and sets the property RecoveryMechanisms. 
        /// <para>
        /// The list of options and priorities for user message delivery in forgot-password operations.
        /// Sets or displays user pool preferences for email or SMS message priority, whether
        /// users should fall back to a second delivery method, and whether passwords should only
        /// be reset by administrators.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<RecoveryOptionType> RecoveryMechanisms
        {
            get { return this._recoveryMechanisms; }
            set { this._recoveryMechanisms = value; }
        }

        // Check to see if RecoveryMechanisms property is set
        internal bool IsSetRecoveryMechanisms()
        {
            return this._recoveryMechanisms != null && (this._recoveryMechanisms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}