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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// A proposed grant configuration for a KMS key. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_CreateGrant.html">CreateGrant</a>.
    /// </summary>
    public partial class KmsGrantConfiguration
    {
        private KmsGrantConstraints _constraints;
        private string _granteePrincipal;
        private string _issuingAccount;
        private List<string> _operations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _retiringPrincipal;

        /// <summary>
        /// Gets and sets the property Constraints. 
        /// <para>
        /// Use this structure to propose allowing <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
        /// operations</a> in the grant only when the operation request includes the specified
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">encryption
        /// context</a>.
        /// </para>
        /// </summary>
        public KmsGrantConstraints Constraints
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
        /// The principal that is given permission to perform the operations that the grant permits.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property IssuingAccount. 
        /// <para>
        ///  The Amazon Web Services account under which the grant was issued. The account is
        /// used to propose KMS grants issued by accounts other than the owner of the key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A list of operations that the grant permits.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Operations
        {
            get { return this._operations; }
            set { this._operations = value; }
        }

        // Check to see if Operations property is set
        internal bool IsSetOperations()
        {
            return this._operations != null && (this._operations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RetiringPrincipal. 
        /// <para>
        /// The principal that is given permission to retire the grant by using <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_RetireGrant.html">RetireGrant</a>
        /// operation.
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