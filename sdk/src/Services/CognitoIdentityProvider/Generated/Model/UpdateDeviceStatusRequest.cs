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
    /// Container for the parameters to the UpdateDeviceStatus operation.
    /// Updates the status of a the currently signed-in user's device so that it is marked
    /// as remembered or not remembered for the purpose of device authentication. Device authentication
    /// is a "remember me" mechanism that silently completes sign-in from trusted devices
    /// with a device key instead of a user-provided MFA code. This operation changes the
    /// status of a device without deleting it, so you can enable it again later. For more
    /// information about device authentication, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-device-tracking.html">Working
    /// with devices</a>.
    /// 
    ///  
    /// <para>
    /// Authorize this action with a signed-in user's access token. It must include the scope
    /// <c>aws.cognito.signin.user.admin</c>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
    /// for this API operation. For this operation, you can't use IAM credentials to authorize
    /// requests, and you can't grant IAM permissions in policies. For more information about
    /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateDeviceStatusRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _accessToken;
        private string _deviceKey;
        private DeviceRememberedStatusType _deviceRememberedStatus;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// A valid access token that Amazon Cognito issued to the currently signed-in user. Must
        /// include a scope claim for <c>aws.cognito.signin.user.admin</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string AccessToken
        {
            get { return this._accessToken; }
            set { this._accessToken = value; }
        }

        // Check to see if AccessToken property is set
        internal bool IsSetAccessToken()
        {
            return this._accessToken != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceKey. 
        /// <para>
        /// The device key of the device you want to update, for example <c>us-west-2_a1b2c3d4-5678-90ab-cdef-EXAMPLE11111</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
        public string DeviceKey
        {
            get { return this._deviceKey; }
            set { this._deviceKey = value; }
        }

        // Check to see if DeviceKey property is set
        internal bool IsSetDeviceKey()
        {
            return this._deviceKey != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceRememberedStatus. 
        /// <para>
        /// To enable device authentication with the specified device, set to <c>remembered</c>.To
        /// disable, set to <c>not_remembered</c>.
        /// </para>
        /// </summary>
        public DeviceRememberedStatusType DeviceRememberedStatus
        {
            get { return this._deviceRememberedStatus; }
            set { this._deviceRememberedStatus = value; }
        }

        // Check to see if DeviceRememberedStatus property is set
        internal bool IsSetDeviceRememberedStatus()
        {
            return this._deviceRememberedStatus != null;
        }

    }
}