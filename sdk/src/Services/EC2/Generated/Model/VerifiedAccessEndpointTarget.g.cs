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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property VerifiedAccessEndpointId. 
        /// <para>
        /// The ID of the Verified Access endpoint.
        /// </para>
        /// </summary>
        public string VerifiedAccessEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the VerifiedAccessEndpointId property is set.
        /// </summary>
        internal bool IsSetVerifiedAccessEndpointId() => this.VerifiedAccessEndpointId != null;

        /// <summary>
        /// Gets and sets the property VerifiedAccessEndpointTargetDns. 
        /// <para>
        /// The DNS name of the target.
        /// </para>
        /// </summary>
        public string VerifiedAccessEndpointTargetDns { get; set; }

        /// <summary>
        /// Checks to see if the VerifiedAccessEndpointTargetDns property is set.
        /// </summary>
        internal bool IsSetVerifiedAccessEndpointTargetDns() => this.VerifiedAccessEndpointTargetDns != null;

        /// <summary>
        /// Gets and sets the property VerifiedAccessEndpointTargetIpAddress. 
        /// <para>
        /// The IP address of the target.
        /// </para>
        /// </summary>
        public string VerifiedAccessEndpointTargetIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the VerifiedAccessEndpointTargetIpAddress property is set.
        /// </summary>
        internal bool IsSetVerifiedAccessEndpointTargetIpAddress() => this.VerifiedAccessEndpointTargetIpAddress != null;
    }
}
