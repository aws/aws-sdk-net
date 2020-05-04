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
    /// How long a job is allowed to run, or how many candidates a job is allowed to generate.
    /// </summary>
    public partial class AutoMLJobCompletionCriteria
    {
        private int? _maxAutoMLJobRuntimeInSeconds;
        private int? _maxCandidates;
        private int? _maxRuntimePerTrainingJobInSeconds;

        /// <summary>
        /// Gets and sets the property MaxAutoMLJobRuntimeInSeconds. 
        /// <para>
        /// The maximum time, in seconds, an AutoML job is allowed to wait for a trial to complete.
        /// It must be equal to or greater than MaxRuntimePerTrainingJobInSeconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int MaxAutoMLJobRuntimeInSeconds
        {
            get { return this._maxAutoMLJobRuntimeInSeconds.GetValueOrDefault(); }
            set { this._maxAutoMLJobRuntimeInSeconds = value; }
        }

        // Check to see if MaxAutoMLJobRuntimeInSeconds property is set
        internal bool IsSetMaxAutoMLJobRuntimeInSeconds()
        {
            return this._maxAutoMLJobRuntimeInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxCandidates. 
        /// <para>
        /// The maximum number of times a training job is allowed to run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int MaxCandidates
        {
            get { return this._maxCandidates.GetValueOrDefault(); }
            set { this._maxCandidates = value; }
        }

        // Check to see if MaxCandidates property is set
        internal bool IsSetMaxCandidates()
        {
            return this._maxCandidates.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxRuntimePerTrainingJobInSeconds. 
        /// <para>
        /// The maximum time, in seconds, a job is allowed to run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int MaxRuntimePerTrainingJobInSeconds
        {
            get { return this._maxRuntimePerTrainingJobInSeconds.GetValueOrDefault(); }
            set { this._maxRuntimePerTrainingJobInSeconds = value; }
        }

        // Check to see if MaxRuntimePerTrainingJobInSeconds property is set
        internal bool IsSetMaxRuntimePerTrainingJobInSeconds()
        {
            return this._maxRuntimePerTrainingJobInSeconds.HasValue; 
        }

    }
}