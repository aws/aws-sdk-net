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
 * Do not modify this file. This file is generated from the iam-toolbox-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.IAMToolbox.Model;
using Amazon.IAMToolbox.Model.Internal.MarshallTransformations;
using Amazon.IAMToolbox.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.IAMToolbox
{
    /// <summary>
    /// <para>Implementation for accessing IAMToolbox</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// Contains APIs to work with AWS Identity and Access Management (IAM).
    /// </summary>
    public partial class AmazonIAMToolboxClient : AmazonServiceClient, IAmazonIAMToolbox
    {
        private static IServiceMetadata serviceMetadata = new AmazonIAMToolboxMetadata();
        private IIAMToolboxPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IIAMToolboxPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new IAMToolboxPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonIAMToolboxClient with the credentials loaded from the application's
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
        public AmazonIAMToolboxClient()
            : base(new AmazonIAMToolboxConfig()) { }

        /// <summary>
        /// Constructs AmazonIAMToolboxClient with the credentials loaded from the application's
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
        public AmazonIAMToolboxClient(RegionEndpoint region)
            : base(new AmazonIAMToolboxConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIAMToolboxClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIAMToolboxClient Configuration Object</param>
        public AmazonIAMToolboxClient(AmazonIAMToolboxConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonIAMToolboxClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIAMToolboxClient(AWSCredentials credentials)
            : this(credentials, new AmazonIAMToolboxConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIAMToolboxClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIAMToolboxClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIAMToolboxConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIAMToolboxClient with AWS Credentials and an
        /// AmazonIAMToolboxClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIAMToolboxClient Configuration Object</param>
        public AmazonIAMToolboxClient(AWSCredentials credentials, AmazonIAMToolboxConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIAMToolboxClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIAMToolboxClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIAMToolboxConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIAMToolboxClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIAMToolboxClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIAMToolboxConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIAMToolboxClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIAMToolboxClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIAMToolboxClient Configuration Object</param>
        public AmazonIAMToolboxClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIAMToolboxConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIAMToolboxClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIAMToolboxClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIAMToolboxConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIAMToolboxClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIAMToolboxClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIAMToolboxConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIAMToolboxClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIAMToolboxClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIAMToolboxClient Configuration Object</param>
        public AmazonIAMToolboxClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIAMToolboxConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIAMToolboxEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIAMToolboxAuthSchemeHandler());
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


        #region  GetRequestAuthorizationDetails


        /// <summary>
        /// Retrieves the authorization details for a specific access denied request. The details
        /// include the request context, the evaluations performed, and the policies that were
        /// evaluated.
        /// 
        ///  
        /// <para>
        /// Use this operation to understand why a request was denied. Supported services include
        /// an authorization ID in the access denied error message. Pass that ID to this operation
        /// to retrieve the details.
        /// </para>
        ///  
        /// <para>
        /// Authorization details are available for at least 24 hours after the denial.
        /// </para>
        ///  
        /// <para>
        /// To use this operation, you must have the <c>iam:GetRequestAuthorizationDetails</c>
        /// permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRequestAuthorizationDetails service method.</param>
        /// 
        /// <returns>The response from the GetRequestAuthorizationDetails service method, as returned by IAMToolbox.</returns>
        /// <exception cref="Amazon.IAMToolbox.Model.AccessDeniedException">
        /// The caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMToolbox.Model.InternalServerException">
        /// An unexpected error occurred while processing the request. Try again.
        /// </exception>
        /// <exception cref="Amazon.IAMToolbox.Model.ResourceNotFoundException">
        /// The requested authorization details do not exist in this region or have expired. Verify
        /// that the authorization ID from the access denied error message is correct and the
        /// call is made in the region where the denial occurred. Ensure that the calling principal
        /// belongs to the same account or organization as the original denied request.
        /// </exception>
        /// <exception cref="Amazon.IAMToolbox.Model.ValidationException">
        /// The request is malformed or is missing one or more required parameters. Check the
        /// request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-toolbox-2018-05-10/GetRequestAuthorizationDetails">REST API Reference for GetRequestAuthorizationDetails Operation</seealso>
        public virtual GetRequestAuthorizationDetailsResponse GetRequestAuthorizationDetails(GetRequestAuthorizationDetailsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRequestAuthorizationDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRequestAuthorizationDetailsResponseUnmarshaller.Instance;

            return Invoke<GetRequestAuthorizationDetailsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the authorization details for a specific access denied request. The details
        /// include the request context, the evaluations performed, and the policies that were
        /// evaluated.
        /// 
        ///  
        /// <para>
        /// Use this operation to understand why a request was denied. Supported services include
        /// an authorization ID in the access denied error message. Pass that ID to this operation
        /// to retrieve the details.
        /// </para>
        ///  
        /// <para>
        /// Authorization details are available for at least 24 hours after the denial.
        /// </para>
        ///  
        /// <para>
        /// To use this operation, you must have the <c>iam:GetRequestAuthorizationDetails</c>
        /// permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRequestAuthorizationDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRequestAuthorizationDetails service method, as returned by IAMToolbox.</returns>
        /// <exception cref="Amazon.IAMToolbox.Model.AccessDeniedException">
        /// The caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMToolbox.Model.InternalServerException">
        /// An unexpected error occurred while processing the request. Try again.
        /// </exception>
        /// <exception cref="Amazon.IAMToolbox.Model.ResourceNotFoundException">
        /// The requested authorization details do not exist in this region or have expired. Verify
        /// that the authorization ID from the access denied error message is correct and the
        /// call is made in the region where the denial occurred. Ensure that the calling principal
        /// belongs to the same account or organization as the original denied request.
        /// </exception>
        /// <exception cref="Amazon.IAMToolbox.Model.ValidationException">
        /// The request is malformed or is missing one or more required parameters. Check the
        /// request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-toolbox-2018-05-10/GetRequestAuthorizationDetails">REST API Reference for GetRequestAuthorizationDetails Operation</seealso>
        public virtual Task<GetRequestAuthorizationDetailsResponse> GetRequestAuthorizationDetailsAsync(GetRequestAuthorizationDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRequestAuthorizationDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRequestAuthorizationDetailsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRequestAuthorizationDetailsResponse>(request, options, cancellationToken);
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