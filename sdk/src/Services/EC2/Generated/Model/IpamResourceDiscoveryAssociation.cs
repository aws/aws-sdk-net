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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// An IPAM resource discovery association. An associated resource discovery is a resource
    /// discovery that has been associated with an IPAM. IPAM aggregates the resource CIDRs
    /// discovered by the associated resource discovery.
    /// </summary>
    public partial class IpamResourceDiscoveryAssociation
    {
        private string _ipamArn;
        private string _ipamId;
        private string _ipamRegion;
        private string _ipamResourceDiscoveryAssociationArn;
        private string _ipamResourceDiscoveryAssociationId;
        private string _ipamResourceDiscoveryId;
        private bool? _isDefault;
        private string _ownerId;
        private IpamAssociatedResourceDiscoveryStatus _resourceDiscoveryStatus;
        private IpamResourceDiscoveryAssociationState _state;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property IpamArn. 
        /// <para>
        /// The IPAM ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string IpamArn
        {
            get { return this._ipamArn; }
            set { this._ipamArn = value; }
        }

        // Check to see if IpamArn property is set
        internal bool IsSetIpamArn()
        {
            return this._ipamArn != null;
        }

        /// <summary>
        /// Gets and sets the property IpamId. 
        /// <para>
        /// The IPAM ID.
        /// </para>
        /// </summary>
        public string IpamId
        {
            get { return this._ipamId; }
            set { this._ipamId = value; }
        }

        // Check to see if IpamId property is set
        internal bool IsSetIpamId()
        {
            return this._ipamId != null;
        }

        /// <summary>
        /// Gets and sets the property IpamRegion. 
        /// <para>
        /// The IPAM home Region.
        /// </para>
        /// </summary>
        public string IpamRegion
        {
            get { return this._ipamRegion; }
            set { this._ipamRegion = value; }
        }

        // Check to see if IpamRegion property is set
        internal bool IsSetIpamRegion()
        {
            return this._ipamRegion != null;
        }

        /// <summary>
        /// Gets and sets the property IpamResourceDiscoveryAssociationArn. 
        /// <para>
        /// The resource discovery association Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public string IpamResourceDiscoveryAssociationArn
        {
            get { return this._ipamResourceDiscoveryAssociationArn; }
            set { this._ipamResourceDiscoveryAssociationArn = value; }
        }

        // Check to see if IpamResourceDiscoveryAssociationArn property is set
        internal bool IsSetIpamResourceDiscoveryAssociationArn()
        {
            return this._ipamResourceDiscoveryAssociationArn != null;
        }

        /// <summary>
        /// Gets and sets the property IpamResourceDiscoveryAssociationId. 
        /// <para>
        /// The resource discovery association ID.
        /// </para>
        /// </summary>
        public string IpamResourceDiscoveryAssociationId
        {
            get { return this._ipamResourceDiscoveryAssociationId; }
            set { this._ipamResourceDiscoveryAssociationId = value; }
        }

        // Check to see if IpamResourceDiscoveryAssociationId property is set
        internal bool IsSetIpamResourceDiscoveryAssociationId()
        {
            return this._ipamResourceDiscoveryAssociationId != null;
        }

        /// <summary>
        /// Gets and sets the property IpamResourceDiscoveryId. 
        /// <para>
        /// The resource discovery ID.
        /// </para>
        /// </summary>
        public string IpamResourceDiscoveryId
        {
            get { return this._ipamResourceDiscoveryId; }
            set { this._ipamResourceDiscoveryId = value; }
        }

        // Check to see if IpamResourceDiscoveryId property is set
        internal bool IsSetIpamResourceDiscoveryId()
        {
            return this._ipamResourceDiscoveryId != null;
        }

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// Defines if the resource discovery is the default. When you create an IPAM, a default
        /// resource discovery is created for your IPAM and it's associated with your IPAM.
        /// </para>
        /// </summary>
        public bool IsDefault
        {
            get { return this._isDefault.GetValueOrDefault(); }
            set { this._isDefault = value; }
        }

        // Check to see if IsDefault property is set
        internal bool IsSetIsDefault()
        {
            return this._isDefault.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The Amazon Web Services account ID of the resource discovery owner.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceDiscoveryStatus. 
        /// <para>
        /// The resource discovery status.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>active</code> - Connection or permissions required to read the results of the
        /// resource discovery are intact.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>not-found</code> - Connection or permissions required to read the results of
        /// the resource discovery are broken. This may happen if the owner of the resource discovery
        /// stopped sharing it or deleted the resource discovery. Verify the resource discovery
        /// still exists and the Amazon Web Services RAM resource share is still intact.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IpamAssociatedResourceDiscoveryStatus ResourceDiscoveryStatus
        {
            get { return this._resourceDiscoveryStatus; }
            set { this._resourceDiscoveryStatus = value; }
        }

        // Check to see if ResourceDiscoveryStatus property is set
        internal bool IsSetResourceDiscoveryStatus()
        {
            return this._resourceDiscoveryStatus != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The lifecycle state of the association when you associate or disassociate a resource
        /// discovery.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>associate-in-progress</code> - Resource discovery is being associated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>associate-complete</code> - Resource discovery association is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>associate-failed</code> - Resource discovery association has failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>disassociate-in-progress</code> - Resource discovery is being disassociated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>disassociate-complete</code> - Resource discovery disassociation is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>disassociate-failed </code> - Resource discovery disassociation has failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>isolate-in-progress</code> - Amazon Web Services account that created the resource
        /// discovery association has been removed and the resource discovery associatation is
        /// being isolated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>isolate-complete</code> - Resource discovery isolation is complete..
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>restore-in-progress</code> - Resource discovery is being restored.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IpamResourceDiscoveryAssociationState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A tag is a label that you assign to an Amazon Web Services resource. Each tag consists
        /// of a key and an optional value. You can use tags to search and filter your resources
        /// or track your Amazon Web Services costs.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}