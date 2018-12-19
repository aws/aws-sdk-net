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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Specifies how long model training can run. When model training reaches the limit,
    /// Amazon SageMaker ends the training job. Use this API to cap model training cost.
    /// 
    ///  
    /// <para>
    /// To stop a job, Amazon SageMaker sends the algorithm the <code>SIGTERM</code> signal,
    /// which delays job termination for120 seconds. Algorithms might use this 120-second
    /// window to save the model artifacts, so the results of training is not lost. 
    /// </para>
    ///  
    /// <para>
    /// Training algorithms provided by Amazon SageMaker automatically saves the intermediate
    /// results of a model training job (it is best effort case, as model might not be ready
    /// to save as some stages, for example training just started). This intermediate data
    /// is a valid model artifact. You can use it to create a model (<code>CreateModel</code>).
    /// 
    /// </para>
    /// </summary>
    public partial class StoppingCondition
    {
        private int? _maxRuntimeInSeconds;

        /// <summary>
        /// Gets and sets the property MaxRuntimeInSeconds. 
        /// <para>
        /// The maximum length of time, in seconds, that the training job can run. If model training
        /// does not complete during this time, Amazon SageMaker ends the job. If value is not
        /// specified, default value is 1 day. Maximum value is 5 days.
        /// </para>
        /// </summary>
        public int MaxRuntimeInSeconds
        {
            get { return this._maxRuntimeInSeconds.GetValueOrDefault(); }
            set { this._maxRuntimeInSeconds = value; }
        }

        // Check to see if MaxRuntimeInSeconds property is set
        internal bool IsSetMaxRuntimeInSeconds()
        {
            return this._maxRuntimeInSeconds.HasValue; 
        }

    }
}