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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the ListSkillsStoreSkillsByCategory operation.
    /// Lists all skills in the Alexa skill store by category.
    /// </summary>
    public partial class ListSkillsStoreSkillsByCategoryRequest : AmazonAlexaForBusinessRequest
    {
        private long? _categoryId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CategoryId. 
        /// <para>
        /// The category ID for which the skills are being retrieved from the skill store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public long CategoryId
        {
            get { return this._categoryId.GetValueOrDefault(); }
            set { this._categoryId = value; }
        }

        // Check to see if CategoryId property is set
        internal bool IsSetCategoryId()
        {
            return this._categoryId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of skills returned per paginated calls.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The tokens used for pagination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1100)]
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