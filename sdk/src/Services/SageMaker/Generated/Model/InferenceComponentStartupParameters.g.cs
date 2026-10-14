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
    /// Settings that take effect while the model container starts up.
    /// </summary>
    public partial class InferenceComponentStartupParameters
    {
        /// <summary>
        /// Gets and sets the property ContainerStartupHealthCheckTimeoutInSeconds. 
        /// <para>
        /// The timeout value, in seconds, for your inference container to pass health check by
        /// Amazon S3 Hosting. For more information about health check, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms-inference-code.html#your-algorithms-inference-algo-ping-requests">How
        /// Your Container Should Respond to Health Check (Ping) Requests</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 3600)]
        public int? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ContainerStartupHealthCheckTimeoutInSeconds property is set.
        /// </summary>
        internal bool IsSetContainerStartupHealthCheckTimeoutInSeconds() => this.ContainerStartupHealthCheckTimeoutInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property ModelDataDownloadTimeoutInSeconds. 
        /// <para>
        /// The timeout value, in seconds, to download and extract the model that you want to
        /// host from Amazon S3 to the individual inference instance associated with this inference
        /// component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 3600)]
        public int? ModelDataDownloadTimeoutInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ModelDataDownloadTimeoutInSeconds property is set.
        /// </summary>
        internal bool IsSetModelDataDownloadTimeoutInSeconds() => this.ModelDataDownloadTimeoutInSeconds.HasValue;
    }
}
