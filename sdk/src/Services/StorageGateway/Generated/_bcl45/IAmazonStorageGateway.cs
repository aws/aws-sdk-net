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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.StorageGateway.Model;

namespace Amazon.StorageGateway
{
    /// <summary>
    /// Interface for accessing StorageGateway
    ///
    /// AWS Storage Gateway Service 
    /// <para>
    /// AWS Storage Gateway is the service that connects an on-premises software appliance
    /// with cloud-based storage to provide seamless and secure integration between an organization's
    /// on-premises IT environment and the AWS storage infrastructure. The service enables
    /// you to securely upload data to the AWS Cloud for cost effective backup and rapid disaster
    /// recovery.
    /// </para>
    ///  
    /// <para>
    /// Use the following links to get started using the <i>AWS Storage Gateway Service API
    /// Reference</i>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/AWSStorageGatewayAPI.html#AWSStorageGatewayHTTPRequestsHeaders">AWS
    /// Storage Gateway required request headers</a>: Describes the required headers that
    /// you must send with every POST request to AWS Storage Gateway.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/AWSStorageGatewayAPI.html#AWSStorageGatewaySigningRequests">Signing
    /// requests</a>: AWS Storage Gateway requires that you authenticate every request you
    /// send; this topic describes how sign such a request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/AWSStorageGatewayAPI.html#APIErrorResponses">Error
    /// responses</a>: Provides reference information about AWS Storage Gateway errors.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/storagegateway/latest/APIReference/API_Operations.html">Operations
    /// in AWS Storage Gateway</a>: Contains detailed descriptions of all AWS Storage Gateway
    /// operations, their request parameters, response elements, possible errors, and examples
    /// of requests and responses.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/general/latest/gr/sg.html">AWS Storage Gateway
    /// endpoints and quotas</a>: Provides a list of each AWS Region and the endpoints available
    /// for use with AWS Storage Gateway.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// AWS Storage Gateway resource IDs are in uppercase. When you use these resource IDs
    /// with the Amazon EC2 API, EC2 expects resource IDs in lowercase. You must change your
    /// resource ID to lowercase to use it with the EC2 API. For example, in Storage Gateway
    /// the ID for a volume might be <code>vol-AA22BB012345DAF670</code>. When you use this
    /// ID with the EC2 API, you must change it to <code>vol-aa22bb012345daf670</code>. Otherwise,
    /// the EC2 API might not behave as expected.
    /// </para>
    ///  </note> <important> 
    /// <para>
    /// IDs for Storage Gateway volumes and Amazon EBS snapshots created from gateway volumes
    /// are changing to a longer format. Starting in December 2016, all new volumes and snapshots
    /// will be created with a 17-character string. Starting in April 2016, you will be able
    /// to use these longer IDs so you can test your systems with the new format. For more
    /// information, see <a href="http://aws.amazon.com/ec2/faqs/#longer-ids">Longer EC2 and
    /// EBS resource IDs</a>.
    /// </para>
    ///  
    /// <para>
    /// For example, a volume Amazon Resource Name (ARN) with the longer volume ID format
    /// looks like the following:
    /// </para>
    ///  
    /// <para>
    ///  <code>arn:aws:storagegateway:us-west-2:111122223333:gateway/sgw-12A3456B/volume/vol-1122AABBCCDDEEFFG</code>.
    /// </para>
    ///  
    /// <para>
    /// A snapshot ID with the longer ID format looks like the following: <code>snap-78e226633445566ee</code>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="http://forums.aws.amazon.com/ann.jspa?annID=3557">Announcement:
    /// Heads-up – Longer AWS Storage Gateway volume and snapshot IDs coming in 2016</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial interface IAmazonStorageGateway : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IStorageGatewayPaginatorFactory Paginators { get; }

        
        #region  ActivateGateway


        /// <summary>
        /// Activates the gateway you previously deployed on your host. In the activation process,
        /// you specify information such as the AWS Region that you want to use for storing snapshots
        /// or tapes, the time zone for scheduled snapshots the gateway snapshot schedule window,
        /// an activation key, and a name for your gateway. The activation process also associates
        /// your gateway with your account. For more information, see <a>UpdateGatewayInformation</a>.
        /// 
        ///  <note> 
        /// <para>
        /// You must turn on the gateway VM before you can activate your gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateGateway service method.</param>
        /// 
        /// <returns>The response from the ActivateGateway service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ActivateGateway">REST API Reference for ActivateGateway Operation</seealso>
        ActivateGatewayResponse ActivateGateway(ActivateGatewayRequest request);



