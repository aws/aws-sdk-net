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
    /// This is the response object from the UpdateInferenceComponentRuntimeConfig operation.
    /// </summary>
    public partial class UpdateInferenceComponentRuntimeConfigResponse : AmazonWebServiceResponse
    {
        private string _inferenceComponentArn;

        /// <summary>
        /// Gets and sets the property InferenceComponentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the inference component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string InferenceComponentArn
        {
            get { return this._inferenceComponentArn; }
            set { this._inferenceComponentArn = value; }
        }

        // Check to see if InferenceComponentArn property is set
        internal bool IsSetInferenceComponentArn()
        {
            return this._inferenceComponentArn != null;
        }

    }
}