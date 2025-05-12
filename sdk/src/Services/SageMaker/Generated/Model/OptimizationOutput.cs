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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Output values produced by an optimization job.
    /// </summary>
    public partial class OptimizationOutput
    {
        private string _recommendedInferenceImage;

        /// <summary>
        /// Gets and sets the property RecommendedInferenceImage. 
        /// <para>
        /// The image that SageMaker recommends that you use to host the optimized model that
        /// you created with an optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string RecommendedInferenceImage
        {
            get { return this._recommendedInferenceImage; }
            set { this._recommendedInferenceImage = value; }
        }

        // Check to see if RecommendedInferenceImage property is set
        internal bool IsSetRecommendedInferenceImage()
        {
            return this._recommendedInferenceImage != null;
        }

    }
}