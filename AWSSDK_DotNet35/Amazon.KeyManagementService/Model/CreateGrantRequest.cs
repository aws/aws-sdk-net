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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGrant operation.
    /// Adds a grant to a key to specify who can access the key and under what conditions.
    /// Grants are alternate permission mechanisms to key policies. If absent, access to the
    /// key is evaluated based on IAM policies attached to the user. By default, grants do
    /// not expire. Grants can be listed, retired, or revoked as indicated by the following
    /// APIs. Typically, when you are finished using a grant, you retire it. When you want
    /// to end a grant immediately, revoke it. For more information about grants, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Grants</a>.
    /// <ol> <li><a>ListGrants</a></li> <li><a>RetireGrant</a></li> <li><a>RevokeGrant</a></li>
    /// </ol>
    /// </summary>
    public partial class CreateGrantRequest : AmazonKeyManagementServiceRequest
    {
        private GrantConstraints _constraints;
        private string _granteePrincipal;
        private List<string> _grantTokens = new List<string>();
        private string _keyId;
        private List<string> _operations = new List<string>();
        private string _retiringPrincipal;

        /// <summary>
        /// Gets and sets the property Constraints. 
        /// <para>
        /// Specifies the conditions under which the actions specified by the <code>Operations</code>
        /// parameter are allowed. 
        /// </para>
        /// </summary>
        public GrantConstraints Constraints
        {
            get { return this._constraints; }
            set { this._constraints = value; }
        }

        // Check to see if Constraints property is set
        internal bool IsSetConstraints()
        {
            return this._constraints != null;
        }

        /// <summary>
        /// Gets and sets the property GranteePrincipal. 
        /// <para>
        /// Principal given permission by the grant to use the key identified by the <code>keyId</code>
        /// parameter.
        /// </para>
        /// </summary>
        public string GranteePrincipal
        {
            get { return this._granteePrincipal; }
            set { this._granteePrincipal = value; }
        }

        // Check to see if GranteePrincipal property is set
        internal bool IsSetGranteePrincipal()
        {
            return this._granteePrincipal != null;
        }

        /// <summary>
        /// Gets and sets the property GrantTokens. 
        /// <para>
        /// List of grant tokens.
        /// </para>
        /// </summary>
        public List<string> GrantTokens
        {
            get { return this._grantTokens; }
            set { this._grantTokens = value; }
        }

        // Check to see if GrantTokens property is set
        internal bool IsSetGrantTokens()
        {
            return this._grantTokens != null && this._grantTokens.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// A unique key identifier for a customer master key. This value can be a globally unique
        /// identifier, an ARN, or an alias. 
        /// </para>
        /// </summary>
        public string KeyId
        {
            get { return this._keyId; }
            set { this._keyId = value; }
        }

        // Check to see if KeyId property is set
        internal bool IsSetKeyId()
        {
            return this._keyId != null;
        }

        /// <summary>
        /// Gets and sets the property Operations. 
        /// <para>
        /// List of operations permitted by the grant. This can be any combination of one or more
        /// of the following values: <ol> <li>Decrypt</li> <li>Encrypt</li> <li>GenerateDataKey</li>
        /// <li>GenerateDataKeyWithoutPlaintext</li> <li>ReEncryptFrom</li> <li>ReEncryptTo</li>
        /// <li>CreateGrant</li> </ol> 
        /// </para>
        /// </summary>
        public List<string> Operations
        {
            get { return this._operations; }
            set { this._operations = value; }
        }

        // Check to see if Operations property is set
        internal bool IsSetOperations()
        {
            return this._operations != null && this._operations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RetiringPrincipal. 
        /// <para>
        /// Principal given permission to retire the grant. For more information, see <a>RetireGrant</a>.
        /// </para>
        /// </summary>
        public string RetiringPrincipal
        {
            get { return this._retiringPrincipal; }
            set { this._retiringPrincipal = value; }
        }

        // Check to see if RetiringPrincipal property is set
        internal bool IsSetRetiringPrincipal()
        {
            return this._retiringPrincipal != null;
        }

    }
}