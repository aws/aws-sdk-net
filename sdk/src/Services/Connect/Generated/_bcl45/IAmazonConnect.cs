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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Connect.Model;

namespace Amazon.Connect
{
    /// <summary>
    /// Interface for accessing Connect
    ///
    /// Amazon Connect is a cloud-based contact center solution that makes it easy to set
    /// up and manage a customer contact center and provide reliable customer engagement at
    /// any scale.
    /// 
    ///  
    /// <para>
    /// Amazon Connect provides rich metrics and real-time reporting that allow you to optimize
    /// contact routing. You can also resolve customer issues more efficiently by putting
    /// customers in touch with the right agents.
    /// </para>
    ///  
    /// <para>
    /// There are limits to the number of Amazon Connect resources that you can create and
    /// limits to the number of requests that you can make per second. For more information,
    /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
    /// Connect Service Limits</a> in the <i>Amazon Connect Administrator Guide</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonConnect : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IConnectPaginatorFactory Paginators { get; }

        
        #region  CreateUser


        /// <summary>
        /// Creates a user account for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateUser">REST API Reference for CreateUser Operation</seealso>
        CreateUserResponse CreateUser(CreateUserRequest request);



        /// <summary>
        /// Creates a user account for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/CreateUser">REST API Reference for CreateUser Operation</seealso>
        Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteUser


        /// <summary>
        /// Deletes a user account from the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        DeleteUserResponse DeleteUser(DeleteUserRequest request);



        /// <summary>
        /// Deletes a user account from the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeUser


        /// <summary>
        /// Describes the specified user account. You can find the instance ID in the console
        /// (it’s the final part of the ARN). The console does not display the user IDs. Instead,
        /// list the users and note the IDs provided in the output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        DescribeUserResponse DescribeUser(DescribeUserRequest request);



        /// <summary>
        /// Describes the specified user account. You can find the instance ID in the console
        /// (it’s the final part of the ARN). The console does not display the user IDs. Instead,
        /// list the users and note the IDs provided in the output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        Task<DescribeUserResponse> DescribeUserAsync(DescribeUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeUserHierarchyGroup


        /// <summary>
        /// Describes the specified hierarchy group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserHierarchyGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeUserHierarchyGroup service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeUserHierarchyGroup">REST API Reference for DescribeUserHierarchyGroup Operation</seealso>
        DescribeUserHierarchyGroupResponse DescribeUserHierarchyGroup(DescribeUserHierarchyGroupRequest request);



