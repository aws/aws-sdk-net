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
        IDescribeProjectsPaginator DescribeProjects(DescribeProjectsRequest request);

        /// <summary>
        /// Paginator for DescribeProjectVersions operation
        ///</summary>
        IDescribeProjectVersionsPaginator DescribeProjectVersions(DescribeProjectVersionsRequest request);

        /// <summary>
        /// Paginator for GetCelebrityRecognition operation
        ///</summary>
        IGetCelebrityRecognitionPaginator GetCelebrityRecognition(GetCelebrityRecognitionRequest request);

        /// <summary>
        /// Paginator for GetContentModeration operation
        ///</summary>
        IGetContentModerationPaginator GetContentModeration(GetContentModerationRequest request);

        /// <summary>
        /// Paginator for GetFaceDetection operation
        ///</summary>
        IGetFaceDetectionPaginator GetFaceDetection(GetFaceDetectionRequest request);

        /// <summary>
        /// Paginator for GetFaceSearch operation
        ///</summary>
        IGetFaceSearchPaginator GetFaceSearch(GetFaceSearchRequest request);

        /// <summary>
        /// Paginator for GetLabelDetection operation
        ///</summary>
        IGetLabelDetectionPaginator GetLabelDetection(GetLabelDetectionRequest request);

        /// <summary>
        /// Paginator for GetPersonTracking operation
        ///</summary>
        IGetPersonTrackingPaginator GetPersonTracking(GetPersonTrackingRequest request);

        /// <summary>
        /// Paginator for GetSegmentDetection operation
        ///</summary>
        IGetSegmentDetectionPaginator GetSegmentDetection(GetSegmentDetectionRequest request);

        /// <summary>
        /// Paginator for GetTextDetection operation
        ///</summary>
        IGetTextDetectionPaginator GetTextDetection(GetTextDetectionRequest request);

        /// <summary>
        /// Paginator for ListCollections operation
        ///</summary>
        IListCollectionsPaginator ListCollections(ListCollectionsRequest request);

        /// <summary>
        /// Paginator for ListDatasetEntries operation
        ///</summary>
        IListDatasetEntriesPaginator ListDatasetEntries(ListDatasetEntriesRequest request);

        /// <summary>
        /// Paginator for ListDatasetLabels operation
        ///</summary>
        IListDatasetLabelsPaginator ListDatasetLabels(ListDatasetLabelsRequest request);

        /// <summary>
        /// Paginator for ListFaces operation
        ///</summary>
        IListFacesPaginator ListFaces(ListFacesRequest request);

        /// <summary>
        /// Paginator for ListProjectPolicies operation
        ///</summary>
        IListProjectPoliciesPaginator ListProjectPolicies(ListProjectPoliciesRequest request);

        /// <summary>
        /// Paginator for ListStreamProcessors operation
        ///</summary>
        IListStreamProcessorsPaginator ListStreamProcessors(ListStreamProcessorsRequest request);

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        IListUsersPaginator ListUsers(ListUsersRequest request);
    }
}