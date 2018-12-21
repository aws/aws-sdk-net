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
using System.Net;

using Amazon.GuardDuty.Model;
using Amazon.GuardDuty.Model.Internal.MarshallTransformations;
using Amazon.GuardDuty.Internal;
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
        private static IServiceMetadata serviceMetadata = new AmazonGuardDutyMetadata();
        
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


        #region  AcceptInvitation

        internal virtual AcceptInvitationResponse AcceptInvitation(AcceptInvitationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptInvitationResponseUnmarshaller.Instance;

            return Invoke<AcceptInvitationResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptInvitationResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptInvitationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ArchiveFindings

        internal virtual ArchiveFindingsResponse ArchiveFindings(ArchiveFindingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ArchiveFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ArchiveFindingsResponseUnmarshaller.Instance;

            return Invoke<ArchiveFindingsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ArchiveFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ArchiveFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<ArchiveFindingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDetector

        internal virtual CreateDetectorResponse CreateDetector(CreateDetectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDetectorResponseUnmarshaller.Instance;

            return Invoke<CreateDetectorResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDetectorResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDetectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFilter

        internal virtual CreateFilterResponse CreateFilter(CreateFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFilterResponseUnmarshaller.Instance;

            return Invoke<CreateFilterResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFilterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFilterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateIPSet

        internal virtual CreateIPSetResponse CreateIPSet(CreateIPSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIPSetResponseUnmarshaller.Instance;

            return Invoke<CreateIPSetResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIPSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIPSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMembers

        internal virtual CreateMembersResponse CreateMembers(CreateMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMembersResponseUnmarshaller.Instance;

            return Invoke<CreateMembersResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMembersResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSampleFindings

        internal virtual CreateSampleFindingsResponse CreateSampleFindings(CreateSampleFindingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSampleFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSampleFindingsResponseUnmarshaller.Instance;

            return Invoke<CreateSampleFindingsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSampleFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSampleFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSampleFindingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateThreatIntelSet

        internal virtual CreateThreatIntelSetResponse CreateThreatIntelSet(CreateThreatIntelSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateThreatIntelSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThreatIntelSetResponseUnmarshaller.Instance;

            return Invoke<CreateThreatIntelSetResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateThreatIntelSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThreatIntelSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateThreatIntelSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeclineInvitations

        internal virtual DeclineInvitationsResponse DeclineInvitations(DeclineInvitationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeclineInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeclineInvitationsResponseUnmarshaller.Instance;

            return Invoke<DeclineInvitationsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeclineInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeclineInvitationsResponseUnmarshaller.Instance;

            return InvokeAsync<DeclineInvitationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDetector

        internal virtual DeleteDetectorResponse DeleteDetector(DeleteDetectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDetectorResponseUnmarshaller.Instance;

            return Invoke<DeleteDetectorResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDetectorResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDetectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFilter

        internal virtual DeleteFilterResponse DeleteFilter(DeleteFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFilterResponseUnmarshaller.Instance;

            return Invoke<DeleteFilterResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFilterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFilterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInvitations

        internal virtual DeleteInvitationsResponse DeleteInvitations(DeleteInvitationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInvitationsResponseUnmarshaller.Instance;

            return Invoke<DeleteInvitationsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInvitationsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInvitationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteIPSet

        internal virtual DeleteIPSetResponse DeleteIPSet(DeleteIPSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIPSetResponseUnmarshaller.Instance;

            return Invoke<DeleteIPSetResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIPSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIPSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMembers

        internal virtual DeleteMembersResponse DeleteMembers(DeleteMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMembersResponseUnmarshaller.Instance;

            return Invoke<DeleteMembersResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMembersResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteThreatIntelSet

        internal virtual DeleteThreatIntelSetResponse DeleteThreatIntelSet(DeleteThreatIntelSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThreatIntelSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThreatIntelSetResponseUnmarshaller.Instance;

            return Invoke<DeleteThreatIntelSetResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThreatIntelSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThreatIntelSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteThreatIntelSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateFromMasterAccount

        internal virtual DisassociateFromMasterAccountResponse DisassociateFromMasterAccount(DisassociateFromMasterAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateFromMasterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFromMasterAccountResponseUnmarshaller.Instance;

            return Invoke<DisassociateFromMasterAccountResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateFromMasterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFromMasterAccountResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateFromMasterAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateMembers

        internal virtual DisassociateMembersResponse DisassociateMembers(DisassociateMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMembersResponseUnmarshaller.Instance;

            return Invoke<DisassociateMembersResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMembersResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDetector

        internal virtual GetDetectorResponse GetDetector(GetDetectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDetectorResponseUnmarshaller.Instance;

            return Invoke<GetDetectorResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDetectorResponseUnmarshaller.Instance;

            return InvokeAsync<GetDetectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFilter

        internal virtual GetFilterResponse GetFilter(GetFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFilterResponseUnmarshaller.Instance;

            return Invoke<GetFilterResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFilterResponseUnmarshaller.Instance;

            return InvokeAsync<GetFilterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFindings

        internal virtual GetFindingsResponse GetFindings(GetFindingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingsResponseUnmarshaller.Instance;

            return Invoke<GetFindingsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetFindingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFindingsStatistics

        internal virtual GetFindingsStatisticsResponse GetFindingsStatistics(GetFindingsStatisticsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFindingsStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingsStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetFindingsStatisticsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFindingsStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingsStatisticsResponseUnmarshaller.Instance;

            return InvokeAsync<GetFindingsStatisticsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInvitationsCount

        internal virtual GetInvitationsCountResponse GetInvitationsCount(GetInvitationsCountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInvitationsCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvitationsCountResponseUnmarshaller.Instance;

            return Invoke<GetInvitationsCountResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInvitationsCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvitationsCountResponseUnmarshaller.Instance;

            return InvokeAsync<GetInvitationsCountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIPSet

        internal virtual GetIPSetResponse GetIPSet(GetIPSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIPSetResponseUnmarshaller.Instance;

            return Invoke<GetIPSetResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIPSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetIPSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMasterAccount

        internal virtual GetMasterAccountResponse GetMasterAccount(GetMasterAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMasterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMasterAccountResponseUnmarshaller.Instance;

            return Invoke<GetMasterAccountResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMasterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMasterAccountResponseUnmarshaller.Instance;

            return InvokeAsync<GetMasterAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMembers

        internal virtual GetMembersResponse GetMembers(GetMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMembersResponseUnmarshaller.Instance;

            return Invoke<GetMembersResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMembersResponseUnmarshaller.Instance;

            return InvokeAsync<GetMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetThreatIntelSet

        internal virtual GetThreatIntelSetResponse GetThreatIntelSet(GetThreatIntelSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetThreatIntelSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetThreatIntelSetResponseUnmarshaller.Instance;

            return Invoke<GetThreatIntelSetResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetThreatIntelSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetThreatIntelSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetThreatIntelSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InviteMembers

        internal virtual InviteMembersResponse InviteMembers(InviteMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InviteMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InviteMembersResponseUnmarshaller.Instance;

            return Invoke<InviteMembersResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = InviteMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InviteMembersResponseUnmarshaller.Instance;

            return InvokeAsync<InviteMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDetectors

        internal virtual ListDetectorsResponse ListDetectors(ListDetectorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDetectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDetectorsResponseUnmarshaller.Instance;

            return Invoke<ListDetectorsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDetectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDetectorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDetectorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFilters

        internal virtual ListFiltersResponse ListFilters(ListFiltersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFiltersResponseUnmarshaller.Instance;

            return Invoke<ListFiltersResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFiltersResponseUnmarshaller.Instance;

            return InvokeAsync<ListFiltersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFindings

        internal virtual ListFindingsResponse ListFindings(ListFindingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return Invoke<ListFindingsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFindingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInvitations

        internal virtual ListInvitationsResponse ListInvitations(ListInvitationsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        public virtual Task<ListInvitationsResponse> ListInvitationsAsync(ListInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvitationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListInvitationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListIPSets

        internal virtual ListIPSetsResponse ListIPSets(ListIPSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIPSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIPSetsResponseUnmarshaller.Instance;

            return Invoke<ListIPSetsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIPSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIPSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListIPSetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMembers

        internal virtual ListMembersResponse ListMembers(ListMembersRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListMembers">REST API Reference for ListMembers Operation</seealso>
        public virtual Task<ListMembersResponse> ListMembersAsync(ListMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembersResponseUnmarshaller.Instance;

            return InvokeAsync<ListMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListThreatIntelSets

        internal virtual ListThreatIntelSetsResponse ListThreatIntelSets(ListThreatIntelSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThreatIntelSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThreatIntelSetsResponseUnmarshaller.Instance;

            return Invoke<ListThreatIntelSetsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThreatIntelSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThreatIntelSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListThreatIntelSetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartMonitoringMembers

        internal virtual StartMonitoringMembersResponse StartMonitoringMembers(StartMonitoringMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMonitoringMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMonitoringMembersResponseUnmarshaller.Instance;

            return Invoke<StartMonitoringMembersResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMonitoringMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMonitoringMembersResponseUnmarshaller.Instance;

            return InvokeAsync<StartMonitoringMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopMonitoringMembers

        internal virtual StopMonitoringMembersResponse StopMonitoringMembers(StopMonitoringMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopMonitoringMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopMonitoringMembersResponseUnmarshaller.Instance;

            return Invoke<StopMonitoringMembersResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StopMonitoringMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopMonitoringMembersResponseUnmarshaller.Instance;

            return InvokeAsync<StopMonitoringMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UnarchiveFindings

        internal virtual UnarchiveFindingsResponse UnarchiveFindings(UnarchiveFindingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnarchiveFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnarchiveFindingsResponseUnmarshaller.Instance;

            return Invoke<UnarchiveFindingsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UnarchiveFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnarchiveFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<UnarchiveFindingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDetector

        internal virtual UpdateDetectorResponse UpdateDetector(UpdateDetectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDetectorResponseUnmarshaller.Instance;

            return Invoke<UpdateDetectorResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDetectorResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDetectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFilter

        internal virtual UpdateFilterResponse UpdateFilter(UpdateFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFilterResponseUnmarshaller.Instance;

            return Invoke<UpdateFilterResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFilterResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFilterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFindingsFeedback

        internal virtual UpdateFindingsFeedbackResponse UpdateFindingsFeedback(UpdateFindingsFeedbackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFindingsFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFindingsFeedbackResponseUnmarshaller.Instance;

            return Invoke<UpdateFindingsFeedbackResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFindingsFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFindingsFeedbackResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFindingsFeedbackResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateIPSet

        internal virtual UpdateIPSetResponse UpdateIPSet(UpdateIPSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIPSetResponseUnmarshaller.Instance;

            return Invoke<UpdateIPSetResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIPSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIPSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateThreatIntelSet

        internal virtual UpdateThreatIntelSetResponse UpdateThreatIntelSet(UpdateThreatIntelSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThreatIntelSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThreatIntelSetResponseUnmarshaller.Instance;

            return Invoke<UpdateThreatIntelSetResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThreatIntelSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThreatIntelSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateThreatIntelSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}