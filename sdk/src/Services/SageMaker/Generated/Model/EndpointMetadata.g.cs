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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The metadata of the endpoint.
    /// </summary>
    public partial class EndpointMetadata
    {
        /// <summary>
        /// Gets and sets the property EndpointConfigName. 
        /// <para>
        /// The name of the endpoint configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string EndpointConfigName { get; set; }

        /// <summary>
        /// Checks to see if the EndpointConfigName property is set.
        /// </summary>
        internal bool IsSetEndpointConfigName() => this.EndpointConfigName != null;

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string EndpointName { get; set; }

        /// <summary>
        /// Checks to see if the EndpointName property is set.
        /// </summary>
        internal bool IsSetEndpointName() => this.EndpointName != null;

        /// <summary>
        /// Gets and sets the property EndpointStatus. 
        /// <para>
        ///  The status of the endpoint. For possible values of the status of an endpoint, see
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_EndpointSummary.html">EndpointSummary</a>.
        /// 
        /// </para>
        /// </summary>
        public EndpointStatus EndpointStatus { get; set; }

        /// <summary>
        /// Checks to see if the EndpointStatus property is set.
        /// </summary>
        internal bool IsSetEndpointStatus() => this.EndpointStatus != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        ///  If the status of the endpoint is <c>Failed</c>, or the status is <c>InService</c>
        /// but update operation fails, this provides the reason why it failed. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;
    }
}
