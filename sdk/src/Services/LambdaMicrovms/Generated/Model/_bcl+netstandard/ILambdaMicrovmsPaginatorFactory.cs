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
 * Do not modify this file. This file is generated from the lambda-microvms-2025-09-09.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.LambdaMicrovms.Model
{
    /// <summary>
    /// Paginators for the LambdaMicrovms service
    ///</summary>
    public interface ILambdaMicrovmsPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListManagedMicrovmImages operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListManagedMicrovmImagesPaginator ListManagedMicrovmImages(ListManagedMicrovmImagesRequest request);

        /// <summary>
        /// Paginator for ListManagedMicrovmImageVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListManagedMicrovmImageVersionsPaginator ListManagedMicrovmImageVersions(ListManagedMicrovmImageVersionsRequest request);

        /// <summary>
        /// Paginator for ListMicrovmImageBuilds operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMicrovmImageBuildsPaginator ListMicrovmImageBuilds(ListMicrovmImageBuildsRequest request);

        /// <summary>
        /// Paginator for ListMicrovmImages operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMicrovmImagesPaginator ListMicrovmImages(ListMicrovmImagesRequest request);

        /// <summary>
        /// Paginator for ListMicrovmImageVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMicrovmImageVersionsPaginator ListMicrovmImageVersions(ListMicrovmImageVersionsRequest request);

        /// <summary>
        /// Paginator for ListMicrovms operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMicrovmsPaginator ListMicrovms(ListMicrovmsRequest request);
    }
}