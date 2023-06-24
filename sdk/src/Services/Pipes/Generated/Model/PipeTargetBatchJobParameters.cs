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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The parameters for using an Batch job as a target.
    /// </summary>
    public partial class PipeTargetBatchJobParameters
    {
        private BatchArrayProperties _arrayProperties;
        private BatchContainerOverrides _containerOverrides;
        private List<BatchJobDependency> _dependsOn = new List<BatchJobDependency>();
        private string _jobDefinition;
        private string _jobName;
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private BatchRetryStrategy _retryStrategy;

        /// <summary>
        /// Gets and sets the property ArrayProperties. 
        /// <para>
        /// The array properties for the submitted job, such as the size of the array. The array
        /// size can be between 2 and 10,000. If you specify array properties for a job, it becomes
        /// an array job. This parameter is used only if the target is an Batch job.
        /// </para>
        /// </summary>
        public BatchArrayProperties ArrayProperties
        {
            get { return this._arrayProperties; }
            set { this._arrayProperties = value; }
        }

        // Check to see if ArrayProperties property is set
        internal bool IsSetArrayProperties()
        {
            return this._arrayProperties != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerOverrides. 
        /// <para>
        /// The overrides that are sent to a container.
        /// </para>
        /// </summary>
        public BatchContainerOverrides ContainerOverrides
        {
            get { return this._containerOverrides; }
            set { this._containerOverrides = value; }
        }

        // Check to see if ContainerOverrides property is set
        internal bool IsSetContainerOverrides()
        {
            return this._containerOverrides != null;
        }

        /// <summary>
        /// Gets and sets the property DependsOn. 
        /// <para>
        /// A list of dependencies for the job. A job can depend upon a maximum of 20 jobs. You
        /// can specify a <code>SEQUENTIAL</code> type dependency without specifying a job ID
        /// for array jobs so that each child array job completes sequentially, starting at index
        /// 0. You can also specify an <code>N_TO_N</code> type dependency with a job ID for array
        /// jobs. In that case, each index child of this job must wait for the corresponding index
        /// child of each dependency to complete before it can begin.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<BatchJobDependency> DependsOn
        {
            get { return this._dependsOn; }
            set { this._dependsOn = value; }
        }

        // Check to see if DependsOn property is set
        internal bool IsSetDependsOn()
        {
            return this._dependsOn != null && this._dependsOn.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property JobDefinition. 
        /// <para>
        /// The job definition used by this job. This value can be one of <code>name</code>, <code>name:revision</code>,
        /// or the Amazon Resource Name (ARN) for the job definition. If name is specified without
        /// a revision then the latest active revision is used.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobDefinition
        {
            get { return this._jobDefinition; }
            set { this._jobDefinition = value; }
        }

        // Check to see if JobDefinition property is set
        internal bool IsSetJobDefinition()
        {
            return this._jobDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job. It can be up to 128 letters long. The first character must be
        /// alphanumeric, can contain uppercase and lowercase letters, numbers, hyphens (-), and
        /// underscores (_).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Additional parameters passed to the job that replace parameter substitution placeholders
        /// that are set in the job definition. Parameters are specified as a key and value pair
        /// mapping. Parameters included here override any corresponding parameter defaults from
        /// the job definition.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RetryStrategy. 
        /// <para>
        /// The retry strategy to use for failed jobs. When a retry strategy is specified here,
        /// it overrides the retry strategy defined in the job definition.
        /// </para>
        /// </summary>
        public BatchRetryStrategy RetryStrategy
        {
            get { return this._retryStrategy; }
            set { this._retryStrategy = value; }
        }

        // Check to see if RetryStrategy property is set
        internal bool IsSetRetryStrategy()
        {
            return this._retryStrategy != null;
        }

    }
}