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
    /// Container for the parameters to the CreateAccountAlias operation.
    /// This action creates an alias for your AWS account. For information about using an
    /// AWS account            alias, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html"
    /// target="_blank">Using an Alias for Your AWS Account ID</a> in <i>Using AWS Identity
    /// and Access                Management</i>.
    /// </summary>
    public partial class CreateAccountAliasRequest : AmazonWebServiceRequest
    {
        private string _accountAlias;


        /// <summary>
        /// Gets and sets the property AccountAlias. 
        /// <para>
        /// Name of the account alias to create.
        /// </para>
        /// </summary>
        public string AccountAlias
        {
            get { return this._accountAlias; }
            set { this._accountAlias = value; }
        }


        /// <summary>
        /// Sets the AccountAlias property
        /// </summary>
        /// <param name="accountAlias">The value to set for the AccountAlias property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateAccountAliasRequest WithAccountAlias(string accountAlias)
        {
            this._accountAlias = accountAlias;
            return this;
        }

        // Check to see if AccountAlias property is set
        internal bool IsSetAccountAlias()
        {
            return this._accountAlias != null;
        }

    }
}