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
    /// models</a> in the Amazon Bedrock User Guide.
    /// </para>
    /// </summary>
    public partial class ListCustomModelsRequest : AmazonBedrockRequest
    {
        private string _baseModelArnEquals;
        private DateTime? _creationTimeAfter;
        private DateTime? _creationTimeBefore;
        private string _foundationModelArnEquals;
        private int? _maxResults;
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results to return in the response.
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
        /// Continuation token from the previous response, for Amazon Bedrock to list the next
        /// set of results.
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