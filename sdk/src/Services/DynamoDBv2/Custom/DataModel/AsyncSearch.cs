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

using Amazon.DynamoDBv2.DocumentModel;
using Amazon.Runtime.Telemetry.Tracing;

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Interface retrieving search results (Query or Scan)
    /// from DynamoDB.
    /// </summary>
    public partial interface IAsyncSearch<T>
    {
        /// <summary>
        /// Flag that, if true, indicates that the search is done
        /// </summary>
        bool IsDone { get; }

        /// <summary>
        /// Pagination token corresponding to the item where the search operation stopped,
        /// inclusive of the previous result set. Use this value to start a new
        /// operation to resume search from the next item.
        /// </summary>
        string PaginationToken { get; }
    }

    /// <summary>
    /// A strongly-typed object for retrieving search results (Query or Scan)
    /// from DynamoDB.
    /// </summary>
    public partial class AsyncSearch<T> : IAsyncSearch<T>
    {
        private Search _documentSearch { get; set; }
        private DynamoDBContext _sourceContext { get; set; }
        private DynamoDBFlatConfig _config { get; set; }

        internal TracerProvider TracerProvider { get; set; }

        /// <summary>
        /// This constructor is used for mocking. Users that want to mock AsyncSearch can create a subclass of AsyncSearch and make a public parameterless constructor.
        /// </summary>
        protected AsyncSearch()
        {

        }

        internal AsyncSearch(DynamoDBContext source, DynamoDBContext.ContextSearch contextSearch)
        {
            _sourceContext = source;
            _documentSearch = contextSearch.Search;
            _config = contextSearch.FlatConfig;
            TracerProvider = source?.Client?.Config?.TelemetryProvider?.TracerProvider
                ?? AWSConfigs.TelemetryProvider.TracerProvider;
        }

        /// <inheritdoc/>
        public virtual bool IsDone
        {
            get
            {
                return _documentSearch.IsDone;
            }
        }

        /// <inheritdoc/>
        public virtual string PaginationToken
        {
            get
            {
                return _documentSearch.PaginationToken;
            }
        }
    }
}
