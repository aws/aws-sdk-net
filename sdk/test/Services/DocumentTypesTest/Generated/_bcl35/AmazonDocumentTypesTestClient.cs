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
 * Do not modify this file. This file is generated from the document-types-test-2022-09-16.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.DocumentTypesTest.Model;
using Amazon.DocumentTypesTest.Model.Internal.MarshallTransformations;
using Amazon.DocumentTypesTest.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.DocumentTypesTest
{
    /// <summary>
    /// <para>Implementation for accessing DocumentTypesTest</para>
    ///
    /// 
    /// </summary>
    public partial class AmazonDocumentTypesTestClient : AmazonServiceClient, IAmazonDocumentTypesTest
    {
        private static IServiceMetadata serviceMetadata = new AmazonDocumentTypesTestMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonDocumentTypesTestClient with the credentials loaded from the application's
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
        public AmazonDocumentTypesTestClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDocumentTypesTestConfig()) { }

        /// <summary>
        /// Constructs AmazonDocumentTypesTestClient with the credentials loaded from the application's
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
        public AmazonDocumentTypesTestClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDocumentTypesTestConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDocumentTypesTestClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDocumentTypesTestClient Configuration Object</param>
        public AmazonDocumentTypesTestClient(AmazonDocumentTypesTestConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonDocumentTypesTestClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDocumentTypesTestClient(AWSCredentials credentials)
            : this(credentials, new AmazonDocumentTypesTestConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDocumentTypesTestClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDocumentTypesTestClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDocumentTypesTestConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDocumentTypesTestClient with AWS Credentials and an
        /// AmazonDocumentTypesTestClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDocumentTypesTestClient Configuration Object</param>
        public AmazonDocumentTypesTestClient(AWSCredentials credentials, AmazonDocumentTypesTestConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDocumentTypesTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDocumentTypesTestClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDocumentTypesTestConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDocumentTypesTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDocumentTypesTestClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDocumentTypesTestConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDocumentTypesTestClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDocumentTypesTestClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDocumentTypesTestClient Configuration Object</param>
        public AmazonDocumentTypesTestClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDocumentTypesTestConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDocumentTypesTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDocumentTypesTestClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDocumentTypesTestConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDocumentTypesTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDocumentTypesTestClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDocumentTypesTestConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDocumentTypesTestClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDocumentTypesTestClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDocumentTypesTestClient Configuration Object</param>
        public AmazonDocumentTypesTestClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDocumentTypesTestConfig clientConfig)
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


        #region  ExecuteQuery

        /// <summary>
        /// Execute Query
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteQuery service method.</param>
        /// 
        /// <returns>The response from the ExecuteQuery service method, as returned by DocumentTypesTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/document-types-test-2022-09-16/ExecuteQuery">REST API Reference for ExecuteQuery Operation</seealso>
        public virtual ExecuteQueryResponse ExecuteQuery(ExecuteQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteQueryResponseUnmarshaller.Instance;

            return Invoke<ExecuteQueryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteQuery operation on AmazonDocumentTypesTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/document-types-test-2022-09-16/ExecuteQuery">REST API Reference for ExecuteQuery Operation</seealso>
        public virtual IAsyncResult BeginExecuteQuery(ExecuteQueryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteQueryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteQuery.</param>
        /// 
        /// <returns>Returns a  ExecuteQueryResult from DocumentTypesTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/document-types-test-2022-09-16/ExecuteQuery">REST API Reference for ExecuteQuery Operation</seealso>
        public virtual ExecuteQueryResponse EndExecuteQuery(IAsyncResult asyncResult)
        {
            return EndInvoke<ExecuteQueryResponse>(asyncResult);
        }

        #endregion
        
    }
}