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

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Paginators for the CodeDeploy service
    /// </summary>
    public interface ICodeDeployPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListApplicationRevisions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListApplicationRevisionsPaginator ListApplicationRevisions(ListApplicationRevisionsRequest request);

        /// <summary>
        /// Paginator for ListApplications operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListApplicationsPaginator ListApplications(ListApplicationsRequest request);

        /// <summary>
        /// Paginator for ListDeploymentConfigs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListDeploymentConfigsPaginator ListDeploymentConfigs(ListDeploymentConfigsRequest request);

        /// <summary>
        /// Paginator for ListDeploymentGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListDeploymentGroupsPaginator ListDeploymentGroups(ListDeploymentGroupsRequest request);

        /// <summary>
        /// Paginator for ListDeploymentInstances operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListDeploymentInstancesPaginator ListDeploymentInstances(ListDeploymentInstancesRequest request);

        /// <summary>
        /// Paginator for ListDeployments operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListDeploymentsPaginator ListDeployments(ListDeploymentsRequest request);
    }
}
