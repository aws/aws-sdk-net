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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Paginators for the CodeDeploy service
    ///</summary>
    public class CodeDeployPaginatorFactory : ICodeDeployPaginatorFactory
    {
        private readonly IAmazonCodeDeploy client;

        internal CodeDeployPaginatorFactory(IAmazonCodeDeploy client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListApplicationRevisions operation
        ///</summary>
        public IListApplicationRevisionsPaginator ListApplicationRevisions(ListApplicationRevisionsRequest request) 
        {
            return new ListApplicationRevisionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListApplications operation
        ///</summary>
        public IListApplicationsPaginator ListApplications(ListApplicationsRequest request) 
        {
            return new ListApplicationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDeploymentConfigs operation
        ///</summary>
        public IListDeploymentConfigsPaginator ListDeploymentConfigs(ListDeploymentConfigsRequest request) 
        {
            return new ListDeploymentConfigsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDeploymentGroups operation
        ///</summary>
        public IListDeploymentGroupsPaginator ListDeploymentGroups(ListDeploymentGroupsRequest request) 
        {
            return new ListDeploymentGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDeploymentInstances operation
        ///</summary>
        public IListDeploymentInstancesPaginator ListDeploymentInstances(ListDeploymentInstancesRequest request) 
        {
            return new ListDeploymentInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDeployments operation
        ///</summary>
        public IListDeploymentsPaginator ListDeployments(ListDeploymentsRequest request) 
        {
            return new ListDeploymentsPaginator(this.client, request);
        }
    }
}