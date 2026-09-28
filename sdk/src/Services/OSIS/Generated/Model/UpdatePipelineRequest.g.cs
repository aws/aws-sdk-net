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

namespace Amazon.OSIS.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePipeline operation. Updates an OpenSearch
    /// Ingestion pipeline. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/update-pipeline.html">Updating
    /// Amazon OpenSearch Ingestion pipelines</a>.
    /// </summary>
    public partial class UpdatePipelineRequest : AmazonOSISRequest
    {
        /// <summary>
        /// Gets and sets the property BufferOptions. 
        /// <para>
        /// Key-value pairs to configure persistent buffering for the pipeline.
        /// </para>
        /// </summary>
        public BufferOptions BufferOptions { get; set; }

        /// <summary>
        /// Checks to see if the BufferOptions property is set.
        /// </summary>
        internal bool IsSetBufferOptions() => this.BufferOptions != null;

        /// <summary>
        /// Gets and sets the property EncryptionAtRestOptions. 
        /// <para>
        /// Key-value pairs to configure encryption for data that is written to a persistent buffer.
        /// </para>
        /// </summary>
        public EncryptionAtRestOptions EncryptionAtRestOptions { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionAtRestOptions property is set.
        /// </summary>
        internal bool IsSetEncryptionAtRestOptions() => this.EncryptionAtRestOptions != null;

        /// <summary>
        /// Gets and sets the property LogPublishingOptions. 
        /// <para>
        /// Key-value pairs to configure log publishing.
        /// </para>
        /// </summary>
        public LogPublishingOptions LogPublishingOptions { get; set; }

        /// <summary>
        /// Checks to see if the LogPublishingOptions property is set.
        /// </summary>
        internal bool IsSetLogPublishingOptions() => this.LogPublishingOptions != null;

        /// <summary>
        /// Gets and sets the property MaxUnits. 
        /// <para>
        /// The maximum pipeline capacity, in Ingestion Compute Units (ICUs)
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxUnits { get; set; }

        /// <summary>
        /// Checks to see if the MaxUnits property is set.
        /// </summary>
        internal bool IsSetMaxUnits() => this.MaxUnits.HasValue;

        /// <summary>
        /// Gets and sets the property MinUnits. 
        /// <para>
        /// The minimum pipeline capacity, in Ingestion Compute Units (ICUs).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MinUnits { get; set; }

        /// <summary>
        /// Checks to see if the MinUnits property is set.
        /// </summary>
        internal bool IsSetMinUnits() => this.MinUnits.HasValue;

        /// <summary>
        /// Gets and sets the property PipelineConfigurationBody. 
        /// <para>
        /// The pipeline configuration in YAML format. The command accepts the pipeline configuration
        /// as a string or within a .yaml file. If you provide the configuration as a string,
        /// each new line must be escaped with <c>\n</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100000)]
        public string PipelineConfigurationBody { get; set; }

        /// <summary>
        /// Checks to see if the PipelineConfigurationBody property is set.
        /// </summary>
        internal bool IsSetPipelineConfigurationBody() => this.PipelineConfigurationBody != null;

        /// <summary>
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 28)]
        public string PipelineName { get; set; }

        /// <summary>
        /// Checks to see if the PipelineName property is set.
        /// </summary>
        internal bool IsSetPipelineName() => this.PipelineName != null;

        /// <summary>
        /// Gets and sets the property PipelineRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that grants the pipeline permission
        /// to access Amazon Web Services resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string PipelineRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the PipelineRoleArn property is set.
        /// </summary>
        internal bool IsSetPipelineRoleArn() => this.PipelineRoleArn != null;
    }
}
