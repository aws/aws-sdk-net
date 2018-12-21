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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MTurk.Model;
using Amazon.MTurk.Model.Internal.MarshallTransformations;
using Amazon.MTurk.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.MTurk
{
    /// <summary>
    /// Implementation for accessing MTurk
    ///
    /// Amazon Mechanical Turk API Reference
    /// </summary>
    public partial class AmazonMTurkClient : AmazonServiceClient, IAmazonMTurk
    {
        private static IServiceMetadata serviceMetadata = new AmazonMTurkMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonMTurkClient with the credentials loaded from the application's
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
        public AmazonMTurkClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMTurkConfig()) { }

        /// <summary>
        /// Constructs AmazonMTurkClient with the credentials loaded from the application's
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
        public AmazonMTurkClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMTurkConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMTurkClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMTurkClient Configuration Object</param>
        public AmazonMTurkClient(AmazonMTurkConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonMTurkClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMTurkClient(AWSCredentials credentials)
            : this(credentials, new AmazonMTurkConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMTurkClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMTurkClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMTurkConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMTurkClient with AWS Credentials and an
        /// AmazonMTurkClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMTurkClient Configuration Object</param>
        public AmazonMTurkClient(AWSCredentials credentials, AmazonMTurkConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMTurkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMTurkClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMTurkConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMTurkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMTurkClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMTurkConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMTurkClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMTurkClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMTurkClient Configuration Object</param>
        public AmazonMTurkClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMTurkConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMTurkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMTurkClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMTurkConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMTurkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMTurkClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMTurkConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMTurkClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMTurkClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMTurkClient Configuration Object</param>
        public AmazonMTurkClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMTurkConfig clientConfig)
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


        #region  AcceptQualificationRequest

        internal virtual AcceptQualificationRequestResponse AcceptQualificationRequest(AcceptQualificationRequestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptQualificationRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptQualificationRequestResponseUnmarshaller.Instance;

            return Invoke<AcceptQualificationRequestResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AcceptQualificationRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptQualificationRequest operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/AcceptQualificationRequest">REST API Reference for AcceptQualificationRequest Operation</seealso>
        public virtual Task<AcceptQualificationRequestResponse> AcceptQualificationRequestAsync(AcceptQualificationRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptQualificationRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptQualificationRequestResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptQualificationRequestResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ApproveAssignment

        internal virtual ApproveAssignmentResponse ApproveAssignment(ApproveAssignmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ApproveAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApproveAssignmentResponseUnmarshaller.Instance;

            return Invoke<ApproveAssignmentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ApproveAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApproveAssignment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ApproveAssignment">REST API Reference for ApproveAssignment Operation</seealso>
        public virtual Task<ApproveAssignmentResponse> ApproveAssignmentAsync(ApproveAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ApproveAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApproveAssignmentResponseUnmarshaller.Instance;

            return InvokeAsync<ApproveAssignmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateQualificationWithWorker

        internal virtual AssociateQualificationWithWorkerResponse AssociateQualificationWithWorker(AssociateQualificationWithWorkerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateQualificationWithWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateQualificationWithWorkerResponseUnmarshaller.Instance;

            return Invoke<AssociateQualificationWithWorkerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateQualificationWithWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateQualificationWithWorker operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/AssociateQualificationWithWorker">REST API Reference for AssociateQualificationWithWorker Operation</seealso>
        public virtual Task<AssociateQualificationWithWorkerResponse> AssociateQualificationWithWorkerAsync(AssociateQualificationWithWorkerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateQualificationWithWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateQualificationWithWorkerResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateQualificationWithWorkerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAdditionalAssignmentsForHIT

        internal virtual CreateAdditionalAssignmentsForHITResponse CreateAdditionalAssignmentsForHIT(CreateAdditionalAssignmentsForHITRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAdditionalAssignmentsForHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAdditionalAssignmentsForHITResponseUnmarshaller.Instance;

            return Invoke<CreateAdditionalAssignmentsForHITResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAdditionalAssignmentsForHIT operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAdditionalAssignmentsForHIT operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateAdditionalAssignmentsForHIT">REST API Reference for CreateAdditionalAssignmentsForHIT Operation</seealso>
        public virtual Task<CreateAdditionalAssignmentsForHITResponse> CreateAdditionalAssignmentsForHITAsync(CreateAdditionalAssignmentsForHITRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAdditionalAssignmentsForHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAdditionalAssignmentsForHITResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAdditionalAssignmentsForHITResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateHIT

        internal virtual CreateHITResponse CreateHIT(CreateHITRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHITResponseUnmarshaller.Instance;

            return Invoke<CreateHITResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateHIT operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHIT operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateHIT">REST API Reference for CreateHIT Operation</seealso>
        public virtual Task<CreateHITResponse> CreateHITAsync(CreateHITRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHITResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHITResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateHITType

        internal virtual CreateHITTypeResponse CreateHITType(CreateHITTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHITTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHITTypeResponseUnmarshaller.Instance;

            return Invoke<CreateHITTypeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateHITType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHITType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateHITType">REST API Reference for CreateHITType Operation</seealso>
        public virtual Task<CreateHITTypeResponse> CreateHITTypeAsync(CreateHITTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHITTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHITTypeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHITTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateHITWithHITType

        internal virtual CreateHITWithHITTypeResponse CreateHITWithHITType(CreateHITWithHITTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHITWithHITTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHITWithHITTypeResponseUnmarshaller.Instance;

            return Invoke<CreateHITWithHITTypeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateHITWithHITType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHITWithHITType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateHITWithHITType">REST API Reference for CreateHITWithHITType Operation</seealso>
        public virtual Task<CreateHITWithHITTypeResponse> CreateHITWithHITTypeAsync(CreateHITWithHITTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHITWithHITTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHITWithHITTypeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHITWithHITTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateQualificationType

        internal virtual CreateQualificationTypeResponse CreateQualificationType(CreateQualificationTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateQualificationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQualificationTypeResponseUnmarshaller.Instance;

            return Invoke<CreateQualificationTypeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateQualificationType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateQualificationType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateQualificationType">REST API Reference for CreateQualificationType Operation</seealso>
        public virtual Task<CreateQualificationTypeResponse> CreateQualificationTypeAsync(CreateQualificationTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateQualificationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQualificationTypeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateQualificationTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWorkerBlock

        internal virtual CreateWorkerBlockResponse CreateWorkerBlock(CreateWorkerBlockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkerBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkerBlockResponseUnmarshaller.Instance;

            return Invoke<CreateWorkerBlockResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkerBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkerBlock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateWorkerBlock">REST API Reference for CreateWorkerBlock Operation</seealso>
        public virtual Task<CreateWorkerBlockResponse> CreateWorkerBlockAsync(CreateWorkerBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkerBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkerBlockResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWorkerBlockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteHIT

        internal virtual DeleteHITResponse DeleteHIT(DeleteHITRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHITResponseUnmarshaller.Instance;

            return Invoke<DeleteHITResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHIT operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHIT operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/DeleteHIT">REST API Reference for DeleteHIT Operation</seealso>
        public virtual Task<DeleteHITResponse> DeleteHITAsync(DeleteHITRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHITResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHITResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteQualificationType

        internal virtual DeleteQualificationTypeResponse DeleteQualificationType(DeleteQualificationTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteQualificationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQualificationTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteQualificationTypeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteQualificationType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQualificationType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/DeleteQualificationType">REST API Reference for DeleteQualificationType Operation</seealso>
        public virtual Task<DeleteQualificationTypeResponse> DeleteQualificationTypeAsync(DeleteQualificationTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteQualificationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQualificationTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteQualificationTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWorkerBlock

        internal virtual DeleteWorkerBlockResponse DeleteWorkerBlock(DeleteWorkerBlockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkerBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkerBlockResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkerBlockResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkerBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkerBlock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/DeleteWorkerBlock">REST API Reference for DeleteWorkerBlock Operation</seealso>
        public virtual Task<DeleteWorkerBlockResponse> DeleteWorkerBlockAsync(DeleteWorkerBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkerBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkerBlockResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWorkerBlockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateQualificationFromWorker

        internal virtual DisassociateQualificationFromWorkerResponse DisassociateQualificationFromWorker(DisassociateQualificationFromWorkerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateQualificationFromWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateQualificationFromWorkerResponseUnmarshaller.Instance;

            return Invoke<DisassociateQualificationFromWorkerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateQualificationFromWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateQualificationFromWorker operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/DisassociateQualificationFromWorker">REST API Reference for DisassociateQualificationFromWorker Operation</seealso>
        public virtual Task<DisassociateQualificationFromWorkerResponse> DisassociateQualificationFromWorkerAsync(DisassociateQualificationFromWorkerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateQualificationFromWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateQualificationFromWorkerResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateQualificationFromWorkerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccountBalance

        internal virtual GetAccountBalanceResponse GetAccountBalance(GetAccountBalanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountBalanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountBalanceResponseUnmarshaller.Instance;

            return Invoke<GetAccountBalanceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountBalance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountBalance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetAccountBalance">REST API Reference for GetAccountBalance Operation</seealso>
        public virtual Task<GetAccountBalanceResponse> GetAccountBalanceAsync(GetAccountBalanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountBalanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountBalanceResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountBalanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAssignment

        internal virtual GetAssignmentResponse GetAssignment(GetAssignmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssignmentResponseUnmarshaller.Instance;

            return Invoke<GetAssignmentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssignment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetAssignment">REST API Reference for GetAssignment Operation</seealso>
        public virtual Task<GetAssignmentResponse> GetAssignmentAsync(GetAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssignmentResponseUnmarshaller.Instance;

            return InvokeAsync<GetAssignmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFileUploadURL

        internal virtual GetFileUploadURLResponse GetFileUploadURL(GetFileUploadURLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFileUploadURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFileUploadURLResponseUnmarshaller.Instance;

            return Invoke<GetFileUploadURLResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetFileUploadURL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFileUploadURL operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetFileUploadURL">REST API Reference for GetFileUploadURL Operation</seealso>
        public virtual Task<GetFileUploadURLResponse> GetFileUploadURLAsync(GetFileUploadURLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFileUploadURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFileUploadURLResponseUnmarshaller.Instance;

            return InvokeAsync<GetFileUploadURLResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetHIT

        internal virtual GetHITResponse GetHIT(GetHITRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHITResponseUnmarshaller.Instance;

            return Invoke<GetHITResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetHIT operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHIT operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetHIT">REST API Reference for GetHIT Operation</seealso>
        public virtual Task<GetHITResponse> GetHITAsync(GetHITRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHITResponseUnmarshaller.Instance;

            return InvokeAsync<GetHITResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetQualificationScore

        internal virtual GetQualificationScoreResponse GetQualificationScore(GetQualificationScoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQualificationScoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQualificationScoreResponseUnmarshaller.Instance;

            return Invoke<GetQualificationScoreResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetQualificationScore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQualificationScore operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetQualificationScore">REST API Reference for GetQualificationScore Operation</seealso>
        public virtual Task<GetQualificationScoreResponse> GetQualificationScoreAsync(GetQualificationScoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQualificationScoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQualificationScoreResponseUnmarshaller.Instance;

            return InvokeAsync<GetQualificationScoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetQualificationType

        internal virtual GetQualificationTypeResponse GetQualificationType(GetQualificationTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQualificationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQualificationTypeResponseUnmarshaller.Instance;

            return Invoke<GetQualificationTypeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetQualificationType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQualificationType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetQualificationType">REST API Reference for GetQualificationType Operation</seealso>
        public virtual Task<GetQualificationTypeResponse> GetQualificationTypeAsync(GetQualificationTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQualificationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQualificationTypeResponseUnmarshaller.Instance;

            return InvokeAsync<GetQualificationTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAssignmentsForHIT

        internal virtual ListAssignmentsForHITResponse ListAssignmentsForHIT(ListAssignmentsForHITRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssignmentsForHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssignmentsForHITResponseUnmarshaller.Instance;

            return Invoke<ListAssignmentsForHITResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAssignmentsForHIT operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssignmentsForHIT operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListAssignmentsForHIT">REST API Reference for ListAssignmentsForHIT Operation</seealso>
        public virtual Task<ListAssignmentsForHITResponse> ListAssignmentsForHITAsync(ListAssignmentsForHITRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssignmentsForHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssignmentsForHITResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssignmentsForHITResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBonusPayments

        internal virtual ListBonusPaymentsResponse ListBonusPayments(ListBonusPaymentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBonusPaymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBonusPaymentsResponseUnmarshaller.Instance;

            return Invoke<ListBonusPaymentsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListBonusPayments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBonusPayments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListBonusPayments">REST API Reference for ListBonusPayments Operation</seealso>
        public virtual Task<ListBonusPaymentsResponse> ListBonusPaymentsAsync(ListBonusPaymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBonusPaymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBonusPaymentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBonusPaymentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListHITs

        internal virtual ListHITsResponse ListHITs(ListHITsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHITsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHITsResponseUnmarshaller.Instance;

            return Invoke<ListHITsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListHITs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHITs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListHITs">REST API Reference for ListHITs Operation</seealso>
        public virtual Task<ListHITsResponse> ListHITsAsync(ListHITsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHITsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHITsResponseUnmarshaller.Instance;

            return InvokeAsync<ListHITsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListHITsForQualificationType

        internal virtual ListHITsForQualificationTypeResponse ListHITsForQualificationType(ListHITsForQualificationTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHITsForQualificationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHITsForQualificationTypeResponseUnmarshaller.Instance;

            return Invoke<ListHITsForQualificationTypeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListHITsForQualificationType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHITsForQualificationType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListHITsForQualificationType">REST API Reference for ListHITsForQualificationType Operation</seealso>
        public virtual Task<ListHITsForQualificationTypeResponse> ListHITsForQualificationTypeAsync(ListHITsForQualificationTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHITsForQualificationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHITsForQualificationTypeResponseUnmarshaller.Instance;

            return InvokeAsync<ListHITsForQualificationTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListQualificationRequests

        internal virtual ListQualificationRequestsResponse ListQualificationRequests(ListQualificationRequestsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQualificationRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQualificationRequestsResponseUnmarshaller.Instance;

            return Invoke<ListQualificationRequestsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListQualificationRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQualificationRequests operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListQualificationRequests">REST API Reference for ListQualificationRequests Operation</seealso>
        public virtual Task<ListQualificationRequestsResponse> ListQualificationRequestsAsync(ListQualificationRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQualificationRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQualificationRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<ListQualificationRequestsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListQualificationTypes

        internal virtual ListQualificationTypesResponse ListQualificationTypes(ListQualificationTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQualificationTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQualificationTypesResponseUnmarshaller.Instance;

            return Invoke<ListQualificationTypesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListQualificationTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQualificationTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListQualificationTypes">REST API Reference for ListQualificationTypes Operation</seealso>
        public virtual Task<ListQualificationTypesResponse> ListQualificationTypesAsync(ListQualificationTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQualificationTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQualificationTypesResponseUnmarshaller.Instance;

            return InvokeAsync<ListQualificationTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListReviewableHITs

        internal virtual ListReviewableHITsResponse ListReviewableHITs(ListReviewableHITsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReviewableHITsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReviewableHITsResponseUnmarshaller.Instance;

            return Invoke<ListReviewableHITsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListReviewableHITs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReviewableHITs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListReviewableHITs">REST API Reference for ListReviewableHITs Operation</seealso>
        public virtual Task<ListReviewableHITsResponse> ListReviewableHITsAsync(ListReviewableHITsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReviewableHITsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReviewableHITsResponseUnmarshaller.Instance;

            return InvokeAsync<ListReviewableHITsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListReviewPolicyResultsForHIT

        internal virtual ListReviewPolicyResultsForHITResponse ListReviewPolicyResultsForHIT(ListReviewPolicyResultsForHITRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReviewPolicyResultsForHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReviewPolicyResultsForHITResponseUnmarshaller.Instance;

            return Invoke<ListReviewPolicyResultsForHITResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListReviewPolicyResultsForHIT operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReviewPolicyResultsForHIT operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListReviewPolicyResultsForHIT">REST API Reference for ListReviewPolicyResultsForHIT Operation</seealso>
        public virtual Task<ListReviewPolicyResultsForHITResponse> ListReviewPolicyResultsForHITAsync(ListReviewPolicyResultsForHITRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReviewPolicyResultsForHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReviewPolicyResultsForHITResponseUnmarshaller.Instance;

            return InvokeAsync<ListReviewPolicyResultsForHITResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWorkerBlocks

        internal virtual ListWorkerBlocksResponse ListWorkerBlocks(ListWorkerBlocksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkerBlocksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkerBlocksResponseUnmarshaller.Instance;

            return Invoke<ListWorkerBlocksResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkerBlocks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkerBlocks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListWorkerBlocks">REST API Reference for ListWorkerBlocks Operation</seealso>
        public virtual Task<ListWorkerBlocksResponse> ListWorkerBlocksAsync(ListWorkerBlocksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkerBlocksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkerBlocksResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkerBlocksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWorkersWithQualificationType

        internal virtual ListWorkersWithQualificationTypeResponse ListWorkersWithQualificationType(ListWorkersWithQualificationTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkersWithQualificationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkersWithQualificationTypeResponseUnmarshaller.Instance;

            return Invoke<ListWorkersWithQualificationTypeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkersWithQualificationType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkersWithQualificationType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListWorkersWithQualificationType">REST API Reference for ListWorkersWithQualificationType Operation</seealso>
        public virtual Task<ListWorkersWithQualificationTypeResponse> ListWorkersWithQualificationTypeAsync(ListWorkersWithQualificationTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkersWithQualificationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkersWithQualificationTypeResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkersWithQualificationTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  NotifyWorkers

        internal virtual NotifyWorkersResponse NotifyWorkers(NotifyWorkersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = NotifyWorkersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NotifyWorkersResponseUnmarshaller.Instance;

            return Invoke<NotifyWorkersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the NotifyWorkers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NotifyWorkers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/NotifyWorkers">REST API Reference for NotifyWorkers Operation</seealso>
        public virtual Task<NotifyWorkersResponse> NotifyWorkersAsync(NotifyWorkersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = NotifyWorkersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NotifyWorkersResponseUnmarshaller.Instance;

            return InvokeAsync<NotifyWorkersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectAssignment

        internal virtual RejectAssignmentResponse RejectAssignment(RejectAssignmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectAssignmentResponseUnmarshaller.Instance;

            return Invoke<RejectAssignmentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RejectAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectAssignment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/RejectAssignment">REST API Reference for RejectAssignment Operation</seealso>
        public virtual Task<RejectAssignmentResponse> RejectAssignmentAsync(RejectAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectAssignmentResponseUnmarshaller.Instance;

            return InvokeAsync<RejectAssignmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectQualificationRequest

        internal virtual RejectQualificationRequestResponse RejectQualificationRequest(RejectQualificationRequestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectQualificationRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectQualificationRequestResponseUnmarshaller.Instance;

            return Invoke<RejectQualificationRequestResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RejectQualificationRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectQualificationRequest operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/RejectQualificationRequest">REST API Reference for RejectQualificationRequest Operation</seealso>
        public virtual Task<RejectQualificationRequestResponse> RejectQualificationRequestAsync(RejectQualificationRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectQualificationRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectQualificationRequestResponseUnmarshaller.Instance;

            return InvokeAsync<RejectQualificationRequestResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendBonus

        internal virtual SendBonusResponse SendBonus(SendBonusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendBonusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendBonusResponseUnmarshaller.Instance;

            return Invoke<SendBonusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SendBonus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendBonus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/SendBonus">REST API Reference for SendBonus Operation</seealso>
        public virtual Task<SendBonusResponse> SendBonusAsync(SendBonusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendBonusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendBonusResponseUnmarshaller.Instance;

            return InvokeAsync<SendBonusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendTestEventNotification

        internal virtual SendTestEventNotificationResponse SendTestEventNotification(SendTestEventNotificationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendTestEventNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendTestEventNotificationResponseUnmarshaller.Instance;

            return Invoke<SendTestEventNotificationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SendTestEventNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendTestEventNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/SendTestEventNotification">REST API Reference for SendTestEventNotification Operation</seealso>
        public virtual Task<SendTestEventNotificationResponse> SendTestEventNotificationAsync(SendTestEventNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendTestEventNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendTestEventNotificationResponseUnmarshaller.Instance;

            return InvokeAsync<SendTestEventNotificationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateExpirationForHIT

        internal virtual UpdateExpirationForHITResponse UpdateExpirationForHIT(UpdateExpirationForHITRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateExpirationForHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExpirationForHITResponseUnmarshaller.Instance;

            return Invoke<UpdateExpirationForHITResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateExpirationForHIT operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateExpirationForHIT operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateExpirationForHIT">REST API Reference for UpdateExpirationForHIT Operation</seealso>
        public virtual Task<UpdateExpirationForHITResponse> UpdateExpirationForHITAsync(UpdateExpirationForHITRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateExpirationForHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExpirationForHITResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateExpirationForHITResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateHITReviewStatus

        internal virtual UpdateHITReviewStatusResponse UpdateHITReviewStatus(UpdateHITReviewStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateHITReviewStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHITReviewStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateHITReviewStatusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHITReviewStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHITReviewStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateHITReviewStatus">REST API Reference for UpdateHITReviewStatus Operation</seealso>
        public virtual Task<UpdateHITReviewStatusResponse> UpdateHITReviewStatusAsync(UpdateHITReviewStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateHITReviewStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHITReviewStatusResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateHITReviewStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateHITTypeOfHIT

        internal virtual UpdateHITTypeOfHITResponse UpdateHITTypeOfHIT(UpdateHITTypeOfHITRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateHITTypeOfHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHITTypeOfHITResponseUnmarshaller.Instance;

            return Invoke<UpdateHITTypeOfHITResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHITTypeOfHIT operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHITTypeOfHIT operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateHITTypeOfHIT">REST API Reference for UpdateHITTypeOfHIT Operation</seealso>
        public virtual Task<UpdateHITTypeOfHITResponse> UpdateHITTypeOfHITAsync(UpdateHITTypeOfHITRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateHITTypeOfHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHITTypeOfHITResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateHITTypeOfHITResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateNotificationSettings

        internal virtual UpdateNotificationSettingsResponse UpdateNotificationSettings(UpdateNotificationSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotificationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotificationSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateNotificationSettingsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNotificationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotificationSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateNotificationSettings">REST API Reference for UpdateNotificationSettings Operation</seealso>
        public virtual Task<UpdateNotificationSettingsResponse> UpdateNotificationSettingsAsync(UpdateNotificationSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotificationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotificationSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNotificationSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateQualificationType

        internal virtual UpdateQualificationTypeResponse UpdateQualificationType(UpdateQualificationTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQualificationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQualificationTypeResponseUnmarshaller.Instance;

            return Invoke<UpdateQualificationTypeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQualificationType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQualificationType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateQualificationType">REST API Reference for UpdateQualificationType Operation</seealso>
        public virtual Task<UpdateQualificationTypeResponse> UpdateQualificationTypeAsync(UpdateQualificationTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQualificationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQualificationTypeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateQualificationTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}