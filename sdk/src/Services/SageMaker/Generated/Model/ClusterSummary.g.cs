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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property ClusterStatus. 
        /// <para>
        /// The status of the SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ClusterStatus ClusterStatus { get; set; }

        /// <summary>
        /// Checks to see if the ClusterStatus property is set.
        /// </summary>
        internal bool IsSetClusterStatus() => this.ClusterStatus != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the SageMaker HyperPod cluster is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property ImageVersionStatus. 
        /// <para>
        /// The aggregate status of the image version across the cluster's instance groups.
        /// </para>
        /// </summary>
        public ClusterImageVersionStatus ImageVersionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ImageVersionStatus property is set.
        /// </summary>
        internal bool IsSetImageVersionStatus() => this.ImageVersionStatus != null;

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TrainingPlanArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TrainingPlanArns property is set.
        /// </summary>
        internal bool IsSetTrainingPlanArns() => this.TrainingPlanArns != null && (this.TrainingPlanArns.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
