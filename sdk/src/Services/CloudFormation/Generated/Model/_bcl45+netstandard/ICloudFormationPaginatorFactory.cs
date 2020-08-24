#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Paginators for the CloudFormation service
    ///</summary>
    public interface ICloudFormationPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeAccountLimits operation
        ///</summary>
        IDescribeAccountLimitsPaginator DescribeAccountLimits(DescribeAccountLimitsRequest request);

        /// <summary>
        /// Paginator for DescribeStackEvents operation
        ///</summary>
        IDescribeStackEventsPaginator DescribeStackEvents(DescribeStackEventsRequest request);

        /// <summary>
        /// Paginator for DescribeStackResourceDrifts operation
        ///</summary>
        IDescribeStackResourceDriftsPaginator DescribeStackResourceDrifts(DescribeStackResourceDriftsRequest request);

        /// <summary>
        /// Paginator for DescribeStacks operation
        ///</summary>
        IDescribeStacksPaginator DescribeStacks(DescribeStacksRequest request);

        /// <summary>
        /// Paginator for ListChangeSets operation
        ///</summary>
        IListChangeSetsPaginator ListChangeSets(ListChangeSetsRequest request);

        /// <summary>
        /// Paginator for ListExports operation
        ///</summary>
        IListExportsPaginator ListExports(ListExportsRequest request);

        /// <summary>
        /// Paginator for ListImports operation
        ///</summary>
        IListImportsPaginator ListImports(ListImportsRequest request);

        /// <summary>
        /// Paginator for ListStackInstances operation
        ///</summary>
        IListStackInstancesPaginator ListStackInstances(ListStackInstancesRequest request);

        /// <summary>
        /// Paginator for ListStackResources operation
        ///</summary>
        IListStackResourcesPaginator ListStackResources(ListStackResourcesRequest request);

        /// <summary>
        /// Paginator for ListStacks operation
        ///</summary>
        IListStacksPaginator ListStacks(ListStacksRequest request);

        /// <summary>
        /// Paginator for ListStackSetOperationResults operation
        ///</summary>
        IListStackSetOperationResultsPaginator ListStackSetOperationResults(ListStackSetOperationResultsRequest request);

        /// <summary>
        /// Paginator for ListStackSetOperations operation
        ///</summary>
        IListStackSetOperationsPaginator ListStackSetOperations(ListStackSetOperationsRequest request);

        /// <summary>
        /// Paginator for ListStackSets operation
        ///</summary>
        IListStackSetsPaginator ListStackSets(ListStackSetsRequest request);

        /// <summary>
        /// Paginator for ListTypeRegistrations operation
        ///</summary>
        IListTypeRegistrationsPaginator ListTypeRegistrations(ListTypeRegistrationsRequest request);

        /// <summary>
        /// Paginator for ListTypes operation
        ///</summary>
        IListTypesPaginator ListTypes(ListTypesRequest request);

        /// <summary>
        /// Paginator for ListTypeVersions operation
        ///</summary>
        IListTypeVersionsPaginator ListTypeVersions(ListTypeVersionsRequest request);
    }
}
#endif