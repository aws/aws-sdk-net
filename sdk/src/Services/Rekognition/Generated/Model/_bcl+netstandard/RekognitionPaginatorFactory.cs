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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Paginators for the Rekognition service
    ///</summary>
    public class RekognitionPaginatorFactory : IRekognitionPaginatorFactory
    {
        private readonly IAmazonRekognition client;

        internal RekognitionPaginatorFactory(IAmazonRekognition client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeProjects operation
        ///</summary>
        public IDescribeProjectsPaginator DescribeProjects(DescribeProjectsRequest request) 
        {
            return new DescribeProjectsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeProjectVersions operation
        ///</summary>
        public IDescribeProjectVersionsPaginator DescribeProjectVersions(DescribeProjectVersionsRequest request) 
        {
            return new DescribeProjectVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetCelebrityRecognition operation
        ///</summary>
        public IGetCelebrityRecognitionPaginator GetCelebrityRecognition(GetCelebrityRecognitionRequest request) 
        {
            return new GetCelebrityRecognitionPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetContentModeration operation
        ///</summary>
        public IGetContentModerationPaginator GetContentModeration(GetContentModerationRequest request) 
        {
            return new GetContentModerationPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetFaceDetection operation
        ///</summary>
        public IGetFaceDetectionPaginator GetFaceDetection(GetFaceDetectionRequest request) 
        {
            return new GetFaceDetectionPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetFaceSearch operation
        ///</summary>
        public IGetFaceSearchPaginator GetFaceSearch(GetFaceSearchRequest request) 
        {
            return new GetFaceSearchPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetLabelDetection operation
        ///</summary>
        public IGetLabelDetectionPaginator GetLabelDetection(GetLabelDetectionRequest request) 
        {
            return new GetLabelDetectionPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetPersonTracking operation
        ///</summary>
        public IGetPersonTrackingPaginator GetPersonTracking(GetPersonTrackingRequest request) 
        {
            return new GetPersonTrackingPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetSegmentDetection operation
        ///</summary>
        public IGetSegmentDetectionPaginator GetSegmentDetection(GetSegmentDetectionRequest request) 
        {
            return new GetSegmentDetectionPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetTextDetection operation
        ///</summary>
        public IGetTextDetectionPaginator GetTextDetection(GetTextDetectionRequest request) 
        {
            return new GetTextDetectionPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCollections operation
        ///</summary>
        public IListCollectionsPaginator ListCollections(ListCollectionsRequest request) 
        {
            return new ListCollectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDatasetEntries operation
        ///</summary>
        public IListDatasetEntriesPaginator ListDatasetEntries(ListDatasetEntriesRequest request) 
        {
            return new ListDatasetEntriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDatasetLabels operation
        ///</summary>
        public IListDatasetLabelsPaginator ListDatasetLabels(ListDatasetLabelsRequest request) 
        {
            return new ListDatasetLabelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFaces operation
        ///</summary>
        public IListFacesPaginator ListFaces(ListFacesRequest request) 
        {
            return new ListFacesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMediaAnalysisJobs operation
        ///</summary>
        public IListMediaAnalysisJobsPaginator ListMediaAnalysisJobs(ListMediaAnalysisJobsRequest request) 
        {
            return new ListMediaAnalysisJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProjectPolicies operation
        ///</summary>
        public IListProjectPoliciesPaginator ListProjectPolicies(ListProjectPoliciesRequest request) 
        {
            return new ListProjectPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStreamProcessors operation
        ///</summary>
        public IListStreamProcessorsPaginator ListStreamProcessors(ListStreamProcessorsRequest request) 
        {
            return new ListStreamProcessorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        public IListUsersPaginator ListUsers(ListUsersRequest request) 
        {
            return new ListUsersPaginator(this.client, request);
        }
    }
}