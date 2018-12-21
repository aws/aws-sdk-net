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
    /// and calendars using Microsoft Outlook, your browser, or their native iOS and Android
    /// email applications. You can integrate Amazon WorkMail with your existing corporate
    /// directory and control both the keys that encrypt your data and the location in which
    /// your data is stored.
    /// 
    ///  
    /// <para>
    /// The Amazon WorkMail API is designed for the following scenarios:
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
    /// All Amazon WorkMail API actions are Amazon-authenticated and certificate-signed. They
    /// not only require the use of the AWS SDK, but also allow for the exclusive use of IAM
    /// users and roles to help facilitate access, trust, and permission policies. By creating
    /// a role and allowing an IAM user to access the Amazon WorkMail site, the IAM user gains
    /// full administrative visibility into the entire Amazon WorkMail organization (or as
    /// set in the IAM policy). This includes, but is not limited to, the ability to create,
    /// update, and delete users, groups, and resources. This allows developers to perform
    /// the scenarios listed above, as well as give users the ability to grant access on a
    /// selective basis using the IAM model.
    /// </para>
    /// </summary>
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


        /// <summary>
        /// Adds a member to the resource's set of delegates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDelegateToResource service method.</param>
        /// 
        /// <returns>The response from the AssociateDelegateToResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/AssociateDelegateToResource">REST API Reference for AssociateDelegateToResource Operation</seealso>
        public virtual AssociateDelegateToResourceResponse AssociateDelegateToResource(AssociateDelegateToResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDelegateToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDelegateToResourceResponseUnmarshaller.Instance;

            return Invoke<AssociateDelegateToResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDelegateToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDelegateToResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Adds a member to the group's set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToGroup service method.</param>
        /// 
        /// <returns>The response from the AssociateMemberToGroup service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The Directory Service doesn't recognize the credentials supplied by the Amazon WorkMail
        /// service.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory that you are trying to perform operations on isn't available.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/AssociateMemberToGroup">REST API Reference for AssociateMemberToGroup Operation</seealso>
        public virtual AssociateMemberToGroupResponse AssociateMemberToGroup(AssociateMemberToGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateMemberToGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMemberToGroupResponseUnmarshaller.Instance;

            return Invoke<AssociateMemberToGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateMemberToGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/AssociateMemberToGroup">REST API Reference for AssociateMemberToGroup Operation</seealso>
        public virtual Task<AssociateMemberToGroupResponse> AssociateMemberToGroupAsync(AssociateMemberToGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateMemberToGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMemberToGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateMemberToGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAlias


        /// <summary>
        /// Adds an alias to the set of a given member of Amazon WorkMail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EmailAddressInUseException">
        /// The email address that you're trying to assign is already created for a different
        /// user, group, or resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
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
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Creates a group that can be used in Amazon WorkMail by calling the RegisterToWorkMail
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The Directory Service doesn't recognize the credentials supplied by the Amazon WorkMail
        /// service.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory that you are trying to perform operations on isn't available.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.NameAvailabilityException">
        /// The entity (user, group, or user) name isn't unique in Amazon WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ReservedNameException">
        /// This entity name is not allowed in Amazon WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateResource


        /// <summary>
        /// Creates a new Amazon WorkMail resource. The available types are equipment and room.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResource service method.</param>
        /// 
        /// <returns>The response from the CreateResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The Directory Service doesn't recognize the credentials supplied by the Amazon WorkMail
        /// service.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory that you are trying to perform operations on isn't available.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.NameAvailabilityException">
        /// The entity (user, group, or user) name isn't unique in Amazon WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ReservedNameException">
        /// This entity name is not allowed in Amazon WorkMail.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateResource">REST API Reference for CreateResource Operation</seealso>
        public virtual CreateResourceResponse CreateResource(CreateResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceResponseUnmarshaller.Instance;

            return Invoke<CreateResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Creates a user who can be used in Amazon WorkMail by calling the RegisterToWorkMail
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The Directory Service doesn't recognize the credentials supplied by the Amazon WorkMail
        /// service.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory that you are trying to perform operations on isn't available.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidPasswordException">
        /// The supplied password doesn't match the minimum security constraints, such as length
        /// or use of special characters.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.NameAvailabilityException">
        /// The entity (user, group, or user) name isn't unique in Amazon WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ReservedNameException">
        /// This entity name is not allowed in Amazon WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual CreateUserResponse CreateUser(CreateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return Invoke<CreateUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAlias


        /// <summary>
        /// Remove the alias from a set of aliases for a given user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual DeleteAliasResponse DeleteAlias(DeleteAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Deletes a group from Amazon WorkMail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The Directory Service doesn't recognize the credentials supplied by the Amazon WorkMail
        /// service.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory that you are trying to perform operations on isn't available.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Deletes permissions granted to a user or group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMailboxPermissions service method.</param>
        /// 
        /// <returns>The response from the DeleteMailboxPermissions service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteMailboxPermissions">REST API Reference for DeleteMailboxPermissions Operation</seealso>
        public virtual DeleteMailboxPermissionsResponse DeleteMailboxPermissions(DeleteMailboxPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMailboxPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMailboxPermissionsResponseUnmarshaller.Instance;

            return Invoke<DeleteMailboxPermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMailboxPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMailboxPermissions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteMailboxPermissions">REST API Reference for DeleteMailboxPermissions Operation</seealso>
        public virtual Task<DeleteMailboxPermissionsResponse> DeleteMailboxPermissionsAsync(DeleteMailboxPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMailboxPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMailboxPermissionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteMailboxPermissionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResource


        /// <summary>
        /// Deletes the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResource service method.</param>
        /// 
        /// <returns>The response from the DeleteResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteResource">REST API Reference for DeleteResource Operation</seealso>
        public virtual DeleteResourceResponse DeleteResource(DeleteResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceResponseUnmarshaller.Instance;

            return Invoke<DeleteResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteResource">REST API Reference for DeleteResource Operation</seealso>
        public virtual Task<DeleteResourceResponse> DeleteResourceAsync(DeleteResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteUser


        /// <summary>
        /// Deletes a user from Amazon WorkMail and all subsequent systems. The action can't be
        /// undone. The mailbox is kept as-is for a minimum of 30 days, without any means to restore
        /// it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The Directory Service doesn't recognize the credentials supplied by the Amazon WorkMail
        /// service.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory that you are trying to perform operations on isn't available.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Mark a user, group, or resource as no longer used in Amazon WorkMail. This action
        /// disassociates the mailbox and schedules it for clean-up. Amazon WorkMail keeps mailboxes
        /// for 30 days before they are permanently removed. The functionality in the console
        /// is <i>Disable</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterFromWorkMail service method.</param>
        /// 
        /// <returns>The response from the DeregisterFromWorkMail service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeregisterFromWorkMail">REST API Reference for DeregisterFromWorkMail Operation</seealso>
        public virtual DeregisterFromWorkMailResponse DeregisterFromWorkMail(DeregisterFromWorkMailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterFromWorkMailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterFromWorkMailResponseUnmarshaller.Instance;

            return Invoke<DeregisterFromWorkMailResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterFromWorkMail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterFromWorkMail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Returns the data available for the group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeGroup service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        public virtual DescribeGroupResponse DescribeGroup(DescribeGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        public virtual Task<DescribeGroupResponse> DescribeGroupAsync(DescribeGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeOrganization


        /// <summary>
        /// Provides more information regarding a given organization based on its identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganization service method.</param>
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
        public virtual DescribeOrganizationResponse DescribeOrganization(DescribeOrganizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationResponseUnmarshaller.Instance;

            return Invoke<DescribeOrganizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Returns the data available for the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResource service method.</param>
        /// 
        /// <returns>The response from the DescribeResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeResource">REST API Reference for DescribeResource Operation</seealso>
        public virtual DescribeResourceResponse DescribeResource(DescribeResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourceResponseUnmarshaller.Instance;

            return Invoke<DescribeResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Provides information regarding the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        public virtual DescribeUserResponse DescribeUser(DescribeUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserResponseUnmarshaller.Instance;

            return Invoke<DescribeUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Removes a member from the resource's set of delegates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDelegateFromResource service method.</param>
        /// 
        /// <returns>The response from the DisassociateDelegateFromResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DisassociateDelegateFromResource">REST API Reference for DisassociateDelegateFromResource Operation</seealso>
        public virtual DisassociateDelegateFromResourceResponse DisassociateDelegateFromResource(DisassociateDelegateFromResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateDelegateFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDelegateFromResourceResponseUnmarshaller.Instance;

            return Invoke<DisassociateDelegateFromResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateDelegateFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDelegateFromResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Removes a member from a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromGroup service method.</param>
        /// 
        /// <returns>The response from the DisassociateMemberFromGroup service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The Directory Service doesn't recognize the credentials supplied by the Amazon WorkMail
        /// service.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory that you are trying to perform operations on isn't available.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DisassociateMemberFromGroup">REST API Reference for DisassociateMemberFromGroup Operation</seealso>
        public virtual DisassociateMemberFromGroupResponse DisassociateMemberFromGroup(DisassociateMemberFromGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateMemberFromGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMemberFromGroupResponseUnmarshaller.Instance;

            return Invoke<DisassociateMemberFromGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateMemberFromGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DisassociateMemberFromGroup">REST API Reference for DisassociateMemberFromGroup Operation</seealso>
        public virtual Task<DisassociateMemberFromGroupResponse> DisassociateMemberFromGroupAsync(DisassociateMemberFromGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateMemberFromGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMemberFromGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateMemberFromGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAliases


        /// <summary>
        /// Creates a paginated call to list the aliases associated with a given entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAliases service method.</param>
        /// 
        /// <returns>The response from the ListAliases service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        public virtual ListAliasesResponse ListAliases(ListAliasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return Invoke<ListAliasesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAliases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Returns an overview of the members of a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMembers service method.</param>
        /// 
        /// <returns>The response from the ListGroupMembers service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListGroupMembers">REST API Reference for ListGroupMembers Operation</seealso>
        public virtual ListGroupMembersResponse ListGroupMembers(ListGroupMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupMembersResponseUnmarshaller.Instance;

            return Invoke<ListGroupMembersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Returns summaries of the organization's groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return Invoke<ListGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMailboxPermissions


        /// <summary>
        /// Lists the mailbox permissions associated with a mailbox.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMailboxPermissions service method.</param>
        /// 
        /// <returns>The response from the ListMailboxPermissions service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListMailboxPermissions">REST API Reference for ListMailboxPermissions Operation</seealso>
        public virtual ListMailboxPermissionsResponse ListMailboxPermissions(ListMailboxPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMailboxPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMailboxPermissionsResponseUnmarshaller.Instance;

            return Invoke<ListMailboxPermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMailboxPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMailboxPermissions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Returns summaries of the customer's non-deleted organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizations service method.</param>
        /// 
        /// <returns>The response from the ListOrganizations service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListOrganizations">REST API Reference for ListOrganizations Operation</seealso>
        public virtual ListOrganizationsResponse ListOrganizations(ListOrganizationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOrganizationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationsResponseUnmarshaller.Instance;

            return Invoke<ListOrganizationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOrganizations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Lists the delegates associated with a resource. Users and groups can be resource delegates
        /// and answer requests on behalf of the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDelegates service method.</param>
        /// 
        /// <returns>The response from the ListResourceDelegates service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListResourceDelegates">REST API Reference for ListResourceDelegates Operation</seealso>
        public virtual ListResourceDelegatesResponse ListResourceDelegates(ListResourceDelegatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceDelegatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceDelegatesResponseUnmarshaller.Instance;

            return Invoke<ListResourceDelegatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceDelegates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDelegates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Returns summaries of the organization's resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResources service method.</param>
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
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListResources">REST API Reference for ListResources Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListResources">REST API Reference for ListResources Operation</seealso>
        public virtual Task<ListResourcesResponse> ListResourcesAsync(ListResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListUsers


        /// <summary>
        /// Returns summaries of the organization's users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
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
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual ListUsersResponse ListUsers(ListUsersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return Invoke<ListUsersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListUsersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutMailboxPermissions


        /// <summary>
        /// Sets permissions for a user or group. This replaces any pre-existing permissions set
        /// for the entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMailboxPermissions service method.</param>
        /// 
        /// <returns>The response from the PutMailboxPermissions service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutMailboxPermissions">REST API Reference for PutMailboxPermissions Operation</seealso>
        public virtual PutMailboxPermissionsResponse PutMailboxPermissions(PutMailboxPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutMailboxPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMailboxPermissionsResponseUnmarshaller.Instance;

            return Invoke<PutMailboxPermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutMailboxPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMailboxPermissions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutMailboxPermissions">REST API Reference for PutMailboxPermissions Operation</seealso>
        public virtual Task<PutMailboxPermissionsResponse> PutMailboxPermissionsAsync(PutMailboxPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutMailboxPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMailboxPermissionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutMailboxPermissionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterToWorkMail


        /// <summary>
        /// Registers an existing and disabled user, group, or resource/entity for Amazon WorkMail
        /// use by associating a mailbox and calendaring capabilities. It performs no change if
        /// the entity is enabled and fails if the entity is deleted. This operation results in
        /// the accumulation of costs. For more information, see <a href="http://aws.amazon.com/workmail/pricing">Pricing</a>.
        /// The equivalent console functionality for this operation is <i>Enable</i>. Users can
        /// either be created by calling the CreateUser API or they can be synchronized from your
        /// directory. For more information, see DeregisterFromWorkMail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterToWorkMail service method.</param>
        /// 
        /// <returns>The response from the RegisterToWorkMail service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The Directory Service doesn't recognize the credentials supplied by the Amazon WorkMail
        /// service.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory that you are trying to perform operations on isn't available.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EmailAddressInUseException">
        /// The email address that you're trying to assign is already created for a different
        /// user, group, or resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityAlreadyRegisteredException">
        /// The user, group, or resource that you're trying to register is already registered.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
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
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/RegisterToWorkMail">REST API Reference for RegisterToWorkMail Operation</seealso>
        public virtual RegisterToWorkMailResponse RegisterToWorkMail(RegisterToWorkMailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterToWorkMailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterToWorkMailResponseUnmarshaller.Instance;

            return Invoke<RegisterToWorkMailResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterToWorkMail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterToWorkMail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Allows the administrator to reset the password for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetPassword service method.</param>
        /// 
        /// <returns>The response from the ResetPassword service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The Directory Service doesn't recognize the credentials supplied by the Amazon WorkMail
        /// service.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory that you are trying to perform operations on isn't available.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
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
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ResetPassword">REST API Reference for ResetPassword Operation</seealso>
        public virtual ResetPasswordResponse ResetPassword(ResetPasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetPasswordResponseUnmarshaller.Instance;

            return Invoke<ResetPasswordResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetPassword operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ResetPassword">REST API Reference for ResetPassword Operation</seealso>
        public virtual Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetPasswordResponseUnmarshaller.Instance;
            
            return InvokeAsync<ResetPasswordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePrimaryEmailAddress


        /// <summary>
        /// Updates the primary email for an entity. The current email is moved into the list
        /// of aliases (or swapped between an existing alias and the current primary email) and
        /// the email provided in the input is promoted as the primary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrimaryEmailAddress service method.</param>
        /// 
        /// <returns>The response from the UpdatePrimaryEmailAddress service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The Directory Service doesn't recognize the credentials supplied by the Amazon WorkMail
        /// service.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory that you are trying to perform operations on isn't available.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EmailAddressInUseException">
        /// The email address that you're trying to assign is already created for a different
        /// user, group, or resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
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
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdatePrimaryEmailAddress">REST API Reference for UpdatePrimaryEmailAddress Operation</seealso>
        public virtual UpdatePrimaryEmailAddressResponse UpdatePrimaryEmailAddress(UpdatePrimaryEmailAddressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePrimaryEmailAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePrimaryEmailAddressResponseUnmarshaller.Instance;

            return Invoke<UpdatePrimaryEmailAddressResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePrimaryEmailAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrimaryEmailAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Updates data for the resource. It must be preceded by a describe call in order to
        /// have the latest information. The dataset in the request should be the one expected
        /// when performing another describe call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource service method.</param>
        /// 
        /// <returns>The response from the UpdateResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory that you are trying to perform operations on isn't available.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EmailAddressInUseException">
        /// The email address that you're trying to assign is already created for a different
        /// user, group, or resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidConfigurationException">
        /// The configuration for a resource isn't valid. A resource must either be able to auto-respond
        /// to requests or have at least one delegate associated that can do it on its behalf.
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
        /// The entity (user, group, or user) name isn't unique in Amazon WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        public virtual UpdateResourceResponse UpdateResource(UpdateResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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