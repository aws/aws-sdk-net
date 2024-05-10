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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// Paginators for the CloudWatchEvidently service
    ///</summary>
    public class CloudWatchEvidentlyPaginatorFactory : ICloudWatchEvidentlyPaginatorFactory
    {
        private readonly IAmazonCloudWatchEvidently client;

        internal CloudWatchEvidentlyPaginatorFactory(IAmazonCloudWatchEvidently client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListExperiments operation
        ///</summary>
        public IListExperimentsPaginator ListExperiments(ListExperimentsRequest request) 
        {
            return new ListExperimentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFeatures operation
        ///</summary>
        public IListFeaturesPaginator ListFeatures(ListFeaturesRequest request) 
        {
            return new ListFeaturesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLaunches operation
        ///</summary>
        public IListLaunchesPaginator ListLaunches(ListLaunchesRequest request) 
        {
            return new ListLaunchesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProjects operation
        ///</summary>
        public IListProjectsPaginator ListProjects(ListProjectsRequest request) 
        {
            return new ListProjectsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSegmentReferences operation
        ///</summary>
        public IListSegmentReferencesPaginator ListSegmentReferences(ListSegmentReferencesRequest request) 
        {
            return new ListSegmentReferencesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSegments operation
        ///</summary>
        public IListSegmentsPaginator ListSegments(ListSegmentsRequest request) 
        {
            return new ListSegmentsPaginator(this.client, request);
        }
    }
}