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
    /// The device-remembering configuration for a user pool. A <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html">
    /// DescribeUserPool</a> request returns a null value for this object when the user pool
    /// isn't configured to remember devices. When device remembering is active, you can remember
    /// a user's device with a <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_ConfirmDevice.html">ConfirmDevice</a>
    /// API request. Additionally. when the property <c>DeviceOnlyRememberedOnUserPrompt</c>
    /// is <c>true</c>, you must follow <c>ConfirmDevice</c> with an <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateDeviceStatus.html">UpdateDeviceStatus</a>
    /// API request that sets the user's device to <c>remembered</c> or <c>not_remembered</c>.
    /// 
    ///  
    /// <para>
    /// To sign in with a remembered device, include <c>DEVICE_KEY</c> in the authentication
    /// parameters in your user's <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_InitiateAuth.html">
    /// InitiateAuth</a> request. If your app doesn't include a <c>DEVICE_KEY</c> parameter,
    /// the <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_InitiateAuth.html#API_InitiateAuth_ResponseSyntax">response</a>
    /// from Amazon Cognito includes newly-generated <c>DEVICE_KEY</c> and <c>DEVICE_GROUP_KEY</c>
    /// values under <c>NewDeviceMetadata</c>. Store these values to use in future device-authentication
    /// requests.
    /// </para>
    ///  <note> 
    /// <para>
    /// When you provide a value for any property of <c>DeviceConfiguration</c>, you activate
    /// the device remembering for the user pool.
    /// </para>
    ///  
    /// <para>
    /// This data type is a request and response parameter of <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateUserPool.html">CreateUserPool</a>
    /// and <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateUserPool.html">UpdateUserPool</a>,
    /// and a response parameter of <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html">DescribeUserPool</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeviceConfigurationType
    {
        private bool? _challengeRequiredOnNewDevice;
        private bool? _deviceOnlyRememberedOnUserPrompt;

        /// <summary>
        /// Gets and sets the property ChallengeRequiredOnNewDevice. 
        /// <para>
        /// When true, a remembered device can sign in with device authentication instead of SMS
        /// and time-based one-time password (TOTP) factors for multi-factor authentication (MFA).
        /// </para>
        ///  <note> 
        /// <para>
        /// Whether or not <c>ChallengeRequiredOnNewDevice</c> is true, users who sign in with
        /// devices that have not been confirmed or remembered must still provide a second factor
        /// in a user pool that requires MFA.
        /// </para>
        ///  </note>
        /// </summary>
        public bool ChallengeRequiredOnNewDevice
        {
            get { return this._challengeRequiredOnNewDevice.GetValueOrDefault(); }
            set { this._challengeRequiredOnNewDevice = value; }
        }

        // Check to see if ChallengeRequiredOnNewDevice property is set
        internal bool IsSetChallengeRequiredOnNewDevice()
        {
            return this._challengeRequiredOnNewDevice.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeviceOnlyRememberedOnUserPrompt. 
        /// <para>
        /// When true, Amazon Cognito doesn't automatically remember a user's device when your
        /// app sends a <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_ConfirmDevice.html">
        /// ConfirmDevice</a> API request. In your app, create a prompt for your user to choose
        /// whether they want to remember their device. Return the user's choice in an <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateDeviceStatus.html">
        /// UpdateDeviceStatus</a> API request.
        /// </para>
        ///  
        /// <para>
        /// When <c>DeviceOnlyRememberedOnUserPrompt</c> is <c>false</c>, Amazon Cognito immediately
        /// remembers devices that you register in a <c>ConfirmDevice</c> API request.
        /// </para>
        /// </summary>
        public bool DeviceOnlyRememberedOnUserPrompt
        {
            get { return this._deviceOnlyRememberedOnUserPrompt.GetValueOrDefault(); }
            set { this._deviceOnlyRememberedOnUserPrompt = value; }
        }

        // Check to see if DeviceOnlyRememberedOnUserPrompt property is set
        internal bool IsSetDeviceOnlyRememberedOnUserPrompt()
        {
            return this._deviceOnlyRememberedOnUserPrompt.HasValue; 
        }

    }
}