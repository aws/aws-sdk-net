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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDataset operation.
    /// Creates a new Dataset resource asynchronously.
    /// 
    ///  
    /// <para>
    /// Returns immediately with status CREATING. Poll GetDataset until status transitions
    /// to ACTIVE or CREATE_FAILED (with failureReason).
    /// </para>
    /// </summary>
    public partial class CreateDatasetRequest : AmazonBedrockAgentCoreControlRequest
    {
        private string _clientToken;
        private string _datasetName;
        private string _description;
        private string _kmsKeyArn;
        private DatasetSchemaType _schemaType;
        private DataSourceType _source;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Optional idempotency token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// Human-readable name for the dataset. Unique within the account (case-insensitive).
        /// Immutable after creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DatasetName
        {
            get { return this._datasetName; }
            set { this._datasetName = value; }
        }

        // Check to see if DatasetName property is set
        internal bool IsSetDatasetName()
        {
            return this._datasetName != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the dataset. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// Optional AWS KMS key ARN for SSE-KMS on service S3 writes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaType. 
        /// <para>
        /// Versioned schema type governing the structure of examples. Immutable after creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DatasetSchemaType SchemaType
        {
            get { return this._schemaType; }
            set { this._schemaType = value; }
        }

        // Check to see if SchemaType property is set
        internal bool IsSetSchemaType()
        {
            return this._schemaType != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Source of initial examples. Provide either inline examples or an S3 URI pointing to
        /// a JSONL file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataSourceType Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A map of tag keys and values to assign to the dataset. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}