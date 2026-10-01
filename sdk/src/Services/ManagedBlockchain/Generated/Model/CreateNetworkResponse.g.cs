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

namespace Amazon.ManagedBlockchain.Model
{
    /// <summary>
    /// This is the response object from the CreateNetwork operation.
    /// </summary>
    public partial class CreateNetworkResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property MemberId. 
        /// <para>
        /// The unique identifier for the first member within the network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string MemberId { get; set; }

        /// <summary>
        /// Checks to see if the MemberId property is set.
        /// </summary>
        internal bool IsSetMemberId() => this.MemberId != null;

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The unique identifier for the network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string NetworkId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkId property is set.
        /// </summary>
        internal bool IsSetNetworkId() => this.NetworkId != null;
    }
}
