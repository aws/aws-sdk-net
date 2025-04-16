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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Paginators for the Rekognition service
    ///</summary>
    public interface IRekognitionPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeProjects operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeProjectsPaginator DescribeProjects(DescribeProjectsRequest request);

        /// <summary>
        /// Paginator for DescribeProjectVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeProjectVersionsPaginator DescribeProjectVersions(DescribeProjectVersionsRequest request);

        /// <summary>
        /// Paginator for GetCelebrityRecognition operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetCelebrityRecognitionPaginator GetCelebrityRecognition(GetCelebrityRecognitionRequest request);

        /// <summary>
        /// Paginator for GetContentModeration operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetContentModerationPaginator GetContentModeration(GetContentModerationRequest request);

        /// <summary>
        /// Paginator for GetFaceDetection operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetFaceDetectionPaginator GetFaceDetection(GetFaceDetectionRequest request);

        /// <summary>
        /// Paginator for GetFaceSearch operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetFaceSearchPaginator GetFaceSearch(GetFaceSearchRequest request);

        /// <summary>
        /// Paginator for GetLabelDetection operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetLabelDetectionPaginator GetLabelDetection(GetLabelDetectionRequest request);

        /// <summary>
        /// Paginator for GetPersonTracking operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetPersonTrackingPaginator GetPersonTracking(GetPersonTrackingRequest request);

        /// <summary>
        /// Paginator for GetSegmentDetection operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetSegmentDetectionPaginator GetSegmentDetection(GetSegmentDetectionRequest request);

        /// <summary>
        /// Paginator for GetTextDetection operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetTextDetectionPaginator GetTextDetection(GetTextDetectionRequest request);

        /// <summary>
        /// Paginator for ListCollections operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCollectionsPaginator ListCollections(ListCollectionsRequest request);

        /// <summary>
        /// Paginator for ListDatasetEntries operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDatasetEntriesPaginator ListDatasetEntries(ListDatasetEntriesRequest request);

        /// <summary>
        /// Paginator for ListDatasetLabels operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDatasetLabelsPaginator ListDatasetLabels(ListDatasetLabelsRequest request);

        /// <summary>
        /// Paginator for ListFaces operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFacesPaginator ListFaces(ListFacesRequest request);

        /// <summary>
        /// Paginator for ListMediaAnalysisJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMediaAnalysisJobsPaginator ListMediaAnalysisJobs(ListMediaAnalysisJobsRequest request);

        /// <summary>
        /// Paginator for ListProjectPolicies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListProjectPoliciesPaginator ListProjectPolicies(ListProjectPoliciesRequest request);

        /// <summary>
        /// Paginator for ListStreamProcessors operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListStreamProcessorsPaginator ListStreamProcessors(ListStreamProcessorsRequest request);

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListUsersPaginator ListUsers(ListUsersRequest request);
    }
}