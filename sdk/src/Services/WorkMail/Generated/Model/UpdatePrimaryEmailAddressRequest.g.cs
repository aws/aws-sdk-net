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
    /// Container for the parameters to the UpdatePrimaryEmailAddress operation. Updates the
    /// primary email for a user, group, or resource. The current email is moved into the
    /// list of aliases (or swapped between an existing alias and the current primary email),
    /// and the email provided in the input is promoted as the primary.
    /// </summary>
    public partial class UpdatePrimaryEmailAddressRequest : AmazonWorkMailRequest
    {
        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The value of the email to be updated as primary.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 254)]
        public string Email { get; set; }

        /// <summary>
        /// Checks to see if the Email property is set.
        /// </summary>
        internal bool IsSetEmail() => this.Email != null;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The user, group, or resource to update.
        /// </para>
        ///  
        /// <para>
        /// The identifier can accept <i>UseriD, ResourceId, or GroupId</i>, <i>Username, Resourcename,
        /// or Groupname</i>, or <i>email</i>. The following identity formats are available:
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
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The organization that contains the user, group, or resource to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 34, Max = 34)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationId property is set.
        /// </summary>
        internal bool IsSetOrganizationId() => this.OrganizationId != null;
    }
}
