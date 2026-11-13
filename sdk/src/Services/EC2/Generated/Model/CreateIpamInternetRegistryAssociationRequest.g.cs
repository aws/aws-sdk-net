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
    /// Container for the parameters to the CreateIpamInternetRegistryAssociation operation.
    /// Creates an association between an IPAM and a Regional Internet Registry (RIR) for
    /// Resource Public Key Infrastructure (RPKI) management. You can use this association
    /// to create Route Origin Authorizations (ROAs) for IP address prefixes registered with
    /// the internet registry. Your IPAM must be in the Advanced tier to use this feature.
    /// </summary>
    public partial class CreateIpamInternetRegistryAssociationRequest : AmazonEC2Request
    {
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
        /// A description for the internet registry association.
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
        /// Gets and sets the property IpamId. 
        /// <para>
        /// The ID of the IPAM to associate with the internet registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IpamId { get; set; }

        /// <summary>
        /// Checks to see if the IpamId property is set.
        /// </summary>
        internal bool IsSetIpamId() => this.IpamId != null;

        /// <summary>
        /// Gets and sets the property OrganizationHandle. 
        /// <para>
        /// The organization handle at the internet registry (for example, a RIPE NCC organization
        /// ID or ARIN Org ID).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OrganizationHandle { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationHandle property is set.
        /// </summary>
        internal bool IsSetOrganizationHandle() => this.OrganizationHandle != null;

        /// <summary>
        /// Gets and sets the property Rir. 
        /// <para>
        /// The internet registry to associate with. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ripe</c> - RIPE NCC (Europe, the Middle East, and Central Asia).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>apnic</c> - APNIC (Asia Pacific).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arin</c> - ARIN (North America).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>lacnic</c> - LACNIC (Latin America and the Caribbean).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>nicbr</c> - NIC.br (Brazil).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public Rir Rir { get; set; }

        /// <summary>
        /// Checks to see if the Rir property is set.
        /// </summary>
        internal bool IsSetRir() => this.Rir != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the internet registry association.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
