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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Container for the parameters to the ListCustomModels operation.
    /// Returns a list of the custom models that you have created with the <c>CreateModelCustomizationJob</c>
    /// operation.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
    /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
    /// Bedrock User Guide</a>.
    /// </para>
    /// </summary>
    public partial class ListCustomModelsRequest : AmazonBedrockRequest
    {
        private string _baseModelArnEquals;
        private DateTime? _creationTimeAfter;
        private DateTime? _creationTimeBefore;
        private string _foundationModelArnEquals;
        private bool? _isOwned;
        private int? _maxResults;
        private ModelStatus _modelStatus;
        private string _nameContains;
        private string _nextToken;
        private SortModelsBy _sortBy;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property BaseModelArnEquals. 
        /// <para>
        /// Return custom models only if the base model Amazon Resource Name (ARN) matches this
        /// parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=1011)]
        public string BaseModelArnEquals
        {
            get { return this._baseModelArnEquals; }
            set { this._baseModelArnEquals = value; }
        }

        // Check to see if BaseModelArnEquals property is set
        internal bool IsSetBaseModelArnEquals()
        {
            return this._baseModelArnEquals != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// Return custom models created after the specified time. 
        /// </para>
        /// </summary>
        public DateTime? CreationTimeAfter
        {
            get { return this._creationTimeAfter; }
            set { this._creationTimeAfter = value; }
        }

        // Check to see if CreationTimeAfter property is set
        internal bool IsSetCreationTimeAfter()
        {
            return this._creationTimeAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTimeBefore. 
        /// <para>
        /// Return custom models created before the specified time. 
        /// </para>
        /// </summary>
        public DateTime? CreationTimeBefore
        {
            get { return this._creationTimeBefore; }
            set { this._creationTimeBefore = value; }
        }

        // Check to see if CreationTimeBefore property is set
        internal bool IsSetCreationTimeBefore()
        {
            return this._creationTimeBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FoundationModelArnEquals. 
        /// <para>
        /// Return custom models only if the foundation model Amazon Resource Name (ARN) matches
        /// this parameter.
        /// </para>
        /// </summary>
        public string FoundationModelArnEquals
        {
            get { return this._foundationModelArnEquals; }
            set { this._foundationModelArnEquals = value; }
        }

        // Check to see if FoundationModelArnEquals property is set
        internal bool IsSetFoundationModelArnEquals()
        {
            return this._foundationModelArnEquals != null;
        }

        /// <summary>
        /// Gets and sets the property IsOwned. 
        /// <para>
        /// Return custom models depending on if the current account owns them (<c>true</c>) or
        /// if they were shared with the current account (<c>false</c>).
        /// </para>
        /// </summary>
        public bool? IsOwned
        {
            get { return this._isOwned; }
            set { this._isOwned = value; }
        }

        // Check to see if IsOwned property is set
        internal bool IsSetIsOwned()
        {
            return this._isOwned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in the response. If the total number of results
        /// is greater than this value, use the token returned in the response in the <c>nextToken</c>
        /// field when making another request to return the next batch of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelStatus. 
        /// <para>
        /// The status of them model to filter results by. Possible values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Creating</c> - Include only models that are currently being created and validated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Active</c> - Include only models that have been successfully created and are ready
        /// for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c> - Include only models where the creation process failed.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify a status, the API returns models in all states.
        /// </para>
        /// </summary>
        public ModelStatus ModelStatus
        {
            get { return this._modelStatus; }
            set { this._modelStatus = value; }
        }

        // Check to see if ModelStatus property is set
        internal bool IsSetModelStatus()
        {
            return this._modelStatus != null;
        }

        /// <summary>
        /// Gets and sets the property NameContains. 
        /// <para>
        /// Return custom models only if the job name contains these characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string NameContains
        {
            get { return this._nameContains; }
            set { this._nameContains = value; }
        }

        // Check to see if NameContains property is set
        internal bool IsSetNameContains()
        {
            return this._nameContains != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the total number of results is greater than the <c>maxResults</c> value provided
        /// in the request, enter the token returned in the <c>nextToken</c> field in the response
        /// in this field to return the next batch of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The field to sort by in the returned list of models.
        /// </para>
        /// </summary>
        public SortModelsBy SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort order of the results.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

    }
}