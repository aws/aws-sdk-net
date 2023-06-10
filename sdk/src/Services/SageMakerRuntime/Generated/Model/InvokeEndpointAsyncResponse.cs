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
 * Do not modify this file. This file is generated from the runtime.sagemaker-2017-05-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMakerRuntime.Model
{
    /// <summary>
    /// This is the response object from the InvokeEndpointAsync operation.
    /// </summary>
    public partial class InvokeEndpointAsyncResponse : AmazonWebServiceResponse
    {
        private string _failureLocation;
        private string _inferenceId;
        private string _outputLocation;

        /// <summary>
        /// Gets and sets the property FailureLocation. 
        /// <para>
        /// The Amazon S3 URI where the inference failure response payload is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string FailureLocation
        {
            get { return this._failureLocation; }
            set { this._failureLocation = value; }
        }

        // Check to see if FailureLocation property is set
        internal bool IsSetFailureLocation()
        {
            return this._failureLocation != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceId. 
        /// <para>
        /// Identifier for an inference request. This will be the same as the <code>InferenceId</code>
        /// specified in the input. Amazon SageMaker will generate an identifier for you if you
        /// do not specify one.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string InferenceId
        {
            get { return this._inferenceId; }
            set { this._inferenceId = value; }
        }

        // Check to see if InferenceId property is set
        internal bool IsSetInferenceId()
        {
            return this._inferenceId != null;
        }

        /// <summary>
        /// Gets and sets the property OutputLocation. 
        /// <para>
        /// The Amazon S3 URI where the inference response payload is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string OutputLocation
        {
            get { return this._outputLocation; }
            set { this._outputLocation = value; }
        }

        // Check to see if OutputLocation property is set
        internal bool IsSetOutputLocation()
        {
            return this._outputLocation != null;
        }

    }
}