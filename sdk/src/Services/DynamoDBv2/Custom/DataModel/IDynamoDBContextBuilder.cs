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
    /// Interface for a builder that constructs a <see cref="DynamoDBContext"/>
    /// Using <see cref="IDynamoDBContextBuilder"/> to construct a <see cref="DynamoDBContext"/> will implicitly set 
    /// <see cref="DynamoDBContextConfig.DisableFetchingTableMetadata"/> to true which avoids the DescribeTable call 
    /// and relies entirely on the DynamoDB attributes set on the .NET classes. Alternatively, you can register the
    /// table definition using <see cref="DynamoDBContext.RegisterTableDefinition(DocumentModel.Table)"/>.
    /// If needed, you can revert back to the previous behavior by setting <see cref="DynamoDBContextConfig.DisableFetchingTableMetadata"/>
    /// to false using <see cref="IDynamoDBContextBuilder.ConfigureContext(Action{DynamoDBContextConfig})"/> as such:
    /// <code>
    /// var context = new DynamoDBContextBuilder()
    ///   .ConfigureContext(x =>
    ///   {
    ///       x.DisableFetchingTableMetadata = false;
    ///   })
    ///   .Build();
    /// </code>
    /// </summary>
    public interface IDynamoDBContextBuilder
    {
        /// <summary>
        /// Supplies a factory method for creating a <see cref="IAmazonDynamoDB"/> client.
        /// If a factory method is not provided, a new <see cref="IAmazonDynamoDB"/> client
        /// will be created using the environment to search for credentials and region configuration.
        /// </summary>
        /// <param name="factory">Factory method for creating a <see cref="IAmazonDynamoDB"/> client</param>
        IDynamoDBContextBuilder WithDynamoDBClient(Func<IAmazonDynamoDB> factory);

        /// <summary>
        /// Configures the <see cref="DynamoDBContext"/> that is being constructed
        /// </summary>
        /// <param name="configure">The configuration applied to the constructed <see cref="DynamoDBContext"/></param>
        IDynamoDBContextBuilder ConfigureContext(Action<DynamoDBContextConfig> configure);

        /// <summary>
        /// Call at the end to retrieve the new <see cref="DynamoDBContext"/>
        /// </summary>
        /// <returns>Built <see cref="DynamoDBContext"/></returns>
        DynamoDBContext Build();
    }
}
