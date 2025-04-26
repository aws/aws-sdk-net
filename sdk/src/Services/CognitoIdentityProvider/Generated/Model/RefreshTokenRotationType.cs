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
    /// The configuration of your app client for refresh token rotation. When enabled, your
    /// app client issues new ID, access, and refresh tokens when users renew their sessions
    /// with refresh tokens. When disabled, token refresh issues only ID and access tokens.
    /// </summary>
    public partial class RefreshTokenRotationType
    {
        private FeatureType _feature;
        private int? _retryGracePeriodSeconds;

        /// <summary>
        /// Gets and sets the property Feature. 
        /// <para>
        /// The state of refresh token rotation for the current app client.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FeatureType Feature
        {
            get { return this._feature; }
            set { this._feature = value; }
        }

        // Check to see if Feature property is set
        internal bool IsSetFeature()
        {
            return this._feature != null;
        }

        /// <summary>
        /// Gets and sets the property RetryGracePeriodSeconds. 
        /// <para>
        /// When you request a token refresh with <c>GetTokensFromRefreshToken</c>, the original
        /// refresh token that you're rotating out can remain valid for a period of time of up
        /// to 60 seconds. This allows for client-side retries. When <c>RetryGracePeriodSeconds</c>
        /// is <c>0</c>, the grace period is disabled and a successful request immediately invalidates
        /// the submitted refresh token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=60)]
        public int? RetryGracePeriodSeconds
        {
            get { return this._retryGracePeriodSeconds; }
            set { this._retryGracePeriodSeconds = value; }
        }

        // Check to see if RetryGracePeriodSeconds property is set
        internal bool IsSetRetryGracePeriodSeconds()
        {
            return this._retryGracePeriodSeconds.HasValue; 
        }

    }
}