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
    /// Contains information about an association between an IPAM and a Regional Internet
    /// Registry (RIR) for delegated RPKI management.
    /// </summary>
    public partial class IpamInternetRegistryAssociation
    {
        /// <summary>
        /// Gets and sets the property ChildRequestXml. 
        /// <para>
        /// The XML content for the child request to be submitted to the internet registry to
        /// complete the BPKI setup.
        /// </para>
        /// </summary>
        public string ChildRequestXml { get; set; }

        /// <summary>
        /// Checks to see if the ChildRequestXml property is set.
        /// </summary>
        internal bool IsSetChildRequestXml() => this.ChildRequestXml != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the internet registry association.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IpamId. 
        /// <para>
        /// The ID of the associated IPAM.
        /// </para>
        /// </summary>
        public string IpamId { get; set; }

        /// <summary>
        /// Checks to see if the IpamId property is set.
        /// </summary>
        internal bool IsSetIpamId() => this.IpamId != null;

        /// <summary>
        /// Gets and sets the property IpamInternetRegistryAssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the internet registry association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1283)]
        public string IpamInternetRegistryAssociationArn { get; set; }

        /// <summary>
        /// Checks to see if the IpamInternetRegistryAssociationArn property is set.
        /// </summary>
        internal bool IsSetIpamInternetRegistryAssociationArn() => this.IpamInternetRegistryAssociationArn != null;

        /// <summary>
        /// Gets and sets the property IpamInternetRegistryAssociationId. 
        /// <para>
        /// The ID of the internet registry association.
        /// </para>
        /// </summary>
        public string IpamInternetRegistryAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the IpamInternetRegistryAssociationId property is set.
        /// </summary>
        internal bool IsSetIpamInternetRegistryAssociationId() => this.IpamInternetRegistryAssociationId != null;

        /// <summary>
        /// Gets and sets the property IpamRegion. 
        /// <para>
        /// The Amazon Web Services Region of the IPAM.
        /// </para>
        /// </summary>
        public string IpamRegion { get; set; }

        /// <summary>
        /// Checks to see if the IpamRegion property is set.
        /// </summary>
        internal bool IsSetIpamRegion() => this.IpamRegion != null;

        /// <summary>
        /// Gets and sets the property OrganizationHandle. 
        /// <para>
        /// The organization handle at the internet registry.
        /// </para>
        /// </summary>
        public string OrganizationHandle { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationHandle property is set.
        /// </summary>
        internal bool IsSetOrganizationHandle() => this.OrganizationHandle != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the internet registry association.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property Rir. 
        /// <para>
        /// The Regional Internet Registry. Possible values:
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
        ///  </li> </ul>
        /// </summary>
        public Rir Rir { get; set; }

        /// <summary>
        /// Checks to see if the Rir property is set.
        /// </summary>
        internal bool IsSetRir() => this.Rir != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the internet registry association. Valid values: <c>pending-activation</c>
        /// | <c>pending-enable</c> | <c>create-in-progress</c> | <c>create-failed</c> | <c>enable-in-progress</c>
        /// | <c>enable-complete</c> | <c>enable-failed</c> | <c>delete-in-progress</c> | <c>delete-complete</c>
        /// | <c>delete-failed</c>.
        /// </para>
        /// </summary>
        public IpamInternetRegistryAssociationState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateMessage. 
        /// <para>
        /// A message describing the current state of the internet registry association, including
        /// additional details such as the reason for a failure.
        /// </para>
        /// </summary>
        public string StateMessage { get; set; }

        /// <summary>
        /// Checks to see if the StateMessage property is set.
        /// </summary>
        internal bool IsSetStateMessage() => this.StateMessage != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the internet registry association.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
