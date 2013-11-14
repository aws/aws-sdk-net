/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// <para> Contains the result of a successful call to the GetFederationToken action, including temporary AWS credentials that can be used to
    /// make AWS requests. </para>
    /// </summary>
    public partial class GetFederationTokenResult : AmazonWebServiceResponse
    {
        
        private Credentials credentials;
        private FederatedUser federatedUser;
        private int? packedPolicySize;


        /// <summary>
        /// Credentials for the service API authentication.
        ///  
        /// </summary>
        public Credentials Credentials
        {
            get { return this.credentials; }
            set { this.credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this.credentials != null;
        }

        /// <summary>
        /// Identifiers for the federated user associated with the credentials (such as <c>arn:aws:sts::123456789012:federated-user/Bob</c> or
        /// <c>123456789012:Bob</c>). You can use the federated user's ARN in your resource policies like in an Amazon S3 bucket policy.
        ///  
        /// </summary>
        public FederatedUser FederatedUser
        {
            get { return this.federatedUser; }
            set { this.federatedUser = value; }
        }

        // Check to see if FederatedUser property is set
        internal bool IsSetFederatedUser()
        {
            return this.federatedUser != null;
        }

        /// <summary>
        /// A percentage value indicating the size of the policy in packed form. The service rejects policies for which the packed size is greater than
        /// 100 percent of the allowed value.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>0 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int PackedPolicySize
        {
            get { return this.packedPolicySize ?? default(int); }
            set { this.packedPolicySize = value; }
        }

        // Check to see if PackedPolicySize property is set
        internal bool IsSetPackedPolicySize()
        {
            return this.packedPolicySize.HasValue;
        }
    }
}
