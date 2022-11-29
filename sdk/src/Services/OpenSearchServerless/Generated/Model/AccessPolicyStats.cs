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
    /// Statistics for an OpenSearch Serverless access policy.
    /// </summary>
    public partial class AccessPolicyStats
    {
        private long? _dataPolicyCount;

        /// <summary>
        /// Gets and sets the property DataPolicyCount. 
        /// <para>
        /// The number of data access policies in the current account.
        /// </para>
        /// </summary>
        public long DataPolicyCount
        {
            get { return this._dataPolicyCount.GetValueOrDefault(); }
            set { this._dataPolicyCount = value; }
        }

        // Check to see if DataPolicyCount property is set
        internal bool IsSetDataPolicyCount()
        {
            return this._dataPolicyCount.HasValue; 
        }

    }
}