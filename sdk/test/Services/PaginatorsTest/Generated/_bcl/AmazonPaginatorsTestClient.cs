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
 * Do not modify this file. This file is generated from the paginators-test-2022-03-14.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.PaginatorsTest.Model;
using Amazon.PaginatorsTest.Model.Internal.MarshallTransformations;
using Amazon.PaginatorsTest.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.PaginatorsTest
{
    /// <summary>
    /// <para>Implementation for accessing PaginatorsTest</para>
    ///
    /// 
    /// </summary>
    public partial class AmazonPaginatorsTestClient : AmazonServiceClient, IAmazonPaginatorsTest
    {
        private static IServiceMetadata serviceMetadata = new AmazonPaginatorsTestMetadata();
        private IPaginatorsTestPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IPaginatorsTestPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new PaginatorsTestPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonPaginatorsTestClient with the credentials loaded from the application's
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
        public AmazonPaginatorsTestClient()
            : base(new AmazonPaginatorsTestConfig()) { }

        /// <summary>
        /// Constructs AmazonPaginatorsTestClient with the credentials loaded from the application's
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
        public AmazonPaginatorsTestClient(RegionEndpoint region)
            : base(new AmazonPaginatorsTestConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPaginatorsTestClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPaginatorsTestClient Configuration Object</param>
        public AmazonPaginatorsTestClient(AmazonPaginatorsTestConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonPaginatorsTestClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPaginatorsTestClient(AWSCredentials credentials)
            : this(credentials, new AmazonPaginatorsTestConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPaginatorsTestClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPaginatorsTestClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPaginatorsTestConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPaginatorsTestClient with AWS Credentials and an
        /// AmazonPaginatorsTestClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPaginatorsTestClient Configuration Object</param>
        public AmazonPaginatorsTestClient(AWSCredentials credentials, AmazonPaginatorsTestConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPaginatorsTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPaginatorsTestClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPaginatorsTestConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPaginatorsTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPaginatorsTestClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPaginatorsTestConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPaginatorsTestClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPaginatorsTestClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPaginatorsTestClient Configuration Object</param>
        public AmazonPaginatorsTestClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPaginatorsTestConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPaginatorsTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPaginatorsTestClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPaginatorsTestConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPaginatorsTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPaginatorsTestClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPaginatorsTestConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPaginatorsTestClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPaginatorsTestClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPaginatorsTestClient Configuration Object</param>
        public AmazonPaginatorsTestClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPaginatorsTestConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPaginatorsTestAuthSchemeHandler());
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


        #region  TestPaginator


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestPaginator service method.</param>
        /// 
        /// <returns>The response from the TestPaginator service method, as returned by PaginatorsTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/paginator-test-2021-03-14/TestPaginator">REST API Reference for TestPaginator Operation</seealso>
        public virtual TestPaginatorResponse TestPaginator(TestPaginatorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestPaginatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestPaginatorResponseUnmarshaller.Instance;

            return Invoke<TestPaginatorResponse>(request, options);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestPaginator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestPaginator service method, as returned by PaginatorsTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/paginator-test-2021-03-14/TestPaginator">REST API Reference for TestPaginator Operation</seealso>
        public virtual Task<TestPaginatorResponse> TestPaginatorAsync(TestPaginatorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestPaginatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestPaginatorResponseUnmarshaller.Instance;
            
            return InvokeAsync<TestPaginatorResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}