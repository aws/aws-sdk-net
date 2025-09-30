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
using System.Net;

using Amazon.MediaConvert.Model;
using Amazon.MediaConvert.Model.Internal.MarshallTransformations;
using Amazon.MediaConvert.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.MediaConvert
{
    /// <summary>
    /// <para>Implementation for accessing MediaConvert</para>
    ///
    /// AWS Elemental MediaConvert
    /// </summary>
    public partial class AmazonMediaConvertClient : AmazonServiceClient, IAmazonMediaConvert
    {
        private static IServiceMetadata serviceMetadata = new AmazonMediaConvertMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IMediaConvertPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMediaConvertPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new MediaConvertPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonMediaConvertClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonMediaConvertClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMediaConvertConfig()) { }

        /// <summary>
        /// Constructs AmazonMediaConvertClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaConvertClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMediaConvertConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMediaConvertClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonMediaConvertClient Configuration Object</param>
        public AmazonMediaConvertClient(AmazonMediaConvertConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonMediaConvertClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMediaConvertClient(AWSCredentials credentials)
            : this(credentials, new AmazonMediaConvertConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaConvertClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaConvertClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMediaConvertConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaConvertClient with AWS Credentials and an
        /// AmazonMediaConvertClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMediaConvertClient Configuration Object</param>
        public AmazonMediaConvertClient(AWSCredentials credentials, AmazonMediaConvertConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaConvertClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMediaConvertClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaConvertConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaConvertClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaConvertClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaConvertConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaConvertClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaConvertClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMediaConvertClient Configuration Object</param>
        public AmazonMediaConvertClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMediaConvertConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaConvertClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMediaConvertClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaConvertConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaConvertClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaConvertClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaConvertConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaConvertClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaConvertClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMediaConvertClient Configuration Object</param>
        public AmazonMediaConvertClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMediaConvertConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMediaConvertEndpointResolver());
        }
        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


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
        public virtual AssociateCertificateResponse AssociateCertificate(AssociateCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateCertificateResponseUnmarshaller.Instance;

            return Invoke<AssociateCertificateResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginAssociateCertificate(AssociateCertificateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateCertificate.</param>
        /// 
        /// <returns>Returns a  AssociateCertificateResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/AssociateCertificate">REST API Reference for AssociateCertificate Operation</seealso>
        public virtual AssociateCertificateResponse EndAssociateCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateCertificateResponse>(asyncResult);
        }

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
        public virtual CancelJobResponse CancelJob(CancelJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobResponseUnmarshaller.Instance;

            return Invoke<CancelJobResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginCancelJob(CancelJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelJob.</param>
        /// 
        /// <returns>Returns a  CancelJobResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CancelJob">REST API Reference for CancelJob Operation</seealso>
        public virtual CancelJobResponse EndCancelJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelJobResponse>(asyncResult);
        }

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
        public virtual CreateJobResponse CreateJob(CreateJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;

            return Invoke<CreateJobResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginCreateJob(CreateJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJob.</param>
        /// 
        /// <returns>Returns a  CreateJobResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public virtual CreateJobResponse EndCreateJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateJobResponse>(asyncResult);
        }

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
        public virtual CreateJobTemplateResponse CreateJobTemplate(CreateJobTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateJobTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateJobTemplateResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginCreateJobTemplate(CreateJobTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateJobTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJobTemplate.</param>
        /// 
        /// <returns>Returns a  CreateJobTemplateResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CreateJobTemplate">REST API Reference for CreateJobTemplate Operation</seealso>
        public virtual CreateJobTemplateResponse EndCreateJobTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateJobTemplateResponse>(asyncResult);
        }

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
        public virtual CreatePresetResponse CreatePreset(CreatePresetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePresetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePresetResponseUnmarshaller.Instance;

            return Invoke<CreatePresetResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginCreatePreset(CreatePresetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePresetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePresetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePreset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePreset.</param>
        /// 
        /// <returns>Returns a  CreatePresetResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CreatePreset">REST API Reference for CreatePreset Operation</seealso>
        public virtual CreatePresetResponse EndCreatePreset(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePresetResponse>(asyncResult);
        }

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
        public virtual CreateQueueResponse CreateQueue(CreateQueueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQueueResponseUnmarshaller.Instance;

            return Invoke<CreateQueueResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginCreateQueue(CreateQueueRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQueueResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateQueue.</param>
        /// 
        /// <returns>Returns a  CreateQueueResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        public virtual CreateQueueResponse EndCreateQueue(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateQueueResponse>(asyncResult);
        }

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
        public virtual CreateResourceShareResponse CreateResourceShare(CreateResourceShareRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceShareResponseUnmarshaller.Instance;

            return Invoke<CreateResourceShareResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginCreateResourceShare(CreateResourceShareRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceShareResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResourceShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResourceShare.</param>
        /// 
        /// <returns>Returns a  CreateResourceShareResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/CreateResourceShare">REST API Reference for CreateResourceShare Operation</seealso>
        public virtual CreateResourceShareResponse EndCreateResourceShare(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateResourceShareResponse>(asyncResult);
        }

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
        public virtual DeleteJobTemplateResponse DeleteJobTemplate(DeleteJobTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteJobTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteJobTemplateResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDeleteJobTemplate(DeleteJobTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteJobTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteJobTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteJobTemplateResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DeleteJobTemplate">REST API Reference for DeleteJobTemplate Operation</seealso>
        public virtual DeleteJobTemplateResponse EndDeleteJobTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteJobTemplateResponse>(asyncResult);
        }

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
        public virtual DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDeletePolicy(DeletePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePolicy.</param>
        /// 
        /// <returns>Returns a  DeletePolicyResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual DeletePolicyResponse EndDeletePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePolicyResponse>(asyncResult);
        }

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
        public virtual DeletePresetResponse DeletePreset(DeletePresetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePresetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePresetResponseUnmarshaller.Instance;

            return Invoke<DeletePresetResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDeletePreset(DeletePresetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePresetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePresetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePreset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePreset.</param>
        /// 
        /// <returns>Returns a  DeletePresetResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DeletePreset">REST API Reference for DeletePreset Operation</seealso>
        public virtual DeletePresetResponse EndDeletePreset(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePresetResponse>(asyncResult);
        }

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
        public virtual DeleteQueueResponse DeleteQueue(DeleteQueueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueueResponseUnmarshaller.Instance;

            return Invoke<DeleteQueueResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDeleteQueue(DeleteQueueRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueueResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteQueue.</param>
        /// 
        /// <returns>Returns a  DeleteQueueResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DeleteQueue">REST API Reference for DeleteQueue Operation</seealso>
        public virtual DeleteQueueResponse EndDeleteQueue(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteQueueResponse>(asyncResult);
        }

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
        public virtual DescribeEndpointsResponse DescribeEndpoints(DescribeEndpointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointsResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointsResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDescribeEndpoints(DescribeEndpointsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEndpoints.</param>
        /// 
        /// <returns>Returns a  DescribeEndpointsResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DescribeEndpoints">REST API Reference for DescribeEndpoints Operation</seealso>
        [Obsolete("DescribeEndpoints and account specific endpoints are no longer required. We recommend that you send your requests directly to the regional endpoint instead.")]
        public virtual DescribeEndpointsResponse EndDescribeEndpoints(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEndpointsResponse>(asyncResult);
        }

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
        public virtual DisassociateCertificateResponse DisassociateCertificate(DisassociateCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateCertificateResponseUnmarshaller.Instance;

            return Invoke<DisassociateCertificateResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDisassociateCertificate(DisassociateCertificateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateCertificate.</param>
        /// 
        /// <returns>Returns a  DisassociateCertificateResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/DisassociateCertificate">REST API Reference for DisassociateCertificate Operation</seealso>
        public virtual DisassociateCertificateResponse EndDisassociateCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateCertificateResponse>(asyncResult);
        }

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
        public virtual GetJobResponse GetJob(GetJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;

            return Invoke<GetJobResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginGetJob(GetJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJob.</param>
        /// 
        /// <returns>Returns a  GetJobResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual GetJobResponse EndGetJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetJobResponse>(asyncResult);
        }

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
        public virtual GetJobTemplateResponse GetJobTemplate(GetJobTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJobTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobTemplateResponseUnmarshaller.Instance;

            return Invoke<GetJobTemplateResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginGetJobTemplate(GetJobTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJobTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJobTemplate.</param>
        /// 
        /// <returns>Returns a  GetJobTemplateResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/GetJobTemplate">REST API Reference for GetJobTemplate Operation</seealso>
        public virtual GetJobTemplateResponse EndGetJobTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetJobTemplateResponse>(asyncResult);
        }

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
        public virtual GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return Invoke<GetPolicyResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginGetPolicy(GetPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPolicy.</param>
        /// 
        /// <returns>Returns a  GetPolicyResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual GetPolicyResponse EndGetPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPolicyResponse>(asyncResult);
        }

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
        public virtual GetPresetResponse GetPreset(GetPresetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPresetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPresetResponseUnmarshaller.Instance;

            return Invoke<GetPresetResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginGetPreset(GetPresetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPresetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPresetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPreset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPreset.</param>
        /// 
        /// <returns>Returns a  GetPresetResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/GetPreset">REST API Reference for GetPreset Operation</seealso>
        public virtual GetPresetResponse EndGetPreset(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPresetResponse>(asyncResult);
        }

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
        public virtual GetQueueResponse GetQueue(GetQueueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueueResponseUnmarshaller.Instance;

            return Invoke<GetQueueResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginGetQueue(GetQueueRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueueResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQueue.</param>
        /// 
        /// <returns>Returns a  GetQueueResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/GetQueue">REST API Reference for GetQueue Operation</seealso>
        public virtual GetQueueResponse EndGetQueue(IAsyncResult asyncResult)
        {
            return EndInvoke<GetQueueResponse>(asyncResult);
        }

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
        public virtual ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginListJobs(ListJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobs.</param>
        /// 
        /// <returns>Returns a  ListJobsResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual ListJobsResponse EndListJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListJobsResponse>(asyncResult);
        }

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
        public virtual ListJobTemplatesResponse ListJobTemplates(ListJobTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListJobTemplatesResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginListJobTemplates(ListJobTemplatesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobTemplates.</param>
        /// 
        /// <returns>Returns a  ListJobTemplatesResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListJobTemplates">REST API Reference for ListJobTemplates Operation</seealso>
        public virtual ListJobTemplatesResponse EndListJobTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListJobTemplatesResponse>(asyncResult);
        }

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
        public virtual ListPresetsResponse ListPresets(ListPresetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPresetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPresetsResponseUnmarshaller.Instance;

            return Invoke<ListPresetsResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginListPresets(ListPresetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPresetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPresetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPresets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPresets.</param>
        /// 
        /// <returns>Returns a  ListPresetsResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListPresets">REST API Reference for ListPresets Operation</seealso>
        public virtual ListPresetsResponse EndListPresets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPresetsResponse>(asyncResult);
        }

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
        public virtual ListQueuesResponse ListQueues(ListQueuesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueuesResponseUnmarshaller.Instance;

            return Invoke<ListQueuesResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginListQueues(ListQueuesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueuesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListQueues operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQueues.</param>
        /// 
        /// <returns>Returns a  ListQueuesResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListQueues">REST API Reference for ListQueues Operation</seealso>
        public virtual ListQueuesResponse EndListQueues(IAsyncResult asyncResult)
        {
            return EndInvoke<ListQueuesResponse>(asyncResult);
        }

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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

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
        public virtual ListVersionsResponse ListVersions(ListVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVersionsResponseUnmarshaller.Instance;

            return Invoke<ListVersionsResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginListVersions(ListVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVersions.</param>
        /// 
        /// <returns>Returns a  ListVersionsResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/ListVersions">REST API Reference for ListVersions Operation</seealso>
        public virtual ListVersionsResponse EndListVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVersionsResponse>(asyncResult);
        }

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
        public virtual ProbeResponse Probe(ProbeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ProbeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ProbeResponseUnmarshaller.Instance;

            return Invoke<ProbeResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginProbe(ProbeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ProbeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ProbeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  Probe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginProbe.</param>
        /// 
        /// <returns>Returns a  ProbeResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/Probe">REST API Reference for Probe Operation</seealso>
        public virtual ProbeResponse EndProbe(IAsyncResult asyncResult)
        {
            return EndInvoke<ProbeResponse>(asyncResult);
        }

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
        public virtual PutPolicyResponse PutPolicy(PutPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPolicyResponseUnmarshaller.Instance;

            return Invoke<PutPolicyResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginPutPolicy(PutPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPolicy.</param>
        /// 
        /// <returns>Returns a  PutPolicyResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/PutPolicy">REST API Reference for PutPolicy Operation</seealso>
        public virtual PutPolicyResponse EndPutPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutPolicyResponse>(asyncResult);
        }

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
        public virtual SearchJobsResponse SearchJobs(SearchJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchJobsResponseUnmarshaller.Instance;

            return Invoke<SearchJobsResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginSearchJobs(SearchJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchJobs.</param>
        /// 
        /// <returns>Returns a  SearchJobsResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/SearchJobs">REST API Reference for SearchJobs Operation</seealso>
        public virtual SearchJobsResponse EndSearchJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchJobsResponse>(asyncResult);
        }

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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

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
        public virtual UpdateJobTemplateResponse UpdateJobTemplate(UpdateJobTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateJobTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateJobTemplateResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginUpdateJobTemplate(UpdateJobTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateJobTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateJobTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateJobTemplateResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/UpdateJobTemplate">REST API Reference for UpdateJobTemplate Operation</seealso>
        public virtual UpdateJobTemplateResponse EndUpdateJobTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateJobTemplateResponse>(asyncResult);
        }

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
        public virtual UpdatePresetResponse UpdatePreset(UpdatePresetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePresetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePresetResponseUnmarshaller.Instance;

            return Invoke<UpdatePresetResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginUpdatePreset(UpdatePresetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePresetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePresetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePreset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePreset.</param>
        /// 
        /// <returns>Returns a  UpdatePresetResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/UpdatePreset">REST API Reference for UpdatePreset Operation</seealso>
        public virtual UpdatePresetResponse EndUpdatePreset(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePresetResponse>(asyncResult);
        }

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
        public virtual UpdateQueueResponse UpdateQueue(UpdateQueueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueResponseUnmarshaller.Instance;

            return Invoke<UpdateQueueResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginUpdateQueue(UpdateQueueRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQueue.</param>
        /// 
        /// <returns>Returns a  UpdateQueueResult from MediaConvert.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconvert-2017-08-29/UpdateQueue">REST API Reference for UpdateQueue Operation</seealso>
        public virtual UpdateQueueResponse EndUpdateQueue(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateQueueResponse>(asyncResult);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonMediaConvertEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}