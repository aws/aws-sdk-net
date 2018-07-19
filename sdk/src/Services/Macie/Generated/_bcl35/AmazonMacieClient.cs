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
 * Do not modify this file. This file is generated from the macie-2017-12-19.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Macie.Model;
using Amazon.Macie.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Macie
{
    /// <summary>
    /// Implementation for accessing Macie
    ///
    /// Amazon Macie 
    /// <para>
    /// Amazon Macie is a security service that uses machine learning to automatically discover,
    /// classify, and protect sensitive data in AWS. Macie recognizes sensitive data such
    /// as personally identifiable information (PII) or intellectual property, and provides
    /// you with dashboards and alerts that give visibility into how this data is being accessed
    /// or moved. For more information, see the <a href="https://docs.aws.amazon.com/macie/latest/userguide/what-is-macie.html">Macie
    /// User Guide</a>. 
    /// </para>
    /// </summary>
    public partial class AmazonMacieClient : AmazonServiceClient, IAmazonMacie
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonMacieClient with the credentials loaded from the application's
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
        public AmazonMacieClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMacieConfig()) { }

        /// <summary>
        /// Constructs AmazonMacieClient with the credentials loaded from the application's
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
        public AmazonMacieClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMacieConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMacieClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMacieClient Configuration Object</param>
        public AmazonMacieClient(AmazonMacieConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonMacieClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMacieClient(AWSCredentials credentials)
            : this(credentials, new AmazonMacieConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMacieClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMacieClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMacieConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMacieClient with AWS Credentials and an
        /// AmazonMacieClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMacieClient Configuration Object</param>
        public AmazonMacieClient(AWSCredentials credentials, AmazonMacieConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMacieClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMacieClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMacieConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMacieClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMacieClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMacieConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMacieClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMacieClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMacieClient Configuration Object</param>
        public AmazonMacieClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMacieConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMacieClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMacieClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMacieConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMacieClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMacieClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMacieConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMacieClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMacieClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMacieClient Configuration Object</param>
        public AmazonMacieClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMacieConfig clientConfig)
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

        
        #region  AssociateMemberAccount

        /// <summary>
        /// Associates a specified AWS account with Amazon Macie as a member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberAccount service method.</param>
        /// 
        /// <returns>The response from the AssociateMemberAccount service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/AssociateMemberAccount">REST API Reference for AssociateMemberAccount Operation</seealso>
        public virtual AssociateMemberAccountResponse AssociateMemberAccount(AssociateMemberAccountRequest request)
        {
            var marshaller = AssociateMemberAccountRequestMarshaller.Instance;
            var unmarshaller = AssociateMemberAccountResponseUnmarshaller.Instance;

            return Invoke<AssociateMemberAccountRequest,AssociateMemberAccountResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateMemberAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberAccount operation on AmazonMacieClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateMemberAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/AssociateMemberAccount">REST API Reference for AssociateMemberAccount Operation</seealso>
        public virtual IAsyncResult BeginAssociateMemberAccount(AssociateMemberAccountRequest request, AsyncCallback callback, object state)
        {
            var marshaller = AssociateMemberAccountRequestMarshaller.Instance;
            var unmarshaller = AssociateMemberAccountResponseUnmarshaller.Instance;

            return BeginInvoke<AssociateMemberAccountRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateMemberAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateMemberAccount.</param>
        /// 
        /// <returns>Returns a  AssociateMemberAccountResult from Macie.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/AssociateMemberAccount">REST API Reference for AssociateMemberAccount Operation</seealso>
        public virtual AssociateMemberAccountResponse EndAssociateMemberAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateMemberAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateS3Resources

        /// <summary>
        /// Associates specified S3 resources with Amazon Macie for monitoring and data classification.
        /// If memberAccountId isn't specified, the action associates specified S3 resources with
        /// Macie for the current master account. If memberAccountId is specified, the action
        /// associates specified S3 resources with Macie for the specified member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateS3Resources service method.</param>
        /// 
        /// <returns>The response from the AssociateS3Resources service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/AssociateS3Resources">REST API Reference for AssociateS3Resources Operation</seealso>
        public virtual AssociateS3ResourcesResponse AssociateS3Resources(AssociateS3ResourcesRequest request)
        {
            var marshaller = AssociateS3ResourcesRequestMarshaller.Instance;
            var unmarshaller = AssociateS3ResourcesResponseUnmarshaller.Instance;

            return Invoke<AssociateS3ResourcesRequest,AssociateS3ResourcesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateS3Resources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateS3Resources operation on AmazonMacieClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateS3Resources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/AssociateS3Resources">REST API Reference for AssociateS3Resources Operation</seealso>
        public virtual IAsyncResult BeginAssociateS3Resources(AssociateS3ResourcesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = AssociateS3ResourcesRequestMarshaller.Instance;
            var unmarshaller = AssociateS3ResourcesResponseUnmarshaller.Instance;

            return BeginInvoke<AssociateS3ResourcesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateS3Resources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateS3Resources.</param>
        /// 
        /// <returns>Returns a  AssociateS3ResourcesResult from Macie.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/AssociateS3Resources">REST API Reference for AssociateS3Resources Operation</seealso>
        public virtual AssociateS3ResourcesResponse EndAssociateS3Resources(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateS3ResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateMemberAccount

        /// <summary>
        /// Removes the specified member account from Amazon Macie.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateMemberAccount service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/DisassociateMemberAccount">REST API Reference for DisassociateMemberAccount Operation</seealso>
        public virtual DisassociateMemberAccountResponse DisassociateMemberAccount(DisassociateMemberAccountRequest request)
        {
            var marshaller = DisassociateMemberAccountRequestMarshaller.Instance;
            var unmarshaller = DisassociateMemberAccountResponseUnmarshaller.Instance;

            return Invoke<DisassociateMemberAccountRequest,DisassociateMemberAccountResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateMemberAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberAccount operation on AmazonMacieClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateMemberAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/DisassociateMemberAccount">REST API Reference for DisassociateMemberAccount Operation</seealso>
        public virtual IAsyncResult BeginDisassociateMemberAccount(DisassociateMemberAccountRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DisassociateMemberAccountRequestMarshaller.Instance;
            var unmarshaller = DisassociateMemberAccountResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateMemberAccountRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateMemberAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateMemberAccount.</param>
        /// 
        /// <returns>Returns a  DisassociateMemberAccountResult from Macie.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/DisassociateMemberAccount">REST API Reference for DisassociateMemberAccount Operation</seealso>
        public virtual DisassociateMemberAccountResponse EndDisassociateMemberAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateMemberAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateS3Resources

        /// <summary>
        /// Removes specified S3 resources from being monitored by Amazon Macie. If memberAccountId
        /// isn't specified, the action removes specified S3 resources from Macie for the current
        /// master account. If memberAccountId is specified, the action removes specified S3 resources
        /// from Macie for the specified member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateS3Resources service method.</param>
        /// 
        /// <returns>The response from the DisassociateS3Resources service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/DisassociateS3Resources">REST API Reference for DisassociateS3Resources Operation</seealso>
        public virtual DisassociateS3ResourcesResponse DisassociateS3Resources(DisassociateS3ResourcesRequest request)
        {
            var marshaller = DisassociateS3ResourcesRequestMarshaller.Instance;
            var unmarshaller = DisassociateS3ResourcesResponseUnmarshaller.Instance;

            return Invoke<DisassociateS3ResourcesRequest,DisassociateS3ResourcesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateS3Resources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateS3Resources operation on AmazonMacieClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateS3Resources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/DisassociateS3Resources">REST API Reference for DisassociateS3Resources Operation</seealso>
        public virtual IAsyncResult BeginDisassociateS3Resources(DisassociateS3ResourcesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DisassociateS3ResourcesRequestMarshaller.Instance;
            var unmarshaller = DisassociateS3ResourcesResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateS3ResourcesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateS3Resources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateS3Resources.</param>
        /// 
        /// <returns>Returns a  DisassociateS3ResourcesResult from Macie.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/DisassociateS3Resources">REST API Reference for DisassociateS3Resources Operation</seealso>
        public virtual DisassociateS3ResourcesResponse EndDisassociateS3Resources(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateS3ResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMemberAccounts

        /// <summary>
        /// Lists all Amazon Macie member accounts for the current Amazon Macie master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemberAccounts service method.</param>
        /// 
        /// <returns>The response from the ListMemberAccounts service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/ListMemberAccounts">REST API Reference for ListMemberAccounts Operation</seealso>
        public virtual ListMemberAccountsResponse ListMemberAccounts(ListMemberAccountsRequest request)
        {
            var marshaller = ListMemberAccountsRequestMarshaller.Instance;
            var unmarshaller = ListMemberAccountsResponseUnmarshaller.Instance;

            return Invoke<ListMemberAccountsRequest,ListMemberAccountsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMemberAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMemberAccounts operation on AmazonMacieClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMemberAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/ListMemberAccounts">REST API Reference for ListMemberAccounts Operation</seealso>
        public virtual IAsyncResult BeginListMemberAccounts(ListMemberAccountsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListMemberAccountsRequestMarshaller.Instance;
            var unmarshaller = ListMemberAccountsResponseUnmarshaller.Instance;

            return BeginInvoke<ListMemberAccountsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMemberAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMemberAccounts.</param>
        /// 
        /// <returns>Returns a  ListMemberAccountsResult from Macie.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/ListMemberAccounts">REST API Reference for ListMemberAccounts Operation</seealso>
        public virtual ListMemberAccountsResponse EndListMemberAccounts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMemberAccountsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListS3Resources

        /// <summary>
        /// Lists all the S3 resources associated with Amazon Macie. If memberAccountId isn't
        /// specified, the action lists the S3 resources associated with Amazon Macie for the
        /// current master account. If memberAccountId is specified, the action lists the S3 resources
        /// associated with Amazon Macie for the specified member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListS3Resources service method.</param>
        /// 
        /// <returns>The response from the ListS3Resources service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/ListS3Resources">REST API Reference for ListS3Resources Operation</seealso>
        public virtual ListS3ResourcesResponse ListS3Resources(ListS3ResourcesRequest request)
        {
            var marshaller = ListS3ResourcesRequestMarshaller.Instance;
            var unmarshaller = ListS3ResourcesResponseUnmarshaller.Instance;

            return Invoke<ListS3ResourcesRequest,ListS3ResourcesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListS3Resources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListS3Resources operation on AmazonMacieClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListS3Resources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/ListS3Resources">REST API Reference for ListS3Resources Operation</seealso>
        public virtual IAsyncResult BeginListS3Resources(ListS3ResourcesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListS3ResourcesRequestMarshaller.Instance;
            var unmarshaller = ListS3ResourcesResponseUnmarshaller.Instance;

            return BeginInvoke<ListS3ResourcesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListS3Resources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListS3Resources.</param>
        /// 
        /// <returns>Returns a  ListS3ResourcesResult from Macie.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/ListS3Resources">REST API Reference for ListS3Resources Operation</seealso>
        public virtual ListS3ResourcesResponse EndListS3Resources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListS3ResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateS3Resources

        /// <summary>
        /// Updates the classification types for the specified S3 resources. If memberAccountId
        /// isn't specified, the action updates the classification types of the S3 resources associated
        /// with Amazon Macie for the current master account. If memberAccountId is specified,
        /// the action updates the classification types of the S3 resources associated with Amazon
        /// Macie for the specified member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateS3Resources service method.</param>
        /// 
        /// <returns>The response from the UpdateS3Resources service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/UpdateS3Resources">REST API Reference for UpdateS3Resources Operation</seealso>
        public virtual UpdateS3ResourcesResponse UpdateS3Resources(UpdateS3ResourcesRequest request)
        {
            var marshaller = UpdateS3ResourcesRequestMarshaller.Instance;
            var unmarshaller = UpdateS3ResourcesResponseUnmarshaller.Instance;

            return Invoke<UpdateS3ResourcesRequest,UpdateS3ResourcesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateS3Resources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateS3Resources operation on AmazonMacieClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateS3Resources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/UpdateS3Resources">REST API Reference for UpdateS3Resources Operation</seealso>
        public virtual IAsyncResult BeginUpdateS3Resources(UpdateS3ResourcesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateS3ResourcesRequestMarshaller.Instance;
            var unmarshaller = UpdateS3ResourcesResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateS3ResourcesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateS3Resources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateS3Resources.</param>
        /// 
        /// <returns>Returns a  UpdateS3ResourcesResult from Macie.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/UpdateS3Resources">REST API Reference for UpdateS3Resources Operation</seealso>
        public virtual UpdateS3ResourcesResponse EndUpdateS3Resources(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateS3ResourcesResponse>(asyncResult);
        }

        #endregion
        
    }
}