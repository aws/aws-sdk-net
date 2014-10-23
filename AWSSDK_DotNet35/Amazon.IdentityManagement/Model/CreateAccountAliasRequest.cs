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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
    /// Creates an alias for your AWS account. For information about using an AWS account
    /// alias, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html">Using
    /// an Alias for Your AWS Account ID</a> in the <i>Using IAM</i> guide.
    /// </summary>
    public partial class CreateAccountAliasRequest : AmazonIdentityManagementServiceRequest
    {
        private string _accountAlias;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateAccountAliasRequest() { }

        /// <summary>
        /// Instantiates CreateAccountAliasRequest with the parameterized properties
        /// </summary>
        /// <param name="accountAlias">The name of the account alias to create.</param>
        public CreateAccountAliasRequest(string accountAlias)
        {
            _accountAlias = accountAlias;
        }

        /// <summary>
        /// Gets and sets the property AccountAlias. 
        /// <para>
        /// The name of the account alias to create.
        /// </para>
        /// </summary>
        public string AccountAlias
        {
            get { return this._accountAlias; }
            set { this._accountAlias = value; }
        }

        // Check to see if AccountAlias property is set
        internal bool IsSetAccountAlias()
        {
            return this._accountAlias != null;
        }

    }
}