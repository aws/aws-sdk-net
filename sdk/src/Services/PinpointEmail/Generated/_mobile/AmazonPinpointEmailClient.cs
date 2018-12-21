/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.PinpointEmail.Model;
using Amazon.PinpointEmail.Model.Internal.MarshallTransformations;
using Amazon.PinpointEmail.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.PinpointEmail
{
    /// <summary>
    /// Implementation for accessing PinpointEmail
    ///
    /// Amazon Pinpoint Email Service 
    /// <para>
    ///  This document contains reference information for the <a href="https://aws.amazon.com/pinpoint">Amazon
    /// Pinpoint</a> Email API, version 1.0. This document is best used in conjunction with
    /// the <a href="http://docs.aws.amazon.com/pinpoint/latest/developerguide/welcome.html">Amazon
    /// Pinpoint Developer Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// The Amazon Pinpoint Email API is available in the US East (N. Virginia), US West (Oregon)
    /// and the EU (Ireland) Regions at the following endpoints:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>US East (N. Virginia)</b>: <code>email.us-east-1.amazonaws.com</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>US West (Oregon)</b>: <code>email.us-west-2.amazonaws.com</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>EU (Ireland)</b>: <code>email.eu-west-1.amazonaws.com</code> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonPinpointEmailClient : AmazonServiceClient, IAmazonPinpointEmail
    {
        private static IServiceMetadata serviceMetadata = new AmazonPinpointEmailMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonPinpointEmailClient with the credentials loaded from the application's
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
        public AmazonPinpointEmailClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPinpointEmailConfig()) { }

        /// <summary>
        /// Constructs AmazonPinpointEmailClient with the credentials loaded from the application's
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
        public AmazonPinpointEmailClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPinpointEmailConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPinpointEmailClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPinpointEmailClient Configuration Object</param>
        public AmazonPinpointEmailClient(AmazonPinpointEmailConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonPinpointEmailClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPinpointEmailClient(AWSCredentials credentials)
            : this(credentials, new AmazonPinpointEmailConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointEmailClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPinpointEmailClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPinpointEmailConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointEmailClient with AWS Credentials and an
        /// AmazonPinpointEmailClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPinpointEmailClient Configuration Object</param>
        public AmazonPinpointEmailClient(AWSCredentials credentials, AmazonPinpointEmailConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointEmailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPinpointEmailClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPinpointEmailConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointEmailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPinpointEmailClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPinpointEmailConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointEmailClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPinpointEmailClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPinpointEmailClient Configuration Object</param>
        public AmazonPinpointEmailClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPinpointEmailConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointEmailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPinpointEmailClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPinpointEmailConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointEmailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPinpointEmailClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPinpointEmailConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointEmailClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPinpointEmailClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPinpointEmailClient Configuration Object</param>
        public AmazonPinpointEmailClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPinpointEmailConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
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


        #region  CreateConfigurationSet

        internal virtual CreateConfigurationSetResponse CreateConfigurationSet(CreateConfigurationSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationSetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateConfigurationSetResponse> CreateConfigurationSetAsync(CreateConfigurationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfigurationSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateConfigurationSetEventDestination

        internal virtual CreateConfigurationSetEventDestinationResponse CreateConfigurationSetEventDestination(CreateConfigurationSetEventDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigurationSetEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationSetEventDestinationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSetEventDestination operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateConfigurationSetEventDestinationResponse> CreateConfigurationSetEventDestinationAsync(CreateConfigurationSetEventDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigurationSetEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfigurationSetEventDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDedicatedIpPool

        internal virtual CreateDedicatedIpPoolResponse CreateDedicatedIpPool(CreateDedicatedIpPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDedicatedIpPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDedicatedIpPoolResponseUnmarshaller.Instance;

            return Invoke<CreateDedicatedIpPoolResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDedicatedIpPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDedicatedIpPool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateDedicatedIpPoolResponse> CreateDedicatedIpPoolAsync(CreateDedicatedIpPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDedicatedIpPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDedicatedIpPoolResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDedicatedIpPoolResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDeliverabilityTestReport

        internal virtual CreateDeliverabilityTestReportResponse CreateDeliverabilityTestReport(CreateDeliverabilityTestReportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeliverabilityTestReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeliverabilityTestReportResponseUnmarshaller.Instance;

            return Invoke<CreateDeliverabilityTestReportResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeliverabilityTestReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeliverabilityTestReport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateDeliverabilityTestReportResponse> CreateDeliverabilityTestReportAsync(CreateDeliverabilityTestReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeliverabilityTestReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeliverabilityTestReportResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeliverabilityTestReportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEmailIdentity

        internal virtual CreateEmailIdentityResponse CreateEmailIdentity(CreateEmailIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEmailIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEmailIdentityResponseUnmarshaller.Instance;

            return Invoke<CreateEmailIdentityResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEmailIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEmailIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateEmailIdentityResponse> CreateEmailIdentityAsync(CreateEmailIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEmailIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEmailIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEmailIdentityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConfigurationSet

        internal virtual DeleteConfigurationSetResponse DeleteConfigurationSet(DeleteConfigurationSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationSetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteConfigurationSetResponse> DeleteConfigurationSetAsync(DeleteConfigurationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfigurationSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConfigurationSetEventDestination

        internal virtual DeleteConfigurationSetEventDestinationResponse DeleteConfigurationSetEventDestination(DeleteConfigurationSetEventDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationSetEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationSetEventDestinationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSetEventDestination operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteConfigurationSetEventDestinationResponse> DeleteConfigurationSetEventDestinationAsync(DeleteConfigurationSetEventDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationSetEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfigurationSetEventDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDedicatedIpPool

        internal virtual DeleteDedicatedIpPoolResponse DeleteDedicatedIpPool(DeleteDedicatedIpPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDedicatedIpPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDedicatedIpPoolResponseUnmarshaller.Instance;

            return Invoke<DeleteDedicatedIpPoolResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDedicatedIpPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDedicatedIpPool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteDedicatedIpPoolResponse> DeleteDedicatedIpPoolAsync(DeleteDedicatedIpPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDedicatedIpPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDedicatedIpPoolResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDedicatedIpPoolResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEmailIdentity

        internal virtual DeleteEmailIdentityResponse DeleteEmailIdentity(DeleteEmailIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEmailIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEmailIdentityResponseUnmarshaller.Instance;

            return Invoke<DeleteEmailIdentityResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEmailIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteEmailIdentityResponse> DeleteEmailIdentityAsync(DeleteEmailIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEmailIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEmailIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEmailIdentityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccount

        internal virtual GetAccountResponse GetAccount(GetAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountResponseUnmarshaller.Instance;

            return Invoke<GetAccountResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetAccountResponse> GetAccountAsync(GetAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBlacklistReports

        internal virtual GetBlacklistReportsResponse GetBlacklistReports(GetBlacklistReportsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBlacklistReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlacklistReportsResponseUnmarshaller.Instance;

            return Invoke<GetBlacklistReportsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBlacklistReports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBlacklistReports operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBlacklistReportsResponse> GetBlacklistReportsAsync(GetBlacklistReportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBlacklistReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlacklistReportsResponseUnmarshaller.Instance;

            return InvokeAsync<GetBlacklistReportsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConfigurationSet

        internal virtual GetConfigurationSetResponse GetConfigurationSet(GetConfigurationSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<GetConfigurationSetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetConfigurationSetResponse> GetConfigurationSetAsync(GetConfigurationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetConfigurationSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConfigurationSetEventDestinations

        internal virtual GetConfigurationSetEventDestinationsResponse GetConfigurationSetEventDestinations(GetConfigurationSetEventDestinationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfigurationSetEventDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationSetEventDestinationsResponseUnmarshaller.Instance;

            return Invoke<GetConfigurationSetEventDestinationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetConfigurationSetEventDestinations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationSetEventDestinations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetConfigurationSetEventDestinationsResponse> GetConfigurationSetEventDestinationsAsync(GetConfigurationSetEventDestinationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfigurationSetEventDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationSetEventDestinationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetConfigurationSetEventDestinationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDedicatedIp

        internal virtual GetDedicatedIpResponse GetDedicatedIp(GetDedicatedIpRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDedicatedIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDedicatedIpResponseUnmarshaller.Instance;

            return Invoke<GetDedicatedIpResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDedicatedIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDedicatedIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetDedicatedIpResponse> GetDedicatedIpAsync(GetDedicatedIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDedicatedIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDedicatedIpResponseUnmarshaller.Instance;

            return InvokeAsync<GetDedicatedIpResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDedicatedIps

        internal virtual GetDedicatedIpsResponse GetDedicatedIps(GetDedicatedIpsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDedicatedIpsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDedicatedIpsResponseUnmarshaller.Instance;

            return Invoke<GetDedicatedIpsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDedicatedIps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDedicatedIps operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetDedicatedIpsResponse> GetDedicatedIpsAsync(GetDedicatedIpsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDedicatedIpsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDedicatedIpsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDedicatedIpsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDeliverabilityDashboardOptions

        internal virtual GetDeliverabilityDashboardOptionsResponse GetDeliverabilityDashboardOptions(GetDeliverabilityDashboardOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeliverabilityDashboardOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeliverabilityDashboardOptionsResponseUnmarshaller.Instance;

            return Invoke<GetDeliverabilityDashboardOptionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDeliverabilityDashboardOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeliverabilityDashboardOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetDeliverabilityDashboardOptionsResponse> GetDeliverabilityDashboardOptionsAsync(GetDeliverabilityDashboardOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeliverabilityDashboardOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeliverabilityDashboardOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeliverabilityDashboardOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDeliverabilityTestReport

        internal virtual GetDeliverabilityTestReportResponse GetDeliverabilityTestReport(GetDeliverabilityTestReportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeliverabilityTestReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeliverabilityTestReportResponseUnmarshaller.Instance;

            return Invoke<GetDeliverabilityTestReportResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDeliverabilityTestReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeliverabilityTestReport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetDeliverabilityTestReportResponse> GetDeliverabilityTestReportAsync(GetDeliverabilityTestReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeliverabilityTestReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeliverabilityTestReportResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeliverabilityTestReportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDomainStatisticsReport

        internal virtual GetDomainStatisticsReportResponse GetDomainStatisticsReport(GetDomainStatisticsReportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainStatisticsReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainStatisticsReportResponseUnmarshaller.Instance;

            return Invoke<GetDomainStatisticsReportResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainStatisticsReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainStatisticsReport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetDomainStatisticsReportResponse> GetDomainStatisticsReportAsync(GetDomainStatisticsReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainStatisticsReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainStatisticsReportResponseUnmarshaller.Instance;

            return InvokeAsync<GetDomainStatisticsReportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEmailIdentity

        internal virtual GetEmailIdentityResponse GetEmailIdentity(GetEmailIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEmailIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEmailIdentityResponseUnmarshaller.Instance;

            return Invoke<GetEmailIdentityResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetEmailIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEmailIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetEmailIdentityResponse> GetEmailIdentityAsync(GetEmailIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEmailIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEmailIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<GetEmailIdentityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListConfigurationSets

        internal virtual ListConfigurationSetsResponse ListConfigurationSets(ListConfigurationSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfigurationSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationSetsResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationSetsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurationSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListConfigurationSetsResponse> ListConfigurationSetsAsync(ListConfigurationSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfigurationSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConfigurationSetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDedicatedIpPools

        internal virtual ListDedicatedIpPoolsResponse ListDedicatedIpPools(ListDedicatedIpPoolsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDedicatedIpPoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDedicatedIpPoolsResponseUnmarshaller.Instance;

            return Invoke<ListDedicatedIpPoolsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDedicatedIpPools operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDedicatedIpPools operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListDedicatedIpPoolsResponse> ListDedicatedIpPoolsAsync(ListDedicatedIpPoolsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDedicatedIpPoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDedicatedIpPoolsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDedicatedIpPoolsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDeliverabilityTestReports

        internal virtual ListDeliverabilityTestReportsResponse ListDeliverabilityTestReports(ListDeliverabilityTestReportsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDeliverabilityTestReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeliverabilityTestReportsResponseUnmarshaller.Instance;

            return Invoke<ListDeliverabilityTestReportsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDeliverabilityTestReports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeliverabilityTestReports operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListDeliverabilityTestReportsResponse> ListDeliverabilityTestReportsAsync(ListDeliverabilityTestReportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDeliverabilityTestReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeliverabilityTestReportsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeliverabilityTestReportsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEmailIdentities

        internal virtual ListEmailIdentitiesResponse ListEmailIdentities(ListEmailIdentitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEmailIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEmailIdentitiesResponseUnmarshaller.Instance;

            return Invoke<ListEmailIdentitiesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListEmailIdentities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEmailIdentities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListEmailIdentitiesResponse> ListEmailIdentitiesAsync(ListEmailIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEmailIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEmailIdentitiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListEmailIdentitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutAccountDedicatedIpWarmupAttributes

        internal virtual PutAccountDedicatedIpWarmupAttributesResponse PutAccountDedicatedIpWarmupAttributes(PutAccountDedicatedIpWarmupAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAccountDedicatedIpWarmupAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountDedicatedIpWarmupAttributesResponseUnmarshaller.Instance;

            return Invoke<PutAccountDedicatedIpWarmupAttributesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutAccountDedicatedIpWarmupAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAccountDedicatedIpWarmupAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutAccountDedicatedIpWarmupAttributesResponse> PutAccountDedicatedIpWarmupAttributesAsync(PutAccountDedicatedIpWarmupAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAccountDedicatedIpWarmupAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountDedicatedIpWarmupAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutAccountDedicatedIpWarmupAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutAccountSendingAttributes

        internal virtual PutAccountSendingAttributesResponse PutAccountSendingAttributes(PutAccountSendingAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAccountSendingAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountSendingAttributesResponseUnmarshaller.Instance;

            return Invoke<PutAccountSendingAttributesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutAccountSendingAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSendingAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutAccountSendingAttributesResponse> PutAccountSendingAttributesAsync(PutAccountSendingAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAccountSendingAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountSendingAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutAccountSendingAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutConfigurationSetDeliveryOptions

        internal virtual PutConfigurationSetDeliveryOptionsResponse PutConfigurationSetDeliveryOptions(PutConfigurationSetDeliveryOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetDeliveryOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetDeliveryOptionsResponseUnmarshaller.Instance;

            return Invoke<PutConfigurationSetDeliveryOptionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigurationSetDeliveryOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetDeliveryOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutConfigurationSetDeliveryOptionsResponse> PutConfigurationSetDeliveryOptionsAsync(PutConfigurationSetDeliveryOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetDeliveryOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetDeliveryOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<PutConfigurationSetDeliveryOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutConfigurationSetReputationOptions

        internal virtual PutConfigurationSetReputationOptionsResponse PutConfigurationSetReputationOptions(PutConfigurationSetReputationOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetReputationOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetReputationOptionsResponseUnmarshaller.Instance;

            return Invoke<PutConfigurationSetReputationOptionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigurationSetReputationOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetReputationOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutConfigurationSetReputationOptionsResponse> PutConfigurationSetReputationOptionsAsync(PutConfigurationSetReputationOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetReputationOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetReputationOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<PutConfigurationSetReputationOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutConfigurationSetSendingOptions

        internal virtual PutConfigurationSetSendingOptionsResponse PutConfigurationSetSendingOptions(PutConfigurationSetSendingOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetSendingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetSendingOptionsResponseUnmarshaller.Instance;

            return Invoke<PutConfigurationSetSendingOptionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigurationSetSendingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetSendingOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutConfigurationSetSendingOptionsResponse> PutConfigurationSetSendingOptionsAsync(PutConfigurationSetSendingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetSendingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetSendingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<PutConfigurationSetSendingOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutConfigurationSetTrackingOptions

        internal virtual PutConfigurationSetTrackingOptionsResponse PutConfigurationSetTrackingOptions(PutConfigurationSetTrackingOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;

            return Invoke<PutConfigurationSetTrackingOptionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigurationSetTrackingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetTrackingOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutConfigurationSetTrackingOptionsResponse> PutConfigurationSetTrackingOptionsAsync(PutConfigurationSetTrackingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<PutConfigurationSetTrackingOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutDedicatedIpInPool

        internal virtual PutDedicatedIpInPoolResponse PutDedicatedIpInPool(PutDedicatedIpInPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDedicatedIpInPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDedicatedIpInPoolResponseUnmarshaller.Instance;

            return Invoke<PutDedicatedIpInPoolResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutDedicatedIpInPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDedicatedIpInPool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutDedicatedIpInPoolResponse> PutDedicatedIpInPoolAsync(PutDedicatedIpInPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDedicatedIpInPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDedicatedIpInPoolResponseUnmarshaller.Instance;

            return InvokeAsync<PutDedicatedIpInPoolResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutDedicatedIpWarmupAttributes

        internal virtual PutDedicatedIpWarmupAttributesResponse PutDedicatedIpWarmupAttributes(PutDedicatedIpWarmupAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDedicatedIpWarmupAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDedicatedIpWarmupAttributesResponseUnmarshaller.Instance;

            return Invoke<PutDedicatedIpWarmupAttributesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutDedicatedIpWarmupAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDedicatedIpWarmupAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutDedicatedIpWarmupAttributesResponse> PutDedicatedIpWarmupAttributesAsync(PutDedicatedIpWarmupAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDedicatedIpWarmupAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDedicatedIpWarmupAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutDedicatedIpWarmupAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutDeliverabilityDashboardOption

        internal virtual PutDeliverabilityDashboardOptionResponse PutDeliverabilityDashboardOption(PutDeliverabilityDashboardOptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDeliverabilityDashboardOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDeliverabilityDashboardOptionResponseUnmarshaller.Instance;

            return Invoke<PutDeliverabilityDashboardOptionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutDeliverabilityDashboardOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDeliverabilityDashboardOption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutDeliverabilityDashboardOptionResponse> PutDeliverabilityDashboardOptionAsync(PutDeliverabilityDashboardOptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDeliverabilityDashboardOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDeliverabilityDashboardOptionResponseUnmarshaller.Instance;

            return InvokeAsync<PutDeliverabilityDashboardOptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutEmailIdentityDkimAttributes

        internal virtual PutEmailIdentityDkimAttributesResponse PutEmailIdentityDkimAttributes(PutEmailIdentityDkimAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEmailIdentityDkimAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEmailIdentityDkimAttributesResponseUnmarshaller.Instance;

            return Invoke<PutEmailIdentityDkimAttributesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutEmailIdentityDkimAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityDkimAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutEmailIdentityDkimAttributesResponse> PutEmailIdentityDkimAttributesAsync(PutEmailIdentityDkimAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEmailIdentityDkimAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEmailIdentityDkimAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutEmailIdentityDkimAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutEmailIdentityFeedbackAttributes

        internal virtual PutEmailIdentityFeedbackAttributesResponse PutEmailIdentityFeedbackAttributes(PutEmailIdentityFeedbackAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEmailIdentityFeedbackAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEmailIdentityFeedbackAttributesResponseUnmarshaller.Instance;

            return Invoke<PutEmailIdentityFeedbackAttributesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutEmailIdentityFeedbackAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityFeedbackAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutEmailIdentityFeedbackAttributesResponse> PutEmailIdentityFeedbackAttributesAsync(PutEmailIdentityFeedbackAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEmailIdentityFeedbackAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEmailIdentityFeedbackAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutEmailIdentityFeedbackAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutEmailIdentityMailFromAttributes

        internal virtual PutEmailIdentityMailFromAttributesResponse PutEmailIdentityMailFromAttributes(PutEmailIdentityMailFromAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEmailIdentityMailFromAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEmailIdentityMailFromAttributesResponseUnmarshaller.Instance;

            return Invoke<PutEmailIdentityMailFromAttributesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutEmailIdentityMailFromAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityMailFromAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutEmailIdentityMailFromAttributesResponse> PutEmailIdentityMailFromAttributesAsync(PutEmailIdentityMailFromAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEmailIdentityMailFromAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEmailIdentityMailFromAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutEmailIdentityMailFromAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendEmail

        internal virtual SendEmailResponse SendEmail(SendEmailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendEmailResponseUnmarshaller.Instance;

            return Invoke<SendEmailResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SendEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendEmail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<SendEmailResponse> SendEmailAsync(SendEmailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendEmailResponseUnmarshaller.Instance;

            return InvokeAsync<SendEmailResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConfigurationSetEventDestination

        internal virtual UpdateConfigurationSetEventDestinationResponse UpdateConfigurationSetEventDestination(UpdateConfigurationSetEventDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationSetEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationSetEventDestinationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetEventDestination operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateConfigurationSetEventDestinationResponse> UpdateConfigurationSetEventDestinationAsync(UpdateConfigurationSetEventDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationSetEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfigurationSetEventDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}