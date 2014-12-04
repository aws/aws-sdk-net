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
    /// The AWS Support service also exposes a set of <a href="https://aws.amazon.com/premiumsupport/trustedadvisor/">Trusted
    /// Advisor</a> features. You can retrieve a list of checks and their descriptions, get
    /// check results, specify checks to refresh, and get the refresh status of checks. 
    /// </para>
    ///  
    /// <para>
    /// The following list describes the AWS Support case management operations: 
    /// </para>
    ///  <ul> <li> <b>Service names, issue categories, and available severity levels. </b>The
    /// <a>DescribeServices</a> and <a>DescribeSeverityLevels</a> operations return AWS service
    /// names, service codes, service categories, and problem severity levels. You use these
    /// values when you call the <a>CreateCase</a> operation. </li> <li> <b>Case creation,
    /// case details, and case resolution.</b> The <a>CreateCase</a>, <a>DescribeCases</a>,
    /// <a>DescribeAttachment</a>, and <a>ResolveCase</a> operations create AWS Support cases,
    /// retrieve information about cases, and resolve cases.</li> <li> <b>Case communication.</b>
    /// The <a>DescribeCommunications</a>, <a>AddCommunicationToCase</a>, and <a>AddAttachmentsToSet</a>
    /// operations retrieve and add communications and attachments to AWS Support cases. </li>
    /// </ul> 
    /// <para>
    /// The following list describes the operations available from the AWS Support service
    /// for Trusted Advisor:
    /// </para>
    ///  <ul> <li> <a>DescribeTrustedAdvisorChecks</a> returns the list of checks that run
    /// against your AWS resources.</li> <li>Using the <code>CheckId</code> for a specific
    /// check returned by <a>DescribeTrustedAdvisorChecks</a>, you can call <a>DescribeTrustedAdvisorCheckResult</a>
    /// to obtain the results for the check you specified.</li> <li> <a>DescribeTrustedAdvisorCheckSummaries</a>
    /// returns summarized results for one or more Trusted Advisor checks.</li> <li> <a>RefreshTrustedAdvisorCheck</a>
    /// requests that Trusted Advisor rerun a specified check. </li> <li> <a>DescribeTrustedAdvisorCheckRefreshStatuses</a>
    /// reports the refresh status of one or more checks. </li> </ul> 
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
        /// Constructs AmazonAWSSupportClient with the credentials loaded from the application's
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
        public AmazonAWSSupportClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAWSSupportConfig()) { }

        /// <summary>
        /// Constructs AmazonAWSSupportClient with the credentials loaded from the application's
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
        public AmazonAWSSupportClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAWSSupportConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAWSSupportClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAWSSupportClient Configuration Object</param>
        public AmazonAWSSupportClient(AmazonAWSSupportConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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

        /// <summary>
        /// Adds one or more attachments to an attachment set. If an <code>AttachmentSetId</code>
        /// is not specified, a new attachment set is created, and the ID of the set is returned
        /// in the response. If an <code>AttachmentSetId</code> is specified, the attachments
        /// are added to the specified set, if it exists.
        /// 
        ///  
        /// <para>
        /// An attachment set is a temporary container for attachments that are to be added to
        /// a case or case communication. The set is available for one hour after it is created;
        /// the <code>ExpiryTime</code> returned in the response indicates when the set expires.
        /// The maximum number of attachments in a set is 3, and the maximum size of any attachment
        /// in the set is 5 MB.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddAttachmentsToSet service method.</param>
        /// 
        /// <returns>The response from the AddAttachmentsToSet service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.AttachmentLimitExceededException">
        /// The limit for the number of attachment sets created in a short period of time has
        /// been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.AttachmentSetExpiredException">
        /// The expiration time of the attachment set has passed. The set expires 1 hour after
        /// it is created.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.AttachmentSetIdNotFoundException">
        /// An attachment set with the specified ID could not be found.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.AttachmentSetSizeLimitExceededException">
        /// A limit for the size of an attachment set has been exceeded. The limits are 3 attachments
        /// and 5 MB per attachment.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        public AddAttachmentsToSetResponse AddAttachmentsToSet(AddAttachmentsToSetRequest request)
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

        /// <summary>
        /// Adds additional customer communication to an AWS Support case. You use the <code>CaseId</code>
        /// value to identify the case to add communication to. You can list a set of email addresses
        /// to copy on the communication using the <code>CcEmailAddresses</code> value. The <code>CommunicationBody</code>
        /// value contains the text of the communication.
        /// 
        ///  
        /// <para>
        /// The response indicates the success or failure of the request.
        /// </para>
        ///  
        /// <para>
        /// This operation implements a subset of the features of the AWS Support Center.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddCommunicationToCase service method.</param>
        /// 
        /// <returns>The response from the AddCommunicationToCase service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.AttachmentSetExpiredException">
        /// The expiration time of the attachment set has passed. The set expires 1 hour after
        /// it is created.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.AttachmentSetIdNotFoundException">
        /// An attachment set with the specified ID could not be found.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.CaseIdNotFoundException">
        /// The requested <code>CaseId</code> could not be located.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        public AddCommunicationToCaseResponse AddCommunicationToCase(AddCommunicationToCaseRequest request)
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

        /// <summary>
        /// Creates a new case in the AWS Support Center. This operation is modeled on the behavior
        /// of the AWS Support Center <a href="https://console.aws.amazon.com/support/home#/case/create">Create
        /// Case</a> page. Its parameters require you to specify the following information: 
        /// 
        ///  <ol> <li> <b>IssueType.</b> The type of issue for the case. You can specify either
        /// "customer-service" or "technical." If you do not indicate a value, the default is
        /// "technical." </li> <li> <b>ServiceCode.</b> The code for an AWS service. You obtain
        /// the <code>ServiceCode</code> by calling <a>DescribeServices</a>. </li> <li> <b>CategoryCode.</b>
        /// The category for the service defined for the <code>ServiceCode</code> value. You also
        /// obtain the category code for a service by calling <a>DescribeServices</a>. Each AWS
        /// service defines its own set of category codes. </li> <li> <b>SeverityCode.</b> A value
        /// that indicates the urgency of the case, which in turn determines the response time
        /// according to your service level agreement with AWS Support. You obtain the SeverityCode
        /// by calling <a>DescribeSeverityLevels</a>.</li> <li> <b>Subject.</b> The <b>Subject</b>
        /// field on the AWS Support Center <a href="https://console.aws.amazon.com/support/home#/case/create">Create
        /// Case</a> page.</li> <li> <b>CommunicationBody.</b> The <b>Description</b> field on
        /// the AWS Support Center <a href="https://console.aws.amazon.com/support/home#/case/create">Create
        /// Case</a> page.</li> <li> <b>AttachmentSetId.</b> The ID of a set of attachments that
        /// has been created by using <a>AddAttachmentsToSet</a>.</li> <li> <b>Language.</b> The
        /// human language in which AWS Support handles the case. English and Japanese are currently
        /// supported.</li> <li> <b>CcEmailAddresses.</b> The AWS Support Center <b>CC</b> field
        /// on the <a href="https://console.aws.amazon.com/support/home#/case/create">Create Case</a>
        /// page. You can list email addresses to be copied on any correspondence about the case.
        /// The account that opens the case is already identified by passing the AWS Credentials
        /// in the HTTP POST method or in a method or function call from one of the programming
        /// languages supported by an <a href="http://aws.amazon.com/tools/">AWS SDK</a>. </li>
        /// </ol> <note>
        /// <para>
        /// To add additional communication or attachments to an existing case, use <a>AddCommunicationToCase</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// A successful <a>CreateCase</a> request returns an AWS Support case number. Case numbers
        /// are used by the <a>DescribeCases</a> operation to retrieve existing AWS Support cases.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCase service method.</param>
        /// 
        /// <returns>The response from the CreateCase service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.AttachmentSetExpiredException">
        /// The expiration time of the attachment set has passed. The set expires 1 hour after
        /// it is created.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.AttachmentSetIdNotFoundException">
        /// An attachment set with the specified ID could not be found.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.CaseCreationLimitExceededException">
        /// The case creation limit for the account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        public CreateCaseResponse CreateCase(CreateCaseRequest request)
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

        /// <summary>
        /// Returns the attachment that has the specified ID. Attachment IDs are generated by
        /// the case management system when you add an attachment to a case or case communication.
        /// Attachment IDs are returned in the <a>AttachmentDetails</a> objects that are returned
        /// by the <a>DescribeCommunications</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAttachment service method.</param>
        /// 
        /// <returns>The response from the DescribeAttachment service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.AttachmentIdNotFoundException">
        /// An attachment with the specified ID could not be found.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.DescribeAttachmentLimitExceededException">
        /// The limit for the number of <a>DescribeAttachment</a> requests in a short period of
        /// time has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        public DescribeAttachmentResponse DescribeAttachment(DescribeAttachmentRequest request)
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

        /// <summary>
        /// Returns a list of cases that you specify by passing one or more case IDs. In addition,
        /// you can filter the cases by date by setting values for the <code>AfterTime</code>
        /// and <code>BeforeTime</code> request parameters. You can set values for the <code>IncludeResolvedCases</code>
        /// and <code>IncludeCommunications</code> request parameters to control how much information
        /// is returned. 
        /// 
        ///  
        /// <para>
        /// Case data is available for 12 months after creation. If a case was created more than
        /// 12 months ago, a request for data might cause an error. 
        /// </para>
        ///  
        /// <para>
        /// The response returns the following in JSON format:
        /// </para>
        ///  <ol> <li>One or more <a>CaseDetails</a> data types. </li> <li>One or more <code>NextToken</code>
        /// values, which specify where to paginate the returned records represented by the <code>CaseDetails</code>
        /// objects.</li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCases service method.</param>
        /// 
        /// <returns>The response from the DescribeCases service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.CaseIdNotFoundException">
        /// The requested <code>CaseId</code> could not be located.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        public DescribeCasesResponse DescribeCases(DescribeCasesRequest request)
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

        /// <summary>
        /// Returns communications (and attachments) for one or more support cases. You can use
        /// the <code>AfterTime</code> and <code>BeforeTime</code> parameters to filter by date.
        /// You can use the <code>CaseId</code> parameter to restrict the results to a particular
        /// case.
        /// 
        ///  
        /// <para>
        /// Case data is available for 12 months after creation. If a case was created more than
        /// 12 months ago, a request for data might cause an error. 
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>MaxResults</code> and <code>NextToken</code> parameters to control
        /// the pagination of the result set. Set <code>MaxResults</code> to the number of cases
        /// you want displayed on each page, and use <code>NextToken</code> to specify the resumption
        /// of pagination.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCommunications service method.</param>
        /// 
        /// <returns>The response from the DescribeCommunications service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.CaseIdNotFoundException">
        /// The requested <code>CaseId</code> could not be located.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        public DescribeCommunicationsResponse DescribeCommunications(DescribeCommunicationsRequest request)
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

        /// <summary>
        /// Returns the current list of AWS services and a list of service categories that applies
        /// to each one. You then use service names and categories in your <a>CreateCase</a> requests.
        /// Each AWS service has its own set of categories.
        /// 
        ///  
        /// <para>
        /// The service codes and category codes correspond to the values that are displayed in
        /// the <b>Service</b> and <b>Category</b> drop-down lists on the AWS Support Center <a
        /// href="https://console.aws.amazon.com/support/home#/case/create">Create Case</a> page.
        /// The values in those fields, however, do not necessarily match the service codes and
        /// categories returned by the <code>DescribeServices</code> request. Always use the service
        /// codes and categories obtained programmatically. This practice ensures that you always
        /// have the most recent set of service and category codes.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeServices service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        public DescribeServicesResponse DescribeServices()
        {
            return DescribeServices(new DescribeServicesRequest());
        }

        /// <summary>
        /// Returns the current list of AWS services and a list of service categories that applies
        /// to each one. You then use service names and categories in your <a>CreateCase</a> requests.
        /// Each AWS service has its own set of categories.
        /// 
        ///  
        /// <para>
        /// The service codes and category codes correspond to the values that are displayed in
        /// the <b>Service</b> and <b>Category</b> drop-down lists on the AWS Support Center <a
        /// href="https://console.aws.amazon.com/support/home#/case/create">Create Case</a> page.
        /// The values in those fields, however, do not necessarily match the service codes and
        /// categories returned by the <code>DescribeServices</code> request. Always use the service
        /// codes and categories obtained programmatically. This practice ensures that you always
        /// have the most recent set of service and category codes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServices service method.</param>
        /// 
        /// <returns>The response from the DescribeServices service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        public DescribeServicesResponse DescribeServices(DescribeServicesRequest request)
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

        /// <summary>
        /// Returns the list of severity levels that you can assign to an AWS Support case. The
        /// severity level for a case is also a field in the <a>CaseDetails</a> data type included
        /// in any <a>CreateCase</a> request.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSeverityLevels service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        public DescribeSeverityLevelsResponse DescribeSeverityLevels()
        {
            return DescribeSeverityLevels(new DescribeSeverityLevelsRequest());
        }

        /// <summary>
        /// Returns the list of severity levels that you can assign to an AWS Support case. The
        /// severity level for a case is also a field in the <a>CaseDetails</a> data type included
        /// in any <a>CreateCase</a> request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSeverityLevels service method.</param>
        /// 
        /// <returns>The response from the DescribeSeverityLevels service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        public DescribeSeverityLevelsResponse DescribeSeverityLevels(DescribeSeverityLevelsRequest request)
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

        /// <summary>
        /// Returns the refresh status of the Trusted Advisor checks that have the specified check
        /// IDs. Check IDs can be obtained by calling <a>DescribeTrustedAdvisorChecks</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorCheckRefreshStatuses service method.</param>
        /// 
        /// <returns>The response from the DescribeTrustedAdvisorCheckRefreshStatuses service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        public DescribeTrustedAdvisorCheckRefreshStatusesResponse DescribeTrustedAdvisorCheckRefreshStatuses(DescribeTrustedAdvisorCheckRefreshStatusesRequest request)
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

        /// <summary>
        /// Returns the results of the Trusted Advisor check that has the specified check ID.
        /// Check IDs can be obtained by calling <a>DescribeTrustedAdvisorChecks</a>.
        /// 
        ///  
        /// <para>
        /// The response contains a <a>TrustedAdvisorCheckResult</a> object, which contains these
        /// three objects:
        /// </para>
        ///  <ul> <li><a>TrustedAdvisorCategorySpecificSummary</a></li> <li><a>TrustedAdvisorResourceDetail</a></li>
        /// <li><a>TrustedAdvisorResourcesSummary</a></li> </ul> 
        /// <para>
        /// In addition, the response contains these fields:
        /// </para>
        ///  <ul> <li> <b>Status.</b> The alert status of the check: "ok" (green), "warning" (yellow),
        /// "error" (red), or "not_available".</li> <li> <b>Timestamp.</b> The time of the last
        /// refresh of the check.</li> <li> <b>CheckId.</b> The unique identifier for the check.</li>
        /// </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorCheckResult service method.</param>
        /// 
        /// <returns>The response from the DescribeTrustedAdvisorCheckResult service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        public DescribeTrustedAdvisorCheckResultResponse DescribeTrustedAdvisorCheckResult(DescribeTrustedAdvisorCheckResultRequest request)
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

        /// <summary>
        /// Returns information about all available Trusted Advisor checks, including name, ID,
        /// category, description, and metadata. You must specify a language code; English ("en")
        /// and Japanese ("ja") are currently supported. The response contains a <a>TrustedAdvisorCheckDescription</a>
        /// for each check.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorChecks service method.</param>
        /// 
        /// <returns>The response from the DescribeTrustedAdvisorChecks service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        public DescribeTrustedAdvisorChecksResponse DescribeTrustedAdvisorChecks(DescribeTrustedAdvisorChecksRequest request)
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

        /// <summary>
        /// Returns the summaries of the results of the Trusted Advisor checks that have the specified
        /// check IDs. Check IDs can be obtained by calling <a>DescribeTrustedAdvisorChecks</a>.
        /// 
        ///  
        /// <para>
        /// The response contains an array of <a>TrustedAdvisorCheckSummary</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorCheckSummaries service method.</param>
        /// 
        /// <returns>The response from the DescribeTrustedAdvisorCheckSummaries service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        public DescribeTrustedAdvisorCheckSummariesResponse DescribeTrustedAdvisorCheckSummaries(DescribeTrustedAdvisorCheckSummariesRequest request)
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

        /// <summary>
        /// Requests a refresh of the Trusted Advisor check that has the specified check ID. Check
        /// IDs can be obtained by calling <a>DescribeTrustedAdvisorChecks</a>.
        /// 
        ///  
        /// <para>
        /// The response contains a <a>TrustedAdvisorCheckRefreshStatus</a> object, which contains
        /// these fields:
        /// </para>
        ///  <ul> <li> <b>Status.</b> The refresh status of the check: "none", "enqueued", "processing",
        /// "success", or "abandoned".</li> <li> <b>MillisUntilNextRefreshable.</b> The amount
        /// of time, in milliseconds, until the check is eligible for refresh.</li> <li> <b>CheckId.</b>
        /// The unique identifier for the check.</li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RefreshTrustedAdvisorCheck service method.</param>
        /// 
        /// <returns>The response from the RefreshTrustedAdvisorCheck service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        public RefreshTrustedAdvisorCheckResponse RefreshTrustedAdvisorCheck(RefreshTrustedAdvisorCheckRequest request)
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

        /// <summary>
        /// Takes a <code>CaseId</code> and returns the initial state of the case along with the
        /// state of the case after the call to <a>ResolveCase</a> completed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResolveCase service method.</param>
        /// 
        /// <returns>The response from the ResolveCase service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.CaseIdNotFoundException">
        /// The requested <code>CaseId</code> could not be located.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        public ResolveCaseResponse ResolveCase(ResolveCaseRequest request)
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