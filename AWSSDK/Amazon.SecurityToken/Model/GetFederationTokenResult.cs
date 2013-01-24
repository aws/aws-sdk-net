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

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// <para>Contains the result of a successful invocation of the GetFederationToken action.</para>
    /// </summary>
    public class GetFederationTokenResult  
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

        /// <summary>
        /// Sets the Credentials property
        /// </summary>
        /// <param name="credentials">The value to set for the Credentials property </param>
        /// <returns>this instance</returns>
        public GetFederationTokenResult WithCredentials(Credentials credentials)
        {
            this.credentials = credentials;
            return this;
        }
            

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this.credentials != null;       
        }

        /// <summary>
        /// Identifiers for the federated user associated with the credentials. You can use the federated user's ARN in your resource policies.
        ///  
        /// </summary>
        public FederatedUser FederatedUser
        {
            get { return this.federatedUser; }
            set { this.federatedUser = value; }
        }

        /// <summary>
        /// Sets the FederatedUser property
        /// </summary>
        /// <param name="federatedUser">The value to set for the FederatedUser property </param>
        /// <returns>this instance</returns>
        public GetFederationTokenResult WithFederatedUser(FederatedUser federatedUser)
        {
            this.federatedUser = federatedUser;
            return this;
        }
            

        // Check to see if FederatedUser property is set
        internal bool IsSetFederatedUser()
        {
            return this.federatedUser != null;       
        }

        /// <summary>
        /// A percentage value indicating the size of the policy in packed form. Policies for which the packed size is greater than 100% of the allowed
        /// value are rejected by the service.
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

        /// <summary>
        /// Sets the PackedPolicySize property
        /// </summary>
        /// <param name="packedPolicySize">The value to set for the PackedPolicySize property </param>
        /// <returns>this instance</returns>
        public GetFederationTokenResult WithPackedPolicySize(int packedPolicySize)
        {
            this.packedPolicySize = packedPolicySize;
            return this;
        }
            

        // Check to see if PackedPolicySize property is set
        internal bool IsSetPackedPolicySize()
        {
            return this.packedPolicySize.HasValue;       
        }
    }
}
