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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The time units that, with <c>IdTokenValidity</c>, <c>AccessTokenValidity</c>, and
    /// <c>RefreshTokenValidity</c>, set and display the duration of ID, access, and refresh
    /// tokens for an app client. You can assign a separate token validity unit to each type
    /// of token.
    /// </summary>
    public partial class TokenValidityUnitsType
    {
        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        ///  A time unit for the value that you set in the <c>AccessTokenValidity</c> parameter.
        /// The default <c>AccessTokenValidity</c> time unit is <c>hours</c>. <c>AccessTokenValidity</c>
        /// duration can range from five minutes to one day.
        /// </para>
        /// </summary>
        public TimeUnitsType AccessToken { get; set; }

        /// <summary>
        /// Checks to see if the AccessToken property is set.
        /// </summary>
        internal bool IsSetAccessToken() => this.AccessToken != null;

        /// <summary>
        /// Gets and sets the property IdToken. 
        /// <para>
        /// A time unit for the value that you set in the <c>IdTokenValidity</c> parameter. The
        /// default <c>IdTokenValidity</c> time unit is <c>hours</c>. <c>IdTokenValidity</c> duration
        /// can range from five minutes to one day.
        /// </para>
        /// </summary>
        public TimeUnitsType IdToken { get; set; }

        /// <summary>
        /// Checks to see if the IdToken property is set.
        /// </summary>
        internal bool IsSetIdToken() => this.IdToken != null;

        /// <summary>
        /// Gets and sets the property RefreshToken. 
        /// <para>
        /// A time unit for the value that you set in the <c>RefreshTokenValidity</c> parameter.
        /// The default <c>RefreshTokenValidity</c> time unit is <c>days</c>. <c>RefreshTokenValidity</c>
        /// duration can range from 60 minutes to 10 years.
        /// </para>
        /// </summary>
        public TimeUnitsType RefreshToken { get; set; }

        /// <summary>
        /// Checks to see if the RefreshToken property is set.
        /// </summary>
        internal bool IsSetRefreshToken() => this.RefreshToken != null;
    }
}
