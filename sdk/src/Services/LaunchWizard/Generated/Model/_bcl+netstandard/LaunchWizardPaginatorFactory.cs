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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.LaunchWizard.Model
{
    /// <summary>
    /// Paginators for the LaunchWizard service
    ///</summary>
    public class LaunchWizardPaginatorFactory : ILaunchWizardPaginatorFactory
    {
        private readonly IAmazonLaunchWizard client;

        internal LaunchWizardPaginatorFactory(IAmazonLaunchWizard client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListDeploymentEvents operation
        ///</summary>
        public IListDeploymentEventsPaginator ListDeploymentEvents(ListDeploymentEventsRequest request) 
        {
            return new ListDeploymentEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDeployments operation
        ///</summary>
        public IListDeploymentsPaginator ListDeployments(ListDeploymentsRequest request) 
        {
            return new ListDeploymentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkloadDeploymentPatterns operation
        ///</summary>
        public IListWorkloadDeploymentPatternsPaginator ListWorkloadDeploymentPatterns(ListWorkloadDeploymentPatternsRequest request) 
        {
            return new ListWorkloadDeploymentPatternsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkloads operation
        ///</summary>
        public IListWorkloadsPaginator ListWorkloads(ListWorkloadsRequest request) 
        {
            return new ListWorkloadsPaginator(this.client, request);
        }
    }
}