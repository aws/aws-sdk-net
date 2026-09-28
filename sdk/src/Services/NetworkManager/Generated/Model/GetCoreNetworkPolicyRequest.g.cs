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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Container for the parameters to the GetCoreNetworkPolicy operation. Returns details
    /// about a core network policy. You can get details about your current live policy or
    /// any previous policy version.
    /// </summary>
    public partial class GetCoreNetworkPolicyRequest : AmazonNetworkManagerRequest
    {
        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The alias of a core network policy 
        /// </para>
        /// </summary>
        public CoreNetworkPolicyAlias Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property CoreNetworkId. 
        /// <para>
        /// The ID of a core network.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 50)]
        public string CoreNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the CoreNetworkId property is set.
        /// </summary>
        internal bool IsSetCoreNetworkId() => this.CoreNetworkId != null;

        /// <summary>
        /// Gets and sets the property PolicyVersionId. 
        /// <para>
        /// The ID of a core network policy version.
        /// </para>
        /// </summary>
        public int? PolicyVersionId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyVersionId property is set.
        /// </summary>
        internal bool IsSetPolicyVersionId() => this.PolicyVersionId.HasValue;
    }
}
