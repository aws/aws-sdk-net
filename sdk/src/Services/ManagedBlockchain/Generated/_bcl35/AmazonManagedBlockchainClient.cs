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
 * Do not modify this file. This file is generated from the managedblockchain-2018-09-24.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.ManagedBlockchain.Model;
using Amazon.ManagedBlockchain.Model.Internal.MarshallTransformations;
using Amazon.ManagedBlockchain.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ManagedBlockchain
{
    /// <summary>
    /// Implementation for accessing ManagedBlockchain
    ///
    /// Amazon Managed Blockchain is a fully managed service for creating and managing blockchain
    /// networks using open-source frameworks. Blockchain allows you to build applications
    /// where multiple parties can securely and transparently run transactions and share data
    /// without the need for a trusted, central authority.
    /// 
    ///  
    /// <para>
    /// Managed Blockchain supports the Hyperledger Fabric and Ethereum open-source frameworks.
    /// Because of fundamental differences between the frameworks, some API actions or data
    /// types may only apply in the context of one framework and not the other. For example,
    /// actions related to Hyperledger Fabric network members such as <code>CreateMember</code>
    /// and <code>DeleteMember</code> do not apply to Ethereum.
    /// </para>
    ///  
    /// <para>
    /// The description for each action indicates the framework or frameworks to which it
    /// applies. Data types and properties that apply only in the context of a particular
    /// framework are similarly indicated.
    /// </para>
    /// </summary>
    public partial class AmazonManagedBlockchainClient : AmazonServiceClient, IAmazonManagedBlockchain
    {
        private static IServiceMetadata serviceMetadata = new AmazonManagedBlockchainMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonManagedBlockchainClient with the credentials loaded from the application's
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
        public AmazonManagedBlockchainClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonManagedBlockchainConfig()) { }

        /// <summary>
        /// Constructs AmazonManagedBlockchainClient with the credentials loaded from the application's
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
        public AmazonManagedBlockchainClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonManagedBlockchainConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonManagedBlockchainClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonManagedBlockchainClient Configuration Object</param>
        public AmazonManagedBlockchainClient(AmazonManagedBlockchainConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonManagedBlockchainClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonManagedBlockchainClient(AWSCredentials credentials)
            : this(credentials, new AmazonManagedBlockchainConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonManagedBlockchainClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonManagedBlockchainClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonManagedBlockchainConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonManagedBlockchainClient with AWS Credentials and an
        /// AmazonManagedBlockchainClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonManagedBlockchainClient Configuration Object</param>
        public AmazonManagedBlockchainClient(AWSCredentials credentials, AmazonManagedBlockchainConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonManagedBlockchainClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonManagedBlockchainClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonManagedBlockchainConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonManagedBlockchainClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonManagedBlockchainClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonManagedBlockchainConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonManagedBlockchainClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonManagedBlockchainClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonManagedBlockchainClient Configuration Object</param>
        public AmazonManagedBlockchainClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonManagedBlockchainConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonManagedBlockchainClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonManagedBlockchainClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonManagedBlockchainConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonManagedBlockchainClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonManagedBlockchainClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonManagedBlockchainConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonManagedBlockchainClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonManagedBlockchainClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonManagedBlockchainClient Configuration Object</param>
        public AmazonManagedBlockchainClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonManagedBlockchainConfig clientConfig)
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


        #region  CreateMember

        /// <summary>
        /// Creates a member within a Managed Blockchain network.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMember service method.</param>
        /// 
        /// <returns>The response from the CreateMember service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceAlreadyExistsException">
        /// A resource request is issued for a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceLimitExceededException">
        /// The maximum number of resources of that type already exist. Ensure the resources requested
        /// are within the boundaries of the service edition and your account limits.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotReadyException">
        /// The requested resource exists but is not in a status that can complete the operation.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/CreateMember">REST API Reference for CreateMember Operation</seealso>
        public virtual CreateMemberResponse CreateMember(CreateMemberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMemberResponseUnmarshaller.Instance;

            return Invoke<CreateMemberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMember operation on AmazonManagedBlockchainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/CreateMember">REST API Reference for CreateMember Operation</seealso>
        public virtual IAsyncResult BeginCreateMember(CreateMemberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMemberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMember.</param>
        /// 
        /// <returns>Returns a  CreateMemberResult from ManagedBlockchain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/CreateMember">REST API Reference for CreateMember Operation</seealso>
        public virtual CreateMemberResponse EndCreateMember(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMemberResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateNetwork

        /// <summary>
        /// Creates a new blockchain network using Amazon Managed Blockchain.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetwork service method.</param>
        /// 
        /// <returns>The response from the CreateNetwork service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceAlreadyExistsException">
        /// A resource request is issued for a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceLimitExceededException">
        /// The maximum number of resources of that type already exist. Ensure the resources requested
        /// are within the boundaries of the service edition and your account limits.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/CreateNetwork">REST API Reference for CreateNetwork Operation</seealso>
        public virtual CreateNetworkResponse CreateNetwork(CreateNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetwork operation on AmazonManagedBlockchainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/CreateNetwork">REST API Reference for CreateNetwork Operation</seealso>
        public virtual IAsyncResult BeginCreateNetwork(CreateNetworkRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetwork.</param>
        /// 
        /// <returns>Returns a  CreateNetworkResult from ManagedBlockchain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/CreateNetwork">REST API Reference for CreateNetwork Operation</seealso>
        public virtual CreateNetworkResponse EndCreateNetwork(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateNetworkResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateNode

        /// <summary>
        /// Creates a node on the specified blockchain network.
        /// 
        ///  
        /// <para>
        /// Applies to Hyperledger Fabric and Ethereum.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNode service method.</param>
        /// 
        /// <returns>The response from the CreateNode service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceAlreadyExistsException">
        /// A resource request is issued for a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceLimitExceededException">
        /// The maximum number of resources of that type already exist. Ensure the resources requested
        /// are within the boundaries of the service edition and your account limits.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotReadyException">
        /// The requested resource exists but is not in a status that can complete the operation.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/CreateNode">REST API Reference for CreateNode Operation</seealso>
        public virtual CreateNodeResponse CreateNode(CreateNodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNodeResponseUnmarshaller.Instance;

            return Invoke<CreateNodeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNode operation on AmazonManagedBlockchainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/CreateNode">REST API Reference for CreateNode Operation</seealso>
        public virtual IAsyncResult BeginCreateNode(CreateNodeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNode.</param>
        /// 
        /// <returns>Returns a  CreateNodeResult from ManagedBlockchain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/CreateNode">REST API Reference for CreateNode Operation</seealso>
        public virtual CreateNodeResponse EndCreateNode(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateNodeResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProposal

        /// <summary>
        /// Creates a proposal for a change to the network that other members of the network can
        /// vote on, for example, a proposal to add a new member to the network. Any member can
        /// create a proposal.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProposal service method.</param>
        /// 
        /// <returns>The response from the CreateProposal service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotReadyException">
        /// The requested resource exists but is not in a status that can complete the operation.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/CreateProposal">REST API Reference for CreateProposal Operation</seealso>
        public virtual CreateProposalResponse CreateProposal(CreateProposalRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProposalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProposalResponseUnmarshaller.Instance;

            return Invoke<CreateProposalResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProposal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProposal operation on AmazonManagedBlockchainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProposal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/CreateProposal">REST API Reference for CreateProposal Operation</seealso>
        public virtual IAsyncResult BeginCreateProposal(CreateProposalRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProposalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProposalResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProposal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProposal.</param>
        /// 
        /// <returns>Returns a  CreateProposalResult from ManagedBlockchain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/CreateProposal">REST API Reference for CreateProposal Operation</seealso>
        public virtual CreateProposalResponse EndCreateProposal(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProposalResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMember

        /// <summary>
        /// Deletes a member. Deleting a member removes the member and all associated resources
        /// from the network. <code>DeleteMember</code> can only be called for a specified <code>MemberId</code>
        /// if the principal performing the action is associated with the AWS account that owns
        /// the member. In all other cases, the <code>DeleteMember</code> action is carried out
        /// as the result of an approved proposal to remove a member. If <code>MemberId</code>
        /// is the last member in a network specified by the last AWS account, the network is
        /// deleted also.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMember service method.</param>
        /// 
        /// <returns>The response from the DeleteMember service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotReadyException">
        /// The requested resource exists but is not in a status that can complete the operation.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/DeleteMember">REST API Reference for DeleteMember Operation</seealso>
        public virtual DeleteMemberResponse DeleteMember(DeleteMemberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMemberResponseUnmarshaller.Instance;

            return Invoke<DeleteMemberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMember operation on AmazonManagedBlockchainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/DeleteMember">REST API Reference for DeleteMember Operation</seealso>
        public virtual IAsyncResult BeginDeleteMember(DeleteMemberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMemberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMember.</param>
        /// 
        /// <returns>Returns a  DeleteMemberResult from ManagedBlockchain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/DeleteMember">REST API Reference for DeleteMember Operation</seealso>
        public virtual DeleteMemberResponse EndDeleteMember(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMemberResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteNode

        /// <summary>
        /// Deletes a node that your AWS account owns. All data on the node is lost and cannot
        /// be recovered.
        /// 
        ///  
        /// <para>
        /// Applies to Hyperledger Fabric and Ethereum.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNode service method.</param>
        /// 
        /// <returns>The response from the DeleteNode service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotReadyException">
        /// The requested resource exists but is not in a status that can complete the operation.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/DeleteNode">REST API Reference for DeleteNode Operation</seealso>
        public virtual DeleteNodeResponse DeleteNode(DeleteNodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNodeResponseUnmarshaller.Instance;

            return Invoke<DeleteNodeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNode operation on AmazonManagedBlockchainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/DeleteNode">REST API Reference for DeleteNode Operation</seealso>
        public virtual IAsyncResult BeginDeleteNode(DeleteNodeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNode.</param>
        /// 
        /// <returns>Returns a  DeleteNodeResult from ManagedBlockchain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/DeleteNode">REST API Reference for DeleteNode Operation</seealso>
        public virtual DeleteNodeResponse EndDeleteNode(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNodeResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMember

        /// <summary>
        /// Returns detailed information about a member.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMember service method.</param>
        /// 
        /// <returns>The response from the GetMember service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/GetMember">REST API Reference for GetMember Operation</seealso>
        public virtual GetMemberResponse GetMember(GetMemberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMemberResponseUnmarshaller.Instance;

            return Invoke<GetMemberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMember operation on AmazonManagedBlockchainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/GetMember">REST API Reference for GetMember Operation</seealso>
        public virtual IAsyncResult BeginGetMember(GetMemberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMemberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMember.</param>
        /// 
        /// <returns>Returns a  GetMemberResult from ManagedBlockchain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/GetMember">REST API Reference for GetMember Operation</seealso>
        public virtual GetMemberResponse EndGetMember(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMemberResponse>(asyncResult);
        }

        #endregion
        
        #region  GetNetwork

        /// <summary>
        /// Returns detailed information about a network.
        /// 
        ///  
        /// <para>
        /// Applies to Hyperledger Fabric and Ethereum.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetwork service method.</param>
        /// 
        /// <returns>The response from the GetNetwork service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/GetNetwork">REST API Reference for GetNetwork Operation</seealso>
        public virtual GetNetworkResponse GetNetwork(GetNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkResponseUnmarshaller.Instance;

            return Invoke<GetNetworkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNetwork operation on AmazonManagedBlockchainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/GetNetwork">REST API Reference for GetNetwork Operation</seealso>
        public virtual IAsyncResult BeginGetNetwork(GetNetworkRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNetwork.</param>
        /// 
        /// <returns>Returns a  GetNetworkResult from ManagedBlockchain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/GetNetwork">REST API Reference for GetNetwork Operation</seealso>
        public virtual GetNetworkResponse EndGetNetwork(IAsyncResult asyncResult)
        {
            return EndInvoke<GetNetworkResponse>(asyncResult);
        }

        #endregion
        
        #region  GetNode

        /// <summary>
        /// Returns detailed information about a node.
        /// 
        ///  
        /// <para>
        /// Applies to Hyperledger Fabric and Ethereum.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNode service method.</param>
        /// 
        /// <returns>The response from the GetNode service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/GetNode">REST API Reference for GetNode Operation</seealso>
        public virtual GetNodeResponse GetNode(GetNodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNodeResponseUnmarshaller.Instance;

            return Invoke<GetNodeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNode operation on AmazonManagedBlockchainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/GetNode">REST API Reference for GetNode Operation</seealso>
        public virtual IAsyncResult BeginGetNode(GetNodeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNode.</param>
        /// 
        /// <returns>Returns a  GetNodeResult from ManagedBlockchain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/GetNode">REST API Reference for GetNode Operation</seealso>
        public virtual GetNodeResponse EndGetNode(IAsyncResult asyncResult)
        {
            return EndInvoke<GetNodeResponse>(asyncResult);
        }

        #endregion
        
        #region  GetProposal

        /// <summary>
        /// Returns detailed information about a proposal.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProposal service method.</param>
        /// 
        /// <returns>The response from the GetProposal service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/GetProposal">REST API Reference for GetProposal Operation</seealso>
        public virtual GetProposalResponse GetProposal(GetProposalRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProposalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProposalResponseUnmarshaller.Instance;

            return Invoke<GetProposalResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProposal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProposal operation on AmazonManagedBlockchainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProposal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/GetProposal">REST API Reference for GetProposal Operation</seealso>
        public virtual IAsyncResult BeginGetProposal(GetProposalRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProposalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProposalResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProposal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProposal.</param>
        /// 
        /// <returns>Returns a  GetProposalResult from ManagedBlockchain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/GetProposal">REST API Reference for GetProposal Operation</seealso>
        public virtual GetProposalResponse EndGetProposal(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProposalResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInvitations

        /// <summary>
        /// Returns a list of all invitations for the current AWS account.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations service method.</param>
        /// 
        /// <returns>The response from the ListInvitations service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceLimitExceededException">
        /// The maximum number of resources of that type already exist. Ensure the resources requested
        /// are within the boundaries of the service edition and your account limits.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        public virtual ListInvitationsResponse ListInvitations(ListInvitationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvitationsResponseUnmarshaller.Instance;

            return Invoke<ListInvitationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations operation on AmazonManagedBlockchainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInvitations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        public virtual IAsyncResult BeginListInvitations(ListInvitationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvitationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInvitations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInvitations.</param>
        /// 
        /// <returns>Returns a  ListInvitationsResult from ManagedBlockchain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        public virtual ListInvitationsResponse EndListInvitations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInvitationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMembers

        /// <summary>
        /// Returns a list of the members in a network and properties of their configurations.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListMembers">REST API Reference for ListMembers Operation</seealso>
        public virtual ListMembersResponse ListMembers(ListMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembersResponseUnmarshaller.Instance;

            return Invoke<ListMembersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMembers operation on AmazonManagedBlockchainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListMembers">REST API Reference for ListMembers Operation</seealso>
        public virtual IAsyncResult BeginListMembers(ListMembersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMembers.</param>
        /// 
        /// <returns>Returns a  ListMembersResult from ManagedBlockchain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListMembers">REST API Reference for ListMembers Operation</seealso>
        public virtual ListMembersResponse EndListMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMembersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListNetworks

        /// <summary>
        /// Returns information about the networks in which the current AWS account participates.
        /// 
        ///  
        /// <para>
        /// Applies to Hyperledger Fabric and Ethereum.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworks service method.</param>
        /// 
        /// <returns>The response from the ListNetworks service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListNetworks">REST API Reference for ListNetworks Operation</seealso>
        public virtual ListNetworksResponse ListNetworks(ListNetworksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworksResponseUnmarshaller.Instance;

            return Invoke<ListNetworksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListNetworks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNetworks operation on AmazonManagedBlockchainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNetworks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListNetworks">REST API Reference for ListNetworks Operation</seealso>
        public virtual IAsyncResult BeginListNetworks(ListNetworksRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNetworks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNetworks.</param>
        /// 
        /// <returns>Returns a  ListNetworksResult from ManagedBlockchain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListNetworks">REST API Reference for ListNetworks Operation</seealso>
        public virtual ListNetworksResponse EndListNetworks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNetworksResponse>(asyncResult);
        }

        #endregion
        
        #region  ListNodes

        /// <summary>
        /// Returns information about the nodes within a network.
        /// 
        ///  
        /// <para>
        /// Applies to Hyperledger Fabric and Ethereum.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNodes service method.</param>
        /// 
        /// <returns>The response from the ListNodes service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListNodes">REST API Reference for ListNodes Operation</seealso>
        public virtual ListNodesResponse ListNodes(ListNodesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNodesResponseUnmarshaller.Instance;

            return Invoke<ListNodesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListNodes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNodes operation on AmazonManagedBlockchainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNodes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListNodes">REST API Reference for ListNodes Operation</seealso>
        public virtual IAsyncResult BeginListNodes(ListNodesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNodesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNodes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNodes.</param>
        /// 
        /// <returns>Returns a  ListNodesResult from ManagedBlockchain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListNodes">REST API Reference for ListNodes Operation</seealso>
        public virtual ListNodesResponse EndListNodes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNodesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProposals

        /// <summary>
        /// Returns a list of proposals for the network.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProposals service method.</param>
        /// 
        /// <returns>The response from the ListProposals service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListProposals">REST API Reference for ListProposals Operation</seealso>
        public virtual ListProposalsResponse ListProposals(ListProposalsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProposalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProposalsResponseUnmarshaller.Instance;

            return Invoke<ListProposalsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProposals operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProposals operation on AmazonManagedBlockchainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProposals
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListProposals">REST API Reference for ListProposals Operation</seealso>
        public virtual IAsyncResult BeginListProposals(ListProposalsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProposalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProposalsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProposals operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProposals.</param>
        /// 
        /// <returns>Returns a  ListProposalsResult from ManagedBlockchain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListProposals">REST API Reference for ListProposals Operation</seealso>
        public virtual ListProposalsResponse EndListProposals(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProposalsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProposalVotes

        /// <summary>
        /// Returns the list of votes for a specified proposal, including the value of each vote
        /// and the unique identifier of the member that cast the vote.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProposalVotes service method.</param>
        /// 
        /// <returns>The response from the ListProposalVotes service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListProposalVotes">REST API Reference for ListProposalVotes Operation</seealso>
        public virtual ListProposalVotesResponse ListProposalVotes(ListProposalVotesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProposalVotesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProposalVotesResponseUnmarshaller.Instance;

            return Invoke<ListProposalVotesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProposalVotes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProposalVotes operation on AmazonManagedBlockchainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProposalVotes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListProposalVotes">REST API Reference for ListProposalVotes Operation</seealso>
        public virtual IAsyncResult BeginListProposalVotes(ListProposalVotesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProposalVotesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProposalVotesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProposalVotes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProposalVotes.</param>
        /// 
        /// <returns>Returns a  ListProposalVotesResult from ManagedBlockchain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListProposalVotes">REST API Reference for ListProposalVotes Operation</seealso>
        public virtual ListProposalVotesResponse EndListProposalVotes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProposalVotesResponse>(asyncResult);
        }

        #endregion
        
        #region  RejectInvitation

        /// <summary>
        /// Rejects an invitation to join a network. This action can be called by a principal
        /// in an AWS account that has received an invitation to create a member and join a network.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectInvitation service method.</param>
        /// 
        /// <returns>The response from the RejectInvitation service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.IllegalActionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/RejectInvitation">REST API Reference for RejectInvitation Operation</seealso>
        public virtual RejectInvitationResponse RejectInvitation(RejectInvitationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectInvitationResponseUnmarshaller.Instance;

            return Invoke<RejectInvitationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RejectInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectInvitation operation on AmazonManagedBlockchainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/RejectInvitation">REST API Reference for RejectInvitation Operation</seealso>
        public virtual IAsyncResult BeginRejectInvitation(RejectInvitationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectInvitationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RejectInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectInvitation.</param>
        /// 
        /// <returns>Returns a  RejectInvitationResult from ManagedBlockchain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/RejectInvitation">REST API Reference for RejectInvitation Operation</seealso>
        public virtual RejectInvitationResponse EndRejectInvitation(IAsyncResult asyncResult)
        {
            return EndInvoke<RejectInvitationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMember

        /// <summary>
        /// Updates a member configuration with new parameters.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMember service method.</param>
        /// 
        /// <returns>The response from the UpdateMember service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/UpdateMember">REST API Reference for UpdateMember Operation</seealso>
        public virtual UpdateMemberResponse UpdateMember(UpdateMemberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMemberResponseUnmarshaller.Instance;

            return Invoke<UpdateMemberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMember operation on AmazonManagedBlockchainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/UpdateMember">REST API Reference for UpdateMember Operation</seealso>
        public virtual IAsyncResult BeginUpdateMember(UpdateMemberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMemberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMember.</param>
        /// 
        /// <returns>Returns a  UpdateMemberResult from ManagedBlockchain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/UpdateMember">REST API Reference for UpdateMember Operation</seealso>
        public virtual UpdateMemberResponse EndUpdateMember(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMemberResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateNode

        /// <summary>
        /// Updates a node configuration with new parameters.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNode service method.</param>
        /// 
        /// <returns>The response from the UpdateNode service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/UpdateNode">REST API Reference for UpdateNode Operation</seealso>
        public virtual UpdateNodeResponse UpdateNode(UpdateNodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNodeResponseUnmarshaller.Instance;

            return Invoke<UpdateNodeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNode operation on AmazonManagedBlockchainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/UpdateNode">REST API Reference for UpdateNode Operation</seealso>
        public virtual IAsyncResult BeginUpdateNode(UpdateNodeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNode.</param>
        /// 
        /// <returns>Returns a  UpdateNodeResult from ManagedBlockchain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/UpdateNode">REST API Reference for UpdateNode Operation</seealso>
        public virtual UpdateNodeResponse EndUpdateNode(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateNodeResponse>(asyncResult);
        }

        #endregion
        
        #region  VoteOnProposal

        /// <summary>
        /// Casts a vote for a specified <code>ProposalId</code> on behalf of a member. The member
        /// to vote as, specified by <code>VoterMemberId</code>, must be in the same AWS account
        /// as the principal that calls the action.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VoteOnProposal service method.</param>
        /// 
        /// <returns>The response from the VoteOnProposal service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.IllegalActionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/VoteOnProposal">REST API Reference for VoteOnProposal Operation</seealso>
        public virtual VoteOnProposalResponse VoteOnProposal(VoteOnProposalRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VoteOnProposalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VoteOnProposalResponseUnmarshaller.Instance;

            return Invoke<VoteOnProposalResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the VoteOnProposal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VoteOnProposal operation on AmazonManagedBlockchainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndVoteOnProposal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/VoteOnProposal">REST API Reference for VoteOnProposal Operation</seealso>
        public virtual IAsyncResult BeginVoteOnProposal(VoteOnProposalRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VoteOnProposalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VoteOnProposalResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  VoteOnProposal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVoteOnProposal.</param>
        /// 
        /// <returns>Returns a  VoteOnProposalResult from ManagedBlockchain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/VoteOnProposal">REST API Reference for VoteOnProposal Operation</seealso>
        public virtual VoteOnProposalResponse EndVoteOnProposal(IAsyncResult asyncResult)
        {
            return EndInvoke<VoteOnProposalResponse>(asyncResult);
        }

        #endregion
        
    }
}