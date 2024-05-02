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
 * Do not modify this file. This file is generated from the sso-oidc-2019-06-10.normal.json service model.
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
namespace Amazon.SSOOIDC.Model
{
    /// <summary>
    /// This is the response object from the StartDeviceAuthorization operation.
    /// </summary>
    public partial class StartDeviceAuthorizationResponse : AmazonWebServiceResponse
    {
        private string _deviceCode;
        private int? _expiresIn;
        private int? _interval;
        private string _userCode;
        private string _verificationUri;
        private string _verificationUriComplete;

        /// <summary>
        /// Gets and sets the property DeviceCode. 
        /// <para>
        /// The short-lived code that is used by the device when polling for a session token.
        /// </para>
        /// </summary>
        public string DeviceCode
        {
            get { return this._deviceCode; }
            set { this._deviceCode = value; }
        }

        // Check to see if DeviceCode property is set
        internal bool IsSetDeviceCode()
        {
            return this._deviceCode != null;
        }

        /// <summary>
        /// Gets and sets the property ExpiresIn. 
        /// <para>
        /// Indicates the number of seconds in which the verification code will become invalid.
        /// </para>
        /// </summary>
        public int? ExpiresIn
        {
            get { return this._expiresIn; }
            set { this._expiresIn = value; }
        }

        // Check to see if ExpiresIn property is set
        internal bool IsSetExpiresIn()
        {
            return this._expiresIn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// Indicates the number of seconds the client must wait between attempts when polling
        /// for a session.
        /// </para>
        /// </summary>
        public int? Interval
        {
            get { return this._interval; }
            set { this._interval = value; }
        }

        // Check to see if Interval property is set
        internal bool IsSetInterval()
        {
            return this._interval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserCode. 
        /// <para>
        /// A one-time user verification code. This is needed to authorize an in-use device.
        /// </para>
        /// </summary>
        public string UserCode
        {
            get { return this._userCode; }
            set { this._userCode = value; }
        }

        // Check to see if UserCode property is set
        internal bool IsSetUserCode()
        {
            return this._userCode != null;
        }

        /// <summary>
        /// Gets and sets the property VerificationUri. 
        /// <para>
        /// The URI of the verification page that takes the <c>userCode</c> to authorize the device.
        /// </para>
        /// </summary>
        public string VerificationUri
        {
            get { return this._verificationUri; }
            set { this._verificationUri = value; }
        }

        // Check to see if VerificationUri property is set
        internal bool IsSetVerificationUri()
        {
            return this._verificationUri != null;
        }

        /// <summary>
        /// Gets and sets the property VerificationUriComplete. 
        /// <para>
        /// An alternate URL that the client can use to automatically launch a browser. This process
        /// skips the manual step in which the user visits the verification page and enters their
        /// code.
        /// </para>
        /// </summary>
        public string VerificationUriComplete
        {
            get { return this._verificationUriComplete; }
            set { this._verificationUriComplete = value; }
        }

        // Check to see if VerificationUriComplete property is set
        internal bool IsSetVerificationUriComplete()
        {
            return this._verificationUriComplete != null;
        }

    }
}