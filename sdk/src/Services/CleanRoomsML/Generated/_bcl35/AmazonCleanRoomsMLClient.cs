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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.CleanRoomsML.Model;
using Amazon.CleanRoomsML.Model.Internal.MarshallTransformations;
using Amazon.CleanRoomsML.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.CleanRoomsML
{
    /// <summary>
    /// <para>Implementation for accessing CleanRoomsML</para>
    ///
    /// Welcome to the <i>Amazon Web Services Clean Rooms ML API Reference</i>.
    /// 
    ///  
    /// <para>
    /// Amazon Web Services Clean Rooms ML provides a privacy-enhancing method for two parties
    /// to identify similar users in their data without the need to share their data with
    /// each other. The first party brings the training data to Clean Rooms so that they can
    /// create and configure an audience model (lookalike model) and associate it with a collaboration.
    /// The second party then brings their seed data to Clean Rooms and generates an audience
    /// (lookalike segment) that resembles the training data.
    /// </para>
    ///  
    /// <para>
    /// To learn more about Amazon Web Services Clean Rooms ML concepts, procedures, and best
    /// practices, see the <a href="https://docs.aws.amazon.com/clean-rooms/latest/userguide/machine-learning.html">Clean
    /// Rooms User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// To learn more about SQL commands, functions, and conditions supported in Clean Rooms,
    /// see the <a href="https://docs.aws.amazon.com/clean-rooms/latest/sql-reference/sql-reference.html">Clean
    /// Rooms SQL Reference</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCleanRoomsMLClient : AmazonServiceClient, IAmazonCleanRoomsML
    {
        private static IServiceMetadata serviceMetadata = new AmazonCleanRoomsMLMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ICleanRoomsMLPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICleanRoomsMLPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CleanRoomsMLPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonCleanRoomsMLClient with the credentials loaded from the application's
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
        public AmazonCleanRoomsMLClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCleanRoomsMLConfig()) { }

        /// <summary>
        /// Constructs AmazonCleanRoomsMLClient with the credentials loaded from the application's
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
        public AmazonCleanRoomsMLClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCleanRoomsMLConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCleanRoomsMLClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCleanRoomsMLClient Configuration Object</param>
        public AmazonCleanRoomsMLClient(AmazonCleanRoomsMLConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonCleanRoomsMLClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCleanRoomsMLClient(AWSCredentials credentials)
            : this(credentials, new AmazonCleanRoomsMLConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsMLClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCleanRoomsMLClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCleanRoomsMLConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsMLClient with AWS Credentials and an
        /// AmazonCleanRoomsMLClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCleanRoomsMLClient Configuration Object</param>
        public AmazonCleanRoomsMLClient(AWSCredentials credentials, AmazonCleanRoomsMLConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsMLClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCleanRoomsMLClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCleanRoomsMLConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsMLClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCleanRoomsMLClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCleanRoomsMLConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsMLClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCleanRoomsMLClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCleanRoomsMLClient Configuration Object</param>
        public AmazonCleanRoomsMLClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCleanRoomsMLConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsMLClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCleanRoomsMLClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCleanRoomsMLConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsMLClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCleanRoomsMLClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCleanRoomsMLConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsMLClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCleanRoomsMLClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCleanRoomsMLClient Configuration Object</param>
        public AmazonCleanRoomsMLClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCleanRoomsMLConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCleanRoomsMLEndpointResolver());
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


        #region  CancelTrainedModel

        /// <summary>
        /// Submits a request to cancel the trained model job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelTrainedModel service method.</param>
        /// 
        /// <returns>The response from the CancelTrainedModel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CancelTrainedModel">REST API Reference for CancelTrainedModel Operation</seealso>
        public virtual CancelTrainedModelResponse CancelTrainedModel(CancelTrainedModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelTrainedModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelTrainedModelResponseUnmarshaller.Instance;

            return Invoke<CancelTrainedModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelTrainedModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelTrainedModel operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelTrainedModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CancelTrainedModel">REST API Reference for CancelTrainedModel Operation</seealso>
        public virtual IAsyncResult BeginCancelTrainedModel(CancelTrainedModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelTrainedModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelTrainedModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelTrainedModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelTrainedModel.</param>
        /// 
        /// <returns>Returns a  CancelTrainedModelResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CancelTrainedModel">REST API Reference for CancelTrainedModel Operation</seealso>
        public virtual CancelTrainedModelResponse EndCancelTrainedModel(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelTrainedModelResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelTrainedModelInferenceJob

        /// <summary>
        /// Submits a request to cancel a trained model inference job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelTrainedModelInferenceJob service method.</param>
        /// 
        /// <returns>The response from the CancelTrainedModelInferenceJob service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CancelTrainedModelInferenceJob">REST API Reference for CancelTrainedModelInferenceJob Operation</seealso>
        public virtual CancelTrainedModelInferenceJobResponse CancelTrainedModelInferenceJob(CancelTrainedModelInferenceJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelTrainedModelInferenceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelTrainedModelInferenceJobResponseUnmarshaller.Instance;

            return Invoke<CancelTrainedModelInferenceJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelTrainedModelInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelTrainedModelInferenceJob operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelTrainedModelInferenceJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CancelTrainedModelInferenceJob">REST API Reference for CancelTrainedModelInferenceJob Operation</seealso>
        public virtual IAsyncResult BeginCancelTrainedModelInferenceJob(CancelTrainedModelInferenceJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelTrainedModelInferenceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelTrainedModelInferenceJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelTrainedModelInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelTrainedModelInferenceJob.</param>
        /// 
        /// <returns>Returns a  CancelTrainedModelInferenceJobResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CancelTrainedModelInferenceJob">REST API Reference for CancelTrainedModelInferenceJob Operation</seealso>
        public virtual CancelTrainedModelInferenceJobResponse EndCancelTrainedModelInferenceJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelTrainedModelInferenceJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAudienceModel

        /// <summary>
        /// Defines the information necessary to create an audience model. An audience model is
        /// a machine learning model that Clean Rooms ML trains to measure similarity between
        /// users. Clean Rooms ML manages training and storing the audience model. The audience
        /// model can be used in multiple calls to the <a>StartAudienceGenerationJob</a> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAudienceModel service method.</param>
        /// 
        /// <returns>The response from the CreateAudienceModel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateAudienceModel">REST API Reference for CreateAudienceModel Operation</seealso>
        public virtual CreateAudienceModelResponse CreateAudienceModel(CreateAudienceModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAudienceModelResponseUnmarshaller.Instance;

            return Invoke<CreateAudienceModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAudienceModel operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAudienceModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateAudienceModel">REST API Reference for CreateAudienceModel Operation</seealso>
        public virtual IAsyncResult BeginCreateAudienceModel(CreateAudienceModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAudienceModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAudienceModel.</param>
        /// 
        /// <returns>Returns a  CreateAudienceModelResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateAudienceModel">REST API Reference for CreateAudienceModel Operation</seealso>
        public virtual CreateAudienceModelResponse EndCreateAudienceModel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAudienceModelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConfiguredAudienceModel

        /// <summary>
        /// Defines the information necessary to create a configured audience model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredAudienceModel service method.</param>
        /// 
        /// <returns>The response from the CreateConfiguredAudienceModel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateConfiguredAudienceModel">REST API Reference for CreateConfiguredAudienceModel Operation</seealso>
        public virtual CreateConfiguredAudienceModelResponse CreateConfiguredAudienceModel(CreateConfiguredAudienceModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfiguredAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredAudienceModelResponseUnmarshaller.Instance;

            return Invoke<CreateConfiguredAudienceModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfiguredAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredAudienceModel operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfiguredAudienceModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateConfiguredAudienceModel">REST API Reference for CreateConfiguredAudienceModel Operation</seealso>
        public virtual IAsyncResult BeginCreateConfiguredAudienceModel(CreateConfiguredAudienceModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfiguredAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredAudienceModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfiguredAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfiguredAudienceModel.</param>
        /// 
        /// <returns>Returns a  CreateConfiguredAudienceModelResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateConfiguredAudienceModel">REST API Reference for CreateConfiguredAudienceModel Operation</seealso>
        public virtual CreateConfiguredAudienceModelResponse EndCreateConfiguredAudienceModel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConfiguredAudienceModelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConfiguredModelAlgorithm

        /// <summary>
        /// Creates a configured model algorithm using a container image stored in an ECR repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredModelAlgorithm service method.</param>
        /// 
        /// <returns>The response from the CreateConfiguredModelAlgorithm service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateConfiguredModelAlgorithm">REST API Reference for CreateConfiguredModelAlgorithm Operation</seealso>
        public virtual CreateConfiguredModelAlgorithmResponse CreateConfiguredModelAlgorithm(CreateConfiguredModelAlgorithmRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfiguredModelAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredModelAlgorithmResponseUnmarshaller.Instance;

            return Invoke<CreateConfiguredModelAlgorithmResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfiguredModelAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredModelAlgorithm operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfiguredModelAlgorithm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateConfiguredModelAlgorithm">REST API Reference for CreateConfiguredModelAlgorithm Operation</seealso>
        public virtual IAsyncResult BeginCreateConfiguredModelAlgorithm(CreateConfiguredModelAlgorithmRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfiguredModelAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredModelAlgorithmResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfiguredModelAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfiguredModelAlgorithm.</param>
        /// 
        /// <returns>Returns a  CreateConfiguredModelAlgorithmResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateConfiguredModelAlgorithm">REST API Reference for CreateConfiguredModelAlgorithm Operation</seealso>
        public virtual CreateConfiguredModelAlgorithmResponse EndCreateConfiguredModelAlgorithm(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConfiguredModelAlgorithmResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConfiguredModelAlgorithmAssociation

        /// <summary>
        /// Associates a configured model algorithm to a collaboration for use by any member of
        /// the collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredModelAlgorithmAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateConfiguredModelAlgorithmAssociation service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateConfiguredModelAlgorithmAssociation">REST API Reference for CreateConfiguredModelAlgorithmAssociation Operation</seealso>
        public virtual CreateConfiguredModelAlgorithmAssociationResponse CreateConfiguredModelAlgorithmAssociation(CreateConfiguredModelAlgorithmAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfiguredModelAlgorithmAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredModelAlgorithmAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateConfiguredModelAlgorithmAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfiguredModelAlgorithmAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredModelAlgorithmAssociation operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfiguredModelAlgorithmAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateConfiguredModelAlgorithmAssociation">REST API Reference for CreateConfiguredModelAlgorithmAssociation Operation</seealso>
        public virtual IAsyncResult BeginCreateConfiguredModelAlgorithmAssociation(CreateConfiguredModelAlgorithmAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfiguredModelAlgorithmAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredModelAlgorithmAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfiguredModelAlgorithmAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfiguredModelAlgorithmAssociation.</param>
        /// 
        /// <returns>Returns a  CreateConfiguredModelAlgorithmAssociationResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateConfiguredModelAlgorithmAssociation">REST API Reference for CreateConfiguredModelAlgorithmAssociation Operation</seealso>
        public virtual CreateConfiguredModelAlgorithmAssociationResponse EndCreateConfiguredModelAlgorithmAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConfiguredModelAlgorithmAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMLInputChannel

        /// <summary>
        /// Provides the information to create an ML input channel. An ML input channel is the
        /// result of a query that can be used for ML modeling.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMLInputChannel service method.</param>
        /// 
        /// <returns>The response from the CreateMLInputChannel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateMLInputChannel">REST API Reference for CreateMLInputChannel Operation</seealso>
        public virtual CreateMLInputChannelResponse CreateMLInputChannel(CreateMLInputChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMLInputChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMLInputChannelResponseUnmarshaller.Instance;

            return Invoke<CreateMLInputChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMLInputChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMLInputChannel operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMLInputChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateMLInputChannel">REST API Reference for CreateMLInputChannel Operation</seealso>
        public virtual IAsyncResult BeginCreateMLInputChannel(CreateMLInputChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMLInputChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMLInputChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMLInputChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMLInputChannel.</param>
        /// 
        /// <returns>Returns a  CreateMLInputChannelResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateMLInputChannel">REST API Reference for CreateMLInputChannel Operation</seealso>
        public virtual CreateMLInputChannelResponse EndCreateMLInputChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMLInputChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTrainedModel

        /// <summary>
        /// Creates a trained model from an associated configured model algorithm using data from
        /// any member of the collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrainedModel service method.</param>
        /// 
        /// <returns>The response from the CreateTrainedModel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.InternalServiceException">
        /// An internal service error occurred. Retry your request. If the problem persists, contact
        /// AWS Support.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateTrainedModel">REST API Reference for CreateTrainedModel Operation</seealso>
        public virtual CreateTrainedModelResponse CreateTrainedModel(CreateTrainedModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTrainedModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrainedModelResponseUnmarshaller.Instance;

            return Invoke<CreateTrainedModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrainedModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrainedModel operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrainedModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateTrainedModel">REST API Reference for CreateTrainedModel Operation</seealso>
        public virtual IAsyncResult BeginCreateTrainedModel(CreateTrainedModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTrainedModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrainedModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrainedModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrainedModel.</param>
        /// 
        /// <returns>Returns a  CreateTrainedModelResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateTrainedModel">REST API Reference for CreateTrainedModel Operation</seealso>
        public virtual CreateTrainedModelResponse EndCreateTrainedModel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTrainedModelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTrainingDataset

        /// <summary>
        /// Defines the information necessary to create a training dataset. In Clean Rooms ML,
        /// the <c>TrainingDataset</c> is metadata that points to a Glue table, which is read
        /// only during <c>AudienceModel</c> creation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrainingDataset service method.</param>
        /// 
        /// <returns>The response from the CreateTrainingDataset service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateTrainingDataset">REST API Reference for CreateTrainingDataset Operation</seealso>
        public virtual CreateTrainingDatasetResponse CreateTrainingDataset(CreateTrainingDatasetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTrainingDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrainingDatasetResponseUnmarshaller.Instance;

            return Invoke<CreateTrainingDatasetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrainingDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrainingDataset operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrainingDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateTrainingDataset">REST API Reference for CreateTrainingDataset Operation</seealso>
        public virtual IAsyncResult BeginCreateTrainingDataset(CreateTrainingDatasetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTrainingDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrainingDatasetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrainingDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrainingDataset.</param>
        /// 
        /// <returns>Returns a  CreateTrainingDatasetResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateTrainingDataset">REST API Reference for CreateTrainingDataset Operation</seealso>
        public virtual CreateTrainingDatasetResponse EndCreateTrainingDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTrainingDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAudienceGenerationJob

        /// <summary>
        /// Deletes the specified audience generation job, and removes all data associated with
        /// the job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAudienceGenerationJob service method.</param>
        /// 
        /// <returns>The response from the DeleteAudienceGenerationJob service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteAudienceGenerationJob">REST API Reference for DeleteAudienceGenerationJob Operation</seealso>
        public virtual DeleteAudienceGenerationJobResponse DeleteAudienceGenerationJob(DeleteAudienceGenerationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAudienceGenerationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAudienceGenerationJobResponseUnmarshaller.Instance;

            return Invoke<DeleteAudienceGenerationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAudienceGenerationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAudienceGenerationJob operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAudienceGenerationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteAudienceGenerationJob">REST API Reference for DeleteAudienceGenerationJob Operation</seealso>
        public virtual IAsyncResult BeginDeleteAudienceGenerationJob(DeleteAudienceGenerationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAudienceGenerationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAudienceGenerationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAudienceGenerationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAudienceGenerationJob.</param>
        /// 
        /// <returns>Returns a  DeleteAudienceGenerationJobResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteAudienceGenerationJob">REST API Reference for DeleteAudienceGenerationJob Operation</seealso>
        public virtual DeleteAudienceGenerationJobResponse EndDeleteAudienceGenerationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAudienceGenerationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAudienceModel

        /// <summary>
        /// Specifies an audience model that you want to delete. You can't delete an audience
        /// model if there are any configured audience models that depend on the audience model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAudienceModel service method.</param>
        /// 
        /// <returns>The response from the DeleteAudienceModel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteAudienceModel">REST API Reference for DeleteAudienceModel Operation</seealso>
        public virtual DeleteAudienceModelResponse DeleteAudienceModel(DeleteAudienceModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAudienceModelResponseUnmarshaller.Instance;

            return Invoke<DeleteAudienceModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAudienceModel operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAudienceModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteAudienceModel">REST API Reference for DeleteAudienceModel Operation</seealso>
        public virtual IAsyncResult BeginDeleteAudienceModel(DeleteAudienceModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAudienceModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAudienceModel.</param>
        /// 
        /// <returns>Returns a  DeleteAudienceModelResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteAudienceModel">REST API Reference for DeleteAudienceModel Operation</seealso>
        public virtual DeleteAudienceModelResponse EndDeleteAudienceModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAudienceModelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConfiguredAudienceModel

        /// <summary>
        /// Deletes the specified configured audience model. You can't delete a configured audience
        /// model if there are any lookalike models that use the configured audience model. If
        /// you delete a configured audience model, it will be removed from any collaborations
        /// that it is associated to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredAudienceModel service method.</param>
        /// 
        /// <returns>The response from the DeleteConfiguredAudienceModel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteConfiguredAudienceModel">REST API Reference for DeleteConfiguredAudienceModel Operation</seealso>
        public virtual DeleteConfiguredAudienceModelResponse DeleteConfiguredAudienceModel(DeleteConfiguredAudienceModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredAudienceModelResponseUnmarshaller.Instance;

            return Invoke<DeleteConfiguredAudienceModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfiguredAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredAudienceModel operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfiguredAudienceModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteConfiguredAudienceModel">REST API Reference for DeleteConfiguredAudienceModel Operation</seealso>
        public virtual IAsyncResult BeginDeleteConfiguredAudienceModel(DeleteConfiguredAudienceModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredAudienceModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfiguredAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfiguredAudienceModel.</param>
        /// 
        /// <returns>Returns a  DeleteConfiguredAudienceModelResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteConfiguredAudienceModel">REST API Reference for DeleteConfiguredAudienceModel Operation</seealso>
        public virtual DeleteConfiguredAudienceModelResponse EndDeleteConfiguredAudienceModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConfiguredAudienceModelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConfiguredAudienceModelPolicy

        /// <summary>
        /// Deletes the specified configured audience model policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredAudienceModelPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteConfiguredAudienceModelPolicy service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteConfiguredAudienceModelPolicy">REST API Reference for DeleteConfiguredAudienceModelPolicy Operation</seealso>
        public virtual DeleteConfiguredAudienceModelPolicyResponse DeleteConfiguredAudienceModelPolicy(DeleteConfiguredAudienceModelPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredAudienceModelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredAudienceModelPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteConfiguredAudienceModelPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfiguredAudienceModelPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredAudienceModelPolicy operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfiguredAudienceModelPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteConfiguredAudienceModelPolicy">REST API Reference for DeleteConfiguredAudienceModelPolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteConfiguredAudienceModelPolicy(DeleteConfiguredAudienceModelPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredAudienceModelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredAudienceModelPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfiguredAudienceModelPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfiguredAudienceModelPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteConfiguredAudienceModelPolicyResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteConfiguredAudienceModelPolicy">REST API Reference for DeleteConfiguredAudienceModelPolicy Operation</seealso>
        public virtual DeleteConfiguredAudienceModelPolicyResponse EndDeleteConfiguredAudienceModelPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConfiguredAudienceModelPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConfiguredModelAlgorithm

        /// <summary>
        /// Deletes a configured model algorithm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredModelAlgorithm service method.</param>
        /// 
        /// <returns>The response from the DeleteConfiguredModelAlgorithm service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteConfiguredModelAlgorithm">REST API Reference for DeleteConfiguredModelAlgorithm Operation</seealso>
        public virtual DeleteConfiguredModelAlgorithmResponse DeleteConfiguredModelAlgorithm(DeleteConfiguredModelAlgorithmRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredModelAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredModelAlgorithmResponseUnmarshaller.Instance;

            return Invoke<DeleteConfiguredModelAlgorithmResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfiguredModelAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredModelAlgorithm operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfiguredModelAlgorithm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteConfiguredModelAlgorithm">REST API Reference for DeleteConfiguredModelAlgorithm Operation</seealso>
        public virtual IAsyncResult BeginDeleteConfiguredModelAlgorithm(DeleteConfiguredModelAlgorithmRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredModelAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredModelAlgorithmResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfiguredModelAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfiguredModelAlgorithm.</param>
        /// 
        /// <returns>Returns a  DeleteConfiguredModelAlgorithmResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteConfiguredModelAlgorithm">REST API Reference for DeleteConfiguredModelAlgorithm Operation</seealso>
        public virtual DeleteConfiguredModelAlgorithmResponse EndDeleteConfiguredModelAlgorithm(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConfiguredModelAlgorithmResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConfiguredModelAlgorithmAssociation

        /// <summary>
        /// Deletes a configured model algorithm association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredModelAlgorithmAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteConfiguredModelAlgorithmAssociation service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteConfiguredModelAlgorithmAssociation">REST API Reference for DeleteConfiguredModelAlgorithmAssociation Operation</seealso>
        public virtual DeleteConfiguredModelAlgorithmAssociationResponse DeleteConfiguredModelAlgorithmAssociation(DeleteConfiguredModelAlgorithmAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredModelAlgorithmAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredModelAlgorithmAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteConfiguredModelAlgorithmAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfiguredModelAlgorithmAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredModelAlgorithmAssociation operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfiguredModelAlgorithmAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteConfiguredModelAlgorithmAssociation">REST API Reference for DeleteConfiguredModelAlgorithmAssociation Operation</seealso>
        public virtual IAsyncResult BeginDeleteConfiguredModelAlgorithmAssociation(DeleteConfiguredModelAlgorithmAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredModelAlgorithmAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredModelAlgorithmAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfiguredModelAlgorithmAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfiguredModelAlgorithmAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteConfiguredModelAlgorithmAssociationResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteConfiguredModelAlgorithmAssociation">REST API Reference for DeleteConfiguredModelAlgorithmAssociation Operation</seealso>
        public virtual DeleteConfiguredModelAlgorithmAssociationResponse EndDeleteConfiguredModelAlgorithmAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConfiguredModelAlgorithmAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMLConfiguration

        /// <summary>
        /// Deletes a ML modeling configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMLConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteMLConfiguration service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteMLConfiguration">REST API Reference for DeleteMLConfiguration Operation</seealso>
        public virtual DeleteMLConfigurationResponse DeleteMLConfiguration(DeleteMLConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMLConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMLConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteMLConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMLConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMLConfiguration operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMLConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteMLConfiguration">REST API Reference for DeleteMLConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteMLConfiguration(DeleteMLConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMLConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMLConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMLConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMLConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteMLConfigurationResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteMLConfiguration">REST API Reference for DeleteMLConfiguration Operation</seealso>
        public virtual DeleteMLConfigurationResponse EndDeleteMLConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMLConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMLInputChannelData

        /// <summary>
        /// Provides the information necessary to delete an ML input channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMLInputChannelData service method.</param>
        /// 
        /// <returns>The response from the DeleteMLInputChannelData service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteMLInputChannelData">REST API Reference for DeleteMLInputChannelData Operation</seealso>
        public virtual DeleteMLInputChannelDataResponse DeleteMLInputChannelData(DeleteMLInputChannelDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMLInputChannelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMLInputChannelDataResponseUnmarshaller.Instance;

            return Invoke<DeleteMLInputChannelDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMLInputChannelData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMLInputChannelData operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMLInputChannelData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteMLInputChannelData">REST API Reference for DeleteMLInputChannelData Operation</seealso>
        public virtual IAsyncResult BeginDeleteMLInputChannelData(DeleteMLInputChannelDataRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMLInputChannelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMLInputChannelDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMLInputChannelData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMLInputChannelData.</param>
        /// 
        /// <returns>Returns a  DeleteMLInputChannelDataResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteMLInputChannelData">REST API Reference for DeleteMLInputChannelData Operation</seealso>
        public virtual DeleteMLInputChannelDataResponse EndDeleteMLInputChannelData(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMLInputChannelDataResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTrainedModelOutput

        /// <summary>
        /// Deletes the model artifacts stored by the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrainedModelOutput service method.</param>
        /// 
        /// <returns>The response from the DeleteTrainedModelOutput service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteTrainedModelOutput">REST API Reference for DeleteTrainedModelOutput Operation</seealso>
        public virtual DeleteTrainedModelOutputResponse DeleteTrainedModelOutput(DeleteTrainedModelOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTrainedModelOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrainedModelOutputResponseUnmarshaller.Instance;

            return Invoke<DeleteTrainedModelOutputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrainedModelOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrainedModelOutput operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTrainedModelOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteTrainedModelOutput">REST API Reference for DeleteTrainedModelOutput Operation</seealso>
        public virtual IAsyncResult BeginDeleteTrainedModelOutput(DeleteTrainedModelOutputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTrainedModelOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrainedModelOutputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTrainedModelOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTrainedModelOutput.</param>
        /// 
        /// <returns>Returns a  DeleteTrainedModelOutputResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteTrainedModelOutput">REST API Reference for DeleteTrainedModelOutput Operation</seealso>
        public virtual DeleteTrainedModelOutputResponse EndDeleteTrainedModelOutput(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTrainedModelOutputResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTrainingDataset

        /// <summary>
        /// Specifies a training dataset that you want to delete. You can't delete a training
        /// dataset if there are any audience models that depend on the training dataset. In Clean
        /// Rooms ML, the <c>TrainingDataset</c> is metadata that points to a Glue table, which
        /// is read only during <c>AudienceModel</c> creation. This action deletes the metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrainingDataset service method.</param>
        /// 
        /// <returns>The response from the DeleteTrainingDataset service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteTrainingDataset">REST API Reference for DeleteTrainingDataset Operation</seealso>
        public virtual DeleteTrainingDatasetResponse DeleteTrainingDataset(DeleteTrainingDatasetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTrainingDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrainingDatasetResponseUnmarshaller.Instance;

            return Invoke<DeleteTrainingDatasetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrainingDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrainingDataset operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTrainingDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteTrainingDataset">REST API Reference for DeleteTrainingDataset Operation</seealso>
        public virtual IAsyncResult BeginDeleteTrainingDataset(DeleteTrainingDatasetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTrainingDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrainingDatasetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTrainingDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTrainingDataset.</param>
        /// 
        /// <returns>Returns a  DeleteTrainingDatasetResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteTrainingDataset">REST API Reference for DeleteTrainingDataset Operation</seealso>
        public virtual DeleteTrainingDatasetResponse EndDeleteTrainingDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTrainingDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAudienceGenerationJob

        /// <summary>
        /// Returns information about an audience generation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAudienceGenerationJob service method.</param>
        /// 
        /// <returns>The response from the GetAudienceGenerationJob service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetAudienceGenerationJob">REST API Reference for GetAudienceGenerationJob Operation</seealso>
        public virtual GetAudienceGenerationJobResponse GetAudienceGenerationJob(GetAudienceGenerationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAudienceGenerationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAudienceGenerationJobResponseUnmarshaller.Instance;

            return Invoke<GetAudienceGenerationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAudienceGenerationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAudienceGenerationJob operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAudienceGenerationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetAudienceGenerationJob">REST API Reference for GetAudienceGenerationJob Operation</seealso>
        public virtual IAsyncResult BeginGetAudienceGenerationJob(GetAudienceGenerationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAudienceGenerationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAudienceGenerationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAudienceGenerationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAudienceGenerationJob.</param>
        /// 
        /// <returns>Returns a  GetAudienceGenerationJobResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetAudienceGenerationJob">REST API Reference for GetAudienceGenerationJob Operation</seealso>
        public virtual GetAudienceGenerationJobResponse EndGetAudienceGenerationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAudienceGenerationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAudienceModel

        /// <summary>
        /// Returns information about an audience model
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAudienceModel service method.</param>
        /// 
        /// <returns>The response from the GetAudienceModel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetAudienceModel">REST API Reference for GetAudienceModel Operation</seealso>
        public virtual GetAudienceModelResponse GetAudienceModel(GetAudienceModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAudienceModelResponseUnmarshaller.Instance;

            return Invoke<GetAudienceModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAudienceModel operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAudienceModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetAudienceModel">REST API Reference for GetAudienceModel Operation</seealso>
        public virtual IAsyncResult BeginGetAudienceModel(GetAudienceModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAudienceModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAudienceModel.</param>
        /// 
        /// <returns>Returns a  GetAudienceModelResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetAudienceModel">REST API Reference for GetAudienceModel Operation</seealso>
        public virtual GetAudienceModelResponse EndGetAudienceModel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAudienceModelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCollaborationConfiguredModelAlgorithmAssociation

        /// <summary>
        /// Returns information about the configured model algorithm association in a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollaborationConfiguredModelAlgorithmAssociation service method.</param>
        /// 
        /// <returns>The response from the GetCollaborationConfiguredModelAlgorithmAssociation service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetCollaborationConfiguredModelAlgorithmAssociation">REST API Reference for GetCollaborationConfiguredModelAlgorithmAssociation Operation</seealso>
        public virtual GetCollaborationConfiguredModelAlgorithmAssociationResponse GetCollaborationConfiguredModelAlgorithmAssociation(GetCollaborationConfiguredModelAlgorithmAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCollaborationConfiguredModelAlgorithmAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationConfiguredModelAlgorithmAssociationResponseUnmarshaller.Instance;

            return Invoke<GetCollaborationConfiguredModelAlgorithmAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCollaborationConfiguredModelAlgorithmAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCollaborationConfiguredModelAlgorithmAssociation operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCollaborationConfiguredModelAlgorithmAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetCollaborationConfiguredModelAlgorithmAssociation">REST API Reference for GetCollaborationConfiguredModelAlgorithmAssociation Operation</seealso>
        public virtual IAsyncResult BeginGetCollaborationConfiguredModelAlgorithmAssociation(GetCollaborationConfiguredModelAlgorithmAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCollaborationConfiguredModelAlgorithmAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationConfiguredModelAlgorithmAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCollaborationConfiguredModelAlgorithmAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCollaborationConfiguredModelAlgorithmAssociation.</param>
        /// 
        /// <returns>Returns a  GetCollaborationConfiguredModelAlgorithmAssociationResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetCollaborationConfiguredModelAlgorithmAssociation">REST API Reference for GetCollaborationConfiguredModelAlgorithmAssociation Operation</seealso>
        public virtual GetCollaborationConfiguredModelAlgorithmAssociationResponse EndGetCollaborationConfiguredModelAlgorithmAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCollaborationConfiguredModelAlgorithmAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCollaborationMLInputChannel

        /// <summary>
        /// Returns information about a specific ML input channel in a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollaborationMLInputChannel service method.</param>
        /// 
        /// <returns>The response from the GetCollaborationMLInputChannel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetCollaborationMLInputChannel">REST API Reference for GetCollaborationMLInputChannel Operation</seealso>
        public virtual GetCollaborationMLInputChannelResponse GetCollaborationMLInputChannel(GetCollaborationMLInputChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCollaborationMLInputChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationMLInputChannelResponseUnmarshaller.Instance;

            return Invoke<GetCollaborationMLInputChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCollaborationMLInputChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCollaborationMLInputChannel operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCollaborationMLInputChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetCollaborationMLInputChannel">REST API Reference for GetCollaborationMLInputChannel Operation</seealso>
        public virtual IAsyncResult BeginGetCollaborationMLInputChannel(GetCollaborationMLInputChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCollaborationMLInputChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationMLInputChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCollaborationMLInputChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCollaborationMLInputChannel.</param>
        /// 
        /// <returns>Returns a  GetCollaborationMLInputChannelResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetCollaborationMLInputChannel">REST API Reference for GetCollaborationMLInputChannel Operation</seealso>
        public virtual GetCollaborationMLInputChannelResponse EndGetCollaborationMLInputChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCollaborationMLInputChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCollaborationTrainedModel

        /// <summary>
        /// Returns information about a trained model in a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollaborationTrainedModel service method.</param>
        /// 
        /// <returns>The response from the GetCollaborationTrainedModel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetCollaborationTrainedModel">REST API Reference for GetCollaborationTrainedModel Operation</seealso>
        public virtual GetCollaborationTrainedModelResponse GetCollaborationTrainedModel(GetCollaborationTrainedModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCollaborationTrainedModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationTrainedModelResponseUnmarshaller.Instance;

            return Invoke<GetCollaborationTrainedModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCollaborationTrainedModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCollaborationTrainedModel operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCollaborationTrainedModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetCollaborationTrainedModel">REST API Reference for GetCollaborationTrainedModel Operation</seealso>
        public virtual IAsyncResult BeginGetCollaborationTrainedModel(GetCollaborationTrainedModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCollaborationTrainedModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationTrainedModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCollaborationTrainedModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCollaborationTrainedModel.</param>
        /// 
        /// <returns>Returns a  GetCollaborationTrainedModelResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetCollaborationTrainedModel">REST API Reference for GetCollaborationTrainedModel Operation</seealso>
        public virtual GetCollaborationTrainedModelResponse EndGetCollaborationTrainedModel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCollaborationTrainedModelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConfiguredAudienceModel

        /// <summary>
        /// Returns information about a specified configured audience model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredAudienceModel service method.</param>
        /// 
        /// <returns>The response from the GetConfiguredAudienceModel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetConfiguredAudienceModel">REST API Reference for GetConfiguredAudienceModel Operation</seealso>
        public virtual GetConfiguredAudienceModelResponse GetConfiguredAudienceModel(GetConfiguredAudienceModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfiguredAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredAudienceModelResponseUnmarshaller.Instance;

            return Invoke<GetConfiguredAudienceModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfiguredAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredAudienceModel operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfiguredAudienceModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetConfiguredAudienceModel">REST API Reference for GetConfiguredAudienceModel Operation</seealso>
        public virtual IAsyncResult BeginGetConfiguredAudienceModel(GetConfiguredAudienceModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfiguredAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredAudienceModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfiguredAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfiguredAudienceModel.</param>
        /// 
        /// <returns>Returns a  GetConfiguredAudienceModelResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetConfiguredAudienceModel">REST API Reference for GetConfiguredAudienceModel Operation</seealso>
        public virtual GetConfiguredAudienceModelResponse EndGetConfiguredAudienceModel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConfiguredAudienceModelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConfiguredAudienceModelPolicy

        /// <summary>
        /// Returns information about a configured audience model policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredAudienceModelPolicy service method.</param>
        /// 
        /// <returns>The response from the GetConfiguredAudienceModelPolicy service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetConfiguredAudienceModelPolicy">REST API Reference for GetConfiguredAudienceModelPolicy Operation</seealso>
        public virtual GetConfiguredAudienceModelPolicyResponse GetConfiguredAudienceModelPolicy(GetConfiguredAudienceModelPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfiguredAudienceModelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredAudienceModelPolicyResponseUnmarshaller.Instance;

            return Invoke<GetConfiguredAudienceModelPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfiguredAudienceModelPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredAudienceModelPolicy operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfiguredAudienceModelPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetConfiguredAudienceModelPolicy">REST API Reference for GetConfiguredAudienceModelPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetConfiguredAudienceModelPolicy(GetConfiguredAudienceModelPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfiguredAudienceModelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredAudienceModelPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfiguredAudienceModelPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfiguredAudienceModelPolicy.</param>
        /// 
        /// <returns>Returns a  GetConfiguredAudienceModelPolicyResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetConfiguredAudienceModelPolicy">REST API Reference for GetConfiguredAudienceModelPolicy Operation</seealso>
        public virtual GetConfiguredAudienceModelPolicyResponse EndGetConfiguredAudienceModelPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConfiguredAudienceModelPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConfiguredModelAlgorithm

        /// <summary>
        /// Returns information about a configured model algorithm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredModelAlgorithm service method.</param>
        /// 
        /// <returns>The response from the GetConfiguredModelAlgorithm service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetConfiguredModelAlgorithm">REST API Reference for GetConfiguredModelAlgorithm Operation</seealso>
        public virtual GetConfiguredModelAlgorithmResponse GetConfiguredModelAlgorithm(GetConfiguredModelAlgorithmRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfiguredModelAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredModelAlgorithmResponseUnmarshaller.Instance;

            return Invoke<GetConfiguredModelAlgorithmResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfiguredModelAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredModelAlgorithm operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfiguredModelAlgorithm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetConfiguredModelAlgorithm">REST API Reference for GetConfiguredModelAlgorithm Operation</seealso>
        public virtual IAsyncResult BeginGetConfiguredModelAlgorithm(GetConfiguredModelAlgorithmRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfiguredModelAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredModelAlgorithmResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfiguredModelAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfiguredModelAlgorithm.</param>
        /// 
        /// <returns>Returns a  GetConfiguredModelAlgorithmResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetConfiguredModelAlgorithm">REST API Reference for GetConfiguredModelAlgorithm Operation</seealso>
        public virtual GetConfiguredModelAlgorithmResponse EndGetConfiguredModelAlgorithm(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConfiguredModelAlgorithmResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConfiguredModelAlgorithmAssociation

        /// <summary>
        /// Returns information about a configured model algorithm association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredModelAlgorithmAssociation service method.</param>
        /// 
        /// <returns>The response from the GetConfiguredModelAlgorithmAssociation service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetConfiguredModelAlgorithmAssociation">REST API Reference for GetConfiguredModelAlgorithmAssociation Operation</seealso>
        public virtual GetConfiguredModelAlgorithmAssociationResponse GetConfiguredModelAlgorithmAssociation(GetConfiguredModelAlgorithmAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfiguredModelAlgorithmAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredModelAlgorithmAssociationResponseUnmarshaller.Instance;

            return Invoke<GetConfiguredModelAlgorithmAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfiguredModelAlgorithmAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredModelAlgorithmAssociation operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfiguredModelAlgorithmAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetConfiguredModelAlgorithmAssociation">REST API Reference for GetConfiguredModelAlgorithmAssociation Operation</seealso>
        public virtual IAsyncResult BeginGetConfiguredModelAlgorithmAssociation(GetConfiguredModelAlgorithmAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfiguredModelAlgorithmAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredModelAlgorithmAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfiguredModelAlgorithmAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfiguredModelAlgorithmAssociation.</param>
        /// 
        /// <returns>Returns a  GetConfiguredModelAlgorithmAssociationResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetConfiguredModelAlgorithmAssociation">REST API Reference for GetConfiguredModelAlgorithmAssociation Operation</seealso>
        public virtual GetConfiguredModelAlgorithmAssociationResponse EndGetConfiguredModelAlgorithmAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConfiguredModelAlgorithmAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMLConfiguration

        /// <summary>
        /// Returns information about a specific ML configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetMLConfiguration service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetMLConfiguration">REST API Reference for GetMLConfiguration Operation</seealso>
        public virtual GetMLConfigurationResponse GetMLConfiguration(GetMLConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMLConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetMLConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMLConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMLConfiguration operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMLConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetMLConfiguration">REST API Reference for GetMLConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetMLConfiguration(GetMLConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMLConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMLConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMLConfiguration.</param>
        /// 
        /// <returns>Returns a  GetMLConfigurationResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetMLConfiguration">REST API Reference for GetMLConfiguration Operation</seealso>
        public virtual GetMLConfigurationResponse EndGetMLConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMLConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMLInputChannel

        /// <summary>
        /// Returns information about an ML input channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLInputChannel service method.</param>
        /// 
        /// <returns>The response from the GetMLInputChannel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetMLInputChannel">REST API Reference for GetMLInputChannel Operation</seealso>
        public virtual GetMLInputChannelResponse GetMLInputChannel(GetMLInputChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMLInputChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLInputChannelResponseUnmarshaller.Instance;

            return Invoke<GetMLInputChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMLInputChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMLInputChannel operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMLInputChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetMLInputChannel">REST API Reference for GetMLInputChannel Operation</seealso>
        public virtual IAsyncResult BeginGetMLInputChannel(GetMLInputChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMLInputChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLInputChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMLInputChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMLInputChannel.</param>
        /// 
        /// <returns>Returns a  GetMLInputChannelResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetMLInputChannel">REST API Reference for GetMLInputChannel Operation</seealso>
        public virtual GetMLInputChannelResponse EndGetMLInputChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMLInputChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTrainedModel

        /// <summary>
        /// Returns information about a trained model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrainedModel service method.</param>
        /// 
        /// <returns>The response from the GetTrainedModel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetTrainedModel">REST API Reference for GetTrainedModel Operation</seealso>
        public virtual GetTrainedModelResponse GetTrainedModel(GetTrainedModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTrainedModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrainedModelResponseUnmarshaller.Instance;

            return Invoke<GetTrainedModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrainedModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrainedModel operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTrainedModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetTrainedModel">REST API Reference for GetTrainedModel Operation</seealso>
        public virtual IAsyncResult BeginGetTrainedModel(GetTrainedModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTrainedModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrainedModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTrainedModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTrainedModel.</param>
        /// 
        /// <returns>Returns a  GetTrainedModelResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetTrainedModel">REST API Reference for GetTrainedModel Operation</seealso>
        public virtual GetTrainedModelResponse EndGetTrainedModel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTrainedModelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTrainedModelInferenceJob

        /// <summary>
        /// Returns information about a trained model inference job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrainedModelInferenceJob service method.</param>
        /// 
        /// <returns>The response from the GetTrainedModelInferenceJob service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetTrainedModelInferenceJob">REST API Reference for GetTrainedModelInferenceJob Operation</seealso>
        public virtual GetTrainedModelInferenceJobResponse GetTrainedModelInferenceJob(GetTrainedModelInferenceJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTrainedModelInferenceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrainedModelInferenceJobResponseUnmarshaller.Instance;

            return Invoke<GetTrainedModelInferenceJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrainedModelInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrainedModelInferenceJob operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTrainedModelInferenceJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetTrainedModelInferenceJob">REST API Reference for GetTrainedModelInferenceJob Operation</seealso>
        public virtual IAsyncResult BeginGetTrainedModelInferenceJob(GetTrainedModelInferenceJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTrainedModelInferenceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrainedModelInferenceJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTrainedModelInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTrainedModelInferenceJob.</param>
        /// 
        /// <returns>Returns a  GetTrainedModelInferenceJobResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetTrainedModelInferenceJob">REST API Reference for GetTrainedModelInferenceJob Operation</seealso>
        public virtual GetTrainedModelInferenceJobResponse EndGetTrainedModelInferenceJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTrainedModelInferenceJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTrainingDataset

        /// <summary>
        /// Returns information about a training dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrainingDataset service method.</param>
        /// 
        /// <returns>The response from the GetTrainingDataset service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetTrainingDataset">REST API Reference for GetTrainingDataset Operation</seealso>
        public virtual GetTrainingDatasetResponse GetTrainingDataset(GetTrainingDatasetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTrainingDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrainingDatasetResponseUnmarshaller.Instance;

            return Invoke<GetTrainingDatasetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrainingDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrainingDataset operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTrainingDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetTrainingDataset">REST API Reference for GetTrainingDataset Operation</seealso>
        public virtual IAsyncResult BeginGetTrainingDataset(GetTrainingDatasetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTrainingDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrainingDatasetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTrainingDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTrainingDataset.</param>
        /// 
        /// <returns>Returns a  GetTrainingDatasetResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetTrainingDataset">REST API Reference for GetTrainingDataset Operation</seealso>
        public virtual GetTrainingDatasetResponse EndGetTrainingDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTrainingDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAudienceExportJobs

        /// <summary>
        /// Returns a list of the audience export jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAudienceExportJobs service method.</param>
        /// 
        /// <returns>The response from the ListAudienceExportJobs service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListAudienceExportJobs">REST API Reference for ListAudienceExportJobs Operation</seealso>
        public virtual ListAudienceExportJobsResponse ListAudienceExportJobs(ListAudienceExportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAudienceExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAudienceExportJobsResponseUnmarshaller.Instance;

            return Invoke<ListAudienceExportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAudienceExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAudienceExportJobs operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAudienceExportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListAudienceExportJobs">REST API Reference for ListAudienceExportJobs Operation</seealso>
        public virtual IAsyncResult BeginListAudienceExportJobs(ListAudienceExportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAudienceExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAudienceExportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAudienceExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAudienceExportJobs.</param>
        /// 
        /// <returns>Returns a  ListAudienceExportJobsResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListAudienceExportJobs">REST API Reference for ListAudienceExportJobs Operation</seealso>
        public virtual ListAudienceExportJobsResponse EndListAudienceExportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAudienceExportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAudienceGenerationJobs

        /// <summary>
        /// Returns a list of audience generation jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAudienceGenerationJobs service method.</param>
        /// 
        /// <returns>The response from the ListAudienceGenerationJobs service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListAudienceGenerationJobs">REST API Reference for ListAudienceGenerationJobs Operation</seealso>
        public virtual ListAudienceGenerationJobsResponse ListAudienceGenerationJobs(ListAudienceGenerationJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAudienceGenerationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAudienceGenerationJobsResponseUnmarshaller.Instance;

            return Invoke<ListAudienceGenerationJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAudienceGenerationJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAudienceGenerationJobs operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAudienceGenerationJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListAudienceGenerationJobs">REST API Reference for ListAudienceGenerationJobs Operation</seealso>
        public virtual IAsyncResult BeginListAudienceGenerationJobs(ListAudienceGenerationJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAudienceGenerationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAudienceGenerationJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAudienceGenerationJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAudienceGenerationJobs.</param>
        /// 
        /// <returns>Returns a  ListAudienceGenerationJobsResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListAudienceGenerationJobs">REST API Reference for ListAudienceGenerationJobs Operation</seealso>
        public virtual ListAudienceGenerationJobsResponse EndListAudienceGenerationJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAudienceGenerationJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAudienceModels

        /// <summary>
        /// Returns a list of audience models.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAudienceModels service method.</param>
        /// 
        /// <returns>The response from the ListAudienceModels service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListAudienceModels">REST API Reference for ListAudienceModels Operation</seealso>
        public virtual ListAudienceModelsResponse ListAudienceModels(ListAudienceModelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAudienceModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAudienceModelsResponseUnmarshaller.Instance;

            return Invoke<ListAudienceModelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAudienceModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAudienceModels operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAudienceModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListAudienceModels">REST API Reference for ListAudienceModels Operation</seealso>
        public virtual IAsyncResult BeginListAudienceModels(ListAudienceModelsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAudienceModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAudienceModelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAudienceModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAudienceModels.</param>
        /// 
        /// <returns>Returns a  ListAudienceModelsResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListAudienceModels">REST API Reference for ListAudienceModels Operation</seealso>
        public virtual ListAudienceModelsResponse EndListAudienceModels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAudienceModelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCollaborationConfiguredModelAlgorithmAssociations

        /// <summary>
        /// Returns a list of the configured model algorithm associations in a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationConfiguredModelAlgorithmAssociations service method.</param>
        /// 
        /// <returns>The response from the ListCollaborationConfiguredModelAlgorithmAssociations service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListCollaborationConfiguredModelAlgorithmAssociations">REST API Reference for ListCollaborationConfiguredModelAlgorithmAssociations Operation</seealso>
        public virtual ListCollaborationConfiguredModelAlgorithmAssociationsResponse ListCollaborationConfiguredModelAlgorithmAssociations(ListCollaborationConfiguredModelAlgorithmAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollaborationConfiguredModelAlgorithmAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationConfiguredModelAlgorithmAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListCollaborationConfiguredModelAlgorithmAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCollaborationConfiguredModelAlgorithmAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationConfiguredModelAlgorithmAssociations operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCollaborationConfiguredModelAlgorithmAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListCollaborationConfiguredModelAlgorithmAssociations">REST API Reference for ListCollaborationConfiguredModelAlgorithmAssociations Operation</seealso>
        public virtual IAsyncResult BeginListCollaborationConfiguredModelAlgorithmAssociations(ListCollaborationConfiguredModelAlgorithmAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollaborationConfiguredModelAlgorithmAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationConfiguredModelAlgorithmAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCollaborationConfiguredModelAlgorithmAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCollaborationConfiguredModelAlgorithmAssociations.</param>
        /// 
        /// <returns>Returns a  ListCollaborationConfiguredModelAlgorithmAssociationsResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListCollaborationConfiguredModelAlgorithmAssociations">REST API Reference for ListCollaborationConfiguredModelAlgorithmAssociations Operation</seealso>
        public virtual ListCollaborationConfiguredModelAlgorithmAssociationsResponse EndListCollaborationConfiguredModelAlgorithmAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCollaborationConfiguredModelAlgorithmAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCollaborationMLInputChannels

        /// <summary>
        /// Returns a list of the ML input channels in a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationMLInputChannels service method.</param>
        /// 
        /// <returns>The response from the ListCollaborationMLInputChannels service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListCollaborationMLInputChannels">REST API Reference for ListCollaborationMLInputChannels Operation</seealso>
        public virtual ListCollaborationMLInputChannelsResponse ListCollaborationMLInputChannels(ListCollaborationMLInputChannelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollaborationMLInputChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationMLInputChannelsResponseUnmarshaller.Instance;

            return Invoke<ListCollaborationMLInputChannelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCollaborationMLInputChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationMLInputChannels operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCollaborationMLInputChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListCollaborationMLInputChannels">REST API Reference for ListCollaborationMLInputChannels Operation</seealso>
        public virtual IAsyncResult BeginListCollaborationMLInputChannels(ListCollaborationMLInputChannelsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollaborationMLInputChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationMLInputChannelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCollaborationMLInputChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCollaborationMLInputChannels.</param>
        /// 
        /// <returns>Returns a  ListCollaborationMLInputChannelsResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListCollaborationMLInputChannels">REST API Reference for ListCollaborationMLInputChannels Operation</seealso>
        public virtual ListCollaborationMLInputChannelsResponse EndListCollaborationMLInputChannels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCollaborationMLInputChannelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCollaborationTrainedModelExportJobs

        /// <summary>
        /// Returns a list of the export jobs for a trained model in a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationTrainedModelExportJobs service method.</param>
        /// 
        /// <returns>The response from the ListCollaborationTrainedModelExportJobs service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListCollaborationTrainedModelExportJobs">REST API Reference for ListCollaborationTrainedModelExportJobs Operation</seealso>
        public virtual ListCollaborationTrainedModelExportJobsResponse ListCollaborationTrainedModelExportJobs(ListCollaborationTrainedModelExportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollaborationTrainedModelExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationTrainedModelExportJobsResponseUnmarshaller.Instance;

            return Invoke<ListCollaborationTrainedModelExportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCollaborationTrainedModelExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationTrainedModelExportJobs operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCollaborationTrainedModelExportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListCollaborationTrainedModelExportJobs">REST API Reference for ListCollaborationTrainedModelExportJobs Operation</seealso>
        public virtual IAsyncResult BeginListCollaborationTrainedModelExportJobs(ListCollaborationTrainedModelExportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollaborationTrainedModelExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationTrainedModelExportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCollaborationTrainedModelExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCollaborationTrainedModelExportJobs.</param>
        /// 
        /// <returns>Returns a  ListCollaborationTrainedModelExportJobsResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListCollaborationTrainedModelExportJobs">REST API Reference for ListCollaborationTrainedModelExportJobs Operation</seealso>
        public virtual ListCollaborationTrainedModelExportJobsResponse EndListCollaborationTrainedModelExportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCollaborationTrainedModelExportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCollaborationTrainedModelInferenceJobs

        /// <summary>
        /// Returns a list of trained model inference jobs in a specified collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationTrainedModelInferenceJobs service method.</param>
        /// 
        /// <returns>The response from the ListCollaborationTrainedModelInferenceJobs service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListCollaborationTrainedModelInferenceJobs">REST API Reference for ListCollaborationTrainedModelInferenceJobs Operation</seealso>
        public virtual ListCollaborationTrainedModelInferenceJobsResponse ListCollaborationTrainedModelInferenceJobs(ListCollaborationTrainedModelInferenceJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollaborationTrainedModelInferenceJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationTrainedModelInferenceJobsResponseUnmarshaller.Instance;

            return Invoke<ListCollaborationTrainedModelInferenceJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCollaborationTrainedModelInferenceJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationTrainedModelInferenceJobs operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCollaborationTrainedModelInferenceJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListCollaborationTrainedModelInferenceJobs">REST API Reference for ListCollaborationTrainedModelInferenceJobs Operation</seealso>
        public virtual IAsyncResult BeginListCollaborationTrainedModelInferenceJobs(ListCollaborationTrainedModelInferenceJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollaborationTrainedModelInferenceJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationTrainedModelInferenceJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCollaborationTrainedModelInferenceJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCollaborationTrainedModelInferenceJobs.</param>
        /// 
        /// <returns>Returns a  ListCollaborationTrainedModelInferenceJobsResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListCollaborationTrainedModelInferenceJobs">REST API Reference for ListCollaborationTrainedModelInferenceJobs Operation</seealso>
        public virtual ListCollaborationTrainedModelInferenceJobsResponse EndListCollaborationTrainedModelInferenceJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCollaborationTrainedModelInferenceJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCollaborationTrainedModels

        /// <summary>
        /// Returns a list of the trained models in a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationTrainedModels service method.</param>
        /// 
        /// <returns>The response from the ListCollaborationTrainedModels service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListCollaborationTrainedModels">REST API Reference for ListCollaborationTrainedModels Operation</seealso>
        public virtual ListCollaborationTrainedModelsResponse ListCollaborationTrainedModels(ListCollaborationTrainedModelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollaborationTrainedModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationTrainedModelsResponseUnmarshaller.Instance;

            return Invoke<ListCollaborationTrainedModelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCollaborationTrainedModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationTrainedModels operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCollaborationTrainedModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListCollaborationTrainedModels">REST API Reference for ListCollaborationTrainedModels Operation</seealso>
        public virtual IAsyncResult BeginListCollaborationTrainedModels(ListCollaborationTrainedModelsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollaborationTrainedModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationTrainedModelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCollaborationTrainedModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCollaborationTrainedModels.</param>
        /// 
        /// <returns>Returns a  ListCollaborationTrainedModelsResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListCollaborationTrainedModels">REST API Reference for ListCollaborationTrainedModels Operation</seealso>
        public virtual ListCollaborationTrainedModelsResponse EndListCollaborationTrainedModels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCollaborationTrainedModelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConfiguredAudienceModels

        /// <summary>
        /// Returns a list of the configured audience models.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfiguredAudienceModels service method.</param>
        /// 
        /// <returns>The response from the ListConfiguredAudienceModels service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListConfiguredAudienceModels">REST API Reference for ListConfiguredAudienceModels Operation</seealso>
        public virtual ListConfiguredAudienceModelsResponse ListConfiguredAudienceModels(ListConfiguredAudienceModelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfiguredAudienceModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfiguredAudienceModelsResponseUnmarshaller.Instance;

            return Invoke<ListConfiguredAudienceModelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfiguredAudienceModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfiguredAudienceModels operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfiguredAudienceModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListConfiguredAudienceModels">REST API Reference for ListConfiguredAudienceModels Operation</seealso>
        public virtual IAsyncResult BeginListConfiguredAudienceModels(ListConfiguredAudienceModelsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfiguredAudienceModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfiguredAudienceModelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfiguredAudienceModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfiguredAudienceModels.</param>
        /// 
        /// <returns>Returns a  ListConfiguredAudienceModelsResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListConfiguredAudienceModels">REST API Reference for ListConfiguredAudienceModels Operation</seealso>
        public virtual ListConfiguredAudienceModelsResponse EndListConfiguredAudienceModels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConfiguredAudienceModelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConfiguredModelAlgorithmAssociations

        /// <summary>
        /// Returns a list of configured model algorithm associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfiguredModelAlgorithmAssociations service method.</param>
        /// 
        /// <returns>The response from the ListConfiguredModelAlgorithmAssociations service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListConfiguredModelAlgorithmAssociations">REST API Reference for ListConfiguredModelAlgorithmAssociations Operation</seealso>
        public virtual ListConfiguredModelAlgorithmAssociationsResponse ListConfiguredModelAlgorithmAssociations(ListConfiguredModelAlgorithmAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfiguredModelAlgorithmAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfiguredModelAlgorithmAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListConfiguredModelAlgorithmAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfiguredModelAlgorithmAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfiguredModelAlgorithmAssociations operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfiguredModelAlgorithmAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListConfiguredModelAlgorithmAssociations">REST API Reference for ListConfiguredModelAlgorithmAssociations Operation</seealso>
        public virtual IAsyncResult BeginListConfiguredModelAlgorithmAssociations(ListConfiguredModelAlgorithmAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfiguredModelAlgorithmAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfiguredModelAlgorithmAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfiguredModelAlgorithmAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfiguredModelAlgorithmAssociations.</param>
        /// 
        /// <returns>Returns a  ListConfiguredModelAlgorithmAssociationsResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListConfiguredModelAlgorithmAssociations">REST API Reference for ListConfiguredModelAlgorithmAssociations Operation</seealso>
        public virtual ListConfiguredModelAlgorithmAssociationsResponse EndListConfiguredModelAlgorithmAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConfiguredModelAlgorithmAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConfiguredModelAlgorithms

        /// <summary>
        /// Returns a list of configured model algorithms.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfiguredModelAlgorithms service method.</param>
        /// 
        /// <returns>The response from the ListConfiguredModelAlgorithms service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListConfiguredModelAlgorithms">REST API Reference for ListConfiguredModelAlgorithms Operation</seealso>
        public virtual ListConfiguredModelAlgorithmsResponse ListConfiguredModelAlgorithms(ListConfiguredModelAlgorithmsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfiguredModelAlgorithmsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfiguredModelAlgorithmsResponseUnmarshaller.Instance;

            return Invoke<ListConfiguredModelAlgorithmsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfiguredModelAlgorithms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfiguredModelAlgorithms operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfiguredModelAlgorithms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListConfiguredModelAlgorithms">REST API Reference for ListConfiguredModelAlgorithms Operation</seealso>
        public virtual IAsyncResult BeginListConfiguredModelAlgorithms(ListConfiguredModelAlgorithmsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfiguredModelAlgorithmsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfiguredModelAlgorithmsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfiguredModelAlgorithms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfiguredModelAlgorithms.</param>
        /// 
        /// <returns>Returns a  ListConfiguredModelAlgorithmsResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListConfiguredModelAlgorithms">REST API Reference for ListConfiguredModelAlgorithms Operation</seealso>
        public virtual ListConfiguredModelAlgorithmsResponse EndListConfiguredModelAlgorithms(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConfiguredModelAlgorithmsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMLInputChannels

        /// <summary>
        /// Returns a list of ML input channels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMLInputChannels service method.</param>
        /// 
        /// <returns>The response from the ListMLInputChannels service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListMLInputChannels">REST API Reference for ListMLInputChannels Operation</seealso>
        public virtual ListMLInputChannelsResponse ListMLInputChannels(ListMLInputChannelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMLInputChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMLInputChannelsResponseUnmarshaller.Instance;

            return Invoke<ListMLInputChannelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMLInputChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMLInputChannels operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMLInputChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListMLInputChannels">REST API Reference for ListMLInputChannels Operation</seealso>
        public virtual IAsyncResult BeginListMLInputChannels(ListMLInputChannelsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMLInputChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMLInputChannelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMLInputChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMLInputChannels.</param>
        /// 
        /// <returns>Returns a  ListMLInputChannelsResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListMLInputChannels">REST API Reference for ListMLInputChannels Operation</seealso>
        public virtual ListMLInputChannelsResponse EndListMLInputChannels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMLInputChannelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns a list of tags for a provided resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTrainedModelInferenceJobs

        /// <summary>
        /// Returns a list of trained model inference jobs that match the request parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrainedModelInferenceJobs service method.</param>
        /// 
        /// <returns>The response from the ListTrainedModelInferenceJobs service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListTrainedModelInferenceJobs">REST API Reference for ListTrainedModelInferenceJobs Operation</seealso>
        public virtual ListTrainedModelInferenceJobsResponse ListTrainedModelInferenceJobs(ListTrainedModelInferenceJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTrainedModelInferenceJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrainedModelInferenceJobsResponseUnmarshaller.Instance;

            return Invoke<ListTrainedModelInferenceJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrainedModelInferenceJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrainedModelInferenceJobs operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrainedModelInferenceJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListTrainedModelInferenceJobs">REST API Reference for ListTrainedModelInferenceJobs Operation</seealso>
        public virtual IAsyncResult BeginListTrainedModelInferenceJobs(ListTrainedModelInferenceJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTrainedModelInferenceJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrainedModelInferenceJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrainedModelInferenceJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrainedModelInferenceJobs.</param>
        /// 
        /// <returns>Returns a  ListTrainedModelInferenceJobsResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListTrainedModelInferenceJobs">REST API Reference for ListTrainedModelInferenceJobs Operation</seealso>
        public virtual ListTrainedModelInferenceJobsResponse EndListTrainedModelInferenceJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTrainedModelInferenceJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTrainedModels

        /// <summary>
        /// Returns a list of trained models.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrainedModels service method.</param>
        /// 
        /// <returns>The response from the ListTrainedModels service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListTrainedModels">REST API Reference for ListTrainedModels Operation</seealso>
        public virtual ListTrainedModelsResponse ListTrainedModels(ListTrainedModelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTrainedModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrainedModelsResponseUnmarshaller.Instance;

            return Invoke<ListTrainedModelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrainedModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrainedModels operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrainedModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListTrainedModels">REST API Reference for ListTrainedModels Operation</seealso>
        public virtual IAsyncResult BeginListTrainedModels(ListTrainedModelsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTrainedModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrainedModelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrainedModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrainedModels.</param>
        /// 
        /// <returns>Returns a  ListTrainedModelsResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListTrainedModels">REST API Reference for ListTrainedModels Operation</seealso>
        public virtual ListTrainedModelsResponse EndListTrainedModels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTrainedModelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTrainedModelVersions

        /// <summary>
        /// Returns a list of trained model versions for a specified trained model. This operation
        /// allows you to view all versions of a trained model, including information about their
        /// status and creation details. You can use this to track the evolution of your trained
        /// models and select specific versions for inference or further training.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrainedModelVersions service method.</param>
        /// 
        /// <returns>The response from the ListTrainedModelVersions service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListTrainedModelVersions">REST API Reference for ListTrainedModelVersions Operation</seealso>
        public virtual ListTrainedModelVersionsResponse ListTrainedModelVersions(ListTrainedModelVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTrainedModelVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrainedModelVersionsResponseUnmarshaller.Instance;

            return Invoke<ListTrainedModelVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrainedModelVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrainedModelVersions operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrainedModelVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListTrainedModelVersions">REST API Reference for ListTrainedModelVersions Operation</seealso>
        public virtual IAsyncResult BeginListTrainedModelVersions(ListTrainedModelVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTrainedModelVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrainedModelVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrainedModelVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrainedModelVersions.</param>
        /// 
        /// <returns>Returns a  ListTrainedModelVersionsResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListTrainedModelVersions">REST API Reference for ListTrainedModelVersions Operation</seealso>
        public virtual ListTrainedModelVersionsResponse EndListTrainedModelVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTrainedModelVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTrainingDatasets

        /// <summary>
        /// Returns a list of training datasets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingDatasets service method.</param>
        /// 
        /// <returns>The response from the ListTrainingDatasets service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListTrainingDatasets">REST API Reference for ListTrainingDatasets Operation</seealso>
        public virtual ListTrainingDatasetsResponse ListTrainingDatasets(ListTrainingDatasetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTrainingDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrainingDatasetsResponseUnmarshaller.Instance;

            return Invoke<ListTrainingDatasetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrainingDatasets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingDatasets operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrainingDatasets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListTrainingDatasets">REST API Reference for ListTrainingDatasets Operation</seealso>
        public virtual IAsyncResult BeginListTrainingDatasets(ListTrainingDatasetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTrainingDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrainingDatasetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrainingDatasets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrainingDatasets.</param>
        /// 
        /// <returns>Returns a  ListTrainingDatasetsResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListTrainingDatasets">REST API Reference for ListTrainingDatasets Operation</seealso>
        public virtual ListTrainingDatasetsResponse EndListTrainingDatasets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTrainingDatasetsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutConfiguredAudienceModelPolicy

        /// <summary>
        /// Create or update the resource policy for a configured audience model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfiguredAudienceModelPolicy service method.</param>
        /// 
        /// <returns>The response from the PutConfiguredAudienceModelPolicy service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/PutConfiguredAudienceModelPolicy">REST API Reference for PutConfiguredAudienceModelPolicy Operation</seealso>
        public virtual PutConfiguredAudienceModelPolicyResponse PutConfiguredAudienceModelPolicy(PutConfiguredAudienceModelPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutConfiguredAudienceModelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfiguredAudienceModelPolicyResponseUnmarshaller.Instance;

            return Invoke<PutConfiguredAudienceModelPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutConfiguredAudienceModelPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfiguredAudienceModelPolicy operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutConfiguredAudienceModelPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/PutConfiguredAudienceModelPolicy">REST API Reference for PutConfiguredAudienceModelPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutConfiguredAudienceModelPolicy(PutConfiguredAudienceModelPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutConfiguredAudienceModelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfiguredAudienceModelPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutConfiguredAudienceModelPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutConfiguredAudienceModelPolicy.</param>
        /// 
        /// <returns>Returns a  PutConfiguredAudienceModelPolicyResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/PutConfiguredAudienceModelPolicy">REST API Reference for PutConfiguredAudienceModelPolicy Operation</seealso>
        public virtual PutConfiguredAudienceModelPolicyResponse EndPutConfiguredAudienceModelPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutConfiguredAudienceModelPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutMLConfiguration

        /// <summary>
        /// Assigns information about an ML configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMLConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutMLConfiguration service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/PutMLConfiguration">REST API Reference for PutMLConfiguration Operation</seealso>
        public virtual PutMLConfigurationResponse PutMLConfiguration(PutMLConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutMLConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMLConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutMLConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutMLConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMLConfiguration operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutMLConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/PutMLConfiguration">REST API Reference for PutMLConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutMLConfiguration(PutMLConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutMLConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMLConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutMLConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMLConfiguration.</param>
        /// 
        /// <returns>Returns a  PutMLConfigurationResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/PutMLConfiguration">REST API Reference for PutMLConfiguration Operation</seealso>
        public virtual PutMLConfigurationResponse EndPutMLConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutMLConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  StartAudienceExportJob

        /// <summary>
        /// Export an audience of a specified size after you have generated an audience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAudienceExportJob service method.</param>
        /// 
        /// <returns>The response from the StartAudienceExportJob service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/StartAudienceExportJob">REST API Reference for StartAudienceExportJob Operation</seealso>
        public virtual StartAudienceExportJobResponse StartAudienceExportJob(StartAudienceExportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAudienceExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAudienceExportJobResponseUnmarshaller.Instance;

            return Invoke<StartAudienceExportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartAudienceExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAudienceExportJob operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAudienceExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/StartAudienceExportJob">REST API Reference for StartAudienceExportJob Operation</seealso>
        public virtual IAsyncResult BeginStartAudienceExportJob(StartAudienceExportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAudienceExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAudienceExportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartAudienceExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAudienceExportJob.</param>
        /// 
        /// <returns>Returns a  StartAudienceExportJobResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/StartAudienceExportJob">REST API Reference for StartAudienceExportJob Operation</seealso>
        public virtual StartAudienceExportJobResponse EndStartAudienceExportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartAudienceExportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StartAudienceGenerationJob

        /// <summary>
        /// Information necessary to start the audience generation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAudienceGenerationJob service method.</param>
        /// 
        /// <returns>The response from the StartAudienceGenerationJob service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/StartAudienceGenerationJob">REST API Reference for StartAudienceGenerationJob Operation</seealso>
        public virtual StartAudienceGenerationJobResponse StartAudienceGenerationJob(StartAudienceGenerationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAudienceGenerationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAudienceGenerationJobResponseUnmarshaller.Instance;

            return Invoke<StartAudienceGenerationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartAudienceGenerationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAudienceGenerationJob operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAudienceGenerationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/StartAudienceGenerationJob">REST API Reference for StartAudienceGenerationJob Operation</seealso>
        public virtual IAsyncResult BeginStartAudienceGenerationJob(StartAudienceGenerationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAudienceGenerationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAudienceGenerationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartAudienceGenerationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAudienceGenerationJob.</param>
        /// 
        /// <returns>Returns a  StartAudienceGenerationJobResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/StartAudienceGenerationJob">REST API Reference for StartAudienceGenerationJob Operation</seealso>
        public virtual StartAudienceGenerationJobResponse EndStartAudienceGenerationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartAudienceGenerationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StartTrainedModelExportJob

        /// <summary>
        /// Provides the information necessary to start a trained model export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTrainedModelExportJob service method.</param>
        /// 
        /// <returns>The response from the StartTrainedModelExportJob service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/StartTrainedModelExportJob">REST API Reference for StartTrainedModelExportJob Operation</seealso>
        public virtual StartTrainedModelExportJobResponse StartTrainedModelExportJob(StartTrainedModelExportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartTrainedModelExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTrainedModelExportJobResponseUnmarshaller.Instance;

            return Invoke<StartTrainedModelExportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartTrainedModelExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTrainedModelExportJob operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTrainedModelExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/StartTrainedModelExportJob">REST API Reference for StartTrainedModelExportJob Operation</seealso>
        public virtual IAsyncResult BeginStartTrainedModelExportJob(StartTrainedModelExportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartTrainedModelExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTrainedModelExportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartTrainedModelExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTrainedModelExportJob.</param>
        /// 
        /// <returns>Returns a  StartTrainedModelExportJobResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/StartTrainedModelExportJob">REST API Reference for StartTrainedModelExportJob Operation</seealso>
        public virtual StartTrainedModelExportJobResponse EndStartTrainedModelExportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartTrainedModelExportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StartTrainedModelInferenceJob

        /// <summary>
        /// Defines the information necessary to begin a trained model inference job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTrainedModelInferenceJob service method.</param>
        /// 
        /// <returns>The response from the StartTrainedModelInferenceJob service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/StartTrainedModelInferenceJob">REST API Reference for StartTrainedModelInferenceJob Operation</seealso>
        public virtual StartTrainedModelInferenceJobResponse StartTrainedModelInferenceJob(StartTrainedModelInferenceJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartTrainedModelInferenceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTrainedModelInferenceJobResponseUnmarshaller.Instance;

            return Invoke<StartTrainedModelInferenceJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartTrainedModelInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTrainedModelInferenceJob operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTrainedModelInferenceJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/StartTrainedModelInferenceJob">REST API Reference for StartTrainedModelInferenceJob Operation</seealso>
        public virtual IAsyncResult BeginStartTrainedModelInferenceJob(StartTrainedModelInferenceJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartTrainedModelInferenceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTrainedModelInferenceJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartTrainedModelInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTrainedModelInferenceJob.</param>
        /// 
        /// <returns>Returns a  StartTrainedModelInferenceJobResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/StartTrainedModelInferenceJob">REST API Reference for StartTrainedModelInferenceJob Operation</seealso>
        public virtual StartTrainedModelInferenceJobResponse EndStartTrainedModelInferenceJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartTrainedModelInferenceJobResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds metadata tags to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes metadata tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConfiguredAudienceModel

        /// <summary>
        /// Provides the information necessary to update a configured audience model. Updates
        /// that impact audience generation jobs take effect when a new job starts, but do not
        /// impact currently running jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredAudienceModel service method.</param>
        /// 
        /// <returns>The response from the UpdateConfiguredAudienceModel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/UpdateConfiguredAudienceModel">REST API Reference for UpdateConfiguredAudienceModel Operation</seealso>
        public virtual UpdateConfiguredAudienceModelResponse UpdateConfiguredAudienceModel(UpdateConfiguredAudienceModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfiguredAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfiguredAudienceModelResponseUnmarshaller.Instance;

            return Invoke<UpdateConfiguredAudienceModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfiguredAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredAudienceModel operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfiguredAudienceModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/UpdateConfiguredAudienceModel">REST API Reference for UpdateConfiguredAudienceModel Operation</seealso>
        public virtual IAsyncResult BeginUpdateConfiguredAudienceModel(UpdateConfiguredAudienceModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfiguredAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfiguredAudienceModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfiguredAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfiguredAudienceModel.</param>
        /// 
        /// <returns>Returns a  UpdateConfiguredAudienceModelResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/UpdateConfiguredAudienceModel">REST API Reference for UpdateConfiguredAudienceModel Operation</seealso>
        public virtual UpdateConfiguredAudienceModelResponse EndUpdateConfiguredAudienceModel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConfiguredAudienceModelResponse>(asyncResult);
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
            var resolver = new AmazonCleanRoomsMLEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}