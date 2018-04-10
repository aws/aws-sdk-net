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
using System.Collections.Generic;

using Amazon.WorkMail.Model;
using Amazon.WorkMail.Model.Internal.MarshallTransformations;
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
            var marshaller = AssociateDelegateToResourceRequestMarshaller.Instance;
            var unmarshaller = AssociateDelegateToResourceResponseUnmarshaller.Instance;

            return Invoke<AssociateDelegateToResourceRequest,AssociateDelegateToResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDelegateToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDelegateToResource operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateDelegateToResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/AssociateDelegateToResource">REST API Reference for AssociateDelegateToResource Operation</seealso>
        public virtual IAsyncResult BeginAssociateDelegateToResource(AssociateDelegateToResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = AssociateDelegateToResourceRequestMarshaller.Instance;
            var unmarshaller = AssociateDelegateToResourceResponseUnmarshaller.Instance;

            return BeginInvoke<AssociateDelegateToResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateDelegateToResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateDelegateToResource.</param>
        /// 
        /// <returns>Returns a  AssociateDelegateToResourceResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/AssociateDelegateToResource">REST API Reference for AssociateDelegateToResource Operation</seealso>
        public virtual AssociateDelegateToResourceResponse EndAssociateDelegateToResource(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateDelegateToResourceResponse>(asyncResult);
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
            var marshaller = AssociateMemberToGroupRequestMarshaller.Instance;
            var unmarshaller = AssociateMemberToGroupResponseUnmarshaller.Instance;

            return Invoke<AssociateMemberToGroupRequest,AssociateMemberToGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateMemberToGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToGroup operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateMemberToGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/AssociateMemberToGroup">REST API Reference for AssociateMemberToGroup Operation</seealso>
        public virtual IAsyncResult BeginAssociateMemberToGroup(AssociateMemberToGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = AssociateMemberToGroupRequestMarshaller.Instance;
            var unmarshaller = AssociateMemberToGroupResponseUnmarshaller.Instance;

            return BeginInvoke<AssociateMemberToGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateMemberToGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateMemberToGroup.</param>
        /// 
        /// <returns>Returns a  AssociateMemberToGroupResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/AssociateMemberToGroup">REST API Reference for AssociateMemberToGroup Operation</seealso>
        public virtual AssociateMemberToGroupResponse EndAssociateMemberToGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateMemberToGroupResponse>(asyncResult);
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
            var marshaller = CreateAliasRequestMarshaller.Instance;
            var unmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAliasRequest,CreateAliasResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual IAsyncResult BeginCreateAlias(CreateAliasRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateAliasRequestMarshaller.Instance;
            var unmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return BeginInvoke<CreateAliasRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAlias.</param>
        /// 
        /// <returns>Returns a  CreateAliasResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual CreateAliasResponse EndCreateAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAliasResponse>(asyncResult);
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
            var marshaller = CreateGroupRequestMarshaller.Instance;
            var unmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGroupRequest,CreateGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateGroup(CreateGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateGroupRequestMarshaller.Instance;
            var unmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return BeginInvoke<CreateGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroup.</param>
        /// 
        /// <returns>Returns a  CreateGroupResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual CreateGroupResponse EndCreateGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGroupResponse>(asyncResult);
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
            var marshaller = CreateResourceRequestMarshaller.Instance;
            var unmarshaller = CreateResourceResponseUnmarshaller.Instance;

            return Invoke<CreateResourceRequest,CreateResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResource operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateResource">REST API Reference for CreateResource Operation</seealso>
        public virtual IAsyncResult BeginCreateResource(CreateResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateResourceRequestMarshaller.Instance;
            var unmarshaller = CreateResourceResponseUnmarshaller.Instance;

            return BeginInvoke<CreateResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResource.</param>
        /// 
        /// <returns>Returns a  CreateResourceResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateResource">REST API Reference for CreateResource Operation</seealso>
        public virtual CreateResourceResponse EndCreateResource(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateResourceResponse>(asyncResult);
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
            var marshaller = CreateUserRequestMarshaller.Instance;
            var unmarshaller = CreateUserResponseUnmarshaller.Instance;

            return Invoke<CreateUserRequest,CreateUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual IAsyncResult BeginCreateUser(CreateUserRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateUserRequestMarshaller.Instance;
            var unmarshaller = CreateUserResponseUnmarshaller.Instance;

            return BeginInvoke<CreateUserRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUser.</param>
        /// 
        /// <returns>Returns a  CreateUserResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual CreateUserResponse EndCreateUser(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUserResponse>(asyncResult);
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
            var marshaller = DeleteAliasRequestMarshaller.Instance;
            var unmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteAliasRequest,DeleteAliasResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual IAsyncResult BeginDeleteAlias(DeleteAliasRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteAliasRequestMarshaller.Instance;
            var unmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteAliasRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAlias.</param>
        /// 
        /// <returns>Returns a  DeleteAliasResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual DeleteAliasResponse EndDeleteAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAliasResponse>(asyncResult);
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
            var marshaller = DeleteGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupRequest,DeleteGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteGroup(DeleteGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroup.</param>
        /// 
        /// <returns>Returns a  DeleteGroupResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual DeleteGroupResponse EndDeleteGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGroupResponse>(asyncResult);
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
            var marshaller = DeleteMailboxPermissionsRequestMarshaller.Instance;
            var unmarshaller = DeleteMailboxPermissionsResponseUnmarshaller.Instance;

            return Invoke<DeleteMailboxPermissionsRequest,DeleteMailboxPermissionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMailboxPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMailboxPermissions operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMailboxPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteMailboxPermissions">REST API Reference for DeleteMailboxPermissions Operation</seealso>
        public virtual IAsyncResult BeginDeleteMailboxPermissions(DeleteMailboxPermissionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteMailboxPermissionsRequestMarshaller.Instance;
            var unmarshaller = DeleteMailboxPermissionsResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteMailboxPermissionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMailboxPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMailboxPermissions.</param>
        /// 
        /// <returns>Returns a  DeleteMailboxPermissionsResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteMailboxPermissions">REST API Reference for DeleteMailboxPermissions Operation</seealso>
        public virtual DeleteMailboxPermissionsResponse EndDeleteMailboxPermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMailboxPermissionsResponse>(asyncResult);
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
            var marshaller = DeleteResourceRequestMarshaller.Instance;
            var unmarshaller = DeleteResourceResponseUnmarshaller.Instance;

            return Invoke<DeleteResourceRequest,DeleteResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResource operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteResource">REST API Reference for DeleteResource Operation</seealso>
        public virtual IAsyncResult BeginDeleteResource(DeleteResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteResourceRequestMarshaller.Instance;
            var unmarshaller = DeleteResourceResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResource.</param>
        /// 
        /// <returns>Returns a  DeleteResourceResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteResource">REST API Reference for DeleteResource Operation</seealso>
        public virtual DeleteResourceResponse EndDeleteResource(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteResourceResponse>(asyncResult);
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
            var marshaller = DeleteUserRequestMarshaller.Instance;
            var unmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserRequest,DeleteUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual IAsyncResult BeginDeleteUser(DeleteUserRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteUserRequestMarshaller.Instance;
            var unmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteUserRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUser.</param>
        /// 
        /// <returns>Returns a  DeleteUserResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserResponse>(asyncResult);
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
            var marshaller = DeregisterFromWorkMailRequestMarshaller.Instance;
            var unmarshaller = DeregisterFromWorkMailResponseUnmarshaller.Instance;

            return Invoke<DeregisterFromWorkMailRequest,DeregisterFromWorkMailResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterFromWorkMail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterFromWorkMail operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterFromWorkMail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeregisterFromWorkMail">REST API Reference for DeregisterFromWorkMail Operation</seealso>
        public virtual IAsyncResult BeginDeregisterFromWorkMail(DeregisterFromWorkMailRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeregisterFromWorkMailRequestMarshaller.Instance;
            var unmarshaller = DeregisterFromWorkMailResponseUnmarshaller.Instance;

            return BeginInvoke<DeregisterFromWorkMailRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterFromWorkMail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterFromWorkMail.</param>
        /// 
        /// <returns>Returns a  DeregisterFromWorkMailResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeregisterFromWorkMail">REST API Reference for DeregisterFromWorkMail Operation</seealso>
        public virtual DeregisterFromWorkMailResponse EndDeregisterFromWorkMail(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterFromWorkMailResponse>(asyncResult);
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
            var marshaller = DescribeGroupRequestMarshaller.Instance;
            var unmarshaller = DescribeGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeGroupRequest,DescribeGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        public virtual IAsyncResult BeginDescribeGroup(DescribeGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeGroupRequestMarshaller.Instance;
            var unmarshaller = DescribeGroupResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGroup.</param>
        /// 
        /// <returns>Returns a  DescribeGroupResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        public virtual DescribeGroupResponse EndDescribeGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeGroupResponse>(asyncResult);
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
            var marshaller = DescribeOrganizationRequestMarshaller.Instance;
            var unmarshaller = DescribeOrganizationResponseUnmarshaller.Instance;

            return Invoke<DescribeOrganizationRequest,DescribeOrganizationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganization operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeOrganization">REST API Reference for DescribeOrganization Operation</seealso>
        public virtual IAsyncResult BeginDescribeOrganization(DescribeOrganizationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeOrganizationRequestMarshaller.Instance;
            var unmarshaller = DescribeOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeOrganizationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOrganization.</param>
        /// 
        /// <returns>Returns a  DescribeOrganizationResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeOrganization">REST API Reference for DescribeOrganization Operation</seealso>
        public virtual DescribeOrganizationResponse EndDescribeOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeOrganizationResponse>(asyncResult);
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
            var marshaller = DescribeResourceRequestMarshaller.Instance;
            var unmarshaller = DescribeResourceResponseUnmarshaller.Instance;

            return Invoke<DescribeResourceRequest,DescribeResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResource operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeResource">REST API Reference for DescribeResource Operation</seealso>
        public virtual IAsyncResult BeginDescribeResource(DescribeResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeResourceRequestMarshaller.Instance;
            var unmarshaller = DescribeResourceResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeResource.</param>
        /// 
        /// <returns>Returns a  DescribeResourceResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeResource">REST API Reference for DescribeResource Operation</seealso>
        public virtual DescribeResourceResponse EndDescribeResource(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeResourceResponse>(asyncResult);
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
            var marshaller = DescribeUserRequestMarshaller.Instance;
            var unmarshaller = DescribeUserResponseUnmarshaller.Instance;

            return Invoke<DescribeUserRequest,DescribeUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        public virtual IAsyncResult BeginDescribeUser(DescribeUserRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeUserRequestMarshaller.Instance;
            var unmarshaller = DescribeUserResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeUserRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUser.</param>
        /// 
        /// <returns>Returns a  DescribeUserResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        public virtual DescribeUserResponse EndDescribeUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeUserResponse>(asyncResult);
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
            var marshaller = DisassociateDelegateFromResourceRequestMarshaller.Instance;
            var unmarshaller = DisassociateDelegateFromResourceResponseUnmarshaller.Instance;

            return Invoke<DisassociateDelegateFromResourceRequest,DisassociateDelegateFromResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateDelegateFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDelegateFromResource operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateDelegateFromResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DisassociateDelegateFromResource">REST API Reference for DisassociateDelegateFromResource Operation</seealso>
        public virtual IAsyncResult BeginDisassociateDelegateFromResource(DisassociateDelegateFromResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DisassociateDelegateFromResourceRequestMarshaller.Instance;
            var unmarshaller = DisassociateDelegateFromResourceResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateDelegateFromResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateDelegateFromResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateDelegateFromResource.</param>
        /// 
        /// <returns>Returns a  DisassociateDelegateFromResourceResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DisassociateDelegateFromResource">REST API Reference for DisassociateDelegateFromResource Operation</seealso>
        public virtual DisassociateDelegateFromResourceResponse EndDisassociateDelegateFromResource(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateDelegateFromResourceResponse>(asyncResult);
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
            var marshaller = DisassociateMemberFromGroupRequestMarshaller.Instance;
            var unmarshaller = DisassociateMemberFromGroupResponseUnmarshaller.Instance;

            return Invoke<DisassociateMemberFromGroupRequest,DisassociateMemberFromGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateMemberFromGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromGroup operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateMemberFromGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DisassociateMemberFromGroup">REST API Reference for DisassociateMemberFromGroup Operation</seealso>
        public virtual IAsyncResult BeginDisassociateMemberFromGroup(DisassociateMemberFromGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DisassociateMemberFromGroupRequestMarshaller.Instance;
            var unmarshaller = DisassociateMemberFromGroupResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateMemberFromGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateMemberFromGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateMemberFromGroup.</param>
        /// 
        /// <returns>Returns a  DisassociateMemberFromGroupResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DisassociateMemberFromGroup">REST API Reference for DisassociateMemberFromGroup Operation</seealso>
        public virtual DisassociateMemberFromGroupResponse EndDisassociateMemberFromGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateMemberFromGroupResponse>(asyncResult);
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
            var marshaller = ListAliasesRequestMarshaller.Instance;
            var unmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return Invoke<ListAliasesRequest,ListAliasesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAliases operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAliases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        public virtual IAsyncResult BeginListAliases(ListAliasesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListAliasesRequestMarshaller.Instance;
            var unmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return BeginInvoke<ListAliasesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAliases.</param>
        /// 
        /// <returns>Returns a  ListAliasesResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        public virtual ListAliasesResponse EndListAliases(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAliasesResponse>(asyncResult);
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
            var marshaller = ListGroupMembersRequestMarshaller.Instance;
            var unmarshaller = ListGroupMembersResponseUnmarshaller.Instance;

            return Invoke<ListGroupMembersRequest,ListGroupMembersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMembers operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListGroupMembers">REST API Reference for ListGroupMembers Operation</seealso>
        public virtual IAsyncResult BeginListGroupMembers(ListGroupMembersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListGroupMembersRequestMarshaller.Instance;
            var unmarshaller = ListGroupMembersResponseUnmarshaller.Instance;

            return BeginInvoke<ListGroupMembersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupMembers.</param>
        /// 
        /// <returns>Returns a  ListGroupMembersResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListGroupMembers">REST API Reference for ListGroupMembers Operation</seealso>
        public virtual ListGroupMembersResponse EndListGroupMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroupMembersResponse>(asyncResult);
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
            var marshaller = ListGroupsRequestMarshaller.Instance;
            var unmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return Invoke<ListGroupsRequest,ListGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual IAsyncResult BeginListGroups(ListGroupsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListGroupsRequestMarshaller.Instance;
            var unmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return BeginInvoke<ListGroupsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroups.</param>
        /// 
        /// <returns>Returns a  ListGroupsResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual ListGroupsResponse EndListGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroupsResponse>(asyncResult);
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
            var marshaller = ListMailboxPermissionsRequestMarshaller.Instance;
            var unmarshaller = ListMailboxPermissionsResponseUnmarshaller.Instance;

            return Invoke<ListMailboxPermissionsRequest,ListMailboxPermissionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMailboxPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMailboxPermissions operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMailboxPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListMailboxPermissions">REST API Reference for ListMailboxPermissions Operation</seealso>
        public virtual IAsyncResult BeginListMailboxPermissions(ListMailboxPermissionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListMailboxPermissionsRequestMarshaller.Instance;
            var unmarshaller = ListMailboxPermissionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListMailboxPermissionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMailboxPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMailboxPermissions.</param>
        /// 
        /// <returns>Returns a  ListMailboxPermissionsResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListMailboxPermissions">REST API Reference for ListMailboxPermissions Operation</seealso>
        public virtual ListMailboxPermissionsResponse EndListMailboxPermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMailboxPermissionsResponse>(asyncResult);
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
            var marshaller = ListOrganizationsRequestMarshaller.Instance;
            var unmarshaller = ListOrganizationsResponseUnmarshaller.Instance;

            return Invoke<ListOrganizationsRequest,ListOrganizationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOrganizations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizations operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOrganizations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListOrganizations">REST API Reference for ListOrganizations Operation</seealso>
        public virtual IAsyncResult BeginListOrganizations(ListOrganizationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListOrganizationsRequestMarshaller.Instance;
            var unmarshaller = ListOrganizationsResponseUnmarshaller.Instance;

            return BeginInvoke<ListOrganizationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOrganizations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOrganizations.</param>
        /// 
        /// <returns>Returns a  ListOrganizationsResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListOrganizations">REST API Reference for ListOrganizations Operation</seealso>
        public virtual ListOrganizationsResponse EndListOrganizations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOrganizationsResponse>(asyncResult);
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
            var marshaller = ListResourceDelegatesRequestMarshaller.Instance;
            var unmarshaller = ListResourceDelegatesResponseUnmarshaller.Instance;

            return Invoke<ListResourceDelegatesRequest,ListResourceDelegatesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceDelegates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDelegates operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceDelegates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListResourceDelegates">REST API Reference for ListResourceDelegates Operation</seealso>
        public virtual IAsyncResult BeginListResourceDelegates(ListResourceDelegatesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListResourceDelegatesRequestMarshaller.Instance;
            var unmarshaller = ListResourceDelegatesResponseUnmarshaller.Instance;

            return BeginInvoke<ListResourceDelegatesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceDelegates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceDelegates.</param>
        /// 
        /// <returns>Returns a  ListResourceDelegatesResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListResourceDelegates">REST API Reference for ListResourceDelegates Operation</seealso>
        public virtual ListResourceDelegatesResponse EndListResourceDelegates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResourceDelegatesResponse>(asyncResult);
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
            var marshaller = ListResourcesRequestMarshaller.Instance;
            var unmarshaller = ListResourcesResponseUnmarshaller.Instance;

            return Invoke<ListResourcesRequest,ListResourcesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResources operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListResources">REST API Reference for ListResources Operation</seealso>
        public virtual IAsyncResult BeginListResources(ListResourcesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListResourcesRequestMarshaller.Instance;
            var unmarshaller = ListResourcesResponseUnmarshaller.Instance;

            return BeginInvoke<ListResourcesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResources.</param>
        /// 
        /// <returns>Returns a  ListResourcesResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListResources">REST API Reference for ListResources Operation</seealso>
        public virtual ListResourcesResponse EndListResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResourcesResponse>(asyncResult);
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
            var marshaller = ListUsersRequestMarshaller.Instance;
            var unmarshaller = ListUsersResponseUnmarshaller.Instance;

            return Invoke<ListUsersRequest,ListUsersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual IAsyncResult BeginListUsers(ListUsersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListUsersRequestMarshaller.Instance;
            var unmarshaller = ListUsersResponseUnmarshaller.Instance;

            return BeginInvoke<ListUsersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUsers.</param>
        /// 
        /// <returns>Returns a  ListUsersResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual ListUsersResponse EndListUsers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUsersResponse>(asyncResult);
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
            var marshaller = PutMailboxPermissionsRequestMarshaller.Instance;
            var unmarshaller = PutMailboxPermissionsResponseUnmarshaller.Instance;

            return Invoke<PutMailboxPermissionsRequest,PutMailboxPermissionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutMailboxPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMailboxPermissions operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutMailboxPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutMailboxPermissions">REST API Reference for PutMailboxPermissions Operation</seealso>
        public virtual IAsyncResult BeginPutMailboxPermissions(PutMailboxPermissionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = PutMailboxPermissionsRequestMarshaller.Instance;
            var unmarshaller = PutMailboxPermissionsResponseUnmarshaller.Instance;

            return BeginInvoke<PutMailboxPermissionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutMailboxPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMailboxPermissions.</param>
        /// 
        /// <returns>Returns a  PutMailboxPermissionsResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutMailboxPermissions">REST API Reference for PutMailboxPermissions Operation</seealso>
        public virtual PutMailboxPermissionsResponse EndPutMailboxPermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<PutMailboxPermissionsResponse>(asyncResult);
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
            var marshaller = RegisterToWorkMailRequestMarshaller.Instance;
            var unmarshaller = RegisterToWorkMailResponseUnmarshaller.Instance;

            return Invoke<RegisterToWorkMailRequest,RegisterToWorkMailResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterToWorkMail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterToWorkMail operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterToWorkMail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/RegisterToWorkMail">REST API Reference for RegisterToWorkMail Operation</seealso>
        public virtual IAsyncResult BeginRegisterToWorkMail(RegisterToWorkMailRequest request, AsyncCallback callback, object state)
        {
            var marshaller = RegisterToWorkMailRequestMarshaller.Instance;
            var unmarshaller = RegisterToWorkMailResponseUnmarshaller.Instance;

            return BeginInvoke<RegisterToWorkMailRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterToWorkMail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterToWorkMail.</param>
        /// 
        /// <returns>Returns a  RegisterToWorkMailResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/RegisterToWorkMail">REST API Reference for RegisterToWorkMail Operation</seealso>
        public virtual RegisterToWorkMailResponse EndRegisterToWorkMail(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterToWorkMailResponse>(asyncResult);
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
            var marshaller = ResetPasswordRequestMarshaller.Instance;
            var unmarshaller = ResetPasswordResponseUnmarshaller.Instance;

            return Invoke<ResetPasswordRequest,ResetPasswordResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetPassword operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetPassword
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ResetPassword">REST API Reference for ResetPassword Operation</seealso>
        public virtual IAsyncResult BeginResetPassword(ResetPasswordRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ResetPasswordRequestMarshaller.Instance;
            var unmarshaller = ResetPasswordResponseUnmarshaller.Instance;

            return BeginInvoke<ResetPasswordRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResetPassword operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetPassword.</param>
        /// 
        /// <returns>Returns a  ResetPasswordResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ResetPassword">REST API Reference for ResetPassword Operation</seealso>
        public virtual ResetPasswordResponse EndResetPassword(IAsyncResult asyncResult)
        {
            return EndInvoke<ResetPasswordResponse>(asyncResult);
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
            var marshaller = UpdatePrimaryEmailAddressRequestMarshaller.Instance;
            var unmarshaller = UpdatePrimaryEmailAddressResponseUnmarshaller.Instance;

            return Invoke<UpdatePrimaryEmailAddressRequest,UpdatePrimaryEmailAddressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePrimaryEmailAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrimaryEmailAddress operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePrimaryEmailAddress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdatePrimaryEmailAddress">REST API Reference for UpdatePrimaryEmailAddress Operation</seealso>
        public virtual IAsyncResult BeginUpdatePrimaryEmailAddress(UpdatePrimaryEmailAddressRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdatePrimaryEmailAddressRequestMarshaller.Instance;
            var unmarshaller = UpdatePrimaryEmailAddressResponseUnmarshaller.Instance;

            return BeginInvoke<UpdatePrimaryEmailAddressRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePrimaryEmailAddress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePrimaryEmailAddress.</param>
        /// 
        /// <returns>Returns a  UpdatePrimaryEmailAddressResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdatePrimaryEmailAddress">REST API Reference for UpdatePrimaryEmailAddress Operation</seealso>
        public virtual UpdatePrimaryEmailAddressResponse EndUpdatePrimaryEmailAddress(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePrimaryEmailAddressResponse>(asyncResult);
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
            var marshaller = UpdateResourceRequestMarshaller.Instance;
            var unmarshaller = UpdateResourceResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceRequest,UpdateResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        public virtual IAsyncResult BeginUpdateResource(UpdateResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateResourceRequestMarshaller.Instance;
            var unmarshaller = UpdateResourceResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResource.</param>
        /// 
        /// <returns>Returns a  UpdateResourceResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        public virtual UpdateResourceResponse EndUpdateResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateResourceResponse>(asyncResult);
        }

        #endregion
        
    }
}