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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Paginators for the SageMaker service
    /// </summary>
    public interface ISageMakerPaginatorFactory
    {
        /// <summary>
        /// Paginator for CreateHubContentPresignedUrls operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ICreateHubContentPresignedUrlsPaginator CreateHubContentPresignedUrls(CreateHubContentPresignedUrlsRequest request);

        /// <summary>
        /// Paginator for DescribeTrainingPlanExtensionHistory operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeTrainingPlanExtensionHistoryPaginator DescribeTrainingPlanExtensionHistory(DescribeTrainingPlanExtensionHistoryRequest request);

        /// <summary>
        /// Paginator for ListAIBenchmarkJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAIBenchmarkJobsPaginator ListAIBenchmarkJobs(ListAIBenchmarkJobsRequest request);

        /// <summary>
        /// Paginator for ListAIRecommendationJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAIRecommendationJobsPaginator ListAIRecommendationJobs(ListAIRecommendationJobsRequest request);

        /// <summary>
        /// Paginator for ListAIWorkloadConfigs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAIWorkloadConfigsPaginator ListAIWorkloadConfigs(ListAIWorkloadConfigsRequest request);

        /// <summary>
        /// Paginator for ListActions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListActionsPaginator ListActions(ListActionsRequest request);

        /// <summary>
        /// Paginator for ListAlgorithms operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAlgorithmsPaginator ListAlgorithms(ListAlgorithmsRequest request);

        /// <summary>
        /// Paginator for ListAliases operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAliasesPaginator ListAliases(ListAliasesRequest request);

        /// <summary>
        /// Paginator for ListAppImageConfigs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAppImageConfigsPaginator ListAppImageConfigs(ListAppImageConfigsRequest request);

        /// <summary>
        /// Paginator for ListApps operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAppsPaginator ListApps(ListAppsRequest request);

        /// <summary>
        /// Paginator for ListArtifacts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListArtifactsPaginator ListArtifacts(ListArtifactsRequest request);

        /// <summary>
        /// Paginator for ListAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAssociationsPaginator ListAssociations(ListAssociationsRequest request);

        /// <summary>
        /// Paginator for ListAutoMLJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAutoMLJobsPaginator ListAutoMLJobs(ListAutoMLJobsRequest request);

        /// <summary>
        /// Paginator for ListCandidatesForAutoMLJob operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCandidatesForAutoMLJobPaginator ListCandidatesForAutoMLJob(ListCandidatesForAutoMLJobRequest request);

        /// <summary>
        /// Paginator for ListClusterEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListClusterEventsPaginator ListClusterEvents(ListClusterEventsRequest request);

        /// <summary>
        /// Paginator for ListClusterNodes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListClusterNodesPaginator ListClusterNodes(ListClusterNodesRequest request);

        /// <summary>
        /// Paginator for ListClusterSchedulerConfigs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListClusterSchedulerConfigsPaginator ListClusterSchedulerConfigs(ListClusterSchedulerConfigsRequest request);

        /// <summary>
        /// Paginator for ListClusters operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListClustersPaginator ListClusters(ListClustersRequest request);

        /// <summary>
        /// Paginator for ListCodeRepositories operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCodeRepositoriesPaginator ListCodeRepositories(ListCodeRepositoriesRequest request);

        /// <summary>
        /// Paginator for ListCompilationJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCompilationJobsPaginator ListCompilationJobs(ListCompilationJobsRequest request);

        /// <summary>
        /// Paginator for ListComputeQuotas operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListComputeQuotasPaginator ListComputeQuotas(ListComputeQuotasRequest request);

        /// <summary>
        /// Paginator for ListContexts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListContextsPaginator ListContexts(ListContextsRequest request);

        /// <summary>
        /// Paginator for ListDataQualityJobDefinitions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDataQualityJobDefinitionsPaginator ListDataQualityJobDefinitions(ListDataQualityJobDefinitionsRequest request);

        /// <summary>
        /// Paginator for ListDeviceFleets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDeviceFleetsPaginator ListDeviceFleets(ListDeviceFleetsRequest request);

        /// <summary>
        /// Paginator for ListDevices operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDevicesPaginator ListDevices(ListDevicesRequest request);

        /// <summary>
        /// Paginator for ListDomains operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDomainsPaginator ListDomains(ListDomainsRequest request);

        /// <summary>
        /// Paginator for ListEdgeDeploymentPlans operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEdgeDeploymentPlansPaginator ListEdgeDeploymentPlans(ListEdgeDeploymentPlansRequest request);

        /// <summary>
        /// Paginator for ListEdgePackagingJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEdgePackagingJobsPaginator ListEdgePackagingJobs(ListEdgePackagingJobsRequest request);

        /// <summary>
        /// Paginator for ListEndpointConfigs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEndpointConfigsPaginator ListEndpointConfigs(ListEndpointConfigsRequest request);

        /// <summary>
        /// Paginator for ListEndpoints operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEndpointsPaginator ListEndpoints(ListEndpointsRequest request);

        /// <summary>
        /// Paginator for ListExperiments operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListExperimentsPaginator ListExperiments(ListExperimentsRequest request);

        /// <summary>
        /// Paginator for ListFeatureGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListFeatureGroupsPaginator ListFeatureGroups(ListFeatureGroupsRequest request);

        /// <summary>
        /// Paginator for ListFlowDefinitions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListFlowDefinitionsPaginator ListFlowDefinitions(ListFlowDefinitionsRequest request);

        /// <summary>
        /// Paginator for ListHumanTaskUis operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListHumanTaskUisPaginator ListHumanTaskUis(ListHumanTaskUisRequest request);

        /// <summary>
        /// Paginator for ListHyperParameterTuningJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListHyperParameterTuningJobsPaginator ListHyperParameterTuningJobs(ListHyperParameterTuningJobsRequest request);

        /// <summary>
        /// Paginator for ListImageVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListImageVersionsPaginator ListImageVersions(ListImageVersionsRequest request);

        /// <summary>
        /// Paginator for ListImages operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListImagesPaginator ListImages(ListImagesRequest request);

        /// <summary>
        /// Paginator for ListInferenceComponents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListInferenceComponentsPaginator ListInferenceComponents(ListInferenceComponentsRequest request);

        /// <summary>
        /// Paginator for ListInferenceExperiments operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListInferenceExperimentsPaginator ListInferenceExperiments(ListInferenceExperimentsRequest request);

        /// <summary>
        /// Paginator for ListInferenceRecommendationsJobSteps operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListInferenceRecommendationsJobStepsPaginator ListInferenceRecommendationsJobSteps(ListInferenceRecommendationsJobStepsRequest request);

        /// <summary>
        /// Paginator for ListInferenceRecommendationsJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListInferenceRecommendationsJobsPaginator ListInferenceRecommendationsJobs(ListInferenceRecommendationsJobsRequest request);

        /// <summary>
        /// Paginator for ListJobSchemaVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListJobSchemaVersionsPaginator ListJobSchemaVersions(ListJobSchemaVersionsRequest request);

        /// <summary>
        /// Paginator for ListJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListJobsPaginator ListJobs(ListJobsRequest request);

        /// <summary>
        /// Paginator for ListLabelingJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListLabelingJobsPaginator ListLabelingJobs(ListLabelingJobsRequest request);

        /// <summary>
        /// Paginator for ListLabelingJobsForWorkteam operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListLabelingJobsForWorkteamPaginator ListLabelingJobsForWorkteam(ListLabelingJobsForWorkteamRequest request);

        /// <summary>
        /// Paginator for ListLineageGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListLineageGroupsPaginator ListLineageGroups(ListLineageGroupsRequest request);

        /// <summary>
        /// Paginator for ListMlflowApps operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMlflowAppsPaginator ListMlflowApps(ListMlflowAppsRequest request);

        /// <summary>
        /// Paginator for ListMlflowTrackingServers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMlflowTrackingServersPaginator ListMlflowTrackingServers(ListMlflowTrackingServersRequest request);

        /// <summary>
        /// Paginator for ListModelBiasJobDefinitions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListModelBiasJobDefinitionsPaginator ListModelBiasJobDefinitions(ListModelBiasJobDefinitionsRequest request);

        /// <summary>
        /// Paginator for ListModelCardExportJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListModelCardExportJobsPaginator ListModelCardExportJobs(ListModelCardExportJobsRequest request);

        /// <summary>
        /// Paginator for ListModelCardVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListModelCardVersionsPaginator ListModelCardVersions(ListModelCardVersionsRequest request);

        /// <summary>
        /// Paginator for ListModelCards operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListModelCardsPaginator ListModelCards(ListModelCardsRequest request);

        /// <summary>
        /// Paginator for ListModelExplainabilityJobDefinitions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListModelExplainabilityJobDefinitionsPaginator ListModelExplainabilityJobDefinitions(ListModelExplainabilityJobDefinitionsRequest request);

        /// <summary>
        /// Paginator for ListModelMetadata operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListModelMetadataPaginator ListModelMetadata(ListModelMetadataRequest request);

        /// <summary>
        /// Paginator for ListModelPackageGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListModelPackageGroupsPaginator ListModelPackageGroups(ListModelPackageGroupsRequest request);

        /// <summary>
        /// Paginator for ListModelPackages operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListModelPackagesPaginator ListModelPackages(ListModelPackagesRequest request);

        /// <summary>
        /// Paginator for ListModelQualityJobDefinitions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListModelQualityJobDefinitionsPaginator ListModelQualityJobDefinitions(ListModelQualityJobDefinitionsRequest request);

        /// <summary>
        /// Paginator for ListModels operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListModelsPaginator ListModels(ListModelsRequest request);

        /// <summary>
        /// Paginator for ListMonitoringAlertHistory operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMonitoringAlertHistoryPaginator ListMonitoringAlertHistory(ListMonitoringAlertHistoryRequest request);

        /// <summary>
        /// Paginator for ListMonitoringAlerts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMonitoringAlertsPaginator ListMonitoringAlerts(ListMonitoringAlertsRequest request);

        /// <summary>
        /// Paginator for ListMonitoringExecutions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMonitoringExecutionsPaginator ListMonitoringExecutions(ListMonitoringExecutionsRequest request);

        /// <summary>
        /// Paginator for ListMonitoringSchedules operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMonitoringSchedulesPaginator ListMonitoringSchedules(ListMonitoringSchedulesRequest request);

        /// <summary>
        /// Paginator for ListNotebookInstanceLifecycleConfigs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListNotebookInstanceLifecycleConfigsPaginator ListNotebookInstanceLifecycleConfigs(ListNotebookInstanceLifecycleConfigsRequest request);

        /// <summary>
        /// Paginator for ListNotebookInstances operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListNotebookInstancesPaginator ListNotebookInstances(ListNotebookInstancesRequest request);

        /// <summary>
        /// Paginator for ListOptimizationJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListOptimizationJobsPaginator ListOptimizationJobs(ListOptimizationJobsRequest request);

        /// <summary>
        /// Paginator for ListPartnerApps operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPartnerAppsPaginator ListPartnerApps(ListPartnerAppsRequest request);

        /// <summary>
        /// Paginator for ListPipelineExecutionSteps operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPipelineExecutionStepsPaginator ListPipelineExecutionSteps(ListPipelineExecutionStepsRequest request);

        /// <summary>
        /// Paginator for ListPipelineExecutions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPipelineExecutionsPaginator ListPipelineExecutions(ListPipelineExecutionsRequest request);

        /// <summary>
        /// Paginator for ListPipelineParametersForExecution operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPipelineParametersForExecutionPaginator ListPipelineParametersForExecution(ListPipelineParametersForExecutionRequest request);

        /// <summary>
        /// Paginator for ListPipelineVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPipelineVersionsPaginator ListPipelineVersions(ListPipelineVersionsRequest request);

        /// <summary>
        /// Paginator for ListPipelines operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPipelinesPaginator ListPipelines(ListPipelinesRequest request);

        /// <summary>
        /// Paginator for ListProcessingJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListProcessingJobsPaginator ListProcessingJobs(ListProcessingJobsRequest request);

        /// <summary>
        /// Paginator for ListProjects operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListProjectsPaginator ListProjects(ListProjectsRequest request);

        /// <summary>
        /// Paginator for ListResourceCatalogs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListResourceCatalogsPaginator ListResourceCatalogs(ListResourceCatalogsRequest request);

        /// <summary>
        /// Paginator for ListSpaces operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSpacesPaginator ListSpaces(ListSpacesRequest request);

        /// <summary>
        /// Paginator for ListStageDevices operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListStageDevicesPaginator ListStageDevices(ListStageDevicesRequest request);

        /// <summary>
        /// Paginator for ListStudioLifecycleConfigs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListStudioLifecycleConfigsPaginator ListStudioLifecycleConfigs(ListStudioLifecycleConfigsRequest request);

        /// <summary>
        /// Paginator for ListSubscribedWorkteams operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSubscribedWorkteamsPaginator ListSubscribedWorkteams(ListSubscribedWorkteamsRequest request);

        /// <summary>
        /// Paginator for ListTags operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTagsPaginator ListTags(ListTagsRequest request);

        /// <summary>
        /// Paginator for ListTrainingJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTrainingJobsPaginator ListTrainingJobs(ListTrainingJobsRequest request);

        /// <summary>
        /// Paginator for ListTrainingJobsForHyperParameterTuningJob operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTrainingJobsForHyperParameterTuningJobPaginator ListTrainingJobsForHyperParameterTuningJob(ListTrainingJobsForHyperParameterTuningJobRequest request);

        /// <summary>
        /// Paginator for ListTrainingPlans operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTrainingPlansPaginator ListTrainingPlans(ListTrainingPlansRequest request);

        /// <summary>
        /// Paginator for ListTrainingSessions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTrainingSessionsPaginator ListTrainingSessions(ListTrainingSessionsRequest request);

        /// <summary>
        /// Paginator for ListTransformJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTransformJobsPaginator ListTransformJobs(ListTransformJobsRequest request);

        /// <summary>
        /// Paginator for ListTrialComponents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTrialComponentsPaginator ListTrialComponents(ListTrialComponentsRequest request);

        /// <summary>
        /// Paginator for ListTrials operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTrialsPaginator ListTrials(ListTrialsRequest request);

        /// <summary>
        /// Paginator for ListUltraServersByReservedCapacity operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListUltraServersByReservedCapacityPaginator ListUltraServersByReservedCapacity(ListUltraServersByReservedCapacityRequest request);

        /// <summary>
        /// Paginator for ListUserProfiles operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListUserProfilesPaginator ListUserProfiles(ListUserProfilesRequest request);

        /// <summary>
        /// Paginator for ListWorkforces operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListWorkforcesPaginator ListWorkforces(ListWorkforcesRequest request);

        /// <summary>
        /// Paginator for ListWorkteams operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListWorkteamsPaginator ListWorkteams(ListWorkteamsRequest request);

        /// <summary>
        /// Paginator for QueryLineage operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IQueryLineagePaginator QueryLineage(QueryLineageRequest request);

        /// <summary>
        /// Paginator for Search operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchPaginator Search(SearchRequest request);
    }
}
