/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EKS.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateClusterConfig operation.
    /// Updates an Amazon EKS cluster configuration. Your cluster continues to function during
    /// the update. The response output includes an update ID that you can use to track the
    /// status of your cluster update with the <a>DescribeUpdate</a> API operation.
    /// 
    ///  
    /// <para>
    /// Currently, the only cluster configuration changes supported are to enable or disable
    /// Amazon EKS public and private API server endpoints. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/cluster-endpoint.html">Amazon
    /// EKS Cluster Endpoint Access Control</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
    /// </para>
    ///  
    /// <para>
    /// Cluster updates are asynchronous, and they should finish within a few minutes. During
    /// an update, the cluster status moves to <code>UPDATING</code> (this status transition
    /// is eventually consistent). When the update is complete (either <code>Failed</code>
    /// or <code>Successful</code>), the cluster status moves to <code>Active</code>.
    /// </para>
    /// </summary>
    public partial class UpdateClusterConfigRequest : AmazonEKSRequest
    {
        private string _clientRequestToken;
        private string _name;
        private VpcConfigRequest _resourcesVpcConfig;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon EKS cluster to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ResourcesVpcConfig.
        /// </summary>
        public VpcConfigRequest ResourcesVpcConfig
        {
            get { return this._resourcesVpcConfig; }
            set { this._resourcesVpcConfig = value; }
        }

        // Check to see if ResourcesVpcConfig property is set
        internal bool IsSetResourcesVpcConfig()
        {
            return this._resourcesVpcConfig != null;
        }

    }
}