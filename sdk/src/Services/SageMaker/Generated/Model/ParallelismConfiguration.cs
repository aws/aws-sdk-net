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
    /// Configuration that controls the parallelism of the pipeline. By default, the parallelism
    /// configuration specified applies to all executions of the pipeline unless overridden.
    /// </summary>
    public partial class ParallelismConfiguration
    {
        private int? _maxParallelExecutionSteps;

        /// <summary>
        /// Gets and sets the property MaxParallelExecutionSteps. 
        /// <para>
        /// The max number of steps that can be executed in parallel. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int MaxParallelExecutionSteps
        {
            get { return this._maxParallelExecutionSteps.GetValueOrDefault(); }
            set { this._maxParallelExecutionSteps = value; }
        }

        // Check to see if MaxParallelExecutionSteps property is set
        internal bool IsSetMaxParallelExecutionSteps()
        {
            return this._maxParallelExecutionSteps.HasValue; 
        }

    }
}