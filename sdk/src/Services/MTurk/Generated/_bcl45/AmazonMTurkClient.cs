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


        /// <summary>
        /// The <code>AcceptQualificationRequest</code> operation approves a Worker's request
        /// for a Qualification. 
        /// 
        ///  
        /// <para>
        ///  Only the owner of the Qualification type can grant a Qualification request for that
        /// type. 
        /// </para>
        ///  
        /// <para>
        ///  A successful request for the <code>AcceptQualificationRequest</code> operation returns
        /// with no errors and an empty body. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptQualificationRequest service method.</param>
        /// 
        /// <returns>The response from the AcceptQualificationRequest service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/AcceptQualificationRequest">REST API Reference for AcceptQualificationRequest Operation</seealso>
        public virtual AcceptQualificationRequestResponse AcceptQualificationRequest(AcceptQualificationRequestRequest request)
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


        /// <summary>
        /// The <code>ApproveAssignment</code> operation approves the results of a completed
        /// assignment. 
        /// 
        ///  
        /// <para>
        ///  Approving an assignment initiates two payments from the Requester's Amazon.com account
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  The Worker who submitted the results is paid the reward specified in the HIT. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Amazon Mechanical Turk fees are debited. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If the Requester's account does not have adequate funds for these payments, the call
        /// to ApproveAssignment returns an exception, and the approval is not processed. You
        /// can include an optional feedback message with the approval, which the Worker can see
        /// in the Status section of the web site. 
        /// </para>
        ///  
        /// <para>
        ///  You can also call this operation for assignments that were previous rejected and
        /// approve them by explicitly overriding the previous rejection. This only works on rejected
        /// assignments that were submitted within the previous 30 days and only if the assignment's
        /// related HIT has not been deleted. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApproveAssignment service method.</param>
        /// 
        /// <returns>The response from the ApproveAssignment service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ApproveAssignment">REST API Reference for ApproveAssignment Operation</seealso>
        public virtual ApproveAssignmentResponse ApproveAssignment(ApproveAssignmentRequest request)
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


        /// <summary>
        /// The <code>AssociateQualificationWithWorker</code> operation gives a Worker a Qualification.
        /// <code>AssociateQualificationWithWorker</code> does not require that the Worker submit
        /// a Qualification request. It gives the Qualification directly to the Worker. 
        /// 
        ///  
        /// <para>
        ///  You can only assign a Qualification of a Qualification type that you created (using
        /// the <code>CreateQualificationType</code> operation). 
        /// </para>
        ///  <note> 
        /// <para>
        ///  Note: <code>AssociateQualificationWithWorker</code> does not affect any pending Qualification
        /// requests for the Qualification by the Worker. If you assign a Qualification to a Worker,
        /// then later grant a Qualification request made by the Worker, the granting of the request
        /// may modify the Qualification score. To resolve a pending Qualification request without
        /// affecting the Qualification the Worker already has, reject the request with the <code>RejectQualificationRequest</code>
        /// operation. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateQualificationWithWorker service method.</param>
        /// 
        /// <returns>The response from the AssociateQualificationWithWorker service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/AssociateQualificationWithWorker">REST API Reference for AssociateQualificationWithWorker Operation</seealso>
        public virtual AssociateQualificationWithWorkerResponse AssociateQualificationWithWorker(AssociateQualificationWithWorkerRequest request)
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


        /// <summary>
        /// The <code>CreateAdditionalAssignmentsForHIT</code> operation increases the maximum
        /// number of assignments of an existing HIT. 
        /// 
        ///  
        /// <para>
        ///  To extend the maximum number of assignments, specify the number of additional assignments.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// HITs created with fewer than 10 assignments cannot be extended to have 10 or more
        /// assignments. Attempting to add assignments in a way that brings the total number of
        /// assignments for a HIT from fewer than 10 assignments to 10 or more assignments will
        /// result in an <code>AWS.MechanicalTurk.InvalidMaximumAssignmentsIncrease</code> exception.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HITs that were created before July 22, 2015 cannot be extended. Attempting to extend
        /// HITs that were created before July 22, 2015 will result in an <code>AWS.MechanicalTurk.HITTooOldForExtension</code>
        /// exception. 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAdditionalAssignmentsForHIT service method.</param>
        /// 
        /// <returns>The response from the CreateAdditionalAssignmentsForHIT service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateAdditionalAssignmentsForHIT">REST API Reference for CreateAdditionalAssignmentsForHIT Operation</seealso>
        public virtual CreateAdditionalAssignmentsForHITResponse CreateAdditionalAssignmentsForHIT(CreateAdditionalAssignmentsForHITRequest request)
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


        /// <summary>
        /// The <code>CreateHIT</code> operation creates a new Human Intelligence Task (HIT).
        /// The new HIT is made available for Workers to find and accept on the Amazon Mechanical
        /// Turk website. 
        /// 
        ///  
        /// <para>
        ///  This operation allows you to specify a new HIT by passing in values for the properties
        /// of the HIT, such as its title, reward amount and number of assignments. When you pass
        /// these values to <code>CreateHIT</code>, a new HIT is created for you, with a new <code>HITTypeID</code>.
        /// The HITTypeID can be used to create additional HITs in the future without needing
        /// to specify common parameters such as the title, description and reward amount each
        /// time.
        /// </para>
        ///  
        /// <para>
        ///  An alternative way to create HITs is to first generate a HITTypeID using the <code>CreateHITType</code>
        /// operation and then call the <code>CreateHITWithHITType</code> operation. This is the
        /// recommended best practice for Requesters who are creating large numbers of HITs. 
        /// </para>
        ///  
        /// <para>
        /// CreateHIT also supports several ways to provide question data: by providing a value
        /// for the <code>Question</code> parameter that fully specifies the contents of the HIT,
        /// or by providing a <code>HitLayoutId</code> and associated <code>HitLayoutParameters</code>.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        ///  If a HIT is created with 10 or more maximum assignments, there is an additional fee.
        /// For more information, see <a href="https://requester.mturk.com/pricing">Amazon Mechanical
        /// Turk Pricing</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHIT service method.</param>
        /// 
        /// <returns>The response from the CreateHIT service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateHIT">REST API Reference for CreateHIT Operation</seealso>
        public virtual CreateHITResponse CreateHIT(CreateHITRequest request)
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


        /// <summary>
        /// The <code>CreateHITType</code> operation creates a new HIT type. This operation allows
        /// you to define a standard set of HIT properties to use when creating HITs. If you register
        /// a HIT type with values that match an existing HIT type, the HIT type ID of the existing
        /// type will be returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHITType service method.</param>
        /// 
        /// <returns>The response from the CreateHITType service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateHITType">REST API Reference for CreateHITType Operation</seealso>
        public virtual CreateHITTypeResponse CreateHITType(CreateHITTypeRequest request)
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


        /// <summary>
        /// The <code>CreateHITWithHITType</code> operation creates a new Human Intelligence
        /// Task (HIT) using an existing HITTypeID generated by the <code>CreateHITType</code>
        /// operation. 
        /// 
        ///  
        /// <para>
        ///  This is an alternative way to create HITs from the <code>CreateHIT</code> operation.
        /// This is the recommended best practice for Requesters who are creating large numbers
        /// of HITs. 
        /// </para>
        ///  
        /// <para>
        /// CreateHITWithHITType also supports several ways to provide question data: by providing
        /// a value for the <code>Question</code> parameter that fully specifies the contents
        /// of the HIT, or by providing a <code>HitLayoutId</code> and associated <code>HitLayoutParameters</code>.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        ///  If a HIT is created with 10 or more maximum assignments, there is an additional fee.
        /// For more information, see <a href="https://requester.mturk.com/pricing">Amazon Mechanical
        /// Turk Pricing</a>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHITWithHITType service method.</param>
        /// 
        /// <returns>The response from the CreateHITWithHITType service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateHITWithHITType">REST API Reference for CreateHITWithHITType Operation</seealso>
        public virtual CreateHITWithHITTypeResponse CreateHITWithHITType(CreateHITWithHITTypeRequest request)
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


        /// <summary>
        /// The <code>CreateQualificationType</code> operation creates a new Qualification type,
        /// which is represented by a <code>QualificationType</code> data structure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQualificationType service method.</param>
        /// 
        /// <returns>The response from the CreateQualificationType service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateQualificationType">REST API Reference for CreateQualificationType Operation</seealso>
        public virtual CreateQualificationTypeResponse CreateQualificationType(CreateQualificationTypeRequest request)
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


        /// <summary>
        /// The <code>CreateWorkerBlock</code> operation allows you to prevent a Worker from working
        /// on your HITs. For example, you can block a Worker who is producing poor quality work.
        /// You can block up to 100,000 Workers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkerBlock service method.</param>
        /// 
        /// <returns>The response from the CreateWorkerBlock service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateWorkerBlock">REST API Reference for CreateWorkerBlock Operation</seealso>
        public virtual CreateWorkerBlockResponse CreateWorkerBlock(CreateWorkerBlockRequest request)
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


        /// <summary>
        /// The <code>DeleteHIT</code> operation is used to delete HIT that is no longer needed.
        /// Only the Requester who created the HIT can delete it. 
        /// 
        ///  
        /// <para>
        ///  You can only dispose of HITs that are in the <code>Reviewable</code> state, with
        /// all of their submitted assignments already either approved or rejected. If you call
        /// the DeleteHIT operation on a HIT that is not in the <code>Reviewable</code> state
        /// (for example, that has not expired, or still has active assignments), or on a HIT
        /// that is Reviewable but without all of its submitted assignments already approved or
        /// rejected, the service will return an error. 
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        ///  HITs are automatically disposed of after 120 days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  After you dispose of a HIT, you can no longer approve the HIT's rejected assignments.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Disposed HITs are not returned in results for the ListHITs operation. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Disposing HITs can improve the performance of operations such as ListReviewableHITs
        /// and ListHITs. 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHIT service method.</param>
        /// 
        /// <returns>The response from the DeleteHIT service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/DeleteHIT">REST API Reference for DeleteHIT Operation</seealso>
        public virtual DeleteHITResponse DeleteHIT(DeleteHITRequest request)
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


        /// <summary>
        /// The <code>DeleteQualificationType</code> deletes a Qualification type and deletes
        /// any HIT types that are associated with the Qualification type. 
        /// 
        ///  
        /// <para>
        /// This operation does not revoke Qualifications already assigned to Workers because
        /// the Qualifications might be needed for active HITs. If there are any pending requests
        /// for the Qualification type, Amazon Mechanical Turk rejects those requests. After you
        /// delete a Qualification type, you can no longer use it to create HITs or HIT types.
        /// </para>
        ///  <note> 
        /// <para>
        /// DeleteQualificationType must wait for all the HITs that use the deleted Qualification
        /// type to be deleted before completing. It may take up to 48 hours before DeleteQualificationType
        /// completes and the unique name of the Qualification type is available for reuse with
        /// CreateQualificationType.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQualificationType service method.</param>
        /// 
        /// <returns>The response from the DeleteQualificationType service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/DeleteQualificationType">REST API Reference for DeleteQualificationType Operation</seealso>
        public virtual DeleteQualificationTypeResponse DeleteQualificationType(DeleteQualificationTypeRequest request)
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


        /// <summary>
        /// The <code>DeleteWorkerBlock</code> operation allows you to reinstate a blocked Worker
        /// to work on your HITs. This operation reverses the effects of the CreateWorkerBlock
        /// operation. You need the Worker ID to use this operation. If the Worker ID is missing
        /// or invalid, this operation fails and returns the message “WorkerId is invalid.” If
        /// the specified Worker is not blocked, this operation returns successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkerBlock service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkerBlock service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/DeleteWorkerBlock">REST API Reference for DeleteWorkerBlock Operation</seealso>
        public virtual DeleteWorkerBlockResponse DeleteWorkerBlock(DeleteWorkerBlockRequest request)
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


        /// <summary>
        /// The <code>DisassociateQualificationFromWorker</code> revokes a previously granted
        /// Qualification from a user. 
        /// 
        ///  
        /// <para>
        ///  You can provide a text message explaining why the Qualification was revoked. The
        /// user who had the Qualification can see this message. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateQualificationFromWorker service method.</param>
        /// 
        /// <returns>The response from the DisassociateQualificationFromWorker service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/DisassociateQualificationFromWorker">REST API Reference for DisassociateQualificationFromWorker Operation</seealso>
        public virtual DisassociateQualificationFromWorkerResponse DisassociateQualificationFromWorker(DisassociateQualificationFromWorkerRequest request)
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


        /// <summary>
        /// The <code>GetAccountBalance</code> operation retrieves the amount of money in your
        /// Amazon Mechanical Turk account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountBalance service method.</param>
        /// 
        /// <returns>The response from the GetAccountBalance service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetAccountBalance">REST API Reference for GetAccountBalance Operation</seealso>
        public virtual GetAccountBalanceResponse GetAccountBalance(GetAccountBalanceRequest request)
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


        /// <summary>
        /// The <code>GetAssignment</code> operation retrieves the details of the specified Assignment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssignment service method.</param>
        /// 
        /// <returns>The response from the GetAssignment service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetAssignment">REST API Reference for GetAssignment Operation</seealso>
        public virtual GetAssignmentResponse GetAssignment(GetAssignmentRequest request)
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


        /// <summary>
        /// The <code>GetFileUploadURL</code> operation generates and returns a temporary URL.
        /// You use the temporary URL to retrieve a file uploaded by a Worker as an answer to
        /// a FileUploadAnswer question for a HIT. The temporary URL is generated the instant
        /// the GetFileUploadURL operation is called, and is valid for 60 seconds. You can get
        /// a temporary file upload URL any time until the HIT is disposed. After the HIT is disposed,
        /// any uploaded files are deleted, and cannot be retrieved. Pending Deprecation on December
        /// 12, 2017. The Answer Specification structure will no longer support the <code>FileUploadAnswer</code>
        /// element to be used for the QuestionForm data structure. Instead, we recommend that
        /// Requesters who want to create HITs asking Workers to upload files to use Amazon S3.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFileUploadURL service method.</param>
        /// 
        /// <returns>The response from the GetFileUploadURL service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetFileUploadURL">REST API Reference for GetFileUploadURL Operation</seealso>
        public virtual GetFileUploadURLResponse GetFileUploadURL(GetFileUploadURLRequest request)
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


        /// <summary>
        /// The <code>GetHIT</code> operation retrieves the details of the specified HIT.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHIT service method.</param>
        /// 
        /// <returns>The response from the GetHIT service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetHIT">REST API Reference for GetHIT Operation</seealso>
        public virtual GetHITResponse GetHIT(GetHITRequest request)
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


        /// <summary>
        /// The <code>GetQualificationScore</code> operation returns the value of a Worker's
        /// Qualification for a given Qualification type. 
        /// 
        ///  
        /// <para>
        ///  To get a Worker's Qualification, you must know the Worker's ID. The Worker's ID is
        /// included in the assignment data returned by the <code>ListAssignmentsForHIT</code>
        /// operation. 
        /// </para>
        ///  
        /// <para>
        /// Only the owner of a Qualification type can query the value of a Worker's Qualification
        /// of that type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQualificationScore service method.</param>
        /// 
        /// <returns>The response from the GetQualificationScore service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetQualificationScore">REST API Reference for GetQualificationScore Operation</seealso>
        public virtual GetQualificationScoreResponse GetQualificationScore(GetQualificationScoreRequest request)
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


        /// <summary>
        /// The <code>GetQualificationType</code>operation retrieves information about a Qualification
        /// type using its ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQualificationType service method.</param>
        /// 
        /// <returns>The response from the GetQualificationType service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetQualificationType">REST API Reference for GetQualificationType Operation</seealso>
        public virtual GetQualificationTypeResponse GetQualificationType(GetQualificationTypeRequest request)
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


        /// <summary>
        /// The <code>ListAssignmentsForHIT</code> operation retrieves completed assignments
        /// for a HIT. You can use this operation to retrieve the results for a HIT. 
        /// 
        ///  
        /// <para>
        ///  You can get assignments for a HIT at any time, even if the HIT is not yet Reviewable.
        /// If a HIT requested multiple assignments, and has received some results but has not
        /// yet become Reviewable, you can still retrieve the partial results with this operation.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  Use the AssignmentStatus parameter to control which set of assignments for a HIT
        /// are returned. The ListAssignmentsForHIT operation can return submitted assignments
        /// awaiting approval, or it can return assignments that have already been approved or
        /// rejected. You can set AssignmentStatus=Approved,Rejected to get assignments that have
        /// already been approved and rejected together in one result set. 
        /// </para>
        ///  
        /// <para>
        ///  Only the Requester who created the HIT can retrieve the assignments for that HIT.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  Results are sorted and divided into numbered pages and the operation returns a single
        /// page of results. You can use the parameters of the operation to control sorting and
        /// pagination. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssignmentsForHIT service method.</param>
        /// 
        /// <returns>The response from the ListAssignmentsForHIT service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListAssignmentsForHIT">REST API Reference for ListAssignmentsForHIT Operation</seealso>
        public virtual ListAssignmentsForHITResponse ListAssignmentsForHIT(ListAssignmentsForHITRequest request)
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


        /// <summary>
        /// The <code>ListBonusPayments</code> operation retrieves the amounts of bonuses you
        /// have paid to Workers for a given HIT or assignment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBonusPayments service method.</param>
        /// 
        /// <returns>The response from the ListBonusPayments service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListBonusPayments">REST API Reference for ListBonusPayments Operation</seealso>
        public virtual ListBonusPaymentsResponse ListBonusPayments(ListBonusPaymentsRequest request)
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


        /// <summary>
        /// The <code>ListHITs</code> operation returns all of a Requester's HITs. The operation
        /// returns HITs of any status, except for HITs that have been deleted of with the DeleteHIT
        /// operation or that have been auto-deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHITs service method.</param>
        /// 
        /// <returns>The response from the ListHITs service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListHITs">REST API Reference for ListHITs Operation</seealso>
        public virtual ListHITsResponse ListHITs(ListHITsRequest request)
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


        /// <summary>
        /// The <code>ListHITsForQualificationType</code> operation returns the HITs that use
        /// the given Qualification type for a Qualification requirement. The operation returns
        /// HITs of any status, except for HITs that have been deleted with the <code>DeleteHIT</code>
        /// operation or that have been auto-deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHITsForQualificationType service method.</param>
        /// 
        /// <returns>The response from the ListHITsForQualificationType service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListHITsForQualificationType">REST API Reference for ListHITsForQualificationType Operation</seealso>
        public virtual ListHITsForQualificationTypeResponse ListHITsForQualificationType(ListHITsForQualificationTypeRequest request)
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


        /// <summary>
        /// The <code>ListQualificationRequests</code> operation retrieves requests for Qualifications
        /// of a particular Qualification type. The owner of the Qualification type calls this
        /// operation to poll for pending requests, and accepts them using the AcceptQualification
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQualificationRequests service method.</param>
        /// 
        /// <returns>The response from the ListQualificationRequests service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListQualificationRequests">REST API Reference for ListQualificationRequests Operation</seealso>
        public virtual ListQualificationRequestsResponse ListQualificationRequests(ListQualificationRequestsRequest request)
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


        /// <summary>
        /// The <code>ListQualificationTypes</code> operation returns a list of Qualification
        /// types, filtered by an optional search term.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQualificationTypes service method.</param>
        /// 
        /// <returns>The response from the ListQualificationTypes service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListQualificationTypes">REST API Reference for ListQualificationTypes Operation</seealso>
        public virtual ListQualificationTypesResponse ListQualificationTypes(ListQualificationTypesRequest request)
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


        /// <summary>
        /// The <code>ListReviewableHITs</code> operation retrieves the HITs with Status equal
        /// to Reviewable or Status equal to Reviewing that belong to the Requester calling the
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReviewableHITs service method.</param>
        /// 
        /// <returns>The response from the ListReviewableHITs service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListReviewableHITs">REST API Reference for ListReviewableHITs Operation</seealso>
        public virtual ListReviewableHITsResponse ListReviewableHITs(ListReviewableHITsRequest request)
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


        /// <summary>
        /// The <code>ListReviewPolicyResultsForHIT</code> operation retrieves the computed results
        /// and the actions taken in the course of executing your Review Policies for a given
        /// HIT. For information about how to specify Review Policies when you call CreateHIT,
        /// see Review Policies. The ListReviewPolicyResultsForHIT operation can return results
        /// for both Assignment-level and HIT-level review results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReviewPolicyResultsForHIT service method.</param>
        /// 
        /// <returns>The response from the ListReviewPolicyResultsForHIT service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListReviewPolicyResultsForHIT">REST API Reference for ListReviewPolicyResultsForHIT Operation</seealso>
        public virtual ListReviewPolicyResultsForHITResponse ListReviewPolicyResultsForHIT(ListReviewPolicyResultsForHITRequest request)
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


        /// <summary>
        /// The <code>ListWorkersBlocks</code> operation retrieves a list of Workers who are blocked
        /// from working on your HITs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkerBlocks service method.</param>
        /// 
        /// <returns>The response from the ListWorkerBlocks service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListWorkerBlocks">REST API Reference for ListWorkerBlocks Operation</seealso>
        public virtual ListWorkerBlocksResponse ListWorkerBlocks(ListWorkerBlocksRequest request)
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


        /// <summary>
        /// The <code>ListWorkersWithQualificationType</code> operation returns all of the Workers
        /// that have been associated with a given Qualification type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkersWithQualificationType service method.</param>
        /// 
        /// <returns>The response from the ListWorkersWithQualificationType service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListWorkersWithQualificationType">REST API Reference for ListWorkersWithQualificationType Operation</seealso>
        public virtual ListWorkersWithQualificationTypeResponse ListWorkersWithQualificationType(ListWorkersWithQualificationTypeRequest request)
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


        /// <summary>
        /// The <code>NotifyWorkers</code> operation sends an email to one or more Workers that
        /// you specify with the Worker ID. You can specify up to 100 Worker IDs to send the same
        /// message with a single call to the NotifyWorkers operation. The NotifyWorkers operation
        /// will send a notification email to a Worker only if you have previously approved or
        /// rejected work from the Worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NotifyWorkers service method.</param>
        /// 
        /// <returns>The response from the NotifyWorkers service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/NotifyWorkers">REST API Reference for NotifyWorkers Operation</seealso>
        public virtual NotifyWorkersResponse NotifyWorkers(NotifyWorkersRequest request)
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


        /// <summary>
        /// The <code>RejectAssignment</code> operation rejects the results of a completed assignment.
        /// 
        /// 
        ///  
        /// <para>
        ///  You can include an optional feedback message with the rejection, which the Worker
        /// can see in the Status section of the web site. When you include a feedback message
        /// with the rejection, it helps the Worker understand why the assignment was rejected,
        /// and can improve the quality of the results the Worker submits in the future. 
        /// </para>
        ///  
        /// <para>
        ///  Only the Requester who created the HIT can reject an assignment for the HIT. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectAssignment service method.</param>
        /// 
        /// <returns>The response from the RejectAssignment service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/RejectAssignment">REST API Reference for RejectAssignment Operation</seealso>
        public virtual RejectAssignmentResponse RejectAssignment(RejectAssignmentRequest request)
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


        /// <summary>
        /// The <code>RejectQualificationRequest</code> operation rejects a user's request for
        /// a Qualification. 
        /// 
        ///  
        /// <para>
        ///  You can provide a text message explaining why the request was rejected. The Worker
        /// who made the request can see this message.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectQualificationRequest service method.</param>
        /// 
        /// <returns>The response from the RejectQualificationRequest service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/RejectQualificationRequest">REST API Reference for RejectQualificationRequest Operation</seealso>
        public virtual RejectQualificationRequestResponse RejectQualificationRequest(RejectQualificationRequestRequest request)
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


        /// <summary>
        /// The <code>SendBonus</code> operation issues a payment of money from your account
        /// to a Worker. This payment happens separately from the reward you pay to the Worker
        /// when you approve the Worker's assignment. The SendBonus operation requires the Worker's
        /// ID and the assignment ID as parameters to initiate payment of the bonus. You must
        /// include a message that explains the reason for the bonus payment, as the Worker may
        /// not be expecting the payment. Amazon Mechanical Turk collects a fee for bonus payments,
        /// similar to the HIT listing fee. This operation fails if your account does not have
        /// enough funds to pay for both the bonus and the fees.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendBonus service method.</param>
        /// 
        /// <returns>The response from the SendBonus service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/SendBonus">REST API Reference for SendBonus Operation</seealso>
        public virtual SendBonusResponse SendBonus(SendBonusRequest request)
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


        /// <summary>
        /// The <code>SendTestEventNotification</code> operation causes Amazon Mechanical Turk
        /// to send a notification message as if a HIT event occurred, according to the provided
        /// notification specification. This allows you to test notifications without setting
        /// up notifications for a real HIT type and trying to trigger them using the website.
        /// When you call this operation, the service attempts to send the test notification immediately.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendTestEventNotification service method.</param>
        /// 
        /// <returns>The response from the SendTestEventNotification service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/SendTestEventNotification">REST API Reference for SendTestEventNotification Operation</seealso>
        public virtual SendTestEventNotificationResponse SendTestEventNotification(SendTestEventNotificationRequest request)
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


        /// <summary>
        /// The <code>UpdateExpirationForHIT</code> operation allows you update the expiration
        /// time of a HIT. If you update it to a time in the past, the HIT will be immediately
        /// expired.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExpirationForHIT service method.</param>
        /// 
        /// <returns>The response from the UpdateExpirationForHIT service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateExpirationForHIT">REST API Reference for UpdateExpirationForHIT Operation</seealso>
        public virtual UpdateExpirationForHITResponse UpdateExpirationForHIT(UpdateExpirationForHITRequest request)
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


        /// <summary>
        /// The <code>UpdateHITReviewStatus</code> operation updates the status of a HIT. If
        /// the status is Reviewable, this operation can update the status to Reviewing, or it
        /// can revert a Reviewing HIT back to the Reviewable status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHITReviewStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateHITReviewStatus service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateHITReviewStatus">REST API Reference for UpdateHITReviewStatus Operation</seealso>
        public virtual UpdateHITReviewStatusResponse UpdateHITReviewStatus(UpdateHITReviewStatusRequest request)
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


        /// <summary>
        /// The <code>UpdateHITTypeOfHIT</code> operation allows you to change the HITType properties
        /// of a HIT. This operation disassociates the HIT from its old HITType properties and
        /// associates it with the new HITType properties. The HIT takes on the properties of
        /// the new HITType in place of the old ones.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHITTypeOfHIT service method.</param>
        /// 
        /// <returns>The response from the UpdateHITTypeOfHIT service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateHITTypeOfHIT">REST API Reference for UpdateHITTypeOfHIT Operation</seealso>
        public virtual UpdateHITTypeOfHITResponse UpdateHITTypeOfHIT(UpdateHITTypeOfHITRequest request)
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


        /// <summary>
        /// The <code>UpdateNotificationSettings</code> operation creates, updates, disables
        /// or re-enables notifications for a HIT type. If you call the UpdateNotificationSettings
        /// operation for a HIT type that already has a notification specification, the operation
        /// replaces the old specification with a new one. You can call the UpdateNotificationSettings
        /// operation to enable or disable notifications for the HIT type, without having to modify
        /// the notification specification itself by providing updates to the Active status without
        /// specifying a new notification specification. To change the Active status of a HIT
        /// type's notifications, the HIT type must already have a notification specification,
        /// or one must be provided in the same call to <code>UpdateNotificationSettings</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotificationSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateNotificationSettings service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateNotificationSettings">REST API Reference for UpdateNotificationSettings Operation</seealso>
        public virtual UpdateNotificationSettingsResponse UpdateNotificationSettings(UpdateNotificationSettingsRequest request)
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


        /// <summary>
        /// The <code>UpdateQualificationType</code> operation modifies the attributes of an
        /// existing Qualification type, which is represented by a QualificationType data structure.
        /// Only the owner of a Qualification type can modify its attributes. 
        /// 
        ///  
        /// <para>
        ///  Most attributes of a Qualification type can be changed after the type has been created.
        /// However, the Name and Keywords fields cannot be modified. The RetryDelayInSeconds
        /// parameter can be modified or added to change the delay or to enable retries, but RetryDelayInSeconds
        /// cannot be used to disable retries. 
        /// </para>
        ///  
        /// <para>
        ///  You can use this operation to update the test for a Qualification type. The test
        /// is updated based on the values specified for the Test, TestDurationInSeconds and AnswerKey
        /// parameters. All three parameters specify the updated test. If you are updating the
        /// test for a type, you must specify the Test and TestDurationInSeconds parameters. The
        /// AnswerKey parameter is optional; omitting it specifies that the updated test does
        /// not have an answer key. 
        /// </para>
        ///  
        /// <para>
        ///  If you omit the Test parameter, the test for the Qualification type is unchanged.
        /// There is no way to remove a test from a Qualification type that has one. If the type
        /// already has a test, you cannot update it to be AutoGranted. If the Qualification type
        /// does not have a test and one is provided by an update, the type will henceforth have
        /// a test. 
        /// </para>
        ///  
        /// <para>
        ///  If you want to update the test duration or answer key for an existing test without
        /// changing the questions, you must specify a Test parameter with the original questions,
        /// along with the updated values. 
        /// </para>
        ///  
        /// <para>
        ///  If you provide an updated Test but no AnswerKey, the new test will not have an answer
        /// key. Requests for such Qualifications must be granted manually. 
        /// </para>
        ///  
        /// <para>
        ///  You can also update the AutoGranted and AutoGrantedValue attributes of the Qualification
        /// type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQualificationType service method.</param>
        /// 
        /// <returns>The response from the UpdateQualificationType service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateQualificationType">REST API Reference for UpdateQualificationType Operation</seealso>
        public virtual UpdateQualificationTypeResponse UpdateQualificationType(UpdateQualificationTypeRequest request)
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