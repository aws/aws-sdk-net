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
        /// Registers an <see cref="IPropertyConverter"/> that is applied by default to every property of the
        /// specified .NET type on the constructed <see cref="DynamoDBContext"/>, without having to set the
        /// converter on each property via <see cref="DynamoDBPropertyAttribute"/> or a per-property mapping.
        /// A converter explicitly set on an individual property still takes precedence over the default converter.
        /// </summary>
        /// <param name="type">The .NET type the converter is applied to.</param>
        /// <param name="converter">The converter to use for properties of <paramref name="type"/>.</param>
        /// <exception cref="System.ArgumentNullException">Thrown when <paramref name="type"/> or <paramref name="converter"/> is null.</exception>
        /// <exception cref="System.InvalidOperationException">Thrown when a default converter has already been registered for <paramref name="type"/>.</exception>
        IDynamoDBContextBuilder AddDefaultConverter(Type type, IPropertyConverter converter)
#if NET8_0_OR_GREATER
            => throw new NotImplementedException();
#else
        ;
#endif

        /// <summary>
        /// Registers an <see cref="IPropertyConverter"/> that is applied by default to every property of type
        /// <typeparamref name="T"/> on the constructed <see cref="DynamoDBContext"/>, without having to set the
        /// converter on each property via <see cref="DynamoDBPropertyAttribute"/> or a per-property mapping.
        /// A converter explicitly set on an individual property still takes precedence over the default converter.
        /// </summary>
        /// <typeparam name="T">The .NET type the converter is applied to.</typeparam>
        /// <param name="converter">The converter to use for properties of type <typeparamref name="T"/>.</param>
        /// <exception cref="System.ArgumentNullException">Thrown when <paramref name="converter"/> is null.</exception>
        /// <exception cref="System.InvalidOperationException">Thrown when a default converter has already been registered for <typeparamref name="T"/>.</exception>
        IDynamoDBContextBuilder AddDefaultConverter<T>(IPropertyConverter converter)
#if NET8_0_OR_GREATER
            => throw new NotImplementedException();
#else
        ;
#endif

        /// <summary>
        /// Call at the end to retrieve the new <see cref="DynamoDBContext"/>
        /// </summary>
        /// <returns>Built <see cref="DynamoDBContext"/></returns>
        DynamoDBContext Build();
    }
}
