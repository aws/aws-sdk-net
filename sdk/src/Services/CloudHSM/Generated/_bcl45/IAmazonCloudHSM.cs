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
 * Do not modify this file. This file is generated from the cloudhsm-2014-05-30.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CloudHSM.Model;

namespace Amazon.CloudHSM
{
    /// <summary>
    /// Interface for accessing CloudHSM
    ///
    /// AWS CloudHSM Service 
    /// <para>
    /// This is the reference for AWS CloudHSM Classic. For more information, see <a href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS
    /// CloudHSM Classic FAQs</a> and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS
    /// CloudHSM Classic User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information about AWS CloudHSM, see <a href="http://aws.amazon.com/cloudhsm/">AWS
    /// CloudHSM</a> and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
    /// CloudHSM User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCloudHSM : IAmazonService, IDisposable
    {

        
        #region  AddTagsToResource


        /// <summary>
        /// Adds or overwrites one or more tags for the specified AWS CloudHSM resource.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a key and a value. Tag keys must be unique to each resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateHapg


        /// <summary>
        /// Creates a high-availability partition group. A high-availability partition group is
        /// a group of partitions that spans multiple physical HSMs.
        /// </summary>
        /// <param name="label">The label of the new high-availability partition group.</param>
        /// 
        /// <returns>The response from the CreateHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/CreateHapg">REST API Reference for CreateHapg Operation</seealso>
        CreateHapgResponse CreateHapg(string label);

        /// <summary>
        /// Creates a high-availability partition group. A high-availability partition group is
        /// a group of partitions that spans multiple physical HSMs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHapg service method.</param>
        /// 
        /// <returns>The response from the CreateHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/CreateHapg">REST API Reference for CreateHapg Operation</seealso>
        CreateHapgResponse CreateHapg(CreateHapgRequest request);


        /// <summary>
        /// Creates a high-availability partition group. A high-availability partition group is
        /// a group of partitions that spans multiple physical HSMs.
        /// </summary>
        /// <param name="label">The label of the new high-availability partition group.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/CreateHapg">REST API Reference for CreateHapg Operation</seealso>
        Task<CreateHapgResponse> CreateHapgAsync(string label, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHapg operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHapg operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/CreateHapg">REST API Reference for CreateHapg Operation</seealso>
        Task<CreateHapgResponse> CreateHapgAsync(CreateHapgRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateHsm


        /// <summary>
        /// Creates an uninitialized HSM instance.
        /// 
        ///  
        /// <para>
        /// There is an upfront fee charged for each HSM instance that you create with the <code>CreateHsm</code>
        /// operation. If you accidentally provision an HSM and want to request a refund, delete
        /// the instance using the <a>DeleteHsm</a> operation, go to the <a href="https://console.aws.amazon.com/support/home">AWS
        /// Support Center</a>, create a new case, and select <b>Account and Billing Support</b>.
        /// </para>
        ///  <important> 
        /// <para>
        /// It can take up to 20 minutes to create and provision an HSM. You can monitor the status
        /// of the HSM with the <a>DescribeHsm</a> operation. The HSM is ready to be initialized
        /// when the status changes to <code>RUNNING</code>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHsm service method.</param>
        /// 
        /// <returns>The response from the CreateHsm service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/CreateHsm">REST API Reference for CreateHsm Operation</seealso>
        CreateHsmResponse CreateHsm(CreateHsmRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsm operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/CreateHsm">REST API Reference for CreateHsm Operation</seealso>
        Task<CreateHsmResponse> CreateHsmAsync(CreateHsmRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLunaClient


        /// <summary>
        /// Creates an HSM client.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLunaClient service method.</param>
        /// 
        /// <returns>The response from the CreateLunaClient service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/CreateLunaClient">REST API Reference for CreateLunaClient Operation</seealso>
        CreateLunaClientResponse CreateLunaClient(CreateLunaClientRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLunaClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLunaClient operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/CreateLunaClient">REST API Reference for CreateLunaClient Operation</seealso>
        Task<CreateLunaClientResponse> CreateLunaClientAsync(CreateLunaClientRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteHapg


        /// <summary>
        /// Deletes a high-availability partition group.
        /// </summary>
        /// <param name="hapgArn">The ARN of the high-availability partition group to delete.</param>
        /// 
        /// <returns>The response from the DeleteHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteHapg">REST API Reference for DeleteHapg Operation</seealso>
        DeleteHapgResponse DeleteHapg(string hapgArn);

        /// <summary>
        /// Deletes a high-availability partition group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHapg service method.</param>
        /// 
        /// <returns>The response from the DeleteHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteHapg">REST API Reference for DeleteHapg Operation</seealso>
        DeleteHapgResponse DeleteHapg(DeleteHapgRequest request);


        /// <summary>
        /// Deletes a high-availability partition group.
        /// </summary>
        /// <param name="hapgArn">The ARN of the high-availability partition group to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteHapg">REST API Reference for DeleteHapg Operation</seealso>
        Task<DeleteHapgResponse> DeleteHapgAsync(string hapgArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHapg operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHapg operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteHapg">REST API Reference for DeleteHapg Operation</seealso>
        Task<DeleteHapgResponse> DeleteHapgAsync(DeleteHapgRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteHsm


        /// <summary>
        /// Deletes an HSM. After completion, this operation cannot be undone and your key material
        /// cannot be recovered.
        /// </summary>
        /// <param name="hsmArn">The ARN of the HSM to delete.</param>
        /// 
        /// <returns>The response from the DeleteHsm service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteHsm">REST API Reference for DeleteHsm Operation</seealso>
        DeleteHsmResponse DeleteHsm(string hsmArn);

        /// <summary>
        /// Deletes an HSM. After completion, this operation cannot be undone and your key material
        /// cannot be recovered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsm service method.</param>
        /// 
        /// <returns>The response from the DeleteHsm service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteHsm">REST API Reference for DeleteHsm Operation</seealso>
        DeleteHsmResponse DeleteHsm(DeleteHsmRequest request);


        /// <summary>
        /// Deletes an HSM. After completion, this operation cannot be undone and your key material
        /// cannot be recovered.
        /// </summary>
        /// <param name="hsmArn">The ARN of the HSM to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteHsm service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteHsm">REST API Reference for DeleteHsm Operation</seealso>
        Task<DeleteHsmResponse> DeleteHsmAsync(string hsmArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsm operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteHsm">REST API Reference for DeleteHsm Operation</seealso>
        Task<DeleteHsmResponse> DeleteHsmAsync(DeleteHsmRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLunaClient


        /// <summary>
        /// Deletes a client.
        /// </summary>
        /// <param name="clientArn">The ARN of the client to delete.</param>
        /// 
        /// <returns>The response from the DeleteLunaClient service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteLunaClient">REST API Reference for DeleteLunaClient Operation</seealso>
        DeleteLunaClientResponse DeleteLunaClient(string clientArn);

        /// <summary>
        /// Deletes a client.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLunaClient service method.</param>
        /// 
        /// <returns>The response from the DeleteLunaClient service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteLunaClient">REST API Reference for DeleteLunaClient Operation</seealso>
        DeleteLunaClientResponse DeleteLunaClient(DeleteLunaClientRequest request);


        /// <summary>
        /// Deletes a client.
        /// </summary>
        /// <param name="clientArn">The ARN of the client to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLunaClient service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteLunaClient">REST API Reference for DeleteLunaClient Operation</seealso>
        Task<DeleteLunaClientResponse> DeleteLunaClientAsync(string clientArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLunaClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLunaClient operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteLunaClient">REST API Reference for DeleteLunaClient Operation</seealso>
        Task<DeleteLunaClientResponse> DeleteLunaClientAsync(DeleteLunaClientRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeHapg


        /// <summary>
        /// Retrieves information about a high-availability partition group.
        /// </summary>
        /// <param name="hapgArn">The ARN of the high-availability partition group to describe.</param>
        /// 
        /// <returns>The response from the DescribeHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DescribeHapg">REST API Reference for DescribeHapg Operation</seealso>
        DescribeHapgResponse DescribeHapg(string hapgArn);

        /// <summary>
        /// Retrieves information about a high-availability partition group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHapg service method.</param>
        /// 
        /// <returns>The response from the DescribeHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DescribeHapg">REST API Reference for DescribeHapg Operation</seealso>
        DescribeHapgResponse DescribeHapg(DescribeHapgRequest request);


        /// <summary>
        /// Retrieves information about a high-availability partition group.
        /// </summary>
        /// <param name="hapgArn">The ARN of the high-availability partition group to describe.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DescribeHapg">REST API Reference for DescribeHapg Operation</seealso>
        Task<DescribeHapgResponse> DescribeHapgAsync(string hapgArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHapg operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHapg operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DescribeHapg">REST API Reference for DescribeHapg Operation</seealso>
        Task<DescribeHapgResponse> DescribeHapgAsync(DescribeHapgRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeHsm


        /// <summary>
        /// Retrieves information about an HSM. You can identify the HSM by its ARN or its serial
        /// number.
        /// </summary>
        /// <param name="hsmArn">The ARN of the HSM. Either the <code>HsmArn</code> or the <code>SerialNumber</code> parameter must be specified.</param>
        /// 
        /// <returns>The response from the DescribeHsm service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DescribeHsm">REST API Reference for DescribeHsm Operation</seealso>
        DescribeHsmResponse DescribeHsm(string hsmArn);

        /// <summary>
        /// Retrieves information about an HSM. You can identify the HSM by its ARN or its serial
        /// number.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsm service method.</param>
        /// 
        /// <returns>The response from the DescribeHsm service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DescribeHsm">REST API Reference for DescribeHsm Operation</seealso>
        DescribeHsmResponse DescribeHsm(DescribeHsmRequest request);


        /// <summary>
        /// Retrieves information about an HSM. You can identify the HSM by its ARN or its serial
        /// number.
        /// </summary>
        /// <param name="hsmArn">The ARN of the HSM. Either the <code>HsmArn</code> or the <code>SerialNumber</code> parameter must be specified.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHsm service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DescribeHsm">REST API Reference for DescribeHsm Operation</seealso>
        Task<DescribeHsmResponse> DescribeHsmAsync(string hsmArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHsm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsm operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DescribeHsm">REST API Reference for DescribeHsm Operation</seealso>
        Task<DescribeHsmResponse> DescribeHsmAsync(DescribeHsmRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLunaClient


        /// <summary>
        /// Retrieves information about an HSM client.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLunaClient service method.</param>
        /// 
        /// <returns>The response from the DescribeLunaClient service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DescribeLunaClient">REST API Reference for DescribeLunaClient Operation</seealso>
        DescribeLunaClientResponse DescribeLunaClient(DescribeLunaClientRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLunaClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLunaClient operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DescribeLunaClient">REST API Reference for DescribeLunaClient Operation</seealso>
        Task<DescribeLunaClientResponse> DescribeLunaClientAsync(DescribeLunaClientRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetConfig


        /// <summary>
        /// Gets the configuration files necessary to connect to all high availability partition
        /// groups the client is associated with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfig service method.</param>
        /// 
        /// <returns>The response from the GetConfig service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/GetConfig">REST API Reference for GetConfig Operation</seealso>
        GetConfigResponse GetConfig(GetConfigRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/GetConfig">REST API Reference for GetConfig Operation</seealso>
        Task<GetConfigResponse> GetConfigAsync(GetConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAvailableZones


        /// <summary>
        /// Lists the Availability Zones that have available AWS CloudHSM capacity.
        /// </summary>
        /// 
        /// <returns>The response from the ListAvailableZones service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListAvailableZones">REST API Reference for ListAvailableZones Operation</seealso>
        ListAvailableZonesResponse ListAvailableZones();

        /// <summary>
        /// Lists the Availability Zones that have available AWS CloudHSM capacity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableZones service method.</param>
        /// 
        /// <returns>The response from the ListAvailableZones service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListAvailableZones">REST API Reference for ListAvailableZones Operation</seealso>
        ListAvailableZonesResponse ListAvailableZones(ListAvailableZonesRequest request);


        /// <summary>
        /// Lists the Availability Zones that have available AWS CloudHSM capacity.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAvailableZones service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListAvailableZones">REST API Reference for ListAvailableZones Operation</seealso>
        Task<ListAvailableZonesResponse> ListAvailableZonesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the ListAvailableZones operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableZones operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListAvailableZones">REST API Reference for ListAvailableZones Operation</seealso>
        Task<ListAvailableZonesResponse> ListAvailableZonesAsync(ListAvailableZonesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListHapgs


        /// <summary>
        /// Lists the high-availability partition groups for the account.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <code>NextToken</code> member.
        /// If more results are available, the <code>NextToken</code> member of the response contains
        /// a token that you pass in the next call to <code>ListHapgs</code> to retrieve the next
        /// set of items.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListHapgs service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListHapgs">REST API Reference for ListHapgs Operation</seealso>
        ListHapgsResponse ListHapgs();

        /// <summary>
        /// Lists the high-availability partition groups for the account.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <code>NextToken</code> member.
        /// If more results are available, the <code>NextToken</code> member of the response contains
        /// a token that you pass in the next call to <code>ListHapgs</code> to retrieve the next
        /// set of items.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHapgs service method.</param>
        /// 
        /// <returns>The response from the ListHapgs service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListHapgs">REST API Reference for ListHapgs Operation</seealso>
        ListHapgsResponse ListHapgs(ListHapgsRequest request);


        /// <summary>
        /// Lists the high-availability partition groups for the account.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <code>NextToken</code> member.
        /// If more results are available, the <code>NextToken</code> member of the response contains
        /// a token that you pass in the next call to <code>ListHapgs</code> to retrieve the next
        /// set of items.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHapgs service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListHapgs">REST API Reference for ListHapgs Operation</seealso>
        Task<ListHapgsResponse> ListHapgsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the ListHapgs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHapgs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListHapgs">REST API Reference for ListHapgs Operation</seealso>
        Task<ListHapgsResponse> ListHapgsAsync(ListHapgsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListHsms


        /// <summary>
        /// Retrieves the identifiers of all of the HSMs provisioned for the current customer.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <code>NextToken</code> member.
        /// If more results are available, the <code>NextToken</code> member of the response contains
        /// a token that you pass in the next call to <code>ListHsms</code> to retrieve the next
        /// set of items.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListHsms service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListHsms">REST API Reference for ListHsms Operation</seealso>
        ListHsmsResponse ListHsms();

        /// <summary>
        /// Retrieves the identifiers of all of the HSMs provisioned for the current customer.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <code>NextToken</code> member.
        /// If more results are available, the <code>NextToken</code> member of the response contains
        /// a token that you pass in the next call to <code>ListHsms</code> to retrieve the next
        /// set of items.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHsms service method.</param>
        /// 
        /// <returns>The response from the ListHsms service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListHsms">REST API Reference for ListHsms Operation</seealso>
        ListHsmsResponse ListHsms(ListHsmsRequest request);


        /// <summary>
        /// Retrieves the identifiers of all of the HSMs provisioned for the current customer.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <code>NextToken</code> member.
        /// If more results are available, the <code>NextToken</code> member of the response contains
        /// a token that you pass in the next call to <code>ListHsms</code> to retrieve the next
        /// set of items.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHsms service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListHsms">REST API Reference for ListHsms Operation</seealso>
        Task<ListHsmsResponse> ListHsmsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the ListHsms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHsms operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListHsms">REST API Reference for ListHsms Operation</seealso>
        Task<ListHsmsResponse> ListHsmsAsync(ListHsmsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLunaClients


        /// <summary>
        /// Lists all of the clients.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <code>NextToken</code> member.
        /// If more results are available, the <code>NextToken</code> member of the response contains
        /// a token that you pass in the next call to <code>ListLunaClients</code> to retrieve
        /// the next set of items.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListLunaClients service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListLunaClients">REST API Reference for ListLunaClients Operation</seealso>
        ListLunaClientsResponse ListLunaClients();

        /// <summary>
        /// Lists all of the clients.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <code>NextToken</code> member.
        /// If more results are available, the <code>NextToken</code> member of the response contains
        /// a token that you pass in the next call to <code>ListLunaClients</code> to retrieve
        /// the next set of items.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLunaClients service method.</param>
        /// 
        /// <returns>The response from the ListLunaClients service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListLunaClients">REST API Reference for ListLunaClients Operation</seealso>
        ListLunaClientsResponse ListLunaClients(ListLunaClientsRequest request);


        /// <summary>
        /// Lists all of the clients.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <code>NextToken</code> member.
        /// If more results are available, the <code>NextToken</code> member of the response contains
        /// a token that you pass in the next call to <code>ListLunaClients</code> to retrieve
        /// the next set of items.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLunaClients service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListLunaClients">REST API Reference for ListLunaClients Operation</seealso>
        Task<ListLunaClientsResponse> ListLunaClientsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the ListLunaClients operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLunaClients operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListLunaClients">REST API Reference for ListLunaClients Operation</seealso>
        Task<ListLunaClientsResponse> ListLunaClientsAsync(ListLunaClientsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of all tags for the specified AWS CloudHSM resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyHapg


        /// <summary>
        /// Modifies an existing high-availability partition group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyHapg service method.</param>
        /// 
        /// <returns>The response from the ModifyHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ModifyHapg">REST API Reference for ModifyHapg Operation</seealso>
        ModifyHapgResponse ModifyHapg(ModifyHapgRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyHapg operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyHapg operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ModifyHapg">REST API Reference for ModifyHapg Operation</seealso>
        Task<ModifyHapgResponse> ModifyHapgAsync(ModifyHapgRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyHsm


        /// <summary>
        /// Modifies an HSM.
        /// 
        ///  <important> 
        /// <para>
        /// This operation can result in the HSM being offline for up to 15 minutes while the
        /// AWS CloudHSM service is reconfigured. If you are modifying a production HSM, you should
        /// ensure that your AWS CloudHSM service is configured for high availability, and consider
        /// executing this operation during a maintenance window.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyHsm service method.</param>
        /// 
        /// <returns>The response from the ModifyHsm service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ModifyHsm">REST API Reference for ModifyHsm Operation</seealso>
        ModifyHsmResponse ModifyHsm(ModifyHsmRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyHsm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyHsm operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ModifyHsm">REST API Reference for ModifyHsm Operation</seealso>
        Task<ModifyHsmResponse> ModifyHsmAsync(ModifyHsmRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyLunaClient


        /// <summary>
        /// Modifies the certificate used by the client.
        /// 
        ///  
        /// <para>
        /// This action can potentially start a workflow to install the new certificate on the
        /// client's HSMs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyLunaClient service method.</param>
        /// 
        /// <returns>The response from the ModifyLunaClient service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ModifyLunaClient">REST API Reference for ModifyLunaClient Operation</seealso>
        ModifyLunaClientResponse ModifyLunaClient(ModifyLunaClientRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyLunaClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyLunaClient operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ModifyLunaClient">REST API Reference for ModifyLunaClient Operation</seealso>
        Task<ModifyLunaClientResponse> ModifyLunaClientAsync(ModifyLunaClientRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveTagsFromResource


        /// <summary>
        /// Removes one or more tags from the specified AWS CloudHSM resource.
        /// 
        ///  
        /// <para>
        /// To remove a tag, specify only the tag key to remove (not the value). To overwrite
        /// the value for an existing tag, use <a>AddTagsToResource</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}