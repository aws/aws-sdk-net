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
    /// Describes the targets for the specified Verified Access endpoint.
    /// </summary>
    public partial class VerifiedAccessEndpointTarget
    {
        private string _verifiedAccessEndpointId;
        private string _verifiedAccessEndpointTargetDns;
        private string _verifiedAccessEndpointTargetIpAddress;

        /// <summary>
        /// Gets and sets the property VerifiedAccessEndpointId. 
        /// <para>
        /// The ID of the Verified Access endpoint.
        /// </para>
        /// </summary>
        public string VerifiedAccessEndpointId
        {
            get { return this._verifiedAccessEndpointId; }
            set { this._verifiedAccessEndpointId = value; }
        }

        // Check to see if VerifiedAccessEndpointId property is set
        internal bool IsSetVerifiedAccessEndpointId()
        {
            return this._verifiedAccessEndpointId != null;
        }

        /// <summary>
        /// Gets and sets the property VerifiedAccessEndpointTargetDns. 
        /// <para>
        /// The DNS name of the target.
        /// </para>
        /// </summary>
        public string VerifiedAccessEndpointTargetDns
        {
            get { return this._verifiedAccessEndpointTargetDns; }
            set { this._verifiedAccessEndpointTargetDns = value; }
        }

        // Check to see if VerifiedAccessEndpointTargetDns property is set
        internal bool IsSetVerifiedAccessEndpointTargetDns()
        {
            return this._verifiedAccessEndpointTargetDns != null;
        }

        /// <summary>
        /// Gets and sets the property VerifiedAccessEndpointTargetIpAddress. 
        /// <para>
        /// The IP address of the target.
        /// </para>
        /// </summary>
        public string VerifiedAccessEndpointTargetIpAddress
        {
            get { return this._verifiedAccessEndpointTargetIpAddress; }
            set { this._verifiedAccessEndpointTargetIpAddress = value; }
        }

        // Check to see if VerifiedAccessEndpointTargetIpAddress property is set
        internal bool IsSetVerifiedAccessEndpointTargetIpAddress()
        {
            return this._verifiedAccessEndpointTargetIpAddress != null;
        }

    }
}