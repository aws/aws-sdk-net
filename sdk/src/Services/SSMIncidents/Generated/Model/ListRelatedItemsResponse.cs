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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
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
namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// This is the response object from the ListRelatedItems operation.
    /// </summary>
    public partial class ListRelatedItemsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RelatedItem> _relatedItems = AWSConfigs.InitializeCollections ? new List<RelatedItem>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token to use when requesting the next set of items. If there are no
        /// additional items to return, the string is null.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2000)]
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
        /// Gets and sets the property RelatedItems. 
        /// <para>
        /// Details about each related item.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<RelatedItem> RelatedItems
        {
            get { return this._relatedItems; }
            set { this._relatedItems = value; }
        }

        // Check to see if RelatedItems property is set
        internal bool IsSetRelatedItems()
        {
            return this._relatedItems != null && (this._relatedItems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}