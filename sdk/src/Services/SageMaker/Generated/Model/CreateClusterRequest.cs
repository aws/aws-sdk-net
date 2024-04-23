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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCluster operation.
    /// Creates a SageMaker HyperPod cluster. SageMaker HyperPod is a capability of SageMaker
    /// for creating and managing persistent clusters for developing large machine learning
    /// models, such as large language models (LLMs) and diffusion models. To learn more,
    /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod.html">Amazon
    /// SageMaker HyperPod</a> in the <i>Amazon SageMaker Developer Guide</i>.
    /// </summary>
    public partial class CreateClusterRequest : AmazonSageMakerRequest
    {
        private string _clusterName;
        private List<ClusterInstanceGroupSpecification> _instanceGroups = AWSConfigs.InitializeCollections ? new List<ClusterInstanceGroupSpecification>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name for the new SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// Gets and sets the property InstanceGroups. 
        /// <para>
        /// The instance groups to be created in the SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<ClusterInstanceGroupSpecification> InstanceGroups
        {
            get { return this._instanceGroups; }
            set { this._instanceGroups = value; }
        }

        // Check to see if InstanceGroups property is set
        internal bool IsSetInstanceGroups()
        {
            return this._instanceGroups != null && (this._instanceGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Custom tags for managing the SageMaker HyperPod cluster as an Amazon Web Services
        /// resource. You can add tags to your cluster in the same way you add them in other Amazon
        /// Web Services services that support tagging. To learn more about tagging Amazon Web
        /// Services resources in general, see <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tagging.html">Tagging
        /// Amazon Web Services Resources User Guide</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcConfig.
        /// </summary>
        public VpcConfig VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

    }
}