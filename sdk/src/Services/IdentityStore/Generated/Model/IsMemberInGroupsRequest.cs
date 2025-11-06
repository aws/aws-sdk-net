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
 * Do not modify this file. This file is generated from the identitystore-2020-06-15.normal.json service model.
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
namespace Amazon.IdentityStore.Model
{
    /// <summary>
    /// Container for the parameters to the IsMemberInGroups operation.
    /// Checks the user's membership in all requested groups and returns if the member exists
    /// in all queried groups.
    /// 
    ///  <note> 
    /// <para>
    /// If you have access to a member account, you can use this API operation from the member
    /// account. For more information, see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/manage-your-accounts.html#limiting-access-from-member-accounts">Limiting
    /// access to the identity store from member accounts</a> in the <i> IAM Identity Center
    /// User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class IsMemberInGroupsRequest : AmazonIdentityStoreRequest
    {
        private List<string> _groupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _identityStoreId;
        private MemberId _memberId;

        /// <summary>
        /// Gets and sets the property GroupIds. 
        /// <para>
        /// A list of identifiers for groups in the identity store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> GroupIds
        {
            get { return this._groupIds; }
            set { this._groupIds = value; }
        }

        // Check to see if GroupIds property is set
        internal bool IsSetGroupIds()
        {
            return this._groupIds != null && (this._groupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IdentityStoreId. 
        /// <para>
        /// The globally unique identifier for the identity store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string IdentityStoreId
        {
            get { return this._identityStoreId; }
            set { this._identityStoreId = value; }
        }

        // Check to see if IdentityStoreId property is set
        internal bool IsSetIdentityStoreId()
        {
            return this._identityStoreId != null;
        }

        /// <summary>
        /// Gets and sets the property MemberId. 
        /// <para>
        /// An object containing the identifier of a group member.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MemberId MemberId
        {
            get { return this._memberId; }
            set { this._memberId = value; }
        }

        // Check to see if MemberId property is set
        internal bool IsSetMemberId()
        {
            return this._memberId != null;
        }

    }
}