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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Finspace.Model;

namespace Amazon.Finspace
{
    /// <summary>
    /// <para>Interface for accessing Finspace</para>
    ///
    /// The FinSpace management service provides the APIs for managing FinSpace environments.
    /// </summary>
    public partial interface IAmazonFinspace : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IFinspacePaginatorFactory Paginators { get; }
#endif


        
        #region  CreateEnvironment


        /// <summary>
        /// Create a new FinSpace environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        IAsyncResult BeginCreateEnvironment(CreateEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEnvironment.</param>
        /// 
        /// <returns>Returns a  CreateEnvironmentResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        CreateEnvironmentResponse EndCreateEnvironment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateKxChangeset


        /// <summary>
        /// Creates a changeset for a kdb database. A changeset allows you to add and delete
        /// existing files by using an ordered list of change requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKxChangeset service method.</param>
        /// 
        /// <returns>The response from the CreateKxChangeset service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxChangeset">REST API Reference for CreateKxChangeset Operation</seealso>
        CreateKxChangesetResponse CreateKxChangeset(CreateKxChangesetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKxChangeset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKxChangeset operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKxChangeset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxChangeset">REST API Reference for CreateKxChangeset Operation</seealso>
        IAsyncResult BeginCreateKxChangeset(CreateKxChangesetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKxChangeset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKxChangeset.</param>
        /// 
        /// <returns>Returns a  CreateKxChangesetResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxChangeset">REST API Reference for CreateKxChangeset Operation</seealso>
        CreateKxChangesetResponse EndCreateKxChangeset(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateKxCluster


        /// <summary>
        /// Creates a new kdb cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKxCluster service method.</param>
        /// 
        /// <returns>The response from the CreateKxCluster service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxCluster">REST API Reference for CreateKxCluster Operation</seealso>
        CreateKxClusterResponse CreateKxCluster(CreateKxClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKxCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKxCluster operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKxCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxCluster">REST API Reference for CreateKxCluster Operation</seealso>
        IAsyncResult BeginCreateKxCluster(CreateKxClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKxCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKxCluster.</param>
        /// 
        /// <returns>Returns a  CreateKxClusterResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxCluster">REST API Reference for CreateKxCluster Operation</seealso>
        CreateKxClusterResponse EndCreateKxCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateKxDatabase


        /// <summary>
        /// Creates a new kdb database in the environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKxDatabase service method.</param>
        /// 
        /// <returns>The response from the CreateKxDatabase service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceAlreadyExistsException">
        /// The specified resource group already exists.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxDatabase">REST API Reference for CreateKxDatabase Operation</seealso>
        CreateKxDatabaseResponse CreateKxDatabase(CreateKxDatabaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKxDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKxDatabase operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKxDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxDatabase">REST API Reference for CreateKxDatabase Operation</seealso>
        IAsyncResult BeginCreateKxDatabase(CreateKxDatabaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKxDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKxDatabase.</param>
        /// 
        /// <returns>Returns a  CreateKxDatabaseResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxDatabase">REST API Reference for CreateKxDatabase Operation</seealso>
        CreateKxDatabaseResponse EndCreateKxDatabase(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateKxDataview


        /// <summary>
        /// Creates a snapshot of kdb database with tiered storage capabilities and a pre-warmed
        /// cache, ready for mounting on kdb clusters. Dataviews are only available for clusters
        /// running on a scaling group. They are not supported on dedicated clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKxDataview service method.</param>
        /// 
        /// <returns>The response from the CreateKxDataview service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceAlreadyExistsException">
        /// The specified resource group already exists.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxDataview">REST API Reference for CreateKxDataview Operation</seealso>
        CreateKxDataviewResponse CreateKxDataview(CreateKxDataviewRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKxDataview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKxDataview operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKxDataview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxDataview">REST API Reference for CreateKxDataview Operation</seealso>
        IAsyncResult BeginCreateKxDataview(CreateKxDataviewRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKxDataview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKxDataview.</param>
        /// 
        /// <returns>Returns a  CreateKxDataviewResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxDataview">REST API Reference for CreateKxDataview Operation</seealso>
        CreateKxDataviewResponse EndCreateKxDataview(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateKxEnvironment


        /// <summary>
        /// Creates a managed kdb environment for the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKxEnvironment service method.</param>
        /// 
        /// <returns>The response from the CreateKxEnvironment service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxEnvironment">REST API Reference for CreateKxEnvironment Operation</seealso>
        CreateKxEnvironmentResponse CreateKxEnvironment(CreateKxEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKxEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKxEnvironment operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKxEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxEnvironment">REST API Reference for CreateKxEnvironment Operation</seealso>
        IAsyncResult BeginCreateKxEnvironment(CreateKxEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKxEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKxEnvironment.</param>
        /// 
        /// <returns>Returns a  CreateKxEnvironmentResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxEnvironment">REST API Reference for CreateKxEnvironment Operation</seealso>
        CreateKxEnvironmentResponse EndCreateKxEnvironment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateKxScalingGroup


        /// <summary>
        /// Creates a new scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKxScalingGroup service method.</param>
        /// 
        /// <returns>The response from the CreateKxScalingGroup service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxScalingGroup">REST API Reference for CreateKxScalingGroup Operation</seealso>
        CreateKxScalingGroupResponse CreateKxScalingGroup(CreateKxScalingGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKxScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKxScalingGroup operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKxScalingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxScalingGroup">REST API Reference for CreateKxScalingGroup Operation</seealso>
        IAsyncResult BeginCreateKxScalingGroup(CreateKxScalingGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKxScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKxScalingGroup.</param>
        /// 
        /// <returns>Returns a  CreateKxScalingGroupResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxScalingGroup">REST API Reference for CreateKxScalingGroup Operation</seealso>
        CreateKxScalingGroupResponse EndCreateKxScalingGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateKxUser


        /// <summary>
        /// Creates a user in FinSpace kdb environment with an associated IAM role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKxUser service method.</param>
        /// 
        /// <returns>The response from the CreateKxUser service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceAlreadyExistsException">
        /// The specified resource group already exists.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxUser">REST API Reference for CreateKxUser Operation</seealso>
        CreateKxUserResponse CreateKxUser(CreateKxUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKxUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKxUser operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKxUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxUser">REST API Reference for CreateKxUser Operation</seealso>
        IAsyncResult BeginCreateKxUser(CreateKxUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKxUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKxUser.</param>
        /// 
        /// <returns>Returns a  CreateKxUserResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxUser">REST API Reference for CreateKxUser Operation</seealso>
        CreateKxUserResponse EndCreateKxUser(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateKxVolume


        /// <summary>
        /// Creates a new volume with a specific amount of throughput and storage capacity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKxVolume service method.</param>
        /// 
        /// <returns>The response from the CreateKxVolume service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceAlreadyExistsException">
        /// The specified resource group already exists.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxVolume">REST API Reference for CreateKxVolume Operation</seealso>
        CreateKxVolumeResponse CreateKxVolume(CreateKxVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKxVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKxVolume operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKxVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxVolume">REST API Reference for CreateKxVolume Operation</seealso>
        IAsyncResult BeginCreateKxVolume(CreateKxVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKxVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKxVolume.</param>
        /// 
        /// <returns>Returns a  CreateKxVolumeResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/CreateKxVolume">REST API Reference for CreateKxVolume Operation</seealso>
        CreateKxVolumeResponse EndCreateKxVolume(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEnvironment


        /// <summary>
        /// Delete an FinSpace environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironment service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        DeleteEnvironmentResponse DeleteEnvironment(DeleteEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        IAsyncResult BeginDeleteEnvironment(DeleteEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEnvironment.</param>
        /// 
        /// <returns>Returns a  DeleteEnvironmentResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        DeleteEnvironmentResponse EndDeleteEnvironment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteKxCluster


        /// <summary>
        /// Deletes a kdb cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteKxCluster service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxCluster">REST API Reference for DeleteKxCluster Operation</seealso>
        DeleteKxClusterResponse DeleteKxCluster(DeleteKxClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKxCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxCluster operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKxCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxCluster">REST API Reference for DeleteKxCluster Operation</seealso>
        IAsyncResult BeginDeleteKxCluster(DeleteKxClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKxCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKxCluster.</param>
        /// 
        /// <returns>Returns a  DeleteKxClusterResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxCluster">REST API Reference for DeleteKxCluster Operation</seealso>
        DeleteKxClusterResponse EndDeleteKxCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteKxClusterNode


        /// <summary>
        /// Deletes the specified nodes from a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxClusterNode service method.</param>
        /// 
        /// <returns>The response from the DeleteKxClusterNode service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxClusterNode">REST API Reference for DeleteKxClusterNode Operation</seealso>
        DeleteKxClusterNodeResponse DeleteKxClusterNode(DeleteKxClusterNodeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKxClusterNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxClusterNode operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKxClusterNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxClusterNode">REST API Reference for DeleteKxClusterNode Operation</seealso>
        IAsyncResult BeginDeleteKxClusterNode(DeleteKxClusterNodeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKxClusterNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKxClusterNode.</param>
        /// 
        /// <returns>Returns a  DeleteKxClusterNodeResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxClusterNode">REST API Reference for DeleteKxClusterNode Operation</seealso>
        DeleteKxClusterNodeResponse EndDeleteKxClusterNode(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteKxDatabase


        /// <summary>
        /// Deletes the specified database and all of its associated data. This action is irreversible.
        /// You must copy any data out of the database before deleting it if the data is to be
        /// retained.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxDatabase service method.</param>
        /// 
        /// <returns>The response from the DeleteKxDatabase service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxDatabase">REST API Reference for DeleteKxDatabase Operation</seealso>
        DeleteKxDatabaseResponse DeleteKxDatabase(DeleteKxDatabaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKxDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxDatabase operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKxDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxDatabase">REST API Reference for DeleteKxDatabase Operation</seealso>
        IAsyncResult BeginDeleteKxDatabase(DeleteKxDatabaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKxDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKxDatabase.</param>
        /// 
        /// <returns>Returns a  DeleteKxDatabaseResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxDatabase">REST API Reference for DeleteKxDatabase Operation</seealso>
        DeleteKxDatabaseResponse EndDeleteKxDatabase(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteKxDataview


        /// <summary>
        /// Deletes the specified dataview. Before deleting a dataview, make sure that it is
        /// not in use by any cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxDataview service method.</param>
        /// 
        /// <returns>The response from the DeleteKxDataview service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxDataview">REST API Reference for DeleteKxDataview Operation</seealso>
        DeleteKxDataviewResponse DeleteKxDataview(DeleteKxDataviewRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKxDataview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxDataview operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKxDataview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxDataview">REST API Reference for DeleteKxDataview Operation</seealso>
        IAsyncResult BeginDeleteKxDataview(DeleteKxDataviewRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKxDataview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKxDataview.</param>
        /// 
        /// <returns>Returns a  DeleteKxDataviewResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxDataview">REST API Reference for DeleteKxDataview Operation</seealso>
        DeleteKxDataviewResponse EndDeleteKxDataview(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteKxEnvironment


        /// <summary>
        /// Deletes the kdb environment. This action is irreversible. Deleting a kdb environment
        /// will remove all the associated data and any services running in it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxEnvironment service method.</param>
        /// 
        /// <returns>The response from the DeleteKxEnvironment service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxEnvironment">REST API Reference for DeleteKxEnvironment Operation</seealso>
        DeleteKxEnvironmentResponse DeleteKxEnvironment(DeleteKxEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKxEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxEnvironment operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKxEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxEnvironment">REST API Reference for DeleteKxEnvironment Operation</seealso>
        IAsyncResult BeginDeleteKxEnvironment(DeleteKxEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKxEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKxEnvironment.</param>
        /// 
        /// <returns>Returns a  DeleteKxEnvironmentResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxEnvironment">REST API Reference for DeleteKxEnvironment Operation</seealso>
        DeleteKxEnvironmentResponse EndDeleteKxEnvironment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteKxScalingGroup


        /// <summary>
        /// Deletes the specified scaling group. This action is irreversible. You cannot delete
        /// a scaling group until all the clusters running on it have been deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxScalingGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteKxScalingGroup service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxScalingGroup">REST API Reference for DeleteKxScalingGroup Operation</seealso>
        DeleteKxScalingGroupResponse DeleteKxScalingGroup(DeleteKxScalingGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKxScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxScalingGroup operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKxScalingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxScalingGroup">REST API Reference for DeleteKxScalingGroup Operation</seealso>
        IAsyncResult BeginDeleteKxScalingGroup(DeleteKxScalingGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKxScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKxScalingGroup.</param>
        /// 
        /// <returns>Returns a  DeleteKxScalingGroupResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxScalingGroup">REST API Reference for DeleteKxScalingGroup Operation</seealso>
        DeleteKxScalingGroupResponse EndDeleteKxScalingGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteKxUser


        /// <summary>
        /// Deletes a user in the specified kdb environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxUser service method.</param>
        /// 
        /// <returns>The response from the DeleteKxUser service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxUser">REST API Reference for DeleteKxUser Operation</seealso>
        DeleteKxUserResponse DeleteKxUser(DeleteKxUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKxUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxUser operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKxUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxUser">REST API Reference for DeleteKxUser Operation</seealso>
        IAsyncResult BeginDeleteKxUser(DeleteKxUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKxUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKxUser.</param>
        /// 
        /// <returns>Returns a  DeleteKxUserResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxUser">REST API Reference for DeleteKxUser Operation</seealso>
        DeleteKxUserResponse EndDeleteKxUser(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteKxVolume


        /// <summary>
        /// Deletes a volume. You can only delete a volume if it's not attached to a cluster
        /// or a dataview. When a volume is deleted, any data on the volume is lost. This action
        /// is irreversible.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxVolume service method.</param>
        /// 
        /// <returns>The response from the DeleteKxVolume service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxVolume">REST API Reference for DeleteKxVolume Operation</seealso>
        DeleteKxVolumeResponse DeleteKxVolume(DeleteKxVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKxVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKxVolume operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKxVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxVolume">REST API Reference for DeleteKxVolume Operation</seealso>
        IAsyncResult BeginDeleteKxVolume(DeleteKxVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKxVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKxVolume.</param>
        /// 
        /// <returns>Returns a  DeleteKxVolumeResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/DeleteKxVolume">REST API Reference for DeleteKxVolume Operation</seealso>
        DeleteKxVolumeResponse EndDeleteKxVolume(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEnvironment


        /// <summary>
        /// Returns the FinSpace environment object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// 
        /// <returns>The response from the GetEnvironment service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        GetEnvironmentResponse GetEnvironment(GetEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        IAsyncResult BeginGetEnvironment(GetEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEnvironment.</param>
        /// 
        /// <returns>Returns a  GetEnvironmentResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        GetEnvironmentResponse EndGetEnvironment(IAsyncResult asyncResult);

        #endregion
        
        #region  GetKxChangeset


        /// <summary>
        /// Returns information about a kdb changeset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxChangeset service method.</param>
        /// 
        /// <returns>The response from the GetKxChangeset service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxChangeset">REST API Reference for GetKxChangeset Operation</seealso>
        GetKxChangesetResponse GetKxChangeset(GetKxChangesetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetKxChangeset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKxChangeset operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKxChangeset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxChangeset">REST API Reference for GetKxChangeset Operation</seealso>
        IAsyncResult BeginGetKxChangeset(GetKxChangesetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetKxChangeset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKxChangeset.</param>
        /// 
        /// <returns>Returns a  GetKxChangesetResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxChangeset">REST API Reference for GetKxChangeset Operation</seealso>
        GetKxChangesetResponse EndGetKxChangeset(IAsyncResult asyncResult);

        #endregion
        
        #region  GetKxCluster


        /// <summary>
        /// Retrieves information about a kdb cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxCluster service method.</param>
        /// 
        /// <returns>The response from the GetKxCluster service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxCluster">REST API Reference for GetKxCluster Operation</seealso>
        GetKxClusterResponse GetKxCluster(GetKxClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetKxCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKxCluster operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKxCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxCluster">REST API Reference for GetKxCluster Operation</seealso>
        IAsyncResult BeginGetKxCluster(GetKxClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetKxCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKxCluster.</param>
        /// 
        /// <returns>Returns a  GetKxClusterResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxCluster">REST API Reference for GetKxCluster Operation</seealso>
        GetKxClusterResponse EndGetKxCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  GetKxConnectionString


        /// <summary>
        /// Retrieves a connection string for a user to connect to a kdb cluster. You must call
        /// this API using the same role that you have defined while creating a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxConnectionString service method.</param>
        /// 
        /// <returns>The response from the GetKxConnectionString service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxConnectionString">REST API Reference for GetKxConnectionString Operation</seealso>
        GetKxConnectionStringResponse GetKxConnectionString(GetKxConnectionStringRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetKxConnectionString operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKxConnectionString operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKxConnectionString
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxConnectionString">REST API Reference for GetKxConnectionString Operation</seealso>
        IAsyncResult BeginGetKxConnectionString(GetKxConnectionStringRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetKxConnectionString operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKxConnectionString.</param>
        /// 
        /// <returns>Returns a  GetKxConnectionStringResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxConnectionString">REST API Reference for GetKxConnectionString Operation</seealso>
        GetKxConnectionStringResponse EndGetKxConnectionString(IAsyncResult asyncResult);

        #endregion
        
        #region  GetKxDatabase


        /// <summary>
        /// Returns database information for the specified environment ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxDatabase service method.</param>
        /// 
        /// <returns>The response from the GetKxDatabase service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxDatabase">REST API Reference for GetKxDatabase Operation</seealso>
        GetKxDatabaseResponse GetKxDatabase(GetKxDatabaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetKxDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKxDatabase operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKxDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxDatabase">REST API Reference for GetKxDatabase Operation</seealso>
        IAsyncResult BeginGetKxDatabase(GetKxDatabaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetKxDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKxDatabase.</param>
        /// 
        /// <returns>Returns a  GetKxDatabaseResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxDatabase">REST API Reference for GetKxDatabase Operation</seealso>
        GetKxDatabaseResponse EndGetKxDatabase(IAsyncResult asyncResult);

        #endregion
        
        #region  GetKxDataview


        /// <summary>
        /// Retrieves details of the dataview.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxDataview service method.</param>
        /// 
        /// <returns>The response from the GetKxDataview service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxDataview">REST API Reference for GetKxDataview Operation</seealso>
        GetKxDataviewResponse GetKxDataview(GetKxDataviewRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetKxDataview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKxDataview operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKxDataview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxDataview">REST API Reference for GetKxDataview Operation</seealso>
        IAsyncResult BeginGetKxDataview(GetKxDataviewRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetKxDataview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKxDataview.</param>
        /// 
        /// <returns>Returns a  GetKxDataviewResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxDataview">REST API Reference for GetKxDataview Operation</seealso>
        GetKxDataviewResponse EndGetKxDataview(IAsyncResult asyncResult);

        #endregion
        
        #region  GetKxEnvironment


        /// <summary>
        /// Retrieves all the information for the specified kdb environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxEnvironment service method.</param>
        /// 
        /// <returns>The response from the GetKxEnvironment service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxEnvironment">REST API Reference for GetKxEnvironment Operation</seealso>
        GetKxEnvironmentResponse GetKxEnvironment(GetKxEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetKxEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKxEnvironment operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKxEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxEnvironment">REST API Reference for GetKxEnvironment Operation</seealso>
        IAsyncResult BeginGetKxEnvironment(GetKxEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetKxEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKxEnvironment.</param>
        /// 
        /// <returns>Returns a  GetKxEnvironmentResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxEnvironment">REST API Reference for GetKxEnvironment Operation</seealso>
        GetKxEnvironmentResponse EndGetKxEnvironment(IAsyncResult asyncResult);

        #endregion
        
        #region  GetKxScalingGroup


        /// <summary>
        /// Retrieves details of a scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxScalingGroup service method.</param>
        /// 
        /// <returns>The response from the GetKxScalingGroup service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxScalingGroup">REST API Reference for GetKxScalingGroup Operation</seealso>
        GetKxScalingGroupResponse GetKxScalingGroup(GetKxScalingGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetKxScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKxScalingGroup operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKxScalingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxScalingGroup">REST API Reference for GetKxScalingGroup Operation</seealso>
        IAsyncResult BeginGetKxScalingGroup(GetKxScalingGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetKxScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKxScalingGroup.</param>
        /// 
        /// <returns>Returns a  GetKxScalingGroupResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxScalingGroup">REST API Reference for GetKxScalingGroup Operation</seealso>
        GetKxScalingGroupResponse EndGetKxScalingGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  GetKxUser


        /// <summary>
        /// Retrieves information about the specified kdb user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxUser service method.</param>
        /// 
        /// <returns>The response from the GetKxUser service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxUser">REST API Reference for GetKxUser Operation</seealso>
        GetKxUserResponse GetKxUser(GetKxUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetKxUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKxUser operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKxUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxUser">REST API Reference for GetKxUser Operation</seealso>
        IAsyncResult BeginGetKxUser(GetKxUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetKxUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKxUser.</param>
        /// 
        /// <returns>Returns a  GetKxUserResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxUser">REST API Reference for GetKxUser Operation</seealso>
        GetKxUserResponse EndGetKxUser(IAsyncResult asyncResult);

        #endregion
        
        #region  GetKxVolume


        /// <summary>
        /// Retrieves the information about the volume.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKxVolume service method.</param>
        /// 
        /// <returns>The response from the GetKxVolume service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxVolume">REST API Reference for GetKxVolume Operation</seealso>
        GetKxVolumeResponse GetKxVolume(GetKxVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetKxVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKxVolume operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKxVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxVolume">REST API Reference for GetKxVolume Operation</seealso>
        IAsyncResult BeginGetKxVolume(GetKxVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetKxVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKxVolume.</param>
        /// 
        /// <returns>Returns a  GetKxVolumeResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/GetKxVolume">REST API Reference for GetKxVolume Operation</seealso>
        GetKxVolumeResponse EndGetKxVolume(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEnvironments


        /// <summary>
        /// A list of all of your FinSpace environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// 
        /// <returns>The response from the ListEnvironments service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEnvironments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        IAsyncResult BeginListEnvironments(ListEnvironmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEnvironments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEnvironments.</param>
        /// 
        /// <returns>Returns a  ListEnvironmentsResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        ListEnvironmentsResponse EndListEnvironments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListKxChangesets


        /// <summary>
        /// Returns a list of all the changesets for a database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxChangesets service method.</param>
        /// 
        /// <returns>The response from the ListKxChangesets service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxChangesets">REST API Reference for ListKxChangesets Operation</seealso>
        ListKxChangesetsResponse ListKxChangesets(ListKxChangesetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListKxChangesets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKxChangesets operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKxChangesets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxChangesets">REST API Reference for ListKxChangesets Operation</seealso>
        IAsyncResult BeginListKxChangesets(ListKxChangesetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListKxChangesets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKxChangesets.</param>
        /// 
        /// <returns>Returns a  ListKxChangesetsResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxChangesets">REST API Reference for ListKxChangesets Operation</seealso>
        ListKxChangesetsResponse EndListKxChangesets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListKxClusterNodes


        /// <summary>
        /// Lists all the nodes in a kdb cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxClusterNodes service method.</param>
        /// 
        /// <returns>The response from the ListKxClusterNodes service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxClusterNodes">REST API Reference for ListKxClusterNodes Operation</seealso>
        ListKxClusterNodesResponse ListKxClusterNodes(ListKxClusterNodesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListKxClusterNodes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKxClusterNodes operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKxClusterNodes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxClusterNodes">REST API Reference for ListKxClusterNodes Operation</seealso>
        IAsyncResult BeginListKxClusterNodes(ListKxClusterNodesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListKxClusterNodes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKxClusterNodes.</param>
        /// 
        /// <returns>Returns a  ListKxClusterNodesResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxClusterNodes">REST API Reference for ListKxClusterNodes Operation</seealso>
        ListKxClusterNodesResponse EndListKxClusterNodes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListKxClusters


        /// <summary>
        /// Returns a list of clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxClusters service method.</param>
        /// 
        /// <returns>The response from the ListKxClusters service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxClusters">REST API Reference for ListKxClusters Operation</seealso>
        ListKxClustersResponse ListKxClusters(ListKxClustersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListKxClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKxClusters operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKxClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxClusters">REST API Reference for ListKxClusters Operation</seealso>
        IAsyncResult BeginListKxClusters(ListKxClustersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListKxClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKxClusters.</param>
        /// 
        /// <returns>Returns a  ListKxClustersResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxClusters">REST API Reference for ListKxClusters Operation</seealso>
        ListKxClustersResponse EndListKxClusters(IAsyncResult asyncResult);

        #endregion
        
        #region  ListKxDatabases


        /// <summary>
        /// Returns a list of all the databases in the kdb environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxDatabases service method.</param>
        /// 
        /// <returns>The response from the ListKxDatabases service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxDatabases">REST API Reference for ListKxDatabases Operation</seealso>
        ListKxDatabasesResponse ListKxDatabases(ListKxDatabasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListKxDatabases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKxDatabases operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKxDatabases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxDatabases">REST API Reference for ListKxDatabases Operation</seealso>
        IAsyncResult BeginListKxDatabases(ListKxDatabasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListKxDatabases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKxDatabases.</param>
        /// 
        /// <returns>Returns a  ListKxDatabasesResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxDatabases">REST API Reference for ListKxDatabases Operation</seealso>
        ListKxDatabasesResponse EndListKxDatabases(IAsyncResult asyncResult);

        #endregion
        
        #region  ListKxDataviews


        /// <summary>
        /// Returns a list of all the dataviews in the database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxDataviews service method.</param>
        /// 
        /// <returns>The response from the ListKxDataviews service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxDataviews">REST API Reference for ListKxDataviews Operation</seealso>
        ListKxDataviewsResponse ListKxDataviews(ListKxDataviewsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListKxDataviews operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKxDataviews operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKxDataviews
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxDataviews">REST API Reference for ListKxDataviews Operation</seealso>
        IAsyncResult BeginListKxDataviews(ListKxDataviewsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListKxDataviews operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKxDataviews.</param>
        /// 
        /// <returns>Returns a  ListKxDataviewsResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxDataviews">REST API Reference for ListKxDataviews Operation</seealso>
        ListKxDataviewsResponse EndListKxDataviews(IAsyncResult asyncResult);

        #endregion
        
        #region  ListKxEnvironments


        /// <summary>
        /// Returns a list of kdb environments created in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxEnvironments service method.</param>
        /// 
        /// <returns>The response from the ListKxEnvironments service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxEnvironments">REST API Reference for ListKxEnvironments Operation</seealso>
        ListKxEnvironmentsResponse ListKxEnvironments(ListKxEnvironmentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListKxEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKxEnvironments operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKxEnvironments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxEnvironments">REST API Reference for ListKxEnvironments Operation</seealso>
        IAsyncResult BeginListKxEnvironments(ListKxEnvironmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListKxEnvironments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKxEnvironments.</param>
        /// 
        /// <returns>Returns a  ListKxEnvironmentsResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxEnvironments">REST API Reference for ListKxEnvironments Operation</seealso>
        ListKxEnvironmentsResponse EndListKxEnvironments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListKxScalingGroups


        /// <summary>
        /// Returns a list of scaling groups in a kdb environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxScalingGroups service method.</param>
        /// 
        /// <returns>The response from the ListKxScalingGroups service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxScalingGroups">REST API Reference for ListKxScalingGroups Operation</seealso>
        ListKxScalingGroupsResponse ListKxScalingGroups(ListKxScalingGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListKxScalingGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKxScalingGroups operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKxScalingGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxScalingGroups">REST API Reference for ListKxScalingGroups Operation</seealso>
        IAsyncResult BeginListKxScalingGroups(ListKxScalingGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListKxScalingGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKxScalingGroups.</param>
        /// 
        /// <returns>Returns a  ListKxScalingGroupsResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxScalingGroups">REST API Reference for ListKxScalingGroups Operation</seealso>
        ListKxScalingGroupsResponse EndListKxScalingGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListKxUsers


        /// <summary>
        /// Lists all the users in a kdb environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxUsers service method.</param>
        /// 
        /// <returns>The response from the ListKxUsers service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxUsers">REST API Reference for ListKxUsers Operation</seealso>
        ListKxUsersResponse ListKxUsers(ListKxUsersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListKxUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKxUsers operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKxUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxUsers">REST API Reference for ListKxUsers Operation</seealso>
        IAsyncResult BeginListKxUsers(ListKxUsersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListKxUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKxUsers.</param>
        /// 
        /// <returns>Returns a  ListKxUsersResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxUsers">REST API Reference for ListKxUsers Operation</seealso>
        ListKxUsersResponse EndListKxUsers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListKxVolumes


        /// <summary>
        /// Lists all the volumes in a kdb environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKxVolumes service method.</param>
        /// 
        /// <returns>The response from the ListKxVolumes service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxVolumes">REST API Reference for ListKxVolumes Operation</seealso>
        ListKxVolumesResponse ListKxVolumes(ListKxVolumesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListKxVolumes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKxVolumes operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKxVolumes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxVolumes">REST API Reference for ListKxVolumes Operation</seealso>
        IAsyncResult BeginListKxVolumes(ListKxVolumesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListKxVolumes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKxVolumes.</param>
        /// 
        /// <returns>Returns a  ListKxVolumesResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListKxVolumes">REST API Reference for ListKxVolumes Operation</seealso>
        ListKxVolumesResponse EndListKxVolumes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// A list of all tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InvalidRequestException">
        /// The request is invalid. Something is wrong with the input to the request.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds metadata tags to a FinSpace resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InvalidRequestException">
        /// The request is invalid. Something is wrong with the input to the request.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes metadata tags from a FinSpace resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InvalidRequestException">
        /// The request is invalid. Something is wrong with the input to the request.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEnvironment


        /// <summary>
        /// Update your FinSpace environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        IAsyncResult BeginUpdateEnvironment(UpdateEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEnvironment.</param>
        /// 
        /// <returns>Returns a  UpdateEnvironmentResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        [Obsolete("This method will be discontinued.")]
        UpdateEnvironmentResponse EndUpdateEnvironment(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateKxClusterCodeConfiguration


        /// <summary>
        /// Allows you to update code configuration on a running cluster. By using this API you
        /// can update the code, the initialization script path, and the command line arguments
        /// for a specific cluster. The configuration that you want to update will override any
        /// existing configurations on the cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxClusterCodeConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateKxClusterCodeConfiguration service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxClusterCodeConfiguration">REST API Reference for UpdateKxClusterCodeConfiguration Operation</seealso>
        UpdateKxClusterCodeConfigurationResponse UpdateKxClusterCodeConfiguration(UpdateKxClusterCodeConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKxClusterCodeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxClusterCodeConfiguration operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKxClusterCodeConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxClusterCodeConfiguration">REST API Reference for UpdateKxClusterCodeConfiguration Operation</seealso>
        IAsyncResult BeginUpdateKxClusterCodeConfiguration(UpdateKxClusterCodeConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKxClusterCodeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKxClusterCodeConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateKxClusterCodeConfigurationResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxClusterCodeConfiguration">REST API Reference for UpdateKxClusterCodeConfiguration Operation</seealso>
        UpdateKxClusterCodeConfigurationResponse EndUpdateKxClusterCodeConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateKxClusterDatabases


        /// <summary>
        /// Updates the databases mounted on a kdb cluster, which includes the <c>changesetId</c>
        /// and all the dbPaths to be cached. This API does not allow you to change a database
        /// name or add a database if you created a cluster without one. 
        /// 
        ///  
        /// <para>
        /// Using this API you can point a cluster to a different changeset and modify a list
        /// of partitions being cached.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxClusterDatabases service method.</param>
        /// 
        /// <returns>The response from the UpdateKxClusterDatabases service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxClusterDatabases">REST API Reference for UpdateKxClusterDatabases Operation</seealso>
        UpdateKxClusterDatabasesResponse UpdateKxClusterDatabases(UpdateKxClusterDatabasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKxClusterDatabases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxClusterDatabases operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKxClusterDatabases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxClusterDatabases">REST API Reference for UpdateKxClusterDatabases Operation</seealso>
        IAsyncResult BeginUpdateKxClusterDatabases(UpdateKxClusterDatabasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKxClusterDatabases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKxClusterDatabases.</param>
        /// 
        /// <returns>Returns a  UpdateKxClusterDatabasesResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxClusterDatabases">REST API Reference for UpdateKxClusterDatabases Operation</seealso>
        UpdateKxClusterDatabasesResponse EndUpdateKxClusterDatabases(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateKxDatabase


        /// <summary>
        /// Updates information for the given kdb database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxDatabase service method.</param>
        /// 
        /// <returns>The response from the UpdateKxDatabase service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxDatabase">REST API Reference for UpdateKxDatabase Operation</seealso>
        UpdateKxDatabaseResponse UpdateKxDatabase(UpdateKxDatabaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKxDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxDatabase operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKxDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxDatabase">REST API Reference for UpdateKxDatabase Operation</seealso>
        IAsyncResult BeginUpdateKxDatabase(UpdateKxDatabaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKxDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKxDatabase.</param>
        /// 
        /// <returns>Returns a  UpdateKxDatabaseResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxDatabase">REST API Reference for UpdateKxDatabase Operation</seealso>
        UpdateKxDatabaseResponse EndUpdateKxDatabase(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateKxDataview


        /// <summary>
        /// Updates the specified dataview. The dataviews get automatically updated when any
        /// new changesets are ingested. Each update of the dataview creates a new version, including
        /// changeset details and cache configurations
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxDataview service method.</param>
        /// 
        /// <returns>The response from the UpdateKxDataview service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceAlreadyExistsException">
        /// The specified resource group already exists.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxDataview">REST API Reference for UpdateKxDataview Operation</seealso>
        UpdateKxDataviewResponse UpdateKxDataview(UpdateKxDataviewRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKxDataview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxDataview operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKxDataview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxDataview">REST API Reference for UpdateKxDataview Operation</seealso>
        IAsyncResult BeginUpdateKxDataview(UpdateKxDataviewRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKxDataview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKxDataview.</param>
        /// 
        /// <returns>Returns a  UpdateKxDataviewResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxDataview">REST API Reference for UpdateKxDataview Operation</seealso>
        UpdateKxDataviewResponse EndUpdateKxDataview(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateKxEnvironment


        /// <summary>
        /// Updates information for the given kdb environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxEnvironment service method.</param>
        /// 
        /// <returns>The response from the UpdateKxEnvironment service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxEnvironment">REST API Reference for UpdateKxEnvironment Operation</seealso>
        UpdateKxEnvironmentResponse UpdateKxEnvironment(UpdateKxEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKxEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxEnvironment operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKxEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxEnvironment">REST API Reference for UpdateKxEnvironment Operation</seealso>
        IAsyncResult BeginUpdateKxEnvironment(UpdateKxEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKxEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKxEnvironment.</param>
        /// 
        /// <returns>Returns a  UpdateKxEnvironmentResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxEnvironment">REST API Reference for UpdateKxEnvironment Operation</seealso>
        UpdateKxEnvironmentResponse EndUpdateKxEnvironment(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateKxEnvironmentNetwork


        /// <summary>
        /// Updates environment network to connect to your internal network by using a transit
        /// gateway. This API supports request to create a transit gateway attachment from FinSpace
        /// VPC to your transit gateway ID and create a custom Route-53 outbound resolvers.
        /// 
        ///  
        /// <para>
        /// Once you send a request to update a network, you cannot change it again. Network update
        /// might require termination of any clusters that are running in the existing network.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxEnvironmentNetwork service method.</param>
        /// 
        /// <returns>The response from the UpdateKxEnvironmentNetwork service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxEnvironmentNetwork">REST API Reference for UpdateKxEnvironmentNetwork Operation</seealso>
        UpdateKxEnvironmentNetworkResponse UpdateKxEnvironmentNetwork(UpdateKxEnvironmentNetworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKxEnvironmentNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxEnvironmentNetwork operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKxEnvironmentNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxEnvironmentNetwork">REST API Reference for UpdateKxEnvironmentNetwork Operation</seealso>
        IAsyncResult BeginUpdateKxEnvironmentNetwork(UpdateKxEnvironmentNetworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKxEnvironmentNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKxEnvironmentNetwork.</param>
        /// 
        /// <returns>Returns a  UpdateKxEnvironmentNetworkResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxEnvironmentNetwork">REST API Reference for UpdateKxEnvironmentNetwork Operation</seealso>
        UpdateKxEnvironmentNetworkResponse EndUpdateKxEnvironmentNetwork(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateKxUser


        /// <summary>
        /// Updates the user details. You can only update the IAM role associated with a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxUser service method.</param>
        /// 
        /// <returns>The response from the UpdateKxUser service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxUser">REST API Reference for UpdateKxUser Operation</seealso>
        UpdateKxUserResponse UpdateKxUser(UpdateKxUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKxUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxUser operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKxUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxUser">REST API Reference for UpdateKxUser Operation</seealso>
        IAsyncResult BeginUpdateKxUser(UpdateKxUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKxUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKxUser.</param>
        /// 
        /// <returns>Returns a  UpdateKxUserResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxUser">REST API Reference for UpdateKxUser Operation</seealso>
        UpdateKxUserResponse EndUpdateKxUser(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateKxVolume


        /// <summary>
        /// Updates the throughput or capacity of a volume. During the update process, the filesystem
        /// might be unavailable for a few minutes. You can retry any operations after the update
        /// is complete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxVolume service method.</param>
        /// 
        /// <returns>The response from the UpdateKxVolume service method, as returned by Finspace.</returns>
        /// <exception cref="Amazon.Finspace.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.LimitExceededException">
        /// A service limit or quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Finspace.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxVolume">REST API Reference for UpdateKxVolume Operation</seealso>
        UpdateKxVolumeResponse UpdateKxVolume(UpdateKxVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKxVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKxVolume operation on AmazonFinspaceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKxVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxVolume">REST API Reference for UpdateKxVolume Operation</seealso>
        IAsyncResult BeginUpdateKxVolume(UpdateKxVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKxVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKxVolume.</param>
        /// 
        /// <returns>Returns a  UpdateKxVolumeResult from Finspace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2021-03-12/UpdateKxVolume">REST API Reference for UpdateKxVolume Operation</seealso>
        UpdateKxVolumeResponse EndUpdateKxVolume(IAsyncResult asyncResult);

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