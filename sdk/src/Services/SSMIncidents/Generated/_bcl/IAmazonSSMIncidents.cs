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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SSMIncidents.Model;

#pragma warning disable CS1570
namespace Amazon.SSMIncidents
{
    /// <summary>
    /// <para>Interface for accessing SSMIncidents</para>
    ///
    /// Systems Manager Incident Manager is an incident management console designed to help
    /// users mitigate and recover from incidents affecting their Amazon Web Services-hosted
    /// applications. An incident is any unplanned interruption or reduction in quality of
    /// services. 
    /// 
    ///  
    /// <para>
    /// Incident Manager increases incident resolution by notifying responders of impact,
    /// highlighting relevant troubleshooting data, and providing collaboration tools to get
    /// services back up and running. To achieve the primary goal of reducing the time-to-resolution
    /// of critical incidents, Incident Manager automates response plans and enables responder
    /// team escalation. 
    /// </para>
    /// </summary>
    public partial interface IAmazonSSMIncidents : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISSMIncidentsPaginatorFactory Paginators { get; }

        
        #region  BatchGetIncidentFindings


        /// <summary>
        /// Retrieves details about all specified findings for an incident, including descriptive
        /// details about each finding. A finding represents a recent application environment
        /// change made by an CodeDeploy deployment or an CloudFormation stack creation or update
        /// that can be investigated as a potential cause of the incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetIncidentFindings service method.</param>
        /// 
        /// <returns>The response from the BatchGetIncidentFindings service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/BatchGetIncidentFindings">REST API Reference for BatchGetIncidentFindings Operation</seealso>
        BatchGetIncidentFindingsResponse BatchGetIncidentFindings(BatchGetIncidentFindingsRequest request);



