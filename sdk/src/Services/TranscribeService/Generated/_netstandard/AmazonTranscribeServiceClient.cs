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
    /// Amazon Transcribe offers three main types of batch transcription: <b>Standard</b>,
    /// <b>Medical</b>, and <b>Call Analytics</b>.
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <b>Standard transcriptions</b> are the most common option. Refer to for details.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Medical transcriptions</b> are tailored to medical professionals and incorporate
    /// medical terms. A common use case for this service is transcribing doctor-patient dialogue
    /// into after-visit notes. Refer to for details.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Call Analytics transcriptions</b> are designed for use with call center audio
    /// on two different channels; if you're looking for insight into customer service calls,
    /// use this option. Refer to for details.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonTranscribeServiceClient : AmazonServiceClient, IAmazonTranscribeService
    {
        private static IServiceMetadata serviceMetadata = new AmazonTranscribeServiceMetadata();
        
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
#if AWS_ASYNC_ENUMERABLES_API
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
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonTranscribeServiceEndpointResolver());
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

        internal virtual CreateCallAnalyticsCategoryResponse CreateCallAnalyticsCategory(CreateCallAnalyticsCategoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCallAnalyticsCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCallAnalyticsCategoryResponseUnmarshaller.Instance;

            return Invoke<CreateCallAnalyticsCategoryResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Call Analytics category.
        /// 
        ///  
        /// <para>
        /// All categories are automatically applied to your Call Analytics transcriptions. Note
        /// that in order to apply categories to your transcriptions, you must create them before
        /// submitting your transcription request, as categories cannot be applied retroactively.
        /// </para>
        ///  
        /// <para>
        /// When creating a new category, you can use the <code>InputType</code> parameter to
        /// label the category as a batch category (<code>POST_CALL</code>) or a streaming category
        /// (<code>REAL_TIME</code>). Batch categories can only be applied to batch transcriptions
        /// and streaming categories can only be applied to streaming transcriptions. If you do
        /// not include <code>InputType</code>, your category is created as a batch category by
        /// default.
        /// </para>
        ///  
        /// <para>
        /// Call Analytics categories are composed of rules. For each category, you must create
        /// between 1 and 20 rules. Rules can include these parameters: , , , and .
        /// </para>
        ///  
        /// <para>
        /// To update an existing category, see .
        /// </para>
        ///  
        /// <para>
        /// To learn more about Call Analytics categories, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-categories-batch.html">Creating
        /// categories for batch transcriptions</a> and <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-categories-stream.html">Creating
        /// categories for streaming transcriptions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCallAnalyticsCategory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// A resource already exists with this name. Resource names must be unique within an
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
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

        internal virtual CreateLanguageModelResponse CreateLanguageModel(CreateLanguageModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLanguageModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLanguageModelResponseUnmarshaller.Instance;

            return Invoke<CreateLanguageModelResponse>(request, options);
        }



        /// <summary>
        /// Creates a new custom language model.
        /// 
        ///  
        /// <para>
        /// When creating a new custom language model, you must specify:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you want a Wideband (audio sample rates over 16,000 Hz) or Narrowband (audio sample
        /// rates under 16,000 Hz) base model
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The location of your training and tuning files (this must be an Amazon S3 URI)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The language of your model
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A unique name for your model
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLanguageModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLanguageModel service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// A resource already exists with this name. Resource names must be unique within an
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
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

        internal virtual CreateMedicalVocabularyResponse CreateMedicalVocabulary(CreateMedicalVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMedicalVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMedicalVocabularyResponseUnmarshaller.Instance;

            return Invoke<CreateMedicalVocabularyResponse>(request, options);
        }



        /// <summary>
        /// Creates a new custom medical vocabulary.
        /// 
        ///  
        /// <para>
        /// Before creating a new custom medical vocabulary, you must first upload a text file
        /// that contains your new entries, phrases, and terms into an Amazon S3 bucket. Note
        /// that this differs from , where you can include a list of terms within your request
        /// using the <code>Phrases</code> flag; <code>CreateMedicalVocabulary</code> does not
        /// support the <code>Phrases</code> flag.
        /// </para>
        ///  
        /// <para>
        /// Each language has a character set that contains all allowed characters for that specific
        /// language. If you use unsupported characters, your custom vocabulary request fails.
        /// Refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/charsets.html">Character
        /// Sets for Custom Vocabularies</a> to get the character set for your language.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/custom-vocabulary.html">Custom
        /// vocabularies</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMedicalVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// A resource already exists with this name. Resource names must be unique within an
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
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

        internal virtual CreateVocabularyResponse CreateVocabulary(CreateVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVocabularyResponseUnmarshaller.Instance;

            return Invoke<CreateVocabularyResponse>(request, options);
        }



        /// <summary>
        /// Creates a new custom vocabulary.
        /// 
        ///  
        /// <para>
        /// When creating a new custom vocabulary, you can either upload a text file that contains
        /// your new entries, phrases, and terms into an Amazon S3 bucket and include the URI
        /// in your request. Or you can include a list of terms directly in your request using
        /// the <code>Phrases</code> flag.
        /// </para>
        ///  
        /// <para>
        /// Each language has a character set that contains all allowed characters for that specific
        /// language. If you use unsupported characters, your custom vocabulary request fails.
        /// Refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/charsets.html">Character
        /// Sets for Custom Vocabularies</a> to get the character set for your language.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/custom-vocabulary.html">Custom
        /// vocabularies</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// A resource already exists with this name. Resource names must be unique within an
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
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

        internal virtual CreateVocabularyFilterResponse CreateVocabularyFilter(CreateVocabularyFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVocabularyFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVocabularyFilterResponseUnmarshaller.Instance;

            return Invoke<CreateVocabularyFilterResponse>(request, options);
        }



        /// <summary>
        /// Creates a new custom vocabulary filter.
        /// 
        ///  
        /// <para>
        /// You can use custom vocabulary filters to mask, delete, or flag specific words from
        /// your transcript. Custom vocabulary filters are commonly used to mask profanity in
        /// transcripts.
        /// </para>
        ///  
        /// <para>
        /// Each language has a character set that contains all allowed characters for that specific
        /// language. If you use unsupported characters, your custom vocabulary filter request
        /// fails. Refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/charsets.html">Character
        /// Sets for Custom Vocabularies</a> to get the character set for your language.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/vocabulary-filtering.html">Vocabulary
        /// filtering</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVocabularyFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// A resource already exists with this name. Resource names must be unique within an
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
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

        internal virtual DeleteCallAnalyticsCategoryResponse DeleteCallAnalyticsCategory(DeleteCallAnalyticsCategoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCallAnalyticsCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCallAnalyticsCategoryResponseUnmarshaller.Instance;

            return Invoke<DeleteCallAnalyticsCategoryResponse>(request, options);
        }



        /// <summary>
        /// Deletes a Call Analytics category. To use this operation, specify the name of the
        /// category you want to delete using <code>CategoryName</code>. Category names are case
        /// sensitive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCallAnalyticsCategory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check that the specified name is correct and
        /// try your request again.
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

        internal virtual DeleteCallAnalyticsJobResponse DeleteCallAnalyticsJob(DeleteCallAnalyticsJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCallAnalyticsJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCallAnalyticsJobResponseUnmarshaller.Instance;

            return Invoke<DeleteCallAnalyticsJobResponse>(request, options);
        }



        /// <summary>
        /// Deletes a Call Analytics job. To use this operation, specify the name of the job you
        /// want to delete using <code>CallAnalyticsJobName</code>. Job names are case sensitive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCallAnalyticsJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCallAnalyticsJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
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

        internal virtual DeleteLanguageModelResponse DeleteLanguageModel(DeleteLanguageModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLanguageModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLanguageModelResponseUnmarshaller.Instance;

            return Invoke<DeleteLanguageModelResponse>(request, options);
        }



        /// <summary>
        /// Deletes a custom language model. To use this operation, specify the name of the language
        /// model you want to delete using <code>ModelName</code>. custom language model names
        /// are case sensitive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLanguageModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLanguageModel service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
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

        internal virtual DeleteMedicalTranscriptionJobResponse DeleteMedicalTranscriptionJob(DeleteMedicalTranscriptionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMedicalTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMedicalTranscriptionJobResponseUnmarshaller.Instance;

            return Invoke<DeleteMedicalTranscriptionJobResponse>(request, options);
        }



        /// <summary>
        /// Deletes a medical transcription job. To use this operation, specify the name of the
        /// job you want to delete using <code>MedicalTranscriptionJobName</code>. Job names are
        /// case sensitive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMedicalTranscriptionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMedicalTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
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

        internal virtual DeleteMedicalVocabularyResponse DeleteMedicalVocabulary(DeleteMedicalVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMedicalVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMedicalVocabularyResponseUnmarshaller.Instance;

            return Invoke<DeleteMedicalVocabularyResponse>(request, options);
        }



        /// <summary>
        /// Deletes a custom medical vocabulary. To use this operation, specify the name of the
        /// custom vocabulary you want to delete using <code>VocabularyName</code>. Custom vocabulary
        /// names are case sensitive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMedicalVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check that the specified name is correct and
        /// try your request again.
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

        internal virtual DeleteTranscriptionJobResponse DeleteTranscriptionJob(DeleteTranscriptionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTranscriptionJobResponseUnmarshaller.Instance;

            return Invoke<DeleteTranscriptionJobResponse>(request, options);
        }



        /// <summary>
        /// Deletes a transcription job. To use this operation, specify the name of the job you
        /// want to delete using <code>TranscriptionJobName</code>. Job names are case sensitive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTranscriptionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
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

        internal virtual DeleteVocabularyResponse DeleteVocabulary(DeleteVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVocabularyResponseUnmarshaller.Instance;

            return Invoke<DeleteVocabularyResponse>(request, options);
        }



        /// <summary>
        /// Deletes a custom vocabulary. To use this operation, specify the name of the custom
        /// vocabulary you want to delete using <code>VocabularyName</code>. Custom vocabulary
        /// names are case sensitive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check that the specified name is correct and
        /// try your request again.
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

        internal virtual DeleteVocabularyFilterResponse DeleteVocabularyFilter(DeleteVocabularyFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVocabularyFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVocabularyFilterResponseUnmarshaller.Instance;

            return Invoke<DeleteVocabularyFilterResponse>(request, options);
        }



        /// <summary>
        /// Deletes a custom vocabulary filter. To use this operation, specify the name of the
        /// custom vocabulary filter you want to delete using <code>VocabularyFilterName</code>.
        /// Custom vocabulary filter names are case sensitive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVocabularyFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check that the specified name is correct and
        /// try your request again.
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

        internal virtual DescribeLanguageModelResponse DescribeLanguageModel(DescribeLanguageModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLanguageModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLanguageModelResponseUnmarshaller.Instance;

            return Invoke<DescribeLanguageModelResponse>(request, options);
        }



        /// <summary>
        /// Provides information about the specified custom language model.
        /// 
        ///  
        /// <para>
        /// This operation also shows if the base language model that you used to create your
        /// custom language model has been updated. If Amazon Transcribe has updated the base
        /// model, you can create a new custom language model using the updated base model.
        /// </para>
        ///  
        /// <para>
        /// If you tried to create a new custom language model and the request wasn't successful,
        /// you can use <code>DescribeLanguageModel</code> to help identify the reason for this
        /// failure.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLanguageModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLanguageModel service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check that the specified name is correct and
        /// try your request again.
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

        internal virtual GetCallAnalyticsCategoryResponse GetCallAnalyticsCategory(GetCallAnalyticsCategoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCallAnalyticsCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCallAnalyticsCategoryResponseUnmarshaller.Instance;

            return Invoke<GetCallAnalyticsCategoryResponse>(request, options);
        }



        /// <summary>
        /// Provides information about the specified Call Analytics category.
        /// 
        ///  
        /// <para>
        /// To get a list of your Call Analytics categories, use the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCallAnalyticsCategory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check that the specified name is correct and
        /// try your request again.
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

        internal virtual GetCallAnalyticsJobResponse GetCallAnalyticsJob(GetCallAnalyticsJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCallAnalyticsJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCallAnalyticsJobResponseUnmarshaller.Instance;

            return Invoke<GetCallAnalyticsJobResponse>(request, options);
        }



        /// <summary>
        /// Provides information about the specified Call Analytics job.
        /// 
        ///  
        /// <para>
        /// To view the job's status, refer to <code>CallAnalyticsJobStatus</code>. If the status
        /// is <code>COMPLETED</code>, the job is finished. You can find your completed transcript
        /// at the URI specified in <code>TranscriptFileUri</code>. If the status is <code>FAILED</code>,
        /// <code>FailureReason</code> provides details on why your transcription job failed.
        /// </para>
        ///  
        /// <para>
        /// If you enabled personally identifiable information (PII) redaction, the redacted transcript
        /// appears at the location specified in <code>RedactedTranscriptFileUri</code>.
        /// </para>
        ///  
        /// <para>
        /// If you chose to redact the audio in your media file, you can find your redacted media
        /// file at the location specified in <code>RedactedMediaFileUri</code>.
        /// </para>
        ///  
        /// <para>
        /// To get a list of your Call Analytics jobs, use the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCallAnalyticsJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCallAnalyticsJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check that the specified name is correct and
        /// try your request again.
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

        internal virtual GetMedicalTranscriptionJobResponse GetMedicalTranscriptionJob(GetMedicalTranscriptionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMedicalTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMedicalTranscriptionJobResponseUnmarshaller.Instance;

            return Invoke<GetMedicalTranscriptionJobResponse>(request, options);
        }



        /// <summary>
        /// Provides information about the specified medical transcription job.
        /// 
        ///  
        /// <para>
        /// To view the status of the specified medical transcription job, check the <code>TranscriptionJobStatus</code>
        /// field. If the status is <code>COMPLETED</code>, the job is finished. You can find
        /// the results at the location specified in <code>TranscriptFileUri</code>. If the status
        /// is <code>FAILED</code>, <code>FailureReason</code> provides details on why your transcription
        /// job failed.
        /// </para>
        ///  
        /// <para>
        /// To get a list of your medical transcription jobs, use the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalTranscriptionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMedicalTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check that the specified name is correct and
        /// try your request again.
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

        internal virtual GetMedicalVocabularyResponse GetMedicalVocabulary(GetMedicalVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMedicalVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMedicalVocabularyResponseUnmarshaller.Instance;

            return Invoke<GetMedicalVocabularyResponse>(request, options);
        }



        /// <summary>
        /// Provides information about the specified custom medical vocabulary.
        /// 
        ///  
        /// <para>
        /// To view the status of the specified custom medical vocabulary, check the <code>VocabularyState</code>
        /// field. If the status is <code>READY</code>, your custom vocabulary is available to
        /// use. If the status is <code>FAILED</code>, <code>FailureReason</code> provides details
        /// on why your vocabulary failed.
        /// </para>
        ///  
        /// <para>
        /// To get a list of your custom medical vocabularies, use the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check that the specified name is correct and
        /// try your request again.
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

        internal virtual GetTranscriptionJobResponse GetTranscriptionJob(GetTranscriptionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTranscriptionJobResponseUnmarshaller.Instance;

            return Invoke<GetTranscriptionJobResponse>(request, options);
        }



        /// <summary>
        /// Provides information about the specified transcription job.
        /// 
        ///  
        /// <para>
        /// To view the status of the specified transcription job, check the <code>TranscriptionJobStatus</code>
        /// field. If the status is <code>COMPLETED</code>, the job is finished. You can find
        /// the results at the location specified in <code>TranscriptFileUri</code>. If the status
        /// is <code>FAILED</code>, <code>FailureReason</code> provides details on why your transcription
        /// job failed.
        /// </para>
        ///  
        /// <para>
        /// If you enabled content redaction, the redacted transcript can be found at the location
        /// specified in <code>RedactedTranscriptFileUri</code>.
        /// </para>
        ///  
        /// <para>
        /// To get a list of your transcription jobs, use the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTranscriptionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check that the specified name is correct and
        /// try your request again.
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

        internal virtual GetVocabularyResponse GetVocabulary(GetVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVocabularyResponseUnmarshaller.Instance;

            return Invoke<GetVocabularyResponse>(request, options);
        }



        /// <summary>
        /// Provides information about the specified custom vocabulary.
        /// 
        ///  
        /// <para>
        /// To view the status of the specified custom vocabulary, check the <code>VocabularyState</code>
        /// field. If the status is <code>READY</code>, your custom vocabulary is available to
        /// use. If the status is <code>FAILED</code>, <code>FailureReason</code> provides details
        /// on why your custom vocabulary failed.
        /// </para>
        ///  
        /// <para>
        /// To get a list of your custom vocabularies, use the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check that the specified name is correct and
        /// try your request again.
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

        internal virtual GetVocabularyFilterResponse GetVocabularyFilter(GetVocabularyFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVocabularyFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVocabularyFilterResponseUnmarshaller.Instance;

            return Invoke<GetVocabularyFilterResponse>(request, options);
        }



        /// <summary>
        /// Provides information about the specified custom vocabulary filter.
        /// 
        ///  
        /// <para>
        /// To get a list of your custom vocabulary filters, use the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVocabularyFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check that the specified name is correct and
        /// try your request again.
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

        internal virtual ListCallAnalyticsCategoriesResponse ListCallAnalyticsCategories(ListCallAnalyticsCategoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCallAnalyticsCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCallAnalyticsCategoriesResponseUnmarshaller.Instance;

            return Invoke<ListCallAnalyticsCategoriesResponse>(request, options);
        }



        /// <summary>
        /// Provides a list of Call Analytics categories, including all rules that make up each
        /// category.
        /// 
        ///  
        /// <para>
        /// To get detailed information about a specific Call Analytics category, use the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCallAnalyticsCategories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCallAnalyticsCategories service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
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

        internal virtual ListCallAnalyticsJobsResponse ListCallAnalyticsJobs(ListCallAnalyticsJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCallAnalyticsJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCallAnalyticsJobsResponseUnmarshaller.Instance;

            return Invoke<ListCallAnalyticsJobsResponse>(request, options);
        }



        /// <summary>
        /// Provides a list of Call Analytics jobs that match the specified criteria. If no criteria
        /// are specified, all Call Analytics jobs are returned.
        /// 
        ///  
        /// <para>
        /// To get detailed information about a specific Call Analytics job, use the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCallAnalyticsJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCallAnalyticsJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
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

        internal virtual ListLanguageModelsResponse ListLanguageModels(ListLanguageModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLanguageModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLanguageModelsResponseUnmarshaller.Instance;

            return Invoke<ListLanguageModelsResponse>(request, options);
        }



        /// <summary>
        /// Provides a list of custom language models that match the specified criteria. If no
        /// criteria are specified, all custom language models are returned.
        /// 
        ///  
        /// <para>
        /// To get detailed information about a specific custom language model, use the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLanguageModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLanguageModels service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
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

        internal virtual ListMedicalTranscriptionJobsResponse ListMedicalTranscriptionJobs(ListMedicalTranscriptionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMedicalTranscriptionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMedicalTranscriptionJobsResponseUnmarshaller.Instance;

            return Invoke<ListMedicalTranscriptionJobsResponse>(request, options);
        }



        /// <summary>
        /// Provides a list of medical transcription jobs that match the specified criteria. If
        /// no criteria are specified, all medical transcription jobs are returned.
        /// 
        ///  
        /// <para>
        /// To get detailed information about a specific medical transcription job, use the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMedicalTranscriptionJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMedicalTranscriptionJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
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

        internal virtual ListMedicalVocabulariesResponse ListMedicalVocabularies(ListMedicalVocabulariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMedicalVocabulariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMedicalVocabulariesResponseUnmarshaller.Instance;

            return Invoke<ListMedicalVocabulariesResponse>(request, options);
        }



        /// <summary>
        /// Provides a list of custom medical vocabularies that match the specified criteria.
        /// If no criteria are specified, all custom medical vocabularies are returned.
        /// 
        ///  
        /// <para>
        /// To get detailed information about a specific custom medical vocabulary, use the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMedicalVocabularies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMedicalVocabularies service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
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

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists all tags associated with the specified transcription job, vocabulary, model,
        /// or resource.
        /// 
        ///  
        /// <para>
        /// To learn more about using tags with Amazon Transcribe, refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tagging.html">Tagging
        /// resources</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check that the specified name is correct and
        /// try your request again.
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

        internal virtual ListTranscriptionJobsResponse ListTranscriptionJobs(ListTranscriptionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTranscriptionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTranscriptionJobsResponseUnmarshaller.Instance;

            return Invoke<ListTranscriptionJobsResponse>(request, options);
        }



        /// <summary>
        /// Provides a list of transcription jobs that match the specified criteria. If no criteria
        /// are specified, all transcription jobs are returned.
        /// 
        ///  
        /// <para>
        /// To get detailed information about a specific transcription job, use the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTranscriptionJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTranscriptionJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
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

        internal virtual ListVocabulariesResponse ListVocabularies(ListVocabulariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVocabulariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVocabulariesResponseUnmarshaller.Instance;

            return Invoke<ListVocabulariesResponse>(request, options);
        }



        /// <summary>
        /// Provides a list of custom vocabularies that match the specified criteria. If no criteria
        /// are specified, all custom vocabularies are returned.
        /// 
        ///  
        /// <para>
        /// To get detailed information about a specific custom vocabulary, use the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVocabularies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVocabularies service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
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

        internal virtual ListVocabularyFiltersResponse ListVocabularyFilters(ListVocabularyFiltersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVocabularyFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVocabularyFiltersResponseUnmarshaller.Instance;

            return Invoke<ListVocabularyFiltersResponse>(request, options);
        }



        /// <summary>
        /// Provides a list of custom vocabulary filters that match the specified criteria. If
        /// no criteria are specified, all custom vocabularies are returned.
        /// 
        ///  
        /// <para>
        /// To get detailed information about a specific custom vocabulary filter, use the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVocabularyFilters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVocabularyFilters service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
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

        internal virtual StartCallAnalyticsJobResponse StartCallAnalyticsJob(StartCallAnalyticsJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCallAnalyticsJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCallAnalyticsJobResponseUnmarshaller.Instance;

            return Invoke<StartCallAnalyticsJobResponse>(request, options);
        }



        /// <summary>
        /// Transcribes the audio from a customer service call and applies any additional Request
        /// Parameters you choose to include in your request.
        /// 
        ///  
        /// <para>
        /// In addition to many standard transcription features, Call Analytics provides you with
        /// call characteristics, call summarization, speaker sentiment, and optional redaction
        /// of your text transcript and your audio file. You can also apply custom categories
        /// to flag specified conditions. To learn more about these features and insights, refer
        /// to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/call-analytics.html">Analyzing
        /// call center audio with Call Analytics</a>.
        /// </para>
        ///  
        /// <para>
        /// If you want to apply categories to your Call Analytics job, you must create them before
        /// submitting your job request. Categories cannot be retroactively applied to a job.
        /// To create a new category, use the operation. To learn more about Call Analytics categories,
        /// see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-categories-batch.html">Creating
        /// categories for batch transcriptions</a> and <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-categories-stream.html">Creating
        /// categories for streaming transcriptions</a>.
        /// </para>
        ///  
        /// <para>
        /// To make a <code>StartCallAnalyticsJob</code> request, you must first upload your media
        /// file into an Amazon S3 bucket; you can then specify the Amazon S3 location of the
        /// file using the <code>Media</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// You must include the following parameters in your <code>StartCallAnalyticsJob</code>
        /// request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>region</code>: The Amazon Web Services Region where you are making your request.
        /// For a list of Amazon Web Services Regions supported with Amazon Transcribe, refer
        /// to <a href="https://docs.aws.amazon.com/general/latest/gr/transcribe.html">Amazon
        /// Transcribe endpoints and quotas</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CallAnalyticsJobName</code>: A custom name that you create for your transcription
        /// job that's unique within your Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DataAccessRoleArn</code>: The Amazon Resource Name (ARN) of an IAM role that
        /// has permissions to access the Amazon S3 bucket that contains your input files.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Media</code> (<code>MediaFileUri</code> or <code>RedactedMediaFileUri</code>):
        /// The Amazon S3 location of your media file.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// With Call Analytics, you can redact the audio contained in your media file by including
        /// <code>RedactedMediaFileUri</code>, instead of <code>MediaFileUri</code>, to specify
        /// the location of your input audio. If you choose to redact your audio, you can find
        /// your redacted media at the location specified in the <code>RedactedMediaFileUri</code>
        /// field of your response.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCallAnalyticsJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCallAnalyticsJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// A resource already exists with this name. Resource names must be unique within an
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
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

        internal virtual StartMedicalTranscriptionJobResponse StartMedicalTranscriptionJob(StartMedicalTranscriptionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMedicalTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMedicalTranscriptionJobResponseUnmarshaller.Instance;

            return Invoke<StartMedicalTranscriptionJobResponse>(request, options);
        }



        /// <summary>
        /// Transcribes the audio from a medical dictation or conversation and applies any additional
        /// Request Parameters you choose to include in your request.
        /// 
        ///  
        /// <para>
        /// In addition to many standard transcription features, Amazon Transcribe Medical provides
        /// you with a robust medical vocabulary and, optionally, content identification, which
        /// adds flags to personal health information (PHI). To learn more about these features,
        /// refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/how-it-works-med.html">How
        /// Amazon Transcribe Medical works</a>.
        /// </para>
        ///  
        /// <para>
        /// To make a <code>StartMedicalTranscriptionJob</code> request, you must first upload
        /// your media file into an Amazon S3 bucket; you can then specify the S3 location of
        /// the file using the <code>Media</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// You must include the following parameters in your <code>StartMedicalTranscriptionJob</code>
        /// request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>region</code>: The Amazon Web Services Region where you are making your request.
        /// For a list of Amazon Web Services Regions supported with Amazon Transcribe, refer
        /// to <a href="https://docs.aws.amazon.com/general/latest/gr/transcribe.html">Amazon
        /// Transcribe endpoints and quotas</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MedicalTranscriptionJobName</code>: A custom name you create for your transcription
        /// job that is unique within your Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Media</code> (<code>MediaFileUri</code>): The Amazon S3 location of your media
        /// file.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LanguageCode</code>: This must be <code>en-US</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OutputBucketName</code>: The Amazon S3 bucket where you want your transcript
        /// stored. If you want your output stored in a sub-folder of this bucket, you must also
        /// include <code>OutputKey</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Specialty</code>: This must be <code>PRIMARYCARE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Type</code>: Choose whether your audio is a conversation or a dictation.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMedicalTranscriptionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMedicalTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// A resource already exists with this name. Resource names must be unique within an
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
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

        internal virtual StartTranscriptionJobResponse StartTranscriptionJob(StartTranscriptionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTranscriptionJobResponseUnmarshaller.Instance;

            return Invoke<StartTranscriptionJobResponse>(request, options);
        }



        /// <summary>
        /// Transcribes the audio from a media file and applies any additional Request Parameters
        /// you choose to include in your request.
        /// 
        ///  
        /// <para>
        /// To make a <code>StartTranscriptionJob</code> request, you must first upload your media
        /// file into an Amazon S3 bucket; you can then specify the Amazon S3 location of the
        /// file using the <code>Media</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// You must include the following parameters in your <code>StartTranscriptionJob</code>
        /// request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>region</code>: The Amazon Web Services Region where you are making your request.
        /// For a list of Amazon Web Services Regions supported with Amazon Transcribe, refer
        /// to <a href="https://docs.aws.amazon.com/general/latest/gr/transcribe.html">Amazon
        /// Transcribe endpoints and quotas</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TranscriptionJobName</code>: A custom name you create for your transcription
        /// job that is unique within your Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Media</code> (<code>MediaFileUri</code>): The Amazon S3 location of your media
        /// file.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// One of <code>LanguageCode</code>, <code>IdentifyLanguage</code>, or <code>IdentifyMultipleLanguages</code>:
        /// If you know the language of your media file, specify it using the <code>LanguageCode</code>
        /// parameter; you can find all valid language codes in the <a href="https://docs.aws.amazon.com/transcribe/latest/dg/supported-languages.html">Supported
        /// languages</a> table. If you don't know the languages spoken in your media, use either
        /// <code>IdentifyLanguage</code> or <code>IdentifyMultipleLanguages</code> and let Amazon
        /// Transcribe identify the languages for you.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTranscriptionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// A resource already exists with this name. Resource names must be unique within an
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
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

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds one or more custom tags, each in the form of a key:value pair, to the specified
        /// resource.
        /// 
        ///  
        /// <para>
        /// To learn more about using tags with Amazon Transcribe, refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tagging.html">Tagging
        /// resources</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// A resource already exists with this name. Resource names must be unique within an
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check that the specified name is correct and
        /// try your request again.
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

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified tags from the specified Amazon Transcribe resource.
        /// 
        ///  
        /// <para>
        /// If you include <code>UntagResource</code> in your request, you must also include <code>ResourceArn</code>
        /// and <code>TagKeys</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// A resource already exists with this name. Resource names must be unique within an
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check that the specified name is correct and
        /// try your request again.
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

        internal virtual UpdateCallAnalyticsCategoryResponse UpdateCallAnalyticsCategory(UpdateCallAnalyticsCategoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCallAnalyticsCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCallAnalyticsCategoryResponseUnmarshaller.Instance;

            return Invoke<UpdateCallAnalyticsCategoryResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified Call Analytics category with new rules. Note that the <code>UpdateCallAnalyticsCategory</code>
        /// operation overwrites all existing rules contained in the specified category. You cannot
        /// append additional rules onto an existing category.
        /// 
        ///  
        /// <para>
        /// To create a new category, see .
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCallAnalyticsCategory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// A resource already exists with this name. Resource names must be unique within an
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check that the specified name is correct and
        /// try your request again.
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

        internal virtual UpdateMedicalVocabularyResponse UpdateMedicalVocabulary(UpdateMedicalVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMedicalVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMedicalVocabularyResponseUnmarshaller.Instance;

            return Invoke<UpdateMedicalVocabularyResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing custom medical vocabulary with new values. This operation overwrites
        /// all existing information with your new values; you cannot append new terms onto an
        /// existing custom vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMedicalVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// A resource already exists with this name. Resource names must be unique within an
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check that the specified name is correct and
        /// try your request again.
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

        internal virtual UpdateVocabularyResponse UpdateVocabulary(UpdateVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVocabularyResponseUnmarshaller.Instance;

            return Invoke<UpdateVocabularyResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing custom vocabulary with new values. This operation overwrites all
        /// existing information with your new values; you cannot append new terms onto an existing
        /// custom vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// A resource already exists with this name. Resource names must be unique within an
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check that the specified name is correct and
        /// try your request again.
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

        internal virtual UpdateVocabularyFilterResponse UpdateVocabularyFilter(UpdateVocabularyFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVocabularyFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVocabularyFilterResponseUnmarshaller.Instance;

            return Invoke<UpdateVocabularyFilterResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing custom vocabulary filter with a new list of words. The new list
        /// you provide overwrites all previous entries; you cannot append new terms onto an existing
        /// custom vocabulary filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVocabularyFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <code>IN PROGRESS</code>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check that the specified name is correct and
        /// try your request again.
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