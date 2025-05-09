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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Statistics for an OpenSearch Serverless lifecycle policy.
    /// </summary>
    public partial class LifecyclePolicyStats
    {
        private long? _retentionPolicyCount;

        /// <summary>
        /// Gets and sets the property RetentionPolicyCount. 
        /// <para>
        /// The number of retention lifecycle policies in the current account.
        /// </para>
        /// </summary>
        public long? RetentionPolicyCount
        {
            get { return this._retentionPolicyCount; }
            set { this._retentionPolicyCount = value; }
        }

        // Check to see if RetentionPolicyCount property is set
        internal bool IsSetRetentionPolicyCount()
        {
            return this._retentionPolicyCount.HasValue; 
        }

    }
}