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
 * Do not modify this file. This file is generated from the numerictypesrestxml-2026-10-26.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.NumericTypesRestXml.Model;
using Amazon.NumericTypesRestXml.Model.Internal.MarshallTransformations;
using Amazon.NumericTypesRestXml.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.NumericTypesRestXml
{
    /// <summary>
    /// <para>Implementation for accessing NumericTypesRestXml</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// 
    /// </summary>
    public partial class AmazonNumericTypesRestXmlClient : AmazonServiceClient, IAmazonNumericTypesRestXml
    {
        private static IServiceMetadata serviceMetadata = new AmazonNumericTypesRestXmlMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonNumericTypesRestXmlClient with the credentials loaded from the application's
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
        public AmazonNumericTypesRestXmlClient()
            : base(new AmazonNumericTypesRestXmlConfig()) { }

        /// <summary>
        /// Constructs AmazonNumericTypesRestXmlClient with the credentials loaded from the application's
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
        public AmazonNumericTypesRestXmlClient(RegionEndpoint region)
            : base(new AmazonNumericTypesRestXmlConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonNumericTypesRestXmlClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonNumericTypesRestXmlClient Configuration Object</param>
        public AmazonNumericTypesRestXmlClient(AmazonNumericTypesRestXmlConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonNumericTypesRestXmlClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonNumericTypesRestXmlClient(AWSCredentials credentials)
            : this(credentials, new AmazonNumericTypesRestXmlConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNumericTypesRestXmlClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNumericTypesRestXmlClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonNumericTypesRestXmlConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNumericTypesRestXmlClient with AWS Credentials and an
        /// AmazonNumericTypesRestXmlClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonNumericTypesRestXmlClient Configuration Object</param>
        public AmazonNumericTypesRestXmlClient(AWSCredentials credentials, AmazonNumericTypesRestXmlConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNumericTypesRestXmlClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonNumericTypesRestXmlClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNumericTypesRestXmlConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNumericTypesRestXmlClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNumericTypesRestXmlClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNumericTypesRestXmlConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonNumericTypesRestXmlClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNumericTypesRestXmlClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonNumericTypesRestXmlClient Configuration Object</param>
        public AmazonNumericTypesRestXmlClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonNumericTypesRestXmlConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNumericTypesRestXmlClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonNumericTypesRestXmlClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNumericTypesRestXmlConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNumericTypesRestXmlClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNumericTypesRestXmlClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNumericTypesRestXmlConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNumericTypesRestXmlClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNumericTypesRestXmlClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonNumericTypesRestXmlClient Configuration Object</param>
        public AmazonNumericTypesRestXmlClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonNumericTypesRestXmlConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNumericTypesRestXmlAuthSchemeHandler());
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


        #region  BodyNumbers

        internal virtual BodyNumbersResponse BodyNumbers(BodyNumbersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BodyNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BodyNumbersResponseUnmarshaller.Instance;

            return Invoke<BodyNumbersResponse>(request, options);
        }



        /// <summary>
        /// Sends and receives every numeric type in the request and response bodies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BodyNumbers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BodyNumbers service method, as returned by NumericTypesRestXml.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/numerictypesrestxml-2026-10-26/BodyNumbers">REST API Reference for BodyNumbers Operation</seealso>
        public virtual Task<BodyNumbersResponse> BodyNumbersAsync(BodyNumbersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BodyNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BodyNumbersResponseUnmarshaller.Instance;

            return InvokeAsync<BodyNumbersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  HttpNumbers

        internal virtual HttpNumbersResponse HttpNumbers(HttpNumbersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpNumbersResponseUnmarshaller.Instance;

            return Invoke<HttpNumbersResponse>(request, options);
        }



        /// <summary>
        /// Sends every numeric type in headers, the query string and the URI, and receives them
        /// in headers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpNumbers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpNumbers service method, as returned by NumericTypesRestXml.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/numerictypesrestxml-2026-10-26/HttpNumbers">REST API Reference for HttpNumbers Operation</seealso>
        public virtual Task<HttpNumbersResponse> HttpNumbersAsync(HttpNumbersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HttpNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HttpNumbersResponseUnmarshaller.Instance;

            return InvokeAsync<HttpNumbersResponse>(request, options, cancellationToken);
        }
        #endregion
        
    }
}