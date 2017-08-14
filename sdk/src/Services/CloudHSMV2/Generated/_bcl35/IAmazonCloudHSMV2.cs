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
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CloudHSMV2.Model;

namespace Amazon.CloudHSMV2
{
    /// <summary>
    /// Interface for accessing CloudHSMV2
    ///
    /// For more information about AWS CloudHSM, see <a href="http://aws.amazon.com/cloudhsm/">AWS
    /// CloudHSM</a> and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
    /// CloudHSM User Guide</a>.
    /// </summary>
    public partial interface IAmazonCloudHSMV2 : IAmazonService, IDisposable
    {

        
        #region  CreateCluster


        /// <summary>
        /// Creates a new AWS CloudHSM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by CloudHSMV2.</returns>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmAccessDeniedException">
        /// The request was rejected because the requester does not have permission to perform
        /// the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInternalFailureException">
        /// The request was rejected because of an AWS CloudHSM internal failure. The request
        /// can be retried.
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
        /// Creates a new hardware security module (HSM) in the specified AWS CloudHSM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHsm service method.</param>
        /// 
        /// <returns>The response from the CreateHsm service method, as returned by CloudHSMV2.</returns>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmAccessDeniedException">
        /// The request was rejected because the requester does not have permission to perform
        /// the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInternalFailureException">
        /// The request was rejected because of an AWS CloudHSM internal failure. The request
        /// can be retried.
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
        
        #region  DeleteCluster


        /// <summary>
        /// Deletes the specified AWS CloudHSM cluster. Before you can delete a cluster, you must
        /// delete all HSMs in the cluster. To see if the cluster contains any HSMs, use <a>DescribeClusters</a>.
        /// To delete an HSM, use <a>DeleteHsm</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by CloudHSMV2.</returns>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmAccessDeniedException">
        /// The request was rejected because the requester does not have permission to perform
        /// the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInternalFailureException">
        /// The request was rejected because of an AWS CloudHSM internal failure. The request
        /// can be retried.
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
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsm service method.</param>
        /// 
        /// <returns>The response from the DeleteHsm service method, as returned by CloudHSMV2.</returns>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmAccessDeniedException">
        /// The request was rejected because the requester does not have permission to perform
        /// the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInternalFailureException">
        /// The request was rejected because of an AWS CloudHSM internal failure. The request
        /// can be retried.
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
        
        #region  DescribeBackups


        /// <summary>
        /// Gets information about backups of AWS CloudHSM clusters.
        /// 
        ///  
        /// <para>
        /// This is a paginated operation, which means that each response might contain only a
        /// subset of all the backups. When the response contains only a subset of backups, it
        /// includes a <code>NextToken</code> value. Use this value in a subsequent <code>DescribeBackups</code>
        /// request to get more backups. When you receive a response with no <code>NextToken</code>
        /// (or an empty or null value), that means there are no more backups to get.
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
        /// The request was rejected because of an AWS CloudHSM internal failure. The request
        /// can be retried.
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
        /// Gets information about AWS CloudHSM clusters.
        /// 
        ///  
        /// <para>
        /// This is a paginated operation, which means that each response might contain only a
        /// subset of all the clusters. When the response contains only a subset of clusters,
        /// it includes a <code>NextToken</code> value. Use this value in a subsequent <code>DescribeClusters</code>
        /// request to get more clusters. When you receive a response with no <code>NextToken</code>
        /// (or an empty or null value), that means there are no more clusters to get.
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
        /// The request was rejected because of an AWS CloudHSM internal failure. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInvalidRequestException">
        /// The request was rejected because it is not a valid request.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmServiceException">
        /// The request was rejected because an error occurred.
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
        
        #region  InitializeCluster


        /// <summary>
        /// Claims an AWS CloudHSM cluster by submitting the cluster certificate issued by your
        /// issuing certificate authority (CA) and the CA's root certificate. Before you can claim
        /// a cluster, you must sign the cluster's certificate signing request (CSR) with your
        /// issuing CA. To get the cluster's CSR, use <a>DescribeClusters</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitializeCluster service method.</param>
        /// 
        /// <returns>The response from the InitializeCluster service method, as returned by CloudHSMV2.</returns>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmAccessDeniedException">
        /// The request was rejected because the requester does not have permission to perform
        /// the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInternalFailureException">
        /// The request was rejected because of an AWS CloudHSM internal failure. The request
        /// can be retried.
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
        /// Gets a list of tags for the specified AWS CloudHSM cluster.
        /// 
        ///  
        /// <para>
        /// This is a paginated operation, which means that each response might contain only a
        /// subset of all the tags. When the response contains only a subset of tags, it includes
        /// a <code>NextToken</code> value. Use this value in a subsequent <code>ListTags</code>
        /// request to get more tags. When you receive a response with no <code>NextToken</code>
        /// (or an empty or null value), that means there are no more tags to get.
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
        /// The request was rejected because of an AWS CloudHSM internal failure. The request
        /// can be retried.
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
        
        #region  TagResource


        /// <summary>
        /// Adds or overwrites one or more tags for the specified AWS CloudHSM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CloudHSMV2.</returns>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmAccessDeniedException">
        /// The request was rejected because the requester does not have permission to perform
        /// the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInternalFailureException">
        /// The request was rejected because of an AWS CloudHSM internal failure. The request
        /// can be retried.
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
        /// Removes the specified tag or tags from the specified AWS CloudHSM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CloudHSMV2.</returns>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmAccessDeniedException">
        /// The request was rejected because the requester does not have permission to perform
        /// the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CloudHSMV2.Model.CloudHsmInternalFailureException">
        /// The request was rejected because of an AWS CloudHSM internal failure. The request
        /// can be retried.
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
        
    }
}