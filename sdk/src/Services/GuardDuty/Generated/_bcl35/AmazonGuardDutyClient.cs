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

        /// <summary>
        /// Accepts the invitation to be monitored by a master GuardDuty account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation service method.</param>
        /// 
        /// <returns>The response from the AcceptInvitation service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        public virtual AcceptInvitationResponse AcceptInvitation(AcceptInvitationRequest request)
        {
            var marshaller = AcceptInvitationRequestMarshaller.Instance;
            var unmarshaller = AcceptInvitationResponseUnmarshaller.Instance;

            return Invoke<AcceptInvitationRequest,AcceptInvitationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        public virtual IAsyncResult BeginAcceptInvitation(AcceptInvitationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = AcceptInvitationRequestMarshaller.Instance;
            var unmarshaller = AcceptInvitationResponseUnmarshaller.Instance;

            return BeginInvoke<AcceptInvitationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptInvitation.</param>
        /// 
        /// <returns>Returns a  AcceptInvitationResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        public virtual AcceptInvitationResponse EndAcceptInvitation(IAsyncResult asyncResult)
        {
            return EndInvoke<AcceptInvitationResponse>(asyncResult);
        }

        #endregion
        
        #region  ArchiveFindings

        /// <summary>
        /// Archives Amazon GuardDuty findings specified by the list of finding IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ArchiveFindings service method.</param>
        /// 
        /// <returns>The response from the ArchiveFindings service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ArchiveFindings">REST API Reference for ArchiveFindings Operation</seealso>
        public virtual ArchiveFindingsResponse ArchiveFindings(ArchiveFindingsRequest request)
        {
            var marshaller = ArchiveFindingsRequestMarshaller.Instance;
            var unmarshaller = ArchiveFindingsResponseUnmarshaller.Instance;

            return Invoke<ArchiveFindingsRequest,ArchiveFindingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ArchiveFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ArchiveFindings operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndArchiveFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ArchiveFindings">REST API Reference for ArchiveFindings Operation</seealso>
        public virtual IAsyncResult BeginArchiveFindings(ArchiveFindingsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ArchiveFindingsRequestMarshaller.Instance;
            var unmarshaller = ArchiveFindingsResponseUnmarshaller.Instance;

            return BeginInvoke<ArchiveFindingsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ArchiveFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginArchiveFindings.</param>
        /// 
        /// <returns>Returns a  ArchiveFindingsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ArchiveFindings">REST API Reference for ArchiveFindings Operation</seealso>
        public virtual ArchiveFindingsResponse EndArchiveFindings(IAsyncResult asyncResult)
        {
            return EndInvoke<ArchiveFindingsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDetector

        /// <summary>
        /// Creates a single Amazon GuardDuty detector. A detector is an object that represents
        /// the GuardDuty service. A detector must be created in order for GuardDuty to become
        /// operational.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDetector service method.</param>
        /// 
        /// <returns>The response from the CreateDetector service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateDetector">REST API Reference for CreateDetector Operation</seealso>
        public virtual CreateDetectorResponse CreateDetector(CreateDetectorRequest request)
        {
            var marshaller = CreateDetectorRequestMarshaller.Instance;
            var unmarshaller = CreateDetectorResponseUnmarshaller.Instance;

            return Invoke<CreateDetectorRequest,CreateDetectorResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDetector operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateDetector">REST API Reference for CreateDetector Operation</seealso>
        public virtual IAsyncResult BeginCreateDetector(CreateDetectorRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateDetectorRequestMarshaller.Instance;
            var unmarshaller = CreateDetectorResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDetectorRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDetector.</param>
        /// 
        /// <returns>Returns a  CreateDetectorResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateDetector">REST API Reference for CreateDetector Operation</seealso>
        public virtual CreateDetectorResponse EndCreateDetector(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDetectorResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFilter

        /// <summary>
        /// Creates a filter using the specified finding criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFilter service method.</param>
        /// 
        /// <returns>The response from the CreateFilter service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateFilter">REST API Reference for CreateFilter Operation</seealso>
        public virtual CreateFilterResponse CreateFilter(CreateFilterRequest request)
        {
            var marshaller = CreateFilterRequestMarshaller.Instance;
            var unmarshaller = CreateFilterResponseUnmarshaller.Instance;

            return Invoke<CreateFilterRequest,CreateFilterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFilter operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateFilter">REST API Reference for CreateFilter Operation</seealso>
        public virtual IAsyncResult BeginCreateFilter(CreateFilterRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateFilterRequestMarshaller.Instance;
            var unmarshaller = CreateFilterResponseUnmarshaller.Instance;

            return BeginInvoke<CreateFilterRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFilter.</param>
        /// 
        /// <returns>Returns a  CreateFilterResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateFilter">REST API Reference for CreateFilter Operation</seealso>
        public virtual CreateFilterResponse EndCreateFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFilterResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateIPSet

        /// <summary>
        /// Creates a new IPSet - a list of trusted IP addresses that have been whitelisted for
        /// secure communication with AWS infrastructure and applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIPSet service method.</param>
        /// 
        /// <returns>The response from the CreateIPSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        public virtual CreateIPSetResponse CreateIPSet(CreateIPSetRequest request)
        {
            var marshaller = CreateIPSetRequestMarshaller.Instance;
            var unmarshaller = CreateIPSetResponseUnmarshaller.Instance;

            return Invoke<CreateIPSetRequest,CreateIPSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIPSet operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIPSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        public virtual IAsyncResult BeginCreateIPSet(CreateIPSetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateIPSetRequestMarshaller.Instance;
            var unmarshaller = CreateIPSetResponseUnmarshaller.Instance;

            return BeginInvoke<CreateIPSetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIPSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIPSet.</param>
        /// 
        /// <returns>Returns a  CreateIPSetResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        public virtual CreateIPSetResponse EndCreateIPSet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateIPSetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMembers

        /// <summary>
        /// Creates member accounts of the current AWS account by specifying a list of AWS account
        /// IDs. The current AWS account can then invite these members to manage GuardDuty in
        /// their accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembers service method.</param>
        /// 
        /// <returns>The response from the CreateMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateMembers">REST API Reference for CreateMembers Operation</seealso>
        public virtual CreateMembersResponse CreateMembers(CreateMembersRequest request)
        {
            var marshaller = CreateMembersRequestMarshaller.Instance;
            var unmarshaller = CreateMembersResponseUnmarshaller.Instance;

            return Invoke<CreateMembersRequest,CreateMembersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMembers operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateMembers">REST API Reference for CreateMembers Operation</seealso>
        public virtual IAsyncResult BeginCreateMembers(CreateMembersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateMembersRequestMarshaller.Instance;
            var unmarshaller = CreateMembersResponseUnmarshaller.Instance;

            return BeginInvoke<CreateMembersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMembers.</param>
        /// 
        /// <returns>Returns a  CreateMembersResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateMembers">REST API Reference for CreateMembers Operation</seealso>
        public virtual CreateMembersResponse EndCreateMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMembersResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSampleFindings

        /// <summary>
        /// Generates example findings of types specified by the list of finding types. If 'NULL'
        /// is specified for findingTypes, the API generates example findings of all supported
        /// finding types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSampleFindings service method.</param>
        /// 
        /// <returns>The response from the CreateSampleFindings service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateSampleFindings">REST API Reference for CreateSampleFindings Operation</seealso>
        public virtual CreateSampleFindingsResponse CreateSampleFindings(CreateSampleFindingsRequest request)
        {
            var marshaller = CreateSampleFindingsRequestMarshaller.Instance;
            var unmarshaller = CreateSampleFindingsResponseUnmarshaller.Instance;

            return Invoke<CreateSampleFindingsRequest,CreateSampleFindingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSampleFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSampleFindings operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSampleFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateSampleFindings">REST API Reference for CreateSampleFindings Operation</seealso>
        public virtual IAsyncResult BeginCreateSampleFindings(CreateSampleFindingsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateSampleFindingsRequestMarshaller.Instance;
            var unmarshaller = CreateSampleFindingsResponseUnmarshaller.Instance;

            return BeginInvoke<CreateSampleFindingsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSampleFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSampleFindings.</param>
        /// 
        /// <returns>Returns a  CreateSampleFindingsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateSampleFindings">REST API Reference for CreateSampleFindings Operation</seealso>
        public virtual CreateSampleFindingsResponse EndCreateSampleFindings(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSampleFindingsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateThreatIntelSet

        /// <summary>
        /// Create a new ThreatIntelSet. ThreatIntelSets consist of known malicious IP addresses.
        /// GuardDuty generates findings based on ThreatIntelSets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateThreatIntelSet service method.</param>
        /// 
        /// <returns>The response from the CreateThreatIntelSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateThreatIntelSet">REST API Reference for CreateThreatIntelSet Operation</seealso>
        public virtual CreateThreatIntelSetResponse CreateThreatIntelSet(CreateThreatIntelSetRequest request)
        {
            var marshaller = CreateThreatIntelSetRequestMarshaller.Instance;
            var unmarshaller = CreateThreatIntelSetResponseUnmarshaller.Instance;

            return Invoke<CreateThreatIntelSetRequest,CreateThreatIntelSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateThreatIntelSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateThreatIntelSet operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateThreatIntelSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateThreatIntelSet">REST API Reference for CreateThreatIntelSet Operation</seealso>
        public virtual IAsyncResult BeginCreateThreatIntelSet(CreateThreatIntelSetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateThreatIntelSetRequestMarshaller.Instance;
            var unmarshaller = CreateThreatIntelSetResponseUnmarshaller.Instance;

            return BeginInvoke<CreateThreatIntelSetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateThreatIntelSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateThreatIntelSet.</param>
        /// 
        /// <returns>Returns a  CreateThreatIntelSetResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateThreatIntelSet">REST API Reference for CreateThreatIntelSet Operation</seealso>
        public virtual CreateThreatIntelSetResponse EndCreateThreatIntelSet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateThreatIntelSetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeclineInvitations

        /// <summary>
        /// Declines invitations sent to the current member account by AWS account specified by
        /// their account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeclineInvitations service method.</param>
        /// 
        /// <returns>The response from the DeclineInvitations service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeclineInvitations">REST API Reference for DeclineInvitations Operation</seealso>
        public virtual DeclineInvitationsResponse DeclineInvitations(DeclineInvitationsRequest request)
        {
            var marshaller = DeclineInvitationsRequestMarshaller.Instance;
            var unmarshaller = DeclineInvitationsResponseUnmarshaller.Instance;

            return Invoke<DeclineInvitationsRequest,DeclineInvitationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeclineInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeclineInvitations operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeclineInvitations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeclineInvitations">REST API Reference for DeclineInvitations Operation</seealso>
        public virtual IAsyncResult BeginDeclineInvitations(DeclineInvitationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeclineInvitationsRequestMarshaller.Instance;
            var unmarshaller = DeclineInvitationsResponseUnmarshaller.Instance;

            return BeginInvoke<DeclineInvitationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeclineInvitations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeclineInvitations.</param>
        /// 
        /// <returns>Returns a  DeclineInvitationsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeclineInvitations">REST API Reference for DeclineInvitations Operation</seealso>
        public virtual DeclineInvitationsResponse EndDeclineInvitations(IAsyncResult asyncResult)
        {
            return EndInvoke<DeclineInvitationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDetector

        /// <summary>
        /// Deletes a Amazon GuardDuty detector specified by the detector ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetector service method.</param>
        /// 
        /// <returns>The response from the DeleteDetector service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteDetector">REST API Reference for DeleteDetector Operation</seealso>
        public virtual DeleteDetectorResponse DeleteDetector(DeleteDetectorRequest request)
        {
            var marshaller = DeleteDetectorRequestMarshaller.Instance;
            var unmarshaller = DeleteDetectorResponseUnmarshaller.Instance;

            return Invoke<DeleteDetectorRequest,DeleteDetectorResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetector operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteDetector">REST API Reference for DeleteDetector Operation</seealso>
        public virtual IAsyncResult BeginDeleteDetector(DeleteDetectorRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteDetectorRequestMarshaller.Instance;
            var unmarshaller = DeleteDetectorResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDetectorRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDetector.</param>
        /// 
        /// <returns>Returns a  DeleteDetectorResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteDetector">REST API Reference for DeleteDetector Operation</seealso>
        public virtual DeleteDetectorResponse EndDeleteDetector(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDetectorResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFilter

        /// <summary>
        /// Deletes the filter specified by the filter name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFilter service method.</param>
        /// 
        /// <returns>The response from the DeleteFilter service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteFilter">REST API Reference for DeleteFilter Operation</seealso>
        public virtual DeleteFilterResponse DeleteFilter(DeleteFilterRequest request)
        {
            var marshaller = DeleteFilterRequestMarshaller.Instance;
            var unmarshaller = DeleteFilterResponseUnmarshaller.Instance;

            return Invoke<DeleteFilterRequest,DeleteFilterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFilter operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteFilter">REST API Reference for DeleteFilter Operation</seealso>
        public virtual IAsyncResult BeginDeleteFilter(DeleteFilterRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteFilterRequestMarshaller.Instance;
            var unmarshaller = DeleteFilterResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteFilterRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFilter.</param>
        /// 
        /// <returns>Returns a  DeleteFilterResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteFilter">REST API Reference for DeleteFilter Operation</seealso>
        public virtual DeleteFilterResponse EndDeleteFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFilterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInvitations

        /// <summary>
        /// Deletes invitations sent to the current member account by AWS accounts specified by
        /// their account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvitations service method.</param>
        /// 
        /// <returns>The response from the DeleteInvitations service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteInvitations">REST API Reference for DeleteInvitations Operation</seealso>
        public virtual DeleteInvitationsResponse DeleteInvitations(DeleteInvitationsRequest request)
        {
            var marshaller = DeleteInvitationsRequestMarshaller.Instance;
            var unmarshaller = DeleteInvitationsResponseUnmarshaller.Instance;

            return Invoke<DeleteInvitationsRequest,DeleteInvitationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvitations operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInvitations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteInvitations">REST API Reference for DeleteInvitations Operation</seealso>
        public virtual IAsyncResult BeginDeleteInvitations(DeleteInvitationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteInvitationsRequestMarshaller.Instance;
            var unmarshaller = DeleteInvitationsResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteInvitationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInvitations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInvitations.</param>
        /// 
        /// <returns>Returns a  DeleteInvitationsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteInvitations">REST API Reference for DeleteInvitations Operation</seealso>
        public virtual DeleteInvitationsResponse EndDeleteInvitations(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInvitationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIPSet

        /// <summary>
        /// Deletes the IPSet specified by the IPSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIPSet service method.</param>
        /// 
        /// <returns>The response from the DeleteIPSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        public virtual DeleteIPSetResponse DeleteIPSet(DeleteIPSetRequest request)
        {
            var marshaller = DeleteIPSetRequestMarshaller.Instance;
            var unmarshaller = DeleteIPSetResponseUnmarshaller.Instance;

            return Invoke<DeleteIPSetRequest,DeleteIPSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIPSet operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIPSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        public virtual IAsyncResult BeginDeleteIPSet(DeleteIPSetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteIPSetRequestMarshaller.Instance;
            var unmarshaller = DeleteIPSetResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteIPSetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIPSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIPSet.</param>
        /// 
        /// <returns>Returns a  DeleteIPSetResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        public virtual DeleteIPSetResponse EndDeleteIPSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIPSetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMembers

        /// <summary>
        /// Deletes GuardDuty member accounts (to the current GuardDuty master account) specified
        /// by the account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembers service method.</param>
        /// 
        /// <returns>The response from the DeleteMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteMembers">REST API Reference for DeleteMembers Operation</seealso>
        public virtual DeleteMembersResponse DeleteMembers(DeleteMembersRequest request)
        {
            var marshaller = DeleteMembersRequestMarshaller.Instance;
            var unmarshaller = DeleteMembersResponseUnmarshaller.Instance;

            return Invoke<DeleteMembersRequest,DeleteMembersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembers operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteMembers">REST API Reference for DeleteMembers Operation</seealso>
        public virtual IAsyncResult BeginDeleteMembers(DeleteMembersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteMembersRequestMarshaller.Instance;
            var unmarshaller = DeleteMembersResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteMembersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMembers.</param>
        /// 
        /// <returns>Returns a  DeleteMembersResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteMembers">REST API Reference for DeleteMembers Operation</seealso>
        public virtual DeleteMembersResponse EndDeleteMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMembersResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteThreatIntelSet

        /// <summary>
        /// Deletes ThreatIntelSet specified by the ThreatIntelSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteThreatIntelSet service method.</param>
        /// 
        /// <returns>The response from the DeleteThreatIntelSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteThreatIntelSet">REST API Reference for DeleteThreatIntelSet Operation</seealso>
        public virtual DeleteThreatIntelSetResponse DeleteThreatIntelSet(DeleteThreatIntelSetRequest request)
        {
            var marshaller = DeleteThreatIntelSetRequestMarshaller.Instance;
            var unmarshaller = DeleteThreatIntelSetResponseUnmarshaller.Instance;

            return Invoke<DeleteThreatIntelSetRequest,DeleteThreatIntelSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteThreatIntelSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteThreatIntelSet operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteThreatIntelSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteThreatIntelSet">REST API Reference for DeleteThreatIntelSet Operation</seealso>
        public virtual IAsyncResult BeginDeleteThreatIntelSet(DeleteThreatIntelSetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteThreatIntelSetRequestMarshaller.Instance;
            var unmarshaller = DeleteThreatIntelSetResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteThreatIntelSetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteThreatIntelSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteThreatIntelSet.</param>
        /// 
        /// <returns>Returns a  DeleteThreatIntelSetResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteThreatIntelSet">REST API Reference for DeleteThreatIntelSet Operation</seealso>
        public virtual DeleteThreatIntelSetResponse EndDeleteThreatIntelSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteThreatIntelSetResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateFromMasterAccount

        /// <summary>
        /// Disassociates the current GuardDuty member account from its master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromMasterAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateFromMasterAccount service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
        public virtual DisassociateFromMasterAccountResponse DisassociateFromMasterAccount(DisassociateFromMasterAccountRequest request)
        {
            var marshaller = DisassociateFromMasterAccountRequestMarshaller.Instance;
            var unmarshaller = DisassociateFromMasterAccountResponseUnmarshaller.Instance;

            return Invoke<DisassociateFromMasterAccountRequest,DisassociateFromMasterAccountResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateFromMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromMasterAccount operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateFromMasterAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
        public virtual IAsyncResult BeginDisassociateFromMasterAccount(DisassociateFromMasterAccountRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DisassociateFromMasterAccountRequestMarshaller.Instance;
            var unmarshaller = DisassociateFromMasterAccountResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateFromMasterAccountRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateFromMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateFromMasterAccount.</param>
        /// 
        /// <returns>Returns a  DisassociateFromMasterAccountResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
        public virtual DisassociateFromMasterAccountResponse EndDisassociateFromMasterAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateFromMasterAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateMembers

        /// <summary>
        /// Disassociates GuardDuty member accounts (to the current GuardDuty master account)
        /// specified by the account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMembers service method.</param>
        /// 
        /// <returns>The response from the DisassociateMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisassociateMembers">REST API Reference for DisassociateMembers Operation</seealso>
        public virtual DisassociateMembersResponse DisassociateMembers(DisassociateMembersRequest request)
        {
            var marshaller = DisassociateMembersRequestMarshaller.Instance;
            var unmarshaller = DisassociateMembersResponseUnmarshaller.Instance;

            return Invoke<DisassociateMembersRequest,DisassociateMembersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMembers operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisassociateMembers">REST API Reference for DisassociateMembers Operation</seealso>
        public virtual IAsyncResult BeginDisassociateMembers(DisassociateMembersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DisassociateMembersRequestMarshaller.Instance;
            var unmarshaller = DisassociateMembersResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateMembersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateMembers.</param>
        /// 
        /// <returns>Returns a  DisassociateMembersResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisassociateMembers">REST API Reference for DisassociateMembers Operation</seealso>
        public virtual DisassociateMembersResponse EndDisassociateMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateMembersResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDetector

        /// <summary>
        /// Retrieves an Amazon GuardDuty detector specified by the detectorId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDetector service method.</param>
        /// 
        /// <returns>The response from the GetDetector service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetDetector">REST API Reference for GetDetector Operation</seealso>
        public virtual GetDetectorResponse GetDetector(GetDetectorRequest request)
        {
            var marshaller = GetDetectorRequestMarshaller.Instance;
            var unmarshaller = GetDetectorResponseUnmarshaller.Instance;

            return Invoke<GetDetectorRequest,GetDetectorResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDetector operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetDetector">REST API Reference for GetDetector Operation</seealso>
        public virtual IAsyncResult BeginGetDetector(GetDetectorRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetDetectorRequestMarshaller.Instance;
            var unmarshaller = GetDetectorResponseUnmarshaller.Instance;

            return BeginInvoke<GetDetectorRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDetector.</param>
        /// 
        /// <returns>Returns a  GetDetectorResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetDetector">REST API Reference for GetDetector Operation</seealso>
        public virtual GetDetectorResponse EndGetDetector(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDetectorResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFilter

        /// <summary>
        /// Returns the details of the filter specified by the filter name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFilter service method.</param>
        /// 
        /// <returns>The response from the GetFilter service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFilter">REST API Reference for GetFilter Operation</seealso>
        public virtual GetFilterResponse GetFilter(GetFilterRequest request)
        {
            var marshaller = GetFilterRequestMarshaller.Instance;
            var unmarshaller = GetFilterResponseUnmarshaller.Instance;

            return Invoke<GetFilterRequest,GetFilterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFilter operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFilter">REST API Reference for GetFilter Operation</seealso>
        public virtual IAsyncResult BeginGetFilter(GetFilterRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetFilterRequestMarshaller.Instance;
            var unmarshaller = GetFilterResponseUnmarshaller.Instance;

            return BeginInvoke<GetFilterRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFilter.</param>
        /// 
        /// <returns>Returns a  GetFilterResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFilter">REST API Reference for GetFilter Operation</seealso>
        public virtual GetFilterResponse EndGetFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFilterResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFindings

        /// <summary>
        /// Describes Amazon GuardDuty findings specified by finding IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindings service method.</param>
        /// 
        /// <returns>The response from the GetFindings service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFindings">REST API Reference for GetFindings Operation</seealso>
        public virtual GetFindingsResponse GetFindings(GetFindingsRequest request)
        {
            var marshaller = GetFindingsRequestMarshaller.Instance;
            var unmarshaller = GetFindingsResponseUnmarshaller.Instance;

            return Invoke<GetFindingsRequest,GetFindingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFindings operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFindings">REST API Reference for GetFindings Operation</seealso>
        public virtual IAsyncResult BeginGetFindings(GetFindingsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetFindingsRequestMarshaller.Instance;
            var unmarshaller = GetFindingsResponseUnmarshaller.Instance;

            return BeginInvoke<GetFindingsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFindings.</param>
        /// 
        /// <returns>Returns a  GetFindingsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFindings">REST API Reference for GetFindings Operation</seealso>
        public virtual GetFindingsResponse EndGetFindings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFindingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFindingsStatistics

        /// <summary>
        /// Lists Amazon GuardDuty findings' statistics for the specified detector ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsStatistics service method.</param>
        /// 
        /// <returns>The response from the GetFindingsStatistics service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFindingsStatistics">REST API Reference for GetFindingsStatistics Operation</seealso>
        public virtual GetFindingsStatisticsResponse GetFindingsStatistics(GetFindingsStatisticsRequest request)
        {
            var marshaller = GetFindingsStatisticsRequestMarshaller.Instance;
            var unmarshaller = GetFindingsStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetFindingsStatisticsRequest,GetFindingsStatisticsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFindingsStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsStatistics operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFindingsStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFindingsStatistics">REST API Reference for GetFindingsStatistics Operation</seealso>
        public virtual IAsyncResult BeginGetFindingsStatistics(GetFindingsStatisticsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetFindingsStatisticsRequestMarshaller.Instance;
            var unmarshaller = GetFindingsStatisticsResponseUnmarshaller.Instance;

            return BeginInvoke<GetFindingsStatisticsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFindingsStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFindingsStatistics.</param>
        /// 
        /// <returns>Returns a  GetFindingsStatisticsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFindingsStatistics">REST API Reference for GetFindingsStatistics Operation</seealso>
        public virtual GetFindingsStatisticsResponse EndGetFindingsStatistics(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFindingsStatisticsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInvitationsCount

        /// <summary>
        /// Returns the count of all GuardDuty membership invitations that were sent to the current
        /// member account except the currently accepted invitation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvitationsCount service method.</param>
        /// 
        /// <returns>The response from the GetInvitationsCount service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetInvitationsCount">REST API Reference for GetInvitationsCount Operation</seealso>
        public virtual GetInvitationsCountResponse GetInvitationsCount(GetInvitationsCountRequest request)
        {
            var marshaller = GetInvitationsCountRequestMarshaller.Instance;
            var unmarshaller = GetInvitationsCountResponseUnmarshaller.Instance;

            return Invoke<GetInvitationsCountRequest,GetInvitationsCountResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInvitationsCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInvitationsCount operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInvitationsCount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetInvitationsCount">REST API Reference for GetInvitationsCount Operation</seealso>
        public virtual IAsyncResult BeginGetInvitationsCount(GetInvitationsCountRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetInvitationsCountRequestMarshaller.Instance;
            var unmarshaller = GetInvitationsCountResponseUnmarshaller.Instance;

            return BeginInvoke<GetInvitationsCountRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInvitationsCount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInvitationsCount.</param>
        /// 
        /// <returns>Returns a  GetInvitationsCountResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetInvitationsCount">REST API Reference for GetInvitationsCount Operation</seealso>
        public virtual GetInvitationsCountResponse EndGetInvitationsCount(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInvitationsCountResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIPSet

        /// <summary>
        /// Retrieves the IPSet specified by the IPSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIPSet service method.</param>
        /// 
        /// <returns>The response from the GetIPSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        public virtual GetIPSetResponse GetIPSet(GetIPSetRequest request)
        {
            var marshaller = GetIPSetRequestMarshaller.Instance;
            var unmarshaller = GetIPSetResponseUnmarshaller.Instance;

            return Invoke<GetIPSetRequest,GetIPSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIPSet operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIPSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        public virtual IAsyncResult BeginGetIPSet(GetIPSetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetIPSetRequestMarshaller.Instance;
            var unmarshaller = GetIPSetResponseUnmarshaller.Instance;

            return BeginInvoke<GetIPSetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIPSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIPSet.</param>
        /// 
        /// <returns>Returns a  GetIPSetResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        public virtual GetIPSetResponse EndGetIPSet(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIPSetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMasterAccount

        /// <summary>
        /// Provides the details for the GuardDuty master account to the current GuardDuty member
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMasterAccount service method.</param>
        /// 
        /// <returns>The response from the GetMasterAccount service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
        public virtual GetMasterAccountResponse GetMasterAccount(GetMasterAccountRequest request)
        {
            var marshaller = GetMasterAccountRequestMarshaller.Instance;
            var unmarshaller = GetMasterAccountResponseUnmarshaller.Instance;

            return Invoke<GetMasterAccountRequest,GetMasterAccountResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMasterAccount operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMasterAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
        public virtual IAsyncResult BeginGetMasterAccount(GetMasterAccountRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetMasterAccountRequestMarshaller.Instance;
            var unmarshaller = GetMasterAccountResponseUnmarshaller.Instance;

            return BeginInvoke<GetMasterAccountRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMasterAccount.</param>
        /// 
        /// <returns>Returns a  GetMasterAccountResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
        public virtual GetMasterAccountResponse EndGetMasterAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMasterAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMembers

        /// <summary>
        /// Retrieves GuardDuty member accounts (to the current GuardDuty master account) specified
        /// by the account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMembers service method.</param>
        /// 
        /// <returns>The response from the GetMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMembers">REST API Reference for GetMembers Operation</seealso>
        public virtual GetMembersResponse GetMembers(GetMembersRequest request)
        {
            var marshaller = GetMembersRequestMarshaller.Instance;
            var unmarshaller = GetMembersResponseUnmarshaller.Instance;

            return Invoke<GetMembersRequest,GetMembersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMembers operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMembers">REST API Reference for GetMembers Operation</seealso>
        public virtual IAsyncResult BeginGetMembers(GetMembersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetMembersRequestMarshaller.Instance;
            var unmarshaller = GetMembersResponseUnmarshaller.Instance;

            return BeginInvoke<GetMembersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMembers.</param>
        /// 
        /// <returns>Returns a  GetMembersResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMembers">REST API Reference for GetMembers Operation</seealso>
        public virtual GetMembersResponse EndGetMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMembersResponse>(asyncResult);
        }

        #endregion
        
        #region  GetThreatIntelSet

        /// <summary>
        /// Retrieves the ThreatIntelSet that is specified by the ThreatIntelSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetThreatIntelSet service method.</param>
        /// 
        /// <returns>The response from the GetThreatIntelSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetThreatIntelSet">REST API Reference for GetThreatIntelSet Operation</seealso>
        public virtual GetThreatIntelSetResponse GetThreatIntelSet(GetThreatIntelSetRequest request)
        {
            var marshaller = GetThreatIntelSetRequestMarshaller.Instance;
            var unmarshaller = GetThreatIntelSetResponseUnmarshaller.Instance;

            return Invoke<GetThreatIntelSetRequest,GetThreatIntelSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetThreatIntelSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetThreatIntelSet operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetThreatIntelSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetThreatIntelSet">REST API Reference for GetThreatIntelSet Operation</seealso>
        public virtual IAsyncResult BeginGetThreatIntelSet(GetThreatIntelSetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetThreatIntelSetRequestMarshaller.Instance;
            var unmarshaller = GetThreatIntelSetResponseUnmarshaller.Instance;

            return BeginInvoke<GetThreatIntelSetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetThreatIntelSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetThreatIntelSet.</param>
        /// 
        /// <returns>Returns a  GetThreatIntelSetResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetThreatIntelSet">REST API Reference for GetThreatIntelSet Operation</seealso>
        public virtual GetThreatIntelSetResponse EndGetThreatIntelSet(IAsyncResult asyncResult)
        {
            return EndInvoke<GetThreatIntelSetResponse>(asyncResult);
        }

        #endregion
        
        #region  InviteMembers

        /// <summary>
        /// Invites other AWS accounts (created as members of the current AWS account by CreateMembers)
        /// to enable GuardDuty and allow the current AWS account to view and manage these accounts'
        /// GuardDuty findings on their behalf as the master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InviteMembers service method.</param>
        /// 
        /// <returns>The response from the InviteMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/InviteMembers">REST API Reference for InviteMembers Operation</seealso>
        public virtual InviteMembersResponse InviteMembers(InviteMembersRequest request)
        {
            var marshaller = InviteMembersRequestMarshaller.Instance;
            var unmarshaller = InviteMembersResponseUnmarshaller.Instance;

            return Invoke<InviteMembersRequest,InviteMembersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InviteMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InviteMembers operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInviteMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/InviteMembers">REST API Reference for InviteMembers Operation</seealso>
        public virtual IAsyncResult BeginInviteMembers(InviteMembersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = InviteMembersRequestMarshaller.Instance;
            var unmarshaller = InviteMembersResponseUnmarshaller.Instance;

            return BeginInvoke<InviteMembersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  InviteMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInviteMembers.</param>
        /// 
        /// <returns>Returns a  InviteMembersResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/InviteMembers">REST API Reference for InviteMembers Operation</seealso>
        public virtual InviteMembersResponse EndInviteMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<InviteMembersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDetectors

        /// <summary>
        /// Lists detectorIds of all the existing Amazon GuardDuty detector resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDetectors service method.</param>
        /// 
        /// <returns>The response from the ListDetectors service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListDetectors">REST API Reference for ListDetectors Operation</seealso>
        public virtual ListDetectorsResponse ListDetectors(ListDetectorsRequest request)
        {
            var marshaller = ListDetectorsRequestMarshaller.Instance;
            var unmarshaller = ListDetectorsResponseUnmarshaller.Instance;

            return Invoke<ListDetectorsRequest,ListDetectorsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDetectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDetectors operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDetectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListDetectors">REST API Reference for ListDetectors Operation</seealso>
        public virtual IAsyncResult BeginListDetectors(ListDetectorsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListDetectorsRequestMarshaller.Instance;
            var unmarshaller = ListDetectorsResponseUnmarshaller.Instance;

            return BeginInvoke<ListDetectorsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDetectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDetectors.</param>
        /// 
        /// <returns>Returns a  ListDetectorsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListDetectors">REST API Reference for ListDetectors Operation</seealso>
        public virtual ListDetectorsResponse EndListDetectors(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDetectorsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFilters

        /// <summary>
        /// Returns a paginated list of the current filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFilters service method.</param>
        /// 
        /// <returns>The response from the ListFilters service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListFilters">REST API Reference for ListFilters Operation</seealso>
        public virtual ListFiltersResponse ListFilters(ListFiltersRequest request)
        {
            var marshaller = ListFiltersRequestMarshaller.Instance;
            var unmarshaller = ListFiltersResponseUnmarshaller.Instance;

            return Invoke<ListFiltersRequest,ListFiltersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFilters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFilters operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFilters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListFilters">REST API Reference for ListFilters Operation</seealso>
        public virtual IAsyncResult BeginListFilters(ListFiltersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListFiltersRequestMarshaller.Instance;
            var unmarshaller = ListFiltersResponseUnmarshaller.Instance;

            return BeginInvoke<ListFiltersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFilters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFilters.</param>
        /// 
        /// <returns>Returns a  ListFiltersResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListFilters">REST API Reference for ListFilters Operation</seealso>
        public virtual ListFiltersResponse EndListFilters(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFiltersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFindings

        /// <summary>
        /// Lists Amazon GuardDuty findings for the specified detector ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// 
        /// <returns>The response from the ListFindings service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListFindings">REST API Reference for ListFindings Operation</seealso>
        public virtual ListFindingsResponse ListFindings(ListFindingsRequest request)
        {
            var marshaller = ListFindingsRequestMarshaller.Instance;
            var unmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return Invoke<ListFindingsRequest,ListFindingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFindings operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListFindings">REST API Reference for ListFindings Operation</seealso>
        public virtual IAsyncResult BeginListFindings(ListFindingsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListFindingsRequestMarshaller.Instance;
            var unmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return BeginInvoke<ListFindingsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFindings.</param>
        /// 
        /// <returns>Returns a  ListFindingsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListFindings">REST API Reference for ListFindings Operation</seealso>
        public virtual ListFindingsResponse EndListFindings(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFindingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInvitations

        /// <summary>
        /// Lists all GuardDuty membership invitations that were sent to the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations service method.</param>
        /// 
        /// <returns>The response from the ListInvitations service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        public virtual ListInvitationsResponse ListInvitations(ListInvitationsRequest request)
        {
            var marshaller = ListInvitationsRequestMarshaller.Instance;
            var unmarshaller = ListInvitationsResponseUnmarshaller.Instance;

            return Invoke<ListInvitationsRequest,ListInvitationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInvitations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        public virtual IAsyncResult BeginListInvitations(ListInvitationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListInvitationsRequestMarshaller.Instance;
            var unmarshaller = ListInvitationsResponseUnmarshaller.Instance;

            return BeginInvoke<ListInvitationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInvitations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInvitations.</param>
        /// 
        /// <returns>Returns a  ListInvitationsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        public virtual ListInvitationsResponse EndListInvitations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInvitationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIPSets

        /// <summary>
        /// Lists the IPSets of the GuardDuty service specified by the detector ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIPSets service method.</param>
        /// 
        /// <returns>The response from the ListIPSets service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListIPSets">REST API Reference for ListIPSets Operation</seealso>
        public virtual ListIPSetsResponse ListIPSets(ListIPSetsRequest request)
        {
            var marshaller = ListIPSetsRequestMarshaller.Instance;
            var unmarshaller = ListIPSetsResponseUnmarshaller.Instance;

            return Invoke<ListIPSetsRequest,ListIPSetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIPSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIPSets operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIPSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListIPSets">REST API Reference for ListIPSets Operation</seealso>
        public virtual IAsyncResult BeginListIPSets(ListIPSetsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListIPSetsRequestMarshaller.Instance;
            var unmarshaller = ListIPSetsResponseUnmarshaller.Instance;

            return BeginInvoke<ListIPSetsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIPSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIPSets.</param>
        /// 
        /// <returns>Returns a  ListIPSetsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListIPSets">REST API Reference for ListIPSets Operation</seealso>
        public virtual ListIPSetsResponse EndListIPSets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIPSetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMembers

        /// <summary>
        /// Lists details about all member accounts for the current GuardDuty master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListMembers">REST API Reference for ListMembers Operation</seealso>
        public virtual ListMembersResponse ListMembers(ListMembersRequest request)
        {
            var marshaller = ListMembersRequestMarshaller.Instance;
            var unmarshaller = ListMembersResponseUnmarshaller.Instance;

            return Invoke<ListMembersRequest,ListMembersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMembers operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListMembers">REST API Reference for ListMembers Operation</seealso>
        public virtual IAsyncResult BeginListMembers(ListMembersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListMembersRequestMarshaller.Instance;
            var unmarshaller = ListMembersResponseUnmarshaller.Instance;

            return BeginInvoke<ListMembersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMembers.</param>
        /// 
        /// <returns>Returns a  ListMembersResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListMembers">REST API Reference for ListMembers Operation</seealso>
        public virtual ListMembersResponse EndListMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMembersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListThreatIntelSets

        /// <summary>
        /// Lists the ThreatIntelSets of the GuardDuty service specified by the detector ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThreatIntelSets service method.</param>
        /// 
        /// <returns>The response from the ListThreatIntelSets service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListThreatIntelSets">REST API Reference for ListThreatIntelSets Operation</seealso>
        public virtual ListThreatIntelSetsResponse ListThreatIntelSets(ListThreatIntelSetsRequest request)
        {
            var marshaller = ListThreatIntelSetsRequestMarshaller.Instance;
            var unmarshaller = ListThreatIntelSetsResponseUnmarshaller.Instance;

            return Invoke<ListThreatIntelSetsRequest,ListThreatIntelSetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListThreatIntelSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThreatIntelSets operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListThreatIntelSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListThreatIntelSets">REST API Reference for ListThreatIntelSets Operation</seealso>
        public virtual IAsyncResult BeginListThreatIntelSets(ListThreatIntelSetsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListThreatIntelSetsRequestMarshaller.Instance;
            var unmarshaller = ListThreatIntelSetsResponseUnmarshaller.Instance;

            return BeginInvoke<ListThreatIntelSetsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListThreatIntelSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListThreatIntelSets.</param>
        /// 
        /// <returns>Returns a  ListThreatIntelSetsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListThreatIntelSets">REST API Reference for ListThreatIntelSets Operation</seealso>
        public virtual ListThreatIntelSetsResponse EndListThreatIntelSets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListThreatIntelSetsResponse>(asyncResult);
        }

        #endregion
        
        #region  StartMonitoringMembers

        /// <summary>
        /// Re-enables GuardDuty to monitor findings of the member accounts specified by the account
        /// IDs. A master GuardDuty account can run this command after disabling GuardDuty from
        /// monitoring these members' findings by running StopMonitoringMembers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMonitoringMembers service method.</param>
        /// 
        /// <returns>The response from the StartMonitoringMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/StartMonitoringMembers">REST API Reference for StartMonitoringMembers Operation</seealso>
        public virtual StartMonitoringMembersResponse StartMonitoringMembers(StartMonitoringMembersRequest request)
        {
            var marshaller = StartMonitoringMembersRequestMarshaller.Instance;
            var unmarshaller = StartMonitoringMembersResponseUnmarshaller.Instance;

            return Invoke<StartMonitoringMembersRequest,StartMonitoringMembersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartMonitoringMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMonitoringMembers operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMonitoringMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/StartMonitoringMembers">REST API Reference for StartMonitoringMembers Operation</seealso>
        public virtual IAsyncResult BeginStartMonitoringMembers(StartMonitoringMembersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = StartMonitoringMembersRequestMarshaller.Instance;
            var unmarshaller = StartMonitoringMembersResponseUnmarshaller.Instance;

            return BeginInvoke<StartMonitoringMembersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartMonitoringMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMonitoringMembers.</param>
        /// 
        /// <returns>Returns a  StartMonitoringMembersResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/StartMonitoringMembers">REST API Reference for StartMonitoringMembers Operation</seealso>
        public virtual StartMonitoringMembersResponse EndStartMonitoringMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<StartMonitoringMembersResponse>(asyncResult);
        }

        #endregion
        
        #region  StopMonitoringMembers

        /// <summary>
        /// Disables GuardDuty from monitoring findings of the member accounts specified by the
        /// account IDs. After running this command, a master GuardDuty account can run StartMonitoringMembers
        /// to re-enable GuardDuty to monitor these members’ findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopMonitoringMembers service method.</param>
        /// 
        /// <returns>The response from the StopMonitoringMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/StopMonitoringMembers">REST API Reference for StopMonitoringMembers Operation</seealso>
        public virtual StopMonitoringMembersResponse StopMonitoringMembers(StopMonitoringMembersRequest request)
        {
            var marshaller = StopMonitoringMembersRequestMarshaller.Instance;
            var unmarshaller = StopMonitoringMembersResponseUnmarshaller.Instance;

            return Invoke<StopMonitoringMembersRequest,StopMonitoringMembersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopMonitoringMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopMonitoringMembers operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopMonitoringMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/StopMonitoringMembers">REST API Reference for StopMonitoringMembers Operation</seealso>
        public virtual IAsyncResult BeginStopMonitoringMembers(StopMonitoringMembersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = StopMonitoringMembersRequestMarshaller.Instance;
            var unmarshaller = StopMonitoringMembersResponseUnmarshaller.Instance;

            return BeginInvoke<StopMonitoringMembersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopMonitoringMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopMonitoringMembers.</param>
        /// 
        /// <returns>Returns a  StopMonitoringMembersResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/StopMonitoringMembers">REST API Reference for StopMonitoringMembers Operation</seealso>
        public virtual StopMonitoringMembersResponse EndStopMonitoringMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<StopMonitoringMembersResponse>(asyncResult);
        }

        #endregion
        
        #region  UnarchiveFindings

        /// <summary>
        /// Unarchives Amazon GuardDuty findings specified by the list of finding IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnarchiveFindings service method.</param>
        /// 
        /// <returns>The response from the UnarchiveFindings service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UnarchiveFindings">REST API Reference for UnarchiveFindings Operation</seealso>
        public virtual UnarchiveFindingsResponse UnarchiveFindings(UnarchiveFindingsRequest request)
        {
            var marshaller = UnarchiveFindingsRequestMarshaller.Instance;
            var unmarshaller = UnarchiveFindingsResponseUnmarshaller.Instance;

            return Invoke<UnarchiveFindingsRequest,UnarchiveFindingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UnarchiveFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnarchiveFindings operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnarchiveFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UnarchiveFindings">REST API Reference for UnarchiveFindings Operation</seealso>
        public virtual IAsyncResult BeginUnarchiveFindings(UnarchiveFindingsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UnarchiveFindingsRequestMarshaller.Instance;
            var unmarshaller = UnarchiveFindingsResponseUnmarshaller.Instance;

            return BeginInvoke<UnarchiveFindingsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UnarchiveFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnarchiveFindings.</param>
        /// 
        /// <returns>Returns a  UnarchiveFindingsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UnarchiveFindings">REST API Reference for UnarchiveFindings Operation</seealso>
        public virtual UnarchiveFindingsResponse EndUnarchiveFindings(IAsyncResult asyncResult)
        {
            return EndInvoke<UnarchiveFindingsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDetector

        /// <summary>
        /// Updates an Amazon GuardDuty detector specified by the detectorId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetector service method.</param>
        /// 
        /// <returns>The response from the UpdateDetector service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateDetector">REST API Reference for UpdateDetector Operation</seealso>
        public virtual UpdateDetectorResponse UpdateDetector(UpdateDetectorRequest request)
        {
            var marshaller = UpdateDetectorRequestMarshaller.Instance;
            var unmarshaller = UpdateDetectorResponseUnmarshaller.Instance;

            return Invoke<UpdateDetectorRequest,UpdateDetectorResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetector operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateDetector">REST API Reference for UpdateDetector Operation</seealso>
        public virtual IAsyncResult BeginUpdateDetector(UpdateDetectorRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateDetectorRequestMarshaller.Instance;
            var unmarshaller = UpdateDetectorResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateDetectorRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDetector.</param>
        /// 
        /// <returns>Returns a  UpdateDetectorResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateDetector">REST API Reference for UpdateDetector Operation</seealso>
        public virtual UpdateDetectorResponse EndUpdateDetector(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDetectorResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFilter

        /// <summary>
        /// Updates the filter specified by the filter name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFilter service method.</param>
        /// 
        /// <returns>The response from the UpdateFilter service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateFilter">REST API Reference for UpdateFilter Operation</seealso>
        public virtual UpdateFilterResponse UpdateFilter(UpdateFilterRequest request)
        {
            var marshaller = UpdateFilterRequestMarshaller.Instance;
            var unmarshaller = UpdateFilterResponseUnmarshaller.Instance;

            return Invoke<UpdateFilterRequest,UpdateFilterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFilter operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateFilter">REST API Reference for UpdateFilter Operation</seealso>
        public virtual IAsyncResult BeginUpdateFilter(UpdateFilterRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateFilterRequestMarshaller.Instance;
            var unmarshaller = UpdateFilterResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateFilterRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFilter.</param>
        /// 
        /// <returns>Returns a  UpdateFilterResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateFilter">REST API Reference for UpdateFilter Operation</seealso>
        public virtual UpdateFilterResponse EndUpdateFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFilterResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFindingsFeedback

        /// <summary>
        /// Marks specified Amazon GuardDuty findings as useful or not useful.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindingsFeedback service method.</param>
        /// 
        /// <returns>The response from the UpdateFindingsFeedback service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateFindingsFeedback">REST API Reference for UpdateFindingsFeedback Operation</seealso>
        public virtual UpdateFindingsFeedbackResponse UpdateFindingsFeedback(UpdateFindingsFeedbackRequest request)
        {
            var marshaller = UpdateFindingsFeedbackRequestMarshaller.Instance;
            var unmarshaller = UpdateFindingsFeedbackResponseUnmarshaller.Instance;

            return Invoke<UpdateFindingsFeedbackRequest,UpdateFindingsFeedbackResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFindingsFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindingsFeedback operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFindingsFeedback
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateFindingsFeedback">REST API Reference for UpdateFindingsFeedback Operation</seealso>
        public virtual IAsyncResult BeginUpdateFindingsFeedback(UpdateFindingsFeedbackRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateFindingsFeedbackRequestMarshaller.Instance;
            var unmarshaller = UpdateFindingsFeedbackResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateFindingsFeedbackRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFindingsFeedback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFindingsFeedback.</param>
        /// 
        /// <returns>Returns a  UpdateFindingsFeedbackResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateFindingsFeedback">REST API Reference for UpdateFindingsFeedback Operation</seealso>
        public virtual UpdateFindingsFeedbackResponse EndUpdateFindingsFeedback(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFindingsFeedbackResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateIPSet

        /// <summary>
        /// Updates the IPSet specified by the IPSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIPSet service method.</param>
        /// 
        /// <returns>The response from the UpdateIPSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        public virtual UpdateIPSetResponse UpdateIPSet(UpdateIPSetRequest request)
        {
            var marshaller = UpdateIPSetRequestMarshaller.Instance;
            var unmarshaller = UpdateIPSetResponseUnmarshaller.Instance;

            return Invoke<UpdateIPSetRequest,UpdateIPSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIPSet operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIPSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        public virtual IAsyncResult BeginUpdateIPSet(UpdateIPSetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateIPSetRequestMarshaller.Instance;
            var unmarshaller = UpdateIPSetResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateIPSetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIPSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIPSet.</param>
        /// 
        /// <returns>Returns a  UpdateIPSetResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        public virtual UpdateIPSetResponse EndUpdateIPSet(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateIPSetResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateThreatIntelSet

        /// <summary>
        /// Updates the ThreatIntelSet specified by ThreatIntelSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThreatIntelSet service method.</param>
        /// 
        /// <returns>The response from the UpdateThreatIntelSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateThreatIntelSet">REST API Reference for UpdateThreatIntelSet Operation</seealso>
        public virtual UpdateThreatIntelSetResponse UpdateThreatIntelSet(UpdateThreatIntelSetRequest request)
        {
            var marshaller = UpdateThreatIntelSetRequestMarshaller.Instance;
            var unmarshaller = UpdateThreatIntelSetResponseUnmarshaller.Instance;

            return Invoke<UpdateThreatIntelSetRequest,UpdateThreatIntelSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateThreatIntelSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateThreatIntelSet operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateThreatIntelSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateThreatIntelSet">REST API Reference for UpdateThreatIntelSet Operation</seealso>
        public virtual IAsyncResult BeginUpdateThreatIntelSet(UpdateThreatIntelSetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateThreatIntelSetRequestMarshaller.Instance;
            var unmarshaller = UpdateThreatIntelSetResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateThreatIntelSetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateThreatIntelSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateThreatIntelSet.</param>
        /// 
        /// <returns>Returns a  UpdateThreatIntelSetResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateThreatIntelSet">REST API Reference for UpdateThreatIntelSet Operation</seealso>
        public virtual UpdateThreatIntelSetResponse EndUpdateThreatIntelSet(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateThreatIntelSetResponse>(asyncResult);
        }

        #endregion
        
    }
}