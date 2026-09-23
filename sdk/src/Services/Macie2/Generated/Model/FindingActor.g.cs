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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about an entity that performed an action that produced a policy
    /// finding for a resource.
    /// </summary>
    public partial class FindingActor
    {
        /// <summary>
        /// Gets and sets the property DomainDetails. 
        /// <para>
        /// The domain name of the device that the entity used to perform the action on the affected
        /// resource.
        /// </para>
        /// </summary>
        public DomainDetails DomainDetails { get; set; }

        /// <summary>
        /// Checks to see if the DomainDetails property is set.
        /// </summary>
        internal bool IsSetDomainDetails() => this.DomainDetails != null;

        /// <summary>
        /// Gets and sets the property IpAddressDetails. 
        /// <para>
        /// The IP address and related details about the device that the entity used to perform
        /// the action on the affected resource. The details can include information such as the
        /// owner and geographic location of the IP address.
        /// </para>
        /// </summary>
        public IpAddressDetails IpAddressDetails { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressDetails property is set.
        /// </summary>
        internal bool IsSetIpAddressDetails() => this.IpAddressDetails != null;

        /// <summary>
        /// Gets and sets the property UserIdentity. 
        /// <para>
        /// The type and other characteristics of the entity that performed the action on the
        /// affected resource. This value is null if the action was performed by an anonymous
        /// (unauthenticated) entity.
        /// </para>
        /// </summary>
        public UserIdentity UserIdentity { get; set; }

        /// <summary>
        /// Checks to see if the UserIdentity property is set.
        /// </summary>
        internal bool IsSetUserIdentity() => this.UserIdentity != null;
    }
}
