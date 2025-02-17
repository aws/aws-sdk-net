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
    /// Lists a summary of the properties of a SageMaker HyperPod cluster.
    /// </summary>
    public partial class ClusterSummary
    {
        private string _clusterArn;
        private string _clusterName;
        private ClusterStatus _clusterStatus;
        private DateTime? _creationTime;
        private List<string> _trainingPlanArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
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
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the SageMaker HyperPod cluster.
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
        /// Gets and sets the property ClusterStatus. 
        /// <para>
        /// The status of the SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClusterStatus ClusterStatus
        {
            get { return this._clusterStatus; }
            set { this._clusterStatus = value; }
        }

        // Check to see if ClusterStatus property is set
        internal bool IsSetClusterStatus()
        {
            return this._clusterStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the SageMaker HyperPod cluster is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrainingPlanArns. 
        /// <para>
        /// A list of Amazon Resource Names (ARNs) of the training plans associated with this
        /// cluster.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to reserve GPU capacity for your SageMaker HyperPod
        /// clusters using Amazon SageMaker Training Plan, see <c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingPlan.html">CreateTrainingPlan</a>
        /// </c>.
        /// </para>
        /// </summary>
        public List<string> TrainingPlanArns
        {
            get { return this._trainingPlanArns; }
            set { this._trainingPlanArns = value; }
        }

        // Check to see if TrainingPlanArns property is set
        internal bool IsSetTrainingPlanArns()
        {
            return this._trainingPlanArns != null && (this._trainingPlanArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}