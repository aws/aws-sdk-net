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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MediaConvert.Model;

#pragma warning disable CS1570
namespace Amazon.MediaConvert
{
    /// <summary>
    /// <para>Interface for accessing MediaConvert</para>
    ///
    /// AWS Elemental MediaConvert
    /// </summary>
    public partial interface IAmazonMediaConvert : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMediaConvertPaginatorFactory Paginators { get; }

        
        #region  AssociateCertificate


        /// <summary>
        /// Associates an AWS Certificate Manager (ACM) Amazon Resource Name (ARN) with AWS Elemental
        /// MediaConvert.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateCertificate service method.</param>
        /// 
        /// <returns>The response from the AssociateCertificate service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/AssociateCertificate">REST API Reference for AssociateCertificate Operation</seealso>
        AssociateCertificateResponse AssociateCertificate(AssociateCertificateRequest request);



        /// <summary>
        /// Associates an AWS Certificate Manager (ACM) Amazon Resource Name (ARN) with AWS Elemental
        /// MediaConvert.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateCertificate service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/AssociateCertificate">REST API Reference for AssociateCertificate Operation</seealso>
        Task<AssociateCertificateResponse> AssociateCertificateAsync(AssociateCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelJob


        /// <summary>
        /// Permanently cancel a job. Once you have canceled a job, you can't start it again.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CancelJob">REST API Reference for CancelJob Operation</seealso>
        CancelJobResponse CancelJob(CancelJobRequest request);



        /// <summary>
        /// Permanently cancel a job. Once you have canceled a job, you can't start it again.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CancelJob">REST API Reference for CancelJob Operation</seealso>
        Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateJob


        /// <summary>
        /// Create a new transcoding job. For information about jobs and job settings, see the
        /// User Guide at http://docs.aws.amazon.com/mediaconvert/latest/ug/what-is.html
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CreateJob">REST API Reference for CreateJob Operation</seealso>
        CreateJobResponse CreateJob(CreateJobRequest request);



        /// <summary>
        /// Create a new transcoding job. For information about jobs and job settings, see the
        /// User Guide at http://docs.aws.amazon.com/mediaconvert/latest/ug/what-is.html
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CreateJob">REST API Reference for CreateJob Operation</seealso>
        Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateJobTemplate


        /// <summary>
        /// Create a new job template. For information about job templates see the User Guide
        /// at http://docs.aws.amazon.com/mediaconvert/latest/ug/what-is.html
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJobTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateJobTemplate service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CreateJobTemplate">REST API Reference for CreateJobTemplate Operation</seealso>
        CreateJobTemplateResponse CreateJobTemplate(CreateJobTemplateRequest request);



        /// <summary>
        /// Create a new job template. For information about job templates see the User Guide
        /// at http://docs.aws.amazon.com/mediaconvert/latest/ug/what-is.html
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJobTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateJobTemplate service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CreateJobTemplate">REST API Reference for CreateJobTemplate Operation</seealso>
        Task<CreateJobTemplateResponse> CreateJobTemplateAsync(CreateJobTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePreset


        /// <summary>
        /// Create a new preset. For information about job templates see the User Guide at http://docs.aws.amazon.com/mediaconvert/latest/ug/what-is.html
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePreset service method.</param>
        /// 
        /// <returns>The response from the CreatePreset service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CreatePreset">REST API Reference for CreatePreset Operation</seealso>
        CreatePresetResponse CreatePreset(CreatePresetRequest request);



        /// <summary>
        /// Create a new preset. For information about job templates see the User Guide at http://docs.aws.amazon.com/mediaconvert/latest/ug/what-is.html
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePreset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePreset service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CreatePreset">REST API Reference for CreatePreset Operation</seealso>
        Task<CreatePresetResponse> CreatePresetAsync(CreatePresetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateQueue


        /// <summary>
        /// Create a new transcoding queue. For information about queues, see Working With Queues
        /// in the User Guide at https://docs.aws.amazon.com/mediaconvert/latest/ug/working-with-queues.html
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueue service method.</param>
        /// 
        /// <returns>The response from the CreateQueue service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        CreateQueueResponse CreateQueue(CreateQueueRequest request);



        /// <summary>
        /// Create a new transcoding queue. For information about queues, see Working With Queues
        /// in the User Guide at https://docs.aws.amazon.com/mediaconvert/latest/ug/working-with-queues.html
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateQueue service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        Task<CreateQueueResponse> CreateQueueAsync(CreateQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateResourceShare


        /// <summary>
        /// Create a new resource share request for MediaConvert resources with AWS Support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceShare service method.</param>
        /// 
        /// <returns>The response from the CreateResourceShare service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CreateResourceShare">REST API Reference for CreateResourceShare Operation</seealso>
        CreateResourceShareResponse CreateResourceShare(CreateResourceShareRequest request);



        /// <summary>
        /// Create a new resource share request for MediaConvert resources with AWS Support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateResourceShare service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CreateResourceShare">REST API Reference for CreateResourceShare Operation</seealso>
        Task<CreateResourceShareResponse> CreateResourceShareAsync(CreateResourceShareRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteJobTemplate


        /// <summary>
        /// Permanently delete a job template you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteJobTemplate service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DeleteJobTemplate">REST API Reference for DeleteJobTemplate Operation</seealso>
        DeleteJobTemplateResponse DeleteJobTemplate(DeleteJobTemplateRequest request);



        /// <summary>
        /// Permanently delete a job template you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteJobTemplate service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DeleteJobTemplate">REST API Reference for DeleteJobTemplate Operation</seealso>
        Task<DeleteJobTemplateResponse> DeleteJobTemplateAsync(DeleteJobTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePolicy


        /// <summary>
        /// Permanently delete a policy that you created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        DeletePolicyResponse DeletePolicy(DeletePolicyRequest request);



        /// <summary>
        /// Permanently delete a policy that you created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePreset


        /// <summary>
        /// Permanently delete a preset you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePreset service method.</param>
        /// 
        /// <returns>The response from the DeletePreset service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DeletePreset">REST API Reference for DeletePreset Operation</seealso>
        DeletePresetResponse DeletePreset(DeletePresetRequest request);



        /// <summary>
        /// Permanently delete a preset you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePreset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePreset service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DeletePreset">REST API Reference for DeletePreset Operation</seealso>
        Task<DeletePresetResponse> DeletePresetAsync(DeletePresetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteQueue


        /// <summary>
        /// Permanently delete a queue you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueue service method.</param>
        /// 
        /// <returns>The response from the DeleteQueue service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DeleteQueue">REST API Reference for DeleteQueue Operation</seealso>
        DeleteQueueResponse DeleteQueue(DeleteQueueRequest request);



        /// <summary>
        /// Permanently delete a queue you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteQueue service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DeleteQueue">REST API Reference for DeleteQueue Operation</seealso>
        Task<DeleteQueueResponse> DeleteQueueAsync(DeleteQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEndpoints


        /// <summary>
        /// Send a request with an empty body to the regional API endpoint to get your account
        /// API endpoint. Note that DescribeEndpoints is no longer required. We recommend that
        /// you send your requests directly to the regional endpoint instead.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoints service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpoints service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DescribeEndpoints">REST API Reference for DescribeEndpoints Operation</seealso>
        [Obsolete("DescribeEndpoints and account specific endpoints are no longer required. We recommend that you send your requests directly to the regional endpoint instead.")]
        DescribeEndpointsResponse DescribeEndpoints(DescribeEndpointsRequest request);



        /// <summary>
        /// Send a request with an empty body to the regional API endpoint to get your account
        /// API endpoint. Note that DescribeEndpoints is no longer required. We recommend that
        /// you send your requests directly to the regional endpoint instead.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEndpoints service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DescribeEndpoints">REST API Reference for DescribeEndpoints Operation</seealso>
        [Obsolete("DescribeEndpoints and account specific endpoints are no longer required. We recommend that you send your requests directly to the regional endpoint instead.")]
        Task<DescribeEndpointsResponse> DescribeEndpointsAsync(DescribeEndpointsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateCertificate


        /// <summary>
        /// Removes an association between the Amazon Resource Name (ARN) of an AWS Certificate
        /// Manager (ACM) certificate and an AWS Elemental MediaConvert resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCertificate service method.</param>
        /// 
        /// <returns>The response from the DisassociateCertificate service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DisassociateCertificate">REST API Reference for DisassociateCertificate Operation</seealso>
        DisassociateCertificateResponse DisassociateCertificate(DisassociateCertificateRequest request);



        /// <summary>
        /// Removes an association between the Amazon Resource Name (ARN) of an AWS Certificate
        /// Manager (ACM) certificate and an AWS Elemental MediaConvert resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateCertificate service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DisassociateCertificate">REST API Reference for DisassociateCertificate Operation</seealso>
        Task<DisassociateCertificateResponse> DisassociateCertificateAsync(DisassociateCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetJob


        /// <summary>
        /// Retrieve the JSON for a specific transcoding job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/GetJob">REST API Reference for GetJob Operation</seealso>
        GetJobResponse GetJob(GetJobRequest request);



        /// <summary>
        /// Retrieve the JSON for a specific transcoding job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/GetJob">REST API Reference for GetJob Operation</seealso>
        Task<GetJobResponse> GetJobAsync(GetJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetJobTemplate


        /// <summary>
        /// Retrieve the JSON for a specific job template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobTemplate service method.</param>
        /// 
        /// <returns>The response from the GetJobTemplate service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/GetJobTemplate">REST API Reference for GetJobTemplate Operation</seealso>
        GetJobTemplateResponse GetJobTemplate(GetJobTemplateRequest request);



        /// <summary>
        /// Retrieve the JSON for a specific job template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJobTemplate service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/GetJobTemplate">REST API Reference for GetJobTemplate Operation</seealso>
        Task<GetJobTemplateResponse> GetJobTemplateAsync(GetJobTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPolicy


        /// <summary>
        /// Retrieve the JSON for your policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        GetPolicyResponse GetPolicy(GetPolicyRequest request);



        /// <summary>
        /// Retrieve the JSON for your policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPreset


        /// <summary>
        /// Retrieve the JSON for a specific preset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPreset service method.</param>
        /// 
        /// <returns>The response from the GetPreset service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/GetPreset">REST API Reference for GetPreset Operation</seealso>
        GetPresetResponse GetPreset(GetPresetRequest request);



        /// <summary>
        /// Retrieve the JSON for a specific preset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPreset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPreset service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/GetPreset">REST API Reference for GetPreset Operation</seealso>
        Task<GetPresetResponse> GetPresetAsync(GetPresetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetQueue


        /// <summary>
        /// Retrieve the JSON for a specific queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueue service method.</param>
        /// 
        /// <returns>The response from the GetQueue service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/GetQueue">REST API Reference for GetQueue Operation</seealso>
        GetQueueResponse GetQueue(GetQueueRequest request);



        /// <summary>
        /// Retrieve the JSON for a specific queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueue service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/GetQueue">REST API Reference for GetQueue Operation</seealso>
        Task<GetQueueResponse> GetQueueAsync(GetQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListJobs


        /// <summary>
        /// Retrieve a JSON array of up to twenty of your most recently created jobs. This array
        /// includes in-process, completed, and errored jobs. This will return the jobs themselves,
        /// not just a list of the jobs. To retrieve the twenty next most recent jobs, use the
        /// nextToken string returned with the array.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListJobs">REST API Reference for ListJobs Operation</seealso>
        ListJobsResponse ListJobs(ListJobsRequest request);



        /// <summary>
        /// Retrieve a JSON array of up to twenty of your most recently created jobs. This array
        /// includes in-process, completed, and errored jobs. This will return the jobs themselves,
        /// not just a list of the jobs. To retrieve the twenty next most recent jobs, use the
        /// nextToken string returned with the array.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListJobs">REST API Reference for ListJobs Operation</seealso>
        Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListJobTemplates


        /// <summary>
        /// Retrieve a JSON array of up to twenty of your job templates. This will return the
        /// templates themselves, not just a list of them. To retrieve the next twenty templates,
        /// use the nextToken string returned with the array
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobTemplates service method.</param>
        /// 
        /// <returns>The response from the ListJobTemplates service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListJobTemplates">REST API Reference for ListJobTemplates Operation</seealso>
        ListJobTemplatesResponse ListJobTemplates(ListJobTemplatesRequest request);



        /// <summary>
        /// Retrieve a JSON array of up to twenty of your job templates. This will return the
        /// templates themselves, not just a list of them. To retrieve the next twenty templates,
        /// use the nextToken string returned with the array
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobTemplates service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListJobTemplates">REST API Reference for ListJobTemplates Operation</seealso>
        Task<ListJobTemplatesResponse> ListJobTemplatesAsync(ListJobTemplatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPresets


        /// <summary>
        /// Retrieve a JSON array of up to twenty of your presets. This will return the presets
        /// themselves, not just a list of them. To retrieve the next twenty presets, use the
        /// nextToken string returned with the array.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPresets service method.</param>
        /// 
        /// <returns>The response from the ListPresets service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListPresets">REST API Reference for ListPresets Operation</seealso>
        ListPresetsResponse ListPresets(ListPresetsRequest request);



        /// <summary>
        /// Retrieve a JSON array of up to twenty of your presets. This will return the presets
        /// themselves, not just a list of them. To retrieve the next twenty presets, use the
        /// nextToken string returned with the array.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPresets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPresets service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListPresets">REST API Reference for ListPresets Operation</seealso>
        Task<ListPresetsResponse> ListPresetsAsync(ListPresetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListQueues


        /// <summary>
        /// Retrieve a JSON array of up to twenty of your queues. This will return the queues
        /// themselves, not just a list of them. To retrieve the next twenty queues, use the nextToken
        /// string returned with the array.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueues service method.</param>
        /// 
        /// <returns>The response from the ListQueues service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListQueues">REST API Reference for ListQueues Operation</seealso>
        ListQueuesResponse ListQueues(ListQueuesRequest request);



        /// <summary>
        /// Retrieve a JSON array of up to twenty of your queues. This will return the queues
        /// themselves, not just a list of them. To retrieve the next twenty queues, use the nextToken
        /// string returned with the array.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQueues service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListQueues">REST API Reference for ListQueues Operation</seealso>
        Task<ListQueuesResponse> ListQueuesAsync(ListQueuesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieve the tags for a MediaConvert resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Retrieve the tags for a MediaConvert resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListVersions


        /// <summary>
        /// Retrieve a JSON array of all available Job engine versions and the date they expire.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVersions service method.</param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListVersions">REST API Reference for ListVersions Operation</seealso>
        ListVersionsResponse ListVersions(ListVersionsRequest request);



        /// <summary>
        /// Retrieve a JSON array of all available Job engine versions and the date they expire.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListVersions">REST API Reference for ListVersions Operation</seealso>
        Task<ListVersionsResponse> ListVersionsAsync(ListVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  Probe


        /// <summary>
        /// Use Probe to obtain detailed information about your input media files. Probe returns
        /// a JSON that includes container, codec, frame rate, resolution, track count, audio
        /// layout, captions, and more. You can use this information to learn more about your
        /// media files, or to help make decisions while automating your transcoding workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Probe service method.</param>
        /// 
        /// <returns>The response from the Probe service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/Probe">REST API Reference for Probe Operation</seealso>
        ProbeResponse Probe(ProbeRequest request);



        /// <summary>
        /// Use Probe to obtain detailed information about your input media files. Probe returns
        /// a JSON that includes container, codec, frame rate, resolution, track count, audio
        /// layout, captions, and more. You can use this information to learn more about your
        /// media files, or to help make decisions while automating your transcoding workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Probe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Probe service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/Probe">REST API Reference for Probe Operation</seealso>
        Task<ProbeResponse> ProbeAsync(ProbeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutPolicy


        /// <summary>
        /// Create or change your policy. For more information about policies, see the user guide
        /// at http://docs.aws.amazon.com/mediaconvert/latest/ug/what-is.html
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPolicy service method.</param>
        /// 
        /// <returns>The response from the PutPolicy service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/PutPolicy">REST API Reference for PutPolicy Operation</seealso>
        PutPolicyResponse PutPolicy(PutPolicyRequest request);



        /// <summary>
        /// Create or change your policy. For more information about policies, see the user guide
        /// at http://docs.aws.amazon.com/mediaconvert/latest/ug/what-is.html
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutPolicy service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/PutPolicy">REST API Reference for PutPolicy Operation</seealso>
        Task<PutPolicyResponse> PutPolicyAsync(PutPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchJobs


        /// <summary>
        /// Retrieve a JSON array that includes job details for up to twenty of your most recent
        /// jobs. Optionally filter results further according to input file, queue, or status.
        /// To retrieve the twenty next most recent jobs, use the nextToken string returned with
        /// the array.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchJobs service method.</param>
        /// 
        /// <returns>The response from the SearchJobs service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/SearchJobs">REST API Reference for SearchJobs Operation</seealso>
        SearchJobsResponse SearchJobs(SearchJobsRequest request);



        /// <summary>
        /// Retrieve a JSON array that includes job details for up to twenty of your most recent
        /// jobs. Optionally filter results further according to input file, queue, or status.
        /// To retrieve the twenty next most recent jobs, use the nextToken string returned with
        /// the array.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchJobs service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/SearchJobs">REST API Reference for SearchJobs Operation</seealso>
        Task<SearchJobsResponse> SearchJobsAsync(SearchJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Add tags to a MediaConvert queue, preset, or job template. For information about tagging,
        /// see the User Guide at https://docs.aws.amazon.com/mediaconvert/latest/ug/tagging-resources.html
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Add tags to a MediaConvert queue, preset, or job template. For information about tagging,
        /// see the User Guide at https://docs.aws.amazon.com/mediaconvert/latest/ug/tagging-resources.html
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Remove tags from a MediaConvert queue, preset, or job template. For information about
        /// tagging, see the User Guide at https://docs.aws.amazon.com/mediaconvert/latest/ug/tagging-resources.html
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Remove tags from a MediaConvert queue, preset, or job template. For information about
        /// tagging, see the User Guide at https://docs.aws.amazon.com/mediaconvert/latest/ug/tagging-resources.html
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateJobTemplate


        /// <summary>
        /// Modify one of your existing job templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateJobTemplate service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/UpdateJobTemplate">REST API Reference for UpdateJobTemplate Operation</seealso>
        UpdateJobTemplateResponse UpdateJobTemplate(UpdateJobTemplateRequest request);



        /// <summary>
        /// Modify one of your existing job templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateJobTemplate service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/UpdateJobTemplate">REST API Reference for UpdateJobTemplate Operation</seealso>
        Task<UpdateJobTemplateResponse> UpdateJobTemplateAsync(UpdateJobTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdatePreset


        /// <summary>
        /// Modify one of your existing presets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePreset service method.</param>
        /// 
        /// <returns>The response from the UpdatePreset service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/UpdatePreset">REST API Reference for UpdatePreset Operation</seealso>
        UpdatePresetResponse UpdatePreset(UpdatePresetRequest request);



        /// <summary>
        /// Modify one of your existing presets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePreset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePreset service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/UpdatePreset">REST API Reference for UpdatePreset Operation</seealso>
        Task<UpdatePresetResponse> UpdatePresetAsync(UpdatePresetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateQueue


        /// <summary>
        /// Modify one of your existing queues.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueue service method.</param>
        /// 
        /// <returns>The response from the UpdateQueue service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/UpdateQueue">REST API Reference for UpdateQueue Operation</seealso>
        UpdateQueueResponse UpdateQueue(UpdateQueueRequest request);



        /// <summary>
        /// Modify one of your existing queues.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQueue service method, as returned by MediaConvert.</returns>
        /// <exception cref="Amazon.MediaConvert.Model.BadRequestException">
        /// The service can't process your request because of a problem in the request. Please
        /// check your request form and syntax.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ConflictException">
        /// The service couldn't complete your request because there is a conflict with the current
        /// state of the resource.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.ForbiddenException">
        /// You don't have permissions for this action with the credentials you sent.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.InternalServerErrorException">
        /// The service encountered an unexpected condition and can't fulfill your request.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.NotFoundException">
        /// The resource you requested doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaConvert.Model.TooManyRequestsException">
        /// Too many requests have been sent in too short of a time. The service limits the rate
        /// at which it will accept requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/UpdateQueue">REST API Reference for UpdateQueue Operation</seealso>
        Task<UpdateQueueResponse> UpdateQueueAsync(UpdateQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

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