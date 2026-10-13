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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the PutMailboxPermissions operation. Sets permissions
    /// for a user, group, or resource. This replaces any pre-existing permissions.
    /// </summary>
    public partial class PutMailboxPermissionsRequest : AmazonWorkMailRequest
    {
        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The identifier of the user or resource for which to update mailbox permissions.
        /// </para>
        ///  
        /// <para>
        /// The identifier can be <i>UserId, ResourceID, or Group Id</i>, <i>Username, Resourcename,
        /// or Groupname</i>, or <i>email</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Entity ID: 12345678-1234-1234-1234-123456789012, r-0123456789a0123456789b0123456789,
        /// or S-1-1-12-1234567890-123456789-123456789-1234
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Email address: entity@domain.tld
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Entity name: entity
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;

        /// <summary>
        /// Gets and sets the property GranteeId. 
        /// <para>
        /// The identifier of the user, group, or resource to which to grant the permissions.
        /// </para>
        ///  
        /// <para>
        /// The identifier can be <i>UserId, ResourceID, or Group Id</i>, <i>Username, Resourcename,
        /// or Groupname</i>, or <i>email</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Grantee ID: 12345678-1234-1234-1234-123456789012, r-0123456789a0123456789b0123456789,
        /// or S-1-1-12-1234567890-123456789-123456789-1234
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Email address: grantee@domain.tld
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Grantee name: grantee
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string GranteeId { get; set; }

        /// <summary>
        /// Checks to see if the GranteeId property is set.
        /// </summary>
        internal bool IsSetGranteeId() => this.GranteeId != null;

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The identifier of the organization under which the user, group, or resource exists.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 34, Max = 34)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationId property is set.
        /// </summary>
        internal bool IsSetOrganizationId() => this.OrganizationId != null;

        /// <summary>
        /// Gets and sets the property PermissionValues. 
        /// <para>
        /// The permissions granted to the grantee. SEND_AS allows the grantee to send email as
        /// the owner of the mailbox (the grantee is not mentioned on these emails). SEND_ON_BEHALF
        /// allows the grantee to send email on behalf of the owner of the mailbox (the grantee
        /// is not mentioned as the physical sender of these emails). FULL_ACCESS allows the grantee
        /// full access to the mailbox, irrespective of other folder-level permissions set on
        /// the mailbox.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> PermissionValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PermissionValues property is set.
        /// </summary>
        internal bool IsSetPermissionValues() => this.PermissionValues != null && (this.PermissionValues.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
