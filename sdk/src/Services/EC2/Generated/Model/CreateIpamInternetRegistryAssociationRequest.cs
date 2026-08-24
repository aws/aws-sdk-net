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
    /// Container for the parameters to the CreateIpamInternetRegistryAssociation operation.
    /// Creates an association between an IPAM and a Regional Internet Registry (RIR) for
    /// Resource Public Key Infrastructure (RPKI) management. You can use this association
    /// to create Route Origin Authorizations (ROAs) for IP address prefixes registered with
    /// the internet registry. Your IPAM must be in the Advanced tier to use this feature.
    /// </summary>
    public partial class CreateIpamInternetRegistryAssociationRequest : AmazonEC2Request
    {
        private string _clientToken;
        private string _description;
        private bool? _dryRun;
        private string _ipamId;
        private string _organizationHandle;
        private Rir _rir;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the operation completes no more
        /// than one time. If this token matches a previous request, the operation ignores the
        /// request, but does not return an error.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the internet registry association.
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
        /// Checks whether you have the required permissions for the operation, without actually
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
        /// Gets and sets the property IpamId. 
        /// <para>
        /// The ID of the IPAM to associate with the internet registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property OrganizationHandle. 
        /// <para>
        /// The organization handle at the internet registry (for example, a RIPE NCC organization
        /// ID or ARIN Org ID).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Rir. 
        /// <para>
        /// The Regional Internet Registry to associate with. Possible values:
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the internet registry association.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}