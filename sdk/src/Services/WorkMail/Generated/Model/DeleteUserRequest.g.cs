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
    /// Container for the parameters to the DeleteUser operation. Deletes a user from WorkMail
    /// and all subsequent systems. Before you can delete a user, the user state must be <c>DISABLED</c>.
    /// Use the <a>DescribeUser</a> action to confirm the user state. <para> Deleting a user
    /// is permanent and cannot be undone. WorkMail archives user mailboxes for 30 days before
    /// they are permanently removed. </para>
    /// </summary>
    public partial class DeleteUserRequest : AmazonWorkMailRequest
    {
        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The organization that contains the user to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 34, Max = 34)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationId property is set.
        /// </summary>
        internal bool IsSetOrganizationId() => this.OrganizationId != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier of the user to be deleted.
        /// </para>
        ///  
        /// <para>
        /// The identifier can be the <i>UserId</i> or <i>Username</i>. The following identity
        /// formats are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// User ID: 12345678-1234-1234-1234-123456789012 or S-1-1-12-1234567890-123456789-123456789-1234
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User name: user
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
