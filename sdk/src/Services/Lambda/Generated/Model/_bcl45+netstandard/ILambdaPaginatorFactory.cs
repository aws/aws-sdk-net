#if !NETSTANDARD13
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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Paginators for the Lambda service
    ///</summary>
    public interface ILambdaPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAliases operation
        ///</summary>
        IListAliasesPaginator ListAliases(ListAliasesRequest request);

        /// <summary>
        /// Paginator for ListCodeSigningConfigs operation
        ///</summary>
        IListCodeSigningConfigsPaginator ListCodeSigningConfigs(ListCodeSigningConfigsRequest request);

        /// <summary>
        /// Paginator for ListEventSourceMappings operation
        ///</summary>
        IListEventSourceMappingsPaginator ListEventSourceMappings(ListEventSourceMappingsRequest request);

        /// <summary>
        /// Paginator for ListFunctionEventInvokeConfigs operation
        ///</summary>
        IListFunctionEventInvokeConfigsPaginator ListFunctionEventInvokeConfigs(ListFunctionEventInvokeConfigsRequest request);

        /// <summary>
        /// Paginator for ListFunctions operation
        ///</summary>
        IListFunctionsPaginator ListFunctions(ListFunctionsRequest request);

        /// <summary>
        /// Paginator for ListFunctionsByCodeSigningConfig operation
        ///</summary>
        IListFunctionsByCodeSigningConfigPaginator ListFunctionsByCodeSigningConfig(ListFunctionsByCodeSigningConfigRequest request);

        /// <summary>
        /// Paginator for ListLayers operation
        ///</summary>
        IListLayersPaginator ListLayers(ListLayersRequest request);

        /// <summary>
        /// Paginator for ListLayerVersions operation
        ///</summary>
        IListLayerVersionsPaginator ListLayerVersions(ListLayerVersionsRequest request);

        /// <summary>
        /// Paginator for ListProvisionedConcurrencyConfigs operation
        ///</summary>
        IListProvisionedConcurrencyConfigsPaginator ListProvisionedConcurrencyConfigs(ListProvisionedConcurrencyConfigsRequest request);

        /// <summary>
        /// Paginator for ListVersionsByFunction operation
        ///</summary>
        IListVersionsByFunctionPaginator ListVersionsByFunction(ListVersionsByFunctionRequest request);
    }
}
#endif