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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.GroundStation.Model;

namespace Amazon.GroundStation
{
    /// <summary>
    /// Interface for accessing GroundStation
    ///
    /// Welcome to the AWS Ground Station API Reference. AWS Ground Station is a fully managed
    /// service that enables you to control satellite communications, downlink and process
    /// satellite data, and scale your satellite operations efficiently and cost-effectively
    /// without having to build or manage your own ground station infrastructure.
    /// </summary>
    public partial interface IAmazonGroundStation : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IGroundStationPaginatorFactory Paginators { get; }
#endif
                
        #region  CancelContact



        /// <summary>
        /// Cancels a contact with a specified contact ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelContact service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CancelContact">REST API Reference for CancelContact Operation</seealso>
        Task<CancelContactResponse> CancelContactAsync(CancelContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateConfig



        /// <summary>
        /// Creates a <code>Config</code> with the specified <code>configData</code> parameters.
        /// 
        ///  
        /// <para>
        /// Only one type of <code>configData</code> can be specified.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfig service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceLimitExceededException">
        /// Account limits for this resource have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateConfig">REST API Reference for CreateConfig Operation</seealso>
        Task<CreateConfigResponse> CreateConfigAsync(CreateConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDataflowEndpointGroup



        /// <summary>
        /// Creates a <code>DataflowEndpoint</code> group containing the specified list of <code>DataflowEndpoint</code>
        /// objects.
        /// 
        ///  
        /// <para>
        /// The <code>name</code> field in each endpoint is used in your mission profile <code>DataflowEndpointConfig</code>
        /// to specify which endpoints to use during a contact.
        /// </para>
        ///  
        /// <para>
        /// When a contact uses multiple <code>DataflowEndpointConfig</code> objects, each <code>Config</code>
        /// must match a <code>DataflowEndpoint</code> in the same group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataflowEndpointGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataflowEndpointGroup service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateDataflowEndpointGroup">REST API Reference for CreateDataflowEndpointGroup Operation</seealso>
        Task<CreateDataflowEndpointGroupResponse> CreateDataflowEndpointGroupAsync(CreateDataflowEndpointGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEphemeris



        /// <summary>
        /// Creates an Ephemeris with the specified <code>EphemerisData</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEphemeris service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEphemeris service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateEphemeris">REST API Reference for CreateEphemeris Operation</seealso>
        Task<CreateEphemerisResponse> CreateEphemerisAsync(CreateEphemerisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMissionProfile



        /// <summary>
        /// Creates a mission profile.
        /// 
        ///  
        /// <para>
        ///  <code>dataflowEdges</code> is a list of lists of strings. Each lower level list of
        /// strings has two elements: a <i>from</i> ARN and a <i>to</i> ARN.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMissionProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMissionProfile service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateMissionProfile">REST API Reference for CreateMissionProfile Operation</seealso>
        Task<CreateMissionProfileResponse> CreateMissionProfileAsync(CreateMissionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteConfig



        /// <summary>
        /// Deletes a <code>Config</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfig service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteConfig">REST API Reference for DeleteConfig Operation</seealso>
        Task<DeleteConfigResponse> DeleteConfigAsync(DeleteConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDataflowEndpointGroup



        /// <summary>
        /// Deletes a dataflow endpoint group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataflowEndpointGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataflowEndpointGroup service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteDataflowEndpointGroup">REST API Reference for DeleteDataflowEndpointGroup Operation</seealso>
        Task<DeleteDataflowEndpointGroupResponse> DeleteDataflowEndpointGroupAsync(DeleteDataflowEndpointGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEphemeris



        /// <summary>
        /// Deletes an ephemeris
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEphemeris service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEphemeris service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteEphemeris">REST API Reference for DeleteEphemeris Operation</seealso>
        Task<DeleteEphemerisResponse> DeleteEphemerisAsync(DeleteEphemerisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMissionProfile



        /// <summary>
        /// Deletes a mission profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMissionProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMissionProfile service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteMissionProfile">REST API Reference for DeleteMissionProfile Operation</seealso>
        Task<DeleteMissionProfileResponse> DeleteMissionProfileAsync(DeleteMissionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeContact



        /// <summary>
        /// Describes an existing contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeContact service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DescribeContact">REST API Reference for DescribeContact Operation</seealso>
        Task<DescribeContactResponse> DescribeContactAsync(DescribeContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEphemeris



        /// <summary>
        /// Describes an existing ephemeris.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEphemeris service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEphemeris service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DescribeEphemeris">REST API Reference for DescribeEphemeris Operation</seealso>
        Task<DescribeEphemerisResponse> DescribeEphemerisAsync(DescribeEphemerisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAgentConfiguration



        /// <summary>
        /// Gets the latest configuration information for a registered agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAgentConfiguration service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetAgentConfiguration">REST API Reference for GetAgentConfiguration Operation</seealso>
        Task<GetAgentConfigurationResponse> GetAgentConfigurationAsync(GetAgentConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetConfig



        /// <summary>
        /// Returns <code>Config</code> information.
        /// 
        ///  
        /// <para>
        /// Only one <code>Config</code> response can be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfig service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetConfig">REST API Reference for GetConfig Operation</seealso>
        Task<GetConfigResponse> GetConfigAsync(GetConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDataflowEndpointGroup



        /// <summary>
        /// Returns the dataflow endpoint group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataflowEndpointGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataflowEndpointGroup service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetDataflowEndpointGroup">REST API Reference for GetDataflowEndpointGroup Operation</seealso>
        Task<GetDataflowEndpointGroupResponse> GetDataflowEndpointGroupAsync(GetDataflowEndpointGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMinuteUsage



        /// <summary>
        /// Returns the number of minutes used by account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMinuteUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMinuteUsage service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetMinuteUsage">REST API Reference for GetMinuteUsage Operation</seealso>
        Task<GetMinuteUsageResponse> GetMinuteUsageAsync(GetMinuteUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMissionProfile



        /// <summary>
        /// Returns a mission profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMissionProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMissionProfile service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetMissionProfile">REST API Reference for GetMissionProfile Operation</seealso>
        Task<GetMissionProfileResponse> GetMissionProfileAsync(GetMissionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSatellite



        /// <summary>
        /// Returns a satellite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSatellite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSatellite service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetSatellite">REST API Reference for GetSatellite Operation</seealso>
        Task<GetSatelliteResponse> GetSatelliteAsync(GetSatelliteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListConfigs



        /// <summary>
        /// Returns a list of <code>Config</code> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfigs service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListConfigs">REST API Reference for ListConfigs Operation</seealso>
        Task<ListConfigsResponse> ListConfigsAsync(ListConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListContacts



        /// <summary>
        /// Returns a list of contacts.
        /// 
        ///  
        /// <para>
        /// If <code>statusList</code> contains AVAILABLE, the request must include <code>groundStation</code>,
        /// <code>missionprofileArn</code>, and <code>satelliteArn</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContacts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListContacts service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListContacts">REST API Reference for ListContacts Operation</seealso>
        Task<ListContactsResponse> ListContactsAsync(ListContactsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDataflowEndpointGroups



        /// <summary>
        /// Returns a list of <code>DataflowEndpoint</code> groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataflowEndpointGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataflowEndpointGroups service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListDataflowEndpointGroups">REST API Reference for ListDataflowEndpointGroups Operation</seealso>
        Task<ListDataflowEndpointGroupsResponse> ListDataflowEndpointGroupsAsync(ListDataflowEndpointGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEphemerides



        /// <summary>
        /// List existing ephemerides.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEphemerides service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEphemerides service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListEphemerides">REST API Reference for ListEphemerides Operation</seealso>
        Task<ListEphemeridesResponse> ListEphemeridesAsync(ListEphemeridesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListGroundStations



        /// <summary>
        /// Returns a list of ground stations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroundStations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroundStations service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListGroundStations">REST API Reference for ListGroundStations Operation</seealso>
        Task<ListGroundStationsResponse> ListGroundStationsAsync(ListGroundStationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMissionProfiles



        /// <summary>
        /// Returns a list of mission profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMissionProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMissionProfiles service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListMissionProfiles">REST API Reference for ListMissionProfiles Operation</seealso>
        Task<ListMissionProfilesResponse> ListMissionProfilesAsync(ListMissionProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSatellites



        /// <summary>
        /// Returns a list of satellites.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSatellites service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSatellites service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListSatellites">REST API Reference for ListSatellites Operation</seealso>
        Task<ListSatellitesResponse> ListSatellitesAsync(ListSatellitesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Returns a list of tags for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterAgent



        /// <summary>
        /// Registers a new agent with AWS Groundstation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterAgent service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/RegisterAgent">REST API Reference for RegisterAgent Operation</seealso>
        Task<RegisterAgentResponse> RegisterAgentAsync(RegisterAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReserveContact



        /// <summary>
        /// Reserves a contact using specified parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReserveContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReserveContact service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ReserveContact">REST API Reference for ReserveContact Operation</seealso>
        Task<ReserveContactResponse> ReserveContactAsync(ReserveContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Assigns a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Deassigns a resource tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAgentStatus



        /// <summary>
        /// Update the status of the agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAgentStatus service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateAgentStatus">REST API Reference for UpdateAgentStatus Operation</seealso>
        Task<UpdateAgentStatusResponse> UpdateAgentStatusAsync(UpdateAgentStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateConfig



        /// <summary>
        /// Updates the <code>Config</code> used when scheduling contacts.
        /// 
        ///  
        /// <para>
        /// Updating a <code>Config</code> will not update the execution parameters for existing
        /// future contacts scheduled with this <code>Config</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfig service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateConfig">REST API Reference for UpdateConfig Operation</seealso>
        Task<UpdateConfigResponse> UpdateConfigAsync(UpdateConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateEphemeris



        /// <summary>
        /// Updates an existing ephemeris
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEphemeris service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEphemeris service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateEphemeris">REST API Reference for UpdateEphemeris Operation</seealso>
        Task<UpdateEphemerisResponse> UpdateEphemerisAsync(UpdateEphemerisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMissionProfile



        /// <summary>
        /// Updates a mission profile.
        /// 
        ///  
        /// <para>
        /// Updating a mission profile will not update the execution parameters for existing future
        /// contacts.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMissionProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMissionProfile service method, as returned by GroundStation.</returns>
        /// <exception cref="Amazon.GroundStation.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.GroundStation.Model.ResourceNotFoundException">
        /// Resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateMissionProfile">REST API Reference for UpdateMissionProfile Operation</seealso>
        Task<UpdateMissionProfileResponse> UpdateMissionProfileAsync(UpdateMissionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}