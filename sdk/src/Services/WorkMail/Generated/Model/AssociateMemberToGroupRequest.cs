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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateMemberToGroup operation.
    /// Adds a member (user or group) to the group's set.
    /// </summary>
    public partial class AssociateMemberToGroupRequest : AmazonWorkMailRequest
    {
        private string _groupId;
        private string _memberId;
        private string _organizationId;

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The group to which the member (user or group) is associated.
        /// </para>
        ///  
        /// <para>
        /// The identifier can accept <i>GroupId</i>, <i>Groupname</i>, or <i>email</i>. The following
        /// identity formats are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Group ID: 12345678-1234-1234-1234-123456789012 or S-1-1-12-1234567890-123456789-123456789-1234
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Email address: group@domain.tld
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Group name: group
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property MemberId. 
        /// <para>
        /// The member (user or group) to associate to the group.
        /// </para>
        ///  
        /// <para>
        /// The member ID can accept <i>UserID or GroupId</i>, <i>Username or Groupname</i>, or
        /// <i>email</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Member: 12345678-1234-1234-1234-123456789012 or S-1-1-12-1234567890-123456789-123456789-1234
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Email address: member@domain.tld
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Member name: member
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string MemberId
        {
            get { return this._memberId; }
            set { this._memberId = value; }
        }

        // Check to see if MemberId property is set
        internal bool IsSetMemberId()
        {
            return this._memberId != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The organization under which the group exists.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=34, Max=34)]
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

    }
}