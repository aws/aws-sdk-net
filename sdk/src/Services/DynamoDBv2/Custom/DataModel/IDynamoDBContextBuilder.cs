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
    /// </summary>
    public interface IDynamoDBContextBuilder : IDisposable
    {
        /// <summary>
        /// Sets the DynamoDB client to be used by the <see cref="DynamoDBContext"/> that is constructed
        /// </summary>
        /// <param name="client"><see cref="IAmazonDynamoDB"/> to use to access DynamoDB.</param>
        IDynamoDBContextBuilder SetDynamoDBClient(IAmazonDynamoDB client);

        /// <summary>
        /// Sets the AWS Region to be used by the <see cref="IAmazonDynamoDB"/> client and the constructed <see cref="DynamoDBContext"/>
        /// </summary>
        /// <param name="region">The <see cref="RegionEndpoint"/> used by the <see cref="IAmazonDynamoDB"/> client.</param>
        IDynamoDBContextBuilder SetAWSRegion(RegionEndpoint region);

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
