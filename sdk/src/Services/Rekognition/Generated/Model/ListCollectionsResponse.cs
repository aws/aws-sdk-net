/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// This is the response object from the ListCollections operation.
    /// </summary>
    public partial class ListCollectionsResponse : AmazonWebServiceResponse
    {
        private List<string> _collectionIds = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CollectionIds. 
        /// <para>
        /// An array of collection IDs.
        /// </para>
        /// </summary>
        public List<string> CollectionIds
        {
            get { return this._collectionIds; }
            set { this._collectionIds = value; }
        }

        // Check to see if CollectionIds property is set
        internal bool IsSetCollectionIds()
        {
            return this._collectionIds != null && this._collectionIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the result is truncated, the response provides a <code>NextToken</code> that you
        /// can use in the subsequent request to fetch the next set of collection IDs.
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