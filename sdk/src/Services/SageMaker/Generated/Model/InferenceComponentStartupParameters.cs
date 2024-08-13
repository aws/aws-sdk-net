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
    /// Settings that take effect while the model container starts up.
    /// </summary>
    public partial class InferenceComponentStartupParameters
    {
        private int? _containerStartupHealthCheckTimeoutInSeconds;
        private int? _modelDataDownloadTimeoutInSeconds;

        /// <summary>
        /// Gets and sets the property ContainerStartupHealthCheckTimeoutInSeconds. 
        /// <para>
        /// The timeout value, in seconds, for your inference container to pass health check by
        /// Amazon S3 Hosting. For more information about health check, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms-inference-code.html#your-algorithms-inference-algo-ping-requests">How
        /// Your Container Should Respond to Health Check (Ping) Requests</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=3600)]
        public int? ContainerStartupHealthCheckTimeoutInSeconds
        {
            get { return this._containerStartupHealthCheckTimeoutInSeconds; }
            set { this._containerStartupHealthCheckTimeoutInSeconds = value; }
        }

        // Check to see if ContainerStartupHealthCheckTimeoutInSeconds property is set
        internal bool IsSetContainerStartupHealthCheckTimeoutInSeconds()
        {
            return this._containerStartupHealthCheckTimeoutInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelDataDownloadTimeoutInSeconds. 
        /// <para>
        /// The timeout value, in seconds, to download and extract the model that you want to
        /// host from Amazon S3 to the individual inference instance associated with this inference
        /// component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=3600)]
        public int? ModelDataDownloadTimeoutInSeconds
        {
            get { return this._modelDataDownloadTimeoutInSeconds; }
            set { this._modelDataDownloadTimeoutInSeconds = value; }
        }

        // Check to see if ModelDataDownloadTimeoutInSeconds property is set
        internal bool IsSetModelDataDownloadTimeoutInSeconds()
        {
            return this._modelDataDownloadTimeoutInSeconds.HasValue; 
        }

    }
}