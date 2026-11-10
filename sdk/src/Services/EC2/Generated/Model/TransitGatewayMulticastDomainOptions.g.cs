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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the options for a transit gateway multicast domain.
    /// </summary>
    public partial class TransitGatewayMulticastDomainOptions
    {
        /// <summary>
        /// Gets and sets the property AutoAcceptSharedAssociations. 
        /// <para>
        /// Indicates whether to automatically cross-account subnet associations that are associated
        /// with the transit gateway multicast domain.
        /// </para>
        /// </summary>
        public AutoAcceptSharedAssociationsValue AutoAcceptSharedAssociations { get; set; }

        /// <summary>
        /// Checks to see if the AutoAcceptSharedAssociations property is set.
        /// </summary>
        internal bool IsSetAutoAcceptSharedAssociations() => this.AutoAcceptSharedAssociations != null;

        /// <summary>
        /// Gets and sets the property Igmpv2Support. 
        /// <para>
        /// Indicates whether Internet Group Management Protocol (IGMP) version 2 is turned on
        /// for the transit gateway multicast domain.
        /// </para>
        /// </summary>
        public Igmpv2SupportValue Igmpv2Support { get; set; }

        /// <summary>
        /// Checks to see if the Igmpv2Support property is set.
        /// </summary>
        internal bool IsSetIgmpv2Support() => this.Igmpv2Support != null;

        /// <summary>
        /// Gets and sets the property StaticSourcesSupport. 
        /// <para>
        /// Indicates whether support for statically configuring transit gateway multicast group
        /// sources is turned on.
        /// </para>
        /// </summary>
        public StaticSourcesSupportValue StaticSourcesSupport { get; set; }

        /// <summary>
        /// Checks to see if the StaticSourcesSupport property is set.
        /// </summary>
        internal bool IsSetStaticSourcesSupport() => this.StaticSourcesSupport != null;
    }
}
