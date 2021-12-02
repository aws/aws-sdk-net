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
    /// Specifies conditions for stopping a job. When a job reaches a stopping condition limit,
    /// SageMaker ends the job.
    /// </summary>
    public partial class RecommendationJobStoppingConditions
    {
        private int? _maxInvocations;
        private List<ModelLatencyThreshold> _modelLatencyThresholds = new List<ModelLatencyThreshold>();

        /// <summary>
        /// Gets and sets the property MaxInvocations. 
        /// <para>
        /// The maximum number of requests per minute expected for the endpoint.
        /// </para>
        /// </summary>
        public int MaxInvocations
        {
            get { return this._maxInvocations.GetValueOrDefault(); }
            set { this._maxInvocations = value; }
        }

        // Check to see if MaxInvocations property is set
        internal bool IsSetMaxInvocations()
        {
            return this._maxInvocations.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelLatencyThresholds. 
        /// <para>
        /// The interval of time taken by a model to respond as viewed from SageMaker. The interval
        /// includes the local communication time taken to send the request and to fetch the response
        /// from the container of a model and the time taken to complete the inference in the
        /// container.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<ModelLatencyThreshold> ModelLatencyThresholds
        {
            get { return this._modelLatencyThresholds; }
            set { this._modelLatencyThresholds = value; }
        }

        // Check to see if ModelLatencyThresholds property is set
        internal bool IsSetModelLatencyThresholds()
        {
            return this._modelLatencyThresholds != null && this._modelLatencyThresholds.Count > 0; 
        }

    }
}