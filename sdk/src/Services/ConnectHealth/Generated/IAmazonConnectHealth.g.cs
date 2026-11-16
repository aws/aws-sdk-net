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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.ConnectHealth.Model;

#pragma warning disable CS1570

namespace Amazon.ConnectHealth
{
    /// <summary>
    /// <para>Interface for accessing ConnectHealth</para>
    ///
    /// Amazon Connect Health is an AI-powered healthcare service built on Amazon Connect.
    /// It provides pre-built agents that automate patient engagement workflows and support
    /// clinical documentation at the point of care.
    /// 
    ///  
    /// <para>
    /// You can use the Amazon Connect Health API to programmatically manage domains, configure
    /// patient engagement agents, run patient insights jobs, and stream ambient documentation
    /// sessions. This API reference describes the available API operations and data types
    /// for Amazon Connect Health.
    /// </para>
    ///  
    /// <para>
    /// We recommend that you use the AWS SDKs to make programmatic API calls to Amazon Connect
    /// Health.
    /// </para>
    /// </summary>
    public partial interface IAmazonConnectHealth : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IConnectHealthPaginatorFactory Paginators { get; }

#if NETFRAMEWORK
        /// <summary>
        /// Activates a Subscription to enable billing for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateSubscription service method.</param>
        /// <returns>The response from the ActivateSubscription service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/ActivateSubscription">REST API Reference for ActivateSubscription Operation</seealso>
        ActivateSubscriptionResponse ActivateSubscription(ActivateSubscriptionRequest request);
#endif

