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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
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
namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGrant operation.
    /// Adds a grant to a KMS key. 
    /// 
    ///  
    /// <para>
    /// A <i>grant</i> is a policy instrument that allows Amazon Web Services principals to
    /// use KMS keys in cryptographic operations. It also can allow them to view a KMS key
    /// (<a>DescribeKey</a>) and create and manage grants. When authorizing access to a KMS
    /// key, grants are considered along with key policies and IAM policies. Grants are often
    /// used for temporary permissions because you can create one, use its permissions, and
    /// delete it without changing your key policies or IAM policies. 
    /// </para>
    ///  
    /// <para>
    /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Grants
    /// in KMS</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
    /// of creating grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/example_kms_CreateGrant_section.html">Use
    /// CreateGrant with an Amazon Web Services SDK or CLI</a>. 
    /// </para>
    ///  
    /// <para>
    /// The <c>CreateGrant</c> operation returns a <c>GrantToken</c> and a <c>GrantId</c>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// When you create, retire, or revoke a grant, there might be a brief delay, usually
    /// less than five minutes, until the grant is available throughout KMS. This state is
    /// known as <i>eventual consistency</i>. Once the grant has achieved eventual consistency,
    /// the grantee principal can use the permissions in the grant without identifying the
    /// grant. 
    /// </para>
    ///  
    /// <para>
    /// However, to use the permissions in the grant immediately, use the <c>GrantToken</c>
    /// that <c>CreateGrant</c> returns. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/using-grant-token.html">Using
    /// a grant token</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>CreateGrant</c> operation also returns a <c>GrantId</c>. You can use the <c>GrantId</c>
    /// and a key identifier to identify the grant in the <a>RetireGrant</a> and <a>RevokeGrant</a>
    /// operations. To find the grant ID, use the <a>ListGrants</a> or <a>ListRetirableGrants</a>
    /// operations.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The KMS key that you use for this operation must be in a compatible key state. For
    /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
    /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: Yes. To perform this operation on a KMS key in a different
    /// Amazon Web Services account, specify the key ARN in the value of the <c>KeyId</c>
    /// parameter. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateGrant</a>
    /// (key policy)
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListGrants</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListRetirableGrants</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>RetireGrant</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>RevokeGrant</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
    /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
    /// eventual consistency</a>.
    /// </para>
    /// </summary>
    public partial class CreateGrantRequest : AmazonKeyManagementServiceRequest
    {
        private GrantConstraints _constraints;
        private bool? _dryRun;
        private string _granteePrincipal;
        private List<string> _grantTokens = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _keyId;
        private string _name;
        private List<string> _operations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _retiringPrincipal;

        /// <summary>
        /// Gets and sets the property Constraints. 
        /// <para>
        /// Specifies a grant constraint.
        /// </para>
        ///  <important> 
        /// <para>
        /// Do not include confidential or sensitive information in this field. This field may
        /// be displayed in plaintext in CloudTrail logs and other output.
        /// </para>
        ///  </important> 
        /// <para>
        /// KMS supports the <c>EncryptionContextEquals</c> and <c>EncryptionContextSubset</c>
        /// grant constraints, which allow the permissions in the grant only when the encryption
        /// context in the request matches (<c>EncryptionContextEquals</c>) or includes (<c>EncryptionContextSubset</c>)
        /// the encryption context specified in the constraint. 
        /// </para>
        ///  
        /// <para>
        /// The encryption context grant constraints are supported only on <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#terms-grant-operations">grant
        /// operations</a> that include an <c>EncryptionContext</c> parameter, such as cryptographic
        /// operations on symmetric encryption KMS keys. Grants with grant constraints can include
        /// the <a>DescribeKey</a> and <a>RetireGrant</a> operations, but the constraint doesn't
        /// apply to these operations. If a grant with a grant constraint includes the <c>CreateGrant</c>
        /// operation, the constraint requires that any grants created with the <c>CreateGrant</c>
        /// permission have an equally strict or stricter encryption context constraint.
        /// </para>
        ///  
        /// <para>
        /// You cannot use an encryption context grant constraint for cryptographic operations
        /// with asymmetric KMS keys or HMAC KMS keys. Operations with these keys don't support
        /// an encryption context.
        /// </para>
        ///  
        /// <para>
        /// Each constraint value can include up to 8 encryption context pairs. The encryption
        /// context value in each constraint cannot exceed 384 characters. For information about
        /// grant constraints, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-grant-overview.html#grant-constraints">Using
        /// grant constraints</a> in the <i>Key Management Service Developer Guide</i>. For more
        /// information about encryption context, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
        /// context</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. 
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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks if your request will succeed. <c>DryRun</c> is an optional parameter. 
        /// </para>
        ///  
        /// <para>
        /// To learn more about how to use this parameter, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/testing-permissions.html">Testing
        /// your permissions</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GranteePrincipal. 
        /// <para>
        /// The identity that gets the permissions specified in the grant.
        /// </para>
        ///  
        /// <para>
        /// To specify the grantee principal, use the Amazon Resource Name (ARN) of an Amazon
        /// Web Services principal. Valid principals include Amazon Web Services accounts, IAM
        /// users, IAM roles, federated users, and assumed role users. For help with the ARN syntax
        /// for a principal, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html#identifiers-arns">IAM
        /// ARNs</a> in the <i> <i>Identity and Access Management User Guide</i> </i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Use a grant token when your permission to call this operation comes from a new grant
        /// that has not yet achieved <i>eventual consistency</i>. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#grant_token">Grant
        /// token</a> and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/using-grant-token.html">Using
        /// a grant token</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> GrantTokens
        {
            get { return this._grantTokens; }
            set { this._grantTokens = value; }
        }

        // Check to see if GrantTokens property is set
        internal bool IsSetGrantTokens()
        {
            return this._grantTokens != null && (this._grantTokens.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Identifies the KMS key for the grant. The grant gives principals permission to use
        /// this KMS key.
        /// </para>
        ///  
        /// <para>
        /// Specify the key ID or key ARN of the KMS key. To specify a KMS key in a different
        /// Amazon Web Services account, you must use the key ARN.
        /// </para>
        ///  
        /// <para>
        /// For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <c>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// A friendly name for the grant. Use this value to prevent the unintended creation of
        /// duplicate grants when retrying this request.
        /// </para>
        ///  <important> 
        /// <para>
        /// Do not include confidential or sensitive information in this field. This field may
        /// be displayed in plaintext in CloudTrail logs and other output.
        /// </para>
        ///  </important> 
        /// <para>
        /// When this value is absent, all <c>CreateGrant</c> requests result in a new grant with
        /// a unique <c>GrantId</c> even if all the supplied parameters are identical. This can
        /// result in unintended duplicates when you retry the <c>CreateGrant</c> request.
        /// </para>
        ///  
        /// <para>
        /// When this value is present, you can retry a <c>CreateGrant</c> request with identical
        /// parameters; if the grant already exists, the original <c>GrantId</c> is returned without
        /// creating a new grant. Note that the returned grant token is unique with every <c>CreateGrant</c>
        /// request, even when a duplicate <c>GrantId</c> is returned. All grant tokens for the
        /// same grant ID can be used interchangeably.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        ///  
        /// <para>
        /// This list must include only operations that are permitted in a grant. Also, the operation
        /// must be supported on the KMS key. For example, you cannot create a grant for a symmetric
        /// encryption KMS key that allows the <a>Sign</a> operation, or a grant for an asymmetric
        /// KMS key that allows the <a>GenerateDataKey</a> operation. If you try, KMS returns
        /// a <c>ValidationError</c> exception. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#terms-grant-operations">Grant
        /// operations</a> in the <i>Key Management Service Developer Guide</i>.
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
        /// The principal that has permission to use the <a>RetireGrant</a> operation to retire
        /// the grant. 
        /// </para>
        ///  
        /// <para>
        /// To specify the principal, use the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of an Amazon Web Services principal. Valid principals include
        /// Amazon Web Services accounts, IAM users, IAM roles, federated users, and assumed role
        /// users. For help with the ARN syntax for a principal, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html#identifiers-arns">IAM
        /// ARNs</a> in the <i> <i>Identity and Access Management User Guide</i> </i>.
        /// </para>
        ///  
        /// <para>
        /// The grant determines the retiring principal. Other principals might have permission
        /// to retire the grant or revoke the grant. For details, see <a>RevokeGrant</a> and <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/grant-delete.html">Retiring
        /// and revoking grants</a> in the <i>Key Management Service Developer Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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