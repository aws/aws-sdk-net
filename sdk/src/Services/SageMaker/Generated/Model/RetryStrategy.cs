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
    /// The retry strategy to use when a training job fails due to an <code>InternalServerError</code>.
    /// <code>RetryStrategy</code> is specified as part of the <code>CreateTrainingJob</code>
    /// and <code>CreateHyperParameterTuningJob</code> requests. You can add the <code>StoppingCondition</code>
    /// parameter to the request to limit the training time for the complete job.
    /// </summary>
    public partial class RetryStrategy
    {
        private int? _maximumRetryAttempts;

        /// <summary>
        /// Gets and sets the property MaximumRetryAttempts. 
        /// <para>
        /// The number of times to retry the job. When the job is retried, it's <code>SecondaryStatus</code>
        /// is changed to <code>STARTING</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=30)]
        public int MaximumRetryAttempts
        {
            get { return this._maximumRetryAttempts.GetValueOrDefault(); }
            set { this._maximumRetryAttempts = value; }
        }

        // Check to see if MaximumRetryAttempts property is set
        internal bool IsSetMaximumRetryAttempts()
        {
            return this._maximumRetryAttempts.HasValue; 
        }

    }
}