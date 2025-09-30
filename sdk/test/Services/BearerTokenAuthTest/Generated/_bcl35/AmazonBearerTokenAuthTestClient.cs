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
 * Do not modify this file. This file is generated from the bearer-token-auth-test-2022-03-21.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.BearerTokenAuthTest.Model;
using Amazon.BearerTokenAuthTest.Model.Internal.MarshallTransformations;
using Amazon.BearerTokenAuthTest.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.BearerTokenAuthTest
{
    /// <summary>
    /// <para>Implementation for accessing BearerTokenAuthTest</para>
    ///
    /// 
    /// </summary>
    public partial class AmazonBearerTokenAuthTestClient : AmazonServiceClient, IAmazonBearerTokenAuthTest
    {
        private static IServiceMetadata serviceMetadata = new AmazonBearerTokenAuthTestMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonBearerTokenAuthTestClient with the credentials loaded from the application's
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
        public AmazonBearerTokenAuthTestClient()
            : base(FallbackCredentialsFactory.GetCredentials(fallbackToAnonymous: true), new AmazonBearerTokenAuthTestConfig()) { }

        /// <summary>
        /// Constructs AmazonBearerTokenAuthTestClient with the credentials loaded from the application's
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
        public AmazonBearerTokenAuthTestClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(fallbackToAnonymous: true), new AmazonBearerTokenAuthTestConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonBearerTokenAuthTestClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonBearerTokenAuthTestClient Configuration Object</param>
        public AmazonBearerTokenAuthTestClient(AmazonBearerTokenAuthTestConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config, fallbackToAnonymous: true), config){}
        /// <summary>
        /// Constructs AmazonBearerTokenAuthTestClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonBearerTokenAuthTestClient(AWSCredentials credentials)
            : this(credentials, new AmazonBearerTokenAuthTestConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBearerTokenAuthTestClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBearerTokenAuthTestClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonBearerTokenAuthTestConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBearerTokenAuthTestClient with AWS Credentials and an
        /// AmazonBearerTokenAuthTestClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonBearerTokenAuthTestClient Configuration Object</param>
        public AmazonBearerTokenAuthTestClient(AWSCredentials credentials, AmazonBearerTokenAuthTestConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBearerTokenAuthTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonBearerTokenAuthTestClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBearerTokenAuthTestConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBearerTokenAuthTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBearerTokenAuthTestClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBearerTokenAuthTestConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonBearerTokenAuthTestClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBearerTokenAuthTestClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonBearerTokenAuthTestClient Configuration Object</param>
        public AmazonBearerTokenAuthTestClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonBearerTokenAuthTestConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBearerTokenAuthTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonBearerTokenAuthTestClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBearerTokenAuthTestConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBearerTokenAuthTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBearerTokenAuthTestClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBearerTokenAuthTestConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBearerTokenAuthTestClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBearerTokenAuthTestClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonBearerTokenAuthTestClient Configuration Object</param>
        public AmazonBearerTokenAuthTestClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonBearerTokenAuthTestConfig clientConfig)
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
            return new BearerTokenSigner();
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


        #region  InheritBearerAuthOperation

        /// <summary>
        /// Request that inherits the bearer signature version set at the Service
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InheritBearerAuthOperation service method.</param>
        /// 
        /// <returns>The response from the InheritBearerAuthOperation service method, as returned by BearerTokenAuthTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bearer-token-auth-test-2022-03-21/InheritBearerAuthOperation">REST API Reference for InheritBearerAuthOperation Operation</seealso>
        public virtual InheritBearerAuthOperationResponse InheritBearerAuthOperation(InheritBearerAuthOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InheritBearerAuthOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InheritBearerAuthOperationResponseUnmarshaller.Instance;

            return Invoke<InheritBearerAuthOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InheritBearerAuthOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InheritBearerAuthOperation operation on AmazonBearerTokenAuthTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInheritBearerAuthOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bearer-token-auth-test-2022-03-21/InheritBearerAuthOperation">REST API Reference for InheritBearerAuthOperation Operation</seealso>
        public virtual IAsyncResult BeginInheritBearerAuthOperation(InheritBearerAuthOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InheritBearerAuthOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InheritBearerAuthOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  InheritBearerAuthOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInheritBearerAuthOperation.</param>
        /// 
        /// <returns>Returns a  InheritBearerAuthOperationResult from BearerTokenAuthTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bearer-token-auth-test-2022-03-21/InheritBearerAuthOperation">REST API Reference for InheritBearerAuthOperation Operation</seealso>
        public virtual InheritBearerAuthOperationResponse EndInheritBearerAuthOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<InheritBearerAuthOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  OverrideAuthToSigV4Operation

        /// <summary>
        /// An operation that overrides auth to Sigv4.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OverrideAuthToSigV4Operation service method.</param>
        /// 
        /// <returns>The response from the OverrideAuthToSigV4Operation service method, as returned by BearerTokenAuthTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bearer-token-auth-test-2022-03-21/OverrideAuthToSigV4Operation">REST API Reference for OverrideAuthToSigV4Operation Operation</seealso>
        public virtual OverrideAuthToSigV4OperationResponse OverrideAuthToSigV4Operation(OverrideAuthToSigV4OperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = OverrideAuthToSigV4OperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OverrideAuthToSigV4OperationResponseUnmarshaller.Instance;

            return Invoke<OverrideAuthToSigV4OperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the OverrideAuthToSigV4Operation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the OverrideAuthToSigV4Operation operation on AmazonBearerTokenAuthTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndOverrideAuthToSigV4Operation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bearer-token-auth-test-2022-03-21/OverrideAuthToSigV4Operation">REST API Reference for OverrideAuthToSigV4Operation Operation</seealso>
        public virtual IAsyncResult BeginOverrideAuthToSigV4Operation(OverrideAuthToSigV4OperationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = OverrideAuthToSigV4OperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OverrideAuthToSigV4OperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  OverrideAuthToSigV4Operation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginOverrideAuthToSigV4Operation.</param>
        /// 
        /// <returns>Returns a  OverrideAuthToSigV4OperationResult from BearerTokenAuthTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bearer-token-auth-test-2022-03-21/OverrideAuthToSigV4Operation">REST API Reference for OverrideAuthToSigV4Operation Operation</seealso>
        public virtual OverrideAuthToSigV4OperationResponse EndOverrideAuthToSigV4Operation(IAsyncResult asyncResult)
        {
            return EndInvoke<OverrideAuthToSigV4OperationResponse>(asyncResult);
        }

        #endregion
        
    }
}