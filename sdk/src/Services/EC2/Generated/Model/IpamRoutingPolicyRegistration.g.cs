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
    /// Contains information about a routing policy registration that represents a Route Origin
    /// Authorization (ROA) managed through IPAM.
    /// </summary>
    public partial class IpamRoutingPolicyRegistration
    {
        /// <summary>
        /// Gets and sets the property Asns. 
        /// <para>
        /// The Autonomous System Numbers (ASNs) authorized to originate the prefix.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Asns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Asns property is set.
        /// </summary>
        internal bool IsSetAsns() => this.Asns != null && (this.Asns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The IP address prefix in CIDR notation authorized by the ROA.
        /// </para>
        /// </summary>
        public string Cidr { get; set; }

        /// <summary>
        /// Checks to see if the Cidr property is set.
        /// </summary>
        internal bool IsSetCidr() => this.Cidr != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the routing policy registration.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LatestDeltaId. 
        /// <para>
        /// The ID of the most recent delta that modified this registration.
        /// </para>
        /// </summary>
        public string LatestDeltaId { get; set; }

        /// <summary>
        /// Checks to see if the LatestDeltaId property is set.
        /// </summary>
        internal bool IsSetLatestDeltaId() => this.LatestDeltaId != null;

        /// <summary>
        /// Gets and sets the property MaxLength. 
        /// <para>
        /// The maximum prefix length that the ASNs are authorized to announce.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 48)]
        public int? MaxLength { get; set; }

        /// <summary>
        /// Checks to see if the MaxLength property is set.
        /// </summary>
        internal bool IsSetMaxLength() => this.MaxLength.HasValue;

        /// <summary>
        /// Gets and sets the property PermitMoreSpecificAnnouncements. 
        /// <para>
        /// Specifies whether to permit more specific route announcements than the CIDR prefix.
        /// When enabled, ASNs can announce sub-prefixes of the authorized CIDR up to the specified
        /// maximum length. Default: <c>false</c>.
        /// </para>
        /// </summary>
        public bool? PermitMoreSpecificAnnouncements { get; set; }

        /// <summary>
        /// Checks to see if the PermitMoreSpecificAnnouncements property is set.
        /// </summary>
        internal bool IsSetPermitMoreSpecificAnnouncements() => this.PermitMoreSpecificAnnouncements.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the routing policy registration. Valid values: <c>pending-activate</c>
        /// | <c>activate-failed</c> | <c>create-in-progress</c> | <c>create-complete</c> | <c>update-in-progress</c>
        /// | <c>update-complete</c> | <c>delete-in-progress</c> | <c>delete-complete</c>.
        /// </para>
        /// </summary>
        public IpamRoutingPolicyRegistrationState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
