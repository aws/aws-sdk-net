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
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CloudHSMV2.Model;

#pragma warning disable CS1570
namespace Amazon.CloudHSMV2
{
    /// <summary>
    /// <para>Interface for accessing CloudHSMV2</para>
    ///
    /// For more information about CloudHSM, see <a href="http://aws.amazon.com/cloudhsm/">CloudHSM</a>
    /// and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/"> CloudHSM
    /// User Guide</a>.
    /// </summary>
    public partial interface IAmazonCloudHSMV2 : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICloudHSMV2PaginatorFactory Paginators { get; }
#endif


        
        #region  CopyBackupToRegion


        /// <summary>
        /// Copy an CloudHSM cluster backup to a different region.
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> No. You cannot perform this operation on an CloudHSM backup
        /// in a different Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyBackupToRegion service method.</param>
        /// 
        /// <returns>The response from the CopyBackupToRegion service method, as returned by CloudHSMV2.</returns>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmAccessDeniedException">
        /// The request was rejected because the requester does not have permission to perform
        /// the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInternalFailureException">
        /// The request was rejected because of an CloudHSM internal failure. The request can
        /// be retried.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInvalidRequestException">
        /// The request was rejected because it is not a valid request.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmResourceNotFoundException">
        /// The request was rejected because it refers to a resource that cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmServiceException">
        /// The request was rejected because an error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmTagException">
        /// The request was rejected because of a tagging failure. Verify the tag conditions in
        /// all applicable policies, and then retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/CopyBackupToRegion">REST API Reference for CopyBackupToRegion Operation</seealso>
        CopyBackupToRegionResponse CopyBackupToRegion(CopyBackupToRegionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CopyBackupToRegion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyBackupToRegion operation on AmazonCloudHSMV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyBackupToRegion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/CopyBackupToRegion">REST API Reference for CopyBackupToRegion Operation</seealso>
        IAsyncResult BeginCopyBackupToRegion(CopyBackupToRegionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CopyBackupToRegion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyBackupToRegion.</param>
        /// 
        /// <returns>Returns a  CopyBackupToRegionResult from CloudHSMV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/CopyBackupToRegion">REST API Reference for CopyBackupToRegion Operation</seealso>
        CopyBackupToRegionResponse EndCopyBackupToRegion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCluster


        /// <summary>
        /// Creates a new CloudHSM cluster.
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> Yes. To perform this operation with an CloudHSM backup
        /// in a different AWS account, specify the full backup ARN in the value of the SourceBackupId
        /// parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by CloudHSMV2.</returns>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmAccessDeniedException">
        /// The request was rejected because the requester does not have permission to perform
        /// the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInternalFailureException">
        /// The request was rejected because of an CloudHSM internal failure. The request can
        /// be retried.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInvalidRequestException">
        /// The request was rejected because it is not a valid request.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmResourceNotFoundException">
        /// The request was rejected because it refers to a resource that cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmServiceException">
        /// The request was rejected because an error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmTagException">
        /// The request was rejected because of a tagging failure. Verify the tag conditions in
        /// all applicable policies, and then retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        CreateClusterResponse CreateCluster(CreateClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation on AmazonCloudHSMV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        IAsyncResult BeginCreateCluster(CreateClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCluster.</param>
        /// 
        /// <returns>Returns a  CreateClusterResult from CloudHSMV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        CreateClusterResponse EndCreateCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateHsm


        /// <summary>
        /// Creates a new hardware security module (HSM) in the specified CloudHSM cluster.
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> No. You cannot perform this operation on an CloudHSM cluster
        /// in a different Amazon Web Service account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHsm service method.</param>
        /// 
        /// <returns>The response from the CreateHsm service method, as returned by CloudHSMV2.</returns>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmAccessDeniedException">
        /// The request was rejected because the requester does not have permission to perform
        /// the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInternalFailureException">
        /// The request was rejected because of an CloudHSM internal failure. The request can
        /// be retried.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInvalidRequestException">
        /// The request was rejected because it is not a valid request.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmResourceNotFoundException">
        /// The request was rejected because it refers to a resource that cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmServiceException">
        /// The request was rejected because an error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/CreateHsm">REST API Reference for CreateHsm Operation</seealso>
        CreateHsmResponse CreateHsm(CreateHsmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsm operation on AmazonCloudHSMV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHsm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/CreateHsm">REST API Reference for CreateHsm Operation</seealso>
        IAsyncResult BeginCreateHsm(CreateHsmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHsm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHsm.</param>
        /// 
        /// <returns>Returns a  CreateHsmResult from CloudHSMV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/CreateHsm">REST API Reference for CreateHsm Operation</seealso>
        CreateHsmResponse EndCreateHsm(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBackup


        /// <summary>
        /// Deletes a specified CloudHSM backup. A backup can be restored up to 7 days after the
        /// DeleteBackup request is made. For more information on restoring a backup, see <a>RestoreBackup</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> No. You cannot perform this operation on an CloudHSM backup
        /// in a different Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackup service method.</param>
        /// 
        /// <returns>The response from the DeleteBackup service method, as returned by CloudHSMV2.</returns>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmAccessDeniedException">
        /// The request was rejected because the requester does not have permission to perform
        /// the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInternalFailureException">
        /// The request was rejected because of an CloudHSM internal failure. The request can
        /// be retried.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInvalidRequestException">
        /// The request was rejected because it is not a valid request.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmResourceNotFoundException">
        /// The request was rejected because it refers to a resource that cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmServiceException">
        /// The request was rejected because an error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/DeleteBackup">REST API Reference for DeleteBackup Operation</seealso>
        DeleteBackupResponse DeleteBackup(DeleteBackupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackup operation on AmazonCloudHSMV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBackup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/DeleteBackup">REST API Reference for DeleteBackup Operation</seealso>
        IAsyncResult BeginDeleteBackup(DeleteBackupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBackup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBackup.</param>
        /// 
        /// <returns>Returns a  DeleteBackupResult from CloudHSMV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/DeleteBackup">REST API Reference for DeleteBackup Operation</seealso>
        DeleteBackupResponse EndDeleteBackup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCluster


        /// <summary>
        /// Deletes the specified CloudHSM cluster. Before you can delete a cluster, you must
        /// delete all HSMs in the cluster. To see if the cluster contains any HSMs, use <a>DescribeClusters</a>.
        /// To delete an HSM, use <a>DeleteHsm</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> No. You cannot perform this operation on an CloudHSM cluster
        /// in a different Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by CloudHSMV2.</returns>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmAccessDeniedException">
        /// The request was rejected because the requester does not have permission to perform
        /// the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInternalFailureException">
        /// The request was rejected because of an CloudHSM internal failure. The request can
        /// be retried.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInvalidRequestException">
        /// The request was rejected because it is not a valid request.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmResourceNotFoundException">
        /// The request was rejected because it refers to a resource that cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmServiceException">
        /// The request was rejected because an error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmTagException">
        /// The request was rejected because of a tagging failure. Verify the tag conditions in
        /// all applicable policies, and then retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        DeleteClusterResponse DeleteCluster(DeleteClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation on AmazonCloudHSMV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        IAsyncResult BeginDeleteCluster(DeleteClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCluster.</param>
        /// 
        /// <returns>Returns a  DeleteClusterResult from CloudHSMV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        DeleteClusterResponse EndDeleteCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteHsm


        /// <summary>
        /// Deletes the specified HSM. To specify an HSM, you can use its identifier (ID), the
        /// IP address of the HSM's elastic network interface (ENI), or the ID of the HSM's ENI.
        /// You need to specify only one of these values. To find these values, use <a>DescribeClusters</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> No. You cannot perform this operation on an CloudHSM hsm
        /// in a different Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsm service method.</param>
        /// 
        /// <returns>The response from the DeleteHsm service method, as returned by CloudHSMV2.</returns>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmAccessDeniedException">
        /// The request was rejected because the requester does not have permission to perform
        /// the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInternalFailureException">
        /// The request was rejected because of an CloudHSM internal failure. The request can
        /// be retried.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInvalidRequestException">
        /// The request was rejected because it is not a valid request.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmResourceNotFoundException">
        /// The request was rejected because it refers to a resource that cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmServiceException">
        /// The request was rejected because an error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/DeleteHsm">REST API Reference for DeleteHsm Operation</seealso>
        DeleteHsmResponse DeleteHsm(DeleteHsmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsm operation on AmazonCloudHSMV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHsm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/DeleteHsm">REST API Reference for DeleteHsm Operation</seealso>
        IAsyncResult BeginDeleteHsm(DeleteHsmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHsm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHsm.</param>
        /// 
        /// <returns>Returns a  DeleteHsmResult from CloudHSMV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/DeleteHsm">REST API Reference for DeleteHsm Operation</seealso>
        DeleteHsmResponse EndDeleteHsm(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteResourcePolicy


        /// <summary>
        /// Deletes an CloudHSM resource policy. Deleting a resource policy will result in the
        /// resource being unshared and removed from any RAM resource shares. Deleting the resource
        /// policy attached to a backup will not impact any clusters created from that backup.
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> No. You cannot perform this operation on an CloudHSM resource
        /// in a different Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by CloudHSMV2.</returns>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmAccessDeniedException">
        /// The request was rejected because the requester does not have permission to perform
        /// the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInternalFailureException">
        /// The request was rejected because of an CloudHSM internal failure. The request can
        /// be retried.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInvalidRequestException">
        /// The request was rejected because it is not a valid request.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmResourceNotFoundException">
        /// The request was rejected because it refers to a resource that cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmServiceException">
        /// The request was rejected because an error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation on AmazonCloudHSMV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        IAsyncResult BeginDeleteResourcePolicy(DeleteResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePolicyResult from CloudHSMV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse EndDeleteResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeBackups


        /// <summary>
        /// Gets information about backups of CloudHSM clusters. Lists either the backups you
        /// own or the backups shared with you when the Shared parameter is true.
        /// 
        ///  
        /// <para>
        /// This is a paginated operation, which means that each response might contain only a
        /// subset of all the backups. When the response contains only a subset of backups, it
        /// includes a <c>NextToken</c> value. Use this value in a subsequent <c>DescribeBackups</c>
        /// request to get more backups. When you receive a response with no <c>NextToken</c>
        /// (or an empty or null value), that means there are no more backups to get.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> Yes. Customers can describe backups in other Amazon Web
        /// Services accounts that are shared with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackups service method.</param>
        /// 
        /// <returns>The response from the DescribeBackups service method, as returned by CloudHSMV2.</returns>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmAccessDeniedException">
        /// The request was rejected because the requester does not have permission to perform
        /// the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInternalFailureException">
        /// The request was rejected because of an CloudHSM internal failure. The request can
        /// be retried.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInvalidRequestException">
        /// The request was rejected because it is not a valid request.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmResourceNotFoundException">
        /// The request was rejected because it refers to a resource that cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmServiceException">
        /// The request was rejected because an error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmTagException">
        /// The request was rejected because of a tagging failure. Verify the tag conditions in
        /// all applicable policies, and then retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/DescribeBackups">REST API Reference for DescribeBackups Operation</seealso>
        DescribeBackupsResponse DescribeBackups(DescribeBackupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBackups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackups operation on AmazonCloudHSMV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBackups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/DescribeBackups">REST API Reference for DescribeBackups Operation</seealso>
        IAsyncResult BeginDescribeBackups(DescribeBackupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBackups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBackups.</param>
        /// 
        /// <returns>Returns a  DescribeBackupsResult from CloudHSMV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/DescribeBackups">REST API Reference for DescribeBackups Operation</seealso>
        DescribeBackupsResponse EndDescribeBackups(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeClusters


        /// <summary>
        /// Gets information about CloudHSM clusters.
        /// 
        ///  
        /// <para>
        /// This is a paginated operation, which means that each response might contain only a
        /// subset of all the clusters. When the response contains only a subset of clusters,
        /// it includes a <c>NextToken</c> value. Use this value in a subsequent <c>DescribeClusters</c>
        /// request to get more clusters. When you receive a response with no <c>NextToken</c>
        /// (or an empty or null value), that means there are no more clusters to get.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> No. You cannot perform this operation on CloudHSM clusters
        /// in a different Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters service method.</param>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by CloudHSMV2.</returns>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmAccessDeniedException">
        /// The request was rejected because the requester does not have permission to perform
        /// the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInternalFailureException">
        /// The request was rejected because of an CloudHSM internal failure. The request can
        /// be retried.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInvalidRequestException">
        /// The request was rejected because it is not a valid request.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmServiceException">
        /// The request was rejected because an error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmTagException">
        /// The request was rejected because of a tagging failure. Verify the tag conditions in
        /// all applicable policies, and then retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        DescribeClustersResponse DescribeClusters(DescribeClustersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters operation on AmazonCloudHSMV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        IAsyncResult BeginDescribeClusters(DescribeClustersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusters.</param>
        /// 
        /// <returns>Returns a  DescribeClustersResult from CloudHSMV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        DescribeClustersResponse EndDescribeClusters(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourcePolicy


        /// <summary>
        /// Retrieves the resource policy document attached to a given resource. 
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> No. You cannot perform this operation on an CloudHSM resource
        /// in a different Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by CloudHSMV2.</returns>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmAccessDeniedException">
        /// The request was rejected because the requester does not have permission to perform
        /// the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInternalFailureException">
        /// The request was rejected because of an CloudHSM internal failure. The request can
        /// be retried.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInvalidRequestException">
        /// The request was rejected because it is not a valid request.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmResourceNotFoundException">
        /// The request was rejected because it refers to a resource that cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmServiceException">
        /// The request was rejected because an error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy operation on AmazonCloudHSMV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        IAsyncResult BeginGetResourcePolicy(GetResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePolicy.</param>
        /// 
        /// <returns>Returns a  GetResourcePolicyResult from CloudHSMV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse EndGetResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  InitializeCluster


        /// <summary>
        /// Claims an CloudHSM cluster by submitting the cluster certificate issued by your issuing
        /// certificate authority (CA) and the CA's root certificate. Before you can claim a cluster,
        /// you must sign the cluster's certificate signing request (CSR) with your issuing CA.
        /// To get the cluster's CSR, use <a>DescribeClusters</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> No. You cannot perform this operation on an CloudHSM cluster
        /// in a different Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitializeCluster service method.</param>
        /// 
        /// <returns>The response from the InitializeCluster service method, as returned by CloudHSMV2.</returns>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmAccessDeniedException">
        /// The request was rejected because the requester does not have permission to perform
        /// the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInternalFailureException">
        /// The request was rejected because of an CloudHSM internal failure. The request can
        /// be retried.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInvalidRequestException">
        /// The request was rejected because it is not a valid request.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmResourceNotFoundException">
        /// The request was rejected because it refers to a resource that cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmServiceException">
        /// The request was rejected because an error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/InitializeCluster">REST API Reference for InitializeCluster Operation</seealso>
        InitializeClusterResponse InitializeCluster(InitializeClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InitializeCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitializeCluster operation on AmazonCloudHSMV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInitializeCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/InitializeCluster">REST API Reference for InitializeCluster Operation</seealso>
        IAsyncResult BeginInitializeCluster(InitializeClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InitializeCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInitializeCluster.</param>
        /// 
        /// <returns>Returns a  InitializeClusterResult from CloudHSMV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/InitializeCluster">REST API Reference for InitializeCluster Operation</seealso>
        InitializeClusterResponse EndInitializeCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTags


        /// <summary>
        /// Gets a list of tags for the specified CloudHSM cluster.
        /// 
        ///  
        /// <para>
        /// This is a paginated operation, which means that each response might contain only a
        /// subset of all the tags. When the response contains only a subset of tags, it includes
        /// a <c>NextToken</c> value. Use this value in a subsequent <c>ListTags</c> request to
        /// get more tags. When you receive a response with no <c>NextToken</c> (or an empty or
        /// null value), that means there are no more tags to get.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> No. You cannot perform this operation on an CloudHSM resource
        /// in a different Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by CloudHSMV2.</returns>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmAccessDeniedException">
        /// The request was rejected because the requester does not have permission to perform
        /// the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInternalFailureException">
        /// The request was rejected because of an CloudHSM internal failure. The request can
        /// be retried.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInvalidRequestException">
        /// The request was rejected because it is not a valid request.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmResourceNotFoundException">
        /// The request was rejected because it refers to a resource that cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmServiceException">
        /// The request was rejected because an error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmTagException">
        /// The request was rejected because of a tagging failure. Verify the tag conditions in
        /// all applicable policies, and then retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/ListTags">REST API Reference for ListTags Operation</seealso>
        ListTagsResponse ListTags(ListTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation on AmazonCloudHSMV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/ListTags">REST API Reference for ListTags Operation</seealso>
        IAsyncResult BeginListTags(ListTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTags.</param>
        /// 
        /// <returns>Returns a  ListTagsResult from CloudHSMV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/ListTags">REST API Reference for ListTags Operation</seealso>
        ListTagsResponse EndListTags(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyBackupAttributes


        /// <summary>
        /// Modifies attributes for CloudHSM backup.
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> No. You cannot perform this operation on an CloudHSM backup
        /// in a different Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyBackupAttributes service method.</param>
        /// 
        /// <returns>The response from the ModifyBackupAttributes service method, as returned by CloudHSMV2.</returns>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmAccessDeniedException">
        /// The request was rejected because the requester does not have permission to perform
        /// the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInternalFailureException">
        /// The request was rejected because of an CloudHSM internal failure. The request can
        /// be retried.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInvalidRequestException">
        /// The request was rejected because it is not a valid request.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmResourceNotFoundException">
        /// The request was rejected because it refers to a resource that cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmServiceException">
        /// The request was rejected because an error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/ModifyBackupAttributes">REST API Reference for ModifyBackupAttributes Operation</seealso>
        ModifyBackupAttributesResponse ModifyBackupAttributes(ModifyBackupAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyBackupAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyBackupAttributes operation on AmazonCloudHSMV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyBackupAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/ModifyBackupAttributes">REST API Reference for ModifyBackupAttributes Operation</seealso>
        IAsyncResult BeginModifyBackupAttributes(ModifyBackupAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyBackupAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyBackupAttributes.</param>
        /// 
        /// <returns>Returns a  ModifyBackupAttributesResult from CloudHSMV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/ModifyBackupAttributes">REST API Reference for ModifyBackupAttributes Operation</seealso>
        ModifyBackupAttributesResponse EndModifyBackupAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyCluster


        /// <summary>
        /// Modifies CloudHSM cluster.
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> No. You cannot perform this operation on an CloudHSM cluster
        /// in a different Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCluster service method.</param>
        /// 
        /// <returns>The response from the ModifyCluster service method, as returned by CloudHSMV2.</returns>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmAccessDeniedException">
        /// The request was rejected because the requester does not have permission to perform
        /// the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInternalFailureException">
        /// The request was rejected because of an CloudHSM internal failure. The request can
        /// be retried.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInvalidRequestException">
        /// The request was rejected because it is not a valid request.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmResourceNotFoundException">
        /// The request was rejected because it refers to a resource that cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmServiceException">
        /// The request was rejected because an error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/ModifyCluster">REST API Reference for ModifyCluster Operation</seealso>
        ModifyClusterResponse ModifyCluster(ModifyClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCluster operation on AmazonCloudHSMV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/ModifyCluster">REST API Reference for ModifyCluster Operation</seealso>
        IAsyncResult BeginModifyCluster(ModifyClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyCluster.</param>
        /// 
        /// <returns>Returns a  ModifyClusterResult from CloudHSMV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/ModifyCluster">REST API Reference for ModifyCluster Operation</seealso>
        ModifyClusterResponse EndModifyCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  PutResourcePolicy


        /// <summary>
        /// Creates or updates an CloudHSM resource policy. A resource policy helps you to define
        /// the IAM entity (for example, an Amazon Web Services account) that can manage your
        /// CloudHSM resources. The following resources support CloudHSM resource policies: 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  Backup - The resource policy allows you to describe the backup and restore a cluster
        /// from the backup in another Amazon Web Services account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In order to share a backup, it must be in a 'READY' state and you must own it.
        /// </para>
        ///  <important> 
        /// <para>
        /// While you can share a backup using the CloudHSM PutResourcePolicy operation, we recommend
        /// using Resource Access Manager (RAM) instead. Using RAM provides multiple benefits
        /// as it creates the policy for you, allows multiple resources to be shared at one time,
        /// and increases the discoverability of shared resources. If you use PutResourcePolicy
        /// and want consumers to be able to describe the backups you share with them, you must
        /// promote the backup to a standard RAM Resource Share using the RAM PromoteResourceShareCreatedFromPolicy
        /// API operation. For more information, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/sharing.html">
        /// Working with shared backups</a> in the CloudHSM User Guide
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Cross-account use:</b> No. You cannot perform this operation on an CloudHSM resource
        /// in a different Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by CloudHSMV2.</returns>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmAccessDeniedException">
        /// The request was rejected because the requester does not have permission to perform
        /// the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInternalFailureException">
        /// The request was rejected because of an CloudHSM internal failure. The request can
        /// be retried.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInvalidRequestException">
        /// The request was rejected because it is not a valid request.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmResourceNotFoundException">
        /// The request was rejected because it refers to a resource that cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmServiceException">
        /// The request was rejected because an error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation on AmazonCloudHSMV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        IAsyncResult BeginPutResourcePolicy(PutResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourcePolicy.</param>
        /// 
        /// <returns>Returns a  PutResourcePolicyResult from CloudHSMV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse EndPutResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  RestoreBackup


        /// <summary>
        /// Restores a specified CloudHSM backup that is in the <c>PENDING_DELETION</c> state.
        /// For more information on deleting a backup, see <a>DeleteBackup</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> No. You cannot perform this operation on an CloudHSM backup
        /// in a different Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreBackup service method.</param>
        /// 
        /// <returns>The response from the RestoreBackup service method, as returned by CloudHSMV2.</returns>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmAccessDeniedException">
        /// The request was rejected because the requester does not have permission to perform
        /// the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInternalFailureException">
        /// The request was rejected because of an CloudHSM internal failure. The request can
        /// be retried.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInvalidRequestException">
        /// The request was rejected because it is not a valid request.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmResourceNotFoundException">
        /// The request was rejected because it refers to a resource that cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmServiceException">
        /// The request was rejected because an error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/RestoreBackup">REST API Reference for RestoreBackup Operation</seealso>
        RestoreBackupResponse RestoreBackup(RestoreBackupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreBackup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreBackup operation on AmazonCloudHSMV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreBackup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/RestoreBackup">REST API Reference for RestoreBackup Operation</seealso>
        IAsyncResult BeginRestoreBackup(RestoreBackupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreBackup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreBackup.</param>
        /// 
        /// <returns>Returns a  RestoreBackupResult from CloudHSMV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/RestoreBackup">REST API Reference for RestoreBackup Operation</seealso>
        RestoreBackupResponse EndRestoreBackup(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or overwrites one or more tags for the specified CloudHSM cluster.
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> No. You cannot perform this operation on an CloudHSM resource
        /// in a different Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CloudHSMV2.</returns>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmAccessDeniedException">
        /// The request was rejected because the requester does not have permission to perform
        /// the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInternalFailureException">
        /// The request was rejected because of an CloudHSM internal failure. The request can
        /// be retried.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInvalidRequestException">
        /// The request was rejected because it is not a valid request.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmResourceLimitExceededException">
        /// The request was rejected because it exceeds an CloudHSM limit.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmResourceNotFoundException">
        /// The request was rejected because it refers to a resource that cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmServiceException">
        /// The request was rejected because an error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmTagException">
        /// The request was rejected because of a tagging failure. Verify the tag conditions in
        /// all applicable policies, and then retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCloudHSMV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from CloudHSMV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tag or tags from the specified CloudHSM cluster.
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> No. You cannot perform this operation on an CloudHSM resource
        /// in a different Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CloudHSMV2.</returns>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmAccessDeniedException">
        /// The request was rejected because the requester does not have permission to perform
        /// the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInternalFailureException">
        /// The request was rejected because of an CloudHSM internal failure. The request can
        /// be retried.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInvalidRequestException">
        /// The request was rejected because it is not a valid request.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmResourceNotFoundException">
        /// The request was rejected because it refers to a resource that cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmServiceException">
        /// The request was rejected because an error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmTagException">
        /// The request was rejected because of a tagging failure. Verify the tag conditions in
        /// all applicable policies, and then retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCloudHSMV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from CloudHSMV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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