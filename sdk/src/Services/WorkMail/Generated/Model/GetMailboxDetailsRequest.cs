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
    /// Container for the parameters to the GetMailboxDetails operation.
    /// Requests a user's mailbox details for a specified organization and user.
    /// </summary>
    public partial class GetMailboxDetailsRequest : AmazonWorkMailRequest
    {
        private string _organizationId;
        private string _userId;

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The identifier for the organization that contains the user whose mailbox details are
        /// being requested.
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
        /// The identifier for the user whose mailbox details are being requested.
        /// </para>
        ///  
        /// <para>
        /// The identifier can be the <i>UserId</i>, <i>Username</i>, or <i>email</i>. The following
        /// identity formats are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// User ID: 12345678-1234-1234-1234-123456789012 or S-1-1-12-1234567890-123456789-123456789-1234
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Email address: user@domain.tld
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User name: user
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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