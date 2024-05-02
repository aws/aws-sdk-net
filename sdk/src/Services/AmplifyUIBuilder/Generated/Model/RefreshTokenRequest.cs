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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
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
namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Container for the parameters to the RefreshToken operation.
    /// <note> 
    /// <para>
    /// This is for internal use.
    /// </para>
    ///  </note> 
    /// <para>
    /// Amplify uses this action to refresh a previously issued access token that might have
    /// expired.
    /// </para>
    /// </summary>
    public partial class RefreshTokenRequest : AmazonAmplifyUIBuilderRequest
    {
        private TokenProviders _provider;
        private RefreshTokenRequestBody _refreshTokenBody;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The third-party provider for the token. The only valid value is <c>figma</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TokenProviders Provider
        {
            get { return this._provider; }
            set { this._provider = value; }
        }

        // Check to see if Provider property is set
        internal bool IsSetProvider()
        {
            return this._provider != null;
        }

        /// <summary>
        /// Gets and sets the property RefreshTokenBody. 
        /// <para>
        /// Information about the refresh token request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RefreshTokenRequestBody RefreshTokenBody
        {
            get { return this._refreshTokenBody; }
            set { this._refreshTokenBody = value; }
        }

        // Check to see if RefreshTokenBody property is set
        internal bool IsSetRefreshTokenBody()
        {
            return this._refreshTokenBody != null;
        }

    }
}