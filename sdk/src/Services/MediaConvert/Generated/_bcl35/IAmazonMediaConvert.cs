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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMediaConvertPaginatorFactory Paginators { get; }
#endif


        
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
        /// Initiates the asynchronous execution of the AssociateCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateCertificate operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/AssociateCertificate">REST API Reference for AssociateCertificate Operation</seealso>
        IAsyncResult BeginAssociateCertificate(AssociateCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateCertificate.</param>
        /// 
        /// <returns>Returns a  AssociateCertificateResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/AssociateCertificate">REST API Reference for AssociateCertificate Operation</seealso>
        AssociateCertificateResponse EndAssociateCertificate(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CancelJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelJob operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CancelJob">REST API Reference for CancelJob Operation</seealso>
        IAsyncResult BeginCancelJob(CancelJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelJob.</param>
        /// 
        /// <returns>Returns a  CancelJobResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CancelJob">REST API Reference for CancelJob Operation</seealso>
        CancelJobResponse EndCancelJob(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJob operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CreateJob">REST API Reference for CreateJob Operation</seealso>
        IAsyncResult BeginCreateJob(CreateJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJob.</param>
        /// 
        /// <returns>Returns a  CreateJobResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CreateJob">REST API Reference for CreateJob Operation</seealso>
        CreateJobResponse EndCreateJob(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJobTemplate operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateJobTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CreateJobTemplate">REST API Reference for CreateJobTemplate Operation</seealso>
        IAsyncResult BeginCreateJobTemplate(CreateJobTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJobTemplate.</param>
        /// 
        /// <returns>Returns a  CreateJobTemplateResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CreateJobTemplate">REST API Reference for CreateJobTemplate Operation</seealso>
        CreateJobTemplateResponse EndCreateJobTemplate(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreatePreset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePreset operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePreset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CreatePreset">REST API Reference for CreatePreset Operation</seealso>
        IAsyncResult BeginCreatePreset(CreatePresetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePreset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePreset.</param>
        /// 
        /// <returns>Returns a  CreatePresetResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CreatePreset">REST API Reference for CreatePreset Operation</seealso>
        CreatePresetResponse EndCreatePreset(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateQueue operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        IAsyncResult BeginCreateQueue(CreateQueueRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateQueue.</param>
        /// 
        /// <returns>Returns a  CreateQueueResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        CreateQueueResponse EndCreateQueue(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateResourceShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceShare operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResourceShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CreateResourceShare">REST API Reference for CreateResourceShare Operation</seealso>
        IAsyncResult BeginCreateResourceShare(CreateResourceShareRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResourceShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResourceShare.</param>
        /// 
        /// <returns>Returns a  CreateResourceShareResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CreateResourceShare">REST API Reference for CreateResourceShare Operation</seealso>
        CreateResourceShareResponse EndCreateResourceShare(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobTemplate operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteJobTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DeleteJobTemplate">REST API Reference for DeleteJobTemplate Operation</seealso>
        IAsyncResult BeginDeleteJobTemplate(DeleteJobTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteJobTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteJobTemplateResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DeleteJobTemplate">REST API Reference for DeleteJobTemplate Operation</seealso>
        DeleteJobTemplateResponse EndDeleteJobTemplate(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        IAsyncResult BeginDeletePolicy(DeletePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePolicy.</param>
        /// 
        /// <returns>Returns a  DeletePolicyResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        DeletePolicyResponse EndDeletePolicy(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeletePreset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePreset operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePreset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DeletePreset">REST API Reference for DeletePreset Operation</seealso>
        IAsyncResult BeginDeletePreset(DeletePresetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePreset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePreset.</param>
        /// 
        /// <returns>Returns a  DeletePresetResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DeletePreset">REST API Reference for DeletePreset Operation</seealso>
        DeletePresetResponse EndDeletePreset(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueue operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DeleteQueue">REST API Reference for DeleteQueue Operation</seealso>
        IAsyncResult BeginDeleteQueue(DeleteQueueRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteQueue.</param>
        /// 
        /// <returns>Returns a  DeleteQueueResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DeleteQueue">REST API Reference for DeleteQueue Operation</seealso>
        DeleteQueueResponse EndDeleteQueue(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DescribeEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoints operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DescribeEndpoints">REST API Reference for DescribeEndpoints Operation</seealso>
        [Obsolete("DescribeEndpoints and account specific endpoints are no longer required. We recommend that you send your requests directly to the regional endpoint instead.")]
        IAsyncResult BeginDescribeEndpoints(DescribeEndpointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEndpoints.</param>
        /// 
        /// <returns>Returns a  DescribeEndpointsResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DescribeEndpoints">REST API Reference for DescribeEndpoints Operation</seealso>
        [Obsolete("DescribeEndpoints and account specific endpoints are no longer required. We recommend that you send your requests directly to the regional endpoint instead.")]
        DescribeEndpointsResponse EndDescribeEndpoints(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DisassociateCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCertificate operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DisassociateCertificate">REST API Reference for DisassociateCertificate Operation</seealso>
        IAsyncResult BeginDisassociateCertificate(DisassociateCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateCertificate.</param>
        /// 
        /// <returns>Returns a  DisassociateCertificateResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DisassociateCertificate">REST API Reference for DisassociateCertificate Operation</seealso>
        DisassociateCertificateResponse EndDisassociateCertificate(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJob operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/GetJob">REST API Reference for GetJob Operation</seealso>
        IAsyncResult BeginGetJob(GetJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJob.</param>
        /// 
        /// <returns>Returns a  GetJobResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/GetJob">REST API Reference for GetJob Operation</seealso>
        GetJobResponse EndGetJob(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobTemplate operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJobTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/GetJobTemplate">REST API Reference for GetJobTemplate Operation</seealso>
        IAsyncResult BeginGetJobTemplate(GetJobTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJobTemplate.</param>
        /// 
        /// <returns>Returns a  GetJobTemplateResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/GetJobTemplate">REST API Reference for GetJobTemplate Operation</seealso>
        GetJobTemplateResponse EndGetJobTemplate(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        IAsyncResult BeginGetPolicy(GetPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPolicy.</param>
        /// 
        /// <returns>Returns a  GetPolicyResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        GetPolicyResponse EndGetPolicy(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetPreset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPreset operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPreset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/GetPreset">REST API Reference for GetPreset Operation</seealso>
        IAsyncResult BeginGetPreset(GetPresetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPreset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPreset.</param>
        /// 
        /// <returns>Returns a  GetPresetResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/GetPreset">REST API Reference for GetPreset Operation</seealso>
        GetPresetResponse EndGetPreset(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueue operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/GetQueue">REST API Reference for GetQueue Operation</seealso>
        IAsyncResult BeginGetQueue(GetQueueRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQueue.</param>
        /// 
        /// <returns>Returns a  GetQueueResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/GetQueue">REST API Reference for GetQueue Operation</seealso>
        GetQueueResponse EndGetQueue(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListJobs">REST API Reference for ListJobs Operation</seealso>
        IAsyncResult BeginListJobs(ListJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobs.</param>
        /// 
        /// <returns>Returns a  ListJobsResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListJobs">REST API Reference for ListJobs Operation</seealso>
        ListJobsResponse EndListJobs(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListJobTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobTemplates operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListJobTemplates">REST API Reference for ListJobTemplates Operation</seealso>
        IAsyncResult BeginListJobTemplates(ListJobTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobTemplates.</param>
        /// 
        /// <returns>Returns a  ListJobTemplatesResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListJobTemplates">REST API Reference for ListJobTemplates Operation</seealso>
        ListJobTemplatesResponse EndListJobTemplates(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListPresets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPresets operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPresets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListPresets">REST API Reference for ListPresets Operation</seealso>
        IAsyncResult BeginListPresets(ListPresetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPresets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPresets.</param>
        /// 
        /// <returns>Returns a  ListPresetsResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListPresets">REST API Reference for ListPresets Operation</seealso>
        ListPresetsResponse EndListPresets(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListQueues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQueues operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQueues
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListQueues">REST API Reference for ListQueues Operation</seealso>
        IAsyncResult BeginListQueues(ListQueuesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListQueues operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQueues.</param>
        /// 
        /// <returns>Returns a  ListQueuesResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListQueues">REST API Reference for ListQueues Operation</seealso>
        ListQueuesResponse EndListQueues(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVersions operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListVersions">REST API Reference for ListVersions Operation</seealso>
        IAsyncResult BeginListVersions(ListVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVersions.</param>
        /// 
        /// <returns>Returns a  ListVersionsResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListVersions">REST API Reference for ListVersions Operation</seealso>
        ListVersionsResponse EndListVersions(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the Probe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Probe operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndProbe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/Probe">REST API Reference for Probe Operation</seealso>
        IAsyncResult BeginProbe(ProbeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Probe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginProbe.</param>
        /// 
        /// <returns>Returns a  ProbeResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/Probe">REST API Reference for Probe Operation</seealso>
        ProbeResponse EndProbe(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the PutPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPolicy operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/PutPolicy">REST API Reference for PutPolicy Operation</seealso>
        IAsyncResult BeginPutPolicy(PutPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPolicy.</param>
        /// 
        /// <returns>Returns a  PutPolicyResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/PutPolicy">REST API Reference for PutPolicy Operation</seealso>
        PutPolicyResponse EndPutPolicy(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the SearchJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchJobs operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/SearchJobs">REST API Reference for SearchJobs Operation</seealso>
        IAsyncResult BeginSearchJobs(SearchJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchJobs.</param>
        /// 
        /// <returns>Returns a  SearchJobsResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/SearchJobs">REST API Reference for SearchJobs Operation</seealso>
        SearchJobsResponse EndSearchJobs(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobTemplate operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateJobTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/UpdateJobTemplate">REST API Reference for UpdateJobTemplate Operation</seealso>
        IAsyncResult BeginUpdateJobTemplate(UpdateJobTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateJobTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateJobTemplateResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/UpdateJobTemplate">REST API Reference for UpdateJobTemplate Operation</seealso>
        UpdateJobTemplateResponse EndUpdateJobTemplate(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdatePreset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePreset operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePreset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/UpdatePreset">REST API Reference for UpdatePreset Operation</seealso>
        IAsyncResult BeginUpdatePreset(UpdatePresetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePreset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePreset.</param>
        /// 
        /// <returns>Returns a  UpdatePresetResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/UpdatePreset">REST API Reference for UpdatePreset Operation</seealso>
        UpdatePresetResponse EndUpdatePreset(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueue operation on AmazonMediaConvertClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/UpdateQueue">REST API Reference for UpdateQueue Operation</seealso>
        IAsyncResult BeginUpdateQueue(UpdateQueueRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQueue.</param>
        /// 
        /// <returns>Returns a  UpdateQueueResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/UpdateQueue">REST API Reference for UpdateQueue Operation</seealso>
        UpdateQueueResponse EndUpdateQueue(IAsyncResult asyncResult);

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