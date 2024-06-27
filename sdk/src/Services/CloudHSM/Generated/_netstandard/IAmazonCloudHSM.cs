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
 * Do not modify this file. This file is generated from the cloudhsm-2014-05-30.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CloudHSM.Model;

#pragma warning disable CS1570
namespace Amazon.CloudHSM
{
    /// <summary>
    /// <para>Interface for accessing CloudHSM</para>
    ///
    /// AWS CloudHSM Service 
    /// <para>
    /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
    /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
    /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
    /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
    /// CloudHSM Classic API Reference</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
    /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
    /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
    /// CloudHSM API Reference</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCloudHSM : IAmazonService, IDisposable
    {
                
        #region  AddTagsToResource



        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Adds or overwrites one or more tags for the specified AWS CloudHSM resource.
        /// </para>
        ///  
        /// <para>
        /// Each tag consists of a key and a value. Tag keys must be unique to each resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        [Obsolete("This API is deprecated.")]
        Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateHapg


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Creates a high-availability partition group. A high-availability partition group is
        /// a group of partitions that spans multiple physical HSMs.
        /// </para>
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
        [Obsolete("This API is deprecated.")]
        Task<CreateHapgResponse> CreateHapgAsync(string label, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Creates a high-availability partition group. A high-availability partition group is
        /// a group of partitions that spans multiple physical HSMs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHapg service method.</param>
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
        [Obsolete("This API is deprecated.")]
        Task<CreateHapgResponse> CreateHapgAsync(CreateHapgRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateHsm



        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Creates an uninitialized HSM instance.
        /// </para>
        ///  
        /// <para>
        /// There is an upfront fee charged for each HSM instance that you create with the <c>CreateHsm</c>
        /// operation. If you accidentally provision an HSM and want to request a refund, delete
        /// the instance using the <a>DeleteHsm</a> operation, go to the <a href="https://console.aws.amazon.com/support/home">AWS
        /// Support Center</a>, create a new case, and select <b>Account and Billing Support</b>.
        /// </para>
        ///  <important> 
        /// <para>
        /// It can take up to 20 minutes to create and provision an HSM. You can monitor the status
        /// of the HSM with the <a>DescribeHsm</a> operation. The HSM is ready to be initialized
        /// when the status changes to <c>RUNNING</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHsm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        [Obsolete("This API is deprecated.")]
        Task<CreateHsmResponse> CreateHsmAsync(CreateHsmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLunaClient



        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Creates an HSM client.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLunaClient service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        [Obsolete("This API is deprecated.")]
        Task<CreateLunaClientResponse> CreateLunaClientAsync(CreateLunaClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteHapg


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Deletes a high-availability partition group.
        /// </para>
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
        [Obsolete("This API is deprecated.")]
        Task<DeleteHapgResponse> DeleteHapgAsync(string hapgArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Deletes a high-availability partition group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHapg service method.</param>
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
        [Obsolete("This API is deprecated.")]
        Task<DeleteHapgResponse> DeleteHapgAsync(DeleteHapgRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteHsm


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Deletes an HSM. After completion, this operation cannot be undone and your key material
        /// cannot be recovered.
        /// </para>
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
        [Obsolete("This API is deprecated.")]
        Task<DeleteHsmResponse> DeleteHsmAsync(string hsmArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Deletes an HSM. After completion, this operation cannot be undone and your key material
        /// cannot be recovered.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsm service method.</param>
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
        [Obsolete("This API is deprecated.")]
        Task<DeleteHsmResponse> DeleteHsmAsync(DeleteHsmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLunaClient


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Deletes a client.
        /// </para>
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
        [Obsolete("This API is deprecated.")]
        Task<DeleteLunaClientResponse> DeleteLunaClientAsync(string clientArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Deletes a client.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLunaClient service method.</param>
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
        [Obsolete("This API is deprecated.")]
        Task<DeleteLunaClientResponse> DeleteLunaClientAsync(DeleteLunaClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeHapg


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Retrieves information about a high-availability partition group.
        /// </para>
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
        [Obsolete("This API is deprecated.")]
        Task<DescribeHapgResponse> DescribeHapgAsync(string hapgArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Retrieves information about a high-availability partition group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHapg service method.</param>
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
        [Obsolete("This API is deprecated.")]
        Task<DescribeHapgResponse> DescribeHapgAsync(DescribeHapgRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeHsm


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Retrieves information about an HSM. You can identify the HSM by its ARN or its serial
        /// number.
        /// </para>
        /// </summary>
        /// <param name="hsmArn">The ARN of the HSM. Either the <c>HsmArn</c> or the <c>SerialNumber</c> parameter must be specified.</param>
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
        [Obsolete("This API is deprecated.")]
        Task<DescribeHsmResponse> DescribeHsmAsync(string hsmArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Retrieves information about an HSM. You can identify the HSM by its ARN or its serial
        /// number.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsm service method.</param>
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
        [Obsolete("This API is deprecated.")]
        Task<DescribeHsmResponse> DescribeHsmAsync(DescribeHsmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLunaClient



        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Retrieves information about an HSM client.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLunaClient service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        [Obsolete("This API is deprecated.")]
        Task<DescribeLunaClientResponse> DescribeLunaClientAsync(DescribeLunaClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetConfig



        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Gets the configuration files necessary to connect to all high availability partition
        /// groups the client is associated with.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        [Obsolete("This API is deprecated.")]
        Task<GetConfigResponse> GetConfigAsync(GetConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAvailableZones


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Lists the Availability Zones that have available AWS CloudHSM capacity.
        /// </para>
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
        [Obsolete("This API is deprecated.")]
        Task<ListAvailableZonesResponse> ListAvailableZonesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Lists the Availability Zones that have available AWS CloudHSM capacity.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableZones service method.</param>
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
        [Obsolete("This API is deprecated.")]
        Task<ListAvailableZonesResponse> ListAvailableZonesAsync(ListAvailableZonesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHapgs


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Lists the high-availability partition groups for the account.
        /// </para>
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <c>NextToken</c> member. If
        /// more results are available, the <c>NextToken</c> member of the response contains a
        /// token that you pass in the next call to <c>ListHapgs</c> to retrieve the next set
        /// of items.
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
        [Obsolete("This API is deprecated.")]
        Task<ListHapgsResponse> ListHapgsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Lists the high-availability partition groups for the account.
        /// </para>
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <c>NextToken</c> member. If
        /// more results are available, the <c>NextToken</c> member of the response contains a
        /// token that you pass in the next call to <c>ListHapgs</c> to retrieve the next set
        /// of items.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHapgs service method.</param>
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
        [Obsolete("This API is deprecated.")]
        Task<ListHapgsResponse> ListHapgsAsync(ListHapgsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHsms


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Retrieves the identifiers of all of the HSMs provisioned for the current customer.
        /// </para>
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <c>NextToken</c> member. If
        /// more results are available, the <c>NextToken</c> member of the response contains a
        /// token that you pass in the next call to <c>ListHsms</c> to retrieve the next set of
        /// items.
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
        [Obsolete("This API is deprecated.")]
        Task<ListHsmsResponse> ListHsmsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Retrieves the identifiers of all of the HSMs provisioned for the current customer.
        /// </para>
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <c>NextToken</c> member. If
        /// more results are available, the <c>NextToken</c> member of the response contains a
        /// token that you pass in the next call to <c>ListHsms</c> to retrieve the next set of
        /// items.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHsms service method.</param>
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
        [Obsolete("This API is deprecated.")]
        Task<ListHsmsResponse> ListHsmsAsync(ListHsmsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListLunaClients


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Lists all of the clients.
        /// </para>
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <c>NextToken</c> member. If
        /// more results are available, the <c>NextToken</c> member of the response contains a
        /// token that you pass in the next call to <c>ListLunaClients</c> to retrieve the next
        /// set of items.
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
        [Obsolete("This API is deprecated.")]
        Task<ListLunaClientsResponse> ListLunaClientsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Lists all of the clients.
        /// </para>
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <c>NextToken</c> member. If
        /// more results are available, the <c>NextToken</c> member of the response contains a
        /// token that you pass in the next call to <c>ListLunaClients</c> to retrieve the next
        /// set of items.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLunaClients service method.</param>
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
        [Obsolete("This API is deprecated.")]
        Task<ListLunaClientsResponse> ListLunaClientsAsync(ListLunaClientsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Returns a list of all tags for the specified AWS CloudHSM resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        [Obsolete("This API is deprecated.")]
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyHapg



        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Modifies an existing high-availability partition group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyHapg service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        [Obsolete("This API is deprecated.")]
        Task<ModifyHapgResponse> ModifyHapgAsync(ModifyHapgRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyHsm



        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Modifies an HSM.
        /// </para>
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        [Obsolete("This API is deprecated.")]
        Task<ModifyHsmResponse> ModifyHsmAsync(ModifyHsmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyLunaClient



        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Modifies the certificate used by the client.
        /// </para>
        ///  
        /// <para>
        /// This action can potentially start a workflow to install the new certificate on the
        /// client's HSMs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyLunaClient service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyLunaClient service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ModifyLunaClient">REST API Reference for ModifyLunaClient Operation</seealso>
        [Obsolete("This API is deprecated.")]
        Task<ModifyLunaClientResponse> ModifyLunaClientAsync(ModifyLunaClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveTagsFromResource



        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Removes one or more tags from the specified AWS CloudHSM resource.
        /// </para>
        ///  
        /// <para>
        /// To remove a tag, specify only the tag key to remove (not the value). To overwrite
        /// the value for an existing tag, use <a>AddTagsToResource</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        [Obsolete("This API is deprecated.")]
        Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonCloudHSMConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonCloudHSMConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonCloudHSMConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonCloudHSMConfig to create AmazonCloudHSMClient");
            }

            return awsCredentials == null ? 
                    new AmazonCloudHSMClient(serviceClientConfig) :
                    new AmazonCloudHSMClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}