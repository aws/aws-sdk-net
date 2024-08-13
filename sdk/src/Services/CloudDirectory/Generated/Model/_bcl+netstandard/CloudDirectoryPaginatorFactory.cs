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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Paginators for the CloudDirectory service
    ///</summary>
    public class CloudDirectoryPaginatorFactory : ICloudDirectoryPaginatorFactory
    {
        private readonly IAmazonCloudDirectory client;

        internal CloudDirectoryPaginatorFactory(IAmazonCloudDirectory client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAppliedSchemaArns operation
        ///</summary>
        public IListAppliedSchemaArnsPaginator ListAppliedSchemaArns(ListAppliedSchemaArnsRequest request) 
        {
            return new ListAppliedSchemaArnsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAttachedIndices operation
        ///</summary>
        public IListAttachedIndicesPaginator ListAttachedIndices(ListAttachedIndicesRequest request) 
        {
            return new ListAttachedIndicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDevelopmentSchemaArns operation
        ///</summary>
        public IListDevelopmentSchemaArnsPaginator ListDevelopmentSchemaArns(ListDevelopmentSchemaArnsRequest request) 
        {
            return new ListDevelopmentSchemaArnsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDirectories operation
        ///</summary>
        public IListDirectoriesPaginator ListDirectories(ListDirectoriesRequest request) 
        {
            return new ListDirectoriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFacetAttributes operation
        ///</summary>
        public IListFacetAttributesPaginator ListFacetAttributes(ListFacetAttributesRequest request) 
        {
            return new ListFacetAttributesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFacetNames operation
        ///</summary>
        public IListFacetNamesPaginator ListFacetNames(ListFacetNamesRequest request) 
        {
            return new ListFacetNamesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIndex operation
        ///</summary>
        public IListIndexPaginator ListIndex(ListIndexRequest request) 
        {
            return new ListIndexPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListManagedSchemaArns operation
        ///</summary>
        public IListManagedSchemaArnsPaginator ListManagedSchemaArns(ListManagedSchemaArnsRequest request) 
        {
            return new ListManagedSchemaArnsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListObjectAttributes operation
        ///</summary>
        public IListObjectAttributesPaginator ListObjectAttributes(ListObjectAttributesRequest request) 
        {
            return new ListObjectAttributesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListObjectChildren operation
        ///</summary>
        public IListObjectChildrenPaginator ListObjectChildren(ListObjectChildrenRequest request) 
        {
            return new ListObjectChildrenPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListObjectParentPaths operation
        ///</summary>
        public IListObjectParentPathsPaginator ListObjectParentPaths(ListObjectParentPathsRequest request) 
        {
            return new ListObjectParentPathsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListObjectParents operation
        ///</summary>
        public IListObjectParentsPaginator ListObjectParents(ListObjectParentsRequest request) 
        {
            return new ListObjectParentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListObjectPolicies operation
        ///</summary>
        public IListObjectPoliciesPaginator ListObjectPolicies(ListObjectPoliciesRequest request) 
        {
            return new ListObjectPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPolicyAttachments operation
        ///</summary>
        public IListPolicyAttachmentsPaginator ListPolicyAttachments(ListPolicyAttachmentsRequest request) 
        {
            return new ListPolicyAttachmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPublishedSchemaArns operation
        ///</summary>
        public IListPublishedSchemaArnsPaginator ListPublishedSchemaArns(ListPublishedSchemaArnsRequest request) 
        {
            return new ListPublishedSchemaArnsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        public IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request) 
        {
            return new ListTagsForResourcePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTypedLinkFacetAttributes operation
        ///</summary>
        public IListTypedLinkFacetAttributesPaginator ListTypedLinkFacetAttributes(ListTypedLinkFacetAttributesRequest request) 
        {
            return new ListTypedLinkFacetAttributesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTypedLinkFacetNames operation
        ///</summary>
        public IListTypedLinkFacetNamesPaginator ListTypedLinkFacetNames(ListTypedLinkFacetNamesRequest request) 
        {
            return new ListTypedLinkFacetNamesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for LookupPolicy operation
        ///</summary>
        public ILookupPolicyPaginator LookupPolicy(LookupPolicyRequest request) 
        {
            return new LookupPolicyPaginator(this.client, request);
        }
    }
}