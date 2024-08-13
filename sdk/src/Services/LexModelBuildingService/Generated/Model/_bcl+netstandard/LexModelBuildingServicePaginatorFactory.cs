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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Paginators for the LexModelBuildingService service
    ///</summary>
    public class LexModelBuildingServicePaginatorFactory : ILexModelBuildingServicePaginatorFactory
    {
        private readonly IAmazonLexModelBuildingService client;

        internal LexModelBuildingServicePaginatorFactory(IAmazonLexModelBuildingService client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetBotAliases operation
        ///</summary>
        public IGetBotAliasesPaginator GetBotAliases(GetBotAliasesRequest request) 
        {
            return new GetBotAliasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetBotChannelAssociations operation
        ///</summary>
        public IGetBotChannelAssociationsPaginator GetBotChannelAssociations(GetBotChannelAssociationsRequest request) 
        {
            return new GetBotChannelAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetBots operation
        ///</summary>
        public IGetBotsPaginator GetBots(GetBotsRequest request) 
        {
            return new GetBotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetBotVersions operation
        ///</summary>
        public IGetBotVersionsPaginator GetBotVersions(GetBotVersionsRequest request) 
        {
            return new GetBotVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetBuiltinIntents operation
        ///</summary>
        public IGetBuiltinIntentsPaginator GetBuiltinIntents(GetBuiltinIntentsRequest request) 
        {
            return new GetBuiltinIntentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetBuiltinSlotTypes operation
        ///</summary>
        public IGetBuiltinSlotTypesPaginator GetBuiltinSlotTypes(GetBuiltinSlotTypesRequest request) 
        {
            return new GetBuiltinSlotTypesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetIntents operation
        ///</summary>
        public IGetIntentsPaginator GetIntents(GetIntentsRequest request) 
        {
            return new GetIntentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetIntentVersions operation
        ///</summary>
        public IGetIntentVersionsPaginator GetIntentVersions(GetIntentVersionsRequest request) 
        {
            return new GetIntentVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetMigrations operation
        ///</summary>
        public IGetMigrationsPaginator GetMigrations(GetMigrationsRequest request) 
        {
            return new GetMigrationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetSlotTypes operation
        ///</summary>
        public IGetSlotTypesPaginator GetSlotTypes(GetSlotTypesRequest request) 
        {
            return new GetSlotTypesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetSlotTypeVersions operation
        ///</summary>
        public IGetSlotTypeVersionsPaginator GetSlotTypeVersions(GetSlotTypeVersionsRequest request) 
        {
            return new GetSlotTypeVersionsPaginator(this.client, request);
        }
    }
}