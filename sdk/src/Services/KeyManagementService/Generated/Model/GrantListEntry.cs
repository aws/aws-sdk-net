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
    /// Contains information about a grant.
    /// </summary>
    public partial class GrantListEntry
    {
        private GrantConstraints _constraints;
        private DateTime? _creationDate;
        private string _granteePrincipal;
        private string _grantId;
        private string _issuingAccount;
        private string _keyId;
        private string _name;
        private List<string> _operations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _retiringPrincipal;

        /// <summary>
        /// Gets and sets the property Constraints. 
        /// <para>
        /// A list of key-value pairs that must be present in the encryption context of certain
        /// subsequent operations that the grant allows.
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
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the grant was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GranteePrincipal. 
        /// <para>
        /// The identity that gets the permissions in the grant.
        /// </para>
        ///  
        /// <para>
        /// The <c>GranteePrincipal</c> field in the <c>ListGrants</c> response usually contains
        /// the user or role designated as the grantee principal in the grant. However, when the
        /// grantee principal in the grant is an Amazon Web Services service, the <c>GranteePrincipal</c>
        /// field contains the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_principal.html#principal-services">service
        /// principal</a>, which might represent several different grantee principals.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// The unique identifier for the grant.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// The Amazon Web Services account under which the grant was issued.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The unique identifier for the KMS key to which the grant applies.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// The friendly name that identifies the grant. If a name was provided in the <a>CreateGrant</a>
        /// request, that name is returned. Otherwise this value is null.
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
        /// The list of operations permitted by the grant.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// The principal that can retire the grant.
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