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
    /// Provides translation of the input content from the source language to the target language.
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
#if AWS_ASYNC_ENUMERABLES_API
        private ITranslatePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ITranslatePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new TranslatePaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonTranslateEndpointResolver());
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


        #region  CreateParallelData

        internal virtual CreateParallelDataResponse CreateParallelData(CreateParallelDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateParallelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateParallelDataResponseUnmarshaller.Instance;

            return Invoke<CreateParallelDataResponse>(request, options);
        }



        /// <summary>
        /// Creates a parallel data resource in Amazon Translate by importing an input file from
        /// Amazon S3. Parallel data files contain examples that show how you want segments of
        /// text to be translated. By adding parallel data, you can influence the style, tone,
        /// and word choice in your translation output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateParallelData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateParallelData service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is not valid. Review the value of the parameter you are
        /// using to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidRequestException">
        /// The request that you made is not valid. Check your request to determine why it's
        /// not valid and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.LimitExceededException">
        /// The specified limit has been exceeded. Review your request and retry it with a quantity
        /// below the stated limit.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyTagsException">
        /// You have added too many tags to this resource. The maximum is 50 tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/CreateParallelData">REST API Reference for CreateParallelData Operation</seealso>
        public virtual Task<CreateParallelDataResponse> CreateParallelDataAsync(CreateParallelDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateParallelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateParallelDataResponseUnmarshaller.Instance;

            return InvokeAsync<CreateParallelDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteParallelData

        internal virtual DeleteParallelDataResponse DeleteParallelData(DeleteParallelDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteParallelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteParallelDataResponseUnmarshaller.Instance;

            return Invoke<DeleteParallelDataResponse>(request, options);
        }



        /// <summary>
        /// Deletes a parallel data resource in Amazon Translate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteParallelData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteParallelData service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/DeleteParallelData">REST API Reference for DeleteParallelData Operation</seealso>
        public virtual Task<DeleteParallelDataResponse> DeleteParallelDataAsync(DeleteParallelDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteParallelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteParallelDataResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteParallelDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTerminology

        internal virtual DeleteTerminologyResponse DeleteTerminology(DeleteTerminologyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTerminologyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTerminologyResponseUnmarshaller.Instance;

            return Invoke<DeleteTerminologyResponse>(request, options);
        }



        /// <summary>
        /// A synchronous action that deletes a custom terminology.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTerminology service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTerminology service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is not valid. Review the value of the parameter you are
        /// using to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/DeleteTerminology">REST API Reference for DeleteTerminology Operation</seealso>
        public virtual Task<DeleteTerminologyResponse> DeleteTerminologyAsync(DeleteTerminologyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTerminologyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTerminologyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTerminologyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTextTranslationJob

        internal virtual DescribeTextTranslationJobResponse DescribeTextTranslationJob(DescribeTextTranslationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTextTranslationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTextTranslationJobResponseUnmarshaller.Instance;

            return Invoke<DescribeTextTranslationJobResponse>(request, options);
        }



        /// <summary>
        /// Gets the properties associated with an asynchronous batch translation job including
        /// name, ID, status, source and target languages, input/output S3 buckets, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTextTranslationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTextTranslationJob service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/DescribeTextTranslationJob">REST API Reference for DescribeTextTranslationJob Operation</seealso>
        public virtual Task<DescribeTextTranslationJobResponse> DescribeTextTranslationJobAsync(DescribeTextTranslationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTextTranslationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTextTranslationJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTextTranslationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetParallelData

        internal virtual GetParallelDataResponse GetParallelData(GetParallelDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParallelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParallelDataResponseUnmarshaller.Instance;

            return Invoke<GetParallelDataResponse>(request, options);
        }



        /// <summary>
        /// Provides information about a parallel data resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParallelData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetParallelData service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is not valid. Review the value of the parameter you are
        /// using to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/GetParallelData">REST API Reference for GetParallelData Operation</seealso>
        public virtual Task<GetParallelDataResponse> GetParallelDataAsync(GetParallelDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParallelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParallelDataResponseUnmarshaller.Instance;

            return InvokeAsync<GetParallelDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTerminology

        internal virtual GetTerminologyResponse GetTerminology(GetTerminologyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTerminologyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTerminologyResponseUnmarshaller.Instance;

            return Invoke<GetTerminologyResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a custom terminology.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTerminology service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTerminology service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is not valid. Review the value of the parameter you are
        /// using to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
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

        internal virtual ImportTerminologyResponse ImportTerminology(ImportTerminologyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportTerminologyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportTerminologyResponseUnmarshaller.Instance;

            return Invoke<ImportTerminologyResponse>(request, options);
        }



        /// <summary>
        /// Creates or updates a custom terminology, depending on whether one already exists for
        /// the given terminology name. Importing a terminology with the same name as an existing
        /// one will merge the terminologies based on the chosen merge strategy. The only supported
        /// merge strategy is OVERWRITE, where the imported terminology overwrites the existing
        /// terminology of the same name.
        /// 
        ///  
        /// <para>
        /// If you import a terminology that overwrites an existing one, the new terminology takes
        /// up to 10 minutes to fully propagate. After that, translations have access to the new
        /// terminology.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportTerminology service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportTerminology service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is not valid. Review the value of the parameter you are
        /// using to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.LimitExceededException">
        /// The specified limit has been exceeded. Review your request and retry it with a quantity
        /// below the stated limit.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyTagsException">
        /// You have added too many tags to this resource. The maximum is 50 tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ImportTerminology">REST API Reference for ImportTerminology Operation</seealso>
        public virtual Task<ImportTerminologyResponse> ImportTerminologyAsync(ImportTerminologyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportTerminologyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportTerminologyResponseUnmarshaller.Instance;

            return InvokeAsync<ImportTerminologyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLanguages

        internal virtual ListLanguagesResponse ListLanguages(ListLanguagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLanguagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLanguagesResponseUnmarshaller.Instance;

            return Invoke<ListLanguagesResponse>(request, options);
        }



        /// <summary>
        /// Provides a list of languages (RFC-5646 codes and names) that Amazon Translate supports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLanguages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLanguages service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is not valid. Review the value of the parameter you are
        /// using to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.UnsupportedDisplayLanguageCodeException">
        /// Requested display language code is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListLanguages">REST API Reference for ListLanguages Operation</seealso>
        public virtual Task<ListLanguagesResponse> ListLanguagesAsync(ListLanguagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLanguagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLanguagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListLanguagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListParallelData

        internal virtual ListParallelDataResponse ListParallelData(ListParallelDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListParallelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListParallelDataResponseUnmarshaller.Instance;

            return Invoke<ListParallelDataResponse>(request, options);
        }



        /// <summary>
        /// Provides a list of your parallel data resources in Amazon Translate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListParallelData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListParallelData service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is not valid. Review the value of the parameter you are
        /// using to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListParallelData">REST API Reference for ListParallelData Operation</seealso>
        public virtual Task<ListParallelDataResponse> ListParallelDataAsync(ListParallelDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListParallelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListParallelDataResponseUnmarshaller.Instance;

            return InvokeAsync<ListParallelDataResponse>(request, options, cancellationToken);
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
        /// Lists all tags associated with a given Amazon Translate resource. For more information,
        /// see <a href="https://docs.aws.amazon.com/translate/latest/dg/tagging.html"> Tagging
        /// your resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is not valid. Review the value of the parameter you are
        /// using to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTerminologies

        internal virtual ListTerminologiesResponse ListTerminologies(ListTerminologiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTerminologiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTerminologiesResponseUnmarshaller.Instance;

            return Invoke<ListTerminologiesResponse>(request, options);
        }



        /// <summary>
        /// Provides a list of custom terminologies associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTerminologies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTerminologies service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is not valid. Review the value of the parameter you are
        /// using to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListTerminologies">REST API Reference for ListTerminologies Operation</seealso>
        public virtual Task<ListTerminologiesResponse> ListTerminologiesAsync(ListTerminologiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTerminologiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTerminologiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTerminologiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTextTranslationJobs

        internal virtual ListTextTranslationJobsResponse ListTextTranslationJobs(ListTextTranslationJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTextTranslationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTextTranslationJobsResponseUnmarshaller.Instance;

            return Invoke<ListTextTranslationJobsResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of the batch translation jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTextTranslationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTextTranslationJobs service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidFilterException">
        /// The filter specified for the operation is not valid. Specify a different filter.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidRequestException">
        /// The request that you made is not valid. Check your request to determine why it's
        /// not valid and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListTextTranslationJobs">REST API Reference for ListTextTranslationJobs Operation</seealso>
        public virtual Task<ListTextTranslationJobsResponse> ListTextTranslationJobsAsync(ListTextTranslationJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTextTranslationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTextTranslationJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTextTranslationJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartTextTranslationJob

        internal virtual StartTextTranslationJobResponse StartTextTranslationJob(StartTextTranslationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTextTranslationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTextTranslationJobResponseUnmarshaller.Instance;

            return Invoke<StartTextTranslationJobResponse>(request, options);
        }



        /// <summary>
        /// Starts an asynchronous batch translation job. Use batch translation jobs to translate
        /// large volumes of text across multiple documents at once. For batch translation, you
        /// can input documents with different source languages (specify <code>auto</code> as
        /// the source language). You can specify one or more target languages. Batch translation
        /// translates each input document into each of the target languages. For more information,
        /// see <a href="https://docs.aws.amazon.com/translate/latest/dg/async.html">Asynchronous
        /// batch processing</a>.
        /// 
        ///  
        /// <para>
        /// Batch translation jobs can be described with the <a>DescribeTextTranslationJob</a>
        /// operation, listed with the <a>ListTextTranslationJobs</a> operation, and stopped with
        /// the <a>StopTextTranslationJob</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTextTranslationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartTextTranslationJob service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is not valid. Review the value of the parameter you are
        /// using to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidRequestException">
        /// The request that you made is not valid. Check your request to determine why it's
        /// not valid and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.UnsupportedLanguagePairException">
        /// Amazon Translate does not support translation from the language of the source text
        /// into the requested target language. For more information, see <a href="https://docs.aws.amazon.com/translate/latest/dg/how-to-error-msg.html">Error
        /// messages</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/StartTextTranslationJob">REST API Reference for StartTextTranslationJob Operation</seealso>
        public virtual Task<StartTextTranslationJobResponse> StartTextTranslationJobAsync(StartTextTranslationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTextTranslationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTextTranslationJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartTextTranslationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopTextTranslationJob

        internal virtual StopTextTranslationJobResponse StopTextTranslationJob(StopTextTranslationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTextTranslationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTextTranslationJobResponseUnmarshaller.Instance;

            return Invoke<StopTextTranslationJobResponse>(request, options);
        }



        /// <summary>
        /// Stops an asynchronous batch translation job that is in progress.
        /// 
        ///  
        /// <para>
        /// If the job's state is <code>IN_PROGRESS</code>, the job will be marked for termination
        /// and put into the <code>STOP_REQUESTED</code> state. If the job completes before it
        /// can be stopped, it is put into the <code>COMPLETED</code> state. Otherwise, the job
        /// is put into the <code>STOPPED</code> state.
        /// </para>
        ///  
        /// <para>
        /// Asynchronous batch translation jobs are started with the <a>StartTextTranslationJob</a>
        /// operation. You can use the <a>DescribeTextTranslationJob</a> or <a>ListTextTranslationJobs</a>
        /// operations to get a batch translation job's <code>JobId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTextTranslationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopTextTranslationJob service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/StopTextTranslationJob">REST API Reference for StopTextTranslationJob Operation</seealso>
        public virtual Task<StopTextTranslationJobResponse> StopTextTranslationJobAsync(StopTextTranslationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTextTranslationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTextTranslationJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopTextTranslationJobResponse>(request, options, cancellationToken);
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
        /// Associates a specific tag with a resource. A tag is a key-value pair that adds as
        /// a metadata to a resource. For more information, see <a href="https://docs.aws.amazon.com/translate/latest/dg/tagging.html">
        /// Tagging your resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is not valid. Review the value of the parameter you are
        /// using to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyTagsException">
        /// You have added too many tags to this resource. The maximum is 50 tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TranslateText

        internal virtual TranslateTextResponse TranslateText(TranslateTextRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TranslateTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TranslateTextResponseUnmarshaller.Instance;

            return Invoke<TranslateTextResponse>(request, options);
        }



        /// <summary>
        /// Translates input text from the source language to the target language. For a list
        /// of available languages and language codes, see <a href="https://docs.aws.amazon.com/translate/latest/dg/what-is-languages.html">Supported
        /// languages</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TranslateText service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The request that you made is not valid. Check your request to determine why it's
        /// not valid and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ServiceUnavailableException">
        /// The Amazon Translate service is temporarily unavailable. Wait a bit and then retry
        /// your request.
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
        /// into the requested target language. For more information, see <a href="https://docs.aws.amazon.com/translate/latest/dg/how-to-error-msg.html">Error
        /// messages</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/TranslateText">REST API Reference for TranslateText Operation</seealso>
        public virtual Task<TranslateTextResponse> TranslateTextAsync(TranslateTextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TranslateTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TranslateTextResponseUnmarshaller.Instance;

            return InvokeAsync<TranslateTextResponse>(request, options, cancellationToken);
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
        /// Removes a specific tag associated with an Amazon Translate resource. For more information,
        /// see <a href="https://docs.aws.amazon.com/translate/latest/dg/tagging.html"> Tagging
        /// your resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is not valid. Review the value of the parameter you are
        /// using to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateParallelData

        internal virtual UpdateParallelDataResponse UpdateParallelData(UpdateParallelDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateParallelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateParallelDataResponseUnmarshaller.Instance;

            return Invoke<UpdateParallelDataResponse>(request, options);
        }



        /// <summary>
        /// Updates a previously created parallel data resource by importing a new input file
        /// from Amazon S3.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateParallelData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateParallelData service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is not valid. Review the value of the parameter you are
        /// using to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidRequestException">
        /// The request that you made is not valid. Check your request to determine why it's
        /// not valid and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.LimitExceededException">
        /// The specified limit has been exceeded. Review your request and retry it with a quantity
        /// below the stated limit.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/UpdateParallelData">REST API Reference for UpdateParallelData Operation</seealso>
        public virtual Task<UpdateParallelDataResponse> UpdateParallelDataAsync(UpdateParallelDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateParallelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateParallelDataResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateParallelDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}