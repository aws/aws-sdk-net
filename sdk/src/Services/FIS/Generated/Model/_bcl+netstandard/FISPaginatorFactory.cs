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
 * Do not modify this file. This file is generated from the fis-2020-12-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.FIS.Model
{
    /// <summary>
    /// Paginators for the FIS service
    ///</summary>
    public class FISPaginatorFactory : IFISPaginatorFactory
    {
        private readonly IAmazonFIS client;

        internal FISPaginatorFactory(IAmazonFIS client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListActions operation
        ///</summary>
        public IListActionsPaginator ListActions(ListActionsRequest request) 
        {
            return new ListActionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListExperimentResolvedTargets operation
        ///</summary>
        public IListExperimentResolvedTargetsPaginator ListExperimentResolvedTargets(ListExperimentResolvedTargetsRequest request) 
        {
            return new ListExperimentResolvedTargetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListExperiments operation
        ///</summary>
        public IListExperimentsPaginator ListExperiments(ListExperimentsRequest request) 
        {
            return new ListExperimentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListExperimentTemplates operation
        ///</summary>
        public IListExperimentTemplatesPaginator ListExperimentTemplates(ListExperimentTemplatesRequest request) 
        {
            return new ListExperimentTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTargetAccountConfigurations operation
        ///</summary>
        public IListTargetAccountConfigurationsPaginator ListTargetAccountConfigurations(ListTargetAccountConfigurationsRequest request) 
        {
            return new ListTargetAccountConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTargetResourceTypes operation
        ///</summary>
        public IListTargetResourceTypesPaginator ListTargetResourceTypes(ListTargetResourceTypesRequest request) 
        {
            return new ListTargetResourceTypesPaginator(this.client, request);
        }
    }
}