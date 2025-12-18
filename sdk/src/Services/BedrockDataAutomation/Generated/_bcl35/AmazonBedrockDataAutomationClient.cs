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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.BedrockDataAutomation.Model;
using Amazon.BedrockDataAutomation.Model.Internal.MarshallTransformations;
using Amazon.BedrockDataAutomation.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.BedrockDataAutomation
{
    /// <summary>
    /// <para>Implementation for accessing BedrockDataAutomation</para>
    ///
    /// Amazon Bedrock Data Automation BuildTime
    /// </summary>
    public partial class AmazonBedrockDataAutomationClient : AmazonServiceClient, IAmazonBedrockDataAutomation
    {
        private static IServiceMetadata serviceMetadata = new AmazonBedrockDataAutomationMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IBedrockDataAutomationPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IBedrockDataAutomationPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new BedrockDataAutomationPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationClient with the credentials loaded from the application's
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
        public AmazonBedrockDataAutomationClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBedrockDataAutomationConfig()) { }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationClient with the credentials loaded from the application's
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
        public AmazonBedrockDataAutomationClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBedrockDataAutomationConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonBedrockDataAutomationClient Configuration Object</param>
        public AmazonBedrockDataAutomationClient(AmazonBedrockDataAutomationConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonBedrockDataAutomationClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonBedrockDataAutomationClient(AWSCredentials credentials)
            : this(credentials, new AmazonBedrockDataAutomationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockDataAutomationClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonBedrockDataAutomationConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationClient with AWS Credentials and an
        /// AmazonBedrockDataAutomationClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonBedrockDataAutomationClient Configuration Object</param>
        public AmazonBedrockDataAutomationClient(AWSCredentials credentials, AmazonBedrockDataAutomationConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonBedrockDataAutomationClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBedrockDataAutomationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockDataAutomationClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBedrockDataAutomationConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBedrockDataAutomationClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonBedrockDataAutomationClient Configuration Object</param>
        public AmazonBedrockDataAutomationClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonBedrockDataAutomationConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonBedrockDataAutomationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBedrockDataAutomationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockDataAutomationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBedrockDataAutomationConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBedrockDataAutomationClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonBedrockDataAutomationClient Configuration Object</param>
        public AmazonBedrockDataAutomationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonBedrockDataAutomationConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBedrockDataAutomationEndpointResolver());
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


        #region  CopyBlueprintStage

        /// <summary>
        /// Copies a Blueprint from one stage to another
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyBlueprintStage service method.</param>
        /// 
        /// <returns>The response from the CopyBlueprintStage service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CopyBlueprintStage">REST API Reference for CopyBlueprintStage Operation</seealso>
        public virtual CopyBlueprintStageResponse CopyBlueprintStage(CopyBlueprintStageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyBlueprintStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyBlueprintStageResponseUnmarshaller.Instance;

            return Invoke<CopyBlueprintStageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyBlueprintStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyBlueprintStage operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyBlueprintStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CopyBlueprintStage">REST API Reference for CopyBlueprintStage Operation</seealso>
        public virtual IAsyncResult BeginCopyBlueprintStage(CopyBlueprintStageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyBlueprintStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyBlueprintStageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CopyBlueprintStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyBlueprintStage.</param>
        /// 
        /// <returns>Returns a  CopyBlueprintStageResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CopyBlueprintStage">REST API Reference for CopyBlueprintStage Operation</seealso>
        public virtual CopyBlueprintStageResponse EndCopyBlueprintStage(IAsyncResult asyncResult)
        {
            return EndInvoke<CopyBlueprintStageResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBlueprint

        /// <summary>
        /// Creates an Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBlueprint service method.</param>
        /// 
        /// <returns>The response from the CreateBlueprint service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateBlueprint">REST API Reference for CreateBlueprint Operation</seealso>
        public virtual CreateBlueprintResponse CreateBlueprint(CreateBlueprintRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBlueprintResponseUnmarshaller.Instance;

            return Invoke<CreateBlueprintResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBlueprint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBlueprint operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBlueprint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateBlueprint">REST API Reference for CreateBlueprint Operation</seealso>
        public virtual IAsyncResult BeginCreateBlueprint(CreateBlueprintRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBlueprintResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBlueprint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBlueprint.</param>
        /// 
        /// <returns>Returns a  CreateBlueprintResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateBlueprint">REST API Reference for CreateBlueprint Operation</seealso>
        public virtual CreateBlueprintResponse EndCreateBlueprint(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBlueprintResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBlueprintVersion

        /// <summary>
        /// Creates a new version of an existing Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBlueprintVersion service method.</param>
        /// 
        /// <returns>The response from the CreateBlueprintVersion service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateBlueprintVersion">REST API Reference for CreateBlueprintVersion Operation</seealso>
        public virtual CreateBlueprintVersionResponse CreateBlueprintVersion(CreateBlueprintVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBlueprintVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBlueprintVersionResponseUnmarshaller.Instance;

            return Invoke<CreateBlueprintVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBlueprintVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBlueprintVersion operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBlueprintVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateBlueprintVersion">REST API Reference for CreateBlueprintVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateBlueprintVersion(CreateBlueprintVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBlueprintVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBlueprintVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBlueprintVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBlueprintVersion.</param>
        /// 
        /// <returns>Returns a  CreateBlueprintVersionResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateBlueprintVersion">REST API Reference for CreateBlueprintVersion Operation</seealso>
        public virtual CreateBlueprintVersionResponse EndCreateBlueprintVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBlueprintVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataAutomationProject

        /// <summary>
        /// Creates an Amazon Bedrock Data Automation Project
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataAutomationProject service method.</param>
        /// 
        /// <returns>The response from the CreateDataAutomationProject service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateDataAutomationProject">REST API Reference for CreateDataAutomationProject Operation</seealso>
        public virtual CreateDataAutomationProjectResponse CreateDataAutomationProject(CreateDataAutomationProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataAutomationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataAutomationProjectResponseUnmarshaller.Instance;

            return Invoke<CreateDataAutomationProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataAutomationProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataAutomationProject operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataAutomationProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateDataAutomationProject">REST API Reference for CreateDataAutomationProject Operation</seealso>
        public virtual IAsyncResult BeginCreateDataAutomationProject(CreateDataAutomationProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataAutomationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataAutomationProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataAutomationProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataAutomationProject.</param>
        /// 
        /// <returns>Returns a  CreateDataAutomationProjectResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateDataAutomationProject">REST API Reference for CreateDataAutomationProject Operation</seealso>
        public virtual CreateDataAutomationProjectResponse EndCreateDataAutomationProject(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataAutomationProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBlueprint

        /// <summary>
        /// Deletes an existing Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBlueprint service method.</param>
        /// 
        /// <returns>The response from the DeleteBlueprint service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/DeleteBlueprint">REST API Reference for DeleteBlueprint Operation</seealso>
        public virtual DeleteBlueprintResponse DeleteBlueprint(DeleteBlueprintRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBlueprintResponseUnmarshaller.Instance;

            return Invoke<DeleteBlueprintResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBlueprint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBlueprint operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBlueprint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/DeleteBlueprint">REST API Reference for DeleteBlueprint Operation</seealso>
        public virtual IAsyncResult BeginDeleteBlueprint(DeleteBlueprintRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBlueprintResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBlueprint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBlueprint.</param>
        /// 
        /// <returns>Returns a  DeleteBlueprintResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/DeleteBlueprint">REST API Reference for DeleteBlueprint Operation</seealso>
        public virtual DeleteBlueprintResponse EndDeleteBlueprint(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBlueprintResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataAutomationProject

        /// <summary>
        /// Deletes an existing Amazon Bedrock Data Automation Project
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataAutomationProject service method.</param>
        /// 
        /// <returns>The response from the DeleteDataAutomationProject service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/DeleteDataAutomationProject">REST API Reference for DeleteDataAutomationProject Operation</seealso>
        public virtual DeleteDataAutomationProjectResponse DeleteDataAutomationProject(DeleteDataAutomationProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataAutomationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataAutomationProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteDataAutomationProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataAutomationProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataAutomationProject operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataAutomationProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/DeleteDataAutomationProject">REST API Reference for DeleteDataAutomationProject Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataAutomationProject(DeleteDataAutomationProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataAutomationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataAutomationProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataAutomationProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataAutomationProject.</param>
        /// 
        /// <returns>Returns a  DeleteDataAutomationProjectResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/DeleteDataAutomationProject">REST API Reference for DeleteDataAutomationProject Operation</seealso>
        public virtual DeleteDataAutomationProjectResponse EndDeleteDataAutomationProject(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataAutomationProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBlueprint

        /// <summary>
        /// Gets an existing Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlueprint service method.</param>
        /// 
        /// <returns>The response from the GetBlueprint service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/GetBlueprint">REST API Reference for GetBlueprint Operation</seealso>
        public virtual GetBlueprintResponse GetBlueprint(GetBlueprintRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlueprintResponseUnmarshaller.Instance;

            return Invoke<GetBlueprintResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBlueprint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBlueprint operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBlueprint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/GetBlueprint">REST API Reference for GetBlueprint Operation</seealso>
        public virtual IAsyncResult BeginGetBlueprint(GetBlueprintRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlueprintResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBlueprint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBlueprint.</param>
        /// 
        /// <returns>Returns a  GetBlueprintResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/GetBlueprint">REST API Reference for GetBlueprint Operation</seealso>
        public virtual GetBlueprintResponse EndGetBlueprint(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBlueprintResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBlueprintOptimizationStatus

        /// <summary>
        /// API used to get blueprint optimization status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlueprintOptimizationStatus service method.</param>
        /// 
        /// <returns>The response from the GetBlueprintOptimizationStatus service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/GetBlueprintOptimizationStatus">REST API Reference for GetBlueprintOptimizationStatus Operation</seealso>
        public virtual GetBlueprintOptimizationStatusResponse GetBlueprintOptimizationStatus(GetBlueprintOptimizationStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBlueprintOptimizationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlueprintOptimizationStatusResponseUnmarshaller.Instance;

            return Invoke<GetBlueprintOptimizationStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBlueprintOptimizationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBlueprintOptimizationStatus operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBlueprintOptimizationStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/GetBlueprintOptimizationStatus">REST API Reference for GetBlueprintOptimizationStatus Operation</seealso>
        public virtual IAsyncResult BeginGetBlueprintOptimizationStatus(GetBlueprintOptimizationStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBlueprintOptimizationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlueprintOptimizationStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBlueprintOptimizationStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBlueprintOptimizationStatus.</param>
        /// 
        /// <returns>Returns a  GetBlueprintOptimizationStatusResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/GetBlueprintOptimizationStatus">REST API Reference for GetBlueprintOptimizationStatus Operation</seealso>
        public virtual GetBlueprintOptimizationStatusResponse EndGetBlueprintOptimizationStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBlueprintOptimizationStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataAutomationProject

        /// <summary>
        /// Gets an existing Amazon Bedrock Data Automation Project
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataAutomationProject service method.</param>
        /// 
        /// <returns>The response from the GetDataAutomationProject service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/GetDataAutomationProject">REST API Reference for GetDataAutomationProject Operation</seealso>
        public virtual GetDataAutomationProjectResponse GetDataAutomationProject(GetDataAutomationProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataAutomationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataAutomationProjectResponseUnmarshaller.Instance;

            return Invoke<GetDataAutomationProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataAutomationProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataAutomationProject operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataAutomationProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/GetDataAutomationProject">REST API Reference for GetDataAutomationProject Operation</seealso>
        public virtual IAsyncResult BeginGetDataAutomationProject(GetDataAutomationProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataAutomationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataAutomationProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataAutomationProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataAutomationProject.</param>
        /// 
        /// <returns>Returns a  GetDataAutomationProjectResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/GetDataAutomationProject">REST API Reference for GetDataAutomationProject Operation</seealso>
        public virtual GetDataAutomationProjectResponse EndGetDataAutomationProject(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataAutomationProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  InvokeBlueprintOptimizationAsync

        /// <summary>
        /// Invoke an async job to perform Blueprint Optimization
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeBlueprintOptimizationAsync service method.</param>
        /// 
        /// <returns>The response from the InvokeBlueprintOptimizationAsync service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/InvokeBlueprintOptimizationAsync">REST API Reference for InvokeBlueprintOptimizationAsync Operation</seealso>
        public virtual InvokeBlueprintOptimizationAsyncResponse InvokeBlueprintOptimizationAsync(InvokeBlueprintOptimizationAsyncRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeBlueprintOptimizationAsyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeBlueprintOptimizationAsyncResponseUnmarshaller.Instance;

            return Invoke<InvokeBlueprintOptimizationAsyncResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InvokeBlueprintOptimizationAsync operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvokeBlueprintOptimizationAsync operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInvokeBlueprintOptimizationAsync
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/InvokeBlueprintOptimizationAsync">REST API Reference for InvokeBlueprintOptimizationAsync Operation</seealso>
        public virtual IAsyncResult BeginInvokeBlueprintOptimizationAsync(InvokeBlueprintOptimizationAsyncRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeBlueprintOptimizationAsyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeBlueprintOptimizationAsyncResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  InvokeBlueprintOptimizationAsync operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvokeBlueprintOptimizationAsync.</param>
        /// 
        /// <returns>Returns a  InvokeBlueprintOptimizationAsyncResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/InvokeBlueprintOptimizationAsync">REST API Reference for InvokeBlueprintOptimizationAsync Operation</seealso>
        public virtual InvokeBlueprintOptimizationAsyncResponse EndInvokeBlueprintOptimizationAsync(IAsyncResult asyncResult)
        {
            return EndInvoke<InvokeBlueprintOptimizationAsyncResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBlueprints

        /// <summary>
        /// Lists all existing Amazon Bedrock Data Automation Blueprints
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBlueprints service method.</param>
        /// 
        /// <returns>The response from the ListBlueprints service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListBlueprints">REST API Reference for ListBlueprints Operation</seealso>
        public virtual ListBlueprintsResponse ListBlueprints(ListBlueprintsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBlueprintsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBlueprintsResponseUnmarshaller.Instance;

            return Invoke<ListBlueprintsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBlueprints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBlueprints operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBlueprints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListBlueprints">REST API Reference for ListBlueprints Operation</seealso>
        public virtual IAsyncResult BeginListBlueprints(ListBlueprintsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBlueprintsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBlueprintsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBlueprints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBlueprints.</param>
        /// 
        /// <returns>Returns a  ListBlueprintsResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListBlueprints">REST API Reference for ListBlueprints Operation</seealso>
        public virtual ListBlueprintsResponse EndListBlueprints(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBlueprintsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataAutomationProjects

        /// <summary>
        /// Lists all existing Amazon Bedrock Data Automation Projects
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataAutomationProjects service method.</param>
        /// 
        /// <returns>The response from the ListDataAutomationProjects service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListDataAutomationProjects">REST API Reference for ListDataAutomationProjects Operation</seealso>
        public virtual ListDataAutomationProjectsResponse ListDataAutomationProjects(ListDataAutomationProjectsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataAutomationProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataAutomationProjectsResponseUnmarshaller.Instance;

            return Invoke<ListDataAutomationProjectsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataAutomationProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataAutomationProjects operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataAutomationProjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListDataAutomationProjects">REST API Reference for ListDataAutomationProjects Operation</seealso>
        public virtual IAsyncResult BeginListDataAutomationProjects(ListDataAutomationProjectsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataAutomationProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataAutomationProjectsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataAutomationProjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataAutomationProjects.</param>
        /// 
        /// <returns>Returns a  ListDataAutomationProjectsResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListDataAutomationProjects">REST API Reference for ListDataAutomationProjects Operation</seealso>
        public virtual ListDataAutomationProjectsResponse EndListDataAutomationProjects(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataAutomationProjectsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// List tags for an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Tag an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Untag an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBlueprint

        /// <summary>
        /// Updates an existing Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBlueprint service method.</param>
        /// 
        /// <returns>The response from the UpdateBlueprint service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UpdateBlueprint">REST API Reference for UpdateBlueprint Operation</seealso>
        public virtual UpdateBlueprintResponse UpdateBlueprint(UpdateBlueprintRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBlueprintResponseUnmarshaller.Instance;

            return Invoke<UpdateBlueprintResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBlueprint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBlueprint operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBlueprint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UpdateBlueprint">REST API Reference for UpdateBlueprint Operation</seealso>
        public virtual IAsyncResult BeginUpdateBlueprint(UpdateBlueprintRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBlueprintResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBlueprint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBlueprint.</param>
        /// 
        /// <returns>Returns a  UpdateBlueprintResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UpdateBlueprint">REST API Reference for UpdateBlueprint Operation</seealso>
        public virtual UpdateBlueprintResponse EndUpdateBlueprint(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBlueprintResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDataAutomationProject

        /// <summary>
        /// Updates an existing Amazon Bedrock Data Automation Project
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataAutomationProject service method.</param>
        /// 
        /// <returns>The response from the UpdateDataAutomationProject service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UpdateDataAutomationProject">REST API Reference for UpdateDataAutomationProject Operation</seealso>
        public virtual UpdateDataAutomationProjectResponse UpdateDataAutomationProject(UpdateDataAutomationProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataAutomationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataAutomationProjectResponseUnmarshaller.Instance;

            return Invoke<UpdateDataAutomationProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataAutomationProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataAutomationProject operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataAutomationProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UpdateDataAutomationProject">REST API Reference for UpdateDataAutomationProject Operation</seealso>
        public virtual IAsyncResult BeginUpdateDataAutomationProject(UpdateDataAutomationProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataAutomationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataAutomationProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataAutomationProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataAutomationProject.</param>
        /// 
        /// <returns>Returns a  UpdateDataAutomationProjectResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UpdateDataAutomationProject">REST API Reference for UpdateDataAutomationProject Operation</seealso>
        public virtual UpdateDataAutomationProjectResponse EndUpdateDataAutomationProject(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDataAutomationProjectResponse>(asyncResult);
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
            var resolver = new AmazonBedrockDataAutomationEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}