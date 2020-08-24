#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Paginators for the SageMaker service
    ///</summary>
    public class SageMakerPaginatorFactory : ISageMakerPaginatorFactory
    {
        private readonly IAmazonSageMaker client;

        internal SageMakerPaginatorFactory(IAmazonSageMaker client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAlgorithms operation
        ///</summary>
        public IListAlgorithmsPaginator ListAlgorithms(ListAlgorithmsRequest request) 
        {
            return new ListAlgorithmsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListApps operation
        ///</summary>
        public IListAppsPaginator ListApps(ListAppsRequest request) 
        {
            return new ListAppsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAutoMLJobs operation
        ///</summary>
        public IListAutoMLJobsPaginator ListAutoMLJobs(ListAutoMLJobsRequest request) 
        {
            return new ListAutoMLJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCandidatesForAutoMLJob operation
        ///</summary>
        public IListCandidatesForAutoMLJobPaginator ListCandidatesForAutoMLJob(ListCandidatesForAutoMLJobRequest request) 
        {
            return new ListCandidatesForAutoMLJobPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCodeRepositories operation
        ///</summary>
        public IListCodeRepositoriesPaginator ListCodeRepositories(ListCodeRepositoriesRequest request) 
        {
            return new ListCodeRepositoriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCompilationJobs operation
        ///</summary>
        public IListCompilationJobsPaginator ListCompilationJobs(ListCompilationJobsRequest request) 
        {
            return new ListCompilationJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDomains operation
        ///</summary>
        public IListDomainsPaginator ListDomains(ListDomainsRequest request) 
        {
            return new ListDomainsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEndpointConfigs operation
        ///</summary>
        public IListEndpointConfigsPaginator ListEndpointConfigs(ListEndpointConfigsRequest request) 
        {
            return new ListEndpointConfigsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEndpoints operation
        ///</summary>
        public IListEndpointsPaginator ListEndpoints(ListEndpointsRequest request) 
        {
            return new ListEndpointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListExperiments operation
        ///</summary>
        public IListExperimentsPaginator ListExperiments(ListExperimentsRequest request) 
        {
            return new ListExperimentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFlowDefinitions operation
        ///</summary>
        public IListFlowDefinitionsPaginator ListFlowDefinitions(ListFlowDefinitionsRequest request) 
        {
            return new ListFlowDefinitionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListHumanTaskUis operation
        ///</summary>
        public IListHumanTaskUisPaginator ListHumanTaskUis(ListHumanTaskUisRequest request) 
        {
            return new ListHumanTaskUisPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListHyperParameterTuningJobs operation
        ///</summary>
        public IListHyperParameterTuningJobsPaginator ListHyperParameterTuningJobs(ListHyperParameterTuningJobsRequest request) 
        {
            return new ListHyperParameterTuningJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLabelingJobs operation
        ///</summary>
        public IListLabelingJobsPaginator ListLabelingJobs(ListLabelingJobsRequest request) 
        {
            return new ListLabelingJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLabelingJobsForWorkteam operation
        ///</summary>
        public IListLabelingJobsForWorkteamPaginator ListLabelingJobsForWorkteam(ListLabelingJobsForWorkteamRequest request) 
        {
            return new ListLabelingJobsForWorkteamPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListModelPackages operation
        ///</summary>
        public IListModelPackagesPaginator ListModelPackages(ListModelPackagesRequest request) 
        {
            return new ListModelPackagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListModels operation
        ///</summary>
        public IListModelsPaginator ListModels(ListModelsRequest request) 
        {
            return new ListModelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMonitoringExecutions operation
        ///</summary>
        public IListMonitoringExecutionsPaginator ListMonitoringExecutions(ListMonitoringExecutionsRequest request) 
        {
            return new ListMonitoringExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMonitoringSchedules operation
        ///</summary>
        public IListMonitoringSchedulesPaginator ListMonitoringSchedules(ListMonitoringSchedulesRequest request) 
        {
            return new ListMonitoringSchedulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNotebookInstanceLifecycleConfigs operation
        ///</summary>
        public IListNotebookInstanceLifecycleConfigsPaginator ListNotebookInstanceLifecycleConfigs(ListNotebookInstanceLifecycleConfigsRequest request) 
        {
            return new ListNotebookInstanceLifecycleConfigsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNotebookInstances operation
        ///</summary>
        public IListNotebookInstancesPaginator ListNotebookInstances(ListNotebookInstancesRequest request) 
        {
            return new ListNotebookInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProcessingJobs operation
        ///</summary>
        public IListProcessingJobsPaginator ListProcessingJobs(ListProcessingJobsRequest request) 
        {
            return new ListProcessingJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSubscribedWorkteams operation
        ///</summary>
        public IListSubscribedWorkteamsPaginator ListSubscribedWorkteams(ListSubscribedWorkteamsRequest request) 
        {
            return new ListSubscribedWorkteamsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTags operation
        ///</summary>
        public IListTagsPaginator ListTags(ListTagsRequest request) 
        {
            return new ListTagsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTrainingJobs operation
        ///</summary>
        public IListTrainingJobsPaginator ListTrainingJobs(ListTrainingJobsRequest request) 
        {
            return new ListTrainingJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTrainingJobsForHyperParameterTuningJob operation
        ///</summary>
        public IListTrainingJobsForHyperParameterTuningJobPaginator ListTrainingJobsForHyperParameterTuningJob(ListTrainingJobsForHyperParameterTuningJobRequest request) 
        {
            return new ListTrainingJobsForHyperParameterTuningJobPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTransformJobs operation
        ///</summary>
        public IListTransformJobsPaginator ListTransformJobs(ListTransformJobsRequest request) 
        {
            return new ListTransformJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTrialComponents operation
        ///</summary>
        public IListTrialComponentsPaginator ListTrialComponents(ListTrialComponentsRequest request) 
        {
            return new ListTrialComponentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTrials operation
        ///</summary>
        public IListTrialsPaginator ListTrials(ListTrialsRequest request) 
        {
            return new ListTrialsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUserProfiles operation
        ///</summary>
        public IListUserProfilesPaginator ListUserProfiles(ListUserProfilesRequest request) 
        {
            return new ListUserProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkforces operation
        ///</summary>
        public IListWorkforcesPaginator ListWorkforces(ListWorkforcesRequest request) 
        {
            return new ListWorkforcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkteams operation
        ///</summary>
        public IListWorkteamsPaginator ListWorkteams(ListWorkteamsRequest request) 
        {
            return new ListWorkteamsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for Search operation
        ///</summary>
        public ISearchPaginator Search(SearchRequest request) 
        {
            return new SearchPaginator(this.client, request);
        }
    }
}
#endif