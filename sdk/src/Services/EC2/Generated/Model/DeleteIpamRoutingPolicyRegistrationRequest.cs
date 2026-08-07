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
    /// Container for the parameters to the DeleteIpamRoutingPolicyRegistration operation.
    /// Deletes a routing policy registration for a specified CIDR prefix.
    /// </summary>
    public partial class DeleteIpamRoutingPolicyRegistrationRequest : AmazonEC2Request
    {
        private string _cidr;
        private string _clientToken;
        private bool? _dryRun;
        private bool? _force;
        private string _ipamInternetRegistryAssociationId;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The IP address prefix in CIDR notation identifying the routing policy registration
        /// to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Cidr
        {
            get { return this._cidr; }
            set { this._cidr = value; }
        }

        // Check to see if Cidr property is set
        internal bool IsSetCidr()
        {
            return this._cidr != null;
        }

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
        /// Gets and sets the property Force. 
        /// <para>
        /// Forces the deletion even if it conflicts with an announced route. Default: <c>false</c>.
        /// </para>
        /// </summary>
        public bool? Force
        {
            get { return this._force; }
            set { this._force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this._force.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IpamInternetRegistryAssociationId. 
        /// <para>
        /// The ID of the IPAM internet registry association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}