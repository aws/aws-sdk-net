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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the StartClusterHealthCheck operation.
    /// Start deep health checks for a SageMaker HyperPod cluster. You can use <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeClusterNode.html">DescribeClusterNode</a>
    /// API to track progress of the deep health checks. The unhealthy nodes will be automatically
    /// rebooted or replaced. Please see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod-eks-resiliency-node-labels.html">
    /// Resilience-related Kubernetes labels by SageMaker HyperPod</a> for details.
    /// </summary>
    public partial class StartClusterHealthCheckRequest : AmazonSageMakerRequest
    {
        private string _clusterName;
        private List<InstanceGroupHealthCheckConfiguration> _deepHealthCheckConfigurations = AWSConfigs.InitializeCollections ? new List<InstanceGroupHealthCheckConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The string name or the Amazon Resource Name (ARN) of the SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
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

        /// <summary>
        /// Gets and sets the property DeepHealthCheckConfigurations. 
        /// <para>
        /// A list of configurations containing instance group names, EC2 instance IDs, and deep
        /// health checks to perform.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=99)]
        public List<InstanceGroupHealthCheckConfiguration> DeepHealthCheckConfigurations
        {
            get { return this._deepHealthCheckConfigurations; }
            set { this._deepHealthCheckConfigurations = value; }
        }

        // Check to see if DeepHealthCheckConfigurations property is set
        internal bool IsSetDeepHealthCheckConfigurations()
        {
            return this._deepHealthCheckConfigurations != null && (this._deepHealthCheckConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}