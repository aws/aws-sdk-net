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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Paginators for the CloudFormation service
    /// </summary>
    public interface ICloudFormationPaginatorFactory
    {
        /// <summary>
        /// Paginator for DescribeAccountLimits operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IDescribeAccountLimitsPaginator DescribeAccountLimits(DescribeAccountLimitsRequest request);

        /// <summary>
        /// Paginator for DescribeChangeSet operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IDescribeChangeSetPaginator DescribeChangeSet(DescribeChangeSetRequest request);

        /// <summary>
        /// Paginator for DescribeEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IDescribeEventsPaginator DescribeEvents(DescribeEventsRequest request);

        /// <summary>
        /// Paginator for DescribeStackEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IDescribeStackEventsPaginator DescribeStackEvents(DescribeStackEventsRequest request);

        /// <summary>
        /// Paginator for DescribeStackResourceDrifts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeStackResourceDriftsPaginator DescribeStackResourceDrifts(DescribeStackResourceDriftsRequest request);

        /// <summary>
        /// Paginator for DescribeStacks operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IDescribeStacksPaginator DescribeStacks(DescribeStacksRequest request);

        /// <summary>
        /// Paginator for ListChangeSets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListChangeSetsPaginator ListChangeSets(ListChangeSetsRequest request);

        /// <summary>
        /// Paginator for ListExports operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListExportsPaginator ListExports(ListExportsRequest request);

        /// <summary>
        /// Paginator for ListGeneratedTemplates operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListGeneratedTemplatesPaginator ListGeneratedTemplates(ListGeneratedTemplatesRequest request);

        /// <summary>
        /// Paginator for ListImports operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListImportsPaginator ListImports(ListImportsRequest request);

        /// <summary>
        /// Paginator for ListResourceScanRelatedResources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListResourceScanRelatedResourcesPaginator ListResourceScanRelatedResources(ListResourceScanRelatedResourcesRequest request);

        /// <summary>
        /// Paginator for ListResourceScanResources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListResourceScanResourcesPaginator ListResourceScanResources(ListResourceScanResourcesRequest request);

        /// <summary>
        /// Paginator for ListResourceScans operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListResourceScansPaginator ListResourceScans(ListResourceScansRequest request);

        /// <summary>
        /// Paginator for ListStackInstances operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListStackInstancesPaginator ListStackInstances(ListStackInstancesRequest request);

        /// <summary>
        /// Paginator for ListStackRefactorActions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListStackRefactorActionsPaginator ListStackRefactorActions(ListStackRefactorActionsRequest request);

        /// <summary>
        /// Paginator for ListStackRefactors operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListStackRefactorsPaginator ListStackRefactors(ListStackRefactorsRequest request);

        /// <summary>
        /// Paginator for ListStackResources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListStackResourcesPaginator ListStackResources(ListStackResourcesRequest request);

        /// <summary>
        /// Paginator for ListStackSetOperationResults operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListStackSetOperationResultsPaginator ListStackSetOperationResults(ListStackSetOperationResultsRequest request);

        /// <summary>
        /// Paginator for ListStackSetOperations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListStackSetOperationsPaginator ListStackSetOperations(ListStackSetOperationsRequest request);

        /// <summary>
        /// Paginator for ListStackSets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListStackSetsPaginator ListStackSets(ListStackSetsRequest request);

        /// <summary>
        /// Paginator for ListStacks operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListStacksPaginator ListStacks(ListStacksRequest request);

        /// <summary>
        /// Paginator for ListTypeRegistrations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTypeRegistrationsPaginator ListTypeRegistrations(ListTypeRegistrationsRequest request);

        /// <summary>
        /// Paginator for ListTypeVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTypeVersionsPaginator ListTypeVersions(ListTypeVersionsRequest request);

        /// <summary>
        /// Paginator for ListTypes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTypesPaginator ListTypes(ListTypesRequest request);
    }
}
