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
    /// Summarizes an optimization job by providing some of its key properties.
    /// </summary>
    public partial class OptimizationJobSummary
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when you created the optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeploymentInstanceType. 
        /// <para>
        /// The type of instance that hosts the optimized model that you create with the optimization
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OptimizationJobDeploymentInstanceType DeploymentInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentInstanceType property is set.
        /// </summary>
        internal bool IsSetDeploymentInstanceType() => this.DeploymentInstanceType != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time when the optimization job was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property MaxInstanceCount. 
        /// <para>
        /// The maximum number of instances to use for the optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxInstanceCount property is set.
        /// </summary>
        internal bool IsSetMaxInstanceCount() => this.MaxInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property OptimizationEndTime. 
        /// <para>
        /// The time when the optimization job finished processing.
        /// </para>
        /// </summary>
        public DateTime? OptimizationEndTime { get; set; }

        /// <summary>
        /// Checks to see if the OptimizationEndTime property is set.
        /// </summary>
        internal bool IsSetOptimizationEndTime() => this.OptimizationEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property OptimizationJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string OptimizationJobArn { get; set; }

        /// <summary>
        /// Checks to see if the OptimizationJobArn property is set.
        /// </summary>
        internal bool IsSetOptimizationJobArn() => this.OptimizationJobArn != null;

        /// <summary>
        /// Gets and sets the property OptimizationJobName. 
        /// <para>
        /// The name that you assigned to the optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string OptimizationJobName { get; set; }

        /// <summary>
        /// Checks to see if the OptimizationJobName property is set.
        /// </summary>
        internal bool IsSetOptimizationJobName() => this.OptimizationJobName != null;

        /// <summary>
        /// Gets and sets the property OptimizationJobStatus. 
        /// <para>
        /// The current status of the optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OptimizationJobStatus OptimizationJobStatus { get; set; }

        /// <summary>
        /// Checks to see if the OptimizationJobStatus property is set.
        /// </summary>
        internal bool IsSetOptimizationJobStatus() => this.OptimizationJobStatus != null;

        /// <summary>
        /// Gets and sets the property OptimizationStartTime. 
        /// <para>
        /// The time when the optimization job started.
        /// </para>
        /// </summary>
        public DateTime? OptimizationStartTime { get; set; }

        /// <summary>
        /// Checks to see if the OptimizationStartTime property is set.
        /// </summary>
        internal bool IsSetOptimizationStartTime() => this.OptimizationStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property OptimizationTypes. 
        /// <para>
        /// The optimization techniques that are applied by the optimization job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> OptimizationTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OptimizationTypes property is set.
        /// </summary>
        internal bool IsSetOptimizationTypes() => this.OptimizationTypes != null && (this.OptimizationTypes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
