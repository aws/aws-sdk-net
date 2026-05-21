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
    /// This is the response object from the AddDatasetExamples operation.
    /// </summary>
    public partial class AddDatasetExamplesResponse : AmazonWebServiceResponse
    {
        private long? _addedCount;
        private string _datasetArn;
        private string _datasetId;
        private List<string> _exampleIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DatasetStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AddedCount. 
        /// <para>
        ///  The number of examples added. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? AddedCount
        {
            get { return this._addedCount; }
            set { this._addedCount = value; }
        }

        // Check to see if AddedCount property is set
        internal bool IsSetAddedCount()
        {
            return this._addedCount.HasValue; 
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
        /// Gets and sets the property ExampleIds. 
        /// <para>
        /// IDs of all added examples (auto-generated UUIDs).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ExampleIds
        {
            get { return this._exampleIds; }
            set { this._exampleIds = value; }
        }

        // Check to see if ExampleIds property is set
        internal bool IsSetExampleIds()
        {
            return this._exampleIds != null && (this._exampleIds.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        ///  The timestamp when the examples were added. 
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