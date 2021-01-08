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

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteUser operation.
    /// Deletes a user from Amazon WorkMail and all subsequent systems. Before you can delete
    /// a user, the user state must be <code>DISABLED</code>. Use the <a>DescribeUser</a>
    /// action to confirm the user state.
    /// 
    ///  
    /// <para>
    /// Deleting a user is permanent and cannot be undone. WorkMail archives user mailboxes
    /// for 30 days before they are permanently removed.
    /// </para>
    /// </summary>
    public partial class DeleteUserRequest : AmazonWorkMailRequest
    {
        private string _organizationId;
        private string _userId;

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The organization that contains the user to be deleted.
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

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier of the user to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=256)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}