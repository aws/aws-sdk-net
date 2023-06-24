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
        /// Paginator for ListActions operation
        ///</summary>
        public IListActionsPaginator ListActions(ListActionsRequest request) 
        {
            return new ListActionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAlgorithms operation
        ///</summary>
        public IListAlgorithmsPaginator ListAlgorithms(ListAlgorithmsRequest request) 
        {
            return new ListAlgorithmsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAliases operation
        ///</summary>
        public IListAliasesPaginator ListAliases(ListAliasesRequest request) 
        {
            return new ListAliasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAppImageConfigs operation
        ///</summary>
        public IListAppImageConfigsPaginator ListAppImageConfigs(ListAppImageConfigsRequest request) 
        {
            return new ListAppImageConfigsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListApps operation
        ///</summary>
        public IListAppsPaginator ListApps(ListAppsRequest request) 
        {
            return new ListAppsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListArtifacts operation
        ///</summary>
        public IListArtifactsPaginator ListArtifacts(ListArtifactsRequest request) 
        {
            return new ListArtifactsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssociations operation
        ///</summary>
        public IListAssociationsPaginator ListAssociations(ListAssociationsRequest request) 
        {
            return new ListAssociationsPaginator(this.client, request);
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
        /// Paginator for ListContexts operation
        ///</summary>
        public IListContextsPaginator ListContexts(ListContextsRequest request) 
        {
            return new ListContextsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataQualityJobDefinitions operation
        ///</summary>
        public IListDataQualityJobDefinitionsPaginator ListDataQualityJobDefinitions(ListDataQualityJobDefinitionsRequest request) 
        {
            return new ListDataQualityJobDefinitionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDeviceFleets operation
        ///</summary>
        public IListDeviceFleetsPaginator ListDeviceFleets(ListDeviceFleetsRequest request) 
        {
            return new ListDeviceFleetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDevices operation
        ///</summary>
        public IListDevicesPaginator ListDevices(ListDevicesRequest request) 
        {
            return new ListDevicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDomains operation
        ///</summary>
        public IListDomainsPaginator ListDomains(ListDomainsRequest request) 
        {
            return new ListDomainsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEdgeDeploymentPlans operation
        ///</summary>
        public IListEdgeDeploymentPlansPaginator ListEdgeDeploymentPlans(ListEdgeDeploymentPlansRequest request) 
        {
            return new ListEdgeDeploymentPlansPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEdgePackagingJobs operation
        ///</summary>
        public IListEdgePackagingJobsPaginator ListEdgePackagingJobs(ListEdgePackagingJobsRequest request) 
        {
            return new ListEdgePackagingJobsPaginator(this.client, request);
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
        /// Paginator for ListFeatureGroups operation
        ///</summary>
        public IListFeatureGroupsPaginator ListFeatureGroups(ListFeatureGroupsRequest request) 
        {
            return new ListFeatureGroupsPaginator(this.client, request);
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
        /// Paginator for ListImages operation
        ///</summary>
        public IListImagesPaginator ListImages(ListImagesRequest request) 
        {
            return new ListImagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListImageVersions operation
        ///</summary>
        public IListImageVersionsPaginator ListImageVersions(ListImageVersionsRequest request) 
        {
            return new ListImageVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInferenceExperiments operation
        ///</summary>
        public IListInferenceExperimentsPaginator ListInferenceExperiments(ListInferenceExperimentsRequest request) 
        {
            return new ListInferenceExperimentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInferenceRecommendationsJobs operation
        ///</summary>
        public IListInferenceRecommendationsJobsPaginator ListInferenceRecommendationsJobs(ListInferenceRecommendationsJobsRequest request) 
        {
            return new ListInferenceRecommendationsJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInferenceRecommendationsJobSteps operation
        ///</summary>
        public IListInferenceRecommendationsJobStepsPaginator ListInferenceRecommendationsJobSteps(ListInferenceRecommendationsJobStepsRequest request) 
        {
            return new ListInferenceRecommendationsJobStepsPaginator(this.client, request);
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
        /// Paginator for ListLineageGroups operation
        ///</summary>
        public IListLineageGroupsPaginator ListLineageGroups(ListLineageGroupsRequest request) 
        {
            return new ListLineageGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListModelBiasJobDefinitions operation
        ///</summary>
        public IListModelBiasJobDefinitionsPaginator ListModelBiasJobDefinitions(ListModelBiasJobDefinitionsRequest request) 
        {
            return new ListModelBiasJobDefinitionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListModelCardExportJobs operation
        ///</summary>
        public IListModelCardExportJobsPaginator ListModelCardExportJobs(ListModelCardExportJobsRequest request) 
        {
            return new ListModelCardExportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListModelCards operation
        ///</summary>
        public IListModelCardsPaginator ListModelCards(ListModelCardsRequest request) 
        {
            return new ListModelCardsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListModelCardVersions operation
        ///</summary>
        public IListModelCardVersionsPaginator ListModelCardVersions(ListModelCardVersionsRequest request) 
        {
            return new ListModelCardVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListModelExplainabilityJobDefinitions operation
        ///</summary>
        public IListModelExplainabilityJobDefinitionsPaginator ListModelExplainabilityJobDefinitions(ListModelExplainabilityJobDefinitionsRequest request) 
        {
            return new ListModelExplainabilityJobDefinitionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListModelMetadata operation
        ///</summary>
        public IListModelMetadataPaginator ListModelMetadata(ListModelMetadataRequest request) 
        {
            return new ListModelMetadataPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListModelPackageGroups operation
        ///</summary>
        public IListModelPackageGroupsPaginator ListModelPackageGroups(ListModelPackageGroupsRequest request) 
        {
            return new ListModelPackageGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListModelPackages operation
        ///</summary>
        public IListModelPackagesPaginator ListModelPackages(ListModelPackagesRequest request) 
        {
            return new ListModelPackagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListModelQualityJobDefinitions operation
        ///</summary>
        public IListModelQualityJobDefinitionsPaginator ListModelQualityJobDefinitions(ListModelQualityJobDefinitionsRequest request) 
        {
            return new ListModelQualityJobDefinitionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListModels operation
        ///</summary>
        public IListModelsPaginator ListModels(ListModelsRequest request) 
        {
            return new ListModelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMonitoringAlertHistory operation
        ///</summary>
        public IListMonitoringAlertHistoryPaginator ListMonitoringAlertHistory(ListMonitoringAlertHistoryRequest request) 
        {
            return new ListMonitoringAlertHistoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMonitoringAlerts operation
        ///</summary>
        public IListMonitoringAlertsPaginator ListMonitoringAlerts(ListMonitoringAlertsRequest request) 
        {
            return new ListMonitoringAlertsPaginator(this.client, request);
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
        /// Paginator for ListPipelineExecutions operation
        ///</summary>
        public IListPipelineExecutionsPaginator ListPipelineExecutions(ListPipelineExecutionsRequest request) 
        {
            return new ListPipelineExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPipelineExecutionSteps operation
        ///</summary>
        public IListPipelineExecutionStepsPaginator ListPipelineExecutionSteps(ListPipelineExecutionStepsRequest request) 
        {
            return new ListPipelineExecutionStepsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPipelineParametersForExecution operation
        ///</summary>
        public IListPipelineParametersForExecutionPaginator ListPipelineParametersForExecution(ListPipelineParametersForExecutionRequest request) 
        {
            return new ListPipelineParametersForExecutionPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPipelines operation
        ///</summary>
        public IListPipelinesPaginator ListPipelines(ListPipelinesRequest request) 
        {
            return new ListPipelinesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProcessingJobs operation
        ///</summary>
        public IListProcessingJobsPaginator ListProcessingJobs(ListProcessingJobsRequest request) 
        {
            return new ListProcessingJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProjects operation
        ///</summary>
        public IListProjectsPaginator ListProjects(ListProjectsRequest request) 
        {
            return new ListProjectsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSpaces operation
        ///</summary>
        public IListSpacesPaginator ListSpaces(ListSpacesRequest request) 
        {
            return new ListSpacesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStageDevices operation
        ///</summary>
        public IListStageDevicesPaginator ListStageDevices(ListStageDevicesRequest request) 
        {
            return new ListStageDevicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStudioLifecycleConfigs operation
        ///</summary>
        public IListStudioLifecycleConfigsPaginator ListStudioLifecycleConfigs(ListStudioLifecycleConfigsRequest request) 
        {
            return new ListStudioLifecycleConfigsPaginator(this.client, request);
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
        /// Paginator for QueryLineage operation
        ///</summary>
        public IQueryLineagePaginator QueryLineage(QueryLineageRequest request) 
        {
            return new QueryLineagePaginator(this.client, request);
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