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
    /// The settings for updates to user attributes. These settings include the property <c>AttributesRequireVerificationBeforeUpdate</c>,
    /// a user-pool setting that tells Amazon Cognito how to handle changes to the value of
    /// your users' email address and phone number attributes. For more information, see <a
    /// href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-email-phone-verification.html#user-pool-settings-verifications-verify-attribute-updates">
    /// Verifying updates to email addresses and phone numbers</a>.
    /// 
    ///  
    /// <para>
    /// This data type is a request and response parameter of <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateUserPool.html">CreateUserPool</a>
    /// and <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateUserPool.html">UpdateUserPool</a>,
    /// and a response parameter of <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html">DescribeUserPool</a>.
    /// </para>
    /// </summary>
    public partial class UserAttributeUpdateSettingsType
    {
        private List<string> _attributesRequireVerificationBeforeUpdate = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AttributesRequireVerificationBeforeUpdate. 
        /// <para>
        /// Requires that your user verifies their email address, phone number, or both before
        /// Amazon Cognito updates the value of that attribute. When you update a user attribute
        /// that has this option activated, Amazon Cognito sends a verification message to the
        /// new phone number or email address. Amazon Cognito doesn’t change the value of the
        /// attribute until your user responds to the verification message and confirms the new
        /// value.
        /// </para>
        ///  
        /// <para>
        /// You can verify an updated email address or phone number with a <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_VerifyUserAttribute.html">VerifyUserAttribute</a>
        /// API request. You can also call the <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_AdminUpdateUserAttributes.html">AdminUpdateUserAttributes</a>
        /// API and set <c>email_verified</c> or <c>phone_number_verified</c> to true.
        /// </para>
        ///  
        /// <para>
        /// When <c>AttributesRequireVerificationBeforeUpdate</c> is false, your user pool doesn't
        /// require that your users verify attribute changes before Amazon Cognito updates them.
        /// In a user pool where <c>AttributesRequireVerificationBeforeUpdate</c> is false, API
        /// operations that change attribute values can immediately update a user’s <c>email</c>
        /// or <c>phone_number</c> attribute.
        /// </para>
        /// </summary>
        public List<string> AttributesRequireVerificationBeforeUpdate
        {
            get { return this._attributesRequireVerificationBeforeUpdate; }
            set { this._attributesRequireVerificationBeforeUpdate = value; }
        }

        // Check to see if AttributesRequireVerificationBeforeUpdate property is set
        internal bool IsSetAttributesRequireVerificationBeforeUpdate()
        {
            return this._attributesRequireVerificationBeforeUpdate != null && (this._attributesRequireVerificationBeforeUpdate.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}