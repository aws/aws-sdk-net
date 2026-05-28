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
    /// This is the response object from the ListDatasetExamples operation.
    /// </summary>
    public partial class ListDatasetExamplesResponse : AmazonWebServiceResponse
    {
        private string _datasetArn;
        private string _datasetId;
        private string _datasetVersion;
        private List<Amazon.Runtime.Documents.Document> _examples = AWSConfigs.InitializeCollections ? new List<Amazon.Runtime.Documents.Document>() : null;
        private string _nextToken;

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
        /// Gets and sets the property DatasetVersion. 
        /// <para>
        /// The version returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DatasetVersion
        {
            get { return this._datasetVersion; }
            set { this._datasetVersion = value; }
        }

        // Check to see if DatasetVersion property is set
        internal bool IsSetDatasetVersion()
        {
            return this._datasetVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Examples. 
        /// <para>
        /// Paginated example content. Each element is a JSON object containing at least an <c>exampleId</c>
        /// field plus the schema-specific content fields.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Amazon.Runtime.Documents.Document> Examples
        {
            get { return this._examples; }
            set { this._examples = value; }
        }

        // Check to see if Examples property is set
        internal bool IsSetExamples()
        {
            return this._examples != null && (this._examples.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token for the next page of results, or null if there are no more results. 
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}