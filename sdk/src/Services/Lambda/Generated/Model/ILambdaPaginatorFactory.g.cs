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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Paginators for the Lambda service
    /// </summary>
    public interface ILambdaPaginatorFactory
    {
        /// <summary>
        /// Paginator for GetDurableExecutionHistory operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["NextMarker"])]
        IGetDurableExecutionHistoryPaginator GetDurableExecutionHistory(GetDurableExecutionHistoryRequest request);

        /// <summary>
        /// Paginator for GetDurableExecutionState operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["NextMarker"])]
        IGetDurableExecutionStatePaginator GetDurableExecutionState(GetDurableExecutionStateRequest request);

        /// <summary>
        /// Paginator for ListAliases operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["NextMarker"])]
        IListAliasesPaginator ListAliases(ListAliasesRequest request);

        /// <summary>
        /// Paginator for ListCapacityProviders operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["NextMarker"])]
        IListCapacityProvidersPaginator ListCapacityProviders(ListCapacityProvidersRequest request);

        /// <summary>
        /// Paginator for ListCodeSigningConfigs operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["NextMarker"])]
        IListCodeSigningConfigsPaginator ListCodeSigningConfigs(ListCodeSigningConfigsRequest request);

        /// <summary>
        /// Paginator for ListDurableExecutionsByFunction operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["NextMarker"])]
        IListDurableExecutionsByFunctionPaginator ListDurableExecutionsByFunction(ListDurableExecutionsByFunctionRequest request);

        /// <summary>
        /// Paginator for ListEventSourceMappings operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["NextMarker"])]
        IListEventSourceMappingsPaginator ListEventSourceMappings(ListEventSourceMappingsRequest request);

        /// <summary>
        /// Paginator for ListFunctionEventInvokeConfigs operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["NextMarker"])]
        IListFunctionEventInvokeConfigsPaginator ListFunctionEventInvokeConfigs(ListFunctionEventInvokeConfigsRequest request);

        /// <summary>
        /// Paginator for ListFunctionUrlConfigs operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["NextMarker"])]
        IListFunctionUrlConfigsPaginator ListFunctionUrlConfigs(ListFunctionUrlConfigsRequest request);

        /// <summary>
        /// Paginator for ListFunctionVersionsByCapacityProvider operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["NextMarker"])]
        IListFunctionVersionsByCapacityProviderPaginator ListFunctionVersionsByCapacityProvider(ListFunctionVersionsByCapacityProviderRequest request);

        /// <summary>
        /// Paginator for ListFunctions operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["NextMarker"])]
        IListFunctionsPaginator ListFunctions(ListFunctionsRequest request);

        /// <summary>
        /// Paginator for ListFunctionsByCodeSigningConfig operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["NextMarker"])]
        IListFunctionsByCodeSigningConfigPaginator ListFunctionsByCodeSigningConfig(ListFunctionsByCodeSigningConfigRequest request);

        /// <summary>
        /// Paginator for ListLayerVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["NextMarker"])]
        IListLayerVersionsPaginator ListLayerVersions(ListLayerVersionsRequest request);

        /// <summary>
        /// Paginator for ListLayers operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["NextMarker"])]
        IListLayersPaginator ListLayers(ListLayersRequest request);

        /// <summary>
        /// Paginator for ListProvisionedConcurrencyConfigs operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["NextMarker"])]
        IListProvisionedConcurrencyConfigsPaginator ListProvisionedConcurrencyConfigs(ListProvisionedConcurrencyConfigsRequest request);

        /// <summary>
        /// Paginator for ListVersionsByFunction operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["NextMarker"])]
        IListVersionsByFunctionPaginator ListVersionsByFunction(ListVersionsByFunctionRequest request);
    }
}
