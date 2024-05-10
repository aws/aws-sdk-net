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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
namespace Amazon.Omics.Model
{
    /// <summary>
    /// This is the response object from the ListAnnotationStores operation.
    /// </summary>
    public partial class ListAnnotationStoresResponse : AmazonWebServiceResponse
    {
        private List<AnnotationStoreItem> _annotationStores = AWSConfigs.InitializeCollections ? new List<AnnotationStoreItem>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AnnotationStores. 
        /// <para>
        /// A list of stores.
        /// </para>
        /// </summary>
        public List<AnnotationStoreItem> AnnotationStores
        {
            get { return this._annotationStores; }
            set { this._annotationStores = value; }
        }

        // Check to see if AnnotationStores property is set
        internal bool IsSetAnnotationStores()
        {
            return this._annotationStores != null && (this._annotationStores.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token that's included if more results are available.
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