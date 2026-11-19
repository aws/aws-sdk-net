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
    /// Container for the parameters to the ModifyIpamRoutingPolicyRegistration operation.
    /// Modifies an existing routing policy registration. You can update the authorized ASNs,
    /// maximum prefix length, and other properties of a Route Origin Authorization (ROA).
    /// </summary>
    public partial class ModifyIpamRoutingPolicyRegistrationRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property Asns. 
        /// <para>
        /// The updated list of Autonomous System Numbers (ASNs) authorized to originate the prefix.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Asns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Asns property is set.
        /// </summary>
        internal bool IsSetAsns() => this.Asns != null && (this.Asns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The IP address prefix in CIDR notation identifying the routing policy registration
        /// to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Cidr { get; set; }

        /// <summary>
        /// Checks to see if the Cidr property is set.
        /// </summary>
        internal bool IsSetCidr() => this.Cidr != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the operation completes no more
        /// than one time. If this token matches a previous request, the operation ignores the
        /// request, but does not return an error.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A new description for the routing policy registration.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the operation, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        /// Forces the modification even if it conflicts with an announced route. Default: <c>false</c>.
        /// </para>
        /// </summary>
        public bool? Force { get; set; }

        /// <summary>
        /// Checks to see if the Force property is set.
        /// </summary>
        internal bool IsSetForce() => this.Force.HasValue;

        /// <summary>
        /// Gets and sets the property IpamInternetRegistryAssociationId. 
        /// <para>
        /// The ID of the IPAM internet registry association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IpamInternetRegistryAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the IpamInternetRegistryAssociationId property is set.
        /// </summary>
        internal bool IsSetIpamInternetRegistryAssociationId() => this.IpamInternetRegistryAssociationId != null;

        /// <summary>
        /// Gets and sets the property MaxLength. 
        /// <para>
        /// The new maximum prefix length that the ASNs are authorized to announce. Must be greater
        /// than or equal to the prefix length of the CIDR.
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
        /// Default: <c>false</c>.
        /// </para>
        /// </summary>
        public bool? PermitMoreSpecificAnnouncements { get; set; }

        /// <summary>
        /// Checks to see if the PermitMoreSpecificAnnouncements property is set.
        /// </summary>
        internal bool IsSetPermitMoreSpecificAnnouncements() => this.PermitMoreSpecificAnnouncements.HasValue;
    }
}
