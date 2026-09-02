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
    /// Contains information about an association between an IPAM and a Regional Internet
    /// Registry (RIR) for delegated RPKI management.
    /// </summary>
    public partial class IpamInternetRegistryAssociation
    {
        private string _childRequestXml;
        private string _description;
        private string _ipamId;
        private string _ipamInternetRegistryAssociationArn;
        private string _ipamInternetRegistryAssociationId;
        private string _ipamRegion;
        private string _organizationHandle;
        private string _ownerId;
        private Rir _rir;
        private IpamInternetRegistryAssociationState _state;
        private string _stateMessage;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ChildRequestXml. 
        /// <para>
        /// The XML content for the child request to be submitted to the internet registry to
        /// complete the BPKI setup.
        /// </para>
        /// </summary>
        public string ChildRequestXml
        {
            get { return this._childRequestXml; }
            set { this._childRequestXml = value; }
        }

        // Check to see if ChildRequestXml property is set
        internal bool IsSetChildRequestXml()
        {
            return this._childRequestXml != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the internet registry association.
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
        /// Gets and sets the property IpamId. 
        /// <para>
        /// The ID of the associated IPAM.
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
        /// Gets and sets the property IpamInternetRegistryAssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the internet registry association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string IpamInternetRegistryAssociationArn
        {
            get { return this._ipamInternetRegistryAssociationArn; }
            set { this._ipamInternetRegistryAssociationArn = value; }
        }

        // Check to see if IpamInternetRegistryAssociationArn property is set
        internal bool IsSetIpamInternetRegistryAssociationArn()
        {
            return this._ipamInternetRegistryAssociationArn != null;
        }

        /// <summary>
        /// Gets and sets the property IpamInternetRegistryAssociationId. 
        /// <para>
        /// The ID of the internet registry association.
        /// </para>
        /// </summary>
        public string IpamInternetRegistryAssociationId
        {
            get { return this._ipamInternetRegistryAssociationId; }
            set { this._ipamInternetRegistryAssociationId = value; }
        }

        // Check to see if IpamInternetRegistryAssociationId property is set
        internal bool IsSetIpamInternetRegistryAssociationId()
        {
            return this._ipamInternetRegistryAssociationId != null;
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
        /// Gets and sets the property OrganizationHandle. 
        /// <para>
        /// The organization handle at the internet registry.
        /// </para>
        /// </summary>
        public string OrganizationHandle
        {
            get { return this._organizationHandle; }
            set { this._organizationHandle = value; }
        }

        // Check to see if OrganizationHandle property is set
        internal bool IsSetOrganizationHandle()
        {
            return this._organizationHandle != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the internet registry association.
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
        public Rir Rir
        {
            get { return this._rir; }
            set { this._rir = value; }
        }

        // Check to see if Rir property is set
        internal bool IsSetRir()
        {
            return this._rir != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the internet registry association. Valid values: <c>pending-activation</c>
        /// | <c>pending-enable</c> | <c>create-in-progress</c> | <c>create-failed</c> | <c>enable-in-progress</c>
        /// | <c>enable-complete</c> | <c>enable-failed</c> | <c>delete-in-progress</c> | <c>delete-complete</c>
        /// | <c>delete-failed</c>.
        /// </para>
        /// </summary>
        public IpamInternetRegistryAssociationState State
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
        /// Gets and sets the property StateMessage. 
        /// <para>
        /// A message describing the current state of the internet registry association, including
        /// additional details such as the reason for a failure.
        /// </para>
        /// </summary>
        public string StateMessage
        {
            get { return this._stateMessage; }
            set { this._stateMessage = value; }
        }

        // Check to see if StateMessage property is set
        internal bool IsSetStateMessage()
        {
            return this._stateMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the internet registry association.
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