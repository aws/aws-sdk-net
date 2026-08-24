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
    /// <inheritdoc/>
    public partial class AsyncSearchVectors<T> : IAsyncSearchVectors<T>
    {
        private SearchVectors _documentSearchVectors { get; set; }
        private DynamoDBContext _sourceContext { get; set; }
        private DynamoDBFlatConfig _config { get; set; }

        internal TracerProvider TracerProvider { get; set; }

        /// <summary>
        /// This constructor is used for mocking. Users that want to mock AsyncSearchVectors can create a subclass of AsyncSearchVectors and make a public parameterless constructor.
        /// </summary>
        protected AsyncSearchVectors()
        {
        }

        internal AsyncSearchVectors(DynamoDBContext source, DynamoDBContext.ContextSearchVectors contextSearch)
        {
            _sourceContext = source;
            _documentSearchVectors = contextSearch.SearchVectors;
            _config = contextSearch.FlatConfig;
            TracerProvider = source?.Client?.Config?.TelemetryProvider?.TracerProvider
                ?? AWSConfigs.TelemetryProvider.TracerProvider;
        }
    }
}