        /// <summary>
        /// Activates a Subscription to enable billing for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ActivateSubscription service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/ActivateSubscription">REST API Reference for ActivateSubscription Operation</seealso>
        Task<ActivateSubscriptionResponse> ActivateSubscriptionAsync(ActivateSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a Dataset in a Domain and starts building it. A new dataset has the status
        /// CREATING. When it's ready to use, its status changes to ACTIVE, or to CREATE_FAILED
        /// if it fails to build. To check the status, call GetDataset.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent: if you retry a request with the same clientToken, it
        /// returns the dataset that the first request created.
        /// </para>
        ///  
        /// <para>
        /// For a medical coding dataset, Amazon Connect Health uses the coded examples that are
        /// in the s3InputPath when you create the dataset, and writes evaluation scores to the
        /// s3OutputPath. Later changes to the s3InputPath don't change the dataset. To use this
        /// operation, you must have s3:GetObject and s3:ListBucket permissions for the input
        /// location and s3:PutObject permission for the output location, and kms:Decrypt and
        /// kms:GenerateDataKey permissions if you encrypt the locations with an AWS KMS key.
        /// </para>
        ///  
        /// <para>
        /// Datasets are in preview release and are subject to change.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
        /// <returns>The response from the CreateDataset service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ConflictException">
        /// This error is thrown when a resource update is no longer valid due to assumptions
        /// about initial state changing.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        CreateDatasetResponse CreateDataset(CreateDatasetRequest request);
#endif

        /// <summary>
        /// Creates a Dataset in a Domain and starts building it. A new dataset has the status
        /// CREATING. When it's ready to use, its status changes to ACTIVE, or to CREATE_FAILED
        /// if it fails to build. To check the status, call GetDataset.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent: if you retry a request with the same clientToken, it
        /// returns the dataset that the first request created.
        /// </para>
        ///  
        /// <para>
        /// For a medical coding dataset, Amazon Connect Health uses the coded examples that are
        /// in the s3InputPath when you create the dataset, and writes evaluation scores to the
        /// s3OutputPath. Later changes to the s3InputPath don't change the dataset. To use this
        /// operation, you must have s3:GetObject and s3:ListBucket permissions for the input
        /// location and s3:PutObject permission for the output location, and kms:Decrypt and
        /// kms:GenerateDataKey permissions if you encrypt the locations with an AWS KMS key.
        /// </para>
        ///  
        /// <para>
        /// Datasets are in preview release and are subject to change.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateDataset service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ConflictException">
        /// This error is thrown when a resource update is no longer valid due to assumptions
        /// about initial state changing.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        Task<CreateDatasetResponse> CreateDatasetAsync(CreateDatasetRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new Domain for managing HealthAgent resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// <returns>The response from the CreateDomain service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        CreateDomainResponse CreateDomain(CreateDomainRequest request);
#endif

        /// <summary>
        /// Creates a new Domain for managing HealthAgent resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateDomain service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new Subscription within a Domain for billing and user management.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscription service method.</param>
        /// <returns>The response from the CreateSubscription service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/CreateSubscription">REST API Reference for CreateSubscription Operation</seealso>
        CreateSubscriptionResponse CreateSubscription(CreateSubscriptionRequest request);
#endif

        /// <summary>
        /// Creates a new Subscription within a Domain for billing and user management.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateSubscription service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/CreateSubscription">REST API Reference for CreateSubscription Operation</seealso>
        Task<CreateSubscriptionResponse> CreateSubscriptionAsync(CreateSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deactivates a Subscription to stop billing for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateSubscription service method.</param>
        /// <returns>The response from the DeactivateSubscription service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/DeactivateSubscription">REST API Reference for DeactivateSubscription Operation</seealso>
        DeactivateSubscriptionResponse DeactivateSubscription(DeactivateSubscriptionRequest request);
#endif

        /// <summary>
        /// Deactivates a Subscription to stop billing for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeactivateSubscription service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/DeactivateSubscription">REST API Reference for DeactivateSubscription Operation</seealso>
        Task<DeactivateSubscriptionResponse> DeactivateSubscriptionAsync(DeactivateSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Starts deleting a Dataset and the resources that Amazon Connect Health built for it.
        /// You can delete a dataset whose status is ACTIVE, CREATE_FAILED, or DELETE_FAILED.
        /// The dataset moves to DELETING, and then to DELETED. If the delete fails, the dataset
        /// moves to DELETE_FAILED, and you can call DeleteDataset again.
        /// 
        ///  
        /// <para>
        /// Medical coding jobs that already use the dataset finish. Amazon Connect Health rejects
        /// new requests that specify the dataset.
        /// </para>
        ///  
        /// <para>
        /// Datasets are in preview release and are subject to change.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// <returns>The response from the DeleteDataset service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ConflictException">
        /// This error is thrown when a resource update is no longer valid due to assumptions
        /// about initial state changing.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request);
#endif

        /// <summary>
        /// Starts deleting a Dataset and the resources that Amazon Connect Health built for it.
        /// You can delete a dataset whose status is ACTIVE, CREATE_FAILED, or DELETE_FAILED.
        /// The dataset moves to DELETING, and then to DELETED. If the delete fails, the dataset
        /// moves to DELETE_FAILED, and you can call DeleteDataset again.
        /// 
        ///  
        /// <para>
        /// Medical coding jobs that already use the dataset finish. Amazon Connect Health rejects
        /// new requests that specify the dataset.
        /// </para>
        ///  
        /// <para>
        /// Datasets are in preview release and are subject to change.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteDataset service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ConflictException">
        /// This error is thrown when a resource update is no longer valid due to assumptions
        /// about initial state changing.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        Task<DeleteDatasetResponse> DeleteDatasetAsync(DeleteDatasetRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a Domain and all associated resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// <returns>The response from the DeleteDomain service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        DeleteDomainResponse DeleteDomain(DeleteDomainRequest request);
#endif

        /// <summary>
        /// Deletes a Domain and all associated resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteDomain service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about a Dataset, including its status and, after it is built,
        /// its results. A dataset whose status is DELETED returns ResourceNotFoundException.
        /// 
        ///  
        /// <para>
        /// Datasets are in preview release and are subject to change.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataset service method.</param>
        /// <returns>The response from the GetDataset service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetDataset">REST API Reference for GetDataset Operation</seealso>
        GetDatasetResponse GetDataset(GetDatasetRequest request);
#endif

        /// <summary>
        /// Retrieves information about a Dataset, including its status and, after it is built,
        /// its results. A dataset whose status is DELETED returns ResourceNotFoundException.
        /// 
        ///  
        /// <para>
        /// Datasets are in preview release and are subject to change.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetDataset service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetDataset">REST API Reference for GetDataset Operation</seealso>
        Task<GetDatasetResponse> GetDatasetAsync(GetDatasetRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about a Domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
        /// <returns>The response from the GetDomain service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetDomain">REST API Reference for GetDomain Operation</seealso>
        GetDomainResponse GetDomain(GetDomainRequest request);
#endif

        /// <summary>
        /// Retrieves information about a Domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetDomain service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetDomain">REST API Reference for GetDomain Operation</seealso>
        Task<GetDomainResponse> GetDomainAsync(GetDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about a medical coding job, including its status and, when it
        /// succeeds, the location of its results.
        /// 
        ///  
        /// <para>
        /// Medical coding jobs are in preview release and are subject to change.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalCodingJob service method.</param>
        /// <returns>The response from the GetMedicalCodingJob service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetMedicalCodingJob">REST API Reference for GetMedicalCodingJob Operation</seealso>
        GetMedicalCodingJobResponse GetMedicalCodingJob(GetMedicalCodingJobRequest request);
#endif

        /// <summary>
        /// Retrieves information about a medical coding job, including its status and, when it
        /// succeeds, the location of its results.
        /// 
        ///  
        /// <para>
        /// Medical coding jobs are in preview release and are subject to change.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalCodingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetMedicalCodingJob service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetMedicalCodingJob">REST API Reference for GetMedicalCodingJob Operation</seealso>
        Task<GetMedicalCodingJobResponse> GetMedicalCodingJobAsync(GetMedicalCodingJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves details about an existing Medical Scribe listening session
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalScribeListeningSession service method.</param>
        /// <returns>The response from the GetMedicalScribeListeningSession service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetMedicalScribeListeningSession">REST API Reference for GetMedicalScribeListeningSession Operation</seealso>
        GetMedicalScribeListeningSessionResponse GetMedicalScribeListeningSession(GetMedicalScribeListeningSessionRequest request);
#endif

        /// <summary>
        /// Retrieves details about an existing Medical Scribe listening session
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalScribeListeningSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetMedicalScribeListeningSession service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetMedicalScribeListeningSession">REST API Reference for GetMedicalScribeListeningSession Operation</seealso>
        Task<GetMedicalScribeListeningSessionResponse> GetMedicalScribeListeningSessionAsync(GetMedicalScribeListeningSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Get details of a started patient insights job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPatientInsightsJob service method.</param>
        /// <returns>The response from the GetPatientInsightsJob service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetPatientInsightsJob">REST API Reference for GetPatientInsightsJob Operation</seealso>
        GetPatientInsightsJobResponse GetPatientInsightsJob(GetPatientInsightsJobRequest request);
#endif

        /// <summary>
        /// Get details of a started patient insights job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPatientInsightsJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetPatientInsightsJob service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetPatientInsightsJob">REST API Reference for GetPatientInsightsJob Operation</seealso>
        Task<GetPatientInsightsJobResponse> GetPatientInsightsJobAsync(GetPatientInsightsJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about a Subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscription service method.</param>
        /// <returns>The response from the GetSubscription service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetSubscription">REST API Reference for GetSubscription Operation</seealso>
        GetSubscriptionResponse GetSubscription(GetSubscriptionRequest request);
#endif

        /// <summary>
        /// Retrieves information about a Subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetSubscription service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetSubscription">REST API Reference for GetSubscription Operation</seealso>
        Task<GetSubscriptionResponse> GetSubscriptionAsync(GetSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the Datasets in a Domain. You can list only the datasets of one type. The operation
        /// doesn't return datasets whose status is DELETED, and the order of the results isn't
        /// specified. We recommend using pagination to ensure that the operation returns quickly
        /// and successfully.
        /// 
        ///  
        /// <para>
        /// Datasets are in preview release and are subject to change.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
        /// <returns>The response from the ListDatasets service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        ListDatasetsResponse ListDatasets(ListDatasetsRequest request);
#endif

        /// <summary>
        /// Lists the Datasets in a Domain. You can list only the datasets of one type. The operation
        /// doesn't return datasets whose status is DELETED, and the order of the results isn't
        /// specified. We recommend using pagination to ensure that the operation returns quickly
        /// and successfully.
        /// 
        ///  
        /// <para>
        /// Datasets are in preview release and are subject to change.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListDatasets service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists Domains for a given account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// <returns>The response from the ListDomains service method, as returned by ConnectHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/ListDomains">REST API Reference for ListDomains Operation</seealso>
        ListDomainsResponse ListDomains(ListDomainsRequest request);
#endif

        /// <summary>
        /// Lists Domains for a given account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListDomains service method, as returned by ConnectHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/ListDomains">REST API Reference for ListDomains Operation</seealso>
        Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists all Subscriptions within a Domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions service method.</param>
        /// <returns>The response from the ListSubscriptions service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest request);
#endif

        /// <summary>
        /// Lists all Subscriptions within a Domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListSubscriptions service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        Task<ListSubscriptionsResponse> ListSubscriptionsAsync(ListSubscriptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the tags associated with the specified resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <returns>The response from the ListTagsForResource service method, as returned by ConnectHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);
#endif

        /// <summary>
        /// Lists the tags associated with the specified resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTagsForResource service method, as returned by ConnectHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Starts an asynchronous job that generates medical codes (ICD-10 and CPT) for clinical
        /// text. Call GetMedicalCodingJob to check the status of the job. When the job succeeds,
        /// Amazon Connect Health writes the results to the output Amazon S3 location.
        /// 
        ///  
        /// <para>
        /// To tailor the codes to your organization, specify an ACTIVE medical coding dataset
        /// in the Domain. If you don't specify a dataset, the job uses the general medical coding
        /// knowledge base.
        /// </para>
        ///  
        /// <para>
        /// Medical coding jobs are in preview release and are subject to change.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMedicalCodingJob service method.</param>
        /// <returns>The response from the StartMedicalCodingJob service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ConflictException">
        /// This error is thrown when a resource update is no longer valid due to assumptions
        /// about initial state changing.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/StartMedicalCodingJob">REST API Reference for StartMedicalCodingJob Operation</seealso>
        StartMedicalCodingJobResponse StartMedicalCodingJob(StartMedicalCodingJobRequest request);
#endif

        /// <summary>
        /// Starts an asynchronous job that generates medical codes (ICD-10 and CPT) for clinical
        /// text. Call GetMedicalCodingJob to check the status of the job. When the job succeeds,
        /// Amazon Connect Health writes the results to the output Amazon S3 location.
        /// 
        ///  
        /// <para>
        /// To tailor the codes to your organization, specify an ACTIVE medical coding dataset
        /// in the Domain. If you don't specify a dataset, the job uses the general medical coding
        /// knowledge base.
        /// </para>
        ///  
        /// <para>
        /// Medical coding jobs are in preview release and are subject to change.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMedicalCodingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartMedicalCodingJob service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ConflictException">
        /// This error is thrown when a resource update is no longer valid due to assumptions
        /// about initial state changing.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/StartMedicalCodingJob">REST API Reference for StartMedicalCodingJob Operation</seealso>
        Task<StartMedicalCodingJobResponse> StartMedicalCodingJobAsync(StartMedicalCodingJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NET8_0_OR_GREATER
#if NETFRAMEWORK
        /// <summary>
        /// Starts a new Medical Scribe listening session for real-time audio transcription
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMedicalScribeListeningSession service method.</param>
        /// <returns>The response from the StartMedicalScribeListeningSession service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/StartMedicalScribeListeningSession">REST API Reference for StartMedicalScribeListeningSession Operation</seealso>
        StartMedicalScribeListeningSessionResponse StartMedicalScribeListeningSession(StartMedicalScribeListeningSessionRequest request);
#endif

        /// <summary>
        /// Starts a new Medical Scribe listening session for real-time audio transcription
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMedicalScribeListeningSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartMedicalScribeListeningSession service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/StartMedicalScribeListeningSession">REST API Reference for StartMedicalScribeListeningSession Operation</seealso>
        Task<StartMedicalScribeListeningSessionResponse> StartMedicalScribeListeningSessionAsync(StartMedicalScribeListeningSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));
#endif

#if NETFRAMEWORK
        /// <summary>
        /// Starts a new patient insights job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPatientInsightsJob service method.</param>
        /// <returns>The response from the StartPatientInsightsJob service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ConflictException">
        /// This error is thrown when a resource update is no longer valid due to assumptions
        /// about initial state changing.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/StartPatientInsightsJob">REST API Reference for StartPatientInsightsJob Operation</seealso>
        StartPatientInsightsJobResponse StartPatientInsightsJob(StartPatientInsightsJobRequest request);
#endif

        /// <summary>
        /// Starts a new patient insights job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPatientInsightsJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartPatientInsightsJob service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ConflictException">
        /// This error is thrown when a resource update is no longer valid due to assumptions
        /// about initial state changing.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/StartPatientInsightsJob">REST API Reference for StartPatientInsightsJob Operation</seealso>
        Task<StartPatientInsightsJobResponse> StartPatientInsightsJobAsync(StartPatientInsightsJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Submits feedback on a clinical document or a set of medical codes that Amazon Connect
        /// Health generated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitFeedback service method.</param>
        /// <returns>The response from the SubmitFeedback service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/SubmitFeedback">REST API Reference for SubmitFeedback Operation</seealso>
        SubmitFeedbackResponse SubmitFeedback(SubmitFeedbackRequest request);
#endif

        /// <summary>
        /// Submits feedback on a clinical document or a set of medical codes that Amazon Connect
        /// Health generated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitFeedback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the SubmitFeedback service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/SubmitFeedback">REST API Reference for SubmitFeedback Operation</seealso>
        Task<SubmitFeedbackResponse> SubmitFeedbackAsync(SubmitFeedbackRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Associates the specified tags with the specified resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <returns>The response from the TagResource service method, as returned by ConnectHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);
#endif

        /// <summary>
        /// Associates the specified tags with the specified resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TagResource service method, as returned by ConnectHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Removes the specified tags from the specified resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <returns>The response from the UntagResource service method, as returned by ConnectHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);
#endif

        /// <summary>
        /// Removes the specified tags from the specified resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UntagResource service method, as returned by ConnectHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);

#if NET8_0_OR_GREATER
        // Warning CA1033 is issued when the child types can not call the method defined in parent types.
        // In this use case the intended caller is only meant to be the interface as a factory
        // method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonConnectHealthConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonConnectHealthConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonConnectHealthConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonConnectHealthConfig to create AmazonConnectHealthClient");
            }

            return awsCredentials == null ?
                    new AmazonConnectHealthClient(serviceClientConfig) :
                    new AmazonConnectHealthClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
