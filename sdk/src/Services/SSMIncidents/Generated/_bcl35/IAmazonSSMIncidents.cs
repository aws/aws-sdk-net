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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SSMIncidents.Model;

namespace Amazon.SSMIncidents
{
    /// <summary>
    /// Interface for accessing SSMIncidents
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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISSMIncidentsPaginatorFactory Paginators { get; }
#endif


        
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
        /// Initiates the asynchronous execution of the CreateReplicationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationSet operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReplicationSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/CreateReplicationSet">REST API Reference for CreateReplicationSet Operation</seealso>
        IAsyncResult BeginCreateReplicationSet(CreateReplicationSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReplicationSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReplicationSet.</param>
        /// 
        /// <returns>Returns a  CreateReplicationSetResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/CreateReplicationSet">REST API Reference for CreateReplicationSet Operation</seealso>
        CreateReplicationSetResponse EndCreateReplicationSet(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateResponsePlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResponsePlan operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResponsePlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/CreateResponsePlan">REST API Reference for CreateResponsePlan Operation</seealso>
        IAsyncResult BeginCreateResponsePlan(CreateResponsePlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResponsePlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResponsePlan.</param>
        /// 
        /// <returns>Returns a  CreateResponsePlanResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/CreateResponsePlan">REST API Reference for CreateResponsePlan Operation</seealso>
        CreateResponsePlanResponse EndCreateResponsePlan(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateTimelineEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTimelineEvent operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTimelineEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/CreateTimelineEvent">REST API Reference for CreateTimelineEvent Operation</seealso>
        IAsyncResult BeginCreateTimelineEvent(CreateTimelineEventRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTimelineEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTimelineEvent.</param>
        /// 
        /// <returns>Returns a  CreateTimelineEventResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/CreateTimelineEvent">REST API Reference for CreateTimelineEvent Operation</seealso>
        CreateTimelineEventResponse EndCreateTimelineEvent(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteIncidentRecord operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIncidentRecord operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIncidentRecord
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/DeleteIncidentRecord">REST API Reference for DeleteIncidentRecord Operation</seealso>
        IAsyncResult BeginDeleteIncidentRecord(DeleteIncidentRecordRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIncidentRecord operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIncidentRecord.</param>
        /// 
        /// <returns>Returns a  DeleteIncidentRecordResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/DeleteIncidentRecord">REST API Reference for DeleteIncidentRecord Operation</seealso>
        DeleteIncidentRecordResponse EndDeleteIncidentRecord(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteReplicationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationSet operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReplicationSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/DeleteReplicationSet">REST API Reference for DeleteReplicationSet Operation</seealso>
        IAsyncResult BeginDeleteReplicationSet(DeleteReplicationSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReplicationSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReplicationSet.</param>
        /// 
        /// <returns>Returns a  DeleteReplicationSetResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/DeleteReplicationSet">REST API Reference for DeleteReplicationSet Operation</seealso>
        DeleteReplicationSetResponse EndDeleteReplicationSet(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        IAsyncResult BeginDeleteResourcePolicy(DeleteResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePolicyResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse EndDeleteResourcePolicy(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteResponsePlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResponsePlan operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResponsePlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/DeleteResponsePlan">REST API Reference for DeleteResponsePlan Operation</seealso>
        IAsyncResult BeginDeleteResponsePlan(DeleteResponsePlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResponsePlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResponsePlan.</param>
        /// 
        /// <returns>Returns a  DeleteResponsePlanResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/DeleteResponsePlan">REST API Reference for DeleteResponsePlan Operation</seealso>
        DeleteResponsePlanResponse EndDeleteResponsePlan(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteTimelineEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTimelineEvent operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTimelineEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/DeleteTimelineEvent">REST API Reference for DeleteTimelineEvent Operation</seealso>
        IAsyncResult BeginDeleteTimelineEvent(DeleteTimelineEventRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTimelineEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTimelineEvent.</param>
        /// 
        /// <returns>Returns a  DeleteTimelineEventResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/DeleteTimelineEvent">REST API Reference for DeleteTimelineEvent Operation</seealso>
        DeleteTimelineEventResponse EndDeleteTimelineEvent(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetIncidentRecord operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIncidentRecord operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIncidentRecord
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/GetIncidentRecord">REST API Reference for GetIncidentRecord Operation</seealso>
        IAsyncResult BeginGetIncidentRecord(GetIncidentRecordRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIncidentRecord operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIncidentRecord.</param>
        /// 
        /// <returns>Returns a  GetIncidentRecordResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/GetIncidentRecord">REST API Reference for GetIncidentRecord Operation</seealso>
        GetIncidentRecordResponse EndGetIncidentRecord(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetReplicationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationSet operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReplicationSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/GetReplicationSet">REST API Reference for GetReplicationSet Operation</seealso>
        IAsyncResult BeginGetReplicationSet(GetReplicationSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetReplicationSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReplicationSet.</param>
        /// 
        /// <returns>Returns a  GetReplicationSetResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/GetReplicationSet">REST API Reference for GetReplicationSet Operation</seealso>
        GetReplicationSetResponse EndGetReplicationSet(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetResourcePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicies operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/GetResourcePolicies">REST API Reference for GetResourcePolicies Operation</seealso>
        IAsyncResult BeginGetResourcePolicies(GetResourcePoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePolicies.</param>
        /// 
        /// <returns>Returns a  GetResourcePoliciesResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/GetResourcePolicies">REST API Reference for GetResourcePolicies Operation</seealso>
        GetResourcePoliciesResponse EndGetResourcePolicies(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetResponsePlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResponsePlan operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResponsePlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/GetResponsePlan">REST API Reference for GetResponsePlan Operation</seealso>
        IAsyncResult BeginGetResponsePlan(GetResponsePlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResponsePlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResponsePlan.</param>
        /// 
        /// <returns>Returns a  GetResponsePlanResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/GetResponsePlan">REST API Reference for GetResponsePlan Operation</seealso>
        GetResponsePlanResponse EndGetResponsePlan(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetTimelineEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTimelineEvent operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTimelineEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/GetTimelineEvent">REST API Reference for GetTimelineEvent Operation</seealso>
        IAsyncResult BeginGetTimelineEvent(GetTimelineEventRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTimelineEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTimelineEvent.</param>
        /// 
        /// <returns>Returns a  GetTimelineEventResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/GetTimelineEvent">REST API Reference for GetTimelineEvent Operation</seealso>
        GetTimelineEventResponse EndGetTimelineEvent(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListIncidentRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIncidentRecords operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIncidentRecords
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListIncidentRecords">REST API Reference for ListIncidentRecords Operation</seealso>
        IAsyncResult BeginListIncidentRecords(ListIncidentRecordsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIncidentRecords operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIncidentRecords.</param>
        /// 
        /// <returns>Returns a  ListIncidentRecordsResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListIncidentRecords">REST API Reference for ListIncidentRecords Operation</seealso>
        ListIncidentRecordsResponse EndListIncidentRecords(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListRelatedItems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRelatedItems operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRelatedItems
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListRelatedItems">REST API Reference for ListRelatedItems Operation</seealso>
        IAsyncResult BeginListRelatedItems(ListRelatedItemsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRelatedItems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRelatedItems.</param>
        /// 
        /// <returns>Returns a  ListRelatedItemsResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListRelatedItems">REST API Reference for ListRelatedItems Operation</seealso>
        ListRelatedItemsResponse EndListRelatedItems(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListReplicationSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReplicationSets operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReplicationSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListReplicationSets">REST API Reference for ListReplicationSets Operation</seealso>
        IAsyncResult BeginListReplicationSets(ListReplicationSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListReplicationSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReplicationSets.</param>
        /// 
        /// <returns>Returns a  ListReplicationSetsResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListReplicationSets">REST API Reference for ListReplicationSets Operation</seealso>
        ListReplicationSetsResponse EndListReplicationSets(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListResponsePlans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResponsePlans operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResponsePlans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListResponsePlans">REST API Reference for ListResponsePlans Operation</seealso>
        IAsyncResult BeginListResponsePlans(ListResponsePlansRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResponsePlans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResponsePlans.</param>
        /// 
        /// <returns>Returns a  ListResponsePlansResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListResponsePlans">REST API Reference for ListResponsePlans Operation</seealso>
        ListResponsePlansResponse EndListResponsePlans(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags that are attached to the specified response plan.
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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTimelineEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTimelineEvents operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTimelineEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListTimelineEvents">REST API Reference for ListTimelineEvents Operation</seealso>
        IAsyncResult BeginListTimelineEvents(ListTimelineEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTimelineEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTimelineEvents.</param>
        /// 
        /// <returns>Returns a  ListTimelineEventsResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListTimelineEvents">REST API Reference for ListTimelineEvents Operation</seealso>
        ListTimelineEventsResponse EndListTimelineEvents(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        IAsyncResult BeginPutResourcePolicy(PutResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourcePolicy.</param>
        /// 
        /// <returns>Returns a  PutResourcePolicyResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse EndPutResourcePolicy(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the StartIncident operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartIncident operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartIncident
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/StartIncident">REST API Reference for StartIncident Operation</seealso>
        IAsyncResult BeginStartIncident(StartIncidentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartIncident operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartIncident.</param>
        /// 
        /// <returns>Returns a  StartIncidentResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/StartIncident">REST API Reference for StartIncident Operation</seealso>
        StartIncidentResponse EndStartIncident(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateDeletionProtection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeletionProtection operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDeletionProtection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateDeletionProtection">REST API Reference for UpdateDeletionProtection Operation</seealso>
        IAsyncResult BeginUpdateDeletionProtection(UpdateDeletionProtectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDeletionProtection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDeletionProtection.</param>
        /// 
        /// <returns>Returns a  UpdateDeletionProtectionResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateDeletionProtection">REST API Reference for UpdateDeletionProtection Operation</seealso>
        UpdateDeletionProtectionResponse EndUpdateDeletionProtection(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateIncidentRecord operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIncidentRecord operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIncidentRecord
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateIncidentRecord">REST API Reference for UpdateIncidentRecord Operation</seealso>
        IAsyncResult BeginUpdateIncidentRecord(UpdateIncidentRecordRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIncidentRecord operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIncidentRecord.</param>
        /// 
        /// <returns>Returns a  UpdateIncidentRecordResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateIncidentRecord">REST API Reference for UpdateIncidentRecord Operation</seealso>
        UpdateIncidentRecordResponse EndUpdateIncidentRecord(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateRelatedItems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRelatedItems operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRelatedItems
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateRelatedItems">REST API Reference for UpdateRelatedItems Operation</seealso>
        IAsyncResult BeginUpdateRelatedItems(UpdateRelatedItemsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRelatedItems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRelatedItems.</param>
        /// 
        /// <returns>Returns a  UpdateRelatedItemsResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateRelatedItems">REST API Reference for UpdateRelatedItems Operation</seealso>
        UpdateRelatedItemsResponse EndUpdateRelatedItems(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateReplicationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationSet operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateReplicationSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateReplicationSet">REST API Reference for UpdateReplicationSet Operation</seealso>
        IAsyncResult BeginUpdateReplicationSet(UpdateReplicationSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateReplicationSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateReplicationSet.</param>
        /// 
        /// <returns>Returns a  UpdateReplicationSetResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateReplicationSet">REST API Reference for UpdateReplicationSet Operation</seealso>
        UpdateReplicationSetResponse EndUpdateReplicationSet(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateResponsePlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResponsePlan operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResponsePlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateResponsePlan">REST API Reference for UpdateResponsePlan Operation</seealso>
        IAsyncResult BeginUpdateResponsePlan(UpdateResponsePlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResponsePlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResponsePlan.</param>
        /// 
        /// <returns>Returns a  UpdateResponsePlanResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateResponsePlan">REST API Reference for UpdateResponsePlan Operation</seealso>
        UpdateResponsePlanResponse EndUpdateResponsePlan(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTimelineEvent


        /// <summary>
        /// Updates a timeline event. You can update events of type <code>Custom Event</code>.
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
        /// Initiates the asynchronous execution of the UpdateTimelineEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTimelineEvent operation on AmazonSSMIncidentsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTimelineEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateTimelineEvent">REST API Reference for UpdateTimelineEvent Operation</seealso>
        IAsyncResult BeginUpdateTimelineEvent(UpdateTimelineEventRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTimelineEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTimelineEvent.</param>
        /// 
        /// <returns>Returns a  UpdateTimelineEventResult from SSMIncidents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateTimelineEvent">REST API Reference for UpdateTimelineEvent Operation</seealso>
        UpdateTimelineEventResponse EndUpdateTimelineEvent(IAsyncResult asyncResult);

        #endregion
        
    }
}