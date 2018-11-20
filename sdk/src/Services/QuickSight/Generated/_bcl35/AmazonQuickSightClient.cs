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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.QuickSight.Model;
using Amazon.QuickSight.Model.Internal.MarshallTransformations;
using Amazon.QuickSight.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.QuickSight
{
    /// <summary>
    /// Implementation for accessing QuickSight
    ///
    /// Amazon QuickSight API Reference 
    /// <para>
    /// Amazon QuickSight is a fast, cloud-powered BI service that makes it easy to build
    /// visualizations, perform ad hoc analysis, and quickly get business insights from your
    /// data. This API interface reference contains documentation for a programming interface
    /// that you can use to manage Amazon QuickSight. 
    /// </para>
    /// </summary>
    public partial class AmazonQuickSightClient : AmazonServiceClient, IAmazonQuickSight
    {
        private static IServiceMetadata serviceMetadata = new AmazonQuickSightMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonQuickSightClient with the credentials loaded from the application's
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
        public AmazonQuickSightClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonQuickSightConfig()) { }

        /// <summary>
        /// Constructs AmazonQuickSightClient with the credentials loaded from the application's
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
        public AmazonQuickSightClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonQuickSightConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonQuickSightClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonQuickSightClient Configuration Object</param>
        public AmazonQuickSightClient(AmazonQuickSightConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonQuickSightClient(AWSCredentials credentials)
            : this(credentials, new AmazonQuickSightConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQuickSightClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonQuickSightConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Credentials and an
        /// AmazonQuickSightClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonQuickSightClient Configuration Object</param>
        public AmazonQuickSightClient(AWSCredentials credentials, AmazonQuickSightConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonQuickSightClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQuickSightConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQuickSightClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQuickSightConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQuickSightClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonQuickSightClient Configuration Object</param>
        public AmazonQuickSightClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonQuickSightConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonQuickSightClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQuickSightConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQuickSightClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQuickSightConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQuickSightClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonQuickSightClient Configuration Object</param>
        public AmazonQuickSightClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonQuickSightConfig clientConfig)
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

        
        #region  CreateGroup

        /// <summary>
        /// Creates an Amazon QuickSight group.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;relevant-aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The response is a group object.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
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
        /// <returns>Returns a  CreateGroupResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual CreateGroupResponse EndCreateGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGroupMembership

        /// <summary>
        /// Adds an Amazon QuickSight user to an Amazon QuickSight group. 
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The condition resource is the user name.
        /// </para>
        ///  
        /// <para>
        /// The condition key is <code>quicksight:UserName</code>.
        /// </para>
        ///  
        /// <para>
        /// The response is the group member object.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupMembership service method.</param>
        /// 
        /// <returns>The response from the CreateGroupMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroupMembership">REST API Reference for CreateGroupMembership Operation</seealso>
        public virtual CreateGroupMembershipResponse CreateGroupMembership(CreateGroupMembershipRequest request)
        {
            var marshaller = CreateGroupMembershipRequestMarshaller.Instance;
            var unmarshaller = CreateGroupMembershipResponseUnmarshaller.Instance;

            return Invoke<CreateGroupMembershipRequest,CreateGroupMembershipResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupMembership operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroupMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroupMembership">REST API Reference for CreateGroupMembership Operation</seealso>
        public virtual IAsyncResult BeginCreateGroupMembership(CreateGroupMembershipRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateGroupMembershipRequestMarshaller.Instance;
            var unmarshaller = CreateGroupMembershipResponseUnmarshaller.Instance;

            return BeginInvoke<CreateGroupMembershipRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroupMembership.</param>
        /// 
        /// <returns>Returns a  CreateGroupMembershipResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroupMembership">REST API Reference for CreateGroupMembership Operation</seealso>
        public virtual CreateGroupMembershipResponse EndCreateGroupMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGroupMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGroup

        /// <summary>
        /// Removes a user group from Amazon QuickSight. 
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
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
        /// <returns>Returns a  DeleteGroupResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual DeleteGroupResponse EndDeleteGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGroupMembership

        /// <summary>
        /// Removes a user from a group so that the user is no longer a member of the group.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The condition resource is the user name.
        /// </para>
        ///  
        /// <para>
        /// The condition key is <code>quicksight:UserName</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupMembership service method.</param>
        /// 
        /// <returns>The response from the DeleteGroupMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroupMembership">REST API Reference for DeleteGroupMembership Operation</seealso>
        public virtual DeleteGroupMembershipResponse DeleteGroupMembership(DeleteGroupMembershipRequest request)
        {
            var marshaller = DeleteGroupMembershipRequestMarshaller.Instance;
            var unmarshaller = DeleteGroupMembershipResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupMembershipRequest,DeleteGroupMembershipResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupMembership operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroupMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroupMembership">REST API Reference for DeleteGroupMembership Operation</seealso>
        public virtual IAsyncResult BeginDeleteGroupMembership(DeleteGroupMembershipRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteGroupMembershipRequestMarshaller.Instance;
            var unmarshaller = DeleteGroupMembershipResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteGroupMembershipRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroupMembership.</param>
        /// 
        /// <returns>Returns a  DeleteGroupMembershipResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroupMembership">REST API Reference for DeleteGroupMembership Operation</seealso>
        public virtual DeleteGroupMembershipResponse EndDeleteGroupMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGroupMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUser

        /// <summary>
        /// Deletes the Amazon QuickSight user that is associated with the identity of the AWS
        /// Identity and Access Management (IAM) user or role that's making the call. The IAM
        /// user isn't deleted as a result of this call. 
        /// 
        ///  
        /// <para>
        /// The permission resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:user/default/<i>&lt;user-name&gt;
        /// </i> </code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
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
        /// <returns>Returns a  DeleteUserResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeGroup

        /// <summary>
        /// Returns an Amazon QuickSight group's description and Amazon Resource Name (ARN). 
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;relevant-aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The response is the group object. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
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
        /// <returns>Returns a  DescribeGroupResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        public virtual DescribeGroupResponse EndDescribeGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeUser

        /// <summary>
        /// Returns information about a user, given the user name. 
        /// 
        ///  
        /// <para>
        /// The permission resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:user/default/<i>&lt;user-name&gt;</i>
        /// </code>. 
        /// </para>
        ///  
        /// <para>
        /// The response is a user object that contains the user's Amazon Resource Name (ARN),
        /// AWS Identity and Access Management (IAM) role, and email address. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
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
        /// <returns>Returns a  DescribeUserResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        public virtual DescribeUserResponse EndDescribeUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeUserResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDashboardEmbedUrl

        /// <summary>
        /// Generates an embedded URL and authorization code. Before this can work properly, you
        /// need to configure the dashboards and user permissions first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDashboardEmbedUrl service method.</param>
        /// 
        /// <returns>The response from the GetDashboardEmbedUrl service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.DomainNotWhitelistedException">
        /// The domain specified is not on the allowlist. All domains for embedded dashboards
        /// must be added to the approved list by an Amazon QuickSight admin.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.IdentityTypeNotSupportedException">
        /// The identity type specified is not supported. Supported identity types include: IAM
        /// and QUICKSIGHT.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.QuickSightUserNotFoundException">
        /// The user is not found. This could happen in any operation that requires finding a
        /// user based on the provided user name, such as DeleteUser, DescribeUser, and so on.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.SessionLifetimeInMinutesInvalidException">
        /// The number of minutes specified for the lifetime of a session is invalid. The session
        /// lifetime must be between 15 and 600 minutes.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// Indicates that you are calling an operation on an Amazon QuickSight subscription where
        /// the edition does not include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetDashboardEmbedUrl">REST API Reference for GetDashboardEmbedUrl Operation</seealso>
        public virtual GetDashboardEmbedUrlResponse GetDashboardEmbedUrl(GetDashboardEmbedUrlRequest request)
        {
            var marshaller = GetDashboardEmbedUrlRequestMarshaller.Instance;
            var unmarshaller = GetDashboardEmbedUrlResponseUnmarshaller.Instance;

            return Invoke<GetDashboardEmbedUrlRequest,GetDashboardEmbedUrlResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDashboardEmbedUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDashboardEmbedUrl operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDashboardEmbedUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetDashboardEmbedUrl">REST API Reference for GetDashboardEmbedUrl Operation</seealso>
        public virtual IAsyncResult BeginGetDashboardEmbedUrl(GetDashboardEmbedUrlRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetDashboardEmbedUrlRequestMarshaller.Instance;
            var unmarshaller = GetDashboardEmbedUrlResponseUnmarshaller.Instance;

            return BeginInvoke<GetDashboardEmbedUrlRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDashboardEmbedUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDashboardEmbedUrl.</param>
        /// 
        /// <returns>Returns a  GetDashboardEmbedUrlResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetDashboardEmbedUrl">REST API Reference for GetDashboardEmbedUrl Operation</seealso>
        public virtual GetDashboardEmbedUrlResponse EndGetDashboardEmbedUrl(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDashboardEmbedUrlResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGroupMemberships

        /// <summary>
        /// Lists member users in a group.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The response is a list of group member objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMemberships service method.</param>
        /// 
        /// <returns>The response from the ListGroupMemberships service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroupMemberships">REST API Reference for ListGroupMemberships Operation</seealso>
        public virtual ListGroupMembershipsResponse ListGroupMemberships(ListGroupMembershipsRequest request)
        {
            var marshaller = ListGroupMembershipsRequestMarshaller.Instance;
            var unmarshaller = ListGroupMembershipsResponseUnmarshaller.Instance;

            return Invoke<ListGroupMembershipsRequest,ListGroupMembershipsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupMemberships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMemberships operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupMemberships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroupMemberships">REST API Reference for ListGroupMemberships Operation</seealso>
        public virtual IAsyncResult BeginListGroupMemberships(ListGroupMembershipsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListGroupMembershipsRequestMarshaller.Instance;
            var unmarshaller = ListGroupMembershipsResponseUnmarshaller.Instance;

            return BeginInvoke<ListGroupMembershipsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupMemberships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupMemberships.</param>
        /// 
        /// <returns>Returns a  ListGroupMembershipsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroupMemberships">REST API Reference for ListGroupMemberships Operation</seealso>
        public virtual ListGroupMembershipsResponse EndListGroupMemberships(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroupMembershipsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGroups

        /// <summary>
        /// Lists all user groups in Amazon QuickSight. 
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/*</code>.
        /// </para>
        ///  
        /// <para>
        /// The response is a list of group objects. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
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
        /// <returns>Returns a  ListGroupsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual ListGroupsResponse EndListGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUserGroups

        /// <summary>
        /// Lists the Amazon QuickSight groups that a user is part of.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserGroups service method.</param>
        /// 
        /// <returns>The response from the ListUserGroups service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUserGroups">REST API Reference for ListUserGroups Operation</seealso>
        public virtual ListUserGroupsResponse ListUserGroups(ListUserGroupsRequest request)
        {
            var marshaller = ListUserGroupsRequestMarshaller.Instance;
            var unmarshaller = ListUserGroupsResponseUnmarshaller.Instance;

            return Invoke<ListUserGroupsRequest,ListUserGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserGroups operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUserGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUserGroups">REST API Reference for ListUserGroups Operation</seealso>
        public virtual IAsyncResult BeginListUserGroups(ListUserGroupsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListUserGroupsRequestMarshaller.Instance;
            var unmarshaller = ListUserGroupsResponseUnmarshaller.Instance;

            return BeginInvoke<ListUserGroupsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserGroups.</param>
        /// 
        /// <returns>Returns a  ListUserGroupsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUserGroups">REST API Reference for ListUserGroups Operation</seealso>
        public virtual ListUserGroupsResponse EndListUserGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUserGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUsers

        /// <summary>
        /// Returns a list of all of the Amazon QuickSight users belonging to this account. 
        /// 
        ///  
        /// <para>
        /// The permission resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:user/default/<i>*</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The response is a list of user objects, containing each user's Amazon Resource Name
        /// (ARN), AWS Identity and Access Management (IAM) role, and email address. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
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
        /// <returns>Returns a  ListUsersResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual ListUsersResponse EndListUsers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUsersResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterUser

        /// <summary>
        /// Creates an Amazon QuickSight user, whose identity is associated with the AWS Identity
        /// and Access Management (IAM) identity or role specified in the request. 
        /// 
        ///  
        /// <para>
        /// The permission resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:user/default/<i>&lt;user-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The condition resource is the Amazon Resource Name (ARN) for the IAM user or role,
        /// and the session name. 
        /// </para>
        ///  
        /// <para>
        /// The condition keys are <code>quicksight:IamArn</code> and <code>quicksight:SessionName</code>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterUser service method.</param>
        /// 
        /// <returns>The response from the RegisterUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/RegisterUser">REST API Reference for RegisterUser Operation</seealso>
        public virtual RegisterUserResponse RegisterUser(RegisterUserRequest request)
        {
            var marshaller = RegisterUserRequestMarshaller.Instance;
            var unmarshaller = RegisterUserResponseUnmarshaller.Instance;

            return Invoke<RegisterUserRequest,RegisterUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterUser operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/RegisterUser">REST API Reference for RegisterUser Operation</seealso>
        public virtual IAsyncResult BeginRegisterUser(RegisterUserRequest request, AsyncCallback callback, object state)
        {
            var marshaller = RegisterUserRequestMarshaller.Instance;
            var unmarshaller = RegisterUserResponseUnmarshaller.Instance;

            return BeginInvoke<RegisterUserRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterUser.</param>
        /// 
        /// <returns>Returns a  RegisterUserResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/RegisterUser">REST API Reference for RegisterUser Operation</seealso>
        public virtual RegisterUserResponse EndRegisterUser(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterUserResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGroup

        /// <summary>
        /// Changes a group description. 
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The response is a group object.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            var marshaller = UpdateGroupRequestMarshaller.Instance;
            var unmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupRequest,UpdateGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateGroup(UpdateGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateGroupRequestMarshaller.Instance;
            var unmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGroup.</param>
        /// 
        /// <returns>Returns a  UpdateGroupResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual UpdateGroupResponse EndUpdateGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUser

        /// <summary>
        /// Updates an Amazon QuickSight user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            var marshaller = UpdateUserRequestMarshaller.Instance;
            var unmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return Invoke<UpdateUserRequest,UpdateUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual IAsyncResult BeginUpdateUser(UpdateUserRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateUserRequestMarshaller.Instance;
            var unmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateUserRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUser.</param>
        /// 
        /// <returns>Returns a  UpdateUserResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual UpdateUserResponse EndUpdateUser(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserResponse>(asyncResult);
        }

        #endregion
        
    }
}