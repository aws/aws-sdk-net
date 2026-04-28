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
 * Do not modify this file. This file is generated from the sustainability-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Sustainability.Model;
using Amazon.Sustainability.Model.Internal.MarshallTransformations;
using Amazon.Sustainability.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Sustainability
{
    /// <summary>
    /// <para>Implementation for accessing Sustainability</para>
    ///
    /// The AWS Sustainability service provides programmatic access to estimated carbon emissions
    /// data for your Amazon Web Services usage. Use the AWS Sustainability service to retrieve,
    /// analyze, and track the carbon footprint of your cloud infrastructure over time. 
    /// 
    ///  
    /// <para>
    /// With the AWS Sustainability service, you can:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Retrieve estimated carbon emissions for your Amazon Web Services usage across different
    /// time periods 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Group emissions data by dimensions such as account, region, and service
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Filter emissions data to focus on specific accounts, regions, or services
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Access multiple emissions calculation methodologies including Location-based Method
    /// (LBM) and Market-based Method (MBM) 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Aggregate emissions data at various time granularities including monthly, quarterly,
    /// and yearly periods 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  The API supports pagination for efficient data retrieval and provides dimension values
    /// to help you understand the available grouping and filtering options for your account.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  All emissions values are calculated using methodologies aligned with the Greenhouse
    /// Gas (GHG) Protocol and are provided in metric tons of carbon dioxide-equivalent (MTCO2e).
    /// 
    /// </para>
    /// </summary>
    public partial class AmazonSustainabilityClient : AmazonServiceClient, IAmazonSustainability
    {
        private static IServiceMetadata serviceMetadata = new AmazonSustainabilityMetadata();
        private ISustainabilityPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISustainabilityPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SustainabilityPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonSustainabilityClient with the credentials loaded from the application's
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
        public AmazonSustainabilityClient()
            : base(new AmazonSustainabilityConfig()) { }

        /// <summary>
        /// Constructs AmazonSustainabilityClient with the credentials loaded from the application's
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
        public AmazonSustainabilityClient(RegionEndpoint region)
            : base(new AmazonSustainabilityConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSustainabilityClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSustainabilityClient Configuration Object</param>
        public AmazonSustainabilityClient(AmazonSustainabilityConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonSustainabilityClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSustainabilityClient(AWSCredentials credentials)
            : this(credentials, new AmazonSustainabilityConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSustainabilityClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSustainabilityClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSustainabilityConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSustainabilityClient with AWS Credentials and an
        /// AmazonSustainabilityClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSustainabilityClient Configuration Object</param>
        public AmazonSustainabilityClient(AWSCredentials credentials, AmazonSustainabilityConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSustainabilityClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSustainabilityClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSustainabilityConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSustainabilityClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSustainabilityClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSustainabilityConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSustainabilityClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSustainabilityClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSustainabilityClient Configuration Object</param>
        public AmazonSustainabilityClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSustainabilityConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSustainabilityClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSustainabilityClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSustainabilityConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSustainabilityClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSustainabilityClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSustainabilityConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSustainabilityClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSustainabilityClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSustainabilityClient Configuration Object</param>
        public AmazonSustainabilityClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSustainabilityConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSustainabilityEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSustainabilityAuthSchemeHandler());
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


        #region  GetEstimatedCarbonEmissions


        /// <summary>
        /// Returns estimated carbon emission values based on customer grouping and filtering
        /// parameters. We recommend using pagination to ensure that the operation returns quickly
        /// and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEstimatedCarbonEmissions service method.</param>
        /// 
        /// <returns>The response from the GetEstimatedCarbonEmissions service method, as returned by Sustainability.</returns>
        /// <exception cref="Amazon.Sustainability.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Sustainability.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Sustainability.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Sustainability.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sustainability-2018-05-10/GetEstimatedCarbonEmissions">REST API Reference for GetEstimatedCarbonEmissions Operation</seealso>
        public virtual GetEstimatedCarbonEmissionsResponse GetEstimatedCarbonEmissions(GetEstimatedCarbonEmissionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEstimatedCarbonEmissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEstimatedCarbonEmissionsResponseUnmarshaller.Instance;

            return Invoke<GetEstimatedCarbonEmissionsResponse>(request, options);
        }


        /// <summary>
        /// Returns estimated carbon emission values based on customer grouping and filtering
        /// parameters. We recommend using pagination to ensure that the operation returns quickly
        /// and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEstimatedCarbonEmissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEstimatedCarbonEmissions service method, as returned by Sustainability.</returns>
        /// <exception cref="Amazon.Sustainability.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Sustainability.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Sustainability.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Sustainability.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sustainability-2018-05-10/GetEstimatedCarbonEmissions">REST API Reference for GetEstimatedCarbonEmissions Operation</seealso>
        public virtual Task<GetEstimatedCarbonEmissionsResponse> GetEstimatedCarbonEmissionsAsync(GetEstimatedCarbonEmissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEstimatedCarbonEmissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEstimatedCarbonEmissionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetEstimatedCarbonEmissionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEstimatedCarbonEmissionsDimensionValues


        /// <summary>
        /// Returns the possible dimension values available for a customer's account. We recommend
        /// using pagination to ensure that the operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEstimatedCarbonEmissionsDimensionValues service method.</param>
        /// 
        /// <returns>The response from the GetEstimatedCarbonEmissionsDimensionValues service method, as returned by Sustainability.</returns>
        /// <exception cref="Amazon.Sustainability.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Sustainability.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Sustainability.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Sustainability.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sustainability-2018-05-10/GetEstimatedCarbonEmissionsDimensionValues">REST API Reference for GetEstimatedCarbonEmissionsDimensionValues Operation</seealso>
        public virtual GetEstimatedCarbonEmissionsDimensionValuesResponse GetEstimatedCarbonEmissionsDimensionValues(GetEstimatedCarbonEmissionsDimensionValuesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEstimatedCarbonEmissionsDimensionValuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEstimatedCarbonEmissionsDimensionValuesResponseUnmarshaller.Instance;

            return Invoke<GetEstimatedCarbonEmissionsDimensionValuesResponse>(request, options);
        }


        /// <summary>
        /// Returns the possible dimension values available for a customer's account. We recommend
        /// using pagination to ensure that the operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEstimatedCarbonEmissionsDimensionValues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEstimatedCarbonEmissionsDimensionValues service method, as returned by Sustainability.</returns>
        /// <exception cref="Amazon.Sustainability.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Sustainability.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Sustainability.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Sustainability.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sustainability-2018-05-10/GetEstimatedCarbonEmissionsDimensionValues">REST API Reference for GetEstimatedCarbonEmissionsDimensionValues Operation</seealso>
        public virtual Task<GetEstimatedCarbonEmissionsDimensionValuesResponse> GetEstimatedCarbonEmissionsDimensionValuesAsync(GetEstimatedCarbonEmissionsDimensionValuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEstimatedCarbonEmissionsDimensionValuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEstimatedCarbonEmissionsDimensionValuesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetEstimatedCarbonEmissionsDimensionValuesResponse>(request, options, cancellationToken);
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