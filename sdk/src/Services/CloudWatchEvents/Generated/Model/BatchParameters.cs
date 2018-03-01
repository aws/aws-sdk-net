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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// The custom parameters to be used when the target is an AWS Batch job.
    /// </summary>
    public partial class BatchParameters
    {
        private BatchArrayProperties _arrayProperties;
        private string _jobDefinition;
        private string _jobName;
        private BatchRetryStrategy _retryStrategy;

        /// <summary>
        /// Gets and sets the property ArrayProperties. 
        /// <para>
        /// The array properties for the submitted job, such as the size of the array. The array
        /// size can be between 2 and 10,000. If you specify array properties for a job, it becomes
        /// an array job. This parameter is used only if the target is an AWS Batch job.
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
        /// Gets and sets the property JobDefinition. 
        /// <para>
        /// The ARN or name of the job definition to use if the event target is an AWS Batch job.
        /// This job definition must already exist.
        /// </para>
        /// </summary>
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
        /// The name to use for this execution of the job, if the target is an AWS Batch job.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property RetryStrategy. 
        /// <para>
        /// The retry strategy to use for failed jobs, if the target is an AWS Batch job. The
        /// retry strategy is the number of times to retry the failed job execution. Valid values
        /// are 1 to 10. When you specify a retry strategy here, it overrides the retry strategy
        /// defined in the job definition.
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