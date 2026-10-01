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

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Paginators for the CloudDirectory service
    /// </summary>
    public interface ICloudDirectoryPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListAppliedSchemaArns operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAppliedSchemaArnsPaginator ListAppliedSchemaArns(ListAppliedSchemaArnsRequest request);

        /// <summary>
        /// Paginator for ListAttachedIndices operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAttachedIndicesPaginator ListAttachedIndices(ListAttachedIndicesRequest request);

        /// <summary>
        /// Paginator for ListDevelopmentSchemaArns operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDevelopmentSchemaArnsPaginator ListDevelopmentSchemaArns(ListDevelopmentSchemaArnsRequest request);

        /// <summary>
        /// Paginator for ListDirectories operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDirectoriesPaginator ListDirectories(ListDirectoriesRequest request);

        /// <summary>
        /// Paginator for ListFacetAttributes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListFacetAttributesPaginator ListFacetAttributes(ListFacetAttributesRequest request);

        /// <summary>
        /// Paginator for ListFacetNames operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListFacetNamesPaginator ListFacetNames(ListFacetNamesRequest request);

        /// <summary>
        /// Paginator for ListIndex operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListIndexPaginator ListIndex(ListIndexRequest request);

        /// <summary>
        /// Paginator for ListManagedSchemaArns operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListManagedSchemaArnsPaginator ListManagedSchemaArns(ListManagedSchemaArnsRequest request);

        /// <summary>
        /// Paginator for ListObjectAttributes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListObjectAttributesPaginator ListObjectAttributes(ListObjectAttributesRequest request);

        /// <summary>
        /// Paginator for ListObjectChildren operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListObjectChildrenPaginator ListObjectChildren(ListObjectChildrenRequest request);

        /// <summary>
        /// Paginator for ListObjectParentPaths operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListObjectParentPathsPaginator ListObjectParentPaths(ListObjectParentPathsRequest request);

        /// <summary>
        /// Paginator for ListObjectParents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListObjectParentsPaginator ListObjectParents(ListObjectParentsRequest request);

        /// <summary>
        /// Paginator for ListObjectPolicies operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListObjectPoliciesPaginator ListObjectPolicies(ListObjectPoliciesRequest request);

        /// <summary>
        /// Paginator for ListPolicyAttachments operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPolicyAttachmentsPaginator ListPolicyAttachments(ListPolicyAttachmentsRequest request);

        /// <summary>
        /// Paginator for ListPublishedSchemaArns operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPublishedSchemaArnsPaginator ListPublishedSchemaArns(ListPublishedSchemaArnsRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Paginator for ListTypedLinkFacetAttributes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTypedLinkFacetAttributesPaginator ListTypedLinkFacetAttributes(ListTypedLinkFacetAttributesRequest request);

        /// <summary>
        /// Paginator for ListTypedLinkFacetNames operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTypedLinkFacetNamesPaginator ListTypedLinkFacetNames(ListTypedLinkFacetNamesRequest request);

        /// <summary>
        /// Paginator for LookupPolicy operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ILookupPolicyPaginator LookupPolicy(LookupPolicyRequest request);
    }
}
