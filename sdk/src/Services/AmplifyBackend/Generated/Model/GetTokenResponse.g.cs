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

namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// This is the response object from the GetToken operation.
    /// </summary>
    public partial class GetTokenResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The app ID.
        /// </para>
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// Checks to see if the AppId property is set.
        /// </summary>
        internal bool IsSetAppId() => this.AppId != null;

        /// <summary>
        /// Gets and sets the property ChallengeCode. 
        /// <para>
        /// The one-time challenge code for authenticating into the Amplify Admin UI.
        /// </para>
        /// </summary>
        public string ChallengeCode { get; set; }

        /// <summary>
        /// Checks to see if the ChallengeCode property is set.
        /// </summary>
        internal bool IsSetChallengeCode() => this.ChallengeCode != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// A unique ID provided when creating a new challenge token.
        /// </para>
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property Ttl. 
        /// <para>
        /// The expiry time for the one-time generated token code.
        /// </para>
        /// </summary>
        public string Ttl { get; set; }

        /// <summary>
        /// Checks to see if the Ttl property is set.
        /// </summary>
        internal bool IsSetTtl() => this.Ttl != null;
    }
}
