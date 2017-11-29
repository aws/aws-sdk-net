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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The challenge response type.
    /// </summary>
    public partial class ChallengeResponseType
    {
        private ChallengeName _challengeName;
        private ChallengeResponse _challengeResponse;

        /// <summary>
        /// Gets and sets the property ChallengeName. 
        /// <para>
        /// The challenge name
        /// </para>
        /// </summary>
        public ChallengeName ChallengeName
        {
            get { return this._challengeName; }
            set { this._challengeName = value; }
        }

        // Check to see if ChallengeName property is set
        internal bool IsSetChallengeName()
        {
            return this._challengeName != null;
        }

        /// <summary>
        /// Gets and sets the property ChallengeResponse. 
        /// <para>
        /// The challenge response.
        /// </para>
        /// </summary>
        public ChallengeResponse ChallengeResponse
        {
            get { return this._challengeResponse; }
            set { this._challengeResponse = value; }
        }

        // Check to see if ChallengeResponse property is set
        internal bool IsSetChallengeResponse()
        {
            return this._challengeResponse != null;
        }

    }
}