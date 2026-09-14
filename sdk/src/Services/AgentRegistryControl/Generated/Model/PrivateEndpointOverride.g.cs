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

namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// A mapping of a domain to the private endpoint used to reach it.
    /// </summary>
    public partial class PrivateEndpointOverride
    {
        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain name to which this private endpoint override applies.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 253)]
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property PrivateEndpoint. 
        /// <para>
        /// The private endpoint used to reach the specified domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PrivateEndpoint PrivateEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the PrivateEndpoint property is set.
        /// </summary>
        internal bool IsSetPrivateEndpoint() => this.PrivateEndpoint != null;
    }
}
