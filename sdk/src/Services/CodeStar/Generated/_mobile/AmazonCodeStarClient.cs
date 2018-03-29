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
 * Do not modify this file. This file is generated from the codestar-2017-04-19.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.CodeStar.Model;
using Amazon.CodeStar.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CodeStar
{
    /// <summary>
    /// Implementation for accessing CodeStar
    ///
    /// AWS CodeStar 
    /// <para>
    /// This is the API reference for AWS CodeStar. This reference provides descriptions of
    /// the operations and data types for the AWS CodeStar API along with usage examples.
    /// </para>
    ///  
    /// <para>
    /// You can use the AWS CodeStar API to work with:
    /// </para>
    ///  
    /// <para>
    /// Projects and their resources, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>DeleteProject</code>, which deletes a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DescribeProject</code>, which lists the attributes of a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListProjects</code>, which lists all projects associated with your AWS account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListResources</code>, which lists the resources associated with a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListTagsForProject</code>, which lists the tags associated with a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>TagProject</code>, which adds tags to a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UntagProject</code>, which removes tags from a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UpdateProject</code>, which updates the attributes of a project.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Teams and team members, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>AssociateTeamMember</code>, which adds an IAM user to the team for a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DisassociateTeamMember</code>, which removes an IAM user from the team for
    /// a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListTeamMembers</code>, which lists all the IAM users in the team for a project,
    /// including their roles and attributes.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UpdateTeamMember</code>, which updates a team member's attributes in a project.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Users, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>CreateUserProfile</code>, which creates a user profile that contains data associated
    /// with the user across all projects.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteUserProfile</code>, which deletes all user profile information across
    /// all projects.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DescribeUserProfile</code>, which describes the profile of a user.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListUserProfiles</code>, which lists all user profiles.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UpdateUserProfile</code>, which updates the profile for a user.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonCodeStarClient : AmazonServiceClient, IAmazonCodeStar
    {
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonCodeStarClient with the credentials loaded from the application's
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
        public AmazonCodeStarClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodeStarConfig()) { }

        /// <summary>
        /// Constructs AmazonCodeStarClient with the credentials loaded from the application's
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
        public AmazonCodeStarClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodeStarConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCodeStarClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCodeStarClient Configuration Object</param>
        public AmazonCodeStarClient(AmazonCodeStarConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonCodeStarClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCodeStarClient(AWSCredentials credentials)
            : this(credentials, new AmazonCodeStarConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeStarClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCodeStarConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarClient with AWS Credentials and an
        /// AmazonCodeStarClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCodeStarClient Configuration Object</param>
        public AmazonCodeStarClient(AWSCredentials credentials, AmazonCodeStarConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCodeStarClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeStarConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeStarClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeStarConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeStarClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCodeStarClient Configuration Object</param>
        public AmazonCodeStarClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCodeStarConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCodeStarClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeStarConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeStarClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeStarConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeStarClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCodeStarClient Configuration Object</param>
        public AmazonCodeStarClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCodeStarConfig clientConfig)
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

        
        #region  AssociateTeamMember

        internal virtual AssociateTeamMemberResponse AssociateTeamMember(AssociateTeamMemberRequest request)
        {
            var marshaller = AssociateTeamMemberRequestMarshaller.Instance;
            var unmarshaller = AssociateTeamMemberResponseUnmarshaller.Instance;

            return Invoke<AssociateTeamMemberRequest,AssociateTeamMemberResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateTeamMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateTeamMember operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/AssociateTeamMember">REST API Reference for AssociateTeamMember Operation</seealso>
        public virtual Task<AssociateTeamMemberResponse> AssociateTeamMemberAsync(AssociateTeamMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociateTeamMemberRequestMarshaller.Instance;
            var unmarshaller = AssociateTeamMemberResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateTeamMemberRequest,AssociateTeamMemberResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateProject

        internal virtual CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            var marshaller = CreateProjectRequestMarshaller.Instance;
            var unmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return Invoke<CreateProjectRequest,CreateProjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateProjectRequestMarshaller.Instance;
            var unmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProjectRequest,CreateProjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateUserProfile

        internal virtual CreateUserProfileResponse CreateUserProfile(CreateUserProfileRequest request)
        {
            var marshaller = CreateUserProfileRequestMarshaller.Instance;
            var unmarshaller = CreateUserProfileResponseUnmarshaller.Instance;

            return Invoke<CreateUserProfileRequest,CreateUserProfileResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        public virtual Task<CreateUserProfileResponse> CreateUserProfileAsync(CreateUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateUserProfileRequestMarshaller.Instance;
            var unmarshaller = CreateUserProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserProfileRequest,CreateUserProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteProject

        internal virtual DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            var marshaller = DeleteProjectRequestMarshaller.Instance;
            var unmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectRequest,DeleteProjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteProjectRequestMarshaller.Instance;
            var unmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProjectRequest,DeleteProjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteUserProfile

        internal virtual DeleteUserProfileResponse DeleteUserProfile(DeleteUserProfileRequest request)
        {
            var marshaller = DeleteUserProfileRequestMarshaller.Instance;
            var unmarshaller = DeleteUserProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteUserProfileRequest,DeleteUserProfileResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DeleteUserProfile">REST API Reference for DeleteUserProfile Operation</seealso>
        public virtual Task<DeleteUserProfileResponse> DeleteUserProfileAsync(DeleteUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteUserProfileRequestMarshaller.Instance;
            var unmarshaller = DeleteUserProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserProfileRequest,DeleteUserProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeProject

        internal virtual DescribeProjectResponse DescribeProject(DescribeProjectRequest request)
        {
            var marshaller = DescribeProjectRequestMarshaller.Instance;
            var unmarshaller = DescribeProjectResponseUnmarshaller.Instance;

            return Invoke<DescribeProjectRequest,DescribeProjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        public virtual Task<DescribeProjectResponse> DescribeProjectAsync(DescribeProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeProjectRequestMarshaller.Instance;
            var unmarshaller = DescribeProjectResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProjectRequest,DescribeProjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeUserProfile

        internal virtual DescribeUserProfileResponse DescribeUserProfile(DescribeUserProfileRequest request)
        {
            var marshaller = DescribeUserProfileRequestMarshaller.Instance;
            var unmarshaller = DescribeUserProfileResponseUnmarshaller.Instance;

            return Invoke<DescribeUserProfileRequest,DescribeUserProfileResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DescribeUserProfile">REST API Reference for DescribeUserProfile Operation</seealso>
        public virtual Task<DescribeUserProfileResponse> DescribeUserProfileAsync(DescribeUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeUserProfileRequestMarshaller.Instance;
            var unmarshaller = DescribeUserProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUserProfileRequest,DescribeUserProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateTeamMember

        internal virtual DisassociateTeamMemberResponse DisassociateTeamMember(DisassociateTeamMemberRequest request)
        {
            var marshaller = DisassociateTeamMemberRequestMarshaller.Instance;
            var unmarshaller = DisassociateTeamMemberResponseUnmarshaller.Instance;

            return Invoke<DisassociateTeamMemberRequest,DisassociateTeamMemberResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateTeamMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTeamMember operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DisassociateTeamMember">REST API Reference for DisassociateTeamMember Operation</seealso>
        public virtual Task<DisassociateTeamMemberResponse> DisassociateTeamMemberAsync(DisassociateTeamMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateTeamMemberRequestMarshaller.Instance;
            var unmarshaller = DisassociateTeamMemberResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateTeamMemberRequest,DisassociateTeamMemberResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListProjects

        internal virtual ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            var marshaller = ListProjectsRequestMarshaller.Instance;
            var unmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return Invoke<ListProjectsRequest,ListProjectsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public virtual Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListProjectsRequestMarshaller.Instance;
            var unmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProjectsRequest,ListProjectsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListResources

        internal virtual ListResourcesResponse ListResources(ListResourcesRequest request)
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListResources">REST API Reference for ListResources Operation</seealso>
        public virtual Task<ListResourcesResponse> ListResourcesAsync(ListResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListResourcesRequestMarshaller.Instance;
            var unmarshaller = ListResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourcesRequest,ListResourcesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForProject

        internal virtual ListTagsForProjectResponse ListTagsForProject(ListTagsForProjectRequest request)
        {
            var marshaller = ListTagsForProjectRequestMarshaller.Instance;
            var unmarshaller = ListTagsForProjectResponseUnmarshaller.Instance;

            return Invoke<ListTagsForProjectRequest,ListTagsForProjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListTagsForProject">REST API Reference for ListTagsForProject Operation</seealso>
        public virtual Task<ListTagsForProjectResponse> ListTagsForProjectAsync(ListTagsForProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListTagsForProjectRequestMarshaller.Instance;
            var unmarshaller = ListTagsForProjectResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForProjectRequest,ListTagsForProjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTeamMembers

        internal virtual ListTeamMembersResponse ListTeamMembers(ListTeamMembersRequest request)
        {
            var marshaller = ListTeamMembersRequestMarshaller.Instance;
            var unmarshaller = ListTeamMembersResponseUnmarshaller.Instance;

            return Invoke<ListTeamMembersRequest,ListTeamMembersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTeamMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTeamMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListTeamMembers">REST API Reference for ListTeamMembers Operation</seealso>
        public virtual Task<ListTeamMembersResponse> ListTeamMembersAsync(ListTeamMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListTeamMembersRequestMarshaller.Instance;
            var unmarshaller = ListTeamMembersResponseUnmarshaller.Instance;

            return InvokeAsync<ListTeamMembersRequest,ListTeamMembersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListUserProfiles

        internal virtual ListUserProfilesResponse ListUserProfiles(ListUserProfilesRequest request)
        {
            var marshaller = ListUserProfilesRequestMarshaller.Instance;
            var unmarshaller = ListUserProfilesResponseUnmarshaller.Instance;

            return Invoke<ListUserProfilesRequest,ListUserProfilesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListUserProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserProfiles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListUserProfiles">REST API Reference for ListUserProfiles Operation</seealso>
        public virtual Task<ListUserProfilesResponse> ListUserProfilesAsync(ListUserProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListUserProfilesRequestMarshaller.Instance;
            var unmarshaller = ListUserProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<ListUserProfilesRequest,ListUserProfilesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TagProject

        internal virtual TagProjectResponse TagProject(TagProjectRequest request)
        {
            var marshaller = TagProjectRequestMarshaller.Instance;
            var unmarshaller = TagProjectResponseUnmarshaller.Instance;

            return Invoke<TagProjectRequest,TagProjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TagProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/TagProject">REST API Reference for TagProject Operation</seealso>
        public virtual Task<TagProjectResponse> TagProjectAsync(TagProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = TagProjectRequestMarshaller.Instance;
            var unmarshaller = TagProjectResponseUnmarshaller.Instance;

            return InvokeAsync<TagProjectRequest,TagProjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UntagProject

        internal virtual UntagProjectResponse UntagProject(UntagProjectRequest request)
        {
            var marshaller = UntagProjectRequestMarshaller.Instance;
            var unmarshaller = UntagProjectResponseUnmarshaller.Instance;

            return Invoke<UntagProjectRequest,UntagProjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UntagProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UntagProject">REST API Reference for UntagProject Operation</seealso>
        public virtual Task<UntagProjectResponse> UntagProjectAsync(UntagProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UntagProjectRequestMarshaller.Instance;
            var unmarshaller = UntagProjectResponseUnmarshaller.Instance;

            return InvokeAsync<UntagProjectRequest,UntagProjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateProject

        internal virtual UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            var marshaller = UpdateProjectRequestMarshaller.Instance;
            var unmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return Invoke<UpdateProjectRequest,UpdateProjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public virtual Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateProjectRequestMarshaller.Instance;
            var unmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProjectRequest,UpdateProjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateTeamMember

        internal virtual UpdateTeamMemberResponse UpdateTeamMember(UpdateTeamMemberRequest request)
        {
            var marshaller = UpdateTeamMemberRequestMarshaller.Instance;
            var unmarshaller = UpdateTeamMemberResponseUnmarshaller.Instance;

            return Invoke<UpdateTeamMemberRequest,UpdateTeamMemberResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTeamMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTeamMember operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UpdateTeamMember">REST API Reference for UpdateTeamMember Operation</seealso>
        public virtual Task<UpdateTeamMemberResponse> UpdateTeamMemberAsync(UpdateTeamMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateTeamMemberRequestMarshaller.Instance;
            var unmarshaller = UpdateTeamMemberResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTeamMemberRequest,UpdateTeamMemberResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateUserProfile

        internal virtual UpdateUserProfileResponse UpdateUserProfile(UpdateUserProfileRequest request)
        {
            var marshaller = UpdateUserProfileRequestMarshaller.Instance;
            var unmarshaller = UpdateUserProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateUserProfileRequest,UpdateUserProfileResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        public virtual Task<UpdateUserProfileResponse> UpdateUserProfileAsync(UpdateUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateUserProfileRequestMarshaller.Instance;
            var unmarshaller = UpdateUserProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserProfileRequest,UpdateUserProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}