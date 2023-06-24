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
 * Do not modify this file. This file is generated from the rest-json-test-2016-04-12.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.RestJsonTest.Model;
using Amazon.RestJsonTest.Model.Internal.MarshallTransformations;
using Amazon.RestJsonTest.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.RestJsonTest
{
    /// <summary>
    /// Implementation for accessing RestJsonTest
    ///
    /// 
    /// </summary>
    public partial class AmazonRestJsonTestClient : AmazonServiceClient, IAmazonRestJsonTest
    {
        private static IServiceMetadata serviceMetadata = new AmazonRestJsonTestMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with the credentials loaded from the application's
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
        public AmazonRestJsonTestClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRestJsonTestConfig()) { }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with the credentials loaded from the application's
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
        public AmazonRestJsonTestClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRestJsonTestConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRestJsonTestClient Configuration Object</param>
        public AmazonRestJsonTestClient(AmazonRestJsonTestConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRestJsonTestClient(AWSCredentials credentials)
            : this(credentials, new AmazonRestJsonTestConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRestJsonTestClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRestJsonTestConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Credentials and an
        /// AmazonRestJsonTestClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRestJsonTestClient Configuration Object</param>
        public AmazonRestJsonTestClient(AWSCredentials credentials, AmazonRestJsonTestConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRestJsonTestClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRestJsonTestConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRestJsonTestClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRestJsonTestConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRestJsonTestClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRestJsonTestClient Configuration Object</param>
        public AmazonRestJsonTestClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRestJsonTestConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRestJsonTestClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRestJsonTestConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRestJsonTestClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRestJsonTestConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRestJsonTestClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRestJsonTestClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRestJsonTestClient Configuration Object</param>
        public AmazonRestJsonTestClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRestJsonTestConfig clientConfig)
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


        #region  NoPayload


        /// <summary>
        /// Request without a body
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoPayload service method.</param>
        /// 
        /// <returns>The response from the NoPayload service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/NoPayload">REST API Reference for NoPayload Operation</seealso>
        public virtual NoPayloadResponse NoPayload(NoPayloadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = NoPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoPayloadResponseUnmarshaller.Instance;

            return Invoke<NoPayloadResponse>(request, options);
        }


        /// <summary>
        /// Request without a body
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NoPayload service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/NoPayload">REST API Reference for NoPayload Operation</seealso>
        public virtual Task<NoPayloadResponse> NoPayloadAsync(NoPayloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = NoPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoPayloadResponseUnmarshaller.Instance;
            
            return InvokeAsync<NoPayloadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TestBlobPayload


        /// <summary>
        /// Post a test blob payload request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestBlobPayload service method.</param>
        /// 
        /// <returns>The response from the TestBlobPayload service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/TestBlobPayload">REST API Reference for TestBlobPayload Operation</seealso>
        public virtual TestBlobPayloadResponse TestBlobPayload(TestBlobPayloadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestBlobPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestBlobPayloadResponseUnmarshaller.Instance;

            return Invoke<TestBlobPayloadResponse>(request, options);
        }


        /// <summary>
        /// Post a test blob payload request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestBlobPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestBlobPayload service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/TestBlobPayload">REST API Reference for TestBlobPayload Operation</seealso>
        public virtual Task<TestBlobPayloadResponse> TestBlobPayloadAsync(TestBlobPayloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestBlobPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestBlobPayloadResponseUnmarshaller.Instance;
            
            return InvokeAsync<TestBlobPayloadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TestBody


        /// <summary>
        /// Post a test body request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestBody service method.</param>
        /// 
        /// <returns>The response from the TestBody service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/TestBody">REST API Reference for TestBody Operation</seealso>
        public virtual TestBodyResponse TestBody(TestBodyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestBodyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestBodyResponseUnmarshaller.Instance;

            return Invoke<TestBodyResponse>(request, options);
        }


        /// <summary>
        /// Post a test body request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestBody service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestBody service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/TestBody">REST API Reference for TestBody Operation</seealso>
        public virtual Task<TestBodyResponse> TestBodyAsync(TestBodyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestBodyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestBodyResponseUnmarshaller.Instance;
            
            return InvokeAsync<TestBodyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TestPayload


        /// <summary>
        /// Post a test payload request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestPayload service method.</param>
        /// 
        /// <returns>The response from the TestPayload service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/TestPayload">REST API Reference for TestPayload Operation</seealso>
        public virtual TestPayloadResponse TestPayload(TestPayloadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestPayloadResponseUnmarshaller.Instance;

            return Invoke<TestPayloadResponse>(request, options);
        }


        /// <summary>
        /// Post a test payload request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestPayload service method, as returned by RestJsonTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2021-05-13/TestPayload">REST API Reference for TestPayload Operation</seealso>
        public virtual Task<TestPayloadResponse> TestPayloadAsync(TestPayloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestPayloadResponseUnmarshaller.Instance;
            
            return InvokeAsync<TestPayloadResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}