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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// This is the response object from the DescribeServerlessCaches operation.
    /// </summary>
    public partial class DescribeServerlessCachesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ServerlessCache> _serverlessCaches = AWSConfigs.InitializeCollections ? new List<ServerlessCache>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An optional marker returned from a prior request to support pagination of results
        /// from this operation. If this parameter is specified, the response includes only records
        /// beyond the marker, up to the value specified by MaxResults.
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

        /// <summary>
        /// Gets and sets the property ServerlessCaches. 
        /// <para>
        /// The serverless caches associated with a given description request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServerlessCache> ServerlessCaches
        {
            get { return this._serverlessCaches; }
            set { this._serverlessCaches = value; }
        }

        // Check to see if ServerlessCaches property is set
        internal bool IsSetServerlessCaches()
        {
            return this._serverlessCaches != null && (this._serverlessCaches.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}