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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.IoT.Model;
using Amazon.IoT.Model.Internal.MarshallTransformations;
using Amazon.IoT.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IoT
{
    /// <summary>
    /// Implementation for accessing IoT
    ///
    /// AWS IoT 
    /// <para>
    /// AWS IoT provides secure, bi-directional communication between Internet-connected devices
    /// (such as sensors, actuators, embedded devices, or smart appliances) and the AWS cloud.
    /// You can discover your custom IoT-Data endpoint to communicate with, configure rules
    /// for data processing and integration with other services, organize resources associated
    /// with each device (Registry), configure logging, and create and manage policies and
    /// credentials to authenticate devices.
    /// </para>
    ///  
    /// <para>
    /// For more information about how AWS IoT works, see the <a href="http://docs.aws.amazon.com/iot/latest/developerguide/aws-iot-how-it-works.html">Developer
    /// Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// For information about how to use the credentials provider for AWS IoT, see <a href="http://docs.aws.amazon.com/iot/latest/developerguide/authorizing-direct-aws.html">Authorizing
    /// Direct Calls to AWS Services</a>.
    /// </para>
    /// </summary>
    public partial class AmazonIoTClient : AmazonServiceClient, IAmazonIoT
    {
        private static IServiceMetadata serviceMetadata = new AmazonIoTMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonIoTClient with the credentials loaded from the application's
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
        public AmazonIoTClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTConfig()) { }

        /// <summary>
        /// Constructs AmazonIoTClient with the credentials loaded from the application's
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
        public AmazonIoTClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIoTClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIoTClient Configuration Object</param>
        public AmazonIoTClient(AmazonIoTConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonIoTClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIoTClient(AWSCredentials credentials)
            : this(credentials, new AmazonIoTConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIoTConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTClient with AWS Credentials and an
        /// AmazonIoTClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIoTClient Configuration Object</param>
        public AmazonIoTClient(AWSCredentials credentials, AmazonIoTConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIoTClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIoTClient Configuration Object</param>
        public AmazonIoTClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIoTConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIoTClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIoTClient Configuration Object</param>
        public AmazonIoTClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIoTConfig clientConfig)
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


        #region  AcceptCertificateTransfer


        /// <summary>
        /// Accepts a pending certificate transfer. The default state of the certificate is INACTIVE.
        /// 
        ///  
        /// <para>
        /// To check for pending certificate transfers, call <a>ListCertificates</a> to enumerate
        /// your certificates.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptCertificateTransfer service method.</param>
        /// 
        /// <returns>The response from the AcceptCertificateTransfer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.TransferAlreadyCompletedException">
        /// You can't revert the certificate transfer because the transfer is already complete.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AcceptCertificateTransfer">REST API Reference for AcceptCertificateTransfer Operation</seealso>
        public virtual AcceptCertificateTransferResponse AcceptCertificateTransfer(AcceptCertificateTransferRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptCertificateTransferRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptCertificateTransferResponseUnmarshaller.Instance;

            return Invoke<AcceptCertificateTransferResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptCertificateTransfer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptCertificateTransfer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AcceptCertificateTransfer">REST API Reference for AcceptCertificateTransfer Operation</seealso>
        public virtual Task<AcceptCertificateTransferResponse> AcceptCertificateTransferAsync(AcceptCertificateTransferRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptCertificateTransferRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptCertificateTransferResponseUnmarshaller.Instance;
            
            return InvokeAsync<AcceptCertificateTransferResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddThingToBillingGroup


        /// <summary>
        /// Adds a thing to a billing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddThingToBillingGroup service method.</param>
        /// 
        /// <returns>The response from the AddThingToBillingGroup service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AddThingToBillingGroup">REST API Reference for AddThingToBillingGroup Operation</seealso>
        public virtual AddThingToBillingGroupResponse AddThingToBillingGroup(AddThingToBillingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddThingToBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddThingToBillingGroupResponseUnmarshaller.Instance;

            return Invoke<AddThingToBillingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddThingToBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddThingToBillingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AddThingToBillingGroup">REST API Reference for AddThingToBillingGroup Operation</seealso>
        public virtual Task<AddThingToBillingGroupResponse> AddThingToBillingGroupAsync(AddThingToBillingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddThingToBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddThingToBillingGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<AddThingToBillingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddThingToThingGroup


        /// <summary>
        /// Adds a thing to a thing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddThingToThingGroup service method.</param>
        /// 
        /// <returns>The response from the AddThingToThingGroup service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AddThingToThingGroup">REST API Reference for AddThingToThingGroup Operation</seealso>
        public virtual AddThingToThingGroupResponse AddThingToThingGroup(AddThingToThingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddThingToThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddThingToThingGroupResponseUnmarshaller.Instance;

            return Invoke<AddThingToThingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddThingToThingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddThingToThingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AddThingToThingGroup">REST API Reference for AddThingToThingGroup Operation</seealso>
        public virtual Task<AddThingToThingGroupResponse> AddThingToThingGroupAsync(AddThingToThingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddThingToThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddThingToThingGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<AddThingToThingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateTargetsWithJob


        /// <summary>
        /// Associates a group with a continuous job. The following criteria must be met: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The job must have been created with the <code>targetSelection</code> field set to
        /// "CONTINUOUS".
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The job status must currently be "IN_PROGRESS".
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total number of targets associated with a job must not exceed 100.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTargetsWithJob service method.</param>
        /// 
        /// <returns>The response from the AssociateTargetsWithJob service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AssociateTargetsWithJob">REST API Reference for AssociateTargetsWithJob Operation</seealso>
        public virtual AssociateTargetsWithJobResponse AssociateTargetsWithJob(AssociateTargetsWithJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTargetsWithJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTargetsWithJobResponseUnmarshaller.Instance;

            return Invoke<AssociateTargetsWithJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateTargetsWithJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateTargetsWithJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AssociateTargetsWithJob">REST API Reference for AssociateTargetsWithJob Operation</seealso>
        public virtual Task<AssociateTargetsWithJobResponse> AssociateTargetsWithJobAsync(AssociateTargetsWithJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTargetsWithJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTargetsWithJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateTargetsWithJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachPolicy


        /// <summary>
        /// Attaches a policy to the specified target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachPolicy service method.</param>
        /// 
        /// <returns>The response from the AttachPolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachPolicy">REST API Reference for AttachPolicy Operation</seealso>
        public virtual AttachPolicyResponse AttachPolicy(AttachPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachPolicyResponseUnmarshaller.Instance;

            return Invoke<AttachPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachPolicy">REST API Reference for AttachPolicy Operation</seealso>
        public virtual Task<AttachPolicyResponse> AttachPolicyAsync(AttachPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<AttachPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachPrincipalPolicy


        /// <summary>
        /// Attaches the specified policy to the specified principal (certificate or other credential).
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This API is deprecated. Please use <a>AttachPolicy</a> instead.
        /// </para>
        /// </summary>
        /// <param name="policyName">The policy name.</param>
        /// <param name="principal">The principal, which can be a certificate ARN (as returned from the CreateCertificate operation) or an Amazon Cognito ID.</param>
        /// 
        /// <returns>The response from the AttachPrincipalPolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachPrincipalPolicy">REST API Reference for AttachPrincipalPolicy Operation</seealso>
        [Obsolete("Deprecated in favor of AttachPolicy.")]
        public virtual AttachPrincipalPolicyResponse AttachPrincipalPolicy(string policyName, string principal)
        {
            var request = new AttachPrincipalPolicyRequest();
            request.PolicyName = policyName;
            request.Principal = principal;
            return AttachPrincipalPolicy(request);
        }


        /// <summary>
        /// Attaches the specified policy to the specified principal (certificate or other credential).
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This API is deprecated. Please use <a>AttachPolicy</a> instead.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachPrincipalPolicy service method.</param>
        /// 
        /// <returns>The response from the AttachPrincipalPolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachPrincipalPolicy">REST API Reference for AttachPrincipalPolicy Operation</seealso>
        [Obsolete("Deprecated in favor of AttachPolicy.")]
        public virtual AttachPrincipalPolicyResponse AttachPrincipalPolicy(AttachPrincipalPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachPrincipalPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachPrincipalPolicyResponseUnmarshaller.Instance;

            return Invoke<AttachPrincipalPolicyResponse>(request, options);
        }


        /// <summary>
        /// Attaches the specified policy to the specified principal (certificate or other credential).
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This API is deprecated. Please use <a>AttachPolicy</a> instead.
        /// </para>
        /// </summary>
        /// <param name="policyName">The policy name.</param>
        /// <param name="principal">The principal, which can be a certificate ARN (as returned from the CreateCertificate operation) or an Amazon Cognito ID.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachPrincipalPolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachPrincipalPolicy">REST API Reference for AttachPrincipalPolicy Operation</seealso>
        [Obsolete("Deprecated in favor of AttachPolicy.")]
        public virtual Task<AttachPrincipalPolicyResponse> AttachPrincipalPolicyAsync(string policyName, string principal, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new AttachPrincipalPolicyRequest();
            request.PolicyName = policyName;
            request.Principal = principal;
            return AttachPrincipalPolicyAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachPrincipalPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachPrincipalPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachPrincipalPolicy">REST API Reference for AttachPrincipalPolicy Operation</seealso>
        [Obsolete("Deprecated in favor of AttachPolicy.")]
        public virtual Task<AttachPrincipalPolicyResponse> AttachPrincipalPolicyAsync(AttachPrincipalPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachPrincipalPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachPrincipalPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<AttachPrincipalPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachSecurityProfile


        /// <summary>
        /// Associates a Device Defender security profile with a thing group or with this account.
        /// Each thing group or account can have up to five security profiles associated with
        /// it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachSecurityProfile service method.</param>
        /// 
        /// <returns>The response from the AttachSecurityProfile service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachSecurityProfile">REST API Reference for AttachSecurityProfile Operation</seealso>
        public virtual AttachSecurityProfileResponse AttachSecurityProfile(AttachSecurityProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachSecurityProfileResponseUnmarshaller.Instance;

            return Invoke<AttachSecurityProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachSecurityProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachSecurityProfile">REST API Reference for AttachSecurityProfile Operation</seealso>
        public virtual Task<AttachSecurityProfileResponse> AttachSecurityProfileAsync(AttachSecurityProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachSecurityProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<AttachSecurityProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachThingPrincipal


        /// <summary>
        /// Attaches the specified principal to the specified thing.
        /// </summary>
        /// <param name="thingName">The name of the thing.</param>
        /// <param name="principal">The principal, such as a certificate or other credential.</param>
        /// 
        /// <returns>The response from the AttachThingPrincipal service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachThingPrincipal">REST API Reference for AttachThingPrincipal Operation</seealso>
        public virtual AttachThingPrincipalResponse AttachThingPrincipal(string thingName, string principal)
        {
            var request = new AttachThingPrincipalRequest();
            request.ThingName = thingName;
            request.Principal = principal;
            return AttachThingPrincipal(request);
        }


        /// <summary>
        /// Attaches the specified principal to the specified thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachThingPrincipal service method.</param>
        /// 
        /// <returns>The response from the AttachThingPrincipal service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachThingPrincipal">REST API Reference for AttachThingPrincipal Operation</seealso>
        public virtual AttachThingPrincipalResponse AttachThingPrincipal(AttachThingPrincipalRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachThingPrincipalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachThingPrincipalResponseUnmarshaller.Instance;

            return Invoke<AttachThingPrincipalResponse>(request, options);
        }


        /// <summary>
        /// Attaches the specified principal to the specified thing.
        /// </summary>
        /// <param name="thingName">The name of the thing.</param>
        /// <param name="principal">The principal, such as a certificate or other credential.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachThingPrincipal service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachThingPrincipal">REST API Reference for AttachThingPrincipal Operation</seealso>
        public virtual Task<AttachThingPrincipalResponse> AttachThingPrincipalAsync(string thingName, string principal, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new AttachThingPrincipalRequest();
            request.ThingName = thingName;
            request.Principal = principal;
            return AttachThingPrincipalAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachThingPrincipal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachThingPrincipal operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachThingPrincipal">REST API Reference for AttachThingPrincipal Operation</seealso>
        public virtual Task<AttachThingPrincipalResponse> AttachThingPrincipalAsync(AttachThingPrincipalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachThingPrincipalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachThingPrincipalResponseUnmarshaller.Instance;
            
            return InvokeAsync<AttachThingPrincipalResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelAuditTask


        /// <summary>
        /// Cancels an audit that is in progress. The audit can be either scheduled or on-demand.
        /// If the audit is not in progress, an "InvalidRequestException" occurs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelAuditTask service method.</param>
        /// 
        /// <returns>The response from the CancelAuditTask service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelAuditTask">REST API Reference for CancelAuditTask Operation</seealso>
        public virtual CancelAuditTaskResponse CancelAuditTask(CancelAuditTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelAuditTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelAuditTaskResponseUnmarshaller.Instance;

            return Invoke<CancelAuditTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelAuditTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelAuditTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelAuditTask">REST API Reference for CancelAuditTask Operation</seealso>
        public virtual Task<CancelAuditTaskResponse> CancelAuditTaskAsync(CancelAuditTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelAuditTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelAuditTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelAuditTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelCertificateTransfer


        /// <summary>
        /// Cancels a pending transfer for the specified certificate.
        /// 
        ///  
        /// <para>
        ///  <b>Note</b> Only the transfer source account can use this operation to cancel a transfer.
        /// (Transfer destinations can use <a>RejectCertificateTransfer</a> instead.) After transfer,
        /// AWS IoT returns the certificate to the source account in the INACTIVE state. After
        /// the destination account has accepted the transfer, the transfer cannot be cancelled.
        /// </para>
        ///  
        /// <para>
        /// After a certificate transfer is cancelled, the status of the certificate changes from
        /// PENDING_TRANSFER to INACTIVE.
        /// </para>
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// 
        /// <returns>The response from the CancelCertificateTransfer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.TransferAlreadyCompletedException">
        /// You can't revert the certificate transfer because the transfer is already complete.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelCertificateTransfer">REST API Reference for CancelCertificateTransfer Operation</seealso>
        public virtual CancelCertificateTransferResponse CancelCertificateTransfer(string certificateId)
        {
            var request = new CancelCertificateTransferRequest();
            request.CertificateId = certificateId;
            return CancelCertificateTransfer(request);
        }


        /// <summary>
        /// Cancels a pending transfer for the specified certificate.
        /// 
        ///  
        /// <para>
        ///  <b>Note</b> Only the transfer source account can use this operation to cancel a transfer.
        /// (Transfer destinations can use <a>RejectCertificateTransfer</a> instead.) After transfer,
        /// AWS IoT returns the certificate to the source account in the INACTIVE state. After
        /// the destination account has accepted the transfer, the transfer cannot be cancelled.
        /// </para>
        ///  
        /// <para>
        /// After a certificate transfer is cancelled, the status of the certificate changes from
        /// PENDING_TRANSFER to INACTIVE.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelCertificateTransfer service method.</param>
        /// 
        /// <returns>The response from the CancelCertificateTransfer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.TransferAlreadyCompletedException">
        /// You can't revert the certificate transfer because the transfer is already complete.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelCertificateTransfer">REST API Reference for CancelCertificateTransfer Operation</seealso>
        public virtual CancelCertificateTransferResponse CancelCertificateTransfer(CancelCertificateTransferRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelCertificateTransferRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelCertificateTransferResponseUnmarshaller.Instance;

            return Invoke<CancelCertificateTransferResponse>(request, options);
        }


        /// <summary>
        /// Cancels a pending transfer for the specified certificate.
        /// 
        ///  
        /// <para>
        ///  <b>Note</b> Only the transfer source account can use this operation to cancel a transfer.
        /// (Transfer destinations can use <a>RejectCertificateTransfer</a> instead.) After transfer,
        /// AWS IoT returns the certificate to the source account in the INACTIVE state. After
        /// the destination account has accepted the transfer, the transfer cannot be cancelled.
        /// </para>
        ///  
        /// <para>
        /// After a certificate transfer is cancelled, the status of the certificate changes from
        /// PENDING_TRANSFER to INACTIVE.
        /// </para>
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelCertificateTransfer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.TransferAlreadyCompletedException">
        /// You can't revert the certificate transfer because the transfer is already complete.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelCertificateTransfer">REST API Reference for CancelCertificateTransfer Operation</seealso>
        public virtual Task<CancelCertificateTransferResponse> CancelCertificateTransferAsync(string certificateId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CancelCertificateTransferRequest();
            request.CertificateId = certificateId;
            return CancelCertificateTransferAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelCertificateTransfer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelCertificateTransfer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelCertificateTransfer">REST API Reference for CancelCertificateTransfer Operation</seealso>
        public virtual Task<CancelCertificateTransferResponse> CancelCertificateTransferAsync(CancelCertificateTransferRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelCertificateTransferRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelCertificateTransferResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelCertificateTransferResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelJob


        /// <summary>
        /// Cancels a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelJob">REST API Reference for CancelJob Operation</seealso>
        public virtual CancelJobResponse CancelJob(CancelJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobResponseUnmarshaller.Instance;

            return Invoke<CancelJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelJob">REST API Reference for CancelJob Operation</seealso>
        public virtual Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelJobExecution


        /// <summary>
        /// Cancels the execution of a job for a given thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJobExecution service method.</param>
        /// 
        /// <returns>The response from the CancelJobExecution service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidStateTransitionException">
        /// An attempt was made to change to an invalid state, for example by deleting a job or
        /// a job execution which is "IN_PROGRESS" without setting the <code>force</code> parameter.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelJobExecution">REST API Reference for CancelJobExecution Operation</seealso>
        public virtual CancelJobExecutionResponse CancelJobExecution(CancelJobExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelJobExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobExecutionResponseUnmarshaller.Instance;

            return Invoke<CancelJobExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelJobExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelJobExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelJobExecution">REST API Reference for CancelJobExecution Operation</seealso>
        public virtual Task<CancelJobExecutionResponse> CancelJobExecutionAsync(CancelJobExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelJobExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobExecutionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelJobExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ClearDefaultAuthorizer


        /// <summary>
        /// Clears the default authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ClearDefaultAuthorizer service method.</param>
        /// 
        /// <returns>The response from the ClearDefaultAuthorizer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ClearDefaultAuthorizer">REST API Reference for ClearDefaultAuthorizer Operation</seealso>
        public virtual ClearDefaultAuthorizerResponse ClearDefaultAuthorizer(ClearDefaultAuthorizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ClearDefaultAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ClearDefaultAuthorizerResponseUnmarshaller.Instance;

            return Invoke<ClearDefaultAuthorizerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ClearDefaultAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ClearDefaultAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ClearDefaultAuthorizer">REST API Reference for ClearDefaultAuthorizer Operation</seealso>
        public virtual Task<ClearDefaultAuthorizerResponse> ClearDefaultAuthorizerAsync(ClearDefaultAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ClearDefaultAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ClearDefaultAuthorizerResponseUnmarshaller.Instance;
            
            return InvokeAsync<ClearDefaultAuthorizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAuthorizer


        /// <summary>
        /// Creates an authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthorizer service method.</param>
        /// 
        /// <returns>The response from the CreateAuthorizer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateAuthorizer">REST API Reference for CreateAuthorizer Operation</seealso>
        public virtual CreateAuthorizerResponse CreateAuthorizer(CreateAuthorizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAuthorizerResponseUnmarshaller.Instance;

            return Invoke<CreateAuthorizerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateAuthorizer">REST API Reference for CreateAuthorizer Operation</seealso>
        public virtual Task<CreateAuthorizerResponse> CreateAuthorizerAsync(CreateAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAuthorizerResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAuthorizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBillingGroup


        /// <summary>
        /// Creates a billing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBillingGroup service method.</param>
        /// 
        /// <returns>The response from the CreateBillingGroup service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateBillingGroup">REST API Reference for CreateBillingGroup Operation</seealso>
        public virtual CreateBillingGroupResponse CreateBillingGroup(CreateBillingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBillingGroupResponseUnmarshaller.Instance;

            return Invoke<CreateBillingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBillingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateBillingGroup">REST API Reference for CreateBillingGroup Operation</seealso>
        public virtual Task<CreateBillingGroupResponse> CreateBillingGroupAsync(CreateBillingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBillingGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateBillingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCertificateFromCsr


        /// <summary>
        /// Creates an X.509 certificate using the specified certificate signing request.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> The CSR must include a public key that is either an RSA key with a length
        /// of at least 2048 bits or an ECC key from NIST P-256 or NIST P-384 curves. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> Reusing the same certificate signing request (CSR) results in a distinct
        /// certificate.
        /// </para>
        ///  
        /// <para>
        /// You can create multiple certificates in a batch by creating a directory, copying multiple
        /// .csr files into that directory, and then specifying that directory on the command
        /// line. The following commands show how to create a batch of certificates given a batch
        /// of CSRs.
        /// </para>
        ///  
        /// <para>
        /// Assuming a set of CSRs are located inside of the directory my-csr-directory:
        /// </para>
        ///  
        /// <para>
        /// On Linux and OS X, the command is:
        /// </para>
        ///  
        /// <para>
        /// $ ls my-csr-directory/ | xargs -I {} aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/{}
        /// </para>
        ///  
        /// <para>
        /// This command lists all of the CSRs in my-csr-directory and pipes each CSR file name
        /// to the aws iot create-certificate-from-csr AWS CLI command to create a certificate
        /// for the corresponding CSR.
        /// </para>
        ///  
        /// <para>
        /// The aws iot create-certificate-from-csr part of the command can also be run in parallel
        /// to speed up the certificate creation process:
        /// </para>
        ///  
        /// <para>
        /// $ ls my-csr-directory/ | xargs -P 10 -I {} aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/{}
        /// </para>
        ///  
        /// <para>
        /// On Windows PowerShell, the command to create certificates for all CSRs in my-csr-directory
        /// is:
        /// </para>
        ///  
        /// <para>
        /// &gt; ls -Name my-csr-directory | %{aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/$_}
        /// </para>
        ///  
        /// <para>
        /// On a Windows command prompt, the command to create certificates for all CSRs in my-csr-directory
        /// is:
        /// </para>
        ///  
        /// <para>
        /// &gt; forfiles /p my-csr-directory /c "cmd /c aws iot create-certificate-from-csr --certificate-signing-request
        /// file://@path"
        /// </para>
        /// </summary>
        /// <param name="certificateSigningRequest">The certificate signing request (CSR).</param>
        /// 
        /// <returns>The response from the CreateCertificateFromCsr service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateCertificateFromCsr">REST API Reference for CreateCertificateFromCsr Operation</seealso>
        public virtual CreateCertificateFromCsrResponse CreateCertificateFromCsr(string certificateSigningRequest)
        {
            var request = new CreateCertificateFromCsrRequest();
            request.CertificateSigningRequest = certificateSigningRequest;
            return CreateCertificateFromCsr(request);
        }


        /// <summary>
        /// Creates an X.509 certificate using the specified certificate signing request.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> The CSR must include a public key that is either an RSA key with a length
        /// of at least 2048 bits or an ECC key from NIST P-256 or NIST P-384 curves. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> Reusing the same certificate signing request (CSR) results in a distinct
        /// certificate.
        /// </para>
        ///  
        /// <para>
        /// You can create multiple certificates in a batch by creating a directory, copying multiple
        /// .csr files into that directory, and then specifying that directory on the command
        /// line. The following commands show how to create a batch of certificates given a batch
        /// of CSRs.
        /// </para>
        ///  
        /// <para>
        /// Assuming a set of CSRs are located inside of the directory my-csr-directory:
        /// </para>
        ///  
        /// <para>
        /// On Linux and OS X, the command is:
        /// </para>
        ///  
        /// <para>
        /// $ ls my-csr-directory/ | xargs -I {} aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/{}
        /// </para>
        ///  
        /// <para>
        /// This command lists all of the CSRs in my-csr-directory and pipes each CSR file name
        /// to the aws iot create-certificate-from-csr AWS CLI command to create a certificate
        /// for the corresponding CSR.
        /// </para>
        ///  
        /// <para>
        /// The aws iot create-certificate-from-csr part of the command can also be run in parallel
        /// to speed up the certificate creation process:
        /// </para>
        ///  
        /// <para>
        /// $ ls my-csr-directory/ | xargs -P 10 -I {} aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/{}
        /// </para>
        ///  
        /// <para>
        /// On Windows PowerShell, the command to create certificates for all CSRs in my-csr-directory
        /// is:
        /// </para>
        ///  
        /// <para>
        /// &gt; ls -Name my-csr-directory | %{aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/$_}
        /// </para>
        ///  
        /// <para>
        /// On a Windows command prompt, the command to create certificates for all CSRs in my-csr-directory
        /// is:
        /// </para>
        ///  
        /// <para>
        /// &gt; forfiles /p my-csr-directory /c "cmd /c aws iot create-certificate-from-csr --certificate-signing-request
        /// file://@path"
        /// </para>
        /// </summary>
        /// <param name="certificateSigningRequest">The certificate signing request (CSR).</param>
        /// <param name="setAsActive">Specifies whether the certificate is active.</param>
        /// 
        /// <returns>The response from the CreateCertificateFromCsr service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateCertificateFromCsr">REST API Reference for CreateCertificateFromCsr Operation</seealso>
        public virtual CreateCertificateFromCsrResponse CreateCertificateFromCsr(string certificateSigningRequest, bool setAsActive)
        {
            var request = new CreateCertificateFromCsrRequest();
            request.CertificateSigningRequest = certificateSigningRequest;
            request.SetAsActive = setAsActive;
            return CreateCertificateFromCsr(request);
        }


        /// <summary>
        /// Creates an X.509 certificate using the specified certificate signing request.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> The CSR must include a public key that is either an RSA key with a length
        /// of at least 2048 bits or an ECC key from NIST P-256 or NIST P-384 curves. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> Reusing the same certificate signing request (CSR) results in a distinct
        /// certificate.
        /// </para>
        ///  
        /// <para>
        /// You can create multiple certificates in a batch by creating a directory, copying multiple
        /// .csr files into that directory, and then specifying that directory on the command
        /// line. The following commands show how to create a batch of certificates given a batch
        /// of CSRs.
        /// </para>
        ///  
        /// <para>
        /// Assuming a set of CSRs are located inside of the directory my-csr-directory:
        /// </para>
        ///  
        /// <para>
        /// On Linux and OS X, the command is:
        /// </para>
        ///  
        /// <para>
        /// $ ls my-csr-directory/ | xargs -I {} aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/{}
        /// </para>
        ///  
        /// <para>
        /// This command lists all of the CSRs in my-csr-directory and pipes each CSR file name
        /// to the aws iot create-certificate-from-csr AWS CLI command to create a certificate
        /// for the corresponding CSR.
        /// </para>
        ///  
        /// <para>
        /// The aws iot create-certificate-from-csr part of the command can also be run in parallel
        /// to speed up the certificate creation process:
        /// </para>
        ///  
        /// <para>
        /// $ ls my-csr-directory/ | xargs -P 10 -I {} aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/{}
        /// </para>
        ///  
        /// <para>
        /// On Windows PowerShell, the command to create certificates for all CSRs in my-csr-directory
        /// is:
        /// </para>
        ///  
        /// <para>
        /// &gt; ls -Name my-csr-directory | %{aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/$_}
        /// </para>
        ///  
        /// <para>
        /// On a Windows command prompt, the command to create certificates for all CSRs in my-csr-directory
        /// is:
        /// </para>
        ///  
        /// <para>
        /// &gt; forfiles /p my-csr-directory /c "cmd /c aws iot create-certificate-from-csr --certificate-signing-request
        /// file://@path"
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCertificateFromCsr service method.</param>
        /// 
        /// <returns>The response from the CreateCertificateFromCsr service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateCertificateFromCsr">REST API Reference for CreateCertificateFromCsr Operation</seealso>
        public virtual CreateCertificateFromCsrResponse CreateCertificateFromCsr(CreateCertificateFromCsrRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCertificateFromCsrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCertificateFromCsrResponseUnmarshaller.Instance;

            return Invoke<CreateCertificateFromCsrResponse>(request, options);
        }


        /// <summary>
        /// Creates an X.509 certificate using the specified certificate signing request.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> The CSR must include a public key that is either an RSA key with a length
        /// of at least 2048 bits or an ECC key from NIST P-256 or NIST P-384 curves. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> Reusing the same certificate signing request (CSR) results in a distinct
        /// certificate.
        /// </para>
        ///  
        /// <para>
        /// You can create multiple certificates in a batch by creating a directory, copying multiple
        /// .csr files into that directory, and then specifying that directory on the command
        /// line. The following commands show how to create a batch of certificates given a batch
        /// of CSRs.
        /// </para>
        ///  
        /// <para>
        /// Assuming a set of CSRs are located inside of the directory my-csr-directory:
        /// </para>
        ///  
        /// <para>
        /// On Linux and OS X, the command is:
        /// </para>
        ///  
        /// <para>
        /// $ ls my-csr-directory/ | xargs -I {} aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/{}
        /// </para>
        ///  
        /// <para>
        /// This command lists all of the CSRs in my-csr-directory and pipes each CSR file name
        /// to the aws iot create-certificate-from-csr AWS CLI command to create a certificate
        /// for the corresponding CSR.
        /// </para>
        ///  
        /// <para>
        /// The aws iot create-certificate-from-csr part of the command can also be run in parallel
        /// to speed up the certificate creation process:
        /// </para>
        ///  
        /// <para>
        /// $ ls my-csr-directory/ | xargs -P 10 -I {} aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/{}
        /// </para>
        ///  
        /// <para>
        /// On Windows PowerShell, the command to create certificates for all CSRs in my-csr-directory
        /// is:
        /// </para>
        ///  
        /// <para>
        /// &gt; ls -Name my-csr-directory | %{aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/$_}
        /// </para>
        ///  
        /// <para>
        /// On a Windows command prompt, the command to create certificates for all CSRs in my-csr-directory
        /// is:
        /// </para>
        ///  
        /// <para>
        /// &gt; forfiles /p my-csr-directory /c "cmd /c aws iot create-certificate-from-csr --certificate-signing-request
        /// file://@path"
        /// </para>
        /// </summary>
        /// <param name="certificateSigningRequest">The certificate signing request (CSR).</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCertificateFromCsr service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateCertificateFromCsr">REST API Reference for CreateCertificateFromCsr Operation</seealso>
        public virtual Task<CreateCertificateFromCsrResponse> CreateCertificateFromCsrAsync(string certificateSigningRequest, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreateCertificateFromCsrRequest();
            request.CertificateSigningRequest = certificateSigningRequest;
            return CreateCertificateFromCsrAsync(request, cancellationToken);
        }


        /// <summary>
        /// Creates an X.509 certificate using the specified certificate signing request.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> The CSR must include a public key that is either an RSA key with a length
        /// of at least 2048 bits or an ECC key from NIST P-256 or NIST P-384 curves. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> Reusing the same certificate signing request (CSR) results in a distinct
        /// certificate.
        /// </para>
        ///  
        /// <para>
        /// You can create multiple certificates in a batch by creating a directory, copying multiple
        /// .csr files into that directory, and then specifying that directory on the command
        /// line. The following commands show how to create a batch of certificates given a batch
        /// of CSRs.
        /// </para>
        ///  
        /// <para>
        /// Assuming a set of CSRs are located inside of the directory my-csr-directory:
        /// </para>
        ///  
        /// <para>
        /// On Linux and OS X, the command is:
        /// </para>
        ///  
        /// <para>
        /// $ ls my-csr-directory/ | xargs -I {} aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/{}
        /// </para>
        ///  
        /// <para>
        /// This command lists all of the CSRs in my-csr-directory and pipes each CSR file name
        /// to the aws iot create-certificate-from-csr AWS CLI command to create a certificate
        /// for the corresponding CSR.
        /// </para>
        ///  
        /// <para>
        /// The aws iot create-certificate-from-csr part of the command can also be run in parallel
        /// to speed up the certificate creation process:
        /// </para>
        ///  
        /// <para>
        /// $ ls my-csr-directory/ | xargs -P 10 -I {} aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/{}
        /// </para>
        ///  
        /// <para>
        /// On Windows PowerShell, the command to create certificates for all CSRs in my-csr-directory
        /// is:
        /// </para>
        ///  
        /// <para>
        /// &gt; ls -Name my-csr-directory | %{aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/$_}
        /// </para>
        ///  
        /// <para>
        /// On a Windows command prompt, the command to create certificates for all CSRs in my-csr-directory
        /// is:
        /// </para>
        ///  
        /// <para>
        /// &gt; forfiles /p my-csr-directory /c "cmd /c aws iot create-certificate-from-csr --certificate-signing-request
        /// file://@path"
        /// </para>
        /// </summary>
        /// <param name="certificateSigningRequest">The certificate signing request (CSR).</param>
        /// <param name="setAsActive">Specifies whether the certificate is active.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCertificateFromCsr service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateCertificateFromCsr">REST API Reference for CreateCertificateFromCsr Operation</seealso>
        public virtual Task<CreateCertificateFromCsrResponse> CreateCertificateFromCsrAsync(string certificateSigningRequest, bool setAsActive, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreateCertificateFromCsrRequest();
            request.CertificateSigningRequest = certificateSigningRequest;
            request.SetAsActive = setAsActive;
            return CreateCertificateFromCsrAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCertificateFromCsr operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCertificateFromCsr operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateCertificateFromCsr">REST API Reference for CreateCertificateFromCsr Operation</seealso>
        public virtual Task<CreateCertificateFromCsrResponse> CreateCertificateFromCsrAsync(CreateCertificateFromCsrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCertificateFromCsrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCertificateFromCsrResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateCertificateFromCsrResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDynamicThingGroup


        /// <summary>
        /// Creates a dynamic thing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDynamicThingGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDynamicThingGroup service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidQueryException">
        /// The query is invalid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateDynamicThingGroup">REST API Reference for CreateDynamicThingGroup Operation</seealso>
        public virtual CreateDynamicThingGroupResponse CreateDynamicThingGroup(CreateDynamicThingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDynamicThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDynamicThingGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDynamicThingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDynamicThingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDynamicThingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateDynamicThingGroup">REST API Reference for CreateDynamicThingGroup Operation</seealso>
        public virtual Task<CreateDynamicThingGroupResponse> CreateDynamicThingGroupAsync(CreateDynamicThingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDynamicThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDynamicThingGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDynamicThingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateJob


        /// <summary>
        /// Creates a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public virtual CreateJobResponse CreateJob(CreateJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;

            return Invoke<CreateJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public virtual Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateKeysAndCertificate


        /// <summary>
        /// Creates a 2048-bit RSA key pair and issues an X.509 certificate using the issued public
        /// key.
        /// 
        ///  
        /// <para>
        ///  <b>Note</b> This is the only time AWS IoT issues the private key for this certificate,
        /// so it is important to keep it in a secure location.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the CreateKeysAndCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateKeysAndCertificate">REST API Reference for CreateKeysAndCertificate Operation</seealso>
        public virtual CreateKeysAndCertificateResponse CreateKeysAndCertificate()
        {
            var request = new CreateKeysAndCertificateRequest();
            return CreateKeysAndCertificate(request);
        }


        /// <summary>
        /// Creates a 2048-bit RSA key pair and issues an X.509 certificate using the issued public
        /// key.
        /// 
        ///  
        /// <para>
        ///  <b>Note</b> This is the only time AWS IoT issues the private key for this certificate,
        /// so it is important to keep it in a secure location.
        /// </para>
        /// </summary>
        /// <param name="setAsActive">Specifies whether the certificate is active.</param>
        /// 
        /// <returns>The response from the CreateKeysAndCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateKeysAndCertificate">REST API Reference for CreateKeysAndCertificate Operation</seealso>
        public virtual CreateKeysAndCertificateResponse CreateKeysAndCertificate(bool setAsActive)
        {
            var request = new CreateKeysAndCertificateRequest();
            request.SetAsActive = setAsActive;
            return CreateKeysAndCertificate(request);
        }


        /// <summary>
        /// Creates a 2048-bit RSA key pair and issues an X.509 certificate using the issued public
        /// key.
        /// 
        ///  
        /// <para>
        ///  <b>Note</b> This is the only time AWS IoT issues the private key for this certificate,
        /// so it is important to keep it in a secure location.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKeysAndCertificate service method.</param>
        /// 
        /// <returns>The response from the CreateKeysAndCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateKeysAndCertificate">REST API Reference for CreateKeysAndCertificate Operation</seealso>
        public virtual CreateKeysAndCertificateResponse CreateKeysAndCertificate(CreateKeysAndCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateKeysAndCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeysAndCertificateResponseUnmarshaller.Instance;

            return Invoke<CreateKeysAndCertificateResponse>(request, options);
        }


        /// <summary>
        /// Creates a 2048-bit RSA key pair and issues an X.509 certificate using the issued public
        /// key.
        /// 
        ///  
        /// <para>
        ///  <b>Note</b> This is the only time AWS IoT issues the private key for this certificate,
        /// so it is important to keep it in a secure location.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateKeysAndCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateKeysAndCertificate">REST API Reference for CreateKeysAndCertificate Operation</seealso>
        public virtual Task<CreateKeysAndCertificateResponse> CreateKeysAndCertificateAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreateKeysAndCertificateRequest();
            return CreateKeysAndCertificateAsync(request, cancellationToken);
        }


        /// <summary>
        /// Creates a 2048-bit RSA key pair and issues an X.509 certificate using the issued public
        /// key.
        /// 
        ///  
        /// <para>
        ///  <b>Note</b> This is the only time AWS IoT issues the private key for this certificate,
        /// so it is important to keep it in a secure location.
        /// </para>
        /// </summary>
        /// <param name="setAsActive">Specifies whether the certificate is active.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateKeysAndCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateKeysAndCertificate">REST API Reference for CreateKeysAndCertificate Operation</seealso>
        public virtual Task<CreateKeysAndCertificateResponse> CreateKeysAndCertificateAsync(bool setAsActive, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreateKeysAndCertificateRequest();
            request.SetAsActive = setAsActive;
            return CreateKeysAndCertificateAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKeysAndCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKeysAndCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateKeysAndCertificate">REST API Reference for CreateKeysAndCertificate Operation</seealso>
        public virtual Task<CreateKeysAndCertificateResponse> CreateKeysAndCertificateAsync(CreateKeysAndCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateKeysAndCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeysAndCertificateResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateKeysAndCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateOTAUpdate


        /// <summary>
        /// Creates an AWS IoT OTAUpdate on a target group of things or groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOTAUpdate service method.</param>
        /// 
        /// <returns>The response from the CreateOTAUpdate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateOTAUpdate">REST API Reference for CreateOTAUpdate Operation</seealso>
        public virtual CreateOTAUpdateResponse CreateOTAUpdate(CreateOTAUpdateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOTAUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOTAUpdateResponseUnmarshaller.Instance;

            return Invoke<CreateOTAUpdateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOTAUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOTAUpdate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateOTAUpdate">REST API Reference for CreateOTAUpdate Operation</seealso>
        public virtual Task<CreateOTAUpdateResponse> CreateOTAUpdateAsync(CreateOTAUpdateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOTAUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOTAUpdateResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateOTAUpdateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePolicy


        /// <summary>
        /// Creates an AWS IoT policy.
        /// 
        ///  
        /// <para>
        /// The created policy is the default version for the policy. This operation creates a
        /// policy version with a version identifier of <b>1</b> and sets <b>1</b> as the policy's
        /// default version.
        /// </para>
        /// </summary>
        /// <param name="policyName">The policy name.</param>
        /// <param name="policyDocument">The JSON document that describes the policy. <b>policyDocument</b> must have a minimum length of 1, with a maximum length of 2048, excluding whitespace.</param>
        /// 
        /// <returns>The response from the CreatePolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.MalformedPolicyException">
        /// The policy documentation is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        public virtual CreatePolicyResponse CreatePolicy(string policyName, string policyDocument)
        {
            var request = new CreatePolicyRequest();
            request.PolicyName = policyName;
            request.PolicyDocument = policyDocument;
            return CreatePolicy(request);
        }


        /// <summary>
        /// Creates an AWS IoT policy.
        /// 
        ///  
        /// <para>
        /// The created policy is the default version for the policy. This operation creates a
        /// policy version with a version identifier of <b>1</b> and sets <b>1</b> as the policy's
        /// default version.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy service method.</param>
        /// 
        /// <returns>The response from the CreatePolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.MalformedPolicyException">
        /// The policy documentation is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        public virtual CreatePolicyResponse CreatePolicy(CreatePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePolicyResponseUnmarshaller.Instance;

            return Invoke<CreatePolicyResponse>(request, options);
        }


        /// <summary>
        /// Creates an AWS IoT policy.
        /// 
        ///  
        /// <para>
        /// The created policy is the default version for the policy. This operation creates a
        /// policy version with a version identifier of <b>1</b> and sets <b>1</b> as the policy's
        /// default version.
        /// </para>
        /// </summary>
        /// <param name="policyName">The policy name.</param>
        /// <param name="policyDocument">The JSON document that describes the policy. <b>policyDocument</b> must have a minimum length of 1, with a maximum length of 2048, excluding whitespace.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.MalformedPolicyException">
        /// The policy documentation is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        public virtual Task<CreatePolicyResponse> CreatePolicyAsync(string policyName, string policyDocument, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreatePolicyRequest();
            request.PolicyName = policyName;
            request.PolicyDocument = policyDocument;
            return CreatePolicyAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        public virtual Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePolicyVersion


        /// <summary>
        /// Creates a new version of the specified AWS IoT policy. To update a policy, create
        /// a new policy version. A managed policy can have up to five versions. If the policy
        /// has five versions, you must use <a>DeletePolicyVersion</a> to delete an existing version
        /// before you create a new one.
        /// 
        ///  
        /// <para>
        /// Optionally, you can set the new version as the policy's default version. The default
        /// version is the operative version (that is, the version that is in effect for the certificates
        /// to which the policy is attached).
        /// </para>
        /// </summary>
        /// <param name="policyName">The policy name.</param>
        /// <param name="policyDocument">The JSON document that describes the policy. Minimum length of 1. Maximum length of 2048, excluding whitespace.</param>
        /// 
        /// <returns>The response from the CreatePolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.MalformedPolicyException">
        /// The policy documentation is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionsLimitExceededException">
        /// The number of policy versions exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreatePolicyVersion">REST API Reference for CreatePolicyVersion Operation</seealso>
        public virtual CreatePolicyVersionResponse CreatePolicyVersion(string policyName, string policyDocument)
        {
            var request = new CreatePolicyVersionRequest();
            request.PolicyName = policyName;
            request.PolicyDocument = policyDocument;
            return CreatePolicyVersion(request);
        }


        /// <summary>
        /// Creates a new version of the specified AWS IoT policy. To update a policy, create
        /// a new policy version. A managed policy can have up to five versions. If the policy
        /// has five versions, you must use <a>DeletePolicyVersion</a> to delete an existing version
        /// before you create a new one.
        /// 
        ///  
        /// <para>
        /// Optionally, you can set the new version as the policy's default version. The default
        /// version is the operative version (that is, the version that is in effect for the certificates
        /// to which the policy is attached).
        /// </para>
        /// </summary>
        /// <param name="policyName">The policy name.</param>
        /// <param name="policyDocument">The JSON document that describes the policy. Minimum length of 1. Maximum length of 2048, excluding whitespace.</param>
        /// <param name="setAsDefault">Specifies whether the policy version is set as the default. When this parameter is true, the new policy version becomes the operative version (that is, the version that is in effect for the certificates to which the policy is attached).</param>
        /// 
        /// <returns>The response from the CreatePolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.MalformedPolicyException">
        /// The policy documentation is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionsLimitExceededException">
        /// The number of policy versions exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreatePolicyVersion">REST API Reference for CreatePolicyVersion Operation</seealso>
        public virtual CreatePolicyVersionResponse CreatePolicyVersion(string policyName, string policyDocument, bool setAsDefault)
        {
            var request = new CreatePolicyVersionRequest();
            request.PolicyName = policyName;
            request.PolicyDocument = policyDocument;
            request.SetAsDefault = setAsDefault;
            return CreatePolicyVersion(request);
        }


        /// <summary>
        /// Creates a new version of the specified AWS IoT policy. To update a policy, create
        /// a new policy version. A managed policy can have up to five versions. If the policy
        /// has five versions, you must use <a>DeletePolicyVersion</a> to delete an existing version
        /// before you create a new one.
        /// 
        ///  
        /// <para>
        /// Optionally, you can set the new version as the policy's default version. The default
        /// version is the operative version (that is, the version that is in effect for the certificates
        /// to which the policy is attached).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicyVersion service method.</param>
        /// 
        /// <returns>The response from the CreatePolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.MalformedPolicyException">
        /// The policy documentation is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionsLimitExceededException">
        /// The number of policy versions exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreatePolicyVersion">REST API Reference for CreatePolicyVersion Operation</seealso>
        public virtual CreatePolicyVersionResponse CreatePolicyVersion(CreatePolicyVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePolicyVersionResponseUnmarshaller.Instance;

            return Invoke<CreatePolicyVersionResponse>(request, options);
        }


        /// <summary>
        /// Creates a new version of the specified AWS IoT policy. To update a policy, create
        /// a new policy version. A managed policy can have up to five versions. If the policy
        /// has five versions, you must use <a>DeletePolicyVersion</a> to delete an existing version
        /// before you create a new one.
        /// 
        ///  
        /// <para>
        /// Optionally, you can set the new version as the policy's default version. The default
        /// version is the operative version (that is, the version that is in effect for the certificates
        /// to which the policy is attached).
        /// </para>
        /// </summary>
        /// <param name="policyName">The policy name.</param>
        /// <param name="policyDocument">The JSON document that describes the policy. Minimum length of 1. Maximum length of 2048, excluding whitespace.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.MalformedPolicyException">
        /// The policy documentation is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionsLimitExceededException">
        /// The number of policy versions exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreatePolicyVersion">REST API Reference for CreatePolicyVersion Operation</seealso>
        public virtual Task<CreatePolicyVersionResponse> CreatePolicyVersionAsync(string policyName, string policyDocument, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreatePolicyVersionRequest();
            request.PolicyName = policyName;
            request.PolicyDocument = policyDocument;
            return CreatePolicyVersionAsync(request, cancellationToken);
        }


        /// <summary>
        /// Creates a new version of the specified AWS IoT policy. To update a policy, create
        /// a new policy version. A managed policy can have up to five versions. If the policy
        /// has five versions, you must use <a>DeletePolicyVersion</a> to delete an existing version
        /// before you create a new one.
        /// 
        ///  
        /// <para>
        /// Optionally, you can set the new version as the policy's default version. The default
        /// version is the operative version (that is, the version that is in effect for the certificates
        /// to which the policy is attached).
        /// </para>
        /// </summary>
        /// <param name="policyName">The policy name.</param>
        /// <param name="policyDocument">The JSON document that describes the policy. Minimum length of 1. Maximum length of 2048, excluding whitespace.</param>
        /// <param name="setAsDefault">Specifies whether the policy version is set as the default. When this parameter is true, the new policy version becomes the operative version (that is, the version that is in effect for the certificates to which the policy is attached).</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.MalformedPolicyException">
        /// The policy documentation is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionsLimitExceededException">
        /// The number of policy versions exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreatePolicyVersion">REST API Reference for CreatePolicyVersion Operation</seealso>
        public virtual Task<CreatePolicyVersionResponse> CreatePolicyVersionAsync(string policyName, string policyDocument, bool setAsDefault, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreatePolicyVersionRequest();
            request.PolicyName = policyName;
            request.PolicyDocument = policyDocument;
            request.SetAsDefault = setAsDefault;
            return CreatePolicyVersionAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicyVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreatePolicyVersion">REST API Reference for CreatePolicyVersion Operation</seealso>
        public virtual Task<CreatePolicyVersionResponse> CreatePolicyVersionAsync(CreatePolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePolicyVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePolicyVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRoleAlias


        /// <summary>
        /// Creates a role alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoleAlias service method.</param>
        /// 
        /// <returns>The response from the CreateRoleAlias service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateRoleAlias">REST API Reference for CreateRoleAlias Operation</seealso>
        public virtual CreateRoleAliasResponse CreateRoleAlias(CreateRoleAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRoleAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoleAliasResponseUnmarshaller.Instance;

            return Invoke<CreateRoleAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoleAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoleAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateRoleAlias">REST API Reference for CreateRoleAlias Operation</seealso>
        public virtual Task<CreateRoleAliasResponse> CreateRoleAliasAsync(CreateRoleAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRoleAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoleAliasResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateRoleAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateScheduledAudit


        /// <summary>
        /// Creates a scheduled audit that is run at a specified time interval.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScheduledAudit service method.</param>
        /// 
        /// <returns>The response from the CreateScheduledAudit service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateScheduledAudit">REST API Reference for CreateScheduledAudit Operation</seealso>
        public virtual CreateScheduledAuditResponse CreateScheduledAudit(CreateScheduledAuditRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScheduledAuditRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScheduledAuditResponseUnmarshaller.Instance;

            return Invoke<CreateScheduledAuditResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateScheduledAudit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateScheduledAudit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateScheduledAudit">REST API Reference for CreateScheduledAudit Operation</seealso>
        public virtual Task<CreateScheduledAuditResponse> CreateScheduledAuditAsync(CreateScheduledAuditRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScheduledAuditRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScheduledAuditResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateScheduledAuditResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSecurityProfile


        /// <summary>
        /// Creates a Device Defender security profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityProfile service method.</param>
        /// 
        /// <returns>The response from the CreateSecurityProfile service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateSecurityProfile">REST API Reference for CreateSecurityProfile Operation</seealso>
        public virtual CreateSecurityProfileResponse CreateSecurityProfile(CreateSecurityProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityProfileResponseUnmarshaller.Instance;

            return Invoke<CreateSecurityProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateSecurityProfile">REST API Reference for CreateSecurityProfile Operation</seealso>
        public virtual Task<CreateSecurityProfileResponse> CreateSecurityProfileAsync(CreateSecurityProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSecurityProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateStream


        /// <summary>
        /// Creates a stream for delivering one or more large files in chunks over MQTT. A stream
        /// transports data bytes in chunks or blocks packaged as MQTT messages from a source
        /// like S3. You can have one or more files associated with a stream. The total size of
        /// a file associated with the stream cannot exceed more than 2 MB. The stream will be
        /// created with version 0. If a stream is created with the same streamID as a stream
        /// that existed and was deleted within last 90 days, we will resurrect that old stream
        /// by incrementing the version by 1.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStream service method.</param>
        /// 
        /// <returns>The response from the CreateStream service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateStream">REST API Reference for CreateStream Operation</seealso>
        public virtual CreateStreamResponse CreateStream(CreateStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamResponseUnmarshaller.Instance;

            return Invoke<CreateStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateStream">REST API Reference for CreateStream Operation</seealso>
        public virtual Task<CreateStreamResponse> CreateStreamAsync(CreateStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateThing


        /// <summary>
        /// Creates a thing record in the registry.
        /// 
        ///  <note> 
        /// <para>
        /// This is a control plane operation. See <a href="http://docs.aws.amazon.com/iot/latest/developerguide/authorization.html">Authorization</a>
        /// for information about authorizing control plane actions.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateThing service method.</param>
        /// 
        /// <returns>The response from the CreateThing service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateThing">REST API Reference for CreateThing Operation</seealso>
        public virtual CreateThingResponse CreateThing(CreateThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThingResponseUnmarshaller.Instance;

            return Invoke<CreateThingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateThing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateThing">REST API Reference for CreateThing Operation</seealso>
        public virtual Task<CreateThingResponse> CreateThingAsync(CreateThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThingResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateThingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateThingGroup


        /// <summary>
        /// Create a thing group.
        /// 
        ///  <note> 
        /// <para>
        /// This is a control plane operation. See <a href="http://docs.aws.amazon.com/iot/latest/developerguide/authorization.html">Authorization</a>
        /// for information about authorizing control plane actions.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateThingGroup service method.</param>
        /// 
        /// <returns>The response from the CreateThingGroup service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateThingGroup">REST API Reference for CreateThingGroup Operation</seealso>
        public virtual CreateThingGroupResponse CreateThingGroup(CreateThingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThingGroupResponseUnmarshaller.Instance;

            return Invoke<CreateThingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateThingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateThingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateThingGroup">REST API Reference for CreateThingGroup Operation</seealso>
        public virtual Task<CreateThingGroupResponse> CreateThingGroupAsync(CreateThingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThingGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateThingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateThingType


        /// <summary>
        /// Creates a new thing type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateThingType service method.</param>
        /// 
        /// <returns>The response from the CreateThingType service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateThingType">REST API Reference for CreateThingType Operation</seealso>
        public virtual CreateThingTypeResponse CreateThingType(CreateThingTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateThingTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThingTypeResponseUnmarshaller.Instance;

            return Invoke<CreateThingTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateThingType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateThingType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateThingType">REST API Reference for CreateThingType Operation</seealso>
        public virtual Task<CreateThingTypeResponse> CreateThingTypeAsync(CreateThingTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateThingTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThingTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateThingTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTopicRule


        /// <summary>
        /// Creates a rule. Creating rules is an administrator-level action. Any user who has
        /// permission to create rules will be able to access data processed by the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTopicRule service method.</param>
        /// 
        /// <returns>The response from the CreateTopicRule service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.ConflictingResourceUpdateException">
        /// A conflicting resource update exception. This exception is thrown when two pending
        /// updates cause a conflict.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.SqlParseException">
        /// The Rule-SQL expression can't be parsed correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateTopicRule">REST API Reference for CreateTopicRule Operation</seealso>
        public virtual CreateTopicRuleResponse CreateTopicRule(CreateTopicRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTopicRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTopicRuleResponseUnmarshaller.Instance;

            return Invoke<CreateTopicRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTopicRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTopicRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateTopicRule">REST API Reference for CreateTopicRule Operation</seealso>
        public virtual Task<CreateTopicRuleResponse> CreateTopicRuleAsync(CreateTopicRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTopicRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTopicRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateTopicRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAccountAuditConfiguration


        /// <summary>
        /// Restores the default settings for Device Defender audits for this account. Any configuration
        /// data you entered is deleted and all audit checks are reset to disabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAuditConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteAccountAuditConfiguration service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteAccountAuditConfiguration">REST API Reference for DeleteAccountAuditConfiguration Operation</seealso>
        public virtual DeleteAccountAuditConfigurationResponse DeleteAccountAuditConfiguration(DeleteAccountAuditConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccountAuditConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountAuditConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteAccountAuditConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountAuditConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAuditConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteAccountAuditConfiguration">REST API Reference for DeleteAccountAuditConfiguration Operation</seealso>
        public virtual Task<DeleteAccountAuditConfigurationResponse> DeleteAccountAuditConfigurationAsync(DeleteAccountAuditConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccountAuditConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountAuditConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAccountAuditConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAuthorizer


        /// <summary>
        /// Deletes an authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthorizer service method.</param>
        /// 
        /// <returns>The response from the DeleteAuthorizer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.DeleteConflictException">
        /// You can't delete the resource because it is attached to one or more resources.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteAuthorizer">REST API Reference for DeleteAuthorizer Operation</seealso>
        public virtual DeleteAuthorizerResponse DeleteAuthorizer(DeleteAuthorizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAuthorizerResponseUnmarshaller.Instance;

            return Invoke<DeleteAuthorizerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteAuthorizer">REST API Reference for DeleteAuthorizer Operation</seealso>
        public virtual Task<DeleteAuthorizerResponse> DeleteAuthorizerAsync(DeleteAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAuthorizerResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAuthorizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBillingGroup


        /// <summary>
        /// Deletes the billing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBillingGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteBillingGroup service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteBillingGroup">REST API Reference for DeleteBillingGroup Operation</seealso>
        public virtual DeleteBillingGroupResponse DeleteBillingGroup(DeleteBillingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBillingGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteBillingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBillingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteBillingGroup">REST API Reference for DeleteBillingGroup Operation</seealso>
        public virtual Task<DeleteBillingGroupResponse> DeleteBillingGroupAsync(DeleteBillingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBillingGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteBillingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCACertificate


        /// <summary>
        /// Deletes a registered CA certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCACertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteCACertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.CertificateStateException">
        /// The certificate operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteCACertificate">REST API Reference for DeleteCACertificate Operation</seealso>
        public virtual DeleteCACertificateResponse DeleteCACertificate(DeleteCACertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCACertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCACertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteCACertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCACertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCACertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteCACertificate">REST API Reference for DeleteCACertificate Operation</seealso>
        public virtual Task<DeleteCACertificateResponse> DeleteCACertificateAsync(DeleteCACertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCACertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCACertificateResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCACertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCertificate


        /// <summary>
        /// Deletes the specified certificate.
        /// 
        ///  
        /// <para>
        /// A certificate cannot be deleted if it has a policy attached to it or if its status
        /// is set to ACTIVE. To delete a certificate, first use the <a>DetachPrincipalPolicy</a>
        /// API to detach all policies. Next, use the <a>UpdateCertificate</a> API to set the
        /// certificate to the INACTIVE status.
        /// </para>
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.CertificateStateException">
        /// The certificate operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.DeleteConflictException">
        /// You can't delete the resource because it is attached to one or more resources.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        public virtual DeleteCertificateResponse DeleteCertificate(string certificateId)
        {
            var request = new DeleteCertificateRequest();
            request.CertificateId = certificateId;
            return DeleteCertificate(request);
        }


        /// <summary>
        /// Deletes the specified certificate.
        /// 
        ///  
        /// <para>
        /// A certificate cannot be deleted if it has a policy attached to it or if its status
        /// is set to ACTIVE. To delete a certificate, first use the <a>DetachPrincipalPolicy</a>
        /// API to detach all policies. Next, use the <a>UpdateCertificate</a> API to set the
        /// certificate to the INACTIVE status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.CertificateStateException">
        /// The certificate operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.DeleteConflictException">
        /// You can't delete the resource because it is attached to one or more resources.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        public virtual DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteCertificateResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified certificate.
        /// 
        ///  
        /// <para>
        /// A certificate cannot be deleted if it has a policy attached to it or if its status
        /// is set to ACTIVE. To delete a certificate, first use the <a>DetachPrincipalPolicy</a>
        /// API to detach all policies. Next, use the <a>UpdateCertificate</a> API to set the
        /// certificate to the INACTIVE status.
        /// </para>
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.CertificateStateException">
        /// The certificate operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.DeleteConflictException">
        /// You can't delete the resource because it is attached to one or more resources.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        public virtual Task<DeleteCertificateResponse> DeleteCertificateAsync(string certificateId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteCertificateRequest();
            request.CertificateId = certificateId;
            return DeleteCertificateAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        public virtual Task<DeleteCertificateResponse> DeleteCertificateAsync(DeleteCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCertificateResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDynamicThingGroup


        /// <summary>
        /// Deletes a dynamic thing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDynamicThingGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDynamicThingGroup service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteDynamicThingGroup">REST API Reference for DeleteDynamicThingGroup Operation</seealso>
        public virtual DeleteDynamicThingGroupResponse DeleteDynamicThingGroup(DeleteDynamicThingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDynamicThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDynamicThingGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDynamicThingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDynamicThingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDynamicThingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteDynamicThingGroup">REST API Reference for DeleteDynamicThingGroup Operation</seealso>
        public virtual Task<DeleteDynamicThingGroupResponse> DeleteDynamicThingGroupAsync(DeleteDynamicThingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDynamicThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDynamicThingGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDynamicThingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteJob


        /// <summary>
        /// Deletes a job and its related job executions.
        /// 
        ///  
        /// <para>
        /// Deleting a job may take time, depending on the number of job executions created for
        /// the job and various other factors. While the job is being deleted, the status of the
        /// job will be shown as "DELETION_IN_PROGRESS". Attempting to delete or cancel a job
        /// whose status is already "DELETION_IN_PROGRESS" will result in an error.
        /// </para>
        ///  
        /// <para>
        /// Only 10 jobs may have status "DELETION_IN_PROGRESS" at the same time, or a LimitExceededException
        /// will occur.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob service method.</param>
        /// 
        /// <returns>The response from the DeleteJob service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidStateTransitionException">
        /// An attempt was made to change to an invalid state, for example by deleting a job or
        /// a job execution which is "IN_PROGRESS" without setting the <code>force</code> parameter.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        public virtual DeleteJobResponse DeleteJob(DeleteJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobResponseUnmarshaller.Instance;

            return Invoke<DeleteJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        public virtual Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteJobExecution


        /// <summary>
        /// Deletes a job execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobExecution service method.</param>
        /// 
        /// <returns>The response from the DeleteJobExecution service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidStateTransitionException">
        /// An attempt was made to change to an invalid state, for example by deleting a job or
        /// a job execution which is "IN_PROGRESS" without setting the <code>force</code> parameter.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteJobExecution">REST API Reference for DeleteJobExecution Operation</seealso>
        public virtual DeleteJobExecutionResponse DeleteJobExecution(DeleteJobExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobExecutionResponseUnmarshaller.Instance;

            return Invoke<DeleteJobExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteJobExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteJobExecution">REST API Reference for DeleteJobExecution Operation</seealso>
        public virtual Task<DeleteJobExecutionResponse> DeleteJobExecutionAsync(DeleteJobExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobExecutionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteJobExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteOTAUpdate


        /// <summary>
        /// Delete an OTA update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOTAUpdate service method.</param>
        /// 
        /// <returns>The response from the DeleteOTAUpdate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteOTAUpdate">REST API Reference for DeleteOTAUpdate Operation</seealso>
        public virtual DeleteOTAUpdateResponse DeleteOTAUpdate(DeleteOTAUpdateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOTAUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOTAUpdateResponseUnmarshaller.Instance;

            return Invoke<DeleteOTAUpdateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOTAUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOTAUpdate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteOTAUpdate">REST API Reference for DeleteOTAUpdate Operation</seealso>
        public virtual Task<DeleteOTAUpdateResponse> DeleteOTAUpdateAsync(DeleteOTAUpdateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOTAUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOTAUpdateResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteOTAUpdateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePolicy


        /// <summary>
        /// Deletes the specified policy.
        /// 
        ///  
        /// <para>
        /// A policy cannot be deleted if it has non-default versions or it is attached to any
        /// certificate.
        /// </para>
        ///  
        /// <para>
        /// To delete a policy, use the DeletePolicyVersion API to delete all non-default versions
        /// of the policy; use the DetachPrincipalPolicy API to detach the policy from any certificate;
        /// and then use the DeletePolicy API to delete the policy.
        /// </para>
        ///  
        /// <para>
        /// When a policy is deleted using DeletePolicy, its default version is deleted with it.
        /// </para>
        /// </summary>
        /// <param name="policyName">The name of the policy to delete.</param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.DeleteConflictException">
        /// You can't delete the resource because it is attached to one or more resources.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual DeletePolicyResponse DeletePolicy(string policyName)
        {
            var request = new DeletePolicyRequest();
            request.PolicyName = policyName;
            return DeletePolicy(request);
        }


        /// <summary>
        /// Deletes the specified policy.
        /// 
        ///  
        /// <para>
        /// A policy cannot be deleted if it has non-default versions or it is attached to any
        /// certificate.
        /// </para>
        ///  
        /// <para>
        /// To delete a policy, use the DeletePolicyVersion API to delete all non-default versions
        /// of the policy; use the DetachPrincipalPolicy API to detach the policy from any certificate;
        /// and then use the DeletePolicy API to delete the policy.
        /// </para>
        ///  
        /// <para>
        /// When a policy is deleted using DeletePolicy, its default version is deleted with it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.DeleteConflictException">
        /// You can't delete the resource because it is attached to one or more resources.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified policy.
        /// 
        ///  
        /// <para>
        /// A policy cannot be deleted if it has non-default versions or it is attached to any
        /// certificate.
        /// </para>
        ///  
        /// <para>
        /// To delete a policy, use the DeletePolicyVersion API to delete all non-default versions
        /// of the policy; use the DetachPrincipalPolicy API to detach the policy from any certificate;
        /// and then use the DeletePolicy API to delete the policy.
        /// </para>
        ///  
        /// <para>
        /// When a policy is deleted using DeletePolicy, its default version is deleted with it.
        /// </para>
        /// </summary>
        /// <param name="policyName">The name of the policy to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.DeleteConflictException">
        /// You can't delete the resource because it is attached to one or more resources.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual Task<DeletePolicyResponse> DeletePolicyAsync(string policyName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeletePolicyRequest();
            request.PolicyName = policyName;
            return DeletePolicyAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePolicyVersion


        /// <summary>
        /// Deletes the specified version of the specified policy. You cannot delete the default
        /// version of a policy using this API. To delete the default version of a policy, use
        /// <a>DeletePolicy</a>. To find out which version of a policy is marked as the default
        /// version, use ListPolicyVersions.
        /// </summary>
        /// <param name="policyName">The name of the policy.</param>
        /// <param name="policyVersionId">The policy version ID.</param>
        /// 
        /// <returns>The response from the DeletePolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.DeleteConflictException">
        /// You can't delete the resource because it is attached to one or more resources.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeletePolicyVersion">REST API Reference for DeletePolicyVersion Operation</seealso>
        public virtual DeletePolicyVersionResponse DeletePolicyVersion(string policyName, string policyVersionId)
        {
            var request = new DeletePolicyVersionRequest();
            request.PolicyName = policyName;
            request.PolicyVersionId = policyVersionId;
            return DeletePolicyVersion(request);
        }


        /// <summary>
        /// Deletes the specified version of the specified policy. You cannot delete the default
        /// version of a policy using this API. To delete the default version of a policy, use
        /// <a>DeletePolicy</a>. To find out which version of a policy is marked as the default
        /// version, use ListPolicyVersions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyVersion service method.</param>
        /// 
        /// <returns>The response from the DeletePolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.DeleteConflictException">
        /// You can't delete the resource because it is attached to one or more resources.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeletePolicyVersion">REST API Reference for DeletePolicyVersion Operation</seealso>
        public virtual DeletePolicyVersionResponse DeletePolicyVersion(DeletePolicyVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyVersionResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyVersionResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified version of the specified policy. You cannot delete the default
        /// version of a policy using this API. To delete the default version of a policy, use
        /// <a>DeletePolicy</a>. To find out which version of a policy is marked as the default
        /// version, use ListPolicyVersions.
        /// </summary>
        /// <param name="policyName">The name of the policy.</param>
        /// <param name="policyVersionId">The policy version ID.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.DeleteConflictException">
        /// You can't delete the resource because it is attached to one or more resources.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeletePolicyVersion">REST API Reference for DeletePolicyVersion Operation</seealso>
        public virtual Task<DeletePolicyVersionResponse> DeletePolicyVersionAsync(string policyName, string policyVersionId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeletePolicyVersionRequest();
            request.PolicyName = policyName;
            request.PolicyVersionId = policyVersionId;
            return DeletePolicyVersionAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeletePolicyVersion">REST API Reference for DeletePolicyVersion Operation</seealso>
        public virtual Task<DeletePolicyVersionResponse> DeletePolicyVersionAsync(DeletePolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePolicyVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRegistrationCode


        /// <summary>
        /// Deletes a CA certificate registration code.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistrationCode service method.</param>
        /// 
        /// <returns>The response from the DeleteRegistrationCode service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteRegistrationCode">REST API Reference for DeleteRegistrationCode Operation</seealso>
        public virtual DeleteRegistrationCodeResponse DeleteRegistrationCode(DeleteRegistrationCodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRegistrationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegistrationCodeResponseUnmarshaller.Instance;

            return Invoke<DeleteRegistrationCodeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRegistrationCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistrationCode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteRegistrationCode">REST API Reference for DeleteRegistrationCode Operation</seealso>
        public virtual Task<DeleteRegistrationCodeResponse> DeleteRegistrationCodeAsync(DeleteRegistrationCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRegistrationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegistrationCodeResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteRegistrationCodeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRoleAlias


        /// <summary>
        /// Deletes a role alias
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoleAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteRoleAlias service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.DeleteConflictException">
        /// You can't delete the resource because it is attached to one or more resources.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteRoleAlias">REST API Reference for DeleteRoleAlias Operation</seealso>
        public virtual DeleteRoleAliasResponse DeleteRoleAlias(DeleteRoleAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRoleAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoleAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteRoleAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoleAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoleAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteRoleAlias">REST API Reference for DeleteRoleAlias Operation</seealso>
        public virtual Task<DeleteRoleAliasResponse> DeleteRoleAliasAsync(DeleteRoleAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRoleAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoleAliasResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteRoleAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteScheduledAudit


        /// <summary>
        /// Deletes a scheduled audit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAudit service method.</param>
        /// 
        /// <returns>The response from the DeleteScheduledAudit service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteScheduledAudit">REST API Reference for DeleteScheduledAudit Operation</seealso>
        public virtual DeleteScheduledAuditResponse DeleteScheduledAudit(DeleteScheduledAuditRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScheduledAuditRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduledAuditResponseUnmarshaller.Instance;

            return Invoke<DeleteScheduledAuditResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScheduledAudit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAudit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteScheduledAudit">REST API Reference for DeleteScheduledAudit Operation</seealso>
        public virtual Task<DeleteScheduledAuditResponse> DeleteScheduledAuditAsync(DeleteScheduledAuditRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScheduledAuditRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduledAuditResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteScheduledAuditResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSecurityProfile


        /// <summary>
        /// Deletes a Device Defender security profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteSecurityProfile service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteSecurityProfile">REST API Reference for DeleteSecurityProfile Operation</seealso>
        public virtual DeleteSecurityProfileResponse DeleteSecurityProfile(DeleteSecurityProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteSecurityProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteSecurityProfile">REST API Reference for DeleteSecurityProfile Operation</seealso>
        public virtual Task<DeleteSecurityProfileResponse> DeleteSecurityProfileAsync(DeleteSecurityProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSecurityProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteStream


        /// <summary>
        /// Deletes a stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStream service method.</param>
        /// 
        /// <returns>The response from the DeleteStream service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.DeleteConflictException">
        /// You can't delete the resource because it is attached to one or more resources.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteStream">REST API Reference for DeleteStream Operation</seealso>
        public virtual DeleteStreamResponse DeleteStream(DeleteStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamResponseUnmarshaller.Instance;

            return Invoke<DeleteStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteStream">REST API Reference for DeleteStream Operation</seealso>
        public virtual Task<DeleteStreamResponse> DeleteStreamAsync(DeleteStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteThing


        /// <summary>
        /// Deletes the specified thing. Returns successfully with no error if the deletion is
        /// successful or you specify a thing that doesn't exist.
        /// </summary>
        /// <param name="thingName">The name of the thing to delete.</param>
        /// 
        /// <returns>The response from the DeleteThing service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteThing">REST API Reference for DeleteThing Operation</seealso>
        public virtual DeleteThingResponse DeleteThing(string thingName)
        {
            var request = new DeleteThingRequest();
            request.ThingName = thingName;
            return DeleteThing(request);
        }


        /// <summary>
        /// Deletes the specified thing. Returns successfully with no error if the deletion is
        /// successful or you specify a thing that doesn't exist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteThing service method.</param>
        /// 
        /// <returns>The response from the DeleteThing service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteThing">REST API Reference for DeleteThing Operation</seealso>
        public virtual DeleteThingResponse DeleteThing(DeleteThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThingResponseUnmarshaller.Instance;

            return Invoke<DeleteThingResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified thing. Returns successfully with no error if the deletion is
        /// successful or you specify a thing that doesn't exist.
        /// </summary>
        /// <param name="thingName">The name of the thing to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteThing service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteThing">REST API Reference for DeleteThing Operation</seealso>
        public virtual Task<DeleteThingResponse> DeleteThingAsync(string thingName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteThingRequest();
            request.ThingName = thingName;
            return DeleteThingAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteThing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteThing">REST API Reference for DeleteThing Operation</seealso>
        public virtual Task<DeleteThingResponse> DeleteThingAsync(DeleteThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThingResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteThingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteThingGroup


        /// <summary>
        /// Deletes a thing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteThingGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteThingGroup service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteThingGroup">REST API Reference for DeleteThingGroup Operation</seealso>
        public virtual DeleteThingGroupResponse DeleteThingGroup(DeleteThingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThingGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteThingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteThingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteThingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteThingGroup">REST API Reference for DeleteThingGroup Operation</seealso>
        public virtual Task<DeleteThingGroupResponse> DeleteThingGroupAsync(DeleteThingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThingGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteThingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteThingType


        /// <summary>
        /// Deletes the specified thing type. You cannot delete a thing type if it has things
        /// associated with it. To delete a thing type, first mark it as deprecated by calling
        /// <a>DeprecateThingType</a>, then remove any associated things by calling <a>UpdateThing</a>
        /// to change the thing type on any associated thing, and finally use <a>DeleteThingType</a>
        /// to delete the thing type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteThingType service method.</param>
        /// 
        /// <returns>The response from the DeleteThingType service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteThingType">REST API Reference for DeleteThingType Operation</seealso>
        public virtual DeleteThingTypeResponse DeleteThingType(DeleteThingTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThingTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThingTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteThingTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteThingType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteThingType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteThingType">REST API Reference for DeleteThingType Operation</seealso>
        public virtual Task<DeleteThingTypeResponse> DeleteThingTypeAsync(DeleteThingTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThingTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThingTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteThingTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTopicRule


        /// <summary>
        /// Deletes the rule.
        /// </summary>
        /// <param name="ruleName">The name of the rule.</param>
        /// 
        /// <returns>The response from the DeleteTopicRule service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.ConflictingResourceUpdateException">
        /// A conflicting resource update exception. This exception is thrown when two pending
        /// updates cause a conflict.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteTopicRule">REST API Reference for DeleteTopicRule Operation</seealso>
        public virtual DeleteTopicRuleResponse DeleteTopicRule(string ruleName)
        {
            var request = new DeleteTopicRuleRequest();
            request.RuleName = ruleName;
            return DeleteTopicRule(request);
        }


        /// <summary>
        /// Deletes the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopicRule service method.</param>
        /// 
        /// <returns>The response from the DeleteTopicRule service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.ConflictingResourceUpdateException">
        /// A conflicting resource update exception. This exception is thrown when two pending
        /// updates cause a conflict.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteTopicRule">REST API Reference for DeleteTopicRule Operation</seealso>
        public virtual DeleteTopicRuleResponse DeleteTopicRule(DeleteTopicRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTopicRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTopicRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteTopicRuleResponse>(request, options);
        }


        /// <summary>
        /// Deletes the rule.
        /// </summary>
        /// <param name="ruleName">The name of the rule.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTopicRule service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.ConflictingResourceUpdateException">
        /// A conflicting resource update exception. This exception is thrown when two pending
        /// updates cause a conflict.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteTopicRule">REST API Reference for DeleteTopicRule Operation</seealso>
        public virtual Task<DeleteTopicRuleResponse> DeleteTopicRuleAsync(string ruleName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteTopicRuleRequest();
            request.RuleName = ruleName;
            return DeleteTopicRuleAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTopicRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopicRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteTopicRule">REST API Reference for DeleteTopicRule Operation</seealso>
        public virtual Task<DeleteTopicRuleResponse> DeleteTopicRuleAsync(DeleteTopicRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTopicRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTopicRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteTopicRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteV2LoggingLevel


        /// <summary>
        /// Deletes a logging level.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteV2LoggingLevel service method.</param>
        /// 
        /// <returns>The response from the DeleteV2LoggingLevel service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteV2LoggingLevel">REST API Reference for DeleteV2LoggingLevel Operation</seealso>
        public virtual DeleteV2LoggingLevelResponse DeleteV2LoggingLevel(DeleteV2LoggingLevelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteV2LoggingLevelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteV2LoggingLevelResponseUnmarshaller.Instance;

            return Invoke<DeleteV2LoggingLevelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteV2LoggingLevel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteV2LoggingLevel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteV2LoggingLevel">REST API Reference for DeleteV2LoggingLevel Operation</seealso>
        public virtual Task<DeleteV2LoggingLevelResponse> DeleteV2LoggingLevelAsync(DeleteV2LoggingLevelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteV2LoggingLevelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteV2LoggingLevelResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteV2LoggingLevelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeprecateThingType


        /// <summary>
        /// Deprecates a thing type. You can not associate new things with deprecated thing type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprecateThingType service method.</param>
        /// 
        /// <returns>The response from the DeprecateThingType service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeprecateThingType">REST API Reference for DeprecateThingType Operation</seealso>
        public virtual DeprecateThingTypeResponse DeprecateThingType(DeprecateThingTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeprecateThingTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateThingTypeResponseUnmarshaller.Instance;

            return Invoke<DeprecateThingTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeprecateThingType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeprecateThingType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeprecateThingType">REST API Reference for DeprecateThingType Operation</seealso>
        public virtual Task<DeprecateThingTypeResponse> DeprecateThingTypeAsync(DeprecateThingTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeprecateThingTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateThingTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeprecateThingTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountAuditConfiguration


        /// <summary>
        /// Gets information about the Device Defender audit settings for this account. Settings
        /// include how audit notifications are sent and which audit checks are enabled or disabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAuditConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountAuditConfiguration service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAccountAuditConfiguration">REST API Reference for DescribeAccountAuditConfiguration Operation</seealso>
        public virtual DescribeAccountAuditConfigurationResponse DescribeAccountAuditConfiguration(DescribeAccountAuditConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAuditConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAuditConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAuditConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAuditConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAuditConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAccountAuditConfiguration">REST API Reference for DescribeAccountAuditConfiguration Operation</seealso>
        public virtual Task<DescribeAccountAuditConfigurationResponse> DescribeAccountAuditConfigurationAsync(DescribeAccountAuditConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAuditConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAuditConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAccountAuditConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAuditTask


        /// <summary>
        /// Gets information about a Device Defender audit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuditTask service method.</param>
        /// 
        /// <returns>The response from the DescribeAuditTask service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAuditTask">REST API Reference for DescribeAuditTask Operation</seealso>
        public virtual DescribeAuditTaskResponse DescribeAuditTask(DescribeAuditTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAuditTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAuditTaskResponseUnmarshaller.Instance;

            return Invoke<DescribeAuditTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAuditTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuditTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAuditTask">REST API Reference for DescribeAuditTask Operation</seealso>
        public virtual Task<DescribeAuditTaskResponse> DescribeAuditTaskAsync(DescribeAuditTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAuditTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAuditTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAuditTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAuthorizer


        /// <summary>
        /// Describes an authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuthorizer service method.</param>
        /// 
        /// <returns>The response from the DescribeAuthorizer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAuthorizer">REST API Reference for DescribeAuthorizer Operation</seealso>
        public virtual DescribeAuthorizerResponse DescribeAuthorizer(DescribeAuthorizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAuthorizerResponseUnmarshaller.Instance;

            return Invoke<DescribeAuthorizerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAuthorizer">REST API Reference for DescribeAuthorizer Operation</seealso>
        public virtual Task<DescribeAuthorizerResponse> DescribeAuthorizerAsync(DescribeAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAuthorizerResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAuthorizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeBillingGroup


        /// <summary>
        /// Returns information about a billing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBillingGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeBillingGroup service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeBillingGroup">REST API Reference for DescribeBillingGroup Operation</seealso>
        public virtual DescribeBillingGroupResponse DescribeBillingGroup(DescribeBillingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBillingGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeBillingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBillingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeBillingGroup">REST API Reference for DescribeBillingGroup Operation</seealso>
        public virtual Task<DescribeBillingGroupResponse> DescribeBillingGroupAsync(DescribeBillingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBillingGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeBillingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCACertificate


        /// <summary>
        /// Describes a registered CA certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCACertificate service method.</param>
        /// 
        /// <returns>The response from the DescribeCACertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeCACertificate">REST API Reference for DescribeCACertificate Operation</seealso>
        public virtual DescribeCACertificateResponse DescribeCACertificate(DescribeCACertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCACertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCACertificateResponseUnmarshaller.Instance;

            return Invoke<DescribeCACertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCACertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCACertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeCACertificate">REST API Reference for DescribeCACertificate Operation</seealso>
        public virtual Task<DescribeCACertificateResponse> DescribeCACertificateAsync(DescribeCACertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCACertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCACertificateResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeCACertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCertificate


        /// <summary>
        /// Gets information about the specified certificate.
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        public virtual DescribeCertificateResponse DescribeCertificate(string certificateId)
        {
            var request = new DescribeCertificateRequest();
            request.CertificateId = certificateId;
            return DescribeCertificate(request);
        }


        /// <summary>
        /// Gets information about the specified certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificate service method.</param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        public virtual DescribeCertificateResponse DescribeCertificate(DescribeCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificateResponseUnmarshaller.Instance;

            return Invoke<DescribeCertificateResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the specified certificate.
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        public virtual Task<DescribeCertificateResponse> DescribeCertificateAsync(string certificateId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeCertificateRequest();
            request.CertificateId = certificateId;
            return DescribeCertificateAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        public virtual Task<DescribeCertificateResponse> DescribeCertificateAsync(DescribeCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificateResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDefaultAuthorizer


        /// <summary>
        /// Describes the default authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultAuthorizer service method.</param>
        /// 
        /// <returns>The response from the DescribeDefaultAuthorizer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeDefaultAuthorizer">REST API Reference for DescribeDefaultAuthorizer Operation</seealso>
        public virtual DescribeDefaultAuthorizerResponse DescribeDefaultAuthorizer(DescribeDefaultAuthorizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDefaultAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDefaultAuthorizerResponseUnmarshaller.Instance;

            return Invoke<DescribeDefaultAuthorizerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDefaultAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeDefaultAuthorizer">REST API Reference for DescribeDefaultAuthorizer Operation</seealso>
        public virtual Task<DescribeDefaultAuthorizerResponse> DescribeDefaultAuthorizerAsync(DescribeDefaultAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDefaultAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDefaultAuthorizerResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDefaultAuthorizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEndpoint


        /// <summary>
        /// Returns a unique endpoint specific to the AWS account making the call.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEndpoint service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        public virtual DescribeEndpointResponse DescribeEndpoint()
        {
            var request = new DescribeEndpointRequest();
            return DescribeEndpoint(request);
        }


        /// <summary>
        /// Returns a unique endpoint specific to the AWS account making the call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoint service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpoint service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        public virtual DescribeEndpointResponse DescribeEndpoint(DescribeEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointResponse>(request, options);
        }


        /// <summary>
        /// Returns a unique endpoint specific to the AWS account making the call.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEndpoint service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        public virtual Task<DescribeEndpointResponse> DescribeEndpointAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeEndpointRequest();
            return DescribeEndpointAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        public virtual Task<DescribeEndpointResponse> DescribeEndpointAsync(DescribeEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventConfigurations


        /// <summary>
        /// Describes event configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeEventConfigurations service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeEventConfigurations">REST API Reference for DescribeEventConfigurations Operation</seealso>
        public virtual DescribeEventConfigurationsResponse DescribeEventConfigurations(DescribeEventConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeEventConfigurations">REST API Reference for DescribeEventConfigurations Operation</seealso>
        public virtual Task<DescribeEventConfigurationsResponse> DescribeEventConfigurationsAsync(DescribeEventConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEventConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeIndex


        /// <summary>
        /// Describes a search index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndex service method.</param>
        /// 
        /// <returns>The response from the DescribeIndex service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeIndex">REST API Reference for DescribeIndex Operation</seealso>
        public virtual DescribeIndexResponse DescribeIndex(DescribeIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIndexResponseUnmarshaller.Instance;

            return Invoke<DescribeIndexResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndex operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeIndex">REST API Reference for DescribeIndex Operation</seealso>
        public virtual Task<DescribeIndexResponse> DescribeIndexAsync(DescribeIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIndexResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeIndexResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeJob


        /// <summary>
        /// Describes a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob service method.</param>
        /// 
        /// <returns>The response from the DescribeJob service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeJob">REST API Reference for DescribeJob Operation</seealso>
        public virtual DescribeJobResponse DescribeJob(DescribeJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobResponseUnmarshaller.Instance;

            return Invoke<DescribeJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeJob">REST API Reference for DescribeJob Operation</seealso>
        public virtual Task<DescribeJobResponse> DescribeJobAsync(DescribeJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeJobExecution


        /// <summary>
        /// Describes a job execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobExecution service method.</param>
        /// 
        /// <returns>The response from the DescribeJobExecution service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeJobExecution">REST API Reference for DescribeJobExecution Operation</seealso>
        public virtual DescribeJobExecutionResponse DescribeJobExecution(DescribeJobExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobExecutionResponseUnmarshaller.Instance;

            return Invoke<DescribeJobExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeJobExecution">REST API Reference for DescribeJobExecution Operation</seealso>
        public virtual Task<DescribeJobExecutionResponse> DescribeJobExecutionAsync(DescribeJobExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobExecutionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeJobExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRoleAlias


        /// <summary>
        /// Describes a role alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRoleAlias service method.</param>
        /// 
        /// <returns>The response from the DescribeRoleAlias service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeRoleAlias">REST API Reference for DescribeRoleAlias Operation</seealso>
        public virtual DescribeRoleAliasResponse DescribeRoleAlias(DescribeRoleAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRoleAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRoleAliasResponseUnmarshaller.Instance;

            return Invoke<DescribeRoleAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRoleAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRoleAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeRoleAlias">REST API Reference for DescribeRoleAlias Operation</seealso>
        public virtual Task<DescribeRoleAliasResponse> DescribeRoleAliasAsync(DescribeRoleAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRoleAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRoleAliasResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeRoleAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeScheduledAudit


        /// <summary>
        /// Gets information about a scheduled audit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledAudit service method.</param>
        /// 
        /// <returns>The response from the DescribeScheduledAudit service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeScheduledAudit">REST API Reference for DescribeScheduledAudit Operation</seealso>
        public virtual DescribeScheduledAuditResponse DescribeScheduledAudit(DescribeScheduledAuditRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledAuditRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledAuditResponseUnmarshaller.Instance;

            return Invoke<DescribeScheduledAuditResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScheduledAudit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledAudit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeScheduledAudit">REST API Reference for DescribeScheduledAudit Operation</seealso>
        public virtual Task<DescribeScheduledAuditResponse> DescribeScheduledAuditAsync(DescribeScheduledAuditRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledAuditRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledAuditResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeScheduledAuditResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSecurityProfile


        /// <summary>
        /// Gets information about a Device Defender security profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityProfile service method.</param>
        /// 
        /// <returns>The response from the DescribeSecurityProfile service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeSecurityProfile">REST API Reference for DescribeSecurityProfile Operation</seealso>
        public virtual DescribeSecurityProfileResponse DescribeSecurityProfile(DescribeSecurityProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecurityProfileResponseUnmarshaller.Instance;

            return Invoke<DescribeSecurityProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeSecurityProfile">REST API Reference for DescribeSecurityProfile Operation</seealso>
        public virtual Task<DescribeSecurityProfileResponse> DescribeSecurityProfileAsync(DescribeSecurityProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecurityProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeSecurityProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStream


        /// <summary>
        /// Gets information about a stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStream service method.</param>
        /// 
        /// <returns>The response from the DescribeStream service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeStream">REST API Reference for DescribeStream Operation</seealso>
        public virtual DescribeStreamResponse DescribeStream(DescribeStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamResponseUnmarshaller.Instance;

            return Invoke<DescribeStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeStream">REST API Reference for DescribeStream Operation</seealso>
        public virtual Task<DescribeStreamResponse> DescribeStreamAsync(DescribeStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeThing


        /// <summary>
        /// Gets information about the specified thing.
        /// </summary>
        /// <param name="thingName">The name of the thing.</param>
        /// 
        /// <returns>The response from the DescribeThing service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThing">REST API Reference for DescribeThing Operation</seealso>
        public virtual DescribeThingResponse DescribeThing(string thingName)
        {
            var request = new DescribeThingRequest();
            request.ThingName = thingName;
            return DescribeThing(request);
        }


        /// <summary>
        /// Gets information about the specified thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeThing service method.</param>
        /// 
        /// <returns>The response from the DescribeThing service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThing">REST API Reference for DescribeThing Operation</seealso>
        public virtual DescribeThingResponse DescribeThing(DescribeThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeThingResponseUnmarshaller.Instance;

            return Invoke<DescribeThingResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the specified thing.
        /// </summary>
        /// <param name="thingName">The name of the thing.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeThing service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThing">REST API Reference for DescribeThing Operation</seealso>
        public virtual Task<DescribeThingResponse> DescribeThingAsync(string thingName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeThingRequest();
            request.ThingName = thingName;
            return DescribeThingAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeThing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThing">REST API Reference for DescribeThing Operation</seealso>
        public virtual Task<DescribeThingResponse> DescribeThingAsync(DescribeThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeThingResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeThingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeThingGroup


        /// <summary>
        /// Describe a thing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeThingGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeThingGroup service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThingGroup">REST API Reference for DescribeThingGroup Operation</seealso>
        public virtual DescribeThingGroupResponse DescribeThingGroup(DescribeThingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeThingGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeThingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeThingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeThingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThingGroup">REST API Reference for DescribeThingGroup Operation</seealso>
        public virtual Task<DescribeThingGroupResponse> DescribeThingGroupAsync(DescribeThingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeThingGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeThingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeThingRegistrationTask


        /// <summary>
        /// Describes a bulk thing provisioning task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeThingRegistrationTask service method.</param>
        /// 
        /// <returns>The response from the DescribeThingRegistrationTask service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThingRegistrationTask">REST API Reference for DescribeThingRegistrationTask Operation</seealso>
        public virtual DescribeThingRegistrationTaskResponse DescribeThingRegistrationTask(DescribeThingRegistrationTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeThingRegistrationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeThingRegistrationTaskResponseUnmarshaller.Instance;

            return Invoke<DescribeThingRegistrationTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeThingRegistrationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeThingRegistrationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThingRegistrationTask">REST API Reference for DescribeThingRegistrationTask Operation</seealso>
        public virtual Task<DescribeThingRegistrationTaskResponse> DescribeThingRegistrationTaskAsync(DescribeThingRegistrationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeThingRegistrationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeThingRegistrationTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeThingRegistrationTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeThingType


        /// <summary>
        /// Gets information about the specified thing type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeThingType service method.</param>
        /// 
        /// <returns>The response from the DescribeThingType service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThingType">REST API Reference for DescribeThingType Operation</seealso>
        public virtual DescribeThingTypeResponse DescribeThingType(DescribeThingTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeThingTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeThingTypeResponseUnmarshaller.Instance;

            return Invoke<DescribeThingTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeThingType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeThingType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThingType">REST API Reference for DescribeThingType Operation</seealso>
        public virtual Task<DescribeThingTypeResponse> DescribeThingTypeAsync(DescribeThingTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeThingTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeThingTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeThingTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachPolicy


        /// <summary>
        /// Detaches a policy from the specified target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachPolicy service method.</param>
        /// 
        /// <returns>The response from the DetachPolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachPolicy">REST API Reference for DetachPolicy Operation</seealso>
        public virtual DetachPolicyResponse DetachPolicy(DetachPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachPolicyResponseUnmarshaller.Instance;

            return Invoke<DetachPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachPolicy">REST API Reference for DetachPolicy Operation</seealso>
        public virtual Task<DetachPolicyResponse> DetachPolicyAsync(DetachPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DetachPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachPrincipalPolicy


        /// <summary>
        /// Removes the specified policy from the specified certificate.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This API is deprecated. Please use <a>DetachPolicy</a> instead.
        /// </para>
        /// </summary>
        /// <param name="policyName">The name of the policy to detach.</param>
        /// <param name="principal">The principal. If the principal is a certificate, specify the certificate ARN. If the principal is an Amazon Cognito identity, specify the identity ID.</param>
        /// 
        /// <returns>The response from the DetachPrincipalPolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachPrincipalPolicy">REST API Reference for DetachPrincipalPolicy Operation</seealso>
        [Obsolete("Deprecated in favor of DetachPolicy.")]
        public virtual DetachPrincipalPolicyResponse DetachPrincipalPolicy(string policyName, string principal)
        {
            var request = new DetachPrincipalPolicyRequest();
            request.PolicyName = policyName;
            request.Principal = principal;
            return DetachPrincipalPolicy(request);
        }


        /// <summary>
        /// Removes the specified policy from the specified certificate.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This API is deprecated. Please use <a>DetachPolicy</a> instead.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachPrincipalPolicy service method.</param>
        /// 
        /// <returns>The response from the DetachPrincipalPolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachPrincipalPolicy">REST API Reference for DetachPrincipalPolicy Operation</seealso>
        [Obsolete("Deprecated in favor of DetachPolicy.")]
        public virtual DetachPrincipalPolicyResponse DetachPrincipalPolicy(DetachPrincipalPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachPrincipalPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachPrincipalPolicyResponseUnmarshaller.Instance;

            return Invoke<DetachPrincipalPolicyResponse>(request, options);
        }


        /// <summary>
        /// Removes the specified policy from the specified certificate.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This API is deprecated. Please use <a>DetachPolicy</a> instead.
        /// </para>
        /// </summary>
        /// <param name="policyName">The name of the policy to detach.</param>
        /// <param name="principal">The principal. If the principal is a certificate, specify the certificate ARN. If the principal is an Amazon Cognito identity, specify the identity ID.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachPrincipalPolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachPrincipalPolicy">REST API Reference for DetachPrincipalPolicy Operation</seealso>
        [Obsolete("Deprecated in favor of DetachPolicy.")]
        public virtual Task<DetachPrincipalPolicyResponse> DetachPrincipalPolicyAsync(string policyName, string principal, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DetachPrincipalPolicyRequest();
            request.PolicyName = policyName;
            request.Principal = principal;
            return DetachPrincipalPolicyAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachPrincipalPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachPrincipalPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachPrincipalPolicy">REST API Reference for DetachPrincipalPolicy Operation</seealso>
        [Obsolete("Deprecated in favor of DetachPolicy.")]
        public virtual Task<DetachPrincipalPolicyResponse> DetachPrincipalPolicyAsync(DetachPrincipalPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachPrincipalPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachPrincipalPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DetachPrincipalPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachSecurityProfile


        /// <summary>
        /// Disassociates a Device Defender security profile from a thing group or from this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachSecurityProfile service method.</param>
        /// 
        /// <returns>The response from the DetachSecurityProfile service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachSecurityProfile">REST API Reference for DetachSecurityProfile Operation</seealso>
        public virtual DetachSecurityProfileResponse DetachSecurityProfile(DetachSecurityProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachSecurityProfileResponseUnmarshaller.Instance;

            return Invoke<DetachSecurityProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachSecurityProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachSecurityProfile">REST API Reference for DetachSecurityProfile Operation</seealso>
        public virtual Task<DetachSecurityProfileResponse> DetachSecurityProfileAsync(DetachSecurityProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachSecurityProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<DetachSecurityProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachThingPrincipal


        /// <summary>
        /// Detaches the specified principal from the specified thing.
        /// 
        ///  <note> 
        /// <para>
        /// This call is asynchronous. It might take several seconds for the detachment to propagate.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="thingName">The name of the thing.</param>
        /// <param name="principal">If the principal is a certificate, this value must be ARN of the certificate. If the principal is an Amazon Cognito identity, this value must be the ID of the Amazon Cognito identity.</param>
        /// 
        /// <returns>The response from the DetachThingPrincipal service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachThingPrincipal">REST API Reference for DetachThingPrincipal Operation</seealso>
        public virtual DetachThingPrincipalResponse DetachThingPrincipal(string thingName, string principal)
        {
            var request = new DetachThingPrincipalRequest();
            request.ThingName = thingName;
            request.Principal = principal;
            return DetachThingPrincipal(request);
        }


        /// <summary>
        /// Detaches the specified principal from the specified thing.
        /// 
        ///  <note> 
        /// <para>
        /// This call is asynchronous. It might take several seconds for the detachment to propagate.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachThingPrincipal service method.</param>
        /// 
        /// <returns>The response from the DetachThingPrincipal service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachThingPrincipal">REST API Reference for DetachThingPrincipal Operation</seealso>
        public virtual DetachThingPrincipalResponse DetachThingPrincipal(DetachThingPrincipalRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachThingPrincipalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachThingPrincipalResponseUnmarshaller.Instance;

            return Invoke<DetachThingPrincipalResponse>(request, options);
        }


        /// <summary>
        /// Detaches the specified principal from the specified thing.
        /// 
        ///  <note> 
        /// <para>
        /// This call is asynchronous. It might take several seconds for the detachment to propagate.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="thingName">The name of the thing.</param>
        /// <param name="principal">If the principal is a certificate, this value must be ARN of the certificate. If the principal is an Amazon Cognito identity, this value must be the ID of the Amazon Cognito identity.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachThingPrincipal service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachThingPrincipal">REST API Reference for DetachThingPrincipal Operation</seealso>
        public virtual Task<DetachThingPrincipalResponse> DetachThingPrincipalAsync(string thingName, string principal, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DetachThingPrincipalRequest();
            request.ThingName = thingName;
            request.Principal = principal;
            return DetachThingPrincipalAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachThingPrincipal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachThingPrincipal operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachThingPrincipal">REST API Reference for DetachThingPrincipal Operation</seealso>
        public virtual Task<DetachThingPrincipalResponse> DetachThingPrincipalAsync(DetachThingPrincipalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachThingPrincipalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachThingPrincipalResponseUnmarshaller.Instance;
            
            return InvokeAsync<DetachThingPrincipalResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableTopicRule


        /// <summary>
        /// Disables the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableTopicRule service method.</param>
        /// 
        /// <returns>The response from the DisableTopicRule service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.ConflictingResourceUpdateException">
        /// A conflicting resource update exception. This exception is thrown when two pending
        /// updates cause a conflict.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DisableTopicRule">REST API Reference for DisableTopicRule Operation</seealso>
        public virtual DisableTopicRuleResponse DisableTopicRule(DisableTopicRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableTopicRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableTopicRuleResponseUnmarshaller.Instance;

            return Invoke<DisableTopicRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableTopicRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableTopicRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DisableTopicRule">REST API Reference for DisableTopicRule Operation</seealso>
        public virtual Task<DisableTopicRuleResponse> DisableTopicRuleAsync(DisableTopicRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableTopicRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableTopicRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisableTopicRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableTopicRule


        /// <summary>
        /// Enables the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableTopicRule service method.</param>
        /// 
        /// <returns>The response from the EnableTopicRule service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.ConflictingResourceUpdateException">
        /// A conflicting resource update exception. This exception is thrown when two pending
        /// updates cause a conflict.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/EnableTopicRule">REST API Reference for EnableTopicRule Operation</seealso>
        public virtual EnableTopicRuleResponse EnableTopicRule(EnableTopicRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableTopicRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableTopicRuleResponseUnmarshaller.Instance;

            return Invoke<EnableTopicRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableTopicRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableTopicRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/EnableTopicRule">REST API Reference for EnableTopicRule Operation</seealso>
        public virtual Task<EnableTopicRuleResponse> EnableTopicRuleAsync(EnableTopicRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableTopicRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableTopicRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<EnableTopicRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEffectivePolicies


        /// <summary>
        /// Gets a list of the policies that have an effect on the authorization behavior of the
        /// specified device when it connects to the AWS IoT device gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEffectivePolicies service method.</param>
        /// 
        /// <returns>The response from the GetEffectivePolicies service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetEffectivePolicies">REST API Reference for GetEffectivePolicies Operation</seealso>
        public virtual GetEffectivePoliciesResponse GetEffectivePolicies(GetEffectivePoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEffectivePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEffectivePoliciesResponseUnmarshaller.Instance;

            return Invoke<GetEffectivePoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEffectivePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEffectivePolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetEffectivePolicies">REST API Reference for GetEffectivePolicies Operation</seealso>
        public virtual Task<GetEffectivePoliciesResponse> GetEffectivePoliciesAsync(GetEffectivePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEffectivePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEffectivePoliciesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetEffectivePoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIndexingConfiguration


        /// <summary>
        /// Gets the search configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIndexingConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetIndexingConfiguration service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetIndexingConfiguration">REST API Reference for GetIndexingConfiguration Operation</seealso>
        public virtual GetIndexingConfigurationResponse GetIndexingConfiguration(GetIndexingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIndexingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIndexingConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetIndexingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIndexingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIndexingConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetIndexingConfiguration">REST API Reference for GetIndexingConfiguration Operation</seealso>
        public virtual Task<GetIndexingConfigurationResponse> GetIndexingConfigurationAsync(GetIndexingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIndexingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIndexingConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetIndexingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetJobDocument


        /// <summary>
        /// Gets a job document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobDocument service method.</param>
        /// 
        /// <returns>The response from the GetJobDocument service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetJobDocument">REST API Reference for GetJobDocument Operation</seealso>
        public virtual GetJobDocumentResponse GetJobDocument(GetJobDocumentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobDocumentResponseUnmarshaller.Instance;

            return Invoke<GetJobDocumentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJobDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobDocument operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetJobDocument">REST API Reference for GetJobDocument Operation</seealso>
        public virtual Task<GetJobDocumentResponse> GetJobDocumentAsync(GetJobDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobDocumentResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetJobDocumentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLoggingOptions


        /// <summary>
        /// Gets the logging options.
        /// 
        ///  
        /// <para>
        /// NOTE: use of this command is not recommended. Use <code>GetV2LoggingOptions</code>
        /// instead.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoggingOptions service method.</param>
        /// 
        /// <returns>The response from the GetLoggingOptions service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetLoggingOptions">REST API Reference for GetLoggingOptions Operation</seealso>
        public virtual GetLoggingOptionsResponse GetLoggingOptions(GetLoggingOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoggingOptionsResponseUnmarshaller.Instance;

            return Invoke<GetLoggingOptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoggingOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetLoggingOptions">REST API Reference for GetLoggingOptions Operation</seealso>
        public virtual Task<GetLoggingOptionsResponse> GetLoggingOptionsAsync(GetLoggingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoggingOptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetLoggingOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOTAUpdate


        /// <summary>
        /// Gets an OTA update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOTAUpdate service method.</param>
        /// 
        /// <returns>The response from the GetOTAUpdate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetOTAUpdate">REST API Reference for GetOTAUpdate Operation</seealso>
        public virtual GetOTAUpdateResponse GetOTAUpdate(GetOTAUpdateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOTAUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOTAUpdateResponseUnmarshaller.Instance;

            return Invoke<GetOTAUpdateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOTAUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOTAUpdate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetOTAUpdate">REST API Reference for GetOTAUpdate Operation</seealso>
        public virtual Task<GetOTAUpdateResponse> GetOTAUpdateAsync(GetOTAUpdateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOTAUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOTAUpdateResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetOTAUpdateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPolicy


        /// <summary>
        /// Gets information about the specified policy with the policy document of the default
        /// version.
        /// </summary>
        /// <param name="policyName">The name of the policy.</param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual GetPolicyResponse GetPolicy(string policyName)
        {
            var request = new GetPolicyRequest();
            request.PolicyName = policyName;
            return GetPolicy(request);
        }


        /// <summary>
        /// Gets information about the specified policy with the policy document of the default
        /// version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return Invoke<GetPolicyResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the specified policy with the policy document of the default
        /// version.
        /// </summary>
        /// <param name="policyName">The name of the policy.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual Task<GetPolicyResponse> GetPolicyAsync(string policyName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetPolicyRequest();
            request.PolicyName = policyName;
            return GetPolicyAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPolicyVersion


        /// <summary>
        /// Gets information about the specified policy version.
        /// </summary>
        /// <param name="policyName">The name of the policy.</param>
        /// <param name="policyVersionId">The policy version ID.</param>
        /// 
        /// <returns>The response from the GetPolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetPolicyVersion">REST API Reference for GetPolicyVersion Operation</seealso>
        public virtual GetPolicyVersionResponse GetPolicyVersion(string policyName, string policyVersionId)
        {
            var request = new GetPolicyVersionRequest();
            request.PolicyName = policyName;
            request.PolicyVersionId = policyVersionId;
            return GetPolicyVersion(request);
        }


        /// <summary>
        /// Gets information about the specified policy version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyVersion service method.</param>
        /// 
        /// <returns>The response from the GetPolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetPolicyVersion">REST API Reference for GetPolicyVersion Operation</seealso>
        public virtual GetPolicyVersionResponse GetPolicyVersion(GetPolicyVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyVersionResponseUnmarshaller.Instance;

            return Invoke<GetPolicyVersionResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the specified policy version.
        /// </summary>
        /// <param name="policyName">The name of the policy.</param>
        /// <param name="policyVersionId">The policy version ID.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetPolicyVersion">REST API Reference for GetPolicyVersion Operation</seealso>
        public virtual Task<GetPolicyVersionResponse> GetPolicyVersionAsync(string policyName, string policyVersionId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetPolicyVersionRequest();
            request.PolicyName = policyName;
            request.PolicyVersionId = policyVersionId;
            return GetPolicyVersionAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetPolicyVersion">REST API Reference for GetPolicyVersion Operation</seealso>
        public virtual Task<GetPolicyVersionResponse> GetPolicyVersionAsync(GetPolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPolicyVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRegistrationCode


        /// <summary>
        /// Gets a registration code used to register a CA certificate with AWS IoT.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegistrationCode service method.</param>
        /// 
        /// <returns>The response from the GetRegistrationCode service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetRegistrationCode">REST API Reference for GetRegistrationCode Operation</seealso>
        public virtual GetRegistrationCodeResponse GetRegistrationCode(GetRegistrationCodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegistrationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegistrationCodeResponseUnmarshaller.Instance;

            return Invoke<GetRegistrationCodeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRegistrationCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRegistrationCode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetRegistrationCode">REST API Reference for GetRegistrationCode Operation</seealso>
        public virtual Task<GetRegistrationCodeResponse> GetRegistrationCodeAsync(GetRegistrationCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegistrationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegistrationCodeResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRegistrationCodeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTopicRule


        /// <summary>
        /// Gets information about the rule.
        /// </summary>
        /// <param name="ruleName">The name of the rule.</param>
        /// 
        /// <returns>The response from the GetTopicRule service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetTopicRule">REST API Reference for GetTopicRule Operation</seealso>
        public virtual GetTopicRuleResponse GetTopicRule(string ruleName)
        {
            var request = new GetTopicRuleRequest();
            request.RuleName = ruleName;
            return GetTopicRule(request);
        }


        /// <summary>
        /// Gets information about the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTopicRule service method.</param>
        /// 
        /// <returns>The response from the GetTopicRule service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetTopicRule">REST API Reference for GetTopicRule Operation</seealso>
        public virtual GetTopicRuleResponse GetTopicRule(GetTopicRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTopicRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTopicRuleResponseUnmarshaller.Instance;

            return Invoke<GetTopicRuleResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the rule.
        /// </summary>
        /// <param name="ruleName">The name of the rule.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTopicRule service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetTopicRule">REST API Reference for GetTopicRule Operation</seealso>
        public virtual Task<GetTopicRuleResponse> GetTopicRuleAsync(string ruleName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetTopicRuleRequest();
            request.RuleName = ruleName;
            return GetTopicRuleAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTopicRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTopicRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetTopicRule">REST API Reference for GetTopicRule Operation</seealso>
        public virtual Task<GetTopicRuleResponse> GetTopicRuleAsync(GetTopicRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTopicRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTopicRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetTopicRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetV2LoggingOptions


        /// <summary>
        /// Gets the fine grained logging options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetV2LoggingOptions service method.</param>
        /// 
        /// <returns>The response from the GetV2LoggingOptions service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.NotConfiguredException">
        /// The resource is not configured.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetV2LoggingOptions">REST API Reference for GetV2LoggingOptions Operation</seealso>
        public virtual GetV2LoggingOptionsResponse GetV2LoggingOptions(GetV2LoggingOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetV2LoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetV2LoggingOptionsResponseUnmarshaller.Instance;

            return Invoke<GetV2LoggingOptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetV2LoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetV2LoggingOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetV2LoggingOptions">REST API Reference for GetV2LoggingOptions Operation</seealso>
        public virtual Task<GetV2LoggingOptionsResponse> GetV2LoggingOptionsAsync(GetV2LoggingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetV2LoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetV2LoggingOptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetV2LoggingOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListActiveViolations


        /// <summary>
        /// Lists the active violations for a given Device Defender security profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActiveViolations service method.</param>
        /// 
        /// <returns>The response from the ListActiveViolations service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListActiveViolations">REST API Reference for ListActiveViolations Operation</seealso>
        public virtual ListActiveViolationsResponse ListActiveViolations(ListActiveViolationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListActiveViolationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActiveViolationsResponseUnmarshaller.Instance;

            return Invoke<ListActiveViolationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListActiveViolations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListActiveViolations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListActiveViolations">REST API Reference for ListActiveViolations Operation</seealso>
        public virtual Task<ListActiveViolationsResponse> ListActiveViolationsAsync(ListActiveViolationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListActiveViolationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActiveViolationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListActiveViolationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAttachedPolicies


        /// <summary>
        /// Lists the policies attached to the specified thing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedPolicies service method.</param>
        /// 
        /// <returns>The response from the ListAttachedPolicies service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAttachedPolicies">REST API Reference for ListAttachedPolicies Operation</seealso>
        public virtual ListAttachedPoliciesResponse ListAttachedPolicies(ListAttachedPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttachedPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachedPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListAttachedPoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAttachedPolicies">REST API Reference for ListAttachedPolicies Operation</seealso>
        public virtual Task<ListAttachedPoliciesResponse> ListAttachedPoliciesAsync(ListAttachedPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttachedPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachedPoliciesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAttachedPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAuditFindings


        /// <summary>
        /// Lists the findings (results) of a Device Defender audit or of the audits performed
        /// during a specified time period. (Findings are retained for 180 days.)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAuditFindings service method.</param>
        /// 
        /// <returns>The response from the ListAuditFindings service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuditFindings">REST API Reference for ListAuditFindings Operation</seealso>
        public virtual ListAuditFindingsResponse ListAuditFindings(ListAuditFindingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAuditFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAuditFindingsResponseUnmarshaller.Instance;

            return Invoke<ListAuditFindingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAuditFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAuditFindings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuditFindings">REST API Reference for ListAuditFindings Operation</seealso>
        public virtual Task<ListAuditFindingsResponse> ListAuditFindingsAsync(ListAuditFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAuditFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAuditFindingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAuditFindingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAuditTasks


        /// <summary>
        /// Lists the Device Defender audits that have been performed during a given time period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAuditTasks service method.</param>
        /// 
        /// <returns>The response from the ListAuditTasks service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuditTasks">REST API Reference for ListAuditTasks Operation</seealso>
        public virtual ListAuditTasksResponse ListAuditTasks(ListAuditTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAuditTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAuditTasksResponseUnmarshaller.Instance;

            return Invoke<ListAuditTasksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAuditTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAuditTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuditTasks">REST API Reference for ListAuditTasks Operation</seealso>
        public virtual Task<ListAuditTasksResponse> ListAuditTasksAsync(ListAuditTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAuditTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAuditTasksResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAuditTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAuthorizers


        /// <summary>
        /// Lists the authorizers registered in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAuthorizers service method.</param>
        /// 
        /// <returns>The response from the ListAuthorizers service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuthorizers">REST API Reference for ListAuthorizers Operation</seealso>
        public virtual ListAuthorizersResponse ListAuthorizers(ListAuthorizersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAuthorizersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAuthorizersResponseUnmarshaller.Instance;

            return Invoke<ListAuthorizersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAuthorizers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAuthorizers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuthorizers">REST API Reference for ListAuthorizers Operation</seealso>
        public virtual Task<ListAuthorizersResponse> ListAuthorizersAsync(ListAuthorizersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAuthorizersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAuthorizersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAuthorizersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBillingGroups


        /// <summary>
        /// Lists the billing groups you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillingGroups service method.</param>
        /// 
        /// <returns>The response from the ListBillingGroups service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListBillingGroups">REST API Reference for ListBillingGroups Operation</seealso>
        public virtual ListBillingGroupsResponse ListBillingGroups(ListBillingGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBillingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillingGroupsResponseUnmarshaller.Instance;

            return Invoke<ListBillingGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBillingGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBillingGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListBillingGroups">REST API Reference for ListBillingGroups Operation</seealso>
        public virtual Task<ListBillingGroupsResponse> ListBillingGroupsAsync(ListBillingGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBillingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillingGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBillingGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCACertificates


        /// <summary>
        /// Lists the CA certificates registered for your AWS account.
        /// 
        ///  
        /// <para>
        /// The results are paginated with a default page size of 25. You can use the returned
        /// marker to retrieve additional results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCACertificates service method.</param>
        /// 
        /// <returns>The response from the ListCACertificates service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListCACertificates">REST API Reference for ListCACertificates Operation</seealso>
        public virtual ListCACertificatesResponse ListCACertificates(ListCACertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCACertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCACertificatesResponseUnmarshaller.Instance;

            return Invoke<ListCACertificatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCACertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCACertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListCACertificates">REST API Reference for ListCACertificates Operation</seealso>
        public virtual Task<ListCACertificatesResponse> ListCACertificatesAsync(ListCACertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCACertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCACertificatesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCACertificatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCertificates


        /// <summary>
        /// Lists the certificates registered in your AWS account.
        /// 
        ///  
        /// <para>
        /// The results are paginated with a default page size of 25. You can use the returned
        /// marker to retrieve additional results.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        public virtual ListCertificatesResponse ListCertificates()
        {
            var request = new ListCertificatesRequest();
            return ListCertificates(request);
        }


        /// <summary>
        /// Lists the certificates registered in your AWS account.
        /// 
        ///  
        /// <para>
        /// The results are paginated with a default page size of 25. You can use the returned
        /// marker to retrieve additional results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificates service method.</param>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        public virtual ListCertificatesResponse ListCertificates(ListCertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCertificatesResponseUnmarshaller.Instance;

            return Invoke<ListCertificatesResponse>(request, options);
        }


        /// <summary>
        /// Lists the certificates registered in your AWS account.
        /// 
        ///  
        /// <para>
        /// The results are paginated with a default page size of 25. You can use the returned
        /// marker to retrieve additional results.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        public virtual Task<ListCertificatesResponse> ListCertificatesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListCertificatesRequest();
            return ListCertificatesAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        public virtual Task<ListCertificatesResponse> ListCertificatesAsync(ListCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCertificatesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCertificatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCertificatesByCA


        /// <summary>
        /// List the device certificates signed by the specified CA certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificatesByCA service method.</param>
        /// 
        /// <returns>The response from the ListCertificatesByCA service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListCertificatesByCA">REST API Reference for ListCertificatesByCA Operation</seealso>
        public virtual ListCertificatesByCAResponse ListCertificatesByCA(ListCertificatesByCARequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCertificatesByCARequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCertificatesByCAResponseUnmarshaller.Instance;

            return Invoke<ListCertificatesByCAResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCertificatesByCA operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCertificatesByCA operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListCertificatesByCA">REST API Reference for ListCertificatesByCA Operation</seealso>
        public virtual Task<ListCertificatesByCAResponse> ListCertificatesByCAAsync(ListCertificatesByCARequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCertificatesByCARequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCertificatesByCAResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCertificatesByCAResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListIndices


        /// <summary>
        /// Lists the search indices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIndices service method.</param>
        /// 
        /// <returns>The response from the ListIndices service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListIndices">REST API Reference for ListIndices Operation</seealso>
        public virtual ListIndicesResponse ListIndices(ListIndicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIndicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIndicesResponseUnmarshaller.Instance;

            return Invoke<ListIndicesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIndices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIndices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListIndices">REST API Reference for ListIndices Operation</seealso>
        public virtual Task<ListIndicesResponse> ListIndicesAsync(ListIndicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIndicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIndicesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListIndicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListJobExecutionsForJob


        /// <summary>
        /// Lists the job executions for a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobExecutionsForJob service method.</param>
        /// 
        /// <returns>The response from the ListJobExecutionsForJob service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListJobExecutionsForJob">REST API Reference for ListJobExecutionsForJob Operation</seealso>
        public virtual ListJobExecutionsForJobResponse ListJobExecutionsForJob(ListJobExecutionsForJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobExecutionsForJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobExecutionsForJobResponseUnmarshaller.Instance;

            return Invoke<ListJobExecutionsForJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobExecutionsForJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobExecutionsForJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListJobExecutionsForJob">REST API Reference for ListJobExecutionsForJob Operation</seealso>
        public virtual Task<ListJobExecutionsForJobResponse> ListJobExecutionsForJobAsync(ListJobExecutionsForJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobExecutionsForJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobExecutionsForJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListJobExecutionsForJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListJobExecutionsForThing


        /// <summary>
        /// Lists the job executions for the specified thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobExecutionsForThing service method.</param>
        /// 
        /// <returns>The response from the ListJobExecutionsForThing service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListJobExecutionsForThing">REST API Reference for ListJobExecutionsForThing Operation</seealso>
        public virtual ListJobExecutionsForThingResponse ListJobExecutionsForThing(ListJobExecutionsForThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobExecutionsForThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobExecutionsForThingResponseUnmarshaller.Instance;

            return Invoke<ListJobExecutionsForThingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobExecutionsForThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobExecutionsForThing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListJobExecutionsForThing">REST API Reference for ListJobExecutionsForThing Operation</seealso>
        public virtual Task<ListJobExecutionsForThingResponse> ListJobExecutionsForThingAsync(ListJobExecutionsForThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobExecutionsForThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobExecutionsForThingResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListJobExecutionsForThingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListJobs


        /// <summary>
        /// Lists jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOTAUpdates


        /// <summary>
        /// Lists OTA updates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOTAUpdates service method.</param>
        /// 
        /// <returns>The response from the ListOTAUpdates service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListOTAUpdates">REST API Reference for ListOTAUpdates Operation</seealso>
        public virtual ListOTAUpdatesResponse ListOTAUpdates(ListOTAUpdatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOTAUpdatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOTAUpdatesResponseUnmarshaller.Instance;

            return Invoke<ListOTAUpdatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOTAUpdates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOTAUpdates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListOTAUpdates">REST API Reference for ListOTAUpdates Operation</seealso>
        public virtual Task<ListOTAUpdatesResponse> ListOTAUpdatesAsync(ListOTAUpdatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOTAUpdatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOTAUpdatesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListOTAUpdatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOutgoingCertificates


        /// <summary>
        /// Lists certificates that are being transferred but not yet accepted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOutgoingCertificates service method.</param>
        /// 
        /// <returns>The response from the ListOutgoingCertificates service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListOutgoingCertificates">REST API Reference for ListOutgoingCertificates Operation</seealso>
        public virtual ListOutgoingCertificatesResponse ListOutgoingCertificates(ListOutgoingCertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOutgoingCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOutgoingCertificatesResponseUnmarshaller.Instance;

            return Invoke<ListOutgoingCertificatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOutgoingCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOutgoingCertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListOutgoingCertificates">REST API Reference for ListOutgoingCertificates Operation</seealso>
        public virtual Task<ListOutgoingCertificatesResponse> ListOutgoingCertificatesAsync(ListOutgoingCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOutgoingCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOutgoingCertificatesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListOutgoingCertificatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPolicies


        /// <summary>
        /// Lists your policies.
        /// </summary>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public virtual ListPoliciesResponse ListPolicies()
        {
            var request = new ListPoliciesRequest();
            return ListPolicies(request);
        }


        /// <summary>
        /// Lists your policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public virtual ListPoliciesResponse ListPolicies(ListPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListPoliciesResponse>(request, options);
        }


        /// <summary>
        /// Lists your policies.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public virtual Task<ListPoliciesResponse> ListPoliciesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListPoliciesRequest();
            return ListPoliciesAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public virtual Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPolicyPrincipals


        /// <summary>
        /// Lists the principals associated with the specified policy.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This API is deprecated. Please use <a>ListTargetsForPolicy</a> instead.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyPrincipals service method.</param>
        /// 
        /// <returns>The response from the ListPolicyPrincipals service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPolicyPrincipals">REST API Reference for ListPolicyPrincipals Operation</seealso>
        [Obsolete("Deprecated in favor of ListTargetsForPolicy.")]
        public virtual ListPolicyPrincipalsResponse ListPolicyPrincipals(ListPolicyPrincipalsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPolicyPrincipalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyPrincipalsResponseUnmarshaller.Instance;

            return Invoke<ListPolicyPrincipalsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicyPrincipals operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyPrincipals operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPolicyPrincipals">REST API Reference for ListPolicyPrincipals Operation</seealso>
        [Obsolete("Deprecated in favor of ListTargetsForPolicy.")]
        public virtual Task<ListPolicyPrincipalsResponse> ListPolicyPrincipalsAsync(ListPolicyPrincipalsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPolicyPrincipalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyPrincipalsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPolicyPrincipalsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPolicyVersions


        /// <summary>
        /// Lists the versions of the specified policy and identifies the default version.
        /// </summary>
        /// <param name="policyName">The policy name.</param>
        /// 
        /// <returns>The response from the ListPolicyVersions service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPolicyVersions">REST API Reference for ListPolicyVersions Operation</seealso>
        public virtual ListPolicyVersionsResponse ListPolicyVersions(string policyName)
        {
            var request = new ListPolicyVersionsRequest();
            request.PolicyName = policyName;
            return ListPolicyVersions(request);
        }


        /// <summary>
        /// Lists the versions of the specified policy and identifies the default version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyVersions service method.</param>
        /// 
        /// <returns>The response from the ListPolicyVersions service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPolicyVersions">REST API Reference for ListPolicyVersions Operation</seealso>
        public virtual ListPolicyVersionsResponse ListPolicyVersions(ListPolicyVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPolicyVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyVersionsResponseUnmarshaller.Instance;

            return Invoke<ListPolicyVersionsResponse>(request, options);
        }


        /// <summary>
        /// Lists the versions of the specified policy and identifies the default version.
        /// </summary>
        /// <param name="policyName">The policy name.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicyVersions service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPolicyVersions">REST API Reference for ListPolicyVersions Operation</seealso>
        public virtual Task<ListPolicyVersionsResponse> ListPolicyVersionsAsync(string policyName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListPolicyVersionsRequest();
            request.PolicyName = policyName;
            return ListPolicyVersionsAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicyVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPolicyVersions">REST API Reference for ListPolicyVersions Operation</seealso>
        public virtual Task<ListPolicyVersionsResponse> ListPolicyVersionsAsync(ListPolicyVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPolicyVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyVersionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPolicyVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPrincipalPolicies


        /// <summary>
        /// Lists the policies attached to the specified principal. If you use an Cognito identity,
        /// the ID must be in <a href="http://docs.aws.amazon.com/cognitoidentity/latest/APIReference/API_GetCredentialsForIdentity.html#API_GetCredentialsForIdentity_RequestSyntax">AmazonCognito
        /// Identity format</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This API is deprecated. Please use <a>ListAttachedPolicies</a> instead.
        /// </para>
        /// </summary>
        /// <param name="principal">The principal.</param>
        /// 
        /// <returns>The response from the ListPrincipalPolicies service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPrincipalPolicies">REST API Reference for ListPrincipalPolicies Operation</seealso>
        [Obsolete("Deprecated in favor of ListAttachedPolicies.")]
        public virtual ListPrincipalPoliciesResponse ListPrincipalPolicies(string principal)
        {
            var request = new ListPrincipalPoliciesRequest();
            request.Principal = principal;
            return ListPrincipalPolicies(request);
        }


        /// <summary>
        /// Lists the policies attached to the specified principal. If you use an Cognito identity,
        /// the ID must be in <a href="http://docs.aws.amazon.com/cognitoidentity/latest/APIReference/API_GetCredentialsForIdentity.html#API_GetCredentialsForIdentity_RequestSyntax">AmazonCognito
        /// Identity format</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This API is deprecated. Please use <a>ListAttachedPolicies</a> instead.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipalPolicies service method.</param>
        /// 
        /// <returns>The response from the ListPrincipalPolicies service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPrincipalPolicies">REST API Reference for ListPrincipalPolicies Operation</seealso>
        [Obsolete("Deprecated in favor of ListAttachedPolicies.")]
        public virtual ListPrincipalPoliciesResponse ListPrincipalPolicies(ListPrincipalPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPrincipalPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrincipalPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListPrincipalPoliciesResponse>(request, options);
        }


        /// <summary>
        /// Lists the policies attached to the specified principal. If you use an Cognito identity,
        /// the ID must be in <a href="http://docs.aws.amazon.com/cognitoidentity/latest/APIReference/API_GetCredentialsForIdentity.html#API_GetCredentialsForIdentity_RequestSyntax">AmazonCognito
        /// Identity format</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This API is deprecated. Please use <a>ListAttachedPolicies</a> instead.
        /// </para>
        /// </summary>
        /// <param name="principal">The principal.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPrincipalPolicies service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPrincipalPolicies">REST API Reference for ListPrincipalPolicies Operation</seealso>
        [Obsolete("Deprecated in favor of ListAttachedPolicies.")]
        public virtual Task<ListPrincipalPoliciesResponse> ListPrincipalPoliciesAsync(string principal, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListPrincipalPoliciesRequest();
            request.Principal = principal;
            return ListPrincipalPoliciesAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPrincipalPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipalPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPrincipalPolicies">REST API Reference for ListPrincipalPolicies Operation</seealso>
        [Obsolete("Deprecated in favor of ListAttachedPolicies.")]
        public virtual Task<ListPrincipalPoliciesResponse> ListPrincipalPoliciesAsync(ListPrincipalPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPrincipalPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrincipalPoliciesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPrincipalPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPrincipalThings


        /// <summary>
        /// Lists the things associated with the specified principal.
        /// </summary>
        /// <param name="principal">The principal.</param>
        /// 
        /// <returns>The response from the ListPrincipalThings service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPrincipalThings">REST API Reference for ListPrincipalThings Operation</seealso>
        public virtual ListPrincipalThingsResponse ListPrincipalThings(string principal)
        {
            var request = new ListPrincipalThingsRequest();
            request.Principal = principal;
            return ListPrincipalThings(request);
        }


        /// <summary>
        /// Lists the things associated with the specified principal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipalThings service method.</param>
        /// 
        /// <returns>The response from the ListPrincipalThings service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPrincipalThings">REST API Reference for ListPrincipalThings Operation</seealso>
        public virtual ListPrincipalThingsResponse ListPrincipalThings(ListPrincipalThingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPrincipalThingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrincipalThingsResponseUnmarshaller.Instance;

            return Invoke<ListPrincipalThingsResponse>(request, options);
        }


        /// <summary>
        /// Lists the things associated with the specified principal.
        /// </summary>
        /// <param name="principal">The principal.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPrincipalThings service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPrincipalThings">REST API Reference for ListPrincipalThings Operation</seealso>
        public virtual Task<ListPrincipalThingsResponse> ListPrincipalThingsAsync(string principal, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListPrincipalThingsRequest();
            request.Principal = principal;
            return ListPrincipalThingsAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPrincipalThings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipalThings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPrincipalThings">REST API Reference for ListPrincipalThings Operation</seealso>
        public virtual Task<ListPrincipalThingsResponse> ListPrincipalThingsAsync(ListPrincipalThingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPrincipalThingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrincipalThingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPrincipalThingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRoleAliases


        /// <summary>
        /// Lists the role aliases registered in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoleAliases service method.</param>
        /// 
        /// <returns>The response from the ListRoleAliases service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListRoleAliases">REST API Reference for ListRoleAliases Operation</seealso>
        public virtual ListRoleAliasesResponse ListRoleAliases(ListRoleAliasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRoleAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoleAliasesResponseUnmarshaller.Instance;

            return Invoke<ListRoleAliasesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRoleAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoleAliases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListRoleAliases">REST API Reference for ListRoleAliases Operation</seealso>
        public virtual Task<ListRoleAliasesResponse> ListRoleAliasesAsync(ListRoleAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRoleAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoleAliasesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRoleAliasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListScheduledAudits


        /// <summary>
        /// Lists all of your scheduled audits.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScheduledAudits service method.</param>
        /// 
        /// <returns>The response from the ListScheduledAudits service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListScheduledAudits">REST API Reference for ListScheduledAudits Operation</seealso>
        public virtual ListScheduledAuditsResponse ListScheduledAudits(ListScheduledAuditsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListScheduledAuditsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScheduledAuditsResponseUnmarshaller.Instance;

            return Invoke<ListScheduledAuditsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListScheduledAudits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListScheduledAudits operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListScheduledAudits">REST API Reference for ListScheduledAudits Operation</seealso>
        public virtual Task<ListScheduledAuditsResponse> ListScheduledAuditsAsync(ListScheduledAuditsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListScheduledAuditsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScheduledAuditsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListScheduledAuditsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSecurityProfiles


        /// <summary>
        /// Lists the Device Defender security profiles you have created. You can use filters
        /// to list only those security profiles associated with a thing group or only those associated
        /// with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityProfiles service method.</param>
        /// 
        /// <returns>The response from the ListSecurityProfiles service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListSecurityProfiles">REST API Reference for ListSecurityProfiles Operation</seealso>
        public virtual ListSecurityProfilesResponse ListSecurityProfiles(ListSecurityProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityProfilesResponseUnmarshaller.Instance;

            return Invoke<ListSecurityProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSecurityProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityProfiles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListSecurityProfiles">REST API Reference for ListSecurityProfiles Operation</seealso>
        public virtual Task<ListSecurityProfilesResponse> ListSecurityProfilesAsync(ListSecurityProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityProfilesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSecurityProfilesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSecurityProfilesForTarget


        /// <summary>
        /// Lists the Device Defender security profiles attached to a target (thing group).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityProfilesForTarget service method.</param>
        /// 
        /// <returns>The response from the ListSecurityProfilesForTarget service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListSecurityProfilesForTarget">REST API Reference for ListSecurityProfilesForTarget Operation</seealso>
        public virtual ListSecurityProfilesForTargetResponse ListSecurityProfilesForTarget(ListSecurityProfilesForTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityProfilesForTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityProfilesForTargetResponseUnmarshaller.Instance;

            return Invoke<ListSecurityProfilesForTargetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSecurityProfilesForTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityProfilesForTarget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListSecurityProfilesForTarget">REST API Reference for ListSecurityProfilesForTarget Operation</seealso>
        public virtual Task<ListSecurityProfilesForTargetResponse> ListSecurityProfilesForTargetAsync(ListSecurityProfilesForTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityProfilesForTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityProfilesForTargetResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSecurityProfilesForTargetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStreams


        /// <summary>
        /// Lists all of the streams in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreams service method.</param>
        /// 
        /// <returns>The response from the ListStreams service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListStreams">REST API Reference for ListStreams Operation</seealso>
        public virtual ListStreamsResponse ListStreams(ListStreamsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamsResponseUnmarshaller.Instance;

            return Invoke<ListStreamsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreams operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListStreams">REST API Reference for ListStreams Operation</seealso>
        public virtual Task<ListStreamsResponse> ListStreamsAsync(ListStreamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListStreamsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags (metadata) you have assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTargetsForPolicy


        /// <summary>
        /// List targets for the specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetsForPolicy service method.</param>
        /// 
        /// <returns>The response from the ListTargetsForPolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTargetsForPolicy">REST API Reference for ListTargetsForPolicy Operation</seealso>
        public virtual ListTargetsForPolicyResponse ListTargetsForPolicy(ListTargetsForPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTargetsForPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetsForPolicyResponseUnmarshaller.Instance;

            return Invoke<ListTargetsForPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTargetsForPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTargetsForPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTargetsForPolicy">REST API Reference for ListTargetsForPolicy Operation</seealso>
        public virtual Task<ListTargetsForPolicyResponse> ListTargetsForPolicyAsync(ListTargetsForPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTargetsForPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetsForPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTargetsForPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTargetsForSecurityProfile


        /// <summary>
        /// Lists the targets (thing groups) associated with a given Device Defender security
        /// profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetsForSecurityProfile service method.</param>
        /// 
        /// <returns>The response from the ListTargetsForSecurityProfile service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTargetsForSecurityProfile">REST API Reference for ListTargetsForSecurityProfile Operation</seealso>
        public virtual ListTargetsForSecurityProfileResponse ListTargetsForSecurityProfile(ListTargetsForSecurityProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTargetsForSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetsForSecurityProfileResponseUnmarshaller.Instance;

            return Invoke<ListTargetsForSecurityProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTargetsForSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTargetsForSecurityProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTargetsForSecurityProfile">REST API Reference for ListTargetsForSecurityProfile Operation</seealso>
        public virtual Task<ListTargetsForSecurityProfileResponse> ListTargetsForSecurityProfileAsync(ListTargetsForSecurityProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTargetsForSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetsForSecurityProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTargetsForSecurityProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListThingGroups


        /// <summary>
        /// List the thing groups in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThingGroups service method.</param>
        /// 
        /// <returns>The response from the ListThingGroups service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingGroups">REST API Reference for ListThingGroups Operation</seealso>
        public virtual ListThingGroupsResponse ListThingGroups(ListThingGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingGroupsResponseUnmarshaller.Instance;

            return Invoke<ListThingGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListThingGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThingGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingGroups">REST API Reference for ListThingGroups Operation</seealso>
        public virtual Task<ListThingGroupsResponse> ListThingGroupsAsync(ListThingGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListThingGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListThingGroupsForThing


        /// <summary>
        /// List the thing groups to which the specified thing belongs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThingGroupsForThing service method.</param>
        /// 
        /// <returns>The response from the ListThingGroupsForThing service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingGroupsForThing">REST API Reference for ListThingGroupsForThing Operation</seealso>
        public virtual ListThingGroupsForThingResponse ListThingGroupsForThing(ListThingGroupsForThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingGroupsForThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingGroupsForThingResponseUnmarshaller.Instance;

            return Invoke<ListThingGroupsForThingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListThingGroupsForThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThingGroupsForThing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingGroupsForThing">REST API Reference for ListThingGroupsForThing Operation</seealso>
        public virtual Task<ListThingGroupsForThingResponse> ListThingGroupsForThingAsync(ListThingGroupsForThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingGroupsForThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingGroupsForThingResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListThingGroupsForThingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListThingPrincipals


        /// <summary>
        /// Lists the principals associated with the specified thing.
        /// </summary>
        /// <param name="thingName">The name of the thing.</param>
        /// 
        /// <returns>The response from the ListThingPrincipals service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingPrincipals">REST API Reference for ListThingPrincipals Operation</seealso>
        public virtual ListThingPrincipalsResponse ListThingPrincipals(string thingName)
        {
            var request = new ListThingPrincipalsRequest();
            request.ThingName = thingName;
            return ListThingPrincipals(request);
        }


        /// <summary>
        /// Lists the principals associated with the specified thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThingPrincipals service method.</param>
        /// 
        /// <returns>The response from the ListThingPrincipals service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingPrincipals">REST API Reference for ListThingPrincipals Operation</seealso>
        public virtual ListThingPrincipalsResponse ListThingPrincipals(ListThingPrincipalsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingPrincipalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingPrincipalsResponseUnmarshaller.Instance;

            return Invoke<ListThingPrincipalsResponse>(request, options);
        }


        /// <summary>
        /// Lists the principals associated with the specified thing.
        /// </summary>
        /// <param name="thingName">The name of the thing.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListThingPrincipals service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingPrincipals">REST API Reference for ListThingPrincipals Operation</seealso>
        public virtual Task<ListThingPrincipalsResponse> ListThingPrincipalsAsync(string thingName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListThingPrincipalsRequest();
            request.ThingName = thingName;
            return ListThingPrincipalsAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListThingPrincipals operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThingPrincipals operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingPrincipals">REST API Reference for ListThingPrincipals Operation</seealso>
        public virtual Task<ListThingPrincipalsResponse> ListThingPrincipalsAsync(ListThingPrincipalsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingPrincipalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingPrincipalsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListThingPrincipalsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListThingRegistrationTaskReports


        /// <summary>
        /// Information about the thing registration tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThingRegistrationTaskReports service method.</param>
        /// 
        /// <returns>The response from the ListThingRegistrationTaskReports service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingRegistrationTaskReports">REST API Reference for ListThingRegistrationTaskReports Operation</seealso>
        public virtual ListThingRegistrationTaskReportsResponse ListThingRegistrationTaskReports(ListThingRegistrationTaskReportsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingRegistrationTaskReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingRegistrationTaskReportsResponseUnmarshaller.Instance;

            return Invoke<ListThingRegistrationTaskReportsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListThingRegistrationTaskReports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThingRegistrationTaskReports operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingRegistrationTaskReports">REST API Reference for ListThingRegistrationTaskReports Operation</seealso>
        public virtual Task<ListThingRegistrationTaskReportsResponse> ListThingRegistrationTaskReportsAsync(ListThingRegistrationTaskReportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingRegistrationTaskReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingRegistrationTaskReportsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListThingRegistrationTaskReportsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListThingRegistrationTasks


        /// <summary>
        /// List bulk thing provisioning tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThingRegistrationTasks service method.</param>
        /// 
        /// <returns>The response from the ListThingRegistrationTasks service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingRegistrationTasks">REST API Reference for ListThingRegistrationTasks Operation</seealso>
        public virtual ListThingRegistrationTasksResponse ListThingRegistrationTasks(ListThingRegistrationTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingRegistrationTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingRegistrationTasksResponseUnmarshaller.Instance;

            return Invoke<ListThingRegistrationTasksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListThingRegistrationTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThingRegistrationTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingRegistrationTasks">REST API Reference for ListThingRegistrationTasks Operation</seealso>
        public virtual Task<ListThingRegistrationTasksResponse> ListThingRegistrationTasksAsync(ListThingRegistrationTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingRegistrationTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingRegistrationTasksResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListThingRegistrationTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListThings


        /// <summary>
        /// Lists your things. Use the <b>attributeName</b> and <b>attributeValue</b> parameters
        /// to filter your things. For example, calling <code>ListThings</code> with attributeName=Color
        /// and attributeValue=Red retrieves all things in the registry that contain an attribute
        /// <b>Color</b> with the value <b>Red</b>.
        /// </summary>
        /// 
        /// <returns>The response from the ListThings service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThings">REST API Reference for ListThings Operation</seealso>
        public virtual ListThingsResponse ListThings()
        {
            var request = new ListThingsRequest();
            return ListThings(request);
        }


        /// <summary>
        /// Lists your things. Use the <b>attributeName</b> and <b>attributeValue</b> parameters
        /// to filter your things. For example, calling <code>ListThings</code> with attributeName=Color
        /// and attributeValue=Red retrieves all things in the registry that contain an attribute
        /// <b>Color</b> with the value <b>Red</b>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThings service method.</param>
        /// 
        /// <returns>The response from the ListThings service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThings">REST API Reference for ListThings Operation</seealso>
        public virtual ListThingsResponse ListThings(ListThingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingsResponseUnmarshaller.Instance;

            return Invoke<ListThingsResponse>(request, options);
        }


        /// <summary>
        /// Lists your things. Use the <b>attributeName</b> and <b>attributeValue</b> parameters
        /// to filter your things. For example, calling <code>ListThings</code> with attributeName=Color
        /// and attributeValue=Red retrieves all things in the registry that contain an attribute
        /// <b>Color</b> with the value <b>Red</b>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListThings service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThings">REST API Reference for ListThings Operation</seealso>
        public virtual Task<ListThingsResponse> ListThingsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListThingsRequest();
            return ListThingsAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListThings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThings">REST API Reference for ListThings Operation</seealso>
        public virtual Task<ListThingsResponse> ListThingsAsync(ListThingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListThingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListThingsInBillingGroup


        /// <summary>
        /// Lists the things you have added to the given billing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThingsInBillingGroup service method.</param>
        /// 
        /// <returns>The response from the ListThingsInBillingGroup service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingsInBillingGroup">REST API Reference for ListThingsInBillingGroup Operation</seealso>
        public virtual ListThingsInBillingGroupResponse ListThingsInBillingGroup(ListThingsInBillingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingsInBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingsInBillingGroupResponseUnmarshaller.Instance;

            return Invoke<ListThingsInBillingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListThingsInBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThingsInBillingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingsInBillingGroup">REST API Reference for ListThingsInBillingGroup Operation</seealso>
        public virtual Task<ListThingsInBillingGroupResponse> ListThingsInBillingGroupAsync(ListThingsInBillingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingsInBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingsInBillingGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListThingsInBillingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListThingsInThingGroup


        /// <summary>
        /// Lists the things in the specified group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThingsInThingGroup service method.</param>
        /// 
        /// <returns>The response from the ListThingsInThingGroup service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingsInThingGroup">REST API Reference for ListThingsInThingGroup Operation</seealso>
        public virtual ListThingsInThingGroupResponse ListThingsInThingGroup(ListThingsInThingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingsInThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingsInThingGroupResponseUnmarshaller.Instance;

            return Invoke<ListThingsInThingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListThingsInThingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThingsInThingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingsInThingGroup">REST API Reference for ListThingsInThingGroup Operation</seealso>
        public virtual Task<ListThingsInThingGroupResponse> ListThingsInThingGroupAsync(ListThingsInThingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingsInThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingsInThingGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListThingsInThingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListThingTypes


        /// <summary>
        /// Lists the existing thing types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThingTypes service method.</param>
        /// 
        /// <returns>The response from the ListThingTypes service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingTypes">REST API Reference for ListThingTypes Operation</seealso>
        public virtual ListThingTypesResponse ListThingTypes(ListThingTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingTypesResponseUnmarshaller.Instance;

            return Invoke<ListThingTypesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListThingTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThingTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingTypes">REST API Reference for ListThingTypes Operation</seealso>
        public virtual Task<ListThingTypesResponse> ListThingTypesAsync(ListThingTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingTypesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListThingTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTopicRules


        /// <summary>
        /// Lists the rules for the specific topic.
        /// </summary>
        /// <param name="topic">The topic.</param>
        /// 
        /// <returns>The response from the ListTopicRules service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTopicRules">REST API Reference for ListTopicRules Operation</seealso>
        public virtual ListTopicRulesResponse ListTopicRules(string topic)
        {
            var request = new ListTopicRulesRequest();
            request.Topic = topic;
            return ListTopicRules(request);
        }


        /// <summary>
        /// Lists the rules for the specific topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTopicRules service method.</param>
        /// 
        /// <returns>The response from the ListTopicRules service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTopicRules">REST API Reference for ListTopicRules Operation</seealso>
        public virtual ListTopicRulesResponse ListTopicRules(ListTopicRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTopicRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTopicRulesResponseUnmarshaller.Instance;

            return Invoke<ListTopicRulesResponse>(request, options);
        }


        /// <summary>
        /// Lists the rules for the specific topic.
        /// </summary>
        /// <param name="topic">The topic.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTopicRules service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTopicRules">REST API Reference for ListTopicRules Operation</seealso>
        public virtual Task<ListTopicRulesResponse> ListTopicRulesAsync(string topic, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListTopicRulesRequest();
            request.Topic = topic;
            return ListTopicRulesAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTopicRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTopicRules operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTopicRules">REST API Reference for ListTopicRules Operation</seealso>
        public virtual Task<ListTopicRulesResponse> ListTopicRulesAsync(ListTopicRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTopicRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTopicRulesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTopicRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListV2LoggingLevels


        /// <summary>
        /// Lists logging levels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListV2LoggingLevels service method.</param>
        /// 
        /// <returns>The response from the ListV2LoggingLevels service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.NotConfiguredException">
        /// The resource is not configured.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListV2LoggingLevels">REST API Reference for ListV2LoggingLevels Operation</seealso>
        public virtual ListV2LoggingLevelsResponse ListV2LoggingLevels(ListV2LoggingLevelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListV2LoggingLevelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListV2LoggingLevelsResponseUnmarshaller.Instance;

            return Invoke<ListV2LoggingLevelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListV2LoggingLevels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListV2LoggingLevels operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListV2LoggingLevels">REST API Reference for ListV2LoggingLevels Operation</seealso>
        public virtual Task<ListV2LoggingLevelsResponse> ListV2LoggingLevelsAsync(ListV2LoggingLevelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListV2LoggingLevelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListV2LoggingLevelsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListV2LoggingLevelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListViolationEvents


        /// <summary>
        /// Lists the Device Defender security profile violations discovered during the given
        /// time period. You can use filters to limit the results to those alerts issued for a
        /// particular security profile, behavior or thing (device).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListViolationEvents service method.</param>
        /// 
        /// <returns>The response from the ListViolationEvents service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListViolationEvents">REST API Reference for ListViolationEvents Operation</seealso>
        public virtual ListViolationEventsResponse ListViolationEvents(ListViolationEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListViolationEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListViolationEventsResponseUnmarshaller.Instance;

            return Invoke<ListViolationEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListViolationEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListViolationEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListViolationEvents">REST API Reference for ListViolationEvents Operation</seealso>
        public virtual Task<ListViolationEventsResponse> ListViolationEventsAsync(ListViolationEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListViolationEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListViolationEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListViolationEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterCACertificate


        /// <summary>
        /// Registers a CA certificate with AWS IoT. This CA certificate can then be used to sign
        /// device certificates, which can be then registered with AWS IoT. You can register up
        /// to 10 CA certificates per AWS account that have the same subject field. This enables
        /// you to have up to 10 certificate authorities sign your device certificates. If you
        /// have more than one CA certificate registered, make sure you pass the CA certificate
        /// when you register your device certificates with the RegisterCertificate API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterCACertificate service method.</param>
        /// 
        /// <returns>The response from the RegisterCACertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.CertificateValidationException">
        /// The certificate is invalid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.RegistrationCodeValidationException">
        /// The registration code is invalid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RegisterCACertificate">REST API Reference for RegisterCACertificate Operation</seealso>
        public virtual RegisterCACertificateResponse RegisterCACertificate(RegisterCACertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterCACertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterCACertificateResponseUnmarshaller.Instance;

            return Invoke<RegisterCACertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterCACertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterCACertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RegisterCACertificate">REST API Reference for RegisterCACertificate Operation</seealso>
        public virtual Task<RegisterCACertificateResponse> RegisterCACertificateAsync(RegisterCACertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterCACertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterCACertificateResponseUnmarshaller.Instance;
            
            return InvokeAsync<RegisterCACertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterCertificate


        /// <summary>
        /// Registers a device certificate with AWS IoT. If you have more than one CA certificate
        /// that has the same subject field, you must specify the CA certificate that was used
        /// to sign the device certificate being registered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterCertificate service method.</param>
        /// 
        /// <returns>The response from the RegisterCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.CertificateConflictException">
        /// Unable to verify the CA certificate used to sign the device certificate you are attempting
        /// to register. This is happens when you have registered more than one CA certificate
        /// that has the same subject field and public key.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.CertificateStateException">
        /// The certificate operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.CertificateValidationException">
        /// The certificate is invalid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RegisterCertificate">REST API Reference for RegisterCertificate Operation</seealso>
        public virtual RegisterCertificateResponse RegisterCertificate(RegisterCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterCertificateResponseUnmarshaller.Instance;

            return Invoke<RegisterCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RegisterCertificate">REST API Reference for RegisterCertificate Operation</seealso>
        public virtual Task<RegisterCertificateResponse> RegisterCertificateAsync(RegisterCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterCertificateResponseUnmarshaller.Instance;
            
            return InvokeAsync<RegisterCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterThing


        /// <summary>
        /// Provisions a thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterThing service method.</param>
        /// 
        /// <returns>The response from the RegisterThing service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.ConflictingResourceUpdateException">
        /// A conflicting resource update exception. This exception is thrown when two pending
        /// updates cause a conflict.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceRegistrationFailureException">
        /// The resource registration failed.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RegisterThing">REST API Reference for RegisterThing Operation</seealso>
        public virtual RegisterThingResponse RegisterThing(RegisterThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterThingResponseUnmarshaller.Instance;

            return Invoke<RegisterThingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterThing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RegisterThing">REST API Reference for RegisterThing Operation</seealso>
        public virtual Task<RegisterThingResponse> RegisterThingAsync(RegisterThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterThingResponseUnmarshaller.Instance;
            
            return InvokeAsync<RegisterThingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectCertificateTransfer


        /// <summary>
        /// Rejects a pending certificate transfer. After AWS IoT rejects a certificate transfer,
        /// the certificate status changes from <b>PENDING_TRANSFER</b> to <b>INACTIVE</b>.
        /// 
        ///  
        /// <para>
        /// To check for pending certificate transfers, call <a>ListCertificates</a> to enumerate
        /// your certificates.
        /// </para>
        ///  
        /// <para>
        /// This operation can only be called by the transfer destination. After it is called,
        /// the certificate will be returned to the source's account in the INACTIVE state.
        /// </para>
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// 
        /// <returns>The response from the RejectCertificateTransfer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.TransferAlreadyCompletedException">
        /// You can't revert the certificate transfer because the transfer is already complete.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RejectCertificateTransfer">REST API Reference for RejectCertificateTransfer Operation</seealso>
        public virtual RejectCertificateTransferResponse RejectCertificateTransfer(string certificateId)
        {
            var request = new RejectCertificateTransferRequest();
            request.CertificateId = certificateId;
            return RejectCertificateTransfer(request);
        }


        /// <summary>
        /// Rejects a pending certificate transfer. After AWS IoT rejects a certificate transfer,
        /// the certificate status changes from <b>PENDING_TRANSFER</b> to <b>INACTIVE</b>.
        /// 
        ///  
        /// <para>
        /// To check for pending certificate transfers, call <a>ListCertificates</a> to enumerate
        /// your certificates.
        /// </para>
        ///  
        /// <para>
        /// This operation can only be called by the transfer destination. After it is called,
        /// the certificate will be returned to the source's account in the INACTIVE state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectCertificateTransfer service method.</param>
        /// 
        /// <returns>The response from the RejectCertificateTransfer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.TransferAlreadyCompletedException">
        /// You can't revert the certificate transfer because the transfer is already complete.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RejectCertificateTransfer">REST API Reference for RejectCertificateTransfer Operation</seealso>
        public virtual RejectCertificateTransferResponse RejectCertificateTransfer(RejectCertificateTransferRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectCertificateTransferRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectCertificateTransferResponseUnmarshaller.Instance;

            return Invoke<RejectCertificateTransferResponse>(request, options);
        }


        /// <summary>
        /// Rejects a pending certificate transfer. After AWS IoT rejects a certificate transfer,
        /// the certificate status changes from <b>PENDING_TRANSFER</b> to <b>INACTIVE</b>.
        /// 
        ///  
        /// <para>
        /// To check for pending certificate transfers, call <a>ListCertificates</a> to enumerate
        /// your certificates.
        /// </para>
        ///  
        /// <para>
        /// This operation can only be called by the transfer destination. After it is called,
        /// the certificate will be returned to the source's account in the INACTIVE state.
        /// </para>
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectCertificateTransfer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.TransferAlreadyCompletedException">
        /// You can't revert the certificate transfer because the transfer is already complete.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RejectCertificateTransfer">REST API Reference for RejectCertificateTransfer Operation</seealso>
        public virtual Task<RejectCertificateTransferResponse> RejectCertificateTransferAsync(string certificateId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RejectCertificateTransferRequest();
            request.CertificateId = certificateId;
            return RejectCertificateTransferAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RejectCertificateTransfer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectCertificateTransfer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RejectCertificateTransfer">REST API Reference for RejectCertificateTransfer Operation</seealso>
        public virtual Task<RejectCertificateTransferResponse> RejectCertificateTransferAsync(RejectCertificateTransferRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectCertificateTransferRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectCertificateTransferResponseUnmarshaller.Instance;
            
            return InvokeAsync<RejectCertificateTransferResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveThingFromBillingGroup


        /// <summary>
        /// Removes the given thing from the billing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveThingFromBillingGroup service method.</param>
        /// 
        /// <returns>The response from the RemoveThingFromBillingGroup service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RemoveThingFromBillingGroup">REST API Reference for RemoveThingFromBillingGroup Operation</seealso>
        public virtual RemoveThingFromBillingGroupResponse RemoveThingFromBillingGroup(RemoveThingFromBillingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveThingFromBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveThingFromBillingGroupResponseUnmarshaller.Instance;

            return Invoke<RemoveThingFromBillingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveThingFromBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveThingFromBillingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RemoveThingFromBillingGroup">REST API Reference for RemoveThingFromBillingGroup Operation</seealso>
        public virtual Task<RemoveThingFromBillingGroupResponse> RemoveThingFromBillingGroupAsync(RemoveThingFromBillingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveThingFromBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveThingFromBillingGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<RemoveThingFromBillingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveThingFromThingGroup


        /// <summary>
        /// Remove the specified thing from the specified group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveThingFromThingGroup service method.</param>
        /// 
        /// <returns>The response from the RemoveThingFromThingGroup service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RemoveThingFromThingGroup">REST API Reference for RemoveThingFromThingGroup Operation</seealso>
        public virtual RemoveThingFromThingGroupResponse RemoveThingFromThingGroup(RemoveThingFromThingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveThingFromThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveThingFromThingGroupResponseUnmarshaller.Instance;

            return Invoke<RemoveThingFromThingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveThingFromThingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveThingFromThingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RemoveThingFromThingGroup">REST API Reference for RemoveThingFromThingGroup Operation</seealso>
        public virtual Task<RemoveThingFromThingGroupResponse> RemoveThingFromThingGroupAsync(RemoveThingFromThingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveThingFromThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveThingFromThingGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<RemoveThingFromThingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReplaceTopicRule


        /// <summary>
        /// Replaces the rule. You must specify all parameters for the new rule. Creating rules
        /// is an administrator-level action. Any user who has permission to create rules will
        /// be able to access data processed by the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceTopicRule service method.</param>
        /// 
        /// <returns>The response from the ReplaceTopicRule service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.ConflictingResourceUpdateException">
        /// A conflicting resource update exception. This exception is thrown when two pending
        /// updates cause a conflict.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.SqlParseException">
        /// The Rule-SQL expression can't be parsed correctly.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ReplaceTopicRule">REST API Reference for ReplaceTopicRule Operation</seealso>
        public virtual ReplaceTopicRuleResponse ReplaceTopicRule(ReplaceTopicRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceTopicRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceTopicRuleResponseUnmarshaller.Instance;

            return Invoke<ReplaceTopicRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceTopicRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceTopicRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ReplaceTopicRule">REST API Reference for ReplaceTopicRule Operation</seealso>
        public virtual Task<ReplaceTopicRuleResponse> ReplaceTopicRuleAsync(ReplaceTopicRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceTopicRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceTopicRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<ReplaceTopicRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchIndex


        /// <summary>
        /// The query search index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchIndex service method.</param>
        /// 
        /// <returns>The response from the SearchIndex service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.IndexNotReadyException">
        /// The index is not ready.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidQueryException">
        /// The query is invalid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SearchIndex">REST API Reference for SearchIndex Operation</seealso>
        public virtual SearchIndexResponse SearchIndex(SearchIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchIndexResponseUnmarshaller.Instance;

            return Invoke<SearchIndexResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchIndex operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SearchIndex">REST API Reference for SearchIndex Operation</seealso>
        public virtual Task<SearchIndexResponse> SearchIndexAsync(SearchIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchIndexResponseUnmarshaller.Instance;
            
            return InvokeAsync<SearchIndexResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetDefaultAuthorizer


        /// <summary>
        /// Sets the default authorizer. This will be used if a websocket connection is made without
        /// specifying an authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultAuthorizer service method.</param>
        /// 
        /// <returns>The response from the SetDefaultAuthorizer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetDefaultAuthorizer">REST API Reference for SetDefaultAuthorizer Operation</seealso>
        public virtual SetDefaultAuthorizerResponse SetDefaultAuthorizer(SetDefaultAuthorizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetDefaultAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDefaultAuthorizerResponseUnmarshaller.Instance;

            return Invoke<SetDefaultAuthorizerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetDefaultAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetDefaultAuthorizer">REST API Reference for SetDefaultAuthorizer Operation</seealso>
        public virtual Task<SetDefaultAuthorizerResponse> SetDefaultAuthorizerAsync(SetDefaultAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetDefaultAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDefaultAuthorizerResponseUnmarshaller.Instance;
            
            return InvokeAsync<SetDefaultAuthorizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetDefaultPolicyVersion


        /// <summary>
        /// Sets the specified version of the specified policy as the policy's default (operative)
        /// version. This action affects all certificates to which the policy is attached. To
        /// list the principals the policy is attached to, use the ListPrincipalPolicy API.
        /// </summary>
        /// <param name="policyName">The policy name.</param>
        /// <param name="policyVersionId">The policy version ID.</param>
        /// 
        /// <returns>The response from the SetDefaultPolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetDefaultPolicyVersion">REST API Reference for SetDefaultPolicyVersion Operation</seealso>
        public virtual SetDefaultPolicyVersionResponse SetDefaultPolicyVersion(string policyName, string policyVersionId)
        {
            var request = new SetDefaultPolicyVersionRequest();
            request.PolicyName = policyName;
            request.PolicyVersionId = policyVersionId;
            return SetDefaultPolicyVersion(request);
        }


        /// <summary>
        /// Sets the specified version of the specified policy as the policy's default (operative)
        /// version. This action affects all certificates to which the policy is attached. To
        /// list the principals the policy is attached to, use the ListPrincipalPolicy API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultPolicyVersion service method.</param>
        /// 
        /// <returns>The response from the SetDefaultPolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetDefaultPolicyVersion">REST API Reference for SetDefaultPolicyVersion Operation</seealso>
        public virtual SetDefaultPolicyVersionResponse SetDefaultPolicyVersion(SetDefaultPolicyVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetDefaultPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDefaultPolicyVersionResponseUnmarshaller.Instance;

            return Invoke<SetDefaultPolicyVersionResponse>(request, options);
        }


        /// <summary>
        /// Sets the specified version of the specified policy as the policy's default (operative)
        /// version. This action affects all certificates to which the policy is attached. To
        /// list the principals the policy is attached to, use the ListPrincipalPolicy API.
        /// </summary>
        /// <param name="policyName">The policy name.</param>
        /// <param name="policyVersionId">The policy version ID.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetDefaultPolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetDefaultPolicyVersion">REST API Reference for SetDefaultPolicyVersion Operation</seealso>
        public virtual Task<SetDefaultPolicyVersionResponse> SetDefaultPolicyVersionAsync(string policyName, string policyVersionId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new SetDefaultPolicyVersionRequest();
            request.PolicyName = policyName;
            request.PolicyVersionId = policyVersionId;
            return SetDefaultPolicyVersionAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetDefaultPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultPolicyVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetDefaultPolicyVersion">REST API Reference for SetDefaultPolicyVersion Operation</seealso>
        public virtual Task<SetDefaultPolicyVersionResponse> SetDefaultPolicyVersionAsync(SetDefaultPolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetDefaultPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDefaultPolicyVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<SetDefaultPolicyVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetLoggingOptions


        /// <summary>
        /// Sets the logging options.
        /// 
        ///  
        /// <para>
        /// NOTE: use of this command is not recommended. Use <code>SetV2LoggingOptions</code>
        /// instead.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetLoggingOptions service method.</param>
        /// 
        /// <returns>The response from the SetLoggingOptions service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetLoggingOptions">REST API Reference for SetLoggingOptions Operation</seealso>
        public virtual SetLoggingOptionsResponse SetLoggingOptions(SetLoggingOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetLoggingOptionsResponseUnmarshaller.Instance;

            return Invoke<SetLoggingOptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoggingOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetLoggingOptions">REST API Reference for SetLoggingOptions Operation</seealso>
        public virtual Task<SetLoggingOptionsResponse> SetLoggingOptionsAsync(SetLoggingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetLoggingOptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<SetLoggingOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetV2LoggingLevel


        /// <summary>
        /// Sets the logging level.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetV2LoggingLevel service method.</param>
        /// 
        /// <returns>The response from the SetV2LoggingLevel service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.NotConfiguredException">
        /// The resource is not configured.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetV2LoggingLevel">REST API Reference for SetV2LoggingLevel Operation</seealso>
        public virtual SetV2LoggingLevelResponse SetV2LoggingLevel(SetV2LoggingLevelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetV2LoggingLevelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetV2LoggingLevelResponseUnmarshaller.Instance;

            return Invoke<SetV2LoggingLevelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetV2LoggingLevel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetV2LoggingLevel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetV2LoggingLevel">REST API Reference for SetV2LoggingLevel Operation</seealso>
        public virtual Task<SetV2LoggingLevelResponse> SetV2LoggingLevelAsync(SetV2LoggingLevelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetV2LoggingLevelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetV2LoggingLevelResponseUnmarshaller.Instance;
            
            return InvokeAsync<SetV2LoggingLevelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetV2LoggingOptions


        /// <summary>
        /// Sets the logging options for the V2 logging service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetV2LoggingOptions service method.</param>
        /// 
        /// <returns>The response from the SetV2LoggingOptions service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetV2LoggingOptions">REST API Reference for SetV2LoggingOptions Operation</seealso>
        public virtual SetV2LoggingOptionsResponse SetV2LoggingOptions(SetV2LoggingOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetV2LoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetV2LoggingOptionsResponseUnmarshaller.Instance;

            return Invoke<SetV2LoggingOptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetV2LoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetV2LoggingOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetV2LoggingOptions">REST API Reference for SetV2LoggingOptions Operation</seealso>
        public virtual Task<SetV2LoggingOptionsResponse> SetV2LoggingOptionsAsync(SetV2LoggingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetV2LoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetV2LoggingOptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<SetV2LoggingOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartOnDemandAuditTask


        /// <summary>
        /// Starts an on-demand Device Defender audit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartOnDemandAuditTask service method.</param>
        /// 
        /// <returns>The response from the StartOnDemandAuditTask service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/StartOnDemandAuditTask">REST API Reference for StartOnDemandAuditTask Operation</seealso>
        public virtual StartOnDemandAuditTaskResponse StartOnDemandAuditTask(StartOnDemandAuditTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartOnDemandAuditTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartOnDemandAuditTaskResponseUnmarshaller.Instance;

            return Invoke<StartOnDemandAuditTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartOnDemandAuditTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartOnDemandAuditTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/StartOnDemandAuditTask">REST API Reference for StartOnDemandAuditTask Operation</seealso>
        public virtual Task<StartOnDemandAuditTaskResponse> StartOnDemandAuditTaskAsync(StartOnDemandAuditTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartOnDemandAuditTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartOnDemandAuditTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartOnDemandAuditTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartThingRegistrationTask


        /// <summary>
        /// Creates a bulk thing provisioning task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartThingRegistrationTask service method.</param>
        /// 
        /// <returns>The response from the StartThingRegistrationTask service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/StartThingRegistrationTask">REST API Reference for StartThingRegistrationTask Operation</seealso>
        public virtual StartThingRegistrationTaskResponse StartThingRegistrationTask(StartThingRegistrationTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartThingRegistrationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartThingRegistrationTaskResponseUnmarshaller.Instance;

            return Invoke<StartThingRegistrationTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartThingRegistrationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartThingRegistrationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/StartThingRegistrationTask">REST API Reference for StartThingRegistrationTask Operation</seealso>
        public virtual Task<StartThingRegistrationTaskResponse> StartThingRegistrationTaskAsync(StartThingRegistrationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartThingRegistrationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartThingRegistrationTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartThingRegistrationTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopThingRegistrationTask


        /// <summary>
        /// Cancels a bulk thing provisioning task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopThingRegistrationTask service method.</param>
        /// 
        /// <returns>The response from the StopThingRegistrationTask service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/StopThingRegistrationTask">REST API Reference for StopThingRegistrationTask Operation</seealso>
        public virtual StopThingRegistrationTaskResponse StopThingRegistrationTask(StopThingRegistrationTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopThingRegistrationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopThingRegistrationTaskResponseUnmarshaller.Instance;

            return Invoke<StopThingRegistrationTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopThingRegistrationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopThingRegistrationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/StopThingRegistrationTask">REST API Reference for StopThingRegistrationTask Operation</seealso>
        public virtual Task<StopThingRegistrationTaskResponse> StopThingRegistrationTaskAsync(StopThingRegistrationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopThingRegistrationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopThingRegistrationTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopThingRegistrationTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds to or modifies the tags of the given resource. Tags are metadata which can be
        /// used to manage a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TestAuthorization


        /// <summary>
        /// Tests if a specified principal is authorized to perform an AWS IoT action on a specified
        /// resource. Use this to test and debug the authorization behavior of devices that connect
        /// to the AWS IoT device gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestAuthorization service method.</param>
        /// 
        /// <returns>The response from the TestAuthorization service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TestAuthorization">REST API Reference for TestAuthorization Operation</seealso>
        public virtual TestAuthorizationResponse TestAuthorization(TestAuthorizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestAuthorizationResponseUnmarshaller.Instance;

            return Invoke<TestAuthorizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestAuthorization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TestAuthorization">REST API Reference for TestAuthorization Operation</seealso>
        public virtual Task<TestAuthorizationResponse> TestAuthorizationAsync(TestAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestAuthorizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<TestAuthorizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TestInvokeAuthorizer


        /// <summary>
        /// Tests a custom authorization behavior by invoking a specified custom authorizer. Use
        /// this to test and debug the custom authorization behavior of devices that connect to
        /// the AWS IoT device gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestInvokeAuthorizer service method.</param>
        /// 
        /// <returns>The response from the TestInvokeAuthorizer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidResponseException">
        /// The response is invalid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TestInvokeAuthorizer">REST API Reference for TestInvokeAuthorizer Operation</seealso>
        public virtual TestInvokeAuthorizerResponse TestInvokeAuthorizer(TestInvokeAuthorizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestInvokeAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestInvokeAuthorizerResponseUnmarshaller.Instance;

            return Invoke<TestInvokeAuthorizerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestInvokeAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestInvokeAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TestInvokeAuthorizer">REST API Reference for TestInvokeAuthorizer Operation</seealso>
        public virtual Task<TestInvokeAuthorizerResponse> TestInvokeAuthorizerAsync(TestInvokeAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestInvokeAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestInvokeAuthorizerResponseUnmarshaller.Instance;
            
            return InvokeAsync<TestInvokeAuthorizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TransferCertificate


        /// <summary>
        /// Transfers the specified certificate to the specified AWS account.
        /// 
        ///  
        /// <para>
        /// You can cancel the transfer until it is acknowledged by the recipient.
        /// </para>
        ///  
        /// <para>
        /// No notification is sent to the transfer destination's account. It is up to the caller
        /// to notify the transfer target.
        /// </para>
        ///  
        /// <para>
        /// The certificate being transferred must not be in the ACTIVE state. You can use the
        /// UpdateCertificate API to deactivate it.
        /// </para>
        ///  
        /// <para>
        /// The certificate must not have any policies attached to it. You can use the DetachPrincipalPolicy
        /// API to detach them.
        /// </para>
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// <param name="targetAwsAccount">The AWS account.</param>
        /// 
        /// <returns>The response from the TransferCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.CertificateStateException">
        /// The certificate operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.TransferConflictException">
        /// You can't transfer the certificate because authorization policies are still attached.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TransferCertificate">REST API Reference for TransferCertificate Operation</seealso>
        public virtual TransferCertificateResponse TransferCertificate(string certificateId, string targetAwsAccount)
        {
            var request = new TransferCertificateRequest();
            request.CertificateId = certificateId;
            request.TargetAwsAccount = targetAwsAccount;
            return TransferCertificate(request);
        }


        /// <summary>
        /// Transfers the specified certificate to the specified AWS account.
        /// 
        ///  
        /// <para>
        /// You can cancel the transfer until it is acknowledged by the recipient.
        /// </para>
        ///  
        /// <para>
        /// No notification is sent to the transfer destination's account. It is up to the caller
        /// to notify the transfer target.
        /// </para>
        ///  
        /// <para>
        /// The certificate being transferred must not be in the ACTIVE state. You can use the
        /// UpdateCertificate API to deactivate it.
        /// </para>
        ///  
        /// <para>
        /// The certificate must not have any policies attached to it. You can use the DetachPrincipalPolicy
        /// API to detach them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TransferCertificate service method.</param>
        /// 
        /// <returns>The response from the TransferCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.CertificateStateException">
        /// The certificate operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.TransferConflictException">
        /// You can't transfer the certificate because authorization policies are still attached.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TransferCertificate">REST API Reference for TransferCertificate Operation</seealso>
        public virtual TransferCertificateResponse TransferCertificate(TransferCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TransferCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TransferCertificateResponseUnmarshaller.Instance;

            return Invoke<TransferCertificateResponse>(request, options);
        }


        /// <summary>
        /// Transfers the specified certificate to the specified AWS account.
        /// 
        ///  
        /// <para>
        /// You can cancel the transfer until it is acknowledged by the recipient.
        /// </para>
        ///  
        /// <para>
        /// No notification is sent to the transfer destination's account. It is up to the caller
        /// to notify the transfer target.
        /// </para>
        ///  
        /// <para>
        /// The certificate being transferred must not be in the ACTIVE state. You can use the
        /// UpdateCertificate API to deactivate it.
        /// </para>
        ///  
        /// <para>
        /// The certificate must not have any policies attached to it. You can use the DetachPrincipalPolicy
        /// API to detach them.
        /// </para>
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// <param name="targetAwsAccount">The AWS account.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TransferCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.CertificateStateException">
        /// The certificate operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.TransferConflictException">
        /// You can't transfer the certificate because authorization policies are still attached.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TransferCertificate">REST API Reference for TransferCertificate Operation</seealso>
        public virtual Task<TransferCertificateResponse> TransferCertificateAsync(string certificateId, string targetAwsAccount, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new TransferCertificateRequest();
            request.CertificateId = certificateId;
            request.TargetAwsAccount = targetAwsAccount;
            return TransferCertificateAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TransferCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TransferCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TransferCertificate">REST API Reference for TransferCertificate Operation</seealso>
        public virtual Task<TransferCertificateResponse> TransferCertificateAsync(TransferCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TransferCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TransferCertificateResponseUnmarshaller.Instance;
            
            return InvokeAsync<TransferCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the given tags (metadata) from the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAccountAuditConfiguration


        /// <summary>
        /// Configures or reconfigures the Device Defender audit settings for this account. Settings
        /// include how audit notifications are sent and which audit checks are enabled or disabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountAuditConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateAccountAuditConfiguration service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateAccountAuditConfiguration">REST API Reference for UpdateAccountAuditConfiguration Operation</seealso>
        public virtual UpdateAccountAuditConfigurationResponse UpdateAccountAuditConfiguration(UpdateAccountAuditConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountAuditConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountAuditConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountAuditConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountAuditConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountAuditConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateAccountAuditConfiguration">REST API Reference for UpdateAccountAuditConfiguration Operation</seealso>
        public virtual Task<UpdateAccountAuditConfigurationResponse> UpdateAccountAuditConfigurationAsync(UpdateAccountAuditConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountAuditConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountAuditConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAccountAuditConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAuthorizer


        /// <summary>
        /// Updates an authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthorizer service method.</param>
        /// 
        /// <returns>The response from the UpdateAuthorizer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateAuthorizer">REST API Reference for UpdateAuthorizer Operation</seealso>
        public virtual UpdateAuthorizerResponse UpdateAuthorizer(UpdateAuthorizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuthorizerResponseUnmarshaller.Instance;

            return Invoke<UpdateAuthorizerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateAuthorizer">REST API Reference for UpdateAuthorizer Operation</seealso>
        public virtual Task<UpdateAuthorizerResponse> UpdateAuthorizerAsync(UpdateAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuthorizerResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAuthorizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateBillingGroup


        /// <summary>
        /// Updates information about the billing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBillingGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateBillingGroup service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateBillingGroup">REST API Reference for UpdateBillingGroup Operation</seealso>
        public virtual UpdateBillingGroupResponse UpdateBillingGroup(UpdateBillingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBillingGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateBillingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBillingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateBillingGroup">REST API Reference for UpdateBillingGroup Operation</seealso>
        public virtual Task<UpdateBillingGroupResponse> UpdateBillingGroupAsync(UpdateBillingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBillingGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateBillingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCACertificate


        /// <summary>
        /// Updates a registered CA certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCACertificate service method.</param>
        /// 
        /// <returns>The response from the UpdateCACertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateCACertificate">REST API Reference for UpdateCACertificate Operation</seealso>
        public virtual UpdateCACertificateResponse UpdateCACertificate(UpdateCACertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCACertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCACertificateResponseUnmarshaller.Instance;

            return Invoke<UpdateCACertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCACertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCACertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateCACertificate">REST API Reference for UpdateCACertificate Operation</seealso>
        public virtual Task<UpdateCACertificateResponse> UpdateCACertificateAsync(UpdateCACertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCACertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCACertificateResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateCACertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCertificate


        /// <summary>
        /// Updates the status of the specified certificate. This operation is idempotent.
        /// 
        ///  
        /// <para>
        /// Moving a certificate from the ACTIVE state (including REVOKED) will not disconnect
        /// currently connected devices, but these devices will be unable to reconnect.
        /// </para>
        ///  
        /// <para>
        /// The ACTIVE state is required to authenticate devices connecting to AWS IoT using a
        /// certificate.
        /// </para>
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// <param name="newStatus">The new status.  <b>Note:</b> Setting the status to PENDING_TRANSFER will result in an exception being thrown. PENDING_TRANSFER is a status used internally by AWS IoT. It is not intended for developer use.  <b>Note:</b> The status value REGISTER_INACTIVE is deprecated and should not be used.</param>
        /// 
        /// <returns>The response from the UpdateCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.CertificateStateException">
        /// The certificate operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateCertificate">REST API Reference for UpdateCertificate Operation</seealso>
        public virtual UpdateCertificateResponse UpdateCertificate(string certificateId, CertificateStatus newStatus)
        {
            var request = new UpdateCertificateRequest();
            request.CertificateId = certificateId;
            request.NewStatus = newStatus;
            return UpdateCertificate(request);
        }


        /// <summary>
        /// Updates the status of the specified certificate. This operation is idempotent.
        /// 
        ///  
        /// <para>
        /// Moving a certificate from the ACTIVE state (including REVOKED) will not disconnect
        /// currently connected devices, but these devices will be unable to reconnect.
        /// </para>
        ///  
        /// <para>
        /// The ACTIVE state is required to authenticate devices connecting to AWS IoT using a
        /// certificate.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCertificate service method.</param>
        /// 
        /// <returns>The response from the UpdateCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.CertificateStateException">
        /// The certificate operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateCertificate">REST API Reference for UpdateCertificate Operation</seealso>
        public virtual UpdateCertificateResponse UpdateCertificate(UpdateCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCertificateResponseUnmarshaller.Instance;

            return Invoke<UpdateCertificateResponse>(request, options);
        }


        /// <summary>
        /// Updates the status of the specified certificate. This operation is idempotent.
        /// 
        ///  
        /// <para>
        /// Moving a certificate from the ACTIVE state (including REVOKED) will not disconnect
        /// currently connected devices, but these devices will be unable to reconnect.
        /// </para>
        ///  
        /// <para>
        /// The ACTIVE state is required to authenticate devices connecting to AWS IoT using a
        /// certificate.
        /// </para>
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// <param name="newStatus">The new status.  <b>Note:</b> Setting the status to PENDING_TRANSFER will result in an exception being thrown. PENDING_TRANSFER is a status used internally by AWS IoT. It is not intended for developer use.  <b>Note:</b> The status value REGISTER_INACTIVE is deprecated and should not be used.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.CertificateStateException">
        /// The certificate operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateCertificate">REST API Reference for UpdateCertificate Operation</seealso>
        public virtual Task<UpdateCertificateResponse> UpdateCertificateAsync(string certificateId, CertificateStatus newStatus, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdateCertificateRequest();
            request.CertificateId = certificateId;
            request.NewStatus = newStatus;
            return UpdateCertificateAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateCertificate">REST API Reference for UpdateCertificate Operation</seealso>
        public virtual Task<UpdateCertificateResponse> UpdateCertificateAsync(UpdateCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCertificateResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDynamicThingGroup


        /// <summary>
        /// Updates a dynamic thing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDynamicThingGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateDynamicThingGroup service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidQueryException">
        /// The query is invalid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateDynamicThingGroup">REST API Reference for UpdateDynamicThingGroup Operation</seealso>
        public virtual UpdateDynamicThingGroupResponse UpdateDynamicThingGroup(UpdateDynamicThingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDynamicThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDynamicThingGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateDynamicThingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDynamicThingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDynamicThingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateDynamicThingGroup">REST API Reference for UpdateDynamicThingGroup Operation</seealso>
        public virtual Task<UpdateDynamicThingGroupResponse> UpdateDynamicThingGroupAsync(UpdateDynamicThingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDynamicThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDynamicThingGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDynamicThingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEventConfigurations


        /// <summary>
        /// Updates the event configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventConfigurations service method.</param>
        /// 
        /// <returns>The response from the UpdateEventConfigurations service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateEventConfigurations">REST API Reference for UpdateEventConfigurations Operation</seealso>
        public virtual UpdateEventConfigurationsResponse UpdateEventConfigurations(UpdateEventConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventConfigurationsResponseUnmarshaller.Instance;

            return Invoke<UpdateEventConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEventConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateEventConfigurations">REST API Reference for UpdateEventConfigurations Operation</seealso>
        public virtual Task<UpdateEventConfigurationsResponse> UpdateEventConfigurationsAsync(UpdateEventConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateEventConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateIndexingConfiguration


        /// <summary>
        /// Updates the search configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIndexingConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateIndexingConfiguration service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateIndexingConfiguration">REST API Reference for UpdateIndexingConfiguration Operation</seealso>
        public virtual UpdateIndexingConfigurationResponse UpdateIndexingConfiguration(UpdateIndexingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIndexingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIndexingConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateIndexingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIndexingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIndexingConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateIndexingConfiguration">REST API Reference for UpdateIndexingConfiguration Operation</seealso>
        public virtual Task<UpdateIndexingConfigurationResponse> UpdateIndexingConfigurationAsync(UpdateIndexingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIndexingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIndexingConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateIndexingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateJob


        /// <summary>
        /// Updates supported fields of the specified job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob service method.</param>
        /// 
        /// <returns>The response from the UpdateJob service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateJob">REST API Reference for UpdateJob Operation</seealso>
        public virtual UpdateJobResponse UpdateJob(UpdateJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobResponseUnmarshaller.Instance;

            return Invoke<UpdateJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateJob">REST API Reference for UpdateJob Operation</seealso>
        public virtual Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRoleAlias


        /// <summary>
        /// Updates a role alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoleAlias service method.</param>
        /// 
        /// <returns>The response from the UpdateRoleAlias service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateRoleAlias">REST API Reference for UpdateRoleAlias Operation</seealso>
        public virtual UpdateRoleAliasResponse UpdateRoleAlias(UpdateRoleAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoleAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoleAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateRoleAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoleAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoleAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateRoleAlias">REST API Reference for UpdateRoleAlias Operation</seealso>
        public virtual Task<UpdateRoleAliasResponse> UpdateRoleAliasAsync(UpdateRoleAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoleAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoleAliasResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateRoleAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateScheduledAudit


        /// <summary>
        /// Updates a scheduled audit, including what checks are performed and how often the audit
        /// takes place.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScheduledAudit service method.</param>
        /// 
        /// <returns>The response from the UpdateScheduledAudit service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateScheduledAudit">REST API Reference for UpdateScheduledAudit Operation</seealso>
        public virtual UpdateScheduledAuditResponse UpdateScheduledAudit(UpdateScheduledAuditRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateScheduledAuditRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScheduledAuditResponseUnmarshaller.Instance;

            return Invoke<UpdateScheduledAuditResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateScheduledAudit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateScheduledAudit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateScheduledAudit">REST API Reference for UpdateScheduledAudit Operation</seealso>
        public virtual Task<UpdateScheduledAuditResponse> UpdateScheduledAuditAsync(UpdateScheduledAuditRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateScheduledAuditRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScheduledAuditResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateScheduledAuditResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSecurityProfile


        /// <summary>
        /// Updates a Device Defender security profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateSecurityProfile service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateSecurityProfile">REST API Reference for UpdateSecurityProfile Operation</seealso>
        public virtual UpdateSecurityProfileResponse UpdateSecurityProfile(UpdateSecurityProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateSecurityProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateSecurityProfile">REST API Reference for UpdateSecurityProfile Operation</seealso>
        public virtual Task<UpdateSecurityProfileResponse> UpdateSecurityProfileAsync(UpdateSecurityProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSecurityProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateStream


        /// <summary>
        /// Updates an existing stream. The stream version will be incremented by one.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStream service method.</param>
        /// 
        /// <returns>The response from the UpdateStream service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateStream">REST API Reference for UpdateStream Operation</seealso>
        public virtual UpdateStreamResponse UpdateStream(UpdateStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStreamResponseUnmarshaller.Instance;

            return Invoke<UpdateStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateStream">REST API Reference for UpdateStream Operation</seealso>
        public virtual Task<UpdateStreamResponse> UpdateStreamAsync(UpdateStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStreamResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateThing


        /// <summary>
        /// Updates the data for a thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThing service method.</param>
        /// 
        /// <returns>The response from the UpdateThing service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateThing">REST API Reference for UpdateThing Operation</seealso>
        public virtual UpdateThingResponse UpdateThing(UpdateThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThingResponseUnmarshaller.Instance;

            return Invoke<UpdateThingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateThing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateThing">REST API Reference for UpdateThing Operation</seealso>
        public virtual Task<UpdateThingResponse> UpdateThingAsync(UpdateThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThingResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateThingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateThingGroup


        /// <summary>
        /// Update a thing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThingGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateThingGroup service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateThingGroup">REST API Reference for UpdateThingGroup Operation</seealso>
        public virtual UpdateThingGroupResponse UpdateThingGroup(UpdateThingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThingGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateThingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateThingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateThingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateThingGroup">REST API Reference for UpdateThingGroup Operation</seealso>
        public virtual Task<UpdateThingGroupResponse> UpdateThingGroupAsync(UpdateThingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThingGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateThingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateThingGroupsForThing


        /// <summary>
        /// Updates the groups to which the thing belongs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThingGroupsForThing service method.</param>
        /// 
        /// <returns>The response from the UpdateThingGroupsForThing service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateThingGroupsForThing">REST API Reference for UpdateThingGroupsForThing Operation</seealso>
        public virtual UpdateThingGroupsForThingResponse UpdateThingGroupsForThing(UpdateThingGroupsForThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThingGroupsForThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThingGroupsForThingResponseUnmarshaller.Instance;

            return Invoke<UpdateThingGroupsForThingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateThingGroupsForThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateThingGroupsForThing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateThingGroupsForThing">REST API Reference for UpdateThingGroupsForThing Operation</seealso>
        public virtual Task<UpdateThingGroupsForThingResponse> UpdateThingGroupsForThingAsync(UpdateThingGroupsForThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThingGroupsForThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThingGroupsForThingResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateThingGroupsForThingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ValidateSecurityProfileBehaviors


        /// <summary>
        /// Validates a Device Defender security profile behaviors specification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateSecurityProfileBehaviors service method.</param>
        /// 
        /// <returns>The response from the ValidateSecurityProfileBehaviors service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ValidateSecurityProfileBehaviors">REST API Reference for ValidateSecurityProfileBehaviors Operation</seealso>
        public virtual ValidateSecurityProfileBehaviorsResponse ValidateSecurityProfileBehaviors(ValidateSecurityProfileBehaviorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateSecurityProfileBehaviorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateSecurityProfileBehaviorsResponseUnmarshaller.Instance;

            return Invoke<ValidateSecurityProfileBehaviorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ValidateSecurityProfileBehaviors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateSecurityProfileBehaviors operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ValidateSecurityProfileBehaviors">REST API Reference for ValidateSecurityProfileBehaviors Operation</seealso>
        public virtual Task<ValidateSecurityProfileBehaviorsResponse> ValidateSecurityProfileBehaviorsAsync(ValidateSecurityProfileBehaviorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateSecurityProfileBehaviorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateSecurityProfileBehaviorsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ValidateSecurityProfileBehaviorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}