        /// <summary>
        /// Retrieves details about all specified findings for an incident, including descriptive
        /// details about each finding. A finding represents a recent application environment
        /// change made by an CodeDeploy deployment or an CloudFormation stack creation or update
        /// that can be investigated as a potential cause of the incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetIncidentFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetIncidentFindings service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/BatchGetIncidentFindings">REST API Reference for BatchGetIncidentFindings Operation</seealso>
        Task<BatchGetIncidentFindingsResponse> BatchGetIncidentFindingsAsync(BatchGetIncidentFindingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateReplicationSet


        /// <summary>
        /// A replication set replicates and encrypts your data to the provided Regions with the
        /// provided KMS key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationSet service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationSet service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/CreateReplicationSet">REST API Reference for CreateReplicationSet Operation</seealso>
        CreateReplicationSetResponse CreateReplicationSet(CreateReplicationSetRequest request);



        /// <summary>
        /// A replication set replicates and encrypts your data to the provided Regions with the
        /// provided KMS key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateReplicationSet service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/CreateReplicationSet">REST API Reference for CreateReplicationSet Operation</seealso>
        Task<CreateReplicationSetResponse> CreateReplicationSetAsync(CreateReplicationSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateResponsePlan


        /// <summary>
        /// Creates a response plan that automates the initial response to incidents. A response
        /// plan engages contacts, starts chat channel collaboration, and initiates runbooks at
        /// the beginning of an incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResponsePlan service method.</param>
        /// 
        /// <returns>The response from the CreateResponsePlan service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/CreateResponsePlan">REST API Reference for CreateResponsePlan Operation</seealso>
        CreateResponsePlanResponse CreateResponsePlan(CreateResponsePlanRequest request);



        /// <summary>
        /// Creates a response plan that automates the initial response to incidents. A response
        /// plan engages contacts, starts chat channel collaboration, and initiates runbooks at
        /// the beginning of an incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResponsePlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateResponsePlan service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/CreateResponsePlan">REST API Reference for CreateResponsePlan Operation</seealso>
        Task<CreateResponsePlanResponse> CreateResponsePlanAsync(CreateResponsePlanRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateTimelineEvent


        /// <summary>
        /// Creates a custom timeline event on the incident details page of an incident record.
        /// Incident Manager automatically creates timeline events that mark key moments during
        /// an incident. You can create custom timeline events to mark important events that Incident
        /// Manager can detect automatically.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTimelineEvent service method.</param>
        /// 
        /// <returns>The response from the CreateTimelineEvent service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/CreateTimelineEvent">REST API Reference for CreateTimelineEvent Operation</seealso>
        CreateTimelineEventResponse CreateTimelineEvent(CreateTimelineEventRequest request);



        /// <summary>
        /// Creates a custom timeline event on the incident details page of an incident record.
        /// Incident Manager automatically creates timeline events that mark key moments during
        /// an incident. You can create custom timeline events to mark important events that Incident
        /// Manager can detect automatically.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTimelineEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTimelineEvent service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/CreateTimelineEvent">REST API Reference for CreateTimelineEvent Operation</seealso>
        Task<CreateTimelineEventResponse> CreateTimelineEventAsync(CreateTimelineEventRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteIncidentRecord


        /// <summary>
        /// Delete an incident record from Incident Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIncidentRecord service method.</param>
        /// 
        /// <returns>The response from the DeleteIncidentRecord service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/DeleteIncidentRecord">REST API Reference for DeleteIncidentRecord Operation</seealso>
        DeleteIncidentRecordResponse DeleteIncidentRecord(DeleteIncidentRecordRequest request);



        /// <summary>
        /// Delete an incident record from Incident Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIncidentRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIncidentRecord service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/DeleteIncidentRecord">REST API Reference for DeleteIncidentRecord Operation</seealso>
        Task<DeleteIncidentRecordResponse> DeleteIncidentRecordAsync(DeleteIncidentRecordRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteReplicationSet


        /// <summary>
        /// Deletes all Regions in your replication set. Deleting the replication set deletes
        /// all Incident Manager data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationSet service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicationSet service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/DeleteReplicationSet">REST API Reference for DeleteReplicationSet Operation</seealso>
        DeleteReplicationSetResponse DeleteReplicationSet(DeleteReplicationSetRequest request);



        /// <summary>
        /// Deletes all Regions in your replication set. Deleting the replication set deletes
        /// all Incident Manager data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteReplicationSet service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/DeleteReplicationSet">REST API Reference for DeleteReplicationSet Operation</seealso>
        Task<DeleteReplicationSetResponse> DeleteReplicationSetAsync(DeleteReplicationSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteResourcePolicy


        /// <summary>
        /// Deletes the resource policy that Resource Access Manager uses to share your Incident
        /// Manager resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request);



        /// <summary>
        /// Deletes the resource policy that Resource Access Manager uses to share your Incident
        /// Manager resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteResponsePlan


        /// <summary>
        /// Deletes the specified response plan. Deleting a response plan stops all linked CloudWatch
        /// alarms and EventBridge events from creating an incident with this response plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResponsePlan service method.</param>
        /// 
        /// <returns>The response from the DeleteResponsePlan service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/DeleteResponsePlan">REST API Reference for DeleteResponsePlan Operation</seealso>
        DeleteResponsePlanResponse DeleteResponsePlan(DeleteResponsePlanRequest request);



        /// <summary>
        /// Deletes the specified response plan. Deleting a response plan stops all linked CloudWatch
        /// alarms and EventBridge events from creating an incident with this response plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResponsePlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResponsePlan service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/DeleteResponsePlan">REST API Reference for DeleteResponsePlan Operation</seealso>
        Task<DeleteResponsePlanResponse> DeleteResponsePlanAsync(DeleteResponsePlanRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTimelineEvent


        /// <summary>
        /// Deletes a timeline event from an incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTimelineEvent service method.</param>
        /// 
        /// <returns>The response from the DeleteTimelineEvent service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/DeleteTimelineEvent">REST API Reference for DeleteTimelineEvent Operation</seealso>
        DeleteTimelineEventResponse DeleteTimelineEvent(DeleteTimelineEventRequest request);



        /// <summary>
        /// Deletes a timeline event from an incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTimelineEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTimelineEvent service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/DeleteTimelineEvent">REST API Reference for DeleteTimelineEvent Operation</seealso>
        Task<DeleteTimelineEventResponse> DeleteTimelineEventAsync(DeleteTimelineEventRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetIncidentRecord


        /// <summary>
        /// Returns the details for the specified incident record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIncidentRecord service method.</param>
        /// 
        /// <returns>The response from the GetIncidentRecord service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/GetIncidentRecord">REST API Reference for GetIncidentRecord Operation</seealso>
        GetIncidentRecordResponse GetIncidentRecord(GetIncidentRecordRequest request);



        /// <summary>
        /// Returns the details for the specified incident record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIncidentRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIncidentRecord service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/GetIncidentRecord">REST API Reference for GetIncidentRecord Operation</seealso>
        Task<GetIncidentRecordResponse> GetIncidentRecordAsync(GetIncidentRecordRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetReplicationSet


        /// <summary>
        /// Retrieve your Incident Manager replication set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationSet service method.</param>
        /// 
        /// <returns>The response from the GetReplicationSet service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/GetReplicationSet">REST API Reference for GetReplicationSet Operation</seealso>
        GetReplicationSetResponse GetReplicationSet(GetReplicationSetRequest request);



        /// <summary>
        /// Retrieve your Incident Manager replication set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReplicationSet service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/GetReplicationSet">REST API Reference for GetReplicationSet Operation</seealso>
        Task<GetReplicationSetResponse> GetReplicationSetAsync(GetReplicationSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResourcePolicies


        /// <summary>
        /// Retrieves the resource policies attached to the specified response plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicies service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicies service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/GetResourcePolicies">REST API Reference for GetResourcePolicies Operation</seealso>
        GetResourcePoliciesResponse GetResourcePolicies(GetResourcePoliciesRequest request);



        /// <summary>
        /// Retrieves the resource policies attached to the specified response plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicies service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/GetResourcePolicies">REST API Reference for GetResourcePolicies Operation</seealso>
        Task<GetResourcePoliciesResponse> GetResourcePoliciesAsync(GetResourcePoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResponsePlan


        /// <summary>
        /// Retrieves the details of the specified response plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResponsePlan service method.</param>
        /// 
        /// <returns>The response from the GetResponsePlan service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/GetResponsePlan">REST API Reference for GetResponsePlan Operation</seealso>
        GetResponsePlanResponse GetResponsePlan(GetResponsePlanRequest request);



        /// <summary>
        /// Retrieves the details of the specified response plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResponsePlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResponsePlan service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/GetResponsePlan">REST API Reference for GetResponsePlan Operation</seealso>
        Task<GetResponsePlanResponse> GetResponsePlanAsync(GetResponsePlanRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTimelineEvent


        /// <summary>
        /// Retrieves a timeline event based on its ID and incident record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTimelineEvent service method.</param>
        /// 
        /// <returns>The response from the GetTimelineEvent service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/GetTimelineEvent">REST API Reference for GetTimelineEvent Operation</seealso>
        GetTimelineEventResponse GetTimelineEvent(GetTimelineEventRequest request);



        /// <summary>
        /// Retrieves a timeline event based on its ID and incident record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTimelineEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTimelineEvent service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/GetTimelineEvent">REST API Reference for GetTimelineEvent Operation</seealso>
        Task<GetTimelineEventResponse> GetTimelineEventAsync(GetTimelineEventRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListIncidentFindings


        /// <summary>
        /// Retrieves a list of the IDs of findings, plus their last modified times, that have
        /// been identified for a specified incident. A finding represents a recent application
        /// environment change made by an CloudFormation stack creation or update or an CodeDeploy
        /// deployment that can be investigated as a potential cause of the incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIncidentFindings service method.</param>
        /// 
        /// <returns>The response from the ListIncidentFindings service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListIncidentFindings">REST API Reference for ListIncidentFindings Operation</seealso>
        ListIncidentFindingsResponse ListIncidentFindings(ListIncidentFindingsRequest request);



        /// <summary>
        /// Retrieves a list of the IDs of findings, plus their last modified times, that have
        /// been identified for a specified incident. A finding represents a recent application
        /// environment change made by an CloudFormation stack creation or update or an CodeDeploy
        /// deployment that can be investigated as a potential cause of the incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIncidentFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIncidentFindings service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListIncidentFindings">REST API Reference for ListIncidentFindings Operation</seealso>
        Task<ListIncidentFindingsResponse> ListIncidentFindingsAsync(ListIncidentFindingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListIncidentRecords


        /// <summary>
        /// Lists all incident records in your account. Use this command to retrieve the Amazon
        /// Resource Name (ARN) of the incident record you want to update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIncidentRecords service method.</param>
        /// 
        /// <returns>The response from the ListIncidentRecords service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListIncidentRecords">REST API Reference for ListIncidentRecords Operation</seealso>
        ListIncidentRecordsResponse ListIncidentRecords(ListIncidentRecordsRequest request);



        /// <summary>
        /// Lists all incident records in your account. Use this command to retrieve the Amazon
        /// Resource Name (ARN) of the incident record you want to update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIncidentRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIncidentRecords service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListIncidentRecords">REST API Reference for ListIncidentRecords Operation</seealso>
        Task<ListIncidentRecordsResponse> ListIncidentRecordsAsync(ListIncidentRecordsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRelatedItems


        /// <summary>
        /// List all related items for an incident record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRelatedItems service method.</param>
        /// 
        /// <returns>The response from the ListRelatedItems service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListRelatedItems">REST API Reference for ListRelatedItems Operation</seealso>
        ListRelatedItemsResponse ListRelatedItems(ListRelatedItemsRequest request);



        /// <summary>
        /// List all related items for an incident record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRelatedItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRelatedItems service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListRelatedItems">REST API Reference for ListRelatedItems Operation</seealso>
        Task<ListRelatedItemsResponse> ListRelatedItemsAsync(ListRelatedItemsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListReplicationSets


        /// <summary>
        /// Lists details about the replication set configured in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReplicationSets service method.</param>
        /// 
        /// <returns>The response from the ListReplicationSets service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListReplicationSets">REST API Reference for ListReplicationSets Operation</seealso>
        ListReplicationSetsResponse ListReplicationSets(ListReplicationSetsRequest request);



        /// <summary>
        /// Lists details about the replication set configured in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReplicationSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReplicationSets service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListReplicationSets">REST API Reference for ListReplicationSets Operation</seealso>
        Task<ListReplicationSetsResponse> ListReplicationSetsAsync(ListReplicationSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResponsePlans


        /// <summary>
        /// Lists all response plans in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResponsePlans service method.</param>
        /// 
        /// <returns>The response from the ListResponsePlans service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListResponsePlans">REST API Reference for ListResponsePlans Operation</seealso>
        ListResponsePlansResponse ListResponsePlans(ListResponsePlansRequest request);



        /// <summary>
        /// Lists all response plans in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResponsePlans service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResponsePlans service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListResponsePlans">REST API Reference for ListResponsePlans Operation</seealso>
        Task<ListResponsePlansResponse> ListResponsePlansAsync(ListResponsePlansRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags that are attached to the specified response plan or incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists the tags that are attached to the specified response plan or incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTimelineEvents


        /// <summary>
        /// Lists timeline events for the specified incident record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTimelineEvents service method.</param>
        /// 
        /// <returns>The response from the ListTimelineEvents service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListTimelineEvents">REST API Reference for ListTimelineEvents Operation</seealso>
        ListTimelineEventsResponse ListTimelineEvents(ListTimelineEventsRequest request);



        /// <summary>
        /// Lists timeline events for the specified incident record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTimelineEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTimelineEvents service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListTimelineEvents">REST API Reference for ListTimelineEvents Operation</seealso>
        Task<ListTimelineEventsResponse> ListTimelineEventsAsync(ListTimelineEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutResourcePolicy


        /// <summary>
        /// Adds a resource policy to the specified response plan. The resource policy is used
        /// to share the response plan using Resource Access Manager (RAM). For more information
        /// about cross-account sharing, see <a href="https://docs.aws.amazon.com/incident-manager/latest/userguide/incident-manager-cross-account-cross-region.html">Cross-Region
        /// and cross-account incident management</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request);



        /// <summary>
        /// Adds a resource policy to the specified response plan. The resource policy is used
        /// to share the response plan using Resource Access Manager (RAM). For more information
        /// about cross-account sharing, see <a href="https://docs.aws.amazon.com/incident-manager/latest/userguide/incident-manager-cross-account-cross-region.html">Cross-Region
        /// and cross-account incident management</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartIncident


        /// <summary>
        /// Used to start an incident from CloudWatch alarms, EventBridge events, or manually.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartIncident service method.</param>
        /// 
        /// <returns>The response from the StartIncident service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/StartIncident">REST API Reference for StartIncident Operation</seealso>
        StartIncidentResponse StartIncident(StartIncidentRequest request);



        /// <summary>
        /// Used to start an incident from CloudWatch alarms, EventBridge events, or manually.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartIncident service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartIncident service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/StartIncident">REST API Reference for StartIncident Operation</seealso>
        Task<StartIncidentResponse> StartIncidentAsync(StartIncidentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds a tag to a response plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds a tag to a response plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDeletionProtection


        /// <summary>
        /// Update deletion protection to either allow or deny deletion of the final Region in
        /// a replication set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeletionProtection service method.</param>
        /// 
        /// <returns>The response from the UpdateDeletionProtection service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateDeletionProtection">REST API Reference for UpdateDeletionProtection Operation</seealso>
        UpdateDeletionProtectionResponse UpdateDeletionProtection(UpdateDeletionProtectionRequest request);



        /// <summary>
        /// Update deletion protection to either allow or deny deletion of the final Region in
        /// a replication set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeletionProtection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDeletionProtection service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateDeletionProtection">REST API Reference for UpdateDeletionProtection Operation</seealso>
        Task<UpdateDeletionProtectionResponse> UpdateDeletionProtectionAsync(UpdateDeletionProtectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateIncidentRecord


        /// <summary>
        /// Update the details of an incident record. You can use this operation to update an
        /// incident record from the defined chat channel. For more information about using actions
        /// in chat channels, see <a href="https://docs.aws.amazon.com/incident-manager/latest/userguide/chat.html#chat-interact">Interacting
        /// through chat</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIncidentRecord service method.</param>
        /// 
        /// <returns>The response from the UpdateIncidentRecord service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateIncidentRecord">REST API Reference for UpdateIncidentRecord Operation</seealso>
        UpdateIncidentRecordResponse UpdateIncidentRecord(UpdateIncidentRecordRequest request);



        /// <summary>
        /// Update the details of an incident record. You can use this operation to update an
        /// incident record from the defined chat channel. For more information about using actions
        /// in chat channels, see <a href="https://docs.aws.amazon.com/incident-manager/latest/userguide/chat.html#chat-interact">Interacting
        /// through chat</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIncidentRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIncidentRecord service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateIncidentRecord">REST API Reference for UpdateIncidentRecord Operation</seealso>
        Task<UpdateIncidentRecordResponse> UpdateIncidentRecordAsync(UpdateIncidentRecordRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRelatedItems


        /// <summary>
        /// Add or remove related items from the related items tab of an incident record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRelatedItems service method.</param>
        /// 
        /// <returns>The response from the UpdateRelatedItems service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateRelatedItems">REST API Reference for UpdateRelatedItems Operation</seealso>
        UpdateRelatedItemsResponse UpdateRelatedItems(UpdateRelatedItemsRequest request);



        /// <summary>
        /// Add or remove related items from the related items tab of an incident record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRelatedItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRelatedItems service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateRelatedItems">REST API Reference for UpdateRelatedItems Operation</seealso>
        Task<UpdateRelatedItemsResponse> UpdateRelatedItemsAsync(UpdateRelatedItemsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateReplicationSet


        /// <summary>
        /// Add or delete Regions from your replication set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationSet service method.</param>
        /// 
        /// <returns>The response from the UpdateReplicationSet service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateReplicationSet">REST API Reference for UpdateReplicationSet Operation</seealso>
        UpdateReplicationSetResponse UpdateReplicationSet(UpdateReplicationSetRequest request);



        /// <summary>
        /// Add or delete Regions from your replication set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateReplicationSet service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateReplicationSet">REST API Reference for UpdateReplicationSet Operation</seealso>
        Task<UpdateReplicationSetResponse> UpdateReplicationSetAsync(UpdateReplicationSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateResponsePlan


        /// <summary>
        /// Updates the specified response plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResponsePlan service method.</param>
        /// 
        /// <returns>The response from the UpdateResponsePlan service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateResponsePlan">REST API Reference for UpdateResponsePlan Operation</seealso>
        UpdateResponsePlanResponse UpdateResponsePlan(UpdateResponsePlanRequest request);



        /// <summary>
        /// Updates the specified response plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResponsePlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResponsePlan service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateResponsePlan">REST API Reference for UpdateResponsePlan Operation</seealso>
        Task<UpdateResponsePlanResponse> UpdateResponsePlanAsync(UpdateResponsePlanRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateTimelineEvent


        /// <summary>
        /// Updates a timeline event. You can update events of type <c>Custom Event</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTimelineEvent service method.</param>
        /// 
        /// <returns>The response from the UpdateTimelineEvent service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateTimelineEvent">REST API Reference for UpdateTimelineEvent Operation</seealso>
        UpdateTimelineEventResponse UpdateTimelineEvent(UpdateTimelineEventRequest request);



        /// <summary>
        /// Updates a timeline event. You can update events of type <c>Custom Event</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTimelineEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTimelineEvent service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateTimelineEvent">REST API Reference for UpdateTimelineEvent Operation</seealso>
        Task<UpdateTimelineEventResponse> UpdateTimelineEventAsync(UpdateTimelineEventRequest request, CancellationToken cancellationToken = default(CancellationToken));

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