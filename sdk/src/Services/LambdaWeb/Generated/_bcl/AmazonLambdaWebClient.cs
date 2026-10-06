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
 * Do not modify this file. This file is generated from the lambda-web-2025-03-07.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.LambdaWeb.Model;
using Amazon.LambdaWeb.Model.Internal.MarshallTransformations;
using Amazon.LambdaWeb.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.LambdaWeb
{
    /// <summary>
    /// <para>Implementation for accessing LambdaWeb</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// <note> 
    /// <para>
    /// The AWS Lambda Web Functions APIs (<c>LambdaWeb</c> namespace) are experimental and
    /// for internal AWS use only. They are not yet available to external customers.
    /// 
    ///  </note>
    /// </para>
    /// </summary>
    public partial class AmazonLambdaWebClient : AmazonServiceClient, IAmazonLambdaWeb
    {
        private static IServiceMetadata serviceMetadata = new AmazonLambdaWebMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonLambdaWebClient with the credentials loaded from the application's
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
        public AmazonLambdaWebClient()
            : base(new AmazonLambdaWebConfig()) { }

        /// <summary>
        /// Constructs AmazonLambdaWebClient with the credentials loaded from the application's
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
        public AmazonLambdaWebClient(RegionEndpoint region)
            : base(new AmazonLambdaWebConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonLambdaWebClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonLambdaWebClient Configuration Object</param>
        public AmazonLambdaWebClient(AmazonLambdaWebConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonLambdaWebClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonLambdaWebClient(AWSCredentials credentials)
            : this(credentials, new AmazonLambdaWebConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaWebClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLambdaWebClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonLambdaWebConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaWebClient with AWS Credentials and an
        /// AmazonLambdaWebClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonLambdaWebClient Configuration Object</param>
        public AmazonLambdaWebClient(AWSCredentials credentials, AmazonLambdaWebConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaWebClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonLambdaWebClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLambdaWebConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaWebClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLambdaWebClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLambdaWebConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaWebClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLambdaWebClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonLambdaWebClient Configuration Object</param>
        public AmazonLambdaWebClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonLambdaWebConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaWebClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonLambdaWebClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLambdaWebConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaWebClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLambdaWebClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLambdaWebConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaWebClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLambdaWebClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonLambdaWebClient Configuration Object</param>
        public AmazonLambdaWebClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonLambdaWebConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLambdaWebEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLambdaWebAuthSchemeHandler());
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


        #region  GetWebAccountSettings


        /// <summary>
        /// Retrieves details about your AWS Lambda Web Functions account settings for the current
        /// AWS Region, including the quotas that apply to web functions and your current usage.
        /// 
        ///  <note> 
        /// <para>
        /// This API is experimental and for internal AWS use only. It is not yet available to
        /// external customers.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebAccountSettings service method.</param>
        /// 
        /// <returns>The response from the GetWebAccountSettings service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was throttled. Reduce the frequency of requests and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/GetWebAccountSettings">REST API Reference for GetWebAccountSettings Operation</seealso>
        public virtual GetWebAccountSettingsResponse GetWebAccountSettings(GetWebAccountSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWebAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<GetWebAccountSettingsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves details about your AWS Lambda Web Functions account settings for the current
        /// AWS Region, including the quotas that apply to web functions and your current usage.
        /// 
        ///  <note> 
        /// <para>
        /// This API is experimental and for internal AWS use only. It is not yet available to
        /// external customers.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWebAccountSettings service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was throttled. Reduce the frequency of requests and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/GetWebAccountSettings">REST API Reference for GetWebAccountSettings Operation</seealso>
        public virtual Task<GetWebAccountSettingsResponse> GetWebAccountSettingsAsync(GetWebAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWebAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebAccountSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetWebAccountSettingsResponse>(request, options, cancellationToken);
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