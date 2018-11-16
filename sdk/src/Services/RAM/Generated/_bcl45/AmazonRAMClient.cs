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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.RAM.Model;
using Amazon.RAM.Model.Internal.MarshallTransformations;
using Amazon.RAM.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.RAM
{
    /// <summary>
    /// Implementation for accessing RAM
    ///
    /// Use AWS Resource Access Manager to share AWS resources between AWS accounts. To share
    /// a resource, you create a resource share, associate the resource with the resource
    /// share, and specify the principals that can access the resource. The following principals
    /// are supported:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The ID of an AWS account
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The Amazon Resource Name (ARN) of an OU from AWS Organizations
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The Amazon Resource Name (ARN) of an organization from AWS Organizations
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you specify an AWS account that doesn't exist in the same organization as the account
    /// that owns the resource share, the owner of the specified account receives an invitation
    /// to accept the resource share. After the owner accepts the invitation, they can access
    /// the resources in the resource share. An administrator of the specified account can
    /// use IAM policies to restrict access resources in the resource share.
    /// </para>
    /// </summary>
    public partial class AmazonRAMClient : AmazonServiceClient, IAmazonRAM
    {
        private static IServiceMetadata serviceMetadata = new AmazonRAMMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonRAMClient with the credentials loaded from the application's
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
        public AmazonRAMClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRAMConfig()) { }

        /// <summary>
        /// Constructs AmazonRAMClient with the credentials loaded from the application's
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
        public AmazonRAMClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRAMConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRAMClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRAMClient Configuration Object</param>
        public AmazonRAMClient(AmazonRAMConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonRAMClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRAMClient(AWSCredentials credentials)
            : this(credentials, new AmazonRAMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRAMClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRAMClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRAMConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRAMClient with AWS Credentials and an
        /// AmazonRAMClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRAMClient Configuration Object</param>
        public AmazonRAMClient(AWSCredentials credentials, AmazonRAMConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRAMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRAMClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRAMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRAMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRAMClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRAMConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRAMClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRAMClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRAMClient Configuration Object</param>
        public AmazonRAMClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRAMConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRAMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRAMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRAMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRAMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRAMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRAMConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRAMClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRAMClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRAMClient Configuration Object</param>
        public AmazonRAMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRAMConfig clientConfig)
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

        
        #region  AcceptResourceShareInvitation


        /// <summary>
        /// Accepts an invitation to a resource share from another AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptResourceShareInvitation service method.</param>
        /// 
        /// <returns>The response from the AcceptResourceShareInvitation service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationAlreadyAcceptedException">
        /// The invitation was already accepted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationAlreadyRejectedException">
        /// The invitation was already rejected.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationArnNotFoundException">
        /// The Amazon Resource Name (ARN) for an invitation was not found.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationExpiredException">
        /// The invitation is expired.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/AcceptResourceShareInvitation">REST API Reference for AcceptResourceShareInvitation Operation</seealso>
        public virtual AcceptResourceShareInvitationResponse AcceptResourceShareInvitation(AcceptResourceShareInvitationRequest request)
        {
            var marshaller = AcceptResourceShareInvitationRequestMarshaller.Instance;
            var unmarshaller = AcceptResourceShareInvitationResponseUnmarshaller.Instance;

            return Invoke<AcceptResourceShareInvitationRequest,AcceptResourceShareInvitationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptResourceShareInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptResourceShareInvitation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/AcceptResourceShareInvitation">REST API Reference for AcceptResourceShareInvitation Operation</seealso>
        public virtual Task<AcceptResourceShareInvitationResponse> AcceptResourceShareInvitationAsync(AcceptResourceShareInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AcceptResourceShareInvitationRequestMarshaller.Instance;
            var unmarshaller = AcceptResourceShareInvitationResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptResourceShareInvitationRequest,AcceptResourceShareInvitationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateResourceShare


        /// <summary>
        /// Associates the specified resource share with the specified principals and resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateResourceShare service method.</param>
        /// 
        /// <returns>The response from the AssociateResourceShare service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// A client token input parameter was reused with an operation, but at least one of the
        /// other input parameters is different from the previous call to the operation.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// A client token is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidStateTransitionException">
        /// The requested state transition is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidStateTransitionException">
        /// The requested state transition is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareLimitExceededException">
        /// The requested resource share exceeds the limit for your account.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/AssociateResourceShare">REST API Reference for AssociateResourceShare Operation</seealso>
        public virtual AssociateResourceShareResponse AssociateResourceShare(AssociateResourceShareRequest request)
        {
            var marshaller = AssociateResourceShareRequestMarshaller.Instance;
            var unmarshaller = AssociateResourceShareResponseUnmarshaller.Instance;

            return Invoke<AssociateResourceShareRequest,AssociateResourceShareResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateResourceShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateResourceShare operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/AssociateResourceShare">REST API Reference for AssociateResourceShare Operation</seealso>
        public virtual Task<AssociateResourceShareResponse> AssociateResourceShareAsync(AssociateResourceShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociateResourceShareRequestMarshaller.Instance;
            var unmarshaller = AssociateResourceShareResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateResourceShareRequest,AssociateResourceShareResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateResourceShare


        /// <summary>
        /// Creates a resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceShare service method.</param>
        /// 
        /// <returns>The response from the CreateResourceShare service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// A client token input parameter was reused with an operation, but at least one of the
        /// other input parameters is different from the previous call to the operation.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// A client token is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidStateTransitionException">
        /// The requested state transition is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareLimitExceededException">
        /// The requested resource share exceeds the limit for your account.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/CreateResourceShare">REST API Reference for CreateResourceShare Operation</seealso>
        public virtual CreateResourceShareResponse CreateResourceShare(CreateResourceShareRequest request)
        {
            var marshaller = CreateResourceShareRequestMarshaller.Instance;
            var unmarshaller = CreateResourceShareResponseUnmarshaller.Instance;

            return Invoke<CreateResourceShareRequest,CreateResourceShareResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResourceShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceShare operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/CreateResourceShare">REST API Reference for CreateResourceShare Operation</seealso>
        public virtual Task<CreateResourceShareResponse> CreateResourceShareAsync(CreateResourceShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateResourceShareRequestMarshaller.Instance;
            var unmarshaller = CreateResourceShareResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResourceShareRequest,CreateResourceShareResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteResourceShare


        /// <summary>
        /// Deletes the specified resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceShare service method.</param>
        /// 
        /// <returns>The response from the DeleteResourceShare service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// A client token input parameter was reused with an operation, but at least one of the
        /// other input parameters is different from the previous call to the operation.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// A client token is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidStateTransitionException">
        /// The requested state transition is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DeleteResourceShare">REST API Reference for DeleteResourceShare Operation</seealso>
        public virtual DeleteResourceShareResponse DeleteResourceShare(DeleteResourceShareRequest request)
        {
            var marshaller = DeleteResourceShareRequestMarshaller.Instance;
            var unmarshaller = DeleteResourceShareResponseUnmarshaller.Instance;

            return Invoke<DeleteResourceShareRequest,DeleteResourceShareResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourceShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceShare operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DeleteResourceShare">REST API Reference for DeleteResourceShare Operation</seealso>
        public virtual Task<DeleteResourceShareResponse> DeleteResourceShareAsync(DeleteResourceShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteResourceShareRequestMarshaller.Instance;
            var unmarshaller = DeleteResourceShareResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourceShareRequest,DeleteResourceShareResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateResourceShare


        /// <summary>
        /// Disassociates the specified principals or resources from the specified resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResourceShare service method.</param>
        /// 
        /// <returns>The response from the DisassociateResourceShare service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// A client token input parameter was reused with an operation, but at least one of the
        /// other input parameters is different from the previous call to the operation.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// A client token is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidStateTransitionException">
        /// The requested state transition is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareLimitExceededException">
        /// The requested resource share exceeds the limit for your account.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DisassociateResourceShare">REST API Reference for DisassociateResourceShare Operation</seealso>
        public virtual DisassociateResourceShareResponse DisassociateResourceShare(DisassociateResourceShareRequest request)
        {
            var marshaller = DisassociateResourceShareRequestMarshaller.Instance;
            var unmarshaller = DisassociateResourceShareResponseUnmarshaller.Instance;

            return Invoke<DisassociateResourceShareRequest,DisassociateResourceShareResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateResourceShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResourceShare operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DisassociateResourceShare">REST API Reference for DisassociateResourceShare Operation</seealso>
        public virtual Task<DisassociateResourceShareResponse> DisassociateResourceShareAsync(DisassociateResourceShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateResourceShareRequestMarshaller.Instance;
            var unmarshaller = DisassociateResourceShareResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateResourceShareRequest,DisassociateResourceShareResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableSharingWithAwsOrganization


        /// <summary>
        /// Enables resource sharing within your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableSharingWithAwsOrganization service method.</param>
        /// 
        /// <returns>The response from the EnableSharingWithAwsOrganization service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/EnableSharingWithAwsOrganization">REST API Reference for EnableSharingWithAwsOrganization Operation</seealso>
        public virtual EnableSharingWithAwsOrganizationResponse EnableSharingWithAwsOrganization(EnableSharingWithAwsOrganizationRequest request)
        {
            var marshaller = EnableSharingWithAwsOrganizationRequestMarshaller.Instance;
            var unmarshaller = EnableSharingWithAwsOrganizationResponseUnmarshaller.Instance;

            return Invoke<EnableSharingWithAwsOrganizationRequest,EnableSharingWithAwsOrganizationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableSharingWithAwsOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableSharingWithAwsOrganization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/EnableSharingWithAwsOrganization">REST API Reference for EnableSharingWithAwsOrganization Operation</seealso>
        public virtual Task<EnableSharingWithAwsOrganizationResponse> EnableSharingWithAwsOrganizationAsync(EnableSharingWithAwsOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = EnableSharingWithAwsOrganizationRequestMarshaller.Instance;
            var unmarshaller = EnableSharingWithAwsOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<EnableSharingWithAwsOrganizationRequest,EnableSharingWithAwsOrganizationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetResourcePolicies


        /// <summary>
        /// Gets the policies for the specifies resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicies service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicies service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for NextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourcePolicies">REST API Reference for GetResourcePolicies Operation</seealso>
        public virtual GetResourcePoliciesResponse GetResourcePolicies(GetResourcePoliciesRequest request)
        {
            var marshaller = GetResourcePoliciesRequestMarshaller.Instance;
            var unmarshaller = GetResourcePoliciesResponseUnmarshaller.Instance;

            return Invoke<GetResourcePoliciesRequest,GetResourcePoliciesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourcePolicies">REST API Reference for GetResourcePolicies Operation</seealso>
        public virtual Task<GetResourcePoliciesResponse> GetResourcePoliciesAsync(GetResourcePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetResourcePoliciesRequestMarshaller.Instance;
            var unmarshaller = GetResourcePoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcePoliciesRequest,GetResourcePoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetResourceShareAssociations


        /// <summary>
        /// Gets the associations for the specified resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceShareAssociations service method.</param>
        /// 
        /// <returns>The response from the GetResourceShareAssociations service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for NextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourceShareAssociations">REST API Reference for GetResourceShareAssociations Operation</seealso>
        public virtual GetResourceShareAssociationsResponse GetResourceShareAssociations(GetResourceShareAssociationsRequest request)
        {
            var marshaller = GetResourceShareAssociationsRequestMarshaller.Instance;
            var unmarshaller = GetResourceShareAssociationsResponseUnmarshaller.Instance;

            return Invoke<GetResourceShareAssociationsRequest,GetResourceShareAssociationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceShareAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceShareAssociations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourceShareAssociations">REST API Reference for GetResourceShareAssociations Operation</seealso>
        public virtual Task<GetResourceShareAssociationsResponse> GetResourceShareAssociationsAsync(GetResourceShareAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetResourceShareAssociationsRequestMarshaller.Instance;
            var unmarshaller = GetResourceShareAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourceShareAssociationsRequest,GetResourceShareAssociationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetResourceShareInvitations


        /// <summary>
        /// Gets the specified invitations for resource sharing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceShareInvitations service method.</param>
        /// 
        /// <returns>The response from the GetResourceShareInvitations service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidMaxResultsException">
        /// The specified value for MaxResults is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for NextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationArnNotFoundException">
        /// The Amazon Resource Name (ARN) for an invitation was not found.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourceShareInvitations">REST API Reference for GetResourceShareInvitations Operation</seealso>
        public virtual GetResourceShareInvitationsResponse GetResourceShareInvitations(GetResourceShareInvitationsRequest request)
        {
            var marshaller = GetResourceShareInvitationsRequestMarshaller.Instance;
            var unmarshaller = GetResourceShareInvitationsResponseUnmarshaller.Instance;

            return Invoke<GetResourceShareInvitationsRequest,GetResourceShareInvitationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceShareInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceShareInvitations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourceShareInvitations">REST API Reference for GetResourceShareInvitations Operation</seealso>
        public virtual Task<GetResourceShareInvitationsResponse> GetResourceShareInvitationsAsync(GetResourceShareInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetResourceShareInvitationsRequestMarshaller.Instance;
            var unmarshaller = GetResourceShareInvitationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourceShareInvitationsRequest,GetResourceShareInvitationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetResourceShares


        /// <summary>
        /// Gets the specified resource shares or all of your resource shares.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceShares service method.</param>
        /// 
        /// <returns>The response from the GetResourceShares service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for NextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourceShares">REST API Reference for GetResourceShares Operation</seealso>
        public virtual GetResourceSharesResponse GetResourceShares(GetResourceSharesRequest request)
        {
            var marshaller = GetResourceSharesRequestMarshaller.Instance;
            var unmarshaller = GetResourceSharesResponseUnmarshaller.Instance;

            return Invoke<GetResourceSharesRequest,GetResourceSharesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceShares operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceShares operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourceShares">REST API Reference for GetResourceShares Operation</seealso>
        public virtual Task<GetResourceSharesResponse> GetResourceSharesAsync(GetResourceSharesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetResourceSharesRequestMarshaller.Instance;
            var unmarshaller = GetResourceSharesResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourceSharesRequest,GetResourceSharesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListPrincipals


        /// <summary>
        /// Lists the principals with access to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipals service method.</param>
        /// 
        /// <returns>The response from the ListPrincipals service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for NextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPrincipals">REST API Reference for ListPrincipals Operation</seealso>
        public virtual ListPrincipalsResponse ListPrincipals(ListPrincipalsRequest request)
        {
            var marshaller = ListPrincipalsRequestMarshaller.Instance;
            var unmarshaller = ListPrincipalsResponseUnmarshaller.Instance;

            return Invoke<ListPrincipalsRequest,ListPrincipalsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPrincipals operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipals operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPrincipals">REST API Reference for ListPrincipals Operation</seealso>
        public virtual Task<ListPrincipalsResponse> ListPrincipalsAsync(ListPrincipalsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListPrincipalsRequestMarshaller.Instance;
            var unmarshaller = ListPrincipalsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPrincipalsRequest,ListPrincipalsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListResources


        /// <summary>
        /// Lists the resources that the specified principal can access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResources service method.</param>
        /// 
        /// <returns>The response from the ListResources service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for NextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidResourceTypeException">
        /// The specified resource type is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListResources">REST API Reference for ListResources Operation</seealso>
        public virtual ListResourcesResponse ListResources(ListResourcesRequest request)
        {
            var marshaller = ListResourcesRequestMarshaller.Instance;
            var unmarshaller = ListResourcesResponseUnmarshaller.Instance;

            return Invoke<ListResourcesRequest,ListResourcesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListResources">REST API Reference for ListResources Operation</seealso>
        public virtual Task<ListResourcesResponse> ListResourcesAsync(ListResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListResourcesRequestMarshaller.Instance;
            var unmarshaller = ListResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourcesRequest,ListResourcesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RejectResourceShareInvitation


        /// <summary>
        /// Rejects an invitation to a resource share from another AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectResourceShareInvitation service method.</param>
        /// 
        /// <returns>The response from the RejectResourceShareInvitation service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationAlreadyAcceptedException">
        /// The invitation was already accepted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationAlreadyRejectedException">
        /// The invitation was already rejected.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationArnNotFoundException">
        /// The Amazon Resource Name (ARN) for an invitation was not found.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationExpiredException">
        /// The invitation is expired.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/RejectResourceShareInvitation">REST API Reference for RejectResourceShareInvitation Operation</seealso>
        public virtual RejectResourceShareInvitationResponse RejectResourceShareInvitation(RejectResourceShareInvitationRequest request)
        {
            var marshaller = RejectResourceShareInvitationRequestMarshaller.Instance;
            var unmarshaller = RejectResourceShareInvitationResponseUnmarshaller.Instance;

            return Invoke<RejectResourceShareInvitationRequest,RejectResourceShareInvitationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RejectResourceShareInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectResourceShareInvitation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/RejectResourceShareInvitation">REST API Reference for RejectResourceShareInvitation Operation</seealso>
        public virtual Task<RejectResourceShareInvitationResponse> RejectResourceShareInvitationAsync(RejectResourceShareInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RejectResourceShareInvitationRequestMarshaller.Instance;
            var unmarshaller = RejectResourceShareInvitationResponseUnmarshaller.Instance;

            return InvokeAsync<RejectResourceShareInvitationRequest,RejectResourceShareInvitationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds the specified tags to the specified resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceArnNotFoundException">
        /// An Amazon Resource Name (ARN) was not found.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.TagLimitExceededException">
        /// The requested tags exceed the limit for your account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var marshaller = TagResourceRequestMarshaller.Instance;
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceRequest,TagResourceResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = TagResourceRequestMarshaller.Instance;
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceRequest,TagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from the specified resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var marshaller = UntagResourceRequestMarshaller.Instance;
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceRequest,UntagResourceResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UntagResourceRequestMarshaller.Instance;
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceRequest,UntagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateResourceShare


        /// <summary>
        /// Updates the specified resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceShare service method.</param>
        /// 
        /// <returns>The response from the UpdateResourceShare service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// A client token input parameter was reused with an operation, but at least one of the
        /// other input parameters is different from the previous call to the operation.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// A client token is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MissingRequiredParameterException">
        /// A required input parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/UpdateResourceShare">REST API Reference for UpdateResourceShare Operation</seealso>
        public virtual UpdateResourceShareResponse UpdateResourceShare(UpdateResourceShareRequest request)
        {
            var marshaller = UpdateResourceShareRequestMarshaller.Instance;
            var unmarshaller = UpdateResourceShareResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceShareRequest,UpdateResourceShareResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResourceShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceShare operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/UpdateResourceShare">REST API Reference for UpdateResourceShare Operation</seealso>
        public virtual Task<UpdateResourceShareResponse> UpdateResourceShareAsync(UpdateResourceShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateResourceShareRequestMarshaller.Instance;
            var unmarshaller = UpdateResourceShareResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateResourceShareRequest,UpdateResourceShareResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}