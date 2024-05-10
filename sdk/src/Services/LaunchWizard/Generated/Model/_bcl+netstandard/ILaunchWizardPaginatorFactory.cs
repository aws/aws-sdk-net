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
 * Do not modify this file. This file is generated from the launch-wizard-2018-05-10.normal.json service model.
 */

#pragma warning disable CS0612,CS0618
namespace Amazon.LaunchWizard.Model
{
    /// <summary>
    /// Paginators for the LaunchWizard service
    ///</summary>
    public interface ILaunchWizardPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListDeploymentEvents operation
        ///</summary>
        IListDeploymentEventsPaginator ListDeploymentEvents(ListDeploymentEventsRequest request);

        /// <summary>
        /// Paginator for ListDeployments operation
        ///</summary>
        IListDeploymentsPaginator ListDeployments(ListDeploymentsRequest request);

        /// <summary>
        /// Paginator for ListWorkloadDeploymentPatterns operation
        ///</summary>
        IListWorkloadDeploymentPatternsPaginator ListWorkloadDeploymentPatterns(ListWorkloadDeploymentPatternsRequest request);

        /// <summary>
        /// Paginator for ListWorkloads operation
        ///</summary>
        IListWorkloadsPaginator ListWorkloads(ListWorkloadsRequest request);
    }
}