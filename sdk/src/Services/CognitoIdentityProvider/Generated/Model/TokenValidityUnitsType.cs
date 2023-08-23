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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The data type TokenValidityUnits specifies the time units you use when you set the
    /// duration of ID, access, and refresh tokens.
    /// </summary>
    public partial class TokenValidityUnitsType
    {
        private TimeUnitsType _accessToken;
        private TimeUnitsType _idToken;
        private TimeUnitsType _refreshToken;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        ///  A time unit of <code>seconds</code>, <code>minutes</code>, <code>hours</code>, or
        /// <code>days</code> for the value that you set in the <code>AccessTokenValidity</code>
        /// parameter. The default <code>AccessTokenValidity</code> time unit is hours. <code>AccessTokenValidity</code>
        /// duration can range from five minutes to one day.
        /// </para>
        /// </summary>
        public TimeUnitsType AccessToken
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
        /// Gets and sets the property IdToken. 
        /// <para>
        /// A time unit of <code>seconds</code>, <code>minutes</code>, <code>hours</code>, or
        /// <code>days</code> for the value that you set in the <code>IdTokenValidity</code> parameter.
        /// The default <code>IdTokenValidity</code> time unit is hours. <code>IdTokenValidity</code>
        /// duration can range from five minutes to one day.
        /// </para>
        /// </summary>
        public TimeUnitsType IdToken
        {
            get { return this._idToken; }
            set { this._idToken = value; }
        }

        // Check to see if IdToken property is set
        internal bool IsSetIdToken()
        {
            return this._idToken != null;
        }

        /// <summary>
        /// Gets and sets the property RefreshToken. 
        /// <para>
        /// A time unit of <code>seconds</code>, <code>minutes</code>, <code>hours</code>, or
        /// <code>days</code> for the value that you set in the <code>RefreshTokenValidity</code>
        /// parameter. The default <code>RefreshTokenValidity</code> time unit is days. <code>RefreshTokenValidity</code>
        /// duration can range from 60 minutes to 10 years.
        /// </para>
        /// </summary>
        public TimeUnitsType RefreshToken
        {
            get { return this._refreshToken; }
            set { this._refreshToken = value; }
        }

        // Check to see if RefreshToken property is set
        internal bool IsSetRefreshToken()
        {
            return this._refreshToken != null;
        }

    }
}