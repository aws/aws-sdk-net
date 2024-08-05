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
 * Do not modify this file. This file is generated from the launch-wizard-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.LaunchWizard.Model;

#pragma warning disable CS1570
namespace Amazon.LaunchWizard
{
    /// <summary>
    /// <para>Interface for accessing LaunchWizard</para>
    ///
    /// Launch Wizard offers a guided way of sizing, configuring, and deploying Amazon Web
    /// Services resources for third party applications, such as Microsoft SQL Server Always
    /// On and HANA based SAP systems, without the need to manually identify and provision
    /// individual Amazon Web Services resources.
    /// </summary>
    public partial interface IAmazonLaunchWizard : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ILaunchWizardPaginatorFactory Paginators { get; }

        
        #region  CreateDeployment


        /// <summary>
        /// Creates a deployment for the given workload. Deployments created by this operation
        /// are not available in the Launch Wizard console to use the <c>Clone deployment</c>
        /// action on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceLimitException">
        /// You have exceeded an Launch Wizard resource limit. For example, you might have too
        /// many deployments in progress.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request);



        /// <summary>
        /// Creates a deployment for the given workload. Deployments created by this operation
        /// are not available in the Launch Wizard console to use the <c>Clone deployment</c>
        /// action on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceLimitException">
        /// You have exceeded an Launch Wizard resource limit. For example, you might have too
        /// many deployments in progress.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDeployment


        /// <summary>
        /// Deletes a deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment service method.</param>
        /// 
        /// <returns>The response from the DeleteDeployment service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceLimitException">
        /// You have exceeded an Launch Wizard resource limit. For example, you might have too
        /// many deployments in progress.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        DeleteDeploymentResponse DeleteDeployment(DeleteDeploymentRequest request);



        /// <summary>
        /// Deletes a deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDeployment service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceLimitException">
        /// You have exceeded an Launch Wizard resource limit. For example, you might have too
        /// many deployments in progress.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        Task<DeleteDeploymentResponse> DeleteDeploymentAsync(DeleteDeploymentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDeployment


        /// <summary>
        /// Returns information about the deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// 
        /// <returns>The response from the GetDeployment service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        GetDeploymentResponse GetDeployment(GetDeploymentRequest request);



        /// <summary>
        /// Returns information about the deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeployment service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        Task<GetDeploymentResponse> GetDeploymentAsync(GetDeploymentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetWorkload


        /// <summary>
        /// Returns information about a workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkload service method.</param>
        /// 
        /// <returns>The response from the GetWorkload service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/GetWorkload">REST API Reference for GetWorkload Operation</seealso>
        GetWorkloadResponse GetWorkload(GetWorkloadRequest request);



