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
 * Do not modify this file. This file is generated from the artifact-2018-05-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Artifact.Model
{
    /// <summary>
    /// Paginators for the Artifact service
    ///</summary>
    public class ArtifactPaginatorFactory : IArtifactPaginatorFactory
    {
        private readonly IAmazonArtifact client;

        internal ArtifactPaginatorFactory(IAmazonArtifact client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListCustomerAgreements operation
        ///</summary>
        public IListCustomerAgreementsPaginator ListCustomerAgreements(ListCustomerAgreementsRequest request) 
        {
            return new ListCustomerAgreementsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReports operation
        ///</summary>
        public IListReportsPaginator ListReports(ListReportsRequest request) 
        {
            return new ListReportsPaginator(this.client, request);
        }
    }
}