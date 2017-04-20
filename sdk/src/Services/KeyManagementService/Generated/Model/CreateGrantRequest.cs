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
    /// Adds a grant to a key to specify who can use the key and under what conditions. Grants
    /// are alternate permission mechanisms to key policies.
    /// 
    ///  
    /// <para>
    /// For more information about grants, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Grants</a>
    /// in the <i>AWS Key Management Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateGrantRequest : AmazonKeyManagementServiceRequest
    {
        private GrantConstraints _constraints;
        private string _granteePrincipal;
        private List<string> _grantTokens = new List<string>();
        private string _keyId;
        private string _name;
        private List<string> _operations = new List<string>();
        private string _retiringPrincipal;

        /// <summary>
        /// Gets and sets the property Constraints. 
        /// <para>
        /// A structure that you can use to allow certain operations in the grant only when the
        /// desired encryption context is present. For more information about encryption context,
        /// see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/encryption-context.html">Encryption
        /// Context</a> in the <i>AWS Key Management Service Developer Guide</i>.
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
        /// The principal that is given permission to perform the operations that the grant permits.
        /// </para>
        ///  
        /// <para>
        /// To specify the principal, use the <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of an AWS principal. Valid AWS principals include AWS accounts
        /// (root), IAM users, federated users, and assumed role users. For examples of the ARN
        /// syntax to use for specifying a principal, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-iam">AWS
        /// Identity and Access Management (IAM)</a> in the Example ARNs section of the <i>AWS
        /// General Reference</i>.
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
        /// A list of grant tokens.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#grant_token">Grant
        /// Tokens</a> in the <i>AWS Key Management Service Developer Guide</i>.
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
        /// The unique identifier for the customer master key (CMK) that the grant applies to.
        /// </para>
        ///  
        /// <para>
        /// To specify this value, use the globally unique key ID or the Amazon Resource Name
        /// (ARN) of the key. Examples:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Globally unique key ID: 12345678-1234-1234-1234-123456789012
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: arn:aws:kms:us-west-2:123456789012:key/12345678-1234-1234-1234-123456789012
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name for identifying the grant. Use this value to prevent unintended creation
        /// of duplicate grants when retrying this request.
        /// </para>
        ///  
        /// <para>
        /// When this value is absent, all <code>CreateGrant</code> requests result in a new grant
        /// with a unique <code>GrantId</code> even if all the supplied parameters are identical.
        /// This can result in unintended duplicates when you retry the <code>CreateGrant</code>
        /// request.
        /// </para>
        ///  
        /// <para>
        /// When this value is present, you can retry a <code>CreateGrant</code> request with
        /// identical parameters; if the grant already exists, the original <code>GrantId</code>
        /// is returned without creating a new grant. Note that the returned grant token is unique
        /// with every <code>CreateGrant</code> request, even when a duplicate <code>GrantId</code>
        /// is returned. All grant tokens obtained in this way can be used interchangeably.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Operations. 
        /// <para>
        /// A list of operations that the grant permits.
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
        /// The principal that is given permission to retire the grant by using <a>RetireGrant</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// To specify the principal, use the <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of an AWS principal. Valid AWS principals include AWS accounts
        /// (root), IAM users, federated users, and assumed role users. For examples of the ARN
        /// syntax to use for specifying a principal, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-iam">AWS
        /// Identity and Access Management (IAM)</a> in the Example ARNs section of the <i>AWS
        /// General Reference</i>.
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