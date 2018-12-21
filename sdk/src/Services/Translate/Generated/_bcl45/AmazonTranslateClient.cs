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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Translate.Model;
using Amazon.Translate.Model.Internal.MarshallTransformations;
using Amazon.Translate.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Translate
{
    /// <summary>
    /// Implementation for accessing Translate
    ///
    /// Provides translation between one source language and another of the same set of languages.
    /// </summary>
    public partial class AmazonTranslateClient : AmazonServiceClient, IAmazonTranslate
    {
        private static IServiceMetadata serviceMetadata = new AmazonTranslateMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonTranslateClient with the credentials loaded from the application's
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
        public AmazonTranslateClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTranslateConfig()) { }

        /// <summary>
        /// Constructs AmazonTranslateClient with the credentials loaded from the application's
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
        public AmazonTranslateClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTranslateConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonTranslateClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonTranslateClient Configuration Object</param>
        public AmazonTranslateClient(AmazonTranslateConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonTranslateClient(AWSCredentials credentials)
            : this(credentials, new AmazonTranslateConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTranslateClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonTranslateConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Credentials and an
        /// AmazonTranslateClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonTranslateClient Configuration Object</param>
        public AmazonTranslateClient(AWSCredentials credentials, AmazonTranslateConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonTranslateClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTranslateConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTranslateClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTranslateConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTranslateClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonTranslateClient Configuration Object</param>
        public AmazonTranslateClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonTranslateConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonTranslateClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTranslateConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTranslateClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTranslateConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTranslateClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonTranslateClient Configuration Object</param>
        public AmazonTranslateClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonTranslateConfig clientConfig)
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


        #region  DeleteTerminology


        /// <summary>
        /// A synchronous action that deletes a custom terminology.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTerminology service method.</param>
        /// 
        /// <returns>The response from the DeleteTerminology service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request. .
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/DeleteTerminology">REST API Reference for DeleteTerminology Operation</seealso>
        public virtual DeleteTerminologyResponse DeleteTerminology(DeleteTerminologyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTerminologyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTerminologyResponseUnmarshaller.Instance;

            return Invoke<DeleteTerminologyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTerminology operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTerminology operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/DeleteTerminology">REST API Reference for DeleteTerminology Operation</seealso>
        public virtual Task<DeleteTerminologyResponse> DeleteTerminologyAsync(DeleteTerminologyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTerminologyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTerminologyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteTerminologyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTerminology


        /// <summary>
        /// Retrieves a custom terminology.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTerminology service method.</param>
        /// 
        /// <returns>The response from the GetTerminology service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is invalid. Review the value of the parameter you are using
        /// to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request. .
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/GetTerminology">REST API Reference for GetTerminology Operation</seealso>
        public virtual GetTerminologyResponse GetTerminology(GetTerminologyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTerminologyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTerminologyResponseUnmarshaller.Instance;

            return Invoke<GetTerminologyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTerminology operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTerminology operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/GetTerminology">REST API Reference for GetTerminology Operation</seealso>
        public virtual Task<GetTerminologyResponse> GetTerminologyAsync(GetTerminologyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTerminologyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTerminologyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetTerminologyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportTerminology


        /// <summary>
        /// Creates or updates a custom terminology, depending on whether or not one already exists
        /// for the given terminology name. Importing a terminology with the same name as an existing
        /// one will merge the terminologies based on the chosen merge strategy. Currently, the
        /// only supported merge strategy is OVERWRITE, and so the imported terminology will overwrite
        /// an existing terminology of the same name.
        /// 
        ///  
        /// <para>
        /// If you import a terminology that overwrites an existing one, the new terminology take
        /// up to 10 minutes to fully propagate and be available for use in a translation due
        /// to cache policies with the DataPlane service that performs the translations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportTerminology service method.</param>
        /// 
        /// <returns>The response from the ImportTerminology service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is invalid. Review the value of the parameter you are using
        /// to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.LimitExceededException">
        /// The specified limit has been exceeded. Review your request and retry it with a quantity
        /// below the stated limit.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ImportTerminology">REST API Reference for ImportTerminology Operation</seealso>
        public virtual ImportTerminologyResponse ImportTerminology(ImportTerminologyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportTerminologyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportTerminologyResponseUnmarshaller.Instance;

            return Invoke<ImportTerminologyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportTerminology operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportTerminology operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ImportTerminology">REST API Reference for ImportTerminology Operation</seealso>
        public virtual Task<ImportTerminologyResponse> ImportTerminologyAsync(ImportTerminologyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportTerminologyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportTerminologyResponseUnmarshaller.Instance;
            
            return InvokeAsync<ImportTerminologyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTerminologies


        /// <summary>
        /// Provides a list of custom terminologies associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTerminologies service method.</param>
        /// 
        /// <returns>The response from the ListTerminologies service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is invalid. Review the value of the parameter you are using
        /// to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListTerminologies">REST API Reference for ListTerminologies Operation</seealso>
        public virtual ListTerminologiesResponse ListTerminologies(ListTerminologiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTerminologiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTerminologiesResponseUnmarshaller.Instance;

            return Invoke<ListTerminologiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTerminologies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTerminologies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListTerminologies">REST API Reference for ListTerminologies Operation</seealso>
        public virtual Task<ListTerminologiesResponse> ListTerminologiesAsync(ListTerminologiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTerminologiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTerminologiesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTerminologiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TranslateText


        /// <summary>
        /// Translates input text from the source language to the target language. It is not necessary
        /// to use English (en) as either the source or the target language but not all language
        /// combinations are supported by Amazon Translate. For more information, see <a href="http://docs.aws.amazon.com/translate/latest/dg/pairs.html">Supported
        /// Language Pairs</a>.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Arabic (ar)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Chinese (Simplified) (zh)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Chinese (Traditional) (zh-TW)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Czech (cs)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Danish (da)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Dutch (nl)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// English (en)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Finnish (fi)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// French (fr)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// German (de)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Hebrew (he)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Indonesian (id)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Italian (it)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Japanese (ja)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Korean (ko)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Polish (pl)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Portuguese (pt)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Russian (ru)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Spanish (es)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Swedish (sv)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Turkish (tr)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To have Amazon Translate determine the source language of your text, you can specify
        /// <code>auto</code> in the <code>SourceLanguageCode</code> field. If you specify <code>auto</code>,
        /// Amazon Translate will call Amazon Comprehend to determine the source language.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TranslateText service method.</param>
        /// 
        /// <returns>The response from the TranslateText service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.DetectedLanguageLowConfidenceException">
        /// The confidence that Amazon Comprehend accurately detected the source language is low.
        /// If a low confidence level is acceptable for your application, you can use the language
        /// in the exception to call Amazon Translate again. For more information, see the <a
        /// href="https://docs.aws.amazon.com/comprehend/latest/dg/API_DetectDominantLanguage.html">DetectDominantLanguage</a>
        /// operation in the <i>Amazon Comprehend Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request. .
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ServiceUnavailableException">
        /// The Amazon Translate service is temporarily unavailable. Please wait a bit and then
        /// retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TextSizeLimitExceededException">
        /// The size of the text you submitted exceeds the size limit. Reduce the size of the
        /// text or use a smaller document and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.UnsupportedLanguagePairException">
        /// Amazon Translate does not support translation from the language of the source text
        /// into the requested target language. For more information, see <a>how-to-error-msg</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/TranslateText">REST API Reference for TranslateText Operation</seealso>
        public virtual TranslateTextResponse TranslateText(TranslateTextRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TranslateTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TranslateTextResponseUnmarshaller.Instance;

            return Invoke<TranslateTextResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TranslateText operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TranslateText operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/TranslateText">REST API Reference for TranslateText Operation</seealso>
        public virtual Task<TranslateTextResponse> TranslateTextAsync(TranslateTextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TranslateTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TranslateTextResponseUnmarshaller.Instance;
            
            return InvokeAsync<TranslateTextResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}