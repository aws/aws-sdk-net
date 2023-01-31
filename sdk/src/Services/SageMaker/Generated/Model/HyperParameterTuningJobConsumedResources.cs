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
    /// The total resources consumed by your hyperparameter tuning job.
    /// </summary>
    public partial class HyperParameterTuningJobConsumedResources
    {
        private int? _runtimeInSeconds;

        /// <summary>
        /// Gets and sets the property RuntimeInSeconds. 
        /// <para>
        /// The wall clock runtime in seconds used by your hyperparameter tuning job.
        /// </para>
        /// </summary>
        public int RuntimeInSeconds
        {
            get { return this._runtimeInSeconds.GetValueOrDefault(); }
            set { this._runtimeInSeconds = value; }
        }

        // Check to see if RuntimeInSeconds property is set
        internal bool IsSetRuntimeInSeconds()
        {
            return this._runtimeInSeconds.HasValue; 
        }

    }
}