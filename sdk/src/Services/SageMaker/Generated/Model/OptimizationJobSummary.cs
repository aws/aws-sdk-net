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
    /// Summarizes an optimization job by providing some of its key properties.
    /// </summary>
    public partial class OptimizationJobSummary
    {
        private DateTime? _creationTime;
        private OptimizationJobDeploymentInstanceType _deploymentInstanceType;
        private DateTime? _lastModifiedTime;
        private DateTime? _optimizationEndTime;
        private string _optimizationJobArn;
        private string _optimizationJobName;
        private OptimizationJobStatus _optimizationJobStatus;
        private DateTime? _optimizationStartTime;
        private List<string> _optimizationTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when you created the optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentInstanceType. 
        /// <para>
        /// The type of instance that hosts the optimized model that you create with the optimization
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OptimizationJobDeploymentInstanceType DeploymentInstanceType
        {
            get { return this._deploymentInstanceType; }
            set { this._deploymentInstanceType = value; }
        }

        // Check to see if DeploymentInstanceType property is set
        internal bool IsSetDeploymentInstanceType()
        {
            return this._deploymentInstanceType != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time when the optimization job was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OptimizationEndTime. 
        /// <para>
        /// The time when the optimization job finished processing.
        /// </para>
        /// </summary>
        public DateTime? OptimizationEndTime
        {
            get { return this._optimizationEndTime; }
            set { this._optimizationEndTime = value; }
        }

        // Check to see if OptimizationEndTime property is set
        internal bool IsSetOptimizationEndTime()
        {
            return this._optimizationEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OptimizationJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string OptimizationJobArn
        {
            get { return this._optimizationJobArn; }
            set { this._optimizationJobArn = value; }
        }

        // Check to see if OptimizationJobArn property is set
        internal bool IsSetOptimizationJobArn()
        {
            return this._optimizationJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property OptimizationJobName. 
        /// <para>
        /// The name that you assigned to the optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string OptimizationJobName
        {
            get { return this._optimizationJobName; }
            set { this._optimizationJobName = value; }
        }

        // Check to see if OptimizationJobName property is set
        internal bool IsSetOptimizationJobName()
        {
            return this._optimizationJobName != null;
        }

        /// <summary>
        /// Gets and sets the property OptimizationJobStatus. 
        /// <para>
        /// The current status of the optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OptimizationJobStatus OptimizationJobStatus
        {
            get { return this._optimizationJobStatus; }
            set { this._optimizationJobStatus = value; }
        }

        // Check to see if OptimizationJobStatus property is set
        internal bool IsSetOptimizationJobStatus()
        {
            return this._optimizationJobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property OptimizationStartTime. 
        /// <para>
        /// The time when the optimization job started.
        /// </para>
        /// </summary>
        public DateTime? OptimizationStartTime
        {
            get { return this._optimizationStartTime; }
            set { this._optimizationStartTime = value; }
        }

        // Check to see if OptimizationStartTime property is set
        internal bool IsSetOptimizationStartTime()
        {
            return this._optimizationStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OptimizationTypes. 
        /// <para>
        /// The optimization techniques that are applied by the optimization job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> OptimizationTypes
        {
            get { return this._optimizationTypes; }
            set { this._optimizationTypes = value; }
        }

        // Check to see if OptimizationTypes property is set
        internal bool IsSetOptimizationTypes()
        {
            return this._optimizationTypes != null && (this._optimizationTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}