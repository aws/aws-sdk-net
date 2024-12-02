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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This structure contains information about the OpenSearch Service network policy used
    /// for this integration. The network policy assigns network access settings to collections.
    /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-network.html#serverless-network-policies">Network
    /// policies</a> in the OpenSearch Service Developer Guide.
    /// </summary>
    public partial class OpenSearchNetworkPolicy
    {
        private string _policyName;
        private OpenSearchResourceStatus _status;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the network policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// This structure contains information about the status of this OpenSearch Service resource.
        /// </para>
        /// </summary>
        public OpenSearchResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}