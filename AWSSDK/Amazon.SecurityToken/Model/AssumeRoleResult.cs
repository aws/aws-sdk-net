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
    /// <para>Contains the result of a successful invocation of the AssumeRole action.</para>
    /// </summary>
    public class AssumeRoleResult
    {
        
        private Credentials credentials;
        private AssumedRoleUser assumedRoleUser;
        private int? packedPolicySize;

        /// <summary>
        /// The temporary security credentials, which include an access key ID, a secret access key, and a security token.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AssumeRoleResult WithCredentials(Credentials credentials)
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
        /// The Amazon Resource Name (ARN) and the assumed role ID, which are identifiers that you can use to refer to the resulting temporary security
        /// credentials. For example, you can reference these credentials as a principal in a resource-based policy by using the ARN or assumed role ID.
        /// The ARN and ID include the <c>RoleSessionName</c> that you specified when you called <c>AssumeRole</c>.
        ///  
        /// </summary>
        public AssumedRoleUser AssumedRoleUser
        {
            get { return this.assumedRoleUser; }
            set { this.assumedRoleUser = value; }
        }

        /// <summary>
        /// Sets the AssumedRoleUser property
        /// </summary>
        /// <param name="assumedRoleUser">The value to set for the AssumedRoleUser property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AssumeRoleResult WithAssumedRoleUser(AssumedRoleUser assumedRoleUser)
        {
            this.assumedRoleUser = assumedRoleUser;
            return this;
        }
            

        // Check to see if AssumedRoleUser property is set
        internal bool IsSetAssumedRoleUser()
        {
            return this.assumedRoleUser != null;
        }

        /// <summary>
        /// A percentage value that indicates the size of the policy in packed form. The service rejects any policy with a packed size greater than 100
        /// percent, which means the policy exceeded the allowed space.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AssumeRoleResult WithPackedPolicySize(int packedPolicySize)
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
