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
 * Do not modify this file. This file is generated from the license-manager-linux-subscriptions-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.LicenseManagerLinuxSubscriptions.Model;
using Amazon.LicenseManagerLinuxSubscriptions.Model.Internal.MarshallTransformations;
using Amazon.LicenseManagerLinuxSubscriptions.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.LicenseManagerLinuxSubscriptions
{
    /// <summary>
    /// <para>Implementation for accessing LicenseManagerLinuxSubscriptions</para>
    ///
    /// With License Manager, you can discover and track your commercial Linux subscriptions
    /// on running Amazon EC2 instances.
    /// </summary>
    public partial class AmazonLicenseManagerLinuxSubscriptionsClient : AmazonServiceClient, IAmazonLicenseManagerLinuxSubscriptions
    {
        private static IServiceMetadata serviceMetadata = new AmazonLicenseManagerLinuxSubscriptionsMetadata();
        private ILicenseManagerLinuxSubscriptionsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ILicenseManagerLinuxSubscriptionsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new LicenseManagerLinuxSubscriptionsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonLicenseManagerLinuxSubscriptionsClient with the credentials loaded from the application's
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
        public AmazonLicenseManagerLinuxSubscriptionsClient()
            : base(new AmazonLicenseManagerLinuxSubscriptionsConfig()) { }

        /// <summary>
        /// Constructs AmazonLicenseManagerLinuxSubscriptionsClient with the credentials loaded from the application's
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
        public AmazonLicenseManagerLinuxSubscriptionsClient(RegionEndpoint region)
            : base(new AmazonLicenseManagerLinuxSubscriptionsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonLicenseManagerLinuxSubscriptionsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonLicenseManagerLinuxSubscriptionsClient Configuration Object</param>
        public AmazonLicenseManagerLinuxSubscriptionsClient(AmazonLicenseManagerLinuxSubscriptionsConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonLicenseManagerLinuxSubscriptionsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonLicenseManagerLinuxSubscriptionsClient(AWSCredentials credentials)
            : this(credentials, new AmazonLicenseManagerLinuxSubscriptionsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerLinuxSubscriptionsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLicenseManagerLinuxSubscriptionsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonLicenseManagerLinuxSubscriptionsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerLinuxSubscriptionsClient with AWS Credentials and an
        /// AmazonLicenseManagerLinuxSubscriptionsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonLicenseManagerLinuxSubscriptionsClient Configuration Object</param>
        public AmazonLicenseManagerLinuxSubscriptionsClient(AWSCredentials credentials, AmazonLicenseManagerLinuxSubscriptionsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerLinuxSubscriptionsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonLicenseManagerLinuxSubscriptionsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLicenseManagerLinuxSubscriptionsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerLinuxSubscriptionsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLicenseManagerLinuxSubscriptionsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLicenseManagerLinuxSubscriptionsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerLinuxSubscriptionsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLicenseManagerLinuxSubscriptionsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonLicenseManagerLinuxSubscriptionsClient Configuration Object</param>
        public AmazonLicenseManagerLinuxSubscriptionsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonLicenseManagerLinuxSubscriptionsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerLinuxSubscriptionsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonLicenseManagerLinuxSubscriptionsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLicenseManagerLinuxSubscriptionsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerLinuxSubscriptionsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLicenseManagerLinuxSubscriptionsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLicenseManagerLinuxSubscriptionsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerLinuxSubscriptionsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLicenseManagerLinuxSubscriptionsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonLicenseManagerLinuxSubscriptionsClient Configuration Object</param>
        public AmazonLicenseManagerLinuxSubscriptionsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonLicenseManagerLinuxSubscriptionsConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLicenseManagerLinuxSubscriptionsEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLicenseManagerLinuxSubscriptionsAuthSchemeHandler());
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


        #region  DeregisterSubscriptionProvider


        /// <summary>
        /// Remove a third-party subscription provider from the Bring Your Own License (BYOL)
        /// subscriptions registered to your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterSubscriptionProvider service method.</param>
        /// 
        /// <returns>The response from the DeregisterSubscriptionProvider service method, as returned by LicenseManagerLinuxSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ResourceNotFoundException">
        /// Unable to find the requested Amazon Web Services resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/DeregisterSubscriptionProvider">REST API Reference for DeregisterSubscriptionProvider Operation</seealso>
        public virtual DeregisterSubscriptionProviderResponse DeregisterSubscriptionProvider(DeregisterSubscriptionProviderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterSubscriptionProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterSubscriptionProviderResponseUnmarshaller.Instance;

            return Invoke<DeregisterSubscriptionProviderResponse>(request, options);
        }


        /// <summary>
        /// Remove a third-party subscription provider from the Bring Your Own License (BYOL)
        /// subscriptions registered to your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterSubscriptionProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterSubscriptionProvider service method, as returned by LicenseManagerLinuxSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ResourceNotFoundException">
        /// Unable to find the requested Amazon Web Services resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/DeregisterSubscriptionProvider">REST API Reference for DeregisterSubscriptionProvider Operation</seealso>
        public virtual Task<DeregisterSubscriptionProviderResponse> DeregisterSubscriptionProviderAsync(DeregisterSubscriptionProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterSubscriptionProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterSubscriptionProviderResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeregisterSubscriptionProviderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRegisteredSubscriptionProvider


        /// <summary>
        /// Get details for a Bring Your Own License (BYOL) subscription that's registered to
        /// your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegisteredSubscriptionProvider service method.</param>
        /// 
        /// <returns>The response from the GetRegisteredSubscriptionProvider service method, as returned by LicenseManagerLinuxSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ResourceNotFoundException">
        /// Unable to find the requested Amazon Web Services resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/GetRegisteredSubscriptionProvider">REST API Reference for GetRegisteredSubscriptionProvider Operation</seealso>
        public virtual GetRegisteredSubscriptionProviderResponse GetRegisteredSubscriptionProvider(GetRegisteredSubscriptionProviderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRegisteredSubscriptionProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegisteredSubscriptionProviderResponseUnmarshaller.Instance;

            return Invoke<GetRegisteredSubscriptionProviderResponse>(request, options);
        }


        /// <summary>
        /// Get details for a Bring Your Own License (BYOL) subscription that's registered to
        /// your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegisteredSubscriptionProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRegisteredSubscriptionProvider service method, as returned by LicenseManagerLinuxSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ResourceNotFoundException">
        /// Unable to find the requested Amazon Web Services resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/GetRegisteredSubscriptionProvider">REST API Reference for GetRegisteredSubscriptionProvider Operation</seealso>
        public virtual Task<GetRegisteredSubscriptionProviderResponse> GetRegisteredSubscriptionProviderAsync(GetRegisteredSubscriptionProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRegisteredSubscriptionProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegisteredSubscriptionProviderResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRegisteredSubscriptionProviderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetServiceSettings


        /// <summary>
        /// Lists the Linux subscriptions service settings for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSettings service method.</param>
        /// 
        /// <returns>The response from the GetServiceSettings service method, as returned by LicenseManagerLinuxSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/GetServiceSettings">REST API Reference for GetServiceSettings Operation</seealso>
        public virtual GetServiceSettingsResponse GetServiceSettings(GetServiceSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServiceSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceSettingsResponseUnmarshaller.Instance;

            return Invoke<GetServiceSettingsResponse>(request, options);
        }


        /// <summary>
        /// Lists the Linux subscriptions service settings for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceSettings service method, as returned by LicenseManagerLinuxSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/GetServiceSettings">REST API Reference for GetServiceSettings Operation</seealso>
        public virtual Task<GetServiceSettingsResponse> GetServiceSettingsAsync(GetServiceSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServiceSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetServiceSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLinuxSubscriptionInstances


        /// <summary>
        /// Lists the running Amazon EC2 instances that were discovered with commercial Linux
        /// subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLinuxSubscriptionInstances service method.</param>
        /// 
        /// <returns>The response from the ListLinuxSubscriptionInstances service method, as returned by LicenseManagerLinuxSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/ListLinuxSubscriptionInstances">REST API Reference for ListLinuxSubscriptionInstances Operation</seealso>
        public virtual ListLinuxSubscriptionInstancesResponse ListLinuxSubscriptionInstances(ListLinuxSubscriptionInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLinuxSubscriptionInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLinuxSubscriptionInstancesResponseUnmarshaller.Instance;

            return Invoke<ListLinuxSubscriptionInstancesResponse>(request, options);
        }


        /// <summary>
        /// Lists the running Amazon EC2 instances that were discovered with commercial Linux
        /// subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLinuxSubscriptionInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLinuxSubscriptionInstances service method, as returned by LicenseManagerLinuxSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/ListLinuxSubscriptionInstances">REST API Reference for ListLinuxSubscriptionInstances Operation</seealso>
        public virtual Task<ListLinuxSubscriptionInstancesResponse> ListLinuxSubscriptionInstancesAsync(ListLinuxSubscriptionInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLinuxSubscriptionInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLinuxSubscriptionInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListLinuxSubscriptionInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLinuxSubscriptions


        /// <summary>
        /// Lists the Linux subscriptions that have been discovered. If you have linked your organization,
        /// the returned results will include data aggregated across your accounts in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLinuxSubscriptions service method.</param>
        /// 
        /// <returns>The response from the ListLinuxSubscriptions service method, as returned by LicenseManagerLinuxSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/ListLinuxSubscriptions">REST API Reference for ListLinuxSubscriptions Operation</seealso>
        public virtual ListLinuxSubscriptionsResponse ListLinuxSubscriptions(ListLinuxSubscriptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLinuxSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLinuxSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<ListLinuxSubscriptionsResponse>(request, options);
        }


        /// <summary>
        /// Lists the Linux subscriptions that have been discovered. If you have linked your organization,
        /// the returned results will include data aggregated across your accounts in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLinuxSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLinuxSubscriptions service method, as returned by LicenseManagerLinuxSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/ListLinuxSubscriptions">REST API Reference for ListLinuxSubscriptions Operation</seealso>
        public virtual Task<ListLinuxSubscriptionsResponse> ListLinuxSubscriptionsAsync(ListLinuxSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLinuxSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLinuxSubscriptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListLinuxSubscriptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRegisteredSubscriptionProviders


        /// <summary>
        /// List Bring Your Own License (BYOL) subscription registration resources for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegisteredSubscriptionProviders service method.</param>
        /// 
        /// <returns>The response from the ListRegisteredSubscriptionProviders service method, as returned by LicenseManagerLinuxSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/ListRegisteredSubscriptionProviders">REST API Reference for ListRegisteredSubscriptionProviders Operation</seealso>
        public virtual ListRegisteredSubscriptionProvidersResponse ListRegisteredSubscriptionProviders(ListRegisteredSubscriptionProvidersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRegisteredSubscriptionProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegisteredSubscriptionProvidersResponseUnmarshaller.Instance;

            return Invoke<ListRegisteredSubscriptionProvidersResponse>(request, options);
        }


        /// <summary>
        /// List Bring Your Own License (BYOL) subscription registration resources for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegisteredSubscriptionProviders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRegisteredSubscriptionProviders service method, as returned by LicenseManagerLinuxSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/ListRegisteredSubscriptionProviders">REST API Reference for ListRegisteredSubscriptionProviders Operation</seealso>
        public virtual Task<ListRegisteredSubscriptionProvidersResponse> ListRegisteredSubscriptionProvidersAsync(ListRegisteredSubscriptionProvidersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRegisteredSubscriptionProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegisteredSubscriptionProvidersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRegisteredSubscriptionProvidersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List the metadata tags that are assigned to the specified Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LicenseManagerLinuxSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ResourceNotFoundException">
        /// Unable to find the requested Amazon Web Services resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// List the metadata tags that are assigned to the specified Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LicenseManagerLinuxSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ResourceNotFoundException">
        /// Unable to find the requested Amazon Web Services resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterSubscriptionProvider


        /// <summary>
        /// Register the supported third-party subscription provider for your Bring Your Own License
        /// (BYOL) subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterSubscriptionProvider service method.</param>
        /// 
        /// <returns>The response from the RegisterSubscriptionProvider service method, as returned by LicenseManagerLinuxSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/RegisterSubscriptionProvider">REST API Reference for RegisterSubscriptionProvider Operation</seealso>
        public virtual RegisterSubscriptionProviderResponse RegisterSubscriptionProvider(RegisterSubscriptionProviderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterSubscriptionProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterSubscriptionProviderResponseUnmarshaller.Instance;

            return Invoke<RegisterSubscriptionProviderResponse>(request, options);
        }


        /// <summary>
        /// Register the supported third-party subscription provider for your Bring Your Own License
        /// (BYOL) subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterSubscriptionProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterSubscriptionProvider service method, as returned by LicenseManagerLinuxSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/RegisterSubscriptionProvider">REST API Reference for RegisterSubscriptionProvider Operation</seealso>
        public virtual Task<RegisterSubscriptionProviderResponse> RegisterSubscriptionProviderAsync(RegisterSubscriptionProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterSubscriptionProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterSubscriptionProviderResponseUnmarshaller.Instance;
            
            return InvokeAsync<RegisterSubscriptionProviderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Add metadata tags to the specified Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LicenseManagerLinuxSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ResourceNotFoundException">
        /// Unable to find the requested Amazon Web Services resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Add metadata tags to the specified Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LicenseManagerLinuxSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ResourceNotFoundException">
        /// Unable to find the requested Amazon Web Services resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Remove one or more metadata tag from the specified Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LicenseManagerLinuxSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ResourceNotFoundException">
        /// Unable to find the requested Amazon Web Services resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Remove one or more metadata tag from the specified Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LicenseManagerLinuxSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ResourceNotFoundException">
        /// Unable to find the requested Amazon Web Services resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateServiceSettings


        /// <summary>
        /// Updates the service settings for Linux subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceSettings service method, as returned by LicenseManagerLinuxSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/UpdateServiceSettings">REST API Reference for UpdateServiceSettings Operation</seealso>
        public virtual UpdateServiceSettingsResponse UpdateServiceSettings(UpdateServiceSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateServiceSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceSettingsResponse>(request, options);
        }


        /// <summary>
        /// Updates the service settings for Linux subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateServiceSettings service method, as returned by LicenseManagerLinuxSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/UpdateServiceSettings">REST API Reference for UpdateServiceSettings Operation</seealso>
        public virtual Task<UpdateServiceSettingsResponse> UpdateServiceSettingsAsync(UpdateServiceSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateServiceSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateServiceSettingsResponse>(request, options, cancellationToken);
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