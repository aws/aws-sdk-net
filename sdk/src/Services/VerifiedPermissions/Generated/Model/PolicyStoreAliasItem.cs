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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
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
namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Contains information about a policy store alias.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response parameter for the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_ListPolicyStoreAliases.html">ListPolicyStoreAliases</a>
    /// operation.
    /// </para>
    /// </summary>
    public partial class PolicyStoreAliasItem
    {
        private string _aliasArn;
        private string _aliasName;
        private DateTime? _createdAt;
        private string _policyStoreId;
        private AliasState _state;

        /// <summary>
        /// Gets and sets the property AliasArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the policy store alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2500)]
        public string AliasArn
        {
            get { return this._aliasArn; }
            set { this._aliasArn = value; }
        }

        // Check to see if AliasArn property is set
        internal bool IsSetAliasArn()
        {
            return this._aliasArn != null;
        }

        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// The name of the policy store alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=150)]
        public string AliasName
        {
            get { return this._aliasName; }
            set { this._aliasName = value; }
        }

        // Check to see if AliasName property is set
        internal bool IsSetAliasName()
        {
            return this._aliasName != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the policy store alias was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyStoreId. 
        /// <para>
        /// The ID of the policy store associated with the alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string PolicyStoreId
        {
            get { return this._policyStoreId; }
            set { this._policyStoreId = value; }
        }

        // Check to see if PolicyStoreId property is set
        internal bool IsSetPolicyStoreId()
        {
            return this._policyStoreId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the policy store alias. Policy Store Aliases in the Active state can
        /// be used normally. When a policy store alias is deleted, it enters the PendingDeletion
        /// state. Policy Store Aliases in the PendingDeletion state cannot be used, and creating
        /// a policy store alias with the same alias name will fail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AliasState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}