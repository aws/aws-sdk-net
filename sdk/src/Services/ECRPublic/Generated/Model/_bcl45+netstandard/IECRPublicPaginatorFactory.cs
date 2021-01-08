#if !NETSTANDARD13
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

namespace Amazon.ECRPublic.Model
{
    /// <summary>
    /// Paginators for the ECRPublic service
    ///</summary>
    public interface IECRPublicPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeImages operation
        ///</summary>
        IDescribeImagesPaginator DescribeImages(DescribeImagesRequest request);

        /// <summary>
        /// Paginator for DescribeImageTags operation
        ///</summary>
        IDescribeImageTagsPaginator DescribeImageTags(DescribeImageTagsRequest request);

        /// <summary>
        /// Paginator for DescribeRegistries operation
        ///</summary>
        IDescribeRegistriesPaginator DescribeRegistries(DescribeRegistriesRequest request);

        /// <summary>
        /// Paginator for DescribeRepositories operation
        ///</summary>
        IDescribeRepositoriesPaginator DescribeRepositories(DescribeRepositoriesRequest request);
    }
}
#endif