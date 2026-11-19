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
    /// An IPAM resource discovery association. An associated resource discovery is a resource
    /// discovery that has been associated with an IPAM. IPAM aggregates the resource CIDRs
    /// discovered by the associated resource discovery.
    /// </summary>
    public partial class IpamResourceDiscoveryAssociation
    {
        /// <summary>
        /// Gets and sets the property IpamArn. 
        /// <para>
        /// The IPAM ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1283)]
        public string IpamArn { get; set; }

        /// <summary>
        /// Checks to see if the IpamArn property is set.
        /// </summary>
        internal bool IsSetIpamArn() => this.IpamArn != null;

        /// <summary>
        /// Gets and sets the property IpamId. 
        /// <para>
        /// The IPAM ID.
        /// </para>
        /// </summary>
        public string IpamId { get; set; }

        /// <summary>
        /// Checks to see if the IpamId property is set.
        /// </summary>
        internal bool IsSetIpamId() => this.IpamId != null;

        /// <summary>
        /// Gets and sets the property IpamRegion. 
        /// <para>
        /// The IPAM home Region.
        /// </para>
        /// </summary>
        public string IpamRegion { get; set; }

        /// <summary>
        /// Checks to see if the IpamRegion property is set.
        /// </summary>
        internal bool IsSetIpamRegion() => this.IpamRegion != null;

        /// <summary>
        /// Gets and sets the property IpamResourceDiscoveryAssociationArn. 
        /// <para>
        /// The resource discovery association Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public string IpamResourceDiscoveryAssociationArn { get; set; }

        /// <summary>
        /// Checks to see if the IpamResourceDiscoveryAssociationArn property is set.
        /// </summary>
        internal bool IsSetIpamResourceDiscoveryAssociationArn() => this.IpamResourceDiscoveryAssociationArn != null;

        /// <summary>
        /// Gets and sets the property IpamResourceDiscoveryAssociationId. 
        /// <para>
        /// The resource discovery association ID.
        /// </para>
        /// </summary>
        public string IpamResourceDiscoveryAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the IpamResourceDiscoveryAssociationId property is set.
        /// </summary>
        internal bool IsSetIpamResourceDiscoveryAssociationId() => this.IpamResourceDiscoveryAssociationId != null;

        /// <summary>
        /// Gets and sets the property IpamResourceDiscoveryId. 
        /// <para>
        /// The resource discovery ID.
        /// </para>
        /// </summary>
        public string IpamResourceDiscoveryId { get; set; }

        /// <summary>
        /// Checks to see if the IpamResourceDiscoveryId property is set.
        /// </summary>
        internal bool IsSetIpamResourceDiscoveryId() => this.IpamResourceDiscoveryId != null;

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// Defines if the resource discovery is the default. When you create an IPAM, a default
        /// resource discovery is created for your IPAM and it's associated with your IPAM.
        /// </para>
        /// </summary>
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Checks to see if the IsDefault property is set.
        /// </summary>
        internal bool IsSetIsDefault() => this.IsDefault.HasValue;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The Amazon Web Services account ID of the resource discovery owner.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property ResourceDiscoveryStatus. 
        /// <para>
        /// The resource discovery status.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>active</c> - Connection or permissions required to read the results of the resource
        /// discovery are intact.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>not-found</c> - Connection or permissions required to read the results of the
        /// resource discovery are broken. This may happen if the owner of the resource discovery
        /// stopped sharing it or deleted the resource discovery. Verify the resource discovery
        /// still exists and the Amazon Web Services RAM resource share is still intact.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IpamAssociatedResourceDiscoveryStatus ResourceDiscoveryStatus { get; set; }

        /// <summary>
        /// Checks to see if the ResourceDiscoveryStatus property is set.
        /// </summary>
        internal bool IsSetResourceDiscoveryStatus() => this.ResourceDiscoveryStatus != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The lifecycle state of the association when you associate or disassociate a resource
        /// discovery.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>associate-in-progress</c> - Resource discovery is being associated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>associate-complete</c> - Resource discovery association is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>associate-failed</c> - Resource discovery association has failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>disassociate-in-progress</c> - Resource discovery is being disassociated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>disassociate-complete</c> - Resource discovery disassociation is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>disassociate-failed </c> - Resource discovery disassociation has failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>isolate-in-progress</c> - Amazon Web Services account that created the resource
        /// discovery association has been removed and the resource discovery association is being
        /// isolated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>isolate-complete</c> - Resource discovery isolation is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>restore-in-progress</c> - Resource discovery is being restored.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IpamResourceDiscoveryAssociationState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A tag is a label that you assign to an Amazon Web Services resource. Each tag consists
        /// of a key and an optional value. You can use tags to search and filter your resources
        /// or track your Amazon Web Services costs.
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
