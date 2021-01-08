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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Paginators for the Glue service
    ///</summary>
    public class GluePaginatorFactory : IGluePaginatorFactory
    {
        private readonly IAmazonGlue client;

        internal GluePaginatorFactory(IAmazonGlue client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetClassifiers operation
        ///</summary>
        public IGetClassifiersPaginator GetClassifiers(GetClassifiersRequest request) 
        {
            return new GetClassifiersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetConnections operation
        ///</summary>
        public IGetConnectionsPaginator GetConnections(GetConnectionsRequest request) 
        {
            return new GetConnectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetCrawlerMetrics operation
        ///</summary>
        public IGetCrawlerMetricsPaginator GetCrawlerMetrics(GetCrawlerMetricsRequest request) 
        {
            return new GetCrawlerMetricsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetCrawlers operation
        ///</summary>
        public IGetCrawlersPaginator GetCrawlers(GetCrawlersRequest request) 
        {
            return new GetCrawlersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetDatabases operation
        ///</summary>
        public IGetDatabasesPaginator GetDatabases(GetDatabasesRequest request) 
        {
            return new GetDatabasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetDevEndpoints operation
        ///</summary>
        public IGetDevEndpointsPaginator GetDevEndpoints(GetDevEndpointsRequest request) 
        {
            return new GetDevEndpointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetJobRuns operation
        ///</summary>
        public IGetJobRunsPaginator GetJobRuns(GetJobRunsRequest request) 
        {
            return new GetJobRunsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetJobs operation
        ///</summary>
        public IGetJobsPaginator GetJobs(GetJobsRequest request) 
        {
            return new GetJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetMLTaskRuns operation
        ///</summary>
        public IGetMLTaskRunsPaginator GetMLTaskRuns(GetMLTaskRunsRequest request) 
        {
            return new GetMLTaskRunsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetMLTransforms operation
        ///</summary>
        public IGetMLTransformsPaginator GetMLTransforms(GetMLTransformsRequest request) 
        {
            return new GetMLTransformsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetPartitionIndexes operation
        ///</summary>
        public IGetPartitionIndexesPaginator GetPartitionIndexes(GetPartitionIndexesRequest request) 
        {
            return new GetPartitionIndexesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetPartitions operation
        ///</summary>
        public IGetPartitionsPaginator GetPartitions(GetPartitionsRequest request) 
        {
            return new GetPartitionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetResourcePolicies operation
        ///</summary>
        public IGetResourcePoliciesPaginator GetResourcePolicies(GetResourcePoliciesRequest request) 
        {
            return new GetResourcePoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetSecurityConfigurations operation
        ///</summary>
        public IGetSecurityConfigurationsPaginator GetSecurityConfigurations(GetSecurityConfigurationsRequest request) 
        {
            return new GetSecurityConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetTables operation
        ///</summary>
        public IGetTablesPaginator GetTables(GetTablesRequest request) 
        {
            return new GetTablesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetTableVersions operation
        ///</summary>
        public IGetTableVersionsPaginator GetTableVersions(GetTableVersionsRequest request) 
        {
            return new GetTableVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetTriggers operation
        ///</summary>
        public IGetTriggersPaginator GetTriggers(GetTriggersRequest request) 
        {
            return new GetTriggersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetUserDefinedFunctions operation
        ///</summary>
        public IGetUserDefinedFunctionsPaginator GetUserDefinedFunctions(GetUserDefinedFunctionsRequest request) 
        {
            return new GetUserDefinedFunctionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetWorkflowRuns operation
        ///</summary>
        public IGetWorkflowRunsPaginator GetWorkflowRuns(GetWorkflowRunsRequest request) 
        {
            return new GetWorkflowRunsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCrawlers operation
        ///</summary>
        public IListCrawlersPaginator ListCrawlers(ListCrawlersRequest request) 
        {
            return new ListCrawlersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDevEndpoints operation
        ///</summary>
        public IListDevEndpointsPaginator ListDevEndpoints(ListDevEndpointsRequest request) 
        {
            return new ListDevEndpointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListJobs operation
        ///</summary>
        public IListJobsPaginator ListJobs(ListJobsRequest request) 
        {
            return new ListJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMLTransforms operation
        ///</summary>
        public IListMLTransformsPaginator ListMLTransforms(ListMLTransformsRequest request) 
        {
            return new ListMLTransformsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRegistries operation
        ///</summary>
        public IListRegistriesPaginator ListRegistries(ListRegistriesRequest request) 
        {
            return new ListRegistriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSchemas operation
        ///</summary>
        public IListSchemasPaginator ListSchemas(ListSchemasRequest request) 
        {
            return new ListSchemasPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSchemaVersions operation
        ///</summary>
        public IListSchemaVersionsPaginator ListSchemaVersions(ListSchemaVersionsRequest request) 
        {
            return new ListSchemaVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTriggers operation
        ///</summary>
        public IListTriggersPaginator ListTriggers(ListTriggersRequest request) 
        {
            return new ListTriggersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkflows operation
        ///</summary>
        public IListWorkflowsPaginator ListWorkflows(ListWorkflowsRequest request) 
        {
            return new ListWorkflowsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchTables operation
        ///</summary>
        public ISearchTablesPaginator SearchTables(SearchTablesRequest request) 
        {
            return new SearchTablesPaginator(this.client, request);
        }
    }
}
#endif