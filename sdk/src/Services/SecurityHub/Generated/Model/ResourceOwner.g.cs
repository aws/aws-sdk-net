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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about the owner of a resource, including the account and organization
    /// that the resource belongs to.
    /// </summary>
    public partial class ResourceOwner
    {
        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// Information about the account that owns the resource, for example, an Azure Subscription
        /// or Amazon Web Services Account.
        /// </para>
        /// </summary>
        public ResourceOwnerAccount Account { get; set; }

        /// <summary>
        /// Checks to see if the Account property is set.
        /// </summary>
        internal bool IsSetAccount() => this.Account != null;

        /// <summary>
        /// Gets and sets the property Org. 
        /// <para>
        /// Information about the organization that owns the resource, for example, an Azure Tenant.
        /// </para>
        /// </summary>
        public ResourceOwnerOrg Org { get; set; }

        /// <summary>
        /// Checks to see if the Org property is set.
        /// </summary>
        internal bool IsSetOrg() => this.Org != null;
    }
}
