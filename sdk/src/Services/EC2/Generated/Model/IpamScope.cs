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
    /// In IPAM, a scope is the highest-level container within IPAM. An IPAM contains two
    /// default scopes. Each scope represents the IP space for a single network. The private
    /// scope is intended for all private IP address space. The public scope is intended for
    /// all public IP address space. Scopes enable you to reuse IP addresses across multiple
    /// unconnected networks without causing IP address overlap or conflict.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/how-it-works-ipam.html">How
    /// IPAM works</a> in the <i>Amazon VPC IPAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class IpamScope
    {
        private string _description;
        private string _ipamArn;
        private string _ipamRegion;
        private string _ipamScopeArn;
        private string _ipamScopeId;
        private IpamScopeType _ipamScopeType;
        private bool? _isDefault;
        private string _ownerId;
        private int? _poolCount;
        private IpamScopeState _state;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the scope.
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
        /// The ARN of the IPAM.
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
        /// Gets and sets the property IpamRegion. 
        /// <para>
        /// The Amazon Web Services Region of the IPAM scope.
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
        /// Gets and sets the property IpamScopeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the scope.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string IpamScopeArn
        {
            get { return this._ipamScopeArn; }
            set { this._ipamScopeArn = value; }
        }

        // Check to see if IpamScopeArn property is set
        internal bool IsSetIpamScopeArn()
        {
            return this._ipamScopeArn != null;
        }

        /// <summary>
        /// Gets and sets the property IpamScopeId. 
        /// <para>
        /// The ID of the scope.
        /// </para>
        /// </summary>
        public string IpamScopeId
        {
            get { return this._ipamScopeId; }
            set { this._ipamScopeId = value; }
        }

        // Check to see if IpamScopeId property is set
        internal bool IsSetIpamScopeId()
        {
            return this._ipamScopeId != null;
        }

        /// <summary>
        /// Gets and sets the property IpamScopeType. 
        /// <para>
        /// The type of the scope.
        /// </para>
        /// </summary>
        public IpamScopeType IpamScopeType
        {
            get { return this._ipamScopeType; }
            set { this._ipamScopeType = value; }
        }

        // Check to see if IpamScopeType property is set
        internal bool IsSetIpamScopeType()
        {
            return this._ipamScopeType != null;
        }

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// Defines if the scope is the default scope or not.
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
        /// The Amazon Web Services account ID of the owner of the scope.
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
        /// Gets and sets the property PoolCount. 
        /// <para>
        /// The number of pools in the scope.
        /// </para>
        /// </summary>
        public int PoolCount
        {
            get { return this._poolCount.GetValueOrDefault(); }
            set { this._poolCount = value; }
        }

        // Check to see if PoolCount property is set
        internal bool IsSetPoolCount()
        {
            return this._poolCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the IPAM scope.
        /// </para>
        /// </summary>
        public IpamScopeState State
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