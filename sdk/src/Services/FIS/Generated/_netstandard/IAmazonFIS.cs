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
 * Do not modify this file. This file is generated from the fis-2020-12-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.FIS.Model;

#pragma warning disable CS1570
namespace Amazon.FIS
{
    /// <summary>
    /// <para>Interface for accessing FIS</para>
    ///
    /// Amazon Web Services Fault Injection Service is a managed service that enables you
    /// to perform fault injection experiments on your Amazon Web Services workloads. For
    /// more information, see the <a href="https://docs.aws.amazon.com/fis/latest/userguide/">Fault
    /// Injection Service User Guide</a>.
    /// </summary>
    public partial interface IAmazonFIS : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IFISPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateExperimentTemplate



        /// <summary>
        /// Creates an experiment template. 
        /// 
        ///  
        /// <para>
        /// An experiment template includes the following components:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Targets</b>: A target can be a specific resource in your Amazon Web Services environment,
        /// or one or more resources that match criteria that you specify, for example, resources
        /// that have specific tags.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Actions</b>: The actions to carry out on the target. You can specify multiple
        /// actions, the duration of each action, and when to start each action during an experiment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Stop conditions</b>: If a stop condition is triggered while an experiment is running,
        /// the experiment is automatically stopped. You can define a stop condition as a CloudWatch
        /// alarm.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/fis/latest/userguide/experiment-templates.html">experiment
        /// templates</a> in the <i>Fault Injection Service User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExperimentTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateExperimentTemplate service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ConflictException">
        /// The request could not be processed because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/CreateExperimentTemplate">REST API Reference for CreateExperimentTemplate Operation</seealso>
        Task<CreateExperimentTemplateResponse> CreateExperimentTemplateAsync(CreateExperimentTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTargetAccountConfiguration



        /// <summary>
        /// Creates a target account configuration for the experiment template. A target account
        /// configuration is required when <c>accountTargeting</c> of <c>experimentOptions</c>
        /// is set to <c>multi-account</c>. For more information, see <a href="https://docs.aws.amazon.com/fis/latest/userguide/experiment-options.html">experiment
        /// options</a> in the <i>Fault Injection Service User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTargetAccountConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTargetAccountConfiguration service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ConflictException">
        /// The request could not be processed because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/CreateTargetAccountConfiguration">REST API Reference for CreateTargetAccountConfiguration Operation</seealso>
        Task<CreateTargetAccountConfigurationResponse> CreateTargetAccountConfigurationAsync(CreateTargetAccountConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteExperimentTemplate



        /// <summary>
        /// Deletes the specified experiment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExperimentTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteExperimentTemplate service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/DeleteExperimentTemplate">REST API Reference for DeleteExperimentTemplate Operation</seealso>
        Task<DeleteExperimentTemplateResponse> DeleteExperimentTemplateAsync(DeleteExperimentTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTargetAccountConfiguration



        /// <summary>
        /// Deletes the specified target account configuration of the experiment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTargetAccountConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTargetAccountConfiguration service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/DeleteTargetAccountConfiguration">REST API Reference for DeleteTargetAccountConfiguration Operation</seealso>
        Task<DeleteTargetAccountConfigurationResponse> DeleteTargetAccountConfigurationAsync(DeleteTargetAccountConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAction



        /// <summary>
        /// Gets information about the specified FIS action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAction service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetAction">REST API Reference for GetAction Operation</seealso>
        Task<GetActionResponse> GetActionAsync(GetActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetExperiment



        /// <summary>
        /// Gets information about the specified experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExperiment service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetExperiment">REST API Reference for GetExperiment Operation</seealso>
        Task<GetExperimentResponse> GetExperimentAsync(GetExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetExperimentTargetAccountConfiguration



        /// <summary>
        /// Gets information about the specified target account configuration of the experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExperimentTargetAccountConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExperimentTargetAccountConfiguration service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetExperimentTargetAccountConfiguration">REST API Reference for GetExperimentTargetAccountConfiguration Operation</seealso>
        Task<GetExperimentTargetAccountConfigurationResponse> GetExperimentTargetAccountConfigurationAsync(GetExperimentTargetAccountConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetExperimentTemplate



        /// <summary>
        /// Gets information about the specified experiment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExperimentTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExperimentTemplate service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetExperimentTemplate">REST API Reference for GetExperimentTemplate Operation</seealso>
        Task<GetExperimentTemplateResponse> GetExperimentTemplateAsync(GetExperimentTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSafetyLever



        /// <summary>
        /// Gets information about the specified safety lever.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSafetyLever service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSafetyLever service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetSafetyLever">REST API Reference for GetSafetyLever Operation</seealso>
        Task<GetSafetyLeverResponse> GetSafetyLeverAsync(GetSafetyLeverRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTargetAccountConfiguration



        /// <summary>
        /// Gets information about the specified target account configuration of the experiment
        /// template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTargetAccountConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTargetAccountConfiguration service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetTargetAccountConfiguration">REST API Reference for GetTargetAccountConfiguration Operation</seealso>
        Task<GetTargetAccountConfigurationResponse> GetTargetAccountConfigurationAsync(GetTargetAccountConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTargetResourceType



        /// <summary>
        /// Gets information about the specified resource type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTargetResourceType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTargetResourceType service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetTargetResourceType">REST API Reference for GetTargetResourceType Operation</seealso>
        Task<GetTargetResourceTypeResponse> GetTargetResourceTypeAsync(GetTargetResourceTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListActions



        /// <summary>
        /// Lists the available FIS actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListActions service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListActions">REST API Reference for ListActions Operation</seealso>
        Task<ListActionsResponse> ListActionsAsync(ListActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListExperimentResolvedTargets



        /// <summary>
        /// Lists the resolved targets information of the specified experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperimentResolvedTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExperimentResolvedTargets service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListExperimentResolvedTargets">REST API Reference for ListExperimentResolvedTargets Operation</seealso>
        Task<ListExperimentResolvedTargetsResponse> ListExperimentResolvedTargetsAsync(ListExperimentResolvedTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListExperiments



        /// <summary>
        /// Lists your experiments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperiments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExperiments service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListExperiments">REST API Reference for ListExperiments Operation</seealso>
        Task<ListExperimentsResponse> ListExperimentsAsync(ListExperimentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListExperimentTargetAccountConfigurations



        /// <summary>
        /// Lists the target account configurations of the specified experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperimentTargetAccountConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExperimentTargetAccountConfigurations service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListExperimentTargetAccountConfigurations">REST API Reference for ListExperimentTargetAccountConfigurations Operation</seealso>
        Task<ListExperimentTargetAccountConfigurationsResponse> ListExperimentTargetAccountConfigurationsAsync(ListExperimentTargetAccountConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListExperimentTemplates



        /// <summary>
        /// Lists your experiment templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperimentTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExperimentTemplates service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListExperimentTemplates">REST API Reference for ListExperimentTemplates Operation</seealso>
        Task<ListExperimentTemplatesResponse> ListExperimentTemplatesAsync(ListExperimentTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTargetAccountConfigurations



        /// <summary>
        /// Lists the target account configurations of the specified experiment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetAccountConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTargetAccountConfigurations service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListTargetAccountConfigurations">REST API Reference for ListTargetAccountConfigurations Operation</seealso>
        Task<ListTargetAccountConfigurationsResponse> ListTargetAccountConfigurationsAsync(ListTargetAccountConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTargetResourceTypes



        /// <summary>
        /// Lists the target resource types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetResourceTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTargetResourceTypes service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListTargetResourceTypes">REST API Reference for ListTargetResourceTypes Operation</seealso>
        Task<ListTargetResourceTypesResponse> ListTargetResourceTypesAsync(ListTargetResourceTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartExperiment



        /// <summary>
        /// Starts running an experiment from the specified experiment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartExperiment service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ConflictException">
        /// The request could not be processed because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/StartExperiment">REST API Reference for StartExperiment Operation</seealso>
        Task<StartExperimentResponse> StartExperimentAsync(StartExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopExperiment



        /// <summary>
        /// Stops the specified experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopExperiment service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/StopExperiment">REST API Reference for StopExperiment Operation</seealso>
        Task<StopExperimentResponse> StopExperimentAsync(StopExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Applies the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateExperimentTemplate



        /// <summary>
        /// Updates the specified experiment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExperimentTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateExperimentTemplate service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/UpdateExperimentTemplate">REST API Reference for UpdateExperimentTemplate Operation</seealso>
        Task<UpdateExperimentTemplateResponse> UpdateExperimentTemplateAsync(UpdateExperimentTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSafetyLeverState



        /// <summary>
        /// Updates the specified safety lever state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSafetyLeverState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSafetyLeverState service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ConflictException">
        /// The request could not be processed because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/UpdateSafetyLeverState">REST API Reference for UpdateSafetyLeverState Operation</seealso>
        Task<UpdateSafetyLeverStateResponse> UpdateSafetyLeverStateAsync(UpdateSafetyLeverStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTargetAccountConfiguration



        /// <summary>
        /// Updates the target account configuration for the specified experiment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTargetAccountConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTargetAccountConfiguration service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/UpdateTargetAccountConfiguration">REST API Reference for UpdateTargetAccountConfiguration Operation</seealso>
        Task<UpdateTargetAccountConfigurationResponse> UpdateTargetAccountConfigurationAsync(UpdateTargetAccountConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonFISConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonFISConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonFISConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonFISConfig to create AmazonFISClient");
            }

            return awsCredentials == null ? 
                    new AmazonFISClient(serviceClientConfig) :
                    new AmazonFISClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}