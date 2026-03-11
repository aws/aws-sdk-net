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
 * Do not modify this file. This file is generated from the bcm-recommended-actions-2024-11-14.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.BCMRecommendedActions.Model;
using Amazon.BCMRecommendedActions.Model.Internal.MarshallTransformations;
using Amazon.BCMRecommendedActions.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.BCMRecommendedActions
{
    /// <summary>
    /// <para>Implementation for accessing BCMRecommendedActions</para>
    ///
    /// You can use the Billing and Cost Management Recommended Actions API to programmatically
    /// query your best practices and recommendations to optimize your costs.
    /// 
    ///  
    /// <para>
    /// The Billing and Cost Management Recommended Actions API provides the following endpoint:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  https://bcm-recommended-actions.us-east-1.api.aws
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonBCMRecommendedActionsClient : AmazonServiceClient, IAmazonBCMRecommendedActions
    {
        private static IServiceMetadata serviceMetadata = new AmazonBCMRecommendedActionsMetadata();
        private IBCMRecommendedActionsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IBCMRecommendedActionsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new BCMRecommendedActionsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonBCMRecommendedActionsClient with the credentials loaded from the application's
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
        public AmazonBCMRecommendedActionsClient()
            : base(new AmazonBCMRecommendedActionsConfig()) { }

        /// <summary>
        /// Constructs AmazonBCMRecommendedActionsClient with the credentials loaded from the application's
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
        public AmazonBCMRecommendedActionsClient(RegionEndpoint region)
            : base(new AmazonBCMRecommendedActionsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonBCMRecommendedActionsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonBCMRecommendedActionsClient Configuration Object</param>
        public AmazonBCMRecommendedActionsClient(AmazonBCMRecommendedActionsConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonBCMRecommendedActionsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonBCMRecommendedActionsClient(AWSCredentials credentials)
            : this(credentials, new AmazonBCMRecommendedActionsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBCMRecommendedActionsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBCMRecommendedActionsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonBCMRecommendedActionsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBCMRecommendedActionsClient with AWS Credentials and an
        /// AmazonBCMRecommendedActionsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonBCMRecommendedActionsClient Configuration Object</param>
        public AmazonBCMRecommendedActionsClient(AWSCredentials credentials, AmazonBCMRecommendedActionsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBCMRecommendedActionsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonBCMRecommendedActionsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBCMRecommendedActionsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBCMRecommendedActionsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBCMRecommendedActionsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBCMRecommendedActionsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonBCMRecommendedActionsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBCMRecommendedActionsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonBCMRecommendedActionsClient Configuration Object</param>
        public AmazonBCMRecommendedActionsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonBCMRecommendedActionsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBCMRecommendedActionsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonBCMRecommendedActionsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBCMRecommendedActionsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBCMRecommendedActionsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBCMRecommendedActionsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBCMRecommendedActionsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBCMRecommendedActionsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBCMRecommendedActionsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonBCMRecommendedActionsClient Configuration Object</param>
        public AmazonBCMRecommendedActionsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonBCMRecommendedActionsConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBCMRecommendedActionsEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBCMRecommendedActionsAuthSchemeHandler());
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


        #region  ListRecommendedActions


        /// <summary>
        /// Returns a list of recommended actions that match the filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendedActions service method.</param>
        /// 
        /// <returns>The response from the ListRecommendedActions service method, as returned by BCMRecommendedActions.</returns>
        /// <exception cref="Amazon.BCMRecommendedActions.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMRecommendedActions.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.BCMRecommendedActions.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMRecommendedActions.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-recommended-actions-2024-11-14/ListRecommendedActions">REST API Reference for ListRecommendedActions Operation</seealso>
        public virtual ListRecommendedActionsResponse ListRecommendedActions(ListRecommendedActionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecommendedActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendedActionsResponseUnmarshaller.Instance;

            return Invoke<ListRecommendedActionsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of recommended actions that match the filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendedActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecommendedActions service method, as returned by BCMRecommendedActions.</returns>
        /// <exception cref="Amazon.BCMRecommendedActions.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMRecommendedActions.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.BCMRecommendedActions.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMRecommendedActions.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-recommended-actions-2024-11-14/ListRecommendedActions">REST API Reference for ListRecommendedActions Operation</seealso>
        public virtual Task<ListRecommendedActionsResponse> ListRecommendedActionsAsync(ListRecommendedActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecommendedActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendedActionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRecommendedActionsResponse>(request, options, cancellationToken);
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