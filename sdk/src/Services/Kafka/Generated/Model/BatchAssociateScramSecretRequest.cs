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
    /// Container for the parameters to the BatchAssociateScramSecret operation.
    /// Associates one or more Scram Secrets with an Amazon MSK cluster.
    /// </summary>
    public partial class BatchAssociateScramSecretRequest : AmazonKafkaRequest
    {
        private string _clusterArn;
        private List<string> _secretArnList = new List<string>();

        /// <summary>
        /// Gets and sets the property ClusterArn.             
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SecretArnList.             
        /// <para>
        /// List of AWS Secrets Manager secret ARNs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SecretArnList
        {
            get { return this._secretArnList; }
            set { this._secretArnList = value; }
        }

        // Check to see if SecretArnList property is set
        internal bool IsSetSecretArnList()
        {
            return this._secretArnList != null && this._secretArnList.Count > 0; 
        }

    }
}