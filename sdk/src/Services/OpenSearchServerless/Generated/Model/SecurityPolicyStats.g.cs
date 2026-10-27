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

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Statistics for an OpenSearch Serverless security policy.
    /// </summary>
    public partial class SecurityPolicyStats
    {
        /// <summary>
        /// Gets and sets the property EncryptionPolicyCount. 
        /// <para>
        /// The number of encryption policies in the current account.
        /// </para>
        /// </summary>
        public long? EncryptionPolicyCount { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionPolicyCount property is set.
        /// </summary>
        internal bool IsSetEncryptionPolicyCount() => this.EncryptionPolicyCount.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkPolicyCount. 
        /// <para>
        /// The number of network policies in the current account.
        /// </para>
        /// </summary>
        public long? NetworkPolicyCount { get; set; }

        /// <summary>
        /// Checks to see if the NetworkPolicyCount property is set.
        /// </summary>
        internal bool IsSetNetworkPolicyCount() => this.NetworkPolicyCount.HasValue;
    }
}
