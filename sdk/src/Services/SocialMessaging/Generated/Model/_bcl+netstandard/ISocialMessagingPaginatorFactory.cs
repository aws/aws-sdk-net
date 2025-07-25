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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// Paginators for the SocialMessaging service
    ///</summary>
    public interface ISocialMessagingPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListLinkedWhatsAppBusinessAccounts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLinkedWhatsAppBusinessAccountsPaginator ListLinkedWhatsAppBusinessAccounts(ListLinkedWhatsAppBusinessAccountsRequest request);

        /// <summary>
        /// Paginator for ListWhatsAppMessageTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWhatsAppMessageTemplatesPaginator ListWhatsAppMessageTemplates(ListWhatsAppMessageTemplatesRequest request);

        /// <summary>
        /// Paginator for ListWhatsAppTemplateLibrary operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWhatsAppTemplateLibraryPaginator ListWhatsAppTemplateLibrary(ListWhatsAppTemplateLibraryRequest request);
    }
}