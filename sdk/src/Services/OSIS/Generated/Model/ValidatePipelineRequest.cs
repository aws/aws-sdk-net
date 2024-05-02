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
 * Do not modify this file. This file is generated from the osis-2022-01-01.normal.json service model.
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
    /// Container for the parameters to the ValidatePipeline operation.
    /// Checks whether an OpenSearch Ingestion pipeline configuration is valid prior to creation.
    /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/creating-pipeline.html">Creating
    /// Amazon OpenSearch Ingestion pipelines</a>.
    /// </summary>
    public partial class ValidatePipelineRequest : AmazonOSISRequest
    {
        private string _pipelineConfigurationBody;

        /// <summary>
        /// Gets and sets the property PipelineConfigurationBody. 
        /// <para>
        /// The pipeline configuration in YAML format. The command accepts the pipeline configuration
        /// as a string or within a .yaml file. If you provide the configuration as a string,
        /// each new line must be escaped with <c>\n</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=24000)]
        public string PipelineConfigurationBody
        {
            get { return this._pipelineConfigurationBody; }
            set { this._pipelineConfigurationBody = value; }
        }

        // Check to see if PipelineConfigurationBody property is set
        internal bool IsSetPipelineConfigurationBody()
        {
            return this._pipelineConfigurationBody != null;
        }

    }
}