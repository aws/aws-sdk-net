/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Threading;

using Amazon.AWSSupport.Model;
using Amazon.AWSSupport.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.AWSSupport
{
    /// <summary>
    /// Implementation for accessing AmazonAWSSupport.
    ///  
    /// AWS Support <para>The AWS Support API reference is intended for programmers who need detailed information about the AWS Support actions and
    /// data types. This service enables you to manage your AWS Support cases programmatically. It uses HTTP methods that return results in JSON
    /// format.</para> <para>The AWS Support service also exposes a set of <a href="https://aws.amazon.com/support/trustedadvisor" >Trusted
    /// Advisor</a> features. You can retrieve a list of checks you can run on your resources, specify checks to run and refresh, and check the
    /// status of checks you have submitted. </para> <para>The following list describes the AWS Support case management actions: </para>
    /// <ul>
    /// <li> <b>Service names, issue categories, and available severity levels. </b> The actions <a
    /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeServices.html" >DescribeServices</a> and <a
    /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeSeverityLevels.html" >DescribeSeverityLevels</a> enable you to
    /// obtain AWS service names, service codes, service categories, and problem severity levels. You use these values when you call the <a
    /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CreateCase.html" >CreateCase</a> action. </li>
    /// <li> <b>Case Creation, case details, and case resolution</b> . The actions <a
    /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CreateCase.html" >CreateCase</a> ,
    /// <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeCases.html" >DescribeCases</a> , and <a
    /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_ResolveCase.html" >ResolveCase</a> enable you to create AWS Support
    /// cases, retrieve them, and resolve them.</li>
    /// <li> <b>Case communication</b> . The actions <a
    /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeCommunications.html" >DescribeCommunications</a> and <a
    /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_AddCommunicationToCase.html" >AddCommunicationToCase</a> enable you to
    /// retrieve and add communication to AWS Support cases. </li>
    /// 
    /// </ul>
    /// <para>The following list describes the actions available from the AWS Support service for Trusted Advisor:</para>
    /// <ul>
    /// <li> <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeTrustedAdvisorChecks.html"
    /// >DescribeTrustedAdvisorChecks</a> returns the list of checks that you can run against your AWS resources.</li>
    /// <li>Using the CheckId for a specific check returned by DescribeTrustedAdvisorChecks, you can call <a
    /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeTrustedAdvisorCheckResult.html"
    /// >DescribeTrustedAdvisorCheckResult</a> </li>
    /// and obtain a new result for the check you specified. <li> Using <a
    /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeTrustedAdvisorCheckSummaries.html"
    /// >DescribeTrustedAdvisorCheckSummaries</a> , you can get summaries for a set of Trusted Advisor checks.</li>
    /// <li> <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_RefreshTrustedAdvisorCheck.html"
    /// >RefreshTrustedAdvisorCheck</a> enables you to request that Trusted Advisor run the check again. </li>
    /// <li> <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeTrustedAdvisorCheckRefreshStatuses.html"
    /// >DescribeTrustedAdvisorCheckRefreshStatuses</a> gets statuses on the checks you are running. </li>
    /// 
    /// </ul>
    /// <para>For authentication of requests, the AWS Support uses <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html"
    /// >Signature Version 4 Signing Process</a> .</para> <para>See the AWS Support <a
    /// href="http://docs.aws.amazon.com/awssupport/latest/developerguide/Welcome.html" >Developer Guide</a> for information about how to use this
    /// service to manage create and manage your support cases, and how to call Trusted Advisor for results of checks on your resources. </para>
    /// </summary>
    public partial class AmazonAWSSupportClient : AmazonWebServiceClient, IAmazonAWSSupport
    {
    AWS4Signer signer = new AWS4Signer();

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

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
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonAWSSupportClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAWSSupportConfig(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonAWSSupportClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonAWSSupportClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAWSSupportConfig{RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonAWSSupportClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonAWSSupport Configuration Object</param>
        public AmazonAWSSupportClient(AmazonAWSSupportConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion


        #region AddCommunicationToCase

        /// <summary>
        /// <para>This action adds additional customer communication to an AWS Support case. You use the <i>CaseId</i> value to identify the case to
        /// which you want to add communication. You can list a set of email addresses to copy on the communication using the <i>CcEmailAddresses</i>
        /// value. The <i>CommunicationBody</i> value contains the text of the communication.</para> <para>This action's response indicates the success
        /// or failure of the request.</para> <para>This action implements a subset of the behavior on the AWS Support <a
        /// href="https://aws.amazon.com/support" >Your Support Cases</a> web form.</para>
        /// </summary>
        /// 
        /// <param name="addCommunicationToCaseRequest">Container for the necessary parameters to execute the AddCommunicationToCase service method on
        ///          AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the AddCommunicationToCase service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="CaseIdNotFoundException"/>
        public AddCommunicationToCaseResponse AddCommunicationToCase(AddCommunicationToCaseRequest addCommunicationToCaseRequest)
        {
            IAsyncResult asyncResult = invokeAddCommunicationToCase(addCommunicationToCaseRequest, null, null, true);
            return EndAddCommunicationToCase(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AddCommunicationToCase operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.AddCommunicationToCase"/>
        /// </summary>
        /// 
        /// <param name="addCommunicationToCaseRequest">Container for the necessary parameters to execute the AddCommunicationToCase operation on
        ///          AmazonAWSSupport.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndAddCommunicationToCase operation.</returns>
        public IAsyncResult BeginAddCommunicationToCase(AddCommunicationToCaseRequest addCommunicationToCaseRequest, AsyncCallback callback, object state)
        {
            return invokeAddCommunicationToCase(addCommunicationToCaseRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AddCommunicationToCase operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.AddCommunicationToCase"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddCommunicationToCase.</param>
        /// 
        /// <returns>Returns a AddCommunicationToCaseResult from AmazonAWSSupport.</returns>
        public AddCommunicationToCaseResponse EndAddCommunicationToCase(IAsyncResult asyncResult)
        {
            return endOperation<AddCommunicationToCaseResponse>(asyncResult);
        }
        
        IAsyncResult invokeAddCommunicationToCase(AddCommunicationToCaseRequest addCommunicationToCaseRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AddCommunicationToCaseRequestMarshaller().Marshall(addCommunicationToCaseRequest);
            var unmarshaller = AddCommunicationToCaseResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateCase

        /// <summary>
        /// <para>Creates a new case in the AWS Support Center. This action is modeled on the behavior of the AWS Support Center <a
        /// href="https://aws.amazon.com/support/createCase" >Open a new case</a> page. Its parameters require you to specify the following information:
        /// </para> <ol> <li> <b>ServiceCode.</b> Represents a code for an AWS service. You obtain the <i>ServiceCode</i> by calling <a
        /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeServices.html" >DescribeServices</a> . </li>
        /// <li> <b>CategoryCode</b> . Represents a category for the service defined for the ServiceCode value. You also obtain the cateogory code for
        /// a service by calling <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeServices.html" >DescribeServices</a> .
        /// Each AWS service defines its own set of category codes. </li>
        /// <li> <b>SeverityCode</b> . Represents a value that specifies the urgency of the case, and the time interval in which your service level
        /// agreement specifies a response from AWS Support. You obtain the SeverityCode by calling <a
        /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeSeverityLevels.html" >DescribeSeverityLevels</a> .</li>
        /// <li> <b>Subject</b> . Represents the <b>Subject</b> field on the AWS Support Center <a href="https://aws.amazon.com/support/createCase"
        /// >Open a new case</a> page.</li>
        /// <li> <b>CommunicationBody</b> . Represents the <b>Description</b> field on the AWS Support Center <a
        /// href="https://aws.amazon.com/support/createCase" >Open a new case</a> page.</li>
        /// <li> <b>Language</b> . Specifies the human language in which AWS Support handles the case. The API currently supports English and
        /// Japanese.</li>
        /// <li> <b>CcEmailAddresses</b> . Represents the AWS Support Center <b>CC</b> field on the <a
        /// href="https://aws.amazon.com/support/createCase" >Open a new case</a> page. You can list email addresses to be copied on any correspondence
        /// about the case. The account that opens the case is already identified by passing the AWS Credentials in the HTTP POST method or in a method
        /// or function call from one of the programming languages supported by an <a href="http://aws.amazon.com/tools/" >AWS SDK</a> . </li>
        /// <li> <b>IssueType</b> . Indicates the type of issue for the case. You can specify either "customer-service" or "technical." If you do not
        /// indicate a value, this parameter defaults to "technical." </li>
        /// </ol> <para><b>NOTE:</b>The AWS Support API does not currently support the ability to add attachments to cases. You can, however, call
        /// AddCommunicationToCase to add information to an open case. </para> <para>A successful <a
        /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CreateCase.html" >CreateCase</a> request returns an AWS Support case
        /// number. Case numbers are used by <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeCases.html"
        /// >DescribeCases</a> request to retrieve existing AWS Support support cases. </para>
        /// </summary>
        /// 
        /// <param name="createCaseRequest">Container for the necessary parameters to execute the CreateCase service method on AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the CreateCase service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="CaseCreationLimitExceededException"/>
        public CreateCaseResponse CreateCase(CreateCaseRequest createCaseRequest)
        {
            IAsyncResult asyncResult = invokeCreateCase(createCaseRequest, null, null, true);
            return EndCreateCase(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCase operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.CreateCase"/>
        /// </summary>
        /// 
        /// <param name="createCaseRequest">Container for the necessary parameters to execute the CreateCase operation on AmazonAWSSupport.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCase
        ///         operation.</returns>
        public IAsyncResult BeginCreateCase(CreateCaseRequest createCaseRequest, AsyncCallback callback, object state)
        {
            return invokeCreateCase(createCaseRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateCase operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.CreateCase"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCase.</param>
        /// 
        /// <returns>Returns a CreateCaseResult from AmazonAWSSupport.</returns>
        public CreateCaseResponse EndCreateCase(IAsyncResult asyncResult)
        {
            return endOperation<CreateCaseResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateCase(CreateCaseRequest createCaseRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateCaseRequestMarshaller().Marshall(createCaseRequest);
            var unmarshaller = CreateCaseResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeCases

        /// <summary>
        /// <para>This action returns a list of cases that you specify by passing one or more CaseIds. In addition, you can filter the cases by date by
        /// setting values for the AfterTime and BeforeTime request parameters. </para> <para> The response returns the following in JSON format:
        /// </para> <ol> <li>One or more <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CaseDetails.html" >CaseDetails</a> data
        /// types. </li>
        /// <li>One or more <i>NextToken</i> objects, strings that specifies where to paginate the returned records represented by <i>CaseDetails</i>
        /// .</li>
        /// </ol>
        /// </summary>
        /// 
        /// <param name="describeCasesRequest">Container for the necessary parameters to execute the DescribeCases service method on
        ///          AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the DescribeCases service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="CaseIdNotFoundException"/>
        public DescribeCasesResponse DescribeCases(DescribeCasesRequest describeCasesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeCases(describeCasesRequest, null, null, true);
            return EndDescribeCases(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCases operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.DescribeCases"/>
        /// </summary>
        /// 
        /// <param name="describeCasesRequest">Container for the necessary parameters to execute the DescribeCases operation on
        ///          AmazonAWSSupport.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCases
        ///         operation.</returns>
        public IAsyncResult BeginDescribeCases(DescribeCasesRequest describeCasesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeCases(describeCasesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeCases operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.DescribeCases"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCases.</param>
        /// 
        /// <returns>Returns a DescribeCasesResult from AmazonAWSSupport.</returns>
        public DescribeCasesResponse EndDescribeCases(IAsyncResult asyncResult)
        {
            return endOperation<DescribeCasesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeCases(DescribeCasesRequest describeCasesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeCasesRequestMarshaller().Marshall(describeCasesRequest);
            var unmarshaller = DescribeCasesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>This action returns a list of cases that you specify by passing one or more CaseIds. In addition, you can filter the cases by date by
        /// setting values for the AfterTime and BeforeTime request parameters. </para> <para> The response returns the following in JSON format:
        /// </para> <ol> <li>One or more <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CaseDetails.html" >CaseDetails</a> data
        /// types. </li>
        /// <li>One or more <i>NextToken</i> objects, strings that specifies where to paginate the returned records represented by <i>CaseDetails</i>
        /// .</li>
        /// </ol>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCases service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="CaseIdNotFoundException"/>
        public DescribeCasesResponse DescribeCases()
        {
            return DescribeCases(new DescribeCasesRequest());
        }
        

        #endregion
    
        #region DescribeCommunications

        /// <summary>
        /// <para>This action returns communications regarding the support case. You can use the <i>AfterTime</i> and <i>BeforeTime</i> parameters to
        /// filter by date. The <i>CaseId</i> parameter enables you to identify a specific case by its <i>CaseId</i> number.</para> <para>The
        /// <i>MaxResults</i> and <i>NextToken</i> parameters enable you to control the pagination of the result set. Set <i>MaxResults</i> to the
        /// number of cases you want displayed on each page, and use <i>NextToken</i> to specify the resumption of pagination.</para>
        /// </summary>
        /// 
        /// <param name="describeCommunicationsRequest">Container for the necessary parameters to execute the DescribeCommunications service method on
        ///          AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the DescribeCommunications service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="CaseIdNotFoundException"/>
        public DescribeCommunicationsResponse DescribeCommunications(DescribeCommunicationsRequest describeCommunicationsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeCommunications(describeCommunicationsRequest, null, null, true);
            return EndDescribeCommunications(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCommunications operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.DescribeCommunications"/>
        /// </summary>
        /// 
        /// <param name="describeCommunicationsRequest">Container for the necessary parameters to execute the DescribeCommunications operation on
        ///          AmazonAWSSupport.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeCommunications operation.</returns>
        public IAsyncResult BeginDescribeCommunications(DescribeCommunicationsRequest describeCommunicationsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeCommunications(describeCommunicationsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeCommunications operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.DescribeCommunications"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCommunications.</param>
        /// 
        /// <returns>Returns a DescribeCommunicationsResult from AmazonAWSSupport.</returns>
        public DescribeCommunicationsResponse EndDescribeCommunications(IAsyncResult asyncResult)
        {
            return endOperation<DescribeCommunicationsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeCommunications(DescribeCommunicationsRequest describeCommunicationsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeCommunicationsRequestMarshaller().Marshall(describeCommunicationsRequest);
            var unmarshaller = DescribeCommunicationsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeServices

        /// <summary>
        /// <para>Returns the current list of AWS services and a list of service categories that applies to each one. You then use service names and
        /// categories in your <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CreateCase.html" >CreateCase</a> requests. Each
        /// AWS service has its own set of categories.</para> <para>The service codes and category codes correspond to the values that are displayed in
        /// the <b>Service</b> and <b>Category</b> drop-down lists on the AWS Support Center <a href="https://aws.amazon.com/support/createCase" >Open a
        /// new case</a> page. The values in those fields, however, do not necessarily match the service codes and categories returned by the
        /// <c>DescribeServices</c> request. Always use the service codes and categories obtained programmatically. This practice ensures that you
        /// always have the most recent set of service and category codes.</para>
        /// </summary>
        /// 
        /// <param name="describeServicesRequest">Container for the necessary parameters to execute the DescribeServices service method on
        ///          AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the DescribeServices service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        public DescribeServicesResponse DescribeServices(DescribeServicesRequest describeServicesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeServices(describeServicesRequest, null, null, true);
            return EndDescribeServices(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServices operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.DescribeServices"/>
        /// </summary>
        /// 
        /// <param name="describeServicesRequest">Container for the necessary parameters to execute the DescribeServices operation on
        ///          AmazonAWSSupport.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeServices
        ///         operation.</returns>
        public IAsyncResult BeginDescribeServices(DescribeServicesRequest describeServicesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeServices(describeServicesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeServices operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.DescribeServices"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeServices.</param>
        /// 
        /// <returns>Returns a DescribeServicesResult from AmazonAWSSupport.</returns>
        public DescribeServicesResponse EndDescribeServices(IAsyncResult asyncResult)
        {
            return endOperation<DescribeServicesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeServices(DescribeServicesRequest describeServicesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeServicesRequestMarshaller().Marshall(describeServicesRequest);
            var unmarshaller = DescribeServicesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns the current list of AWS services and a list of service categories that applies to each one. You then use service names and
        /// categories in your <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CreateCase.html" >CreateCase</a> requests. Each
        /// AWS service has its own set of categories.</para> <para>The service codes and category codes correspond to the values that are displayed in
        /// the <b>Service</b> and <b>Category</b> drop-down lists on the AWS Support Center <a href="https://aws.amazon.com/support/createCase" >Open a
        /// new case</a> page. The values in those fields, however, do not necessarily match the service codes and categories returned by the
        /// <c>DescribeServices</c> request. Always use the service codes and categories obtained programmatically. This practice ensures that you
        /// always have the most recent set of service and category codes.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeServices service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        public DescribeServicesResponse DescribeServices()
        {
            return DescribeServices(new DescribeServicesRequest());
        }
        

        #endregion
    
        #region DescribeSeverityLevels

        /// <summary>
        /// <para>This action returns the list of severity levels that you can assign to an AWS Support case. The severity level for a case is also a
        /// field in the <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CaseDetails.html" >CaseDetails</a> data type included in
        /// any <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CreateCase.html" >CreateCase</a> request. </para>
        /// </summary>
        /// 
        /// <param name="describeSeverityLevelsRequest">Container for the necessary parameters to execute the DescribeSeverityLevels service method on
        ///          AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the DescribeSeverityLevels service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        public DescribeSeverityLevelsResponse DescribeSeverityLevels(DescribeSeverityLevelsRequest describeSeverityLevelsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeSeverityLevels(describeSeverityLevelsRequest, null, null, true);
            return EndDescribeSeverityLevels(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSeverityLevels operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.DescribeSeverityLevels"/>
        /// </summary>
        /// 
        /// <param name="describeSeverityLevelsRequest">Container for the necessary parameters to execute the DescribeSeverityLevels operation on
        ///          AmazonAWSSupport.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeSeverityLevels operation.</returns>
        public IAsyncResult BeginDescribeSeverityLevels(DescribeSeverityLevelsRequest describeSeverityLevelsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeSeverityLevels(describeSeverityLevelsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeSeverityLevels operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.DescribeSeverityLevels"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSeverityLevels.</param>
        /// 
        /// <returns>Returns a DescribeSeverityLevelsResult from AmazonAWSSupport.</returns>
        public DescribeSeverityLevelsResponse EndDescribeSeverityLevels(IAsyncResult asyncResult)
        {
            return endOperation<DescribeSeverityLevelsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeSeverityLevels(DescribeSeverityLevelsRequest describeSeverityLevelsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeSeverityLevelsRequestMarshaller().Marshall(describeSeverityLevelsRequest);
            var unmarshaller = DescribeSeverityLevelsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>This action returns the list of severity levels that you can assign to an AWS Support case. The severity level for a case is also a
        /// field in the <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CaseDetails.html" >CaseDetails</a> data type included in
        /// any <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CreateCase.html" >CreateCase</a> request. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSeverityLevels service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        public DescribeSeverityLevelsResponse DescribeSeverityLevels()
        {
            return DescribeSeverityLevels(new DescribeSeverityLevelsRequest());
        }
        

        #endregion
    
        #region DescribeTrustedAdvisorCheckRefreshStatuses

        /// <summary>
        /// <para>Returns the status of all refresh requests Trusted Advisor checks called using <a
        /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_RefreshTrustedAdvisorCheck.html" >RefreshTrustedAdvisorCheck</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeTrustedAdvisorCheckRefreshStatusesRequest">Container for the necessary parameters to execute the
        ///          DescribeTrustedAdvisorCheckRefreshStatuses service method on AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the DescribeTrustedAdvisorCheckRefreshStatuses service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        public DescribeTrustedAdvisorCheckRefreshStatusesResponse DescribeTrustedAdvisorCheckRefreshStatuses(DescribeTrustedAdvisorCheckRefreshStatusesRequest describeTrustedAdvisorCheckRefreshStatusesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeTrustedAdvisorCheckRefreshStatuses(describeTrustedAdvisorCheckRefreshStatusesRequest, null, null, true);
            return EndDescribeTrustedAdvisorCheckRefreshStatuses(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrustedAdvisorCheckRefreshStatuses operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.DescribeTrustedAdvisorCheckRefreshStatuses"/>
        /// </summary>
        /// 
        /// <param name="describeTrustedAdvisorCheckRefreshStatusesRequest">Container for the necessary parameters to execute the
        ///          DescribeTrustedAdvisorCheckRefreshStatuses operation on AmazonAWSSupport.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeTrustedAdvisorCheckRefreshStatuses operation.</returns>
        public IAsyncResult BeginDescribeTrustedAdvisorCheckRefreshStatuses(DescribeTrustedAdvisorCheckRefreshStatusesRequest describeTrustedAdvisorCheckRefreshStatusesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeTrustedAdvisorCheckRefreshStatuses(describeTrustedAdvisorCheckRefreshStatusesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeTrustedAdvisorCheckRefreshStatuses operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.DescribeTrustedAdvisorCheckRefreshStatuses"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTrustedAdvisorCheckRefreshStatuses.</param>
        /// 
        /// <returns>Returns a DescribeTrustedAdvisorCheckRefreshStatusesResult from AmazonAWSSupport.</returns>
        public DescribeTrustedAdvisorCheckRefreshStatusesResponse EndDescribeTrustedAdvisorCheckRefreshStatuses(IAsyncResult asyncResult)
        {
            return endOperation<DescribeTrustedAdvisorCheckRefreshStatusesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeTrustedAdvisorCheckRefreshStatuses(DescribeTrustedAdvisorCheckRefreshStatusesRequest describeTrustedAdvisorCheckRefreshStatusesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeTrustedAdvisorCheckRefreshStatusesRequestMarshaller().Marshall(describeTrustedAdvisorCheckRefreshStatusesRequest);
            var unmarshaller = DescribeTrustedAdvisorCheckRefreshStatusesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeTrustedAdvisorCheckResult

        /// <summary>
        /// <para>This action responds with the results of a Trusted Advisor check. Once you have obtained the list of available Trusted Advisor checks
        /// by calling <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeTrustedAdvisorChecks.html"
        /// >DescribeTrustedAdvisorChecks</a> , you specify the <i>CheckId</i> for the check you want to retrieve from AWS Support.</para> <para>The
        /// response for this action contains a JSON-formatted <a
        /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeTrustedAdvisorCheckResultResult.html"
        /// >TrustedAdvisorCheckResult</a> object</para> <para>, which is a container for the following three objects:</para> <ol> <li> <a
        /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_TrustedAdvisorCategorySpecificSummary.html"
        /// >TrustedAdvisorCategorySpecificSummary</a> </li>
        /// <li> <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_TrustedAdvisorResourceDetail.html"
        /// >TrustedAdvisorResourceDetail</a> </li>
        /// <li> <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_TrustedAdvisorResourcesSummary.html"
        /// >TrustedAdvisorResourcesSummary</a> </li>
        /// </ol> <para>In addition, the response contains the following fields:</para> <ol> <li> <b>Status</b> . Overall status of the check.</li>
        /// <li> <b>Timestamp</b> . Time at which Trusted Advisor last ran the check. </li>
        /// <li> <b>CheckId</b> . Unique identifier for the specific check returned by the request.</li>
        /// </ol>
        /// </summary>
        /// 
        /// <param name="describeTrustedAdvisorCheckResultRequest">Container for the necessary parameters to execute the
        ///          DescribeTrustedAdvisorCheckResult service method on AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the DescribeTrustedAdvisorCheckResult service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        public DescribeTrustedAdvisorCheckResultResponse DescribeTrustedAdvisorCheckResult(DescribeTrustedAdvisorCheckResultRequest describeTrustedAdvisorCheckResultRequest)
        {
            IAsyncResult asyncResult = invokeDescribeTrustedAdvisorCheckResult(describeTrustedAdvisorCheckResultRequest, null, null, true);
            return EndDescribeTrustedAdvisorCheckResult(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrustedAdvisorCheckResult operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.DescribeTrustedAdvisorCheckResult"/>
        /// </summary>
        /// 
        /// <param name="describeTrustedAdvisorCheckResultRequest">Container for the necessary parameters to execute the
        ///          DescribeTrustedAdvisorCheckResult operation on AmazonAWSSupport.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeTrustedAdvisorCheckResult operation.</returns>
        public IAsyncResult BeginDescribeTrustedAdvisorCheckResult(DescribeTrustedAdvisorCheckResultRequest describeTrustedAdvisorCheckResultRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeTrustedAdvisorCheckResult(describeTrustedAdvisorCheckResultRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeTrustedAdvisorCheckResult operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.DescribeTrustedAdvisorCheckResult"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTrustedAdvisorCheckResult.</param>
        /// 
        /// <returns>Returns a DescribeTrustedAdvisorCheckResultResult from AmazonAWSSupport.</returns>
        public DescribeTrustedAdvisorCheckResultResponse EndDescribeTrustedAdvisorCheckResult(IAsyncResult asyncResult)
        {
            return endOperation<DescribeTrustedAdvisorCheckResultResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeTrustedAdvisorCheckResult(DescribeTrustedAdvisorCheckResultRequest describeTrustedAdvisorCheckResultRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeTrustedAdvisorCheckResultRequestMarshaller().Marshall(describeTrustedAdvisorCheckResultRequest);
            var unmarshaller = DescribeTrustedAdvisorCheckResultResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeTrustedAdvisorCheckSummaries

        /// <summary>
        /// <para>This action enables you to get the latest summaries for Trusted Advisor checks that you specify in your request. You submit the list
        /// of Trusted Advisor checks for which you want summaries. You obtain these <i>CheckIds</i> by submitting a <a
        /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeTrustedAdvisorChecks.html" >DescribeTrustedAdvisorChecks</a>
        /// request. </para> <para>The response body contains an array of <a
        /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_TrustedAdvisorCheckSummary.html" >TrustedAdvisorCheckSummary</a>
        /// objects. </para>
        /// </summary>
        /// 
        /// <param name="describeTrustedAdvisorCheckSummariesRequest">Container for the necessary parameters to execute the
        ///          DescribeTrustedAdvisorCheckSummaries service method on AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the DescribeTrustedAdvisorCheckSummaries service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        public DescribeTrustedAdvisorCheckSummariesResponse DescribeTrustedAdvisorCheckSummaries(DescribeTrustedAdvisorCheckSummariesRequest describeTrustedAdvisorCheckSummariesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeTrustedAdvisorCheckSummaries(describeTrustedAdvisorCheckSummariesRequest, null, null, true);
            return EndDescribeTrustedAdvisorCheckSummaries(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrustedAdvisorCheckSummaries operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.DescribeTrustedAdvisorCheckSummaries"/>
        /// </summary>
        /// 
        /// <param name="describeTrustedAdvisorCheckSummariesRequest">Container for the necessary parameters to execute the
        ///          DescribeTrustedAdvisorCheckSummaries operation on AmazonAWSSupport.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeTrustedAdvisorCheckSummaries operation.</returns>
        public IAsyncResult BeginDescribeTrustedAdvisorCheckSummaries(DescribeTrustedAdvisorCheckSummariesRequest describeTrustedAdvisorCheckSummariesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeTrustedAdvisorCheckSummaries(describeTrustedAdvisorCheckSummariesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeTrustedAdvisorCheckSummaries operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.DescribeTrustedAdvisorCheckSummaries"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTrustedAdvisorCheckSummaries.</param>
        /// 
        /// <returns>Returns a DescribeTrustedAdvisorCheckSummariesResult from AmazonAWSSupport.</returns>
        public DescribeTrustedAdvisorCheckSummariesResponse EndDescribeTrustedAdvisorCheckSummaries(IAsyncResult asyncResult)
        {
            return endOperation<DescribeTrustedAdvisorCheckSummariesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeTrustedAdvisorCheckSummaries(DescribeTrustedAdvisorCheckSummariesRequest describeTrustedAdvisorCheckSummariesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeTrustedAdvisorCheckSummariesRequestMarshaller().Marshall(describeTrustedAdvisorCheckSummariesRequest);
            var unmarshaller = DescribeTrustedAdvisorCheckSummariesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeTrustedAdvisorChecks

        /// <summary>
        /// <para>This action enables you to get a list of the available Trusted Advisor checks. You must specify a language code. English ("en") and
        /// Japanese ("jp") are currently supported. The response contains a list of <a
        /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_TrustedAdvisorCheckDescription.html" >TrustedAdvisorCheckDescription</a>
        /// objects. </para>
        /// </summary>
        /// 
        /// <param name="describeTrustedAdvisorChecksRequest">Container for the necessary parameters to execute the DescribeTrustedAdvisorChecks service
        ///          method on AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the DescribeTrustedAdvisorChecks service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        public DescribeTrustedAdvisorChecksResponse DescribeTrustedAdvisorChecks(DescribeTrustedAdvisorChecksRequest describeTrustedAdvisorChecksRequest)
        {
            IAsyncResult asyncResult = invokeDescribeTrustedAdvisorChecks(describeTrustedAdvisorChecksRequest, null, null, true);
            return EndDescribeTrustedAdvisorChecks(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrustedAdvisorChecks operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.DescribeTrustedAdvisorChecks"/>
        /// </summary>
        /// 
        /// <param name="describeTrustedAdvisorChecksRequest">Container for the necessary parameters to execute the DescribeTrustedAdvisorChecks
        ///          operation on AmazonAWSSupport.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeTrustedAdvisorChecks operation.</returns>
        public IAsyncResult BeginDescribeTrustedAdvisorChecks(DescribeTrustedAdvisorChecksRequest describeTrustedAdvisorChecksRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeTrustedAdvisorChecks(describeTrustedAdvisorChecksRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeTrustedAdvisorChecks operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.DescribeTrustedAdvisorChecks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTrustedAdvisorChecks.</param>
        /// 
        /// <returns>Returns a DescribeTrustedAdvisorChecksResult from AmazonAWSSupport.</returns>
        public DescribeTrustedAdvisorChecksResponse EndDescribeTrustedAdvisorChecks(IAsyncResult asyncResult)
        {
            return endOperation<DescribeTrustedAdvisorChecksResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeTrustedAdvisorChecks(DescribeTrustedAdvisorChecksRequest describeTrustedAdvisorChecksRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeTrustedAdvisorChecksRequestMarshaller().Marshall(describeTrustedAdvisorChecksRequest);
            var unmarshaller = DescribeTrustedAdvisorChecksResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RefreshTrustedAdvisorCheck

        /// <summary>
        /// <para>This action enables you to query the service to request a refresh for a specific Trusted Advisor check. Your request body contains a
        /// <i>CheckId</i> for which you are querying. The response body contains a <a
        /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_RefreshTrustedAdvisorCheckResult.html"
        /// >RefreshTrustedAdvisorCheckResult</a> object containing <i>Status</i> and <i>TimeUntilNextRefresh</i> fields.</para>
        /// </summary>
        /// 
        /// <param name="refreshTrustedAdvisorCheckRequest">Container for the necessary parameters to execute the RefreshTrustedAdvisorCheck service
        ///          method on AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the RefreshTrustedAdvisorCheck service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        public RefreshTrustedAdvisorCheckResponse RefreshTrustedAdvisorCheck(RefreshTrustedAdvisorCheckRequest refreshTrustedAdvisorCheckRequest)
        {
            IAsyncResult asyncResult = invokeRefreshTrustedAdvisorCheck(refreshTrustedAdvisorCheckRequest, null, null, true);
            return EndRefreshTrustedAdvisorCheck(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RefreshTrustedAdvisorCheck operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.RefreshTrustedAdvisorCheck"/>
        /// </summary>
        /// 
        /// <param name="refreshTrustedAdvisorCheckRequest">Container for the necessary parameters to execute the RefreshTrustedAdvisorCheck operation
        ///          on AmazonAWSSupport.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndRefreshTrustedAdvisorCheck operation.</returns>
        public IAsyncResult BeginRefreshTrustedAdvisorCheck(RefreshTrustedAdvisorCheckRequest refreshTrustedAdvisorCheckRequest, AsyncCallback callback, object state)
        {
            return invokeRefreshTrustedAdvisorCheck(refreshTrustedAdvisorCheckRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RefreshTrustedAdvisorCheck operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.RefreshTrustedAdvisorCheck"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRefreshTrustedAdvisorCheck.</param>
        /// 
        /// <returns>Returns a RefreshTrustedAdvisorCheckResult from AmazonAWSSupport.</returns>
        public RefreshTrustedAdvisorCheckResponse EndRefreshTrustedAdvisorCheck(IAsyncResult asyncResult)
        {
            return endOperation<RefreshTrustedAdvisorCheckResponse>(asyncResult);
        }
        
        IAsyncResult invokeRefreshTrustedAdvisorCheck(RefreshTrustedAdvisorCheckRequest refreshTrustedAdvisorCheckRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RefreshTrustedAdvisorCheckRequestMarshaller().Marshall(refreshTrustedAdvisorCheckRequest);
            var unmarshaller = RefreshTrustedAdvisorCheckResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ResolveCase

        /// <summary>
        /// <para>Takes a <i>CaseId</i> and returns the initial state of the case along with the state of the case after the call to <a
        /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_ResolveCase.html" >ResolveCase</a> completed.</para>
        /// </summary>
        /// 
        /// <param name="resolveCaseRequest">Container for the necessary parameters to execute the ResolveCase service method on
        ///          AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the ResolveCase service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="CaseIdNotFoundException"/>
        public ResolveCaseResponse ResolveCase(ResolveCaseRequest resolveCaseRequest)
        {
            IAsyncResult asyncResult = invokeResolveCase(resolveCaseRequest, null, null, true);
            return EndResolveCase(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ResolveCase operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.ResolveCase"/>
        /// </summary>
        /// 
        /// <param name="resolveCaseRequest">Container for the necessary parameters to execute the ResolveCase operation on AmazonAWSSupport.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResolveCase
        ///         operation.</returns>
        public IAsyncResult BeginResolveCase(ResolveCaseRequest resolveCaseRequest, AsyncCallback callback, object state)
        {
            return invokeResolveCase(resolveCaseRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ResolveCase operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.ResolveCase"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResolveCase.</param>
        /// 
        /// <returns>Returns a ResolveCaseResult from AmazonAWSSupport.</returns>
        public ResolveCaseResponse EndResolveCase(IAsyncResult asyncResult)
        {
            return endOperation<ResolveCaseResponse>(asyncResult);
        }
        
        IAsyncResult invokeResolveCase(ResolveCaseRequest resolveCaseRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ResolveCaseRequestMarshaller().Marshall(resolveCaseRequest);
            var unmarshaller = ResolveCaseResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Takes a <i>CaseId</i> and returns the initial state of the case along with the state of the case after the call to <a
        /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_ResolveCase.html" >ResolveCase</a> completed.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ResolveCase service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="CaseIdNotFoundException"/>
        public ResolveCaseResponse ResolveCase()
        {
            return ResolveCase(new ResolveCaseRequest());
        }
        

        #endregion
    
    }
}
    
