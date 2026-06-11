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
    /// Summary information about a dataset.
    /// </summary>
    public partial class DatasetSummary
    {
        private DateTime? _createdAt;
        private string _datasetArn;
        private string _datasetId;
        private string _datasetName;
        private string _description;
        private DraftStatus _draftStatus;
        private long? _exampleCount;
        private DatasetSchemaType _schemaType;
        private DatasetStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The timestamp when the dataset was created. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the dataset. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DatasetArn
        {
            get { return this._datasetArn; }
            set { this._datasetArn = value; }
        }

        // Check to see if DatasetArn property is set
        internal bool IsSetDatasetArn()
        {
            return this._datasetArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        ///  The unique identifier of the dataset. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DatasetId
        {
            get { return this._datasetId; }
            set { this._datasetId = value; }
        }

        // Check to see if DatasetId property is set
        internal bool IsSetDatasetId()
        {
            return this._datasetId != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        ///  The name of the dataset. 
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
        ///  The description of the dataset. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DraftStatus. 
        /// <para>
        /// Publish synchronization state. Only authoritative when status == ACTIVE.
        /// </para>
        /// </summary>
        public DraftStatus DraftStatus
        {
            get { return this._draftStatus; }
            set { this._draftStatus = value; }
        }

        // Check to see if DraftStatus property is set
        internal bool IsSetDraftStatus()
        {
            return this._draftStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ExampleCount. 
        /// <para>
        ///  The number of examples in the dataset. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? ExampleCount
        {
            get { return this._exampleCount; }
            set { this._exampleCount = value; }
        }

        // Check to see if ExampleCount property is set
        internal bool IsSetExampleCount()
        {
            return this._exampleCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SchemaType. 
        /// <para>
        ///  The schema type of the dataset. 
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
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current status of the dataset. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DatasetStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        ///  The timestamp when the dataset was last updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}