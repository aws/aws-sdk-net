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
    /// Container for the parameters to the UpdateClusterSoftware operation.
    /// Updates the platform software of a SageMaker HyperPod cluster for security patching.
    /// To learn how to use this API, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod-operate.html#sagemaker-hyperpod-operate-cli-command-update-cluster-software">Update
    /// the SageMaker HyperPod platform software of a cluster</a>.
    /// 
    ///  <important> 
    /// <para>
    /// The <c>UpgradeClusterSoftware</c> API call may impact your SageMaker HyperPod cluster
    /// uptime and availability. Plan accordingly to mitigate potential disruptions to your
    /// workloads.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateClusterSoftwareRequest : AmazonSageMakerRequest
    {
        private string _clusterName;
        private DeploymentConfiguration _deploymentConfig;
        private List<UpdateClusterSoftwareInstanceGroupSpecification> _instanceGroups = AWSConfigs.InitializeCollections ? new List<UpdateClusterSoftwareInstanceGroupSpecification>() : null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// Specify the name or the Amazon Resource Name (ARN) of the SageMaker HyperPod cluster
        /// you want to update for security patching.
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
        /// Gets and sets the property DeploymentConfig. 
        /// <para>
        /// The configuration to use when updating the AMI versions.
        /// </para>
        /// </summary>
        public DeploymentConfiguration DeploymentConfig
        {
            get { return this._deploymentConfig; }
            set { this._deploymentConfig = value; }
        }

        // Check to see if DeploymentConfig property is set
        internal bool IsSetDeploymentConfig()
        {
            return this._deploymentConfig != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceGroups. 
        /// <para>
        /// The array of instance groups for which to update AMI versions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<UpdateClusterSoftwareInstanceGroupSpecification> InstanceGroups
        {
            get { return this._instanceGroups; }
            set { this._instanceGroups = value; }
        }

        // Check to see if InstanceGroups property is set
        internal bool IsSetInstanceGroups()
        {
            return this._instanceGroups != null && (this._instanceGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}