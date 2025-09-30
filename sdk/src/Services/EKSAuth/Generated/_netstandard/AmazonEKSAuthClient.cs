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
 * Do not modify this file. This file is generated from the eks-auth-2023-11-26.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.EKSAuth.Model;
using Amazon.EKSAuth.Model.Internal.MarshallTransformations;
using Amazon.EKSAuth.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.EKSAuth
{
    /// <summary>
    /// <para>Implementation for accessing EKSAuth</para>
    ///
    /// The Amazon EKS Auth API and the <c>AssumeRoleForPodIdentity</c> action are only used
    /// by the EKS Pod Identity Agent.
    /// </summary>
    public partial class AmazonEKSAuthClient : AmazonServiceClient, IAmazonEKSAuth
    {
        private static IServiceMetadata serviceMetadata = new AmazonEKSAuthMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonEKSAuthClient with the credentials loaded from the application's
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
        public AmazonEKSAuthClient()
            : base(new AmazonEKSAuthConfig()) { }

        /// <summary>
        /// Constructs AmazonEKSAuthClient with the credentials loaded from the application's
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
        public AmazonEKSAuthClient(RegionEndpoint region)
            : base(new AmazonEKSAuthConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonEKSAuthClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonEKSAuthClient Configuration Object</param>
        public AmazonEKSAuthClient(AmazonEKSAuthConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonEKSAuthClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonEKSAuthClient(AWSCredentials credentials)
            : this(credentials, new AmazonEKSAuthConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEKSAuthClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEKSAuthClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonEKSAuthConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEKSAuthClient with AWS Credentials and an
        /// AmazonEKSAuthClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonEKSAuthClient Configuration Object</param>
        public AmazonEKSAuthClient(AWSCredentials credentials, AmazonEKSAuthConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEKSAuthClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonEKSAuthClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEKSAuthConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEKSAuthClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEKSAuthClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEKSAuthConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonEKSAuthClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEKSAuthClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonEKSAuthClient Configuration Object</param>
        public AmazonEKSAuthClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonEKSAuthConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEKSAuthClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonEKSAuthClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEKSAuthConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEKSAuthClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEKSAuthClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEKSAuthConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEKSAuthClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEKSAuthClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonEKSAuthClient Configuration Object</param>
        public AmazonEKSAuthClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonEKSAuthConfig clientConfig)
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
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonEKSAuthEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonEKSAuthAuthSchemeHandler());
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


        #region  AssumeRoleForPodIdentity

        internal virtual AssumeRoleForPodIdentityResponse AssumeRoleForPodIdentity(AssumeRoleForPodIdentityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssumeRoleForPodIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeRoleForPodIdentityResponseUnmarshaller.Instance;

            return Invoke<AssumeRoleForPodIdentityResponse>(request, options);
        }



        /// <summary>
        /// The Amazon EKS Auth API and the <c>AssumeRoleForPodIdentity</c> action are only used
        /// by the EKS Pod Identity Agent.
        /// 
        ///  
        /// <para>
        /// We recommend that applications use the Amazon Web Services SDKs to connect to Amazon
        /// Web Services services; if credentials from an EKS Pod Identity association are available
        /// in the pod, the latest versions of the SDKs use them automatically.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeRoleForPodIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssumeRoleForPodIdentity service method, as returned by EKSAuth.</returns>
        /// <exception cref="Amazon.EKSAuth.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The IAM principal making
        /// the request must have at least one IAM permissions policy attached that grants the
        /// required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.EKSAuth.Model.ExpiredTokenException">
        /// The specified Kubernetes service account token is expired.
        /// </exception>
        /// <exception cref="Amazon.EKSAuth.Model.InternalServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKSAuth.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKSAuth.Model.InvalidRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// will depend on the API, and will be documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.EKSAuth.Model.InvalidTokenException">
        /// The specified Kubernetes service account token is invalid.
        /// </exception>
        /// <exception cref="Amazon.EKSAuth.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.EKSAuth.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.EKSAuth.Model.ThrottlingException">
        /// The request was denied because your request rate is too high. Reduce the frequency
        /// of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-auth-2023-11-26/AssumeRoleForPodIdentity">REST API Reference for AssumeRoleForPodIdentity Operation</seealso>
        public virtual Task<AssumeRoleForPodIdentityResponse> AssumeRoleForPodIdentityAsync(AssumeRoleForPodIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssumeRoleForPodIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeRoleForPodIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<AssumeRoleForPodIdentityResponse>(request, options, cancellationToken);
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