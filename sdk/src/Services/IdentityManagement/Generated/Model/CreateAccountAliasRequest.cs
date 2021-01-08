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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAccountAlias operation.
    /// Creates an alias for your AWS account. For information about using an AWS account
    /// alias, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html">Using
    /// an Alias for Your AWS Account ID</a> in the <i>IAM User Guide</i>.
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
        /// <param name="accountAlias">The account alias to create. This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>) a string of characters consisting of lowercase letters, digits, and dashes. You cannot start or finish with a dash, nor can you have two dashes in a row.</param>
        public CreateAccountAliasRequest(string accountAlias)
        {
            _accountAlias = accountAlias;
        }

        /// <summary>
        /// Gets and sets the property AccountAlias. 
        /// <para>
        /// The account alias to create.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of lowercase letters, digits, and dashes.
        /// You cannot start or finish with a dash, nor can you have two dashes in a row.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
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