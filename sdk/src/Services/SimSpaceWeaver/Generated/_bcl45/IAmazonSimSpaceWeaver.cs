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
 * Do not modify this file. This file is generated from the simspaceweaver-2022-10-28.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SimSpaceWeaver.Model;

namespace Amazon.SimSpaceWeaver
{
    /// <summary>
    /// Interface for accessing SimSpaceWeaver
    ///
    /// Amazon Web Services SimSpace Weaver (SimSpace Weaver) is a managed service that you
    /// can use to build and operate large-scale spatial simulations in the Amazon Web Services
    /// Cloud. For example, you can create a digital twin of a city, crowd simulations with
    /// millions of people and objects, and massilvely-multiplayer games with hundreds of
    /// thousands of connected players. For more information about SimSpace Weaver, see the
    /// <i> <a href="https://docs.aws.amazon.com/simspaceweaver/latest/userguide/">Amazon
    /// Web Services SimSpace Weaver User Guide</a> </i>.
    /// 
    ///  
    /// <para>
    /// This API reference describes the API operations and data types that you can use to
    /// communicate directly with SimSpace Weaver.
    /// </para>
    ///  
    /// <para>
    /// SimSpace Weaver also provides the SimSpace Weaver app SDK, which you use for app development.
    /// The SimSpace Weaver app SDK API reference is included in the SimSpace Weaver app SDK
    /// documentation, which is part of the SimSpace Weaver app SDK distributable package.
    /// </para>
    /// </summary>
    public partial interface IAmazonSimSpaceWeaver : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISimSpaceWeaverPaginatorFactory Paginators { get; }

        
        #region  DeleteApp


        /// <summary>
        /// Deletes the instance of the given custom app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        DeleteAppResponse DeleteApp(DeleteAppRequest request);



        /// <summary>
        /// Deletes the instance of the given custom app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSimulation


        /// <summary>
        /// Deletes all SimSpace Weaver resources assigned to the given simulation.
        /// 
        ///  <note> 
        /// <para>
        /// Your simulation uses resources in other Amazon Web Services services. This API operation
        /// doesn't delete resources in other Amazon Web Services services.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSimulation service method.</param>
        /// 
        /// <returns>The response from the DeleteSimulation service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DeleteSimulation">REST API Reference for DeleteSimulation Operation</seealso>
        DeleteSimulationResponse DeleteSimulation(DeleteSimulationRequest request);



