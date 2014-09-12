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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.AWSSupport.Model;
using Amazon.AWSSupport.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AWSSupport
{
    /// <summary>
    /// Implementation for accessing AWSSupport
    ///
    /// AWS Support            
    /// <para>
    /// The AWS Support API reference is intended for programmers who need detailed information
    /// about the AWS Support operations and data types. This service enables you to manage
    /// your AWS Support cases programmatically. It uses HTTP methods that return results
    /// in JSON format.
    /// </para>
    ///         
    /// <para>
    /// The AWS Support service also exposes a set of <a href="https://aws.amazon.com/support/trustedadvisor">Trusted
    /// Advisor</a> features. You can retrieve a list of checks and their descriptions, get
    /// check results, specify checks to refresh, and get the refresh status of checks. 
    /// </para>
    ///          
    /// <para>
    /// The following list describes the AWS Support case management operations: 
    /// </para>
    ///     <ul>      <li><b>Service names, issue categories, and available severity levels.
    /// </b>The <a>DescribeServices</a> and <a>DescribeSeverityLevels</a> operations return
    /// AWS service names, service codes, service categories, and problem severity levels.
    /// You use these values when you call the <a>CreateCase</a> operation. </li>      <li><b>Case
    /// creation, case details, and case resolution.</b> The <a>CreateCase</a>, <a>DescribeCases</a>,
    /// <a>DescribeAttachment</a>, and <a>ResolveCase</a> operations create AWS Support cases,
    /// retrieve information about cases, and resolve cases.</li>      <li><b>Case communication.</b>
    /// The <a>DescribeCommunications</a>, <a>AddCommunicationToCase</a>, and <a>AddAttachmentsToSet</a>
    /// operations retrieve and add communications and attachments to AWS Support cases. </li>
    ///    </ul>        
    /// <para>
    /// The following list describes the operations available from the AWS Support service
    /// for  Trusted Advisor:
    /// </para>
    ///     <ul>      <li><a>DescribeTrustedAdvisorChecks</a> returns the list of checks that
    /// run against your AWS resources.</li>       <li>Using the <code>CheckId</code> for
    /// a specific check returned by <a>DescribeTrustedAdvisorChecks</a>, you can call <a>DescribeTrustedAdvisorCheckResult</a>
    /// to obtain the results for the check you specified.</li>       <li><a>DescribeTrustedAdvisorCheckSummaries</a>
    /// returns summarized results for one or more Trusted Advisor checks.</li>      <li><a>RefreshTrustedAdvisorCheck</a>
    /// requests that Trusted Advisor rerun a specified check. </li>      <li><a>DescribeTrustedAdvisorCheckRefreshStatuses</a>
    /// reports the refresh status of one or more checks.  </li>    </ul>            
    /// <para>
    /// For authentication of requests, AWS Support uses <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 Signing Process</a>.
    /// </para>
    ///         
    /// <para>
    /// See <a href="http://docs.aws.amazon.com/awssupport/latest/user/Welcome.html">About
    /// the AWS Support API</a> in the <i>AWS Support User Guide</i> for information about
    /// how to use this service to create and manage your support cases, and how to call Trusted
    /// Advisor for results of checks on your resources. 
    /// </para>
    /// </summary>
    public partial class AmazonAWSSupportClient : AmazonServiceClient, IAmazonAWSSupport
    {
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonAWSSupportClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAWSSupportClient(AWSCredentials credentials)
            : this(credentials, new AmazonAWSSupportConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAWSSupportClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAWSSupportClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAWSSupportConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAWSSupportClient with AWS Credentials and an
        /// AmazonAWSSupportClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAWSSupportClient Configuration Object</param>
        public AmazonAWSSupportClient(AWSCredentials credentials, AmazonAWSSupportConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAWSSupportClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAWSSupportClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAWSSupportConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAWSSupportClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAWSSupportClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAWSSupportConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAWSSupportClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAWSSupportClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAWSSupportClient Configuration Object</param>
        public AmazonAWSSupportClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAWSSupportConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAWSSupportClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAWSSupportClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAWSSupportConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAWSSupportClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAWSSupportClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAWSSupportConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAWSSupportClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAWSSupportClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAWSSupportClient Configuration Object</param>
        public AmazonAWSSupportClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAWSSupportConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 


        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  AddAttachmentsToSet

        internal AddAttachmentsToSetResponse AddAttachmentsToSet(AddAttachmentsToSetRequest request)
        {
            var marshaller = new AddAttachmentsToSetRequestMarshaller();
            var unmarshaller = AddAttachmentsToSetResponseUnmarshaller.Instance;

            return Invoke<AddAttachmentsToSetRequest,AddAttachmentsToSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddAttachmentsToSet operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddAttachmentsToSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AddAttachmentsToSetResponse> AddAttachmentsToSetAsync(AddAttachmentsToSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddAttachmentsToSetRequestMarshaller();
            var unmarshaller = AddAttachmentsToSetResponseUnmarshaller.Instance;

            return InvokeAsync<AddAttachmentsToSetRequest,AddAttachmentsToSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AddCommunicationToCase

        internal AddCommunicationToCaseResponse AddCommunicationToCase(AddCommunicationToCaseRequest request)
        {
            var marshaller = new AddCommunicationToCaseRequestMarshaller();
            var unmarshaller = AddCommunicationToCaseResponseUnmarshaller.Instance;

            return Invoke<AddCommunicationToCaseRequest,AddCommunicationToCaseResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddCommunicationToCase operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddCommunicationToCase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AddCommunicationToCaseResponse> AddCommunicationToCaseAsync(AddCommunicationToCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddCommunicationToCaseRequestMarshaller();
            var unmarshaller = AddCommunicationToCaseResponseUnmarshaller.Instance;

            return InvokeAsync<AddCommunicationToCaseRequest,AddCommunicationToCaseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateCase

        internal CreateCaseResponse CreateCase(CreateCaseRequest request)
        {
            var marshaller = new CreateCaseRequestMarshaller();
            var unmarshaller = CreateCaseResponseUnmarshaller.Instance;

            return Invoke<CreateCaseRequest,CreateCaseResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCase operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateCaseResponse> CreateCaseAsync(CreateCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCaseRequestMarshaller();
            var unmarshaller = CreateCaseResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCaseRequest,CreateCaseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAttachment

        internal DescribeAttachmentResponse DescribeAttachment(DescribeAttachmentRequest request)
        {
            var marshaller = new DescribeAttachmentRequestMarshaller();
            var unmarshaller = DescribeAttachmentResponseUnmarshaller.Instance;

            return Invoke<DescribeAttachmentRequest,DescribeAttachmentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAttachment operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAttachment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeAttachmentResponse> DescribeAttachmentAsync(DescribeAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAttachmentRequestMarshaller();
            var unmarshaller = DescribeAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAttachmentRequest,DescribeAttachmentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeCases

        internal DescribeCasesResponse DescribeCases(DescribeCasesRequest request)
        {
            var marshaller = new DescribeCasesRequestMarshaller();
            var unmarshaller = DescribeCasesResponseUnmarshaller.Instance;

            return Invoke<DescribeCasesRequest,DescribeCasesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCases operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeCasesResponse> DescribeCasesAsync(DescribeCasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCasesRequestMarshaller();
            var unmarshaller = DescribeCasesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCasesRequest,DescribeCasesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeCommunications

        internal DescribeCommunicationsResponse DescribeCommunications(DescribeCommunicationsRequest request)
        {
            var marshaller = new DescribeCommunicationsRequestMarshaller();
            var unmarshaller = DescribeCommunicationsResponseUnmarshaller.Instance;

            return Invoke<DescribeCommunicationsRequest,DescribeCommunicationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCommunications operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCommunications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeCommunicationsResponse> DescribeCommunicationsAsync(DescribeCommunicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCommunicationsRequestMarshaller();
            var unmarshaller = DescribeCommunicationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCommunicationsRequest,DescribeCommunicationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeServices

        internal DescribeServicesResponse DescribeServices()
        {
            return DescribeServices(new DescribeServicesRequest());
        }
        internal DescribeServicesResponse DescribeServices(DescribeServicesRequest request)
        {
            var marshaller = new DescribeServicesRequestMarshaller();
            var unmarshaller = DescribeServicesResponseUnmarshaller.Instance;

            return Invoke<DescribeServicesRequest,DescribeServicesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServices operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeServicesResponse> DescribeServicesAsync(DescribeServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeServicesRequestMarshaller();
            var unmarshaller = DescribeServicesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeServicesRequest,DescribeServicesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSeverityLevels

        internal DescribeSeverityLevelsResponse DescribeSeverityLevels()
        {
            return DescribeSeverityLevels(new DescribeSeverityLevelsRequest());
        }
        internal DescribeSeverityLevelsResponse DescribeSeverityLevels(DescribeSeverityLevelsRequest request)
        {
            var marshaller = new DescribeSeverityLevelsRequestMarshaller();
            var unmarshaller = DescribeSeverityLevelsResponseUnmarshaller.Instance;

            return Invoke<DescribeSeverityLevelsRequest,DescribeSeverityLevelsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSeverityLevels operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSeverityLevels operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeSeverityLevelsResponse> DescribeSeverityLevelsAsync(DescribeSeverityLevelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSeverityLevelsRequestMarshaller();
            var unmarshaller = DescribeSeverityLevelsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSeverityLevelsRequest,DescribeSeverityLevelsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTrustedAdvisorCheckRefreshStatuses

        internal DescribeTrustedAdvisorCheckRefreshStatusesResponse DescribeTrustedAdvisorCheckRefreshStatuses(DescribeTrustedAdvisorCheckRefreshStatusesRequest request)
        {
            var marshaller = new DescribeTrustedAdvisorCheckRefreshStatusesRequestMarshaller();
            var unmarshaller = DescribeTrustedAdvisorCheckRefreshStatusesResponseUnmarshaller.Instance;

            return Invoke<DescribeTrustedAdvisorCheckRefreshStatusesRequest,DescribeTrustedAdvisorCheckRefreshStatusesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrustedAdvisorCheckRefreshStatuses operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorCheckRefreshStatuses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeTrustedAdvisorCheckRefreshStatusesResponse> DescribeTrustedAdvisorCheckRefreshStatusesAsync(DescribeTrustedAdvisorCheckRefreshStatusesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTrustedAdvisorCheckRefreshStatusesRequestMarshaller();
            var unmarshaller = DescribeTrustedAdvisorCheckRefreshStatusesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTrustedAdvisorCheckRefreshStatusesRequest,DescribeTrustedAdvisorCheckRefreshStatusesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTrustedAdvisorCheckResult

        internal DescribeTrustedAdvisorCheckResultResponse DescribeTrustedAdvisorCheckResult(DescribeTrustedAdvisorCheckResultRequest request)
        {
            var marshaller = new DescribeTrustedAdvisorCheckResultRequestMarshaller();
            var unmarshaller = DescribeTrustedAdvisorCheckResultResponseUnmarshaller.Instance;

            return Invoke<DescribeTrustedAdvisorCheckResultRequest,DescribeTrustedAdvisorCheckResultResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrustedAdvisorCheckResult operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorCheckResult operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeTrustedAdvisorCheckResultResponse> DescribeTrustedAdvisorCheckResultAsync(DescribeTrustedAdvisorCheckResultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTrustedAdvisorCheckResultRequestMarshaller();
            var unmarshaller = DescribeTrustedAdvisorCheckResultResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTrustedAdvisorCheckResultRequest,DescribeTrustedAdvisorCheckResultResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTrustedAdvisorChecks

        internal DescribeTrustedAdvisorChecksResponse DescribeTrustedAdvisorChecks(DescribeTrustedAdvisorChecksRequest request)
        {
            var marshaller = new DescribeTrustedAdvisorChecksRequestMarshaller();
            var unmarshaller = DescribeTrustedAdvisorChecksResponseUnmarshaller.Instance;

            return Invoke<DescribeTrustedAdvisorChecksRequest,DescribeTrustedAdvisorChecksResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrustedAdvisorChecks operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorChecks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeTrustedAdvisorChecksResponse> DescribeTrustedAdvisorChecksAsync(DescribeTrustedAdvisorChecksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTrustedAdvisorChecksRequestMarshaller();
            var unmarshaller = DescribeTrustedAdvisorChecksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTrustedAdvisorChecksRequest,DescribeTrustedAdvisorChecksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTrustedAdvisorCheckSummaries

        internal DescribeTrustedAdvisorCheckSummariesResponse DescribeTrustedAdvisorCheckSummaries(DescribeTrustedAdvisorCheckSummariesRequest request)
        {
            var marshaller = new DescribeTrustedAdvisorCheckSummariesRequestMarshaller();
            var unmarshaller = DescribeTrustedAdvisorCheckSummariesResponseUnmarshaller.Instance;

            return Invoke<DescribeTrustedAdvisorCheckSummariesRequest,DescribeTrustedAdvisorCheckSummariesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrustedAdvisorCheckSummaries operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorCheckSummaries operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeTrustedAdvisorCheckSummariesResponse> DescribeTrustedAdvisorCheckSummariesAsync(DescribeTrustedAdvisorCheckSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTrustedAdvisorCheckSummariesRequestMarshaller();
            var unmarshaller = DescribeTrustedAdvisorCheckSummariesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTrustedAdvisorCheckSummariesRequest,DescribeTrustedAdvisorCheckSummariesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RefreshTrustedAdvisorCheck

        internal RefreshTrustedAdvisorCheckResponse RefreshTrustedAdvisorCheck(RefreshTrustedAdvisorCheckRequest request)
        {
            var marshaller = new RefreshTrustedAdvisorCheckRequestMarshaller();
            var unmarshaller = RefreshTrustedAdvisorCheckResponseUnmarshaller.Instance;

            return Invoke<RefreshTrustedAdvisorCheckRequest,RefreshTrustedAdvisorCheckResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RefreshTrustedAdvisorCheck operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RefreshTrustedAdvisorCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RefreshTrustedAdvisorCheckResponse> RefreshTrustedAdvisorCheckAsync(RefreshTrustedAdvisorCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RefreshTrustedAdvisorCheckRequestMarshaller();
            var unmarshaller = RefreshTrustedAdvisorCheckResponseUnmarshaller.Instance;

            return InvokeAsync<RefreshTrustedAdvisorCheckRequest,RefreshTrustedAdvisorCheckResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResolveCase

        internal ResolveCaseResponse ResolveCase(ResolveCaseRequest request)
        {
            var marshaller = new ResolveCaseRequestMarshaller();
            var unmarshaller = ResolveCaseResponseUnmarshaller.Instance;

            return Invoke<ResolveCaseRequest,ResolveCaseResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResolveCase operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResolveCase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ResolveCaseResponse> ResolveCaseAsync(ResolveCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResolveCaseRequestMarshaller();
            var unmarshaller = ResolveCaseResponseUnmarshaller.Instance;

            return InvokeAsync<ResolveCaseRequest,ResolveCaseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}