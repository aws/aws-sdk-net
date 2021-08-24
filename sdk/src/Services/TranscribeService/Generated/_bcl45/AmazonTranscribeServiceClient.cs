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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.TranscribeService.Model;
using Amazon.TranscribeService.Model.Internal.MarshallTransformations;
using Amazon.TranscribeService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.TranscribeService
{
    /// <summary>
    /// Implementation for accessing TranscribeService
    ///
    /// Operations and objects for transcribing speech to text.
    /// </summary>
    public partial class AmazonTranscribeServiceClient : AmazonServiceClient, IAmazonTranscribeService
    {
        private static IServiceMetadata serviceMetadata = new AmazonTranscribeServiceMetadata();
        private ITranscribeServicePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ITranscribeServicePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new TranscribeServicePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with the credentials loaded from the application's
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
        public AmazonTranscribeServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTranscribeServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with the credentials loaded from the application's
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
        public AmazonTranscribeServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTranscribeServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonTranscribeServiceClient Configuration Object</param>
        public AmazonTranscribeServiceClient(AmazonTranscribeServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonTranscribeServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonTranscribeServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTranscribeServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonTranscribeServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Credentials and an
        /// AmazonTranscribeServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonTranscribeServiceClient Configuration Object</param>
        public AmazonTranscribeServiceClient(AWSCredentials credentials, AmazonTranscribeServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonTranscribeServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTranscribeServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTranscribeServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTranscribeServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTranscribeServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonTranscribeServiceClient Configuration Object</param>
        public AmazonTranscribeServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonTranscribeServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonTranscribeServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTranscribeServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTranscribeServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTranscribeServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTranscribeServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTranscribeServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonTranscribeServiceClient Configuration Object</param>
        public AmazonTranscribeServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonTranscribeServiceConfig clientConfig)
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


        #region  CreateCallAnalyticsCategory


        /// <summary>
        /// Creates an analytics category. Amazon Transcribe applies the conditions specified
        /// by your analytics categories to your call analytics jobs. For each analytics category,
        /// you specify one or more rules. For example, you can specify a rule that the customer
        /// sentiment was neutral or negative within that category. If you start a call analytics
        /// job, Amazon Transcribe applies the category to the analytics job that you've specified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCallAnalyticsCategory service method.</param>
        /// 
        /// <returns>The response from the CreateCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateCallAnalyticsCategory">REST API Reference for CreateCallAnalyticsCategory Operation</seealso>
        public virtual CreateCallAnalyticsCategoryResponse CreateCallAnalyticsCategory(CreateCallAnalyticsCategoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCallAnalyticsCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCallAnalyticsCategoryResponseUnmarshaller.Instance;

            return Invoke<CreateCallAnalyticsCategoryResponse>(request, options);
        }


        /// <summary>
        /// Creates an analytics category. Amazon Transcribe applies the conditions specified
        /// by your analytics categories to your call analytics jobs. For each analytics category,
        /// you specify one or more rules. For example, you can specify a rule that the customer
        /// sentiment was neutral or negative within that category. If you start a call analytics
        /// job, Amazon Transcribe applies the category to the analytics job that you've specified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCallAnalyticsCategory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateCallAnalyticsCategory">REST API Reference for CreateCallAnalyticsCategory Operation</seealso>
        public virtual Task<CreateCallAnalyticsCategoryResponse> CreateCallAnalyticsCategoryAsync(CreateCallAnalyticsCategoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCallAnalyticsCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCallAnalyticsCategoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateCallAnalyticsCategoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLanguageModel


        /// <summary>
        /// Creates a new custom language model. Use Amazon S3 prefixes to provide the location
        /// of your input files. The time it takes to create your model depends on the size of
        /// your training data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLanguageModel service method.</param>
        /// 
        /// <returns>The response from the CreateLanguageModel service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateLanguageModel">REST API Reference for CreateLanguageModel Operation</seealso>
        public virtual CreateLanguageModelResponse CreateLanguageModel(CreateLanguageModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLanguageModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLanguageModelResponseUnmarshaller.Instance;

            return Invoke<CreateLanguageModelResponse>(request, options);
        }


        /// <summary>
        /// Creates a new custom language model. Use Amazon S3 prefixes to provide the location
        /// of your input files. The time it takes to create your model depends on the size of
        /// your training data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLanguageModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLanguageModel service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateLanguageModel">REST API Reference for CreateLanguageModel Operation</seealso>
        public virtual Task<CreateLanguageModelResponse> CreateLanguageModelAsync(CreateLanguageModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLanguageModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLanguageModelResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateLanguageModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMedicalVocabulary


        /// <summary>
        /// Creates a new custom vocabulary that you can use to modify how Amazon Transcribe Medical
        /// transcribes your audio file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMedicalVocabulary service method.</param>
        /// 
        /// <returns>The response from the CreateMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateMedicalVocabulary">REST API Reference for CreateMedicalVocabulary Operation</seealso>
        public virtual CreateMedicalVocabularyResponse CreateMedicalVocabulary(CreateMedicalVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMedicalVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMedicalVocabularyResponseUnmarshaller.Instance;

            return Invoke<CreateMedicalVocabularyResponse>(request, options);
        }


        /// <summary>
        /// Creates a new custom vocabulary that you can use to modify how Amazon Transcribe Medical
        /// transcribes your audio file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMedicalVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateMedicalVocabulary">REST API Reference for CreateMedicalVocabulary Operation</seealso>
        public virtual Task<CreateMedicalVocabularyResponse> CreateMedicalVocabularyAsync(CreateMedicalVocabularyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMedicalVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMedicalVocabularyResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateMedicalVocabularyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVocabulary


        /// <summary>
        /// Creates a new custom vocabulary that you can use to change the way Amazon Transcribe
        /// handles transcription of an audio file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVocabulary service method.</param>
        /// 
        /// <returns>The response from the CreateVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateVocabulary">REST API Reference for CreateVocabulary Operation</seealso>
        public virtual CreateVocabularyResponse CreateVocabulary(CreateVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVocabularyResponseUnmarshaller.Instance;

            return Invoke<CreateVocabularyResponse>(request, options);
        }


        /// <summary>
        /// Creates a new custom vocabulary that you can use to change the way Amazon Transcribe
        /// handles transcription of an audio file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateVocabulary">REST API Reference for CreateVocabulary Operation</seealso>
        public virtual Task<CreateVocabularyResponse> CreateVocabularyAsync(CreateVocabularyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVocabularyResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateVocabularyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVocabularyFilter


        /// <summary>
        /// Creates a new vocabulary filter that you can use to filter words, such as profane
        /// words, from the output of a transcription job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVocabularyFilter service method.</param>
        /// 
        /// <returns>The response from the CreateVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateVocabularyFilter">REST API Reference for CreateVocabularyFilter Operation</seealso>
        public virtual CreateVocabularyFilterResponse CreateVocabularyFilter(CreateVocabularyFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVocabularyFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVocabularyFilterResponseUnmarshaller.Instance;

            return Invoke<CreateVocabularyFilterResponse>(request, options);
        }


        /// <summary>
        /// Creates a new vocabulary filter that you can use to filter words, such as profane
        /// words, from the output of a transcription job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVocabularyFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateVocabularyFilter">REST API Reference for CreateVocabularyFilter Operation</seealso>
        public virtual Task<CreateVocabularyFilterResponse> CreateVocabularyFilterAsync(CreateVocabularyFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVocabularyFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVocabularyFilterResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateVocabularyFilterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCallAnalyticsCategory


        /// <summary>
        /// Deletes a call analytics category using its name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCallAnalyticsCategory service method.</param>
        /// 
        /// <returns>The response from the DeleteCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteCallAnalyticsCategory">REST API Reference for DeleteCallAnalyticsCategory Operation</seealso>
        public virtual DeleteCallAnalyticsCategoryResponse DeleteCallAnalyticsCategory(DeleteCallAnalyticsCategoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCallAnalyticsCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCallAnalyticsCategoryResponseUnmarshaller.Instance;

            return Invoke<DeleteCallAnalyticsCategoryResponse>(request, options);
        }


        /// <summary>
        /// Deletes a call analytics category using its name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCallAnalyticsCategory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteCallAnalyticsCategory">REST API Reference for DeleteCallAnalyticsCategory Operation</seealso>
        public virtual Task<DeleteCallAnalyticsCategoryResponse> DeleteCallAnalyticsCategoryAsync(DeleteCallAnalyticsCategoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCallAnalyticsCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCallAnalyticsCategoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCallAnalyticsCategoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCallAnalyticsJob


        /// <summary>
        /// Deletes a call analytics job using its name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCallAnalyticsJob service method.</param>
        /// 
        /// <returns>The response from the DeleteCallAnalyticsJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteCallAnalyticsJob">REST API Reference for DeleteCallAnalyticsJob Operation</seealso>
        public virtual DeleteCallAnalyticsJobResponse DeleteCallAnalyticsJob(DeleteCallAnalyticsJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCallAnalyticsJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCallAnalyticsJobResponseUnmarshaller.Instance;

            return Invoke<DeleteCallAnalyticsJobResponse>(request, options);
        }


        /// <summary>
        /// Deletes a call analytics job using its name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCallAnalyticsJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCallAnalyticsJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteCallAnalyticsJob">REST API Reference for DeleteCallAnalyticsJob Operation</seealso>
        public virtual Task<DeleteCallAnalyticsJobResponse> DeleteCallAnalyticsJobAsync(DeleteCallAnalyticsJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCallAnalyticsJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCallAnalyticsJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCallAnalyticsJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLanguageModel


        /// <summary>
        /// Deletes a custom language model using its name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLanguageModel service method.</param>
        /// 
        /// <returns>The response from the DeleteLanguageModel service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteLanguageModel">REST API Reference for DeleteLanguageModel Operation</seealso>
        public virtual DeleteLanguageModelResponse DeleteLanguageModel(DeleteLanguageModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLanguageModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLanguageModelResponseUnmarshaller.Instance;

            return Invoke<DeleteLanguageModelResponse>(request, options);
        }


        /// <summary>
        /// Deletes a custom language model using its name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLanguageModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLanguageModel service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteLanguageModel">REST API Reference for DeleteLanguageModel Operation</seealso>
        public virtual Task<DeleteLanguageModelResponse> DeleteLanguageModelAsync(DeleteLanguageModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLanguageModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLanguageModelResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteLanguageModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMedicalTranscriptionJob


        /// <summary>
        /// Deletes a transcription job generated by Amazon Transcribe Medical and any related
        /// information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMedicalTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the DeleteMedicalTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteMedicalTranscriptionJob">REST API Reference for DeleteMedicalTranscriptionJob Operation</seealso>
        public virtual DeleteMedicalTranscriptionJobResponse DeleteMedicalTranscriptionJob(DeleteMedicalTranscriptionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMedicalTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMedicalTranscriptionJobResponseUnmarshaller.Instance;

            return Invoke<DeleteMedicalTranscriptionJobResponse>(request, options);
        }


        /// <summary>
        /// Deletes a transcription job generated by Amazon Transcribe Medical and any related
        /// information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMedicalTranscriptionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMedicalTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteMedicalTranscriptionJob">REST API Reference for DeleteMedicalTranscriptionJob Operation</seealso>
        public virtual Task<DeleteMedicalTranscriptionJobResponse> DeleteMedicalTranscriptionJobAsync(DeleteMedicalTranscriptionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMedicalTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMedicalTranscriptionJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteMedicalTranscriptionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMedicalVocabulary


        /// <summary>
        /// Deletes a vocabulary from Amazon Transcribe Medical.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMedicalVocabulary service method.</param>
        /// 
        /// <returns>The response from the DeleteMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteMedicalVocabulary">REST API Reference for DeleteMedicalVocabulary Operation</seealso>
        public virtual DeleteMedicalVocabularyResponse DeleteMedicalVocabulary(DeleteMedicalVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMedicalVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMedicalVocabularyResponseUnmarshaller.Instance;

            return Invoke<DeleteMedicalVocabularyResponse>(request, options);
        }


        /// <summary>
        /// Deletes a vocabulary from Amazon Transcribe Medical.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMedicalVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteMedicalVocabulary">REST API Reference for DeleteMedicalVocabulary Operation</seealso>
        public virtual Task<DeleteMedicalVocabularyResponse> DeleteMedicalVocabularyAsync(DeleteMedicalVocabularyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMedicalVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMedicalVocabularyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteMedicalVocabularyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTranscriptionJob


        /// <summary>
        /// Deletes a previously submitted transcription job along with any other generated results
        /// such as the transcription, models, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the DeleteTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteTranscriptionJob">REST API Reference for DeleteTranscriptionJob Operation</seealso>
        public virtual DeleteTranscriptionJobResponse DeleteTranscriptionJob(DeleteTranscriptionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTranscriptionJobResponseUnmarshaller.Instance;

            return Invoke<DeleteTranscriptionJobResponse>(request, options);
        }


        /// <summary>
        /// Deletes a previously submitted transcription job along with any other generated results
        /// such as the transcription, models, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTranscriptionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteTranscriptionJob">REST API Reference for DeleteTranscriptionJob Operation</seealso>
        public virtual Task<DeleteTranscriptionJobResponse> DeleteTranscriptionJobAsync(DeleteTranscriptionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTranscriptionJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteTranscriptionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVocabulary


        /// <summary>
        /// Deletes a vocabulary from Amazon Transcribe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVocabulary service method.</param>
        /// 
        /// <returns>The response from the DeleteVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteVocabulary">REST API Reference for DeleteVocabulary Operation</seealso>
        public virtual DeleteVocabularyResponse DeleteVocabulary(DeleteVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVocabularyResponseUnmarshaller.Instance;

            return Invoke<DeleteVocabularyResponse>(request, options);
        }


        /// <summary>
        /// Deletes a vocabulary from Amazon Transcribe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteVocabulary">REST API Reference for DeleteVocabulary Operation</seealso>
        public virtual Task<DeleteVocabularyResponse> DeleteVocabularyAsync(DeleteVocabularyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVocabularyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteVocabularyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVocabularyFilter


        /// <summary>
        /// Removes a vocabulary filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVocabularyFilter service method.</param>
        /// 
        /// <returns>The response from the DeleteVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteVocabularyFilter">REST API Reference for DeleteVocabularyFilter Operation</seealso>
        public virtual DeleteVocabularyFilterResponse DeleteVocabularyFilter(DeleteVocabularyFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVocabularyFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVocabularyFilterResponseUnmarshaller.Instance;

            return Invoke<DeleteVocabularyFilterResponse>(request, options);
        }


        /// <summary>
        /// Removes a vocabulary filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVocabularyFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteVocabularyFilter">REST API Reference for DeleteVocabularyFilter Operation</seealso>
        public virtual Task<DeleteVocabularyFilterResponse> DeleteVocabularyFilterAsync(DeleteVocabularyFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVocabularyFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVocabularyFilterResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteVocabularyFilterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLanguageModel


        /// <summary>
        /// Gets information about a single custom language model. Use this information to see
        /// details about the language model in your Amazon Web Services account. You can also
        /// see whether the base language model used to create your custom language model has
        /// been updated. If Amazon Transcribe has updated the base model, you can create a new
        /// custom language model using the updated base model. If the language model wasn't created,
        /// you can use this operation to understand why Amazon Transcribe couldn't create it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLanguageModel service method.</param>
        /// 
        /// <returns>The response from the DescribeLanguageModel service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DescribeLanguageModel">REST API Reference for DescribeLanguageModel Operation</seealso>
        public virtual DescribeLanguageModelResponse DescribeLanguageModel(DescribeLanguageModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLanguageModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLanguageModelResponseUnmarshaller.Instance;

            return Invoke<DescribeLanguageModelResponse>(request, options);
        }


        /// <summary>
        /// Gets information about a single custom language model. Use this information to see
        /// details about the language model in your Amazon Web Services account. You can also
        /// see whether the base language model used to create your custom language model has
        /// been updated. If Amazon Transcribe has updated the base model, you can create a new
        /// custom language model using the updated base model. If the language model wasn't created,
        /// you can use this operation to understand why Amazon Transcribe couldn't create it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLanguageModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLanguageModel service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DescribeLanguageModel">REST API Reference for DescribeLanguageModel Operation</seealso>
        public virtual Task<DescribeLanguageModelResponse> DescribeLanguageModelAsync(DescribeLanguageModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLanguageModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLanguageModelResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeLanguageModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCallAnalyticsCategory


        /// <summary>
        /// Retrieves information about a call analytics category.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCallAnalyticsCategory service method.</param>
        /// 
        /// <returns>The response from the GetCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetCallAnalyticsCategory">REST API Reference for GetCallAnalyticsCategory Operation</seealso>
        public virtual GetCallAnalyticsCategoryResponse GetCallAnalyticsCategory(GetCallAnalyticsCategoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCallAnalyticsCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCallAnalyticsCategoryResponseUnmarshaller.Instance;

            return Invoke<GetCallAnalyticsCategoryResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about a call analytics category.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCallAnalyticsCategory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetCallAnalyticsCategory">REST API Reference for GetCallAnalyticsCategory Operation</seealso>
        public virtual Task<GetCallAnalyticsCategoryResponse> GetCallAnalyticsCategoryAsync(GetCallAnalyticsCategoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCallAnalyticsCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCallAnalyticsCategoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCallAnalyticsCategoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCallAnalyticsJob


        /// <summary>
        /// Returns information about a call analytics job. To see the status of the job, check
        /// the <code>CallAnalyticsJobStatus</code> field. If the status is <code>COMPLETED</code>,
        /// the job is finished and you can find the results at the location specified in the
        /// <code>TranscriptFileUri</code> field. If you enable personally identifiable information
        /// (PII) redaction, the redacted transcript appears in the <code>RedactedTranscriptFileUri</code>
        /// field.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCallAnalyticsJob service method.</param>
        /// 
        /// <returns>The response from the GetCallAnalyticsJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetCallAnalyticsJob">REST API Reference for GetCallAnalyticsJob Operation</seealso>
        public virtual GetCallAnalyticsJobResponse GetCallAnalyticsJob(GetCallAnalyticsJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCallAnalyticsJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCallAnalyticsJobResponseUnmarshaller.Instance;

            return Invoke<GetCallAnalyticsJobResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a call analytics job. To see the status of the job, check
        /// the <code>CallAnalyticsJobStatus</code> field. If the status is <code>COMPLETED</code>,
        /// the job is finished and you can find the results at the location specified in the
        /// <code>TranscriptFileUri</code> field. If you enable personally identifiable information
        /// (PII) redaction, the redacted transcript appears in the <code>RedactedTranscriptFileUri</code>
        /// field.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCallAnalyticsJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCallAnalyticsJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetCallAnalyticsJob">REST API Reference for GetCallAnalyticsJob Operation</seealso>
        public virtual Task<GetCallAnalyticsJobResponse> GetCallAnalyticsJobAsync(GetCallAnalyticsJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCallAnalyticsJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCallAnalyticsJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCallAnalyticsJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMedicalTranscriptionJob


        /// <summary>
        /// Returns information about a transcription job from Amazon Transcribe Medical. To see
        /// the status of the job, check the <code>TranscriptionJobStatus</code> field. If the
        /// status is <code>COMPLETED</code>, the job is finished. You find the results of the
        /// completed job in the <code>TranscriptFileUri</code> field.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the GetMedicalTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetMedicalTranscriptionJob">REST API Reference for GetMedicalTranscriptionJob Operation</seealso>
        public virtual GetMedicalTranscriptionJobResponse GetMedicalTranscriptionJob(GetMedicalTranscriptionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMedicalTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMedicalTranscriptionJobResponseUnmarshaller.Instance;

            return Invoke<GetMedicalTranscriptionJobResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a transcription job from Amazon Transcribe Medical. To see
        /// the status of the job, check the <code>TranscriptionJobStatus</code> field. If the
        /// status is <code>COMPLETED</code>, the job is finished. You find the results of the
        /// completed job in the <code>TranscriptFileUri</code> field.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalTranscriptionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMedicalTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetMedicalTranscriptionJob">REST API Reference for GetMedicalTranscriptionJob Operation</seealso>
        public virtual Task<GetMedicalTranscriptionJobResponse> GetMedicalTranscriptionJobAsync(GetMedicalTranscriptionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMedicalTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMedicalTranscriptionJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMedicalTranscriptionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMedicalVocabulary


        /// <summary>
        /// Retrieves information about a medical vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalVocabulary service method.</param>
        /// 
        /// <returns>The response from the GetMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetMedicalVocabulary">REST API Reference for GetMedicalVocabulary Operation</seealso>
        public virtual GetMedicalVocabularyResponse GetMedicalVocabulary(GetMedicalVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMedicalVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMedicalVocabularyResponseUnmarshaller.Instance;

            return Invoke<GetMedicalVocabularyResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about a medical vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetMedicalVocabulary">REST API Reference for GetMedicalVocabulary Operation</seealso>
        public virtual Task<GetMedicalVocabularyResponse> GetMedicalVocabularyAsync(GetMedicalVocabularyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMedicalVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMedicalVocabularyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMedicalVocabularyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTranscriptionJob


        /// <summary>
        /// Returns information about a transcription job. To see the status of the job, check
        /// the <code>TranscriptionJobStatus</code> field. If the status is <code>COMPLETED</code>,
        /// the job is finished and you can find the results at the location specified in the
        /// <code>TranscriptFileUri</code> field. If you enable content redaction, the redacted
        /// transcript appears in <code>RedactedTranscriptFileUri</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the GetTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetTranscriptionJob">REST API Reference for GetTranscriptionJob Operation</seealso>
        public virtual GetTranscriptionJobResponse GetTranscriptionJob(GetTranscriptionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTranscriptionJobResponseUnmarshaller.Instance;

            return Invoke<GetTranscriptionJobResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a transcription job. To see the status of the job, check
        /// the <code>TranscriptionJobStatus</code> field. If the status is <code>COMPLETED</code>,
        /// the job is finished and you can find the results at the location specified in the
        /// <code>TranscriptFileUri</code> field. If you enable content redaction, the redacted
        /// transcript appears in <code>RedactedTranscriptFileUri</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTranscriptionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetTranscriptionJob">REST API Reference for GetTranscriptionJob Operation</seealso>
        public virtual Task<GetTranscriptionJobResponse> GetTranscriptionJobAsync(GetTranscriptionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTranscriptionJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetTranscriptionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetVocabulary


        /// <summary>
        /// Gets information about a vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVocabulary service method.</param>
        /// 
        /// <returns>The response from the GetVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetVocabulary">REST API Reference for GetVocabulary Operation</seealso>
        public virtual GetVocabularyResponse GetVocabulary(GetVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVocabularyResponseUnmarshaller.Instance;

            return Invoke<GetVocabularyResponse>(request, options);
        }


        /// <summary>
        /// Gets information about a vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetVocabulary">REST API Reference for GetVocabulary Operation</seealso>
        public virtual Task<GetVocabularyResponse> GetVocabularyAsync(GetVocabularyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVocabularyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetVocabularyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetVocabularyFilter


        /// <summary>
        /// Returns information about a vocabulary filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVocabularyFilter service method.</param>
        /// 
        /// <returns>The response from the GetVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetVocabularyFilter">REST API Reference for GetVocabularyFilter Operation</seealso>
        public virtual GetVocabularyFilterResponse GetVocabularyFilter(GetVocabularyFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVocabularyFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVocabularyFilterResponseUnmarshaller.Instance;

            return Invoke<GetVocabularyFilterResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a vocabulary filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVocabularyFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetVocabularyFilter">REST API Reference for GetVocabularyFilter Operation</seealso>
        public virtual Task<GetVocabularyFilterResponse> GetVocabularyFilterAsync(GetVocabularyFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVocabularyFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVocabularyFilterResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetVocabularyFilterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCallAnalyticsCategories


        /// <summary>
        /// Provides more information about the call analytics categories that you've created.
        /// You can use the information in this list to find a specific category. You can then
        /// use the operation to get more information about it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCallAnalyticsCategories service method.</param>
        /// 
        /// <returns>The response from the ListCallAnalyticsCategories service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListCallAnalyticsCategories">REST API Reference for ListCallAnalyticsCategories Operation</seealso>
        public virtual ListCallAnalyticsCategoriesResponse ListCallAnalyticsCategories(ListCallAnalyticsCategoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCallAnalyticsCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCallAnalyticsCategoriesResponseUnmarshaller.Instance;

            return Invoke<ListCallAnalyticsCategoriesResponse>(request, options);
        }


        /// <summary>
        /// Provides more information about the call analytics categories that you've created.
        /// You can use the information in this list to find a specific category. You can then
        /// use the operation to get more information about it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCallAnalyticsCategories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCallAnalyticsCategories service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListCallAnalyticsCategories">REST API Reference for ListCallAnalyticsCategories Operation</seealso>
        public virtual Task<ListCallAnalyticsCategoriesResponse> ListCallAnalyticsCategoriesAsync(ListCallAnalyticsCategoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCallAnalyticsCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCallAnalyticsCategoriesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCallAnalyticsCategoriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCallAnalyticsJobs


        /// <summary>
        /// List call analytics jobs with a specified status or substring that matches their names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCallAnalyticsJobs service method.</param>
        /// 
        /// <returns>The response from the ListCallAnalyticsJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListCallAnalyticsJobs">REST API Reference for ListCallAnalyticsJobs Operation</seealso>
        public virtual ListCallAnalyticsJobsResponse ListCallAnalyticsJobs(ListCallAnalyticsJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCallAnalyticsJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCallAnalyticsJobsResponseUnmarshaller.Instance;

            return Invoke<ListCallAnalyticsJobsResponse>(request, options);
        }


        /// <summary>
        /// List call analytics jobs with a specified status or substring that matches their names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCallAnalyticsJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCallAnalyticsJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListCallAnalyticsJobs">REST API Reference for ListCallAnalyticsJobs Operation</seealso>
        public virtual Task<ListCallAnalyticsJobsResponse> ListCallAnalyticsJobsAsync(ListCallAnalyticsJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCallAnalyticsJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCallAnalyticsJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCallAnalyticsJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLanguageModels


        /// <summary>
        /// Provides more information about the custom language models you've created. You can
        /// use the information in this list to find a specific custom language model. You can
        /// then use the operation to get more information about it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLanguageModels service method.</param>
        /// 
        /// <returns>The response from the ListLanguageModels service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListLanguageModels">REST API Reference for ListLanguageModels Operation</seealso>
        public virtual ListLanguageModelsResponse ListLanguageModels(ListLanguageModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLanguageModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLanguageModelsResponseUnmarshaller.Instance;

            return Invoke<ListLanguageModelsResponse>(request, options);
        }


        /// <summary>
        /// Provides more information about the custom language models you've created. You can
        /// use the information in this list to find a specific custom language model. You can
        /// then use the operation to get more information about it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLanguageModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLanguageModels service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListLanguageModels">REST API Reference for ListLanguageModels Operation</seealso>
        public virtual Task<ListLanguageModelsResponse> ListLanguageModelsAsync(ListLanguageModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLanguageModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLanguageModelsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListLanguageModelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMedicalTranscriptionJobs


        /// <summary>
        /// Lists medical transcription jobs with a specified status or substring that matches
        /// their names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMedicalTranscriptionJobs service method.</param>
        /// 
        /// <returns>The response from the ListMedicalTranscriptionJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListMedicalTranscriptionJobs">REST API Reference for ListMedicalTranscriptionJobs Operation</seealso>
        public virtual ListMedicalTranscriptionJobsResponse ListMedicalTranscriptionJobs(ListMedicalTranscriptionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMedicalTranscriptionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMedicalTranscriptionJobsResponseUnmarshaller.Instance;

            return Invoke<ListMedicalTranscriptionJobsResponse>(request, options);
        }


        /// <summary>
        /// Lists medical transcription jobs with a specified status or substring that matches
        /// their names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMedicalTranscriptionJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMedicalTranscriptionJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListMedicalTranscriptionJobs">REST API Reference for ListMedicalTranscriptionJobs Operation</seealso>
        public virtual Task<ListMedicalTranscriptionJobsResponse> ListMedicalTranscriptionJobsAsync(ListMedicalTranscriptionJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMedicalTranscriptionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMedicalTranscriptionJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMedicalTranscriptionJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMedicalVocabularies


        /// <summary>
        /// Returns a list of vocabularies that match the specified criteria. If you don't enter
        /// a value in any of the request parameters, returns the entire list of vocabularies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMedicalVocabularies service method.</param>
        /// 
        /// <returns>The response from the ListMedicalVocabularies service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListMedicalVocabularies">REST API Reference for ListMedicalVocabularies Operation</seealso>
        public virtual ListMedicalVocabulariesResponse ListMedicalVocabularies(ListMedicalVocabulariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMedicalVocabulariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMedicalVocabulariesResponseUnmarshaller.Instance;

            return Invoke<ListMedicalVocabulariesResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of vocabularies that match the specified criteria. If you don't enter
        /// a value in any of the request parameters, returns the entire list of vocabularies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMedicalVocabularies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMedicalVocabularies service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListMedicalVocabularies">REST API Reference for ListMedicalVocabularies Operation</seealso>
        public virtual Task<ListMedicalVocabulariesResponse> ListMedicalVocabulariesAsync(ListMedicalVocabulariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMedicalVocabulariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMedicalVocabulariesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMedicalVocabulariesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags associated with a given transcription job, vocabulary, or resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists all tags associated with a given transcription job, vocabulary, or resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTranscriptionJobs


        /// <summary>
        /// Lists transcription jobs with the specified status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTranscriptionJobs service method.</param>
        /// 
        /// <returns>The response from the ListTranscriptionJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListTranscriptionJobs">REST API Reference for ListTranscriptionJobs Operation</seealso>
        public virtual ListTranscriptionJobsResponse ListTranscriptionJobs(ListTranscriptionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTranscriptionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTranscriptionJobsResponseUnmarshaller.Instance;

            return Invoke<ListTranscriptionJobsResponse>(request, options);
        }


        /// <summary>
        /// Lists transcription jobs with the specified status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTranscriptionJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTranscriptionJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListTranscriptionJobs">REST API Reference for ListTranscriptionJobs Operation</seealso>
        public virtual Task<ListTranscriptionJobsResponse> ListTranscriptionJobsAsync(ListTranscriptionJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTranscriptionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTranscriptionJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTranscriptionJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVocabularies


        /// <summary>
        /// Returns a list of vocabularies that match the specified criteria. If no criteria are
        /// specified, returns the entire list of vocabularies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVocabularies service method.</param>
        /// 
        /// <returns>The response from the ListVocabularies service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListVocabularies">REST API Reference for ListVocabularies Operation</seealso>
        public virtual ListVocabulariesResponse ListVocabularies(ListVocabulariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVocabulariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVocabulariesResponseUnmarshaller.Instance;

            return Invoke<ListVocabulariesResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of vocabularies that match the specified criteria. If no criteria are
        /// specified, returns the entire list of vocabularies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVocabularies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVocabularies service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListVocabularies">REST API Reference for ListVocabularies Operation</seealso>
        public virtual Task<ListVocabulariesResponse> ListVocabulariesAsync(ListVocabulariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVocabulariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVocabulariesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListVocabulariesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVocabularyFilters


        /// <summary>
        /// Gets information about vocabulary filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVocabularyFilters service method.</param>
        /// 
        /// <returns>The response from the ListVocabularyFilters service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListVocabularyFilters">REST API Reference for ListVocabularyFilters Operation</seealso>
        public virtual ListVocabularyFiltersResponse ListVocabularyFilters(ListVocabularyFiltersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVocabularyFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVocabularyFiltersResponseUnmarshaller.Instance;

            return Invoke<ListVocabularyFiltersResponse>(request, options);
        }


        /// <summary>
        /// Gets information about vocabulary filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVocabularyFilters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVocabularyFilters service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListVocabularyFilters">REST API Reference for ListVocabularyFilters Operation</seealso>
        public virtual Task<ListVocabularyFiltersResponse> ListVocabularyFiltersAsync(ListVocabularyFiltersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVocabularyFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVocabularyFiltersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListVocabularyFiltersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartCallAnalyticsJob


        /// <summary>
        /// Starts an asynchronous analytics job that not only transcribes the audio recording
        /// of a caller and agent, but also returns additional insights. These insights include
        /// how quickly or loudly the caller or agent was speaking. To retrieve additional insights
        /// with your analytics jobs, create categories. A category is a way to classify analytics
        /// jobs based on attributes, such as a customer's sentiment or a particular phrase being
        /// used during the call. For more information, see the operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCallAnalyticsJob service method.</param>
        /// 
        /// <returns>The response from the StartCallAnalyticsJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartCallAnalyticsJob">REST API Reference for StartCallAnalyticsJob Operation</seealso>
        public virtual StartCallAnalyticsJobResponse StartCallAnalyticsJob(StartCallAnalyticsJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCallAnalyticsJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCallAnalyticsJobResponseUnmarshaller.Instance;

            return Invoke<StartCallAnalyticsJobResponse>(request, options);
        }


        /// <summary>
        /// Starts an asynchronous analytics job that not only transcribes the audio recording
        /// of a caller and agent, but also returns additional insights. These insights include
        /// how quickly or loudly the caller or agent was speaking. To retrieve additional insights
        /// with your analytics jobs, create categories. A category is a way to classify analytics
        /// jobs based on attributes, such as a customer's sentiment or a particular phrase being
        /// used during the call. For more information, see the operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCallAnalyticsJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCallAnalyticsJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartCallAnalyticsJob">REST API Reference for StartCallAnalyticsJob Operation</seealso>
        public virtual Task<StartCallAnalyticsJobResponse> StartCallAnalyticsJobAsync(StartCallAnalyticsJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCallAnalyticsJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCallAnalyticsJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartCallAnalyticsJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartMedicalTranscriptionJob


        /// <summary>
        /// Starts a batch job to transcribe medical speech to text.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMedicalTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the StartMedicalTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartMedicalTranscriptionJob">REST API Reference for StartMedicalTranscriptionJob Operation</seealso>
        public virtual StartMedicalTranscriptionJobResponse StartMedicalTranscriptionJob(StartMedicalTranscriptionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMedicalTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMedicalTranscriptionJobResponseUnmarshaller.Instance;

            return Invoke<StartMedicalTranscriptionJobResponse>(request, options);
        }


        /// <summary>
        /// Starts a batch job to transcribe medical speech to text.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMedicalTranscriptionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMedicalTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartMedicalTranscriptionJob">REST API Reference for StartMedicalTranscriptionJob Operation</seealso>
        public virtual Task<StartMedicalTranscriptionJobResponse> StartMedicalTranscriptionJobAsync(StartMedicalTranscriptionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMedicalTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMedicalTranscriptionJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartMedicalTranscriptionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartTranscriptionJob


        /// <summary>
        /// Starts an asynchronous job to transcribe speech to text.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the StartTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartTranscriptionJob">REST API Reference for StartTranscriptionJob Operation</seealso>
        public virtual StartTranscriptionJobResponse StartTranscriptionJob(StartTranscriptionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTranscriptionJobResponseUnmarshaller.Instance;

            return Invoke<StartTranscriptionJobResponse>(request, options);
        }


        /// <summary>
        /// Starts an asynchronous job to transcribe speech to text.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTranscriptionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartTranscriptionJob">REST API Reference for StartTranscriptionJob Operation</seealso>
        public virtual Task<StartTranscriptionJobResponse> StartTranscriptionJobAsync(StartTranscriptionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTranscriptionJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartTranscriptionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tags a Amazon Transcribe resource with the given list of tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Tags a Amazon Transcribe resource with the given list of tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes specified tags from a specified Amazon Transcribe resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes specified tags from a specified Amazon Transcribe resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCallAnalyticsCategory


        /// <summary>
        /// Updates the call analytics category with new values. The <code>UpdateCallAnalyticsCategory</code>
        /// operation overwrites all of the existing information with the values that you provide
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCallAnalyticsCategory service method.</param>
        /// 
        /// <returns>The response from the UpdateCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateCallAnalyticsCategory">REST API Reference for UpdateCallAnalyticsCategory Operation</seealso>
        public virtual UpdateCallAnalyticsCategoryResponse UpdateCallAnalyticsCategory(UpdateCallAnalyticsCategoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCallAnalyticsCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCallAnalyticsCategoryResponseUnmarshaller.Instance;

            return Invoke<UpdateCallAnalyticsCategoryResponse>(request, options);
        }


        /// <summary>
        /// Updates the call analytics category with new values. The <code>UpdateCallAnalyticsCategory</code>
        /// operation overwrites all of the existing information with the values that you provide
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCallAnalyticsCategory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateCallAnalyticsCategory">REST API Reference for UpdateCallAnalyticsCategory Operation</seealso>
        public virtual Task<UpdateCallAnalyticsCategoryResponse> UpdateCallAnalyticsCategoryAsync(UpdateCallAnalyticsCategoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCallAnalyticsCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCallAnalyticsCategoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateCallAnalyticsCategoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMedicalVocabulary


        /// <summary>
        /// Updates a vocabulary with new values that you provide in a different text file from
        /// the one you used to create the vocabulary. The <code>UpdateMedicalVocabulary</code>
        /// operation overwrites all of the existing information with the values that you provide
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMedicalVocabulary service method.</param>
        /// 
        /// <returns>The response from the UpdateMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateMedicalVocabulary">REST API Reference for UpdateMedicalVocabulary Operation</seealso>
        public virtual UpdateMedicalVocabularyResponse UpdateMedicalVocabulary(UpdateMedicalVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMedicalVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMedicalVocabularyResponseUnmarshaller.Instance;

            return Invoke<UpdateMedicalVocabularyResponse>(request, options);
        }


        /// <summary>
        /// Updates a vocabulary with new values that you provide in a different text file from
        /// the one you used to create the vocabulary. The <code>UpdateMedicalVocabulary</code>
        /// operation overwrites all of the existing information with the values that you provide
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMedicalVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateMedicalVocabulary">REST API Reference for UpdateMedicalVocabulary Operation</seealso>
        public virtual Task<UpdateMedicalVocabularyResponse> UpdateMedicalVocabularyAsync(UpdateMedicalVocabularyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMedicalVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMedicalVocabularyResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateMedicalVocabularyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateVocabulary


        /// <summary>
        /// Updates an existing vocabulary with new values. The <code>UpdateVocabulary</code>
        /// operation overwrites all of the existing information with the values that you provide
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVocabulary service method.</param>
        /// 
        /// <returns>The response from the UpdateVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateVocabulary">REST API Reference for UpdateVocabulary Operation</seealso>
        public virtual UpdateVocabularyResponse UpdateVocabulary(UpdateVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVocabularyResponseUnmarshaller.Instance;

            return Invoke<UpdateVocabularyResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing vocabulary with new values. The <code>UpdateVocabulary</code>
        /// operation overwrites all of the existing information with the values that you provide
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateVocabulary">REST API Reference for UpdateVocabulary Operation</seealso>
        public virtual Task<UpdateVocabularyResponse> UpdateVocabularyAsync(UpdateVocabularyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVocabularyResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateVocabularyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateVocabularyFilter


        /// <summary>
        /// Updates a vocabulary filter with a new list of filtered words.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVocabularyFilter service method.</param>
        /// 
        /// <returns>The response from the UpdateVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateVocabularyFilter">REST API Reference for UpdateVocabularyFilter Operation</seealso>
        public virtual UpdateVocabularyFilterResponse UpdateVocabularyFilter(UpdateVocabularyFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVocabularyFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVocabularyFilterResponseUnmarshaller.Instance;

            return Invoke<UpdateVocabularyFilterResponse>(request, options);
        }


        /// <summary>
        /// Updates a vocabulary filter with a new list of filtered words.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVocabularyFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateVocabularyFilter">REST API Reference for UpdateVocabularyFilter Operation</seealso>
        public virtual Task<UpdateVocabularyFilterResponse> UpdateVocabularyFilterAsync(UpdateVocabularyFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVocabularyFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVocabularyFilterResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateVocabularyFilterResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}