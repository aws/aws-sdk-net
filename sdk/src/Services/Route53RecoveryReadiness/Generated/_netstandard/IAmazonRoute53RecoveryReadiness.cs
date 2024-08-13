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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Route53RecoveryReadiness.Model;

#pragma warning disable CS1570
namespace Amazon.Route53RecoveryReadiness
{
    /// <summary>
    /// <para>Interface for accessing Route53RecoveryReadiness</para>
    ///
    /// Recovery readiness
    /// </summary>
    public partial interface IAmazonRoute53RecoveryReadiness : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IRoute53RecoveryReadinessPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateCell



        /// <summary>
        /// Creates a cell in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCell service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCell service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateCell">REST API Reference for CreateCell Operation</seealso>
        Task<CreateCellResponse> CreateCellAsync(CreateCellRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCrossAccountAuthorization



        /// <summary>
        /// Creates a cross-account readiness authorization. This lets you authorize another account
        /// to work with Route 53 Application Recovery Controller, for example, to check the readiness
        /// status of resources in a separate account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCrossAccountAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCrossAccountAuthorization service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateCrossAccountAuthorization">REST API Reference for CreateCrossAccountAuthorization Operation</seealso>
        Task<CreateCrossAccountAuthorizationResponse> CreateCrossAccountAuthorizationAsync(CreateCrossAccountAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateReadinessCheck



        /// <summary>
        /// Creates a readiness check in an account. A readiness check monitors a resource set
        /// in your application, such as a set of Amazon Aurora instances, that Application Recovery
        /// Controller is auditing recovery readiness for. The audits run once every minute on
        /// every resource that's associated with a readiness check.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReadinessCheck service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateReadinessCheck service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateReadinessCheck">REST API Reference for CreateReadinessCheck Operation</seealso>
        Task<CreateReadinessCheckResponse> CreateReadinessCheckAsync(CreateReadinessCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRecoveryGroup



        /// <summary>
        /// Creates a recovery group in an account. A recovery group corresponds to an application
        /// and includes a list of the cells that make up the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRecoveryGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRecoveryGroup service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateRecoveryGroup">REST API Reference for CreateRecoveryGroup Operation</seealso>
        Task<CreateRecoveryGroupResponse> CreateRecoveryGroupAsync(CreateRecoveryGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateResourceSet



        /// <summary>
        /// Creates a resource set. A resource set is a set of resources of one type that span
        /// multiple cells. You can associate a resource set with a readiness check to monitor
        /// the resources for failover readiness.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateResourceSet service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateResourceSet">REST API Reference for CreateResourceSet Operation</seealso>
        Task<CreateResourceSetResponse> CreateResourceSetAsync(CreateResourceSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCell



        /// <summary>
        /// Delete a cell. When successful, the response code is 204, with no response body.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCell service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCell service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteCell">REST API Reference for DeleteCell Operation</seealso>
        Task<DeleteCellResponse> DeleteCellAsync(DeleteCellRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCrossAccountAuthorization



        /// <summary>
        /// Deletes cross account readiness authorization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCrossAccountAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCrossAccountAuthorization service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteCrossAccountAuthorization">REST API Reference for DeleteCrossAccountAuthorization Operation</seealso>
        Task<DeleteCrossAccountAuthorizationResponse> DeleteCrossAccountAuthorizationAsync(DeleteCrossAccountAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteReadinessCheck



        /// <summary>
        /// Deletes a readiness check.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReadinessCheck service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteReadinessCheck service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteReadinessCheck">REST API Reference for DeleteReadinessCheck Operation</seealso>
        Task<DeleteReadinessCheckResponse> DeleteReadinessCheckAsync(DeleteReadinessCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRecoveryGroup



        /// <summary>
        /// Deletes a recovery group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecoveryGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRecoveryGroup service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteRecoveryGroup">REST API Reference for DeleteRecoveryGroup Operation</seealso>
        Task<DeleteRecoveryGroupResponse> DeleteRecoveryGroupAsync(DeleteRecoveryGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteResourceSet



        /// <summary>
        /// Deletes a resource set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourceSet service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteResourceSet">REST API Reference for DeleteResourceSet Operation</seealso>
        Task<DeleteResourceSetResponse> DeleteResourceSetAsync(DeleteResourceSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetArchitectureRecommendations



        /// <summary>
        /// Gets recommendations about architecture designs for improving resiliency for an application,
        /// based on a recovery group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchitectureRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetArchitectureRecommendations service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetArchitectureRecommendations">REST API Reference for GetArchitectureRecommendations Operation</seealso>
        Task<GetArchitectureRecommendationsResponse> GetArchitectureRecommendationsAsync(GetArchitectureRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCell



        /// <summary>
        /// Gets information about a cell including cell name, cell Amazon Resource Name (ARN),
        /// ARNs of nested cells for this cell, and a list of those cell ARNs with their associated
        /// recovery group ARNs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCell service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCell service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetCell">REST API Reference for GetCell Operation</seealso>
        Task<GetCellResponse> GetCellAsync(GetCellRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCellReadinessSummary



        /// <summary>
        /// Gets readiness for a cell. Aggregates the readiness of all the resources that are
        /// associated with the cell into a single value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCellReadinessSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCellReadinessSummary service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetCellReadinessSummary">REST API Reference for GetCellReadinessSummary Operation</seealso>
        Task<GetCellReadinessSummaryResponse> GetCellReadinessSummaryAsync(GetCellReadinessSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetReadinessCheck



        /// <summary>
        /// Gets details about a readiness check.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadinessCheck service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReadinessCheck service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetReadinessCheck">REST API Reference for GetReadinessCheck Operation</seealso>
        Task<GetReadinessCheckResponse> GetReadinessCheckAsync(GetReadinessCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetReadinessCheckResourceStatus



        /// <summary>
        /// Gets individual readiness status for a readiness check. To see the overall readiness
        /// status for a recovery group, that considers the readiness status for all the readiness
        /// checks in the recovery group, use GetRecoveryGroupReadinessSummary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadinessCheckResourceStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReadinessCheckResourceStatus service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetReadinessCheckResourceStatus">REST API Reference for GetReadinessCheckResourceStatus Operation</seealso>
        Task<GetReadinessCheckResourceStatusResponse> GetReadinessCheckResourceStatusAsync(GetReadinessCheckResourceStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetReadinessCheckStatus



        /// <summary>
        /// Gets the readiness status for an individual readiness check. To see the overall readiness
        /// status for a recovery group, that considers the readiness status for all the readiness
        /// checks in a recovery group, use GetRecoveryGroupReadinessSummary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadinessCheckStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReadinessCheckStatus service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetReadinessCheckStatus">REST API Reference for GetReadinessCheckStatus Operation</seealso>
        Task<GetReadinessCheckStatusResponse> GetReadinessCheckStatusAsync(GetReadinessCheckStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRecoveryGroup



        /// <summary>
        /// Gets details about a recovery group, including a list of the cells that are included
        /// in it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecoveryGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRecoveryGroup service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetRecoveryGroup">REST API Reference for GetRecoveryGroup Operation</seealso>
        Task<GetRecoveryGroupResponse> GetRecoveryGroupAsync(GetRecoveryGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRecoveryGroupReadinessSummary



        /// <summary>
        /// Displays a summary of information about a recovery group's readiness status. Includes
        /// the readiness checks for resources in the recovery group and the readiness status
        /// of each one.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecoveryGroupReadinessSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRecoveryGroupReadinessSummary service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetRecoveryGroupReadinessSummary">REST API Reference for GetRecoveryGroupReadinessSummary Operation</seealso>
        Task<GetRecoveryGroupReadinessSummaryResponse> GetRecoveryGroupReadinessSummaryAsync(GetRecoveryGroupReadinessSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetResourceSet



        /// <summary>
        /// Displays the details about a resource set, including a list of the resources in the
        /// set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourceSet service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetResourceSet">REST API Reference for GetResourceSet Operation</seealso>
        Task<GetResourceSetResponse> GetResourceSetAsync(GetResourceSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCells



        /// <summary>
        /// Lists the cells for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCells service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCells service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListCells">REST API Reference for ListCells Operation</seealso>
        Task<ListCellsResponse> ListCellsAsync(ListCellsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCrossAccountAuthorizations



        /// <summary>
        /// Lists the cross-account readiness authorizations that are in place for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCrossAccountAuthorizations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCrossAccountAuthorizations service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListCrossAccountAuthorizations">REST API Reference for ListCrossAccountAuthorizations Operation</seealso>
        Task<ListCrossAccountAuthorizationsResponse> ListCrossAccountAuthorizationsAsync(ListCrossAccountAuthorizationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListReadinessChecks



        /// <summary>
        /// Lists the readiness checks for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReadinessChecks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReadinessChecks service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListReadinessChecks">REST API Reference for ListReadinessChecks Operation</seealso>
        Task<ListReadinessChecksResponse> ListReadinessChecksAsync(ListReadinessChecksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRecoveryGroups



        /// <summary>
        /// Lists the recovery groups in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecoveryGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecoveryGroups service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListRecoveryGroups">REST API Reference for ListRecoveryGroups Operation</seealso>
        Task<ListRecoveryGroupsResponse> ListRecoveryGroupsAsync(ListRecoveryGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListResourceSets



        /// <summary>
        /// Lists the resource sets in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceSets service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListResourceSets">REST API Reference for ListResourceSets Operation</seealso>
        Task<ListResourceSetsResponse> ListResourceSetsAsync(ListResourceSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRules



        /// <summary>
        /// Lists all readiness rules, or lists the readiness rules for a specific resource type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListRules">REST API Reference for ListRules Operation</seealso>
        Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResources



        /// <summary>
        /// Lists the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResources service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListTagsForResources">REST API Reference for ListTagsForResources Operation</seealso>
        Task<ListTagsForResourcesResponse> ListTagsForResourcesAsync(ListTagsForResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCell



        /// <summary>
        /// Updates a cell to replace the list of nested cells with a new list of nested cells.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCell service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCell service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateCell">REST API Reference for UpdateCell Operation</seealso>
        Task<UpdateCellResponse> UpdateCellAsync(UpdateCellRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateReadinessCheck



        /// <summary>
        /// Updates a readiness check.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReadinessCheck service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateReadinessCheck service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateReadinessCheck">REST API Reference for UpdateReadinessCheck Operation</seealso>
        Task<UpdateReadinessCheckResponse> UpdateReadinessCheckAsync(UpdateReadinessCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRecoveryGroup



        /// <summary>
        /// Updates a recovery group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecoveryGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRecoveryGroup service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateRecoveryGroup">REST API Reference for UpdateRecoveryGroup Operation</seealso>
        Task<UpdateRecoveryGroupResponse> UpdateRecoveryGroupAsync(UpdateRecoveryGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateResourceSet



        /// <summary>
        /// Updates a resource set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResourceSet service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateResourceSet">REST API Reference for UpdateResourceSet Operation</seealso>
        Task<UpdateResourceSetResponse> UpdateResourceSetAsync(UpdateResourceSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonRoute53RecoveryReadinessConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonRoute53RecoveryReadinessConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonRoute53RecoveryReadinessConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonRoute53RecoveryReadinessConfig to create AmazonRoute53RecoveryReadinessClient");
            }

            return awsCredentials == null ? 
                    new AmazonRoute53RecoveryReadinessClient(serviceClientConfig) :
                    new AmazonRoute53RecoveryReadinessClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}