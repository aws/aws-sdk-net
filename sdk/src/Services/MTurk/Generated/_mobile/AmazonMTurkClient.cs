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

using Amazon.MTurk.Model;
using Amazon.MTurk.Model.Internal.MarshallTransformations;
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
            var marshaller = AcceptQualificationRequestRequestMarshaller.Instance;
            var unmarshaller = AcceptQualificationRequestResponseUnmarshaller.Instance;

            return Invoke<AcceptQualificationRequestRequest,AcceptQualificationRequestResponse>(request, marshaller, unmarshaller);
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
            var marshaller = AcceptQualificationRequestRequestMarshaller.Instance;
            var unmarshaller = AcceptQualificationRequestResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptQualificationRequestRequest,AcceptQualificationRequestResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ApproveAssignment

        internal virtual ApproveAssignmentResponse ApproveAssignment(ApproveAssignmentRequest request)
        {
            var marshaller = ApproveAssignmentRequestMarshaller.Instance;
            var unmarshaller = ApproveAssignmentResponseUnmarshaller.Instance;

            return Invoke<ApproveAssignmentRequest,ApproveAssignmentResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ApproveAssignmentRequestMarshaller.Instance;
            var unmarshaller = ApproveAssignmentResponseUnmarshaller.Instance;

            return InvokeAsync<ApproveAssignmentRequest,ApproveAssignmentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateQualificationWithWorker

        internal virtual AssociateQualificationWithWorkerResponse AssociateQualificationWithWorker(AssociateQualificationWithWorkerRequest request)
        {
            var marshaller = AssociateQualificationWithWorkerRequestMarshaller.Instance;
            var unmarshaller = AssociateQualificationWithWorkerResponseUnmarshaller.Instance;

            return Invoke<AssociateQualificationWithWorkerRequest,AssociateQualificationWithWorkerResponse>(request, marshaller, unmarshaller);
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
            var marshaller = AssociateQualificationWithWorkerRequestMarshaller.Instance;
            var unmarshaller = AssociateQualificationWithWorkerResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateQualificationWithWorkerRequest,AssociateQualificationWithWorkerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateAdditionalAssignmentsForHIT

        internal virtual CreateAdditionalAssignmentsForHITResponse CreateAdditionalAssignmentsForHIT(CreateAdditionalAssignmentsForHITRequest request)
        {
            var marshaller = CreateAdditionalAssignmentsForHITRequestMarshaller.Instance;
            var unmarshaller = CreateAdditionalAssignmentsForHITResponseUnmarshaller.Instance;

            return Invoke<CreateAdditionalAssignmentsForHITRequest,CreateAdditionalAssignmentsForHITResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateAdditionalAssignmentsForHITRequestMarshaller.Instance;
            var unmarshaller = CreateAdditionalAssignmentsForHITResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAdditionalAssignmentsForHITRequest,CreateAdditionalAssignmentsForHITResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateHIT

        internal virtual CreateHITResponse CreateHIT(CreateHITRequest request)
        {
            var marshaller = CreateHITRequestMarshaller.Instance;
            var unmarshaller = CreateHITResponseUnmarshaller.Instance;

            return Invoke<CreateHITRequest,CreateHITResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateHITRequestMarshaller.Instance;
            var unmarshaller = CreateHITResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHITRequest,CreateHITResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateHITType

        internal virtual CreateHITTypeResponse CreateHITType(CreateHITTypeRequest request)
        {
            var marshaller = CreateHITTypeRequestMarshaller.Instance;
            var unmarshaller = CreateHITTypeResponseUnmarshaller.Instance;

            return Invoke<CreateHITTypeRequest,CreateHITTypeResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateHITTypeRequestMarshaller.Instance;
            var unmarshaller = CreateHITTypeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHITTypeRequest,CreateHITTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateHITWithHITType

        internal virtual CreateHITWithHITTypeResponse CreateHITWithHITType(CreateHITWithHITTypeRequest request)
        {
            var marshaller = CreateHITWithHITTypeRequestMarshaller.Instance;
            var unmarshaller = CreateHITWithHITTypeResponseUnmarshaller.Instance;

            return Invoke<CreateHITWithHITTypeRequest,CreateHITWithHITTypeResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateHITWithHITTypeRequestMarshaller.Instance;
            var unmarshaller = CreateHITWithHITTypeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHITWithHITTypeRequest,CreateHITWithHITTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateQualificationType

        internal virtual CreateQualificationTypeResponse CreateQualificationType(CreateQualificationTypeRequest request)
        {
            var marshaller = CreateQualificationTypeRequestMarshaller.Instance;
            var unmarshaller = CreateQualificationTypeResponseUnmarshaller.Instance;

            return Invoke<CreateQualificationTypeRequest,CreateQualificationTypeResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateQualificationTypeRequestMarshaller.Instance;
            var unmarshaller = CreateQualificationTypeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateQualificationTypeRequest,CreateQualificationTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateWorkerBlock

        internal virtual CreateWorkerBlockResponse CreateWorkerBlock(CreateWorkerBlockRequest request)
        {
            var marshaller = CreateWorkerBlockRequestMarshaller.Instance;
            var unmarshaller = CreateWorkerBlockResponseUnmarshaller.Instance;

            return Invoke<CreateWorkerBlockRequest,CreateWorkerBlockResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateWorkerBlockRequestMarshaller.Instance;
            var unmarshaller = CreateWorkerBlockResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWorkerBlockRequest,CreateWorkerBlockResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteHIT

        internal virtual DeleteHITResponse DeleteHIT(DeleteHITRequest request)
        {
            var marshaller = DeleteHITRequestMarshaller.Instance;
            var unmarshaller = DeleteHITResponseUnmarshaller.Instance;

            return Invoke<DeleteHITRequest,DeleteHITResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteHITRequestMarshaller.Instance;
            var unmarshaller = DeleteHITResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHITRequest,DeleteHITResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteQualificationType

        internal virtual DeleteQualificationTypeResponse DeleteQualificationType(DeleteQualificationTypeRequest request)
        {
            var marshaller = DeleteQualificationTypeRequestMarshaller.Instance;
            var unmarshaller = DeleteQualificationTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteQualificationTypeRequest,DeleteQualificationTypeResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteQualificationTypeRequestMarshaller.Instance;
            var unmarshaller = DeleteQualificationTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteQualificationTypeRequest,DeleteQualificationTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteWorkerBlock

        internal virtual DeleteWorkerBlockResponse DeleteWorkerBlock(DeleteWorkerBlockRequest request)
        {
            var marshaller = DeleteWorkerBlockRequestMarshaller.Instance;
            var unmarshaller = DeleteWorkerBlockResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkerBlockRequest,DeleteWorkerBlockResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteWorkerBlockRequestMarshaller.Instance;
            var unmarshaller = DeleteWorkerBlockResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWorkerBlockRequest,DeleteWorkerBlockResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateQualificationFromWorker

        internal virtual DisassociateQualificationFromWorkerResponse DisassociateQualificationFromWorker(DisassociateQualificationFromWorkerRequest request)
        {
            var marshaller = DisassociateQualificationFromWorkerRequestMarshaller.Instance;
            var unmarshaller = DisassociateQualificationFromWorkerResponseUnmarshaller.Instance;

            return Invoke<DisassociateQualificationFromWorkerRequest,DisassociateQualificationFromWorkerResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DisassociateQualificationFromWorkerRequestMarshaller.Instance;
            var unmarshaller = DisassociateQualificationFromWorkerResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateQualificationFromWorkerRequest,DisassociateQualificationFromWorkerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAccountBalance

        internal virtual GetAccountBalanceResponse GetAccountBalance(GetAccountBalanceRequest request)
        {
            var marshaller = GetAccountBalanceRequestMarshaller.Instance;
            var unmarshaller = GetAccountBalanceResponseUnmarshaller.Instance;

            return Invoke<GetAccountBalanceRequest,GetAccountBalanceResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetAccountBalanceRequestMarshaller.Instance;
            var unmarshaller = GetAccountBalanceResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountBalanceRequest,GetAccountBalanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAssignment

        internal virtual GetAssignmentResponse GetAssignment(GetAssignmentRequest request)
        {
            var marshaller = GetAssignmentRequestMarshaller.Instance;
            var unmarshaller = GetAssignmentResponseUnmarshaller.Instance;

            return Invoke<GetAssignmentRequest,GetAssignmentResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetAssignmentRequestMarshaller.Instance;
            var unmarshaller = GetAssignmentResponseUnmarshaller.Instance;

            return InvokeAsync<GetAssignmentRequest,GetAssignmentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetFileUploadURL

        internal virtual GetFileUploadURLResponse GetFileUploadURL(GetFileUploadURLRequest request)
        {
            var marshaller = GetFileUploadURLRequestMarshaller.Instance;
            var unmarshaller = GetFileUploadURLResponseUnmarshaller.Instance;

            return Invoke<GetFileUploadURLRequest,GetFileUploadURLResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetFileUploadURLRequestMarshaller.Instance;
            var unmarshaller = GetFileUploadURLResponseUnmarshaller.Instance;

            return InvokeAsync<GetFileUploadURLRequest,GetFileUploadURLResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetHIT

        internal virtual GetHITResponse GetHIT(GetHITRequest request)
        {
            var marshaller = GetHITRequestMarshaller.Instance;
            var unmarshaller = GetHITResponseUnmarshaller.Instance;

            return Invoke<GetHITRequest,GetHITResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetHITRequestMarshaller.Instance;
            var unmarshaller = GetHITResponseUnmarshaller.Instance;

            return InvokeAsync<GetHITRequest,GetHITResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetQualificationScore

        internal virtual GetQualificationScoreResponse GetQualificationScore(GetQualificationScoreRequest request)
        {
            var marshaller = GetQualificationScoreRequestMarshaller.Instance;
            var unmarshaller = GetQualificationScoreResponseUnmarshaller.Instance;

            return Invoke<GetQualificationScoreRequest,GetQualificationScoreResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetQualificationScoreRequestMarshaller.Instance;
            var unmarshaller = GetQualificationScoreResponseUnmarshaller.Instance;

            return InvokeAsync<GetQualificationScoreRequest,GetQualificationScoreResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetQualificationType

        internal virtual GetQualificationTypeResponse GetQualificationType(GetQualificationTypeRequest request)
        {
            var marshaller = GetQualificationTypeRequestMarshaller.Instance;
            var unmarshaller = GetQualificationTypeResponseUnmarshaller.Instance;

            return Invoke<GetQualificationTypeRequest,GetQualificationTypeResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetQualificationTypeRequestMarshaller.Instance;
            var unmarshaller = GetQualificationTypeResponseUnmarshaller.Instance;

            return InvokeAsync<GetQualificationTypeRequest,GetQualificationTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAssignmentsForHIT

        internal virtual ListAssignmentsForHITResponse ListAssignmentsForHIT(ListAssignmentsForHITRequest request)
        {
            var marshaller = ListAssignmentsForHITRequestMarshaller.Instance;
            var unmarshaller = ListAssignmentsForHITResponseUnmarshaller.Instance;

            return Invoke<ListAssignmentsForHITRequest,ListAssignmentsForHITResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListAssignmentsForHITRequestMarshaller.Instance;
            var unmarshaller = ListAssignmentsForHITResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssignmentsForHITRequest,ListAssignmentsForHITResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListBonusPayments

        internal virtual ListBonusPaymentsResponse ListBonusPayments(ListBonusPaymentsRequest request)
        {
            var marshaller = ListBonusPaymentsRequestMarshaller.Instance;
            var unmarshaller = ListBonusPaymentsResponseUnmarshaller.Instance;

            return Invoke<ListBonusPaymentsRequest,ListBonusPaymentsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListBonusPaymentsRequestMarshaller.Instance;
            var unmarshaller = ListBonusPaymentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBonusPaymentsRequest,ListBonusPaymentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListHITs

        internal virtual ListHITsResponse ListHITs(ListHITsRequest request)
        {
            var marshaller = ListHITsRequestMarshaller.Instance;
            var unmarshaller = ListHITsResponseUnmarshaller.Instance;

            return Invoke<ListHITsRequest,ListHITsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListHITsRequestMarshaller.Instance;
            var unmarshaller = ListHITsResponseUnmarshaller.Instance;

            return InvokeAsync<ListHITsRequest,ListHITsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListHITsForQualificationType

        internal virtual ListHITsForQualificationTypeResponse ListHITsForQualificationType(ListHITsForQualificationTypeRequest request)
        {
            var marshaller = ListHITsForQualificationTypeRequestMarshaller.Instance;
            var unmarshaller = ListHITsForQualificationTypeResponseUnmarshaller.Instance;

            return Invoke<ListHITsForQualificationTypeRequest,ListHITsForQualificationTypeResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListHITsForQualificationTypeRequestMarshaller.Instance;
            var unmarshaller = ListHITsForQualificationTypeResponseUnmarshaller.Instance;

            return InvokeAsync<ListHITsForQualificationTypeRequest,ListHITsForQualificationTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListQualificationRequests

        internal virtual ListQualificationRequestsResponse ListQualificationRequests(ListQualificationRequestsRequest request)
        {
            var marshaller = ListQualificationRequestsRequestMarshaller.Instance;
            var unmarshaller = ListQualificationRequestsResponseUnmarshaller.Instance;

            return Invoke<ListQualificationRequestsRequest,ListQualificationRequestsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListQualificationRequestsRequestMarshaller.Instance;
            var unmarshaller = ListQualificationRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<ListQualificationRequestsRequest,ListQualificationRequestsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListQualificationTypes

        internal virtual ListQualificationTypesResponse ListQualificationTypes(ListQualificationTypesRequest request)
        {
            var marshaller = ListQualificationTypesRequestMarshaller.Instance;
            var unmarshaller = ListQualificationTypesResponseUnmarshaller.Instance;

            return Invoke<ListQualificationTypesRequest,ListQualificationTypesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListQualificationTypesRequestMarshaller.Instance;
            var unmarshaller = ListQualificationTypesResponseUnmarshaller.Instance;

            return InvokeAsync<ListQualificationTypesRequest,ListQualificationTypesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListReviewableHITs

        internal virtual ListReviewableHITsResponse ListReviewableHITs(ListReviewableHITsRequest request)
        {
            var marshaller = ListReviewableHITsRequestMarshaller.Instance;
            var unmarshaller = ListReviewableHITsResponseUnmarshaller.Instance;

            return Invoke<ListReviewableHITsRequest,ListReviewableHITsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListReviewableHITsRequestMarshaller.Instance;
            var unmarshaller = ListReviewableHITsResponseUnmarshaller.Instance;

            return InvokeAsync<ListReviewableHITsRequest,ListReviewableHITsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListReviewPolicyResultsForHIT

        internal virtual ListReviewPolicyResultsForHITResponse ListReviewPolicyResultsForHIT(ListReviewPolicyResultsForHITRequest request)
        {
            var marshaller = ListReviewPolicyResultsForHITRequestMarshaller.Instance;
            var unmarshaller = ListReviewPolicyResultsForHITResponseUnmarshaller.Instance;

            return Invoke<ListReviewPolicyResultsForHITRequest,ListReviewPolicyResultsForHITResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListReviewPolicyResultsForHITRequestMarshaller.Instance;
            var unmarshaller = ListReviewPolicyResultsForHITResponseUnmarshaller.Instance;

            return InvokeAsync<ListReviewPolicyResultsForHITRequest,ListReviewPolicyResultsForHITResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListWorkerBlocks

        internal virtual ListWorkerBlocksResponse ListWorkerBlocks(ListWorkerBlocksRequest request)
        {
            var marshaller = ListWorkerBlocksRequestMarshaller.Instance;
            var unmarshaller = ListWorkerBlocksResponseUnmarshaller.Instance;

            return Invoke<ListWorkerBlocksRequest,ListWorkerBlocksResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListWorkerBlocksRequestMarshaller.Instance;
            var unmarshaller = ListWorkerBlocksResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkerBlocksRequest,ListWorkerBlocksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListWorkersWithQualificationType

        internal virtual ListWorkersWithQualificationTypeResponse ListWorkersWithQualificationType(ListWorkersWithQualificationTypeRequest request)
        {
            var marshaller = ListWorkersWithQualificationTypeRequestMarshaller.Instance;
            var unmarshaller = ListWorkersWithQualificationTypeResponseUnmarshaller.Instance;

            return Invoke<ListWorkersWithQualificationTypeRequest,ListWorkersWithQualificationTypeResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListWorkersWithQualificationTypeRequestMarshaller.Instance;
            var unmarshaller = ListWorkersWithQualificationTypeResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkersWithQualificationTypeRequest,ListWorkersWithQualificationTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  NotifyWorkers

        internal virtual NotifyWorkersResponse NotifyWorkers(NotifyWorkersRequest request)
        {
            var marshaller = NotifyWorkersRequestMarshaller.Instance;
            var unmarshaller = NotifyWorkersResponseUnmarshaller.Instance;

            return Invoke<NotifyWorkersRequest,NotifyWorkersResponse>(request, marshaller, unmarshaller);
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
            var marshaller = NotifyWorkersRequestMarshaller.Instance;
            var unmarshaller = NotifyWorkersResponseUnmarshaller.Instance;

            return InvokeAsync<NotifyWorkersRequest,NotifyWorkersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RejectAssignment

        internal virtual RejectAssignmentResponse RejectAssignment(RejectAssignmentRequest request)
        {
            var marshaller = RejectAssignmentRequestMarshaller.Instance;
            var unmarshaller = RejectAssignmentResponseUnmarshaller.Instance;

            return Invoke<RejectAssignmentRequest,RejectAssignmentResponse>(request, marshaller, unmarshaller);
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
            var marshaller = RejectAssignmentRequestMarshaller.Instance;
            var unmarshaller = RejectAssignmentResponseUnmarshaller.Instance;

            return InvokeAsync<RejectAssignmentRequest,RejectAssignmentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RejectQualificationRequest

        internal virtual RejectQualificationRequestResponse RejectQualificationRequest(RejectQualificationRequestRequest request)
        {
            var marshaller = RejectQualificationRequestRequestMarshaller.Instance;
            var unmarshaller = RejectQualificationRequestResponseUnmarshaller.Instance;

            return Invoke<RejectQualificationRequestRequest,RejectQualificationRequestResponse>(request, marshaller, unmarshaller);
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
            var marshaller = RejectQualificationRequestRequestMarshaller.Instance;
            var unmarshaller = RejectQualificationRequestResponseUnmarshaller.Instance;

            return InvokeAsync<RejectQualificationRequestRequest,RejectQualificationRequestResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SendBonus

        internal virtual SendBonusResponse SendBonus(SendBonusRequest request)
        {
            var marshaller = SendBonusRequestMarshaller.Instance;
            var unmarshaller = SendBonusResponseUnmarshaller.Instance;

            return Invoke<SendBonusRequest,SendBonusResponse>(request, marshaller, unmarshaller);
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
            var marshaller = SendBonusRequestMarshaller.Instance;
            var unmarshaller = SendBonusResponseUnmarshaller.Instance;

            return InvokeAsync<SendBonusRequest,SendBonusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SendTestEventNotification

        internal virtual SendTestEventNotificationResponse SendTestEventNotification(SendTestEventNotificationRequest request)
        {
            var marshaller = SendTestEventNotificationRequestMarshaller.Instance;
            var unmarshaller = SendTestEventNotificationResponseUnmarshaller.Instance;

            return Invoke<SendTestEventNotificationRequest,SendTestEventNotificationResponse>(request, marshaller, unmarshaller);
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
            var marshaller = SendTestEventNotificationRequestMarshaller.Instance;
            var unmarshaller = SendTestEventNotificationResponseUnmarshaller.Instance;

            return InvokeAsync<SendTestEventNotificationRequest,SendTestEventNotificationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateExpirationForHIT

        internal virtual UpdateExpirationForHITResponse UpdateExpirationForHIT(UpdateExpirationForHITRequest request)
        {
            var marshaller = UpdateExpirationForHITRequestMarshaller.Instance;
            var unmarshaller = UpdateExpirationForHITResponseUnmarshaller.Instance;

            return Invoke<UpdateExpirationForHITRequest,UpdateExpirationForHITResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateExpirationForHITRequestMarshaller.Instance;
            var unmarshaller = UpdateExpirationForHITResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateExpirationForHITRequest,UpdateExpirationForHITResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateHITReviewStatus

        internal virtual UpdateHITReviewStatusResponse UpdateHITReviewStatus(UpdateHITReviewStatusRequest request)
        {
            var marshaller = UpdateHITReviewStatusRequestMarshaller.Instance;
            var unmarshaller = UpdateHITReviewStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateHITReviewStatusRequest,UpdateHITReviewStatusResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateHITReviewStatusRequestMarshaller.Instance;
            var unmarshaller = UpdateHITReviewStatusResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateHITReviewStatusRequest,UpdateHITReviewStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateHITTypeOfHIT

        internal virtual UpdateHITTypeOfHITResponse UpdateHITTypeOfHIT(UpdateHITTypeOfHITRequest request)
        {
            var marshaller = UpdateHITTypeOfHITRequestMarshaller.Instance;
            var unmarshaller = UpdateHITTypeOfHITResponseUnmarshaller.Instance;

            return Invoke<UpdateHITTypeOfHITRequest,UpdateHITTypeOfHITResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateHITTypeOfHITRequestMarshaller.Instance;
            var unmarshaller = UpdateHITTypeOfHITResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateHITTypeOfHITRequest,UpdateHITTypeOfHITResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateNotificationSettings

        internal virtual UpdateNotificationSettingsResponse UpdateNotificationSettings(UpdateNotificationSettingsRequest request)
        {
            var marshaller = UpdateNotificationSettingsRequestMarshaller.Instance;
            var unmarshaller = UpdateNotificationSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateNotificationSettingsRequest,UpdateNotificationSettingsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateNotificationSettingsRequestMarshaller.Instance;
            var unmarshaller = UpdateNotificationSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNotificationSettingsRequest,UpdateNotificationSettingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateQualificationType

        internal virtual UpdateQualificationTypeResponse UpdateQualificationType(UpdateQualificationTypeRequest request)
        {
            var marshaller = UpdateQualificationTypeRequestMarshaller.Instance;
            var unmarshaller = UpdateQualificationTypeResponseUnmarshaller.Instance;

            return Invoke<UpdateQualificationTypeRequest,UpdateQualificationTypeResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateQualificationTypeRequestMarshaller.Instance;
            var unmarshaller = UpdateQualificationTypeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateQualificationTypeRequest,UpdateQualificationTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}