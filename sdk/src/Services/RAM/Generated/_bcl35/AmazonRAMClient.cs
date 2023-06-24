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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
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

        /// <summary>
        /// Accepts an invitation to a resource share from another Amazon Web Services account.
        /// After you accept the invitation, the resources included in the resource share are
        /// available to interact with in the relevant Amazon Web Services Management Consoles
        /// and tools.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptResourceShareInvitation service method.</param>
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
        public virtual AcceptResourceShareInvitationResponse AcceptResourceShareInvitation(AcceptResourceShareInvitationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptResourceShareInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptResourceShareInvitationResponseUnmarshaller.Instance;

            return Invoke<AcceptResourceShareInvitationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptResourceShareInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptResourceShareInvitation operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptResourceShareInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/AcceptResourceShareInvitation">REST API Reference for AcceptResourceShareInvitation Operation</seealso>
        public virtual IAsyncResult BeginAcceptResourceShareInvitation(AcceptResourceShareInvitationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptResourceShareInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptResourceShareInvitationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptResourceShareInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptResourceShareInvitation.</param>
        /// 
        /// <returns>Returns a  AcceptResourceShareInvitationResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/AcceptResourceShareInvitation">REST API Reference for AcceptResourceShareInvitation Operation</seealso>
        public virtual AcceptResourceShareInvitationResponse EndAcceptResourceShareInvitation(IAsyncResult asyncResult)
        {
            return EndInvoke<AcceptResourceShareInvitationResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateResourceShare

        /// <summary>
        /// Adds the specified list of principals and list of resources to a resource share. Principals
        /// that already have access to this resource share immediately receive access to the
        /// added resources. Newly added principals immediately receive access to the resources
        /// shared in this resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateResourceShare service method.</param>
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
        public virtual AssociateResourceShareResponse AssociateResourceShare(AssociateResourceShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResourceShareResponseUnmarshaller.Instance;

            return Invoke<AssociateResourceShareResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateResourceShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateResourceShare operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateResourceShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/AssociateResourceShare">REST API Reference for AssociateResourceShare Operation</seealso>
        public virtual IAsyncResult BeginAssociateResourceShare(AssociateResourceShareRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResourceShareResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateResourceShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateResourceShare.</param>
        /// 
        /// <returns>Returns a  AssociateResourceShareResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/AssociateResourceShare">REST API Reference for AssociateResourceShare Operation</seealso>
        public virtual AssociateResourceShareResponse EndAssociateResourceShare(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateResourceShareResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateResourceSharePermission

        /// <summary>
        /// Adds or replaces the RAM permission for a resource type included in a resource share.
        /// You can have exactly one permission associated with each resource type in the resource
        /// share. You can add a new RAM permission only if there are currently no resources of
        /// that resource type currently in the resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateResourceSharePermission service method.</param>
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
        public virtual AssociateResourceSharePermissionResponse AssociateResourceSharePermission(AssociateResourceSharePermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateResourceSharePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResourceSharePermissionResponseUnmarshaller.Instance;

            return Invoke<AssociateResourceSharePermissionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateResourceSharePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateResourceSharePermission operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateResourceSharePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/AssociateResourceSharePermission">REST API Reference for AssociateResourceSharePermission Operation</seealso>
        public virtual IAsyncResult BeginAssociateResourceSharePermission(AssociateResourceSharePermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateResourceSharePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResourceSharePermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateResourceSharePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateResourceSharePermission.</param>
        /// 
        /// <returns>Returns a  AssociateResourceSharePermissionResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/AssociateResourceSharePermission">REST API Reference for AssociateResourceSharePermission Operation</seealso>
        public virtual AssociateResourceSharePermissionResponse EndAssociateResourceSharePermission(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateResourceSharePermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePermission

        /// <summary>
        /// Creates a customer managed permission for a specified resource type that you can attach
        /// to resource shares. It is created in the Amazon Web Services Region in which you call
        /// the operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePermission service method.</param>
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
        public virtual CreatePermissionResponse CreatePermission(CreatePermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePermissionResponseUnmarshaller.Instance;

            return Invoke<CreatePermissionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePermission operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/CreatePermission">REST API Reference for CreatePermission Operation</seealso>
        public virtual IAsyncResult BeginCreatePermission(CreatePermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePermission.</param>
        /// 
        /// <returns>Returns a  CreatePermissionResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/CreatePermission">REST API Reference for CreatePermission Operation</seealso>
        public virtual CreatePermissionResponse EndCreatePermission(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePermissionVersion

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
        public virtual CreatePermissionVersionResponse CreatePermissionVersion(CreatePermissionVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePermissionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePermissionVersionResponseUnmarshaller.Instance;

            return Invoke<CreatePermissionVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePermissionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePermissionVersion operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePermissionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/CreatePermissionVersion">REST API Reference for CreatePermissionVersion Operation</seealso>
        public virtual IAsyncResult BeginCreatePermissionVersion(CreatePermissionVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePermissionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePermissionVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePermissionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePermissionVersion.</param>
        /// 
        /// <returns>Returns a  CreatePermissionVersionResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/CreatePermissionVersion">REST API Reference for CreatePermissionVersion Operation</seealso>
        public virtual CreatePermissionVersionResponse EndCreatePermissionVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePermissionVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateResourceShare

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
        /// <exception cref="Amazon.RAM.Model.TagPolicyViolationException">
        /// The operation failed because the specified tag key is a reserved word and can't be
        /// used.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// The operation failed because a specified resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/CreateResourceShare">REST API Reference for CreateResourceShare Operation</seealso>
        public virtual CreateResourceShareResponse CreateResourceShare(CreateResourceShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceShareResponseUnmarshaller.Instance;

            return Invoke<CreateResourceShareResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResourceShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceShare operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResourceShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/CreateResourceShare">REST API Reference for CreateResourceShare Operation</seealso>
        public virtual IAsyncResult BeginCreateResourceShare(CreateResourceShareRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceShareResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResourceShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResourceShare.</param>
        /// 
        /// <returns>Returns a  CreateResourceShareResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/CreateResourceShare">REST API Reference for CreateResourceShare Operation</seealso>
        public virtual CreateResourceShareResponse EndCreateResourceShare(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateResourceShareResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePermission

        /// <summary>
        /// Deletes the specified customer managed permission in the Amazon Web Services Region
        /// in which you call this operation. You can delete a customer managed permission only
        /// if it isn't attached to any resource share. The operation deletes all versions associated
        /// with the customer managed permission.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePermission service method.</param>
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
        public virtual DeletePermissionResponse DeletePermission(DeletePermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePermissionResponseUnmarshaller.Instance;

            return Invoke<DeletePermissionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePermission operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DeletePermission">REST API Reference for DeletePermission Operation</seealso>
        public virtual IAsyncResult BeginDeletePermission(DeletePermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePermission.</param>
        /// 
        /// <returns>Returns a  DeletePermissionResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DeletePermission">REST API Reference for DeletePermission Operation</seealso>
        public virtual DeletePermissionResponse EndDeletePermission(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePermissionVersion

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
        public virtual DeletePermissionVersionResponse DeletePermissionVersion(DeletePermissionVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePermissionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePermissionVersionResponseUnmarshaller.Instance;

            return Invoke<DeletePermissionVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePermissionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePermissionVersion operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePermissionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DeletePermissionVersion">REST API Reference for DeletePermissionVersion Operation</seealso>
        public virtual IAsyncResult BeginDeletePermissionVersion(DeletePermissionVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePermissionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePermissionVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePermissionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePermissionVersion.</param>
        /// 
        /// <returns>Returns a  DeletePermissionVersionResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DeletePermissionVersion">REST API Reference for DeletePermissionVersion Operation</seealso>
        public virtual DeletePermissionVersionResponse EndDeletePermissionVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePermissionVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteResourceShare

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
        public virtual DeleteResourceShareResponse DeleteResourceShare(DeleteResourceShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceShareResponseUnmarshaller.Instance;

            return Invoke<DeleteResourceShareResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourceShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceShare operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourceShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DeleteResourceShare">REST API Reference for DeleteResourceShare Operation</seealso>
        public virtual IAsyncResult BeginDeleteResourceShare(DeleteResourceShareRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceShareResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourceShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourceShare.</param>
        /// 
        /// <returns>Returns a  DeleteResourceShareResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DeleteResourceShare">REST API Reference for DeleteResourceShare Operation</seealso>
        public virtual DeleteResourceShareResponse EndDeleteResourceShare(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteResourceShareResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateResourceShare

        /// <summary>
        /// Removes the specified principals or resources from participating in the specified
        /// resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResourceShare service method.</param>
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
        public virtual DisassociateResourceShareResponse DisassociateResourceShare(DisassociateResourceShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResourceShareResponseUnmarshaller.Instance;

            return Invoke<DisassociateResourceShareResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateResourceShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResourceShare operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateResourceShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DisassociateResourceShare">REST API Reference for DisassociateResourceShare Operation</seealso>
        public virtual IAsyncResult BeginDisassociateResourceShare(DisassociateResourceShareRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResourceShareResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateResourceShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateResourceShare.</param>
        /// 
        /// <returns>Returns a  DisassociateResourceShareResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DisassociateResourceShare">REST API Reference for DisassociateResourceShare Operation</seealso>
        public virtual DisassociateResourceShareResponse EndDisassociateResourceShare(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateResourceShareResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateResourceSharePermission

        /// <summary>
        /// Removes a managed permission from a resource share. Permission changes take effect
        /// immediately. You can remove a managed permission from a resource share only if there
        /// are currently no resources of the relevant resource type currently attached to the
        /// resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResourceSharePermission service method.</param>
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
        public virtual DisassociateResourceSharePermissionResponse DisassociateResourceSharePermission(DisassociateResourceSharePermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateResourceSharePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResourceSharePermissionResponseUnmarshaller.Instance;

            return Invoke<DisassociateResourceSharePermissionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateResourceSharePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResourceSharePermission operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateResourceSharePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DisassociateResourceSharePermission">REST API Reference for DisassociateResourceSharePermission Operation</seealso>
        public virtual IAsyncResult BeginDisassociateResourceSharePermission(DisassociateResourceSharePermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateResourceSharePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResourceSharePermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateResourceSharePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateResourceSharePermission.</param>
        /// 
        /// <returns>Returns a  DisassociateResourceSharePermissionResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DisassociateResourceSharePermission">REST API Reference for DisassociateResourceSharePermission Operation</seealso>
        public virtual DisassociateResourceSharePermissionResponse EndDisassociateResourceSharePermission(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateResourceSharePermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  EnableSharingWithAwsOrganization

        /// <summary>
        /// Enables resource sharing within your organization in Organizations. This operation
        /// creates a service-linked role called <code>AWSServiceRoleForResourceAccessManager</code>
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
        public virtual EnableSharingWithAwsOrganizationResponse EnableSharingWithAwsOrganization(EnableSharingWithAwsOrganizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableSharingWithAwsOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableSharingWithAwsOrganizationResponseUnmarshaller.Instance;

            return Invoke<EnableSharingWithAwsOrganizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableSharingWithAwsOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableSharingWithAwsOrganization operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableSharingWithAwsOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/EnableSharingWithAwsOrganization">REST API Reference for EnableSharingWithAwsOrganization Operation</seealso>
        public virtual IAsyncResult BeginEnableSharingWithAwsOrganization(EnableSharingWithAwsOrganizationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableSharingWithAwsOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableSharingWithAwsOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableSharingWithAwsOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableSharingWithAwsOrganization.</param>
        /// 
        /// <returns>Returns a  EnableSharingWithAwsOrganizationResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/EnableSharingWithAwsOrganization">REST API Reference for EnableSharingWithAwsOrganization Operation</seealso>
        public virtual EnableSharingWithAwsOrganizationResponse EndEnableSharingWithAwsOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableSharingWithAwsOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPermission

        /// <summary>
        /// Retrieves the contents of a managed permission in JSON format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPermission service method.</param>
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
        public virtual GetPermissionResponse GetPermission(GetPermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPermissionResponseUnmarshaller.Instance;

            return Invoke<GetPermissionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPermission operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetPermission">REST API Reference for GetPermission Operation</seealso>
        public virtual IAsyncResult BeginGetPermission(GetPermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPermission.</param>
        /// 
        /// <returns>Returns a  GetPermissionResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetPermission">REST API Reference for GetPermission Operation</seealso>
        public virtual GetPermissionResponse EndGetPermission(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourcePolicies

        /// <summary>
        /// Retrieves the resource policies for the specified resources that you own and have
        /// shared.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicies service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicies service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The operation failed because the specified value for <code>NextToken</code> isn't
        /// valid. You must specify a value you received in the <code>NextToken</code> response
        /// of a previous call to this operation.
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
        public virtual GetResourcePoliciesResponse GetResourcePolicies(GetResourcePoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePoliciesResponseUnmarshaller.Instance;

            return Invoke<GetResourcePoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicies operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourcePolicies">REST API Reference for GetResourcePolicies Operation</seealso>
        public virtual IAsyncResult BeginGetResourcePolicies(GetResourcePoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePolicies.</param>
        /// 
        /// <returns>Returns a  GetResourcePoliciesResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourcePolicies">REST API Reference for GetResourcePolicies Operation</seealso>
        public virtual GetResourcePoliciesResponse EndGetResourcePolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourcePoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourceShareAssociations

        /// <summary>
        /// Retrieves the lists of resources and principals that associated for resource shares
        /// that you own.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceShareAssociations service method.</param>
        /// 
        /// <returns>The response from the GetResourceShareAssociations service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The operation failed because the specified value for <code>NextToken</code> isn't
        /// valid. You must specify a value you received in the <code>NextToken</code> response
        /// of a previous call to this operation.
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
        public virtual GetResourceShareAssociationsResponse GetResourceShareAssociations(GetResourceShareAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceShareAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceShareAssociationsResponseUnmarshaller.Instance;

            return Invoke<GetResourceShareAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceShareAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceShareAssociations operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceShareAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourceShareAssociations">REST API Reference for GetResourceShareAssociations Operation</seealso>
        public virtual IAsyncResult BeginGetResourceShareAssociations(GetResourceShareAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceShareAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceShareAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceShareAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceShareAssociations.</param>
        /// 
        /// <returns>Returns a  GetResourceShareAssociationsResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourceShareAssociations">REST API Reference for GetResourceShareAssociations Operation</seealso>
        public virtual GetResourceShareAssociationsResponse EndGetResourceShareAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourceShareAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourceShareInvitations

        /// <summary>
        /// Retrieves details about invitations that you have received for resource shares.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceShareInvitations service method.</param>
        /// 
        /// <returns>The response from the GetResourceShareInvitations service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidMaxResultsException">
        /// The operation failed because the specified value for <code>MaxResults</code> isn't
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The operation failed because the specified value for <code>NextToken</code> isn't
        /// valid. You must specify a value you received in the <code>NextToken</code> response
        /// of a previous call to this operation.
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
        public virtual GetResourceShareInvitationsResponse GetResourceShareInvitations(GetResourceShareInvitationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceShareInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceShareInvitationsResponseUnmarshaller.Instance;

            return Invoke<GetResourceShareInvitationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceShareInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceShareInvitations operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceShareInvitations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourceShareInvitations">REST API Reference for GetResourceShareInvitations Operation</seealso>
        public virtual IAsyncResult BeginGetResourceShareInvitations(GetResourceShareInvitationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceShareInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceShareInvitationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceShareInvitations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceShareInvitations.</param>
        /// 
        /// <returns>Returns a  GetResourceShareInvitationsResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourceShareInvitations">REST API Reference for GetResourceShareInvitations Operation</seealso>
        public virtual GetResourceShareInvitationsResponse EndGetResourceShareInvitations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourceShareInvitationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourceShares

        /// <summary>
        /// Retrieves details about the resource shares that you own or that are shared with you.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceShares service method.</param>
        /// 
        /// <returns>The response from the GetResourceShares service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The operation failed because the specified value for <code>NextToken</code> isn't
        /// valid. You must specify a value you received in the <code>NextToken</code> response
        /// of a previous call to this operation.
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
        public virtual GetResourceSharesResponse GetResourceShares(GetResourceSharesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceSharesResponseUnmarshaller.Instance;

            return Invoke<GetResourceSharesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceShares operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceShares operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceShares
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourceShares">REST API Reference for GetResourceShares Operation</seealso>
        public virtual IAsyncResult BeginGetResourceShares(GetResourceSharesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceSharesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceShares operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceShares.</param>
        /// 
        /// <returns>Returns a  GetResourceSharesResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourceShares">REST API Reference for GetResourceShares Operation</seealso>
        public virtual GetResourceSharesResponse EndGetResourceShares(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourceSharesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPendingInvitationResources

        /// <summary>
        /// Lists the resources in a resource share that is shared with you but for which the
        /// invitation is still <code>PENDING</code>. That means that you haven't accepted or
        /// rejected the invitation and the invitation hasn't expired.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPendingInvitationResources service method.</param>
        /// 
        /// <returns>The response from the ListPendingInvitationResources service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The operation failed because the specified value for <code>NextToken</code> isn't
        /// valid. You must specify a value you received in the <code>NextToken</code> response
        /// of a previous call to this operation.
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
        public virtual ListPendingInvitationResourcesResponse ListPendingInvitationResources(ListPendingInvitationResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPendingInvitationResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPendingInvitationResourcesResponseUnmarshaller.Instance;

            return Invoke<ListPendingInvitationResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPendingInvitationResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPendingInvitationResources operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPendingInvitationResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPendingInvitationResources">REST API Reference for ListPendingInvitationResources Operation</seealso>
        public virtual IAsyncResult BeginListPendingInvitationResources(ListPendingInvitationResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPendingInvitationResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPendingInvitationResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPendingInvitationResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPendingInvitationResources.</param>
        /// 
        /// <returns>Returns a  ListPendingInvitationResourcesResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPendingInvitationResources">REST API Reference for ListPendingInvitationResources Operation</seealso>
        public virtual ListPendingInvitationResourcesResponse EndListPendingInvitationResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPendingInvitationResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPermissionAssociations

        /// <summary>
        /// Lists information about the managed permission and its associations to any resource
        /// shares that use this managed permission. This lets you see which resource shares use
        /// which versions of the specified managed permission.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissionAssociations service method.</param>
        /// 
        /// <returns>The response from the ListPermissionAssociations service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The operation failed because the specified value for <code>NextToken</code> isn't
        /// valid. You must specify a value you received in the <code>NextToken</code> response
        /// of a previous call to this operation.
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
        public virtual ListPermissionAssociationsResponse ListPermissionAssociations(ListPermissionAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListPermissionAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPermissionAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPermissionAssociations operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPermissionAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPermissionAssociations">REST API Reference for ListPermissionAssociations Operation</seealso>
        public virtual IAsyncResult BeginListPermissionAssociations(ListPermissionAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPermissionAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPermissionAssociations.</param>
        /// 
        /// <returns>Returns a  ListPermissionAssociationsResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPermissionAssociations">REST API Reference for ListPermissionAssociations Operation</seealso>
        public virtual ListPermissionAssociationsResponse EndListPermissionAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPermissionAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPermissions

        /// <summary>
        /// Retrieves a list of available RAM permissions that you can use for the supported resource
        /// types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissions service method.</param>
        /// 
        /// <returns>The response from the ListPermissions service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The operation failed because the specified value for <code>NextToken</code> isn't
        /// valid. You must specify a value you received in the <code>NextToken</code> response
        /// of a previous call to this operation.
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
        public virtual ListPermissionsResponse ListPermissions(ListPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionsResponseUnmarshaller.Instance;

            return Invoke<ListPermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPermissions operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPermissions">REST API Reference for ListPermissions Operation</seealso>
        public virtual IAsyncResult BeginListPermissions(ListPermissionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPermissions.</param>
        /// 
        /// <returns>Returns a  ListPermissionsResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPermissions">REST API Reference for ListPermissions Operation</seealso>
        public virtual ListPermissionsResponse EndListPermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPermissionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPermissionVersions

        /// <summary>
        /// Lists the available versions of the specified RAM permission.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissionVersions service method.</param>
        /// 
        /// <returns>The response from the ListPermissionVersions service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The operation failed because the specified value for <code>NextToken</code> isn't
        /// valid. You must specify a value you received in the <code>NextToken</code> response
        /// of a previous call to this operation.
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
        public virtual ListPermissionVersionsResponse ListPermissionVersions(ListPermissionVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionVersionsResponseUnmarshaller.Instance;

            return Invoke<ListPermissionVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPermissionVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPermissionVersions operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPermissionVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPermissionVersions">REST API Reference for ListPermissionVersions Operation</seealso>
        public virtual IAsyncResult BeginListPermissionVersions(ListPermissionVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPermissionVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPermissionVersions.</param>
        /// 
        /// <returns>Returns a  ListPermissionVersionsResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPermissionVersions">REST API Reference for ListPermissionVersions Operation</seealso>
        public virtual ListPermissionVersionsResponse EndListPermissionVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPermissionVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPrincipals

        /// <summary>
        /// Lists the principals that you are sharing resources with or that are sharing resources
        /// with you.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipals service method.</param>
        /// 
        /// <returns>The response from the ListPrincipals service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The operation failed because the specified value for <code>NextToken</code> isn't
        /// valid. You must specify a value you received in the <code>NextToken</code> response
        /// of a previous call to this operation.
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
        public virtual ListPrincipalsResponse ListPrincipals(ListPrincipalsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPrincipalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrincipalsResponseUnmarshaller.Instance;

            return Invoke<ListPrincipalsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPrincipals operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipals operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPrincipals
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPrincipals">REST API Reference for ListPrincipals Operation</seealso>
        public virtual IAsyncResult BeginListPrincipals(ListPrincipalsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPrincipalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrincipalsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPrincipals operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPrincipals.</param>
        /// 
        /// <returns>Returns a  ListPrincipalsResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPrincipals">REST API Reference for ListPrincipals Operation</seealso>
        public virtual ListPrincipalsResponse EndListPrincipals(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPrincipalsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListReplacePermissionAssociationsWork

        /// <summary>
        /// Retrieves the current status of the asynchronous tasks performed by RAM when you perform
        /// the <a>ReplacePermissionAssociationsWork</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReplacePermissionAssociationsWork service method.</param>
        /// 
        /// <returns>The response from the ListReplacePermissionAssociationsWork service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The operation failed because the specified value for <code>NextToken</code> isn't
        /// valid. You must specify a value you received in the <code>NextToken</code> response
        /// of a previous call to this operation.
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
        public virtual ListReplacePermissionAssociationsWorkResponse ListReplacePermissionAssociationsWork(ListReplacePermissionAssociationsWorkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReplacePermissionAssociationsWorkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReplacePermissionAssociationsWorkResponseUnmarshaller.Instance;

            return Invoke<ListReplacePermissionAssociationsWorkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListReplacePermissionAssociationsWork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReplacePermissionAssociationsWork operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReplacePermissionAssociationsWork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListReplacePermissionAssociationsWork">REST API Reference for ListReplacePermissionAssociationsWork Operation</seealso>
        public virtual IAsyncResult BeginListReplacePermissionAssociationsWork(ListReplacePermissionAssociationsWorkRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReplacePermissionAssociationsWorkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReplacePermissionAssociationsWorkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListReplacePermissionAssociationsWork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReplacePermissionAssociationsWork.</param>
        /// 
        /// <returns>Returns a  ListReplacePermissionAssociationsWorkResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListReplacePermissionAssociationsWork">REST API Reference for ListReplacePermissionAssociationsWork Operation</seealso>
        public virtual ListReplacePermissionAssociationsWorkResponse EndListReplacePermissionAssociationsWork(IAsyncResult asyncResult)
        {
            return EndInvoke<ListReplacePermissionAssociationsWorkResponse>(asyncResult);
        }

        #endregion
        
        #region  ListResources

        /// <summary>
        /// Lists the resources that you added to a resource share or the resources that are shared
        /// with you.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResources service method.</param>
        /// 
        /// <returns>The response from the ListResources service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The operation failed because the specified value for <code>NextToken</code> isn't
        /// valid. You must specify a value you received in the <code>NextToken</code> response
        /// of a previous call to this operation.
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
        public virtual ListResourcesResponse ListResources(ListResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesResponseUnmarshaller.Instance;

            return Invoke<ListResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResources operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListResources">REST API Reference for ListResources Operation</seealso>
        public virtual IAsyncResult BeginListResources(ListResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResources.</param>
        /// 
        /// <returns>Returns a  ListResourcesResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListResources">REST API Reference for ListResources Operation</seealso>
        public virtual ListResourcesResponse EndListResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListResourceSharePermissions

        /// <summary>
        /// Lists the RAM permissions that are associated with a resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceSharePermissions service method.</param>
        /// 
        /// <returns>The response from the ListResourceSharePermissions service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The operation failed because the specified value for <code>NextToken</code> isn't
        /// valid. You must specify a value you received in the <code>NextToken</code> response
        /// of a previous call to this operation.
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
        public virtual ListResourceSharePermissionsResponse ListResourceSharePermissions(ListResourceSharePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceSharePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceSharePermissionsResponseUnmarshaller.Instance;

            return Invoke<ListResourceSharePermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceSharePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceSharePermissions operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceSharePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListResourceSharePermissions">REST API Reference for ListResourceSharePermissions Operation</seealso>
        public virtual IAsyncResult BeginListResourceSharePermissions(ListResourceSharePermissionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceSharePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceSharePermissionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceSharePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceSharePermissions.</param>
        /// 
        /// <returns>Returns a  ListResourceSharePermissionsResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListResourceSharePermissions">REST API Reference for ListResourceSharePermissions Operation</seealso>
        public virtual ListResourceSharePermissionsResponse EndListResourceSharePermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResourceSharePermissionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListResourceTypes

        /// <summary>
        /// Lists the resource types that can be shared by RAM.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTypes service method.</param>
        /// 
        /// <returns>The response from the ListResourceTypes service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The operation failed because the specified value for <code>NextToken</code> isn't
        /// valid. You must specify a value you received in the <code>NextToken</code> response
        /// of a previous call to this operation.
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
        public virtual ListResourceTypesResponse ListResourceTypes(ListResourceTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceTypesResponseUnmarshaller.Instance;

            return Invoke<ListResourceTypesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTypes operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListResourceTypes">REST API Reference for ListResourceTypes Operation</seealso>
        public virtual IAsyncResult BeginListResourceTypes(ListResourceTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceTypes.</param>
        /// 
        /// <returns>Returns a  ListResourceTypesResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListResourceTypes">REST API Reference for ListResourceTypes Operation</seealso>
        public virtual ListResourceTypesResponse EndListResourceTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResourceTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  PromotePermissionCreatedFromPolicy

        /// <summary>
        /// When you attach a resource-based policy to a resource, RAM automatically creates a
        /// resource share of <code>featureSet</code>=<code>CREATED_FROM_POLICY</code> with a
        /// managed permission that has the same IAM permissions as the original resource-based
        /// policy. However, this type of managed permission is visible to only the resource share
        /// owner, and the associated resource share can't be modified by using RAM.
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
        /// The original <code>CREATED_FROM_POLICY</code> policy isn't deleted, and resource shares
        /// using that original policy aren't automatically updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't modify a <code>CREATED_FROM_POLICY</code> resource share so you can't associate
        /// the new customer managed permission by using <code>ReplacePermsissionAssociations</code>.
        /// However, if you use <a>PromoteResourceShareCreatedFromPolicy</a>, that operation automatically
        /// associates the fully manageable customer managed permission to the newly promoted
        /// <code>STANDARD</code> resource share.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you promote a resource share, if the original <code>CREATED_FROM_POLICY</code>
        /// managed permission has no other associations to A resource share, then RAM automatically
        /// deletes it.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PromotePermissionCreatedFromPolicy service method.</param>
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
        public virtual PromotePermissionCreatedFromPolicyResponse PromotePermissionCreatedFromPolicy(PromotePermissionCreatedFromPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PromotePermissionCreatedFromPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PromotePermissionCreatedFromPolicyResponseUnmarshaller.Instance;

            return Invoke<PromotePermissionCreatedFromPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PromotePermissionCreatedFromPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PromotePermissionCreatedFromPolicy operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPromotePermissionCreatedFromPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/PromotePermissionCreatedFromPolicy">REST API Reference for PromotePermissionCreatedFromPolicy Operation</seealso>
        public virtual IAsyncResult BeginPromotePermissionCreatedFromPolicy(PromotePermissionCreatedFromPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PromotePermissionCreatedFromPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PromotePermissionCreatedFromPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PromotePermissionCreatedFromPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPromotePermissionCreatedFromPolicy.</param>
        /// 
        /// <returns>Returns a  PromotePermissionCreatedFromPolicyResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/PromotePermissionCreatedFromPolicy">REST API Reference for PromotePermissionCreatedFromPolicy Operation</seealso>
        public virtual PromotePermissionCreatedFromPolicyResponse EndPromotePermissionCreatedFromPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PromotePermissionCreatedFromPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  PromoteResourceShareCreatedFromPolicy

        /// <summary>
        /// When you attach a resource-based policy to a resource, RAM automatically creates a
        /// resource share of <code>featureSet</code>=<code>CREATED_FROM_POLICY</code> with a
        /// managed permission that has the same IAM permissions as the original resource-based
        /// policy. However, this type of managed permission is visible to only the resource share
        /// owner, and the associated resource share can't be modified by using RAM.
        /// 
        ///  
        /// <para>
        /// This operation promotes the resource share to a <code>STANDARD</code> resource share
        /// that is fully manageable in RAM. When you promote a resource share, you can then manage
        /// the resource share in RAM and it becomes visible to all of the principals you shared
        /// it with.
        /// </para>
        ///  <important> 
        /// <para>
        /// Before you perform this operation, you should first run <a>PromotePermissionCreatedFromPolicy</a>to
        /// ensure that you have an appropriate customer managed permission that can be associated
        /// with this resource share after its is promoted. If this operation can't find a managed
        /// permission that exactly matches the existing <code>CREATED_FROM_POLICY</code> permission,
        /// then this operation fails.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PromoteResourceShareCreatedFromPolicy service method.</param>
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
        public virtual PromoteResourceShareCreatedFromPolicyResponse PromoteResourceShareCreatedFromPolicy(PromoteResourceShareCreatedFromPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PromoteResourceShareCreatedFromPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PromoteResourceShareCreatedFromPolicyResponseUnmarshaller.Instance;

            return Invoke<PromoteResourceShareCreatedFromPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PromoteResourceShareCreatedFromPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PromoteResourceShareCreatedFromPolicy operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPromoteResourceShareCreatedFromPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/PromoteResourceShareCreatedFromPolicy">REST API Reference for PromoteResourceShareCreatedFromPolicy Operation</seealso>
        public virtual IAsyncResult BeginPromoteResourceShareCreatedFromPolicy(PromoteResourceShareCreatedFromPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PromoteResourceShareCreatedFromPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PromoteResourceShareCreatedFromPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PromoteResourceShareCreatedFromPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPromoteResourceShareCreatedFromPolicy.</param>
        /// 
        /// <returns>Returns a  PromoteResourceShareCreatedFromPolicyResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/PromoteResourceShareCreatedFromPolicy">REST API Reference for PromoteResourceShareCreatedFromPolicy Operation</seealso>
        public virtual PromoteResourceShareCreatedFromPolicyResponse EndPromoteResourceShareCreatedFromPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PromoteResourceShareCreatedFromPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  RejectResourceShareInvitation

        /// <summary>
        /// Rejects an invitation to a resource share from another Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectResourceShareInvitation service method.</param>
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
        public virtual RejectResourceShareInvitationResponse RejectResourceShareInvitation(RejectResourceShareInvitationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectResourceShareInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectResourceShareInvitationResponseUnmarshaller.Instance;

            return Invoke<RejectResourceShareInvitationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RejectResourceShareInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectResourceShareInvitation operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectResourceShareInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/RejectResourceShareInvitation">REST API Reference for RejectResourceShareInvitation Operation</seealso>
        public virtual IAsyncResult BeginRejectResourceShareInvitation(RejectResourceShareInvitationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectResourceShareInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectResourceShareInvitationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RejectResourceShareInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectResourceShareInvitation.</param>
        /// 
        /// <returns>Returns a  RejectResourceShareInvitationResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/RejectResourceShareInvitation">REST API Reference for RejectResourceShareInvitation Operation</seealso>
        public virtual RejectResourceShareInvitationResponse EndRejectResourceShareInvitation(IAsyncResult asyncResult)
        {
            return EndInvoke<RejectResourceShareInvitationResponse>(asyncResult);
        }

        #endregion
        
        #region  ReplacePermissionAssociations

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
        /// default version of the permission by specifying the same value for the <code>fromPermissionArn</code>
        /// and <code>toPermissionArn</code> parameters.
        /// </para>
        ///  
        /// <para>
        /// You can use the optional <code>fromPermissionVersion</code> parameter to update only
        /// those resources that use a specified version of the managed permission to the new
        /// managed permission.
        /// </para>
        ///  <important> 
        /// <para>
        /// To successfully perform this operation, you must have permission to update the resource-based
        /// policy on all affected resource types.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplacePermissionAssociations service method.</param>
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
        public virtual ReplacePermissionAssociationsResponse ReplacePermissionAssociations(ReplacePermissionAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplacePermissionAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplacePermissionAssociationsResponseUnmarshaller.Instance;

            return Invoke<ReplacePermissionAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReplacePermissionAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplacePermissionAssociations operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReplacePermissionAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ReplacePermissionAssociations">REST API Reference for ReplacePermissionAssociations Operation</seealso>
        public virtual IAsyncResult BeginReplacePermissionAssociations(ReplacePermissionAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplacePermissionAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplacePermissionAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ReplacePermissionAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReplacePermissionAssociations.</param>
        /// 
        /// <returns>Returns a  ReplacePermissionAssociationsResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ReplacePermissionAssociations">REST API Reference for ReplacePermissionAssociations Operation</seealso>
        public virtual ReplacePermissionAssociationsResponse EndReplacePermissionAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ReplacePermissionAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  SetDefaultPermissionVersion

        /// <summary>
        /// Designates the specified version number as the default version for the specified customer
        /// managed permission. New resource shares automatically use this new default permission.
        /// Existing resource shares continue to use their original permission version, but you
        /// can use <a>ReplacePermissionAssociations</a> to update them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultPermissionVersion service method.</param>
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
        public virtual SetDefaultPermissionVersionResponse SetDefaultPermissionVersion(SetDefaultPermissionVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetDefaultPermissionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDefaultPermissionVersionResponseUnmarshaller.Instance;

            return Invoke<SetDefaultPermissionVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetDefaultPermissionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultPermissionVersion operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetDefaultPermissionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/SetDefaultPermissionVersion">REST API Reference for SetDefaultPermissionVersion Operation</seealso>
        public virtual IAsyncResult BeginSetDefaultPermissionVersion(SetDefaultPermissionVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetDefaultPermissionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDefaultPermissionVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetDefaultPermissionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetDefaultPermissionVersion.</param>
        /// 
        /// <returns>Returns a  SetDefaultPermissionVersionResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/SetDefaultPermissionVersion">REST API Reference for SetDefaultPermissionVersion Operation</seealso>
        public virtual SetDefaultPermissionVersionResponse EndSetDefaultPermissionVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<SetDefaultPermissionVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes the specified tag key and value pairs from the specified resource share or
        /// managed permission.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateResourceShare

        /// <summary>
        /// Modifies some of the properties of the specified resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceShare service method.</param>
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
        public virtual UpdateResourceShareResponse UpdateResourceShare(UpdateResourceShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceShareResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceShareResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResourceShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceShare operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResourceShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/UpdateResourceShare">REST API Reference for UpdateResourceShare Operation</seealso>
        public virtual IAsyncResult BeginUpdateResourceShare(UpdateResourceShareRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceShareResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResourceShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResourceShare.</param>
        /// 
        /// <returns>Returns a  UpdateResourceShareResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/UpdateResourceShare">REST API Reference for UpdateResourceShare Operation</seealso>
        public virtual UpdateResourceShareResponse EndUpdateResourceShare(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateResourceShareResponse>(asyncResult);
        }

        #endregion
        
    }
}