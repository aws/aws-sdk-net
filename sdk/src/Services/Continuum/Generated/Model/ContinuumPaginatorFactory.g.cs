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
#pragma warning disable CS0612,CS0618

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// Paginators for the Continuum service
    /// </summary>
    public class ContinuumPaginatorFactory : IContinuumPaginatorFactory
    {
        private readonly IAmazonContinuum client;

        internal ContinuumPaginatorFactory(IAmazonContinuum client)
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAssociatedCollectors operation
        /// </summary>
        public IListAssociatedCollectorsPaginator ListAssociatedCollectors(ListAssociatedCollectorsRequest request)
        {
            return new ListAssociatedCollectorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssociatedEnvironments operation
        /// </summary>
        public IListAssociatedEnvironmentsPaginator ListAssociatedEnvironments(ListAssociatedEnvironmentsRequest request)
        {
            return new ListAssociatedEnvironmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCodeFindings operation
        /// </summary>
        public IListCodeFindingsPaginator ListCodeFindings(ListCodeFindingsRequest request)
        {
            return new ListCodeFindingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCodeIssueArtifacts operation
        /// </summary>
        public IListCodeIssueArtifactsPaginator ListCodeIssueArtifacts(ListCodeIssueArtifactsRequest request)
        {
            return new ListCodeIssueArtifactsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCodeIssues operation
        /// </summary>
        public IListCodeIssuesPaginator ListCodeIssues(ListCodeIssuesRequest request)
        {
            return new ListCodeIssuesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCodeScans operation
        /// </summary>
        public IListCodeScansPaginator ListCodeScans(ListCodeScansRequest request)
        {
            return new ListCodeScansPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEnvironments operation
        /// </summary>
        public IListEnvironmentsPaginator ListEnvironments(ListEnvironmentsRequest request)
        {
            return new ListEnvironmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIntegrations operation
        /// </summary>
        public IListIntegrationsPaginator ListIntegrations(ListIntegrationsRequest request)
        {
            return new ListIntegrationsPaginator(this.client, request);
        }
    }
}
