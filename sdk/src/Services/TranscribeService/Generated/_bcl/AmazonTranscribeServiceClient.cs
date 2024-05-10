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

#pragma warning disable CS1570
namespace Amazon.TranscribeService
{
    /// <summary>
    /// <para>Implementation for accessing TranscribeService</para>
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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}

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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
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
        /// When creating a new category, you can use the <c>InputType</c> parameter to label
        /// the category as a <c>POST_CALL</c> or a <c>REAL_TIME</c> category. <c>POST_CALL</c>
        /// categories can only be applied to post-call transcriptions and <c>REAL_TIME</c> categories
        /// can only be applied to real-time transcriptions. If you do not include <c>InputType</c>,
        /// your category is created as a <c>POST_CALL</c> category by default.
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
        /// categories for post-call transcriptions</a> and <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-categories-stream.html">Creating
        /// categories for real-time transcriptions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCallAnalyticsCategory service method.</param>
        /// 
        /// <returns>The response from the CreateCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual CreateCallAnalyticsCategoryResponse CreateCallAnalyticsCategory(CreateCallAnalyticsCategoryRequest request)
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
        /// When creating a new category, you can use the <c>InputType</c> parameter to label
        /// the category as a <c>POST_CALL</c> or a <c>REAL_TIME</c> category. <c>POST_CALL</c>
        /// categories can only be applied to post-call transcriptions and <c>REAL_TIME</c> categories
        /// can only be applied to real-time transcriptions. If you do not include <c>InputType</c>,
        /// your category is created as a <c>POST_CALL</c> category by default.
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
        /// categories for post-call transcriptions</a> and <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-categories-stream.html">Creating
        /// categories for real-time transcriptions</a>.
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        /// 
        /// <returns>The response from the CreateLanguageModel service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual CreateLanguageModelResponse CreateLanguageModel(CreateLanguageModelRequest request)
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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


        /// <summary>
        /// Creates a new custom medical vocabulary.
        /// 
        ///  
        /// <para>
        /// Before creating a new custom medical vocabulary, you must first upload a text file
        /// that contains your vocabulary table into an Amazon S3 bucket. Note that this differs
        /// from , where you can include a list of terms within your request using the <c>Phrases</c>
        /// flag; <c>CreateMedicalVocabulary</c> does not support the <c>Phrases</c> flag and
        /// only accepts vocabularies in table format.
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
        /// 
        /// <returns>The response from the CreateMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual CreateMedicalVocabularyResponse CreateMedicalVocabulary(CreateMedicalVocabularyRequest request)
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
        /// that contains your vocabulary table into an Amazon S3 bucket. Note that this differs
        /// from , where you can include a list of terms within your request using the <c>Phrases</c>
        /// flag; <c>CreateMedicalVocabulary</c> does not support the <c>Phrases</c> flag and
        /// only accepts vocabularies in table format.
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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


        /// <summary>
        /// Creates a new custom vocabulary.
        /// 
        ///  
        /// <para>
        /// When creating a new custom vocabulary, you can either upload a text file that contains
        /// your new entries, phrases, and terms into an Amazon S3 bucket and include the URI
        /// in your request. Or you can include a list of terms directly in your request using
        /// the <c>Phrases</c> flag.
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
        /// 
        /// <returns>The response from the CreateVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual CreateVocabularyResponse CreateVocabulary(CreateVocabularyRequest request)
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
        /// the <c>Phrases</c> flag.
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        /// 
        /// <returns>The response from the CreateVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual CreateVocabularyFilterResponse CreateVocabularyFilter(CreateVocabularyFilterRequest request)
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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


        /// <summary>
        /// Deletes a Call Analytics category. To use this operation, specify the name of the
        /// category you want to delete using <c>CategoryName</c>. Category names are case sensitive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCallAnalyticsCategory service method.</param>
        /// 
        /// <returns>The response from the DeleteCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual DeleteCallAnalyticsCategoryResponse DeleteCallAnalyticsCategory(DeleteCallAnalyticsCategoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCallAnalyticsCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCallAnalyticsCategoryResponseUnmarshaller.Instance;

            return Invoke<DeleteCallAnalyticsCategoryResponse>(request, options);
        }


        /// <summary>
        /// Deletes a Call Analytics category. To use this operation, specify the name of the
        /// category you want to delete using <c>CategoryName</c>. Category names are case sensitive.
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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


        /// <summary>
        /// Deletes a Call Analytics job. To use this operation, specify the name of the job you
        /// want to delete using <c>CallAnalyticsJobName</c>. Job names are case sensitive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCallAnalyticsJob service method.</param>
        /// 
        /// <returns>The response from the DeleteCallAnalyticsJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual DeleteCallAnalyticsJobResponse DeleteCallAnalyticsJob(DeleteCallAnalyticsJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCallAnalyticsJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCallAnalyticsJobResponseUnmarshaller.Instance;

            return Invoke<DeleteCallAnalyticsJobResponse>(request, options);
        }


        /// <summary>
        /// Deletes a Call Analytics job. To use this operation, specify the name of the job you
        /// want to delete using <c>CallAnalyticsJobName</c>. Job names are case sensitive.
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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


        /// <summary>
        /// Deletes a custom language model. To use this operation, specify the name of the language
        /// model you want to delete using <c>ModelName</c>. custom language model names are case
        /// sensitive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLanguageModel service method.</param>
        /// 
        /// <returns>The response from the DeleteLanguageModel service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual DeleteLanguageModelResponse DeleteLanguageModel(DeleteLanguageModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLanguageModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLanguageModelResponseUnmarshaller.Instance;

            return Invoke<DeleteLanguageModelResponse>(request, options);
        }


        /// <summary>
        /// Deletes a custom language model. To use this operation, specify the name of the language
        /// model you want to delete using <c>ModelName</c>. custom language model names are case
        /// sensitive.
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        
        #region  DeleteMedicalScribeJob


        /// <summary>
        /// Deletes a Medical Scribe job. To use this operation, specify the name of the job you
        /// want to delete using <c>MedicalScribeJobName</c>. Job names are case sensitive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMedicalScribeJob service method.</param>
        /// 
        /// <returns>The response from the DeleteMedicalScribeJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteMedicalScribeJob">REST API Reference for DeleteMedicalScribeJob Operation</seealso>
        public virtual DeleteMedicalScribeJobResponse DeleteMedicalScribeJob(DeleteMedicalScribeJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMedicalScribeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMedicalScribeJobResponseUnmarshaller.Instance;

            return Invoke<DeleteMedicalScribeJobResponse>(request, options);
        }


        /// <summary>
        /// Deletes a Medical Scribe job. To use this operation, specify the name of the job you
        /// want to delete using <c>MedicalScribeJobName</c>. Job names are case sensitive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMedicalScribeJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMedicalScribeJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteMedicalScribeJob">REST API Reference for DeleteMedicalScribeJob Operation</seealso>
        public virtual Task<DeleteMedicalScribeJobResponse> DeleteMedicalScribeJobAsync(DeleteMedicalScribeJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMedicalScribeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMedicalScribeJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteMedicalScribeJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMedicalTranscriptionJob


        /// <summary>
        /// Deletes a medical transcription job. To use this operation, specify the name of the
        /// job you want to delete using <c>MedicalTranscriptionJobName</c>. Job names are case
        /// sensitive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMedicalTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the DeleteMedicalTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual DeleteMedicalTranscriptionJobResponse DeleteMedicalTranscriptionJob(DeleteMedicalTranscriptionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMedicalTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMedicalTranscriptionJobResponseUnmarshaller.Instance;

            return Invoke<DeleteMedicalTranscriptionJobResponse>(request, options);
        }


        /// <summary>
        /// Deletes a medical transcription job. To use this operation, specify the name of the
        /// job you want to delete using <c>MedicalTranscriptionJobName</c>. Job names are case
        /// sensitive.
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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


        /// <summary>
        /// Deletes a custom medical vocabulary. To use this operation, specify the name of the
        /// custom vocabulary you want to delete using <c>VocabularyName</c>. Custom vocabulary
        /// names are case sensitive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMedicalVocabulary service method.</param>
        /// 
        /// <returns>The response from the DeleteMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual DeleteMedicalVocabularyResponse DeleteMedicalVocabulary(DeleteMedicalVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMedicalVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMedicalVocabularyResponseUnmarshaller.Instance;

            return Invoke<DeleteMedicalVocabularyResponse>(request, options);
        }


        /// <summary>
        /// Deletes a custom medical vocabulary. To use this operation, specify the name of the
        /// custom vocabulary you want to delete using <c>VocabularyName</c>. Custom vocabulary
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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


        /// <summary>
        /// Deletes a transcription job. To use this operation, specify the name of the job you
        /// want to delete using <c>TranscriptionJobName</c>. Job names are case sensitive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the DeleteTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual DeleteTranscriptionJobResponse DeleteTranscriptionJob(DeleteTranscriptionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTranscriptionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTranscriptionJobResponseUnmarshaller.Instance;

            return Invoke<DeleteTranscriptionJobResponse>(request, options);
        }


        /// <summary>
        /// Deletes a transcription job. To use this operation, specify the name of the job you
        /// want to delete using <c>TranscriptionJobName</c>. Job names are case sensitive.
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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


        /// <summary>
        /// Deletes a custom vocabulary. To use this operation, specify the name of the custom
        /// vocabulary you want to delete using <c>VocabularyName</c>. Custom vocabulary names
        /// are case sensitive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVocabulary service method.</param>
        /// 
        /// <returns>The response from the DeleteVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual DeleteVocabularyResponse DeleteVocabulary(DeleteVocabularyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVocabularyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVocabularyResponseUnmarshaller.Instance;

            return Invoke<DeleteVocabularyResponse>(request, options);
        }


        /// <summary>
        /// Deletes a custom vocabulary. To use this operation, specify the name of the custom
        /// vocabulary you want to delete using <c>VocabularyName</c>. Custom vocabulary names
        /// are case sensitive.
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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


        /// <summary>
        /// Deletes a custom vocabulary filter. To use this operation, specify the name of the
        /// custom vocabulary filter you want to delete using <c>VocabularyFilterName</c>. Custom
        /// vocabulary filter names are case sensitive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVocabularyFilter service method.</param>
        /// 
        /// <returns>The response from the DeleteVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual DeleteVocabularyFilterResponse DeleteVocabularyFilter(DeleteVocabularyFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVocabularyFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVocabularyFilterResponseUnmarshaller.Instance;

            return Invoke<DeleteVocabularyFilterResponse>(request, options);
        }


        /// <summary>
        /// Deletes a custom vocabulary filter. To use this operation, specify the name of the
        /// custom vocabulary filter you want to delete using <c>VocabularyFilterName</c>. Custom
        /// vocabulary filter names are case sensitive.
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        /// you can use <c>DescribeLanguageModel</c> to help identify the reason for this failure.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLanguageModel service method.</param>
        /// 
        /// <returns>The response from the DescribeLanguageModel service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual DescribeLanguageModelResponse DescribeLanguageModel(DescribeLanguageModelRequest request)
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
        /// you can use <c>DescribeLanguageModel</c> to help identify the reason for this failure.
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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


        /// <summary>
        /// Provides information about the specified Call Analytics category.
        /// 
        ///  
        /// <para>
        /// To get a list of your Call Analytics categories, use the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCallAnalyticsCategory service method.</param>
        /// 
        /// <returns>The response from the GetCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual GetCallAnalyticsCategoryResponse GetCallAnalyticsCategory(GetCallAnalyticsCategoryRequest request)
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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


        /// <summary>
        /// Provides information about the specified Call Analytics job.
        /// 
        ///  
        /// <para>
        /// To view the job's status, refer to <c>CallAnalyticsJobStatus</c>. If the status is
        /// <c>COMPLETED</c>, the job is finished. You can find your completed transcript at the
        /// URI specified in <c>TranscriptFileUri</c>. If the status is <c>FAILED</c>, <c>FailureReason</c>
        /// provides details on why your transcription job failed.
        /// </para>
        ///  
        /// <para>
        /// If you enabled personally identifiable information (PII) redaction, the redacted transcript
        /// appears at the location specified in <c>RedactedTranscriptFileUri</c>.
        /// </para>
        ///  
        /// <para>
        /// If you chose to redact the audio in your media file, you can find your redacted media
        /// file at the location specified in <c>RedactedMediaFileUri</c>.
        /// </para>
        ///  
        /// <para>
        /// To get a list of your Call Analytics jobs, use the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCallAnalyticsJob service method.</param>
        /// 
        /// <returns>The response from the GetCallAnalyticsJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual GetCallAnalyticsJobResponse GetCallAnalyticsJob(GetCallAnalyticsJobRequest request)
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
        /// To view the job's status, refer to <c>CallAnalyticsJobStatus</c>. If the status is
        /// <c>COMPLETED</c>, the job is finished. You can find your completed transcript at the
        /// URI specified in <c>TranscriptFileUri</c>. If the status is <c>FAILED</c>, <c>FailureReason</c>
        /// provides details on why your transcription job failed.
        /// </para>
        ///  
        /// <para>
        /// If you enabled personally identifiable information (PII) redaction, the redacted transcript
        /// appears at the location specified in <c>RedactedTranscriptFileUri</c>.
        /// </para>
        ///  
        /// <para>
        /// If you chose to redact the audio in your media file, you can find your redacted media
        /// file at the location specified in <c>RedactedMediaFileUri</c>.
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        
        #region  GetMedicalScribeJob


        /// <summary>
        /// Provides information about the specified Medical Scribe job.
        /// 
        ///  
        /// <para>
        /// To view the status of the specified medical transcription job, check the <c>MedicalScribeJobStatus</c>
        /// field. If the status is <c>COMPLETED</c>, the job is finished. You can find the results
        /// at the location specified in <c>MedicalScribeOutput</c>. If the status is <c>FAILED</c>,
        /// <c>FailureReason</c> provides details on why your Medical Scribe job failed.
        /// </para>
        ///  
        /// <para>
        /// To get a list of your Medical Scribe jobs, use the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalScribeJob service method.</param>
        /// 
        /// <returns>The response from the GetMedicalScribeJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetMedicalScribeJob">REST API Reference for GetMedicalScribeJob Operation</seealso>
        public virtual GetMedicalScribeJobResponse GetMedicalScribeJob(GetMedicalScribeJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMedicalScribeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMedicalScribeJobResponseUnmarshaller.Instance;

            return Invoke<GetMedicalScribeJobResponse>(request, options);
        }


        /// <summary>
        /// Provides information about the specified Medical Scribe job.
        /// 
        ///  
        /// <para>
        /// To view the status of the specified medical transcription job, check the <c>MedicalScribeJobStatus</c>
        /// field. If the status is <c>COMPLETED</c>, the job is finished. You can find the results
        /// at the location specified in <c>MedicalScribeOutput</c>. If the status is <c>FAILED</c>,
        /// <c>FailureReason</c> provides details on why your Medical Scribe job failed.
        /// </para>
        ///  
        /// <para>
        /// To get a list of your Medical Scribe jobs, use the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalScribeJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMedicalScribeJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetMedicalScribeJob">REST API Reference for GetMedicalScribeJob Operation</seealso>
        public virtual Task<GetMedicalScribeJobResponse> GetMedicalScribeJobAsync(GetMedicalScribeJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMedicalScribeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMedicalScribeJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMedicalScribeJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMedicalTranscriptionJob


        /// <summary>
        /// Provides information about the specified medical transcription job.
        /// 
        ///  
        /// <para>
        /// To view the status of the specified medical transcription job, check the <c>TranscriptionJobStatus</c>
        /// field. If the status is <c>COMPLETED</c>, the job is finished. You can find the results
        /// at the location specified in <c>TranscriptFileUri</c>. If the status is <c>FAILED</c>,
        /// <c>FailureReason</c> provides details on why your transcription job failed.
        /// </para>
        ///  
        /// <para>
        /// To get a list of your medical transcription jobs, use the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the GetMedicalTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual GetMedicalTranscriptionJobResponse GetMedicalTranscriptionJob(GetMedicalTranscriptionJobRequest request)
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
        /// To view the status of the specified medical transcription job, check the <c>TranscriptionJobStatus</c>
        /// field. If the status is <c>COMPLETED</c>, the job is finished. You can find the results
        /// at the location specified in <c>TranscriptFileUri</c>. If the status is <c>FAILED</c>,
        /// <c>FailureReason</c> provides details on why your transcription job failed.
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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


        /// <summary>
        /// Provides information about the specified custom medical vocabulary.
        /// 
        ///  
        /// <para>
        /// To view the status of the specified custom medical vocabulary, check the <c>VocabularyState</c>
        /// field. If the status is <c>READY</c>, your custom vocabulary is available to use.
        /// If the status is <c>FAILED</c>, <c>FailureReason</c> provides details on why your
        /// vocabulary failed.
        /// </para>
        ///  
        /// <para>
        /// To get a list of your custom medical vocabularies, use the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalVocabulary service method.</param>
        /// 
        /// <returns>The response from the GetMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual GetMedicalVocabularyResponse GetMedicalVocabulary(GetMedicalVocabularyRequest request)
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
        /// To view the status of the specified custom medical vocabulary, check the <c>VocabularyState</c>
        /// field. If the status is <c>READY</c>, your custom vocabulary is available to use.
        /// If the status is <c>FAILED</c>, <c>FailureReason</c> provides details on why your
        /// vocabulary failed.
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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


        /// <summary>
        /// Provides information about the specified transcription job.
        /// 
        ///  
        /// <para>
        /// To view the status of the specified transcription job, check the <c>TranscriptionJobStatus</c>
        /// field. If the status is <c>COMPLETED</c>, the job is finished. You can find the results
        /// at the location specified in <c>TranscriptFileUri</c>. If the status is <c>FAILED</c>,
        /// <c>FailureReason</c> provides details on why your transcription job failed.
        /// </para>
        ///  
        /// <para>
        /// If you enabled content redaction, the redacted transcript can be found at the location
        /// specified in <c>RedactedTranscriptFileUri</c>.
        /// </para>
        ///  
        /// <para>
        /// To get a list of your transcription jobs, use the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the GetTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual GetTranscriptionJobResponse GetTranscriptionJob(GetTranscriptionJobRequest request)
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
        /// To view the status of the specified transcription job, check the <c>TranscriptionJobStatus</c>
        /// field. If the status is <c>COMPLETED</c>, the job is finished. You can find the results
        /// at the location specified in <c>TranscriptFileUri</c>. If the status is <c>FAILED</c>,
        /// <c>FailureReason</c> provides details on why your transcription job failed.
        /// </para>
        ///  
        /// <para>
        /// If you enabled content redaction, the redacted transcript can be found at the location
        /// specified in <c>RedactedTranscriptFileUri</c>.
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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


        /// <summary>
        /// Provides information about the specified custom vocabulary.
        /// 
        ///  
        /// <para>
        /// To view the status of the specified custom vocabulary, check the <c>VocabularyState</c>
        /// field. If the status is <c>READY</c>, your custom vocabulary is available to use.
        /// If the status is <c>FAILED</c>, <c>FailureReason</c> provides details on why your
        /// custom vocabulary failed.
        /// </para>
        ///  
        /// <para>
        /// To get a list of your custom vocabularies, use the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVocabulary service method.</param>
        /// 
        /// <returns>The response from the GetVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual GetVocabularyResponse GetVocabulary(GetVocabularyRequest request)
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
        /// To view the status of the specified custom vocabulary, check the <c>VocabularyState</c>
        /// field. If the status is <c>READY</c>, your custom vocabulary is available to use.
        /// If the status is <c>FAILED</c>, <c>FailureReason</c> provides details on why your
        /// custom vocabulary failed.
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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


        /// <summary>
        /// Provides information about the specified custom vocabulary filter.
        /// 
        ///  
        /// <para>
        /// To get a list of your custom vocabulary filters, use the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVocabularyFilter service method.</param>
        /// 
        /// <returns>The response from the GetVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual GetVocabularyFilterResponse GetVocabularyFilter(GetVocabularyFilterRequest request)
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        /// 
        /// <returns>The response from the ListCallAnalyticsCategories service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual ListCallAnalyticsCategoriesResponse ListCallAnalyticsCategories(ListCallAnalyticsCategoriesRequest request)
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        /// 
        /// <returns>The response from the ListCallAnalyticsJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual ListCallAnalyticsJobsResponse ListCallAnalyticsJobs(ListCallAnalyticsJobsRequest request)
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        /// 
        /// <returns>The response from the ListLanguageModels service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual ListLanguageModelsResponse ListLanguageModels(ListLanguageModelsRequest request)
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        
        #region  ListMedicalScribeJobs


        /// <summary>
        /// Provides a list of Medical Scribe jobs that match the specified criteria. If no criteria
        /// are specified, all Medical Scribe jobs are returned.
        /// 
        ///  
        /// <para>
        /// To get detailed information about a specific Medical Scribe job, use the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMedicalScribeJobs service method.</param>
        /// 
        /// <returns>The response from the ListMedicalScribeJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListMedicalScribeJobs">REST API Reference for ListMedicalScribeJobs Operation</seealso>
        public virtual ListMedicalScribeJobsResponse ListMedicalScribeJobs(ListMedicalScribeJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMedicalScribeJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMedicalScribeJobsResponseUnmarshaller.Instance;

            return Invoke<ListMedicalScribeJobsResponse>(request, options);
        }


        /// <summary>
        /// Provides a list of Medical Scribe jobs that match the specified criteria. If no criteria
        /// are specified, all Medical Scribe jobs are returned.
        /// 
        ///  
        /// <para>
        /// To get detailed information about a specific Medical Scribe job, use the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMedicalScribeJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMedicalScribeJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message, correct the issue, and try your
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// You've either sent too many requests or your input file is too long. Wait before retrying
        /// your request, or use a smaller file and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListMedicalScribeJobs">REST API Reference for ListMedicalScribeJobs Operation</seealso>
        public virtual Task<ListMedicalScribeJobsResponse> ListMedicalScribeJobsAsync(ListMedicalScribeJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMedicalScribeJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMedicalScribeJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMedicalScribeJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMedicalTranscriptionJobs


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
        /// 
        /// <returns>The response from the ListMedicalTranscriptionJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual ListMedicalTranscriptionJobsResponse ListMedicalTranscriptionJobs(ListMedicalTranscriptionJobsRequest request)
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        /// 
        /// <returns>The response from the ListMedicalVocabularies service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual ListMedicalVocabulariesResponse ListMedicalVocabularies(ListMedicalVocabulariesRequest request)
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        /// 
        /// <returns>The response from the ListTranscriptionJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual ListTranscriptionJobsResponse ListTranscriptionJobs(ListTranscriptionJobsRequest request)
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        /// 
        /// <returns>The response from the ListVocabularies service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual ListVocabulariesResponse ListVocabularies(ListVocabulariesRequest request)
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        /// 
        /// <returns>The response from the ListVocabularyFilters service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual ListVocabularyFiltersResponse ListVocabularyFilters(ListVocabularyFiltersRequest request)
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        /// categories for post-call transcriptions</a> and <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-categories-stream.html">Creating
        /// categories for real-time transcriptions</a>.
        /// </para>
        ///  
        /// <para>
        /// To make a <c>StartCallAnalyticsJob</c> request, you must first upload your media file
        /// into an Amazon S3 bucket; you can then specify the Amazon S3 location of the file
        /// using the <c>Media</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// Note that job queuing is enabled by default for Call Analytics jobs.
        /// </para>
        ///  
        /// <para>
        /// You must include the following parameters in your <c>StartCallAnalyticsJob</c> request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>region</c>: The Amazon Web Services Region where you are making your request.
        /// For a list of Amazon Web Services Regions supported with Amazon Transcribe, refer
        /// to <a href="https://docs.aws.amazon.com/general/latest/gr/transcribe.html">Amazon
        /// Transcribe endpoints and quotas</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CallAnalyticsJobName</c>: A custom name that you create for your transcription
        /// job that's unique within your Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DataAccessRoleArn</c>: The Amazon Resource Name (ARN) of an IAM role that has
        /// permissions to access the Amazon S3 bucket that contains your input files.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Media</c> (<c>MediaFileUri</c> or <c>RedactedMediaFileUri</c>): The Amazon S3
        /// location of your media file.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// With Call Analytics, you can redact the audio contained in your media file by including
        /// <c>RedactedMediaFileUri</c>, instead of <c>MediaFileUri</c>, to specify the location
        /// of your input audio. If you choose to redact your audio, you can find your redacted
        /// media at the location specified in the <c>RedactedMediaFileUri</c> field of your response.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCallAnalyticsJob service method.</param>
        /// 
        /// <returns>The response from the StartCallAnalyticsJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual StartCallAnalyticsJobResponse StartCallAnalyticsJob(StartCallAnalyticsJobRequest request)
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
        /// categories for post-call transcriptions</a> and <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-categories-stream.html">Creating
        /// categories for real-time transcriptions</a>.
        /// </para>
        ///  
        /// <para>
        /// To make a <c>StartCallAnalyticsJob</c> request, you must first upload your media file
        /// into an Amazon S3 bucket; you can then specify the Amazon S3 location of the file
        /// using the <c>Media</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// Note that job queuing is enabled by default for Call Analytics jobs.
        /// </para>
        ///  
        /// <para>
        /// You must include the following parameters in your <c>StartCallAnalyticsJob</c> request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>region</c>: The Amazon Web Services Region where you are making your request.
        /// For a list of Amazon Web Services Regions supported with Amazon Transcribe, refer
        /// to <a href="https://docs.aws.amazon.com/general/latest/gr/transcribe.html">Amazon
        /// Transcribe endpoints and quotas</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CallAnalyticsJobName</c>: A custom name that you create for your transcription
        /// job that's unique within your Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DataAccessRoleArn</c>: The Amazon Resource Name (ARN) of an IAM role that has
        /// permissions to access the Amazon S3 bucket that contains your input files.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Media</c> (<c>MediaFileUri</c> or <c>RedactedMediaFileUri</c>): The Amazon S3
        /// location of your media file.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// With Call Analytics, you can redact the audio contained in your media file by including
        /// <c>RedactedMediaFileUri</c>, instead of <c>MediaFileUri</c>, to specify the location
        /// of your input audio. If you choose to redact your audio, you can find your redacted
        /// media at the location specified in the <c>RedactedMediaFileUri</c> field of your response.
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        
        #region  StartMedicalScribeJob


        /// <summary>
        /// Transcribes patient-clinician conversations and generates clinical notes. 
        /// 
        ///  
        /// <para>
        /// Amazon Web Services HealthScribe automatically provides rich conversation transcripts,
        /// identifies speaker roles, classifies dialogues, extracts medical terms, and generates
        /// preliminary clinical notes. To learn more about these features, refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/health-scribe.html">Amazon
        /// Web Services HealthScribe</a>.
        /// </para>
        ///  
        /// <para>
        /// To make a <c>StartMedicalScribeJob</c> request, you must first upload your media file
        /// into an Amazon S3 bucket; you can then specify the Amazon S3 location of the file
        /// using the <c>Media</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// You must include the following parameters in your <c>StartMedicalTranscriptionJob</c>
        /// request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DataAccessRoleArn</c>: The ARN of an IAM role with the these minimum permissions:
        /// read permission on input file Amazon S3 bucket specified in <c>Media</c>, write permission
        /// on the Amazon S3 bucket specified in <c>OutputBucketName</c>, and full permissions
        /// on the KMS key specified in <c>OutputEncryptionKMSKeyId</c> (if set). The role should
        /// also allow <c>transcribe.amazonaws.com</c> to assume it. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Media</c> (<c>MediaFileUri</c>): The Amazon S3 location of your media file.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MedicalScribeJobName</c>: A custom name you create for your MedicalScribe job
        /// that is unique within your Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OutputBucketName</c>: The Amazon S3 bucket where you want your output files stored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Settings</c>: A <c>MedicalScribeSettings</c> obect that must set exactly one of
        /// <c>ShowSpeakerLabels</c> or <c>ChannelIdentification</c> to true. If <c>ShowSpeakerLabels</c>
        /// is true, <c>MaxSpeakerLabels</c> must also be set. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ChannelDefinitions</c>: A <c>MedicalScribeChannelDefinitions</c> array should
        /// be set if and only if the <c>ChannelIdentification</c> value of <c>Settings</c> is
        /// set to true. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMedicalScribeJob service method.</param>
        /// 
        /// <returns>The response from the StartMedicalScribeJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartMedicalScribeJob">REST API Reference for StartMedicalScribeJob Operation</seealso>
        public virtual StartMedicalScribeJobResponse StartMedicalScribeJob(StartMedicalScribeJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMedicalScribeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMedicalScribeJobResponseUnmarshaller.Instance;

            return Invoke<StartMedicalScribeJobResponse>(request, options);
        }


        /// <summary>
        /// Transcribes patient-clinician conversations and generates clinical notes. 
        /// 
        ///  
        /// <para>
        /// Amazon Web Services HealthScribe automatically provides rich conversation transcripts,
        /// identifies speaker roles, classifies dialogues, extracts medical terms, and generates
        /// preliminary clinical notes. To learn more about these features, refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/health-scribe.html">Amazon
        /// Web Services HealthScribe</a>.
        /// </para>
        ///  
        /// <para>
        /// To make a <c>StartMedicalScribeJob</c> request, you must first upload your media file
        /// into an Amazon S3 bucket; you can then specify the Amazon S3 location of the file
        /// using the <c>Media</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// You must include the following parameters in your <c>StartMedicalTranscriptionJob</c>
        /// request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DataAccessRoleArn</c>: The ARN of an IAM role with the these minimum permissions:
        /// read permission on input file Amazon S3 bucket specified in <c>Media</c>, write permission
        /// on the Amazon S3 bucket specified in <c>OutputBucketName</c>, and full permissions
        /// on the KMS key specified in <c>OutputEncryptionKMSKeyId</c> (if set). The role should
        /// also allow <c>transcribe.amazonaws.com</c> to assume it. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Media</c> (<c>MediaFileUri</c>): The Amazon S3 location of your media file.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MedicalScribeJobName</c>: A custom name you create for your MedicalScribe job
        /// that is unique within your Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OutputBucketName</c>: The Amazon S3 bucket where you want your output files stored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Settings</c>: A <c>MedicalScribeSettings</c> obect that must set exactly one of
        /// <c>ShowSpeakerLabels</c> or <c>ChannelIdentification</c> to true. If <c>ShowSpeakerLabels</c>
        /// is true, <c>MaxSpeakerLabels</c> must also be set. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ChannelDefinitions</c>: A <c>MedicalScribeChannelDefinitions</c> array should
        /// be set if and only if the <c>ChannelIdentification</c> value of <c>Settings</c> is
        /// set to true. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMedicalScribeJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMedicalScribeJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartMedicalScribeJob">REST API Reference for StartMedicalScribeJob Operation</seealso>
        public virtual Task<StartMedicalScribeJobResponse> StartMedicalScribeJobAsync(StartMedicalScribeJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMedicalScribeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMedicalScribeJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartMedicalScribeJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartMedicalTranscriptionJob


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
        /// To make a <c>StartMedicalTranscriptionJob</c> request, you must first upload your
        /// media file into an Amazon S3 bucket; you can then specify the Amazon S3 location of
        /// the file using the <c>Media</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// You must include the following parameters in your <c>StartMedicalTranscriptionJob</c>
        /// request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>region</c>: The Amazon Web Services Region where you are making your request.
        /// For a list of Amazon Web Services Regions supported with Amazon Transcribe, refer
        /// to <a href="https://docs.aws.amazon.com/general/latest/gr/transcribe.html">Amazon
        /// Transcribe endpoints and quotas</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MedicalTranscriptionJobName</c>: A custom name you create for your transcription
        /// job that is unique within your Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Media</c> (<c>MediaFileUri</c>): The Amazon S3 location of your media file.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LanguageCode</c>: This must be <c>en-US</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OutputBucketName</c>: The Amazon S3 bucket where you want your transcript stored.
        /// If you want your output stored in a sub-folder of this bucket, you must also include
        /// <c>OutputKey</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Specialty</c>: This must be <c>PRIMARYCARE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Type</c>: Choose whether your audio is a conversation or a dictation.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMedicalTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the StartMedicalTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual StartMedicalTranscriptionJobResponse StartMedicalTranscriptionJob(StartMedicalTranscriptionJobRequest request)
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
        /// To make a <c>StartMedicalTranscriptionJob</c> request, you must first upload your
        /// media file into an Amazon S3 bucket; you can then specify the Amazon S3 location of
        /// the file using the <c>Media</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// You must include the following parameters in your <c>StartMedicalTranscriptionJob</c>
        /// request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>region</c>: The Amazon Web Services Region where you are making your request.
        /// For a list of Amazon Web Services Regions supported with Amazon Transcribe, refer
        /// to <a href="https://docs.aws.amazon.com/general/latest/gr/transcribe.html">Amazon
        /// Transcribe endpoints and quotas</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MedicalTranscriptionJobName</c>: A custom name you create for your transcription
        /// job that is unique within your Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Media</c> (<c>MediaFileUri</c>): The Amazon S3 location of your media file.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LanguageCode</c>: This must be <c>en-US</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OutputBucketName</c>: The Amazon S3 bucket where you want your transcript stored.
        /// If you want your output stored in a sub-folder of this bucket, you must also include
        /// <c>OutputKey</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Specialty</c>: This must be <c>PRIMARYCARE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Type</c>: Choose whether your audio is a conversation or a dictation.
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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


        /// <summary>
        /// Transcribes the audio from a media file and applies any additional Request Parameters
        /// you choose to include in your request.
        /// 
        ///  
        /// <para>
        /// To make a <c>StartTranscriptionJob</c> request, you must first upload your media file
        /// into an Amazon S3 bucket; you can then specify the Amazon S3 location of the file
        /// using the <c>Media</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// You must include the following parameters in your <c>StartTranscriptionJob</c> request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>region</c>: The Amazon Web Services Region where you are making your request.
        /// For a list of Amazon Web Services Regions supported with Amazon Transcribe, refer
        /// to <a href="https://docs.aws.amazon.com/general/latest/gr/transcribe.html">Amazon
        /// Transcribe endpoints and quotas</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TranscriptionJobName</c>: A custom name you create for your transcription job
        /// that is unique within your Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Media</c> (<c>MediaFileUri</c>): The Amazon S3 location of your media file.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// One of <c>LanguageCode</c>, <c>IdentifyLanguage</c>, or <c>IdentifyMultipleLanguages</c>:
        /// If you know the language of your media file, specify it using the <c>LanguageCode</c>
        /// parameter; you can find all valid language codes in the <a href="https://docs.aws.amazon.com/transcribe/latest/dg/supported-languages.html">Supported
        /// languages</a> table. If you do not know the languages spoken in your media, use either
        /// <c>IdentifyLanguage</c> or <c>IdentifyMultipleLanguages</c> and let Amazon Transcribe
        /// identify the languages for you.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the StartTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual StartTranscriptionJobResponse StartTranscriptionJob(StartTranscriptionJobRequest request)
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
        /// To make a <c>StartTranscriptionJob</c> request, you must first upload your media file
        /// into an Amazon S3 bucket; you can then specify the Amazon S3 location of the file
        /// using the <c>Media</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// You must include the following parameters in your <c>StartTranscriptionJob</c> request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>region</c>: The Amazon Web Services Region where you are making your request.
        /// For a list of Amazon Web Services Regions supported with Amazon Transcribe, refer
        /// to <a href="https://docs.aws.amazon.com/general/latest/gr/transcribe.html">Amazon
        /// Transcribe endpoints and quotas</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TranscriptionJobName</c>: A custom name you create for your transcription job
        /// that is unique within your Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Media</c> (<c>MediaFileUri</c>): The Amazon S3 location of your media file.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// One of <c>LanguageCode</c>, <c>IdentifyLanguage</c>, or <c>IdentifyMultipleLanguages</c>:
        /// If you know the language of your media file, specify it using the <c>LanguageCode</c>
        /// parameter; you can find all valid language codes in the <a href="https://docs.aws.amazon.com/transcribe/latest/dg/supported-languages.html">Supported
        /// languages</a> table. If you do not know the languages spoken in your media, use either
        /// <c>IdentifyLanguage</c> or <c>IdentifyMultipleLanguages</c> and let Amazon Transcribe
        /// identify the languages for you.
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        /// 
        /// <returns>The response from the TagResource service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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


        /// <summary>
        /// Removes the specified tags from the specified Amazon Transcribe resource.
        /// 
        ///  
        /// <para>
        /// If you include <c>UntagResource</c> in your request, you must also include <c>ResourceArn</c>
        /// and <c>TagKeys</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
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
        /// If you include <c>UntagResource</c> in your request, you must also include <c>ResourceArn</c>
        /// and <c>TagKeys</c>.
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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


        /// <summary>
        /// Updates the specified Call Analytics category with new rules. Note that the <c>UpdateCallAnalyticsCategory</c>
        /// operation overwrites all existing rules contained in the specified category. You cannot
        /// append additional rules onto an existing category.
        /// 
        ///  
        /// <para>
        /// To create a new category, see .
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCallAnalyticsCategory service method.</param>
        /// 
        /// <returns>The response from the UpdateCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual UpdateCallAnalyticsCategoryResponse UpdateCallAnalyticsCategory(UpdateCallAnalyticsCategoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCallAnalyticsCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCallAnalyticsCategoryResponseUnmarshaller.Instance;

            return Invoke<UpdateCallAnalyticsCategoryResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified Call Analytics category with new rules. Note that the <c>UpdateCallAnalyticsCategory</c>
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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


        /// <summary>
        /// Updates an existing custom medical vocabulary with new values. This operation overwrites
        /// all existing information with your new values; you cannot append new terms onto an
        /// existing custom vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMedicalVocabulary service method.</param>
        /// 
        /// <returns>The response from the UpdateMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual UpdateMedicalVocabularyResponse UpdateMedicalVocabulary(UpdateMedicalVocabularyRequest request)
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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


        /// <summary>
        /// Updates an existing custom vocabulary with new values. This operation overwrites all
        /// existing information with your new values; you cannot append new terms onto an existing
        /// custom vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVocabulary service method.</param>
        /// 
        /// <returns>The response from the UpdateVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual UpdateVocabularyResponse UpdateVocabulary(UpdateVocabularyRequest request)
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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


        /// <summary>
        /// Updates an existing custom vocabulary filter with a new list of words. The new list
        /// you provide overwrites all previous entries; you cannot append new terms onto an existing
        /// custom vocabulary filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVocabularyFilter service method.</param>
        /// 
        /// <returns>The response from the UpdateVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. This can occur when the entity
        /// you're trying to delete doesn't exist or if it's in a non-terminal state (such as
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        public virtual UpdateVocabularyFilterResponse UpdateVocabularyFilter(UpdateVocabularyFilterRequest request)
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
        /// <c>IN PROGRESS</c>). See the exception message field for more information.
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
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var requestContext = new RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonTranscribeServiceEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}