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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// This is the response object from the ListEntities operation.
    /// </summary>
    public partial class ListEntitiesResponse : AmazonWebServiceResponse
    {
        private List<EntitySummary> _entitySummaryList = new List<EntitySummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EntitySummaryList. 
        /// <para>
        ///  Array of <code>EntitySummary</code> object.
        /// </para>
        /// </summary>
        public List<EntitySummary> EntitySummaryList
        {
            get { return this._entitySummaryList; }
            set { this._entitySummaryList = value; }
        }

        // Check to see if EntitySummaryList property is set
        internal bool IsSetEntitySummaryList()
        {
            return this._entitySummaryList != null && this._entitySummaryList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The value of the next token if it exists. Null if there is no more result.
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

    }
}