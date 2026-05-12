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
 * Do not modify this file. This file is generated from the restxmldataplane-1999-12-31.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.RestXmlDataPlane.Model;
using Amazon.RestXmlDataPlane.Model.Internal.MarshallTransformations;
using Amazon.RestXmlDataPlane.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.RestXmlDataPlane
{
    /// <summary>
    /// <para>Implementation for accessing RestXmlDataPlane</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// 
    /// </summary>
    public partial class AmazonRestXmlDataPlaneClient : AmazonServiceClient, IAmazonRestXmlDataPlane
    {
        private static IServiceMetadata serviceMetadata = new AmazonRestXmlDataPlaneMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonRestXmlDataPlaneClient with the credentials loaded from the application's
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
        public AmazonRestXmlDataPlaneClient()
            : base(new AmazonRestXmlDataPlaneConfig()) { }

        /// <summary>
        /// Constructs AmazonRestXmlDataPlaneClient with the credentials loaded from the application's
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
        public AmazonRestXmlDataPlaneClient(RegionEndpoint region)
            : base(new AmazonRestXmlDataPlaneConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRestXmlDataPlaneClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRestXmlDataPlaneClient Configuration Object</param>
        public AmazonRestXmlDataPlaneClient(AmazonRestXmlDataPlaneConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonRestXmlDataPlaneClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRestXmlDataPlaneClient(AWSCredentials credentials)
            : this(credentials, new AmazonRestXmlDataPlaneConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRestXmlDataPlaneClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRestXmlDataPlaneClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRestXmlDataPlaneConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRestXmlDataPlaneClient with AWS Credentials and an
        /// AmazonRestXmlDataPlaneClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRestXmlDataPlaneClient Configuration Object</param>
        public AmazonRestXmlDataPlaneClient(AWSCredentials credentials, AmazonRestXmlDataPlaneConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRestXmlDataPlaneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRestXmlDataPlaneClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRestXmlDataPlaneConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRestXmlDataPlaneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRestXmlDataPlaneClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRestXmlDataPlaneConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRestXmlDataPlaneClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRestXmlDataPlaneClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRestXmlDataPlaneClient Configuration Object</param>
        public AmazonRestXmlDataPlaneClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRestXmlDataPlaneConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRestXmlDataPlaneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRestXmlDataPlaneClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRestXmlDataPlaneConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRestXmlDataPlaneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRestXmlDataPlaneClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRestXmlDataPlaneConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRestXmlDataPlaneClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRestXmlDataPlaneClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRestXmlDataPlaneClient Configuration Object</param>
        public AmazonRestXmlDataPlaneClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRestXmlDataPlaneConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRestXmlDataPlaneAuthSchemeHandler());
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


        #region  CopyObject

        internal virtual CopyObjectResponse CopyObject(CopyObjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyObjectResponseUnmarshaller.Instance;

            return Invoke<CopyObjectResponse>(request, options);
        }



        /// <summary>
        /// <pre><c>From Amazon S3. CopyObject serializes a large set of headers. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyObject service method, as returned by RestXmlDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/restxmldataplane-1999-12-31/CopyObject">REST API Reference for CopyObject Operation</seealso>
        public virtual Task<CopyObjectResponse> CopyObjectAsync(CopyObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyObjectResponseUnmarshaller.Instance;

            return InvokeAsync<CopyObjectResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetMetricData

        internal virtual GetMetricDataResponse GetMetricData(GetMetricDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetricDataResponseUnmarshaller.Instance;

            return Invoke<GetMetricDataResponse>(request, options);
        }



        /// <summary>
        /// <pre><c>As seen in Amazon CloudWatch </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetricData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMetricData service method, as returned by RestXmlDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/restxmldataplane-1999-12-31/GetMetricData">REST API Reference for GetMetricData Operation</seealso>
        public virtual Task<GetMetricDataResponse> GetMetricDataAsync(GetMetricDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetricDataResponseUnmarshaller.Instance;

            return InvokeAsync<GetMetricDataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetObject

        internal virtual GetObjectResponse GetObject(GetObjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectResponseUnmarshaller.Instance;

            return Invoke<GetObjectResponse>(request, options);
        }



        /// <summary>
        /// As seen in Amazon S3. Object I/O is HTTP payload I/O, and is more of a function of
        /// network and checksum performance than serde. It is here because it's an important
        /// operation, for completeness.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by RestXmlDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/restxmldataplane-1999-12-31/GetObject">REST API Reference for GetObject Operation</seealso>
        public virtual Task<GetObjectResponse> GetObjectAsync(GetObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  Healthcheck

        internal virtual HealthcheckResponse Healthcheck(HealthcheckRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HealthcheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HealthcheckResponseUnmarshaller.Instance;

            return Invoke<HealthcheckResponse>(request, options);
        }



        /// <summary>
        /// <pre><c>A response that only says &quot;OK&quot;, if it can. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Healthcheck service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Healthcheck service method, as returned by RestXmlDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/restxmldataplane-1999-12-31/Healthcheck">REST API Reference for Healthcheck Operation</seealso>
        public virtual Task<HealthcheckResponse> HealthcheckAsync(HealthcheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HealthcheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HealthcheckResponseUnmarshaller.Instance;

            return InvokeAsync<HealthcheckResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutMetricData

        internal virtual PutMetricDataResponse PutMetricData(PutMetricDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMetricDataResponseUnmarshaller.Instance;

            return Invoke<PutMetricDataResponse>(request, options);
        }



        /// <summary>
        /// <pre><c>As seen in Amazon CloudWatch. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetricData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutMetricData service method, as returned by RestXmlDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/restxmldataplane-1999-12-31/PutMetricData">REST API Reference for PutMetricData Operation</seealso>
        public virtual Task<PutMetricDataResponse> PutMetricDataAsync(PutMetricDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMetricDataResponseUnmarshaller.Instance;

            return InvokeAsync<PutMetricDataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutObject

        internal virtual PutObjectResponse PutObject(PutObjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectResponseUnmarshaller.Instance;

            return Invoke<PutObjectResponse>(request, options);
        }



        /// <summary>
        /// As seen in Amazon S3. Object I/O is HTTP payload I/O, and is more of a function of
        /// network and checksum performance than serde. It is here because it's an important
        /// operation, for completeness.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutObject service method, as returned by RestXmlDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/restxmldataplane-1999-12-31/PutObject">REST API Reference for PutObject Operation</seealso>
        public virtual Task<PutObjectResponse> PutObjectAsync(PutObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectResponseUnmarshaller.Instance;

            return InvokeAsync<PutObjectResponse>(request, options, cancellationToken);
        }
        #endregion
        
    }
}