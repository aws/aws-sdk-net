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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

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
    /// This is the <i>Resource Access Manager API Reference</i>. This documentation provides
    /// descriptions and syntax for each of the actions and data types in RAM. RAM is a service
    /// that helps you securely share your Amazon Web Services resources across Amazon Web
    /// Services accounts. If you have multiple Amazon Web Services accounts, you can use
    /// RAM to share those resources with other accounts. If you use Organizations to manage
    /// your accounts, then you share your resources with your organization or organizational
    /// units (OUs). For supported resource types, you can also share resources with individual
    /// Identity and Access Management (IAM) roles an users. 
    /// 
    ///  
    /// <para>
    /// To learn more about RAM, see the following resources:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://aws.amazon.com/ram">Resource Access Manager product page</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/ram/latest/userguide/">Resource Access Manager
    /// User Guide</a> 
    /// </para>
    ///  </li> </ul>
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
#if AWS_ASYNC_ENUMERABLES_API
        private IRAMPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IRAMPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new RAMPaginatorFactory(this);
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
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRAMEndpointResolver());
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

        internal virtual AcceptResourceShareInvitationResponse AcceptResourceShareInvitation(AcceptResourceShareInvitationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptResourceShareInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptResourceShareInvitationResponseUnmarshaller.Instance;

            return Invoke<AcceptResourceShareInvitationResponse>(request, options);
        }



        /// <summary>
        /// Accepts an invitation to a resource share from another Amazon Web Services account.
        /// After you accept the invitation, the resources included in the resource share are
        /// available to interact with in the relevant Amazon Web Services Management Consoles
        /// and tools.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptResourceShareInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptResourceShareInvitation service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// The client token input parameter was matched one used with a previous call to the
        /// operation, but at least one of the other input parameters is different from the previous
        /// call.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// The client token is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationAlreadyAcceptedException">
        /// The specified invitation was already accepted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationAlreadyRejectedException">
        /// The specified invitation was already rejected.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationArnNotFoundException">
        /// The specified Amazon Resource Name (ARN) for an invitation was not found.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationExpiredException">
        /// The specified invitation is expired.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/AcceptResourceShareInvitation">REST API Reference for AcceptResourceShareInvitation Operation</seealso>
        public virtual Task<AcceptResourceShareInvitationResponse> AcceptResourceShareInvitationAsync(AcceptResourceShareInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptResourceShareInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptResourceShareInvitationResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptResourceShareInvitationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateResourceShare

        internal virtual AssociateResourceShareResponse AssociateResourceShare(AssociateResourceShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResourceShareResponseUnmarshaller.Instance;

            return Invoke<AssociateResourceShareResponse>(request, options);
        }



        /// <summary>
        /// Adds the specified list of principals and list of resources to a resource share. Principals
        /// that already have access to this resource share immediately receive access to the
        /// added resources. Newly added principals immediately receive access to the resources
        /// shared in this resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateResourceShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateResourceShare service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// The client token input parameter was matched one used with a previous call to the
        /// operation, but at least one of the other input parameters is different from the previous
        /// call.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// The client token is not valid.
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
        /// This request would exceed the limit for resource shares for your account.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ThrottlingException">
        /// You exceeded the rate at which you are allowed to perform this operation. Please try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/AssociateResourceShare">REST API Reference for AssociateResourceShare Operation</seealso>
        public virtual Task<AssociateResourceShareResponse> AssociateResourceShareAsync(AssociateResourceShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResourceShareResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateResourceShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateResourceSharePermission

        internal virtual AssociateResourceSharePermissionResponse AssociateResourceSharePermission(AssociateResourceSharePermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateResourceSharePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResourceSharePermissionResponseUnmarshaller.Instance;

            return Invoke<AssociateResourceSharePermissionResponse>(request, options);
        }



        /// <summary>
        /// Adds or replaces the RAM permission for a resource type included in a resource share.
        /// You can have exactly one permission associated with each resource type in the resource
        /// share. You can add a new RAM permission only if there are currently no resources of
        /// that resource type currently in the resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateResourceSharePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateResourceSharePermission service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// The client token is not valid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/AssociateResourceSharePermission">REST API Reference for AssociateResourceSharePermission Operation</seealso>
        public virtual Task<AssociateResourceSharePermissionResponse> AssociateResourceSharePermissionAsync(AssociateResourceSharePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateResourceSharePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResourceSharePermissionResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateResourceSharePermissionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateResourceShare

        internal virtual CreateResourceShareResponse CreateResourceShare(CreateResourceShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceShareResponseUnmarshaller.Instance;

            return Invoke<CreateResourceShareResponse>(request, options);
        }



        /// <summary>
        /// Creates a resource share. You can provide a list of the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> for the resources that you want to share, a list of principals
        /// you want to share the resources with, and the permissions to grant those principals.
        /// 
        ///  <note> 
        /// <para>
        /// Sharing a resource makes it available for use by principals outside of the Amazon
        /// Web Services account that created the resource. Sharing doesn't change any permissions
        /// or quotas that apply to the resource in the account that created it.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateResourceShare service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// The client token input parameter was matched one used with a previous call to the
        /// operation, but at least one of the other input parameters is different from the previous
        /// call.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// The client token is not valid.
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
        /// This request would exceed the limit for resource shares for your account.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.TagPolicyViolationException">
        /// The specified tag key is a reserved word and can't be used.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/CreateResourceShare">REST API Reference for CreateResourceShare Operation</seealso>
        public virtual Task<CreateResourceShareResponse> CreateResourceShareAsync(CreateResourceShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceShareResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResourceShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResourceShare

        internal virtual DeleteResourceShareResponse DeleteResourceShare(DeleteResourceShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceShareResponseUnmarshaller.Instance;

            return Invoke<DeleteResourceShareResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified resource share. This doesn't delete any of the resources that
        /// were associated with the resource share; it only stops the sharing of those resources
        /// outside of the Amazon Web Services account that created them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourceShare service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// The client token input parameter was matched one used with a previous call to the
        /// operation, but at least one of the other input parameters is different from the previous
        /// call.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// The client token is not valid.
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
        public virtual Task<DeleteResourceShareResponse> DeleteResourceShareAsync(DeleteResourceShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceShareResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourceShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateResourceShare

        internal virtual DisassociateResourceShareResponse DisassociateResourceShare(DisassociateResourceShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResourceShareResponseUnmarshaller.Instance;

            return Invoke<DisassociateResourceShareResponse>(request, options);
        }



        /// <summary>
        /// Disassociates the specified principals or resources from the specified resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResourceShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateResourceShare service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// The client token input parameter was matched one used with a previous call to the
        /// operation, but at least one of the other input parameters is different from the previous
        /// call.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// The client token is not valid.
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
        /// This request would exceed the limit for resource shares for your account.
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
        public virtual Task<DisassociateResourceShareResponse> DisassociateResourceShareAsync(DisassociateResourceShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResourceShareResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateResourceShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateResourceSharePermission

        internal virtual DisassociateResourceSharePermissionResponse DisassociateResourceSharePermission(DisassociateResourceSharePermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateResourceSharePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResourceSharePermissionResponseUnmarshaller.Instance;

            return Invoke<DisassociateResourceSharePermissionResponse>(request, options);
        }



        /// <summary>
        /// Disassociates an RAM permission from a resource share. Permission changes take effect
        /// immediately. You can remove a RAM permission from a resource share only if there are
        /// currently no resources of the relevant resource type currently attached to the resource
        /// share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResourceSharePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateResourceSharePermission service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// The client token is not valid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DisassociateResourceSharePermission">REST API Reference for DisassociateResourceSharePermission Operation</seealso>
        public virtual Task<DisassociateResourceSharePermissionResponse> DisassociateResourceSharePermissionAsync(DisassociateResourceSharePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateResourceSharePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResourceSharePermissionResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateResourceSharePermissionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableSharingWithAwsOrganization

        internal virtual EnableSharingWithAwsOrganizationResponse EnableSharingWithAwsOrganization(EnableSharingWithAwsOrganizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableSharingWithAwsOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableSharingWithAwsOrganizationResponseUnmarshaller.Instance;

            return Invoke<EnableSharingWithAwsOrganizationResponse>(request, options);
        }



        /// <summary>
        /// Enables resource sharing within your organization in Organizations. Calling this operation
        /// enables RAM to retrieve information about the organization and its structure. This
        /// lets you share resources with all of the accounts in an organization by specifying
        /// the organization's ID, or all of the accounts in an organizational unit (OU) by specifying
        /// the OU's ID. Until you enable sharing within the organization, you can specify only
        /// individual Amazon Web Services accounts, or for supported resource types, IAM users
        /// and roles.
        /// 
        ///  
        /// <para>
        /// You must call this operation from an IAM user or role in the organization's management
        /// account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableSharingWithAwsOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<EnableSharingWithAwsOrganizationResponse> EnableSharingWithAwsOrganizationAsync(EnableSharingWithAwsOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableSharingWithAwsOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableSharingWithAwsOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<EnableSharingWithAwsOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPermission

        internal virtual GetPermissionResponse GetPermission(GetPermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPermissionResponseUnmarshaller.Instance;

            return Invoke<GetPermissionResponse>(request, options);
        }



        /// <summary>
        /// Gets the contents of an RAM permission in JSON format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPermission service method, as returned by RAM.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetPermission">REST API Reference for GetPermission Operation</seealso>
        public virtual Task<GetPermissionResponse> GetPermissionAsync(GetPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPermissionResponseUnmarshaller.Instance;

            return InvokeAsync<GetPermissionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourcePolicies

        internal virtual GetResourcePoliciesResponse GetResourcePolicies(GetResourcePoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePoliciesResponseUnmarshaller.Instance;

            return Invoke<GetResourcePoliciesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the resource policies for the specified resources that you own and have
        /// shared.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicies service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for <code>NextToken</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceArnNotFoundException">
        /// The specified Amazon Resource Name (ARN) was not found.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourcePolicies">REST API Reference for GetResourcePolicies Operation</seealso>
        public virtual Task<GetResourcePoliciesResponse> GetResourcePoliciesAsync(GetResourcePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcePoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourceShareAssociations

        internal virtual GetResourceShareAssociationsResponse GetResourceShareAssociations(GetResourceShareAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceShareAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceShareAssociationsResponseUnmarshaller.Instance;

            return Invoke<GetResourceShareAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the resource and principal associations for resource shares that you own.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceShareAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourceShareAssociations service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for <code>NextToken</code> is not valid.
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
        public virtual Task<GetResourceShareAssociationsResponse> GetResourceShareAssociationsAsync(GetResourceShareAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceShareAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceShareAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourceShareAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourceShareInvitations

        internal virtual GetResourceShareInvitationsResponse GetResourceShareInvitations(GetResourceShareInvitationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceShareInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceShareInvitationsResponseUnmarshaller.Instance;

            return Invoke<GetResourceShareInvitationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves details about invitations that you have received for resource shares.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceShareInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourceShareInvitations service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidMaxResultsException">
        /// The specified value for <code>MaxResults</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for <code>NextToken</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationArnNotFoundException">
        /// The specified Amazon Resource Name (ARN) for an invitation was not found.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourceShareInvitations">REST API Reference for GetResourceShareInvitations Operation</seealso>
        public virtual Task<GetResourceShareInvitationsResponse> GetResourceShareInvitationsAsync(GetResourceShareInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceShareInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceShareInvitationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourceShareInvitationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourceShares

        internal virtual GetResourceSharesResponse GetResourceShares(GetResourceSharesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceSharesResponseUnmarshaller.Instance;

            return Invoke<GetResourceSharesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves details about the resource shares that you own or that are shared with you.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceShares service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourceShares service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for <code>NextToken</code> is not valid.
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
        public virtual Task<GetResourceSharesResponse> GetResourceSharesAsync(GetResourceSharesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceSharesResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourceSharesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPendingInvitationResources

        internal virtual ListPendingInvitationResourcesResponse ListPendingInvitationResources(ListPendingInvitationResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPendingInvitationResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPendingInvitationResourcesResponseUnmarshaller.Instance;

            return Invoke<ListPendingInvitationResourcesResponse>(request, options);
        }



        /// <summary>
        /// Lists the resources in a resource share that is shared with you but for which the
        /// invitation is still <code>PENDING</code>. That means that you haven't accepted or
        /// rejected the invitation and the invitation hasn't expired.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPendingInvitationResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPendingInvitationResources service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for <code>NextToken</code> is not valid.
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
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationAlreadyRejectedException">
        /// The specified invitation was already rejected.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationArnNotFoundException">
        /// The specified Amazon Resource Name (ARN) for an invitation was not found.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationExpiredException">
        /// The specified invitation is expired.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPendingInvitationResources">REST API Reference for ListPendingInvitationResources Operation</seealso>
        public virtual Task<ListPendingInvitationResourcesResponse> ListPendingInvitationResourcesAsync(ListPendingInvitationResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPendingInvitationResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPendingInvitationResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPendingInvitationResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPermissions

        internal virtual ListPermissionsResponse ListPermissions(ListPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionsResponseUnmarshaller.Instance;

            return Invoke<ListPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of available RAM permissions that you can use for the supported resource
        /// types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPermissions service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for <code>NextToken</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPermissions">REST API Reference for ListPermissions Operation</seealso>
        public virtual Task<ListPermissionsResponse> ListPermissionsAsync(ListPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPermissionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPermissionVersions

        internal virtual ListPermissionVersionsResponse ListPermissionVersions(ListPermissionVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionVersionsResponseUnmarshaller.Instance;

            return Invoke<ListPermissionVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the available versions of the specified RAM permission.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissionVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPermissionVersions service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for <code>NextToken</code> is not valid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPermissionVersions">REST API Reference for ListPermissionVersions Operation</seealso>
        public virtual Task<ListPermissionVersionsResponse> ListPermissionVersionsAsync(ListPermissionVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPermissionVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPrincipals

        internal virtual ListPrincipalsResponse ListPrincipals(ListPrincipalsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPrincipalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrincipalsResponseUnmarshaller.Instance;

            return Invoke<ListPrincipalsResponse>(request, options);
        }



        /// <summary>
        /// Lists the principals that you are sharing resources with or that are sharing resources
        /// with you.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipals service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPrincipals service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for <code>NextToken</code> is not valid.
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
        public virtual Task<ListPrincipalsResponse> ListPrincipalsAsync(ListPrincipalsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPrincipalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrincipalsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPrincipalsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResources

        internal virtual ListResourcesResponse ListResources(ListResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesResponseUnmarshaller.Instance;

            return Invoke<ListResourcesResponse>(request, options);
        }



        /// <summary>
        /// Lists the resources that you added to a resource share or the resources that are shared
        /// with you.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResources service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for <code>NextToken</code> is not valid.
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
        public virtual Task<ListResourcesResponse> ListResourcesAsync(ListResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResourceSharePermissions

        internal virtual ListResourceSharePermissionsResponse ListResourceSharePermissions(ListResourceSharePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceSharePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceSharePermissionsResponseUnmarshaller.Instance;

            return Invoke<ListResourceSharePermissionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the RAM permissions that are associated with a resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceSharePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceSharePermissions service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for <code>NextToken</code> is not valid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListResourceSharePermissions">REST API Reference for ListResourceSharePermissions Operation</seealso>
        public virtual Task<ListResourceSharePermissionsResponse> ListResourceSharePermissionsAsync(ListResourceSharePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceSharePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceSharePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceSharePermissionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResourceTypes

        internal virtual ListResourceTypesResponse ListResourceTypes(ListResourceTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceTypesResponseUnmarshaller.Instance;

            return Invoke<ListResourceTypesResponse>(request, options);
        }



        /// <summary>
        /// Lists the resource types that can be shared by RAM.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceTypes service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for <code>NextToken</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListResourceTypes">REST API Reference for ListResourceTypes Operation</seealso>
        public virtual Task<ListResourceTypesResponse> ListResourceTypesAsync(ListResourceTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceTypesResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PromoteResourceShareCreatedFromPolicy

        internal virtual PromoteResourceShareCreatedFromPolicyResponse PromoteResourceShareCreatedFromPolicy(PromoteResourceShareCreatedFromPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PromoteResourceShareCreatedFromPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PromoteResourceShareCreatedFromPolicyResponseUnmarshaller.Instance;

            return Invoke<PromoteResourceShareCreatedFromPolicyResponse>(request, options);
        }



        /// <summary>
        /// When you attach a resource-based permission policy to a resource, it automatically
        /// creates a resource share. However, resource shares created this way are visible only
        /// to the resource share owner, and the resource share can't be modified in RAM.
        /// 
        ///  
        /// <para>
        /// You can use this operation to promote the resource share to a full RAM resource share.
        /// When you promote a resource share, you can then manage the resource share in RAM and
        /// it becomes visible to all of the principals you shared it with.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PromoteResourceShareCreatedFromPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PromoteResourceShareCreatedFromPolicy service method, as returned by RAM.</returns>
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
        /// <exception cref="Amazon.RAM.Model.ResourceShareLimitExceededException">
        /// This request would exceed the limit for resource shares for your account.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/PromoteResourceShareCreatedFromPolicy">REST API Reference for PromoteResourceShareCreatedFromPolicy Operation</seealso>
        public virtual Task<PromoteResourceShareCreatedFromPolicyResponse> PromoteResourceShareCreatedFromPolicyAsync(PromoteResourceShareCreatedFromPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PromoteResourceShareCreatedFromPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PromoteResourceShareCreatedFromPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PromoteResourceShareCreatedFromPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectResourceShareInvitation

        internal virtual RejectResourceShareInvitationResponse RejectResourceShareInvitation(RejectResourceShareInvitationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectResourceShareInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectResourceShareInvitationResponseUnmarshaller.Instance;

            return Invoke<RejectResourceShareInvitationResponse>(request, options);
        }



        /// <summary>
        /// Rejects an invitation to a resource share from another Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectResourceShareInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectResourceShareInvitation service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// The client token input parameter was matched one used with a previous call to the
        /// operation, but at least one of the other input parameters is different from the previous
        /// call.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// The client token is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationAlreadyAcceptedException">
        /// The specified invitation was already accepted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationAlreadyRejectedException">
        /// The specified invitation was already rejected.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationArnNotFoundException">
        /// The specified Amazon Resource Name (ARN) for an invitation was not found.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationExpiredException">
        /// The specified invitation is expired.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/RejectResourceShareInvitation">REST API Reference for RejectResourceShareInvitation Operation</seealso>
        public virtual Task<RejectResourceShareInvitationResponse> RejectResourceShareInvitationAsync(RejectResourceShareInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectResourceShareInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectResourceShareInvitationResponseUnmarshaller.Instance;

            return InvokeAsync<RejectResourceShareInvitationResponse>(request, options, cancellationToken);
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
        /// Adds the specified tag keys and values to the specified resource share. The tags are
        /// attached only to the resource share, not to the resources that are in the resource
        /// share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceArnNotFoundException">
        /// The specified Amazon Resource Name (ARN) was not found.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.TagLimitExceededException">
        /// This request would exceed the limit for tags for your account.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.TagPolicyViolationException">
        /// The specified tag key is a reserved word and can't be used.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
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
        /// Removes the specified tag key and value pairs from the specified resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateResourceShare

        internal virtual UpdateResourceShareResponse UpdateResourceShare(UpdateResourceShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceShareResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceShareResponse>(request, options);
        }



        /// <summary>
        /// Modifies some of the properties of the specified resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResourceShare service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// The client token input parameter was matched one used with a previous call to the
        /// operation, but at least one of the other input parameters is different from the previous
        /// call.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// The client token is not valid.
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
        public virtual Task<UpdateResourceShareResponse> UpdateResourceShareAsync(UpdateResourceShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceShareResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateResourceShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}