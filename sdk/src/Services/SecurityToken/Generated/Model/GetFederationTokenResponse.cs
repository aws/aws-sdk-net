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
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
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
namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Contains the response to a successful <a>GetFederationToken</a> request, including
    /// temporary Amazon Web Services credentials that can be used to make Amazon Web Services
    /// requests.
    /// </summary>
    public partial class GetFederationTokenResponse : AmazonWebServiceResponse
    {
        private Credentials _credentials;
        private FederatedUser _federatedUser;
        private int? _packedPolicySize;

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The temporary security credentials, which include an access key ID, a secret access
        /// key, and a security (or session) token.
        /// </para>
        ///  <note> 
        /// <para>
        /// The size of the security token that STS API operations return is not fixed. We strongly
        /// recommend that you make no assumptions about the maximum size.
        /// </para>
        ///  </note>
        /// </summary>
        public Credentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null;
        }

        /// <summary>
        /// Gets and sets the property FederatedUser. 
        /// <para>
        /// Identifiers for the federated user associated with the credentials (such as <c>arn:aws:sts::123456789012:federated-user/Bob</c>
        /// or <c>123456789012:Bob</c>). You can use the federated user's ARN in your resource-based
        /// policies, such as an Amazon S3 bucket policy. 
        /// </para>
        /// </summary>
        public FederatedUser FederatedUser
        {
            get { return this._federatedUser; }
            set { this._federatedUser = value; }
        }

        // Check to see if FederatedUser property is set
        internal bool IsSetFederatedUser()
        {
            return this._federatedUser != null;
        }

        /// <summary>
        /// Gets and sets the property PackedPolicySize. 
        /// <para>
        /// A percentage value that indicates the packed size of the session policies and session
        /// tags combined passed in the request. The request fails if the packed size is greater
        /// than 100 percent, which means the policies and tags exceeded the allowed space.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? PackedPolicySize
        {
            get { return this._packedPolicySize; }
            set { this._packedPolicySize = value; }
        }

        // Check to see if PackedPolicySize property is set
        internal bool IsSetPackedPolicySize()
        {
            return this._packedPolicySize.HasValue; 
        }

    }
}