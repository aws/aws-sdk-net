/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// The data type for TokenValidityUnits that specifics the time measurements for token
    /// validity.
    /// </summary>
    public partial class TokenValidityUnitsType
    {
        private TimeUnitsType _accessToken;
        private TimeUnitsType _idToken;
        private TimeUnitsType _refreshToken;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        ///  A time unit in “seconds”, “minutes”, “hours” or “days” for the value in AccessTokenValidity,
        /// defaults to hours.
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
        /// A time unit in “seconds”, “minutes”, “hours” or “days” for the value in IdTokenValidity,
        /// defaults to hours.
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
        /// A time unit in “seconds”, “minutes”, “hours” or “days” for the value in RefreshTokenValidity,
        /// defaults to days.
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