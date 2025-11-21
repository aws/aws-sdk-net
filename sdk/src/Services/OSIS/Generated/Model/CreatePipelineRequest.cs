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
    /// Container for the parameters to the CreatePipeline operation.
    /// Creates an OpenSearch Ingestion pipeline. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/creating-pipeline.html">Creating
    /// Amazon OpenSearch Ingestion pipelines</a>.
    /// </summary>
    public partial class CreatePipelineRequest : AmazonOSISRequest
    {
        private BufferOptions _bufferOptions;
        private EncryptionAtRestOptions _encryptionAtRestOptions;
        private LogPublishingOptions _logPublishingOptions;
        private int? _maxUnits;
        private int? _minUnits;
        private string _pipelineConfigurationBody;
        private string _pipelineName;
        private string _pipelineRoleArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private VpcOptions _vpcOptions;

        /// <summary>
        /// Gets and sets the property BufferOptions. 
        /// <para>
        /// Key-value pairs to configure persistent buffering for the pipeline.
        /// </para>
        /// </summary>
        public BufferOptions BufferOptions
        {
            get { return this._bufferOptions; }
            set { this._bufferOptions = value; }
        }

        // Check to see if BufferOptions property is set
        internal bool IsSetBufferOptions()
        {
            return this._bufferOptions != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionAtRestOptions. 
        /// <para>
        /// Key-value pairs to configure encryption for data that is written to a persistent buffer.
        /// </para>
        /// </summary>
        public EncryptionAtRestOptions EncryptionAtRestOptions
        {
            get { return this._encryptionAtRestOptions; }
            set { this._encryptionAtRestOptions = value; }
        }

        // Check to see if EncryptionAtRestOptions property is set
        internal bool IsSetEncryptionAtRestOptions()
        {
            return this._encryptionAtRestOptions != null;
        }

        /// <summary>
        /// Gets and sets the property LogPublishingOptions. 
        /// <para>
        /// Key-value pairs to configure log publishing.
        /// </para>
        /// </summary>
        public LogPublishingOptions LogPublishingOptions
        {
            get { return this._logPublishingOptions; }
            set { this._logPublishingOptions = value; }
        }

        // Check to see if LogPublishingOptions property is set
        internal bool IsSetLogPublishingOptions()
        {
            return this._logPublishingOptions != null;
        }

        /// <summary>
        /// Gets and sets the property MaxUnits. 
        /// <para>
        /// The maximum pipeline capacity, in Ingestion Compute Units (ICUs).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? MaxUnits
        {
            get { return this._maxUnits; }
            set { this._maxUnits = value; }
        }

        // Check to see if MaxUnits property is set
        internal bool IsSetMaxUnits()
        {
            return this._maxUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinUnits. 
        /// <para>
        /// The minimum pipeline capacity, in Ingestion Compute Units (ICUs).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? MinUnits
        {
            get { return this._minUnits; }
            set { this._minUnits = value; }
        }

        // Check to see if MinUnits property is set
        internal bool IsSetMinUnits()
        {
            return this._minUnits.HasValue; 
        }

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

        /// <summary>
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the OpenSearch Ingestion pipeline to create. Pipeline names are unique
        /// across the pipelines owned by an account within an Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=28)]
        public string PipelineName
        {
            get { return this._pipelineName; }
            set { this._pipelineName = value; }
        }

        // Check to see if PipelineName property is set
        internal bool IsSetPipelineName()
        {
            return this._pipelineName != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that grants the pipeline permission
        /// to access Amazon Web Services resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string PipelineRoleArn
        {
            get { return this._pipelineRoleArn; }
            set { this._pipelineRoleArn = value; }
        }

        // Check to see if PipelineRoleArn property is set
        internal bool IsSetPipelineRoleArn()
        {
            return this._pipelineRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// List of tags to add to the pipeline upon creation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcOptions. 
        /// <para>
        /// Container for the values required to configure VPC access for the pipeline. If you
        /// don't specify these values, OpenSearch Ingestion creates the pipeline with a public
        /// endpoint.
        /// </para>
        /// </summary>
        public VpcOptions VpcOptions
        {
            get { return this._vpcOptions; }
            set { this._vpcOptions = value; }
        }

        // Check to see if VpcOptions property is set
        internal bool IsSetVpcOptions()
        {
            return this._vpcOptions != null;
        }

    }
}