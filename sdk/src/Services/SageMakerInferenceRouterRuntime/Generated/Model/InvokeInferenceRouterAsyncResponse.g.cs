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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SageMakerInferenceRouterRuntime.Model
{
    /// <summary>
    /// This is the response object from the InvokeInferenceRouterAsync operation.
    /// </summary>
    public partial class InvokeInferenceRouterAsyncResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property FailureLocation. 
        /// <para>
        /// The Amazon S3 URI where the failure details are written if the inference fails.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1024)]
        public string FailureLocation { get; set; }

        /// <summary>
        /// Checks to see if the FailureLocation property is set.
        /// </summary>
        internal bool IsSetFailureLocation() => this.FailureLocation != null;

        /// <summary>
        /// Gets and sets the property InferenceId. 
        /// <para>
        /// The identifier for the inference request. This is the <c>InferenceId</c> that you
        /// provided, or the one that SageMaker AI generated.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1024)]
        public string InferenceId { get; set; }

        /// <summary>
        /// Checks to see if the InferenceId property is set.
        /// </summary>
        internal bool IsSetInferenceId() => this.InferenceId != null;

        /// <summary>
        /// Gets and sets the property OutputLocation. 
        /// <para>
        /// The Amazon S3 URI where the inference response is written. The location doesn't change
        /// if the router moves the request to another destination.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1024)]
        public string OutputLocation { get; set; }

        /// <summary>
        /// Checks to see if the OutputLocation property is set.
        /// </summary>
        internal bool IsSetOutputLocation() => this.OutputLocation != null;
    }
}
