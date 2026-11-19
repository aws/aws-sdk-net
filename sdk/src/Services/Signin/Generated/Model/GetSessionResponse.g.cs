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

namespace Amazon.Signin.Model
{
    /// <summary>
    /// This is the response object from the GetSession operation.
    /// </summary>
    public partial class GetSessionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ClientId. The OAuth client that created the session
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property ClientType. The type of OAuth client that created the session
        /// </summary>
        public ClientType ClientType { get; set; }

        /// <summary>
        /// Checks to see if the ClientType property is set.
        /// </summary>
        internal bool IsSetClientType() => this.ClientType != null;

        /// <summary>
        /// Gets and sets the property ExpiresAt. The time the session expires, in Unix epoch
        /// seconds
        /// </summary>
        [AWSProperty(Required = true)]
        public long? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property IssuedAt. The time the session was created, in Unix epoch
        /// seconds
        /// </summary>
        [AWSProperty(Required = true)]
        public long? IssuedAt { get; set; }

        /// <summary>
        /// Checks to see if the IssuedAt property is set.
        /// </summary>
        internal bool IsSetIssuedAt() => this.IssuedAt.HasValue;

        /// <summary>
        /// Gets and sets the property IssuedInRegion. The AWS Region where the session was created
        /// </summary>
        public string IssuedInRegion { get; set; }

        /// <summary>
        /// Checks to see if the IssuedInRegion property is set.
        /// </summary>
        internal bool IsSetIssuedInRegion() => this.IssuedInRegion != null;

        /// <summary>
        /// Gets and sets the property LastUsedAt. The time the session was last refreshed, in
        /// Unix epoch seconds
        /// </summary>
        public long? LastUsedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUsedAt property is set.
        /// </summary>
        internal bool IsSetLastUsedAt() => this.LastUsedAt.HasValue;

        /// <summary>
        /// Gets and sets the property OriginSessionArn. The ARN of the session this session originated
        /// from
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string OriginSessionArn { get; set; }

        /// <summary>
        /// Checks to see if the OriginSessionArn property is set.
        /// </summary>
        internal bool IsSetOriginSessionArn() => this.OriginSessionArn != null;

        /// <summary>
        /// Gets and sets the property PrincipalArn. The IAM identity that owns the session
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string PrincipalArn { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalArn property is set.
        /// </summary>
        internal bool IsSetPrincipalArn() => this.PrincipalArn != null;

        /// <summary>
        /// Gets and sets the property Resource. The resource that the session's tokens are bound
        /// to
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;

        /// <summary>
        /// Gets and sets the property Role. The IAM role for the session, when the owner is a
        /// role
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property SessionArn. The session ARN
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string SessionArn { get; set; }

        /// <summary>
        /// Checks to see if the SessionArn property is set.
        /// </summary>
        internal bool IsSetSessionArn() => this.SessionArn != null;

        /// <summary>
        /// Gets and sets the property Status. The session status
        /// </summary>
        public SessionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UserAgent. The user agent captured when the session was
        /// created or last refreshed
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// Checks to see if the UserAgent property is set.
        /// </summary>
        internal bool IsSetUserAgent() => this.UserAgent != null;
    }
}
