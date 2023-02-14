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
    /// A flag to indicating that automatic model tuning (AMT) has detected model convergence,
    /// defined as a lack of significant improvement (1% or less) against an objective metric.
    /// </summary>
    public partial class ConvergenceDetected
    {
        private CompleteOnConvergence _completeOnConvergence;

        /// <summary>
        /// Gets and sets the property CompleteOnConvergence. 
        /// <para>
        /// A flag to stop a tuning job once AMT has detected that the job has converged.
        /// </para>
        /// </summary>
        public CompleteOnConvergence CompleteOnConvergence
        {
            get { return this._completeOnConvergence; }
            set { this._completeOnConvergence = value; }
        }

        // Check to see if CompleteOnConvergence property is set
        internal bool IsSetCompleteOnConvergence()
        {
            return this._completeOnConvergence != null;
        }

    }
}