        /// <summary>
        /// Describes the specified hierarchy group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserHierarchyGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUserHierarchyGroup service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeUserHierarchyGroup">REST API Reference for DescribeUserHierarchyGroup Operation</seealso>
        Task<DescribeUserHierarchyGroupResponse> DescribeUserHierarchyGroupAsync(DescribeUserHierarchyGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeUserHierarchyStructure


        /// <summary>
        /// Describes the hierarchy structure of the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserHierarchyStructure service method.</param>
        /// 
        /// <returns>The response from the DescribeUserHierarchyStructure service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeUserHierarchyStructure">REST API Reference for DescribeUserHierarchyStructure Operation</seealso>
        DescribeUserHierarchyStructureResponse DescribeUserHierarchyStructure(DescribeUserHierarchyStructureRequest request);



        /// <summary>
        /// Describes the hierarchy structure of the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserHierarchyStructure service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUserHierarchyStructure service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/DescribeUserHierarchyStructure">REST API Reference for DescribeUserHierarchyStructure Operation</seealso>
        Task<DescribeUserHierarchyStructureResponse> DescribeUserHierarchyStructureAsync(DescribeUserHierarchyStructureRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetContactAttributes


        /// <summary>
        /// Retrieves the contact attributes for the specified contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContactAttributes service method.</param>
        /// 
        /// <returns>The response from the GetContactAttributes service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetContactAttributes">REST API Reference for GetContactAttributes Operation</seealso>
        GetContactAttributesResponse GetContactAttributes(GetContactAttributesRequest request);



        /// <summary>
        /// Retrieves the contact attributes for the specified contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContactAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContactAttributes service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetContactAttributes">REST API Reference for GetContactAttributes Operation</seealso>
        Task<GetContactAttributesResponse> GetContactAttributesAsync(GetContactAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCurrentMetricData


        /// <summary>
        /// Gets the real-time metric data from the specified Amazon Connect instance.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/real-time-metrics-reports.html">Real-time
        /// Metrics Reports</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCurrentMetricData service method.</param>
        /// 
        /// <returns>The response from the GetCurrentMetricData service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetCurrentMetricData">REST API Reference for GetCurrentMetricData Operation</seealso>
        GetCurrentMetricDataResponse GetCurrentMetricData(GetCurrentMetricDataRequest request);



        /// <summary>
        /// Gets the real-time metric data from the specified Amazon Connect instance.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/real-time-metrics-reports.html">Real-time
        /// Metrics Reports</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCurrentMetricData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCurrentMetricData service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetCurrentMetricData">REST API Reference for GetCurrentMetricData Operation</seealso>
        Task<GetCurrentMetricDataResponse> GetCurrentMetricDataAsync(GetCurrentMetricDataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFederationToken


        /// <summary>
        /// Retrieves a token for federation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFederationToken service method.</param>
        /// 
        /// <returns>The response from the GetFederationToken service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.UserNotFoundException">
        /// No user with the specified credentials was found in the Amazon Connect instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetFederationToken">REST API Reference for GetFederationToken Operation</seealso>
        GetFederationTokenResponse GetFederationToken(GetFederationTokenRequest request);



        /// <summary>
        /// Retrieves a token for federation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFederationToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFederationToken service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.UserNotFoundException">
        /// No user with the specified credentials was found in the Amazon Connect instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetFederationToken">REST API Reference for GetFederationToken Operation</seealso>
        Task<GetFederationTokenResponse> GetFederationTokenAsync(GetFederationTokenRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMetricData


        /// <summary>
        /// Gets historical metric data from the specified Amazon Connect instance.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics.html">Historical
        /// Metrics Reports</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetricData service method.</param>
        /// 
        /// <returns>The response from the GetMetricData service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetMetricData">REST API Reference for GetMetricData Operation</seealso>
        GetMetricDataResponse GetMetricData(GetMetricDataRequest request);



        /// <summary>
        /// Gets historical metric data from the specified Amazon Connect instance.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics.html">Historical
        /// Metrics Reports</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetricData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMetricData service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/GetMetricData">REST API Reference for GetMetricData Operation</seealso>
        Task<GetMetricDataResponse> GetMetricDataAsync(GetMetricDataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListContactFlows


        /// <summary>
        /// Provides information about the contact flows for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContactFlows service method.</param>
        /// 
        /// <returns>The response from the ListContactFlows service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListContactFlows">REST API Reference for ListContactFlows Operation</seealso>
        ListContactFlowsResponse ListContactFlows(ListContactFlowsRequest request);



        /// <summary>
        /// Provides information about the contact flows for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContactFlows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListContactFlows service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListContactFlows">REST API Reference for ListContactFlows Operation</seealso>
        Task<ListContactFlowsResponse> ListContactFlowsAsync(ListContactFlowsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListHoursOfOperations


        /// <summary>
        /// Provides information about the hours of operation for the specified Amazon Connect
        /// instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHoursOfOperations service method.</param>
        /// 
        /// <returns>The response from the ListHoursOfOperations service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListHoursOfOperations">REST API Reference for ListHoursOfOperations Operation</seealso>
        ListHoursOfOperationsResponse ListHoursOfOperations(ListHoursOfOperationsRequest request);



        /// <summary>
        /// Provides information about the hours of operation for the specified Amazon Connect
        /// instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHoursOfOperations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHoursOfOperations service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListHoursOfOperations">REST API Reference for ListHoursOfOperations Operation</seealso>
        Task<ListHoursOfOperationsResponse> ListHoursOfOperationsAsync(ListHoursOfOperationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPhoneNumbers


        /// <summary>
        /// Provides information about the phone numbers for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumbers service method.</param>
        /// 
        /// <returns>The response from the ListPhoneNumbers service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListPhoneNumbers">REST API Reference for ListPhoneNumbers Operation</seealso>
        ListPhoneNumbersResponse ListPhoneNumbers(ListPhoneNumbersRequest request);



        /// <summary>
        /// Provides information about the phone numbers for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumbers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPhoneNumbers service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListPhoneNumbers">REST API Reference for ListPhoneNumbers Operation</seealso>
        Task<ListPhoneNumbersResponse> ListPhoneNumbersAsync(ListPhoneNumbersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListQueues


        /// <summary>
        /// Provides information about the queues for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueues service method.</param>
        /// 
        /// <returns>The response from the ListQueues service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListQueues">REST API Reference for ListQueues Operation</seealso>
        ListQueuesResponse ListQueues(ListQueuesRequest request);



        /// <summary>
        /// Provides information about the queues for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQueues service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListQueues">REST API Reference for ListQueues Operation</seealso>
        Task<ListQueuesResponse> ListQueuesAsync(ListQueuesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRoutingProfiles


        /// <summary>
        /// Provides summary information about the routing profiles for the specified Amazon Connect
        /// instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoutingProfiles service method.</param>
        /// 
        /// <returns>The response from the ListRoutingProfiles service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListRoutingProfiles">REST API Reference for ListRoutingProfiles Operation</seealso>
        ListRoutingProfilesResponse ListRoutingProfiles(ListRoutingProfilesRequest request);



        /// <summary>
        /// Provides summary information about the routing profiles for the specified Amazon Connect
        /// instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoutingProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRoutingProfiles service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListRoutingProfiles">REST API Reference for ListRoutingProfiles Operation</seealso>
        Task<ListRoutingProfilesResponse> ListRoutingProfilesAsync(ListRoutingProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSecurityProfiles


        /// <summary>
        /// Provides summary information about the security profiles for the specified Amazon
        /// Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityProfiles service method.</param>
        /// 
        /// <returns>The response from the ListSecurityProfiles service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListSecurityProfiles">REST API Reference for ListSecurityProfiles Operation</seealso>
        ListSecurityProfilesResponse ListSecurityProfiles(ListSecurityProfilesRequest request);



        /// <summary>
        /// Provides summary information about the security profiles for the specified Amazon
        /// Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSecurityProfiles service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListSecurityProfiles">REST API Reference for ListSecurityProfiles Operation</seealso>
        Task<ListSecurityProfilesResponse> ListSecurityProfilesAsync(ListSecurityProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListUserHierarchyGroups


        /// <summary>
        /// Provides summary information about the hierarchy groups for the specified Amazon Connect
        /// instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserHierarchyGroups service method.</param>
        /// 
        /// <returns>The response from the ListUserHierarchyGroups service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListUserHierarchyGroups">REST API Reference for ListUserHierarchyGroups Operation</seealso>
        ListUserHierarchyGroupsResponse ListUserHierarchyGroups(ListUserHierarchyGroupsRequest request);



        /// <summary>
        /// Provides summary information about the hierarchy groups for the specified Amazon Connect
        /// instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserHierarchyGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUserHierarchyGroups service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListUserHierarchyGroups">REST API Reference for ListUserHierarchyGroups Operation</seealso>
        Task<ListUserHierarchyGroupsResponse> ListUserHierarchyGroupsAsync(ListUserHierarchyGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListUsers


        /// <summary>
        /// Provides summary information about the users for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListUsers">REST API Reference for ListUsers Operation</seealso>
        ListUsersResponse ListUsers(ListUsersRequest request);



        /// <summary>
        /// Provides summary information about the users for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ListUsers">REST API Reference for ListUsers Operation</seealso>
        Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ResumeContactRecording


        /// <summary>
        /// When a contact is being recorded, and the recording has been suspended using SuspendContactRecording,
        /// this API resumes recording the call.
        /// 
        ///  
        /// <para>
        /// Only voice recordings are supported at this time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeContactRecording service method.</param>
        /// 
        /// <returns>The response from the ResumeContactRecording service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ResumeContactRecording">REST API Reference for ResumeContactRecording Operation</seealso>
        ResumeContactRecordingResponse ResumeContactRecording(ResumeContactRecordingRequest request);



        /// <summary>
        /// When a contact is being recorded, and the recording has been suspended using SuspendContactRecording,
        /// this API resumes recording the call.
        /// 
        ///  
        /// <para>
        /// Only voice recordings are supported at this time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeContactRecording service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResumeContactRecording service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/ResumeContactRecording">REST API Reference for ResumeContactRecording Operation</seealso>
        Task<ResumeContactRecordingResponse> ResumeContactRecordingAsync(ResumeContactRecordingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartChatContact


        /// <summary>
        /// Initiates a contact flow to start a new chat for the customer. Response of this API
        /// provides a token required to obtain credentials from the <a href="https://docs.aws.amazon.com/connect-participant/latest/APIReference/API_CreateParticipantConnection.html">CreateParticipantConnection</a>
        /// API in the Amazon Connect Participant Service.
        /// 
        ///  
        /// <para>
        /// When a new chat contact is successfully created, clients need to subscribe to the
        /// participant’s connection for the created chat within 5 minutes. This is achieved by
        /// invoking <a href="https://docs.aws.amazon.com/connect-participant/latest/APIReference/API_CreateParticipantConnection.html">CreateParticipantConnection</a>
        /// with WEBSOCKET and CONNECTION_CREDENTIALS. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartChatContact service method.</param>
        /// 
        /// <returns>The response from the StartChatContact service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartChatContact">REST API Reference for StartChatContact Operation</seealso>
        StartChatContactResponse StartChatContact(StartChatContactRequest request);



        /// <summary>
        /// Initiates a contact flow to start a new chat for the customer. Response of this API
        /// provides a token required to obtain credentials from the <a href="https://docs.aws.amazon.com/connect-participant/latest/APIReference/API_CreateParticipantConnection.html">CreateParticipantConnection</a>
        /// API in the Amazon Connect Participant Service.
        /// 
        ///  
        /// <para>
        /// When a new chat contact is successfully created, clients need to subscribe to the
        /// participant’s connection for the created chat within 5 minutes. This is achieved by
        /// invoking <a href="https://docs.aws.amazon.com/connect-participant/latest/APIReference/API_CreateParticipantConnection.html">CreateParticipantConnection</a>
        /// with WEBSOCKET and CONNECTION_CREDENTIALS. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartChatContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartChatContact service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartChatContact">REST API Reference for StartChatContact Operation</seealso>
        Task<StartChatContactResponse> StartChatContactAsync(StartChatContactRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartContactRecording


        /// <summary>
        /// This API starts recording the contact when the agent joins the call. StartContactRecording
        /// is a one-time action. For example, if you use StopContactRecording to stop recording
        /// an ongoing call, you can't use StartContactRecording to restart it. For scenarios
        /// where the recording has started and you want to suspend and resume it, such as when
        /// collecting sensitive information (for example, a credit card number), use SuspendContactRecording
        /// and ResumeContactRecording.
        /// 
        ///  
        /// <para>
        /// You can use this API to override the recording behavior configured in the <a href="https://docs.aws.amazon.com/connect/latest/adminguide/set-recording-behavior.html">Set
        /// recording behavior</a> block.
        /// </para>
        ///  
        /// <para>
        /// Only voice recordings are supported at this time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartContactRecording service method.</param>
        /// 
        /// <returns>The response from the StartContactRecording service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartContactRecording">REST API Reference for StartContactRecording Operation</seealso>
        StartContactRecordingResponse StartContactRecording(StartContactRecordingRequest request);



        /// <summary>
        /// This API starts recording the contact when the agent joins the call. StartContactRecording
        /// is a one-time action. For example, if you use StopContactRecording to stop recording
        /// an ongoing call, you can't use StartContactRecording to restart it. For scenarios
        /// where the recording has started and you want to suspend and resume it, such as when
        /// collecting sensitive information (for example, a credit card number), use SuspendContactRecording
        /// and ResumeContactRecording.
        /// 
        ///  
        /// <para>
        /// You can use this API to override the recording behavior configured in the <a href="https://docs.aws.amazon.com/connect/latest/adminguide/set-recording-behavior.html">Set
        /// recording behavior</a> block.
        /// </para>
        ///  
        /// <para>
        /// Only voice recordings are supported at this time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartContactRecording service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartContactRecording service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartContactRecording">REST API Reference for StartContactRecording Operation</seealso>
        Task<StartContactRecordingResponse> StartContactRecordingAsync(StartContactRecordingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartOutboundVoiceContact


        /// <summary>
        /// This API places an outbound call to a contact, and then initiates the contact flow.
        /// It performs the actions in the contact flow that's specified (in <code>ContactFlowId</code>).
        /// 
        ///  
        /// <para>
        /// Agents are not involved in initiating the outbound API (that is, dialing the contact).
        /// If the contact flow places an outbound call to a contact, and then puts the contact
        /// in queue, that's when the call is routed to the agent, like any other inbound case.
        /// </para>
        ///  
        /// <para>
        /// There is a 60 second dialing timeout for this operation. If the call is not connected
        /// after 60 seconds, it fails.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartOutboundVoiceContact service method.</param>
        /// 
        /// <returns>The response from the StartOutboundVoiceContact service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DestinationNotAllowedException">
        /// Outbound calls to the destination number are not allowed.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.OutboundContactNotPermittedException">
        /// The contact is not permitted.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartOutboundVoiceContact">REST API Reference for StartOutboundVoiceContact Operation</seealso>
        StartOutboundVoiceContactResponse StartOutboundVoiceContact(StartOutboundVoiceContactRequest request);



        /// <summary>
        /// This API places an outbound call to a contact, and then initiates the contact flow.
        /// It performs the actions in the contact flow that's specified (in <code>ContactFlowId</code>).
        /// 
        ///  
        /// <para>
        /// Agents are not involved in initiating the outbound API (that is, dialing the contact).
        /// If the contact flow places an outbound call to a contact, and then puts the contact
        /// in queue, that's when the call is routed to the agent, like any other inbound case.
        /// </para>
        ///  
        /// <para>
        /// There is a 60 second dialing timeout for this operation. If the call is not connected
        /// after 60 seconds, it fails.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartOutboundVoiceContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartOutboundVoiceContact service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.DestinationNotAllowedException">
        /// Outbound calls to the destination number are not allowed.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.LimitExceededException">
        /// The allowed limit for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.OutboundContactNotPermittedException">
        /// The contact is not permitted.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StartOutboundVoiceContact">REST API Reference for StartOutboundVoiceContact Operation</seealso>
        Task<StartOutboundVoiceContactResponse> StartOutboundVoiceContactAsync(StartOutboundVoiceContactRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopContact


        /// <summary>
        /// Ends the specified contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopContact service method.</param>
        /// 
        /// <returns>The response from the StopContact service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.ContactNotFoundException">
        /// The contact with the specified ID is not active or does not exist.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StopContact">REST API Reference for StopContact Operation</seealso>
        StopContactResponse StopContact(StopContactRequest request);



        /// <summary>
        /// Ends the specified contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopContact service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.ContactNotFoundException">
        /// The contact with the specified ID is not active or does not exist.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StopContact">REST API Reference for StopContact Operation</seealso>
        Task<StopContactResponse> StopContactAsync(StopContactRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopContactRecording


        /// <summary>
        /// When a contact is being recorded, this API stops recording the call. StopContactRecording
        /// is a one-time action. If you use StopContactRecording to stop recording an ongoing
        /// call, you can't use StartContactRecording to restart it. For scenarios where the recording
        /// has started and you want to suspend it for sensitive information (for example, to
        /// collect a credit card number), and then restart it, use SuspendContactRecording and
        /// ResumeContactRecording.
        /// 
        ///  
        /// <para>
        /// Only voice recordings are supported at this time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopContactRecording service method.</param>
        /// 
        /// <returns>The response from the StopContactRecording service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StopContactRecording">REST API Reference for StopContactRecording Operation</seealso>
        StopContactRecordingResponse StopContactRecording(StopContactRecordingRequest request);



        /// <summary>
        /// When a contact is being recorded, this API stops recording the call. StopContactRecording
        /// is a one-time action. If you use StopContactRecording to stop recording an ongoing
        /// call, you can't use StartContactRecording to restart it. For scenarios where the recording
        /// has started and you want to suspend it for sensitive information (for example, to
        /// collect a credit card number), and then restart it, use SuspendContactRecording and
        /// ResumeContactRecording.
        /// 
        ///  
        /// <para>
        /// Only voice recordings are supported at this time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopContactRecording service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopContactRecording service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/StopContactRecording">REST API Reference for StopContactRecording Operation</seealso>
        Task<StopContactRecordingResponse> StopContactRecordingAsync(StopContactRecordingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SuspendContactRecording


        /// <summary>
        /// When a contact is being recorded, this API suspends recording the call. For example,
        /// you might suspend the call recording while collecting sensitive information, such
        /// as a credit card number. Then use ResumeContactRecording to restart recording. 
        /// 
        ///  
        /// <para>
        /// The period of time that the recording is suspended is filled with silence in the final
        /// recording. 
        /// </para>
        ///  
        /// <para>
        /// Only voice recordings are supported at this time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SuspendContactRecording service method.</param>
        /// 
        /// <returns>The response from the SuspendContactRecording service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SuspendContactRecording">REST API Reference for SuspendContactRecording Operation</seealso>
        SuspendContactRecordingResponse SuspendContactRecording(SuspendContactRecordingRequest request);



        /// <summary>
        /// When a contact is being recorded, this API suspends recording the call. For example,
        /// you might suspend the call recording while collecting sensitive information, such
        /// as a credit card number. Then use ResumeContactRecording to restart recording. 
        /// 
        ///  
        /// <para>
        /// The period of time that the recording is suspended is filled with silence in the final
        /// recording. 
        /// </para>
        ///  
        /// <para>
        /// Only voice recordings are supported at this time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SuspendContactRecording service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SuspendContactRecording service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/SuspendContactRecording">REST API Reference for SuspendContactRecording Operation</seealso>
        Task<SuspendContactRecordingResponse> SuspendContactRecordingAsync(SuspendContactRecordingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// 
        ///  
        /// <para>
        /// The supported resource type is users.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// 
        ///  
        /// <para>
        /// The supported resource type is users.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateContactAttributes


        /// <summary>
        /// Creates or updates the contact attributes associated with the specified contact.
        /// 
        ///  
        /// <para>
        /// You can add or update attributes for both ongoing and completed contacts. For example,
        /// you can update the customer's name or the reason the customer called while the call
        /// is active, or add notes about steps that the agent took during the call that are displayed
        /// to the next agent that takes the call. You can also update attributes for a contact
        /// using data from your CRM application and save the data with the contact in Amazon
        /// Connect. You could also flag calls for additional analysis, such as legal review or
        /// identifying abusive callers.
        /// </para>
        ///  
        /// <para>
        /// Contact attributes are available in Amazon Connect for 24 months, and are then deleted.
        /// </para>
        ///  
        /// <para>
        ///  <b>Important:</b> You cannot use the operation to update attributes for contacts
        /// that occurred prior to the release of the API, September 12, 2018. You can update
        /// attributes only for contacts that started after the release of the API. If you attempt
        /// to update attributes for a contact that occurred prior to the release of the API,
        /// a 400 error is returned. This applies also to queued callbacks that were initiated
        /// prior to the release of the API but are still active in your instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactAttributes service method.</param>
        /// 
        /// <returns>The response from the UpdateContactAttributes service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactAttributes">REST API Reference for UpdateContactAttributes Operation</seealso>
        UpdateContactAttributesResponse UpdateContactAttributes(UpdateContactAttributesRequest request);



        /// <summary>
        /// Creates or updates the contact attributes associated with the specified contact.
        /// 
        ///  
        /// <para>
        /// You can add or update attributes for both ongoing and completed contacts. For example,
        /// you can update the customer's name or the reason the customer called while the call
        /// is active, or add notes about steps that the agent took during the call that are displayed
        /// to the next agent that takes the call. You can also update attributes for a contact
        /// using data from your CRM application and save the data with the contact in Amazon
        /// Connect. You could also flag calls for additional analysis, such as legal review or
        /// identifying abusive callers.
        /// </para>
        ///  
        /// <para>
        /// Contact attributes are available in Amazon Connect for 24 months, and are then deleted.
        /// </para>
        ///  
        /// <para>
        ///  <b>Important:</b> You cannot use the operation to update attributes for contacts
        /// that occurred prior to the release of the API, September 12, 2018. You can update
        /// attributes only for contacts that started after the release of the API. If you attempt
        /// to update attributes for a contact that occurred prior to the release of the API,
        /// a 400 error is returned. This applies also to queued callbacks that were initiated
        /// prior to the release of the API but are still active in your instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContactAttributes service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateContactAttributes">REST API Reference for UpdateContactAttributes Operation</seealso>
        Task<UpdateContactAttributesResponse> UpdateContactAttributesAsync(UpdateContactAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateUserHierarchy


        /// <summary>
        /// Assigns the specified hierarchy group to the specified user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserHierarchy service method.</param>
        /// 
        /// <returns>The response from the UpdateUserHierarchy service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserHierarchy">REST API Reference for UpdateUserHierarchy Operation</seealso>
        UpdateUserHierarchyResponse UpdateUserHierarchy(UpdateUserHierarchyRequest request);



        /// <summary>
        /// Assigns the specified hierarchy group to the specified user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserHierarchy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserHierarchy service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserHierarchy">REST API Reference for UpdateUserHierarchy Operation</seealso>
        Task<UpdateUserHierarchyResponse> UpdateUserHierarchyAsync(UpdateUserHierarchyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateUserIdentityInfo


        /// <summary>
        /// Updates the identity information for the specified user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserIdentityInfo service method.</param>
        /// 
        /// <returns>The response from the UpdateUserIdentityInfo service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserIdentityInfo">REST API Reference for UpdateUserIdentityInfo Operation</seealso>
        UpdateUserIdentityInfoResponse UpdateUserIdentityInfo(UpdateUserIdentityInfoRequest request);



        /// <summary>
        /// Updates the identity information for the specified user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserIdentityInfo service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserIdentityInfo service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserIdentityInfo">REST API Reference for UpdateUserIdentityInfo Operation</seealso>
        Task<UpdateUserIdentityInfoResponse> UpdateUserIdentityInfoAsync(UpdateUserIdentityInfoRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateUserPhoneConfig


        /// <summary>
        /// Updates the phone configuration settings for the specified user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPhoneConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateUserPhoneConfig service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserPhoneConfig">REST API Reference for UpdateUserPhoneConfig Operation</seealso>
        UpdateUserPhoneConfigResponse UpdateUserPhoneConfig(UpdateUserPhoneConfigRequest request);



        /// <summary>
        /// Updates the phone configuration settings for the specified user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPhoneConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserPhoneConfig service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserPhoneConfig">REST API Reference for UpdateUserPhoneConfig Operation</seealso>
        Task<UpdateUserPhoneConfigResponse> UpdateUserPhoneConfigAsync(UpdateUserPhoneConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateUserRoutingProfile


        /// <summary>
        /// Assigns the specified routing profile to the specified user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserRoutingProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateUserRoutingProfile service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserRoutingProfile">REST API Reference for UpdateUserRoutingProfile Operation</seealso>
        UpdateUserRoutingProfileResponse UpdateUserRoutingProfile(UpdateUserRoutingProfileRequest request);



        /// <summary>
        /// Assigns the specified routing profile to the specified user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserRoutingProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserRoutingProfile service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserRoutingProfile">REST API Reference for UpdateUserRoutingProfile Operation</seealso>
        Task<UpdateUserRoutingProfileResponse> UpdateUserRoutingProfileAsync(UpdateUserRoutingProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateUserSecurityProfiles


        /// <summary>
        /// Assigns the specified security profiles to the specified user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserSecurityProfiles service method.</param>
        /// 
        /// <returns>The response from the UpdateUserSecurityProfiles service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserSecurityProfiles">REST API Reference for UpdateUserSecurityProfiles Operation</seealso>
        UpdateUserSecurityProfilesResponse UpdateUserSecurityProfiles(UpdateUserSecurityProfilesRequest request);



        /// <summary>
        /// Assigns the specified security profiles to the specified user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserSecurityProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserSecurityProfiles service method, as returned by Connect.</returns>
        /// <exception cref="Amazon.Connect.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidParameterException">
        /// One or more of the specified parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Connect.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-2017-08-08/UpdateUserSecurityProfiles">REST API Reference for UpdateUserSecurityProfiles Operation</seealso>
        Task<UpdateUserSecurityProfilesResponse> UpdateUserSecurityProfilesAsync(UpdateUserSecurityProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}