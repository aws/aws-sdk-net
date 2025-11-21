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
 * Do not modify this file. This file is generated from the inspector-scan-2023-08-08.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.InspectorScan.Model;
using Amazon.InspectorScan.Model.Internal.MarshallTransformations;
using Amazon.InspectorScan.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.InspectorScan
{
    /// <summary>
    /// <para>Implementation for accessing InspectorScan</para>
    ///
    /// Amazon Inspector Scan is a vulnerability discovery service that scans a provided Software
    /// Bill of Materials (SBOM) for security vulnerabilities.
    /// </summary>
    public partial class AmazonInspectorScanClient : AmazonServiceClient, IAmazonInspectorScan
    {
        private static IServiceMetadata serviceMetadata = new AmazonInspectorScanMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonInspectorScanClient with the credentials loaded from the application's
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
        public AmazonInspectorScanClient()
            : base(new AmazonInspectorScanConfig()) { }

        /// <summary>
        /// Constructs AmazonInspectorScanClient with the credentials loaded from the application's
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
        public AmazonInspectorScanClient(RegionEndpoint region)
            : base(new AmazonInspectorScanConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonInspectorScanClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonInspectorScanClient Configuration Object</param>
        public AmazonInspectorScanClient(AmazonInspectorScanConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonInspectorScanClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonInspectorScanClient(AWSCredentials credentials)
            : this(credentials, new AmazonInspectorScanConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonInspectorScanClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonInspectorScanClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonInspectorScanConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonInspectorScanClient with AWS Credentials and an
        /// AmazonInspectorScanClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonInspectorScanClient Configuration Object</param>
        public AmazonInspectorScanClient(AWSCredentials credentials, AmazonInspectorScanConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonInspectorScanClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonInspectorScanClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonInspectorScanConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonInspectorScanClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonInspectorScanClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonInspectorScanConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonInspectorScanClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonInspectorScanClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonInspectorScanClient Configuration Object</param>
        public AmazonInspectorScanClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonInspectorScanConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonInspectorScanClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonInspectorScanClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonInspectorScanConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonInspectorScanClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonInspectorScanClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonInspectorScanConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonInspectorScanClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonInspectorScanClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonInspectorScanClient Configuration Object</param>
        public AmazonInspectorScanClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonInspectorScanConfig clientConfig)
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
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonInspectorScanEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonInspectorScanAuthSchemeHandler());
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


        #region  ScanSbom


        /// <summary>
        /// Scans a provided CycloneDX 1.5 SBOM and reports on any vulnerabilities discovered
        /// in that SBOM. You can generate compatible SBOMs for your resources using the <a href="">Amazon
        /// Inspector SBOM generator</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ScanSbom service method.</param>
        /// 
        /// <returns>The response from the ScanSbom service method, as returned by InspectorScan.</returns>
        /// <exception cref="Amazon.InspectorScan.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InspectorScan.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.InspectorScan.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InspectorScan.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-scan-2023-08-08/ScanSbom">REST API Reference for ScanSbom Operation</seealso>
        public virtual ScanSbomResponse ScanSbom(ScanSbomRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ScanSbomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ScanSbomResponseUnmarshaller.Instance;

            return Invoke<ScanSbomResponse>(request, options);
        }


        /// <summary>
        /// Scans a provided CycloneDX 1.5 SBOM and reports on any vulnerabilities discovered
        /// in that SBOM. You can generate compatible SBOMs for your resources using the <a href="">Amazon
        /// Inspector SBOM generator</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ScanSbom service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ScanSbom service method, as returned by InspectorScan.</returns>
        /// <exception cref="Amazon.InspectorScan.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InspectorScan.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.InspectorScan.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InspectorScan.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-scan-2023-08-08/ScanSbom">REST API Reference for ScanSbom Operation</seealso>
        public virtual Task<ScanSbomResponse> ScanSbomAsync(ScanSbomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ScanSbomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ScanSbomResponseUnmarshaller.Instance;
            
            return InvokeAsync<ScanSbomResponse>(request, options, cancellationToken);
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