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
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.MTurk
{
    /// <summary>
    /// <para>Implementation for accessing MTurk</para>
    ///
    /// Amazon Mechanical Turk API Reference
    /// </summary>
    public partial class AmazonMTurkClient : AmazonServiceClient, IAmazonMTurk
    {
        private static IServiceMetadata serviceMetadata = new AmazonMTurkMetadata();
        private IMTurkPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMTurkPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new MTurkPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
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
            : base(new AmazonMTurkConfig()) { }

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
            : base(new AmazonMTurkConfig{RegionEndpoint = region}) { }

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
            : base(config) { }

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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMTurkEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMTurkAuthSchemeHandler());
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


        /// <summary>
        /// The <c>AcceptQualificationRequest</c> operation approves a Worker's request for a
        /// Qualification. 
        /// 
        ///  
        /// <para>
        ///  Only the owner of the Qualification type can grant a Qualification request for that
        /// type. 
        /// </para>
        ///  
        /// <para>
        ///  A successful request for the <c>AcceptQualificationRequest</c> operation returns
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptQualificationRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptQualificationRequestResponseUnmarshaller.Instance;

            return Invoke<AcceptQualificationRequestResponse>(request, options);
        }


        /// <summary>
        /// The <c>AcceptQualificationRequest</c> operation approves a Worker's request for a
        /// Qualification. 
        /// 
        ///  
        /// <para>
        ///  Only the owner of the Qualification type can grant a Qualification request for that
        /// type. 
        /// </para>
        ///  
        /// <para>
        ///  A successful request for the <c>AcceptQualificationRequest</c> operation returns
        /// with no errors and an empty body. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptQualificationRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AcceptQualificationRequestResponse> AcceptQualificationRequestAsync(AcceptQualificationRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptQualificationRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptQualificationRequestResponseUnmarshaller.Instance;
            
            return InvokeAsync<AcceptQualificationRequestResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ApproveAssignment


        /// <summary>
        /// The <c>ApproveAssignment</c> operation approves the results of a completed assignment.
        /// 
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ApproveAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApproveAssignmentResponseUnmarshaller.Instance;

            return Invoke<ApproveAssignmentResponse>(request, options);
        }


        /// <summary>
        /// The <c>ApproveAssignment</c> operation approves the results of a completed assignment.
        /// 
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ApproveAssignmentResponse> ApproveAssignmentAsync(ApproveAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ApproveAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApproveAssignmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<ApproveAssignmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateQualificationWithWorker


        /// <summary>
        /// The <c>AssociateQualificationWithWorker</c> operation gives a Worker a Qualification.
        /// <c>AssociateQualificationWithWorker</c> does not require that the Worker submit a
        /// Qualification request. It gives the Qualification directly to the Worker. 
        /// 
        ///  
        /// <para>
        ///  You can only assign a Qualification of a Qualification type that you created (using
        /// the <c>CreateQualificationType</c> operation). 
        /// </para>
        ///  <note> 
        /// <para>
        ///  Note: <c>AssociateQualificationWithWorker</c> does not affect any pending Qualification
        /// requests for the Qualification by the Worker. If you assign a Qualification to a Worker,
        /// then later grant a Qualification request made by the Worker, the granting of the request
        /// may modify the Qualification score. To resolve a pending Qualification request without
        /// affecting the Qualification the Worker already has, reject the request with the <c>RejectQualificationRequest</c>
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateQualificationWithWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateQualificationWithWorkerResponseUnmarshaller.Instance;

            return Invoke<AssociateQualificationWithWorkerResponse>(request, options);
        }


        /// <summary>
        /// The <c>AssociateQualificationWithWorker</c> operation gives a Worker a Qualification.
        /// <c>AssociateQualificationWithWorker</c> does not require that the Worker submit a
        /// Qualification request. It gives the Qualification directly to the Worker. 
        /// 
        ///  
        /// <para>
        ///  You can only assign a Qualification of a Qualification type that you created (using
        /// the <c>CreateQualificationType</c> operation). 
        /// </para>
        ///  <note> 
        /// <para>
        ///  Note: <c>AssociateQualificationWithWorker</c> does not affect any pending Qualification
        /// requests for the Qualification by the Worker. If you assign a Qualification to a Worker,
        /// then later grant a Qualification request made by the Worker, the granting of the request
        /// may modify the Qualification score. To resolve a pending Qualification request without
        /// affecting the Qualification the Worker already has, reject the request with the <c>RejectQualificationRequest</c>
        /// operation. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateQualificationWithWorker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AssociateQualificationWithWorkerResponse> AssociateQualificationWithWorkerAsync(AssociateQualificationWithWorkerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateQualificationWithWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateQualificationWithWorkerResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateQualificationWithWorkerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAdditionalAssignmentsForHIT


        /// <summary>
        /// The <c>CreateAdditionalAssignmentsForHIT</c> operation increases the maximum number
        /// of assignments of an existing HIT. 
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
        /// result in an <c>AWS.MechanicalTurk.InvalidMaximumAssignmentsIncrease</c> exception.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HITs that were created before July 22, 2015 cannot be extended. Attempting to extend
        /// HITs that were created before July 22, 2015 will result in an <c>AWS.MechanicalTurk.HITTooOldForExtension</c>
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAdditionalAssignmentsForHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAdditionalAssignmentsForHITResponseUnmarshaller.Instance;

            return Invoke<CreateAdditionalAssignmentsForHITResponse>(request, options);
        }


        /// <summary>
        /// The <c>CreateAdditionalAssignmentsForHIT</c> operation increases the maximum number
        /// of assignments of an existing HIT. 
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
        /// result in an <c>AWS.MechanicalTurk.InvalidMaximumAssignmentsIncrease</c> exception.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HITs that were created before July 22, 2015 cannot be extended. Attempting to extend
        /// HITs that were created before July 22, 2015 will result in an <c>AWS.MechanicalTurk.HITTooOldForExtension</c>
        /// exception. 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAdditionalAssignmentsForHIT service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateAdditionalAssignmentsForHITResponse> CreateAdditionalAssignmentsForHITAsync(CreateAdditionalAssignmentsForHITRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAdditionalAssignmentsForHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAdditionalAssignmentsForHITResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAdditionalAssignmentsForHITResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateHIT


        /// <summary>
        /// The <c>CreateHIT</c> operation creates a new Human Intelligence Task (HIT). The new
        /// HIT is made available for Workers to find and accept on the Amazon Mechanical Turk
        /// website. 
        /// 
        ///  
        /// <para>
        ///  This operation allows you to specify a new HIT by passing in values for the properties
        /// of the HIT, such as its title, reward amount and number of assignments. When you pass
        /// these values to <c>CreateHIT</c>, a new HIT is created for you, with a new <c>HITTypeID</c>.
        /// The HITTypeID can be used to create additional HITs in the future without needing
        /// to specify common parameters such as the title, description and reward amount each
        /// time.
        /// </para>
        ///  
        /// <para>
        ///  An alternative way to create HITs is to first generate a HITTypeID using the <c>CreateHITType</c>
        /// operation and then call the <c>CreateHITWithHITType</c> operation. This is the recommended
        /// best practice for Requesters who are creating large numbers of HITs. 
        /// </para>
        ///  
        /// <para>
        /// CreateHIT also supports several ways to provide question data: by providing a value
        /// for the <c>Question</c> parameter that fully specifies the contents of the HIT, or
        /// by providing a <c>HitLayoutId</c> and associated <c>HitLayoutParameters</c>. 
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHITResponseUnmarshaller.Instance;

            return Invoke<CreateHITResponse>(request, options);
        }


        /// <summary>
        /// The <c>CreateHIT</c> operation creates a new Human Intelligence Task (HIT). The new
        /// HIT is made available for Workers to find and accept on the Amazon Mechanical Turk
        /// website. 
        /// 
        ///  
        /// <para>
        ///  This operation allows you to specify a new HIT by passing in values for the properties
        /// of the HIT, such as its title, reward amount and number of assignments. When you pass
        /// these values to <c>CreateHIT</c>, a new HIT is created for you, with a new <c>HITTypeID</c>.
        /// The HITTypeID can be used to create additional HITs in the future without needing
        /// to specify common parameters such as the title, description and reward amount each
        /// time.
        /// </para>
        ///  
        /// <para>
        ///  An alternative way to create HITs is to first generate a HITTypeID using the <c>CreateHITType</c>
        /// operation and then call the <c>CreateHITWithHITType</c> operation. This is the recommended
        /// best practice for Requesters who are creating large numbers of HITs. 
        /// </para>
        ///  
        /// <para>
        /// CreateHIT also supports several ways to provide question data: by providing a value
        /// for the <c>Question</c> parameter that fully specifies the contents of the HIT, or
        /// by providing a <c>HitLayoutId</c> and associated <c>HitLayoutParameters</c>. 
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateHITResponse> CreateHITAsync(CreateHITRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHITResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateHITResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateHITType


        /// <summary>
        /// The <c>CreateHITType</c> operation creates a new HIT type. This operation allows
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateHITTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHITTypeResponseUnmarshaller.Instance;

            return Invoke<CreateHITTypeResponse>(request, options);
        }


        /// <summary>
        /// The <c>CreateHITType</c> operation creates a new HIT type. This operation allows
        /// you to define a standard set of HIT properties to use when creating HITs. If you register
        /// a HIT type with values that match an existing HIT type, the HIT type ID of the existing
        /// type will be returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHITType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateHITTypeResponse> CreateHITTypeAsync(CreateHITTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateHITTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHITTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateHITTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateHITWithHITType


        /// <summary>
        /// The <c>CreateHITWithHITType</c> operation creates a new Human Intelligence Task (HIT)
        /// using an existing HITTypeID generated by the <c>CreateHITType</c> operation. 
        /// 
        ///  
        /// <para>
        ///  This is an alternative way to create HITs from the <c>CreateHIT</c> operation. This
        /// is the recommended best practice for Requesters who are creating large numbers of
        /// HITs. 
        /// </para>
        ///  
        /// <para>
        /// CreateHITWithHITType also supports several ways to provide question data: by providing
        /// a value for the <c>Question</c> parameter that fully specifies the contents of the
        /// HIT, or by providing a <c>HitLayoutId</c> and associated <c>HitLayoutParameters</c>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateHITWithHITTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHITWithHITTypeResponseUnmarshaller.Instance;

            return Invoke<CreateHITWithHITTypeResponse>(request, options);
        }


        /// <summary>
        /// The <c>CreateHITWithHITType</c> operation creates a new Human Intelligence Task (HIT)
        /// using an existing HITTypeID generated by the <c>CreateHITType</c> operation. 
        /// 
        ///  
        /// <para>
        ///  This is an alternative way to create HITs from the <c>CreateHIT</c> operation. This
        /// is the recommended best practice for Requesters who are creating large numbers of
        /// HITs. 
        /// </para>
        ///  
        /// <para>
        /// CreateHITWithHITType also supports several ways to provide question data: by providing
        /// a value for the <c>Question</c> parameter that fully specifies the contents of the
        /// HIT, or by providing a <c>HitLayoutId</c> and associated <c>HitLayoutParameters</c>.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateHITWithHITTypeResponse> CreateHITWithHITTypeAsync(CreateHITWithHITTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateHITWithHITTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHITWithHITTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateHITWithHITTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateQualificationType


        /// <summary>
        /// The <c>CreateQualificationType</c> operation creates a new Qualification type, which
        /// is represented by a <c>QualificationType</c> data structure.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateQualificationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQualificationTypeResponseUnmarshaller.Instance;

            return Invoke<CreateQualificationTypeResponse>(request, options);
        }


        /// <summary>
        /// The <c>CreateQualificationType</c> operation creates a new Qualification type, which
        /// is represented by a <c>QualificationType</c> data structure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQualificationType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateQualificationTypeResponse> CreateQualificationTypeAsync(CreateQualificationTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateQualificationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQualificationTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateQualificationTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWorkerBlock


        /// <summary>
        /// The <c>CreateWorkerBlock</c> operation allows you to prevent a Worker from working
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkerBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkerBlockResponseUnmarshaller.Instance;

            return Invoke<CreateWorkerBlockResponse>(request, options);
        }


        /// <summary>
        /// The <c>CreateWorkerBlock</c> operation allows you to prevent a Worker from working
        /// on your HITs. For example, you can block a Worker who is producing poor quality work.
        /// You can block up to 100,000 Workers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkerBlock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateWorkerBlockResponse> CreateWorkerBlockAsync(CreateWorkerBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkerBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkerBlockResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateWorkerBlockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteHIT


        /// <summary>
        /// The <c>DeleteHIT</c> operation is used to delete HIT that is no longer needed. Only
        /// the Requester who created the HIT can delete it. 
        /// 
        ///  
        /// <para>
        ///  You can only dispose of HITs that are in the <c>Reviewable</c> state, with all of
        /// their submitted assignments already either approved or rejected. If you call the DeleteHIT
        /// operation on a HIT that is not in the <c>Reviewable</c> state (for example, that has
        /// not expired, or still has active assignments), or on a HIT that is Reviewable but
        /// without all of its submitted assignments already approved or rejected, the service
        /// will return an error. 
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHITResponseUnmarshaller.Instance;

            return Invoke<DeleteHITResponse>(request, options);
        }


        /// <summary>
        /// The <c>DeleteHIT</c> operation is used to delete HIT that is no longer needed. Only
        /// the Requester who created the HIT can delete it. 
        /// 
        ///  
        /// <para>
        ///  You can only dispose of HITs that are in the <c>Reviewable</c> state, with all of
        /// their submitted assignments already either approved or rejected. If you call the DeleteHIT
        /// operation on a HIT that is not in the <c>Reviewable</c> state (for example, that has
        /// not expired, or still has active assignments), or on a HIT that is Reviewable but
        /// without all of its submitted assignments already approved or rejected, the service
        /// will return an error. 
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteHITResponse> DeleteHITAsync(DeleteHITRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHITResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteHITResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteQualificationType


        /// <summary>
        /// The <c>DeleteQualificationType</c> deletes a Qualification type and deletes any HIT
        /// types that are associated with the Qualification type. 
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQualificationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQualificationTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteQualificationTypeResponse>(request, options);
        }


        /// <summary>
        /// The <c>DeleteQualificationType</c> deletes a Qualification type and deletes any HIT
        /// types that are associated with the Qualification type. 
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteQualificationTypeResponse> DeleteQualificationTypeAsync(DeleteQualificationTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQualificationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQualificationTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteQualificationTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWorkerBlock


        /// <summary>
        /// The <c>DeleteWorkerBlock</c> operation allows you to reinstate a blocked Worker to
        /// work on your HITs. This operation reverses the effects of the CreateWorkerBlock operation.
        /// You need the Worker ID to use this operation. If the Worker ID is missing or invalid,
        /// this operation fails and returns the message “WorkerId is invalid.” If the specified
        /// Worker is not blocked, this operation returns successfully.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkerBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkerBlockResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkerBlockResponse>(request, options);
        }


        /// <summary>
        /// The <c>DeleteWorkerBlock</c> operation allows you to reinstate a blocked Worker to
        /// work on your HITs. This operation reverses the effects of the CreateWorkerBlock operation.
        /// You need the Worker ID to use this operation. If the Worker ID is missing or invalid,
        /// this operation fails and returns the message “WorkerId is invalid.” If the specified
        /// Worker is not blocked, this operation returns successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkerBlock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteWorkerBlockResponse> DeleteWorkerBlockAsync(DeleteWorkerBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkerBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkerBlockResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteWorkerBlockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateQualificationFromWorker


        /// <summary>
        /// The <c>DisassociateQualificationFromWorker</c> revokes a previously granted Qualification
        /// from a user. 
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateQualificationFromWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateQualificationFromWorkerResponseUnmarshaller.Instance;

            return Invoke<DisassociateQualificationFromWorkerResponse>(request, options);
        }


        /// <summary>
        /// The <c>DisassociateQualificationFromWorker</c> revokes a previously granted Qualification
        /// from a user. 
        /// 
        ///  
        /// <para>
        ///  You can provide a text message explaining why the Qualification was revoked. The
        /// user who had the Qualification can see this message. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateQualificationFromWorker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DisassociateQualificationFromWorkerResponse> DisassociateQualificationFromWorkerAsync(DisassociateQualificationFromWorkerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateQualificationFromWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateQualificationFromWorkerResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateQualificationFromWorkerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccountBalance


        /// <summary>
        /// The <c>GetAccountBalance</c> operation retrieves the Prepaid HITs balance in your
        /// Amazon Mechanical Turk account if you are a Prepaid Requester. Alternatively, this
        /// operation will retrieve the remaining available AWS Billing usage if you have enabled
        /// AWS Billing. Note: If you have enabled AWS Billing and still have a remaining Prepaid
        /// HITs balance, this balance can be viewed on the My Account page in the Requester console.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountBalanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountBalanceResponseUnmarshaller.Instance;

            return Invoke<GetAccountBalanceResponse>(request, options);
        }


        /// <summary>
        /// The <c>GetAccountBalance</c> operation retrieves the Prepaid HITs balance in your
        /// Amazon Mechanical Turk account if you are a Prepaid Requester. Alternatively, this
        /// operation will retrieve the remaining available AWS Billing usage if you have enabled
        /// AWS Billing. Note: If you have enabled AWS Billing and still have a remaining Prepaid
        /// HITs balance, this balance can be viewed on the My Account page in the Requester console.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountBalance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetAccountBalanceResponse> GetAccountBalanceAsync(GetAccountBalanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountBalanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountBalanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAccountBalanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAssignment


        /// <summary>
        /// The <c>GetAssignment</c> operation retrieves the details of the specified Assignment.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssignmentResponseUnmarshaller.Instance;

            return Invoke<GetAssignmentResponse>(request, options);
        }


        /// <summary>
        /// The <c>GetAssignment</c> operation retrieves the details of the specified Assignment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssignment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetAssignmentResponse> GetAssignmentAsync(GetAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssignmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAssignmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFileUploadURL


        /// <summary>
        /// The <c>GetFileUploadURL</c> operation generates and returns a temporary URL. You
        /// use the temporary URL to retrieve a file uploaded by a Worker as an answer to a FileUploadAnswer
        /// question for a HIT. The temporary URL is generated the instant the GetFileUploadURL
        /// operation is called, and is valid for 60 seconds. You can get a temporary file upload
        /// URL any time until the HIT is disposed. After the HIT is disposed, any uploaded files
        /// are deleted, and cannot be retrieved. Pending Deprecation on December 12, 2017. The
        /// Answer Specification structure will no longer support the <c>FileUploadAnswer</c>
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFileUploadURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFileUploadURLResponseUnmarshaller.Instance;

            return Invoke<GetFileUploadURLResponse>(request, options);
        }


        /// <summary>
        /// The <c>GetFileUploadURL</c> operation generates and returns a temporary URL. You
        /// use the temporary URL to retrieve a file uploaded by a Worker as an answer to a FileUploadAnswer
        /// question for a HIT. The temporary URL is generated the instant the GetFileUploadURL
        /// operation is called, and is valid for 60 seconds. You can get a temporary file upload
        /// URL any time until the HIT is disposed. After the HIT is disposed, any uploaded files
        /// are deleted, and cannot be retrieved. Pending Deprecation on December 12, 2017. The
        /// Answer Specification structure will no longer support the <c>FileUploadAnswer</c>
        /// element to be used for the QuestionForm data structure. Instead, we recommend that
        /// Requesters who want to create HITs asking Workers to upload files to use Amazon S3.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFileUploadURL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetFileUploadURLResponse> GetFileUploadURLAsync(GetFileUploadURLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFileUploadURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFileUploadURLResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetFileUploadURLResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetHIT


        /// <summary>
        /// The <c>GetHIT</c> operation retrieves the details of the specified HIT.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHITResponseUnmarshaller.Instance;

            return Invoke<GetHITResponse>(request, options);
        }


        /// <summary>
        /// The <c>GetHIT</c> operation retrieves the details of the specified HIT.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHIT service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetHITResponse> GetHITAsync(GetHITRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHITResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetHITResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetQualificationScore


        /// <summary>
        /// The <c>GetQualificationScore</c> operation returns the value of a Worker's Qualification
        /// for a given Qualification type. 
        /// 
        ///  
        /// <para>
        ///  To get a Worker's Qualification, you must know the Worker's ID. The Worker's ID is
        /// included in the assignment data returned by the <c>ListAssignmentsForHIT</c> operation.
        /// 
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQualificationScoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQualificationScoreResponseUnmarshaller.Instance;

            return Invoke<GetQualificationScoreResponse>(request, options);
        }


        /// <summary>
        /// The <c>GetQualificationScore</c> operation returns the value of a Worker's Qualification
        /// for a given Qualification type. 
        /// 
        ///  
        /// <para>
        ///  To get a Worker's Qualification, you must know the Worker's ID. The Worker's ID is
        /// included in the assignment data returned by the <c>ListAssignmentsForHIT</c> operation.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Only the owner of a Qualification type can query the value of a Worker's Qualification
        /// of that type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQualificationScore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetQualificationScoreResponse> GetQualificationScoreAsync(GetQualificationScoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQualificationScoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQualificationScoreResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetQualificationScoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetQualificationType


        /// <summary>
        /// The <c>GetQualificationType</c>operation retrieves information about a Qualification
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQualificationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQualificationTypeResponseUnmarshaller.Instance;

            return Invoke<GetQualificationTypeResponse>(request, options);
        }


        /// <summary>
        /// The <c>GetQualificationType</c>operation retrieves information about a Qualification
        /// type using its ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQualificationType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetQualificationTypeResponse> GetQualificationTypeAsync(GetQualificationTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQualificationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQualificationTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetQualificationTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAssignmentsForHIT


        /// <summary>
        /// The <c>ListAssignmentsForHIT</c> operation retrieves completed assignments for a
        /// HIT. You can use this operation to retrieve the results for a HIT. 
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssignmentsForHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssignmentsForHITResponseUnmarshaller.Instance;

            return Invoke<ListAssignmentsForHITResponse>(request, options);
        }


        /// <summary>
        /// The <c>ListAssignmentsForHIT</c> operation retrieves completed assignments for a
        /// HIT. You can use this operation to retrieve the results for a HIT. 
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListAssignmentsForHITResponse> ListAssignmentsForHITAsync(ListAssignmentsForHITRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssignmentsForHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssignmentsForHITResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAssignmentsForHITResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBonusPayments


        /// <summary>
        /// The <c>ListBonusPayments</c> operation retrieves the amounts of bonuses you have
        /// paid to Workers for a given HIT or assignment.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBonusPaymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBonusPaymentsResponseUnmarshaller.Instance;

            return Invoke<ListBonusPaymentsResponse>(request, options);
        }


        /// <summary>
        /// The <c>ListBonusPayments</c> operation retrieves the amounts of bonuses you have
        /// paid to Workers for a given HIT or assignment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBonusPayments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListBonusPaymentsResponse> ListBonusPaymentsAsync(ListBonusPaymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBonusPaymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBonusPaymentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBonusPaymentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListHITs


        /// <summary>
        /// The <c>ListHITs</c> operation returns all of a Requester's HITs. The operation returns
        /// HITs of any status, except for HITs that have been deleted of with the DeleteHIT operation
        /// or that have been auto-deleted.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListHITsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHITsResponseUnmarshaller.Instance;

            return Invoke<ListHITsResponse>(request, options);
        }


        /// <summary>
        /// The <c>ListHITs</c> operation returns all of a Requester's HITs. The operation returns
        /// HITs of any status, except for HITs that have been deleted of with the DeleteHIT operation
        /// or that have been auto-deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHITs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListHITsResponse> ListHITsAsync(ListHITsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListHITsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHITsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListHITsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListHITsForQualificationType


        /// <summary>
        /// The <c>ListHITsForQualificationType</c> operation returns the HITs that use the given
        /// Qualification type for a Qualification requirement. The operation returns HITs of
        /// any status, except for HITs that have been deleted with the <c>DeleteHIT</c> operation
        /// or that have been auto-deleted.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListHITsForQualificationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHITsForQualificationTypeResponseUnmarshaller.Instance;

            return Invoke<ListHITsForQualificationTypeResponse>(request, options);
        }


        /// <summary>
        /// The <c>ListHITsForQualificationType</c> operation returns the HITs that use the given
        /// Qualification type for a Qualification requirement. The operation returns HITs of
        /// any status, except for HITs that have been deleted with the <c>DeleteHIT</c> operation
        /// or that have been auto-deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHITsForQualificationType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListHITsForQualificationTypeResponse> ListHITsForQualificationTypeAsync(ListHITsForQualificationTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListHITsForQualificationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHITsForQualificationTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListHITsForQualificationTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListQualificationRequests


        /// <summary>
        /// The <c>ListQualificationRequests</c> operation retrieves requests for Qualifications
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQualificationRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQualificationRequestsResponseUnmarshaller.Instance;

            return Invoke<ListQualificationRequestsResponse>(request, options);
        }


        /// <summary>
        /// The <c>ListQualificationRequests</c> operation retrieves requests for Qualifications
        /// of a particular Qualification type. The owner of the Qualification type calls this
        /// operation to poll for pending requests, and accepts them using the AcceptQualification
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQualificationRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListQualificationRequestsResponse> ListQualificationRequestsAsync(ListQualificationRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQualificationRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQualificationRequestsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListQualificationRequestsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListQualificationTypes


        /// <summary>
        /// The <c>ListQualificationTypes</c> operation returns a list of Qualification types,
        /// filtered by an optional search term.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQualificationTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQualificationTypesResponseUnmarshaller.Instance;

            return Invoke<ListQualificationTypesResponse>(request, options);
        }


        /// <summary>
        /// The <c>ListQualificationTypes</c> operation returns a list of Qualification types,
        /// filtered by an optional search term.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQualificationTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListQualificationTypesResponse> ListQualificationTypesAsync(ListQualificationTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQualificationTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQualificationTypesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListQualificationTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListReviewableHITs


        /// <summary>
        /// The <c>ListReviewableHITs</c> operation retrieves the HITs with Status equal to Reviewable
        /// or Status equal to Reviewing that belong to the Requester calling the operation.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReviewableHITsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReviewableHITsResponseUnmarshaller.Instance;

            return Invoke<ListReviewableHITsResponse>(request, options);
        }


        /// <summary>
        /// The <c>ListReviewableHITs</c> operation retrieves the HITs with Status equal to Reviewable
        /// or Status equal to Reviewing that belong to the Requester calling the operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReviewableHITs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListReviewableHITsResponse> ListReviewableHITsAsync(ListReviewableHITsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReviewableHITsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReviewableHITsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListReviewableHITsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListReviewPolicyResultsForHIT


        /// <summary>
        /// The <c>ListReviewPolicyResultsForHIT</c> operation retrieves the computed results
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReviewPolicyResultsForHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReviewPolicyResultsForHITResponseUnmarshaller.Instance;

            return Invoke<ListReviewPolicyResultsForHITResponse>(request, options);
        }


        /// <summary>
        /// The <c>ListReviewPolicyResultsForHIT</c> operation retrieves the computed results
        /// and the actions taken in the course of executing your Review Policies for a given
        /// HIT. For information about how to specify Review Policies when you call CreateHIT,
        /// see Review Policies. The ListReviewPolicyResultsForHIT operation can return results
        /// for both Assignment-level and HIT-level review results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReviewPolicyResultsForHIT service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListReviewPolicyResultsForHITResponse> ListReviewPolicyResultsForHITAsync(ListReviewPolicyResultsForHITRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReviewPolicyResultsForHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReviewPolicyResultsForHITResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListReviewPolicyResultsForHITResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWorkerBlocks


        /// <summary>
        /// The <c>ListWorkersBlocks</c> operation retrieves a list of Workers who are blocked
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkerBlocksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkerBlocksResponseUnmarshaller.Instance;

            return Invoke<ListWorkerBlocksResponse>(request, options);
        }


        /// <summary>
        /// The <c>ListWorkersBlocks</c> operation retrieves a list of Workers who are blocked
        /// from working on your HITs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkerBlocks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListWorkerBlocksResponse> ListWorkerBlocksAsync(ListWorkerBlocksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkerBlocksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkerBlocksResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListWorkerBlocksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWorkersWithQualificationType


        /// <summary>
        /// The <c>ListWorkersWithQualificationType</c> operation returns all of the Workers
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkersWithQualificationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkersWithQualificationTypeResponseUnmarshaller.Instance;

            return Invoke<ListWorkersWithQualificationTypeResponse>(request, options);
        }


        /// <summary>
        /// The <c>ListWorkersWithQualificationType</c> operation returns all of the Workers
        /// that have been associated with a given Qualification type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkersWithQualificationType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListWorkersWithQualificationTypeResponse> ListWorkersWithQualificationTypeAsync(ListWorkersWithQualificationTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkersWithQualificationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkersWithQualificationTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListWorkersWithQualificationTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  NotifyWorkers


        /// <summary>
        /// The <c>NotifyWorkers</c> operation sends an email to one or more Workers that you
        /// specify with the Worker ID. You can specify up to 100 Worker IDs to send the same
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NotifyWorkersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NotifyWorkersResponseUnmarshaller.Instance;

            return Invoke<NotifyWorkersResponse>(request, options);
        }


        /// <summary>
        /// The <c>NotifyWorkers</c> operation sends an email to one or more Workers that you
        /// specify with the Worker ID. You can specify up to 100 Worker IDs to send the same
        /// message with a single call to the NotifyWorkers operation. The NotifyWorkers operation
        /// will send a notification email to a Worker only if you have previously approved or
        /// rejected work from the Worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NotifyWorkers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<NotifyWorkersResponse> NotifyWorkersAsync(NotifyWorkersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NotifyWorkersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NotifyWorkersResponseUnmarshaller.Instance;
            
            return InvokeAsync<NotifyWorkersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectAssignment


        /// <summary>
        /// The <c>RejectAssignment</c> operation rejects the results of a completed assignment.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectAssignmentResponseUnmarshaller.Instance;

            return Invoke<RejectAssignmentResponse>(request, options);
        }


        /// <summary>
        /// The <c>RejectAssignment</c> operation rejects the results of a completed assignment.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RejectAssignmentResponse> RejectAssignmentAsync(RejectAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectAssignmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<RejectAssignmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectQualificationRequest


        /// <summary>
        /// The <c>RejectQualificationRequest</c> operation rejects a user's request for a Qualification.
        /// 
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectQualificationRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectQualificationRequestResponseUnmarshaller.Instance;

            return Invoke<RejectQualificationRequestResponse>(request, options);
        }


        /// <summary>
        /// The <c>RejectQualificationRequest</c> operation rejects a user's request for a Qualification.
        /// 
        /// 
        ///  
        /// <para>
        ///  You can provide a text message explaining why the request was rejected. The Worker
        /// who made the request can see this message.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectQualificationRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RejectQualificationRequestResponse> RejectQualificationRequestAsync(RejectQualificationRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectQualificationRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectQualificationRequestResponseUnmarshaller.Instance;
            
            return InvokeAsync<RejectQualificationRequestResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendBonus


        /// <summary>
        /// The <c>SendBonus</c> operation issues a payment of money from your account to a Worker.
        /// This payment happens separately from the reward you pay to the Worker when you approve
        /// the Worker's assignment. The SendBonus operation requires the Worker's ID and the
        /// assignment ID as parameters to initiate payment of the bonus. You must include a message
        /// that explains the reason for the bonus payment, as the Worker may not be expecting
        /// the payment. Amazon Mechanical Turk collects a fee for bonus payments, similar to
        /// the HIT listing fee. This operation fails if your account does not have enough funds
        /// to pay for both the bonus and the fees.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendBonusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendBonusResponseUnmarshaller.Instance;

            return Invoke<SendBonusResponse>(request, options);
        }


        /// <summary>
        /// The <c>SendBonus</c> operation issues a payment of money from your account to a Worker.
        /// This payment happens separately from the reward you pay to the Worker when you approve
        /// the Worker's assignment. The SendBonus operation requires the Worker's ID and the
        /// assignment ID as parameters to initiate payment of the bonus. You must include a message
        /// that explains the reason for the bonus payment, as the Worker may not be expecting
        /// the payment. Amazon Mechanical Turk collects a fee for bonus payments, similar to
        /// the HIT listing fee. This operation fails if your account does not have enough funds
        /// to pay for both the bonus and the fees.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendBonus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<SendBonusResponse> SendBonusAsync(SendBonusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendBonusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendBonusResponseUnmarshaller.Instance;
            
            return InvokeAsync<SendBonusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendTestEventNotification


        /// <summary>
        /// The <c>SendTestEventNotification</c> operation causes Amazon Mechanical Turk to send
        /// a notification message as if a HIT event occurred, according to the provided notification
        /// specification. This allows you to test notifications without setting up notifications
        /// for a real HIT type and trying to trigger them using the website. When you call this
        /// operation, the service attempts to send the test notification immediately.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendTestEventNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendTestEventNotificationResponseUnmarshaller.Instance;

            return Invoke<SendTestEventNotificationResponse>(request, options);
        }


        /// <summary>
        /// The <c>SendTestEventNotification</c> operation causes Amazon Mechanical Turk to send
        /// a notification message as if a HIT event occurred, according to the provided notification
        /// specification. This allows you to test notifications without setting up notifications
        /// for a real HIT type and trying to trigger them using the website. When you call this
        /// operation, the service attempts to send the test notification immediately.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendTestEventNotification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<SendTestEventNotificationResponse> SendTestEventNotificationAsync(SendTestEventNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendTestEventNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendTestEventNotificationResponseUnmarshaller.Instance;
            
            return InvokeAsync<SendTestEventNotificationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateExpirationForHIT


        /// <summary>
        /// The <c>UpdateExpirationForHIT</c> operation allows you update the expiration time
        /// of a HIT. If you update it to a time in the past, the HIT will be immediately expired.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateExpirationForHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExpirationForHITResponseUnmarshaller.Instance;

            return Invoke<UpdateExpirationForHITResponse>(request, options);
        }


        /// <summary>
        /// The <c>UpdateExpirationForHIT</c> operation allows you update the expiration time
        /// of a HIT. If you update it to a time in the past, the HIT will be immediately expired.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExpirationForHIT service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateExpirationForHITResponse> UpdateExpirationForHITAsync(UpdateExpirationForHITRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateExpirationForHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExpirationForHITResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateExpirationForHITResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateHITReviewStatus


        /// <summary>
        /// The <c>UpdateHITReviewStatus</c> operation updates the status of a HIT. If the status
        /// is Reviewable, this operation can update the status to Reviewing, or it can revert
        /// a Reviewing HIT back to the Reviewable status.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateHITReviewStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHITReviewStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateHITReviewStatusResponse>(request, options);
        }


        /// <summary>
        /// The <c>UpdateHITReviewStatus</c> operation updates the status of a HIT. If the status
        /// is Reviewable, this operation can update the status to Reviewing, or it can revert
        /// a Reviewing HIT back to the Reviewable status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHITReviewStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateHITReviewStatusResponse> UpdateHITReviewStatusAsync(UpdateHITReviewStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateHITReviewStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHITReviewStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateHITReviewStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateHITTypeOfHIT


        /// <summary>
        /// The <c>UpdateHITTypeOfHIT</c> operation allows you to change the HITType properties
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateHITTypeOfHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHITTypeOfHITResponseUnmarshaller.Instance;

            return Invoke<UpdateHITTypeOfHITResponse>(request, options);
        }


        /// <summary>
        /// The <c>UpdateHITTypeOfHIT</c> operation allows you to change the HITType properties
        /// of a HIT. This operation disassociates the HIT from its old HITType properties and
        /// associates it with the new HITType properties. The HIT takes on the properties of
        /// the new HITType in place of the old ones.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHITTypeOfHIT service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateHITTypeOfHITResponse> UpdateHITTypeOfHITAsync(UpdateHITTypeOfHITRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateHITTypeOfHITRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHITTypeOfHITResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateHITTypeOfHITResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateNotificationSettings


        /// <summary>
        /// The <c>UpdateNotificationSettings</c> operation creates, updates, disables or re-enables
        /// notifications for a HIT type. If you call the UpdateNotificationSettings operation
        /// for a HIT type that already has a notification specification, the operation replaces
        /// the old specification with a new one. You can call the UpdateNotificationSettings
        /// operation to enable or disable notifications for the HIT type, without having to modify
        /// the notification specification itself by providing updates to the Active status without
        /// specifying a new notification specification. To change the Active status of a HIT
        /// type's notifications, the HIT type must already have a notification specification,
        /// or one must be provided in the same call to <c>UpdateNotificationSettings</c>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNotificationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotificationSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateNotificationSettingsResponse>(request, options);
        }


        /// <summary>
        /// The <c>UpdateNotificationSettings</c> operation creates, updates, disables or re-enables
        /// notifications for a HIT type. If you call the UpdateNotificationSettings operation
        /// for a HIT type that already has a notification specification, the operation replaces
        /// the old specification with a new one. You can call the UpdateNotificationSettings
        /// operation to enable or disable notifications for the HIT type, without having to modify
        /// the notification specification itself by providing updates to the Active status without
        /// specifying a new notification specification. To change the Active status of a HIT
        /// type's notifications, the HIT type must already have a notification specification,
        /// or one must be provided in the same call to <c>UpdateNotificationSettings</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotificationSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateNotificationSettingsResponse> UpdateNotificationSettingsAsync(UpdateNotificationSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNotificationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotificationSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateNotificationSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateQualificationType


        /// <summary>
        /// The <c>UpdateQualificationType</c> operation modifies the attributes of an existing
        /// Qualification type, which is represented by a QualificationType data structure. Only
        /// the owner of a Qualification type can modify its attributes. 
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQualificationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQualificationTypeResponseUnmarshaller.Instance;

            return Invoke<UpdateQualificationTypeResponse>(request, options);
        }


        /// <summary>
        /// The <c>UpdateQualificationType</c> operation modifies the attributes of an existing
        /// Qualification type, which is represented by a QualificationType data structure. Only
        /// the owner of a Qualification type can modify its attributes. 
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateQualificationTypeResponse> UpdateQualificationTypeAsync(UpdateQualificationTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQualificationTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQualificationTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateQualificationTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}