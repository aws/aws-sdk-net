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
    /// This is the response object from the StopInferenceExperiment operation.
    /// </summary>
    public partial class StopInferenceExperimentResponse : AmazonWebServiceResponse
    {
        private string _inferenceExperimentArn;

        /// <summary>
        /// Gets and sets the property InferenceExperimentArn. 
        /// <para>
        /// The ARN of the stopped inference experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string InferenceExperimentArn
        {
            get { return this._inferenceExperimentArn; }
            set { this._inferenceExperimentArn = value; }
        }

        // Check to see if InferenceExperimentArn property is set
        internal bool IsSetInferenceExperimentArn()
        {
            return this._inferenceExperimentArn != null;
        }

    }
}