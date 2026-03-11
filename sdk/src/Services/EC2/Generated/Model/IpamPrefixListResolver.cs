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
    /// Describes an IPAM prefix list resolver.
    /// 
    ///  
    /// <para>
    /// An IPAM prefix list resolver is a component that manages the synchronization between
    /// IPAM's CIDR selection rules and customer-managed prefix lists. It automates connectivity
    /// configurations by selecting CIDRs from IPAM's database based on your business logic
    /// and synchronizing them with prefix lists used in resources such as VPC route tables
    /// and security groups.
    /// </para>
    /// </summary>
    public partial class IpamPrefixListResolver
    {
        private AddressFamily _addressFamily;
        private string _description;
        private string _ipamArn;
        private string _ipamPrefixListResolverArn;
        private string _ipamPrefixListResolverId;
        private string _ipamRegion;
        private IpamPrefixListResolverVersionCreationStatus _lastVersionCreationStatus;
        private string _lastVersionCreationStatusMessage;
        private string _ownerId;
        private IpamPrefixListResolverState _state;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AddressFamily. 
        /// <para>
        /// The address family (IPv4 or IPv6) for the IPAM prefix list resolver.
        /// </para>
        /// </summary>
        public AddressFamily AddressFamily
        {
            get { return this._addressFamily; }
            set { this._addressFamily = value; }
        }

        // Check to see if AddressFamily property is set
        internal bool IsSetAddressFamily()
        {
            return this._addressFamily != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the IPAM prefix list resolver.
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
        /// The Amazon Resource Name (ARN) of the IPAM associated with this resolver.
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
        /// Gets and sets the property IpamPrefixListResolverArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IPAM prefix list resolver.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string IpamPrefixListResolverArn
        {
            get { return this._ipamPrefixListResolverArn; }
            set { this._ipamPrefixListResolverArn = value; }
        }

        // Check to see if IpamPrefixListResolverArn property is set
        internal bool IsSetIpamPrefixListResolverArn()
        {
            return this._ipamPrefixListResolverArn != null;
        }

        /// <summary>
        /// Gets and sets the property IpamPrefixListResolverId. 
        /// <para>
        /// The ID of the IPAM prefix list resolver.
        /// </para>
        /// </summary>
        public string IpamPrefixListResolverId
        {
            get { return this._ipamPrefixListResolverId; }
            set { this._ipamPrefixListResolverId = value; }
        }

        // Check to see if IpamPrefixListResolverId property is set
        internal bool IsSetIpamPrefixListResolverId()
        {
            return this._ipamPrefixListResolverId != null;
        }

        /// <summary>
        /// Gets and sets the property IpamRegion. 
        /// <para>
        /// The Amazon Web Services Region where the associated IPAM is located.
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
        /// Gets and sets the property LastVersionCreationStatus. 
        /// <para>
        /// The status for the last time a version was created.
        /// </para>
        ///  
        /// <para>
        /// Each version is a snapshot of what CIDRs matched your rules at that moment in time.
        /// The version number increments every time the CIDR list changes due to infrastructure
        /// changes.
        /// </para>
        /// </summary>
        public IpamPrefixListResolverVersionCreationStatus LastVersionCreationStatus
        {
            get { return this._lastVersionCreationStatus; }
            set { this._lastVersionCreationStatus = value; }
        }

        // Check to see if LastVersionCreationStatus property is set
        internal bool IsSetLastVersionCreationStatus()
        {
            return this._lastVersionCreationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastVersionCreationStatusMessage. 
        /// <para>
        /// The status message for the last time a version was created.
        /// </para>
        ///  
        /// <para>
        /// Each version is a snapshot of what CIDRs matched your rules at that moment in time.
        /// The version number increments every time the CIDR list changes due to infrastructure
        /// changes.
        /// </para>
        /// </summary>
        public string LastVersionCreationStatusMessage
        {
            get { return this._lastVersionCreationStatusMessage; }
            set { this._lastVersionCreationStatusMessage = value; }
        }

        // Check to see if LastVersionCreationStatusMessage property is set
        internal bool IsSetLastVersionCreationStatusMessage()
        {
            return this._lastVersionCreationStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the IPAM prefix list resolver.
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
        /// The current state of the IPAM prefix list resolver. Valid values include <c>create-in-progress</c>,
        /// <c>create-complete</c>, <c>create-failed</c>, <c>modify-in-progress</c>, <c>modify-complete</c>,
        /// <c>modify-failed</c>, <c>delete-in-progress</c>, <c>delete-complete</c>, and <c>delete-failed</c>.
        /// </para>
        /// </summary>
        public IpamPrefixListResolverState State
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
        /// The tags assigned to the IPAM prefix list resolver.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}