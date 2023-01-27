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
    /// IPAM is a VPC feature that you can use to automate your IP address management workflows
    /// including assigning, tracking, troubleshooting, and auditing IP addresses across Amazon
    /// Web Services Regions and accounts throughout your Amazon Web Services Organization.
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/what-is-it-ipam.html">What
    /// is IPAM?</a> in the <i>Amazon VPC IPAM User Guide</i>.
    /// </summary>
    public partial class Ipam
    {
        private string _defaultResourceDiscoveryAssociationId;
        private string _defaultResourceDiscoveryId;
        private string _description;
        private string _ipamArn;
        private string _ipamId;
        private string _ipamRegion;
        private List<IpamOperatingRegion> _operatingRegions = new List<IpamOperatingRegion>();
        private string _ownerId;
        private string _privateDefaultScopeId;
        private string _publicDefaultScopeId;
        private int? _resourceDiscoveryAssociationCount;
        private int? _scopeCount;
        private IpamState _state;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property DefaultResourceDiscoveryAssociationId. 
        /// <para>
        /// The IPAM's default resource discovery association ID.
        /// </para>
        /// </summary>
        public string DefaultResourceDiscoveryAssociationId
        {
            get { return this._defaultResourceDiscoveryAssociationId; }
            set { this._defaultResourceDiscoveryAssociationId = value; }
        }

        // Check to see if DefaultResourceDiscoveryAssociationId property is set
        internal bool IsSetDefaultResourceDiscoveryAssociationId()
        {
            return this._defaultResourceDiscoveryAssociationId != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultResourceDiscoveryId. 
        /// <para>
        /// The IPAM's default resource discovery ID.
        /// </para>
        /// </summary>
        public string DefaultResourceDiscoveryId
        {
            get { return this._defaultResourceDiscoveryId; }
            set { this._defaultResourceDiscoveryId = value; }
        }

        // Check to see if DefaultResourceDiscoveryId property is set
        internal bool IsSetDefaultResourceDiscoveryId()
        {
            return this._defaultResourceDiscoveryId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the IPAM.
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
        /// Gets and sets the property IpamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IPAM.
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
        /// The ID of the IPAM.
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
        /// The Amazon Web Services Region of the IPAM.
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
        /// Gets and sets the property OperatingRegions. 
        /// <para>
        /// The operating Regions for an IPAM. Operating Regions are Amazon Web Services Regions
        /// where the IPAM is allowed to manage IP address CIDRs. IPAM only discovers and monitors
        /// resources in the Amazon Web Services Regions you select as operating Regions.
        /// </para>
        ///  
        /// <para>
        /// For more information about operating Regions, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/create-ipam.html">Create
        /// an IPAM</a> in the <i>Amazon VPC IPAM User Guide</i>.
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
        /// The Amazon Web Services account ID of the owner of the IPAM.
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
        /// Gets and sets the property PrivateDefaultScopeId. 
        /// <para>
        /// The ID of the IPAM's default private scope.
        /// </para>
        /// </summary>
        public string PrivateDefaultScopeId
        {
            get { return this._privateDefaultScopeId; }
            set { this._privateDefaultScopeId = value; }
        }

        // Check to see if PrivateDefaultScopeId property is set
        internal bool IsSetPrivateDefaultScopeId()
        {
            return this._privateDefaultScopeId != null;
        }

        /// <summary>
        /// Gets and sets the property PublicDefaultScopeId. 
        /// <para>
        /// The ID of the IPAM's default public scope.
        /// </para>
        /// </summary>
        public string PublicDefaultScopeId
        {
            get { return this._publicDefaultScopeId; }
            set { this._publicDefaultScopeId = value; }
        }

        // Check to see if PublicDefaultScopeId property is set
        internal bool IsSetPublicDefaultScopeId()
        {
            return this._publicDefaultScopeId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceDiscoveryAssociationCount. 
        /// <para>
        /// The IPAM's resource discovery association count.
        /// </para>
        /// </summary>
        public int ResourceDiscoveryAssociationCount
        {
            get { return this._resourceDiscoveryAssociationCount.GetValueOrDefault(); }
            set { this._resourceDiscoveryAssociationCount = value; }
        }

        // Check to see if ResourceDiscoveryAssociationCount property is set
        internal bool IsSetResourceDiscoveryAssociationCount()
        {
            return this._resourceDiscoveryAssociationCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScopeCount. 
        /// <para>
        /// The number of scopes in the IPAM. The scope quota is 5. For more information on quotas,
        /// see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/quotas-ipam.html">Quotas
        /// in IPAM</a> in the <i>Amazon VPC IPAM User Guide</i>. 
        /// </para>
        /// </summary>
        public int ScopeCount
        {
            get { return this._scopeCount.GetValueOrDefault(); }
            set { this._scopeCount = value; }
        }

        // Check to see if ScopeCount property is set
        internal bool IsSetScopeCount()
        {
            return this._scopeCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the IPAM.
        /// </para>
        /// </summary>
        public IpamState State
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
        /// The key/value combination of a tag assigned to the resource. Use the tag key in the
        /// filter name and the tag value as the filter value. For example, to find all resources
        /// that have a tag with the key <code>Owner</code> and the value <code>TeamA</code>,
        /// specify <code>tag:Owner</code> for the filter name and <code>TeamA</code> for the
        /// filter value.
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