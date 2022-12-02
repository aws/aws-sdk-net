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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.RedshiftServerless.Model;

namespace Amazon.RedshiftServerless
{
    /// <summary>
    /// Interface for accessing RedshiftServerless
    ///
    /// This is an interface reference for Amazon Redshift Serverless. It contains documentation
    /// for one of the programming or command line interfaces you can use to manage Amazon
    /// Redshift Serverless. 
    /// 
    ///  
    /// <para>
    /// Amazon Redshift Serverless automatically provisions data warehouse capacity and intelligently
    /// scales the underlying resources based on workload demands. Amazon Redshift Serverless
    /// adjusts capacity in seconds to deliver consistently high performance and simplified
    /// operations for even the most demanding and volatile workloads. Amazon Redshift Serverless
    /// lets you focus on using your data to acquire new insights for your business and customers.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  To learn more about Amazon Redshift Serverless, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/serverless-whatis.html">What
    /// is Amazon Redshift Serverless</a>. 
    /// </para>
    /// </summary>
    public partial interface IAmazonRedshiftServerless : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IRedshiftServerlessPaginatorFactory Paginators { get; }
#endif


        
        #region  ConvertRecoveryPointToSnapshot


        /// <summary>
        /// Converts a recovery point to a snapshot. For more information about recovery points
        /// and snapshots, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/serverless-snapshots-recovery.html">Working
        /// with snapshots and recovery points</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConvertRecoveryPointToSnapshot service method.</param>
        /// 
        /// <returns>The response from the ConvertRecoveryPointToSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.TooManyTagsException">
        /// The request exceeded the number of tags allowed for a resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ConvertRecoveryPointToSnapshot">REST API Reference for ConvertRecoveryPointToSnapshot Operation</seealso>
        ConvertRecoveryPointToSnapshotResponse ConvertRecoveryPointToSnapshot(ConvertRecoveryPointToSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ConvertRecoveryPointToSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConvertRecoveryPointToSnapshot operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConvertRecoveryPointToSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ConvertRecoveryPointToSnapshot">REST API Reference for ConvertRecoveryPointToSnapshot Operation</seealso>
        IAsyncResult BeginConvertRecoveryPointToSnapshot(ConvertRecoveryPointToSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ConvertRecoveryPointToSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConvertRecoveryPointToSnapshot.</param>
        /// 
        /// <returns>Returns a  ConvertRecoveryPointToSnapshotResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ConvertRecoveryPointToSnapshot">REST API Reference for ConvertRecoveryPointToSnapshot Operation</seealso>
        ConvertRecoveryPointToSnapshotResponse EndConvertRecoveryPointToSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEndpointAccess


        /// <summary>
        /// Creates an Amazon Redshift Serverless managed VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointAccess service method.</param>
        /// 
        /// <returns>The response from the CreateEndpointAccess service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateEndpointAccess">REST API Reference for CreateEndpointAccess Operation</seealso>
        CreateEndpointAccessResponse CreateEndpointAccess(CreateEndpointAccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointAccess operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEndpointAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateEndpointAccess">REST API Reference for CreateEndpointAccess Operation</seealso>
        IAsyncResult BeginCreateEndpointAccess(CreateEndpointAccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEndpointAccess.</param>
        /// 
        /// <returns>Returns a  CreateEndpointAccessResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateEndpointAccess">REST API Reference for CreateEndpointAccess Operation</seealso>
        CreateEndpointAccessResponse EndCreateEndpointAccess(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateNamespace


        /// <summary>
        /// Creates a namespace in Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNamespace service method.</param>
        /// 
        /// <returns>The response from the CreateNamespace service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.TooManyTagsException">
        /// The request exceeded the number of tags allowed for a resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateNamespace">REST API Reference for CreateNamespace Operation</seealso>
        CreateNamespaceResponse CreateNamespace(CreateNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNamespace operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateNamespace">REST API Reference for CreateNamespace Operation</seealso>
        IAsyncResult BeginCreateNamespace(CreateNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNamespace.</param>
        /// 
        /// <returns>Returns a  CreateNamespaceResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateNamespace">REST API Reference for CreateNamespace Operation</seealso>
        CreateNamespaceResponse EndCreateNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSnapshot


        /// <summary>
        /// Creates a snapshot of all databases in a namespace. For more information about snapshots,
        /// see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/serverless-snapshots-recovery.html">
        /// Working with snapshots and recovery points</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.TooManyTagsException">
        /// The request exceeded the number of tags allowed for a resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        IAsyncResult BeginCreateSnapshot(CreateSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateSnapshotResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        CreateSnapshotResponse EndCreateSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateUsageLimit


        /// <summary>
        /// Creates a usage limit for a specified Amazon Redshift Serverless usage type. The usage
        /// limit is identified by the returned usage limit identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUsageLimit service method.</param>
        /// 
        /// <returns>The response from the CreateUsageLimit service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateUsageLimit">REST API Reference for CreateUsageLimit Operation</seealso>
        CreateUsageLimitResponse CreateUsageLimit(CreateUsageLimitRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUsageLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUsageLimit operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUsageLimit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateUsageLimit">REST API Reference for CreateUsageLimit Operation</seealso>
        IAsyncResult BeginCreateUsageLimit(CreateUsageLimitRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUsageLimit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUsageLimit.</param>
        /// 
        /// <returns>Returns a  CreateUsageLimitResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateUsageLimit">REST API Reference for CreateUsageLimit Operation</seealso>
        CreateUsageLimitResponse EndCreateUsageLimit(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWorkgroup


        /// <summary>
        /// Creates an workgroup in Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkgroup service method.</param>
        /// 
        /// <returns>The response from the CreateWorkgroup service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InsufficientCapacityException">
        /// There is an insufficient capacity to perform the action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.TooManyTagsException">
        /// The request exceeded the number of tags allowed for a resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateWorkgroup">REST API Reference for CreateWorkgroup Operation</seealso>
        CreateWorkgroupResponse CreateWorkgroup(CreateWorkgroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkgroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkgroup operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkgroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateWorkgroup">REST API Reference for CreateWorkgroup Operation</seealso>
        IAsyncResult BeginCreateWorkgroup(CreateWorkgroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkgroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkgroup.</param>
        /// 
        /// <returns>Returns a  CreateWorkgroupResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/CreateWorkgroup">REST API Reference for CreateWorkgroup Operation</seealso>
        CreateWorkgroupResponse EndCreateWorkgroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEndpointAccess


        /// <summary>
        /// Deletes an Amazon Redshift Serverless managed VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpointAccess service method.</param>
        /// 
        /// <returns>The response from the DeleteEndpointAccess service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteEndpointAccess">REST API Reference for DeleteEndpointAccess Operation</seealso>
        DeleteEndpointAccessResponse DeleteEndpointAccess(DeleteEndpointAccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpointAccess operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEndpointAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteEndpointAccess">REST API Reference for DeleteEndpointAccess Operation</seealso>
        IAsyncResult BeginDeleteEndpointAccess(DeleteEndpointAccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEndpointAccess.</param>
        /// 
        /// <returns>Returns a  DeleteEndpointAccessResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteEndpointAccess">REST API Reference for DeleteEndpointAccess Operation</seealso>
        DeleteEndpointAccessResponse EndDeleteEndpointAccess(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteNamespace


        /// <summary>
        /// Deletes a namespace from Amazon Redshift Serverless. Before you delete the namespace,
        /// you can create a final snapshot that has all of the data within the namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace service method.</param>
        /// 
        /// <returns>The response from the DeleteNamespace service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        IAsyncResult BeginDeleteNamespace(DeleteNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNamespace.</param>
        /// 
        /// <returns>Returns a  DeleteNamespaceResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        DeleteNamespaceResponse EndDeleteNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteResourcePolicy


        /// <summary>
        /// Deletes the specified resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        IAsyncResult BeginDeleteResourcePolicy(DeleteResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePolicyResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse EndDeleteResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSnapshot


        /// <summary>
        /// Deletes a snapshot from Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        IAsyncResult BeginDeleteSnapshot(DeleteSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSnapshot.</param>
        /// 
        /// <returns>Returns a  DeleteSnapshotResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        DeleteSnapshotResponse EndDeleteSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUsageLimit


        /// <summary>
        /// Deletes a usage limit from Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUsageLimit service method.</param>
        /// 
        /// <returns>The response from the DeleteUsageLimit service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteUsageLimit">REST API Reference for DeleteUsageLimit Operation</seealso>
        DeleteUsageLimitResponse DeleteUsageLimit(DeleteUsageLimitRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUsageLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUsageLimit operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUsageLimit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteUsageLimit">REST API Reference for DeleteUsageLimit Operation</seealso>
        IAsyncResult BeginDeleteUsageLimit(DeleteUsageLimitRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUsageLimit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUsageLimit.</param>
        /// 
        /// <returns>Returns a  DeleteUsageLimitResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteUsageLimit">REST API Reference for DeleteUsageLimit Operation</seealso>
        DeleteUsageLimitResponse EndDeleteUsageLimit(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWorkgroup


        /// <summary>
        /// Deletes a workgroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkgroup service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkgroup service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteWorkgroup">REST API Reference for DeleteWorkgroup Operation</seealso>
        DeleteWorkgroupResponse DeleteWorkgroup(DeleteWorkgroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkgroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkgroup operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkgroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteWorkgroup">REST API Reference for DeleteWorkgroup Operation</seealso>
        IAsyncResult BeginDeleteWorkgroup(DeleteWorkgroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkgroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkgroup.</param>
        /// 
        /// <returns>Returns a  DeleteWorkgroupResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/DeleteWorkgroup">REST API Reference for DeleteWorkgroup Operation</seealso>
        DeleteWorkgroupResponse EndDeleteWorkgroup(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCredentials


        /// <summary>
        /// Returns a database user name and temporary password with temporary authorization to
        /// log in to Amazon Redshift Serverless.
        /// 
        ///  
        /// <para>
        /// By default, the temporary credentials expire in 900 seconds. You can optionally specify
        /// a duration between 900 seconds (15 minutes) and 3600 seconds (60 minutes).
        /// </para>
        ///  <pre><code> &lt;p&gt;The Identity and Access Management (IAM) user or role that runs
        /// GetCredentials must have an IAM policy attached that allows access to all necessary
        /// actions and resources.&lt;/p&gt; &lt;p&gt;If the &lt;code&gt;DbName&lt;/code&gt; parameter
        /// is specified, the IAM policy must allow access to the resource dbname for the specified
        /// database name.&lt;/p&gt; </code></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCredentials service method.</param>
        /// 
        /// <returns>The response from the GetCredentials service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetCredentials">REST API Reference for GetCredentials Operation</seealso>
        GetCredentialsResponse GetCredentials(GetCredentialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCredentials operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetCredentials">REST API Reference for GetCredentials Operation</seealso>
        IAsyncResult BeginGetCredentials(GetCredentialsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCredentials.</param>
        /// 
        /// <returns>Returns a  GetCredentialsResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetCredentials">REST API Reference for GetCredentials Operation</seealso>
        GetCredentialsResponse EndGetCredentials(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEndpointAccess


        /// <summary>
        /// Returns information, such as the name, about a VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEndpointAccess service method.</param>
        /// 
        /// <returns>The response from the GetEndpointAccess service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetEndpointAccess">REST API Reference for GetEndpointAccess Operation</seealso>
        GetEndpointAccessResponse GetEndpointAccess(GetEndpointAccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEndpointAccess operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEndpointAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetEndpointAccess">REST API Reference for GetEndpointAccess Operation</seealso>
        IAsyncResult BeginGetEndpointAccess(GetEndpointAccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEndpointAccess.</param>
        /// 
        /// <returns>Returns a  GetEndpointAccessResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetEndpointAccess">REST API Reference for GetEndpointAccess Operation</seealso>
        GetEndpointAccessResponse EndGetEndpointAccess(IAsyncResult asyncResult);

        #endregion
        
        #region  GetNamespace


        /// <summary>
        /// Returns information about a namespace in Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNamespace service method.</param>
        /// 
        /// <returns>The response from the GetNamespace service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetNamespace">REST API Reference for GetNamespace Operation</seealso>
        GetNamespaceResponse GetNamespace(GetNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNamespace operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetNamespace">REST API Reference for GetNamespace Operation</seealso>
        IAsyncResult BeginGetNamespace(GetNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNamespace.</param>
        /// 
        /// <returns>Returns a  GetNamespaceResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetNamespace">REST API Reference for GetNamespace Operation</seealso>
        GetNamespaceResponse EndGetNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRecoveryPoint


        /// <summary>
        /// Returns information about a recovery point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecoveryPoint service method.</param>
        /// 
        /// <returns>The response from the GetRecoveryPoint service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetRecoveryPoint">REST API Reference for GetRecoveryPoint Operation</seealso>
        GetRecoveryPointResponse GetRecoveryPoint(GetRecoveryPointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecoveryPoint operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecoveryPoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetRecoveryPoint">REST API Reference for GetRecoveryPoint Operation</seealso>
        IAsyncResult BeginGetRecoveryPoint(GetRecoveryPointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecoveryPoint.</param>
        /// 
        /// <returns>Returns a  GetRecoveryPointResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetRecoveryPoint">REST API Reference for GetRecoveryPoint Operation</seealso>
        GetRecoveryPointResponse EndGetRecoveryPoint(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourcePolicy


        /// <summary>
        /// Returns a resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        IAsyncResult BeginGetResourcePolicy(GetResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePolicy.</param>
        /// 
        /// <returns>Returns a  GetResourcePolicyResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse EndGetResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSnapshot


        /// <summary>
        /// Returns information about a specific snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshot service method.</param>
        /// 
        /// <returns>The response from the GetSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetSnapshot">REST API Reference for GetSnapshot Operation</seealso>
        GetSnapshotResponse GetSnapshot(GetSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshot operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetSnapshot">REST API Reference for GetSnapshot Operation</seealso>
        IAsyncResult BeginGetSnapshot(GetSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSnapshot.</param>
        /// 
        /// <returns>Returns a  GetSnapshotResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetSnapshot">REST API Reference for GetSnapshot Operation</seealso>
        GetSnapshotResponse EndGetSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTableRestoreStatus


        /// <summary>
        /// Returns information about a <code>TableRestoreStatus</code> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableRestoreStatus service method.</param>
        /// 
        /// <returns>The response from the GetTableRestoreStatus service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetTableRestoreStatus">REST API Reference for GetTableRestoreStatus Operation</seealso>
        GetTableRestoreStatusResponse GetTableRestoreStatus(GetTableRestoreStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTableRestoreStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableRestoreStatus operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableRestoreStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetTableRestoreStatus">REST API Reference for GetTableRestoreStatus Operation</seealso>
        IAsyncResult BeginGetTableRestoreStatus(GetTableRestoreStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableRestoreStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableRestoreStatus.</param>
        /// 
        /// <returns>Returns a  GetTableRestoreStatusResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetTableRestoreStatus">REST API Reference for GetTableRestoreStatus Operation</seealso>
        GetTableRestoreStatusResponse EndGetTableRestoreStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUsageLimit


        /// <summary>
        /// Returns information about a usage limit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsageLimit service method.</param>
        /// 
        /// <returns>The response from the GetUsageLimit service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetUsageLimit">REST API Reference for GetUsageLimit Operation</seealso>
        GetUsageLimitResponse GetUsageLimit(GetUsageLimitRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUsageLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUsageLimit operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUsageLimit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetUsageLimit">REST API Reference for GetUsageLimit Operation</seealso>
        IAsyncResult BeginGetUsageLimit(GetUsageLimitRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsageLimit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsageLimit.</param>
        /// 
        /// <returns>Returns a  GetUsageLimitResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetUsageLimit">REST API Reference for GetUsageLimit Operation</seealso>
        GetUsageLimitResponse EndGetUsageLimit(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWorkgroup


        /// <summary>
        /// Returns information about a specific workgroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkgroup service method.</param>
        /// 
        /// <returns>The response from the GetWorkgroup service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetWorkgroup">REST API Reference for GetWorkgroup Operation</seealso>
        GetWorkgroupResponse GetWorkgroup(GetWorkgroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkgroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkgroup operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkgroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetWorkgroup">REST API Reference for GetWorkgroup Operation</seealso>
        IAsyncResult BeginGetWorkgroup(GetWorkgroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkgroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkgroup.</param>
        /// 
        /// <returns>Returns a  GetWorkgroupResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/GetWorkgroup">REST API Reference for GetWorkgroup Operation</seealso>
        GetWorkgroupResponse EndGetWorkgroup(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEndpointAccess


        /// <summary>
        /// Returns an array of <code>EndpointAccess</code> objects and relevant information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointAccess service method.</param>
        /// 
        /// <returns>The response from the ListEndpointAccess service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListEndpointAccess">REST API Reference for ListEndpointAccess Operation</seealso>
        ListEndpointAccessResponse ListEndpointAccess(ListEndpointAccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointAccess operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEndpointAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListEndpointAccess">REST API Reference for ListEndpointAccess Operation</seealso>
        IAsyncResult BeginListEndpointAccess(ListEndpointAccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEndpointAccess.</param>
        /// 
        /// <returns>Returns a  ListEndpointAccessResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListEndpointAccess">REST API Reference for ListEndpointAccess Operation</seealso>
        ListEndpointAccessResponse EndListEndpointAccess(IAsyncResult asyncResult);

        #endregion
        
        #region  ListNamespaces


        /// <summary>
        /// Returns information about a list of specified namespaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNamespaces service method.</param>
        /// 
        /// <returns>The response from the ListNamespaces service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        ListNamespacesResponse ListNamespaces(ListNamespacesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListNamespaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNamespaces operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNamespaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        IAsyncResult BeginListNamespaces(ListNamespacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListNamespaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNamespaces.</param>
        /// 
        /// <returns>Returns a  ListNamespacesResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        ListNamespacesResponse EndListNamespaces(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRecoveryPoints


        /// <summary>
        /// Returns an array of recovery points.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecoveryPoints service method.</param>
        /// 
        /// <returns>The response from the ListRecoveryPoints service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListRecoveryPoints">REST API Reference for ListRecoveryPoints Operation</seealso>
        ListRecoveryPointsResponse ListRecoveryPoints(ListRecoveryPointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecoveryPoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecoveryPoints operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecoveryPoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListRecoveryPoints">REST API Reference for ListRecoveryPoints Operation</seealso>
        IAsyncResult BeginListRecoveryPoints(ListRecoveryPointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecoveryPoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecoveryPoints.</param>
        /// 
        /// <returns>Returns a  ListRecoveryPointsResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListRecoveryPoints">REST API Reference for ListRecoveryPoints Operation</seealso>
        ListRecoveryPointsResponse EndListRecoveryPoints(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSnapshots


        /// <summary>
        /// Returns a list of snapshots.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSnapshots service method.</param>
        /// 
        /// <returns>The response from the ListSnapshots service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListSnapshots">REST API Reference for ListSnapshots Operation</seealso>
        ListSnapshotsResponse ListSnapshots(ListSnapshotsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSnapshots operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListSnapshots">REST API Reference for ListSnapshots Operation</seealso>
        IAsyncResult BeginListSnapshots(ListSnapshotsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSnapshots.</param>
        /// 
        /// <returns>Returns a  ListSnapshotsResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListSnapshots">REST API Reference for ListSnapshots Operation</seealso>
        ListSnapshotsResponse EndListSnapshots(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTableRestoreStatus


        /// <summary>
        /// Returns information about an array of <code>TableRestoreStatus</code> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTableRestoreStatus service method.</param>
        /// 
        /// <returns>The response from the ListTableRestoreStatus service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InvalidPaginationException">
        /// The provided pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListTableRestoreStatus">REST API Reference for ListTableRestoreStatus Operation</seealso>
        ListTableRestoreStatusResponse ListTableRestoreStatus(ListTableRestoreStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTableRestoreStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTableRestoreStatus operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTableRestoreStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListTableRestoreStatus">REST API Reference for ListTableRestoreStatus Operation</seealso>
        IAsyncResult BeginListTableRestoreStatus(ListTableRestoreStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTableRestoreStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTableRestoreStatus.</param>
        /// 
        /// <returns>Returns a  ListTableRestoreStatusResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListTableRestoreStatus">REST API Reference for ListTableRestoreStatus Operation</seealso>
        ListTableRestoreStatusResponse EndListTableRestoreStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags assigned to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListUsageLimits


        /// <summary>
        /// Lists all usage limits within Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsageLimits service method.</param>
        /// 
        /// <returns>The response from the ListUsageLimits service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InvalidPaginationException">
        /// The provided pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListUsageLimits">REST API Reference for ListUsageLimits Operation</seealso>
        ListUsageLimitsResponse ListUsageLimits(ListUsageLimitsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsageLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsageLimits operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUsageLimits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListUsageLimits">REST API Reference for ListUsageLimits Operation</seealso>
        IAsyncResult BeginListUsageLimits(ListUsageLimitsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUsageLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUsageLimits.</param>
        /// 
        /// <returns>Returns a  ListUsageLimitsResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListUsageLimits">REST API Reference for ListUsageLimits Operation</seealso>
        ListUsageLimitsResponse EndListUsageLimits(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkgroups


        /// <summary>
        /// Returns information about a list of specified workgroups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkgroups service method.</param>
        /// 
        /// <returns>The response from the ListWorkgroups service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListWorkgroups">REST API Reference for ListWorkgroups Operation</seealso>
        ListWorkgroupsResponse ListWorkgroups(ListWorkgroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkgroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkgroups operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkgroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListWorkgroups">REST API Reference for ListWorkgroups Operation</seealso>
        IAsyncResult BeginListWorkgroups(ListWorkgroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkgroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkgroups.</param>
        /// 
        /// <returns>Returns a  ListWorkgroupsResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/ListWorkgroups">REST API Reference for ListWorkgroups Operation</seealso>
        ListWorkgroupsResponse EndListWorkgroups(IAsyncResult asyncResult);

        #endregion
        
        #region  PutResourcePolicy


        /// <summary>
        /// Creates or updates a resource policy. Currently, you can use policies to share snapshots
        /// across Amazon Web Services accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        IAsyncResult BeginPutResourcePolicy(PutResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourcePolicy.</param>
        /// 
        /// <returns>Returns a  PutResourcePolicyResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse EndPutResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  RestoreFromRecoveryPoint


        /// <summary>
        /// Restore the data from a recovery point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromRecoveryPoint service method.</param>
        /// 
        /// <returns>The response from the RestoreFromRecoveryPoint service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/RestoreFromRecoveryPoint">REST API Reference for RestoreFromRecoveryPoint Operation</seealso>
        RestoreFromRecoveryPointResponse RestoreFromRecoveryPoint(RestoreFromRecoveryPointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreFromRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromRecoveryPoint operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreFromRecoveryPoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/RestoreFromRecoveryPoint">REST API Reference for RestoreFromRecoveryPoint Operation</seealso>
        IAsyncResult BeginRestoreFromRecoveryPoint(RestoreFromRecoveryPointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreFromRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreFromRecoveryPoint.</param>
        /// 
        /// <returns>Returns a  RestoreFromRecoveryPointResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/RestoreFromRecoveryPoint">REST API Reference for RestoreFromRecoveryPoint Operation</seealso>
        RestoreFromRecoveryPointResponse EndRestoreFromRecoveryPoint(IAsyncResult asyncResult);

        #endregion
        
        #region  RestoreFromSnapshot


        /// <summary>
        /// Restores a namespace from a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreFromSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/RestoreFromSnapshot">REST API Reference for RestoreFromSnapshot Operation</seealso>
        RestoreFromSnapshotResponse RestoreFromSnapshot(RestoreFromSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromSnapshot operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreFromSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/RestoreFromSnapshot">REST API Reference for RestoreFromSnapshot Operation</seealso>
        IAsyncResult BeginRestoreFromSnapshot(RestoreFromSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreFromSnapshot.</param>
        /// 
        /// <returns>Returns a  RestoreFromSnapshotResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/RestoreFromSnapshot">REST API Reference for RestoreFromSnapshot Operation</seealso>
        RestoreFromSnapshotResponse EndRestoreFromSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  RestoreTableFromSnapshot


        /// <summary>
        /// Restores a table from a snapshot to your Amazon Redshift Serverless instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreTableFromSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreTableFromSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/RestoreTableFromSnapshot">REST API Reference for RestoreTableFromSnapshot Operation</seealso>
        RestoreTableFromSnapshotResponse RestoreTableFromSnapshot(RestoreTableFromSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreTableFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreTableFromSnapshot operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreTableFromSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/RestoreTableFromSnapshot">REST API Reference for RestoreTableFromSnapshot Operation</seealso>
        IAsyncResult BeginRestoreTableFromSnapshot(RestoreTableFromSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreTableFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreTableFromSnapshot.</param>
        /// 
        /// <returns>Returns a  RestoreTableFromSnapshotResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/RestoreTableFromSnapshot">REST API Reference for RestoreTableFromSnapshot Operation</seealso>
        RestoreTableFromSnapshotResponse EndRestoreTableFromSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns one or more tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.TooManyTagsException">
        /// The request exceeded the number of tags allowed for a resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag or set of tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEndpointAccess


        /// <summary>
        /// Updates an Amazon Redshift Serverless managed endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointAccess service method.</param>
        /// 
        /// <returns>The response from the UpdateEndpointAccess service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateEndpointAccess">REST API Reference for UpdateEndpointAccess Operation</seealso>
        UpdateEndpointAccessResponse UpdateEndpointAccess(UpdateEndpointAccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointAccess operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEndpointAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateEndpointAccess">REST API Reference for UpdateEndpointAccess Operation</seealso>
        IAsyncResult BeginUpdateEndpointAccess(UpdateEndpointAccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEndpointAccess.</param>
        /// 
        /// <returns>Returns a  UpdateEndpointAccessResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateEndpointAccess">REST API Reference for UpdateEndpointAccess Operation</seealso>
        UpdateEndpointAccessResponse EndUpdateEndpointAccess(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateNamespace


        /// <summary>
        /// Updates a namespace with the specified settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNamespace service method.</param>
        /// 
        /// <returns>The response from the UpdateNamespace service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateNamespace">REST API Reference for UpdateNamespace Operation</seealso>
        UpdateNamespaceResponse UpdateNamespace(UpdateNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNamespace operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateNamespace">REST API Reference for UpdateNamespace Operation</seealso>
        IAsyncResult BeginUpdateNamespace(UpdateNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNamespace.</param>
        /// 
        /// <returns>Returns a  UpdateNamespaceResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateNamespace">REST API Reference for UpdateNamespace Operation</seealso>
        UpdateNamespaceResponse EndUpdateNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSnapshot


        /// <summary>
        /// Updates a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshot service method.</param>
        /// 
        /// <returns>The response from the UpdateSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateSnapshot">REST API Reference for UpdateSnapshot Operation</seealso>
        UpdateSnapshotResponse UpdateSnapshot(UpdateSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshot operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateSnapshot">REST API Reference for UpdateSnapshot Operation</seealso>
        IAsyncResult BeginUpdateSnapshot(UpdateSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSnapshot.</param>
        /// 
        /// <returns>Returns a  UpdateSnapshotResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateSnapshot">REST API Reference for UpdateSnapshot Operation</seealso>
        UpdateSnapshotResponse EndUpdateSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateUsageLimit


        /// <summary>
        /// Update a usage limit in Amazon Redshift Serverless. You can't update the usage type
        /// or period of a usage limit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUsageLimit service method.</param>
        /// 
        /// <returns>The response from the UpdateUsageLimit service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateUsageLimit">REST API Reference for UpdateUsageLimit Operation</seealso>
        UpdateUsageLimitResponse UpdateUsageLimit(UpdateUsageLimitRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUsageLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUsageLimit operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUsageLimit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateUsageLimit">REST API Reference for UpdateUsageLimit Operation</seealso>
        IAsyncResult BeginUpdateUsageLimit(UpdateUsageLimitRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUsageLimit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUsageLimit.</param>
        /// 
        /// <returns>Returns a  UpdateUsageLimitResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateUsageLimit">REST API Reference for UpdateUsageLimit Operation</seealso>
        UpdateUsageLimitResponse EndUpdateUsageLimit(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWorkgroup


        /// <summary>
        /// Updates a workgroup with the specified configuration settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkgroup service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkgroup service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InsufficientCapacityException">
        /// There is an insufficient capacity to perform the action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateWorkgroup">REST API Reference for UpdateWorkgroup Operation</seealso>
        UpdateWorkgroupResponse UpdateWorkgroup(UpdateWorkgroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkgroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkgroup operation on AmazonRedshiftServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkgroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateWorkgroup">REST API Reference for UpdateWorkgroup Operation</seealso>
        IAsyncResult BeginUpdateWorkgroup(UpdateWorkgroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkgroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkgroup.</param>
        /// 
        /// <returns>Returns a  UpdateWorkgroupResult from RedshiftServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-serverless-2021-04-21/UpdateWorkgroup">REST API Reference for UpdateWorkgroup Operation</seealso>
        UpdateWorkgroupResponse EndUpdateWorkgroup(IAsyncResult asyncResult);

        #endregion
        
    }
}