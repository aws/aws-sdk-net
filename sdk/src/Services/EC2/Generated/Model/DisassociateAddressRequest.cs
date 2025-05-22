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
    /// Container for the parameters to the DisassociateAddress operation.
    /// Disassociates an Elastic IP address from the instance or network interface it's associated
    /// with.
    /// 
    ///  
    /// <para>
    /// This is an idempotent operation. If you perform the operation more than once, Amazon
    /// EC2 doesn't return an error.
    /// </para>
    ///  
    /// <para>
    /// An address cannot be disassociated if the all of the following conditions are met:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Network interface has a <c>publicDualStackDnsName</c> publicDnsName
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Public IPv4 address is the primary public IPv4 address
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Network interface only has one remaining public IPv4 address
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DisassociateAddressRequest : AmazonEC2Request
    {
        private string _associationId;
        private bool? _dryRun;
        private string _publicIp;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DisassociateAddressRequest() { }

        /// <summary>
        /// Instantiates DisassociateAddressRequest with the parameterized properties
        /// </summary>
        /// <param name="publicIp">Deprecated.</param>
        public DisassociateAddressRequest(string publicIp)
        {
            _publicIp = publicIp;
        }

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The association ID. This parameter is required.
        /// </para>
        /// </summary>
        public string AssociationId
        {
            get { return this._associationId; }
            set { this._associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this._associationId != null;
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
        /// Gets and sets the property PublicIp. 
        /// <para>
        /// Deprecated.
        /// </para>
        /// </summary>
        public string PublicIp
        {
            get { return this._publicIp; }
            set { this._publicIp = value; }
        }

        // Check to see if PublicIp property is set
        internal bool IsSetPublicIp()
        {
            return this._publicIp != null;
        }

    }
}