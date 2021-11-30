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

namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// Paginators for the CloudWatchEvidently service
    ///</summary>
    public interface ICloudWatchEvidentlyPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListExperiments operation
        ///</summary>
        IListExperimentsPaginator ListExperiments(ListExperimentsRequest request);

        /// <summary>
        /// Paginator for ListFeatures operation
        ///</summary>
        IListFeaturesPaginator ListFeatures(ListFeaturesRequest request);

        /// <summary>
        /// Paginator for ListLaunches operation
        ///</summary>
        IListLaunchesPaginator ListLaunches(ListLaunchesRequest request);

        /// <summary>
        /// Paginator for ListProjects operation
        ///</summary>
        IListProjectsPaginator ListProjects(ListProjectsRequest request);
    }
}