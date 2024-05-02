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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// The options for the transit gateway multicast domain.
    /// </summary>
    public partial class CreateTransitGatewayMulticastDomainRequestOptions
    {
        private AutoAcceptSharedAssociationsValue _autoAcceptSharedAssociations;
        private Igmpv2SupportValue _igmpv2Support;
        private StaticSourcesSupportValue _staticSourcesSupport;

        /// <summary>
        /// Gets and sets the property AutoAcceptSharedAssociations. 
        /// <para>
        /// Indicates whether to automatically accept cross-account subnet associations that are
        /// associated with the transit gateway multicast domain.
        /// </para>
        /// </summary>
        public AutoAcceptSharedAssociationsValue AutoAcceptSharedAssociations
        {
            get { return this._autoAcceptSharedAssociations; }
            set { this._autoAcceptSharedAssociations = value; }
        }

        // Check to see if AutoAcceptSharedAssociations property is set
        internal bool IsSetAutoAcceptSharedAssociations()
        {
            return this._autoAcceptSharedAssociations != null;
        }

        /// <summary>
        /// Gets and sets the property Igmpv2Support. 
        /// <para>
        /// Specify whether to enable Internet Group Management Protocol (IGMP) version 2 for
        /// the transit gateway multicast domain.
        /// </para>
        /// </summary>
        public Igmpv2SupportValue Igmpv2Support
        {
            get { return this._igmpv2Support; }
            set { this._igmpv2Support = value; }
        }

        // Check to see if Igmpv2Support property is set
        internal bool IsSetIgmpv2Support()
        {
            return this._igmpv2Support != null;
        }

        /// <summary>
        /// Gets and sets the property StaticSourcesSupport. 
        /// <para>
        /// Specify whether to enable support for statically configuring multicast group sources
        /// for a domain.
        /// </para>
        /// </summary>
        public StaticSourcesSupportValue StaticSourcesSupport
        {
            get { return this._staticSourcesSupport; }
            set { this._staticSourcesSupport = value; }
        }

        // Check to see if StaticSourcesSupport property is set
        internal bool IsSetStaticSourcesSupport()
        {
            return this._staticSourcesSupport != null;
        }

    }
}