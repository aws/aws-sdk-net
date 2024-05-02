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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Paginators for the Lambda service
    ///</summary>
    public class LambdaPaginatorFactory : ILambdaPaginatorFactory
    {
        private readonly IAmazonLambda client;

        internal LambdaPaginatorFactory(IAmazonLambda client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAliases operation
        ///</summary>
        public IListAliasesPaginator ListAliases(ListAliasesRequest request) 
        {
            return new ListAliasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCodeSigningConfigs operation
        ///</summary>
        public IListCodeSigningConfigsPaginator ListCodeSigningConfigs(ListCodeSigningConfigsRequest request) 
        {
            return new ListCodeSigningConfigsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEventSourceMappings operation
        ///</summary>
        public IListEventSourceMappingsPaginator ListEventSourceMappings(ListEventSourceMappingsRequest request) 
        {
            return new ListEventSourceMappingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFunctionEventInvokeConfigs operation
        ///</summary>
        public IListFunctionEventInvokeConfigsPaginator ListFunctionEventInvokeConfigs(ListFunctionEventInvokeConfigsRequest request) 
        {
            return new ListFunctionEventInvokeConfigsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFunctions operation
        ///</summary>
        public IListFunctionsPaginator ListFunctions(ListFunctionsRequest request) 
        {
            return new ListFunctionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFunctionsByCodeSigningConfig operation
        ///</summary>
        public IListFunctionsByCodeSigningConfigPaginator ListFunctionsByCodeSigningConfig(ListFunctionsByCodeSigningConfigRequest request) 
        {
            return new ListFunctionsByCodeSigningConfigPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFunctionUrlConfigs operation
        ///</summary>
        public IListFunctionUrlConfigsPaginator ListFunctionUrlConfigs(ListFunctionUrlConfigsRequest request) 
        {
            return new ListFunctionUrlConfigsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLayers operation
        ///</summary>
        public IListLayersPaginator ListLayers(ListLayersRequest request) 
        {
            return new ListLayersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLayerVersions operation
        ///</summary>
        public IListLayerVersionsPaginator ListLayerVersions(ListLayerVersionsRequest request) 
        {
            return new ListLayerVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProvisionedConcurrencyConfigs operation
        ///</summary>
        public IListProvisionedConcurrencyConfigsPaginator ListProvisionedConcurrencyConfigs(ListProvisionedConcurrencyConfigsRequest request) 
        {
            return new ListProvisionedConcurrencyConfigsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVersionsByFunction operation
        ///</summary>
        public IListVersionsByFunctionPaginator ListVersionsByFunction(ListVersionsByFunctionRequest request) 
        {
            return new ListVersionsByFunctionPaginator(this.client, request);
        }
    }
}