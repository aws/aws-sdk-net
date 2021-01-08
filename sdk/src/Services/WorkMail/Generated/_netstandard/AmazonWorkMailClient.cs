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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.WorkMail.Model;
using Amazon.WorkMail.Model.Internal.MarshallTransformations;
using Amazon.WorkMail.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.WorkMail
{
    /// <summary>
    /// Implementation for accessing WorkMail
    ///
    /// Amazon WorkMail is a secure, managed business email and calendaring service with support
    /// for existing desktop and mobile email clients. You can access your email, contacts,
    /// and calendars using Microsoft Outlook, your browser, or other native iOS and Android
    /// email applications. You can integrate WorkMail with your existing corporate directory
    /// and control both the keys that encrypt your data and the location in which your data
    /// is stored.
    /// 
    ///  
    /// <para>
    /// The WorkMail API is designed for the following scenarios:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Listing and describing organizations
    /// </para>
    ///  </li> </ul> <ul> <li> 
    /// <para>
    /// Managing users
    /// </para>
    ///  </li> </ul> <ul> <li> 
    /// <para>
    /// Managing groups
    /// </para>
    ///  </li> </ul> <ul> <li> 
    /// <para>
    /// Managing resources
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// All WorkMail API operations are Amazon-authenticated and certificate-signed. They
    /// not only require the use of the AWS SDK, but also allow for the exclusive use of AWS
    /// Identity and Access Management users and roles to help facilitate access, trust, and
    /// permission policies. By creating a role and allowing an IAM user to access the WorkMail
    /// site, the IAM user gains full administrative visibility into the entire WorkMail organization
    /// (or as set in the IAM policy). This includes, but is not limited to, the ability to
    /// create, update, and delete users, groups, and resources. This allows developers to
    /// perform the scenarios listed above, as well as give users the ability to grant access
    /// on a selective basis using the IAM model.
    /// </para>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonWorkMailClient : AmazonServiceClient, IAmazonWorkMail
    {
        private static IServiceMetadata serviceMetadata = new AmazonWorkMailMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonWorkMailClient with the credentials loaded from the application's
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
        public AmazonWorkMailClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWorkMailConfig()) { }

        /// <summary>
        /// Constructs AmazonWorkMailClient with the credentials loaded from the application's
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
        public AmazonWorkMailClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWorkMailConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonWorkMailClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonWorkMailClient Configuration Object</param>
        public AmazonWorkMailClient(AmazonWorkMailConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonWorkMailClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonWorkMailClient(AWSCredentials credentials)
            : this(credentials, new AmazonWorkMailConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkMailClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonWorkMailConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailClient with AWS Credentials and an
        /// AmazonWorkMailClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonWorkMailClient Configuration Object</param>
        public AmazonWorkMailClient(AWSCredentials credentials, AmazonWorkMailConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonWorkMailClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkMailConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkMailClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkMailConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkMailClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonWorkMailClient Configuration Object</param>
        public AmazonWorkMailClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonWorkMailConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonWorkMailClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkMailConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkMailClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkMailConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkMailClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonWorkMailClient Configuration Object</param>
        public AmazonWorkMailClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonWorkMailConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IWorkMailPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IWorkMailPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new WorkMailPaginatorFactory(this);
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


        #region  AssociateDelegateToResource

        internal virtual AssociateDelegateToResourceResponse AssociateDelegateToResource(AssociateDelegateToResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDelegateToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDelegateToResourceResponseUnmarshaller.Instance;

            return Invoke<AssociateDelegateToResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds a member (user or group) to the resource's set of delegates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDelegateToResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateDelegateToResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/AssociateDelegateToResource">REST API Reference for AssociateDelegateToResource Operation</seealso>
        public virtual Task<AssociateDelegateToResourceResponse> AssociateDelegateToResourceAsync(AssociateDelegateToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDelegateToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDelegateToResourceResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateDelegateToResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateMemberToGroup

        internal virtual AssociateMemberToGroupResponse AssociateMemberToGroup(AssociateMemberToGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateMemberToGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMemberToGroupResponseUnmarshaller.Instance;

            return Invoke<AssociateMemberToGroupResponse>(request, options);
        }



        /// <summary>
        /// Adds a member (user or group) to the group's set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateMemberToGroup service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The directory service doesn't recognize the credentials supplied by WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory is unavailable. It might be located in another Region or deleted.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/AssociateMemberToGroup">REST API Reference for AssociateMemberToGroup Operation</seealso>
        public virtual Task<AssociateMemberToGroupResponse> AssociateMemberToGroupAsync(AssociateMemberToGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateMemberToGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMemberToGroupResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateMemberToGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelMailboxExportJob

        internal virtual CancelMailboxExportJobResponse CancelMailboxExportJob(CancelMailboxExportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelMailboxExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMailboxExportJobResponseUnmarshaller.Instance;

            return Invoke<CancelMailboxExportJobResponse>(request, options);
        }



        /// <summary>
        /// Cancels a mailbox export job.
        /// 
        ///  <note> 
        /// <para>
        /// If the mailbox export job is near completion, it might not be possible to cancel it.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMailboxExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelMailboxExportJob service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CancelMailboxExportJob">REST API Reference for CancelMailboxExportJob Operation</seealso>
        public virtual Task<CancelMailboxExportJobResponse> CancelMailboxExportJobAsync(CancelMailboxExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelMailboxExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMailboxExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<CancelMailboxExportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAlias

        internal virtual CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAliasResponse>(request, options);
        }



        /// <summary>
        /// Adds an alias to the set of a given member (user or group) of Amazon WorkMail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EmailAddressInUseException">
        /// The email address that you're trying to assign is already created for a different
        /// user, group, or resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.LimitExceededException">
        /// The request exceeds the limit of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.MailDomainNotFoundException">
        /// For an email or alias to be created in Amazon WorkMail, the included domain must be
        /// defined in the organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.MailDomainStateException">
        /// After a domain has been added to the organization, it must be verified. The domain
        /// is not yet verified.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGroup

        internal virtual CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a group that can be used in Amazon WorkMail by calling the <a>RegisterToWorkMail</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The directory service doesn't recognize the credentials supplied by WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory is unavailable. It might be located in another Region or deleted.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.NameAvailabilityException">
        /// The user, group, or resource name isn't unique in Amazon WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ReservedNameException">
        /// This user, group, or resource name is not allowed in Amazon WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateOrganization

        internal virtual CreateOrganizationResponse CreateOrganization(CreateOrganizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOrganizationResponseUnmarshaller.Instance;

            return Invoke<CreateOrganizationResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Amazon WorkMail organization. Optionally, you can choose to associate
        /// an existing AWS Directory Service directory with your organization. If an AWS Directory
        /// Service directory ID is specified, the organization alias must match the directory
        /// alias. If you choose not to associate an existing directory with your organization,
        /// then we create a new Amazon WorkMail directory for you. For more information, see
        /// <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/add_new_organization.html">Adding
        /// an organization</a> in the <i>Amazon WorkMail Administrator Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can associate multiple email domains with an organization, then set your default
        /// email domain from the Amazon WorkMail console. You can also associate a domain that
        /// is managed in an Amazon Route 53 public hosted zone. For more information, see <a
        /// href="https://docs.aws.amazon.com/workmail/latest/adminguide/add_domain.html">Adding
        /// a domain</a> and <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/default_domain.html">Choosing
        /// the default domain</a> in the <i>Amazon WorkMail Administrator Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Optionally, you can use a customer managed master key from AWS Key Management Service
        /// (AWS KMS) to encrypt email for your organization. If you don't associate an AWS KMS
        /// key, Amazon WorkMail creates a default AWS managed master key for you.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOrganization service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryInUseException">
        /// The directory is already in use by another WorkMail organization in the same account
        /// and Region.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory is unavailable. It might be located in another Region or deleted.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.LimitExceededException">
        /// The request exceeds the limit of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.NameAvailabilityException">
        /// The user, group, or resource name isn't unique in Amazon WorkMail.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateOrganization">REST API Reference for CreateOrganization Operation</seealso>
        public virtual Task<CreateOrganizationResponse> CreateOrganizationAsync(CreateOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateResource

        internal virtual CreateResourceResponse CreateResource(CreateResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceResponseUnmarshaller.Instance;

            return Invoke<CreateResourceResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Amazon WorkMail resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The directory service doesn't recognize the credentials supplied by WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory is unavailable. It might be located in another Region or deleted.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.NameAvailabilityException">
        /// The user, group, or resource name isn't unique in Amazon WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ReservedNameException">
        /// This user, group, or resource name is not allowed in Amazon WorkMail.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateResource">REST API Reference for CreateResource Operation</seealso>
        public virtual Task<CreateResourceResponse> CreateResourceAsync(CreateResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateUser

        internal virtual CreateUserResponse CreateUser(CreateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return Invoke<CreateUserResponse>(request, options);
        }



        /// <summary>
        /// Creates a user who can be used in Amazon WorkMail by calling the <a>RegisterToWorkMail</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The directory service doesn't recognize the credentials supplied by WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory is unavailable. It might be located in another Region or deleted.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidPasswordException">
        /// The supplied password doesn't match the minimum security constraints, such as length
        /// or use of special characters.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.NameAvailabilityException">
        /// The user, group, or resource name isn't unique in Amazon WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ReservedNameException">
        /// This user, group, or resource name is not allowed in Amazon WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAccessControlRule

        internal virtual DeleteAccessControlRuleResponse DeleteAccessControlRule(DeleteAccessControlRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessControlRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessControlRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessControlRuleResponse>(request, options);
        }



        /// <summary>
        /// Deletes an access control rule for the specified WorkMail organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessControlRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessControlRule service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteAccessControlRule">REST API Reference for DeleteAccessControlRule Operation</seealso>
        public virtual Task<DeleteAccessControlRuleResponse> DeleteAccessControlRuleAsync(DeleteAccessControlRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessControlRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessControlRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAccessControlRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAlias

        internal virtual DeleteAliasResponse DeleteAlias(DeleteAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteAliasResponse>(request, options);
        }



        /// <summary>
        /// Remove one or more specified aliases from a set of aliases for a given user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGroup

        internal virtual DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a group from Amazon WorkMail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The directory service doesn't recognize the credentials supplied by WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory is unavailable. It might be located in another Region or deleted.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMailboxPermissions

        internal virtual DeleteMailboxPermissionsResponse DeleteMailboxPermissions(DeleteMailboxPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMailboxPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMailboxPermissionsResponseUnmarshaller.Instance;

            return Invoke<DeleteMailboxPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Deletes permissions granted to a member (user or group).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMailboxPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMailboxPermissions service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteMailboxPermissions">REST API Reference for DeleteMailboxPermissions Operation</seealso>
        public virtual Task<DeleteMailboxPermissionsResponse> DeleteMailboxPermissionsAsync(DeleteMailboxPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMailboxPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMailboxPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMailboxPermissionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteOrganization

        internal virtual DeleteOrganizationResponse DeleteOrganization(DeleteOrganizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOrganizationResponseUnmarshaller.Instance;

            return Invoke<DeleteOrganizationResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon WorkMail organization and all underlying AWS resources managed by
        /// Amazon WorkMail as part of the organization. You can choose whether to delete the
        /// associated directory. For more information, see <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/remove_organization.html">Removing
        /// an organization</a> in the <i>Amazon WorkMail Administrator Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOrganization service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteOrganization">REST API Reference for DeleteOrganization Operation</seealso>
        public virtual Task<DeleteOrganizationResponse> DeleteOrganizationAsync(DeleteOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResource

        internal virtual DeleteResourceResponse DeleteResource(DeleteResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceResponseUnmarshaller.Instance;

            return Invoke<DeleteResourceResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteResource">REST API Reference for DeleteResource Operation</seealso>
        public virtual Task<DeleteResourceResponse> DeleteResourceAsync(DeleteResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRetentionPolicy

        internal virtual DeleteRetentionPolicyResponse DeleteRetentionPolicy(DeleteRetentionPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRetentionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRetentionPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteRetentionPolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified retention policy from the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRetentionPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRetentionPolicy service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteRetentionPolicy">REST API Reference for DeleteRetentionPolicy Operation</seealso>
        public virtual Task<DeleteRetentionPolicyResponse> DeleteRetentionPolicyAsync(DeleteRetentionPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRetentionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRetentionPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRetentionPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteUser

        internal virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserResponse>(request, options);
        }



        /// <summary>
        /// Deletes a user from Amazon WorkMail and all subsequent systems. Before you can delete
        /// a user, the user state must be <code>DISABLED</code>. Use the <a>DescribeUser</a>
        /// action to confirm the user state.
        /// 
        ///  
        /// <para>
        /// Deleting a user is permanent and cannot be undone. WorkMail archives user mailboxes
        /// for 30 days before they are permanently removed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The directory service doesn't recognize the credentials supplied by WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory is unavailable. It might be located in another Region or deleted.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterFromWorkMail

        internal virtual DeregisterFromWorkMailResponse DeregisterFromWorkMail(DeregisterFromWorkMailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterFromWorkMailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterFromWorkMailResponseUnmarshaller.Instance;

            return Invoke<DeregisterFromWorkMailResponse>(request, options);
        }



        /// <summary>
        /// Mark a user, group, or resource as no longer used in Amazon WorkMail. This action
        /// disassociates the mailbox and schedules it for clean-up. WorkMail keeps mailboxes
        /// for 30 days before they are permanently removed. The functionality in the console
        /// is <i>Disable</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterFromWorkMail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterFromWorkMail service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeregisterFromWorkMail">REST API Reference for DeregisterFromWorkMail Operation</seealso>
        public virtual Task<DeregisterFromWorkMailResponse> DeregisterFromWorkMailAsync(DeregisterFromWorkMailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterFromWorkMailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterFromWorkMailResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterFromWorkMailResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeGroup

        internal virtual DescribeGroupResponse DescribeGroup(DescribeGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeGroupResponse>(request, options);
        }



        /// <summary>
        /// Returns the data available for the group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGroup service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        public virtual Task<DescribeGroupResponse> DescribeGroupAsync(DescribeGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMailboxExportJob

        internal virtual DescribeMailboxExportJobResponse DescribeMailboxExportJob(DescribeMailboxExportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMailboxExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMailboxExportJobResponseUnmarshaller.Instance;

            return Invoke<DescribeMailboxExportJobResponse>(request, options);
        }



        /// <summary>
        /// Describes the current status of a mailbox export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMailboxExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMailboxExportJob service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeMailboxExportJob">REST API Reference for DescribeMailboxExportJob Operation</seealso>
        public virtual Task<DescribeMailboxExportJobResponse> DescribeMailboxExportJobAsync(DescribeMailboxExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMailboxExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMailboxExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMailboxExportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeOrganization

        internal virtual DescribeOrganizationResponse DescribeOrganization(DescribeOrganizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationResponseUnmarshaller.Instance;

            return Invoke<DescribeOrganizationResponse>(request, options);
        }



        /// <summary>
        /// Provides more information regarding a given organization based on its identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrganization service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeOrganization">REST API Reference for DescribeOrganization Operation</seealso>
        public virtual Task<DescribeOrganizationResponse> DescribeOrganizationAsync(DescribeOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeResource

        internal virtual DescribeResourceResponse DescribeResource(DescribeResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourceResponseUnmarshaller.Instance;

            return Invoke<DescribeResourceResponse>(request, options);
        }



        /// <summary>
        /// Returns the data available for the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeResource">REST API Reference for DescribeResource Operation</seealso>
        public virtual Task<DescribeResourceResponse> DescribeResourceAsync(DescribeResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeUser

        internal virtual DescribeUserResponse DescribeUser(DescribeUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserResponseUnmarshaller.Instance;

            return Invoke<DescribeUserResponse>(request, options);
        }



        /// <summary>
        /// Provides information regarding the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        public virtual Task<DescribeUserResponse> DescribeUserAsync(DescribeUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateDelegateFromResource

        internal virtual DisassociateDelegateFromResourceResponse DisassociateDelegateFromResource(DisassociateDelegateFromResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateDelegateFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDelegateFromResourceResponseUnmarshaller.Instance;

            return Invoke<DisassociateDelegateFromResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes a member from the resource's set of delegates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDelegateFromResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateDelegateFromResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DisassociateDelegateFromResource">REST API Reference for DisassociateDelegateFromResource Operation</seealso>
        public virtual Task<DisassociateDelegateFromResourceResponse> DisassociateDelegateFromResourceAsync(DisassociateDelegateFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateDelegateFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDelegateFromResourceResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateDelegateFromResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateMemberFromGroup

        internal virtual DisassociateMemberFromGroupResponse DisassociateMemberFromGroup(DisassociateMemberFromGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateMemberFromGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMemberFromGroupResponseUnmarshaller.Instance;

            return Invoke<DisassociateMemberFromGroupResponse>(request, options);
        }



        /// <summary>
        /// Removes a member from a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateMemberFromGroup service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The directory service doesn't recognize the credentials supplied by WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory is unavailable. It might be located in another Region or deleted.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DisassociateMemberFromGroup">REST API Reference for DisassociateMemberFromGroup Operation</seealso>
        public virtual Task<DisassociateMemberFromGroupResponse> DisassociateMemberFromGroupAsync(DisassociateMemberFromGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateMemberFromGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMemberFromGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateMemberFromGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccessControlEffect

        internal virtual GetAccessControlEffectResponse GetAccessControlEffect(GetAccessControlEffectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessControlEffectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessControlEffectResponseUnmarshaller.Instance;

            return Invoke<GetAccessControlEffectResponse>(request, options);
        }



        /// <summary>
        /// Gets the effects of an organization's access control rules as they apply to a specified
        /// IPv4 address, access protocol action, or user ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessControlEffect service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessControlEffect service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetAccessControlEffect">REST API Reference for GetAccessControlEffect Operation</seealso>
        public virtual Task<GetAccessControlEffectResponse> GetAccessControlEffectAsync(GetAccessControlEffectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessControlEffectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessControlEffectResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccessControlEffectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDefaultRetentionPolicy

        internal virtual GetDefaultRetentionPolicyResponse GetDefaultRetentionPolicy(GetDefaultRetentionPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDefaultRetentionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDefaultRetentionPolicyResponseUnmarshaller.Instance;

            return Invoke<GetDefaultRetentionPolicyResponse>(request, options);
        }



        /// <summary>
        /// Gets the default retention policy details for the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDefaultRetentionPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDefaultRetentionPolicy service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetDefaultRetentionPolicy">REST API Reference for GetDefaultRetentionPolicy Operation</seealso>
        public virtual Task<GetDefaultRetentionPolicyResponse> GetDefaultRetentionPolicyAsync(GetDefaultRetentionPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDefaultRetentionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDefaultRetentionPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetDefaultRetentionPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMailboxDetails

        internal virtual GetMailboxDetailsResponse GetMailboxDetails(GetMailboxDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMailboxDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMailboxDetailsResponseUnmarshaller.Instance;

            return Invoke<GetMailboxDetailsResponse>(request, options);
        }



        /// <summary>
        /// Requests a user's mailbox details for a specified organization and user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMailboxDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMailboxDetails service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetMailboxDetails">REST API Reference for GetMailboxDetails Operation</seealso>
        public virtual Task<GetMailboxDetailsResponse> GetMailboxDetailsAsync(GetMailboxDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMailboxDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMailboxDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<GetMailboxDetailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccessControlRules

        internal virtual ListAccessControlRulesResponse ListAccessControlRules(ListAccessControlRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccessControlRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessControlRulesResponseUnmarshaller.Instance;

            return Invoke<ListAccessControlRulesResponse>(request, options);
        }



        /// <summary>
        /// Lists the access control rules for the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessControlRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessControlRules service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListAccessControlRules">REST API Reference for ListAccessControlRules Operation</seealso>
        public virtual Task<ListAccessControlRulesResponse> ListAccessControlRulesAsync(ListAccessControlRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccessControlRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessControlRulesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAccessControlRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAliases

        internal virtual ListAliasesResponse ListAliases(ListAliasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return Invoke<ListAliasesResponse>(request, options);
        }



        /// <summary>
        /// Creates a paginated call to list the aliases associated with a given entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAliases service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        public virtual Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAliasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGroupMembers

        internal virtual ListGroupMembersResponse ListGroupMembers(ListGroupMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupMembersResponseUnmarshaller.Instance;

            return Invoke<ListGroupMembersResponse>(request, options);
        }



        /// <summary>
        /// Returns an overview of the members of a group. Users and groups can be members of
        /// a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroupMembers service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListGroupMembers">REST API Reference for ListGroupMembers Operation</seealso>
        public virtual Task<ListGroupMembersResponse> ListGroupMembersAsync(ListGroupMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupMembersResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGroups

        internal virtual ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return Invoke<ListGroupsResponse>(request, options);
        }



        /// <summary>
        /// Returns summaries of the organization's groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMailboxExportJobs

        internal virtual ListMailboxExportJobsResponse ListMailboxExportJobs(ListMailboxExportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMailboxExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMailboxExportJobsResponseUnmarshaller.Instance;

            return Invoke<ListMailboxExportJobsResponse>(request, options);
        }



        /// <summary>
        /// Lists the mailbox export jobs started for the specified organization within the last
        /// seven days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMailboxExportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMailboxExportJobs service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListMailboxExportJobs">REST API Reference for ListMailboxExportJobs Operation</seealso>
        public virtual Task<ListMailboxExportJobsResponse> ListMailboxExportJobsAsync(ListMailboxExportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMailboxExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMailboxExportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMailboxExportJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMailboxPermissions

        internal virtual ListMailboxPermissionsResponse ListMailboxPermissions(ListMailboxPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMailboxPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMailboxPermissionsResponseUnmarshaller.Instance;

            return Invoke<ListMailboxPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the mailbox permissions associated with a user, group, or resource mailbox.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMailboxPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMailboxPermissions service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListMailboxPermissions">REST API Reference for ListMailboxPermissions Operation</seealso>
        public virtual Task<ListMailboxPermissionsResponse> ListMailboxPermissionsAsync(ListMailboxPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMailboxPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMailboxPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMailboxPermissionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOrganizations

        internal virtual ListOrganizationsResponse ListOrganizations(ListOrganizationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOrganizationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationsResponseUnmarshaller.Instance;

            return Invoke<ListOrganizationsResponse>(request, options);
        }



        /// <summary>
        /// Returns summaries of the customer's organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOrganizations service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListOrganizations">REST API Reference for ListOrganizations Operation</seealso>
        public virtual Task<ListOrganizationsResponse> ListOrganizationsAsync(ListOrganizationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOrganizationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListOrganizationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResourceDelegates

        internal virtual ListResourceDelegatesResponse ListResourceDelegates(ListResourceDelegatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceDelegatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceDelegatesResponseUnmarshaller.Instance;

            return Invoke<ListResourceDelegatesResponse>(request, options);
        }



        /// <summary>
        /// Lists the delegates associated with a resource. Users and groups can be resource delegates
        /// and answer requests on behalf of the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDelegates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceDelegates service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListResourceDelegates">REST API Reference for ListResourceDelegates Operation</seealso>
        public virtual Task<ListResourceDelegatesResponse> ListResourceDelegatesAsync(ListResourceDelegatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceDelegatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceDelegatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceDelegatesResponse>(request, options, cancellationToken);
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
        /// Returns summaries of the organization's resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResources service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListResources">REST API Reference for ListResources Operation</seealso>
        public virtual Task<ListResourcesResponse> ListResourcesAsync(ListResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourcesResponse>(request, options, cancellationToken);
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
        /// Lists the tags applied to an Amazon WorkMail organization resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListUsers

        internal virtual ListUsersResponse ListUsers(ListUsersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return Invoke<ListUsersResponse>(request, options);
        }



        /// <summary>
        /// Returns summaries of the organization's users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return InvokeAsync<ListUsersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutAccessControlRule

        internal virtual PutAccessControlRuleResponse PutAccessControlRule(PutAccessControlRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAccessControlRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccessControlRuleResponseUnmarshaller.Instance;

            return Invoke<PutAccessControlRuleResponse>(request, options);
        }



        /// <summary>
        /// Adds a new access control rule for the specified organization. The rule allows or
        /// denies access to the organization for the specified IPv4 addresses, access protocol
        /// actions, and user IDs. Adding a new rule with the same name as an existing rule replaces
        /// the older rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccessControlRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccessControlRule service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.LimitExceededException">
        /// The request exceeds the limit of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutAccessControlRule">REST API Reference for PutAccessControlRule Operation</seealso>
        public virtual Task<PutAccessControlRuleResponse> PutAccessControlRuleAsync(PutAccessControlRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAccessControlRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccessControlRuleResponseUnmarshaller.Instance;

            return InvokeAsync<PutAccessControlRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutMailboxPermissions

        internal virtual PutMailboxPermissionsResponse PutMailboxPermissions(PutMailboxPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutMailboxPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMailboxPermissionsResponseUnmarshaller.Instance;

            return Invoke<PutMailboxPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Sets permissions for a user, group, or resource. This replaces any pre-existing permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMailboxPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutMailboxPermissions service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutMailboxPermissions">REST API Reference for PutMailboxPermissions Operation</seealso>
        public virtual Task<PutMailboxPermissionsResponse> PutMailboxPermissionsAsync(PutMailboxPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutMailboxPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMailboxPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<PutMailboxPermissionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutRetentionPolicy

        internal virtual PutRetentionPolicyResponse PutRetentionPolicy(PutRetentionPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRetentionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRetentionPolicyResponseUnmarshaller.Instance;

            return Invoke<PutRetentionPolicyResponse>(request, options);
        }



        /// <summary>
        /// Puts a retention policy to the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRetentionPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRetentionPolicy service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.LimitExceededException">
        /// The request exceeds the limit of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutRetentionPolicy">REST API Reference for PutRetentionPolicy Operation</seealso>
        public virtual Task<PutRetentionPolicyResponse> PutRetentionPolicyAsync(PutRetentionPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRetentionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRetentionPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutRetentionPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterToWorkMail

        internal virtual RegisterToWorkMailResponse RegisterToWorkMail(RegisterToWorkMailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterToWorkMailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterToWorkMailResponseUnmarshaller.Instance;

            return Invoke<RegisterToWorkMailResponse>(request, options);
        }



        /// <summary>
        /// Registers an existing and disabled user, group, or resource for Amazon WorkMail use
        /// by associating a mailbox and calendaring capabilities. It performs no change if the
        /// user, group, or resource is enabled and fails if the user, group, or resource is deleted.
        /// This operation results in the accumulation of costs. For more information, see <a
        /// href="https://aws.amazon.com/workmail/pricing">Pricing</a>. The equivalent console
        /// functionality for this operation is <i>Enable</i>. 
        /// 
        ///  
        /// <para>
        /// Users can either be created by calling the <a>CreateUser</a> API operation or they
        /// can be synchronized from your directory. For more information, see <a>DeregisterFromWorkMail</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterToWorkMail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterToWorkMail service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The directory service doesn't recognize the credentials supplied by WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory is unavailable. It might be located in another Region or deleted.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EmailAddressInUseException">
        /// The email address that you're trying to assign is already created for a different
        /// user, group, or resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityAlreadyRegisteredException">
        /// The user, group, or resource that you're trying to register is already registered.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.MailDomainNotFoundException">
        /// For an email or alias to be created in Amazon WorkMail, the included domain must be
        /// defined in the organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.MailDomainStateException">
        /// After a domain has been added to the organization, it must be verified. The domain
        /// is not yet verified.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/RegisterToWorkMail">REST API Reference for RegisterToWorkMail Operation</seealso>
        public virtual Task<RegisterToWorkMailResponse> RegisterToWorkMailAsync(RegisterToWorkMailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterToWorkMailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterToWorkMailResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterToWorkMailResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetPassword

        internal virtual ResetPasswordResponse ResetPassword(ResetPasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetPasswordResponseUnmarshaller.Instance;

            return Invoke<ResetPasswordResponse>(request, options);
        }



        /// <summary>
        /// Allows the administrator to reset the password for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetPassword service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetPassword service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The directory service doesn't recognize the credentials supplied by WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory is unavailable. It might be located in another Region or deleted.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidPasswordException">
        /// The supplied password doesn't match the minimum security constraints, such as length
        /// or use of special characters.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ResetPassword">REST API Reference for ResetPassword Operation</seealso>
        public virtual Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetPasswordResponseUnmarshaller.Instance;

            return InvokeAsync<ResetPasswordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartMailboxExportJob

        internal virtual StartMailboxExportJobResponse StartMailboxExportJob(StartMailboxExportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMailboxExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMailboxExportJobResponseUnmarshaller.Instance;

            return Invoke<StartMailboxExportJobResponse>(request, options);
        }



        /// <summary>
        /// Starts a mailbox export job to export MIME-format email messages and calendar items
        /// from the specified mailbox to the specified Amazon Simple Storage Service (Amazon
        /// S3) bucket. For more information, see <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/mail-export.html">Exporting
        /// mailbox content</a> in the <i>Amazon WorkMail Administrator Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMailboxExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMailboxExportJob service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.LimitExceededException">
        /// The request exceeds the limit of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/StartMailboxExportJob">REST API Reference for StartMailboxExportJob Operation</seealso>
        public virtual Task<StartMailboxExportJobResponse> StartMailboxExportJobAsync(StartMailboxExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMailboxExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMailboxExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartMailboxExportJobResponse>(request, options, cancellationToken);
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
        /// Applies the specified tags to the specified Amazon WorkMail organization resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.TooManyTagsException">
        /// The resource can have up to 50 user-applied tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Untags the specified tags from the specified Amazon WorkMail organization resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMailboxQuota

        internal virtual UpdateMailboxQuotaResponse UpdateMailboxQuota(UpdateMailboxQuotaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMailboxQuotaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMailboxQuotaResponseUnmarshaller.Instance;

            return Invoke<UpdateMailboxQuotaResponse>(request, options);
        }



        /// <summary>
        /// Updates a user's current mailbox quota for a specified organization and user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMailboxQuota service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMailboxQuota service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateMailboxQuota">REST API Reference for UpdateMailboxQuota Operation</seealso>
        public virtual Task<UpdateMailboxQuotaResponse> UpdateMailboxQuotaAsync(UpdateMailboxQuotaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMailboxQuotaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMailboxQuotaResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMailboxQuotaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePrimaryEmailAddress

        internal virtual UpdatePrimaryEmailAddressResponse UpdatePrimaryEmailAddress(UpdatePrimaryEmailAddressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePrimaryEmailAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePrimaryEmailAddressResponseUnmarshaller.Instance;

            return Invoke<UpdatePrimaryEmailAddressResponse>(request, options);
        }



        /// <summary>
        /// Updates the primary email for a user, group, or resource. The current email is moved
        /// into the list of aliases (or swapped between an existing alias and the current primary
        /// email), and the email provided in the input is promoted as the primary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrimaryEmailAddress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePrimaryEmailAddress service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The directory service doesn't recognize the credentials supplied by WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory is unavailable. It might be located in another Region or deleted.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EmailAddressInUseException">
        /// The email address that you're trying to assign is already created for a different
        /// user, group, or resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.MailDomainNotFoundException">
        /// For an email or alias to be created in Amazon WorkMail, the included domain must be
        /// defined in the organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.MailDomainStateException">
        /// After a domain has been added to the organization, it must be verified. The domain
        /// is not yet verified.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdatePrimaryEmailAddress">REST API Reference for UpdatePrimaryEmailAddress Operation</seealso>
        public virtual Task<UpdatePrimaryEmailAddressResponse> UpdatePrimaryEmailAddressAsync(UpdatePrimaryEmailAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePrimaryEmailAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePrimaryEmailAddressResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePrimaryEmailAddressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateResource

        internal virtual UpdateResourceResponse UpdateResource(UpdateResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceResponse>(request, options);
        }



        /// <summary>
        /// Updates data for the resource. To have the latest information, it must be preceded
        /// by a <a>DescribeResource</a> call. The dataset in the request should be the one expected
        /// when performing another <code>DescribeResource</code> call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory is unavailable. It might be located in another Region or deleted.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EmailAddressInUseException">
        /// The email address that you're trying to assign is already created for a different
        /// user, group, or resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidConfigurationException">
        /// The configuration for a resource isn't valid. A resource must either be able to auto-respond
        /// to requests or have at least one delegate associated that can do so on its behalf.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.MailDomainNotFoundException">
        /// For an email or alias to be created in Amazon WorkMail, the included domain must be
        /// defined in the organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.MailDomainStateException">
        /// After a domain has been added to the organization, it must be verified. The domain
        /// is not yet verified.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.NameAvailabilityException">
        /// The user, group, or resource name isn't unique in Amazon WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        public virtual Task<UpdateResourceResponse> UpdateResourceAsync(UpdateResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}