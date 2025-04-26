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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.PcaConnectorAd.Model
{
    /// <summary>
    /// Paginators for the PcaConnectorAd service
    ///</summary>
    public interface IPcaConnectorAdPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListConnectors operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListConnectorsPaginator ListConnectors(ListConnectorsRequest request);

        /// <summary>
        /// Paginator for ListDirectoryRegistrations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDirectoryRegistrationsPaginator ListDirectoryRegistrations(ListDirectoryRegistrationsRequest request);

        /// <summary>
        /// Paginator for ListServicePrincipalNames operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListServicePrincipalNamesPaginator ListServicePrincipalNames(ListServicePrincipalNamesRequest request);

        /// <summary>
        /// Paginator for ListTemplateGroupAccessControlEntries operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTemplateGroupAccessControlEntriesPaginator ListTemplateGroupAccessControlEntries(ListTemplateGroupAccessControlEntriesRequest request);

        /// <summary>
        /// Paginator for ListTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTemplatesPaginator ListTemplates(ListTemplatesRequest request);
    }
}