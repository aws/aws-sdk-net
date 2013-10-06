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
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAccountAlias operation.
    /// <para>Deletes the specified AWS account alias. For information about using an AWS account alias, see Using an Alias for Your AWS Account ID
    /// in <i>Using AWS Identity and Access Management</i> .</para>
    /// </summary>
    /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteAccountAlias"/>
    public class DeleteAccountAliasRequest : AmazonWebServiceRequest
    {
        private string accountAlias;

        /// <summary>
        /// Name of the account alias to delete.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>3 - 63</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^[a-z0-9](([a-z0-9]|-(?!-))*[a-z0-9])?$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AccountAlias
        {
            get { return this.accountAlias; }
            set { this.accountAlias = value; }
        }

        /// <summary>
        /// Sets the AccountAlias property
        /// </summary>
        /// <param name="accountAlias">The value to set for the AccountAlias property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteAccountAliasRequest WithAccountAlias(string accountAlias)
        {
            this.accountAlias = accountAlias;
            return this;
        }
            

        // Check to see if AccountAlias property is set
        internal bool IsSetAccountAlias()
        {
            return this.accountAlias != null;       
        }
    }
}
    
