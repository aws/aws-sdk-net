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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Paginators for the LexModelBuildingService service
    ///</summary>
    public interface ILexModelBuildingServicePaginatorFactory
    {

        /// <summary>
        /// Paginator for GetBotAliases operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetBotAliasesPaginator GetBotAliases(GetBotAliasesRequest request);

        /// <summary>
        /// Paginator for GetBotChannelAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetBotChannelAssociationsPaginator GetBotChannelAssociations(GetBotChannelAssociationsRequest request);

        /// <summary>
        /// Paginator for GetBots operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetBotsPaginator GetBots(GetBotsRequest request);

        /// <summary>
        /// Paginator for GetBotVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetBotVersionsPaginator GetBotVersions(GetBotVersionsRequest request);

        /// <summary>
        /// Paginator for GetBuiltinIntents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetBuiltinIntentsPaginator GetBuiltinIntents(GetBuiltinIntentsRequest request);

        /// <summary>
        /// Paginator for GetBuiltinSlotTypes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetBuiltinSlotTypesPaginator GetBuiltinSlotTypes(GetBuiltinSlotTypesRequest request);

        /// <summary>
        /// Paginator for GetIntents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetIntentsPaginator GetIntents(GetIntentsRequest request);

        /// <summary>
        /// Paginator for GetIntentVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetIntentVersionsPaginator GetIntentVersions(GetIntentVersionsRequest request);

        /// <summary>
        /// Paginator for GetMigrations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetMigrationsPaginator GetMigrations(GetMigrationsRequest request);

        /// <summary>
        /// Paginator for GetSlotTypes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetSlotTypesPaginator GetSlotTypes(GetSlotTypesRequest request);

        /// <summary>
        /// Paginator for GetSlotTypeVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetSlotTypeVersionsPaginator GetSlotTypeVersions(GetSlotTypeVersionsRequest request);
    }
}