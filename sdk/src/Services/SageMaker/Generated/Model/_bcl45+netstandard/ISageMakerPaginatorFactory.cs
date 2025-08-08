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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Paginators for the SageMaker service
    ///</summary>
    public interface ISageMakerPaginatorFactory
    {

        /// <summary>
        /// Paginator for CreateHubContentPresignedUrls operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ICreateHubContentPresignedUrlsPaginator CreateHubContentPresignedUrls(CreateHubContentPresignedUrlsRequest request);

        /// <summary>
        /// Paginator for ListActions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListActionsPaginator ListActions(ListActionsRequest request);

        /// <summary>
        /// Paginator for ListAlgorithms operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAlgorithmsPaginator ListAlgorithms(ListAlgorithmsRequest request);

        /// <summary>
        /// Paginator for ListAliases operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAliasesPaginator ListAliases(ListAliasesRequest request);

        /// <summary>
        /// Paginator for ListAppImageConfigs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAppImageConfigsPaginator ListAppImageConfigs(ListAppImageConfigsRequest request);

        /// <summary>
        /// Paginator for ListApps operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAppsPaginator ListApps(ListAppsRequest request);

        /// <summary>
        /// Paginator for ListArtifacts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListArtifactsPaginator ListArtifacts(ListArtifactsRequest request);

        /// <summary>
        /// Paginator for ListAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssociationsPaginator ListAssociations(ListAssociationsRequest request);

        /// <summary>
        /// Paginator for ListAutoMLJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAutoMLJobsPaginator ListAutoMLJobs(ListAutoMLJobsRequest request);

        /// <summary>
        /// Paginator for ListCandidatesForAutoMLJob operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCandidatesForAutoMLJobPaginator ListCandidatesForAutoMLJob(ListCandidatesForAutoMLJobRequest request);

        /// <summary>
        /// Paginator for ListClusterEvents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListClusterEventsPaginator ListClusterEvents(ListClusterEventsRequest request);

        /// <summary>
        /// Paginator for ListClusterNodes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListClusterNodesPaginator ListClusterNodes(ListClusterNodesRequest request);

        /// <summary>
        /// Paginator for ListClusters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListClustersPaginator ListClusters(ListClustersRequest request);

        /// <summary>
        /// Paginator for ListClusterSchedulerConfigs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListClusterSchedulerConfigsPaginator ListClusterSchedulerConfigs(ListClusterSchedulerConfigsRequest request);

        /// <summary>
        /// Paginator for ListCodeRepositories operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCodeRepositoriesPaginator ListCodeRepositories(ListCodeRepositoriesRequest request);

        /// <summary>
        /// Paginator for ListCompilationJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCompilationJobsPaginator ListCompilationJobs(ListCompilationJobsRequest request);

        /// <summary>
        /// Paginator for ListComputeQuotas operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListComputeQuotasPaginator ListComputeQuotas(ListComputeQuotasRequest request);

        /// <summary>
        /// Paginator for ListContexts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListContextsPaginator ListContexts(ListContextsRequest request);

        /// <summary>
        /// Paginator for ListDataQualityJobDefinitions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDataQualityJobDefinitionsPaginator ListDataQualityJobDefinitions(ListDataQualityJobDefinitionsRequest request);

        /// <summary>
        /// Paginator for ListDeviceFleets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDeviceFleetsPaginator ListDeviceFleets(ListDeviceFleetsRequest request);

        /// <summary>
        /// Paginator for ListDevices operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDevicesPaginator ListDevices(ListDevicesRequest request);

        /// <summary>
        /// Paginator for ListDomains operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDomainsPaginator ListDomains(ListDomainsRequest request);

        /// <summary>
        /// Paginator for ListEdgeDeploymentPlans operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListEdgeDeploymentPlansPaginator ListEdgeDeploymentPlans(ListEdgeDeploymentPlansRequest request);

        /// <summary>
        /// Paginator for ListEdgePackagingJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListEdgePackagingJobsPaginator ListEdgePackagingJobs(ListEdgePackagingJobsRequest request);

        /// <summary>
        /// Paginator for ListEndpointConfigs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListEndpointConfigsPaginator ListEndpointConfigs(ListEndpointConfigsRequest request);

        /// <summary>
        /// Paginator for ListEndpoints operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListEndpointsPaginator ListEndpoints(ListEndpointsRequest request);

        /// <summary>
        /// Paginator for ListExperiments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListExperimentsPaginator ListExperiments(ListExperimentsRequest request);

        /// <summary>
        /// Paginator for ListFeatureGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFeatureGroupsPaginator ListFeatureGroups(ListFeatureGroupsRequest request);

        /// <summary>
        /// Paginator for ListFlowDefinitions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFlowDefinitionsPaginator ListFlowDefinitions(ListFlowDefinitionsRequest request);

        /// <summary>
        /// Paginator for ListHumanTaskUis operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListHumanTaskUisPaginator ListHumanTaskUis(ListHumanTaskUisRequest request);

        /// <summary>
        /// Paginator for ListHyperParameterTuningJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListHyperParameterTuningJobsPaginator ListHyperParameterTuningJobs(ListHyperParameterTuningJobsRequest request);

        /// <summary>
        /// Paginator for ListImages operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListImagesPaginator ListImages(ListImagesRequest request);

        /// <summary>
        /// Paginator for ListImageVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListImageVersionsPaginator ListImageVersions(ListImageVersionsRequest request);

        /// <summary>
        /// Paginator for ListInferenceComponents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListInferenceComponentsPaginator ListInferenceComponents(ListInferenceComponentsRequest request);

        /// <summary>
        /// Paginator for ListInferenceExperiments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListInferenceExperimentsPaginator ListInferenceExperiments(ListInferenceExperimentsRequest request);

        /// <summary>
        /// Paginator for ListInferenceRecommendationsJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListInferenceRecommendationsJobsPaginator ListInferenceRecommendationsJobs(ListInferenceRecommendationsJobsRequest request);

        /// <summary>
        /// Paginator for ListInferenceRecommendationsJobSteps operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListInferenceRecommendationsJobStepsPaginator ListInferenceRecommendationsJobSteps(ListInferenceRecommendationsJobStepsRequest request);

        /// <summary>
        /// Paginator for ListLabelingJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLabelingJobsPaginator ListLabelingJobs(ListLabelingJobsRequest request);

        /// <summary>
        /// Paginator for ListLabelingJobsForWorkteam operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLabelingJobsForWorkteamPaginator ListLabelingJobsForWorkteam(ListLabelingJobsForWorkteamRequest request);

        /// <summary>
        /// Paginator for ListLineageGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLineageGroupsPaginator ListLineageGroups(ListLineageGroupsRequest request);

        /// <summary>
        /// Paginator for ListMlflowTrackingServers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMlflowTrackingServersPaginator ListMlflowTrackingServers(ListMlflowTrackingServersRequest request);

        /// <summary>
        /// Paginator for ListModelBiasJobDefinitions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListModelBiasJobDefinitionsPaginator ListModelBiasJobDefinitions(ListModelBiasJobDefinitionsRequest request);

        /// <summary>
        /// Paginator for ListModelCardExportJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListModelCardExportJobsPaginator ListModelCardExportJobs(ListModelCardExportJobsRequest request);

        /// <summary>
        /// Paginator for ListModelCards operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListModelCardsPaginator ListModelCards(ListModelCardsRequest request);

        /// <summary>
        /// Paginator for ListModelCardVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListModelCardVersionsPaginator ListModelCardVersions(ListModelCardVersionsRequest request);

        /// <summary>
        /// Paginator for ListModelExplainabilityJobDefinitions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListModelExplainabilityJobDefinitionsPaginator ListModelExplainabilityJobDefinitions(ListModelExplainabilityJobDefinitionsRequest request);

        /// <summary>
        /// Paginator for ListModelMetadata operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListModelMetadataPaginator ListModelMetadata(ListModelMetadataRequest request);

        /// <summary>
        /// Paginator for ListModelPackageGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListModelPackageGroupsPaginator ListModelPackageGroups(ListModelPackageGroupsRequest request);

        /// <summary>
        /// Paginator for ListModelPackages operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListModelPackagesPaginator ListModelPackages(ListModelPackagesRequest request);

        /// <summary>
        /// Paginator for ListModelQualityJobDefinitions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListModelQualityJobDefinitionsPaginator ListModelQualityJobDefinitions(ListModelQualityJobDefinitionsRequest request);

        /// <summary>
        /// Paginator for ListModels operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListModelsPaginator ListModels(ListModelsRequest request);

        /// <summary>
        /// Paginator for ListMonitoringAlertHistory operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMonitoringAlertHistoryPaginator ListMonitoringAlertHistory(ListMonitoringAlertHistoryRequest request);

        /// <summary>
        /// Paginator for ListMonitoringAlerts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMonitoringAlertsPaginator ListMonitoringAlerts(ListMonitoringAlertsRequest request);

        /// <summary>
        /// Paginator for ListMonitoringExecutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMonitoringExecutionsPaginator ListMonitoringExecutions(ListMonitoringExecutionsRequest request);

        /// <summary>
        /// Paginator for ListMonitoringSchedules operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMonitoringSchedulesPaginator ListMonitoringSchedules(ListMonitoringSchedulesRequest request);

        /// <summary>
        /// Paginator for ListNotebookInstanceLifecycleConfigs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNotebookInstanceLifecycleConfigsPaginator ListNotebookInstanceLifecycleConfigs(ListNotebookInstanceLifecycleConfigsRequest request);

        /// <summary>
        /// Paginator for ListNotebookInstances operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNotebookInstancesPaginator ListNotebookInstances(ListNotebookInstancesRequest request);

        /// <summary>
        /// Paginator for ListOptimizationJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListOptimizationJobsPaginator ListOptimizationJobs(ListOptimizationJobsRequest request);

        /// <summary>
        /// Paginator for ListPartnerApps operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPartnerAppsPaginator ListPartnerApps(ListPartnerAppsRequest request);

        /// <summary>
        /// Paginator for ListPipelineExecutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPipelineExecutionsPaginator ListPipelineExecutions(ListPipelineExecutionsRequest request);

        /// <summary>
        /// Paginator for ListPipelineExecutionSteps operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPipelineExecutionStepsPaginator ListPipelineExecutionSteps(ListPipelineExecutionStepsRequest request);

        /// <summary>
        /// Paginator for ListPipelineParametersForExecution operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPipelineParametersForExecutionPaginator ListPipelineParametersForExecution(ListPipelineParametersForExecutionRequest request);

        /// <summary>
        /// Paginator for ListPipelines operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPipelinesPaginator ListPipelines(ListPipelinesRequest request);

        /// <summary>
        /// Paginator for ListPipelineVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPipelineVersionsPaginator ListPipelineVersions(ListPipelineVersionsRequest request);

        /// <summary>
        /// Paginator for ListProcessingJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListProcessingJobsPaginator ListProcessingJobs(ListProcessingJobsRequest request);

        /// <summary>
        /// Paginator for ListProjects operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListProjectsPaginator ListProjects(ListProjectsRequest request);

        /// <summary>
        /// Paginator for ListResourceCatalogs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListResourceCatalogsPaginator ListResourceCatalogs(ListResourceCatalogsRequest request);

        /// <summary>
        /// Paginator for ListSpaces operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSpacesPaginator ListSpaces(ListSpacesRequest request);

        /// <summary>
        /// Paginator for ListStageDevices operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListStageDevicesPaginator ListStageDevices(ListStageDevicesRequest request);

        /// <summary>
        /// Paginator for ListStudioLifecycleConfigs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListStudioLifecycleConfigsPaginator ListStudioLifecycleConfigs(ListStudioLifecycleConfigsRequest request);

        /// <summary>
        /// Paginator for ListSubscribedWorkteams operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSubscribedWorkteamsPaginator ListSubscribedWorkteams(ListSubscribedWorkteamsRequest request);

        /// <summary>
        /// Paginator for ListTags operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTagsPaginator ListTags(ListTagsRequest request);

        /// <summary>
        /// Paginator for ListTrainingJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTrainingJobsPaginator ListTrainingJobs(ListTrainingJobsRequest request);

        /// <summary>
        /// Paginator for ListTrainingJobsForHyperParameterTuningJob operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTrainingJobsForHyperParameterTuningJobPaginator ListTrainingJobsForHyperParameterTuningJob(ListTrainingJobsForHyperParameterTuningJobRequest request);

        /// <summary>
        /// Paginator for ListTrainingPlans operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTrainingPlansPaginator ListTrainingPlans(ListTrainingPlansRequest request);

        /// <summary>
        /// Paginator for ListTransformJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTransformJobsPaginator ListTransformJobs(ListTransformJobsRequest request);

        /// <summary>
        /// Paginator for ListTrialComponents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTrialComponentsPaginator ListTrialComponents(ListTrialComponentsRequest request);

        /// <summary>
        /// Paginator for ListTrials operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTrialsPaginator ListTrials(ListTrialsRequest request);

        /// <summary>
        /// Paginator for ListUltraServersByReservedCapacity operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListUltraServersByReservedCapacityPaginator ListUltraServersByReservedCapacity(ListUltraServersByReservedCapacityRequest request);

        /// <summary>
        /// Paginator for ListUserProfiles operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListUserProfilesPaginator ListUserProfiles(ListUserProfilesRequest request);

        /// <summary>
        /// Paginator for ListWorkforces operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWorkforcesPaginator ListWorkforces(ListWorkforcesRequest request);

        /// <summary>
        /// Paginator for ListWorkteams operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWorkteamsPaginator ListWorkteams(ListWorkteamsRequest request);

        /// <summary>
        /// Paginator for QueryLineage operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IQueryLineagePaginator QueryLineage(QueryLineageRequest request);

        /// <summary>
        /// Paginator for Search operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchPaginator Search(SearchRequest request);
    }
}