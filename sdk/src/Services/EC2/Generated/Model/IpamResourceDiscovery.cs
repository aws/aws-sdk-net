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
    /// A resource discovery is an IPAM component that enables IPAM to manage and monitor
    /// resources that belong to the owning account.
    /// </summary>
    public partial class IpamResourceDiscovery
    {
        private string _description;
        private string _ipamResourceDiscoveryArn;
        private string _ipamResourceDiscoveryId;
        private string _ipamResourceDiscoveryRegion;
        private bool? _isDefault;
        private List<IpamOperatingRegion> _operatingRegions = new List<IpamOperatingRegion>();
        private string _ownerId;
        private IpamResourceDiscoveryState _state;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The resource discovery description.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IpamResourceDiscoveryArn. 
        /// <para>
        /// The resource discovery Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public string IpamResourceDiscoveryArn
        {
            get { return this._ipamResourceDiscoveryArn; }
            set { this._ipamResourceDiscoveryArn = value; }
        }

        // Check to see if IpamResourceDiscoveryArn property is set
        internal bool IsSetIpamResourceDiscoveryArn()
        {
            return this._ipamResourceDiscoveryArn != null;
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
        /// Gets and sets the property IpamResourceDiscoveryRegion. 
        /// <para>
        /// The resource discovery Region.
        /// </para>
        /// </summary>
        public string IpamResourceDiscoveryRegion
        {
            get { return this._ipamResourceDiscoveryRegion; }
            set { this._ipamResourceDiscoveryRegion = value; }
        }

        // Check to see if IpamResourceDiscoveryRegion property is set
        internal bool IsSetIpamResourceDiscoveryRegion()
        {
            return this._ipamResourceDiscoveryRegion != null;
        }

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// Defines if the resource discovery is the default. The default resource discovery is
        /// the resource discovery automatically created when you create an IPAM.
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
        /// Gets and sets the property OperatingRegions. 
        /// <para>
        /// The operating Regions for the resource discovery. Operating Regions are Amazon Web
        /// Services Regions where the IPAM is allowed to manage IP address CIDRs. IPAM only discovers
        /// and monitors resources in the Amazon Web Services Regions you select as operating
        /// Regions.
        /// </para>
        /// </summary>
        public List<IpamOperatingRegion> OperatingRegions
        {
            get { return this._operatingRegions; }
            set { this._operatingRegions = value; }
        }

        // Check to see if OperatingRegions property is set
        internal bool IsSetOperatingRegions()
        {
            return this._operatingRegions != null && this._operatingRegions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the owner.
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
        /// Gets and sets the property State. 
        /// <para>
        /// The lifecycle state of the resource discovery.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>create-in-progress</code> - Resource discovery is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>create-complete</code> - Resource discovery creation is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>create-failed</code> - Resource discovery creation has failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>modify-in-progress</code> - Resource discovery is being modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>modify-complete</code> - Resource discovery modification is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>modify-failed</code> - Resource discovery modification has failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>delete-in-progress</code> - Resource discovery is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>delete-complete</code> - Resource discovery deletion is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>delete-failed</code> - Resource discovery deletion has failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>isolate-in-progress</code> - Amazon Web Services account that created the resource
        /// discovery has been removed and the resource discovery is being isolated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>isolate-complete</code> - Resource discovery isolation is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>restore-in-progress</code> - Amazon Web Services account that created the resource
        /// discovery and was isolated has been restored.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IpamResourceDiscoveryState State
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