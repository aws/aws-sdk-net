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
 * Do not modify this file. This file is generated from the migrationhuborchestrator-2021-08-28.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.MigrationHubOrchestrator.Model
{
    /// <summary>
    /// Paginators for the MigrationHubOrchestrator service
    ///</summary>
    public class MigrationHubOrchestratorPaginatorFactory : IMigrationHubOrchestratorPaginatorFactory
    {
        private readonly IAmazonMigrationHubOrchestrator client;

        internal MigrationHubOrchestratorPaginatorFactory(IAmazonMigrationHubOrchestrator client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListPlugins operation
        ///</summary>
        public IListPluginsPaginator ListPlugins(ListPluginsRequest request) 
        {
            return new ListPluginsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTemplates operation
        ///</summary>
        public IListTemplatesPaginator ListTemplates(ListTemplatesRequest request) 
        {
            return new ListTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTemplateStepGroups operation
        ///</summary>
        public IListTemplateStepGroupsPaginator ListTemplateStepGroups(ListTemplateStepGroupsRequest request) 
        {
            return new ListTemplateStepGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTemplateSteps operation
        ///</summary>
        public IListTemplateStepsPaginator ListTemplateSteps(ListTemplateStepsRequest request) 
        {
            return new ListTemplateStepsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkflows operation
        ///</summary>
        public IListWorkflowsPaginator ListWorkflows(ListWorkflowsRequest request) 
        {
            return new ListWorkflowsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkflowStepGroups operation
        ///</summary>
        public IListWorkflowStepGroupsPaginator ListWorkflowStepGroups(ListWorkflowStepGroupsRequest request) 
        {
            return new ListWorkflowStepGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkflowSteps operation
        ///</summary>
        public IListWorkflowStepsPaginator ListWorkflowSteps(ListWorkflowStepsRequest request) 
        {
            return new ListWorkflowStepsPaginator(this.client, request);
        }
    }
}