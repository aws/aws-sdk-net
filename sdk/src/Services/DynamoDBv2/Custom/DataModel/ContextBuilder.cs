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
    /// <inheritdoc cref="IDynamoDBContextBuilder" />
    public class DynamoDBContextBuilder : IDynamoDBContextBuilder
    {
        /// <summary>
        /// The <see cref="DynamoDBContextConfig"/> object that is built and then supplied to the returned <see cref="DynamoDBContext"/>
        /// </summary>
        private DynamoDBContextConfig _config;

        /// <summary>
        /// A factory method for creating a <see cref="IAmazonDynamoDB"/> client
        /// </summary>
        private Func<IAmazonDynamoDB> _clientFactory;

        /// <summary>
        /// Creates a builder object to construct a <see cref="DynamoDBContext"/>
        /// </summary>
        public DynamoDBContextBuilder()
        {
            _config = new DynamoDBContextConfig();
            _config.DisableFetchingTableMetadata = true;
        }

        /// <inheritdoc/>
        public IDynamoDBContextBuilder ConfigureContext(Action<DynamoDBContextConfig> configure)
        {
            configure(_config);

            return this;
        }

        /// <inheritdoc/>
        public IDynamoDBContextBuilder WithDynamoDBClient(Func<IAmazonDynamoDB> factory)
        {
            _clientFactory = factory;

            return this;
        }

        /// <inheritdoc/>
        public DynamoDBContext Build()
        {
            IAmazonDynamoDB client;
            bool ownClient;

            if (_clientFactory is null)
            {
                client = new AmazonDynamoDBClient();
                ownClient = true;
            }
            else
            {
                client = _clientFactory.Invoke();
                ownClient = false;
            }

            return new DynamoDBContext(client, ownClient, _config);
        }
    }
}
