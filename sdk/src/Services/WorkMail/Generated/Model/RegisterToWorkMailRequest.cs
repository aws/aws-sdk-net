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
    /// Container for the parameters to the RegisterToWorkMail operation.
    /// Registers an existing and disabled user, group, or resource/entity for Amazon WorkMail
    /// use by associating a mailbox and calendaring capabilities. It performs no change if
    /// the entity is enabled and fails if the entity is deleted. This operation results in
    /// the accumulation of costs. For more information, see <a href="http://aws.amazon.com/workmail/pricing">Pricing</a>.
    /// The equivalent console functionality for this operation is <i>Enable</i>. Users can
    /// either be created by calling the CreateUser API or they can be synchronized from your
    /// directory. For more information, see DeregisterFromWorkMail.
    /// </summary>
    public partial class RegisterToWorkMailRequest : AmazonWorkMailRequest
    {
        private string _email;
        private string _entityId;
        private string _organizationId;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email for the entity to be updated.
        /// </para>
        /// </summary>
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
        }

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The identifier for the entity to be updated.
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
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The identifier for the organization under which the Amazon WorkMail entity exists.
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