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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
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
namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteIndex operation.
    /// Deletes an index from an OpenSearch Serverless collection. Be aware that the index
    /// might be configured to conduct automatic semantic enrichment ingestion and search.
    /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-manage.html#serverless-semantic-enrichment">About
    /// automatic semantic enrichment</a>.
    /// </summary>
    public partial class DeleteIndexRequest : AmazonOpenSearchServerlessRequest
    {
        private string _id;
        private string _indexName;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the collection containing the index to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=40)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the index to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IndexName
        {
            get { return this._indexName; }
            set { this._indexName = value; }
        }

        // Check to see if IndexName property is set
        internal bool IsSetIndexName()
        {
            return this._indexName != null;
        }

    }
}