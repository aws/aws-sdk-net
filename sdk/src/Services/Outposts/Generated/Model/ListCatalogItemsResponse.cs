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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// This is the response object from the ListCatalogItems operation.
    /// </summary>
    public partial class ListCatalogItemsResponse : AmazonWebServiceResponse
    {
        private List<CatalogItem> _catalogItems = AWSConfigs.InitializeCollections ? new List<CatalogItem>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CatalogItems. 
        /// <para>
        /// Information about the catalog items.
        /// </para>
        /// </summary>
        public List<CatalogItem> CatalogItems
        {
            get { return this._catalogItems; }
            set { this._catalogItems = value; }
        }

        // Check to see if CatalogItems property is set
        internal bool IsSetCatalogItems()
        {
            return this._catalogItems != null && (this._catalogItems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
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