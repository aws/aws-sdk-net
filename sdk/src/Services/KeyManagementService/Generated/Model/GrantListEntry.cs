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
    /// Contains information about each entry in the grant list.
    /// </summary>
    public partial class GrantListEntry
    {
        private GrantConstraints _constraints;
        private string _granteePrincipal;
        private string _grantId;
        private string _issuingAccount;
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
        /// The principal that receives the grant permission.
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
        /// Gets and sets the property GrantId. 
        /// <para>
        /// Unique grant identifier.
        /// </para>
        /// </summary>
        public string GrantId
        {
            get { return this._grantId; }
            set { this._grantId = value; }
        }

        // Check to see if GrantId property is set
        internal bool IsSetGrantId()
        {
            return this._grantId != null;
        }

        /// <summary>
        /// Gets and sets the property IssuingAccount. 
        /// <para>
        /// The account under which the grant was issued.
        /// </para>
        /// </summary>
        public string IssuingAccount
        {
            get { return this._issuingAccount; }
            set { this._issuingAccount = value; }
        }

        // Check to see if IssuingAccount property is set
        internal bool IsSetIssuingAccount()
        {
            return this._issuingAccount != null;
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
        /// The principal that can retire the account.
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