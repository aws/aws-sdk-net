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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MediaConvert.Model;
using Amazon.MediaConvert.Model.Internal.MarshallTransformations;
using Amazon.MediaConvert.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.MediaConvert
{
    /// <summary>
    /// Implementation for accessing MediaConvert
    ///
    /// AWS Elemental MediaConvert
    /// </summary>
    public partial class AmazonMediaConvertClient : AmazonServiceClient, IAmazonMediaConvert
    {
        private static IServiceMetadata serviceMetadata = new AmazonMediaConvertMetadata();
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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateCertificateResponseUnmarshaller.Instance;

            return Invoke<AssociateCertificateResponse>(request, options);
        }


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
        public virtual Task<AssociateCertificateResponse> AssociateCertificateAsync(AssociateCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateCertificateResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateCertificateResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobResponseUnmarshaller.Instance;

            return Invoke<CancelJobResponse>(request, options);
        }


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
        public virtual Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelJobResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;

            return Invoke<CreateJobResponse>(request, options);
        }


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
        public virtual Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateJobResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateJobTemplateResponse>(request, options);
        }


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
        public virtual Task<CreateJobTemplateResponse> CreateJobTemplateAsync(CreateJobTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateJobTemplateResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePresetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePresetResponseUnmarshaller.Instance;

            return Invoke<CreatePresetResponse>(request, options);
        }


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
        public virtual Task<CreatePresetResponse> CreatePresetAsync(CreatePresetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePresetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePresetResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePresetResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQueueResponseUnmarshaller.Instance;

            return Invoke<CreateQueueResponse>(request, options);
        }


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
        public virtual Task<CreateQueueResponse> CreateQueueAsync(CreateQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQueueResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateQueueResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteJobTemplateResponse>(request, options);
        }


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
        public virtual Task<DeleteJobTemplateResponse> DeleteJobTemplateAsync(DeleteJobTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteJobTemplateResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePresetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePresetResponseUnmarshaller.Instance;

            return Invoke<DeletePresetResponse>(request, options);
        }


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
        public virtual Task<DeletePresetResponse> DeletePresetAsync(DeletePresetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePresetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePresetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePresetResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueueResponseUnmarshaller.Instance;

            return Invoke<DeleteQueueResponse>(request, options);
        }


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
        public virtual Task<DeleteQueueResponse> DeleteQueueAsync(DeleteQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueueResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteQueueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEndpoints


        /// <summary>
        /// Send an request with an empty body to the regional API endpoint to get your account
        /// API endpoint.
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
        public virtual DescribeEndpointsResponse DescribeEndpoints(DescribeEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointsResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointsResponse>(request, options);
        }


        /// <summary>
        /// Send an request with an empty body to the regional API endpoint to get your account
        /// API endpoint.
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
        public virtual Task<DescribeEndpointsResponse> DescribeEndpointsAsync(DescribeEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEndpointsResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateCertificateResponseUnmarshaller.Instance;

            return Invoke<DisassociateCertificateResponse>(request, options);
        }


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
        public virtual Task<DisassociateCertificateResponse> DisassociateCertificateAsync(DisassociateCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateCertificateResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetJob


        /// <summary>
        /// Retrieve the JSON for a specific completed transcoding job.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;

            return Invoke<GetJobResponse>(request, options);
        }


        /// <summary>
        /// Retrieve the JSON for a specific completed transcoding job.
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
        public virtual Task<GetJobResponse> GetJobAsync(GetJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetJobResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobTemplateResponseUnmarshaller.Instance;

            return Invoke<GetJobTemplateResponse>(request, options);
        }


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
        public virtual Task<GetJobTemplateResponse> GetJobTemplateAsync(GetJobTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetJobTemplateResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPresetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPresetResponseUnmarshaller.Instance;

            return Invoke<GetPresetResponse>(request, options);
        }


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
        public virtual Task<GetPresetResponse> GetPresetAsync(GetPresetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPresetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPresetResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPresetResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueueResponseUnmarshaller.Instance;

            return Invoke<GetQueueResponse>(request, options);
        }


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
        public virtual Task<GetQueueResponse> GetQueueAsync(GetQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueueResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetQueueResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsResponse>(request, options);
        }


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
        public virtual Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListJobsResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListJobTemplatesResponse>(request, options);
        }


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
        public virtual Task<ListJobTemplatesResponse> ListJobTemplatesAsync(ListJobTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobTemplatesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListJobTemplatesResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPresetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPresetsResponseUnmarshaller.Instance;

            return Invoke<ListPresetsResponse>(request, options);
        }


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
        public virtual Task<ListPresetsResponse> ListPresetsAsync(ListPresetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPresetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPresetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPresetsResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueuesResponseUnmarshaller.Instance;

            return Invoke<ListQueuesResponse>(request, options);
        }


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
        public virtual Task<ListQueuesResponse> ListQueuesAsync(ListQueuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueuesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListQueuesResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateJobTemplateResponse>(request, options);
        }


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
        public virtual Task<UpdateJobTemplateResponse> UpdateJobTemplateAsync(UpdateJobTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateJobTemplateResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePresetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePresetResponseUnmarshaller.Instance;

            return Invoke<UpdatePresetResponse>(request, options);
        }


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
        public virtual Task<UpdatePresetResponse> UpdatePresetAsync(UpdatePresetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePresetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePresetResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePresetResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueResponseUnmarshaller.Instance;

            return Invoke<UpdateQueueResponse>(request, options);
        }


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
        public virtual Task<UpdateQueueResponse> UpdateQueueAsync(UpdateQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateQueueResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}