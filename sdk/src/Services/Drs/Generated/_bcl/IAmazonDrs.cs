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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Drs.Model;

#pragma warning disable CS1570
namespace Amazon.Drs
{
    /// <summary>
    /// <para>Interface for accessing Drs</para>
    ///
    /// AWS Elastic Disaster Recovery Service.
    /// </summary>
    public partial interface IAmazonDrs : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IDrsPaginatorFactory Paginators { get; }

        
        #region  AssociateSourceNetworkStack


        /// <summary>
        /// Associate a Source Network to an existing CloudFormation Stack and modify launch templates
        /// to use this network. Can be used for reverting to previously deployed CloudFormation
        /// stacks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSourceNetworkStack service method.</param>
        /// 
        /// <returns>The response from the AssociateSourceNetworkStack service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/AssociateSourceNetworkStack">REST API Reference for AssociateSourceNetworkStack Operation</seealso>
        AssociateSourceNetworkStackResponse AssociateSourceNetworkStack(AssociateSourceNetworkStackRequest request);



        /// <summary>
        /// Associate a Source Network to an existing CloudFormation Stack and modify launch templates
        /// to use this network. Can be used for reverting to previously deployed CloudFormation
        /// stacks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSourceNetworkStack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateSourceNetworkStack service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/AssociateSourceNetworkStack">REST API Reference for AssociateSourceNetworkStack Operation</seealso>
        Task<AssociateSourceNetworkStackResponse> AssociateSourceNetworkStackAsync(AssociateSourceNetworkStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateExtendedSourceServer


        /// <summary>
        /// Create an extended source server in the target Account based on the source server
        /// in staging account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExtendedSourceServer service method.</param>
        /// 
        /// <returns>The response from the CreateExtendedSourceServer service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/CreateExtendedSourceServer">REST API Reference for CreateExtendedSourceServer Operation</seealso>
        CreateExtendedSourceServerResponse CreateExtendedSourceServer(CreateExtendedSourceServerRequest request);



        /// <summary>
        /// Create an extended source server in the target Account based on the source server
        /// in staging account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExtendedSourceServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateExtendedSourceServer service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/CreateExtendedSourceServer">REST API Reference for CreateExtendedSourceServer Operation</seealso>
        Task<CreateExtendedSourceServerResponse> CreateExtendedSourceServerAsync(CreateExtendedSourceServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLaunchConfigurationTemplate


        /// <summary>
        /// Creates a new Launch Configuration Template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateLaunchConfigurationTemplate service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/CreateLaunchConfigurationTemplate">REST API Reference for CreateLaunchConfigurationTemplate Operation</seealso>
        CreateLaunchConfigurationTemplateResponse CreateLaunchConfigurationTemplate(CreateLaunchConfigurationTemplateRequest request);



        /// <summary>
        /// Creates a new Launch Configuration Template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchConfigurationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLaunchConfigurationTemplate service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/CreateLaunchConfigurationTemplate">REST API Reference for CreateLaunchConfigurationTemplate Operation</seealso>
        Task<CreateLaunchConfigurationTemplateResponse> CreateLaunchConfigurationTemplateAsync(CreateLaunchConfigurationTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateReplicationConfigurationTemplate


        /// <summary>
        /// Creates a new ReplicationConfigurationTemplate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationConfigurationTemplate service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/CreateReplicationConfigurationTemplate">REST API Reference for CreateReplicationConfigurationTemplate Operation</seealso>
        CreateReplicationConfigurationTemplateResponse CreateReplicationConfigurationTemplate(CreateReplicationConfigurationTemplateRequest request);



        /// <summary>
        /// Creates a new ReplicationConfigurationTemplate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationConfigurationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateReplicationConfigurationTemplate service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/CreateReplicationConfigurationTemplate">REST API Reference for CreateReplicationConfigurationTemplate Operation</seealso>
        Task<CreateReplicationConfigurationTemplateResponse> CreateReplicationConfigurationTemplateAsync(CreateReplicationConfigurationTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSourceNetwork


        /// <summary>
        /// Create a new Source Network resource for a provided VPC ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSourceNetwork service method.</param>
        /// 
        /// <returns>The response from the CreateSourceNetwork service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/CreateSourceNetwork">REST API Reference for CreateSourceNetwork Operation</seealso>
        CreateSourceNetworkResponse CreateSourceNetwork(CreateSourceNetworkRequest request);



        /// <summary>
        /// Create a new Source Network resource for a provided VPC ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSourceNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSourceNetwork service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/CreateSourceNetwork">REST API Reference for CreateSourceNetwork Operation</seealso>
        Task<CreateSourceNetworkResponse> CreateSourceNetworkAsync(CreateSourceNetworkRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteJob


        /// <summary>
        /// Deletes a single Job by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob service method.</param>
        /// 
        /// <returns>The response from the DeleteJob service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        DeleteJobResponse DeleteJob(DeleteJobRequest request);



        /// <summary>
        /// Deletes a single Job by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteJob service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLaunchAction


        /// <summary>
        /// Deletes a resource launch action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchAction service method.</param>
        /// 
        /// <returns>The response from the DeleteLaunchAction service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DeleteLaunchAction">REST API Reference for DeleteLaunchAction Operation</seealso>
        DeleteLaunchActionResponse DeleteLaunchAction(DeleteLaunchActionRequest request);



        /// <summary>
        /// Deletes a resource launch action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLaunchAction service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DeleteLaunchAction">REST API Reference for DeleteLaunchAction Operation</seealso>
        Task<DeleteLaunchActionResponse> DeleteLaunchActionAsync(DeleteLaunchActionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLaunchConfigurationTemplate


        /// <summary>
        /// Deletes a single Launch Configuration Template by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteLaunchConfigurationTemplate service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DeleteLaunchConfigurationTemplate">REST API Reference for DeleteLaunchConfigurationTemplate Operation</seealso>
        DeleteLaunchConfigurationTemplateResponse DeleteLaunchConfigurationTemplate(DeleteLaunchConfigurationTemplateRequest request);



        /// <summary>
        /// Deletes a single Launch Configuration Template by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchConfigurationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLaunchConfigurationTemplate service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DeleteLaunchConfigurationTemplate">REST API Reference for DeleteLaunchConfigurationTemplate Operation</seealso>
        Task<DeleteLaunchConfigurationTemplateResponse> DeleteLaunchConfigurationTemplateAsync(DeleteLaunchConfigurationTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRecoveryInstance


        /// <summary>
        /// Deletes a single Recovery Instance by ID. This deletes the Recovery Instance resource
        /// from Elastic Disaster Recovery. The Recovery Instance must be disconnected first in
        /// order to delete it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecoveryInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteRecoveryInstance service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DeleteRecoveryInstance">REST API Reference for DeleteRecoveryInstance Operation</seealso>
        DeleteRecoveryInstanceResponse DeleteRecoveryInstance(DeleteRecoveryInstanceRequest request);



        /// <summary>
        /// Deletes a single Recovery Instance by ID. This deletes the Recovery Instance resource
        /// from Elastic Disaster Recovery. The Recovery Instance must be disconnected first in
        /// order to delete it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecoveryInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRecoveryInstance service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DeleteRecoveryInstance">REST API Reference for DeleteRecoveryInstance Operation</seealso>
        Task<DeleteRecoveryInstanceResponse> DeleteRecoveryInstanceAsync(DeleteRecoveryInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteReplicationConfigurationTemplate


        /// <summary>
        /// Deletes a single Replication Configuration Template by ID
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicationConfigurationTemplate service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DeleteReplicationConfigurationTemplate">REST API Reference for DeleteReplicationConfigurationTemplate Operation</seealso>
        DeleteReplicationConfigurationTemplateResponse DeleteReplicationConfigurationTemplate(DeleteReplicationConfigurationTemplateRequest request);



        /// <summary>
        /// Deletes a single Replication Configuration Template by ID
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationConfigurationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteReplicationConfigurationTemplate service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DeleteReplicationConfigurationTemplate">REST API Reference for DeleteReplicationConfigurationTemplate Operation</seealso>
        Task<DeleteReplicationConfigurationTemplateResponse> DeleteReplicationConfigurationTemplateAsync(DeleteReplicationConfigurationTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSourceNetwork


        /// <summary>
        /// Delete Source Network resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceNetwork service method.</param>
        /// 
        /// <returns>The response from the DeleteSourceNetwork service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DeleteSourceNetwork">REST API Reference for DeleteSourceNetwork Operation</seealso>
        DeleteSourceNetworkResponse DeleteSourceNetwork(DeleteSourceNetworkRequest request);



        /// <summary>
        /// Delete Source Network resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSourceNetwork service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DeleteSourceNetwork">REST API Reference for DeleteSourceNetwork Operation</seealso>
        Task<DeleteSourceNetworkResponse> DeleteSourceNetworkAsync(DeleteSourceNetworkRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSourceServer


        /// <summary>
        /// Deletes a single Source Server by ID. The Source Server must be disconnected first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceServer service method.</param>
        /// 
        /// <returns>The response from the DeleteSourceServer service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DeleteSourceServer">REST API Reference for DeleteSourceServer Operation</seealso>
        DeleteSourceServerResponse DeleteSourceServer(DeleteSourceServerRequest request);



        /// <summary>
        /// Deletes a single Source Server by ID. The Source Server must be disconnected first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSourceServer service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DeleteSourceServer">REST API Reference for DeleteSourceServer Operation</seealso>
        Task<DeleteSourceServerResponse> DeleteSourceServerAsync(DeleteSourceServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeJobLogItems


        /// <summary>
        /// Retrieves a detailed Job log with pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobLogItems service method.</param>
        /// 
        /// <returns>The response from the DescribeJobLogItems service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeJobLogItems">REST API Reference for DescribeJobLogItems Operation</seealso>
        DescribeJobLogItemsResponse DescribeJobLogItems(DescribeJobLogItemsRequest request);



        /// <summary>
        /// Retrieves a detailed Job log with pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobLogItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJobLogItems service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeJobLogItems">REST API Reference for DescribeJobLogItems Operation</seealso>
        Task<DescribeJobLogItemsResponse> DescribeJobLogItemsAsync(DescribeJobLogItemsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeJobs


        /// <summary>
        /// Returns a list of Jobs. Use the JobsID and fromDate and toDate filters to limit which
        /// jobs are returned. The response is sorted by creationDataTime - latest date first.
        /// Jobs are created by the StartRecovery, TerminateRecoveryInstances and StartFailbackLaunch
        /// APIs. Jobs are also created by DiagnosticLaunch and TerminateDiagnosticInstances,
        /// which are APIs available only to *Support* and only used in response to relevant support
        /// tickets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobs service method.</param>
        /// 
        /// <returns>The response from the DescribeJobs service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeJobs">REST API Reference for DescribeJobs Operation</seealso>
        DescribeJobsResponse DescribeJobs(DescribeJobsRequest request);



        /// <summary>
        /// Returns a list of Jobs. Use the JobsID and fromDate and toDate filters to limit which
        /// jobs are returned. The response is sorted by creationDataTime - latest date first.
        /// Jobs are created by the StartRecovery, TerminateRecoveryInstances and StartFailbackLaunch
        /// APIs. Jobs are also created by DiagnosticLaunch and TerminateDiagnosticInstances,
        /// which are APIs available only to *Support* and only used in response to relevant support
        /// tickets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJobs service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeJobs">REST API Reference for DescribeJobs Operation</seealso>
        Task<DescribeJobsResponse> DescribeJobsAsync(DescribeJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLaunchConfigurationTemplates


        /// <summary>
        /// Lists all Launch Configuration Templates, filtered by Launch Configuration Template
        /// IDs
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchConfigurationTemplates service method.</param>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurationTemplates service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeLaunchConfigurationTemplates">REST API Reference for DescribeLaunchConfigurationTemplates Operation</seealso>
        DescribeLaunchConfigurationTemplatesResponse DescribeLaunchConfigurationTemplates(DescribeLaunchConfigurationTemplatesRequest request);



        /// <summary>
        /// Lists all Launch Configuration Templates, filtered by Launch Configuration Template
        /// IDs
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchConfigurationTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurationTemplates service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeLaunchConfigurationTemplates">REST API Reference for DescribeLaunchConfigurationTemplates Operation</seealso>
        Task<DescribeLaunchConfigurationTemplatesResponse> DescribeLaunchConfigurationTemplatesAsync(DescribeLaunchConfigurationTemplatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRecoveryInstances


        /// <summary>
        /// Lists all Recovery Instances or multiple Recovery Instances by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecoveryInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeRecoveryInstances service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeRecoveryInstances">REST API Reference for DescribeRecoveryInstances Operation</seealso>
        DescribeRecoveryInstancesResponse DescribeRecoveryInstances(DescribeRecoveryInstancesRequest request);



        /// <summary>
        /// Lists all Recovery Instances or multiple Recovery Instances by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecoveryInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRecoveryInstances service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeRecoveryInstances">REST API Reference for DescribeRecoveryInstances Operation</seealso>
        Task<DescribeRecoveryInstancesResponse> DescribeRecoveryInstancesAsync(DescribeRecoveryInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRecoverySnapshots


        /// <summary>
        /// Lists all Recovery Snapshots for a single Source Server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecoverySnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeRecoverySnapshots service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeRecoverySnapshots">REST API Reference for DescribeRecoverySnapshots Operation</seealso>
        DescribeRecoverySnapshotsResponse DescribeRecoverySnapshots(DescribeRecoverySnapshotsRequest request);



        /// <summary>
        /// Lists all Recovery Snapshots for a single Source Server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecoverySnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRecoverySnapshots service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeRecoverySnapshots">REST API Reference for DescribeRecoverySnapshots Operation</seealso>
        Task<DescribeRecoverySnapshotsResponse> DescribeRecoverySnapshotsAsync(DescribeRecoverySnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeReplicationConfigurationTemplates


        /// <summary>
        /// Lists all ReplicationConfigurationTemplates, filtered by Source Server IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationConfigurationTemplates service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationConfigurationTemplates service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeReplicationConfigurationTemplates">REST API Reference for DescribeReplicationConfigurationTemplates Operation</seealso>
        DescribeReplicationConfigurationTemplatesResponse DescribeReplicationConfigurationTemplates(DescribeReplicationConfigurationTemplatesRequest request);



        /// <summary>
        /// Lists all ReplicationConfigurationTemplates, filtered by Source Server IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationConfigurationTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReplicationConfigurationTemplates service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeReplicationConfigurationTemplates">REST API Reference for DescribeReplicationConfigurationTemplates Operation</seealso>
        Task<DescribeReplicationConfigurationTemplatesResponse> DescribeReplicationConfigurationTemplatesAsync(DescribeReplicationConfigurationTemplatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSourceNetworks


        /// <summary>
        /// Lists all Source Networks or multiple Source Networks filtered by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceNetworks service method.</param>
        /// 
        /// <returns>The response from the DescribeSourceNetworks service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeSourceNetworks">REST API Reference for DescribeSourceNetworks Operation</seealso>
        DescribeSourceNetworksResponse DescribeSourceNetworks(DescribeSourceNetworksRequest request);



        /// <summary>
        /// Lists all Source Networks or multiple Source Networks filtered by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceNetworks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSourceNetworks service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeSourceNetworks">REST API Reference for DescribeSourceNetworks Operation</seealso>
        Task<DescribeSourceNetworksResponse> DescribeSourceNetworksAsync(DescribeSourceNetworksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSourceServers


        /// <summary>
        /// Lists all Source Servers or multiple Source Servers filtered by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceServers service method.</param>
        /// 
        /// <returns>The response from the DescribeSourceServers service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeSourceServers">REST API Reference for DescribeSourceServers Operation</seealso>
        DescribeSourceServersResponse DescribeSourceServers(DescribeSourceServersRequest request);



        /// <summary>
        /// Lists all Source Servers or multiple Source Servers filtered by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceServers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSourceServers service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DescribeSourceServers">REST API Reference for DescribeSourceServers Operation</seealso>
        Task<DescribeSourceServersResponse> DescribeSourceServersAsync(DescribeSourceServersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisconnectRecoveryInstance


        /// <summary>
        /// Disconnect a Recovery Instance from Elastic Disaster Recovery. Data replication is
        /// stopped immediately. All AWS resources created by Elastic Disaster Recovery for enabling
        /// the replication of the Recovery Instance will be terminated / deleted within 90 minutes.
        /// If the agent on the Recovery Instance has not been prevented from communicating with
        /// the Elastic Disaster Recovery service, then it will receive a command to uninstall
        /// itself (within approximately 10 minutes). The following properties of the Recovery
        /// Instance will be changed immediately: dataReplicationInfo.dataReplicationState will
        /// be set to DISCONNECTED; The totalStorageBytes property for each of dataReplicationInfo.replicatedDisks
        /// will be set to zero; dataReplicationInfo.lagDuration and dataReplicationInfo.lagDuration
        /// will be nullified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectRecoveryInstance service method.</param>
        /// 
        /// <returns>The response from the DisconnectRecoveryInstance service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DisconnectRecoveryInstance">REST API Reference for DisconnectRecoveryInstance Operation</seealso>
        DisconnectRecoveryInstanceResponse DisconnectRecoveryInstance(DisconnectRecoveryInstanceRequest request);



        /// <summary>
        /// Disconnect a Recovery Instance from Elastic Disaster Recovery. Data replication is
        /// stopped immediately. All AWS resources created by Elastic Disaster Recovery for enabling
        /// the replication of the Recovery Instance will be terminated / deleted within 90 minutes.
        /// If the agent on the Recovery Instance has not been prevented from communicating with
        /// the Elastic Disaster Recovery service, then it will receive a command to uninstall
        /// itself (within approximately 10 minutes). The following properties of the Recovery
        /// Instance will be changed immediately: dataReplicationInfo.dataReplicationState will
        /// be set to DISCONNECTED; The totalStorageBytes property for each of dataReplicationInfo.replicatedDisks
        /// will be set to zero; dataReplicationInfo.lagDuration and dataReplicationInfo.lagDuration
        /// will be nullified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectRecoveryInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisconnectRecoveryInstance service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DisconnectRecoveryInstance">REST API Reference for DisconnectRecoveryInstance Operation</seealso>
        Task<DisconnectRecoveryInstanceResponse> DisconnectRecoveryInstanceAsync(DisconnectRecoveryInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisconnectSourceServer


        /// <summary>
        /// Disconnects a specific Source Server from Elastic Disaster Recovery. Data replication
        /// is stopped immediately. All AWS resources created by Elastic Disaster Recovery for
        /// enabling the replication of the Source Server will be terminated / deleted within
        /// 90 minutes. You cannot disconnect a Source Server if it has a Recovery Instance. If
        /// the agent on the Source Server has not been prevented from communicating with the
        /// Elastic Disaster Recovery service, then it will receive a command to uninstall itself
        /// (within approximately 10 minutes). The following properties of the SourceServer will
        /// be changed immediately: dataReplicationInfo.dataReplicationState will be set to DISCONNECTED;
        /// The totalStorageBytes property for each of dataReplicationInfo.replicatedDisks will
        /// be set to zero; dataReplicationInfo.lagDuration and dataReplicationInfo.lagDuration
        /// will be nullified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectSourceServer service method.</param>
        /// 
        /// <returns>The response from the DisconnectSourceServer service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DisconnectSourceServer">REST API Reference for DisconnectSourceServer Operation</seealso>
        DisconnectSourceServerResponse DisconnectSourceServer(DisconnectSourceServerRequest request);



        /// <summary>
        /// Disconnects a specific Source Server from Elastic Disaster Recovery. Data replication
        /// is stopped immediately. All AWS resources created by Elastic Disaster Recovery for
        /// enabling the replication of the Source Server will be terminated / deleted within
        /// 90 minutes. You cannot disconnect a Source Server if it has a Recovery Instance. If
        /// the agent on the Source Server has not been prevented from communicating with the
        /// Elastic Disaster Recovery service, then it will receive a command to uninstall itself
        /// (within approximately 10 minutes). The following properties of the SourceServer will
        /// be changed immediately: dataReplicationInfo.dataReplicationState will be set to DISCONNECTED;
        /// The totalStorageBytes property for each of dataReplicationInfo.replicatedDisks will
        /// be set to zero; dataReplicationInfo.lagDuration and dataReplicationInfo.lagDuration
        /// will be nullified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectSourceServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisconnectSourceServer service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/DisconnectSourceServer">REST API Reference for DisconnectSourceServer Operation</seealso>
        Task<DisconnectSourceServerResponse> DisconnectSourceServerAsync(DisconnectSourceServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ExportSourceNetworkCfnTemplate


        /// <summary>
        /// Export the Source Network CloudFormation template to an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportSourceNetworkCfnTemplate service method.</param>
        /// 
        /// <returns>The response from the ExportSourceNetworkCfnTemplate service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/ExportSourceNetworkCfnTemplate">REST API Reference for ExportSourceNetworkCfnTemplate Operation</seealso>
        ExportSourceNetworkCfnTemplateResponse ExportSourceNetworkCfnTemplate(ExportSourceNetworkCfnTemplateRequest request);



        /// <summary>
        /// Export the Source Network CloudFormation template to an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportSourceNetworkCfnTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportSourceNetworkCfnTemplate service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/ExportSourceNetworkCfnTemplate">REST API Reference for ExportSourceNetworkCfnTemplate Operation</seealso>
        Task<ExportSourceNetworkCfnTemplateResponse> ExportSourceNetworkCfnTemplateAsync(ExportSourceNetworkCfnTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFailbackReplicationConfiguration


        /// <summary>
        /// Lists all Failback ReplicationConfigurations, filtered by Recovery Instance ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFailbackReplicationConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetFailbackReplicationConfiguration service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/GetFailbackReplicationConfiguration">REST API Reference for GetFailbackReplicationConfiguration Operation</seealso>
        GetFailbackReplicationConfigurationResponse GetFailbackReplicationConfiguration(GetFailbackReplicationConfigurationRequest request);



        /// <summary>
        /// Lists all Failback ReplicationConfigurations, filtered by Recovery Instance ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFailbackReplicationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFailbackReplicationConfiguration service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/GetFailbackReplicationConfiguration">REST API Reference for GetFailbackReplicationConfiguration Operation</seealso>
        Task<GetFailbackReplicationConfigurationResponse> GetFailbackReplicationConfigurationAsync(GetFailbackReplicationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLaunchConfiguration


        /// <summary>
        /// Gets a LaunchConfiguration, filtered by Source Server IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetLaunchConfiguration service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/GetLaunchConfiguration">REST API Reference for GetLaunchConfiguration Operation</seealso>
        GetLaunchConfigurationResponse GetLaunchConfiguration(GetLaunchConfigurationRequest request);



        /// <summary>
        /// Gets a LaunchConfiguration, filtered by Source Server IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLaunchConfiguration service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/GetLaunchConfiguration">REST API Reference for GetLaunchConfiguration Operation</seealso>
        Task<GetLaunchConfigurationResponse> GetLaunchConfigurationAsync(GetLaunchConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetReplicationConfiguration


        /// <summary>
        /// Gets a ReplicationConfiguration, filtered by Source Server ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetReplicationConfiguration service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/GetReplicationConfiguration">REST API Reference for GetReplicationConfiguration Operation</seealso>
        GetReplicationConfigurationResponse GetReplicationConfiguration(GetReplicationConfigurationRequest request);



        /// <summary>
        /// Gets a ReplicationConfiguration, filtered by Source Server ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReplicationConfiguration service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/GetReplicationConfiguration">REST API Reference for GetReplicationConfiguration Operation</seealso>
        Task<GetReplicationConfigurationResponse> GetReplicationConfigurationAsync(GetReplicationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  InitializeService


        /// <summary>
        /// Initialize Elastic Disaster Recovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitializeService service method.</param>
        /// 
        /// <returns>The response from the InitializeService service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/InitializeService">REST API Reference for InitializeService Operation</seealso>
        InitializeServiceResponse InitializeService(InitializeServiceRequest request);



        /// <summary>
        /// Initialize Elastic Disaster Recovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitializeService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InitializeService service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/InitializeService">REST API Reference for InitializeService Operation</seealso>
        Task<InitializeServiceResponse> InitializeServiceAsync(InitializeServiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListExtensibleSourceServers


        /// <summary>
        /// Returns a list of source servers on a staging account that are extensible, which means
        /// that: a. The source server is not already extended into this Account. b. The source
        /// server on the Account we’re reading from is not an extension of another source server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExtensibleSourceServers service method.</param>
        /// 
        /// <returns>The response from the ListExtensibleSourceServers service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/ListExtensibleSourceServers">REST API Reference for ListExtensibleSourceServers Operation</seealso>
        ListExtensibleSourceServersResponse ListExtensibleSourceServers(ListExtensibleSourceServersRequest request);



        /// <summary>
        /// Returns a list of source servers on a staging account that are extensible, which means
        /// that: a. The source server is not already extended into this Account. b. The source
        /// server on the Account we’re reading from is not an extension of another source server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExtensibleSourceServers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExtensibleSourceServers service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/ListExtensibleSourceServers">REST API Reference for ListExtensibleSourceServers Operation</seealso>
        Task<ListExtensibleSourceServersResponse> ListExtensibleSourceServersAsync(ListExtensibleSourceServersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLaunchActions


        /// <summary>
        /// Lists resource launch actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLaunchActions service method.</param>
        /// 
        /// <returns>The response from the ListLaunchActions service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/ListLaunchActions">REST API Reference for ListLaunchActions Operation</seealso>
        ListLaunchActionsResponse ListLaunchActions(ListLaunchActionsRequest request);



        /// <summary>
        /// Lists resource launch actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLaunchActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLaunchActions service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/ListLaunchActions">REST API Reference for ListLaunchActions Operation</seealso>
        Task<ListLaunchActionsResponse> ListLaunchActionsAsync(ListLaunchActionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListStagingAccounts


        /// <summary>
        /// Returns an array of staging accounts for existing extended source servers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStagingAccounts service method.</param>
        /// 
        /// <returns>The response from the ListStagingAccounts service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/ListStagingAccounts">REST API Reference for ListStagingAccounts Operation</seealso>
        ListStagingAccountsResponse ListStagingAccounts(ListStagingAccountsRequest request);



        /// <summary>
        /// Returns an array of staging accounts for existing extended source servers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStagingAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStagingAccounts service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/ListStagingAccounts">REST API Reference for ListStagingAccounts Operation</seealso>
        Task<ListStagingAccountsResponse> ListStagingAccountsAsync(ListStagingAccountsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List all tags for your Elastic Disaster Recovery resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// List all tags for your Elastic Disaster Recovery resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutLaunchAction


        /// <summary>
        /// Puts a resource launch action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLaunchAction service method.</param>
        /// 
        /// <returns>The response from the PutLaunchAction service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/PutLaunchAction">REST API Reference for PutLaunchAction Operation</seealso>
        PutLaunchActionResponse PutLaunchAction(PutLaunchActionRequest request);



        /// <summary>
        /// Puts a resource launch action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLaunchAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutLaunchAction service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/PutLaunchAction">REST API Reference for PutLaunchAction Operation</seealso>
        Task<PutLaunchActionResponse> PutLaunchActionAsync(PutLaunchActionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RetryDataReplication


        /// <summary>
        /// WARNING: RetryDataReplication is deprecated. Causes the data replication initiation
        /// sequence to begin immediately upon next Handshake for the specified Source Server
        /// ID, regardless of when the previous initiation started. This command will work only
        /// if the Source Server is stalled or is in a DISCONNECTED or STOPPED state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryDataReplication service method.</param>
        /// 
        /// <returns>The response from the RetryDataReplication service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/RetryDataReplication">REST API Reference for RetryDataReplication Operation</seealso>
        [Obsolete("WARNING: RetryDataReplication is deprecated")]
        RetryDataReplicationResponse RetryDataReplication(RetryDataReplicationRequest request);



        /// <summary>
        /// WARNING: RetryDataReplication is deprecated. Causes the data replication initiation
        /// sequence to begin immediately upon next Handshake for the specified Source Server
        /// ID, regardless of when the previous initiation started. This command will work only
        /// if the Source Server is stalled or is in a DISCONNECTED or STOPPED state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryDataReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetryDataReplication service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/RetryDataReplication">REST API Reference for RetryDataReplication Operation</seealso>
        [Obsolete("WARNING: RetryDataReplication is deprecated")]
        Task<RetryDataReplicationResponse> RetryDataReplicationAsync(RetryDataReplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ReverseReplication


        /// <summary>
        /// Start replication to origin / target region - applies only to protected instances
        /// that originated in EC2. For recovery instances on target region - starts replication
        /// back to origin region. For failback instances on origin region - starts replication
        /// to target region to re-protect them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReverseReplication service method.</param>
        /// 
        /// <returns>The response from the ReverseReplication service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/ReverseReplication">REST API Reference for ReverseReplication Operation</seealso>
        ReverseReplicationResponse ReverseReplication(ReverseReplicationRequest request);



        /// <summary>
        /// Start replication to origin / target region - applies only to protected instances
        /// that originated in EC2. For recovery instances on target region - starts replication
        /// back to origin region. For failback instances on origin region - starts replication
        /// to target region to re-protect them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReverseReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReverseReplication service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/ReverseReplication">REST API Reference for ReverseReplication Operation</seealso>
        Task<ReverseReplicationResponse> ReverseReplicationAsync(ReverseReplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartFailbackLaunch


        /// <summary>
        /// Initiates a Job for launching the machine that is being failed back to from the specified
        /// Recovery Instance. This will run conversion on the failback client and will reboot
        /// your machine, thus completing the failback process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFailbackLaunch service method.</param>
        /// 
        /// <returns>The response from the StartFailbackLaunch service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StartFailbackLaunch">REST API Reference for StartFailbackLaunch Operation</seealso>
        StartFailbackLaunchResponse StartFailbackLaunch(StartFailbackLaunchRequest request);



        /// <summary>
        /// Initiates a Job for launching the machine that is being failed back to from the specified
        /// Recovery Instance. This will run conversion on the failback client and will reboot
        /// your machine, thus completing the failback process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFailbackLaunch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartFailbackLaunch service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StartFailbackLaunch">REST API Reference for StartFailbackLaunch Operation</seealso>
        Task<StartFailbackLaunchResponse> StartFailbackLaunchAsync(StartFailbackLaunchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartRecovery


        /// <summary>
        /// Launches Recovery Instances for the specified Source Servers. For each Source Server
        /// you may choose a point in time snapshot to launch from, or use an on demand snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRecovery service method.</param>
        /// 
        /// <returns>The response from the StartRecovery service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StartRecovery">REST API Reference for StartRecovery Operation</seealso>
        StartRecoveryResponse StartRecovery(StartRecoveryRequest request);



        /// <summary>
        /// Launches Recovery Instances for the specified Source Servers. For each Source Server
        /// you may choose a point in time snapshot to launch from, or use an on demand snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRecovery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartRecovery service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StartRecovery">REST API Reference for StartRecovery Operation</seealso>
        Task<StartRecoveryResponse> StartRecoveryAsync(StartRecoveryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartReplication


        /// <summary>
        /// Starts replication for a stopped Source Server. This action would make the Source
        /// Server protected again and restart billing for it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReplication service method.</param>
        /// 
        /// <returns>The response from the StartReplication service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StartReplication">REST API Reference for StartReplication Operation</seealso>
        StartReplicationResponse StartReplication(StartReplicationRequest request);



        /// <summary>
        /// Starts replication for a stopped Source Server. This action would make the Source
        /// Server protected again and restart billing for it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartReplication service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StartReplication">REST API Reference for StartReplication Operation</seealso>
        Task<StartReplicationResponse> StartReplicationAsync(StartReplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartSourceNetworkRecovery


        /// <summary>
        /// Deploy VPC for the specified Source Network and modify launch templates to use this
        /// network. The VPC will be deployed using a dedicated CloudFormation stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSourceNetworkRecovery service method.</param>
        /// 
        /// <returns>The response from the StartSourceNetworkRecovery service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StartSourceNetworkRecovery">REST API Reference for StartSourceNetworkRecovery Operation</seealso>
        StartSourceNetworkRecoveryResponse StartSourceNetworkRecovery(StartSourceNetworkRecoveryRequest request);



        /// <summary>
        /// Deploy VPC for the specified Source Network and modify launch templates to use this
        /// network. The VPC will be deployed using a dedicated CloudFormation stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSourceNetworkRecovery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSourceNetworkRecovery service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StartSourceNetworkRecovery">REST API Reference for StartSourceNetworkRecovery Operation</seealso>
        Task<StartSourceNetworkRecoveryResponse> StartSourceNetworkRecoveryAsync(StartSourceNetworkRecoveryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartSourceNetworkReplication


        /// <summary>
        /// Starts replication for a Source Network. This action would make the Source Network
        /// protected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSourceNetworkReplication service method.</param>
        /// 
        /// <returns>The response from the StartSourceNetworkReplication service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StartSourceNetworkReplication">REST API Reference for StartSourceNetworkReplication Operation</seealso>
        StartSourceNetworkReplicationResponse StartSourceNetworkReplication(StartSourceNetworkReplicationRequest request);



        /// <summary>
        /// Starts replication for a Source Network. This action would make the Source Network
        /// protected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSourceNetworkReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSourceNetworkReplication service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StartSourceNetworkReplication">REST API Reference for StartSourceNetworkReplication Operation</seealso>
        Task<StartSourceNetworkReplicationResponse> StartSourceNetworkReplicationAsync(StartSourceNetworkReplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopFailback


        /// <summary>
        /// Stops the failback process for a specified Recovery Instance. This changes the Failback
        /// State of the Recovery Instance back to FAILBACK_NOT_STARTED.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopFailback service method.</param>
        /// 
        /// <returns>The response from the StopFailback service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StopFailback">REST API Reference for StopFailback Operation</seealso>
        StopFailbackResponse StopFailback(StopFailbackRequest request);



        /// <summary>
        /// Stops the failback process for a specified Recovery Instance. This changes the Failback
        /// State of the Recovery Instance back to FAILBACK_NOT_STARTED.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopFailback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopFailback service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StopFailback">REST API Reference for StopFailback Operation</seealso>
        Task<StopFailbackResponse> StopFailbackAsync(StopFailbackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopReplication


        /// <summary>
        /// Stops replication for a Source Server. This action would make the Source Server unprotected,
        /// delete its existing snapshots and stop billing for it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopReplication service method.</param>
        /// 
        /// <returns>The response from the StopReplication service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StopReplication">REST API Reference for StopReplication Operation</seealso>
        StopReplicationResponse StopReplication(StopReplicationRequest request);



        /// <summary>
        /// Stops replication for a Source Server. This action would make the Source Server unprotected,
        /// delete its existing snapshots and stop billing for it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopReplication service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StopReplication">REST API Reference for StopReplication Operation</seealso>
        Task<StopReplicationResponse> StopReplicationAsync(StopReplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopSourceNetworkReplication


        /// <summary>
        /// Stops replication for a Source Network. This action would make the Source Network
        /// unprotected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopSourceNetworkReplication service method.</param>
        /// 
        /// <returns>The response from the StopSourceNetworkReplication service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StopSourceNetworkReplication">REST API Reference for StopSourceNetworkReplication Operation</seealso>
        StopSourceNetworkReplicationResponse StopSourceNetworkReplication(StopSourceNetworkReplicationRequest request);



        /// <summary>
        /// Stops replication for a Source Network. This action would make the Source Network
        /// unprotected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopSourceNetworkReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopSourceNetworkReplication service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/StopSourceNetworkReplication">REST API Reference for StopSourceNetworkReplication Operation</seealso>
        Task<StopSourceNetworkReplicationResponse> StopSourceNetworkReplicationAsync(StopSourceNetworkReplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or overwrites only the specified tags for the specified Elastic Disaster Recovery
        /// resource or resources. When you specify an existing tag key, the value is overwritten
        /// with the new value. Each resource can have a maximum of 50 tags. Each tag consists
        /// of a key and optional value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds or overwrites only the specified tags for the specified Elastic Disaster Recovery
        /// resource or resources. When you specify an existing tag key, the value is overwritten
        /// with the new value. Each resource can have a maximum of 50 tags. Each tag consists
        /// of a key and optional value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TerminateRecoveryInstances


        /// <summary>
        /// Initiates a Job for terminating the EC2 resources associated with the specified Recovery
        /// Instances, and then will delete the Recovery Instances from the Elastic Disaster Recovery
        /// service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateRecoveryInstances service method.</param>
        /// 
        /// <returns>The response from the TerminateRecoveryInstances service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/TerminateRecoveryInstances">REST API Reference for TerminateRecoveryInstances Operation</seealso>
        TerminateRecoveryInstancesResponse TerminateRecoveryInstances(TerminateRecoveryInstancesRequest request);



        /// <summary>
        /// Initiates a Job for terminating the EC2 resources associated with the specified Recovery
        /// Instances, and then will delete the Recovery Instances from the Elastic Disaster Recovery
        /// service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateRecoveryInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateRecoveryInstances service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/TerminateRecoveryInstances">REST API Reference for TerminateRecoveryInstances Operation</seealso>
        Task<TerminateRecoveryInstancesResponse> TerminateRecoveryInstancesAsync(TerminateRecoveryInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Deletes the specified set of tags from the specified set of Elastic Disaster Recovery
        /// resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Deletes the specified set of tags from the specified set of Elastic Disaster Recovery
        /// resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFailbackReplicationConfiguration


        /// <summary>
        /// Allows you to update the failback replication configuration of a Recovery Instance
        /// by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFailbackReplicationConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateFailbackReplicationConfiguration service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UpdateFailbackReplicationConfiguration">REST API Reference for UpdateFailbackReplicationConfiguration Operation</seealso>
        UpdateFailbackReplicationConfigurationResponse UpdateFailbackReplicationConfiguration(UpdateFailbackReplicationConfigurationRequest request);



        /// <summary>
        /// Allows you to update the failback replication configuration of a Recovery Instance
        /// by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFailbackReplicationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFailbackReplicationConfiguration service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UpdateFailbackReplicationConfiguration">REST API Reference for UpdateFailbackReplicationConfiguration Operation</seealso>
        Task<UpdateFailbackReplicationConfigurationResponse> UpdateFailbackReplicationConfigurationAsync(UpdateFailbackReplicationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLaunchConfiguration


        /// <summary>
        /// Updates a LaunchConfiguration by Source Server ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateLaunchConfiguration service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UpdateLaunchConfiguration">REST API Reference for UpdateLaunchConfiguration Operation</seealso>
        UpdateLaunchConfigurationResponse UpdateLaunchConfiguration(UpdateLaunchConfigurationRequest request);



        /// <summary>
        /// Updates a LaunchConfiguration by Source Server ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLaunchConfiguration service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UpdateLaunchConfiguration">REST API Reference for UpdateLaunchConfiguration Operation</seealso>
        Task<UpdateLaunchConfigurationResponse> UpdateLaunchConfigurationAsync(UpdateLaunchConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLaunchConfigurationTemplate


        /// <summary>
        /// Updates an existing Launch Configuration Template by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateLaunchConfigurationTemplate service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UpdateLaunchConfigurationTemplate">REST API Reference for UpdateLaunchConfigurationTemplate Operation</seealso>
        UpdateLaunchConfigurationTemplateResponse UpdateLaunchConfigurationTemplate(UpdateLaunchConfigurationTemplateRequest request);



        /// <summary>
        /// Updates an existing Launch Configuration Template by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchConfigurationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLaunchConfigurationTemplate service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UpdateLaunchConfigurationTemplate">REST API Reference for UpdateLaunchConfigurationTemplate Operation</seealso>
        Task<UpdateLaunchConfigurationTemplateResponse> UpdateLaunchConfigurationTemplateAsync(UpdateLaunchConfigurationTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateReplicationConfiguration


        /// <summary>
        /// Allows you to update a ReplicationConfiguration by Source Server ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateReplicationConfiguration service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UpdateReplicationConfiguration">REST API Reference for UpdateReplicationConfiguration Operation</seealso>
        UpdateReplicationConfigurationResponse UpdateReplicationConfiguration(UpdateReplicationConfigurationRequest request);



        /// <summary>
        /// Allows you to update a ReplicationConfiguration by Source Server ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateReplicationConfiguration service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UpdateReplicationConfiguration">REST API Reference for UpdateReplicationConfiguration Operation</seealso>
        Task<UpdateReplicationConfigurationResponse> UpdateReplicationConfigurationAsync(UpdateReplicationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateReplicationConfigurationTemplate


        /// <summary>
        /// Updates a ReplicationConfigurationTemplate by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateReplicationConfigurationTemplate service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UpdateReplicationConfigurationTemplate">REST API Reference for UpdateReplicationConfigurationTemplate Operation</seealso>
        UpdateReplicationConfigurationTemplateResponse UpdateReplicationConfigurationTemplate(UpdateReplicationConfigurationTemplateRequest request);



        /// <summary>
        /// Updates a ReplicationConfigurationTemplate by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationConfigurationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateReplicationConfigurationTemplate service method, as returned by Drs.</returns>
        /// <exception cref="Amazon.Drs.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ResourceNotFoundException">
        /// The resource for this operation was not found.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.UninitializedAccountException">
        /// The account performing the request has not been initialized.
        /// </exception>
        /// <exception cref="Amazon.Drs.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/drs-2020-02-26/UpdateReplicationConfigurationTemplate">REST API Reference for UpdateReplicationConfigurationTemplate Operation</seealso>
        Task<UpdateReplicationConfigurationTemplateResponse> UpdateReplicationConfigurationTemplateAsync(UpdateReplicationConfigurationTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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