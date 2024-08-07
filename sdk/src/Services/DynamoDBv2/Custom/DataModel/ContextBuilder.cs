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

using System;

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Builder that constructs a <see cref="DynamoDBContext"/>
    /// </summary>
#if NET8_0_OR_GREATER
    [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(Amazon.DynamoDBv2.Custom.Internal.InternalConstants.RequiresUnreferencedCodeMessage)]
#endif
    public class DynamoDBContextBuilder : IDynamoDBContextBuilder
    {
        /// <summary>
        /// The <see cref="DynamoDBContext"/> object that is built and then returned from <see cref="Build"/>
        /// </summary>
        private DynamoDBContext _context;

        /// <summary>
        /// The <see cref="DynamoDBContextConfig"/> object that is built and then supplied to the returned <see cref="DynamoDBContext"/>
        /// </summary>
        private DynamoDBContextConfig _config;

        /// <summary>
        /// Amazon client to use to access DynamoDB
        /// </summary>
        private IAmazonDynamoDB _client;

        /// <summary>
        /// Specifies if an <see cref="IAmazonDynamoDB"/> client is constructed or supplied externally
        /// </summary>
        private bool _ownClient = true;

        /// <summary>
        /// Specifies if the object was disposed to avoid redundant dispose calls
        /// </summary>
        private bool _disposed = false;

        /// <summary>
        /// Creates a builder object to construct a <see cref="DynamoDBContext"/>
        /// </summary>
        public DynamoDBContextBuilder()
        {
            _config = new DynamoDBContextConfig();
            _config.DisableFetchingTableMetadata = true;
        }

        /// <inheritdoc/>
        public IDynamoDBContextBuilder SetDynamoDBClient(IAmazonDynamoDB client)
        {
            if (_client is null)
            {
                _client = client;
                _ownClient = false;
            }
            else
            {
                throw new AmazonDynamoDBException($"Cannot use both '{nameof(SetDynamoDBClient)}' and '{nameof(SetAWSRegion)}'. If you are supplying the DynamoDB client, set the AWS Region directly on the client.");
            }

            return this;
        }

        /// <inheritdoc/>
        public IDynamoDBContextBuilder SetAWSRegion(RegionEndpoint region)
        {
            if (_client is null)
            {
                _client = new AmazonDynamoDBClient(region);
                _ownClient = true;
            }
            else
            {
                throw new AmazonDynamoDBException($"Cannot use both '{nameof(SetDynamoDBClient)}' and '{nameof(SetAWSRegion)}'. If you are supplying the DynamoDB client, set the AWS Region directly on the client.");
            }

            return this;
        }

        /// <inheritdoc/>
        public IDynamoDBContextBuilder ConfigureContext(Action<DynamoDBContextConfig> configure)
        {
            configure(_config);

            return this;
        }

        /// <inheritdoc/>
        public DynamoDBContext Build()
        {
            if (_client is null)
            {
                _client = new AmazonDynamoDBClient();
                _ownClient = true;
            }

            _context = new DynamoDBContext(_client, _ownClient, _config);

            return _context;
        }

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Implements the Dispose pattern
        /// </summary>
        /// <param name="disposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing && _context != null)
            {
                // Dispose managed resources
                _context?.Dispose();
                _context = null;
            }

            // Dispose unmanaged resources if any
            _disposed = true;
        }

        /// <summary>
        /// The destructor for the class.
        /// </summary>
        ~DynamoDBContextBuilder()
        {
            Dispose(false);
        }
    }
}
