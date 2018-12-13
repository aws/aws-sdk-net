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
            var marshaller = CreateConfigurationSetRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationSetRequest,CreateConfigurationSetResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateConfigurationSetRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfigurationSetRequest,CreateConfigurationSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateConfigurationSetEventDestination

        internal virtual CreateConfigurationSetEventDestinationResponse CreateConfigurationSetEventDestination(CreateConfigurationSetEventDestinationRequest request)
        {
            var marshaller = CreateConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationSetEventDestinationRequest,CreateConfigurationSetEventDestinationResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfigurationSetEventDestinationRequest,CreateConfigurationSetEventDestinationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDedicatedIpPool

        internal virtual CreateDedicatedIpPoolResponse CreateDedicatedIpPool(CreateDedicatedIpPoolRequest request)
        {
            var marshaller = CreateDedicatedIpPoolRequestMarshaller.Instance;
            var unmarshaller = CreateDedicatedIpPoolResponseUnmarshaller.Instance;

            return Invoke<CreateDedicatedIpPoolRequest,CreateDedicatedIpPoolResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateDedicatedIpPoolRequestMarshaller.Instance;
            var unmarshaller = CreateDedicatedIpPoolResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDedicatedIpPoolRequest,CreateDedicatedIpPoolResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDeliverabilityTestReport

        internal virtual CreateDeliverabilityTestReportResponse CreateDeliverabilityTestReport(CreateDeliverabilityTestReportRequest request)
        {
            var marshaller = CreateDeliverabilityTestReportRequestMarshaller.Instance;
            var unmarshaller = CreateDeliverabilityTestReportResponseUnmarshaller.Instance;

            return Invoke<CreateDeliverabilityTestReportRequest,CreateDeliverabilityTestReportResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateDeliverabilityTestReportRequestMarshaller.Instance;
            var unmarshaller = CreateDeliverabilityTestReportResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeliverabilityTestReportRequest,CreateDeliverabilityTestReportResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateEmailIdentity

        internal virtual CreateEmailIdentityResponse CreateEmailIdentity(CreateEmailIdentityRequest request)
        {
            var marshaller = CreateEmailIdentityRequestMarshaller.Instance;
            var unmarshaller = CreateEmailIdentityResponseUnmarshaller.Instance;

            return Invoke<CreateEmailIdentityRequest,CreateEmailIdentityResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateEmailIdentityRequestMarshaller.Instance;
            var unmarshaller = CreateEmailIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEmailIdentityRequest,CreateEmailIdentityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteConfigurationSet

        internal virtual DeleteConfigurationSetResponse DeleteConfigurationSet(DeleteConfigurationSetRequest request)
        {
            var marshaller = DeleteConfigurationSetRequestMarshaller.Instance;
            var unmarshaller = DeleteConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationSetRequest,DeleteConfigurationSetResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteConfigurationSetRequestMarshaller.Instance;
            var unmarshaller = DeleteConfigurationSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfigurationSetRequest,DeleteConfigurationSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteConfigurationSetEventDestination

        internal virtual DeleteConfigurationSetEventDestinationResponse DeleteConfigurationSetEventDestination(DeleteConfigurationSetEventDestinationRequest request)
        {
            var marshaller = DeleteConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = DeleteConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationSetEventDestinationRequest,DeleteConfigurationSetEventDestinationResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = DeleteConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfigurationSetEventDestinationRequest,DeleteConfigurationSetEventDestinationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDedicatedIpPool

        internal virtual DeleteDedicatedIpPoolResponse DeleteDedicatedIpPool(DeleteDedicatedIpPoolRequest request)
        {
            var marshaller = DeleteDedicatedIpPoolRequestMarshaller.Instance;
            var unmarshaller = DeleteDedicatedIpPoolResponseUnmarshaller.Instance;

            return Invoke<DeleteDedicatedIpPoolRequest,DeleteDedicatedIpPoolResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteDedicatedIpPoolRequestMarshaller.Instance;
            var unmarshaller = DeleteDedicatedIpPoolResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDedicatedIpPoolRequest,DeleteDedicatedIpPoolResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteEmailIdentity

        internal virtual DeleteEmailIdentityResponse DeleteEmailIdentity(DeleteEmailIdentityRequest request)
        {
            var marshaller = DeleteEmailIdentityRequestMarshaller.Instance;
            var unmarshaller = DeleteEmailIdentityResponseUnmarshaller.Instance;

            return Invoke<DeleteEmailIdentityRequest,DeleteEmailIdentityResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteEmailIdentityRequestMarshaller.Instance;
            var unmarshaller = DeleteEmailIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEmailIdentityRequest,DeleteEmailIdentityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAccount

        internal virtual GetAccountResponse GetAccount(GetAccountRequest request)
        {
            var marshaller = GetAccountRequestMarshaller.Instance;
            var unmarshaller = GetAccountResponseUnmarshaller.Instance;

            return Invoke<GetAccountRequest,GetAccountResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetAccountRequestMarshaller.Instance;
            var unmarshaller = GetAccountResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountRequest,GetAccountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBlacklistReports

        internal virtual GetBlacklistReportsResponse GetBlacklistReports(GetBlacklistReportsRequest request)
        {
            var marshaller = GetBlacklistReportsRequestMarshaller.Instance;
            var unmarshaller = GetBlacklistReportsResponseUnmarshaller.Instance;

            return Invoke<GetBlacklistReportsRequest,GetBlacklistReportsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetBlacklistReportsRequestMarshaller.Instance;
            var unmarshaller = GetBlacklistReportsResponseUnmarshaller.Instance;

            return InvokeAsync<GetBlacklistReportsRequest,GetBlacklistReportsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetConfigurationSet

        internal virtual GetConfigurationSetResponse GetConfigurationSet(GetConfigurationSetRequest request)
        {
            var marshaller = GetConfigurationSetRequestMarshaller.Instance;
            var unmarshaller = GetConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<GetConfigurationSetRequest,GetConfigurationSetResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetConfigurationSetRequestMarshaller.Instance;
            var unmarshaller = GetConfigurationSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetConfigurationSetRequest,GetConfigurationSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetConfigurationSetEventDestinations

        internal virtual GetConfigurationSetEventDestinationsResponse GetConfigurationSetEventDestinations(GetConfigurationSetEventDestinationsRequest request)
        {
            var marshaller = GetConfigurationSetEventDestinationsRequestMarshaller.Instance;
            var unmarshaller = GetConfigurationSetEventDestinationsResponseUnmarshaller.Instance;

            return Invoke<GetConfigurationSetEventDestinationsRequest,GetConfigurationSetEventDestinationsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetConfigurationSetEventDestinationsRequestMarshaller.Instance;
            var unmarshaller = GetConfigurationSetEventDestinationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetConfigurationSetEventDestinationsRequest,GetConfigurationSetEventDestinationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDedicatedIp

        internal virtual GetDedicatedIpResponse GetDedicatedIp(GetDedicatedIpRequest request)
        {
            var marshaller = GetDedicatedIpRequestMarshaller.Instance;
            var unmarshaller = GetDedicatedIpResponseUnmarshaller.Instance;

            return Invoke<GetDedicatedIpRequest,GetDedicatedIpResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetDedicatedIpRequestMarshaller.Instance;
            var unmarshaller = GetDedicatedIpResponseUnmarshaller.Instance;

            return InvokeAsync<GetDedicatedIpRequest,GetDedicatedIpResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDedicatedIps

        internal virtual GetDedicatedIpsResponse GetDedicatedIps(GetDedicatedIpsRequest request)
        {
            var marshaller = GetDedicatedIpsRequestMarshaller.Instance;
            var unmarshaller = GetDedicatedIpsResponseUnmarshaller.Instance;

            return Invoke<GetDedicatedIpsRequest,GetDedicatedIpsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetDedicatedIpsRequestMarshaller.Instance;
            var unmarshaller = GetDedicatedIpsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDedicatedIpsRequest,GetDedicatedIpsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDeliverabilityDashboardOptions

        internal virtual GetDeliverabilityDashboardOptionsResponse GetDeliverabilityDashboardOptions(GetDeliverabilityDashboardOptionsRequest request)
        {
            var marshaller = GetDeliverabilityDashboardOptionsRequestMarshaller.Instance;
            var unmarshaller = GetDeliverabilityDashboardOptionsResponseUnmarshaller.Instance;

            return Invoke<GetDeliverabilityDashboardOptionsRequest,GetDeliverabilityDashboardOptionsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetDeliverabilityDashboardOptionsRequestMarshaller.Instance;
            var unmarshaller = GetDeliverabilityDashboardOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeliverabilityDashboardOptionsRequest,GetDeliverabilityDashboardOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDeliverabilityTestReport

        internal virtual GetDeliverabilityTestReportResponse GetDeliverabilityTestReport(GetDeliverabilityTestReportRequest request)
        {
            var marshaller = GetDeliverabilityTestReportRequestMarshaller.Instance;
            var unmarshaller = GetDeliverabilityTestReportResponseUnmarshaller.Instance;

            return Invoke<GetDeliverabilityTestReportRequest,GetDeliverabilityTestReportResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetDeliverabilityTestReportRequestMarshaller.Instance;
            var unmarshaller = GetDeliverabilityTestReportResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeliverabilityTestReportRequest,GetDeliverabilityTestReportResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDomainStatisticsReport

        internal virtual GetDomainStatisticsReportResponse GetDomainStatisticsReport(GetDomainStatisticsReportRequest request)
        {
            var marshaller = GetDomainStatisticsReportRequestMarshaller.Instance;
            var unmarshaller = GetDomainStatisticsReportResponseUnmarshaller.Instance;

            return Invoke<GetDomainStatisticsReportRequest,GetDomainStatisticsReportResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetDomainStatisticsReportRequestMarshaller.Instance;
            var unmarshaller = GetDomainStatisticsReportResponseUnmarshaller.Instance;

            return InvokeAsync<GetDomainStatisticsReportRequest,GetDomainStatisticsReportResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetEmailIdentity

        internal virtual GetEmailIdentityResponse GetEmailIdentity(GetEmailIdentityRequest request)
        {
            var marshaller = GetEmailIdentityRequestMarshaller.Instance;
            var unmarshaller = GetEmailIdentityResponseUnmarshaller.Instance;

            return Invoke<GetEmailIdentityRequest,GetEmailIdentityResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetEmailIdentityRequestMarshaller.Instance;
            var unmarshaller = GetEmailIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<GetEmailIdentityRequest,GetEmailIdentityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListConfigurationSets

        internal virtual ListConfigurationSetsResponse ListConfigurationSets(ListConfigurationSetsRequest request)
        {
            var marshaller = ListConfigurationSetsRequestMarshaller.Instance;
            var unmarshaller = ListConfigurationSetsResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationSetsRequest,ListConfigurationSetsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListConfigurationSetsRequestMarshaller.Instance;
            var unmarshaller = ListConfigurationSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConfigurationSetsRequest,ListConfigurationSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDedicatedIpPools

        internal virtual ListDedicatedIpPoolsResponse ListDedicatedIpPools(ListDedicatedIpPoolsRequest request)
        {
            var marshaller = ListDedicatedIpPoolsRequestMarshaller.Instance;
            var unmarshaller = ListDedicatedIpPoolsResponseUnmarshaller.Instance;

            return Invoke<ListDedicatedIpPoolsRequest,ListDedicatedIpPoolsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListDedicatedIpPoolsRequestMarshaller.Instance;
            var unmarshaller = ListDedicatedIpPoolsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDedicatedIpPoolsRequest,ListDedicatedIpPoolsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDeliverabilityTestReports

        internal virtual ListDeliverabilityTestReportsResponse ListDeliverabilityTestReports(ListDeliverabilityTestReportsRequest request)
        {
            var marshaller = ListDeliverabilityTestReportsRequestMarshaller.Instance;
            var unmarshaller = ListDeliverabilityTestReportsResponseUnmarshaller.Instance;

            return Invoke<ListDeliverabilityTestReportsRequest,ListDeliverabilityTestReportsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListDeliverabilityTestReportsRequestMarshaller.Instance;
            var unmarshaller = ListDeliverabilityTestReportsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeliverabilityTestReportsRequest,ListDeliverabilityTestReportsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListEmailIdentities

        internal virtual ListEmailIdentitiesResponse ListEmailIdentities(ListEmailIdentitiesRequest request)
        {
            var marshaller = ListEmailIdentitiesRequestMarshaller.Instance;
            var unmarshaller = ListEmailIdentitiesResponseUnmarshaller.Instance;

            return Invoke<ListEmailIdentitiesRequest,ListEmailIdentitiesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListEmailIdentitiesRequestMarshaller.Instance;
            var unmarshaller = ListEmailIdentitiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListEmailIdentitiesRequest,ListEmailIdentitiesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutAccountDedicatedIpWarmupAttributes

        internal virtual PutAccountDedicatedIpWarmupAttributesResponse PutAccountDedicatedIpWarmupAttributes(PutAccountDedicatedIpWarmupAttributesRequest request)
        {
            var marshaller = PutAccountDedicatedIpWarmupAttributesRequestMarshaller.Instance;
            var unmarshaller = PutAccountDedicatedIpWarmupAttributesResponseUnmarshaller.Instance;

            return Invoke<PutAccountDedicatedIpWarmupAttributesRequest,PutAccountDedicatedIpWarmupAttributesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = PutAccountDedicatedIpWarmupAttributesRequestMarshaller.Instance;
            var unmarshaller = PutAccountDedicatedIpWarmupAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutAccountDedicatedIpWarmupAttributesRequest,PutAccountDedicatedIpWarmupAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutAccountSendingAttributes

        internal virtual PutAccountSendingAttributesResponse PutAccountSendingAttributes(PutAccountSendingAttributesRequest request)
        {
            var marshaller = PutAccountSendingAttributesRequestMarshaller.Instance;
            var unmarshaller = PutAccountSendingAttributesResponseUnmarshaller.Instance;

            return Invoke<PutAccountSendingAttributesRequest,PutAccountSendingAttributesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = PutAccountSendingAttributesRequestMarshaller.Instance;
            var unmarshaller = PutAccountSendingAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutAccountSendingAttributesRequest,PutAccountSendingAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutConfigurationSetDeliveryOptions

        internal virtual PutConfigurationSetDeliveryOptionsResponse PutConfigurationSetDeliveryOptions(PutConfigurationSetDeliveryOptionsRequest request)
        {
            var marshaller = PutConfigurationSetDeliveryOptionsRequestMarshaller.Instance;
            var unmarshaller = PutConfigurationSetDeliveryOptionsResponseUnmarshaller.Instance;

            return Invoke<PutConfigurationSetDeliveryOptionsRequest,PutConfigurationSetDeliveryOptionsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = PutConfigurationSetDeliveryOptionsRequestMarshaller.Instance;
            var unmarshaller = PutConfigurationSetDeliveryOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<PutConfigurationSetDeliveryOptionsRequest,PutConfigurationSetDeliveryOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutConfigurationSetReputationOptions

        internal virtual PutConfigurationSetReputationOptionsResponse PutConfigurationSetReputationOptions(PutConfigurationSetReputationOptionsRequest request)
        {
            var marshaller = PutConfigurationSetReputationOptionsRequestMarshaller.Instance;
            var unmarshaller = PutConfigurationSetReputationOptionsResponseUnmarshaller.Instance;

            return Invoke<PutConfigurationSetReputationOptionsRequest,PutConfigurationSetReputationOptionsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = PutConfigurationSetReputationOptionsRequestMarshaller.Instance;
            var unmarshaller = PutConfigurationSetReputationOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<PutConfigurationSetReputationOptionsRequest,PutConfigurationSetReputationOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutConfigurationSetSendingOptions

        internal virtual PutConfigurationSetSendingOptionsResponse PutConfigurationSetSendingOptions(PutConfigurationSetSendingOptionsRequest request)
        {
            var marshaller = PutConfigurationSetSendingOptionsRequestMarshaller.Instance;
            var unmarshaller = PutConfigurationSetSendingOptionsResponseUnmarshaller.Instance;

            return Invoke<PutConfigurationSetSendingOptionsRequest,PutConfigurationSetSendingOptionsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = PutConfigurationSetSendingOptionsRequestMarshaller.Instance;
            var unmarshaller = PutConfigurationSetSendingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<PutConfigurationSetSendingOptionsRequest,PutConfigurationSetSendingOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutConfigurationSetTrackingOptions

        internal virtual PutConfigurationSetTrackingOptionsResponse PutConfigurationSetTrackingOptions(PutConfigurationSetTrackingOptionsRequest request)
        {
            var marshaller = PutConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            var unmarshaller = PutConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;

            return Invoke<PutConfigurationSetTrackingOptionsRequest,PutConfigurationSetTrackingOptionsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = PutConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            var unmarshaller = PutConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<PutConfigurationSetTrackingOptionsRequest,PutConfigurationSetTrackingOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutDedicatedIpInPool

        internal virtual PutDedicatedIpInPoolResponse PutDedicatedIpInPool(PutDedicatedIpInPoolRequest request)
        {
            var marshaller = PutDedicatedIpInPoolRequestMarshaller.Instance;
            var unmarshaller = PutDedicatedIpInPoolResponseUnmarshaller.Instance;

            return Invoke<PutDedicatedIpInPoolRequest,PutDedicatedIpInPoolResponse>(request, marshaller, unmarshaller);
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
            var marshaller = PutDedicatedIpInPoolRequestMarshaller.Instance;
            var unmarshaller = PutDedicatedIpInPoolResponseUnmarshaller.Instance;

            return InvokeAsync<PutDedicatedIpInPoolRequest,PutDedicatedIpInPoolResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutDedicatedIpWarmupAttributes

        internal virtual PutDedicatedIpWarmupAttributesResponse PutDedicatedIpWarmupAttributes(PutDedicatedIpWarmupAttributesRequest request)
        {
            var marshaller = PutDedicatedIpWarmupAttributesRequestMarshaller.Instance;
            var unmarshaller = PutDedicatedIpWarmupAttributesResponseUnmarshaller.Instance;

            return Invoke<PutDedicatedIpWarmupAttributesRequest,PutDedicatedIpWarmupAttributesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = PutDedicatedIpWarmupAttributesRequestMarshaller.Instance;
            var unmarshaller = PutDedicatedIpWarmupAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutDedicatedIpWarmupAttributesRequest,PutDedicatedIpWarmupAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutDeliverabilityDashboardOption

        internal virtual PutDeliverabilityDashboardOptionResponse PutDeliverabilityDashboardOption(PutDeliverabilityDashboardOptionRequest request)
        {
            var marshaller = PutDeliverabilityDashboardOptionRequestMarshaller.Instance;
            var unmarshaller = PutDeliverabilityDashboardOptionResponseUnmarshaller.Instance;

            return Invoke<PutDeliverabilityDashboardOptionRequest,PutDeliverabilityDashboardOptionResponse>(request, marshaller, unmarshaller);
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
            var marshaller = PutDeliverabilityDashboardOptionRequestMarshaller.Instance;
            var unmarshaller = PutDeliverabilityDashboardOptionResponseUnmarshaller.Instance;

            return InvokeAsync<PutDeliverabilityDashboardOptionRequest,PutDeliverabilityDashboardOptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutEmailIdentityDkimAttributes

        internal virtual PutEmailIdentityDkimAttributesResponse PutEmailIdentityDkimAttributes(PutEmailIdentityDkimAttributesRequest request)
        {
            var marshaller = PutEmailIdentityDkimAttributesRequestMarshaller.Instance;
            var unmarshaller = PutEmailIdentityDkimAttributesResponseUnmarshaller.Instance;

            return Invoke<PutEmailIdentityDkimAttributesRequest,PutEmailIdentityDkimAttributesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = PutEmailIdentityDkimAttributesRequestMarshaller.Instance;
            var unmarshaller = PutEmailIdentityDkimAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutEmailIdentityDkimAttributesRequest,PutEmailIdentityDkimAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutEmailIdentityFeedbackAttributes

        internal virtual PutEmailIdentityFeedbackAttributesResponse PutEmailIdentityFeedbackAttributes(PutEmailIdentityFeedbackAttributesRequest request)
        {
            var marshaller = PutEmailIdentityFeedbackAttributesRequestMarshaller.Instance;
            var unmarshaller = PutEmailIdentityFeedbackAttributesResponseUnmarshaller.Instance;

            return Invoke<PutEmailIdentityFeedbackAttributesRequest,PutEmailIdentityFeedbackAttributesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = PutEmailIdentityFeedbackAttributesRequestMarshaller.Instance;
            var unmarshaller = PutEmailIdentityFeedbackAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutEmailIdentityFeedbackAttributesRequest,PutEmailIdentityFeedbackAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutEmailIdentityMailFromAttributes

        internal virtual PutEmailIdentityMailFromAttributesResponse PutEmailIdentityMailFromAttributes(PutEmailIdentityMailFromAttributesRequest request)
        {
            var marshaller = PutEmailIdentityMailFromAttributesRequestMarshaller.Instance;
            var unmarshaller = PutEmailIdentityMailFromAttributesResponseUnmarshaller.Instance;

            return Invoke<PutEmailIdentityMailFromAttributesRequest,PutEmailIdentityMailFromAttributesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = PutEmailIdentityMailFromAttributesRequestMarshaller.Instance;
            var unmarshaller = PutEmailIdentityMailFromAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutEmailIdentityMailFromAttributesRequest,PutEmailIdentityMailFromAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SendEmail

        internal virtual SendEmailResponse SendEmail(SendEmailRequest request)
        {
            var marshaller = SendEmailRequestMarshaller.Instance;
            var unmarshaller = SendEmailResponseUnmarshaller.Instance;

            return Invoke<SendEmailRequest,SendEmailResponse>(request, marshaller, unmarshaller);
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
            var marshaller = SendEmailRequestMarshaller.Instance;
            var unmarshaller = SendEmailResponseUnmarshaller.Instance;

            return InvokeAsync<SendEmailRequest,SendEmailResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateConfigurationSetEventDestination

        internal virtual UpdateConfigurationSetEventDestinationResponse UpdateConfigurationSetEventDestination(UpdateConfigurationSetEventDestinationRequest request)
        {
            var marshaller = UpdateConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationSetEventDestinationRequest,UpdateConfigurationSetEventDestinationResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfigurationSetEventDestinationRequest,UpdateConfigurationSetEventDestinationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}