        /// <summary>
        /// Returns information about a workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkload service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/GetWorkload">REST API Reference for GetWorkload Operation</seealso>
        Task<GetWorkloadResponse> GetWorkloadAsync(GetWorkloadRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetWorkloadDeploymentPattern


        /// <summary>
        /// Returns details for a given workload and deployment pattern, including the available
        /// specifications. You can use the <a href="https://docs.aws.amazon.com/launchwizard/latest/APIReference/API_ListWorkloads.html">ListWorkloads</a>
        /// operation to discover the available workload names and the <a href="https://docs.aws.amazon.com/launchwizard/latest/APIReference/API_ListWorkloadDeploymentPatterns.html">ListWorkloadDeploymentPatterns</a>
        /// operation to discover the available deployment pattern names of a given workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkloadDeploymentPattern service method.</param>
        /// 
        /// <returns>The response from the GetWorkloadDeploymentPattern service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/GetWorkloadDeploymentPattern">REST API Reference for GetWorkloadDeploymentPattern Operation</seealso>
        GetWorkloadDeploymentPatternResponse GetWorkloadDeploymentPattern(GetWorkloadDeploymentPatternRequest request);



        /// <summary>
        /// Returns details for a given workload and deployment pattern, including the available
        /// specifications. You can use the <a href="https://docs.aws.amazon.com/launchwizard/latest/APIReference/API_ListWorkloads.html">ListWorkloads</a>
        /// operation to discover the available workload names and the <a href="https://docs.aws.amazon.com/launchwizard/latest/APIReference/API_ListWorkloadDeploymentPatterns.html">ListWorkloadDeploymentPatterns</a>
        /// operation to discover the available deployment pattern names of a given workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkloadDeploymentPattern service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkloadDeploymentPattern service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/GetWorkloadDeploymentPattern">REST API Reference for GetWorkloadDeploymentPattern Operation</seealso>
        Task<GetWorkloadDeploymentPatternResponse> GetWorkloadDeploymentPatternAsync(GetWorkloadDeploymentPatternRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDeploymentEvents


        /// <summary>
        /// Lists the events of a deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentEvents service method.</param>
        /// 
        /// <returns>The response from the ListDeploymentEvents service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListDeploymentEvents">REST API Reference for ListDeploymentEvents Operation</seealso>
        ListDeploymentEventsResponse ListDeploymentEvents(ListDeploymentEventsRequest request);



        /// <summary>
        /// Lists the events of a deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeploymentEvents service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListDeploymentEvents">REST API Reference for ListDeploymentEvents Operation</seealso>
        Task<ListDeploymentEventsResponse> ListDeploymentEventsAsync(ListDeploymentEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDeployments


        /// <summary>
        /// Lists the deployments that have been created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments service method.</param>
        /// 
        /// <returns>The response from the ListDeployments service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        ListDeploymentsResponse ListDeployments(ListDeploymentsRequest request);



        /// <summary>
        /// Lists the deployments that have been created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeployments service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        Task<ListDeploymentsResponse> ListDeploymentsAsync(ListDeploymentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags associated with a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists the tags associated with a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListWorkloadDeploymentPatterns


        /// <summary>
        /// Lists the workload deployment patterns for a given workload name. You can use the
        /// <a href="https://docs.aws.amazon.com/launchwizard/latest/APIReference/API_ListWorkloads.html">ListWorkloads</a>
        /// operation to discover the available workload names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadDeploymentPatterns service method.</param>
        /// 
        /// <returns>The response from the ListWorkloadDeploymentPatterns service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListWorkloadDeploymentPatterns">REST API Reference for ListWorkloadDeploymentPatterns Operation</seealso>
        ListWorkloadDeploymentPatternsResponse ListWorkloadDeploymentPatterns(ListWorkloadDeploymentPatternsRequest request);



        /// <summary>
        /// Lists the workload deployment patterns for a given workload name. You can use the
        /// <a href="https://docs.aws.amazon.com/launchwizard/latest/APIReference/API_ListWorkloads.html">ListWorkloads</a>
        /// operation to discover the available workload names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadDeploymentPatterns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkloadDeploymentPatterns service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListWorkloadDeploymentPatterns">REST API Reference for ListWorkloadDeploymentPatterns Operation</seealso>
        Task<ListWorkloadDeploymentPatternsResponse> ListWorkloadDeploymentPatternsAsync(ListWorkloadDeploymentPatternsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListWorkloads


        /// <summary>
        /// Lists the available workload names. You can use the <a href="https://docs.aws.amazon.com/launchwizard/latest/APIReference/API_ListWorkloadDeploymentPatterns.html">ListWorkloadDeploymentPatterns</a>
        /// operation to discover the available deployment patterns for a given workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloads service method.</param>
        /// 
        /// <returns>The response from the ListWorkloads service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListWorkloads">REST API Reference for ListWorkloads Operation</seealso>
        ListWorkloadsResponse ListWorkloads(ListWorkloadsRequest request);



        /// <summary>
        /// Lists the available workload names. You can use the <a href="https://docs.aws.amazon.com/launchwizard/latest/APIReference/API_ListWorkloadDeploymentPatterns.html">ListWorkloadDeploymentPatterns</a>
        /// operation to discover the available deployment patterns for a given workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloads service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkloads service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListWorkloads">REST API Reference for ListWorkloads Operation</seealso>
        Task<ListWorkloadsResponse> ListWorkloadsAsync(ListWorkloadsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds the specified tags to the given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds the specified tags to the given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from the given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes the specified tags from the given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}