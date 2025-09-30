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
 * Do not modify this file. This file is generated from the query-compatible-json-rpc-10-2020-07-14.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.QueryCompatibleJSONRPC10.Model;
using Amazon.QueryCompatibleJSONRPC10.Model.Internal.MarshallTransformations;
using Amazon.QueryCompatibleJSONRPC10.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.QueryCompatibleJSONRPC10
{
    /// <summary>
    /// <para>Implementation for accessing QueryCompatibleJSONRPC10</para>
    ///
    /// 
    /// </summary>
    public partial class AmazonQueryCompatibleJSONRPC10Client : AmazonServiceClient, IAmazonQueryCompatibleJSONRPC10
    {
        private static IServiceMetadata serviceMetadata = new AmazonQueryCompatibleJSONRPC10Metadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonQueryCompatibleJSONRPC10Client with the credentials loaded from the application's
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
        public AmazonQueryCompatibleJSONRPC10Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonQueryCompatibleJSONRPC10Config()) { }

        /// <summary>
        /// Constructs AmazonQueryCompatibleJSONRPC10Client with the credentials loaded from the application's
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
        public AmazonQueryCompatibleJSONRPC10Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonQueryCompatibleJSONRPC10Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonQueryCompatibleJSONRPC10Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonQueryCompatibleJSONRPC10Client Configuration Object</param>
        public AmazonQueryCompatibleJSONRPC10Client(AmazonQueryCompatibleJSONRPC10Config config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonQueryCompatibleJSONRPC10Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonQueryCompatibleJSONRPC10Client(AWSCredentials credentials)
            : this(credentials, new AmazonQueryCompatibleJSONRPC10Config())
        {
        }

        /// <summary>
        /// Constructs AmazonQueryCompatibleJSONRPC10Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQueryCompatibleJSONRPC10Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonQueryCompatibleJSONRPC10Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQueryCompatibleJSONRPC10Client with AWS Credentials and an
        /// AmazonQueryCompatibleJSONRPC10Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonQueryCompatibleJSONRPC10Client Configuration Object</param>
        public AmazonQueryCompatibleJSONRPC10Client(AWSCredentials credentials, AmazonQueryCompatibleJSONRPC10Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQueryCompatibleJSONRPC10Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonQueryCompatibleJSONRPC10Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQueryCompatibleJSONRPC10Config())
        {
        }

        /// <summary>
        /// Constructs AmazonQueryCompatibleJSONRPC10Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQueryCompatibleJSONRPC10Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQueryCompatibleJSONRPC10Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonQueryCompatibleJSONRPC10Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQueryCompatibleJSONRPC10Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonQueryCompatibleJSONRPC10Client Configuration Object</param>
        public AmazonQueryCompatibleJSONRPC10Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonQueryCompatibleJSONRPC10Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQueryCompatibleJSONRPC10Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonQueryCompatibleJSONRPC10Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQueryCompatibleJSONRPC10Config())
        {
        }

        /// <summary>
        /// Constructs AmazonQueryCompatibleJSONRPC10Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQueryCompatibleJSONRPC10Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQueryCompatibleJSONRPC10Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQueryCompatibleJSONRPC10Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQueryCompatibleJSONRPC10Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonQueryCompatibleJSONRPC10Client Configuration Object</param>
        public AmazonQueryCompatibleJSONRPC10Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonQueryCompatibleJSONRPC10Config clientConfig)
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


        #region  QueryCompatibleOperation

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryCompatibleOperation service method.</param>
        /// 
        /// <returns>The response from the QueryCompatibleOperation service method, as returned by QueryCompatibleJSONRPC10.</returns>
        /// <exception cref="Amazon.QueryCompatibleJSONRPC10.Model.CustomCodeErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.QueryCompatibleJSONRPC10.Model.NoCustomCodeErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-compatible-json-rpc-10-2020-07-14/QueryCompatibleOperation">REST API Reference for QueryCompatibleOperation Operation</seealso>
        public virtual QueryCompatibleOperationResponse QueryCompatibleOperation(QueryCompatibleOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryCompatibleOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryCompatibleOperationResponseUnmarshaller.Instance;

            return Invoke<QueryCompatibleOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the QueryCompatibleOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryCompatibleOperation operation on AmazonQueryCompatibleJSONRPC10Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryCompatibleOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-compatible-json-rpc-10-2020-07-14/QueryCompatibleOperation">REST API Reference for QueryCompatibleOperation Operation</seealso>
        public virtual IAsyncResult BeginQueryCompatibleOperation(QueryCompatibleOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryCompatibleOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryCompatibleOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  QueryCompatibleOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryCompatibleOperation.</param>
        /// 
        /// <returns>Returns a  QueryCompatibleOperationResult from QueryCompatibleJSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-compatible-json-rpc-10-2020-07-14/QueryCompatibleOperation">REST API Reference for QueryCompatibleOperation Operation</seealso>
        public virtual QueryCompatibleOperationResponse EndQueryCompatibleOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<QueryCompatibleOperationResponse>(asyncResult);
        }

        #endregion
        
    }
}