        /// <summary>
        /// Activates the gateway you previously deployed on your host. In the activation process,
        /// you specify information such as the AWS Region that you want to use for storing snapshots
        /// or tapes, the time zone for scheduled snapshots the gateway snapshot schedule window,
        /// an activation key, and a name for your gateway. The activation process also associates
        /// your gateway with your account. For more information, see <a>UpdateGatewayInformation</a>.
        /// 
        ///  <note> 
        /// <para>
        /// You must turn on the gateway VM before you can activate your gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ActivateGateway service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ActivateGateway">REST API Reference for ActivateGateway Operation</seealso>
        Task<ActivateGatewayResponse> ActivateGatewayAsync(ActivateGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AddCache


        /// <summary>
        /// Configures one or more gateway local disks as cache for a gateway. This operation
        /// is only supported in the cached volume, tape, and file gateway type (see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/StorageGatewayConcepts.html">How
        /// AWS Storage Gateway works (architecture)</a>.
        /// 
        ///  
        /// <para>
        /// In the request, you specify the gateway Amazon Resource Name (ARN) to which you want
        /// to add cache, and one or more disk IDs that you want to configure as cache.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddCache service method.</param>
        /// 
        /// <returns>The response from the AddCache service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/AddCache">REST API Reference for AddCache Operation</seealso>
        AddCacheResponse AddCache(AddCacheRequest request);



        /// <summary>
        /// Configures one or more gateway local disks as cache for a gateway. This operation
        /// is only supported in the cached volume, tape, and file gateway type (see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/StorageGatewayConcepts.html">How
        /// AWS Storage Gateway works (architecture)</a>.
        /// 
        ///  
        /// <para>
        /// In the request, you specify the gateway Amazon Resource Name (ARN) to which you want
        /// to add cache, and one or more disk IDs that you want to configure as cache.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddCache service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/AddCache">REST API Reference for AddCache Operation</seealso>
        Task<AddCacheResponse> AddCacheAsync(AddCacheRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AddTagsToResource


        /// <summary>
        /// Adds one or more tags to the specified resource. You use tags to add metadata to resources,
        /// which you can use to categorize these resources. For example, you can categorize resources
        /// by purpose, owner, environment, or team. Each tag consists of a key and a value, which
        /// you define. You can add tags to the following AWS Storage Gateway resources:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Storage gateways of all types
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Storage volumes
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Virtual tapes
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NFS and SMB file shares
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can create a maximum of 50 tags for each resource. Virtual tapes and storage volumes
        /// that are recovered to a new gateway maintain their tags.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request);



        /// <summary>
        /// Adds one or more tags to the specified resource. You use tags to add metadata to resources,
        /// which you can use to categorize these resources. For example, you can categorize resources
        /// by purpose, owner, environment, or team. Each tag consists of a key and a value, which
        /// you define. You can add tags to the following AWS Storage Gateway resources:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Storage gateways of all types
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Storage volumes
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Virtual tapes
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NFS and SMB file shares
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can create a maximum of 50 tags for each resource. Virtual tapes and storage volumes
        /// that are recovered to a new gateway maintain their tags.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AddUploadBuffer


        /// <summary>
        /// Configures one or more gateway local disks as upload buffer for a specified gateway.
        /// This operation is supported for the stored volume, cached volume and tape gateway
        /// types.
        /// 
        ///  
        /// <para>
        /// In the request, you specify the gateway Amazon Resource Name (ARN) to which you want
        /// to add upload buffer, and one or more disk IDs that you want to configure as upload
        /// buffer.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddUploadBuffer service method.</param>
        /// 
        /// <returns>The response from the AddUploadBuffer service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/AddUploadBuffer">REST API Reference for AddUploadBuffer Operation</seealso>
        AddUploadBufferResponse AddUploadBuffer(AddUploadBufferRequest request);



        /// <summary>
        /// Configures one or more gateway local disks as upload buffer for a specified gateway.
        /// This operation is supported for the stored volume, cached volume and tape gateway
        /// types.
        /// 
        ///  
        /// <para>
        /// In the request, you specify the gateway Amazon Resource Name (ARN) to which you want
        /// to add upload buffer, and one or more disk IDs that you want to configure as upload
        /// buffer.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddUploadBuffer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddUploadBuffer service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/AddUploadBuffer">REST API Reference for AddUploadBuffer Operation</seealso>
        Task<AddUploadBufferResponse> AddUploadBufferAsync(AddUploadBufferRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AddWorkingStorage


        /// <summary>
        /// Configures one or more gateway local disks as working storage for a gateway. This
        /// operation is only supported in the stored volume gateway type. This operation is deprecated
        /// in cached volume API version 20120630. Use <a>AddUploadBuffer</a> instead.
        /// 
        ///  <note> 
        /// <para>
        /// Working storage is also referred to as upload buffer. You can also use the <a>AddUploadBuffer</a>
        /// operation to add upload buffer to a stored volume gateway.
        /// </para>
        ///  </note> 
        /// <para>
        /// In the request, you specify the gateway Amazon Resource Name (ARN) to which you want
        /// to add working storage, and one or more disk IDs that you want to configure as working
        /// storage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddWorkingStorage service method.</param>
        /// 
        /// <returns>The response from the AddWorkingStorage service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/AddWorkingStorage">REST API Reference for AddWorkingStorage Operation</seealso>
        AddWorkingStorageResponse AddWorkingStorage(AddWorkingStorageRequest request);



        /// <summary>
        /// Configures one or more gateway local disks as working storage for a gateway. This
        /// operation is only supported in the stored volume gateway type. This operation is deprecated
        /// in cached volume API version 20120630. Use <a>AddUploadBuffer</a> instead.
        /// 
        ///  <note> 
        /// <para>
        /// Working storage is also referred to as upload buffer. You can also use the <a>AddUploadBuffer</a>
        /// operation to add upload buffer to a stored volume gateway.
        /// </para>
        ///  </note> 
        /// <para>
        /// In the request, you specify the gateway Amazon Resource Name (ARN) to which you want
        /// to add working storage, and one or more disk IDs that you want to configure as working
        /// storage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddWorkingStorage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddWorkingStorage service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/AddWorkingStorage">REST API Reference for AddWorkingStorage Operation</seealso>
        Task<AddWorkingStorageResponse> AddWorkingStorageAsync(AddWorkingStorageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssignTapePool


        /// <summary>
        /// Assigns a tape to a tape pool for archiving. The tape assigned to a pool is archived
        /// in the S3 storage class that is associated with the pool. When you use your backup
        /// application to eject the tape, the tape is archived directly into the S3 storage class
        /// (S3 Glacier or S3 Glacier Deep Archive) that corresponds to the pool.
        /// 
        ///  
        /// <para>
        /// Valid Values: <code>GLACIER</code> | <code>DEEP_ARCHIVE</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssignTapePool service method.</param>
        /// 
        /// <returns>The response from the AssignTapePool service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/AssignTapePool">REST API Reference for AssignTapePool Operation</seealso>
        AssignTapePoolResponse AssignTapePool(AssignTapePoolRequest request);



        /// <summary>
        /// Assigns a tape to a tape pool for archiving. The tape assigned to a pool is archived
        /// in the S3 storage class that is associated with the pool. When you use your backup
        /// application to eject the tape, the tape is archived directly into the S3 storage class
        /// (S3 Glacier or S3 Glacier Deep Archive) that corresponds to the pool.
        /// 
        ///  
        /// <para>
        /// Valid Values: <code>GLACIER</code> | <code>DEEP_ARCHIVE</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssignTapePool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssignTapePool service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/AssignTapePool">REST API Reference for AssignTapePool Operation</seealso>
        Task<AssignTapePoolResponse> AssignTapePoolAsync(AssignTapePoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AttachVolume


        /// <summary>
        /// Connects a volume to an iSCSI connection and then attaches the volume to the specified
        /// gateway. Detaching and attaching a volume enables you to recover your data from one
        /// gateway to a different gateway without creating a snapshot. It also makes it easier
        /// to move your volumes from an on-premises gateway to a gateway hosted on an Amazon
        /// EC2 instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachVolume service method.</param>
        /// 
        /// <returns>The response from the AttachVolume service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/AttachVolume">REST API Reference for AttachVolume Operation</seealso>
        AttachVolumeResponse AttachVolume(AttachVolumeRequest request);



        /// <summary>
        /// Connects a volume to an iSCSI connection and then attaches the volume to the specified
        /// gateway. Detaching and attaching a volume enables you to recover your data from one
        /// gateway to a different gateway without creating a snapshot. It also makes it easier
        /// to move your volumes from an on-premises gateway to a gateway hosted on an Amazon
        /// EC2 instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachVolume service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/AttachVolume">REST API Reference for AttachVolume Operation</seealso>
        Task<AttachVolumeResponse> AttachVolumeAsync(AttachVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelArchival


        /// <summary>
        /// Cancels archiving of a virtual tape to the virtual tape shelf (VTS) after the archiving
        /// process is initiated. This operation is only supported in the tape gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelArchival service method.</param>
        /// 
        /// <returns>The response from the CancelArchival service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CancelArchival">REST API Reference for CancelArchival Operation</seealso>
        CancelArchivalResponse CancelArchival(CancelArchivalRequest request);



        /// <summary>
        /// Cancels archiving of a virtual tape to the virtual tape shelf (VTS) after the archiving
        /// process is initiated. This operation is only supported in the tape gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelArchival service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelArchival service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CancelArchival">REST API Reference for CancelArchival Operation</seealso>
        Task<CancelArchivalResponse> CancelArchivalAsync(CancelArchivalRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelRetrieval


        /// <summary>
        /// Cancels retrieval of a virtual tape from the virtual tape shelf (VTS) to a gateway
        /// after the retrieval process is initiated. The virtual tape is returned to the VTS.
        /// This operation is only supported in the tape gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelRetrieval service method.</param>
        /// 
        /// <returns>The response from the CancelRetrieval service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CancelRetrieval">REST API Reference for CancelRetrieval Operation</seealso>
        CancelRetrievalResponse CancelRetrieval(CancelRetrievalRequest request);



        /// <summary>
        /// Cancels retrieval of a virtual tape from the virtual tape shelf (VTS) to a gateway
        /// after the retrieval process is initiated. The virtual tape is returned to the VTS.
        /// This operation is only supported in the tape gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelRetrieval service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelRetrieval service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CancelRetrieval">REST API Reference for CancelRetrieval Operation</seealso>
        Task<CancelRetrievalResponse> CancelRetrievalAsync(CancelRetrievalRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCachediSCSIVolume


        /// <summary>
        /// Creates a cached volume on a specified cached volume gateway. This operation is only
        /// supported in the cached volume gateway type.
        /// 
        ///  <note> 
        /// <para>
        /// Cache storage must be allocated to the gateway before you can create a cached volume.
        /// Use the <a>AddCache</a> operation to add cache storage to a gateway.
        /// </para>
        ///  </note> 
        /// <para>
        /// In the request, you must specify the gateway, size of the volume in bytes, the iSCSI
        /// target name, an IP address on which to expose the target, and a unique client token.
        /// In response, the gateway creates the volume and returns information about it. This
        /// information includes the volume Amazon Resource Name (ARN), its size, and the iSCSI
        /// target ARN that initiators can use to connect to the volume target.
        /// </para>
        ///  
        /// <para>
        /// Optionally, you can provide the ARN for an existing volume as the <code>SourceVolumeARN</code>
        /// for this cached volume, which creates an exact copy of the existing volume’s latest
        /// recovery point. The <code>VolumeSizeInBytes</code> value must be equal to or larger
        /// than the size of the copied volume, in bytes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCachediSCSIVolume service method.</param>
        /// 
        /// <returns>The response from the CreateCachediSCSIVolume service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateCachediSCSIVolume">REST API Reference for CreateCachediSCSIVolume Operation</seealso>
        CreateCachediSCSIVolumeResponse CreateCachediSCSIVolume(CreateCachediSCSIVolumeRequest request);



        /// <summary>
        /// Creates a cached volume on a specified cached volume gateway. This operation is only
        /// supported in the cached volume gateway type.
        /// 
        ///  <note> 
        /// <para>
        /// Cache storage must be allocated to the gateway before you can create a cached volume.
        /// Use the <a>AddCache</a> operation to add cache storage to a gateway.
        /// </para>
        ///  </note> 
        /// <para>
        /// In the request, you must specify the gateway, size of the volume in bytes, the iSCSI
        /// target name, an IP address on which to expose the target, and a unique client token.
        /// In response, the gateway creates the volume and returns information about it. This
        /// information includes the volume Amazon Resource Name (ARN), its size, and the iSCSI
        /// target ARN that initiators can use to connect to the volume target.
        /// </para>
        ///  
        /// <para>
        /// Optionally, you can provide the ARN for an existing volume as the <code>SourceVolumeARN</code>
        /// for this cached volume, which creates an exact copy of the existing volume’s latest
        /// recovery point. The <code>VolumeSizeInBytes</code> value must be equal to or larger
        /// than the size of the copied volume, in bytes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCachediSCSIVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCachediSCSIVolume service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateCachediSCSIVolume">REST API Reference for CreateCachediSCSIVolume Operation</seealso>
        Task<CreateCachediSCSIVolumeResponse> CreateCachediSCSIVolumeAsync(CreateCachediSCSIVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateNFSFileShare


        /// <summary>
        /// Creates a Network File System (NFS) file share on an existing file gateway. In Storage
        /// Gateway, a file share is a file system mount point backed by Amazon S3 cloud storage.
        /// Storage Gateway exposes file shares using an NFS interface. This operation is only
        /// supported for file gateways.
        /// 
        ///  <important> 
        /// <para>
        /// File gateway requires AWS Security Token Service (AWS STS) to be activated to enable
        /// you to create a file share. Make sure AWS STS is activated in the AWS Region you are
        /// creating your file gateway in. If AWS STS is not activated in the AWS Region, activate
        /// it. For information about how to activate AWS STS, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and deactivating AWS STS in an AWS Region</a> in the <i>AWS Identity and Access Management
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// File gateway does not support creating hard or symbolic links on a file share.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNFSFileShare service method.</param>
        /// 
        /// <returns>The response from the CreateNFSFileShare service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateNFSFileShare">REST API Reference for CreateNFSFileShare Operation</seealso>
        CreateNFSFileShareResponse CreateNFSFileShare(CreateNFSFileShareRequest request);



        /// <summary>
        /// Creates a Network File System (NFS) file share on an existing file gateway. In Storage
        /// Gateway, a file share is a file system mount point backed by Amazon S3 cloud storage.
        /// Storage Gateway exposes file shares using an NFS interface. This operation is only
        /// supported for file gateways.
        /// 
        ///  <important> 
        /// <para>
        /// File gateway requires AWS Security Token Service (AWS STS) to be activated to enable
        /// you to create a file share. Make sure AWS STS is activated in the AWS Region you are
        /// creating your file gateway in. If AWS STS is not activated in the AWS Region, activate
        /// it. For information about how to activate AWS STS, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and deactivating AWS STS in an AWS Region</a> in the <i>AWS Identity and Access Management
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// File gateway does not support creating hard or symbolic links on a file share.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNFSFileShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNFSFileShare service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateNFSFileShare">REST API Reference for CreateNFSFileShare Operation</seealso>
        Task<CreateNFSFileShareResponse> CreateNFSFileShareAsync(CreateNFSFileShareRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSMBFileShare


        /// <summary>
        /// Creates a Server Message Block (SMB) file share on an existing file gateway. In Storage
        /// Gateway, a file share is a file system mount point backed by Amazon S3 cloud storage.
        /// Storage Gateway exposes file shares using an SMB interface. This operation is only
        /// supported for file gateways.
        /// 
        ///  <important> 
        /// <para>
        /// File gateways require AWS Security Token Service (AWS STS) to be activated to enable
        /// you to create a file share. Make sure that AWS STS is activated in the AWS Region
        /// you are creating your file gateway in. If AWS STS is not activated in this AWS Region,
        /// activate it. For information about how to activate AWS STS, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and deactivating AWS STS in an AWS Region</a> in the <i>AWS Identity and Access Management
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// File gateways don't support creating hard or symbolic links on a file share.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSMBFileShare service method.</param>
        /// 
        /// <returns>The response from the CreateSMBFileShare service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateSMBFileShare">REST API Reference for CreateSMBFileShare Operation</seealso>
        CreateSMBFileShareResponse CreateSMBFileShare(CreateSMBFileShareRequest request);



        /// <summary>
        /// Creates a Server Message Block (SMB) file share on an existing file gateway. In Storage
        /// Gateway, a file share is a file system mount point backed by Amazon S3 cloud storage.
        /// Storage Gateway exposes file shares using an SMB interface. This operation is only
        /// supported for file gateways.
        /// 
        ///  <important> 
        /// <para>
        /// File gateways require AWS Security Token Service (AWS STS) to be activated to enable
        /// you to create a file share. Make sure that AWS STS is activated in the AWS Region
        /// you are creating your file gateway in. If AWS STS is not activated in this AWS Region,
        /// activate it. For information about how to activate AWS STS, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and deactivating AWS STS in an AWS Region</a> in the <i>AWS Identity and Access Management
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// File gateways don't support creating hard or symbolic links on a file share.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSMBFileShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSMBFileShare service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateSMBFileShare">REST API Reference for CreateSMBFileShare Operation</seealso>
        Task<CreateSMBFileShareResponse> CreateSMBFileShareAsync(CreateSMBFileShareRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSnapshot


        /// <summary>
        /// Initiates a snapshot of a volume.
        /// 
        ///  
        /// <para>
        /// AWS Storage Gateway provides the ability to back up point-in-time snapshots of your
        /// data to Amazon Simple Storage (Amazon S3) for durable off-site recovery, as well as
        /// import the data to an Amazon Elastic Block Store (EBS) volume in Amazon Elastic Compute
        /// Cloud (EC2). You can take snapshots of your gateway volume on a scheduled or ad hoc
        /// basis. This API enables you to take an ad hoc snapshot. For more information, see
        /// <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/managing-volumes.html#SchedulingSnapshot">Editing
        /// a snapshot schedule</a>.
        /// </para>
        ///  
        /// <para>
        /// In the <code>CreateSnapshot</code> request, you identify the volume by providing its
        /// Amazon Resource Name (ARN). You must also provide description for the snapshot. When
        /// AWS Storage Gateway takes the snapshot of specified volume, the snapshot and description
        /// appears in the AWS Storage Gateway console. In response, AWS Storage Gateway returns
        /// you a snapshot ID. You can use this snapshot ID to check the snapshot progress or
        /// later use it when you want to create a volume from a snapshot. This operation is only
        /// supported in stored and cached volume gateway type.
        /// </para>
        ///  <note> 
        /// <para>
        /// To list or delete a snapshot, you must use the Amazon EC2 API. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSnapshots.html">DescribeSnapshots</a>
        /// or <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DeleteSnapshot.html">DeleteSnapshot</a>
        /// in the <i>Amazon Elastic Compute Cloud API Reference</i>.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// Volume and snapshot IDs are changing to a longer length ID format. For more information,
        /// see the important note on the <a href="https://docs.aws.amazon.com/storagegateway/latest/APIReference/Welcome.html">Welcome</a>
        /// page.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.ServiceUnavailableErrorException">
        /// An internal server error has occurred because the service is unavailable. For more
        /// information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request);



        /// <summary>
        /// Initiates a snapshot of a volume.
        /// 
        ///  
        /// <para>
        /// AWS Storage Gateway provides the ability to back up point-in-time snapshots of your
        /// data to Amazon Simple Storage (Amazon S3) for durable off-site recovery, as well as
        /// import the data to an Amazon Elastic Block Store (EBS) volume in Amazon Elastic Compute
        /// Cloud (EC2). You can take snapshots of your gateway volume on a scheduled or ad hoc
        /// basis. This API enables you to take an ad hoc snapshot. For more information, see
        /// <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/managing-volumes.html#SchedulingSnapshot">Editing
        /// a snapshot schedule</a>.
        /// </para>
        ///  
        /// <para>
        /// In the <code>CreateSnapshot</code> request, you identify the volume by providing its
        /// Amazon Resource Name (ARN). You must also provide description for the snapshot. When
        /// AWS Storage Gateway takes the snapshot of specified volume, the snapshot and description
        /// appears in the AWS Storage Gateway console. In response, AWS Storage Gateway returns
        /// you a snapshot ID. You can use this snapshot ID to check the snapshot progress or
        /// later use it when you want to create a volume from a snapshot. This operation is only
        /// supported in stored and cached volume gateway type.
        /// </para>
        ///  <note> 
        /// <para>
        /// To list or delete a snapshot, you must use the Amazon EC2 API. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSnapshots.html">DescribeSnapshots</a>
        /// or <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DeleteSnapshot.html">DeleteSnapshot</a>
        /// in the <i>Amazon Elastic Compute Cloud API Reference</i>.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// Volume and snapshot IDs are changing to a longer length ID format. For more information,
        /// see the important note on the <a href="https://docs.aws.amazon.com/storagegateway/latest/APIReference/Welcome.html">Welcome</a>
        /// page.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.ServiceUnavailableErrorException">
        /// An internal server error has occurred because the service is unavailable. For more
        /// information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSnapshotFromVolumeRecoveryPoint


        /// <summary>
        /// Initiates a snapshot of a gateway from a volume recovery point. This operation is
        /// only supported in the cached volume gateway type.
        /// 
        ///  
        /// <para>
        /// A volume recovery point is a point in time at which all data of the volume is consistent
        /// and from which you can create a snapshot. To get a list of volume recovery point for
        /// cached volume gateway, use <a>ListVolumeRecoveryPoints</a>.
        /// </para>
        ///  
        /// <para>
        /// In the <code>CreateSnapshotFromVolumeRecoveryPoint</code> request, you identify the
        /// volume by providing its Amazon Resource Name (ARN). You must also provide a description
        /// for the snapshot. When the gateway takes a snapshot of the specified volume, the snapshot
        /// and its description appear in the AWS Storage Gateway console. In response, the gateway
        /// returns you a snapshot ID. You can use this snapshot ID to check the snapshot progress
        /// or later use it when you want to create a volume from a snapshot.
        /// </para>
        ///  <note> 
        /// <para>
        /// To list or delete a snapshot, you must use the Amazon EC2 API. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSnapshots.html">DescribeSnapshots</a>
        /// or <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DeleteSnapshot.html">DeleteSnapshot</a>
        /// in the <i>Amazon Elastic Compute Cloud API Reference</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotFromVolumeRecoveryPoint service method.</param>
        /// 
        /// <returns>The response from the CreateSnapshotFromVolumeRecoveryPoint service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.ServiceUnavailableErrorException">
        /// An internal server error has occurred because the service is unavailable. For more
        /// information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateSnapshotFromVolumeRecoveryPoint">REST API Reference for CreateSnapshotFromVolumeRecoveryPoint Operation</seealso>
        CreateSnapshotFromVolumeRecoveryPointResponse CreateSnapshotFromVolumeRecoveryPoint(CreateSnapshotFromVolumeRecoveryPointRequest request);



        /// <summary>
        /// Initiates a snapshot of a gateway from a volume recovery point. This operation is
        /// only supported in the cached volume gateway type.
        /// 
        ///  
        /// <para>
        /// A volume recovery point is a point in time at which all data of the volume is consistent
        /// and from which you can create a snapshot. To get a list of volume recovery point for
        /// cached volume gateway, use <a>ListVolumeRecoveryPoints</a>.
        /// </para>
        ///  
        /// <para>
        /// In the <code>CreateSnapshotFromVolumeRecoveryPoint</code> request, you identify the
        /// volume by providing its Amazon Resource Name (ARN). You must also provide a description
        /// for the snapshot. When the gateway takes a snapshot of the specified volume, the snapshot
        /// and its description appear in the AWS Storage Gateway console. In response, the gateway
        /// returns you a snapshot ID. You can use this snapshot ID to check the snapshot progress
        /// or later use it when you want to create a volume from a snapshot.
        /// </para>
        ///  <note> 
        /// <para>
        /// To list or delete a snapshot, you must use the Amazon EC2 API. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSnapshots.html">DescribeSnapshots</a>
        /// or <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DeleteSnapshot.html">DeleteSnapshot</a>
        /// in the <i>Amazon Elastic Compute Cloud API Reference</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotFromVolumeRecoveryPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSnapshotFromVolumeRecoveryPoint service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.ServiceUnavailableErrorException">
        /// An internal server error has occurred because the service is unavailable. For more
        /// information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateSnapshotFromVolumeRecoveryPoint">REST API Reference for CreateSnapshotFromVolumeRecoveryPoint Operation</seealso>
        Task<CreateSnapshotFromVolumeRecoveryPointResponse> CreateSnapshotFromVolumeRecoveryPointAsync(CreateSnapshotFromVolumeRecoveryPointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateStorediSCSIVolume


        /// <summary>
        /// Creates a volume on a specified gateway. This operation is only supported in the stored
        /// volume gateway type.
        /// 
        ///  
        /// <para>
        /// The size of the volume to create is inferred from the disk size. You can choose to
        /// preserve existing data on the disk, create volume from an existing snapshot, or create
        /// an empty volume. If you choose to create an empty gateway volume, then any existing
        /// data on the disk is erased.
        /// </para>
        ///  
        /// <para>
        /// In the request, you must specify the gateway and the disk information on which you
        /// are creating the volume. In response, the gateway creates the volume and returns volume
        /// information such as the volume Amazon Resource Name (ARN), its size, and the iSCSI
        /// target ARN that initiators can use to connect to the volume target.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStorediSCSIVolume service method.</param>
        /// 
        /// <returns>The response from the CreateStorediSCSIVolume service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateStorediSCSIVolume">REST API Reference for CreateStorediSCSIVolume Operation</seealso>
        CreateStorediSCSIVolumeResponse CreateStorediSCSIVolume(CreateStorediSCSIVolumeRequest request);



        /// <summary>
        /// Creates a volume on a specified gateway. This operation is only supported in the stored
        /// volume gateway type.
        /// 
        ///  
        /// <para>
        /// The size of the volume to create is inferred from the disk size. You can choose to
        /// preserve existing data on the disk, create volume from an existing snapshot, or create
        /// an empty volume. If you choose to create an empty gateway volume, then any existing
        /// data on the disk is erased.
        /// </para>
        ///  
        /// <para>
        /// In the request, you must specify the gateway and the disk information on which you
        /// are creating the volume. In response, the gateway creates the volume and returns volume
        /// information such as the volume Amazon Resource Name (ARN), its size, and the iSCSI
        /// target ARN that initiators can use to connect to the volume target.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStorediSCSIVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStorediSCSIVolume service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateStorediSCSIVolume">REST API Reference for CreateStorediSCSIVolume Operation</seealso>
        Task<CreateStorediSCSIVolumeResponse> CreateStorediSCSIVolumeAsync(CreateStorediSCSIVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateTapePool


        /// <summary>
        /// Creates a new custom tape pool. You can use custom tape pool to enable tape retention
        /// lock on tapes that are archived in the custom pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTapePool service method.</param>
        /// 
        /// <returns>The response from the CreateTapePool service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateTapePool">REST API Reference for CreateTapePool Operation</seealso>
        CreateTapePoolResponse CreateTapePool(CreateTapePoolRequest request);



        /// <summary>
        /// Creates a new custom tape pool. You can use custom tape pool to enable tape retention
        /// lock on tapes that are archived in the custom pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTapePool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTapePool service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateTapePool">REST API Reference for CreateTapePool Operation</seealso>
        Task<CreateTapePoolResponse> CreateTapePoolAsync(CreateTapePoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateTapes


        /// <summary>
        /// Creates one or more virtual tapes. You write data to the virtual tapes and then archive
        /// the tapes. This operation is only supported in the tape gateway type.
        /// 
        ///  <note> 
        /// <para>
        /// Cache storage must be allocated to the gateway before you can create virtual tapes.
        /// Use the <a>AddCache</a> operation to add cache storage to a gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTapes service method.</param>
        /// 
        /// <returns>The response from the CreateTapes service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateTapes">REST API Reference for CreateTapes Operation</seealso>
        CreateTapesResponse CreateTapes(CreateTapesRequest request);



        /// <summary>
        /// Creates one or more virtual tapes. You write data to the virtual tapes and then archive
        /// the tapes. This operation is only supported in the tape gateway type.
        /// 
        ///  <note> 
        /// <para>
        /// Cache storage must be allocated to the gateway before you can create virtual tapes.
        /// Use the <a>AddCache</a> operation to add cache storage to a gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTapes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTapes service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateTapes">REST API Reference for CreateTapes Operation</seealso>
        Task<CreateTapesResponse> CreateTapesAsync(CreateTapesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateTapeWithBarcode


        /// <summary>
        /// Creates a virtual tape by using your own barcode. You write data to the virtual tape
        /// and then archive the tape. A barcode is unique and cannot be reused if it has already
        /// been used on a tape. This applies to barcodes used on deleted tapes. This operation
        /// is only supported in the tape gateway type.
        /// 
        ///  <note> 
        /// <para>
        /// Cache storage must be allocated to the gateway before you can create a virtual tape.
        /// Use the <a>AddCache</a> operation to add cache storage to a gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTapeWithBarcode service method.</param>
        /// 
        /// <returns>The response from the CreateTapeWithBarcode service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateTapeWithBarcode">REST API Reference for CreateTapeWithBarcode Operation</seealso>
        CreateTapeWithBarcodeResponse CreateTapeWithBarcode(CreateTapeWithBarcodeRequest request);



        /// <summary>
        /// Creates a virtual tape by using your own barcode. You write data to the virtual tape
        /// and then archive the tape. A barcode is unique and cannot be reused if it has already
        /// been used on a tape. This applies to barcodes used on deleted tapes. This operation
        /// is only supported in the tape gateway type.
        /// 
        ///  <note> 
        /// <para>
        /// Cache storage must be allocated to the gateway before you can create a virtual tape.
        /// Use the <a>AddCache</a> operation to add cache storage to a gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTapeWithBarcode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTapeWithBarcode service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/CreateTapeWithBarcode">REST API Reference for CreateTapeWithBarcode Operation</seealso>
        Task<CreateTapeWithBarcodeResponse> CreateTapeWithBarcodeAsync(CreateTapeWithBarcodeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAutomaticTapeCreationPolicy


        /// <summary>
        /// Deletes the automatic tape creation policy of a gateway. If you delete this policy,
        /// new virtual tapes must be created manually. Use the Amazon Resource Name (ARN) of
        /// the gateway in your request to remove the policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutomaticTapeCreationPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteAutomaticTapeCreationPolicy service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteAutomaticTapeCreationPolicy">REST API Reference for DeleteAutomaticTapeCreationPolicy Operation</seealso>
        DeleteAutomaticTapeCreationPolicyResponse DeleteAutomaticTapeCreationPolicy(DeleteAutomaticTapeCreationPolicyRequest request);



        /// <summary>
        /// Deletes the automatic tape creation policy of a gateway. If you delete this policy,
        /// new virtual tapes must be created manually. Use the Amazon Resource Name (ARN) of
        /// the gateway in your request to remove the policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutomaticTapeCreationPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAutomaticTapeCreationPolicy service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteAutomaticTapeCreationPolicy">REST API Reference for DeleteAutomaticTapeCreationPolicy Operation</seealso>
        Task<DeleteAutomaticTapeCreationPolicyResponse> DeleteAutomaticTapeCreationPolicyAsync(DeleteAutomaticTapeCreationPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteBandwidthRateLimit


        /// <summary>
        /// Deletes the bandwidth rate limits of a gateway. You can delete either the upload and
        /// download bandwidth rate limit, or you can delete both. If you delete only one of the
        /// limits, the other limit remains unchanged. To specify which gateway to work with,
        /// use the Amazon Resource Name (ARN) of the gateway in your request. This operation
        /// is supported for the stored volume, cached volume and tape gateway types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBandwidthRateLimit service method.</param>
        /// 
        /// <returns>The response from the DeleteBandwidthRateLimit service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteBandwidthRateLimit">REST API Reference for DeleteBandwidthRateLimit Operation</seealso>
        DeleteBandwidthRateLimitResponse DeleteBandwidthRateLimit(DeleteBandwidthRateLimitRequest request);



        /// <summary>
        /// Deletes the bandwidth rate limits of a gateway. You can delete either the upload and
        /// download bandwidth rate limit, or you can delete both. If you delete only one of the
        /// limits, the other limit remains unchanged. To specify which gateway to work with,
        /// use the Amazon Resource Name (ARN) of the gateway in your request. This operation
        /// is supported for the stored volume, cached volume and tape gateway types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBandwidthRateLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBandwidthRateLimit service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteBandwidthRateLimit">REST API Reference for DeleteBandwidthRateLimit Operation</seealso>
        Task<DeleteBandwidthRateLimitResponse> DeleteBandwidthRateLimitAsync(DeleteBandwidthRateLimitRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteChapCredentials


        /// <summary>
        /// Deletes Challenge-Handshake Authentication Protocol (CHAP) credentials for a specified
        /// iSCSI target and initiator pair. This operation is supported in volume and tape gateway
        /// types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChapCredentials service method.</param>
        /// 
        /// <returns>The response from the DeleteChapCredentials service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteChapCredentials">REST API Reference for DeleteChapCredentials Operation</seealso>
        DeleteChapCredentialsResponse DeleteChapCredentials(DeleteChapCredentialsRequest request);



        /// <summary>
        /// Deletes Challenge-Handshake Authentication Protocol (CHAP) credentials for a specified
        /// iSCSI target and initiator pair. This operation is supported in volume and tape gateway
        /// types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChapCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChapCredentials service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteChapCredentials">REST API Reference for DeleteChapCredentials Operation</seealso>
        Task<DeleteChapCredentialsResponse> DeleteChapCredentialsAsync(DeleteChapCredentialsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFileShare


        /// <summary>
        /// Deletes a file share from a file gateway. This operation is only supported for file
        /// gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFileShare service method.</param>
        /// 
        /// <returns>The response from the DeleteFileShare service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteFileShare">REST API Reference for DeleteFileShare Operation</seealso>
        DeleteFileShareResponse DeleteFileShare(DeleteFileShareRequest request);



        /// <summary>
        /// Deletes a file share from a file gateway. This operation is only supported for file
        /// gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFileShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFileShare service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteFileShare">REST API Reference for DeleteFileShare Operation</seealso>
        Task<DeleteFileShareResponse> DeleteFileShareAsync(DeleteFileShareRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteGateway


        /// <summary>
        /// Deletes a gateway. To specify which gateway to delete, use the Amazon Resource Name
        /// (ARN) of the gateway in your request. The operation deletes the gateway; however,
        /// it does not delete the gateway virtual machine (VM) from your host computer.
        /// 
        ///  
        /// <para>
        /// After you delete a gateway, you cannot reactivate it. Completed snapshots of the gateway
        /// volumes are not deleted upon deleting the gateway, however, pending snapshots will
        /// not complete. After you delete a gateway, your next step is to remove it from your
        /// environment.
        /// </para>
        ///  <important> 
        /// <para>
        /// You no longer pay software charges after the gateway is deleted; however, your existing
        /// Amazon EBS snapshots persist and you will continue to be billed for these snapshots. You
        /// can choose to remove all remaining Amazon EBS snapshots by canceling your Amazon EC2
        /// subscription.  If you prefer not to cancel your Amazon EC2 subscription, you can delete
        /// your snapshots using the Amazon EC2 console. For more information, see the <a href="http://aws.amazon.com/storagegateway">AWS
        /// Storage Gateway detail page</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteGateway service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteGateway">REST API Reference for DeleteGateway Operation</seealso>
        DeleteGatewayResponse DeleteGateway(DeleteGatewayRequest request);



        /// <summary>
        /// Deletes a gateway. To specify which gateway to delete, use the Amazon Resource Name
        /// (ARN) of the gateway in your request. The operation deletes the gateway; however,
        /// it does not delete the gateway virtual machine (VM) from your host computer.
        /// 
        ///  
        /// <para>
        /// After you delete a gateway, you cannot reactivate it. Completed snapshots of the gateway
        /// volumes are not deleted upon deleting the gateway, however, pending snapshots will
        /// not complete. After you delete a gateway, your next step is to remove it from your
        /// environment.
        /// </para>
        ///  <important> 
        /// <para>
        /// You no longer pay software charges after the gateway is deleted; however, your existing
        /// Amazon EBS snapshots persist and you will continue to be billed for these snapshots. You
        /// can choose to remove all remaining Amazon EBS snapshots by canceling your Amazon EC2
        /// subscription.  If you prefer not to cancel your Amazon EC2 subscription, you can delete
        /// your snapshots using the Amazon EC2 console. For more information, see the <a href="http://aws.amazon.com/storagegateway">AWS
        /// Storage Gateway detail page</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGateway service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteGateway">REST API Reference for DeleteGateway Operation</seealso>
        Task<DeleteGatewayResponse> DeleteGatewayAsync(DeleteGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSnapshotSchedule


        /// <summary>
        /// Deletes a snapshot of a volume.
        /// 
        ///  
        /// <para>
        /// You can take snapshots of your gateway volumes on a scheduled or ad hoc basis. This
        /// API action enables you to delete a snapshot schedule for a volume. For more information,
        /// see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/backing-up-volumes.html">Backing
        /// up your volumes</a>. In the <code>DeleteSnapshotSchedule</code> request, you identify
        /// the volume by providing its Amazon Resource Name (ARN). This operation is only supported
        /// in stored and cached volume gateway types.
        /// </para>
        ///  <note> 
        /// <para>
        /// To list or delete a snapshot, you must use the Amazon EC2 API. For more information,
        /// go to <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSnapshots.html">DescribeSnapshots</a>
        /// in the <i>Amazon Elastic Compute Cloud API Reference</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotSchedule service method.</param>
        /// 
        /// <returns>The response from the DeleteSnapshotSchedule service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteSnapshotSchedule">REST API Reference for DeleteSnapshotSchedule Operation</seealso>
        DeleteSnapshotScheduleResponse DeleteSnapshotSchedule(DeleteSnapshotScheduleRequest request);



        /// <summary>
        /// Deletes a snapshot of a volume.
        /// 
        ///  
        /// <para>
        /// You can take snapshots of your gateway volumes on a scheduled or ad hoc basis. This
        /// API action enables you to delete a snapshot schedule for a volume. For more information,
        /// see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/backing-up-volumes.html">Backing
        /// up your volumes</a>. In the <code>DeleteSnapshotSchedule</code> request, you identify
        /// the volume by providing its Amazon Resource Name (ARN). This operation is only supported
        /// in stored and cached volume gateway types.
        /// </para>
        ///  <note> 
        /// <para>
        /// To list or delete a snapshot, you must use the Amazon EC2 API. For more information,
        /// go to <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSnapshots.html">DescribeSnapshots</a>
        /// in the <i>Amazon Elastic Compute Cloud API Reference</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSnapshotSchedule service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteSnapshotSchedule">REST API Reference for DeleteSnapshotSchedule Operation</seealso>
        Task<DeleteSnapshotScheduleResponse> DeleteSnapshotScheduleAsync(DeleteSnapshotScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTape


        /// <summary>
        /// Deletes the specified virtual tape. This operation is only supported in the tape gateway
        /// type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTape service method.</param>
        /// 
        /// <returns>The response from the DeleteTape service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteTape">REST API Reference for DeleteTape Operation</seealso>
        DeleteTapeResponse DeleteTape(DeleteTapeRequest request);



        /// <summary>
        /// Deletes the specified virtual tape. This operation is only supported in the tape gateway
        /// type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTape service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTape service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteTape">REST API Reference for DeleteTape Operation</seealso>
        Task<DeleteTapeResponse> DeleteTapeAsync(DeleteTapeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTapeArchive


        /// <summary>
        /// Deletes the specified virtual tape from the virtual tape shelf (VTS). This operation
        /// is only supported in the tape gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTapeArchive service method.</param>
        /// 
        /// <returns>The response from the DeleteTapeArchive service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteTapeArchive">REST API Reference for DeleteTapeArchive Operation</seealso>
        DeleteTapeArchiveResponse DeleteTapeArchive(DeleteTapeArchiveRequest request);



        /// <summary>
        /// Deletes the specified virtual tape from the virtual tape shelf (VTS). This operation
        /// is only supported in the tape gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTapeArchive service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTapeArchive service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteTapeArchive">REST API Reference for DeleteTapeArchive Operation</seealso>
        Task<DeleteTapeArchiveResponse> DeleteTapeArchiveAsync(DeleteTapeArchiveRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTapePool


        /// <summary>
        /// Delete a custom tape pool. A custom tape pool can only be deleted if there are no
        /// tapes in the pool and if there are no automatic tape creation policies that reference
        /// the custom tape pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTapePool service method.</param>
        /// 
        /// <returns>The response from the DeleteTapePool service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteTapePool">REST API Reference for DeleteTapePool Operation</seealso>
        DeleteTapePoolResponse DeleteTapePool(DeleteTapePoolRequest request);



        /// <summary>
        /// Delete a custom tape pool. A custom tape pool can only be deleted if there are no
        /// tapes in the pool and if there are no automatic tape creation policies that reference
        /// the custom tape pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTapePool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTapePool service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteTapePool">REST API Reference for DeleteTapePool Operation</seealso>
        Task<DeleteTapePoolResponse> DeleteTapePoolAsync(DeleteTapePoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteVolume


        /// <summary>
        /// Deletes the specified storage volume that you previously created using the <a>CreateCachediSCSIVolume</a>
        /// or <a>CreateStorediSCSIVolume</a> API. This operation is only supported in the cached
        /// volume and stored volume types. For stored volume gateways, the local disk that was
        /// configured as the storage volume is not deleted. You can reuse the local disk to create
        /// another storage volume.
        /// 
        ///  
        /// <para>
        /// Before you delete a volume, make sure there are no iSCSI connections to the volume
        /// you are deleting. You should also make sure there is no snapshot in progress. You
        /// can use the Amazon Elastic Compute Cloud (Amazon EC2) API to query snapshots on the
        /// volume you are deleting and check the snapshot status. For more information, go to
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeSnapshots.html">DescribeSnapshots</a>
        /// in the <i>Amazon Elastic Compute Cloud API Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// In the request, you must provide the Amazon Resource Name (ARN) of the storage volume
        /// you want to delete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume service method.</param>
        /// 
        /// <returns>The response from the DeleteVolume service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteVolume">REST API Reference for DeleteVolume Operation</seealso>
        DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request);



        /// <summary>
        /// Deletes the specified storage volume that you previously created using the <a>CreateCachediSCSIVolume</a>
        /// or <a>CreateStorediSCSIVolume</a> API. This operation is only supported in the cached
        /// volume and stored volume types. For stored volume gateways, the local disk that was
        /// configured as the storage volume is not deleted. You can reuse the local disk to create
        /// another storage volume.
        /// 
        ///  
        /// <para>
        /// Before you delete a volume, make sure there are no iSCSI connections to the volume
        /// you are deleting. You should also make sure there is no snapshot in progress. You
        /// can use the Amazon Elastic Compute Cloud (Amazon EC2) API to query snapshots on the
        /// volume you are deleting and check the snapshot status. For more information, go to
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeSnapshots.html">DescribeSnapshots</a>
        /// in the <i>Amazon Elastic Compute Cloud API Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// In the request, you must provide the Amazon Resource Name (ARN) of the storage volume
        /// you want to delete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVolume service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DeleteVolume">REST API Reference for DeleteVolume Operation</seealso>
        Task<DeleteVolumeResponse> DeleteVolumeAsync(DeleteVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAvailabilityMonitorTest


        /// <summary>
        /// Returns information about the most recent High Availability monitoring test that was
        /// performed on the host in a cluster. If a test isn't performed, the status and start
        /// time in the response would be null.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityMonitorTest service method.</param>
        /// 
        /// <returns>The response from the DescribeAvailabilityMonitorTest service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeAvailabilityMonitorTest">REST API Reference for DescribeAvailabilityMonitorTest Operation</seealso>
        DescribeAvailabilityMonitorTestResponse DescribeAvailabilityMonitorTest(DescribeAvailabilityMonitorTestRequest request);



        /// <summary>
        /// Returns information about the most recent High Availability monitoring test that was
        /// performed on the host in a cluster. If a test isn't performed, the status and start
        /// time in the response would be null.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityMonitorTest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAvailabilityMonitorTest service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeAvailabilityMonitorTest">REST API Reference for DescribeAvailabilityMonitorTest Operation</seealso>
        Task<DescribeAvailabilityMonitorTestResponse> DescribeAvailabilityMonitorTestAsync(DescribeAvailabilityMonitorTestRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeBandwidthRateLimit


        /// <summary>
        /// Returns the bandwidth rate limits of a gateway. By default, these limits are not set,
        /// which means no bandwidth rate limiting is in effect. This operation is supported for
        /// the stored volume, cached volume, and tape gateway types.
        /// 
        ///  
        /// <para>
        /// This operation only returns a value for a bandwidth rate limit only if the limit is
        /// set. If no limits are set for the gateway, then this operation returns only the gateway
        /// ARN in the response body. To specify which gateway to describe, use the Amazon Resource
        /// Name (ARN) of the gateway in your request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBandwidthRateLimit service method.</param>
        /// 
        /// <returns>The response from the DescribeBandwidthRateLimit service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeBandwidthRateLimit">REST API Reference for DescribeBandwidthRateLimit Operation</seealso>
        DescribeBandwidthRateLimitResponse DescribeBandwidthRateLimit(DescribeBandwidthRateLimitRequest request);



        /// <summary>
        /// Returns the bandwidth rate limits of a gateway. By default, these limits are not set,
        /// which means no bandwidth rate limiting is in effect. This operation is supported for
        /// the stored volume, cached volume, and tape gateway types.
        /// 
        ///  
        /// <para>
        /// This operation only returns a value for a bandwidth rate limit only if the limit is
        /// set. If no limits are set for the gateway, then this operation returns only the gateway
        /// ARN in the response body. To specify which gateway to describe, use the Amazon Resource
        /// Name (ARN) of the gateway in your request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBandwidthRateLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBandwidthRateLimit service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeBandwidthRateLimit">REST API Reference for DescribeBandwidthRateLimit Operation</seealso>
        Task<DescribeBandwidthRateLimitResponse> DescribeBandwidthRateLimitAsync(DescribeBandwidthRateLimitRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeBandwidthRateLimitSchedule


        /// <summary>
        /// Returns information about the bandwidth rate limit schedule of a gateway. By default,
        /// gateways do not have bandwidth rate limit schedules, which means no bandwidth rate
        /// limiting is in effect. This operation is supported only in the volume and tape gateway
        /// types. 
        /// 
        ///  
        /// <para>
        /// This operation returns information about a gateway's bandwidth rate limit schedule.
        /// A bandwidth rate limit schedule consists of one or more bandwidth rate limit intervals.
        /// A bandwidth rate limit interval defines a period of time on one or more days of the
        /// week, during which bandwidth rate limits are specified for uploading, downloading,
        /// or both. 
        /// </para>
        ///  
        /// <para>
        ///  A bandwidth rate limit interval consists of one or more days of the week, a start
        /// hour and minute, an ending hour and minute, and bandwidth rate limits for uploading
        /// and downloading 
        /// </para>
        ///  
        /// <para>
        ///  If no bandwidth rate limit schedule intervals are set for the gateway, this operation
        /// returns an empty response. To specify which gateway to describe, use the Amazon Resource
        /// Name (ARN) of the gateway in your request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBandwidthRateLimitSchedule service method.</param>
        /// 
        /// <returns>The response from the DescribeBandwidthRateLimitSchedule service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeBandwidthRateLimitSchedule">REST API Reference for DescribeBandwidthRateLimitSchedule Operation</seealso>
        DescribeBandwidthRateLimitScheduleResponse DescribeBandwidthRateLimitSchedule(DescribeBandwidthRateLimitScheduleRequest request);



        /// <summary>
        /// Returns information about the bandwidth rate limit schedule of a gateway. By default,
        /// gateways do not have bandwidth rate limit schedules, which means no bandwidth rate
        /// limiting is in effect. This operation is supported only in the volume and tape gateway
        /// types. 
        /// 
        ///  
        /// <para>
        /// This operation returns information about a gateway's bandwidth rate limit schedule.
        /// A bandwidth rate limit schedule consists of one or more bandwidth rate limit intervals.
        /// A bandwidth rate limit interval defines a period of time on one or more days of the
        /// week, during which bandwidth rate limits are specified for uploading, downloading,
        /// or both. 
        /// </para>
        ///  
        /// <para>
        ///  A bandwidth rate limit interval consists of one or more days of the week, a start
        /// hour and minute, an ending hour and minute, and bandwidth rate limits for uploading
        /// and downloading 
        /// </para>
        ///  
        /// <para>
        ///  If no bandwidth rate limit schedule intervals are set for the gateway, this operation
        /// returns an empty response. To specify which gateway to describe, use the Amazon Resource
        /// Name (ARN) of the gateway in your request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBandwidthRateLimitSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBandwidthRateLimitSchedule service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeBandwidthRateLimitSchedule">REST API Reference for DescribeBandwidthRateLimitSchedule Operation</seealso>
        Task<DescribeBandwidthRateLimitScheduleResponse> DescribeBandwidthRateLimitScheduleAsync(DescribeBandwidthRateLimitScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCache


        /// <summary>
        /// Returns information about the cache of a gateway. This operation is only supported
        /// in the cached volume, tape, and file gateway types.
        /// 
        ///  
        /// <para>
        /// The response includes disk IDs that are configured as cache, and it includes the amount
        /// of cache allocated and used.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCache service method.</param>
        /// 
        /// <returns>The response from the DescribeCache service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeCache">REST API Reference for DescribeCache Operation</seealso>
        DescribeCacheResponse DescribeCache(DescribeCacheRequest request);



        /// <summary>
        /// Returns information about the cache of a gateway. This operation is only supported
        /// in the cached volume, tape, and file gateway types.
        /// 
        ///  
        /// <para>
        /// The response includes disk IDs that are configured as cache, and it includes the amount
        /// of cache allocated and used.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCache service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeCache">REST API Reference for DescribeCache Operation</seealso>
        Task<DescribeCacheResponse> DescribeCacheAsync(DescribeCacheRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCachediSCSIVolumes


        /// <summary>
        /// Returns a description of the gateway volumes specified in the request. This operation
        /// is only supported in the cached volume gateway types.
        /// 
        ///  
        /// <para>
        /// The list of gateway volumes in the request must be from one gateway. In the response,
        /// AWS Storage Gateway returns volume information sorted by volume Amazon Resource Name
        /// (ARN).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCachediSCSIVolumes service method.</param>
        /// 
        /// <returns>The response from the DescribeCachediSCSIVolumes service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeCachediSCSIVolumes">REST API Reference for DescribeCachediSCSIVolumes Operation</seealso>
        DescribeCachediSCSIVolumesResponse DescribeCachediSCSIVolumes(DescribeCachediSCSIVolumesRequest request);



        /// <summary>
        /// Returns a description of the gateway volumes specified in the request. This operation
        /// is only supported in the cached volume gateway types.
        /// 
        ///  
        /// <para>
        /// The list of gateway volumes in the request must be from one gateway. In the response,
        /// AWS Storage Gateway returns volume information sorted by volume Amazon Resource Name
        /// (ARN).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCachediSCSIVolumes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCachediSCSIVolumes service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeCachediSCSIVolumes">REST API Reference for DescribeCachediSCSIVolumes Operation</seealso>
        Task<DescribeCachediSCSIVolumesResponse> DescribeCachediSCSIVolumesAsync(DescribeCachediSCSIVolumesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeChapCredentials


        /// <summary>
        /// Returns an array of Challenge-Handshake Authentication Protocol (CHAP) credentials
        /// information for a specified iSCSI target, one for each target-initiator pair. This
        /// operation is supported in the volume and tape gateway types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChapCredentials service method.</param>
        /// 
        /// <returns>The response from the DescribeChapCredentials service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeChapCredentials">REST API Reference for DescribeChapCredentials Operation</seealso>
        DescribeChapCredentialsResponse DescribeChapCredentials(DescribeChapCredentialsRequest request);



        /// <summary>
        /// Returns an array of Challenge-Handshake Authentication Protocol (CHAP) credentials
        /// information for a specified iSCSI target, one for each target-initiator pair. This
        /// operation is supported in the volume and tape gateway types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChapCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChapCredentials service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeChapCredentials">REST API Reference for DescribeChapCredentials Operation</seealso>
        Task<DescribeChapCredentialsResponse> DescribeChapCredentialsAsync(DescribeChapCredentialsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeGatewayInformation


        /// <summary>
        /// Returns metadata about a gateway such as its name, network interfaces, configured
        /// time zone, and the state (whether the gateway is running or not). To specify which
        /// gateway to describe, use the Amazon Resource Name (ARN) of the gateway in your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGatewayInformation service method.</param>
        /// 
        /// <returns>The response from the DescribeGatewayInformation service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeGatewayInformation">REST API Reference for DescribeGatewayInformation Operation</seealso>
        DescribeGatewayInformationResponse DescribeGatewayInformation(DescribeGatewayInformationRequest request);



        /// <summary>
        /// Returns metadata about a gateway such as its name, network interfaces, configured
        /// time zone, and the state (whether the gateway is running or not). To specify which
        /// gateway to describe, use the Amazon Resource Name (ARN) of the gateway in your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGatewayInformation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGatewayInformation service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeGatewayInformation">REST API Reference for DescribeGatewayInformation Operation</seealso>
        Task<DescribeGatewayInformationResponse> DescribeGatewayInformationAsync(DescribeGatewayInformationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeMaintenanceStartTime


        /// <summary>
        /// Returns your gateway's weekly maintenance start time including the day and time of
        /// the week. Note that values are in terms of the gateway's time zone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceStartTime service method.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceStartTime service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeMaintenanceStartTime">REST API Reference for DescribeMaintenanceStartTime Operation</seealso>
        DescribeMaintenanceStartTimeResponse DescribeMaintenanceStartTime(DescribeMaintenanceStartTimeRequest request);



        /// <summary>
        /// Returns your gateway's weekly maintenance start time including the day and time of
        /// the week. Note that values are in terms of the gateway's time zone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceStartTime service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMaintenanceStartTime service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeMaintenanceStartTime">REST API Reference for DescribeMaintenanceStartTime Operation</seealso>
        Task<DescribeMaintenanceStartTimeResponse> DescribeMaintenanceStartTimeAsync(DescribeMaintenanceStartTimeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeNFSFileShares


        /// <summary>
        /// Gets a description for one or more Network File System (NFS) file shares from a file
        /// gateway. This operation is only supported for file gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNFSFileShares service method.</param>
        /// 
        /// <returns>The response from the DescribeNFSFileShares service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeNFSFileShares">REST API Reference for DescribeNFSFileShares Operation</seealso>
        DescribeNFSFileSharesResponse DescribeNFSFileShares(DescribeNFSFileSharesRequest request);



        /// <summary>
        /// Gets a description for one or more Network File System (NFS) file shares from a file
        /// gateway. This operation is only supported for file gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNFSFileShares service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNFSFileShares service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeNFSFileShares">REST API Reference for DescribeNFSFileShares Operation</seealso>
        Task<DescribeNFSFileSharesResponse> DescribeNFSFileSharesAsync(DescribeNFSFileSharesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSMBFileShares


        /// <summary>
        /// Gets a description for one or more Server Message Block (SMB) file shares from a file
        /// gateway. This operation is only supported for file gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSMBFileShares service method.</param>
        /// 
        /// <returns>The response from the DescribeSMBFileShares service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeSMBFileShares">REST API Reference for DescribeSMBFileShares Operation</seealso>
        DescribeSMBFileSharesResponse DescribeSMBFileShares(DescribeSMBFileSharesRequest request);



        /// <summary>
        /// Gets a description for one or more Server Message Block (SMB) file shares from a file
        /// gateway. This operation is only supported for file gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSMBFileShares service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSMBFileShares service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeSMBFileShares">REST API Reference for DescribeSMBFileShares Operation</seealso>
        Task<DescribeSMBFileSharesResponse> DescribeSMBFileSharesAsync(DescribeSMBFileSharesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSMBSettings


        /// <summary>
        /// Gets a description of a Server Message Block (SMB) file share settings from a file
        /// gateway. This operation is only supported for file gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSMBSettings service method.</param>
        /// 
        /// <returns>The response from the DescribeSMBSettings service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeSMBSettings">REST API Reference for DescribeSMBSettings Operation</seealso>
        DescribeSMBSettingsResponse DescribeSMBSettings(DescribeSMBSettingsRequest request);



        /// <summary>
        /// Gets a description of a Server Message Block (SMB) file share settings from a file
        /// gateway. This operation is only supported for file gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSMBSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSMBSettings service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeSMBSettings">REST API Reference for DescribeSMBSettings Operation</seealso>
        Task<DescribeSMBSettingsResponse> DescribeSMBSettingsAsync(DescribeSMBSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSnapshotSchedule


        /// <summary>
        /// Describes the snapshot schedule for the specified gateway volume. The snapshot schedule
        /// information includes intervals at which snapshots are automatically initiated on the
        /// volume. This operation is only supported in the cached volume and stored volume types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotSchedule service method.</param>
        /// 
        /// <returns>The response from the DescribeSnapshotSchedule service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeSnapshotSchedule">REST API Reference for DescribeSnapshotSchedule Operation</seealso>
        DescribeSnapshotScheduleResponse DescribeSnapshotSchedule(DescribeSnapshotScheduleRequest request);



        /// <summary>
        /// Describes the snapshot schedule for the specified gateway volume. The snapshot schedule
        /// information includes intervals at which snapshots are automatically initiated on the
        /// volume. This operation is only supported in the cached volume and stored volume types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSnapshotSchedule service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeSnapshotSchedule">REST API Reference for DescribeSnapshotSchedule Operation</seealso>
        Task<DescribeSnapshotScheduleResponse> DescribeSnapshotScheduleAsync(DescribeSnapshotScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeStorediSCSIVolumes


        /// <summary>
        /// Returns the description of the gateway volumes specified in the request. The list
        /// of gateway volumes in the request must be from one gateway. In the response, AWS Storage
        /// Gateway returns volume information sorted by volume ARNs. This operation is only supported
        /// in stored volume gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorediSCSIVolumes service method.</param>
        /// 
        /// <returns>The response from the DescribeStorediSCSIVolumes service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeStorediSCSIVolumes">REST API Reference for DescribeStorediSCSIVolumes Operation</seealso>
        DescribeStorediSCSIVolumesResponse DescribeStorediSCSIVolumes(DescribeStorediSCSIVolumesRequest request);



        /// <summary>
        /// Returns the description of the gateway volumes specified in the request. The list
        /// of gateway volumes in the request must be from one gateway. In the response, AWS Storage
        /// Gateway returns volume information sorted by volume ARNs. This operation is only supported
        /// in stored volume gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorediSCSIVolumes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStorediSCSIVolumes service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeStorediSCSIVolumes">REST API Reference for DescribeStorediSCSIVolumes Operation</seealso>
        Task<DescribeStorediSCSIVolumesResponse> DescribeStorediSCSIVolumesAsync(DescribeStorediSCSIVolumesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeTapeArchives


        /// <summary>
        /// Returns a description of specified virtual tapes in the virtual tape shelf (VTS).
        /// This operation is only supported in the tape gateway type.
        /// 
        ///  
        /// <para>
        /// If a specific <code>TapeARN</code> is not specified, AWS Storage Gateway returns a
        /// description of all virtual tapes found in the VTS associated with your account.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeTapeArchives service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeTapeArchives">REST API Reference for DescribeTapeArchives Operation</seealso>
        DescribeTapeArchivesResponse DescribeTapeArchives();


        /// <summary>
        /// Returns a description of specified virtual tapes in the virtual tape shelf (VTS).
        /// This operation is only supported in the tape gateway type.
        /// 
        ///  
        /// <para>
        /// If a specific <code>TapeARN</code> is not specified, AWS Storage Gateway returns a
        /// description of all virtual tapes found in the VTS associated with your account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapeArchives service method.</param>
        /// 
        /// <returns>The response from the DescribeTapeArchives service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeTapeArchives">REST API Reference for DescribeTapeArchives Operation</seealso>
        DescribeTapeArchivesResponse DescribeTapeArchives(DescribeTapeArchivesRequest request);


        /// <summary>
        /// Returns a description of specified virtual tapes in the virtual tape shelf (VTS).
        /// This operation is only supported in the tape gateway type.
        /// 
        ///  
        /// <para>
        /// If a specific <code>TapeARN</code> is not specified, AWS Storage Gateway returns a
        /// description of all virtual tapes found in the VTS associated with your account.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTapeArchives service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeTapeArchives">REST API Reference for DescribeTapeArchives Operation</seealso>
        Task<DescribeTapeArchivesResponse> DescribeTapeArchivesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Returns a description of specified virtual tapes in the virtual tape shelf (VTS).
        /// This operation is only supported in the tape gateway type.
        /// 
        ///  
        /// <para>
        /// If a specific <code>TapeARN</code> is not specified, AWS Storage Gateway returns a
        /// description of all virtual tapes found in the VTS associated with your account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapeArchives service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTapeArchives service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeTapeArchives">REST API Reference for DescribeTapeArchives Operation</seealso>
        Task<DescribeTapeArchivesResponse> DescribeTapeArchivesAsync(DescribeTapeArchivesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeTapeRecoveryPoints


        /// <summary>
        /// Returns a list of virtual tape recovery points that are available for the specified
        /// tape gateway.
        /// 
        ///  
        /// <para>
        /// A recovery point is a point-in-time view of a virtual tape at which all the data on
        /// the virtual tape is consistent. If your gateway crashes, virtual tapes that have recovery
        /// points can be recovered to a new gateway. This operation is only supported in the
        /// tape gateway type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapeRecoveryPoints service method.</param>
        /// 
        /// <returns>The response from the DescribeTapeRecoveryPoints service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeTapeRecoveryPoints">REST API Reference for DescribeTapeRecoveryPoints Operation</seealso>
        DescribeTapeRecoveryPointsResponse DescribeTapeRecoveryPoints(DescribeTapeRecoveryPointsRequest request);



        /// <summary>
        /// Returns a list of virtual tape recovery points that are available for the specified
        /// tape gateway.
        /// 
        ///  
        /// <para>
        /// A recovery point is a point-in-time view of a virtual tape at which all the data on
        /// the virtual tape is consistent. If your gateway crashes, virtual tapes that have recovery
        /// points can be recovered to a new gateway. This operation is only supported in the
        /// tape gateway type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapeRecoveryPoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTapeRecoveryPoints service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeTapeRecoveryPoints">REST API Reference for DescribeTapeRecoveryPoints Operation</seealso>
        Task<DescribeTapeRecoveryPointsResponse> DescribeTapeRecoveryPointsAsync(DescribeTapeRecoveryPointsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeTapes


        /// <summary>
        /// Returns a description of the specified Amazon Resource Name (ARN) of virtual tapes.
        /// If a <code>TapeARN</code> is not specified, returns a description of all virtual tapes
        /// associated with the specified gateway. This operation is only supported in the tape
        /// gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapes service method.</param>
        /// 
        /// <returns>The response from the DescribeTapes service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeTapes">REST API Reference for DescribeTapes Operation</seealso>
        DescribeTapesResponse DescribeTapes(DescribeTapesRequest request);



        /// <summary>
        /// Returns a description of the specified Amazon Resource Name (ARN) of virtual tapes.
        /// If a <code>TapeARN</code> is not specified, returns a description of all virtual tapes
        /// associated with the specified gateway. This operation is only supported in the tape
        /// gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTapes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTapes service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeTapes">REST API Reference for DescribeTapes Operation</seealso>
        Task<DescribeTapesResponse> DescribeTapesAsync(DescribeTapesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeUploadBuffer


        /// <summary>
        /// Returns information about the upload buffer of a gateway. This operation is supported
        /// for the stored volume, cached volume, and tape gateway types.
        /// 
        ///  
        /// <para>
        /// The response includes disk IDs that are configured as upload buffer space, and it
        /// includes the amount of upload buffer space allocated and used.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUploadBuffer service method.</param>
        /// 
        /// <returns>The response from the DescribeUploadBuffer service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeUploadBuffer">REST API Reference for DescribeUploadBuffer Operation</seealso>
        DescribeUploadBufferResponse DescribeUploadBuffer(DescribeUploadBufferRequest request);



        /// <summary>
        /// Returns information about the upload buffer of a gateway. This operation is supported
        /// for the stored volume, cached volume, and tape gateway types.
        /// 
        ///  
        /// <para>
        /// The response includes disk IDs that are configured as upload buffer space, and it
        /// includes the amount of upload buffer space allocated and used.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUploadBuffer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUploadBuffer service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeUploadBuffer">REST API Reference for DescribeUploadBuffer Operation</seealso>
        Task<DescribeUploadBufferResponse> DescribeUploadBufferAsync(DescribeUploadBufferRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeVTLDevices


        /// <summary>
        /// Returns a description of virtual tape library (VTL) devices for the specified tape
        /// gateway. In the response, AWS Storage Gateway returns VTL device information.
        /// 
        ///  
        /// <para>
        /// This operation is only supported in the tape gateway type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVTLDevices service method.</param>
        /// 
        /// <returns>The response from the DescribeVTLDevices service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeVTLDevices">REST API Reference for DescribeVTLDevices Operation</seealso>
        DescribeVTLDevicesResponse DescribeVTLDevices(DescribeVTLDevicesRequest request);



        /// <summary>
        /// Returns a description of virtual tape library (VTL) devices for the specified tape
        /// gateway. In the response, AWS Storage Gateway returns VTL device information.
        /// 
        ///  
        /// <para>
        /// This operation is only supported in the tape gateway type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVTLDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVTLDevices service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeVTLDevices">REST API Reference for DescribeVTLDevices Operation</seealso>
        Task<DescribeVTLDevicesResponse> DescribeVTLDevicesAsync(DescribeVTLDevicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeWorkingStorage


        /// <summary>
        /// Returns information about the working storage of a gateway. This operation is only
        /// supported in the stored volumes gateway type. This operation is deprecated in cached
        /// volumes API version (20120630). Use DescribeUploadBuffer instead.
        /// 
        ///  <note> 
        /// <para>
        /// Working storage is also referred to as upload buffer. You can also use the DescribeUploadBuffer
        /// operation to add upload buffer to a stored volume gateway.
        /// </para>
        ///  </note> 
        /// <para>
        /// The response includes disk IDs that are configured as working storage, and it includes
        /// the amount of working storage allocated and used.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkingStorage service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkingStorage service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeWorkingStorage">REST API Reference for DescribeWorkingStorage Operation</seealso>
        DescribeWorkingStorageResponse DescribeWorkingStorage(DescribeWorkingStorageRequest request);



        /// <summary>
        /// Returns information about the working storage of a gateway. This operation is only
        /// supported in the stored volumes gateway type. This operation is deprecated in cached
        /// volumes API version (20120630). Use DescribeUploadBuffer instead.
        /// 
        ///  <note> 
        /// <para>
        /// Working storage is also referred to as upload buffer. You can also use the DescribeUploadBuffer
        /// operation to add upload buffer to a stored volume gateway.
        /// </para>
        ///  </note> 
        /// <para>
        /// The response includes disk IDs that are configured as working storage, and it includes
        /// the amount of working storage allocated and used.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkingStorage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkingStorage service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DescribeWorkingStorage">REST API Reference for DescribeWorkingStorage Operation</seealso>
        Task<DescribeWorkingStorageResponse> DescribeWorkingStorageAsync(DescribeWorkingStorageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetachVolume


        /// <summary>
        /// Disconnects a volume from an iSCSI connection and then detaches the volume from the
        /// specified gateway. Detaching and attaching a volume enables you to recover your data
        /// from one gateway to a different gateway without creating a snapshot. It also makes
        /// it easier to move your volumes from an on-premises gateway to a gateway hosted on
        /// an Amazon EC2 instance. This operation is only supported in the volume gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachVolume service method.</param>
        /// 
        /// <returns>The response from the DetachVolume service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DetachVolume">REST API Reference for DetachVolume Operation</seealso>
        DetachVolumeResponse DetachVolume(DetachVolumeRequest request);



        /// <summary>
        /// Disconnects a volume from an iSCSI connection and then detaches the volume from the
        /// specified gateway. Detaching and attaching a volume enables you to recover your data
        /// from one gateway to a different gateway without creating a snapshot. It also makes
        /// it easier to move your volumes from an on-premises gateway to a gateway hosted on
        /// an Amazon EC2 instance. This operation is only supported in the volume gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachVolume service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DetachVolume">REST API Reference for DetachVolume Operation</seealso>
        Task<DetachVolumeResponse> DetachVolumeAsync(DetachVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisableGateway


        /// <summary>
        /// Disables a tape gateway when the gateway is no longer functioning. For example, if
        /// your gateway VM is damaged, you can disable the gateway so you can recover virtual
        /// tapes.
        /// 
        ///  
        /// <para>
        /// Use this operation for a tape gateway that is not reachable or not functioning. This
        /// operation is only supported in the tape gateway type.
        /// </para>
        ///  <important> 
        /// <para>
        /// After a gateway is disabled, it cannot be enabled.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableGateway service method.</param>
        /// 
        /// <returns>The response from the DisableGateway service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DisableGateway">REST API Reference for DisableGateway Operation</seealso>
        DisableGatewayResponse DisableGateway(DisableGatewayRequest request);



        /// <summary>
        /// Disables a tape gateway when the gateway is no longer functioning. For example, if
        /// your gateway VM is damaged, you can disable the gateway so you can recover virtual
        /// tapes.
        /// 
        ///  
        /// <para>
        /// Use this operation for a tape gateway that is not reachable or not functioning. This
        /// operation is only supported in the tape gateway type.
        /// </para>
        ///  <important> 
        /// <para>
        /// After a gateway is disabled, it cannot be enabled.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableGateway service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/DisableGateway">REST API Reference for DisableGateway Operation</seealso>
        Task<DisableGatewayResponse> DisableGatewayAsync(DisableGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  JoinDomain


        /// <summary>
        /// Adds a file gateway to an Active Directory domain. This operation is only supported
        /// for file gateways that support the SMB file protocol.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JoinDomain service method.</param>
        /// 
        /// <returns>The response from the JoinDomain service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/JoinDomain">REST API Reference for JoinDomain Operation</seealso>
        JoinDomainResponse JoinDomain(JoinDomainRequest request);



        /// <summary>
        /// Adds a file gateway to an Active Directory domain. This operation is only supported
        /// for file gateways that support the SMB file protocol.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JoinDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the JoinDomain service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/JoinDomain">REST API Reference for JoinDomain Operation</seealso>
        Task<JoinDomainResponse> JoinDomainAsync(JoinDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAutomaticTapeCreationPolicies


        /// <summary>
        /// Lists the automatic tape creation policies for a gateway. If there are no automatic
        /// tape creation policies for the gateway, it returns an empty list.
        /// 
        ///  
        /// <para>
        /// This operation is only supported for tape gateways.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomaticTapeCreationPolicies service method.</param>
        /// 
        /// <returns>The response from the ListAutomaticTapeCreationPolicies service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListAutomaticTapeCreationPolicies">REST API Reference for ListAutomaticTapeCreationPolicies Operation</seealso>
        ListAutomaticTapeCreationPoliciesResponse ListAutomaticTapeCreationPolicies(ListAutomaticTapeCreationPoliciesRequest request);



        /// <summary>
        /// Lists the automatic tape creation policies for a gateway. If there are no automatic
        /// tape creation policies for the gateway, it returns an empty list.
        /// 
        ///  
        /// <para>
        /// This operation is only supported for tape gateways.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomaticTapeCreationPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAutomaticTapeCreationPolicies service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListAutomaticTapeCreationPolicies">REST API Reference for ListAutomaticTapeCreationPolicies Operation</seealso>
        Task<ListAutomaticTapeCreationPoliciesResponse> ListAutomaticTapeCreationPoliciesAsync(ListAutomaticTapeCreationPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFileShares


        /// <summary>
        /// Gets a list of the file shares for a specific file gateway, or the list of file shares
        /// that belong to the calling user account. This operation is only supported for file
        /// gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFileShares service method.</param>
        /// 
        /// <returns>The response from the ListFileShares service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListFileShares">REST API Reference for ListFileShares Operation</seealso>
        ListFileSharesResponse ListFileShares(ListFileSharesRequest request);



        /// <summary>
        /// Gets a list of the file shares for a specific file gateway, or the list of file shares
        /// that belong to the calling user account. This operation is only supported for file
        /// gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFileShares service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFileShares service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListFileShares">REST API Reference for ListFileShares Operation</seealso>
        Task<ListFileSharesResponse> ListFileSharesAsync(ListFileSharesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGateways


        /// <summary>
        /// Lists gateways owned by an AWS account in an AWS Region specified in the request.
        /// The returned list is ordered by gateway Amazon Resource Name (ARN).
        /// 
        ///  
        /// <para>
        /// By default, the operation returns a maximum of 100 gateways. This operation supports
        /// pagination that allows you to optionally reduce the number of gateways returned in
        /// a response.
        /// </para>
        ///  
        /// <para>
        /// If you have more gateways than are returned in a response (that is, the response returns
        /// only a truncated list of your gateways), the response contains a marker that you can
        /// specify in your next request to fetch the next page of gateways.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListGateways service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListGateways">REST API Reference for ListGateways Operation</seealso>
        ListGatewaysResponse ListGateways();


        /// <summary>
        /// Lists gateways owned by an AWS account in an AWS Region specified in the request.
        /// The returned list is ordered by gateway Amazon Resource Name (ARN).
        /// 
        ///  
        /// <para>
        /// By default, the operation returns a maximum of 100 gateways. This operation supports
        /// pagination that allows you to optionally reduce the number of gateways returned in
        /// a response.
        /// </para>
        ///  
        /// <para>
        /// If you have more gateways than are returned in a response (that is, the response returns
        /// only a truncated list of your gateways), the response contains a marker that you can
        /// specify in your next request to fetch the next page of gateways.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGateways service method.</param>
        /// 
        /// <returns>The response from the ListGateways service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListGateways">REST API Reference for ListGateways Operation</seealso>
        ListGatewaysResponse ListGateways(ListGatewaysRequest request);


        /// <summary>
        /// Lists gateways owned by an AWS account in an AWS Region specified in the request.
        /// The returned list is ordered by gateway Amazon Resource Name (ARN).
        /// 
        ///  
        /// <para>
        /// By default, the operation returns a maximum of 100 gateways. This operation supports
        /// pagination that allows you to optionally reduce the number of gateways returned in
        /// a response.
        /// </para>
        ///  
        /// <para>
        /// If you have more gateways than are returned in a response (that is, the response returns
        /// only a truncated list of your gateways), the response contains a marker that you can
        /// specify in your next request to fetch the next page of gateways.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGateways service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListGateways">REST API Reference for ListGateways Operation</seealso>
        Task<ListGatewaysResponse> ListGatewaysAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Lists gateways owned by an AWS account in an AWS Region specified in the request.
        /// The returned list is ordered by gateway Amazon Resource Name (ARN).
        /// 
        ///  
        /// <para>
        /// By default, the operation returns a maximum of 100 gateways. This operation supports
        /// pagination that allows you to optionally reduce the number of gateways returned in
        /// a response.
        /// </para>
        ///  
        /// <para>
        /// If you have more gateways than are returned in a response (that is, the response returns
        /// only a truncated list of your gateways), the response contains a marker that you can
        /// specify in your next request to fetch the next page of gateways.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGateways service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListGateways">REST API Reference for ListGateways Operation</seealso>
        Task<ListGatewaysResponse> ListGatewaysAsync(ListGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLocalDisks


        /// <summary>
        /// Returns a list of the gateway's local disks. To specify which gateway to describe,
        /// you use the Amazon Resource Name (ARN) of the gateway in the body of the request.
        /// 
        ///  
        /// <para>
        /// The request returns a list of all disks, specifying which are configured as working
        /// storage, cache storage, or stored volume or not configured at all. The response includes
        /// a <code>DiskStatus</code> field. This field can have a value of present (the disk
        /// is available to use), missing (the disk is no longer connected to the gateway), or
        /// mismatch (the disk node is occupied by a disk that has incorrect metadata or the disk
        /// content is corrupted).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLocalDisks service method.</param>
        /// 
        /// <returns>The response from the ListLocalDisks service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListLocalDisks">REST API Reference for ListLocalDisks Operation</seealso>
        ListLocalDisksResponse ListLocalDisks(ListLocalDisksRequest request);



        /// <summary>
        /// Returns a list of the gateway's local disks. To specify which gateway to describe,
        /// you use the Amazon Resource Name (ARN) of the gateway in the body of the request.
        /// 
        ///  
        /// <para>
        /// The request returns a list of all disks, specifying which are configured as working
        /// storage, cache storage, or stored volume or not configured at all. The response includes
        /// a <code>DiskStatus</code> field. This field can have a value of present (the disk
        /// is available to use), missing (the disk is no longer connected to the gateway), or
        /// mismatch (the disk node is occupied by a disk that has incorrect metadata or the disk
        /// content is corrupted).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLocalDisks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLocalDisks service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListLocalDisks">REST API Reference for ListLocalDisks Operation</seealso>
        Task<ListLocalDisksResponse> ListLocalDisksAsync(ListLocalDisksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags that have been added to the specified resource. This operation is supported
        /// in storage gateways of all types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists the tags that have been added to the specified resource. This operation is supported
        /// in storage gateways of all types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTapePools


        /// <summary>
        /// Lists custom tape pools. You specify custom tape pools to list by specifying one or
        /// more custom tape pool Amazon Resource Names (ARNs). If you don't specify a custom
        /// tape pool ARN, the operation lists all custom tape pools.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination. You can optionally specify the <code>Limit</code>
        /// parameter in the body to limit the number of tape pools in the response. If the number
        /// of tape pools returned in the response is truncated, the response includes a <code>Marker</code>
        /// element that you can use in your subsequent request to retrieve the next set of tape
        /// pools.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTapePools service method.</param>
        /// 
        /// <returns>The response from the ListTapePools service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListTapePools">REST API Reference for ListTapePools Operation</seealso>
        ListTapePoolsResponse ListTapePools(ListTapePoolsRequest request);



        /// <summary>
        /// Lists custom tape pools. You specify custom tape pools to list by specifying one or
        /// more custom tape pool Amazon Resource Names (ARNs). If you don't specify a custom
        /// tape pool ARN, the operation lists all custom tape pools.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination. You can optionally specify the <code>Limit</code>
        /// parameter in the body to limit the number of tape pools in the response. If the number
        /// of tape pools returned in the response is truncated, the response includes a <code>Marker</code>
        /// element that you can use in your subsequent request to retrieve the next set of tape
        /// pools.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTapePools service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTapePools service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListTapePools">REST API Reference for ListTapePools Operation</seealso>
        Task<ListTapePoolsResponse> ListTapePoolsAsync(ListTapePoolsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTapes


        /// <summary>
        /// Lists virtual tapes in your virtual tape library (VTL) and your virtual tape shelf
        /// (VTS). You specify the tapes to list by specifying one or more tape Amazon Resource
        /// Names (ARNs). If you don't specify a tape ARN, the operation lists all virtual tapes
        /// in both your VTL and VTS.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination. By default, the operation returns a maximum of
        /// up to 100 tapes. You can optionally specify the <code>Limit</code> parameter in the
        /// body to limit the number of tapes in the response. If the number of tapes returned
        /// in the response is truncated, the response includes a <code>Marker</code> element
        /// that you can use in your subsequent request to retrieve the next set of tapes. This
        /// operation is only supported in the tape gateway type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTapes service method.</param>
        /// 
        /// <returns>The response from the ListTapes service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListTapes">REST API Reference for ListTapes Operation</seealso>
        ListTapesResponse ListTapes(ListTapesRequest request);



        /// <summary>
        /// Lists virtual tapes in your virtual tape library (VTL) and your virtual tape shelf
        /// (VTS). You specify the tapes to list by specifying one or more tape Amazon Resource
        /// Names (ARNs). If you don't specify a tape ARN, the operation lists all virtual tapes
        /// in both your VTL and VTS.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination. By default, the operation returns a maximum of
        /// up to 100 tapes. You can optionally specify the <code>Limit</code> parameter in the
        /// body to limit the number of tapes in the response. If the number of tapes returned
        /// in the response is truncated, the response includes a <code>Marker</code> element
        /// that you can use in your subsequent request to retrieve the next set of tapes. This
        /// operation is only supported in the tape gateway type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTapes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTapes service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListTapes">REST API Reference for ListTapes Operation</seealso>
        Task<ListTapesResponse> ListTapesAsync(ListTapesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListVolumeInitiators


        /// <summary>
        /// Lists iSCSI initiators that are connected to a volume. You can use this operation
        /// to determine whether a volume is being used or not. This operation is only supported
        /// in the cached volume and stored volume gateway types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVolumeInitiators service method.</param>
        /// 
        /// <returns>The response from the ListVolumeInitiators service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListVolumeInitiators">REST API Reference for ListVolumeInitiators Operation</seealso>
        ListVolumeInitiatorsResponse ListVolumeInitiators(ListVolumeInitiatorsRequest request);



        /// <summary>
        /// Lists iSCSI initiators that are connected to a volume. You can use this operation
        /// to determine whether a volume is being used or not. This operation is only supported
        /// in the cached volume and stored volume gateway types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVolumeInitiators service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVolumeInitiators service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListVolumeInitiators">REST API Reference for ListVolumeInitiators Operation</seealso>
        Task<ListVolumeInitiatorsResponse> ListVolumeInitiatorsAsync(ListVolumeInitiatorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListVolumeRecoveryPoints


        /// <summary>
        /// Lists the recovery points for a specified gateway. This operation is only supported
        /// in the cached volume gateway type.
        /// 
        ///  
        /// <para>
        /// Each cache volume has one recovery point. A volume recovery point is a point in time
        /// at which all data of the volume is consistent and from which you can create a snapshot
        /// or clone a new cached volume from a source volume. To create a snapshot from a volume
        /// recovery point use the <a>CreateSnapshotFromVolumeRecoveryPoint</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVolumeRecoveryPoints service method.</param>
        /// 
        /// <returns>The response from the ListVolumeRecoveryPoints service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListVolumeRecoveryPoints">REST API Reference for ListVolumeRecoveryPoints Operation</seealso>
        ListVolumeRecoveryPointsResponse ListVolumeRecoveryPoints(ListVolumeRecoveryPointsRequest request);



        /// <summary>
        /// Lists the recovery points for a specified gateway. This operation is only supported
        /// in the cached volume gateway type.
        /// 
        ///  
        /// <para>
        /// Each cache volume has one recovery point. A volume recovery point is a point in time
        /// at which all data of the volume is consistent and from which you can create a snapshot
        /// or clone a new cached volume from a source volume. To create a snapshot from a volume
        /// recovery point use the <a>CreateSnapshotFromVolumeRecoveryPoint</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVolumeRecoveryPoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVolumeRecoveryPoints service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListVolumeRecoveryPoints">REST API Reference for ListVolumeRecoveryPoints Operation</seealso>
        Task<ListVolumeRecoveryPointsResponse> ListVolumeRecoveryPointsAsync(ListVolumeRecoveryPointsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListVolumes


        /// <summary>
        /// Lists the iSCSI stored volumes of a gateway. Results are sorted by volume ARN. The
        /// response includes only the volume ARNs. If you want additional volume information,
        /// use the <a>DescribeStorediSCSIVolumes</a> or the <a>DescribeCachediSCSIVolumes</a>
        /// API.
        /// 
        ///  
        /// <para>
        /// The operation supports pagination. By default, the operation returns a maximum of
        /// up to 100 volumes. You can optionally specify the <code>Limit</code> field in the
        /// body to limit the number of volumes in the response. If the number of volumes returned
        /// in the response is truncated, the response includes a Marker field. You can use this
        /// Marker value in your subsequent request to retrieve the next set of volumes. This
        /// operation is only supported in the cached volume and stored volume gateway types.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVolumes service method.</param>
        /// 
        /// <returns>The response from the ListVolumes service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListVolumes">REST API Reference for ListVolumes Operation</seealso>
        ListVolumesResponse ListVolumes(ListVolumesRequest request);



        /// <summary>
        /// Lists the iSCSI stored volumes of a gateway. Results are sorted by volume ARN. The
        /// response includes only the volume ARNs. If you want additional volume information,
        /// use the <a>DescribeStorediSCSIVolumes</a> or the <a>DescribeCachediSCSIVolumes</a>
        /// API.
        /// 
        ///  
        /// <para>
        /// The operation supports pagination. By default, the operation returns a maximum of
        /// up to 100 volumes. You can optionally specify the <code>Limit</code> field in the
        /// body to limit the number of volumes in the response. If the number of volumes returned
        /// in the response is truncated, the response includes a Marker field. You can use this
        /// Marker value in your subsequent request to retrieve the next set of volumes. This
        /// operation is only supported in the cached volume and stored volume gateway types.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVolumes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVolumes service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ListVolumes">REST API Reference for ListVolumes Operation</seealso>
        Task<ListVolumesResponse> ListVolumesAsync(ListVolumesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  NotifyWhenUploaded


        /// <summary>
        /// Sends you notification through CloudWatch Events when all files written to your file
        /// share have been uploaded to Amazon S3.
        /// 
        ///  
        /// <para>
        /// AWS Storage Gateway can send a notification through Amazon CloudWatch Events when
        /// all files written to your file share up to that point in time have been uploaded to
        /// Amazon S3. These files include files written to the file share up to the time that
        /// you make a request for notification. When the upload is done, Storage Gateway sends
        /// you notification through an Amazon CloudWatch Event. You can configure CloudWatch
        /// Events to send the notification through event targets such as Amazon SNS or AWS Lambda
        /// function. This operation is only supported for file gateways.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/monitoring-file-gateway.html#get-upload-notification">Getting
        /// file upload notification</a> in the <i>AWS Storage Gateway User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NotifyWhenUploaded service method.</param>
        /// 
        /// <returns>The response from the NotifyWhenUploaded service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/NotifyWhenUploaded">REST API Reference for NotifyWhenUploaded Operation</seealso>
        NotifyWhenUploadedResponse NotifyWhenUploaded(NotifyWhenUploadedRequest request);



        /// <summary>
        /// Sends you notification through CloudWatch Events when all files written to your file
        /// share have been uploaded to Amazon S3.
        /// 
        ///  
        /// <para>
        /// AWS Storage Gateway can send a notification through Amazon CloudWatch Events when
        /// all files written to your file share up to that point in time have been uploaded to
        /// Amazon S3. These files include files written to the file share up to the time that
        /// you make a request for notification. When the upload is done, Storage Gateway sends
        /// you notification through an Amazon CloudWatch Event. You can configure CloudWatch
        /// Events to send the notification through event targets such as Amazon SNS or AWS Lambda
        /// function. This operation is only supported for file gateways.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/monitoring-file-gateway.html#get-upload-notification">Getting
        /// file upload notification</a> in the <i>AWS Storage Gateway User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NotifyWhenUploaded service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NotifyWhenUploaded service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/NotifyWhenUploaded">REST API Reference for NotifyWhenUploaded Operation</seealso>
        Task<NotifyWhenUploadedResponse> NotifyWhenUploadedAsync(NotifyWhenUploadedRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RefreshCache


        /// <summary>
        /// Refreshes the cache for the specified file share. This operation finds objects in
        /// the Amazon S3 bucket that were added, removed, or replaced since the gateway last
        /// listed the bucket's contents and cached the results. This operation is only supported
        /// in the file gateway type. You can subscribe to be notified through an Amazon CloudWatch
        /// event when your RefreshCache operation completes. For more information, see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/monitoring-file-gateway.html#get-notification">Getting
        /// notified about file operations</a> in the <i>AWS Storage Gateway User Guide</i>.
        /// 
        ///  
        /// <para>
        /// When this API is called, it only initiates the refresh operation. When the API call
        /// completes and returns a success code, it doesn't necessarily mean that the file refresh
        /// has completed. You should use the refresh-complete notification to determine that
        /// the operation has completed before you check for new files on the gateway file share.
        /// You can subscribe to be notified through an CloudWatch event when your <code>RefreshCache</code>
        /// operation completes.
        /// </para>
        ///  
        /// <para>
        /// Throttle limit: This API is asynchronous so the gateway will accept no more than two
        /// refreshes at any time. We recommend using the refresh-complete CloudWatch event notification
        /// before issuing additional requests. For more information, see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/monitoring-file-gateway.html#get-notification">Getting
        /// notified about file operations</a> in the <i>AWS Storage Gateway User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you invoke the RefreshCache API when two requests are already being processed,
        /// any new request will cause an <code>InvalidGatewayRequestException</code> error because
        /// too many requests were sent to the server.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/monitoring-file-gateway.html#get-notification">Getting
        /// notified about file operations</a> in the <i>AWS Storage Gateway User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RefreshCache service method.</param>
        /// 
        /// <returns>The response from the RefreshCache service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/RefreshCache">REST API Reference for RefreshCache Operation</seealso>
        RefreshCacheResponse RefreshCache(RefreshCacheRequest request);



        /// <summary>
        /// Refreshes the cache for the specified file share. This operation finds objects in
        /// the Amazon S3 bucket that were added, removed, or replaced since the gateway last
        /// listed the bucket's contents and cached the results. This operation is only supported
        /// in the file gateway type. You can subscribe to be notified through an Amazon CloudWatch
        /// event when your RefreshCache operation completes. For more information, see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/monitoring-file-gateway.html#get-notification">Getting
        /// notified about file operations</a> in the <i>AWS Storage Gateway User Guide</i>.
        /// 
        ///  
        /// <para>
        /// When this API is called, it only initiates the refresh operation. When the API call
        /// completes and returns a success code, it doesn't necessarily mean that the file refresh
        /// has completed. You should use the refresh-complete notification to determine that
        /// the operation has completed before you check for new files on the gateway file share.
        /// You can subscribe to be notified through an CloudWatch event when your <code>RefreshCache</code>
        /// operation completes.
        /// </para>
        ///  
        /// <para>
        /// Throttle limit: This API is asynchronous so the gateway will accept no more than two
        /// refreshes at any time. We recommend using the refresh-complete CloudWatch event notification
        /// before issuing additional requests. For more information, see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/monitoring-file-gateway.html#get-notification">Getting
        /// notified about file operations</a> in the <i>AWS Storage Gateway User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you invoke the RefreshCache API when two requests are already being processed,
        /// any new request will cause an <code>InvalidGatewayRequestException</code> error because
        /// too many requests were sent to the server.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/monitoring-file-gateway.html#get-notification">Getting
        /// notified about file operations</a> in the <i>AWS Storage Gateway User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RefreshCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RefreshCache service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/RefreshCache">REST API Reference for RefreshCache Operation</seealso>
        Task<RefreshCacheResponse> RefreshCacheAsync(RefreshCacheRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveTagsFromResource


        /// <summary>
        /// Removes one or more tags from the specified resource. This operation is supported
        /// in storage gateways of all types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request);



        /// <summary>
        /// Removes one or more tags from the specified resource. This operation is supported
        /// in storage gateways of all types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ResetCache


        /// <summary>
        /// Resets all cache disks that have encountered an error and makes the disks available
        /// for reconfiguration as cache storage. If your cache disk encounters an error, the
        /// gateway prevents read and write operations on virtual tapes in the gateway. For example,
        /// an error can occur when a disk is corrupted or removed from the gateway. When a cache
        /// is reset, the gateway loses its cache storage. At this point, you can reconfigure
        /// the disks as cache disks. This operation is only supported in the cached volume and
        /// tape types.
        /// 
        ///  <important> 
        /// <para>
        /// If the cache disk you are resetting contains data that has not been uploaded to Amazon
        /// S3 yet, that data can be lost. After you reset cache disks, there will be no configured
        /// cache disks left in the gateway, so you must configure at least one new cache disk
        /// for your gateway to function properly.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="gatewayARN">A property of ResetCacheRequest used to execute the ResetCache service method.</param>
        /// 
        /// <returns>The response from the ResetCache service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ResetCache">REST API Reference for ResetCache Operation</seealso>
        ResetCacheResponse ResetCache(string gatewayARN);

        /// <summary>
        /// Resets all cache disks that have encountered an error and makes the disks available
        /// for reconfiguration as cache storage. If your cache disk encounters an error, the
        /// gateway prevents read and write operations on virtual tapes in the gateway. For example,
        /// an error can occur when a disk is corrupted or removed from the gateway. When a cache
        /// is reset, the gateway loses its cache storage. At this point, you can reconfigure
        /// the disks as cache disks. This operation is only supported in the cached volume and
        /// tape types.
        /// 
        ///  <important> 
        /// <para>
        /// If the cache disk you are resetting contains data that has not been uploaded to Amazon
        /// S3 yet, that data can be lost. After you reset cache disks, there will be no configured
        /// cache disks left in the gateway, so you must configure at least one new cache disk
        /// for your gateway to function properly.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetCache service method.</param>
        /// 
        /// <returns>The response from the ResetCache service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ResetCache">REST API Reference for ResetCache Operation</seealso>
        ResetCacheResponse ResetCache(ResetCacheRequest request);


        /// <summary>
        /// Resets all cache disks that have encountered an error and makes the disks available
        /// for reconfiguration as cache storage. If your cache disk encounters an error, the
        /// gateway prevents read and write operations on virtual tapes in the gateway. For example,
        /// an error can occur when a disk is corrupted or removed from the gateway. When a cache
        /// is reset, the gateway loses its cache storage. At this point, you can reconfigure
        /// the disks as cache disks. This operation is only supported in the cached volume and
        /// tape types.
        /// 
        ///  <important> 
        /// <para>
        /// If the cache disk you are resetting contains data that has not been uploaded to Amazon
        /// S3 yet, that data can be lost. After you reset cache disks, there will be no configured
        /// cache disks left in the gateway, so you must configure at least one new cache disk
        /// for your gateway to function properly.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="gatewayARN">A property of ResetCacheRequest used to execute the ResetCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetCache service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ResetCache">REST API Reference for ResetCache Operation</seealso>
        Task<ResetCacheResponse> ResetCacheAsync(string gatewayARN, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Resets all cache disks that have encountered an error and makes the disks available
        /// for reconfiguration as cache storage. If your cache disk encounters an error, the
        /// gateway prevents read and write operations on virtual tapes in the gateway. For example,
        /// an error can occur when a disk is corrupted or removed from the gateway. When a cache
        /// is reset, the gateway loses its cache storage. At this point, you can reconfigure
        /// the disks as cache disks. This operation is only supported in the cached volume and
        /// tape types.
        /// 
        ///  <important> 
        /// <para>
        /// If the cache disk you are resetting contains data that has not been uploaded to Amazon
        /// S3 yet, that data can be lost. After you reset cache disks, there will be no configured
        /// cache disks left in the gateway, so you must configure at least one new cache disk
        /// for your gateway to function properly.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetCache service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ResetCache">REST API Reference for ResetCache Operation</seealso>
        Task<ResetCacheResponse> ResetCacheAsync(ResetCacheRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RetrieveTapeArchive


        /// <summary>
        /// Retrieves an archived virtual tape from the virtual tape shelf (VTS) to a tape gateway.
        /// Virtual tapes archived in the VTS are not associated with any gateway. However after
        /// a tape is retrieved, it is associated with a gateway, even though it is also listed
        /// in the VTS, that is, archive. This operation is only supported in the tape gateway
        /// type.
        /// 
        ///  
        /// <para>
        /// Once a tape is successfully retrieved to a gateway, it cannot be retrieved again to
        /// another gateway. You must archive the tape again before you can retrieve it to another
        /// gateway. This operation is only supported in the tape gateway type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveTapeArchive service method.</param>
        /// 
        /// <returns>The response from the RetrieveTapeArchive service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/RetrieveTapeArchive">REST API Reference for RetrieveTapeArchive Operation</seealso>
        RetrieveTapeArchiveResponse RetrieveTapeArchive(RetrieveTapeArchiveRequest request);



        /// <summary>
        /// Retrieves an archived virtual tape from the virtual tape shelf (VTS) to a tape gateway.
        /// Virtual tapes archived in the VTS are not associated with any gateway. However after
        /// a tape is retrieved, it is associated with a gateway, even though it is also listed
        /// in the VTS, that is, archive. This operation is only supported in the tape gateway
        /// type.
        /// 
        ///  
        /// <para>
        /// Once a tape is successfully retrieved to a gateway, it cannot be retrieved again to
        /// another gateway. You must archive the tape again before you can retrieve it to another
        /// gateway. This operation is only supported in the tape gateway type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveTapeArchive service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetrieveTapeArchive service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/RetrieveTapeArchive">REST API Reference for RetrieveTapeArchive Operation</seealso>
        Task<RetrieveTapeArchiveResponse> RetrieveTapeArchiveAsync(RetrieveTapeArchiveRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RetrieveTapeRecoveryPoint


        /// <summary>
        /// Retrieves the recovery point for the specified virtual tape. This operation is only
        /// supported in the tape gateway type.
        /// 
        ///  
        /// <para>
        /// A recovery point is a point in time view of a virtual tape at which all the data on
        /// the tape is consistent. If your gateway crashes, virtual tapes that have recovery
        /// points can be recovered to a new gateway.
        /// </para>
        ///  <note> 
        /// <para>
        /// The virtual tape can be retrieved to only one gateway. The retrieved tape is read-only.
        /// The virtual tape can be retrieved to only a tape gateway. There is no charge for retrieving
        /// recovery points.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveTapeRecoveryPoint service method.</param>
        /// 
        /// <returns>The response from the RetrieveTapeRecoveryPoint service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/RetrieveTapeRecoveryPoint">REST API Reference for RetrieveTapeRecoveryPoint Operation</seealso>
        RetrieveTapeRecoveryPointResponse RetrieveTapeRecoveryPoint(RetrieveTapeRecoveryPointRequest request);



        /// <summary>
        /// Retrieves the recovery point for the specified virtual tape. This operation is only
        /// supported in the tape gateway type.
        /// 
        ///  
        /// <para>
        /// A recovery point is a point in time view of a virtual tape at which all the data on
        /// the tape is consistent. If your gateway crashes, virtual tapes that have recovery
        /// points can be recovered to a new gateway.
        /// </para>
        ///  <note> 
        /// <para>
        /// The virtual tape can be retrieved to only one gateway. The retrieved tape is read-only.
        /// The virtual tape can be retrieved to only a tape gateway. There is no charge for retrieving
        /// recovery points.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveTapeRecoveryPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetrieveTapeRecoveryPoint service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/RetrieveTapeRecoveryPoint">REST API Reference for RetrieveTapeRecoveryPoint Operation</seealso>
        Task<RetrieveTapeRecoveryPointResponse> RetrieveTapeRecoveryPointAsync(RetrieveTapeRecoveryPointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetLocalConsolePassword


        /// <summary>
        /// Sets the password for your VM local console. When you log in to the local console
        /// for the first time, you log in to the VM with the default credentials. We recommend
        /// that you set a new password. You don't need to know the default password to set a
        /// new password.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetLocalConsolePassword service method.</param>
        /// 
        /// <returns>The response from the SetLocalConsolePassword service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/SetLocalConsolePassword">REST API Reference for SetLocalConsolePassword Operation</seealso>
        SetLocalConsolePasswordResponse SetLocalConsolePassword(SetLocalConsolePasswordRequest request);



        /// <summary>
        /// Sets the password for your VM local console. When you log in to the local console
        /// for the first time, you log in to the VM with the default credentials. We recommend
        /// that you set a new password. You don't need to know the default password to set a
        /// new password.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetLocalConsolePassword service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetLocalConsolePassword service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/SetLocalConsolePassword">REST API Reference for SetLocalConsolePassword Operation</seealso>
        Task<SetLocalConsolePasswordResponse> SetLocalConsolePasswordAsync(SetLocalConsolePasswordRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetSMBGuestPassword


        /// <summary>
        /// Sets the password for the guest user <code>smbguest</code>. The <code>smbguest</code>
        /// user is the user when the authentication method for the file share is set to <code>GuestAccess</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetSMBGuestPassword service method.</param>
        /// 
        /// <returns>The response from the SetSMBGuestPassword service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/SetSMBGuestPassword">REST API Reference for SetSMBGuestPassword Operation</seealso>
        SetSMBGuestPasswordResponse SetSMBGuestPassword(SetSMBGuestPasswordRequest request);



        /// <summary>
        /// Sets the password for the guest user <code>smbguest</code>. The <code>smbguest</code>
        /// user is the user when the authentication method for the file share is set to <code>GuestAccess</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetSMBGuestPassword service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetSMBGuestPassword service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/SetSMBGuestPassword">REST API Reference for SetSMBGuestPassword Operation</seealso>
        Task<SetSMBGuestPasswordResponse> SetSMBGuestPasswordAsync(SetSMBGuestPasswordRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ShutdownGateway


        /// <summary>
        /// Shuts down a gateway. To specify which gateway to shut down, use the Amazon Resource
        /// Name (ARN) of the gateway in the body of your request.
        /// 
        ///  
        /// <para>
        /// The operation shuts down the gateway service component running in the gateway's virtual
        /// machine (VM) and not the host VM.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you want to shut down the VM, it is recommended that you first shut down the gateway
        /// component in the VM to avoid unpredictable conditions.
        /// </para>
        ///  </note> 
        /// <para>
        /// After the gateway is shutdown, you cannot call any other API except <a>StartGateway</a>,
        /// <a>DescribeGatewayInformation</a>, and <a>ListGateways</a>. For more information,
        /// see <a>ActivateGateway</a>. Your applications cannot read from or write to the gateway's
        /// storage volumes, and there are no snapshots taken.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you make a shutdown request, you will get a <code>200 OK</code> success response
        /// immediately. However, it might take some time for the gateway to shut down. You can
        /// call the <a>DescribeGatewayInformation</a> API to check the status. For more information,
        /// see <a>ActivateGateway</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// If do not intend to use the gateway again, you must delete the gateway (using <a>DeleteGateway</a>)
        /// to no longer pay software charges associated with the gateway.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ShutdownGateway service method.</param>
        /// 
        /// <returns>The response from the ShutdownGateway service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ShutdownGateway">REST API Reference for ShutdownGateway Operation</seealso>
        ShutdownGatewayResponse ShutdownGateway(ShutdownGatewayRequest request);



        /// <summary>
        /// Shuts down a gateway. To specify which gateway to shut down, use the Amazon Resource
        /// Name (ARN) of the gateway in the body of your request.
        /// 
        ///  
        /// <para>
        /// The operation shuts down the gateway service component running in the gateway's virtual
        /// machine (VM) and not the host VM.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you want to shut down the VM, it is recommended that you first shut down the gateway
        /// component in the VM to avoid unpredictable conditions.
        /// </para>
        ///  </note> 
        /// <para>
        /// After the gateway is shutdown, you cannot call any other API except <a>StartGateway</a>,
        /// <a>DescribeGatewayInformation</a>, and <a>ListGateways</a>. For more information,
        /// see <a>ActivateGateway</a>. Your applications cannot read from or write to the gateway's
        /// storage volumes, and there are no snapshots taken.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you make a shutdown request, you will get a <code>200 OK</code> success response
        /// immediately. However, it might take some time for the gateway to shut down. You can
        /// call the <a>DescribeGatewayInformation</a> API to check the status. For more information,
        /// see <a>ActivateGateway</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// If do not intend to use the gateway again, you must delete the gateway (using <a>DeleteGateway</a>)
        /// to no longer pay software charges associated with the gateway.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ShutdownGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ShutdownGateway service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/ShutdownGateway">REST API Reference for ShutdownGateway Operation</seealso>
        Task<ShutdownGatewayResponse> ShutdownGatewayAsync(ShutdownGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartAvailabilityMonitorTest


        /// <summary>
        /// Start a test that verifies that the specified gateway is configured for High Availability
        /// monitoring in your host environment. This request only initiates the test and that
        /// a successful response only indicates that the test was started. It doesn't indicate
        /// that the test passed. For the status of the test, invoke the <code>DescribeAvailabilityMonitorTest</code>
        /// API.
        /// 
        ///  <note> 
        /// <para>
        /// Starting this test will cause your gateway to go offline for a brief period.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAvailabilityMonitorTest service method.</param>
        /// 
        /// <returns>The response from the StartAvailabilityMonitorTest service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/StartAvailabilityMonitorTest">REST API Reference for StartAvailabilityMonitorTest Operation</seealso>
        StartAvailabilityMonitorTestResponse StartAvailabilityMonitorTest(StartAvailabilityMonitorTestRequest request);



        /// <summary>
        /// Start a test that verifies that the specified gateway is configured for High Availability
        /// monitoring in your host environment. This request only initiates the test and that
        /// a successful response only indicates that the test was started. It doesn't indicate
        /// that the test passed. For the status of the test, invoke the <code>DescribeAvailabilityMonitorTest</code>
        /// API.
        /// 
        ///  <note> 
        /// <para>
        /// Starting this test will cause your gateway to go offline for a brief period.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAvailabilityMonitorTest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAvailabilityMonitorTest service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/StartAvailabilityMonitorTest">REST API Reference for StartAvailabilityMonitorTest Operation</seealso>
        Task<StartAvailabilityMonitorTestResponse> StartAvailabilityMonitorTestAsync(StartAvailabilityMonitorTestRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartGateway


        /// <summary>
        /// Starts a gateway that you previously shut down (see <a>ShutdownGateway</a>). After
        /// the gateway starts, you can then make other API calls, your applications can read
        /// from or write to the gateway's storage volumes and you will be able to take snapshot
        /// backups.
        /// 
        ///  <note> 
        /// <para>
        /// When you make a request, you will get a 200 OK success response immediately. However,
        /// it might take some time for the gateway to be ready. You should call <a>DescribeGatewayInformation</a>
        /// and check the status before making any additional API calls. For more information,
        /// see <a>ActivateGateway</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// To specify which gateway to start, use the Amazon Resource Name (ARN) of the gateway
        /// in your request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartGateway service method.</param>
        /// 
        /// <returns>The response from the StartGateway service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/StartGateway">REST API Reference for StartGateway Operation</seealso>
        StartGatewayResponse StartGateway(StartGatewayRequest request);



        /// <summary>
        /// Starts a gateway that you previously shut down (see <a>ShutdownGateway</a>). After
        /// the gateway starts, you can then make other API calls, your applications can read
        /// from or write to the gateway's storage volumes and you will be able to take snapshot
        /// backups.
        /// 
        ///  <note> 
        /// <para>
        /// When you make a request, you will get a 200 OK success response immediately. However,
        /// it might take some time for the gateway to be ready. You should call <a>DescribeGatewayInformation</a>
        /// and check the status before making any additional API calls. For more information,
        /// see <a>ActivateGateway</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// To specify which gateway to start, use the Amazon Resource Name (ARN) of the gateway
        /// in your request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartGateway service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/StartGateway">REST API Reference for StartGateway Operation</seealso>
        Task<StartGatewayResponse> StartGatewayAsync(StartGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAutomaticTapeCreationPolicy


        /// <summary>
        /// Updates the automatic tape creation policy of a gateway. Use this to update the policy
        /// with a new set of automatic tape creation rules. This is only supported for tape gateways.
        /// 
        ///  
        /// <para>
        /// By default, there is no automatic tape creation policy.
        /// </para>
        ///  <note> 
        /// <para>
        /// A gateway can have only one automatic tape creation policy.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomaticTapeCreationPolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateAutomaticTapeCreationPolicy service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateAutomaticTapeCreationPolicy">REST API Reference for UpdateAutomaticTapeCreationPolicy Operation</seealso>
        UpdateAutomaticTapeCreationPolicyResponse UpdateAutomaticTapeCreationPolicy(UpdateAutomaticTapeCreationPolicyRequest request);



        /// <summary>
        /// Updates the automatic tape creation policy of a gateway. Use this to update the policy
        /// with a new set of automatic tape creation rules. This is only supported for tape gateways.
        /// 
        ///  
        /// <para>
        /// By default, there is no automatic tape creation policy.
        /// </para>
        ///  <note> 
        /// <para>
        /// A gateway can have only one automatic tape creation policy.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomaticTapeCreationPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAutomaticTapeCreationPolicy service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateAutomaticTapeCreationPolicy">REST API Reference for UpdateAutomaticTapeCreationPolicy Operation</seealso>
        Task<UpdateAutomaticTapeCreationPolicyResponse> UpdateAutomaticTapeCreationPolicyAsync(UpdateAutomaticTapeCreationPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateBandwidthRateLimit


        /// <summary>
        /// Updates the bandwidth rate limits of a gateway. You can update both the upload and
        /// download bandwidth rate limit or specify only one of the two. If you don't set a bandwidth
        /// rate limit, the existing rate limit remains. This operation is supported for the stored
        /// volume, cached volume, and tape gateway types.
        /// 
        ///  
        /// <para>
        /// By default, a gateway's bandwidth rate limits are not set. If you don't set any limit,
        /// the gateway does not have any limitations on its bandwidth usage and could potentially
        /// use the maximum available bandwidth.
        /// </para>
        ///  
        /// <para>
        /// To specify which gateway to update, use the Amazon Resource Name (ARN) of the gateway
        /// in your request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBandwidthRateLimit service method.</param>
        /// 
        /// <returns>The response from the UpdateBandwidthRateLimit service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateBandwidthRateLimit">REST API Reference for UpdateBandwidthRateLimit Operation</seealso>
        UpdateBandwidthRateLimitResponse UpdateBandwidthRateLimit(UpdateBandwidthRateLimitRequest request);



        /// <summary>
        /// Updates the bandwidth rate limits of a gateway. You can update both the upload and
        /// download bandwidth rate limit or specify only one of the two. If you don't set a bandwidth
        /// rate limit, the existing rate limit remains. This operation is supported for the stored
        /// volume, cached volume, and tape gateway types.
        /// 
        ///  
        /// <para>
        /// By default, a gateway's bandwidth rate limits are not set. If you don't set any limit,
        /// the gateway does not have any limitations on its bandwidth usage and could potentially
        /// use the maximum available bandwidth.
        /// </para>
        ///  
        /// <para>
        /// To specify which gateway to update, use the Amazon Resource Name (ARN) of the gateway
        /// in your request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBandwidthRateLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBandwidthRateLimit service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateBandwidthRateLimit">REST API Reference for UpdateBandwidthRateLimit Operation</seealso>
        Task<UpdateBandwidthRateLimitResponse> UpdateBandwidthRateLimitAsync(UpdateBandwidthRateLimitRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateBandwidthRateLimitSchedule


        /// <summary>
        /// Updates the bandwidth rate limit schedule for a specified gateway. By default, gateways
        /// do not have bandwidth rate limit schedules, which means no bandwidth rate limiting
        /// is in effect. Use this to initiate or update a gateway's bandwidth rate limit schedule.
        /// This operation is supported in the volume and tape gateway types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBandwidthRateLimitSchedule service method.</param>
        /// 
        /// <returns>The response from the UpdateBandwidthRateLimitSchedule service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateBandwidthRateLimitSchedule">REST API Reference for UpdateBandwidthRateLimitSchedule Operation</seealso>
        UpdateBandwidthRateLimitScheduleResponse UpdateBandwidthRateLimitSchedule(UpdateBandwidthRateLimitScheduleRequest request);



        /// <summary>
        /// Updates the bandwidth rate limit schedule for a specified gateway. By default, gateways
        /// do not have bandwidth rate limit schedules, which means no bandwidth rate limiting
        /// is in effect. Use this to initiate or update a gateway's bandwidth rate limit schedule.
        /// This operation is supported in the volume and tape gateway types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBandwidthRateLimitSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBandwidthRateLimitSchedule service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateBandwidthRateLimitSchedule">REST API Reference for UpdateBandwidthRateLimitSchedule Operation</seealso>
        Task<UpdateBandwidthRateLimitScheduleResponse> UpdateBandwidthRateLimitScheduleAsync(UpdateBandwidthRateLimitScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateChapCredentials


        /// <summary>
        /// Updates the Challenge-Handshake Authentication Protocol (CHAP) credentials for a specified
        /// iSCSI target. By default, a gateway does not have CHAP enabled; however, for added
        /// security, you might use it. This operation is supported in the volume and tape gateway
        /// types.
        /// 
        ///  <important> 
        /// <para>
        /// When you update CHAP credentials, all existing connections on the target are closed
        /// and initiators must reconnect with the new credentials.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChapCredentials service method.</param>
        /// 
        /// <returns>The response from the UpdateChapCredentials service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateChapCredentials">REST API Reference for UpdateChapCredentials Operation</seealso>
        UpdateChapCredentialsResponse UpdateChapCredentials(UpdateChapCredentialsRequest request);



        /// <summary>
        /// Updates the Challenge-Handshake Authentication Protocol (CHAP) credentials for a specified
        /// iSCSI target. By default, a gateway does not have CHAP enabled; however, for added
        /// security, you might use it. This operation is supported in the volume and tape gateway
        /// types.
        /// 
        ///  <important> 
        /// <para>
        /// When you update CHAP credentials, all existing connections on the target are closed
        /// and initiators must reconnect with the new credentials.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChapCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateChapCredentials service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateChapCredentials">REST API Reference for UpdateChapCredentials Operation</seealso>
        Task<UpdateChapCredentialsResponse> UpdateChapCredentialsAsync(UpdateChapCredentialsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateGatewayInformation


        /// <summary>
        /// Updates a gateway's metadata, which includes the gateway's name and time zone. To
        /// specify which gateway to update, use the Amazon Resource Name (ARN) of the gateway
        /// in your request.
        /// 
        ///  <note> 
        /// <para>
        /// For gateways activated after September 2, 2015, the gateway's ARN contains the gateway
        /// ID rather than the gateway name. However, changing the name of the gateway has no
        /// effect on the gateway's ARN.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayInformation service method.</param>
        /// 
        /// <returns>The response from the UpdateGatewayInformation service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateGatewayInformation">REST API Reference for UpdateGatewayInformation Operation</seealso>
        UpdateGatewayInformationResponse UpdateGatewayInformation(UpdateGatewayInformationRequest request);



        /// <summary>
        /// Updates a gateway's metadata, which includes the gateway's name and time zone. To
        /// specify which gateway to update, use the Amazon Resource Name (ARN) of the gateway
        /// in your request.
        /// 
        ///  <note> 
        /// <para>
        /// For gateways activated after September 2, 2015, the gateway's ARN contains the gateway
        /// ID rather than the gateway name. However, changing the name of the gateway has no
        /// effect on the gateway's ARN.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayInformation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGatewayInformation service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateGatewayInformation">REST API Reference for UpdateGatewayInformation Operation</seealso>
        Task<UpdateGatewayInformationResponse> UpdateGatewayInformationAsync(UpdateGatewayInformationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateGatewaySoftwareNow


        /// <summary>
        /// Updates the gateway virtual machine (VM) software. The request immediately triggers
        /// the software update.
        /// 
        ///  <note> 
        /// <para>
        /// When you make this request, you get a <code>200 OK</code> success response immediately.
        /// However, it might take some time for the update to complete. You can call <a>DescribeGatewayInformation</a>
        /// to verify the gateway is in the <code>STATE_RUNNING</code> state.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// A software update forces a system restart of your gateway. You can minimize the chance
        /// of any disruption to your applications by increasing your iSCSI Initiators' timeouts.
        /// For more information about increasing iSCSI Initiator timeouts for Windows and Linux,
        /// see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/ConfiguringiSCSIClientInitiatorWindowsClient.html#CustomizeWindowsiSCSISettings">Customizing
        /// your Windows iSCSI settings</a> and <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/ConfiguringiSCSIClientInitiatorRedHatClient.html#CustomizeLinuxiSCSISettings">Customizing
        /// your Linux iSCSI settings</a>, respectively.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewaySoftwareNow service method.</param>
        /// 
        /// <returns>The response from the UpdateGatewaySoftwareNow service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateGatewaySoftwareNow">REST API Reference for UpdateGatewaySoftwareNow Operation</seealso>
        UpdateGatewaySoftwareNowResponse UpdateGatewaySoftwareNow(UpdateGatewaySoftwareNowRequest request);



        /// <summary>
        /// Updates the gateway virtual machine (VM) software. The request immediately triggers
        /// the software update.
        /// 
        ///  <note> 
        /// <para>
        /// When you make this request, you get a <code>200 OK</code> success response immediately.
        /// However, it might take some time for the update to complete. You can call <a>DescribeGatewayInformation</a>
        /// to verify the gateway is in the <code>STATE_RUNNING</code> state.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// A software update forces a system restart of your gateway. You can minimize the chance
        /// of any disruption to your applications by increasing your iSCSI Initiators' timeouts.
        /// For more information about increasing iSCSI Initiator timeouts for Windows and Linux,
        /// see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/ConfiguringiSCSIClientInitiatorWindowsClient.html#CustomizeWindowsiSCSISettings">Customizing
        /// your Windows iSCSI settings</a> and <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/ConfiguringiSCSIClientInitiatorRedHatClient.html#CustomizeLinuxiSCSISettings">Customizing
        /// your Linux iSCSI settings</a>, respectively.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewaySoftwareNow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGatewaySoftwareNow service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateGatewaySoftwareNow">REST API Reference for UpdateGatewaySoftwareNow Operation</seealso>
        Task<UpdateGatewaySoftwareNowResponse> UpdateGatewaySoftwareNowAsync(UpdateGatewaySoftwareNowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateMaintenanceStartTime


        /// <summary>
        /// Updates a gateway's weekly maintenance start time information, including day and time
        /// of the week. The maintenance time is the time in your gateway's time zone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceStartTime service method.</param>
        /// 
        /// <returns>The response from the UpdateMaintenanceStartTime service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateMaintenanceStartTime">REST API Reference for UpdateMaintenanceStartTime Operation</seealso>
        UpdateMaintenanceStartTimeResponse UpdateMaintenanceStartTime(UpdateMaintenanceStartTimeRequest request);



        /// <summary>
        /// Updates a gateway's weekly maintenance start time information, including day and time
        /// of the week. The maintenance time is the time in your gateway's time zone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceStartTime service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMaintenanceStartTime service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateMaintenanceStartTime">REST API Reference for UpdateMaintenanceStartTime Operation</seealso>
        Task<UpdateMaintenanceStartTimeResponse> UpdateMaintenanceStartTimeAsync(UpdateMaintenanceStartTimeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateNFSFileShare


        /// <summary>
        /// Updates a Network File System (NFS) file share. This operation is only supported in
        /// the file gateway type.
        /// 
        ///  <note> 
        /// <para>
        /// To leave a file share field unchanged, set the corresponding input field to null.
        /// </para>
        ///  </note> 
        /// <para>
        /// Updates the following file share settings:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Default storage class for your S3 bucket
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Metadata defaults for your S3 bucket
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Allowed NFS clients for your file share
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Squash settings
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Write status of your file share
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNFSFileShare service method.</param>
        /// 
        /// <returns>The response from the UpdateNFSFileShare service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateNFSFileShare">REST API Reference for UpdateNFSFileShare Operation</seealso>
        UpdateNFSFileShareResponse UpdateNFSFileShare(UpdateNFSFileShareRequest request);



        /// <summary>
        /// Updates a Network File System (NFS) file share. This operation is only supported in
        /// the file gateway type.
        /// 
        ///  <note> 
        /// <para>
        /// To leave a file share field unchanged, set the corresponding input field to null.
        /// </para>
        ///  </note> 
        /// <para>
        /// Updates the following file share settings:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Default storage class for your S3 bucket
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Metadata defaults for your S3 bucket
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Allowed NFS clients for your file share
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Squash settings
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Write status of your file share
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNFSFileShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNFSFileShare service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateNFSFileShare">REST API Reference for UpdateNFSFileShare Operation</seealso>
        Task<UpdateNFSFileShareResponse> UpdateNFSFileShareAsync(UpdateNFSFileShareRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSMBFileShare


        /// <summary>
        /// Updates a Server Message Block (SMB) file share. This operation is only supported
        /// for file gateways.
        /// 
        ///  <note> 
        /// <para>
        /// To leave a file share field unchanged, set the corresponding input field to null.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// File gateways require AWS Security Token Service (AWS STS) to be activated to enable
        /// you to create a file share. Make sure that AWS STS is activated in the AWS Region
        /// you are creating your file gateway in. If AWS STS is not activated in this AWS Region,
        /// activate it. For information about how to activate AWS STS, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and deactivating AWS STS in an AWS Region</a> in the <i>AWS Identity and Access Management
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// File gateways don't support creating hard or symbolic links on a file share.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSMBFileShare service method.</param>
        /// 
        /// <returns>The response from the UpdateSMBFileShare service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateSMBFileShare">REST API Reference for UpdateSMBFileShare Operation</seealso>
        UpdateSMBFileShareResponse UpdateSMBFileShare(UpdateSMBFileShareRequest request);



        /// <summary>
        /// Updates a Server Message Block (SMB) file share. This operation is only supported
        /// for file gateways.
        /// 
        ///  <note> 
        /// <para>
        /// To leave a file share field unchanged, set the corresponding input field to null.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// File gateways require AWS Security Token Service (AWS STS) to be activated to enable
        /// you to create a file share. Make sure that AWS STS is activated in the AWS Region
        /// you are creating your file gateway in. If AWS STS is not activated in this AWS Region,
        /// activate it. For information about how to activate AWS STS, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and deactivating AWS STS in an AWS Region</a> in the <i>AWS Identity and Access Management
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// File gateways don't support creating hard or symbolic links on a file share.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSMBFileShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSMBFileShare service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateSMBFileShare">REST API Reference for UpdateSMBFileShare Operation</seealso>
        Task<UpdateSMBFileShareResponse> UpdateSMBFileShareAsync(UpdateSMBFileShareRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSMBFileShareVisibility


        /// <summary>
        /// Controls whether the shares on a gateway are visible in a net view or browse list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSMBFileShareVisibility service method.</param>
        /// 
        /// <returns>The response from the UpdateSMBFileShareVisibility service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateSMBFileShareVisibility">REST API Reference for UpdateSMBFileShareVisibility Operation</seealso>
        UpdateSMBFileShareVisibilityResponse UpdateSMBFileShareVisibility(UpdateSMBFileShareVisibilityRequest request);



        /// <summary>
        /// Controls whether the shares on a gateway are visible in a net view or browse list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSMBFileShareVisibility service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSMBFileShareVisibility service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateSMBFileShareVisibility">REST API Reference for UpdateSMBFileShareVisibility Operation</seealso>
        Task<UpdateSMBFileShareVisibilityResponse> UpdateSMBFileShareVisibilityAsync(UpdateSMBFileShareVisibilityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSMBSecurityStrategy


        /// <summary>
        /// Updates the SMB security strategy on a file gateway. This action is only supported
        /// in file gateways.
        /// 
        ///  <note> 
        /// <para>
        /// This API is called Security level in the User Guide.
        /// </para>
        ///  
        /// <para>
        /// A higher security level can affect performance of the gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSMBSecurityStrategy service method.</param>
        /// 
        /// <returns>The response from the UpdateSMBSecurityStrategy service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateSMBSecurityStrategy">REST API Reference for UpdateSMBSecurityStrategy Operation</seealso>
        UpdateSMBSecurityStrategyResponse UpdateSMBSecurityStrategy(UpdateSMBSecurityStrategyRequest request);



        /// <summary>
        /// Updates the SMB security strategy on a file gateway. This action is only supported
        /// in file gateways.
        /// 
        ///  <note> 
        /// <para>
        /// This API is called Security level in the User Guide.
        /// </para>
        ///  
        /// <para>
        /// A higher security level can affect performance of the gateway.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSMBSecurityStrategy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSMBSecurityStrategy service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateSMBSecurityStrategy">REST API Reference for UpdateSMBSecurityStrategy Operation</seealso>
        Task<UpdateSMBSecurityStrategyResponse> UpdateSMBSecurityStrategyAsync(UpdateSMBSecurityStrategyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSnapshotSchedule


        /// <summary>
        /// Updates a snapshot schedule configured for a gateway volume. This operation is only
        /// supported in the cached volume and stored volume gateway types.
        /// 
        ///  
        /// <para>
        /// The default snapshot schedule for volume is once every 24 hours, starting at the creation
        /// time of the volume. You can use this API to change the snapshot schedule configured
        /// for the volume.
        /// </para>
        ///  
        /// <para>
        /// In the request you must identify the gateway volume whose snapshot schedule you want
        /// to update, and the schedule information, including when you want the snapshot to begin
        /// on a day and the frequency (in hours) of snapshots.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshotSchedule service method.</param>
        /// 
        /// <returns>The response from the UpdateSnapshotSchedule service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateSnapshotSchedule">REST API Reference for UpdateSnapshotSchedule Operation</seealso>
        UpdateSnapshotScheduleResponse UpdateSnapshotSchedule(UpdateSnapshotScheduleRequest request);



        /// <summary>
        /// Updates a snapshot schedule configured for a gateway volume. This operation is only
        /// supported in the cached volume and stored volume gateway types.
        /// 
        ///  
        /// <para>
        /// The default snapshot schedule for volume is once every 24 hours, starting at the creation
        /// time of the volume. You can use this API to change the snapshot schedule configured
        /// for the volume.
        /// </para>
        ///  
        /// <para>
        /// In the request you must identify the gateway volume whose snapshot schedule you want
        /// to update, and the schedule information, including when you want the snapshot to begin
        /// on a day and the frequency (in hours) of snapshots.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshotSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSnapshotSchedule service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateSnapshotSchedule">REST API Reference for UpdateSnapshotSchedule Operation</seealso>
        Task<UpdateSnapshotScheduleResponse> UpdateSnapshotScheduleAsync(UpdateSnapshotScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateVTLDeviceType


        /// <summary>
        /// Updates the type of medium changer in a tape gateway. When you activate a tape gateway,
        /// you select a medium changer type for the tape gateway. This operation enables you
        /// to select a different type of medium changer after a tape gateway is activated. This
        /// operation is only supported in the tape gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVTLDeviceType service method.</param>
        /// 
        /// <returns>The response from the UpdateVTLDeviceType service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateVTLDeviceType">REST API Reference for UpdateVTLDeviceType Operation</seealso>
        UpdateVTLDeviceTypeResponse UpdateVTLDeviceType(UpdateVTLDeviceTypeRequest request);



        /// <summary>
        /// Updates the type of medium changer in a tape gateway. When you activate a tape gateway,
        /// you select a medium changer type for the tape gateway. This operation enables you
        /// to select a different type of medium changer after a tape gateway is activated. This
        /// operation is only supported in the tape gateway type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVTLDeviceType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVTLDeviceType service method, as returned by StorageGateway.</returns>
        /// <exception cref="Amazon.StorageGateway.Model.InternalServerErrorException">
        /// An internal server error has occurred during the request. For more information, see
        /// the error and message fields.
        /// </exception>
        /// <exception cref="Amazon.StorageGateway.Model.InvalidGatewayRequestException">
        /// An exception occurred because an invalid gateway request was issued to the service.
        /// For more information, see the error and message fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/storagegateway-2013-06-30/UpdateVTLDeviceType">REST API Reference for UpdateVTLDeviceType Operation</seealso>
        Task<UpdateVTLDeviceTypeResponse> UpdateVTLDeviceTypeAsync(UpdateVTLDeviceTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}