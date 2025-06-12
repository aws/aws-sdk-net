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
    /// Container for the parameters to the CreateLocalGatewayVirtualInterfaceGroup operation.
    /// Create a local gateway virtual interface group.
    /// </summary>
    public partial class CreateLocalGatewayVirtualInterfaceGroupRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private int? _localBgpAsn;
        private long? _localBgpAsnExtended;
        private string _localGatewayId;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

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
        /// Gets and sets the property LocalBgpAsn. 
        /// <para>
        /// The Autonomous System Number(ASN) for the local Border Gateway Protocol (BGP).
        /// </para>
        /// </summary>
        public int? LocalBgpAsn
        {
            get { return this._localBgpAsn; }
            set { this._localBgpAsn = value; }
        }

        // Check to see if LocalBgpAsn property is set
        internal bool IsSetLocalBgpAsn()
        {
            return this._localBgpAsn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocalBgpAsnExtended. 
        /// <para>
        /// The extended 32-bit ASN for the local BGP configuration.
        /// </para>
        /// </summary>
        public long? LocalBgpAsnExtended
        {
            get { return this._localBgpAsnExtended; }
            set { this._localBgpAsnExtended = value; }
        }

        // Check to see if LocalBgpAsnExtended property is set
        internal bool IsSetLocalBgpAsnExtended()
        {
            return this._localBgpAsnExtended.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocalGatewayId. 
        /// <para>
        /// The ID of the local gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LocalGatewayId
        {
            get { return this._localGatewayId; }
            set { this._localGatewayId = value; }
        }

        // Check to see if LocalGatewayId property is set
        internal bool IsSetLocalGatewayId()
        {
            return this._localGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the local gateway virtual interface group when the resource is
        /// being created.
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