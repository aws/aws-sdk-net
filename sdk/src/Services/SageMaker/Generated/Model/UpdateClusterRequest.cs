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
    /// Container for the parameters to the UpdateCluster operation.
    /// Updates a SageMaker HyperPod cluster.
    /// </summary>
    public partial class UpdateClusterRequest : AmazonSageMakerRequest
    {
        private string _clusterName;
        private List<ClusterInstanceGroupSpecification> _instanceGroups = AWSConfigs.InitializeCollections ? new List<ClusterInstanceGroupSpecification>() : null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// Specify the name of the SageMaker HyperPod cluster you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
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
        /// Specify the instance groups to update.
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

    }
}