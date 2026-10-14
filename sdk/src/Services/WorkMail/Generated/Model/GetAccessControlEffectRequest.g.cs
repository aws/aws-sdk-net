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
    /// Container for the parameters to the GetAccessControlEffect operation. Gets the effects
    /// of an organization's access control rules as they apply to a specified IPv4 address,
    /// access protocol action, and user ID or impersonation role ID. You must provide either
    /// the user ID or impersonation role ID. Impersonation role ID can only be used with
    /// Action EWS.
    /// </summary>
    public partial class GetAccessControlEffectRequest : AmazonWorkMailRequest
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The access protocol action. Valid values include <c>ActiveSync</c>, <c>AutoDiscover</c>,
        /// <c>EWS</c>, <c>IMAP</c>, <c>SMTP</c>, <c>WindowsOutlook</c>, and <c>WebMail</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property ImpersonationRoleId. 
        /// <para>
        /// The impersonation role ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ImpersonationRoleId { get; set; }

        /// <summary>
        /// Checks to see if the ImpersonationRoleId property is set.
        /// </summary>
        internal bool IsSetImpersonationRoleId() => this.ImpersonationRoleId != null;

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IPv4 address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 15)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Checks to see if the IpAddress property is set.
        /// </summary>
        internal bool IsSetIpAddress() => this.IpAddress != null;

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The identifier for the organization.
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
        /// The user ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 256)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
