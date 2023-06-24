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

namespace Amazon.MigrationHubOrchestrator.Model
{
    /// <summary>
    /// Paginators for the MigrationHubOrchestrator service
    ///</summary>
    public interface IMigrationHubOrchestratorPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListPlugins operation
        ///</summary>
        IListPluginsPaginator ListPlugins(ListPluginsRequest request);

        /// <summary>
        /// Paginator for ListTemplates operation
        ///</summary>
        IListTemplatesPaginator ListTemplates(ListTemplatesRequest request);

        /// <summary>
        /// Paginator for ListTemplateStepGroups operation
        ///</summary>
        IListTemplateStepGroupsPaginator ListTemplateStepGroups(ListTemplateStepGroupsRequest request);

        /// <summary>
        /// Paginator for ListTemplateSteps operation
        ///</summary>
        IListTemplateStepsPaginator ListTemplateSteps(ListTemplateStepsRequest request);

        /// <summary>
        /// Paginator for ListWorkflows operation
        ///</summary>
        IListWorkflowsPaginator ListWorkflows(ListWorkflowsRequest request);

        /// <summary>
        /// Paginator for ListWorkflowStepGroups operation
        ///</summary>
        IListWorkflowStepGroupsPaginator ListWorkflowStepGroups(ListWorkflowStepGroupsRequest request);

        /// <summary>
        /// Paginator for ListWorkflowSteps operation
        ///</summary>
        IListWorkflowStepsPaginator ListWorkflowSteps(ListWorkflowStepsRequest request);
    }
}