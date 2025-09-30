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
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.RAM
{
    /// <summary>
    /// <para>Implementation for accessing RAM</para>
    ///
    /// This is the <i>Resource Access Manager API Reference</i>. This documentation provides
    /// descriptions and syntax for each of the actions and data types in RAM. RAM is a service
    /// that helps you securely share your Amazon Web Services resources to other Amazon Web
    /// Services accounts. If you use Organizations to manage your accounts, then you can
    /// share your resources with your entire organization or to organizational units (OUs).
    /// For supported resource types, you can also share resources with individual Identity
    /// and Access Management (IAM) roles and users. 
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
            : base(new AmazonRAMConfig()) { }

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
            : base(new AmazonRAMConfig{RegionEndpoint = region}) { }

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
            : base(config) { }


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
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRAMEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRAMAuthSchemeHandler());
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// The operation failed because the client token input parameter matched one that was
        /// used with a previous call to the operation, but at least one of the other input parameters
        /// is different from the previous call.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// The operation failed because the specified client token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The operation failed because the requested operation isn't permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationAlreadyAcceptedException">
        /// The operation failed because the specified invitation was already accepted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationAlreadyRejectedException">
        /// The operation failed because the specified invitation was already rejected.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationArnNotFoundException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> for an invitation was not found.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationExpiredException">
        /// The operation failed because the specified invitation is past its expiration date
        /// and time.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/AcceptResourceShareInvitation">REST API Reference for AcceptResourceShareInvitation Operation</seealso>
        public virtual Task<AcceptResourceShareInvitationResponse> AcceptResourceShareInvitationAsync(AcceptResourceShareInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptResourceShareInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptResourceShareInvitationResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptResourceShareInvitationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateResourceShare

        internal virtual AssociateResourceShareResponse AssociateResourceShare(AssociateResourceShareRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// The operation failed because the client token input parameter matched one that was
        /// used with a previous call to the operation, but at least one of the other input parameters
        /// is different from the previous call.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// The operation failed because the specified client token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidStateTransitionException">
        /// The operation failed because the requested operation isn't valid for the resource
        /// share in its current state.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The operation failed because the requested operation isn't permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareLimitExceededException">
        /// The operation failed because it would exceed the limit for resource shares for your
        /// account. To view the limits for your Amazon Web Services account, see the <a href="https://console.aws.amazon.com/servicequotas/home/services/ram/quotas">RAM
        /// page in the Service Quotas console</a>.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ThrottlingException">
        /// The operation failed because it exceeded the rate at which you are allowed to perform
        /// this operation. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// The operation failed because a specified resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/AssociateResourceShare">REST API Reference for AssociateResourceShare Operation</seealso>
        public virtual Task<AssociateResourceShareResponse> AssociateResourceShareAsync(AssociateResourceShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResourceShareResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateResourceShareResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateResourceSharePermission

        internal virtual AssociateResourceSharePermissionResponse AssociateResourceSharePermission(AssociateResourceSharePermissionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// The operation failed because the specified client token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The operation failed because the requested operation isn't permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// The operation failed because a specified resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/AssociateResourceSharePermission">REST API Reference for AssociateResourceSharePermission Operation</seealso>
        public virtual Task<AssociateResourceSharePermissionResponse> AssociateResourceSharePermissionAsync(AssociateResourceSharePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateResourceSharePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResourceSharePermissionResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateResourceSharePermissionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreatePermission

        internal virtual CreatePermissionResponse CreatePermission(CreatePermissionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePermissionResponseUnmarshaller.Instance;

            return Invoke<CreatePermissionResponse>(request, options);
        }



        /// <summary>
        /// Creates a customer managed permission for a specified resource type that you can attach
        /// to resource shares. It is created in the Amazon Web Services Region in which you call
        /// the operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePermission service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// The operation failed because the client token input parameter matched one that was
        /// used with a previous call to the operation, but at least one of the other input parameters
        /// is different from the previous call.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// The operation failed because the specified client token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidPolicyException">
        /// The operation failed because a policy you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedPolicyTemplateException">
        /// The operation failed because the policy template that you provided isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The operation failed because the requested operation isn't permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.PermissionAlreadyExistsException">
        /// The operation failed because a permission with the specified name already exists in
        /// the requested Amazon Web Services Region. Choose a different name.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.PermissionLimitExceededException">
        /// The operation failed because it would exceed the maximum number of permissions you
        /// can create in each Amazon Web Services Region. To view the limits for your Amazon
        /// Web Services account, see the <a href="https://console.aws.amazon.com/servicequotas/home/services/ram/quotas">RAM
        /// page in the Service Quotas console</a>.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/CreatePermission">REST API Reference for CreatePermission Operation</seealso>
        public virtual Task<CreatePermissionResponse> CreatePermissionAsync(CreatePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePermissionResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePermissionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreatePermissionVersion

        internal virtual CreatePermissionVersionResponse CreatePermissionVersion(CreatePermissionVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePermissionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePermissionVersionResponseUnmarshaller.Instance;

            return Invoke<CreatePermissionVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates a new version of the specified customer managed permission. The new version
        /// is automatically set as the default version of the customer managed permission. New
        /// resource shares automatically use the default permission. Existing resource shares
        /// continue to use their original permission versions, but you can use <a>ReplacePermissionAssociations</a>
        /// to update them.
        /// 
        ///  
        /// <para>
        /// If the specified customer managed permission already has the maximum of 5 versions,
        /// then you must delete one of the existing versions before you can create a new one.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePermissionVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePermissionVersion service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// The operation failed because the client token input parameter matched one that was
        /// used with a previous call to the operation, but at least one of the other input parameters
        /// is different from the previous call.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// The operation failed because the specified client token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidPolicyException">
        /// The operation failed because a policy you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedPolicyTemplateException">
        /// The operation failed because the policy template that you provided isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.PermissionVersionsLimitExceededException">
        /// The operation failed because it would exceed the limit for the number of versions
        /// you can have for a permission. To view the limits for your Amazon Web Services account,
        /// see the <a href="https://console.aws.amazon.com/servicequotas/home/services/ram/quotas">RAM
        /// page in the Service Quotas console</a>.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// The operation failed because a specified resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/CreatePermissionVersion">REST API Reference for CreatePermissionVersion Operation</seealso>
        public virtual Task<CreatePermissionVersionResponse> CreatePermissionVersionAsync(CreatePermissionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePermissionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePermissionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePermissionVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateResourceShare

        internal virtual CreateResourceShareResponse CreateResourceShare(CreateResourceShareRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// The operation failed because the client token input parameter matched one that was
        /// used with a previous call to the operation, but at least one of the other input parameters
        /// is different from the previous call.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// The operation failed because the specified client token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidStateTransitionException">
        /// The operation failed because the requested operation isn't valid for the resource
        /// share in its current state.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The operation failed because the requested operation isn't permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareLimitExceededException">
        /// The operation failed because it would exceed the limit for resource shares for your
        /// account. To view the limits for your Amazon Web Services account, see the <a href="https://console.aws.amazon.com/servicequotas/home/services/ram/quotas">RAM
        /// page in the Service Quotas console</a>.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.TagLimitExceededException">
        /// The operation failed because it would exceed the limit for tags for your Amazon Web
        /// Services account.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.TagPolicyViolationException">
        /// The operation failed because the specified tag key is a reserved word and can't be
        /// used.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// The operation failed because a specified resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/CreateResourceShare">REST API Reference for CreateResourceShare Operation</seealso>
        public virtual Task<CreateResourceShareResponse> CreateResourceShareAsync(CreateResourceShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceShareResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResourceShareResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeletePermission

        internal virtual DeletePermissionResponse DeletePermission(DeletePermissionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePermissionResponseUnmarshaller.Instance;

            return Invoke<DeletePermissionResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified customer managed permission in the Amazon Web Services Region
        /// in which you call this operation. You can delete a customer managed permission only
        /// if it isn't attached to any resource share. The operation deletes all versions associated
        /// with the customer managed permission.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePermission service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// The operation failed because the client token input parameter matched one that was
        /// used with a previous call to the operation, but at least one of the other input parameters
        /// is different from the previous call.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// The operation failed because the specified client token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The operation failed because the requested operation isn't permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// The operation failed because a specified resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DeletePermission">REST API Reference for DeletePermission Operation</seealso>
        public virtual Task<DeletePermissionResponse> DeletePermissionAsync(DeletePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePermissionResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePermissionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeletePermissionVersion

        internal virtual DeletePermissionVersionResponse DeletePermissionVersion(DeletePermissionVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePermissionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePermissionVersionResponseUnmarshaller.Instance;

            return Invoke<DeletePermissionVersionResponse>(request, options);
        }



        /// <summary>
        /// Deletes one version of a customer managed permission. The version you specify must
        /// not be attached to any resource share and must not be the default version for the
        /// permission.
        /// 
        ///  
        /// <para>
        /// If a customer managed permission has the maximum of 5 versions, then you must delete
        /// at least one version before you can create another.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePermissionVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePermissionVersion service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// The operation failed because the client token input parameter matched one that was
        /// used with a previous call to the operation, but at least one of the other input parameters
        /// is different from the previous call.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// The operation failed because the specified client token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The operation failed because the requested operation isn't permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// The operation failed because a specified resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DeletePermissionVersion">REST API Reference for DeletePermissionVersion Operation</seealso>
        public virtual Task<DeletePermissionVersionResponse> DeletePermissionVersionAsync(DeletePermissionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePermissionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePermissionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePermissionVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteResourceShare

        internal virtual DeleteResourceShareResponse DeleteResourceShare(DeleteResourceShareRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceShareResponseUnmarshaller.Instance;

            return Invoke<DeleteResourceShareResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified resource share.
        /// 
        ///  <important> 
        /// <para>
        /// This doesn't delete any of the resources that were associated with the resource share;
        /// it only stops the sharing of those resources through this resource share.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourceShare service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// The operation failed because the client token input parameter matched one that was
        /// used with a previous call to the operation, but at least one of the other input parameters
        /// is different from the previous call.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// The operation failed because the specified client token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidStateTransitionException">
        /// The operation failed because the requested operation isn't valid for the resource
        /// share in its current state.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The operation failed because the requested operation isn't permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// The operation failed because a specified resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DeleteResourceShare">REST API Reference for DeleteResourceShare Operation</seealso>
        public virtual Task<DeleteResourceShareResponse> DeleteResourceShareAsync(DeleteResourceShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceShareResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourceShareResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateResourceShare

        internal virtual DisassociateResourceShareResponse DisassociateResourceShare(DisassociateResourceShareRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResourceShareResponseUnmarshaller.Instance;

            return Invoke<DisassociateResourceShareResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified principals or resources from participating in the specified
        /// resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResourceShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateResourceShare service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// The operation failed because the client token input parameter matched one that was
        /// used with a previous call to the operation, but at least one of the other input parameters
        /// is different from the previous call.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// The operation failed because the specified client token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidStateTransitionException">
        /// The operation failed because the requested operation isn't valid for the resource
        /// share in its current state.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The operation failed because the requested operation isn't permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareLimitExceededException">
        /// The operation failed because it would exceed the limit for resource shares for your
        /// account. To view the limits for your Amazon Web Services account, see the <a href="https://console.aws.amazon.com/servicequotas/home/services/ram/quotas">RAM
        /// page in the Service Quotas console</a>.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// The operation failed because a specified resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DisassociateResourceShare">REST API Reference for DisassociateResourceShare Operation</seealso>
        public virtual Task<DisassociateResourceShareResponse> DisassociateResourceShareAsync(DisassociateResourceShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResourceShareResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateResourceShareResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateResourceSharePermission

        internal virtual DisassociateResourceSharePermissionResponse DisassociateResourceSharePermission(DisassociateResourceSharePermissionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateResourceSharePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResourceSharePermissionResponseUnmarshaller.Instance;

            return Invoke<DisassociateResourceSharePermissionResponse>(request, options);
        }



        /// <summary>
        /// Removes a managed permission from a resource share. Permission changes take effect
        /// immediately. You can remove a managed permission from a resource share only if there
        /// are currently no resources of the relevant resource type currently attached to the
        /// resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResourceSharePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateResourceSharePermission service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// The operation failed because the specified client token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidStateTransitionException">
        /// The operation failed because the requested operation isn't valid for the resource
        /// share in its current state.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The operation failed because the requested operation isn't permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// The operation failed because a specified resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DisassociateResourceSharePermission">REST API Reference for DisassociateResourceSharePermission Operation</seealso>
        public virtual Task<DisassociateResourceSharePermissionResponse> DisassociateResourceSharePermissionAsync(DisassociateResourceSharePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateResourceSharePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResourceSharePermissionResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateResourceSharePermissionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  EnableSharingWithAwsOrganization

        internal virtual EnableSharingWithAwsOrganizationResponse EnableSharingWithAwsOrganization(EnableSharingWithAwsOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableSharingWithAwsOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableSharingWithAwsOrganizationResponseUnmarshaller.Instance;

            return Invoke<EnableSharingWithAwsOrganizationResponse>(request, options);
        }



        /// <summary>
        /// Enables resource sharing within your organization in Organizations. This operation
        /// creates a service-linked role called <c>AWSServiceRoleForResourceAccessManager</c>
        /// that has the IAM managed policy named AWSResourceAccessManagerServiceRolePolicy attached.
        /// This role permits RAM to retrieve information about the organization and its structure.
        /// This lets you share resources with all of the accounts in the calling account's organization
        /// by specifying the organization ID, or all of the accounts in an organizational unit
        /// (OU) by specifying the OU ID. Until you enable sharing within the organization, you
        /// can specify only individual Amazon Web Services accounts, or for supported resource
        /// types, IAM roles and users.
        /// 
        ///  
        /// <para>
        /// You must call this operation from an IAM role or user in the organization's management
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
        /// The operation failed because the requested operation isn't permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/EnableSharingWithAwsOrganization">REST API Reference for EnableSharingWithAwsOrganization Operation</seealso>
        public virtual Task<EnableSharingWithAwsOrganizationResponse> EnableSharingWithAwsOrganizationAsync(EnableSharingWithAwsOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableSharingWithAwsOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableSharingWithAwsOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<EnableSharingWithAwsOrganizationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetPermission

        internal virtual GetPermissionResponse GetPermission(GetPermissionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPermissionResponseUnmarshaller.Instance;

            return Invoke<GetPermissionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the contents of a managed permission in JSON format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPermission service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The operation failed because the requested operation isn't permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// The operation failed because a specified resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetPermission">REST API Reference for GetPermission Operation</seealso>
        public virtual Task<GetPermissionResponse> GetPermissionAsync(GetPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPermissionResponseUnmarshaller.Instance;

            return InvokeAsync<GetPermissionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetResourcePolicies

        internal virtual GetResourcePoliciesResponse GetResourcePolicies(GetResourcePoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// The operation failed because the specified value for <c>NextToken</c> isn't valid.
        /// You must specify a value you received in the <c>NextToken</c> response of a previous
        /// call to this operation.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceArnNotFoundException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> was not found.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourcePolicies">REST API Reference for GetResourcePolicies Operation</seealso>
        public virtual Task<GetResourcePoliciesResponse> GetResourcePoliciesAsync(GetResourcePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcePoliciesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetResourceShareAssociations

        internal virtual GetResourceShareAssociationsResponse GetResourceShareAssociations(GetResourceShareAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceShareAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceShareAssociationsResponseUnmarshaller.Instance;

            return Invoke<GetResourceShareAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the lists of resources and principals that associated for resource shares
        /// that you own.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceShareAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourceShareAssociations service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The operation failed because the specified value for <c>NextToken</c> isn't valid.
        /// You must specify a value you received in the <c>NextToken</c> response of a previous
        /// call to this operation.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The operation failed because the requested operation isn't permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// The operation failed because a specified resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourceShareAssociations">REST API Reference for GetResourceShareAssociations Operation</seealso>
        public virtual Task<GetResourceShareAssociationsResponse> GetResourceShareAssociationsAsync(GetResourceShareAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceShareAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceShareAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourceShareAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetResourceShareInvitations

        internal virtual GetResourceShareInvitationsResponse GetResourceShareInvitations(GetResourceShareInvitationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// The operation failed because the specified value for <c>MaxResults</c> isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The operation failed because the specified value for <c>NextToken</c> isn't valid.
        /// You must specify a value you received in the <c>NextToken</c> response of a previous
        /// call to this operation.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationArnNotFoundException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> for an invitation was not found.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// The operation failed because a specified resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourceShareInvitations">REST API Reference for GetResourceShareInvitations Operation</seealso>
        public virtual Task<GetResourceShareInvitationsResponse> GetResourceShareInvitationsAsync(GetResourceShareInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceShareInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceShareInvitationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourceShareInvitationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetResourceShares

        internal virtual GetResourceSharesResponse GetResourceShares(GetResourceSharesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// The operation failed because the specified value for <c>NextToken</c> isn't valid.
        /// You must specify a value you received in the <c>NextToken</c> response of a previous
        /// call to this operation.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// The operation failed because a specified resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourceShares">REST API Reference for GetResourceShares Operation</seealso>
        public virtual Task<GetResourceSharesResponse> GetResourceSharesAsync(GetResourceSharesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceSharesResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourceSharesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPendingInvitationResources

        internal virtual ListPendingInvitationResourcesResponse ListPendingInvitationResources(ListPendingInvitationResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPendingInvitationResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPendingInvitationResourcesResponseUnmarshaller.Instance;

            return Invoke<ListPendingInvitationResourcesResponse>(request, options);
        }



        /// <summary>
        /// Lists the resources in a resource share that is shared with you but for which the
        /// invitation is still <c>PENDING</c>. That means that you haven't accepted or rejected
        /// the invitation and the invitation hasn't expired.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPendingInvitationResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPendingInvitationResources service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The operation failed because the specified value for <c>NextToken</c> isn't valid.
        /// You must specify a value you received in the <c>NextToken</c> response of a previous
        /// call to this operation.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MissingRequiredParameterException">
        /// The operation failed because a required input parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationAlreadyRejectedException">
        /// The operation failed because the specified invitation was already rejected.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationArnNotFoundException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> for an invitation was not found.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationExpiredException">
        /// The operation failed because the specified invitation is past its expiration date
        /// and time.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPendingInvitationResources">REST API Reference for ListPendingInvitationResources Operation</seealso>
        public virtual Task<ListPendingInvitationResourcesResponse> ListPendingInvitationResourcesAsync(ListPendingInvitationResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPendingInvitationResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPendingInvitationResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPendingInvitationResourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPermissionAssociations

        internal virtual ListPermissionAssociationsResponse ListPermissionAssociations(ListPermissionAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPermissionAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListPermissionAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Lists information about the managed permission and its associations to any resource
        /// shares that use this managed permission. This lets you see which resource shares use
        /// which versions of the specified managed permission.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissionAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPermissionAssociations service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The operation failed because the specified value for <c>NextToken</c> isn't valid.
        /// You must specify a value you received in the <c>NextToken</c> response of a previous
        /// call to this operation.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPermissionAssociations">REST API Reference for ListPermissionAssociations Operation</seealso>
        public virtual Task<ListPermissionAssociationsResponse> ListPermissionAssociationsAsync(ListPermissionAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPermissionAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPermissionAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPermissions

        internal virtual ListPermissionsResponse ListPermissions(ListPermissionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// The operation failed because the specified value for <c>NextToken</c> isn't valid.
        /// You must specify a value you received in the <c>NextToken</c> response of a previous
        /// call to this operation.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The operation failed because the requested operation isn't permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPermissions">REST API Reference for ListPermissions Operation</seealso>
        public virtual Task<ListPermissionsResponse> ListPermissionsAsync(ListPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPermissionVersions

        internal virtual ListPermissionVersionsResponse ListPermissionVersions(ListPermissionVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// The operation failed because the specified value for <c>NextToken</c> isn't valid.
        /// You must specify a value you received in the <c>NextToken</c> response of a previous
        /// call to this operation.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The operation failed because the requested operation isn't permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// The operation failed because a specified resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPermissionVersions">REST API Reference for ListPermissionVersions Operation</seealso>
        public virtual Task<ListPermissionVersionsResponse> ListPermissionVersionsAsync(ListPermissionVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPermissionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPermissionVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPrincipals

        internal virtual ListPrincipalsResponse ListPrincipals(ListPrincipalsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// The operation failed because the specified value for <c>NextToken</c> isn't valid.
        /// You must specify a value you received in the <c>NextToken</c> response of a previous
        /// call to this operation.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// The operation failed because a specified resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPrincipals">REST API Reference for ListPrincipals Operation</seealso>
        public virtual Task<ListPrincipalsResponse> ListPrincipalsAsync(ListPrincipalsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPrincipalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrincipalsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPrincipalsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListReplacePermissionAssociationsWork

        internal virtual ListReplacePermissionAssociationsWorkResponse ListReplacePermissionAssociationsWork(ListReplacePermissionAssociationsWorkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReplacePermissionAssociationsWorkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReplacePermissionAssociationsWorkResponseUnmarshaller.Instance;

            return Invoke<ListReplacePermissionAssociationsWorkResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the current status of the asynchronous tasks performed by RAM when you perform
        /// the <a>ReplacePermissionAssociationsWork</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReplacePermissionAssociationsWork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReplacePermissionAssociationsWork service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The operation failed because the specified value for <c>NextToken</c> isn't valid.
        /// You must specify a value you received in the <c>NextToken</c> response of a previous
        /// call to this operation.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListReplacePermissionAssociationsWork">REST API Reference for ListReplacePermissionAssociationsWork Operation</seealso>
        public virtual Task<ListReplacePermissionAssociationsWorkResponse> ListReplacePermissionAssociationsWorkAsync(ListReplacePermissionAssociationsWorkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReplacePermissionAssociationsWorkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReplacePermissionAssociationsWorkResponseUnmarshaller.Instance;

            return InvokeAsync<ListReplacePermissionAssociationsWorkResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListResources

        internal virtual ListResourcesResponse ListResources(ListResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// The operation failed because the specified value for <c>NextToken</c> isn't valid.
        /// You must specify a value you received in the <c>NextToken</c> response of a previous
        /// call to this operation.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidResourceTypeException">
        /// The operation failed because the specified resource type isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// The operation failed because a specified resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListResources">REST API Reference for ListResources Operation</seealso>
        public virtual Task<ListResourcesResponse> ListResourcesAsync(ListResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListResourceSharePermissions

        internal virtual ListResourceSharePermissionsResponse ListResourceSharePermissions(ListResourceSharePermissionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// The operation failed because the specified value for <c>NextToken</c> isn't valid.
        /// You must specify a value you received in the <c>NextToken</c> response of a previous
        /// call to this operation.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The operation failed because the requested operation isn't permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// The operation failed because a specified resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListResourceSharePermissions">REST API Reference for ListResourceSharePermissions Operation</seealso>
        public virtual Task<ListResourceSharePermissionsResponse> ListResourceSharePermissionsAsync(ListResourceSharePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceSharePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceSharePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceSharePermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListResourceTypes

        internal virtual ListResourceTypesResponse ListResourceTypes(ListResourceTypesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// The operation failed because the specified value for <c>NextToken</c> isn't valid.
        /// You must specify a value you received in the <c>NextToken</c> response of a previous
        /// call to this operation.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListResourceTypes">REST API Reference for ListResourceTypes Operation</seealso>
        public virtual Task<ListResourceTypesResponse> ListResourceTypesAsync(ListResourceTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceTypesResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceTypesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PromotePermissionCreatedFromPolicy

        internal virtual PromotePermissionCreatedFromPolicyResponse PromotePermissionCreatedFromPolicy(PromotePermissionCreatedFromPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PromotePermissionCreatedFromPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PromotePermissionCreatedFromPolicyResponseUnmarshaller.Instance;

            return Invoke<PromotePermissionCreatedFromPolicyResponse>(request, options);
        }



        /// <summary>
        /// When you attach a resource-based policy to a resource, RAM automatically creates a
        /// resource share of <c>featureSet</c>=<c>CREATED_FROM_POLICY</c> with a managed permission
        /// that has the same IAM permissions as the original resource-based policy. However,
        /// this type of managed permission is visible to only the resource share owner, and the
        /// associated resource share can't be modified by using RAM.
        /// 
        ///  
        /// <para>
        /// This operation creates a separate, fully manageable customer managed permission that
        /// has the same IAM permissions as the original resource-based policy. You can associate
        /// this customer managed permission to any resource shares.
        /// </para>
        ///  
        /// <para>
        /// Before you use <a>PromoteResourceShareCreatedFromPolicy</a>, you should first run
        /// this operation to ensure that you have an appropriate customer managed permission
        /// that can be associated with the promoted resource share.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// The original <c>CREATED_FROM_POLICY</c> policy isn't deleted, and resource shares
        /// using that original policy aren't automatically updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't modify a <c>CREATED_FROM_POLICY</c> resource share so you can't associate
        /// the new customer managed permission by using <c>ReplacePermsissionAssociations</c>.
        /// However, if you use <a>PromoteResourceShareCreatedFromPolicy</a>, that operation automatically
        /// associates the fully manageable customer managed permission to the newly promoted
        /// <c>STANDARD</c> resource share.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you promote a resource share, if the original <c>CREATED_FROM_POLICY</c> managed
        /// permission has no other associations to A resource share, then RAM automatically deletes
        /// it.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PromotePermissionCreatedFromPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PromotePermissionCreatedFromPolicy service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MissingRequiredParameterException">
        /// The operation failed because a required input parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The operation failed because the requested operation isn't permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// The operation failed because a specified resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/PromotePermissionCreatedFromPolicy">REST API Reference for PromotePermissionCreatedFromPolicy Operation</seealso>
        public virtual Task<PromotePermissionCreatedFromPolicyResponse> PromotePermissionCreatedFromPolicyAsync(PromotePermissionCreatedFromPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PromotePermissionCreatedFromPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PromotePermissionCreatedFromPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PromotePermissionCreatedFromPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PromoteResourceShareCreatedFromPolicy

        internal virtual PromoteResourceShareCreatedFromPolicyResponse PromoteResourceShareCreatedFromPolicy(PromoteResourceShareCreatedFromPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PromoteResourceShareCreatedFromPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PromoteResourceShareCreatedFromPolicyResponseUnmarshaller.Instance;

            return Invoke<PromoteResourceShareCreatedFromPolicyResponse>(request, options);
        }



        /// <summary>
        /// When you attach a resource-based policy to a resource, RAM automatically creates a
        /// resource share of <c>featureSet</c>=<c>CREATED_FROM_POLICY</c> with a managed permission
        /// that has the same IAM permissions as the original resource-based policy. However,
        /// this type of managed permission is visible to only the resource share owner, and the
        /// associated resource share can't be modified by using RAM.
        /// 
        ///  
        /// <para>
        /// This operation promotes the resource share to a <c>STANDARD</c> resource share that
        /// is fully manageable in RAM. When you promote a resource share, you can then manage
        /// the resource share in RAM and it becomes visible to all of the principals you shared
        /// it with.
        /// </para>
        ///  <important> 
        /// <para>
        /// Before you perform this operation, you should first run <a>PromotePermissionCreatedFromPolicy</a>to
        /// ensure that you have an appropriate customer managed permission that can be associated
        /// with this resource share after its is promoted. If this operation can't find a managed
        /// permission that exactly matches the existing <c>CREATED_FROM_POLICY</c> permission,
        /// then this operation fails.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PromoteResourceShareCreatedFromPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PromoteResourceShareCreatedFromPolicy service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidStateTransitionException">
        /// The operation failed because the requested operation isn't valid for the resource
        /// share in its current state.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MissingRequiredParameterException">
        /// The operation failed because a required input parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The operation failed because the requested operation isn't permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareLimitExceededException">
        /// The operation failed because it would exceed the limit for resource shares for your
        /// account. To view the limits for your Amazon Web Services account, see the <a href="https://console.aws.amazon.com/servicequotas/home/services/ram/quotas">RAM
        /// page in the Service Quotas console</a>.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// The operation failed because a specified resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnmatchedPolicyPermissionException">
        /// There isn't an existing managed permission defined in RAM that has the same IAM permissions
        /// as the resource-based policy attached to the resource. You should first run <a>PromotePermissionCreatedFromPolicy</a>
        /// to create that managed permission.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/PromoteResourceShareCreatedFromPolicy">REST API Reference for PromoteResourceShareCreatedFromPolicy Operation</seealso>
        public virtual Task<PromoteResourceShareCreatedFromPolicyResponse> PromoteResourceShareCreatedFromPolicyAsync(PromoteResourceShareCreatedFromPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PromoteResourceShareCreatedFromPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PromoteResourceShareCreatedFromPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PromoteResourceShareCreatedFromPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RejectResourceShareInvitation

        internal virtual RejectResourceShareInvitationResponse RejectResourceShareInvitation(RejectResourceShareInvitationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// The operation failed because the client token input parameter matched one that was
        /// used with a previous call to the operation, but at least one of the other input parameters
        /// is different from the previous call.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// The operation failed because the specified client token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The operation failed because the requested operation isn't permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationAlreadyAcceptedException">
        /// The operation failed because the specified invitation was already accepted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationAlreadyRejectedException">
        /// The operation failed because the specified invitation was already rejected.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationArnNotFoundException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> for an invitation was not found.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationExpiredException">
        /// The operation failed because the specified invitation is past its expiration date
        /// and time.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/RejectResourceShareInvitation">REST API Reference for RejectResourceShareInvitation Operation</seealso>
        public virtual Task<RejectResourceShareInvitationResponse> RejectResourceShareInvitationAsync(RejectResourceShareInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectResourceShareInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectResourceShareInvitationResponseUnmarshaller.Instance;

            return InvokeAsync<RejectResourceShareInvitationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ReplacePermissionAssociations

        internal virtual ReplacePermissionAssociationsResponse ReplacePermissionAssociations(ReplacePermissionAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReplacePermissionAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplacePermissionAssociationsResponseUnmarshaller.Instance;

            return Invoke<ReplacePermissionAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Updates all resource shares that use a managed permission to a different managed permission.
        /// This operation always applies the default version of the target managed permission.
        /// You can optionally specify that the update applies to only resource shares that currently
        /// use a specified version. This enables you to update to the latest version, without
        /// changing the which managed permission is used.
        /// 
        ///  
        /// <para>
        /// You can use this operation to update all of your resource shares to use the current
        /// default version of the permission by specifying the same value for the <c>fromPermissionArn</c>
        /// and <c>toPermissionArn</c> parameters.
        /// </para>
        ///  
        /// <para>
        /// You can use the optional <c>fromPermissionVersion</c> parameter to update only those
        /// resources that use a specified version of the managed permission to the new managed
        /// permission.
        /// </para>
        ///  <important> 
        /// <para>
        /// To successfully perform this operation, you must have permission to update the resource-based
        /// policy on all affected resource types.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplacePermissionAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReplacePermissionAssociations service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// The operation failed because the client token input parameter matched one that was
        /// used with a previous call to the operation, but at least one of the other input parameters
        /// is different from the previous call.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// The operation failed because the specified client token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The operation failed because the requested operation isn't permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// The operation failed because a specified resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ReplacePermissionAssociations">REST API Reference for ReplacePermissionAssociations Operation</seealso>
        public virtual Task<ReplacePermissionAssociationsResponse> ReplacePermissionAssociationsAsync(ReplacePermissionAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReplacePermissionAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplacePermissionAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ReplacePermissionAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SetDefaultPermissionVersion

        internal virtual SetDefaultPermissionVersionResponse SetDefaultPermissionVersion(SetDefaultPermissionVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetDefaultPermissionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDefaultPermissionVersionResponseUnmarshaller.Instance;

            return Invoke<SetDefaultPermissionVersionResponse>(request, options);
        }



        /// <summary>
        /// Designates the specified version number as the default version for the specified customer
        /// managed permission. New resource shares automatically use this new default permission.
        /// Existing resource shares continue to use their original permission version, but you
        /// can use <a>ReplacePermissionAssociations</a> to update them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultPermissionVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetDefaultPermissionVersion service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// The operation failed because the client token input parameter matched one that was
        /// used with a previous call to the operation, but at least one of the other input parameters
        /// is different from the previous call.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// The operation failed because the specified client token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// The operation failed because a specified resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/SetDefaultPermissionVersion">REST API Reference for SetDefaultPermissionVersion Operation</seealso>
        public virtual Task<SetDefaultPermissionVersionResponse> SetDefaultPermissionVersionAsync(SetDefaultPermissionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetDefaultPermissionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDefaultPermissionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<SetDefaultPermissionVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds the specified tag keys and values to a resource share or managed permission.
        /// If you choose a resource share, the tags are attached to only the resource share,
        /// not to the resources that are in the resource share.
        /// 
        ///  
        /// <para>
        /// The tags on a managed permission are the same for all versions of the managed permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceArnNotFoundException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> was not found.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.TagLimitExceededException">
        /// The operation failed because it would exceed the limit for tags for your Amazon Web
        /// Services account.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.TagPolicyViolationException">
        /// The operation failed because the specified tag key is a reserved word and can't be
        /// used.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// The operation failed because a specified resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified tag key and value pairs from the specified resource share or
        /// managed permission.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// The operation failed because a specified resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateResourceShare

        internal virtual UpdateResourceShareResponse UpdateResourceShare(UpdateResourceShareRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// The operation failed because the client token input parameter matched one that was
        /// used with a previous call to the operation, but at least one of the other input parameters
        /// is different from the previous call.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// The operation failed because the specified client token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// The operation failed because a parameter you specified isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The operation failed because the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> has a format that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MissingRequiredParameterException">
        /// The operation failed because a required input parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The operation failed because the requested operation isn't permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The operation failed because the service could not respond to the request due to an
        /// internal problem. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The operation failed because the service isn't available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// The operation failed because a specified resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/UpdateResourceShare">REST API Reference for UpdateResourceShare Operation</seealso>
        public virtual Task<UpdateResourceShareResponse> UpdateResourceShareAsync(UpdateResourceShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceShareResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateResourceShareResponse>(request, options, cancellationToken);
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