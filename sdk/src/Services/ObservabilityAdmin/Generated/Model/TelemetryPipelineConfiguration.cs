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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
    /// Defines the configuration for a pipeline, including how data flows from sources through
    /// processors to destinations. The configuration is specified in YAML format and must
    /// include a valid pipeline definition with required source and sink components. This
    /// pipeline enables end-to-end telemetry data collection, transformation, and delivery
    /// while supporting optional processing steps and extensions for enhanced functionality.
    /// 
    ///  
    /// <para>
    /// The primary pipeline configuration section are:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Source:</b> Defines where log data originates from (S3 buckets, CloudWatch Logs,
    /// third-party APIs). Each pipeline must have exactly one source.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Processors (optional):</b> Transform, parse, and enrich log data as it flows through
    /// the pipeline. Processors are applied sequentially in the order they are defined.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Sink:</b> Defines the destination where processed log data is sent. Each pipeline
    /// must have exactly one sink.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Extensions (optional):</b> Provide additional functionality such as Amazon Web
    /// Services Secrets Manager integration for credential management.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more details on each configuration section see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/cloudwatch-pipelines.html">CloudWatch
    /// pipelines User Guide</a>. Additional comprehensive configuration examples can be found
    /// in the <a href="https://docs.aws.amazon.com/cloudwatch/latest/observabilityadmin/API_CreateTelemetryPipeline.html#API_CreateTelemetryPipeline_Examples">CreateTelemetryPipeline
    /// API docs</a>.
    /// </para>
    /// </summary>
    public partial class TelemetryPipelineConfiguration
    {
        private string _body;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The pipeline configuration body that defines the data processing rules and transformations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=24000)]
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

    }
}