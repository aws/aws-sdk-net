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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Paginators for the Inspector service
    ///</summary>
    public class InspectorPaginatorFactory : IInspectorPaginatorFactory
    {
        private readonly IAmazonInspector client;

        internal InspectorPaginatorFactory(IAmazonInspector client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetExclusionsPreview operation
        ///</summary>
        public IGetExclusionsPreviewPaginator GetExclusionsPreview(GetExclusionsPreviewRequest request) 
        {
            return new GetExclusionsPreviewPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssessmentRunAgents operation
        ///</summary>
        public IListAssessmentRunAgentsPaginator ListAssessmentRunAgents(ListAssessmentRunAgentsRequest request) 
        {
            return new ListAssessmentRunAgentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssessmentRuns operation
        ///</summary>
        public IListAssessmentRunsPaginator ListAssessmentRuns(ListAssessmentRunsRequest request) 
        {
            return new ListAssessmentRunsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssessmentTargets operation
        ///</summary>
        public IListAssessmentTargetsPaginator ListAssessmentTargets(ListAssessmentTargetsRequest request) 
        {
            return new ListAssessmentTargetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssessmentTemplates operation
        ///</summary>
        public IListAssessmentTemplatesPaginator ListAssessmentTemplates(ListAssessmentTemplatesRequest request) 
        {
            return new ListAssessmentTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEventSubscriptions operation
        ///</summary>
        public IListEventSubscriptionsPaginator ListEventSubscriptions(ListEventSubscriptionsRequest request) 
        {
            return new ListEventSubscriptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListExclusions operation
        ///</summary>
        public IListExclusionsPaginator ListExclusions(ListExclusionsRequest request) 
        {
            return new ListExclusionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFindings operation
        ///</summary>
        public IListFindingsPaginator ListFindings(ListFindingsRequest request) 
        {
            return new ListFindingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRulesPackages operation
        ///</summary>
        public IListRulesPackagesPaginator ListRulesPackages(ListRulesPackagesRequest request) 
        {
            return new ListRulesPackagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for PreviewAgents operation
        ///</summary>
        public IPreviewAgentsPaginator PreviewAgents(PreviewAgentsRequest request) 
        {
            return new PreviewAgentsPaginator(this.client, request);
        }
    }
}