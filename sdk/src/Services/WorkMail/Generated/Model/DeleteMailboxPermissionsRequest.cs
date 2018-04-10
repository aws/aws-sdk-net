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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteMailboxPermissions operation.
    /// Deletes permissions granted to a user or group.
    /// </summary>
    public partial class DeleteMailboxPermissionsRequest : AmazonWorkMailRequest
    {
        private string _entityId;
        private string _granteeId;
        private string _organizationId;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The identifier of the entity (user or group) for which to delete mailbox permissions.
        /// </para>
        /// </summary>
        public string EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }

        // Check to see if EntityId property is set
        internal bool IsSetEntityId()
        {
            return this._entityId != null;
        }

        /// <summary>
        /// Gets and sets the property GranteeId. 
        /// <para>
        /// The identifier of the entity (user or group) for which to delete granted permissions.
        /// </para>
        /// </summary>
        public string GranteeId
        {
            get { return this._granteeId; }
            set { this._granteeId = value; }
        }

        // Check to see if GranteeId property is set
        internal bool IsSetGranteeId()
        {
            return this._granteeId != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The identifier of the organization under which the entity (user or group) exists.
        /// </para>
        /// </summary>
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