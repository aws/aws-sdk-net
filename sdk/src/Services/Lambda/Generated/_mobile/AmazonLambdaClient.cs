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
 * Do not modify this file. This file is generated from the lambda-2014-11-11.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Lambda.Model;
using Amazon.Lambda.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Lambda
{
    /// <summary>
    /// Implementation for accessing Lambda
    ///
    /// AWS Lambda 
    /// <para>
    /// <b>Overview</b>
    /// </para>
    ///  
    /// <para>
    /// This is the AWS Lambda API Reference. The AWS Lambda Developer Guide provides additional
    /// information. For the service overview, go to <a href="http://docs.aws.amazon.com/lambda/latest/dg/welcome.html">What
    /// is AWS Lambda</a>, and for information about how the service works, go to <a href="http://docs.aws.amazon.com/lambda/latest/dg/lambda-introduction.html">AWS
    /// LambdaL How it Works</a> in the AWS Lambda Developer Guide.
    /// </para>
    /// </summary>
    public partial class AmazonLambdaClient : AmazonServiceClient, IAmazonLambda
    {
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonLambdaClient(AWSCredentials credentials)
            : this(credentials, new AmazonLambdaConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLambdaClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonLambdaConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Credentials and an
        /// AmazonLambdaClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonLambdaClient Configuration Object</param>
        public AmazonLambdaClient(AWSCredentials credentials, AmazonLambdaConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonLambdaClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLambdaConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLambdaClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLambdaConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLambdaClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonLambdaClient Configuration Object</param>
        public AmazonLambdaClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonLambdaConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonLambdaClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLambdaConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLambdaClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLambdaConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLambdaClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonLambdaClient Configuration Object</param>
        public AmazonLambdaClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonLambdaConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 


        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  AddEventSource

        internal AddEventSourceResponse AddEventSource(AddEventSourceRequest request)
        {
            var marshaller = new AddEventSourceRequestMarshaller();
            var unmarshaller = AddEventSourceResponseUnmarshaller.Instance;

            return Invoke<AddEventSourceRequest,AddEventSourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddEventSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddEventSource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AddEventSourceResponse> AddEventSourceAsync(AddEventSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddEventSourceRequestMarshaller();
            var unmarshaller = AddEventSourceResponseUnmarshaller.Instance;

            return InvokeAsync<AddEventSourceRequest,AddEventSourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteFunction

        internal DeleteFunctionResponse DeleteFunction(DeleteFunctionRequest request)
        {
            var marshaller = new DeleteFunctionRequestMarshaller();
            var unmarshaller = DeleteFunctionResponseUnmarshaller.Instance;

            return Invoke<DeleteFunctionRequest,DeleteFunctionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteFunctionResponse> DeleteFunctionAsync(DeleteFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteFunctionRequestMarshaller();
            var unmarshaller = DeleteFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFunctionRequest,DeleteFunctionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetEventSource

        internal GetEventSourceResponse GetEventSource(GetEventSourceRequest request)
        {
            var marshaller = new GetEventSourceRequestMarshaller();
            var unmarshaller = GetEventSourceResponseUnmarshaller.Instance;

            return Invoke<GetEventSourceRequest,GetEventSourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventSource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetEventSourceResponse> GetEventSourceAsync(GetEventSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetEventSourceRequestMarshaller();
            var unmarshaller = GetEventSourceResponseUnmarshaller.Instance;

            return InvokeAsync<GetEventSourceRequest,GetEventSourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetFunction

        internal GetFunctionResponse GetFunction(GetFunctionRequest request)
        {
            var marshaller = new GetFunctionRequestMarshaller();
            var unmarshaller = GetFunctionResponseUnmarshaller.Instance;

            return Invoke<GetFunctionRequest,GetFunctionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetFunctionResponse> GetFunctionAsync(GetFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetFunctionRequestMarshaller();
            var unmarshaller = GetFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<GetFunctionRequest,GetFunctionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetFunctionConfiguration

        internal GetFunctionConfigurationResponse GetFunctionConfiguration(GetFunctionConfigurationRequest request)
        {
            var marshaller = new GetFunctionConfigurationRequestMarshaller();
            var unmarshaller = GetFunctionConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetFunctionConfigurationRequest,GetFunctionConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFunctionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetFunctionConfigurationResponse> GetFunctionConfigurationAsync(GetFunctionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetFunctionConfigurationRequestMarshaller();
            var unmarshaller = GetFunctionConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetFunctionConfigurationRequest,GetFunctionConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  InvokeAsync

        internal InvokeAsyncResponse InvokeAsync(InvokeAsyncRequest request)
        {
            var marshaller = new InvokeAsyncRequestMarshaller();
            var unmarshaller = InvokeAsyncResponseUnmarshaller.Instance;

            return Invoke<InvokeAsyncRequest,InvokeAsyncResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InvokeAsync operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvokeAsync operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<InvokeAsyncResponse> InvokeAsyncAsync(InvokeAsyncRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new InvokeAsyncRequestMarshaller();
            var unmarshaller = InvokeAsyncResponseUnmarshaller.Instance;

            return InvokeAsync<InvokeAsyncRequest,InvokeAsyncResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListEventSources

        internal ListEventSourcesResponse ListEventSources(ListEventSourcesRequest request)
        {
            var marshaller = new ListEventSourcesRequestMarshaller();
            var unmarshaller = ListEventSourcesResponseUnmarshaller.Instance;

            return Invoke<ListEventSourcesRequest,ListEventSourcesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventSources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListEventSourcesResponse> ListEventSourcesAsync(ListEventSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListEventSourcesRequestMarshaller();
            var unmarshaller = ListEventSourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListEventSourcesRequest,ListEventSourcesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListFunctions

        internal ListFunctionsResponse ListFunctions(ListFunctionsRequest request)
        {
            var marshaller = new ListFunctionsRequestMarshaller();
            var unmarshaller = ListFunctionsResponseUnmarshaller.Instance;

            return Invoke<ListFunctionsRequest,ListFunctionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFunctions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFunctions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListFunctionsResponse> ListFunctionsAsync(ListFunctionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListFunctionsRequestMarshaller();
            var unmarshaller = ListFunctionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFunctionsRequest,ListFunctionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveEventSource

        internal RemoveEventSourceResponse RemoveEventSource(RemoveEventSourceRequest request)
        {
            var marshaller = new RemoveEventSourceRequestMarshaller();
            var unmarshaller = RemoveEventSourceResponseUnmarshaller.Instance;

            return Invoke<RemoveEventSourceRequest,RemoveEventSourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveEventSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveEventSource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RemoveEventSourceResponse> RemoveEventSourceAsync(RemoveEventSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemoveEventSourceRequestMarshaller();
            var unmarshaller = RemoveEventSourceResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveEventSourceRequest,RemoveEventSourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateFunctionConfiguration

        internal UpdateFunctionConfigurationResponse UpdateFunctionConfiguration(UpdateFunctionConfigurationRequest request)
        {
            var marshaller = new UpdateFunctionConfigurationRequestMarshaller();
            var unmarshaller = UpdateFunctionConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateFunctionConfigurationRequest,UpdateFunctionConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFunctionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateFunctionConfigurationResponse> UpdateFunctionConfigurationAsync(UpdateFunctionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateFunctionConfigurationRequestMarshaller();
            var unmarshaller = UpdateFunctionConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFunctionConfigurationRequest,UpdateFunctionConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UploadFunction

        internal UploadFunctionResponse UploadFunction(UploadFunctionRequest request)
        {
            var marshaller = new UploadFunctionRequestMarshaller();
            var unmarshaller = UploadFunctionResponseUnmarshaller.Instance;

            return Invoke<UploadFunctionRequest,UploadFunctionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UploadFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UploadFunctionResponse> UploadFunctionAsync(UploadFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UploadFunctionRequestMarshaller();
            var unmarshaller = UploadFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<UploadFunctionRequest,UploadFunctionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}