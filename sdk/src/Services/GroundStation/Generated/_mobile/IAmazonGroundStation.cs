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
    /// service that      enables you to control satellite communications, downlink and process
    /// satellite data, and      scale your satellite operations efficiently and cost-effectively
    /// without having      to build or manage your own ground station infrastructure.
    /// </summary>
    public partial interface IAmazonGroundStation : IAmazonService, IDisposable
    {
                
        #region  CancelContact


        /// <summary>
        /// Initiates the asynchronous execution of the CancelContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelContact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CancelContact">REST API Reference for CancelContact Operation</seealso>
        Task<CancelContactResponse> CancelContactAsync(CancelContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateConfig


        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateConfig">REST API Reference for CreateConfig Operation</seealso>
        Task<CreateConfigResponse> CreateConfigAsync(CreateConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDataflowEndpointGroup


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataflowEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataflowEndpointGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateDataflowEndpointGroup">REST API Reference for CreateDataflowEndpointGroup Operation</seealso>
        Task<CreateDataflowEndpointGroupResponse> CreateDataflowEndpointGroupAsync(CreateDataflowEndpointGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMissionProfile


        /// <summary>
        /// Initiates the asynchronous execution of the CreateMissionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMissionProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/CreateMissionProfile">REST API Reference for CreateMissionProfile Operation</seealso>
        Task<CreateMissionProfileResponse> CreateMissionProfileAsync(CreateMissionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteConfig


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteConfig">REST API Reference for DeleteConfig Operation</seealso>
        Task<DeleteConfigResponse> DeleteConfigAsync(DeleteConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDataflowEndpointGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataflowEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataflowEndpointGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteDataflowEndpointGroup">REST API Reference for DeleteDataflowEndpointGroup Operation</seealso>
        Task<DeleteDataflowEndpointGroupResponse> DeleteDataflowEndpointGroupAsync(DeleteDataflowEndpointGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMissionProfile


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMissionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMissionProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DeleteMissionProfile">REST API Reference for DeleteMissionProfile Operation</seealso>
        Task<DeleteMissionProfileResponse> DeleteMissionProfileAsync(DeleteMissionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeContact


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeContact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/DescribeContact">REST API Reference for DescribeContact Operation</seealso>
        Task<DescribeContactResponse> DescribeContactAsync(DescribeContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetConfig


        /// <summary>
        /// Initiates the asynchronous execution of the GetConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetConfig">REST API Reference for GetConfig Operation</seealso>
        Task<GetConfigResponse> GetConfigAsync(GetConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDataflowEndpointGroup


        /// <summary>
        /// Initiates the asynchronous execution of the GetDataflowEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataflowEndpointGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetDataflowEndpointGroup">REST API Reference for GetDataflowEndpointGroup Operation</seealso>
        Task<GetDataflowEndpointGroupResponse> GetDataflowEndpointGroupAsync(GetDataflowEndpointGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMinuteUsage


        /// <summary>
        /// Initiates the asynchronous execution of the GetMinuteUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMinuteUsage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetMinuteUsage">REST API Reference for GetMinuteUsage Operation</seealso>
        Task<GetMinuteUsageResponse> GetMinuteUsageAsync(GetMinuteUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMissionProfile


        /// <summary>
        /// Initiates the asynchronous execution of the GetMissionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMissionProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetMissionProfile">REST API Reference for GetMissionProfile Operation</seealso>
        Task<GetMissionProfileResponse> GetMissionProfileAsync(GetMissionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSatellite


        /// <summary>
        /// Initiates the asynchronous execution of the GetSatellite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSatellite operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/GetSatellite">REST API Reference for GetSatellite Operation</seealso>
        Task<GetSatelliteResponse> GetSatelliteAsync(GetSatelliteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListConfigs


        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListConfigs">REST API Reference for ListConfigs Operation</seealso>
        Task<ListConfigsResponse> ListConfigsAsync(ListConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListContacts


        /// <summary>
        /// Initiates the asynchronous execution of the ListContacts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListContacts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListContacts">REST API Reference for ListContacts Operation</seealso>
        Task<ListContactsResponse> ListContactsAsync(ListContactsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDataflowEndpointGroups


        /// <summary>
        /// Initiates the asynchronous execution of the ListDataflowEndpointGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataflowEndpointGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListDataflowEndpointGroups">REST API Reference for ListDataflowEndpointGroups Operation</seealso>
        Task<ListDataflowEndpointGroupsResponse> ListDataflowEndpointGroupsAsync(ListDataflowEndpointGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListGroundStations


        /// <summary>
        /// Initiates the asynchronous execution of the ListGroundStations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroundStations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListGroundStations">REST API Reference for ListGroundStations Operation</seealso>
        Task<ListGroundStationsResponse> ListGroundStationsAsync(ListGroundStationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMissionProfiles


        /// <summary>
        /// Initiates the asynchronous execution of the ListMissionProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMissionProfiles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListMissionProfiles">REST API Reference for ListMissionProfiles Operation</seealso>
        Task<ListMissionProfilesResponse> ListMissionProfilesAsync(ListMissionProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSatellites


        /// <summary>
        /// Initiates the asynchronous execution of the ListSatellites operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSatellites operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListSatellites">REST API Reference for ListSatellites Operation</seealso>
        Task<ListSatellitesResponse> ListSatellitesAsync(ListSatellitesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReserveContact


        /// <summary>
        /// Initiates the asynchronous execution of the ReserveContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReserveContact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/ReserveContact">REST API Reference for ReserveContact Operation</seealso>
        Task<ReserveContactResponse> ReserveContactAsync(ReserveContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource


        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource


        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateConfig


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateConfig">REST API Reference for UpdateConfig Operation</seealso>
        Task<UpdateConfigResponse> UpdateConfigAsync(UpdateConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMissionProfile


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMissionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMissionProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/groundstation-2019-05-23/UpdateMissionProfile">REST API Reference for UpdateMissionProfile Operation</seealso>
        Task<UpdateMissionProfileResponse> UpdateMissionProfileAsync(UpdateMissionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}