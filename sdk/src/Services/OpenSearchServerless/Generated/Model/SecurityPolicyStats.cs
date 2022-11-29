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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Statistics for an OpenSearch Serverless security policy.
    /// </summary>
    public partial class SecurityPolicyStats
    {
        private long? _encryptionPolicyCount;
        private long? _networkPolicyCount;

        /// <summary>
        /// Gets and sets the property EncryptionPolicyCount. 
        /// <para>
        /// The number of encryption policies in the current account.
        /// </para>
        /// </summary>
        public long EncryptionPolicyCount
        {
            get { return this._encryptionPolicyCount.GetValueOrDefault(); }
            set { this._encryptionPolicyCount = value; }
        }

        // Check to see if EncryptionPolicyCount property is set
        internal bool IsSetEncryptionPolicyCount()
        {
            return this._encryptionPolicyCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkPolicyCount. 
        /// <para>
        /// The number of network policies in the current account.
        /// </para>
        /// </summary>
        public long NetworkPolicyCount
        {
            get { return this._networkPolicyCount.GetValueOrDefault(); }
            set { this._networkPolicyCount = value; }
        }

        // Check to see if NetworkPolicyCount property is set
        internal bool IsSetNetworkPolicyCount()
        {
            return this._networkPolicyCount.HasValue; 
        }

    }
}