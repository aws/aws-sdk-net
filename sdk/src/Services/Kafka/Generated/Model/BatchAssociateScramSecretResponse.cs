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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// This is the response object from the BatchAssociateScramSecret operation.
    /// </summary>
    public partial class BatchAssociateScramSecretResponse : AmazonWebServiceResponse
    {
        private string _clusterArn;
        private List<UnprocessedScramSecret> _unprocessedScramSecrets = new List<UnprocessedScramSecret>();

        /// <summary>
        /// Gets and sets the property ClusterArn.             
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster.
        /// </para>
        /// </summary>
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property UnprocessedScramSecrets.             
        /// <para>
        /// List of errors when associating secrets to cluster.
        /// </para>
        /// </summary>
        public List<UnprocessedScramSecret> UnprocessedScramSecrets
        {
            get { return this._unprocessedScramSecrets; }
            set { this._unprocessedScramSecrets = value; }
        }

        // Check to see if UnprocessedScramSecrets property is set
        internal bool IsSetUnprocessedScramSecrets()
        {
            return this._unprocessedScramSecrets != null && this._unprocessedScramSecrets.Count > 0; 
        }

    }
}