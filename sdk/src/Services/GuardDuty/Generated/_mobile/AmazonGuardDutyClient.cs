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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.GuardDuty.Model;
using Amazon.GuardDuty.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.GuardDuty
{
    /// <summary>
    /// Implementation for accessing GuardDuty
    ///
    /// Assess, monitor, manage, and remediate security issues across your AWS infrastructure,
    /// applications, and data.
    /// </summary>
    public partial class AmazonGuardDutyClient : AmazonServiceClient, IAmazonGuardDuty
    {
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonGuardDutyClient with the credentials loaded from the application's
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
        public AmazonGuardDutyClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGuardDutyConfig()) { }

        /// <summary>
        /// Constructs AmazonGuardDutyClient with the credentials loaded from the application's
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
        public AmazonGuardDutyClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGuardDutyConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonGuardDutyClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonGuardDutyClient Configuration Object</param>
        public AmazonGuardDutyClient(AmazonGuardDutyConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonGuardDutyClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonGuardDutyClient(AWSCredentials credentials)
            : this(credentials, new AmazonGuardDutyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGuardDutyClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGuardDutyClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonGuardDutyConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGuardDutyClient with AWS Credentials and an
        /// AmazonGuardDutyClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonGuardDutyClient Configuration Object</param>
        public AmazonGuardDutyClient(AWSCredentials credentials, AmazonGuardDutyConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGuardDutyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonGuardDutyClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGuardDutyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGuardDutyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGuardDutyClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGuardDutyConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonGuardDutyClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGuardDutyClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonGuardDutyClient Configuration Object</param>
        public AmazonGuardDutyClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonGuardDutyConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGuardDutyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonGuardDutyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGuardDutyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGuardDutyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGuardDutyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGuardDutyConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGuardDutyClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGuardDutyClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonGuardDutyClient Configuration Object</param>
        public AmazonGuardDutyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonGuardDutyConfig clientConfig)
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

        
        #region  AcceptInvitation

        internal virtual AcceptInvitationResponse AcceptInvitation(AcceptInvitationRequest request)
        {
            var marshaller = AcceptInvitationRequestMarshaller.Instance;
            var unmarshaller = AcceptInvitationResponseUnmarshaller.Instance;

            return Invoke<AcceptInvitationRequest,AcceptInvitationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AcceptInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        public virtual Task<AcceptInvitationResponse> AcceptInvitationAsync(AcceptInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AcceptInvitationRequestMarshaller.Instance;
            var unmarshaller = AcceptInvitationResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptInvitationRequest,AcceptInvitationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ArchiveFindings

        internal virtual ArchiveFindingsResponse ArchiveFindings(ArchiveFindingsRequest request)
        {
            var marshaller = ArchiveFindingsRequestMarshaller.Instance;
            var unmarshaller = ArchiveFindingsResponseUnmarshaller.Instance;

            return Invoke<ArchiveFindingsRequest,ArchiveFindingsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ArchiveFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ArchiveFindings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ArchiveFindings">REST API Reference for ArchiveFindings Operation</seealso>
        public virtual Task<ArchiveFindingsResponse> ArchiveFindingsAsync(ArchiveFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ArchiveFindingsRequestMarshaller.Instance;
            var unmarshaller = ArchiveFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<ArchiveFindingsRequest,ArchiveFindingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDetector

        internal virtual CreateDetectorResponse CreateDetector(CreateDetectorRequest request)
        {
            var marshaller = CreateDetectorRequestMarshaller.Instance;
            var unmarshaller = CreateDetectorResponseUnmarshaller.Instance;

            return Invoke<CreateDetectorRequest,CreateDetectorResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDetector operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateDetector">REST API Reference for CreateDetector Operation</seealso>
        public virtual Task<CreateDetectorResponse> CreateDetectorAsync(CreateDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDetectorRequestMarshaller.Instance;
            var unmarshaller = CreateDetectorResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDetectorRequest,CreateDetectorResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateFilter

        internal virtual CreateFilterResponse CreateFilter(CreateFilterRequest request)
        {
            var marshaller = CreateFilterRequestMarshaller.Instance;
            var unmarshaller = CreateFilterResponseUnmarshaller.Instance;

            return Invoke<CreateFilterRequest,CreateFilterResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFilter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateFilter">REST API Reference for CreateFilter Operation</seealso>
        public virtual Task<CreateFilterResponse> CreateFilterAsync(CreateFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateFilterRequestMarshaller.Instance;
            var unmarshaller = CreateFilterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFilterRequest,CreateFilterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateIPSet

        internal virtual CreateIPSetResponse CreateIPSet(CreateIPSetRequest request)
        {
            var marshaller = CreateIPSetRequestMarshaller.Instance;
            var unmarshaller = CreateIPSetResponseUnmarshaller.Instance;

            return Invoke<CreateIPSetRequest,CreateIPSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIPSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        public virtual Task<CreateIPSetResponse> CreateIPSetAsync(CreateIPSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateIPSetRequestMarshaller.Instance;
            var unmarshaller = CreateIPSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIPSetRequest,CreateIPSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateMembers

        internal virtual CreateMembersResponse CreateMembers(CreateMembersRequest request)
        {
            var marshaller = CreateMembersRequestMarshaller.Instance;
            var unmarshaller = CreateMembersResponseUnmarshaller.Instance;

            return Invoke<CreateMembersRequest,CreateMembersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateMembers">REST API Reference for CreateMembers Operation</seealso>
        public virtual Task<CreateMembersResponse> CreateMembersAsync(CreateMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateMembersRequestMarshaller.Instance;
            var unmarshaller = CreateMembersResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMembersRequest,CreateMembersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSampleFindings

        internal virtual CreateSampleFindingsResponse CreateSampleFindings(CreateSampleFindingsRequest request)
        {
            var marshaller = CreateSampleFindingsRequestMarshaller.Instance;
            var unmarshaller = CreateSampleFindingsResponseUnmarshaller.Instance;

            return Invoke<CreateSampleFindingsRequest,CreateSampleFindingsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSampleFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSampleFindings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateSampleFindings">REST API Reference for CreateSampleFindings Operation</seealso>
        public virtual Task<CreateSampleFindingsResponse> CreateSampleFindingsAsync(CreateSampleFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateSampleFindingsRequestMarshaller.Instance;
            var unmarshaller = CreateSampleFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSampleFindingsRequest,CreateSampleFindingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateThreatIntelSet

        internal virtual CreateThreatIntelSetResponse CreateThreatIntelSet(CreateThreatIntelSetRequest request)
        {
            var marshaller = CreateThreatIntelSetRequestMarshaller.Instance;
            var unmarshaller = CreateThreatIntelSetResponseUnmarshaller.Instance;

            return Invoke<CreateThreatIntelSetRequest,CreateThreatIntelSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateThreatIntelSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateThreatIntelSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateThreatIntelSet">REST API Reference for CreateThreatIntelSet Operation</seealso>
        public virtual Task<CreateThreatIntelSetResponse> CreateThreatIntelSetAsync(CreateThreatIntelSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateThreatIntelSetRequestMarshaller.Instance;
            var unmarshaller = CreateThreatIntelSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateThreatIntelSetRequest,CreateThreatIntelSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeclineInvitations

        internal virtual DeclineInvitationsResponse DeclineInvitations(DeclineInvitationsRequest request)
        {
            var marshaller = DeclineInvitationsRequestMarshaller.Instance;
            var unmarshaller = DeclineInvitationsResponseUnmarshaller.Instance;

            return Invoke<DeclineInvitationsRequest,DeclineInvitationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeclineInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeclineInvitations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeclineInvitations">REST API Reference for DeclineInvitations Operation</seealso>
        public virtual Task<DeclineInvitationsResponse> DeclineInvitationsAsync(DeclineInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeclineInvitationsRequestMarshaller.Instance;
            var unmarshaller = DeclineInvitationsResponseUnmarshaller.Instance;

            return InvokeAsync<DeclineInvitationsRequest,DeclineInvitationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDetector

        internal virtual DeleteDetectorResponse DeleteDetector(DeleteDetectorRequest request)
        {
            var marshaller = DeleteDetectorRequestMarshaller.Instance;
            var unmarshaller = DeleteDetectorResponseUnmarshaller.Instance;

            return Invoke<DeleteDetectorRequest,DeleteDetectorResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetector operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteDetector">REST API Reference for DeleteDetector Operation</seealso>
        public virtual Task<DeleteDetectorResponse> DeleteDetectorAsync(DeleteDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteDetectorRequestMarshaller.Instance;
            var unmarshaller = DeleteDetectorResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDetectorRequest,DeleteDetectorResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteFilter

        internal virtual DeleteFilterResponse DeleteFilter(DeleteFilterRequest request)
        {
            var marshaller = DeleteFilterRequestMarshaller.Instance;
            var unmarshaller = DeleteFilterResponseUnmarshaller.Instance;

            return Invoke<DeleteFilterRequest,DeleteFilterResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFilter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteFilter">REST API Reference for DeleteFilter Operation</seealso>
        public virtual Task<DeleteFilterResponse> DeleteFilterAsync(DeleteFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteFilterRequestMarshaller.Instance;
            var unmarshaller = DeleteFilterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFilterRequest,DeleteFilterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteInvitations

        internal virtual DeleteInvitationsResponse DeleteInvitations(DeleteInvitationsRequest request)
        {
            var marshaller = DeleteInvitationsRequestMarshaller.Instance;
            var unmarshaller = DeleteInvitationsResponseUnmarshaller.Instance;

            return Invoke<DeleteInvitationsRequest,DeleteInvitationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvitations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteInvitations">REST API Reference for DeleteInvitations Operation</seealso>
        public virtual Task<DeleteInvitationsResponse> DeleteInvitationsAsync(DeleteInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteInvitationsRequestMarshaller.Instance;
            var unmarshaller = DeleteInvitationsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInvitationsRequest,DeleteInvitationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteIPSet

        internal virtual DeleteIPSetResponse DeleteIPSet(DeleteIPSetRequest request)
        {
            var marshaller = DeleteIPSetRequestMarshaller.Instance;
            var unmarshaller = DeleteIPSetResponseUnmarshaller.Instance;

            return Invoke<DeleteIPSetRequest,DeleteIPSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIPSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        public virtual Task<DeleteIPSetResponse> DeleteIPSetAsync(DeleteIPSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteIPSetRequestMarshaller.Instance;
            var unmarshaller = DeleteIPSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIPSetRequest,DeleteIPSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteMembers

        internal virtual DeleteMembersResponse DeleteMembers(DeleteMembersRequest request)
        {
            var marshaller = DeleteMembersRequestMarshaller.Instance;
            var unmarshaller = DeleteMembersResponseUnmarshaller.Instance;

            return Invoke<DeleteMembersRequest,DeleteMembersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteMembers">REST API Reference for DeleteMembers Operation</seealso>
        public virtual Task<DeleteMembersResponse> DeleteMembersAsync(DeleteMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteMembersRequestMarshaller.Instance;
            var unmarshaller = DeleteMembersResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMembersRequest,DeleteMembersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteThreatIntelSet

        internal virtual DeleteThreatIntelSetResponse DeleteThreatIntelSet(DeleteThreatIntelSetRequest request)
        {
            var marshaller = DeleteThreatIntelSetRequestMarshaller.Instance;
            var unmarshaller = DeleteThreatIntelSetResponseUnmarshaller.Instance;

            return Invoke<DeleteThreatIntelSetRequest,DeleteThreatIntelSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteThreatIntelSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteThreatIntelSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteThreatIntelSet">REST API Reference for DeleteThreatIntelSet Operation</seealso>
        public virtual Task<DeleteThreatIntelSetResponse> DeleteThreatIntelSetAsync(DeleteThreatIntelSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteThreatIntelSetRequestMarshaller.Instance;
            var unmarshaller = DeleteThreatIntelSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteThreatIntelSetRequest,DeleteThreatIntelSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateFromMasterAccount

        internal virtual DisassociateFromMasterAccountResponse DisassociateFromMasterAccount(DisassociateFromMasterAccountRequest request)
        {
            var marshaller = DisassociateFromMasterAccountRequestMarshaller.Instance;
            var unmarshaller = DisassociateFromMasterAccountResponseUnmarshaller.Instance;

            return Invoke<DisassociateFromMasterAccountRequest,DisassociateFromMasterAccountResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateFromMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromMasterAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
        public virtual Task<DisassociateFromMasterAccountResponse> DisassociateFromMasterAccountAsync(DisassociateFromMasterAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateFromMasterAccountRequestMarshaller.Instance;
            var unmarshaller = DisassociateFromMasterAccountResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateFromMasterAccountRequest,DisassociateFromMasterAccountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateMembers

        internal virtual DisassociateMembersResponse DisassociateMembers(DisassociateMembersRequest request)
        {
            var marshaller = DisassociateMembersRequestMarshaller.Instance;
            var unmarshaller = DisassociateMembersResponseUnmarshaller.Instance;

            return Invoke<DisassociateMembersRequest,DisassociateMembersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisassociateMembers">REST API Reference for DisassociateMembers Operation</seealso>
        public virtual Task<DisassociateMembersResponse> DisassociateMembersAsync(DisassociateMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateMembersRequestMarshaller.Instance;
            var unmarshaller = DisassociateMembersResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateMembersRequest,DisassociateMembersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDetector

        internal virtual GetDetectorResponse GetDetector(GetDetectorRequest request)
        {
            var marshaller = GetDetectorRequestMarshaller.Instance;
            var unmarshaller = GetDetectorResponseUnmarshaller.Instance;

            return Invoke<GetDetectorRequest,GetDetectorResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDetector operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetDetector">REST API Reference for GetDetector Operation</seealso>
        public virtual Task<GetDetectorResponse> GetDetectorAsync(GetDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDetectorRequestMarshaller.Instance;
            var unmarshaller = GetDetectorResponseUnmarshaller.Instance;

            return InvokeAsync<GetDetectorRequest,GetDetectorResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetFilter

        internal virtual GetFilterResponse GetFilter(GetFilterRequest request)
        {
            var marshaller = GetFilterRequestMarshaller.Instance;
            var unmarshaller = GetFilterResponseUnmarshaller.Instance;

            return Invoke<GetFilterRequest,GetFilterResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFilter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFilter">REST API Reference for GetFilter Operation</seealso>
        public virtual Task<GetFilterResponse> GetFilterAsync(GetFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetFilterRequestMarshaller.Instance;
            var unmarshaller = GetFilterResponseUnmarshaller.Instance;

            return InvokeAsync<GetFilterRequest,GetFilterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetFindings

        internal virtual GetFindingsResponse GetFindings(GetFindingsRequest request)
        {
            var marshaller = GetFindingsRequestMarshaller.Instance;
            var unmarshaller = GetFindingsResponseUnmarshaller.Instance;

            return Invoke<GetFindingsRequest,GetFindingsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFindings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFindings">REST API Reference for GetFindings Operation</seealso>
        public virtual Task<GetFindingsResponse> GetFindingsAsync(GetFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetFindingsRequestMarshaller.Instance;
            var unmarshaller = GetFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetFindingsRequest,GetFindingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetFindingsStatistics

        internal virtual GetFindingsStatisticsResponse GetFindingsStatistics(GetFindingsStatisticsRequest request)
        {
            var marshaller = GetFindingsStatisticsRequestMarshaller.Instance;
            var unmarshaller = GetFindingsStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetFindingsStatisticsRequest,GetFindingsStatisticsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetFindingsStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsStatistics operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFindingsStatistics">REST API Reference for GetFindingsStatistics Operation</seealso>
        public virtual Task<GetFindingsStatisticsResponse> GetFindingsStatisticsAsync(GetFindingsStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetFindingsStatisticsRequestMarshaller.Instance;
            var unmarshaller = GetFindingsStatisticsResponseUnmarshaller.Instance;

            return InvokeAsync<GetFindingsStatisticsRequest,GetFindingsStatisticsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetInvitationsCount

        internal virtual GetInvitationsCountResponse GetInvitationsCount(GetInvitationsCountRequest request)
        {
            var marshaller = GetInvitationsCountRequestMarshaller.Instance;
            var unmarshaller = GetInvitationsCountResponseUnmarshaller.Instance;

            return Invoke<GetInvitationsCountRequest,GetInvitationsCountResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetInvitationsCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInvitationsCount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetInvitationsCount">REST API Reference for GetInvitationsCount Operation</seealso>
        public virtual Task<GetInvitationsCountResponse> GetInvitationsCountAsync(GetInvitationsCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetInvitationsCountRequestMarshaller.Instance;
            var unmarshaller = GetInvitationsCountResponseUnmarshaller.Instance;

            return InvokeAsync<GetInvitationsCountRequest,GetInvitationsCountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetIPSet

        internal virtual GetIPSetResponse GetIPSet(GetIPSetRequest request)
        {
            var marshaller = GetIPSetRequestMarshaller.Instance;
            var unmarshaller = GetIPSetResponseUnmarshaller.Instance;

            return Invoke<GetIPSetRequest,GetIPSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIPSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        public virtual Task<GetIPSetResponse> GetIPSetAsync(GetIPSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetIPSetRequestMarshaller.Instance;
            var unmarshaller = GetIPSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetIPSetRequest,GetIPSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetMasterAccount

        internal virtual GetMasterAccountResponse GetMasterAccount(GetMasterAccountRequest request)
        {
            var marshaller = GetMasterAccountRequestMarshaller.Instance;
            var unmarshaller = GetMasterAccountResponseUnmarshaller.Instance;

            return Invoke<GetMasterAccountRequest,GetMasterAccountResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMasterAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
        public virtual Task<GetMasterAccountResponse> GetMasterAccountAsync(GetMasterAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetMasterAccountRequestMarshaller.Instance;
            var unmarshaller = GetMasterAccountResponseUnmarshaller.Instance;

            return InvokeAsync<GetMasterAccountRequest,GetMasterAccountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetMembers

        internal virtual GetMembersResponse GetMembers(GetMembersRequest request)
        {
            var marshaller = GetMembersRequestMarshaller.Instance;
            var unmarshaller = GetMembersResponseUnmarshaller.Instance;

            return Invoke<GetMembersRequest,GetMembersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMembers">REST API Reference for GetMembers Operation</seealso>
        public virtual Task<GetMembersResponse> GetMembersAsync(GetMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetMembersRequestMarshaller.Instance;
            var unmarshaller = GetMembersResponseUnmarshaller.Instance;

            return InvokeAsync<GetMembersRequest,GetMembersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetThreatIntelSet

        internal virtual GetThreatIntelSetResponse GetThreatIntelSet(GetThreatIntelSetRequest request)
        {
            var marshaller = GetThreatIntelSetRequestMarshaller.Instance;
            var unmarshaller = GetThreatIntelSetResponseUnmarshaller.Instance;

            return Invoke<GetThreatIntelSetRequest,GetThreatIntelSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetThreatIntelSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetThreatIntelSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetThreatIntelSet">REST API Reference for GetThreatIntelSet Operation</seealso>
        public virtual Task<GetThreatIntelSetResponse> GetThreatIntelSetAsync(GetThreatIntelSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetThreatIntelSetRequestMarshaller.Instance;
            var unmarshaller = GetThreatIntelSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetThreatIntelSetRequest,GetThreatIntelSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  InviteMembers

        internal virtual InviteMembersResponse InviteMembers(InviteMembersRequest request)
        {
            var marshaller = InviteMembersRequestMarshaller.Instance;
            var unmarshaller = InviteMembersResponseUnmarshaller.Instance;

            return Invoke<InviteMembersRequest,InviteMembersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the InviteMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InviteMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/InviteMembers">REST API Reference for InviteMembers Operation</seealso>
        public virtual Task<InviteMembersResponse> InviteMembersAsync(InviteMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = InviteMembersRequestMarshaller.Instance;
            var unmarshaller = InviteMembersResponseUnmarshaller.Instance;

            return InvokeAsync<InviteMembersRequest,InviteMembersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDetectors

        internal virtual ListDetectorsResponse ListDetectors(ListDetectorsRequest request)
        {
            var marshaller = ListDetectorsRequestMarshaller.Instance;
            var unmarshaller = ListDetectorsResponseUnmarshaller.Instance;

            return Invoke<ListDetectorsRequest,ListDetectorsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDetectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDetectors operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListDetectors">REST API Reference for ListDetectors Operation</seealso>
        public virtual Task<ListDetectorsResponse> ListDetectorsAsync(ListDetectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListDetectorsRequestMarshaller.Instance;
            var unmarshaller = ListDetectorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDetectorsRequest,ListDetectorsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListFilters

        internal virtual ListFiltersResponse ListFilters(ListFiltersRequest request)
        {
            var marshaller = ListFiltersRequestMarshaller.Instance;
            var unmarshaller = ListFiltersResponseUnmarshaller.Instance;

            return Invoke<ListFiltersRequest,ListFiltersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListFilters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFilters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListFilters">REST API Reference for ListFilters Operation</seealso>
        public virtual Task<ListFiltersResponse> ListFiltersAsync(ListFiltersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListFiltersRequestMarshaller.Instance;
            var unmarshaller = ListFiltersResponseUnmarshaller.Instance;

            return InvokeAsync<ListFiltersRequest,ListFiltersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListFindings

        internal virtual ListFindingsResponse ListFindings(ListFindingsRequest request)
        {
            var marshaller = ListFindingsRequestMarshaller.Instance;
            var unmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return Invoke<ListFindingsRequest,ListFindingsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFindings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListFindings">REST API Reference for ListFindings Operation</seealso>
        public virtual Task<ListFindingsResponse> ListFindingsAsync(ListFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListFindingsRequestMarshaller.Instance;
            var unmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFindingsRequest,ListFindingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListInvitations

        internal virtual ListInvitationsResponse ListInvitations(ListInvitationsRequest request)
        {
            var marshaller = ListInvitationsRequestMarshaller.Instance;
            var unmarshaller = ListInvitationsResponseUnmarshaller.Instance;

            return Invoke<ListInvitationsRequest,ListInvitationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        public virtual Task<ListInvitationsResponse> ListInvitationsAsync(ListInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListInvitationsRequestMarshaller.Instance;
            var unmarshaller = ListInvitationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListInvitationsRequest,ListInvitationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListIPSets

        internal virtual ListIPSetsResponse ListIPSets(ListIPSetsRequest request)
        {
            var marshaller = ListIPSetsRequestMarshaller.Instance;
            var unmarshaller = ListIPSetsResponseUnmarshaller.Instance;

            return Invoke<ListIPSetsRequest,ListIPSetsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListIPSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIPSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListIPSets">REST API Reference for ListIPSets Operation</seealso>
        public virtual Task<ListIPSetsResponse> ListIPSetsAsync(ListIPSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListIPSetsRequestMarshaller.Instance;
            var unmarshaller = ListIPSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListIPSetsRequest,ListIPSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListMembers

        internal virtual ListMembersResponse ListMembers(ListMembersRequest request)
        {
            var marshaller = ListMembersRequestMarshaller.Instance;
            var unmarshaller = ListMembersResponseUnmarshaller.Instance;

            return Invoke<ListMembersRequest,ListMembersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListMembers">REST API Reference for ListMembers Operation</seealso>
        public virtual Task<ListMembersResponse> ListMembersAsync(ListMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListMembersRequestMarshaller.Instance;
            var unmarshaller = ListMembersResponseUnmarshaller.Instance;

            return InvokeAsync<ListMembersRequest,ListMembersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListThreatIntelSets

        internal virtual ListThreatIntelSetsResponse ListThreatIntelSets(ListThreatIntelSetsRequest request)
        {
            var marshaller = ListThreatIntelSetsRequestMarshaller.Instance;
            var unmarshaller = ListThreatIntelSetsResponseUnmarshaller.Instance;

            return Invoke<ListThreatIntelSetsRequest,ListThreatIntelSetsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListThreatIntelSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThreatIntelSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListThreatIntelSets">REST API Reference for ListThreatIntelSets Operation</seealso>
        public virtual Task<ListThreatIntelSetsResponse> ListThreatIntelSetsAsync(ListThreatIntelSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListThreatIntelSetsRequestMarshaller.Instance;
            var unmarshaller = ListThreatIntelSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListThreatIntelSetsRequest,ListThreatIntelSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartMonitoringMembers

        internal virtual StartMonitoringMembersResponse StartMonitoringMembers(StartMonitoringMembersRequest request)
        {
            var marshaller = StartMonitoringMembersRequestMarshaller.Instance;
            var unmarshaller = StartMonitoringMembersResponseUnmarshaller.Instance;

            return Invoke<StartMonitoringMembersRequest,StartMonitoringMembersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartMonitoringMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMonitoringMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/StartMonitoringMembers">REST API Reference for StartMonitoringMembers Operation</seealso>
        public virtual Task<StartMonitoringMembersResponse> StartMonitoringMembersAsync(StartMonitoringMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartMonitoringMembersRequestMarshaller.Instance;
            var unmarshaller = StartMonitoringMembersResponseUnmarshaller.Instance;

            return InvokeAsync<StartMonitoringMembersRequest,StartMonitoringMembersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopMonitoringMembers

        internal virtual StopMonitoringMembersResponse StopMonitoringMembers(StopMonitoringMembersRequest request)
        {
            var marshaller = StopMonitoringMembersRequestMarshaller.Instance;
            var unmarshaller = StopMonitoringMembersResponseUnmarshaller.Instance;

            return Invoke<StopMonitoringMembersRequest,StopMonitoringMembersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopMonitoringMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopMonitoringMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/StopMonitoringMembers">REST API Reference for StopMonitoringMembers Operation</seealso>
        public virtual Task<StopMonitoringMembersResponse> StopMonitoringMembersAsync(StopMonitoringMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StopMonitoringMembersRequestMarshaller.Instance;
            var unmarshaller = StopMonitoringMembersResponseUnmarshaller.Instance;

            return InvokeAsync<StopMonitoringMembersRequest,StopMonitoringMembersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UnarchiveFindings

        internal virtual UnarchiveFindingsResponse UnarchiveFindings(UnarchiveFindingsRequest request)
        {
            var marshaller = UnarchiveFindingsRequestMarshaller.Instance;
            var unmarshaller = UnarchiveFindingsResponseUnmarshaller.Instance;

            return Invoke<UnarchiveFindingsRequest,UnarchiveFindingsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UnarchiveFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnarchiveFindings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UnarchiveFindings">REST API Reference for UnarchiveFindings Operation</seealso>
        public virtual Task<UnarchiveFindingsResponse> UnarchiveFindingsAsync(UnarchiveFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UnarchiveFindingsRequestMarshaller.Instance;
            var unmarshaller = UnarchiveFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<UnarchiveFindingsRequest,UnarchiveFindingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDetector

        internal virtual UpdateDetectorResponse UpdateDetector(UpdateDetectorRequest request)
        {
            var marshaller = UpdateDetectorRequestMarshaller.Instance;
            var unmarshaller = UpdateDetectorResponseUnmarshaller.Instance;

            return Invoke<UpdateDetectorRequest,UpdateDetectorResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetector operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateDetector">REST API Reference for UpdateDetector Operation</seealso>
        public virtual Task<UpdateDetectorResponse> UpdateDetectorAsync(UpdateDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateDetectorRequestMarshaller.Instance;
            var unmarshaller = UpdateDetectorResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDetectorRequest,UpdateDetectorResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateFilter

        internal virtual UpdateFilterResponse UpdateFilter(UpdateFilterRequest request)
        {
            var marshaller = UpdateFilterRequestMarshaller.Instance;
            var unmarshaller = UpdateFilterResponseUnmarshaller.Instance;

            return Invoke<UpdateFilterRequest,UpdateFilterResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFilter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateFilter">REST API Reference for UpdateFilter Operation</seealso>
        public virtual Task<UpdateFilterResponse> UpdateFilterAsync(UpdateFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateFilterRequestMarshaller.Instance;
            var unmarshaller = UpdateFilterResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFilterRequest,UpdateFilterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateFindingsFeedback

        internal virtual UpdateFindingsFeedbackResponse UpdateFindingsFeedback(UpdateFindingsFeedbackRequest request)
        {
            var marshaller = UpdateFindingsFeedbackRequestMarshaller.Instance;
            var unmarshaller = UpdateFindingsFeedbackResponseUnmarshaller.Instance;

            return Invoke<UpdateFindingsFeedbackRequest,UpdateFindingsFeedbackResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFindingsFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindingsFeedback operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateFindingsFeedback">REST API Reference for UpdateFindingsFeedback Operation</seealso>
        public virtual Task<UpdateFindingsFeedbackResponse> UpdateFindingsFeedbackAsync(UpdateFindingsFeedbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateFindingsFeedbackRequestMarshaller.Instance;
            var unmarshaller = UpdateFindingsFeedbackResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFindingsFeedbackRequest,UpdateFindingsFeedbackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateIPSet

        internal virtual UpdateIPSetResponse UpdateIPSet(UpdateIPSetRequest request)
        {
            var marshaller = UpdateIPSetRequestMarshaller.Instance;
            var unmarshaller = UpdateIPSetResponseUnmarshaller.Instance;

            return Invoke<UpdateIPSetRequest,UpdateIPSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIPSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        public virtual Task<UpdateIPSetResponse> UpdateIPSetAsync(UpdateIPSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateIPSetRequestMarshaller.Instance;
            var unmarshaller = UpdateIPSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIPSetRequest,UpdateIPSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateThreatIntelSet

        internal virtual UpdateThreatIntelSetResponse UpdateThreatIntelSet(UpdateThreatIntelSetRequest request)
        {
            var marshaller = UpdateThreatIntelSetRequestMarshaller.Instance;
            var unmarshaller = UpdateThreatIntelSetResponseUnmarshaller.Instance;

            return Invoke<UpdateThreatIntelSetRequest,UpdateThreatIntelSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateThreatIntelSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateThreatIntelSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateThreatIntelSet">REST API Reference for UpdateThreatIntelSet Operation</seealso>
        public virtual Task<UpdateThreatIntelSetResponse> UpdateThreatIntelSetAsync(UpdateThreatIntelSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateThreatIntelSetRequestMarshaller.Instance;
            var unmarshaller = UpdateThreatIntelSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateThreatIntelSetRequest,UpdateThreatIntelSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}