        /// <summary>
        /// Deletes all SimSpace Weaver resources assigned to the given simulation.
        /// 
        ///  <note> 
        /// <para>
        /// Your simulation uses resources in other Amazon Web Services services. This API operation
        /// doesn't delete resources in other Amazon Web Services services.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSimulation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSimulation service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DeleteSimulation">REST API Reference for DeleteSimulation Operation</seealso>
        Task<DeleteSimulationResponse> DeleteSimulationAsync(DeleteSimulationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeApp


        /// <summary>
        /// Returns the state of the given custom app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApp service method.</param>
        /// 
        /// <returns>The response from the DescribeApp service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DescribeApp">REST API Reference for DescribeApp Operation</seealso>
        DescribeAppResponse DescribeApp(DescribeAppRequest request);



        /// <summary>
        /// Returns the state of the given custom app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApp service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DescribeApp">REST API Reference for DescribeApp Operation</seealso>
        Task<DescribeAppResponse> DescribeAppAsync(DescribeAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSimulation


        /// <summary>
        /// Returns the current state of the given simulation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSimulation service method.</param>
        /// 
        /// <returns>The response from the DescribeSimulation service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DescribeSimulation">REST API Reference for DescribeSimulation Operation</seealso>
        DescribeSimulationResponse DescribeSimulation(DescribeSimulationRequest request);



        /// <summary>
        /// Returns the current state of the given simulation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSimulation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSimulation service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DescribeSimulation">REST API Reference for DescribeSimulation Operation</seealso>
        Task<DescribeSimulationResponse> DescribeSimulationAsync(DescribeSimulationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListApps


        /// <summary>
        /// Lists all custom apps or service apps for the given simulation and domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApps service method.</param>
        /// 
        /// <returns>The response from the ListApps service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListApps">REST API Reference for ListApps Operation</seealso>
        ListAppsResponse ListApps(ListAppsRequest request);



        /// <summary>
        /// Lists all custom apps or service apps for the given simulation and domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApps service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListApps">REST API Reference for ListApps Operation</seealso>
        Task<ListAppsResponse> ListAppsAsync(ListAppsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSimulations


        /// <summary>
        /// Lists the SimSpace Weaver simulations in the Amazon Web Services account used to make
        /// the API call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSimulations service method.</param>
        /// 
        /// <returns>The response from the ListSimulations service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListSimulations">REST API Reference for ListSimulations Operation</seealso>
        ListSimulationsResponse ListSimulations(ListSimulationsRequest request);



        /// <summary>
        /// Lists the SimSpace Weaver simulations in the Amazon Web Services account used to make
        /// the API call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSimulations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSimulations service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListSimulations">REST API Reference for ListSimulations Operation</seealso>
        Task<ListSimulationsResponse> ListSimulationsAsync(ListSimulationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags on a SimSpace Weaver resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists all tags on a SimSpace Weaver resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartApp


        /// <summary>
        /// Starts a custom app with the configuration specified in the simulation schema.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartApp service method.</param>
        /// 
        /// <returns>The response from the StartApp service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartApp">REST API Reference for StartApp Operation</seealso>
        StartAppResponse StartApp(StartAppRequest request);



        /// <summary>
        /// Starts a custom app with the configuration specified in the simulation schema.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartApp service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartApp">REST API Reference for StartApp Operation</seealso>
        Task<StartAppResponse> StartAppAsync(StartAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartClock


        /// <summary>
        /// Starts the simulation clock.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartClock service method.</param>
        /// 
        /// <returns>The response from the StartClock service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartClock">REST API Reference for StartClock Operation</seealso>
        StartClockResponse StartClock(StartClockRequest request);



        /// <summary>
        /// Starts the simulation clock.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartClock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartClock service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartClock">REST API Reference for StartClock Operation</seealso>
        Task<StartClockResponse> StartClockAsync(StartClockRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartSimulation


        /// <summary>
        /// Starts a simulation with the given name and schema.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSimulation service method.</param>
        /// 
        /// <returns>The response from the StartSimulation service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartSimulation">REST API Reference for StartSimulation Operation</seealso>
        StartSimulationResponse StartSimulation(StartSimulationRequest request);



        /// <summary>
        /// Starts a simulation with the given name and schema.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSimulation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSimulation service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartSimulation">REST API Reference for StartSimulation Operation</seealso>
        Task<StartSimulationResponse> StartSimulationAsync(StartSimulationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopApp


        /// <summary>
        /// Stops the given custom app and shuts down all of its allocated compute resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopApp service method.</param>
        /// 
        /// <returns>The response from the StopApp service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopApp">REST API Reference for StopApp Operation</seealso>
        StopAppResponse StopApp(StopAppRequest request);



        /// <summary>
        /// Stops the given custom app and shuts down all of its allocated compute resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopApp service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopApp">REST API Reference for StopApp Operation</seealso>
        Task<StopAppResponse> StopAppAsync(StopAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopClock


        /// <summary>
        /// Stops the simulation clock.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopClock service method.</param>
        /// 
        /// <returns>The response from the StopClock service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopClock">REST API Reference for StopClock Operation</seealso>
        StopClockResponse StopClock(StopClockRequest request);



        /// <summary>
        /// Stops the simulation clock.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopClock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopClock service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopClock">REST API Reference for StopClock Operation</seealso>
        Task<StopClockResponse> StopClockAsync(StopClockRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopSimulation


        /// <summary>
        /// Stops the given simulation.
        /// 
        ///  <important> 
        /// <para>
        /// You can't restart a simulation after you stop it. If you need to restart a simulation,
        /// you must stop it, delete it, and start a new instance of it.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopSimulation service method.</param>
        /// 
        /// <returns>The response from the StopSimulation service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopSimulation">REST API Reference for StopSimulation Operation</seealso>
        StopSimulationResponse StopSimulation(StopSimulationRequest request);



        /// <summary>
        /// Stops the given simulation.
        /// 
        ///  <important> 
        /// <para>
        /// You can't restart a simulation after you stop it. If you need to restart a simulation,
        /// you must stop it, delete it, and start a new instance of it.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopSimulation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopSimulation service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopSimulation">REST API Reference for StopSimulation Operation</seealso>
        Task<StopSimulationResponse> StopSimulationAsync(StopSimulationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to a SimSpace Weaver resource. For more information about tags, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.TooManyTagsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds tags to a SimSpace Weaver resource. For more information about tags, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.TooManyTagsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a SimSpace Weaver resource. For more information about tags, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging Amazon
        /// Web Services resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes tags from a SimSpace Weaver resource. For more information about tags, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging Amazon
        /// Web Services resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}