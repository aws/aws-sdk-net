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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Paginators for the CloudFormation service
    ///</summary>
    public class CloudFormationPaginatorFactory : ICloudFormationPaginatorFactory
    {
        private readonly IAmazonCloudFormation client;

        internal CloudFormationPaginatorFactory(IAmazonCloudFormation client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeAccountLimits operation
        ///</summary>
        public IDescribeAccountLimitsPaginator DescribeAccountLimits(DescribeAccountLimitsRequest request) 
        {
            return new DescribeAccountLimitsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeStackEvents operation
        ///</summary>
        public IDescribeStackEventsPaginator DescribeStackEvents(DescribeStackEventsRequest request) 
        {
            return new DescribeStackEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeStackResourceDrifts operation
        ///</summary>
        public IDescribeStackResourceDriftsPaginator DescribeStackResourceDrifts(DescribeStackResourceDriftsRequest request) 
        {
            return new DescribeStackResourceDriftsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeStacks operation
        ///</summary>
        public IDescribeStacksPaginator DescribeStacks(DescribeStacksRequest request) 
        {
            return new DescribeStacksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListChangeSets operation
        ///</summary>
        public IListChangeSetsPaginator ListChangeSets(ListChangeSetsRequest request) 
        {
            return new ListChangeSetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListExports operation
        ///</summary>
        public IListExportsPaginator ListExports(ListExportsRequest request) 
        {
            return new ListExportsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGeneratedTemplates operation
        ///</summary>
        public IListGeneratedTemplatesPaginator ListGeneratedTemplates(ListGeneratedTemplatesRequest request) 
        {
            return new ListGeneratedTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListImports operation
        ///</summary>
        public IListImportsPaginator ListImports(ListImportsRequest request) 
        {
            return new ListImportsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResourceScanRelatedResources operation
        ///</summary>
        public IListResourceScanRelatedResourcesPaginator ListResourceScanRelatedResources(ListResourceScanRelatedResourcesRequest request) 
        {
            return new ListResourceScanRelatedResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResourceScanResources operation
        ///</summary>
        public IListResourceScanResourcesPaginator ListResourceScanResources(ListResourceScanResourcesRequest request) 
        {
            return new ListResourceScanResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResourceScans operation
        ///</summary>
        public IListResourceScansPaginator ListResourceScans(ListResourceScansRequest request) 
        {
            return new ListResourceScansPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStackInstances operation
        ///</summary>
        public IListStackInstancesPaginator ListStackInstances(ListStackInstancesRequest request) 
        {
            return new ListStackInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStackRefactorActions operation
        ///</summary>
        public IListStackRefactorActionsPaginator ListStackRefactorActions(ListStackRefactorActionsRequest request) 
        {
            return new ListStackRefactorActionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStackRefactors operation
        ///</summary>
        public IListStackRefactorsPaginator ListStackRefactors(ListStackRefactorsRequest request) 
        {
            return new ListStackRefactorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStackResources operation
        ///</summary>
        public IListStackResourcesPaginator ListStackResources(ListStackResourcesRequest request) 
        {
            return new ListStackResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStacks operation
        ///</summary>
        public IListStacksPaginator ListStacks(ListStacksRequest request) 
        {
            return new ListStacksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStackSetOperationResults operation
        ///</summary>
        public IListStackSetOperationResultsPaginator ListStackSetOperationResults(ListStackSetOperationResultsRequest request) 
        {
            return new ListStackSetOperationResultsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStackSetOperations operation
        ///</summary>
        public IListStackSetOperationsPaginator ListStackSetOperations(ListStackSetOperationsRequest request) 
        {
            return new ListStackSetOperationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStackSets operation
        ///</summary>
        public IListStackSetsPaginator ListStackSets(ListStackSetsRequest request) 
        {
            return new ListStackSetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTypeRegistrations operation
        ///</summary>
        public IListTypeRegistrationsPaginator ListTypeRegistrations(ListTypeRegistrationsRequest request) 
        {
            return new ListTypeRegistrationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTypes operation
        ///</summary>
        public IListTypesPaginator ListTypes(ListTypesRequest request) 
        {
            return new ListTypesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTypeVersions operation
        ///</summary>
        public IListTypeVersionsPaginator ListTypeVersions(ListTypeVersionsRequest request) 
        {
            return new ListTypeVersionsPaginator(this.client, request);
        }
    }
}