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
 * Do not modify this file. This file is generated from the ecr-public-2020-10-30.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ECRPublic.Model
{
    /// <summary>
    /// Paginators for the ECRPublic service
    ///</summary>
    public class ECRPublicPaginatorFactory : IECRPublicPaginatorFactory
    {
        private readonly IAmazonECRPublic client;

        internal ECRPublicPaginatorFactory(IAmazonECRPublic client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeImages operation
        ///</summary>
        public IDescribeImagesPaginator DescribeImages(DescribeImagesRequest request) 
        {
            return new DescribeImagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeImageTags operation
        ///</summary>
        public IDescribeImageTagsPaginator DescribeImageTags(DescribeImageTagsRequest request) 
        {
            return new DescribeImageTagsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeRegistries operation
        ///</summary>
        public IDescribeRegistriesPaginator DescribeRegistries(DescribeRegistriesRequest request) 
        {
            return new DescribeRegistriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeRepositories operation
        ///</summary>
        public IDescribeRepositoriesPaginator DescribeRepositories(DescribeRepositoriesRequest request) 
        {
            return new DescribeRepositoriesPaginator(this.client, request);
        }
    }
}