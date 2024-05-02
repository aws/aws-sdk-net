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
    /// This is the response object from the ModifyVpcPeeringConnectionOptions operation.
    /// </summary>
    public partial class ModifyVpcPeeringConnectionOptionsResponse : AmazonWebServiceResponse
    {
        private PeeringConnectionOptions _accepterPeeringConnectionOptions;
        private PeeringConnectionOptions _requesterPeeringConnectionOptions;

        /// <summary>
        /// Gets and sets the property AccepterPeeringConnectionOptions. 
        /// <para>
        /// Information about the VPC peering connection options for the accepter VPC.
        /// </para>
        /// </summary>
        public PeeringConnectionOptions AccepterPeeringConnectionOptions
        {
            get { return this._accepterPeeringConnectionOptions; }
            set { this._accepterPeeringConnectionOptions = value; }
        }

        // Check to see if AccepterPeeringConnectionOptions property is set
        internal bool IsSetAccepterPeeringConnectionOptions()
        {
            return this._accepterPeeringConnectionOptions != null;
        }

        /// <summary>
        /// Gets and sets the property RequesterPeeringConnectionOptions. 
        /// <para>
        /// Information about the VPC peering connection options for the requester VPC.
        /// </para>
        /// </summary>
        public PeeringConnectionOptions RequesterPeeringConnectionOptions
        {
            get { return this._requesterPeeringConnectionOptions; }
            set { this._requesterPeeringConnectionOptions = value; }
        }

        // Check to see if RequesterPeeringConnectionOptions property is set
        internal bool IsSetRequesterPeeringConnectionOptions()
        {
            return this._requesterPeeringConnectionOptions != null;
        }

    }
}