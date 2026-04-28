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
 * Do not modify this file. This file is generated from the simpledbv2-2025-09-26.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SimpleDBv2.Model;
using Amazon.SimpleDBv2.Model.Internal.MarshallTransformations;
using Amazon.SimpleDBv2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.SimpleDBv2
{
    /// <summary>
    /// <para>Implementation for accessing SimpleDBv2</para>
    ///
    /// Amazon SimpleDB is a web service providing the core database functions of data indexing
    /// and querying in the cloud. By offloading the time and effort associated with building
    /// and operating a web-scale database, SimpleDB provides developers the freedom to focus
    /// on application development.
    /// 
    ///  <pre><c> A traditional, clustered relational database requires a sizable upfront
    /// capital outlay, is complex to design, and often requires extensive and repetitive
    /// database administration. Amazon SimpleDB is dramatically simpler, requiring no schema,
    /// automatically indexing your data and providing a simple API for storage and access.
    /// This approach eliminates the administrative burden of data modeling, index maintenance,
    /// and performance tuning. Developers gain access to this functionality within Amazon's
    /// proven computing environment, are able to scale instantly, and pay only for what they
    /// use. </c></pre>
    /// </summary>
    public partial class AmazonSimpleDBv2Client : AmazonServiceClient, IAmazonSimpleDBv2
    {
        private static IServiceMetadata serviceMetadata = new AmazonSimpleDBv2Metadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonSimpleDBv2Client with the credentials loaded from the application's
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
        public AmazonSimpleDBv2Client()
            : base(new AmazonSimpleDBv2Config()) { }

        /// <summary>
        /// Constructs AmazonSimpleDBv2Client with the credentials loaded from the application's
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
        public AmazonSimpleDBv2Client(RegionEndpoint region)
            : base(new AmazonSimpleDBv2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSimpleDBv2Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSimpleDBv2Client Configuration Object</param>
        public AmazonSimpleDBv2Client(AmazonSimpleDBv2Config config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonSimpleDBv2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSimpleDBv2Client(AWSCredentials credentials)
            : this(credentials, new AmazonSimpleDBv2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleDBv2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleDBv2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSimpleDBv2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleDBv2Client with AWS Credentials and an
        /// AmazonSimpleDBv2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSimpleDBv2Client Configuration Object</param>
        public AmazonSimpleDBv2Client(AWSCredentials credentials, AmazonSimpleDBv2Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleDBv2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSimpleDBv2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleDBv2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleDBv2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleDBv2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleDBv2Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleDBv2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleDBv2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSimpleDBv2Client Configuration Object</param>
        public AmazonSimpleDBv2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonSimpleDBv2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleDBv2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSimpleDBv2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleDBv2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleDBv2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleDBv2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleDBv2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleDBv2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleDBv2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSimpleDBv2Client Configuration Object</param>
        public AmazonSimpleDBv2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSimpleDBv2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ISimpleDBv2PaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISimpleDBv2PaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SimpleDBv2PaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSimpleDBv2EndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSimpleDBv2AuthSchemeHandler());
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


        #region  GetExport

        internal virtual GetExportResponse GetExport(GetExportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportResponseUnmarshaller.Instance;

            return Invoke<GetExportResponse>(request, options);
        }



        /// <summary>
        /// Returns information for an existing domain export.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExport service method, as returned by SimpleDBv2.</returns>
        /// <exception cref="Amazon.SimpleDBv2.Model.InvalidParameterValueException">
        /// The specified parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDBv2.Model.NoSuchExportException">
        /// Export with specified ARN does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simpledbv2-2025-09-26/GetExport">REST API Reference for GetExport Operation</seealso>
        public virtual Task<GetExportResponse> GetExportAsync(GetExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportResponseUnmarshaller.Instance;

            return InvokeAsync<GetExportResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListExports

        internal virtual ListExportsResponse ListExports(ListExportsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExportsResponseUnmarshaller.Instance;

            return Invoke<ListExportsResponse>(request, options);
        }



        /// <summary>
        /// Lists all exports that were created. The results are paginated and can be filtered
        /// by domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExports service method, as returned by SimpleDBv2.</returns>
        /// <exception cref="Amazon.SimpleDBv2.Model.InvalidNextTokenException">
        /// The specified next token is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDBv2.Model.InvalidParameterValueException">
        /// The specified parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDBv2.Model.NoSuchDomainException">
        /// The specified domain does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simpledbv2-2025-09-26/ListExports">REST API Reference for ListExports Operation</seealso>
        public virtual Task<ListExportsResponse> ListExportsAsync(ListExportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExportsResponseUnmarshaller.Instance;

            return InvokeAsync<ListExportsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartDomainExport

        internal virtual StartDomainExportResponse StartDomainExport(StartDomainExportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDomainExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDomainExportResponseUnmarshaller.Instance;

            return Invoke<StartDomainExportResponse>(request, options);
        }



        /// <summary>
        /// Initiates the export of a SimpleDB domain to an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDomainExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDomainExport service method, as returned by SimpleDBv2.</returns>
        /// <exception cref="Amazon.SimpleDBv2.Model.ConflictException">
        /// Indicates a conflict with one or more parameters of the request.
        /// </exception>
        /// <exception cref="Amazon.SimpleDBv2.Model.InvalidParameterCombinationException">
        /// Parameters that must not be used together were used together in the request.
        /// </exception>
        /// <exception cref="Amazon.SimpleDBv2.Model.InvalidParameterValueException">
        /// The specified parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDBv2.Model.NoSuchDomainException">
        /// The specified domain does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleDBv2.Model.NumberExportsLimitExceededException">
        /// Cannot start export as export quota limit was exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simpledbv2-2025-09-26/StartDomainExport">REST API Reference for StartDomainExport Operation</seealso>
        public virtual Task<StartDomainExportResponse> StartDomainExportAsync(StartDomainExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDomainExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDomainExportResponseUnmarshaller.Instance;

            return InvokeAsync<StartDomainExportResponse>(request, options, cancellationToken);
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
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}