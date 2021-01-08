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
    /// Container for the parameters to the UpdateMailboxQuota operation.
    /// Updates a user's current mailbox quota for a specified organization and user.
    /// </summary>
    public partial class UpdateMailboxQuotaRequest : AmazonWorkMailRequest
    {
        private int? _mailboxQuota;
        private string _organizationId;
        private string _userId;

        /// <summary>
        /// Gets and sets the property MailboxQuota. 
        /// <para>
        /// The updated mailbox quota, in MB, for the specified user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int MailboxQuota
        {
            get { return this._mailboxQuota.GetValueOrDefault(); }
            set { this._mailboxQuota = value; }
        }

        // Check to see if MailboxQuota property is set
        internal bool IsSetMailboxQuota()
        {
            return this._mailboxQuota.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The identifier for the organization that contains the user for whom to update the
        /// mailbox quota.
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
        /// The identifer for the user for whom to update the mailbox quota.
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