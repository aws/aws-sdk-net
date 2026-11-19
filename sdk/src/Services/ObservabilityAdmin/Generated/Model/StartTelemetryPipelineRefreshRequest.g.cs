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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Container for the parameters to the StartTelemetryPipelineRefresh operation. Starts
    /// a refresh of an external-cloud telemetry pipeline. The refresh re-reads the connector's
    /// telemetry manifest and re-discovers the sources in scope. <para> The pipeline must
    /// be in the <c>ACTIVE</c> or <c>UPDATE_FAILED</c> state, with no refresh already running.
    /// You can use <c>GetTelemetryPipeline</c> to track the refresh. </para>
    /// </summary>
    public partial class StartTelemetryPipelineRefreshRequest : AmazonObservabilityAdminRequest
    {
        /// <summary>
        /// Gets and sets the property PipelineIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the telemetry pipeline to refresh.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string PipelineIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the PipelineIdentifier property is set.
        /// </summary>
        internal bool IsSetPipelineIdentifier() => this.PipelineIdentifier != null;
    }
}
