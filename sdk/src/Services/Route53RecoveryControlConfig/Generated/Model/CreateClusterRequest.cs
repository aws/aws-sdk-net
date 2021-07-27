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
 * Do not modify this file. This file is generated from the route53-recovery-control-config-2020-11-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53RecoveryControlConfig.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCluster operation.
    /// Create a new cluster. A cluster is a set of redundant Regional endpoints against which
    /// you can run API calls to update or get the state of one or more routing controls.
    /// Each cluster has a name, status, Amazon Resource Name (ARN), and an array of the five
    /// cluster endpoints (one for each supported Amazon Web Services Region) that you can
    /// use with API calls to the Amazon Route 53 Application Recovery Controller cluster
    /// data plane.
    /// </summary>
    public partial class CreateClusterRequest : AmazonRoute53RecoveryControlConfigRequest
    {
        private string _clientToken;
        private string _clusterName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique client idempotency token.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

    }
}