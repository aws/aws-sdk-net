#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
 */

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Paginators for the CloudDirectory service
    ///</summary>
    public interface ICloudDirectoryPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAppliedSchemaArns operation
        ///</summary>
        IListAppliedSchemaArnsPaginator ListAppliedSchemaArns(ListAppliedSchemaArnsRequest request);

        /// <summary>
        /// Paginator for ListAttachedIndices operation
        ///</summary>
        IListAttachedIndicesPaginator ListAttachedIndices(ListAttachedIndicesRequest request);

        /// <summary>
        /// Paginator for ListDevelopmentSchemaArns operation
        ///</summary>
        IListDevelopmentSchemaArnsPaginator ListDevelopmentSchemaArns(ListDevelopmentSchemaArnsRequest request);

        /// <summary>
        /// Paginator for ListDirectories operation
        ///</summary>
        IListDirectoriesPaginator ListDirectories(ListDirectoriesRequest request);

        /// <summary>
        /// Paginator for ListFacetAttributes operation
        ///</summary>
        IListFacetAttributesPaginator ListFacetAttributes(ListFacetAttributesRequest request);

        /// <summary>
        /// Paginator for ListFacetNames operation
        ///</summary>
        IListFacetNamesPaginator ListFacetNames(ListFacetNamesRequest request);

        /// <summary>
        /// Paginator for ListIndex operation
        ///</summary>
        IListIndexPaginator ListIndex(ListIndexRequest request);

        /// <summary>
        /// Paginator for ListManagedSchemaArns operation
        ///</summary>
        IListManagedSchemaArnsPaginator ListManagedSchemaArns(ListManagedSchemaArnsRequest request);

        /// <summary>
        /// Paginator for ListObjectAttributes operation
        ///</summary>
        IListObjectAttributesPaginator ListObjectAttributes(ListObjectAttributesRequest request);

        /// <summary>
        /// Paginator for ListObjectChildren operation
        ///</summary>
        IListObjectChildrenPaginator ListObjectChildren(ListObjectChildrenRequest request);

        /// <summary>
        /// Paginator for ListObjectParentPaths operation
        ///</summary>
        IListObjectParentPathsPaginator ListObjectParentPaths(ListObjectParentPathsRequest request);

        /// <summary>
        /// Paginator for ListObjectParents operation
        ///</summary>
        IListObjectParentsPaginator ListObjectParents(ListObjectParentsRequest request);

        /// <summary>
        /// Paginator for ListObjectPolicies operation
        ///</summary>
        IListObjectPoliciesPaginator ListObjectPolicies(ListObjectPoliciesRequest request);

        /// <summary>
        /// Paginator for ListPolicyAttachments operation
        ///</summary>
        IListPolicyAttachmentsPaginator ListPolicyAttachments(ListPolicyAttachmentsRequest request);

        /// <summary>
        /// Paginator for ListPublishedSchemaArns operation
        ///</summary>
        IListPublishedSchemaArnsPaginator ListPublishedSchemaArns(ListPublishedSchemaArnsRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Paginator for ListTypedLinkFacetAttributes operation
        ///</summary>
        IListTypedLinkFacetAttributesPaginator ListTypedLinkFacetAttributes(ListTypedLinkFacetAttributesRequest request);

        /// <summary>
        /// Paginator for ListTypedLinkFacetNames operation
        ///</summary>
        IListTypedLinkFacetNamesPaginator ListTypedLinkFacetNames(ListTypedLinkFacetNamesRequest request);

        /// <summary>
        /// Paginator for LookupPolicy operation
        ///</summary>
        ILookupPolicyPaginator LookupPolicy(LookupPolicyRequest request);
    }
}
#endif