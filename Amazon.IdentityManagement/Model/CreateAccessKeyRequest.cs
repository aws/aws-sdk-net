/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAccessKey operation.
    /// <para>Creates a new AWS Secret Access Key and corresponding AWS Access
    /// Key ID for the specified user. The default status for new keys is
    /// Active.</para> <para>If the <c>UserName</c> field is not specified,
    /// the UserName is determined implicitly based on the AWS Access Key ID
    /// used to sign the request. Because this action works for access keys
    /// under the account, this API can be used to manage root credentials
    /// even if the account has no associated users.</para> <para>For
    /// information about limits on the number of keys you can create, see
    /// Limitations on AWS IAM Entities in the <a
    /// href="http://aws.amazon.com/documentation/"> AWS Identity and Access
    /// Management User Guide </a> .</para> <para><b>IMPORTANT:</b>To ensure
    /// the security of your account, the secret access key is accesible only
    /// during key and user creation. You must save the key (for example, in
    /// a text file) if you want to be able to access it again. If a secret
    /// key is lost, you can delete the access keys for the associated user
    /// and then create new keys.</para>
    /// </summary>
    /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.CreateAccessKey"/>
    public class CreateAccessKeyRequest : AmazonWebServiceRequest
    {
        private string userName;

        /// <summary>
        /// The user that the new key will belong to.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 128</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w+=,.@-]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }

        /// <summary>
        /// Sets the UserName property
        /// </summary>
        /// <param name="userName">The value to set for the UserName property </param>
        /// <returns>this instance</returns>
        public CreateAccessKeyRequest WithUserName(string userName)
        {
            this.userName = userName;
            return this;
        }
            
        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this.userName != null;       
        }
    }
}
    
