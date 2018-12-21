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


        /// <summary>
        /// Create a configuration set. <i>Configuration sets</i> are groups of rules that you
        /// can apply to the emails you send using Amazon Pinpoint. You apply a configuration
        /// set to an email by including a reference to the configuration set in the headers of
        /// the email. When you apply a configuration set to an email, all of the rules in that
        /// configuration set are applied to the email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSet service method.</param>
        /// 
        /// <returns>The response from the CreateConfigurationSet service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual CreateConfigurationSetResponse CreateConfigurationSet(CreateConfigurationSetRequest request)
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


        /// <summary>
        /// Create an event destination. In Amazon Pinpoint, <i>events</i> include message sends,
        /// deliveries, opens, clicks, bounces, and complaints. <i>Event destinations</i> are
        /// places that you can send information about these events to. For example, you can send
        /// event data to Amazon SNS to receive notifications when you receive bounces or complaints,
        /// or you can use Amazon Kinesis Data Firehose to stream data to Amazon S3 for long-term
        /// storage.
        /// 
        ///  
        /// <para>
        /// A single configuration set can include more than one event destination.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSetEventDestination service method.</param>
        /// 
        /// <returns>The response from the CreateConfigurationSetEventDestination service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual CreateConfigurationSetEventDestinationResponse CreateConfigurationSetEventDestination(CreateConfigurationSetEventDestinationRequest request)
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


        /// <summary>
        /// Create a new pool of dedicated IP addresses. A pool can include one or more dedicated
        /// IP addresses that are associated with your Amazon Pinpoint account. You can associate
        /// a pool with a configuration set. When you send an email that uses that configuration
        /// set, Amazon Pinpoint sends it using only the IP addresses in the associated pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDedicatedIpPool service method.</param>
        /// 
        /// <returns>The response from the CreateDedicatedIpPool service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual CreateDedicatedIpPoolResponse CreateDedicatedIpPool(CreateDedicatedIpPoolRequest request)
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


        /// <summary>
        /// Create a new predictive inbox placement test. Predictive inbox placement tests can
        /// help you predict how your messages will be handled by various email providers around
        /// the world. When you perform a predictive inbox placement test, you provide a sample
        /// message that contains the content that you plan to send to your customers. Amazon
        /// Pinpoint then sends that message to special email addresses spread across several
        /// major email providers. After about 24 hours, the test is complete, and you can use
        /// the <code>GetDeliverabilityTestReport</code> operation to view the results of the
        /// test.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeliverabilityTestReport service method.</param>
        /// 
        /// <returns>The response from the CreateDeliverabilityTestReport service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.AccountSuspendedException">
        /// The message can't be sent because the account's ability to send email has been permanently
        /// restricted.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.MailFromDomainNotVerifiedException">
        /// The message can't be sent because the sending domain isn't verified.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.MessageRejectedException">
        /// The message can't be sent because it contains invalid content.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.SendingPausedException">
        /// The message can't be sent because the account's ability to send email is currently
        /// paused.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual CreateDeliverabilityTestReportResponse CreateDeliverabilityTestReport(CreateDeliverabilityTestReportRequest request)
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


        /// <summary>
        /// Verifies an email identity for use with Amazon Pinpoint. In Amazon Pinpoint, an identity
        /// is an email address or domain that you use when you send email. Before you can use
        /// an identity to send email with Amazon Pinpoint, you first have to verify it. By verifying
        /// an address, you demonstrate that you're the owner of the address, and that you've
        /// given Amazon Pinpoint permission to send email from the address.
        /// 
        ///  
        /// <para>
        /// When you verify an email address, Amazon Pinpoint sends an email to the address. Your
        /// email address is verified as soon as you follow the link in the verification email.
        /// 
        /// </para>
        ///  
        /// <para>
        /// When you verify a domain, this operation provides a set of DKIM tokens, which you
        /// can convert into CNAME tokens. You add these CNAME tokens to the DNS configuration
        /// for your domain. Your domain is verified when Amazon Pinpoint detects these records
        /// in the DNS configuration for your domain. It usually takes around 72 hours to complete
        /// the domain verification process.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEmailIdentity service method.</param>
        /// 
        /// <returns>The response from the CreateEmailIdentity service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual CreateEmailIdentityResponse CreateEmailIdentity(CreateEmailIdentityRequest request)
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


        /// <summary>
        /// Delete an existing configuration set.
        /// 
        ///  
        /// <para>
        /// In Amazon Pinpoint, <i>configuration sets</i> are groups of rules that you can apply
        /// to the emails you send. You apply a configuration set to an email by including a reference
        /// to the configuration set in the headers of the email. When you apply a configuration
        /// set to an email, all of the rules in that configuration set are applied to the email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSet service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationSet service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual DeleteConfigurationSetResponse DeleteConfigurationSet(DeleteConfigurationSetRequest request)
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


        /// <summary>
        /// Delete an event destination.
        /// 
        ///  
        /// <para>
        /// In Amazon Pinpoint, <i>events</i> include message sends, deliveries, opens, clicks,
        /// bounces, and complaints. <i>Event destinations</i> are places that you can send information
        /// about these events to. For example, you can send event data to Amazon SNS to receive
        /// notifications when you receive bounces or complaints, or you can use Amazon Kinesis
        /// Data Firehose to stream data to Amazon S3 for long-term storage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSetEventDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationSetEventDestination service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual DeleteConfigurationSetEventDestinationResponse DeleteConfigurationSetEventDestination(DeleteConfigurationSetEventDestinationRequest request)
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


        /// <summary>
        /// Delete a dedicated IP pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDedicatedIpPool service method.</param>
        /// 
        /// <returns>The response from the DeleteDedicatedIpPool service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual DeleteDedicatedIpPoolResponse DeleteDedicatedIpPool(DeleteDedicatedIpPoolRequest request)
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


        /// <summary>
        /// Deletes an email identity that you previously verified for use with Amazon Pinpoint.
        /// An identity can be either an email address or a domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailIdentity service method.</param>
        /// 
        /// <returns>The response from the DeleteEmailIdentity service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual DeleteEmailIdentityResponse DeleteEmailIdentity(DeleteEmailIdentityRequest request)
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


        /// <summary>
        /// Obtain information about the email-sending status and capabilities of your Amazon
        /// Pinpoint account in the current AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccount service method.</param>
        /// 
        /// <returns>The response from the GetAccount service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual GetAccountResponse GetAccount(GetAccountRequest request)
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


        /// <summary>
        /// Retrieve a list of the blacklists that your dedicated IP addresses appear on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlacklistReports service method.</param>
        /// 
        /// <returns>The response from the GetBlacklistReports service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual GetBlacklistReportsResponse GetBlacklistReports(GetBlacklistReportsRequest request)
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


        /// <summary>
        /// Get information about an existing configuration set, including the dedicated IP pool
        /// that it's associated with, whether or not it's enabled for sending email, and more.
        /// 
        ///  
        /// <para>
        /// In Amazon Pinpoint, <i>configuration sets</i> are groups of rules that you can apply
        /// to the emails you send. You apply a configuration set to an email by including a reference
        /// to the configuration set in the headers of the email. When you apply a configuration
        /// set to an email, all of the rules in that configuration set are applied to the email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationSet service method.</param>
        /// 
        /// <returns>The response from the GetConfigurationSet service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual GetConfigurationSetResponse GetConfigurationSet(GetConfigurationSetRequest request)
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


        /// <summary>
        /// Retrieve a list of event destinations that are associated with a configuration set.
        /// 
        ///  
        /// <para>
        /// In Amazon Pinpoint, <i>events</i> include message sends, deliveries, opens, clicks,
        /// bounces, and complaints. <i>Event destinations</i> are places that you can send information
        /// about these events to. For example, you can send event data to Amazon SNS to receive
        /// notifications when you receive bounces or complaints, or you can use Amazon Kinesis
        /// Data Firehose to stream data to Amazon S3 for long-term storage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationSetEventDestinations service method.</param>
        /// 
        /// <returns>The response from the GetConfigurationSetEventDestinations service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual GetConfigurationSetEventDestinationsResponse GetConfigurationSetEventDestinations(GetConfigurationSetEventDestinationsRequest request)
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


        /// <summary>
        /// Get information about a dedicated IP address, including the name of the dedicated
        /// IP pool that it's associated with, as well information about the automatic warm-up
        /// process for the address.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDedicatedIp service method.</param>
        /// 
        /// <returns>The response from the GetDedicatedIp service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual GetDedicatedIpResponse GetDedicatedIp(GetDedicatedIpRequest request)
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


        /// <summary>
        /// List the dedicated IP addresses that are associated with your Amazon Pinpoint account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDedicatedIps service method.</param>
        /// 
        /// <returns>The response from the GetDedicatedIps service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual GetDedicatedIpsResponse GetDedicatedIps(GetDedicatedIpsRequest request)
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


        /// <summary>
        /// Show the status of the Deliverability dashboard. When the Deliverability dashboard
        /// is enabled, you gain access to reputation metrics for the domains that you use to
        /// send email using Amazon Pinpoint. You also gain the ability to perform predictive
        /// inbox placement tests.
        /// 
        ///  
        /// <para>
        /// When you use the Deliverability dashboard, you pay a monthly charge of USD$1,250.00,
        /// in addition to any other fees that you accrue by using Amazon Pinpoint. If you enable
        /// the Deliverability dashboard after the first day of a calendar month, AWS prorates
        /// the monthly charge based on how many days have elapsed in the current calendar month.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeliverabilityDashboardOptions service method.</param>
        /// 
        /// <returns>The response from the GetDeliverabilityDashboardOptions service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual GetDeliverabilityDashboardOptionsResponse GetDeliverabilityDashboardOptions(GetDeliverabilityDashboardOptionsRequest request)
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


        /// <summary>
        /// Retrieve the results of a predictive inbox placement test.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeliverabilityTestReport service method.</param>
        /// 
        /// <returns>The response from the GetDeliverabilityTestReport service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual GetDeliverabilityTestReportResponse GetDeliverabilityTestReport(GetDeliverabilityTestReportRequest request)
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


        /// <summary>
        /// Retrieve inbox placement and engagement rates for the domains that you use to send
        /// email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainStatisticsReport service method.</param>
        /// 
        /// <returns>The response from the GetDomainStatisticsReport service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual GetDomainStatisticsReportResponse GetDomainStatisticsReport(GetDomainStatisticsReportRequest request)
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


        /// <summary>
        /// Provides information about a specific identity associated with your Amazon Pinpoint
        /// account, including the identity's verification status, its DKIM authentication status,
        /// and its custom Mail-From settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEmailIdentity service method.</param>
        /// 
        /// <returns>The response from the GetEmailIdentity service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual GetEmailIdentityResponse GetEmailIdentity(GetEmailIdentityRequest request)
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


        /// <summary>
        /// List all of the configuration sets associated with your Amazon Pinpoint account in
        /// the current region.
        /// 
        ///  
        /// <para>
        /// In Amazon Pinpoint, <i>configuration sets</i> are groups of rules that you can apply
        /// to the emails you send. You apply a configuration set to an email by including a reference
        /// to the configuration set in the headers of the email. When you apply a configuration
        /// set to an email, all of the rules in that configuration set are applied to the email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationSets service method.</param>
        /// 
        /// <returns>The response from the ListConfigurationSets service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual ListConfigurationSetsResponse ListConfigurationSets(ListConfigurationSetsRequest request)
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


        /// <summary>
        /// List all of the dedicated IP pools that exist in your Amazon Pinpoint account in the
        /// current AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDedicatedIpPools service method.</param>
        /// 
        /// <returns>The response from the ListDedicatedIpPools service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual ListDedicatedIpPoolsResponse ListDedicatedIpPools(ListDedicatedIpPoolsRequest request)
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


        /// <summary>
        /// Show a list of the predictive inbox placement tests that you've performed, regardless
        /// of their statuses. For predictive inbox placement tests that are complete, you can
        /// use the <code>GetDeliverabilityTestReport</code> operation to view the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeliverabilityTestReports service method.</param>
        /// 
        /// <returns>The response from the ListDeliverabilityTestReports service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual ListDeliverabilityTestReportsResponse ListDeliverabilityTestReports(ListDeliverabilityTestReportsRequest request)
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


        /// <summary>
        /// Returns a list of all of the email identities that are associated with your Amazon
        /// Pinpoint account. An identity can be either an email address or a domain. This operation
        /// returns identities that are verified as well as those that aren't.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEmailIdentities service method.</param>
        /// 
        /// <returns>The response from the ListEmailIdentities service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual ListEmailIdentitiesResponse ListEmailIdentities(ListEmailIdentitiesRequest request)
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


        /// <summary>
        /// Enable or disable the automatic warm-up feature for dedicated IP addresses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountDedicatedIpWarmupAttributes service method.</param>
        /// 
        /// <returns>The response from the PutAccountDedicatedIpWarmupAttributes service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual PutAccountDedicatedIpWarmupAttributesResponse PutAccountDedicatedIpWarmupAttributes(PutAccountDedicatedIpWarmupAttributesRequest request)
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


        /// <summary>
        /// Enable or disable the ability of your account to send email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSendingAttributes service method.</param>
        /// 
        /// <returns>The response from the PutAccountSendingAttributes service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual PutAccountSendingAttributesResponse PutAccountSendingAttributes(PutAccountSendingAttributesRequest request)
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


        /// <summary>
        /// Associate a configuration set with a dedicated IP pool. You can use dedicated IP pools
        /// to create groups of dedicated IP addresses for sending specific types of email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetDeliveryOptions service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationSetDeliveryOptions service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual PutConfigurationSetDeliveryOptionsResponse PutConfigurationSetDeliveryOptions(PutConfigurationSetDeliveryOptionsRequest request)
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


        /// <summary>
        /// Enable or disable collection of reputation metrics for emails that you send using
        /// a particular configuration set in a specific AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetReputationOptions service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationSetReputationOptions service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual PutConfigurationSetReputationOptionsResponse PutConfigurationSetReputationOptions(PutConfigurationSetReputationOptionsRequest request)
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


        /// <summary>
        /// Enable or disable email sending for messages that use a particular configuration set
        /// in a specific AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetSendingOptions service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationSetSendingOptions service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual PutConfigurationSetSendingOptionsResponse PutConfigurationSetSendingOptions(PutConfigurationSetSendingOptionsRequest request)
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


        /// <summary>
        /// Specify a custom domain to use for open and click tracking elements in email that
        /// you send using Amazon Pinpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetTrackingOptions service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationSetTrackingOptions service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual PutConfigurationSetTrackingOptionsResponse PutConfigurationSetTrackingOptions(PutConfigurationSetTrackingOptionsRequest request)
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


        /// <summary>
        /// Move a dedicated IP address to an existing dedicated IP pool.
        /// 
        ///  <note> 
        /// <para>
        /// The dedicated IP address that you specify must already exist, and must be associated
        /// with your Amazon Pinpoint account. 
        /// </para>
        ///  
        /// <para>
        /// The dedicated IP pool you specify must already exist. You can create a new pool by
        /// using the <code>CreateDedicatedIpPool</code> operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDedicatedIpInPool service method.</param>
        /// 
        /// <returns>The response from the PutDedicatedIpInPool service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual PutDedicatedIpInPoolResponse PutDedicatedIpInPool(PutDedicatedIpInPoolRequest request)
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


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDedicatedIpWarmupAttributes service method.</param>
        /// 
        /// <returns>The response from the PutDedicatedIpWarmupAttributes service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual PutDedicatedIpWarmupAttributesResponse PutDedicatedIpWarmupAttributes(PutDedicatedIpWarmupAttributesRequest request)
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


        /// <summary>
        /// Enable or disable the Deliverability dashboard. When you enable the Deliverability
        /// dashboard, you gain access to reputation metrics for the domains that you use to send
        /// email using Amazon Pinpoint. You also gain the ability to perform predictive inbox
        /// placement tests.
        /// 
        ///  
        /// <para>
        /// When you use the Deliverability dashboard, you pay a monthly charge of USD$1,250.00,
        /// in addition to any other fees that you accrue by using Amazon Pinpoint. If you enable
        /// the Deliverability dashboard after the first day of a calendar month, we prorate the
        /// monthly charge based on how many days have elapsed in the current calendar month.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDeliverabilityDashboardOption service method.</param>
        /// 
        /// <returns>The response from the PutDeliverabilityDashboardOption service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual PutDeliverabilityDashboardOptionResponse PutDeliverabilityDashboardOption(PutDeliverabilityDashboardOptionRequest request)
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


        /// <summary>
        /// Used to enable or disable DKIM authentication for an email identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityDkimAttributes service method.</param>
        /// 
        /// <returns>The response from the PutEmailIdentityDkimAttributes service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual PutEmailIdentityDkimAttributesResponse PutEmailIdentityDkimAttributes(PutEmailIdentityDkimAttributesRequest request)
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


        /// <summary>
        /// Used to enable or disable feedback forwarding for an identity. This setting determines
        /// what happens when an identity is used to send an email that results in a bounce or
        /// complaint event.
        /// 
        ///  
        /// <para>
        /// When you enable feedback forwarding, Amazon Pinpoint sends you email notifications
        /// when bounce or complaint events occur. Amazon Pinpoint sends this notification to
        /// the address that you specified in the Return-Path header of the original email.
        /// </para>
        ///  
        /// <para>
        /// When you disable feedback forwarding, Amazon Pinpoint sends notifications through
        /// other mechanisms, such as by notifying an Amazon SNS topic. You're required to have
        /// a method of tracking bounces and complaints. If you haven't set up another mechanism
        /// for receiving bounce or complaint notifications, Amazon Pinpoint sends an email notification
        /// when these events occur (even if this setting is disabled).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityFeedbackAttributes service method.</param>
        /// 
        /// <returns>The response from the PutEmailIdentityFeedbackAttributes service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual PutEmailIdentityFeedbackAttributesResponse PutEmailIdentityFeedbackAttributes(PutEmailIdentityFeedbackAttributesRequest request)
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


        /// <summary>
        /// Used to enable or disable the custom Mail-From domain configuration for an email identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityMailFromAttributes service method.</param>
        /// 
        /// <returns>The response from the PutEmailIdentityMailFromAttributes service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual PutEmailIdentityMailFromAttributesResponse PutEmailIdentityMailFromAttributes(PutEmailIdentityMailFromAttributesRequest request)
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


        /// <summary>
        /// Sends an email message. You can use the Amazon Pinpoint Email API to send two types
        /// of messages:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>Simple</b> – A standard email message. When you create this type of message, you
        /// specify the sender, the recipient, and the message body, and Amazon Pinpoint assembles
        /// the message for you.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Raw</b> – A raw, MIME-formatted email message. When you send this type of email,
        /// you have to specify all of the message headers, as well as the message body. You can
        /// use this message type to send messages that contain attachments. The message that
        /// you specify has to be a valid MIME message.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendEmail service method.</param>
        /// 
        /// <returns>The response from the SendEmail service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.AccountSuspendedException">
        /// The message can't be sent because the account's ability to send email has been permanently
        /// restricted.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.MailFromDomainNotVerifiedException">
        /// The message can't be sent because the sending domain isn't verified.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.MessageRejectedException">
        /// The message can't be sent because it contains invalid content.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.SendingPausedException">
        /// The message can't be sent because the account's ability to send email is currently
        /// paused.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual SendEmailResponse SendEmail(SendEmailRequest request)
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


        /// <summary>
        /// Update the configuration of an event destination for a configuration set.
        /// 
        ///  
        /// <para>
        /// In Amazon Pinpoint, <i>events</i> include message sends, deliveries, opens, clicks,
        /// bounces, and complaints. <i>Event destinations</i> are places that you can send information
        /// about these events to. For example, you can send event data to Amazon SNS to receive
        /// notifications when you receive bounces or complaints, or you can use Amazon Kinesis
        /// Data Firehose to stream data to Amazon S3 for long-term storage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetEventDestination service method.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationSetEventDestination service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        public virtual UpdateConfigurationSetEventDestinationResponse UpdateConfigurationSetEventDestination(UpdateConfigurationSetEventDestinationRequest request)
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