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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// This is the response object from the ReplicateSecretToRegions operation.
    /// </summary>
    public partial class ReplicateSecretToRegionsResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private List<ReplicationStatusType> _replicationStatus = new List<ReplicationStatusType>();

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// Replicate a secret based on the <code>ReplicaRegionType</code>&gt; consisting of a
        /// Region(required) and a KMSKeyId (optional) which can be the ARN, KeyID, or Alias.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationStatus. 
        /// <para>
        /// Describes the secret replication status as <code>PENDING</code>, <code>SUCCESS</code>
        /// or <code>FAIL</code>.
        /// </para>
        /// </summary>
        public List<ReplicationStatusType> ReplicationStatus
        {
            get { return this._replicationStatus; }
            set { this._replicationStatus = value; }
        }

        // Check to see if ReplicationStatus property is set
        internal bool IsSetReplicationStatus()
        {
            return this._replicationStatus != null && this._replicationStatus.Count > 0; 
        }

    }
}