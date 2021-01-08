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
    /// The service endpoints that expose this API are listed in <a href="https://docs.aws.amazon.com/general/latest/gr/iot-core.html">AWS
    /// IoT Core Endpoints and Quotas</a>. You must use the endpoint for the region that has
    /// the resources you want to access.
    /// </para>
    ///  
    /// <para>
    /// The service name used by <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">AWS
    /// Signature Version 4</a> to sign the request is: <i>execute-api</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information about how AWS IoT works, see the <a href="https://docs.aws.amazon.com/iot/latest/developerguide/aws-iot-how-it-works.html">Developer
    /// Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// For information about how to use the credentials provider for AWS IoT, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/authorizing-direct-aws.html">Authorizing
    /// Direct Calls to AWS Services</a>.
    /// </para>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
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
#if AWS_ASYNC_ENUMERABLES_API
        private IIoTPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IIoTPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new IoTPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

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

        internal virtual AcceptCertificateTransferResponse AcceptCertificateTransfer(AcceptCertificateTransferRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptCertificateTransferRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptCertificateTransferResponseUnmarshaller.Instance;

            return Invoke<AcceptCertificateTransferResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AcceptCertificateTransferResponse> AcceptCertificateTransferAsync(AcceptCertificateTransferRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptCertificateTransferRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptCertificateTransferResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptCertificateTransferResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddThingToBillingGroup

        internal virtual AddThingToBillingGroupResponse AddThingToBillingGroup(AddThingToBillingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddThingToBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddThingToBillingGroupResponseUnmarshaller.Instance;

            return Invoke<AddThingToBillingGroupResponse>(request, options);
        }



        /// <summary>
        /// Adds a thing to a billing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddThingToBillingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AddThingToBillingGroupResponse> AddThingToBillingGroupAsync(AddThingToBillingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddThingToBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddThingToBillingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<AddThingToBillingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddThingToThingGroup

        internal virtual AddThingToThingGroupResponse AddThingToThingGroup(AddThingToThingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddThingToThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddThingToThingGroupResponseUnmarshaller.Instance;

            return Invoke<AddThingToThingGroupResponse>(request, options);
        }



        /// <summary>
        /// Adds a thing to a thing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddThingToThingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AddThingToThingGroupResponse> AddThingToThingGroupAsync(AddThingToThingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddThingToThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddThingToThingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<AddThingToThingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateTargetsWithJob

        internal virtual AssociateTargetsWithJobResponse AssociateTargetsWithJob(AssociateTargetsWithJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTargetsWithJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTargetsWithJobResponseUnmarshaller.Instance;

            return Invoke<AssociateTargetsWithJobResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AssociateTargetsWithJobResponse> AssociateTargetsWithJobAsync(AssociateTargetsWithJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTargetsWithJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTargetsWithJobResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateTargetsWithJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachPolicy

        internal virtual AttachPolicyResponse AttachPolicy(AttachPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachPolicyResponseUnmarshaller.Instance;

            return Invoke<AttachPolicyResponse>(request, options);
        }



        /// <summary>
        /// Attaches a policy to the specified target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AttachPolicyResponse> AttachPolicyAsync(AttachPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<AttachPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachPrincipalPolicy

        [Obsolete("Deprecated in favor of AttachPolicy.")]
        internal virtual AttachPrincipalPolicyResponse AttachPrincipalPolicy(AttachPrincipalPolicyRequest request)
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
        /// Attaches the specified policy to the specified principal (certificate or other credential).
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This API is deprecated. Please use <a>AttachPolicy</a> instead.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachPrincipalPolicy service method.</param>
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
        public virtual Task<AttachPrincipalPolicyResponse> AttachPrincipalPolicyAsync(AttachPrincipalPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachPrincipalPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachPrincipalPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<AttachPrincipalPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachSecurityProfile

        internal virtual AttachSecurityProfileResponse AttachSecurityProfile(AttachSecurityProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachSecurityProfileResponseUnmarshaller.Instance;

            return Invoke<AttachSecurityProfileResponse>(request, options);
        }



        /// <summary>
        /// Associates a Device Defender security profile with a thing group or this account.
        /// Each thing group or account can have up to five security profiles associated with
        /// it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachSecurityProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AttachSecurityProfileResponse> AttachSecurityProfileAsync(AttachSecurityProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachSecurityProfileResponseUnmarshaller.Instance;

            return InvokeAsync<AttachSecurityProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachThingPrincipal

        internal virtual AttachThingPrincipalResponse AttachThingPrincipal(AttachThingPrincipalRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachThingPrincipalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachThingPrincipalResponseUnmarshaller.Instance;

            return Invoke<AttachThingPrincipalResponse>(request, options);
        }


        /// <summary>
        /// Attaches the specified principal to the specified thing. A principal can be X.509
        /// certificates, IAM users, groups, and roles, Amazon Cognito identities or federated
        /// identities.
        /// </summary>
        /// <param name="thingName">The name of the thing.</param>
        /// <param name="principal">The principal, which can be a certificate ARN (as returned from the CreateCertificate operation) or an Amazon Cognito ID.</param>
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
        /// Attaches the specified principal to the specified thing. A principal can be X.509
        /// certificates, IAM users, groups, and roles, Amazon Cognito identities or federated
        /// identities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachThingPrincipal service method.</param>
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
        public virtual Task<AttachThingPrincipalResponse> AttachThingPrincipalAsync(AttachThingPrincipalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachThingPrincipalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachThingPrincipalResponseUnmarshaller.Instance;

            return InvokeAsync<AttachThingPrincipalResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelAuditMitigationActionsTask

        internal virtual CancelAuditMitigationActionsTaskResponse CancelAuditMitigationActionsTask(CancelAuditMitigationActionsTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelAuditMitigationActionsTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelAuditMitigationActionsTaskResponseUnmarshaller.Instance;

            return Invoke<CancelAuditMitigationActionsTaskResponse>(request, options);
        }



        /// <summary>
        /// Cancels a mitigation action task that is in progress. If the task is not in progress,
        /// an InvalidRequestException occurs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelAuditMitigationActionsTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelAuditMitigationActionsTask service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelAuditMitigationActionsTask">REST API Reference for CancelAuditMitigationActionsTask Operation</seealso>
        public virtual Task<CancelAuditMitigationActionsTaskResponse> CancelAuditMitigationActionsTaskAsync(CancelAuditMitigationActionsTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelAuditMitigationActionsTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelAuditMitigationActionsTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelAuditMitigationActionsTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelAuditTask

        internal virtual CancelAuditTaskResponse CancelAuditTask(CancelAuditTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelAuditTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelAuditTaskResponseUnmarshaller.Instance;

            return Invoke<CancelAuditTaskResponse>(request, options);
        }



        /// <summary>
        /// Cancels an audit that is in progress. The audit can be either scheduled or on demand.
        /// If the audit isn't in progress, an "InvalidRequestException" occurs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelAuditTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CancelAuditTaskResponse> CancelAuditTaskAsync(CancelAuditTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelAuditTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelAuditTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelAuditTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelCertificateTransfer

        internal virtual CancelCertificateTransferResponse CancelCertificateTransfer(CancelCertificateTransferRequest request)
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
        public virtual Task<CancelCertificateTransferResponse> CancelCertificateTransferAsync(CancelCertificateTransferRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelCertificateTransferRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelCertificateTransferResponseUnmarshaller.Instance;

            return InvokeAsync<CancelCertificateTransferResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelDetectMitigationActionsTask

        internal virtual CancelDetectMitigationActionsTaskResponse CancelDetectMitigationActionsTask(CancelDetectMitigationActionsTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelDetectMitigationActionsTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelDetectMitigationActionsTaskResponseUnmarshaller.Instance;

            return Invoke<CancelDetectMitigationActionsTaskResponse>(request, options);
        }



        /// <summary>
        /// Cancels a Device Defender ML Detect mitigation action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelDetectMitigationActionsTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelDetectMitigationActionsTask service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelDetectMitigationActionsTask">REST API Reference for CancelDetectMitigationActionsTask Operation</seealso>
        public virtual Task<CancelDetectMitigationActionsTaskResponse> CancelDetectMitigationActionsTaskAsync(CancelDetectMitigationActionsTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelDetectMitigationActionsTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelDetectMitigationActionsTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelDetectMitigationActionsTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelJob

        internal virtual CancelJobResponse CancelJob(CancelJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobResponseUnmarshaller.Instance;

            return Invoke<CancelJobResponse>(request, options);
        }



        /// <summary>
        /// Cancels a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobResponseUnmarshaller.Instance;

            return InvokeAsync<CancelJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelJobExecution

        internal virtual CancelJobExecutionResponse CancelJobExecution(CancelJobExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelJobExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobExecutionResponseUnmarshaller.Instance;

            return Invoke<CancelJobExecutionResponse>(request, options);
        }



        /// <summary>
        /// Cancels the execution of a job for a given thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJobExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CancelJobExecutionResponse> CancelJobExecutionAsync(CancelJobExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelJobExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<CancelJobExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ClearDefaultAuthorizer

        internal virtual ClearDefaultAuthorizerResponse ClearDefaultAuthorizer(ClearDefaultAuthorizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ClearDefaultAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ClearDefaultAuthorizerResponseUnmarshaller.Instance;

            return Invoke<ClearDefaultAuthorizerResponse>(request, options);
        }



        /// <summary>
        /// Clears the default authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ClearDefaultAuthorizer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ClearDefaultAuthorizerResponse> ClearDefaultAuthorizerAsync(ClearDefaultAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ClearDefaultAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ClearDefaultAuthorizerResponseUnmarshaller.Instance;

            return InvokeAsync<ClearDefaultAuthorizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConfirmTopicRuleDestination

        internal virtual ConfirmTopicRuleDestinationResponse ConfirmTopicRuleDestination(ConfirmTopicRuleDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmTopicRuleDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmTopicRuleDestinationResponseUnmarshaller.Instance;

            return Invoke<ConfirmTopicRuleDestinationResponse>(request, options);
        }



        /// <summary>
        /// Confirms a topic rule destination. When you create a rule requiring a destination,
        /// AWS IoT sends a confirmation message to the endpoint or base address you specify.
        /// The message includes a token which you pass back when calling <code>ConfirmTopicRuleDestination</code>
        /// to confirm that you own or have access to the endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmTopicRuleDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConfirmTopicRuleDestination service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ConfirmTopicRuleDestination">REST API Reference for ConfirmTopicRuleDestination Operation</seealso>
        public virtual Task<ConfirmTopicRuleDestinationResponse> ConfirmTopicRuleDestinationAsync(ConfirmTopicRuleDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmTopicRuleDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmTopicRuleDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<ConfirmTopicRuleDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAuditSuppression

        internal virtual CreateAuditSuppressionResponse CreateAuditSuppression(CreateAuditSuppressionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAuditSuppressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAuditSuppressionResponseUnmarshaller.Instance;

            return Invoke<CreateAuditSuppressionResponse>(request, options);
        }



        /// <summary>
        /// Creates a Device Defender audit suppression.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAuditSuppression service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAuditSuppression service method, as returned by IoT.</returns>
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
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateAuditSuppression">REST API Reference for CreateAuditSuppression Operation</seealso>
        public virtual Task<CreateAuditSuppressionResponse> CreateAuditSuppressionAsync(CreateAuditSuppressionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAuditSuppressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAuditSuppressionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAuditSuppressionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAuthorizer

        internal virtual CreateAuthorizerResponse CreateAuthorizer(CreateAuthorizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAuthorizerResponseUnmarshaller.Instance;

            return Invoke<CreateAuthorizerResponse>(request, options);
        }



        /// <summary>
        /// Creates an authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthorizer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateAuthorizerResponse> CreateAuthorizerAsync(CreateAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAuthorizerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAuthorizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBillingGroup

        internal virtual CreateBillingGroupResponse CreateBillingGroup(CreateBillingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBillingGroupResponseUnmarshaller.Instance;

            return Invoke<CreateBillingGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a billing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBillingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateBillingGroupResponse> CreateBillingGroupAsync(CreateBillingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBillingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBillingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCertificateFromCsr

        internal virtual CreateCertificateFromCsrResponse CreateCertificateFromCsr(CreateCertificateFromCsrRequest request)
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
        public virtual Task<CreateCertificateFromCsrResponse> CreateCertificateFromCsrAsync(CreateCertificateFromCsrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCertificateFromCsrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCertificateFromCsrResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCertificateFromCsrResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCustomMetric

        internal virtual CreateCustomMetricResponse CreateCustomMetric(CreateCustomMetricRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomMetricRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomMetricResponseUnmarshaller.Instance;

            return Invoke<CreateCustomMetricResponse>(request, options);
        }



        /// <summary>
        /// Use this API to define a Custom Metric published by your devices to Device Defender.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomMetric service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomMetric service method, as returned by IoT.</returns>
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
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateCustomMetric">REST API Reference for CreateCustomMetric Operation</seealso>
        public virtual Task<CreateCustomMetricResponse> CreateCustomMetricAsync(CreateCustomMetricRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomMetricRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomMetricResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCustomMetricResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDimension

        internal virtual CreateDimensionResponse CreateDimension(CreateDimensionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDimensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDimensionResponseUnmarshaller.Instance;

            return Invoke<CreateDimensionResponse>(request, options);
        }



        /// <summary>
        /// Create a dimension that you can use to limit the scope of a metric used in a security
        /// profile for AWS IoT Device Defender. For example, using a <code>TOPIC_FILTER</code>
        /// dimension, you can narrow down the scope of the metric only to MQTT topics whose name
        /// match the pattern specified in the dimension.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDimension service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDimension service method, as returned by IoT.</returns>
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
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateDimension">REST API Reference for CreateDimension Operation</seealso>
        public virtual Task<CreateDimensionResponse> CreateDimensionAsync(CreateDimensionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDimensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDimensionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDimensionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDomainConfiguration

        internal virtual CreateDomainConfigurationResponse CreateDomainConfiguration(CreateDomainConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateDomainConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Creates a domain configuration.
        /// 
        ///  <note> 
        /// <para>
        /// The domain configuration feature is in public preview and is subject to change.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomainConfiguration service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateDomainConfiguration">REST API Reference for CreateDomainConfiguration Operation</seealso>
        public virtual Task<CreateDomainConfigurationResponse> CreateDomainConfigurationAsync(CreateDomainConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDomainConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDynamicThingGroup

        internal virtual CreateDynamicThingGroupResponse CreateDynamicThingGroup(CreateDynamicThingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDynamicThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDynamicThingGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDynamicThingGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a dynamic thing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDynamicThingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateDynamicThingGroupResponse> CreateDynamicThingGroupAsync(CreateDynamicThingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDynamicThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDynamicThingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDynamicThingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateJob

        internal virtual CreateJobResponse CreateJob(CreateJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;

            return Invoke<CreateJobResponse>(request, options);
        }



        /// <summary>
        /// Creates a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateKeysAndCertificate

        internal virtual CreateKeysAndCertificateResponse CreateKeysAndCertificate(CreateKeysAndCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateKeysAndCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeysAndCertificateResponseUnmarshaller.Instance;

            return Invoke<CreateKeysAndCertificateResponse>(request, options);
        }


        /// <summary>
        /// Creates a 2048-bit RSA key pair and issues an X.509 certificate using the issued public
        /// key. You can also call <code>CreateKeysAndCertificate</code> over MQTT from a device,
        /// for more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/provision-wo-cert.html#provision-mqtt-api">Provisioning
        /// MQTT API</a>.
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
        /// key. You can also call <code>CreateKeysAndCertificate</code> over MQTT from a device,
        /// for more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/provision-wo-cert.html#provision-mqtt-api">Provisioning
        /// MQTT API</a>.
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
        /// Creates a 2048-bit RSA key pair and issues an X.509 certificate using the issued public
        /// key. You can also call <code>CreateKeysAndCertificate</code> over MQTT from a device,
        /// for more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/provision-wo-cert.html#provision-mqtt-api">Provisioning
        /// MQTT API</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Note</b> This is the only time AWS IoT issues the private key for this certificate,
        /// so it is important to keep it in a secure location.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKeysAndCertificate service method.</param>
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
        public virtual Task<CreateKeysAndCertificateResponse> CreateKeysAndCertificateAsync(CreateKeysAndCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateKeysAndCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeysAndCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKeysAndCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMitigationAction

        internal virtual CreateMitigationActionResponse CreateMitigationAction(CreateMitigationActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMitigationActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMitigationActionResponseUnmarshaller.Instance;

            return Invoke<CreateMitigationActionResponse>(request, options);
        }



        /// <summary>
        /// Defines an action that can be applied to audit findings by using StartAuditMitigationActionsTask.
        /// Only certain types of mitigation actions can be applied to specific check names. For
        /// more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/device-defender-mitigation-actions.html">Mitigation
        /// actions</a>. Each mitigation action can apply only one type of change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMitigationAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMitigationAction service method, as returned by IoT.</returns>
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
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateMitigationAction">REST API Reference for CreateMitigationAction Operation</seealso>
        public virtual Task<CreateMitigationActionResponse> CreateMitigationActionAsync(CreateMitigationActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMitigationActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMitigationActionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMitigationActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateOTAUpdate

        internal virtual CreateOTAUpdateResponse CreateOTAUpdate(CreateOTAUpdateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOTAUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOTAUpdateResponseUnmarshaller.Instance;

            return Invoke<CreateOTAUpdateResponse>(request, options);
        }



        /// <summary>
        /// Creates an AWS IoT OTAUpdate on a target group of things or groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOTAUpdate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateOTAUpdateResponse> CreateOTAUpdateAsync(CreateOTAUpdateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOTAUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOTAUpdateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOTAUpdateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePolicy

        internal virtual CreatePolicyResponse CreatePolicy(CreatePolicyRequest request)
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
        public virtual Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePolicyVersion

        internal virtual CreatePolicyVersionResponse CreatePolicyVersion(CreatePolicyVersionRequest request)
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
        public virtual Task<CreatePolicyVersionResponse> CreatePolicyVersionAsync(CreatePolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePolicyVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePolicyVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProvisioningClaim

        internal virtual CreateProvisioningClaimResponse CreateProvisioningClaim(CreateProvisioningClaimRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProvisioningClaimRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProvisioningClaimResponseUnmarshaller.Instance;

            return Invoke<CreateProvisioningClaimResponse>(request, options);
        }



        /// <summary>
        /// Creates a provisioning claim.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisioningClaim service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProvisioningClaim service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateProvisioningClaim">REST API Reference for CreateProvisioningClaim Operation</seealso>
        public virtual Task<CreateProvisioningClaimResponse> CreateProvisioningClaimAsync(CreateProvisioningClaimRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProvisioningClaimRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProvisioningClaimResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProvisioningClaimResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProvisioningTemplate

        internal virtual CreateProvisioningTemplateResponse CreateProvisioningTemplate(CreateProvisioningTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProvisioningTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProvisioningTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateProvisioningTemplateResponse>(request, options);
        }



        /// <summary>
        /// Creates a fleet provisioning template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisioningTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProvisioningTemplate service method, as returned by IoT.</returns>
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
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateProvisioningTemplate">REST API Reference for CreateProvisioningTemplate Operation</seealso>
        public virtual Task<CreateProvisioningTemplateResponse> CreateProvisioningTemplateAsync(CreateProvisioningTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProvisioningTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProvisioningTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProvisioningTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProvisioningTemplateVersion

        internal virtual CreateProvisioningTemplateVersionResponse CreateProvisioningTemplateVersion(CreateProvisioningTemplateVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProvisioningTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProvisioningTemplateVersionResponseUnmarshaller.Instance;

            return Invoke<CreateProvisioningTemplateVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates a new version of a fleet provisioning template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisioningTemplateVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProvisioningTemplateVersion service method, as returned by IoT.</returns>
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
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateProvisioningTemplateVersion">REST API Reference for CreateProvisioningTemplateVersion Operation</seealso>
        public virtual Task<CreateProvisioningTemplateVersionResponse> CreateProvisioningTemplateVersionAsync(CreateProvisioningTemplateVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProvisioningTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProvisioningTemplateVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProvisioningTemplateVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRoleAlias

        internal virtual CreateRoleAliasResponse CreateRoleAlias(CreateRoleAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRoleAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoleAliasResponseUnmarshaller.Instance;

            return Invoke<CreateRoleAliasResponse>(request, options);
        }



        /// <summary>
        /// Creates a role alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoleAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateRoleAliasResponse> CreateRoleAliasAsync(CreateRoleAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRoleAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoleAliasResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRoleAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateScheduledAudit

        internal virtual CreateScheduledAuditResponse CreateScheduledAudit(CreateScheduledAuditRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScheduledAuditRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScheduledAuditResponseUnmarshaller.Instance;

            return Invoke<CreateScheduledAuditResponse>(request, options);
        }



        /// <summary>
        /// Creates a scheduled audit that is run at a specified time interval.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScheduledAudit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
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

        internal virtual CreateSecurityProfileResponse CreateSecurityProfile(CreateSecurityProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityProfileResponseUnmarshaller.Instance;

            return Invoke<CreateSecurityProfileResponse>(request, options);
        }



        /// <summary>
        /// Creates a Device Defender security profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateSecurityProfileResponse> CreateSecurityProfileAsync(CreateSecurityProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSecurityProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateStream

        internal virtual CreateStreamResponse CreateStream(CreateStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamResponseUnmarshaller.Instance;

            return Invoke<CreateStreamResponse>(request, options);
        }



        /// <summary>
        /// Creates a stream for delivering one or more large files in chunks over MQTT. A stream
        /// transports data bytes in chunks or blocks packaged as MQTT messages from a source
        /// like S3. You can have one or more files associated with a stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateStreamResponse> CreateStreamAsync(CreateStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateThing

        internal virtual CreateThingResponse CreateThing(CreateThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThingResponseUnmarshaller.Instance;

            return Invoke<CreateThingResponse>(request, options);
        }



        /// <summary>
        /// Creates a thing record in the registry. If this call is made multiple times using
        /// the same thing name and configuration, the call will succeed. If this call is made
        /// with the same thing name but different configuration a <code>ResourceAlreadyExistsException</code>
        /// is thrown.
        /// 
        ///  <note> 
        /// <para>
        /// This is a control plane operation. See <a href="https://docs.aws.amazon.com/iot/latest/developerguide/iot-authorization.html">Authorization</a>
        /// for information about authorizing control plane actions.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateThing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateThingResponse> CreateThingAsync(CreateThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThingResponseUnmarshaller.Instance;

            return InvokeAsync<CreateThingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateThingGroup

        internal virtual CreateThingGroupResponse CreateThingGroup(CreateThingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThingGroupResponseUnmarshaller.Instance;

            return Invoke<CreateThingGroupResponse>(request, options);
        }



        /// <summary>
        /// Create a thing group.
        /// 
        ///  <note> 
        /// <para>
        /// This is a control plane operation. See <a href="https://docs.aws.amazon.com/iot/latest/developerguide/iot-authorization.html">Authorization</a>
        /// for information about authorizing control plane actions.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateThingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateThingGroupResponse> CreateThingGroupAsync(CreateThingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateThingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateThingType

        internal virtual CreateThingTypeResponse CreateThingType(CreateThingTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateThingTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThingTypeResponseUnmarshaller.Instance;

            return Invoke<CreateThingTypeResponse>(request, options);
        }



        /// <summary>
        /// Creates a new thing type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateThingType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateThingTypeResponse> CreateThingTypeAsync(CreateThingTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateThingTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThingTypeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateThingTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTopicRule

        internal virtual CreateTopicRuleResponse CreateTopicRule(CreateTopicRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTopicRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTopicRuleResponseUnmarshaller.Instance;

            return Invoke<CreateTopicRuleResponse>(request, options);
        }



        /// <summary>
        /// Creates a rule. Creating rules is an administrator-level action. Any user who has
        /// permission to create rules will be able to access data processed by the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTopicRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateTopicRuleResponse> CreateTopicRuleAsync(CreateTopicRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTopicRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTopicRuleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTopicRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTopicRuleDestination

        internal virtual CreateTopicRuleDestinationResponse CreateTopicRuleDestination(CreateTopicRuleDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTopicRuleDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTopicRuleDestinationResponseUnmarshaller.Instance;

            return Invoke<CreateTopicRuleDestinationResponse>(request, options);
        }



        /// <summary>
        /// Creates a topic rule destination. The destination must be confirmed prior to use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTopicRuleDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTopicRuleDestination service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateTopicRuleDestination">REST API Reference for CreateTopicRuleDestination Operation</seealso>
        public virtual Task<CreateTopicRuleDestinationResponse> CreateTopicRuleDestinationAsync(CreateTopicRuleDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTopicRuleDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTopicRuleDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTopicRuleDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAccountAuditConfiguration

        internal virtual DeleteAccountAuditConfigurationResponse DeleteAccountAuditConfiguration(DeleteAccountAuditConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccountAuditConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountAuditConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteAccountAuditConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Restores the default settings for Device Defender audits for this account. Any configuration
        /// data you entered is deleted and all audit checks are reset to disabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAuditConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteAccountAuditConfigurationResponse> DeleteAccountAuditConfigurationAsync(DeleteAccountAuditConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccountAuditConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountAuditConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAccountAuditConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAuditSuppression

        internal virtual DeleteAuditSuppressionResponse DeleteAuditSuppression(DeleteAuditSuppressionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAuditSuppressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAuditSuppressionResponseUnmarshaller.Instance;

            return Invoke<DeleteAuditSuppressionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a Device Defender audit suppression.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuditSuppression service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAuditSuppression service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteAuditSuppression">REST API Reference for DeleteAuditSuppression Operation</seealso>
        public virtual Task<DeleteAuditSuppressionResponse> DeleteAuditSuppressionAsync(DeleteAuditSuppressionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAuditSuppressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAuditSuppressionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAuditSuppressionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAuthorizer

        internal virtual DeleteAuthorizerResponse DeleteAuthorizer(DeleteAuthorizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAuthorizerResponseUnmarshaller.Instance;

            return Invoke<DeleteAuthorizerResponse>(request, options);
        }



        /// <summary>
        /// Deletes an authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthorizer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteAuthorizerResponse> DeleteAuthorizerAsync(DeleteAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAuthorizerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAuthorizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBillingGroup

        internal virtual DeleteBillingGroupResponse DeleteBillingGroup(DeleteBillingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBillingGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteBillingGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes the billing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBillingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteBillingGroupResponse> DeleteBillingGroupAsync(DeleteBillingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBillingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBillingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCACertificate

        internal virtual DeleteCACertificateResponse DeleteCACertificate(DeleteCACertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCACertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCACertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteCACertificateResponse>(request, options);
        }



        /// <summary>
        /// Deletes a registered CA certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCACertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteCACertificateResponse> DeleteCACertificateAsync(DeleteCACertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCACertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCACertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCACertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCertificate

        internal virtual DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest request)
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
        /// A certificate cannot be deleted if it has a policy or IoT thing attached to it or
        /// if its status is set to ACTIVE. To delete a certificate, first use the <a>DetachPrincipalPolicy</a>
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
        /// Deletes the specified certificate.
        /// 
        ///  
        /// <para>
        /// A certificate cannot be deleted if it has a policy or IoT thing attached to it or
        /// if its status is set to ACTIVE. To delete a certificate, first use the <a>DetachPrincipalPolicy</a>
        /// API to detach all policies. Next, use the <a>UpdateCertificate</a> API to set the
        /// certificate to the INACTIVE status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate service method.</param>
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
        public virtual Task<DeleteCertificateResponse> DeleteCertificateAsync(DeleteCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCustomMetric

        internal virtual DeleteCustomMetricResponse DeleteCustomMetric(DeleteCustomMetricRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomMetricRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomMetricResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomMetricResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// Before you can delete a custom metric, you must first remove the custom metric from
        /// all security profiles it's a part of. The security profile associated with the custom
        /// metric can be found using the <a href="https://docs.aws.amazon.com/iot/latest/apireference/API_ListSecurityProfiles.html">ListSecurityProfiles</a>
        /// API with <code>metricName</code> set to your custom metric name.
        /// </para>
        ///  </note> 
        /// <para>
        ///  Deletes a Device Defender detect custom metric. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomMetric service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomMetric service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteCustomMetric">REST API Reference for DeleteCustomMetric Operation</seealso>
        public virtual Task<DeleteCustomMetricResponse> DeleteCustomMetricAsync(DeleteCustomMetricRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomMetricRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomMetricResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCustomMetricResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDimension

        internal virtual DeleteDimensionResponse DeleteDimension(DeleteDimensionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDimensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDimensionResponseUnmarshaller.Instance;

            return Invoke<DeleteDimensionResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified dimension from your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDimension service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDimension service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteDimension">REST API Reference for DeleteDimension Operation</seealso>
        public virtual Task<DeleteDimensionResponse> DeleteDimensionAsync(DeleteDimensionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDimensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDimensionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDimensionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDomainConfiguration

        internal virtual DeleteDomainConfigurationResponse DeleteDomainConfiguration(DeleteDomainConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified domain configuration.
        /// 
        ///  <note> 
        /// <para>
        /// The domain configuration feature is in public preview and is subject to change.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomainConfiguration service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteDomainConfiguration">REST API Reference for DeleteDomainConfiguration Operation</seealso>
        public virtual Task<DeleteDomainConfigurationResponse> DeleteDomainConfigurationAsync(DeleteDomainConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDomainConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDynamicThingGroup

        internal virtual DeleteDynamicThingGroupResponse DeleteDynamicThingGroup(DeleteDynamicThingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDynamicThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDynamicThingGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDynamicThingGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a dynamic thing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDynamicThingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteDynamicThingGroupResponse> DeleteDynamicThingGroupAsync(DeleteDynamicThingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDynamicThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDynamicThingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDynamicThingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteJob

        internal virtual DeleteJobResponse DeleteJob(DeleteJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobResponseUnmarshaller.Instance;

            return Invoke<DeleteJobResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteJobExecution

        internal virtual DeleteJobExecutionResponse DeleteJobExecution(DeleteJobExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobExecutionResponseUnmarshaller.Instance;

            return Invoke<DeleteJobExecutionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a job execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteJobExecutionResponse> DeleteJobExecutionAsync(DeleteJobExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteJobExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMitigationAction

        internal virtual DeleteMitigationActionResponse DeleteMitigationAction(DeleteMitigationActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMitigationActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMitigationActionResponseUnmarshaller.Instance;

            return Invoke<DeleteMitigationActionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a defined mitigation action from your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMitigationAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMitigationAction service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteMitigationAction">REST API Reference for DeleteMitigationAction Operation</seealso>
        public virtual Task<DeleteMitigationActionResponse> DeleteMitigationActionAsync(DeleteMitigationActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMitigationActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMitigationActionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMitigationActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteOTAUpdate

        internal virtual DeleteOTAUpdateResponse DeleteOTAUpdate(DeleteOTAUpdateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOTAUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOTAUpdateResponseUnmarshaller.Instance;

            return Invoke<DeleteOTAUpdateResponse>(request, options);
        }



        /// <summary>
        /// Delete an OTA update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOTAUpdate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteOTAUpdateResponse> DeleteOTAUpdateAsync(DeleteOTAUpdateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOTAUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOTAUpdateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteOTAUpdateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePolicy

        internal virtual DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
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
        public virtual Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePolicyVersion

        internal virtual DeletePolicyVersionResponse DeletePolicyVersion(DeletePolicyVersionRequest request)
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
        /// Deletes the specified version of the specified policy. You cannot delete the default
        /// version of a policy using this API. To delete the default version of a policy, use
        /// <a>DeletePolicy</a>. To find out which version of a policy is marked as the default
        /// version, use ListPolicyVersions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyVersion service method.</param>
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
        public virtual Task<DeletePolicyVersionResponse> DeletePolicyVersionAsync(DeletePolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePolicyVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProvisioningTemplate

        internal virtual DeleteProvisioningTemplateResponse DeleteProvisioningTemplate(DeleteProvisioningTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProvisioningTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProvisioningTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteProvisioningTemplateResponse>(request, options);
        }



        /// <summary>
        /// Deletes a fleet provisioning template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisioningTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProvisioningTemplate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.ConflictingResourceUpdateException">
        /// A conflicting resource update exception. This exception is thrown when two pending
        /// updates cause a conflict.
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
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteProvisioningTemplate">REST API Reference for DeleteProvisioningTemplate Operation</seealso>
        public virtual Task<DeleteProvisioningTemplateResponse> DeleteProvisioningTemplateAsync(DeleteProvisioningTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProvisioningTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProvisioningTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProvisioningTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProvisioningTemplateVersion

        internal virtual DeleteProvisioningTemplateVersionResponse DeleteProvisioningTemplateVersion(DeleteProvisioningTemplateVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProvisioningTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProvisioningTemplateVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteProvisioningTemplateVersionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a fleet provisioning template version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisioningTemplateVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProvisioningTemplateVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.ConflictingResourceUpdateException">
        /// A conflicting resource update exception. This exception is thrown when two pending
        /// updates cause a conflict.
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
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteProvisioningTemplateVersion">REST API Reference for DeleteProvisioningTemplateVersion Operation</seealso>
        public virtual Task<DeleteProvisioningTemplateVersionResponse> DeleteProvisioningTemplateVersionAsync(DeleteProvisioningTemplateVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProvisioningTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProvisioningTemplateVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProvisioningTemplateVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRegistrationCode

        internal virtual DeleteRegistrationCodeResponse DeleteRegistrationCode(DeleteRegistrationCodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRegistrationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegistrationCodeResponseUnmarshaller.Instance;

            return Invoke<DeleteRegistrationCodeResponse>(request, options);
        }



        /// <summary>
        /// Deletes a CA certificate registration code.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistrationCode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteRegistrationCodeResponse> DeleteRegistrationCodeAsync(DeleteRegistrationCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRegistrationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegistrationCodeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRegistrationCodeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRoleAlias

        internal virtual DeleteRoleAliasResponse DeleteRoleAlias(DeleteRoleAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRoleAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoleAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteRoleAliasResponse>(request, options);
        }



        /// <summary>
        /// Deletes a role alias
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoleAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteRoleAliasResponse> DeleteRoleAliasAsync(DeleteRoleAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRoleAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoleAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRoleAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteScheduledAudit

        internal virtual DeleteScheduledAuditResponse DeleteScheduledAudit(DeleteScheduledAuditRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScheduledAuditRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduledAuditResponseUnmarshaller.Instance;

            return Invoke<DeleteScheduledAuditResponse>(request, options);
        }



        /// <summary>
        /// Deletes a scheduled audit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAudit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteScheduledAuditResponse> DeleteScheduledAuditAsync(DeleteScheduledAuditRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScheduledAuditRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduledAuditResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteScheduledAuditResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSecurityProfile

        internal virtual DeleteSecurityProfileResponse DeleteSecurityProfile(DeleteSecurityProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteSecurityProfileResponse>(request, options);
        }



        /// <summary>
        /// Deletes a Device Defender security profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteSecurityProfileResponse> DeleteSecurityProfileAsync(DeleteSecurityProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSecurityProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteStream

        internal virtual DeleteStreamResponse DeleteStream(DeleteStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamResponseUnmarshaller.Instance;

            return Invoke<DeleteStreamResponse>(request, options);
        }



        /// <summary>
        /// Deletes a stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteStreamResponse> DeleteStreamAsync(DeleteStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteThing

        internal virtual DeleteThingResponse DeleteThing(DeleteThingRequest request)
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
        /// Deletes the specified thing. Returns successfully with no error if the deletion is
        /// successful or you specify a thing that doesn't exist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteThing service method.</param>
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
        public virtual Task<DeleteThingResponse> DeleteThingAsync(DeleteThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThingResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteThingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteThingGroup

        internal virtual DeleteThingGroupResponse DeleteThingGroup(DeleteThingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThingGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteThingGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a thing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteThingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteThingGroupResponse> DeleteThingGroupAsync(DeleteThingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteThingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteThingType

        internal virtual DeleteThingTypeResponse DeleteThingType(DeleteThingTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThingTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThingTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteThingTypeResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified thing type. You cannot delete a thing type if it has things
        /// associated with it. To delete a thing type, first mark it as deprecated by calling
        /// <a>DeprecateThingType</a>, then remove any associated things by calling <a>UpdateThing</a>
        /// to change the thing type on any associated thing, and finally use <a>DeleteThingType</a>
        /// to delete the thing type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteThingType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteThingTypeResponse> DeleteThingTypeAsync(DeleteThingTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThingTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThingTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteThingTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTopicRule

        internal virtual DeleteTopicRuleResponse DeleteTopicRule(DeleteTopicRuleRequest request)
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
        /// Deletes the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopicRule service method.</param>
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
        public virtual Task<DeleteTopicRuleResponse> DeleteTopicRuleAsync(DeleteTopicRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTopicRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTopicRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTopicRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTopicRuleDestination

        internal virtual DeleteTopicRuleDestinationResponse DeleteTopicRuleDestination(DeleteTopicRuleDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTopicRuleDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTopicRuleDestinationResponseUnmarshaller.Instance;

            return Invoke<DeleteTopicRuleDestinationResponse>(request, options);
        }



        /// <summary>
        /// Deletes a topic rule destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopicRuleDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTopicRuleDestination service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteTopicRuleDestination">REST API Reference for DeleteTopicRuleDestination Operation</seealso>
        public virtual Task<DeleteTopicRuleDestinationResponse> DeleteTopicRuleDestinationAsync(DeleteTopicRuleDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTopicRuleDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTopicRuleDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTopicRuleDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteV2LoggingLevel

        internal virtual DeleteV2LoggingLevelResponse DeleteV2LoggingLevel(DeleteV2LoggingLevelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteV2LoggingLevelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteV2LoggingLevelResponseUnmarshaller.Instance;

            return Invoke<DeleteV2LoggingLevelResponse>(request, options);
        }



        /// <summary>
        /// Deletes a logging level.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteV2LoggingLevel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteV2LoggingLevelResponse> DeleteV2LoggingLevelAsync(DeleteV2LoggingLevelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteV2LoggingLevelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteV2LoggingLevelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteV2LoggingLevelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeprecateThingType

        internal virtual DeprecateThingTypeResponse DeprecateThingType(DeprecateThingTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeprecateThingTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateThingTypeResponseUnmarshaller.Instance;

            return Invoke<DeprecateThingTypeResponse>(request, options);
        }



        /// <summary>
        /// Deprecates a thing type. You can not associate new things with deprecated thing type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprecateThingType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeprecateThingTypeResponse> DeprecateThingTypeAsync(DeprecateThingTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeprecateThingTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateThingTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DeprecateThingTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountAuditConfiguration

        internal virtual DescribeAccountAuditConfigurationResponse DescribeAccountAuditConfiguration(DescribeAccountAuditConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAuditConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAuditConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAuditConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Gets information about the Device Defender audit settings for this account. Settings
        /// include how audit notifications are sent and which audit checks are enabled or disabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAuditConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountAuditConfiguration service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAccountAuditConfiguration">REST API Reference for DescribeAccountAuditConfiguration Operation</seealso>
        public virtual Task<DescribeAccountAuditConfigurationResponse> DescribeAccountAuditConfigurationAsync(DescribeAccountAuditConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAuditConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAuditConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountAuditConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAuditFinding

        internal virtual DescribeAuditFindingResponse DescribeAuditFinding(DescribeAuditFindingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAuditFindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAuditFindingResponseUnmarshaller.Instance;

            return Invoke<DescribeAuditFindingResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a single audit finding. Properties include the reason for noncompliance,
        /// the severity of the issue, and the start time when the audit that returned the finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuditFinding service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAuditFinding service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAuditFinding">REST API Reference for DescribeAuditFinding Operation</seealso>
        public virtual Task<DescribeAuditFindingResponse> DescribeAuditFindingAsync(DescribeAuditFindingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAuditFindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAuditFindingResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAuditFindingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAuditMitigationActionsTask

        internal virtual DescribeAuditMitigationActionsTaskResponse DescribeAuditMitigationActionsTask(DescribeAuditMitigationActionsTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAuditMitigationActionsTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAuditMitigationActionsTaskResponseUnmarshaller.Instance;

            return Invoke<DescribeAuditMitigationActionsTaskResponse>(request, options);
        }



        /// <summary>
        /// Gets information about an audit mitigation task that is used to apply mitigation actions
        /// to a set of audit findings. Properties include the actions being applied, the audit
        /// checks to which they're being applied, the task status, and aggregated task statistics.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuditMitigationActionsTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAuditMitigationActionsTask service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAuditMitigationActionsTask">REST API Reference for DescribeAuditMitigationActionsTask Operation</seealso>
        public virtual Task<DescribeAuditMitigationActionsTaskResponse> DescribeAuditMitigationActionsTaskAsync(DescribeAuditMitigationActionsTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAuditMitigationActionsTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAuditMitigationActionsTaskResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAuditMitigationActionsTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAuditSuppression

        internal virtual DescribeAuditSuppressionResponse DescribeAuditSuppression(DescribeAuditSuppressionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAuditSuppressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAuditSuppressionResponseUnmarshaller.Instance;

            return Invoke<DescribeAuditSuppressionResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a Device Defender audit suppression.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuditSuppression service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAuditSuppression service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAuditSuppression">REST API Reference for DescribeAuditSuppression Operation</seealso>
        public virtual Task<DescribeAuditSuppressionResponse> DescribeAuditSuppressionAsync(DescribeAuditSuppressionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAuditSuppressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAuditSuppressionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAuditSuppressionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAuditTask

        internal virtual DescribeAuditTaskResponse DescribeAuditTask(DescribeAuditTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAuditTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAuditTaskResponseUnmarshaller.Instance;

            return Invoke<DescribeAuditTaskResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a Device Defender audit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuditTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeAuditTaskResponse> DescribeAuditTaskAsync(DescribeAuditTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAuditTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAuditTaskResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAuditTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAuthorizer

        internal virtual DescribeAuthorizerResponse DescribeAuthorizer(DescribeAuthorizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAuthorizerResponseUnmarshaller.Instance;

            return Invoke<DescribeAuthorizerResponse>(request, options);
        }



        /// <summary>
        /// Describes an authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuthorizer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeAuthorizerResponse> DescribeAuthorizerAsync(DescribeAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAuthorizerResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAuthorizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeBillingGroup

        internal virtual DescribeBillingGroupResponse DescribeBillingGroup(DescribeBillingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBillingGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeBillingGroupResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a billing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBillingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeBillingGroupResponse> DescribeBillingGroupAsync(DescribeBillingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBillingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBillingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCACertificate

        internal virtual DescribeCACertificateResponse DescribeCACertificate(DescribeCACertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCACertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCACertificateResponseUnmarshaller.Instance;

            return Invoke<DescribeCACertificateResponse>(request, options);
        }



        /// <summary>
        /// Describes a registered CA certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCACertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeCACertificateResponse> DescribeCACertificateAsync(DescribeCACertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCACertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCACertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCACertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCertificate

        internal virtual DescribeCertificateResponse DescribeCertificate(DescribeCertificateRequest request)
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
        /// Gets information about the specified certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificate service method.</param>
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
        public virtual Task<DescribeCertificateResponse> DescribeCertificateAsync(DescribeCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCustomMetric

        internal virtual DescribeCustomMetricResponse DescribeCustomMetric(DescribeCustomMetricRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomMetricRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomMetricResponseUnmarshaller.Instance;

            return Invoke<DescribeCustomMetricResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a Device Defender detect custom metric.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomMetric service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCustomMetric service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeCustomMetric">REST API Reference for DescribeCustomMetric Operation</seealso>
        public virtual Task<DescribeCustomMetricResponse> DescribeCustomMetricAsync(DescribeCustomMetricRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomMetricRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomMetricResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCustomMetricResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDefaultAuthorizer

        internal virtual DescribeDefaultAuthorizerResponse DescribeDefaultAuthorizer(DescribeDefaultAuthorizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDefaultAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDefaultAuthorizerResponseUnmarshaller.Instance;

            return Invoke<DescribeDefaultAuthorizerResponse>(request, options);
        }



        /// <summary>
        /// Describes the default authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultAuthorizer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeDefaultAuthorizerResponse> DescribeDefaultAuthorizerAsync(DescribeDefaultAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDefaultAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDefaultAuthorizerResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDefaultAuthorizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDetectMitigationActionsTask

        internal virtual DescribeDetectMitigationActionsTaskResponse DescribeDetectMitigationActionsTask(DescribeDetectMitigationActionsTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDetectMitigationActionsTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDetectMitigationActionsTaskResponseUnmarshaller.Instance;

            return Invoke<DescribeDetectMitigationActionsTaskResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a Device Defender ML Detect mitigation action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDetectMitigationActionsTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDetectMitigationActionsTask service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeDetectMitigationActionsTask">REST API Reference for DescribeDetectMitigationActionsTask Operation</seealso>
        public virtual Task<DescribeDetectMitigationActionsTaskResponse> DescribeDetectMitigationActionsTaskAsync(DescribeDetectMitigationActionsTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDetectMitigationActionsTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDetectMitigationActionsTaskResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDetectMitigationActionsTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDimension

        internal virtual DescribeDimensionResponse DescribeDimension(DescribeDimensionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDimensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDimensionResponseUnmarshaller.Instance;

            return Invoke<DescribeDimensionResponse>(request, options);
        }



        /// <summary>
        /// Provides details about a dimension that is defined in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDimension service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDimension service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeDimension">REST API Reference for DescribeDimension Operation</seealso>
        public virtual Task<DescribeDimensionResponse> DescribeDimensionAsync(DescribeDimensionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDimensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDimensionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDimensionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDomainConfiguration

        internal virtual DescribeDomainConfigurationResponse DescribeDomainConfiguration(DescribeDomainConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Gets summary information about a domain configuration.
        /// 
        ///  <note> 
        /// <para>
        /// The domain configuration feature is in public preview and is subject to change.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDomainConfiguration service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeDomainConfiguration">REST API Reference for DescribeDomainConfiguration Operation</seealso>
        public virtual Task<DescribeDomainConfigurationResponse> DescribeDomainConfigurationAsync(DescribeDomainConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDomainConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEndpoint

        internal virtual DescribeEndpointResponse DescribeEndpoint(DescribeEndpointRequest request)
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
        /// Returns a unique endpoint specific to the AWS account making the call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoint service method.</param>
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
        public virtual Task<DescribeEndpointResponse> DescribeEndpointAsync(DescribeEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventConfigurations

        internal virtual DescribeEventConfigurationsResponse DescribeEventConfigurations(DescribeEventConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Describes event configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventConfigurations service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
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

        internal virtual DescribeIndexResponse DescribeIndex(DescribeIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIndexResponseUnmarshaller.Instance;

            return Invoke<DescribeIndexResponse>(request, options);
        }



        /// <summary>
        /// Describes a search index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeIndexResponse> DescribeIndexAsync(DescribeIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIndexResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeIndexResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeJob

        internal virtual DescribeJobResponse DescribeJob(DescribeJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobResponseUnmarshaller.Instance;

            return Invoke<DescribeJobResponse>(request, options);
        }



        /// <summary>
        /// Describes a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeJobResponse> DescribeJobAsync(DescribeJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeJobExecution

        internal virtual DescribeJobExecutionResponse DescribeJobExecution(DescribeJobExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobExecutionResponseUnmarshaller.Instance;

            return Invoke<DescribeJobExecutionResponse>(request, options);
        }



        /// <summary>
        /// Describes a job execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeJobExecutionResponse> DescribeJobExecutionAsync(DescribeJobExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeJobExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMitigationAction

        internal virtual DescribeMitigationActionResponse DescribeMitigationAction(DescribeMitigationActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMitigationActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMitigationActionResponseUnmarshaller.Instance;

            return Invoke<DescribeMitigationActionResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a mitigation action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMitigationAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMitigationAction service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeMitigationAction">REST API Reference for DescribeMitigationAction Operation</seealso>
        public virtual Task<DescribeMitigationActionResponse> DescribeMitigationActionAsync(DescribeMitigationActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMitigationActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMitigationActionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMitigationActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProvisioningTemplate

        internal virtual DescribeProvisioningTemplateResponse DescribeProvisioningTemplate(DescribeProvisioningTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisioningTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisioningTemplateResponseUnmarshaller.Instance;

            return Invoke<DescribeProvisioningTemplateResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a fleet provisioning template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProvisioningTemplate service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeProvisioningTemplate">REST API Reference for DescribeProvisioningTemplate Operation</seealso>
        public virtual Task<DescribeProvisioningTemplateResponse> DescribeProvisioningTemplateAsync(DescribeProvisioningTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisioningTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisioningTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProvisioningTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProvisioningTemplateVersion

        internal virtual DescribeProvisioningTemplateVersionResponse DescribeProvisioningTemplateVersion(DescribeProvisioningTemplateVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisioningTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisioningTemplateVersionResponseUnmarshaller.Instance;

            return Invoke<DescribeProvisioningTemplateVersionResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a fleet provisioning template version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningTemplateVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProvisioningTemplateVersion service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeProvisioningTemplateVersion">REST API Reference for DescribeProvisioningTemplateVersion Operation</seealso>
        public virtual Task<DescribeProvisioningTemplateVersionResponse> DescribeProvisioningTemplateVersionAsync(DescribeProvisioningTemplateVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisioningTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisioningTemplateVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProvisioningTemplateVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRoleAlias

        internal virtual DescribeRoleAliasResponse DescribeRoleAlias(DescribeRoleAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRoleAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRoleAliasResponseUnmarshaller.Instance;

            return Invoke<DescribeRoleAliasResponse>(request, options);
        }



        /// <summary>
        /// Describes a role alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRoleAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeRoleAliasResponse> DescribeRoleAliasAsync(DescribeRoleAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRoleAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRoleAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRoleAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeScheduledAudit

        internal virtual DescribeScheduledAuditResponse DescribeScheduledAudit(DescribeScheduledAuditRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledAuditRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledAuditResponseUnmarshaller.Instance;

            return Invoke<DescribeScheduledAuditResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a scheduled audit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledAudit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeScheduledAuditResponse> DescribeScheduledAuditAsync(DescribeScheduledAuditRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledAuditRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledAuditResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScheduledAuditResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSecurityProfile

        internal virtual DescribeSecurityProfileResponse DescribeSecurityProfile(DescribeSecurityProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecurityProfileResponseUnmarshaller.Instance;

            return Invoke<DescribeSecurityProfileResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a Device Defender security profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeSecurityProfileResponse> DescribeSecurityProfileAsync(DescribeSecurityProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecurityProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSecurityProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStream

        internal virtual DescribeStreamResponse DescribeStream(DescribeStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamResponseUnmarshaller.Instance;

            return Invoke<DescribeStreamResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeStreamResponse> DescribeStreamAsync(DescribeStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeThing

        internal virtual DescribeThingResponse DescribeThing(DescribeThingRequest request)
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
        /// Gets information about the specified thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeThing service method.</param>
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
        public virtual Task<DescribeThingResponse> DescribeThingAsync(DescribeThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeThingResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeThingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeThingGroup

        internal virtual DescribeThingGroupResponse DescribeThingGroup(DescribeThingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeThingGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeThingGroupResponse>(request, options);
        }



        /// <summary>
        /// Describe a thing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeThingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeThingGroupResponse> DescribeThingGroupAsync(DescribeThingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeThingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeThingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeThingRegistrationTask

        internal virtual DescribeThingRegistrationTaskResponse DescribeThingRegistrationTask(DescribeThingRegistrationTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeThingRegistrationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeThingRegistrationTaskResponseUnmarshaller.Instance;

            return Invoke<DescribeThingRegistrationTaskResponse>(request, options);
        }



        /// <summary>
        /// Describes a bulk thing provisioning task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeThingRegistrationTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeThingRegistrationTaskResponse> DescribeThingRegistrationTaskAsync(DescribeThingRegistrationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeThingRegistrationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeThingRegistrationTaskResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeThingRegistrationTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeThingType

        internal virtual DescribeThingTypeResponse DescribeThingType(DescribeThingTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeThingTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeThingTypeResponseUnmarshaller.Instance;

            return Invoke<DescribeThingTypeResponse>(request, options);
        }



        /// <summary>
        /// Gets information about the specified thing type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeThingType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeThingTypeResponse> DescribeThingTypeAsync(DescribeThingTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeThingTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeThingTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeThingTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachPolicy

        internal virtual DetachPolicyResponse DetachPolicy(DetachPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachPolicyResponseUnmarshaller.Instance;

            return Invoke<DetachPolicyResponse>(request, options);
        }



        /// <summary>
        /// Detaches a policy from the specified target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DetachPolicyResponse> DetachPolicyAsync(DetachPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DetachPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachPrincipalPolicy

        [Obsolete("Deprecated in favor of DetachPolicy.")]
        internal virtual DetachPrincipalPolicyResponse DetachPrincipalPolicy(DetachPrincipalPolicyRequest request)
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
        /// <param name="principal">The principal. Valid principals are CertificateArn (arn:aws:iot:<i>region</i>:<i>accountId</i>:cert/<i>certificateId</i>), thingGroupArn (arn:aws:iot:<i>region</i>:<i>accountId</i>:thinggroup/<i>groupName</i>) and CognitoId (<i>region</i>:<i>id</i>).</param>
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
        /// Removes the specified policy from the specified certificate.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This API is deprecated. Please use <a>DetachPolicy</a> instead.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachPrincipalPolicy service method.</param>
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
        public virtual Task<DetachPrincipalPolicyResponse> DetachPrincipalPolicyAsync(DetachPrincipalPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachPrincipalPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachPrincipalPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DetachPrincipalPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachSecurityProfile

        internal virtual DetachSecurityProfileResponse DetachSecurityProfile(DetachSecurityProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachSecurityProfileResponseUnmarshaller.Instance;

            return Invoke<DetachSecurityProfileResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a Device Defender security profile from a thing group or from this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachSecurityProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DetachSecurityProfileResponse> DetachSecurityProfileAsync(DetachSecurityProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachSecurityProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DetachSecurityProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachThingPrincipal

        internal virtual DetachThingPrincipalResponse DetachThingPrincipal(DetachThingPrincipalRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachThingPrincipalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachThingPrincipalResponseUnmarshaller.Instance;

            return Invoke<DetachThingPrincipalResponse>(request, options);
        }


        /// <summary>
        /// Detaches the specified principal from the specified thing. A principal can be X.509
        /// certificates, IAM users, groups, and roles, Amazon Cognito identities or federated
        /// identities.
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
        /// Detaches the specified principal from the specified thing. A principal can be X.509
        /// certificates, IAM users, groups, and roles, Amazon Cognito identities or federated
        /// identities.
        /// 
        ///  <note> 
        /// <para>
        /// This call is asynchronous. It might take several seconds for the detachment to propagate.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachThingPrincipal service method.</param>
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
        public virtual Task<DetachThingPrincipalResponse> DetachThingPrincipalAsync(DetachThingPrincipalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachThingPrincipalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachThingPrincipalResponseUnmarshaller.Instance;

            return InvokeAsync<DetachThingPrincipalResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableTopicRule

        internal virtual DisableTopicRuleResponse DisableTopicRule(DisableTopicRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableTopicRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableTopicRuleResponseUnmarshaller.Instance;

            return Invoke<DisableTopicRuleResponse>(request, options);
        }



        /// <summary>
        /// Disables the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableTopicRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DisableTopicRuleResponse> DisableTopicRuleAsync(DisableTopicRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableTopicRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableTopicRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DisableTopicRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableTopicRule

        internal virtual EnableTopicRuleResponse EnableTopicRule(EnableTopicRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableTopicRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableTopicRuleResponseUnmarshaller.Instance;

            return Invoke<EnableTopicRuleResponse>(request, options);
        }



        /// <summary>
        /// Enables the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableTopicRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<EnableTopicRuleResponse> EnableTopicRuleAsync(EnableTopicRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableTopicRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableTopicRuleResponseUnmarshaller.Instance;

            return InvokeAsync<EnableTopicRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBehaviorModelTrainingSummaries

        internal virtual GetBehaviorModelTrainingSummariesResponse GetBehaviorModelTrainingSummaries(GetBehaviorModelTrainingSummariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBehaviorModelTrainingSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBehaviorModelTrainingSummariesResponseUnmarshaller.Instance;

            return Invoke<GetBehaviorModelTrainingSummariesResponse>(request, options);
        }



        /// <summary>
        /// Returns a Device Defender's ML Detect Security Profile training model's status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBehaviorModelTrainingSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBehaviorModelTrainingSummaries service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetBehaviorModelTrainingSummaries">REST API Reference for GetBehaviorModelTrainingSummaries Operation</seealso>
        public virtual Task<GetBehaviorModelTrainingSummariesResponse> GetBehaviorModelTrainingSummariesAsync(GetBehaviorModelTrainingSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBehaviorModelTrainingSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBehaviorModelTrainingSummariesResponseUnmarshaller.Instance;

            return InvokeAsync<GetBehaviorModelTrainingSummariesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCardinality

        internal virtual GetCardinalityResponse GetCardinality(GetCardinalityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCardinalityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCardinalityResponseUnmarshaller.Instance;

            return Invoke<GetCardinalityResponse>(request, options);
        }



        /// <summary>
        /// Returns the approximate count of unique values that match the query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCardinality service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCardinality service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.IndexNotReadyException">
        /// The index is not ready.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidAggregationException">
        /// The aggregation is invalid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetCardinality">REST API Reference for GetCardinality Operation</seealso>
        public virtual Task<GetCardinalityResponse> GetCardinalityAsync(GetCardinalityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCardinalityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCardinalityResponseUnmarshaller.Instance;

            return InvokeAsync<GetCardinalityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEffectivePolicies

        internal virtual GetEffectivePoliciesResponse GetEffectivePolicies(GetEffectivePoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEffectivePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEffectivePoliciesResponseUnmarshaller.Instance;

            return Invoke<GetEffectivePoliciesResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of the policies that have an effect on the authorization behavior of the
        /// specified device when it connects to the AWS IoT device gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEffectivePolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetEffectivePoliciesResponse> GetEffectivePoliciesAsync(GetEffectivePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEffectivePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEffectivePoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<GetEffectivePoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIndexingConfiguration

        internal virtual GetIndexingConfigurationResponse GetIndexingConfiguration(GetIndexingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIndexingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIndexingConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetIndexingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Gets the indexing configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIndexingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetIndexingConfigurationResponse> GetIndexingConfigurationAsync(GetIndexingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIndexingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIndexingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetIndexingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetJobDocument

        internal virtual GetJobDocumentResponse GetJobDocument(GetJobDocumentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobDocumentResponseUnmarshaller.Instance;

            return Invoke<GetJobDocumentResponse>(request, options);
        }



        /// <summary>
        /// Gets a job document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobDocument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetJobDocumentResponse> GetJobDocumentAsync(GetJobDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobDocumentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLoggingOptions

        internal virtual GetLoggingOptionsResponse GetLoggingOptions(GetLoggingOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoggingOptionsResponseUnmarshaller.Instance;

            return Invoke<GetLoggingOptionsResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetLoggingOptionsResponse> GetLoggingOptionsAsync(GetLoggingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoggingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetLoggingOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOTAUpdate

        internal virtual GetOTAUpdateResponse GetOTAUpdate(GetOTAUpdateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOTAUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOTAUpdateResponseUnmarshaller.Instance;

            return Invoke<GetOTAUpdateResponse>(request, options);
        }



        /// <summary>
        /// Gets an OTA update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOTAUpdate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetOTAUpdateResponse> GetOTAUpdateAsync(GetOTAUpdateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOTAUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOTAUpdateResponseUnmarshaller.Instance;

            return InvokeAsync<GetOTAUpdateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPercentiles

        internal virtual GetPercentilesResponse GetPercentiles(GetPercentilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPercentilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPercentilesResponseUnmarshaller.Instance;

            return Invoke<GetPercentilesResponse>(request, options);
        }



        /// <summary>
        /// Groups the aggregated values that match the query into percentile groupings. The default
        /// percentile groupings are: 1,5,25,50,75,95,99, although you can specify your own when
        /// you call <code>GetPercentiles</code>. This function returns a value for each percentile
        /// group specified (or the default percentile groupings). The percentile group "1" contains
        /// the aggregated field value that occurs in approximately one percent of the values
        /// that match the query. The percentile group "5" contains the aggregated field value
        /// that occurs in approximately five percent of the values that match the query, and
        /// so on. The result is an approximation, the more values that match the query, the more
        /// accurate the percentile values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPercentiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPercentiles service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.IndexNotReadyException">
        /// The index is not ready.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidAggregationException">
        /// The aggregation is invalid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetPercentiles">REST API Reference for GetPercentiles Operation</seealso>
        public virtual Task<GetPercentilesResponse> GetPercentilesAsync(GetPercentilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPercentilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPercentilesResponseUnmarshaller.Instance;

            return InvokeAsync<GetPercentilesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPolicy

        internal virtual GetPolicyResponse GetPolicy(GetPolicyRequest request)
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
        /// Gets information about the specified policy with the policy document of the default
        /// version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
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
        public virtual Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPolicyVersion

        internal virtual GetPolicyVersionResponse GetPolicyVersion(GetPolicyVersionRequest request)
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
        /// Gets information about the specified policy version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyVersion service method.</param>
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
        public virtual Task<GetPolicyVersionResponse> GetPolicyVersionAsync(GetPolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetPolicyVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRegistrationCode

        internal virtual GetRegistrationCodeResponse GetRegistrationCode(GetRegistrationCodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegistrationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegistrationCodeResponseUnmarshaller.Instance;

            return Invoke<GetRegistrationCodeResponse>(request, options);
        }



        /// <summary>
        /// Gets a registration code used to register a CA certificate with AWS IoT.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegistrationCode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetRegistrationCodeResponse> GetRegistrationCodeAsync(GetRegistrationCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegistrationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegistrationCodeResponseUnmarshaller.Instance;

            return InvokeAsync<GetRegistrationCodeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetStatistics

        internal virtual GetStatisticsResponse GetStatistics(GetStatisticsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetStatisticsResponse>(request, options);
        }



        /// <summary>
        /// Returns the count, average, sum, minimum, maximum, sum of squares, variance, and standard
        /// deviation for the specified aggregated field. If the aggregation field is of type
        /// <code>String</code>, only the count statistic is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStatistics service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.IndexNotReadyException">
        /// The index is not ready.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidAggregationException">
        /// The aggregation is invalid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetStatistics">REST API Reference for GetStatistics Operation</seealso>
        public virtual Task<GetStatisticsResponse> GetStatisticsAsync(GetStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStatisticsResponseUnmarshaller.Instance;

            return InvokeAsync<GetStatisticsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTopicRule

        internal virtual GetTopicRuleResponse GetTopicRule(GetTopicRuleRequest request)
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
        /// Gets information about the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTopicRule service method.</param>
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
        public virtual Task<GetTopicRuleResponse> GetTopicRuleAsync(GetTopicRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTopicRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTopicRuleResponseUnmarshaller.Instance;

            return InvokeAsync<GetTopicRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTopicRuleDestination

        internal virtual GetTopicRuleDestinationResponse GetTopicRuleDestination(GetTopicRuleDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTopicRuleDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTopicRuleDestinationResponseUnmarshaller.Instance;

            return Invoke<GetTopicRuleDestinationResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a topic rule destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTopicRuleDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTopicRuleDestination service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetTopicRuleDestination">REST API Reference for GetTopicRuleDestination Operation</seealso>
        public virtual Task<GetTopicRuleDestinationResponse> GetTopicRuleDestinationAsync(GetTopicRuleDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTopicRuleDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTopicRuleDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<GetTopicRuleDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetV2LoggingOptions

        internal virtual GetV2LoggingOptionsResponse GetV2LoggingOptions(GetV2LoggingOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetV2LoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetV2LoggingOptionsResponseUnmarshaller.Instance;

            return Invoke<GetV2LoggingOptionsResponse>(request, options);
        }



        /// <summary>
        /// Gets the fine grained logging options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetV2LoggingOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetV2LoggingOptionsResponse> GetV2LoggingOptionsAsync(GetV2LoggingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetV2LoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetV2LoggingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetV2LoggingOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListActiveViolations

        internal virtual ListActiveViolationsResponse ListActiveViolations(ListActiveViolationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListActiveViolationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActiveViolationsResponseUnmarshaller.Instance;

            return Invoke<ListActiveViolationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the active violations for a given Device Defender security profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActiveViolations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListActiveViolationsResponse> ListActiveViolationsAsync(ListActiveViolationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListActiveViolationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActiveViolationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListActiveViolationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAttachedPolicies

        internal virtual ListAttachedPoliciesResponse ListAttachedPolicies(ListAttachedPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttachedPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachedPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListAttachedPoliciesResponse>(request, options);
        }



        /// <summary>
        /// Lists the policies attached to the specified thing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListAttachedPoliciesResponse> ListAttachedPoliciesAsync(ListAttachedPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttachedPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachedPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAttachedPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAuditFindings

        internal virtual ListAuditFindingsResponse ListAuditFindings(ListAuditFindingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAuditFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAuditFindingsResponseUnmarshaller.Instance;

            return Invoke<ListAuditFindingsResponse>(request, options);
        }



        /// <summary>
        /// Lists the findings (results) of a Device Defender audit or of the audits performed
        /// during a specified time period. (Findings are retained for 90 days.)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAuditFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListAuditFindingsResponse> ListAuditFindingsAsync(ListAuditFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAuditFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAuditFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAuditFindingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAuditMitigationActionsExecutions

        internal virtual ListAuditMitigationActionsExecutionsResponse ListAuditMitigationActionsExecutions(ListAuditMitigationActionsExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAuditMitigationActionsExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAuditMitigationActionsExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListAuditMitigationActionsExecutionsResponse>(request, options);
        }



        /// <summary>
        /// Gets the status of audit mitigation action tasks that were executed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAuditMitigationActionsExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAuditMitigationActionsExecutions service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuditMitigationActionsExecutions">REST API Reference for ListAuditMitigationActionsExecutions Operation</seealso>
        public virtual Task<ListAuditMitigationActionsExecutionsResponse> ListAuditMitigationActionsExecutionsAsync(ListAuditMitigationActionsExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAuditMitigationActionsExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAuditMitigationActionsExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAuditMitigationActionsExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAuditMitigationActionsTasks

        internal virtual ListAuditMitigationActionsTasksResponse ListAuditMitigationActionsTasks(ListAuditMitigationActionsTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAuditMitigationActionsTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAuditMitigationActionsTasksResponseUnmarshaller.Instance;

            return Invoke<ListAuditMitigationActionsTasksResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of audit mitigation action tasks that match the specified filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAuditMitigationActionsTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAuditMitigationActionsTasks service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuditMitigationActionsTasks">REST API Reference for ListAuditMitigationActionsTasks Operation</seealso>
        public virtual Task<ListAuditMitigationActionsTasksResponse> ListAuditMitigationActionsTasksAsync(ListAuditMitigationActionsTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAuditMitigationActionsTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAuditMitigationActionsTasksResponseUnmarshaller.Instance;

            return InvokeAsync<ListAuditMitigationActionsTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAuditSuppressions

        internal virtual ListAuditSuppressionsResponse ListAuditSuppressions(ListAuditSuppressionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAuditSuppressionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAuditSuppressionsResponseUnmarshaller.Instance;

            return Invoke<ListAuditSuppressionsResponse>(request, options);
        }



        /// <summary>
        /// Lists your Device Defender audit listings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAuditSuppressions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAuditSuppressions service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuditSuppressions">REST API Reference for ListAuditSuppressions Operation</seealso>
        public virtual Task<ListAuditSuppressionsResponse> ListAuditSuppressionsAsync(ListAuditSuppressionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAuditSuppressionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAuditSuppressionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAuditSuppressionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAuditTasks

        internal virtual ListAuditTasksResponse ListAuditTasks(ListAuditTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAuditTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAuditTasksResponseUnmarshaller.Instance;

            return Invoke<ListAuditTasksResponse>(request, options);
        }



        /// <summary>
        /// Lists the Device Defender audits that have been performed during a given time period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAuditTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListAuditTasksResponse> ListAuditTasksAsync(ListAuditTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAuditTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAuditTasksResponseUnmarshaller.Instance;

            return InvokeAsync<ListAuditTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAuthorizers

        internal virtual ListAuthorizersResponse ListAuthorizers(ListAuthorizersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAuthorizersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAuthorizersResponseUnmarshaller.Instance;

            return Invoke<ListAuthorizersResponse>(request, options);
        }



        /// <summary>
        /// Lists the authorizers registered in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAuthorizers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListAuthorizersResponse> ListAuthorizersAsync(ListAuthorizersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAuthorizersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAuthorizersResponseUnmarshaller.Instance;

            return InvokeAsync<ListAuthorizersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBillingGroups

        internal virtual ListBillingGroupsResponse ListBillingGroups(ListBillingGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBillingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillingGroupsResponseUnmarshaller.Instance;

            return Invoke<ListBillingGroupsResponse>(request, options);
        }



        /// <summary>
        /// Lists the billing groups you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillingGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListBillingGroupsResponse> ListBillingGroupsAsync(ListBillingGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBillingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillingGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBillingGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCACertificates

        internal virtual ListCACertificatesResponse ListCACertificates(ListCACertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCACertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCACertificatesResponseUnmarshaller.Instance;

            return Invoke<ListCACertificatesResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListCACertificatesResponse> ListCACertificatesAsync(ListCACertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCACertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCACertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListCACertificatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCertificates

        internal virtual ListCertificatesResponse ListCertificates(ListCertificatesRequest request)
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
        /// Lists the certificates registered in your AWS account.
        /// 
        ///  
        /// <para>
        /// The results are paginated with a default page size of 25. You can use the returned
        /// marker to retrieve additional results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificates service method.</param>
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
        public virtual Task<ListCertificatesResponse> ListCertificatesAsync(ListCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListCertificatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCertificatesByCA

        internal virtual ListCertificatesByCAResponse ListCertificatesByCA(ListCertificatesByCARequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCertificatesByCARequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCertificatesByCAResponseUnmarshaller.Instance;

            return Invoke<ListCertificatesByCAResponse>(request, options);
        }



        /// <summary>
        /// List the device certificates signed by the specified CA certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificatesByCA service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListCertificatesByCAResponse> ListCertificatesByCAAsync(ListCertificatesByCARequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCertificatesByCARequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCertificatesByCAResponseUnmarshaller.Instance;

            return InvokeAsync<ListCertificatesByCAResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCustomMetrics

        internal virtual ListCustomMetricsResponse ListCustomMetrics(ListCustomMetricsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomMetricsResponseUnmarshaller.Instance;

            return Invoke<ListCustomMetricsResponse>(request, options);
        }



        /// <summary>
        /// Lists your Device Defender detect custom metrics.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomMetrics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCustomMetrics service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListCustomMetrics">REST API Reference for ListCustomMetrics Operation</seealso>
        public virtual Task<ListCustomMetricsResponse> ListCustomMetricsAsync(ListCustomMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomMetricsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCustomMetricsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDetectMitigationActionsExecutions

        internal virtual ListDetectMitigationActionsExecutionsResponse ListDetectMitigationActionsExecutions(ListDetectMitigationActionsExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDetectMitigationActionsExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDetectMitigationActionsExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListDetectMitigationActionsExecutionsResponse>(request, options);
        }



        /// <summary>
        /// Lists mitigation actions executions for a Device Defender ML Detect Security Profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDetectMitigationActionsExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDetectMitigationActionsExecutions service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListDetectMitigationActionsExecutions">REST API Reference for ListDetectMitigationActionsExecutions Operation</seealso>
        public virtual Task<ListDetectMitigationActionsExecutionsResponse> ListDetectMitigationActionsExecutionsAsync(ListDetectMitigationActionsExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDetectMitigationActionsExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDetectMitigationActionsExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDetectMitigationActionsExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDetectMitigationActionsTasks

        internal virtual ListDetectMitigationActionsTasksResponse ListDetectMitigationActionsTasks(ListDetectMitigationActionsTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDetectMitigationActionsTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDetectMitigationActionsTasksResponseUnmarshaller.Instance;

            return Invoke<ListDetectMitigationActionsTasksResponse>(request, options);
        }



        /// <summary>
        /// List of Device Defender ML Detect mitigation actions tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDetectMitigationActionsTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDetectMitigationActionsTasks service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListDetectMitigationActionsTasks">REST API Reference for ListDetectMitigationActionsTasks Operation</seealso>
        public virtual Task<ListDetectMitigationActionsTasksResponse> ListDetectMitigationActionsTasksAsync(ListDetectMitigationActionsTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDetectMitigationActionsTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDetectMitigationActionsTasksResponseUnmarshaller.Instance;

            return InvokeAsync<ListDetectMitigationActionsTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDimensions

        internal virtual ListDimensionsResponse ListDimensions(ListDimensionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDimensionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDimensionsResponseUnmarshaller.Instance;

            return Invoke<ListDimensionsResponse>(request, options);
        }



        /// <summary>
        /// List the set of dimensions that are defined for your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDimensions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDimensions service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListDimensions">REST API Reference for ListDimensions Operation</seealso>
        public virtual Task<ListDimensionsResponse> ListDimensionsAsync(ListDimensionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDimensionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDimensionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDimensionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDomainConfigurations

        internal virtual ListDomainConfigurationsResponse ListDomainConfigurations(ListDomainConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListDomainConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of domain configurations for the user. This list is sorted alphabetically
        /// by domain configuration name.
        /// 
        ///  <note> 
        /// <para>
        /// The domain configuration feature is in public preview and is subject to change.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomainConfigurations service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListDomainConfigurations">REST API Reference for ListDomainConfigurations Operation</seealso>
        public virtual Task<ListDomainConfigurationsResponse> ListDomainConfigurationsAsync(ListDomainConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDomainConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListIndices

        internal virtual ListIndicesResponse ListIndices(ListIndicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIndicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIndicesResponseUnmarshaller.Instance;

            return Invoke<ListIndicesResponse>(request, options);
        }



        /// <summary>
        /// Lists the search indices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIndices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListIndicesResponse> ListIndicesAsync(ListIndicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIndicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIndicesResponseUnmarshaller.Instance;

            return InvokeAsync<ListIndicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListJobExecutionsForJob

        internal virtual ListJobExecutionsForJobResponse ListJobExecutionsForJob(ListJobExecutionsForJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobExecutionsForJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobExecutionsForJobResponseUnmarshaller.Instance;

            return Invoke<ListJobExecutionsForJobResponse>(request, options);
        }



        /// <summary>
        /// Lists the job executions for a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobExecutionsForJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListJobExecutionsForJobResponse> ListJobExecutionsForJobAsync(ListJobExecutionsForJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobExecutionsForJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobExecutionsForJobResponseUnmarshaller.Instance;

            return InvokeAsync<ListJobExecutionsForJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListJobExecutionsForThing

        internal virtual ListJobExecutionsForThingResponse ListJobExecutionsForThing(ListJobExecutionsForThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobExecutionsForThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobExecutionsForThingResponseUnmarshaller.Instance;

            return Invoke<ListJobExecutionsForThingResponse>(request, options);
        }



        /// <summary>
        /// Lists the job executions for the specified thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobExecutionsForThing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListJobExecutionsForThingResponse> ListJobExecutionsForThingAsync(ListJobExecutionsForThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobExecutionsForThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobExecutionsForThingResponseUnmarshaller.Instance;

            return InvokeAsync<ListJobExecutionsForThingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListJobs

        internal virtual ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsResponse>(request, options);
        }



        /// <summary>
        /// Lists jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMitigationActions

        internal virtual ListMitigationActionsResponse ListMitigationActions(ListMitigationActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMitigationActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMitigationActionsResponseUnmarshaller.Instance;

            return Invoke<ListMitigationActionsResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of all mitigation actions that match the specified filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMitigationActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMitigationActions service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListMitigationActions">REST API Reference for ListMitigationActions Operation</seealso>
        public virtual Task<ListMitigationActionsResponse> ListMitigationActionsAsync(ListMitigationActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMitigationActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMitigationActionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMitigationActionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOTAUpdates

        internal virtual ListOTAUpdatesResponse ListOTAUpdates(ListOTAUpdatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOTAUpdatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOTAUpdatesResponseUnmarshaller.Instance;

            return Invoke<ListOTAUpdatesResponse>(request, options);
        }



        /// <summary>
        /// Lists OTA updates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOTAUpdates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListOTAUpdatesResponse> ListOTAUpdatesAsync(ListOTAUpdatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOTAUpdatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOTAUpdatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListOTAUpdatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOutgoingCertificates

        internal virtual ListOutgoingCertificatesResponse ListOutgoingCertificates(ListOutgoingCertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOutgoingCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOutgoingCertificatesResponseUnmarshaller.Instance;

            return Invoke<ListOutgoingCertificatesResponse>(request, options);
        }



        /// <summary>
        /// Lists certificates that are being transferred but not yet accepted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOutgoingCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListOutgoingCertificatesResponse> ListOutgoingCertificatesAsync(ListOutgoingCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOutgoingCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOutgoingCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListOutgoingCertificatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPolicies

        internal virtual ListPoliciesResponse ListPolicies(ListPoliciesRequest request)
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
        /// Lists your policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
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
        public virtual Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPolicyPrincipals

        [Obsolete("Deprecated in favor of ListTargetsForPolicy.")]
        internal virtual ListPolicyPrincipalsResponse ListPolicyPrincipals(ListPolicyPrincipalsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPolicyPrincipalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyPrincipalsResponseUnmarshaller.Instance;

            return Invoke<ListPolicyPrincipalsResponse>(request, options);
        }



        /// <summary>
        /// Lists the principals associated with the specified policy.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This API is deprecated. Please use <a>ListTargetsForPolicy</a> instead.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyPrincipals service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListPolicyPrincipalsResponse> ListPolicyPrincipalsAsync(ListPolicyPrincipalsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPolicyPrincipalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyPrincipalsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPolicyPrincipalsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPolicyVersions

        internal virtual ListPolicyVersionsResponse ListPolicyVersions(ListPolicyVersionsRequest request)
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
        /// Lists the versions of the specified policy and identifies the default version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyVersions service method.</param>
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
        public virtual Task<ListPolicyVersionsResponse> ListPolicyVersionsAsync(ListPolicyVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPolicyVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPolicyVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPrincipalPolicies

        [Obsolete("Deprecated in favor of ListAttachedPolicies.")]
        internal virtual ListPrincipalPoliciesResponse ListPrincipalPolicies(ListPrincipalPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPrincipalPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrincipalPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListPrincipalPoliciesResponse>(request, options);
        }


        /// <summary>
        /// Lists the policies attached to the specified principal. If you use an Cognito identity,
        /// the ID must be in <a href="https://docs.aws.amazon.com/cognitoidentity/latest/APIReference/API_GetCredentialsForIdentity.html#API_GetCredentialsForIdentity_RequestSyntax">AmazonCognito
        /// Identity format</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This API is deprecated. Please use <a>ListAttachedPolicies</a> instead.
        /// </para>
        /// </summary>
        /// <param name="principal">The principal. Valid principals are CertificateArn (arn:aws:iot:<i>region</i>:<i>accountId</i>:cert/<i>certificateId</i>), thingGroupArn (arn:aws:iot:<i>region</i>:<i>accountId</i>:thinggroup/<i>groupName</i>) and CognitoId (<i>region</i>:<i>id</i>).</param>
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
        /// Lists the policies attached to the specified principal. If you use an Cognito identity,
        /// the ID must be in <a href="https://docs.aws.amazon.com/cognitoidentity/latest/APIReference/API_GetCredentialsForIdentity.html#API_GetCredentialsForIdentity_RequestSyntax">AmazonCognito
        /// Identity format</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This API is deprecated. Please use <a>ListAttachedPolicies</a> instead.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipalPolicies service method.</param>
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
        public virtual Task<ListPrincipalPoliciesResponse> ListPrincipalPoliciesAsync(ListPrincipalPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPrincipalPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrincipalPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPrincipalPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPrincipalThings

        internal virtual ListPrincipalThingsResponse ListPrincipalThings(ListPrincipalThingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPrincipalThingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrincipalThingsResponseUnmarshaller.Instance;

            return Invoke<ListPrincipalThingsResponse>(request, options);
        }


        /// <summary>
        /// Lists the things associated with the specified principal. A principal can be X.509
        /// certificates, IAM users, groups, and roles, Amazon Cognito identities or federated
        /// identities.
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
        /// Lists the things associated with the specified principal. A principal can be X.509
        /// certificates, IAM users, groups, and roles, Amazon Cognito identities or federated
        /// identities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipalThings service method.</param>
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
        public virtual Task<ListPrincipalThingsResponse> ListPrincipalThingsAsync(ListPrincipalThingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPrincipalThingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrincipalThingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPrincipalThingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProvisioningTemplates

        internal virtual ListProvisioningTemplatesResponse ListProvisioningTemplates(ListProvisioningTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisioningTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisioningTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListProvisioningTemplatesResponse>(request, options);
        }



        /// <summary>
        /// Lists the fleet provisioning templates in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisioningTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProvisioningTemplates service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListProvisioningTemplates">REST API Reference for ListProvisioningTemplates Operation</seealso>
        public virtual Task<ListProvisioningTemplatesResponse> ListProvisioningTemplatesAsync(ListProvisioningTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisioningTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisioningTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListProvisioningTemplatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProvisioningTemplateVersions

        internal virtual ListProvisioningTemplateVersionsResponse ListProvisioningTemplateVersions(ListProvisioningTemplateVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisioningTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisioningTemplateVersionsResponseUnmarshaller.Instance;

            return Invoke<ListProvisioningTemplateVersionsResponse>(request, options);
        }



        /// <summary>
        /// A list of fleet provisioning template versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisioningTemplateVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProvisioningTemplateVersions service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListProvisioningTemplateVersions">REST API Reference for ListProvisioningTemplateVersions Operation</seealso>
        public virtual Task<ListProvisioningTemplateVersionsResponse> ListProvisioningTemplateVersionsAsync(ListProvisioningTemplateVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisioningTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisioningTemplateVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProvisioningTemplateVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRoleAliases

        internal virtual ListRoleAliasesResponse ListRoleAliases(ListRoleAliasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRoleAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoleAliasesResponseUnmarshaller.Instance;

            return Invoke<ListRoleAliasesResponse>(request, options);
        }



        /// <summary>
        /// Lists the role aliases registered in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoleAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListRoleAliasesResponse> ListRoleAliasesAsync(ListRoleAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRoleAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoleAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRoleAliasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListScheduledAudits

        internal virtual ListScheduledAuditsResponse ListScheduledAudits(ListScheduledAuditsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListScheduledAuditsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScheduledAuditsResponseUnmarshaller.Instance;

            return Invoke<ListScheduledAuditsResponse>(request, options);
        }



        /// <summary>
        /// Lists all of your scheduled audits.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScheduledAudits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListScheduledAuditsResponse> ListScheduledAuditsAsync(ListScheduledAuditsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListScheduledAuditsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScheduledAuditsResponseUnmarshaller.Instance;

            return InvokeAsync<ListScheduledAuditsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSecurityProfiles

        internal virtual ListSecurityProfilesResponse ListSecurityProfiles(ListSecurityProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityProfilesResponseUnmarshaller.Instance;

            return Invoke<ListSecurityProfilesResponse>(request, options);
        }



        /// <summary>
        /// Lists the Device Defender security profiles you've created. You can filter security
        /// profiles by dimension or custom metric.
        /// 
        ///  <note> 
        /// <para>
        ///  <code>dimensionName</code> and <code>metricName</code> cannot be used in the same
        /// request.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSecurityProfiles service method, as returned by IoT.</returns>
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

        internal virtual ListSecurityProfilesForTargetResponse ListSecurityProfilesForTarget(ListSecurityProfilesForTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityProfilesForTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityProfilesForTargetResponseUnmarshaller.Instance;

            return Invoke<ListSecurityProfilesForTargetResponse>(request, options);
        }



        /// <summary>
        /// Lists the Device Defender security profiles attached to a target (thing group).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityProfilesForTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListSecurityProfilesForTargetResponse> ListSecurityProfilesForTargetAsync(ListSecurityProfilesForTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityProfilesForTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityProfilesForTargetResponseUnmarshaller.Instance;

            return InvokeAsync<ListSecurityProfilesForTargetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStreams

        internal virtual ListStreamsResponse ListStreams(ListStreamsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamsResponseUnmarshaller.Instance;

            return Invoke<ListStreamsResponse>(request, options);
        }



        /// <summary>
        /// Lists all of the streams in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreams service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListStreamsResponse> ListStreamsAsync(ListStreamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStreamsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags (metadata) you have assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTargetsForPolicy

        internal virtual ListTargetsForPolicyResponse ListTargetsForPolicy(ListTargetsForPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTargetsForPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetsForPolicyResponseUnmarshaller.Instance;

            return Invoke<ListTargetsForPolicyResponse>(request, options);
        }



        /// <summary>
        /// List targets for the specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetsForPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListTargetsForPolicyResponse> ListTargetsForPolicyAsync(ListTargetsForPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTargetsForPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetsForPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<ListTargetsForPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTargetsForSecurityProfile

        internal virtual ListTargetsForSecurityProfileResponse ListTargetsForSecurityProfile(ListTargetsForSecurityProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTargetsForSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetsForSecurityProfileResponseUnmarshaller.Instance;

            return Invoke<ListTargetsForSecurityProfileResponse>(request, options);
        }



        /// <summary>
        /// Lists the targets (thing groups) associated with a given Device Defender security
        /// profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetsForSecurityProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListTargetsForSecurityProfileResponse> ListTargetsForSecurityProfileAsync(ListTargetsForSecurityProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTargetsForSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetsForSecurityProfileResponseUnmarshaller.Instance;

            return InvokeAsync<ListTargetsForSecurityProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListThingGroups

        internal virtual ListThingGroupsResponse ListThingGroups(ListThingGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingGroupsResponseUnmarshaller.Instance;

            return Invoke<ListThingGroupsResponse>(request, options);
        }



        /// <summary>
        /// List the thing groups in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThingGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
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

        internal virtual ListThingGroupsForThingResponse ListThingGroupsForThing(ListThingGroupsForThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingGroupsForThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingGroupsForThingResponseUnmarshaller.Instance;

            return Invoke<ListThingGroupsForThingResponse>(request, options);
        }



        /// <summary>
        /// List the thing groups to which the specified thing belongs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThingGroupsForThing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
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

        internal virtual ListThingPrincipalsResponse ListThingPrincipals(ListThingPrincipalsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingPrincipalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingPrincipalsResponseUnmarshaller.Instance;

            return Invoke<ListThingPrincipalsResponse>(request, options);
        }


        /// <summary>
        /// Lists the principals associated with the specified thing. A principal can be X.509
        /// certificates, IAM users, groups, and roles, Amazon Cognito identities or federated
        /// identities.
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
        /// Lists the principals associated with the specified thing. A principal can be X.509
        /// certificates, IAM users, groups, and roles, Amazon Cognito identities or federated
        /// identities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThingPrincipals service method.</param>
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
        public virtual Task<ListThingPrincipalsResponse> ListThingPrincipalsAsync(ListThingPrincipalsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingPrincipalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingPrincipalsResponseUnmarshaller.Instance;

            return InvokeAsync<ListThingPrincipalsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListThingRegistrationTaskReports

        internal virtual ListThingRegistrationTaskReportsResponse ListThingRegistrationTaskReports(ListThingRegistrationTaskReportsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingRegistrationTaskReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingRegistrationTaskReportsResponseUnmarshaller.Instance;

            return Invoke<ListThingRegistrationTaskReportsResponse>(request, options);
        }



        /// <summary>
        /// Information about the thing registration tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThingRegistrationTaskReports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListThingRegistrationTaskReportsResponse> ListThingRegistrationTaskReportsAsync(ListThingRegistrationTaskReportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingRegistrationTaskReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingRegistrationTaskReportsResponseUnmarshaller.Instance;

            return InvokeAsync<ListThingRegistrationTaskReportsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListThingRegistrationTasks

        internal virtual ListThingRegistrationTasksResponse ListThingRegistrationTasks(ListThingRegistrationTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingRegistrationTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingRegistrationTasksResponseUnmarshaller.Instance;

            return Invoke<ListThingRegistrationTasksResponse>(request, options);
        }



        /// <summary>
        /// List bulk thing provisioning tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThingRegistrationTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListThingRegistrationTasksResponse> ListThingRegistrationTasksAsync(ListThingRegistrationTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingRegistrationTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingRegistrationTasksResponseUnmarshaller.Instance;

            return InvokeAsync<ListThingRegistrationTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListThings

        internal virtual ListThingsResponse ListThings(ListThingsRequest request)
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
        /// 
        ///  <note> 
        /// <para>
        /// You will not be charged for calling this API if an <code>Access denied</code> error
        /// is returned. You will also not be charged if no attributes or pagination token was
        /// provided in request and no pagination token and no results were returned.
        /// </para>
        ///  </note>
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
        /// Lists your things. Use the <b>attributeName</b> and <b>attributeValue</b> parameters
        /// to filter your things. For example, calling <code>ListThings</code> with attributeName=Color
        /// and attributeValue=Red retrieves all things in the registry that contain an attribute
        /// <b>Color</b> with the value <b>Red</b>. 
        /// 
        ///  <note> 
        /// <para>
        /// You will not be charged for calling this API if an <code>Access denied</code> error
        /// is returned. You will also not be charged if no attributes or pagination token was
        /// provided in request and no pagination token and no results were returned.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThings service method.</param>
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
        public virtual Task<ListThingsResponse> ListThingsAsync(ListThingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListThingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListThingsInBillingGroup

        internal virtual ListThingsInBillingGroupResponse ListThingsInBillingGroup(ListThingsInBillingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingsInBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingsInBillingGroupResponseUnmarshaller.Instance;

            return Invoke<ListThingsInBillingGroupResponse>(request, options);
        }



        /// <summary>
        /// Lists the things you have added to the given billing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThingsInBillingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListThingsInBillingGroupResponse> ListThingsInBillingGroupAsync(ListThingsInBillingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingsInBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingsInBillingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ListThingsInBillingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListThingsInThingGroup

        internal virtual ListThingsInThingGroupResponse ListThingsInThingGroup(ListThingsInThingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingsInThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingsInThingGroupResponseUnmarshaller.Instance;

            return Invoke<ListThingsInThingGroupResponse>(request, options);
        }



        /// <summary>
        /// Lists the things in the specified group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThingsInThingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
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

        internal virtual ListThingTypesResponse ListThingTypes(ListThingTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingTypesResponseUnmarshaller.Instance;

            return Invoke<ListThingTypesResponse>(request, options);
        }



        /// <summary>
        /// Lists the existing thing types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThingTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListThingTypesResponse> ListThingTypesAsync(ListThingTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThingTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThingTypesResponseUnmarshaller.Instance;

            return InvokeAsync<ListThingTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTopicRuleDestinations

        internal virtual ListTopicRuleDestinationsResponse ListTopicRuleDestinations(ListTopicRuleDestinationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTopicRuleDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTopicRuleDestinationsResponseUnmarshaller.Instance;

            return Invoke<ListTopicRuleDestinationsResponse>(request, options);
        }



        /// <summary>
        /// Lists all the topic rule destinations in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTopicRuleDestinations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTopicRuleDestinations service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTopicRuleDestinations">REST API Reference for ListTopicRuleDestinations Operation</seealso>
        public virtual Task<ListTopicRuleDestinationsResponse> ListTopicRuleDestinationsAsync(ListTopicRuleDestinationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTopicRuleDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTopicRuleDestinationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTopicRuleDestinationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTopicRules

        internal virtual ListTopicRulesResponse ListTopicRules(ListTopicRulesRequest request)
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
        /// Lists the rules for the specific topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTopicRules service method.</param>
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
        public virtual Task<ListTopicRulesResponse> ListTopicRulesAsync(ListTopicRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTopicRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTopicRulesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTopicRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListV2LoggingLevels

        internal virtual ListV2LoggingLevelsResponse ListV2LoggingLevels(ListV2LoggingLevelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListV2LoggingLevelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListV2LoggingLevelsResponseUnmarshaller.Instance;

            return Invoke<ListV2LoggingLevelsResponse>(request, options);
        }



        /// <summary>
        /// Lists logging levels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListV2LoggingLevels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListV2LoggingLevelsResponse> ListV2LoggingLevelsAsync(ListV2LoggingLevelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListV2LoggingLevelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListV2LoggingLevelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListV2LoggingLevelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListViolationEvents

        internal virtual ListViolationEventsResponse ListViolationEvents(ListViolationEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListViolationEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListViolationEventsResponseUnmarshaller.Instance;

            return Invoke<ListViolationEventsResponse>(request, options);
        }



        /// <summary>
        /// Lists the Device Defender security profile violations discovered during the given
        /// time period. You can use filters to limit the results to those alerts issued for a
        /// particular security profile, behavior, or thing (device).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListViolationEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListViolationEventsResponse> ListViolationEventsAsync(ListViolationEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListViolationEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListViolationEventsResponseUnmarshaller.Instance;

            return InvokeAsync<ListViolationEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterCACertificate

        internal virtual RegisterCACertificateResponse RegisterCACertificate(RegisterCACertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterCACertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterCACertificateResponseUnmarshaller.Instance;

            return Invoke<RegisterCACertificateResponse>(request, options);
        }



        /// <summary>
        /// Registers a CA certificate with AWS IoT. This CA certificate can then be used to sign
        /// device certificates, which can be then registered with AWS IoT. You can register up
        /// to 10 CA certificates per AWS account that have the same subject field. This enables
        /// you to have up to 10 certificate authorities sign your device certificates. If you
        /// have more than one CA certificate registered, make sure you pass the CA certificate
        /// when you register your device certificates with the RegisterCertificate API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterCACertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RegisterCACertificateResponse> RegisterCACertificateAsync(RegisterCACertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterCACertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterCACertificateResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterCACertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterCertificate

        internal virtual RegisterCertificateResponse RegisterCertificate(RegisterCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterCertificateResponseUnmarshaller.Instance;

            return Invoke<RegisterCertificateResponse>(request, options);
        }



        /// <summary>
        /// Registers a device certificate with AWS IoT. If you have more than one CA certificate
        /// that has the same subject field, you must specify the CA certificate that was used
        /// to sign the device certificate being registered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RegisterCertificateResponse> RegisterCertificateAsync(RegisterCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterCertificateWithoutCA

        internal virtual RegisterCertificateWithoutCAResponse RegisterCertificateWithoutCA(RegisterCertificateWithoutCARequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterCertificateWithoutCARequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterCertificateWithoutCAResponseUnmarshaller.Instance;

            return Invoke<RegisterCertificateWithoutCAResponse>(request, options);
        }



        /// <summary>
        /// Register a certificate that does not have a certificate authority (CA).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterCertificateWithoutCA service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterCertificateWithoutCA service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RegisterCertificateWithoutCA">REST API Reference for RegisterCertificateWithoutCA Operation</seealso>
        public virtual Task<RegisterCertificateWithoutCAResponse> RegisterCertificateWithoutCAAsync(RegisterCertificateWithoutCARequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterCertificateWithoutCARequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterCertificateWithoutCAResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterCertificateWithoutCAResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterThing

        internal virtual RegisterThingResponse RegisterThing(RegisterThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterThingResponseUnmarshaller.Instance;

            return Invoke<RegisterThingResponse>(request, options);
        }



        /// <summary>
        /// Provisions a thing in the device registry. RegisterThing calls other AWS IoT control
        /// plane APIs. These calls might exceed your account level <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_iot">
        /// AWS IoT Throttling Limits</a> and cause throttle errors. Please contact <a href="https://console.aws.amazon.com/support/home">AWS
        /// Customer Support</a> to raise your throttling limits if necessary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterThing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RegisterThingResponse> RegisterThingAsync(RegisterThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterThingResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterThingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectCertificateTransfer

        internal virtual RejectCertificateTransferResponse RejectCertificateTransfer(RejectCertificateTransferRequest request)
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
        public virtual Task<RejectCertificateTransferResponse> RejectCertificateTransferAsync(RejectCertificateTransferRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectCertificateTransferRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectCertificateTransferResponseUnmarshaller.Instance;

            return InvokeAsync<RejectCertificateTransferResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveThingFromBillingGroup

        internal virtual RemoveThingFromBillingGroupResponse RemoveThingFromBillingGroup(RemoveThingFromBillingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveThingFromBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveThingFromBillingGroupResponseUnmarshaller.Instance;

            return Invoke<RemoveThingFromBillingGroupResponse>(request, options);
        }



        /// <summary>
        /// Removes the given thing from the billing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveThingFromBillingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RemoveThingFromBillingGroupResponse> RemoveThingFromBillingGroupAsync(RemoveThingFromBillingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveThingFromBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveThingFromBillingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveThingFromBillingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveThingFromThingGroup

        internal virtual RemoveThingFromThingGroupResponse RemoveThingFromThingGroup(RemoveThingFromThingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveThingFromThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveThingFromThingGroupResponseUnmarshaller.Instance;

            return Invoke<RemoveThingFromThingGroupResponse>(request, options);
        }



        /// <summary>
        /// Remove the specified thing from the specified group.
        /// 
        ///  
        /// <para>
        /// You must specify either a <code>thingGroupArn</code> or a <code>thingGroupName</code>
        /// to identify the thing group and either a <code>thingArn</code> or a <code>thingName</code>
        /// to identify the thing to remove from the thing group. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveThingFromThingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RemoveThingFromThingGroupResponse> RemoveThingFromThingGroupAsync(RemoveThingFromThingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveThingFromThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveThingFromThingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveThingFromThingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReplaceTopicRule

        internal virtual ReplaceTopicRuleResponse ReplaceTopicRule(ReplaceTopicRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceTopicRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceTopicRuleResponseUnmarshaller.Instance;

            return Invoke<ReplaceTopicRuleResponse>(request, options);
        }



        /// <summary>
        /// Replaces the rule. You must specify all parameters for the new rule. Creating rules
        /// is an administrator-level action. Any user who has permission to create rules will
        /// be able to access data processed by the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceTopicRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ReplaceTopicRuleResponse> ReplaceTopicRuleAsync(ReplaceTopicRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceTopicRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceTopicRuleResponseUnmarshaller.Instance;

            return InvokeAsync<ReplaceTopicRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchIndex

        internal virtual SearchIndexResponse SearchIndex(SearchIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchIndexResponseUnmarshaller.Instance;

            return Invoke<SearchIndexResponse>(request, options);
        }



        /// <summary>
        /// The query search index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<SearchIndexResponse> SearchIndexAsync(SearchIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchIndexResponseUnmarshaller.Instance;

            return InvokeAsync<SearchIndexResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetDefaultAuthorizer

        internal virtual SetDefaultAuthorizerResponse SetDefaultAuthorizer(SetDefaultAuthorizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetDefaultAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDefaultAuthorizerResponseUnmarshaller.Instance;

            return Invoke<SetDefaultAuthorizerResponse>(request, options);
        }



        /// <summary>
        /// Sets the default authorizer. This will be used if a websocket connection is made without
        /// specifying an authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultAuthorizer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<SetDefaultAuthorizerResponse> SetDefaultAuthorizerAsync(SetDefaultAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetDefaultAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDefaultAuthorizerResponseUnmarshaller.Instance;

            return InvokeAsync<SetDefaultAuthorizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetDefaultPolicyVersion

        internal virtual SetDefaultPolicyVersionResponse SetDefaultPolicyVersion(SetDefaultPolicyVersionRequest request)
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
        /// Sets the specified version of the specified policy as the policy's default (operative)
        /// version. This action affects all certificates to which the policy is attached. To
        /// list the principals the policy is attached to, use the ListPrincipalPolicy API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultPolicyVersion service method.</param>
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
        public virtual Task<SetDefaultPolicyVersionResponse> SetDefaultPolicyVersionAsync(SetDefaultPolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetDefaultPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDefaultPolicyVersionResponseUnmarshaller.Instance;

            return InvokeAsync<SetDefaultPolicyVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetLoggingOptions

        internal virtual SetLoggingOptionsResponse SetLoggingOptions(SetLoggingOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetLoggingOptionsResponseUnmarshaller.Instance;

            return Invoke<SetLoggingOptionsResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<SetLoggingOptionsResponse> SetLoggingOptionsAsync(SetLoggingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetLoggingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<SetLoggingOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetV2LoggingLevel

        internal virtual SetV2LoggingLevelResponse SetV2LoggingLevel(SetV2LoggingLevelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetV2LoggingLevelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetV2LoggingLevelResponseUnmarshaller.Instance;

            return Invoke<SetV2LoggingLevelResponse>(request, options);
        }



        /// <summary>
        /// Sets the logging level.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetV2LoggingLevel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetV2LoggingLevel service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.NotConfiguredException">
        /// The resource is not configured.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
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

        internal virtual SetV2LoggingOptionsResponse SetV2LoggingOptions(SetV2LoggingOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetV2LoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetV2LoggingOptionsResponseUnmarshaller.Instance;

            return Invoke<SetV2LoggingOptionsResponse>(request, options);
        }



        /// <summary>
        /// Sets the logging options for the V2 logging service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetV2LoggingOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<SetV2LoggingOptionsResponse> SetV2LoggingOptionsAsync(SetV2LoggingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetV2LoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetV2LoggingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<SetV2LoggingOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartAuditMitigationActionsTask

        internal virtual StartAuditMitigationActionsTaskResponse StartAuditMitigationActionsTask(StartAuditMitigationActionsTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAuditMitigationActionsTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAuditMitigationActionsTaskResponseUnmarshaller.Instance;

            return Invoke<StartAuditMitigationActionsTaskResponse>(request, options);
        }



        /// <summary>
        /// Starts a task that applies a set of mitigation actions to the specified target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAuditMitigationActionsTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAuditMitigationActionsTask service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.TaskAlreadyExistsException">
        /// This exception occurs if you attempt to start a task with the same task-id as an
        /// existing task but with a different clientRequestToken.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/StartAuditMitigationActionsTask">REST API Reference for StartAuditMitigationActionsTask Operation</seealso>
        public virtual Task<StartAuditMitigationActionsTaskResponse> StartAuditMitigationActionsTaskAsync(StartAuditMitigationActionsTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAuditMitigationActionsTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAuditMitigationActionsTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StartAuditMitigationActionsTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartDetectMitigationActionsTask

        internal virtual StartDetectMitigationActionsTaskResponse StartDetectMitigationActionsTask(StartDetectMitigationActionsTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDetectMitigationActionsTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDetectMitigationActionsTaskResponseUnmarshaller.Instance;

            return Invoke<StartDetectMitigationActionsTaskResponse>(request, options);
        }



        /// <summary>
        /// Starts a Device Defender ML Detect mitigation actions task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDetectMitigationActionsTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDetectMitigationActionsTask service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.TaskAlreadyExistsException">
        /// This exception occurs if you attempt to start a task with the same task-id as an
        /// existing task but with a different clientRequestToken.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/StartDetectMitigationActionsTask">REST API Reference for StartDetectMitigationActionsTask Operation</seealso>
        public virtual Task<StartDetectMitigationActionsTaskResponse> StartDetectMitigationActionsTaskAsync(StartDetectMitigationActionsTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDetectMitigationActionsTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDetectMitigationActionsTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StartDetectMitigationActionsTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartOnDemandAuditTask

        internal virtual StartOnDemandAuditTaskResponse StartOnDemandAuditTask(StartOnDemandAuditTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartOnDemandAuditTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartOnDemandAuditTaskResponseUnmarshaller.Instance;

            return Invoke<StartOnDemandAuditTaskResponse>(request, options);
        }



        /// <summary>
        /// Starts an on-demand Device Defender audit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartOnDemandAuditTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartOnDemandAuditTaskResponse> StartOnDemandAuditTaskAsync(StartOnDemandAuditTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartOnDemandAuditTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartOnDemandAuditTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StartOnDemandAuditTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartThingRegistrationTask

        internal virtual StartThingRegistrationTaskResponse StartThingRegistrationTask(StartThingRegistrationTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartThingRegistrationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartThingRegistrationTaskResponseUnmarshaller.Instance;

            return Invoke<StartThingRegistrationTaskResponse>(request, options);
        }



        /// <summary>
        /// Creates a bulk thing provisioning task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartThingRegistrationTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartThingRegistrationTaskResponse> StartThingRegistrationTaskAsync(StartThingRegistrationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartThingRegistrationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartThingRegistrationTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StartThingRegistrationTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopThingRegistrationTask

        internal virtual StopThingRegistrationTaskResponse StopThingRegistrationTask(StopThingRegistrationTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopThingRegistrationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopThingRegistrationTaskResponseUnmarshaller.Instance;

            return Invoke<StopThingRegistrationTaskResponse>(request, options);
        }



        /// <summary>
        /// Cancels a bulk thing provisioning task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopThingRegistrationTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StopThingRegistrationTaskResponse> StopThingRegistrationTaskAsync(StopThingRegistrationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopThingRegistrationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopThingRegistrationTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StopThingRegistrationTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds to or modifies the tags of the given resource. Tags are metadata which can be
        /// used to manage a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TestAuthorization

        internal virtual TestAuthorizationResponse TestAuthorization(TestAuthorizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestAuthorizationResponseUnmarshaller.Instance;

            return Invoke<TestAuthorizationResponse>(request, options);
        }



        /// <summary>
        /// Tests if a specified principal is authorized to perform an AWS IoT action on a specified
        /// resource. Use this to test and debug the authorization behavior of devices that connect
        /// to the AWS IoT device gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<TestAuthorizationResponse> TestAuthorizationAsync(TestAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestAuthorizationResponseUnmarshaller.Instance;

            return InvokeAsync<TestAuthorizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TestInvokeAuthorizer

        internal virtual TestInvokeAuthorizerResponse TestInvokeAuthorizer(TestInvokeAuthorizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestInvokeAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestInvokeAuthorizerResponseUnmarshaller.Instance;

            return Invoke<TestInvokeAuthorizerResponse>(request, options);
        }



        /// <summary>
        /// Tests a custom authorization behavior by invoking a specified custom authorizer. Use
        /// this to test and debug the custom authorization behavior of devices that connect to
        /// the AWS IoT device gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestInvokeAuthorizer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<TestInvokeAuthorizerResponse> TestInvokeAuthorizerAsync(TestInvokeAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestInvokeAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestInvokeAuthorizerResponseUnmarshaller.Instance;

            return InvokeAsync<TestInvokeAuthorizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TransferCertificate

        internal virtual TransferCertificateResponse TransferCertificate(TransferCertificateRequest request)
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
        public virtual Task<TransferCertificateResponse> TransferCertificateAsync(TransferCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TransferCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TransferCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<TransferCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes the given tags (metadata) from the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAccountAuditConfiguration

        internal virtual UpdateAccountAuditConfigurationResponse UpdateAccountAuditConfiguration(UpdateAccountAuditConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountAuditConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountAuditConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountAuditConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Configures or reconfigures the Device Defender audit settings for this account. Settings
        /// include how audit notifications are sent and which audit checks are enabled or disabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountAuditConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateAccountAuditConfigurationResponse> UpdateAccountAuditConfigurationAsync(UpdateAccountAuditConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountAuditConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountAuditConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAccountAuditConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAuditSuppression

        internal virtual UpdateAuditSuppressionResponse UpdateAuditSuppression(UpdateAuditSuppressionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAuditSuppressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuditSuppressionResponseUnmarshaller.Instance;

            return Invoke<UpdateAuditSuppressionResponse>(request, options);
        }



        /// <summary>
        /// Updates a Device Defender audit suppression.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuditSuppression service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAuditSuppression service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateAuditSuppression">REST API Reference for UpdateAuditSuppression Operation</seealso>
        public virtual Task<UpdateAuditSuppressionResponse> UpdateAuditSuppressionAsync(UpdateAuditSuppressionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAuditSuppressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuditSuppressionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAuditSuppressionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAuthorizer

        internal virtual UpdateAuthorizerResponse UpdateAuthorizer(UpdateAuthorizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuthorizerResponseUnmarshaller.Instance;

            return Invoke<UpdateAuthorizerResponse>(request, options);
        }



        /// <summary>
        /// Updates an authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthorizer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateAuthorizerResponse> UpdateAuthorizerAsync(UpdateAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuthorizerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAuthorizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateBillingGroup

        internal virtual UpdateBillingGroupResponse UpdateBillingGroup(UpdateBillingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBillingGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateBillingGroupResponse>(request, options);
        }



        /// <summary>
        /// Updates information about the billing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBillingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateBillingGroupResponse> UpdateBillingGroupAsync(UpdateBillingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBillingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBillingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCACertificate

        internal virtual UpdateCACertificateResponse UpdateCACertificate(UpdateCACertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCACertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCACertificateResponseUnmarshaller.Instance;

            return Invoke<UpdateCACertificateResponse>(request, options);
        }



        /// <summary>
        /// Updates a registered CA certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCACertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateCACertificateResponse> UpdateCACertificateAsync(UpdateCACertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCACertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCACertificateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCACertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCertificate

        internal virtual UpdateCertificateResponse UpdateCertificate(UpdateCertificateRequest request)
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
        /// Certificates must be in the ACTIVE state to authenticate devices that use a certificate
        /// to connect to AWS IoT.
        /// </para>
        ///  
        /// <para>
        /// Within a few minutes of updating a certificate from the ACTIVE state to any other
        /// state, AWS IoT disconnects all devices that used that certificate to connect. Devices
        /// cannot use a certificate that is not in the ACTIVE state to reconnect.
        /// </para>
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// <param name="newStatus">The new status.  <b>Note:</b> Setting the status to PENDING_TRANSFER or PENDING_ACTIVATION will result in an exception being thrown. PENDING_TRANSFER and PENDING_ACTIVATION are statuses used internally by AWS IoT. They are not intended for developer use.  <b>Note:</b> The status value REGISTER_INACTIVE is deprecated and should not be used.</param>
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
        /// Updates the status of the specified certificate. This operation is idempotent.
        /// 
        ///  
        /// <para>
        /// Certificates must be in the ACTIVE state to authenticate devices that use a certificate
        /// to connect to AWS IoT.
        /// </para>
        ///  
        /// <para>
        /// Within a few minutes of updating a certificate from the ACTIVE state to any other
        /// state, AWS IoT disconnects all devices that used that certificate to connect. Devices
        /// cannot use a certificate that is not in the ACTIVE state to reconnect.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCertificate service method.</param>
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
        public virtual Task<UpdateCertificateResponse> UpdateCertificateAsync(UpdateCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCustomMetric

        internal virtual UpdateCustomMetricResponse UpdateCustomMetric(UpdateCustomMetricRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCustomMetricRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomMetricResponseUnmarshaller.Instance;

            return Invoke<UpdateCustomMetricResponse>(request, options);
        }



        /// <summary>
        /// Updates a Device Defender detect custom metric.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomMetric service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCustomMetric service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateCustomMetric">REST API Reference for UpdateCustomMetric Operation</seealso>
        public virtual Task<UpdateCustomMetricResponse> UpdateCustomMetricAsync(UpdateCustomMetricRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCustomMetricRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomMetricResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCustomMetricResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDimension

        internal virtual UpdateDimensionResponse UpdateDimension(UpdateDimensionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDimensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDimensionResponseUnmarshaller.Instance;

            return Invoke<UpdateDimensionResponse>(request, options);
        }



        /// <summary>
        /// Updates the definition for a dimension. You cannot change the type of a dimension
        /// after it is created (you can delete it and recreate it).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDimension service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDimension service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateDimension">REST API Reference for UpdateDimension Operation</seealso>
        public virtual Task<UpdateDimensionResponse> UpdateDimensionAsync(UpdateDimensionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDimensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDimensionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDimensionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDomainConfiguration

        internal virtual UpdateDomainConfigurationResponse UpdateDomainConfiguration(UpdateDomainConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates values stored in the domain configuration. Domain configurations for default
        /// endpoints can't be updated.
        /// 
        ///  <note> 
        /// <para>
        /// The domain configuration feature is in public preview and is subject to change.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomainConfiguration service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.CertificateValidationException">
        /// The certificate is invalid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateDomainConfiguration">REST API Reference for UpdateDomainConfiguration Operation</seealso>
        public virtual Task<UpdateDomainConfigurationResponse> UpdateDomainConfigurationAsync(UpdateDomainConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDomainConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDynamicThingGroup

        internal virtual UpdateDynamicThingGroupResponse UpdateDynamicThingGroup(UpdateDynamicThingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDynamicThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDynamicThingGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateDynamicThingGroupResponse>(request, options);
        }



        /// <summary>
        /// Updates a dynamic thing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDynamicThingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateDynamicThingGroupResponse> UpdateDynamicThingGroupAsync(UpdateDynamicThingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDynamicThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDynamicThingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDynamicThingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEventConfigurations

        internal virtual UpdateEventConfigurationsResponse UpdateEventConfigurations(UpdateEventConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventConfigurationsResponseUnmarshaller.Instance;

            return Invoke<UpdateEventConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Updates the event configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateEventConfigurationsResponse> UpdateEventConfigurationsAsync(UpdateEventConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEventConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateIndexingConfiguration

        internal virtual UpdateIndexingConfigurationResponse UpdateIndexingConfiguration(UpdateIndexingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIndexingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIndexingConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateIndexingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates the search configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIndexingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateIndexingConfigurationResponse> UpdateIndexingConfigurationAsync(UpdateIndexingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIndexingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIndexingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIndexingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateJob

        internal virtual UpdateJobResponse UpdateJob(UpdateJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobResponseUnmarshaller.Instance;

            return Invoke<UpdateJobResponse>(request, options);
        }



        /// <summary>
        /// Updates supported fields of the specified job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMitigationAction

        internal virtual UpdateMitigationActionResponse UpdateMitigationAction(UpdateMitigationActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMitigationActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMitigationActionResponseUnmarshaller.Instance;

            return Invoke<UpdateMitigationActionResponse>(request, options);
        }



        /// <summary>
        /// Updates the definition for the specified mitigation action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMitigationAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMitigationAction service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateMitigationAction">REST API Reference for UpdateMitigationAction Operation</seealso>
        public virtual Task<UpdateMitigationActionResponse> UpdateMitigationActionAsync(UpdateMitigationActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMitigationActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMitigationActionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMitigationActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateProvisioningTemplate

        internal virtual UpdateProvisioningTemplateResponse UpdateProvisioningTemplate(UpdateProvisioningTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProvisioningTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProvisioningTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateProvisioningTemplateResponse>(request, options);
        }



        /// <summary>
        /// Updates a fleet provisioning template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisioningTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProvisioningTemplate service method, as returned by IoT.</returns>
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
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateProvisioningTemplate">REST API Reference for UpdateProvisioningTemplate Operation</seealso>
        public virtual Task<UpdateProvisioningTemplateResponse> UpdateProvisioningTemplateAsync(UpdateProvisioningTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProvisioningTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProvisioningTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProvisioningTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRoleAlias

        internal virtual UpdateRoleAliasResponse UpdateRoleAlias(UpdateRoleAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoleAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoleAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateRoleAliasResponse>(request, options);
        }



        /// <summary>
        /// Updates a role alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoleAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateRoleAliasResponse> UpdateRoleAliasAsync(UpdateRoleAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoleAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoleAliasResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRoleAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateScheduledAudit

        internal virtual UpdateScheduledAuditResponse UpdateScheduledAudit(UpdateScheduledAuditRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateScheduledAuditRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScheduledAuditResponseUnmarshaller.Instance;

            return Invoke<UpdateScheduledAuditResponse>(request, options);
        }



        /// <summary>
        /// Updates a scheduled audit, including which checks are performed and how often the
        /// audit takes place.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScheduledAudit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateScheduledAuditResponse> UpdateScheduledAuditAsync(UpdateScheduledAuditRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateScheduledAuditRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScheduledAuditResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateScheduledAuditResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSecurityProfile

        internal virtual UpdateSecurityProfileResponse UpdateSecurityProfile(UpdateSecurityProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateSecurityProfileResponse>(request, options);
        }



        /// <summary>
        /// Updates a Device Defender security profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateSecurityProfileResponse> UpdateSecurityProfileAsync(UpdateSecurityProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSecurityProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateStream

        internal virtual UpdateStreamResponse UpdateStream(UpdateStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStreamResponseUnmarshaller.Instance;

            return Invoke<UpdateStreamResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing stream. The stream version will be incremented by one.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateStreamResponse> UpdateStreamAsync(UpdateStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStreamResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateThing

        internal virtual UpdateThingResponse UpdateThing(UpdateThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThingResponseUnmarshaller.Instance;

            return Invoke<UpdateThingResponse>(request, options);
        }



        /// <summary>
        /// Updates the data for a thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateThingResponse> UpdateThingAsync(UpdateThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThingResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateThingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateThingGroup

        internal virtual UpdateThingGroupResponse UpdateThingGroup(UpdateThingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThingGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateThingGroupResponse>(request, options);
        }



        /// <summary>
        /// Update a thing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateThingGroupResponse> UpdateThingGroupAsync(UpdateThingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateThingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateThingGroupsForThing

        internal virtual UpdateThingGroupsForThingResponse UpdateThingGroupsForThing(UpdateThingGroupsForThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThingGroupsForThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThingGroupsForThingResponseUnmarshaller.Instance;

            return Invoke<UpdateThingGroupsForThingResponse>(request, options);
        }



        /// <summary>
        /// Updates the groups to which the thing belongs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThingGroupsForThing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateThingGroupsForThingResponse> UpdateThingGroupsForThingAsync(UpdateThingGroupsForThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThingGroupsForThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThingGroupsForThingResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateThingGroupsForThingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTopicRuleDestination

        internal virtual UpdateTopicRuleDestinationResponse UpdateTopicRuleDestination(UpdateTopicRuleDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTopicRuleDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTopicRuleDestinationResponseUnmarshaller.Instance;

            return Invoke<UpdateTopicRuleDestinationResponse>(request, options);
        }



        /// <summary>
        /// Updates a topic rule destination. You use this to change the status, endpoint URL,
        /// or confirmation URL of the destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTopicRuleDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTopicRuleDestination service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateTopicRuleDestination">REST API Reference for UpdateTopicRuleDestination Operation</seealso>
        public virtual Task<UpdateTopicRuleDestinationResponse> UpdateTopicRuleDestinationAsync(UpdateTopicRuleDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTopicRuleDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTopicRuleDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTopicRuleDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ValidateSecurityProfileBehaviors

        internal virtual ValidateSecurityProfileBehaviorsResponse ValidateSecurityProfileBehaviors(ValidateSecurityProfileBehaviorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateSecurityProfileBehaviorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateSecurityProfileBehaviorsResponseUnmarshaller.Instance;

            return Invoke<ValidateSecurityProfileBehaviorsResponse>(request, options);
        }



        /// <summary>
        /// Validates a Device Defender security profile behaviors specification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateSecurityProfileBehaviors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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