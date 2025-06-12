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
    /// Container for the parameters to the ModifyNetworkInterfaceAttribute operation.
    /// Modifies the specified network interface attribute. You can specify only one attribute
    /// at a time. You can use this action to attach and detach security groups from an existing
    /// EC2 instance.
    /// </summary>
    public partial class ModifyNetworkInterfaceAttributeRequest : AmazonEC2Request
    {
        private List<string> _associatedSubnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _associatePublicIpAddress;
        private NetworkInterfaceAttachmentChanges _attachment;
        private ConnectionTrackingSpecificationRequest _connectionTrackingSpecification;
        private string _description;
        private bool? _dryRun;
        private bool? _enablePrimaryIpv6;
        private EnaSrdSpecification _enaSrdSpecification;
        private List<string> _groups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _networkInterfaceId;
        private bool? _sourceDestCheck;

        /// <summary>
        /// Gets and sets the property AssociatedSubnetIds. 
        /// <para>
        /// A list of subnet IDs to associate with the network interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssociatedSubnetIds
        {
            get { return this._associatedSubnetIds; }
            set { this._associatedSubnetIds = value; }
        }

        // Check to see if AssociatedSubnetIds property is set
        internal bool IsSetAssociatedSubnetIds()
        {
            return this._associatedSubnetIds != null && (this._associatedSubnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssociatePublicIpAddress. 
        /// <para>
        /// Indicates whether to assign a public IPv4 address to a network interface. This option
        /// can be enabled for any network interface but will only apply to the primary network
        /// interface (eth0).
        /// </para>
        /// </summary>
        public bool? AssociatePublicIpAddress
        {
            get { return this._associatePublicIpAddress; }
            set { this._associatePublicIpAddress = value; }
        }

        // Check to see if AssociatePublicIpAddress property is set
        internal bool IsSetAssociatePublicIpAddress()
        {
            return this._associatePublicIpAddress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Attachment. 
        /// <para>
        /// Information about the interface attachment. If modifying the <c>delete on termination</c>
        /// attribute, you must specify the ID of the interface attachment.
        /// </para>
        /// </summary>
        public NetworkInterfaceAttachmentChanges Attachment
        {
            get { return this._attachment; }
            set { this._attachment = value; }
        }

        // Check to see if Attachment property is set
        internal bool IsSetAttachment()
        {
            return this._attachment != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionTrackingSpecification. 
        /// <para>
        /// A connection tracking specification.
        /// </para>
        /// </summary>
        public ConnectionTrackingSpecificationRequest ConnectionTrackingSpecification
        {
            get { return this._connectionTrackingSpecification; }
            set { this._connectionTrackingSpecification = value; }
        }

        // Check to see if ConnectionTrackingSpecification property is set
        internal bool IsSetConnectionTrackingSpecification()
        {
            return this._connectionTrackingSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the network interface.
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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnablePrimaryIpv6. 
        /// <para>
        /// If you’re modifying a network interface in a dual-stack or IPv6-only subnet, you have
        /// the option to assign a primary IPv6 IP address. A primary IPv6 address is an IPv6
        /// GUA address associated with an ENI that you have enabled to use a primary IPv6 address.
        /// Use this option if the instance that this ENI will be attached to relies on its IPv6
        /// address not changing. Amazon Web Services will automatically assign an IPv6 address
        /// associated with the ENI attached to your instance to be the primary IPv6 address.
        /// Once you enable an IPv6 GUA address to be a primary IPv6, you cannot disable it. When
        /// you enable an IPv6 GUA address to be a primary IPv6, the first IPv6 GUA will be made
        /// the primary IPv6 address until the instance is terminated or the network interface
        /// is detached. If you have multiple IPv6 addresses associated with an ENI attached to
        /// your instance and you enable a primary IPv6 address, the first IPv6 GUA address associated
        /// with the ENI becomes the primary IPv6 address.
        /// </para>
        /// </summary>
        public bool? EnablePrimaryIpv6
        {
            get { return this._enablePrimaryIpv6; }
            set { this._enablePrimaryIpv6 = value; }
        }

        // Check to see if EnablePrimaryIpv6 property is set
        internal bool IsSetEnablePrimaryIpv6()
        {
            return this._enablePrimaryIpv6.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnaSrdSpecification. 
        /// <para>
        /// Updates the ENA Express configuration for the network interface that’s attached to
        /// the instance.
        /// </para>
        /// </summary>
        public EnaSrdSpecification EnaSrdSpecification
        {
            get { return this._enaSrdSpecification; }
            set { this._enaSrdSpecification = value; }
        }

        // Check to see if EnaSrdSpecification property is set
        internal bool IsSetEnaSrdSpecification()
        {
            return this._enaSrdSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// Changes the security groups for the network interface. The new set of groups you specify
        /// replaces the current set. You must specify at least one group, even if it's just the
        /// default security group in the VPC. You must specify the ID of the security group,
        /// not the name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Groups
        {
            get { return this._groups; }
            set { this._groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this._groups != null && (this._groups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NetworkInterfaceId
        {
            get { return this._networkInterfaceId; }
            set { this._networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this._networkInterfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDestCheck. 
        /// <para>
        /// Enable or disable source/destination checks, which ensure that the instance is either
        /// the source or the destination of any traffic that it receives. If the value is <c>true</c>,
        /// source/destination checks are enabled; otherwise, they are disabled. The default value
        /// is <c>true</c>. You must disable source/destination checks if the instance runs services
        /// such as network address translation, routing, or firewalls.
        /// </para>
        /// </summary>
        public bool? SourceDestCheck
        {
            get { return this._sourceDestCheck; }
            set { this._sourceDestCheck = value; }
        }

        // Check to see if SourceDestCheck property is set
        internal bool IsSetSourceDestCheck()
        {
            return this._sourceDestCheck.HasValue; 
        }

    }
}