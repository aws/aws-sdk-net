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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Paginators for the AppStream service
    ///</summary>
    public interface IAppStreamPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeAppBlockBuilderAppBlockAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeAppBlockBuilderAppBlockAssociationsPaginator DescribeAppBlockBuilderAppBlockAssociations(DescribeAppBlockBuilderAppBlockAssociationsRequest request);

        /// <summary>
        /// Paginator for DescribeAppBlockBuilders operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeAppBlockBuildersPaginator DescribeAppBlockBuilders(DescribeAppBlockBuildersRequest request);

        /// <summary>
        /// Paginator for DescribeImagePermissions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeImagePermissionsPaginator DescribeImagePermissions(DescribeImagePermissionsRequest request);

        /// <summary>
        /// Paginator for DescribeImages operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeImagesPaginator DescribeImages(DescribeImagesRequest request);
    }
}